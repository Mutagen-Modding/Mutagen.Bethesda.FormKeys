using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mutagen.Bethesda.FormKeys.Generator
{
    [Verb("generate-from-config", HelpText = "Generate FormKeys from mod files listed in a config")]
    public class GenerateFromConfig
    {
        [Option('p', "Path", Required = true, HelpText = "Path to config")]
        public string ConfigPath { get; set; } = string.Empty;
    }
}
