using CommandLine;
using Loqui;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;
using Noggog;
using Noggog.IO;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;

namespace Mutagen.Bethesda.FormKeys.Generator;

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
        if (!char.IsLetter(name[0]) && name[0] != '_')
        {
            name = $"_{name}";
        }
        name = name.Replace('%', '_');
        name = name.Replace('&', '_');
        name = name.Replace('-', '_');
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

    public record RecordItem(FormKey FormKey, string Edid, ILoquiRegistration Regis);

    private static void CleanNames(List<RecordItem> items)
    {
        var nameMapping = new Dictionary<Type, HashSet<string>>();
        foreach (var item in items)
        {
            nameMapping.GetOrAdd(item.Regis.GetterType).Add(item.Edid);
        }

        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i];
            var cleanedName = CleanName(item.Edid, item.Regis.Name);
            if (cleanedName == item.Edid) continue;
            while (nameMapping[item.Regis.GetterType].Contains(cleanedName))
            {
                cleanedName += "_";
            }

            items[i] = item with { Edid = cleanedName };
        }
    }

    public static void Generate(GenerateFromMod gen)
    {
        ExportStringToFile exportStringToFile = new();
        var mod = ModInstantiator.Importer(gen.Path, gen.Release);
        var list = new List<RecordItem>();
        foreach (var rec in mod.EnumerateMajorRecords())
        {
            if (rec.EditorID is not {} edid) continue;
            var formKey = rec.FormKey;
            // Only register FormKeys originating from the mod itself
            if (formKey.ModKey != mod.ModKey) continue;
            var regis = GetMajorRecord(rec.Registration);
            list.Add(new(formKey, edid, regis));
        }
            
        CleanNames(list);

        var namespaceStr = $"Mutagen.Bethesda.FormKeys.{gen.Release}";
        var importStr = $"Mutagen.Bethesda.{gen.Release.ToCategory()}";
        var modName = mod.ModKey.Name.TrimStart("DLC");
        if (char.IsLower(modName[0]))
        {
            modName = char.ToUpper(modName[0]) + modName[1..];
        }

        var autoGenLine = $"// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys";

        StructuredStringBuilder sb;
        string path;
        foreach (var regis in list.GroupBy(x => x.Regis))
        {
            sb = new StructuredStringBuilder();
            sb.AppendLine(autoGenLine);
            sb.AppendLine();
            sb.AppendLine($"using {importStr};");
            sb.AppendLine($"using Mutagen.Bethesda.Plugins;");
            sb.AppendLine();

            using (sb.Namespace(namespaceStr))
            {
                using (var c = sb.Class(modName))
                {
                    c.Static = true;
                    c.Partial = true;
                }
                using (sb.CurlyBrace())
                {
                    using (var c = sb.Class(regis.Key.Name))
                    {
                        c.Static = true;
                        c.Partial = true;
                    }
                    using (sb.CurlyBrace())
                    {
                        sb.AppendLine($"private static FormLink<{regis.Key.GetterType.Name}> Construct(uint id) => new FormLink<{regis.Key.GetterType.Name}>(ModKey.{nameof(ModKeyExt.MakeFormKey)}(id));");
                        foreach (var rec in regis)
                        {
                            sb.AppendLine($"public static FormLink<{regis.Key.GetterType.Name}> {CleanName(rec.Edid, regis.Key.Name)} => Construct(0x{rec.FormKey.ID:x});");
                        }
                    }
                }
            }

            path = Path.Combine("Output", gen.Release.ToString(), modName, $"{regis.Key.Name}.cs");
            exportStringToFile.ExportToFile(path, sb.GetString());
            System.Console.WriteLine($"Exported: {path}");
        }

        // Generate ModKey partial class
        sb = new StructuredStringBuilder();
        sb.AppendLine(autoGenLine);
        sb.AppendLine();
        sb.AppendLine($"using Mutagen.Bethesda.Plugins;");
        sb.AppendLine();
        using (sb.Namespace(namespaceStr))
        {
            using (var c = sb.Class(modName))
            {
                c.Static = true;
                c.Partial = true;
            }
            using (sb.CurlyBrace())
            {
                sb.AppendLine($"public readonly static ModKey ModKey = ModKey.{nameof(ModKey.FromNameAndExtension)}(\"{mod.ModKey}\");");
            }
        }
        path = Path.Combine("Output", gen.Release.ToString(), modName, $"ModKey.cs");
        exportStringToFile.ExportToFile(path, sb.GetString());
        System.Console.WriteLine($"Exported: {path}");
    }
}