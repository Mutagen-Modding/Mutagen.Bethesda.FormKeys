using CommandLine;
using Loqui;
using Loqui.Generation;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Noggog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mutagen.Bethesda.FormKeys.Generator
{
    class Program
    {
        static int Main(string[] args)
        {
            return Parser.Default.ParseArguments(args, typeof(GenerateFromMod), typeof(GenerateFromConfig))
                .MapResult(
                    (GenerateFromMod gen) =>
                    {
                        Clean();
                        Generate(gen);
                        return 0;
                    },
                    (GenerateFromConfig gen) =>
                    {
                        Clean();
                        Generate(gen);
                        return 0;
                    },
                    _ =>
                    {
                        System.Console.WriteLine("Press enter to exit.");
                        System.Console.ReadLine();
                        return -1;
                    });
        }

        public static string CleanName(string name, string className)
        {
            if (string.IsNullOrWhiteSpace(name)) return name;
            if (!char.IsLetter(name[0]))
            {
                name = $"_{name}";
            }
            name = name.Replace('%', '_');
            name = name.Replace('&', '_');
            if (name.Equals(className))
            {
                name = $"_{name}";
            }
            return name;
        }

        public static void Clean()
        {
            var dir = new DirectoryPath("Output");
            dir.DeleteEntireFolder();
        }

        public static ILoquiRegistration GetMajorRecord(ILoquiRegistration regis)
        {
            if (regis.ClassType.BaseType!.Name.EndsWith("MajorRecord")) return regis;
            return GetMajorRecord(LoquiRegistration.GetRegister(regis.ClassType.BaseType!));
        }

        public static void Generate(GenerateFromConfig conf)
        {
            File.ReadAllLines(conf.ConfigPath)
                .AsParallel()
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Select(l =>
                {
                    var split = l.IndexOf(' ');
                    return new GenerateFromMod()
                    {
                        Path = l.Substring(split + 1).TrimStart('\"').TrimEnd('\"'),
                        Release = (GameRelease)Enum.Parse(typeof(GameRelease), l.Substring(0, split))
                    };
                })
                .ForAll((g) => Generate(g));
        }

        public static void Generate(GenerateFromMod gen)
        {
            var mod = ModInstantiator.Importer(gen.Path, gen.Release);
            var list = new List<(FormKey FormKey, string Edid, string TypeName)>();
            foreach (var rec in mod.EnumerateMajorRecords())
            {
                if (!rec.EditorID.TryGet(out var edid)) continue;
                var formKey = rec.FormKey;
                // Only register FormKeys originating from the mod itself
                if (formKey.ModKey != mod.ModKey) continue;
                list.Add((formKey, edid, GetMajorRecord(rec.Registration).Name));
            }

            var namespaceStr = $"Mutagen.Bethesda.FormKeys.{gen.Release}";
            var modName = mod.ModKey.Name.TrimStart("DLC");

            foreach (var recGroup in list.GroupBy(x => x.TypeName))
            {
                FileGeneration fg = new FileGeneration();
                using (new NamespaceWrapper(fg, namespaceStr))
                {
                    using (var c = new ClassWrapper(fg, modName))
                    {
                        c.Static = true;
                        c.Partial = true;
                    }
                    using (new BraceWrapper(fg))
                    {
                        using (var c = new ClassWrapper(fg, recGroup.Key))
                        {
                            c.Static = true;
                        }
                        using (new BraceWrapper(fg))
                        {
                            fg.AppendLine($"private readonly static ModKey ModKey = ModKey.{nameof(ModKey.FromNameAndExtension)}(\"{mod.ModKey}\");");
                            foreach (var rec in recGroup)
                            {
                                fg.AppendLine($"public static FormKey {CleanName(rec.Edid, recGroup.Key)} => ModKey.{nameof(ModKeyExt.MakeFormKey)}(0x{rec.FormKey.ID:x});");
                            }
                        }
                    }
                }

                var path = Path.Combine("Output", gen.Release.ToString(), modName, $"{recGroup.Key}.cs");
                fg.Generate(path);
                System.Console.WriteLine($"Exported: {path}");
            }
        }
    }
}
