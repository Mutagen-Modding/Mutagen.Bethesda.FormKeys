using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mutagen.Bethesda.FormKeys.Generator
{
    [Verb("generate", HelpText = "Generate FormKeys from a mod file")]
    public class GenerateFromMod
    {
        [Option('g', "Game", Required = true, HelpText = "Game release of the mod to process")]
        public GameRelease Release { get; set; }

        [Option('p', "Path", Required = true, HelpText = "Path to the mod to process")]
        public string Path { get; set; } = string.Empty;
    }
}
