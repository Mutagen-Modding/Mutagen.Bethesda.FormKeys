using CommandLine;

namespace Mutagen.Bethesda.FormKeys.Generator;

[Verb("generate-from-config", HelpText = "Generate FormKeys from mod files listed in a config")]
public class GenerateFromConfig
{
    [Option('p', "Path", Required = true, HelpText = "Path to config")]
    public string ConfigPath { get; set; } = string.Empty;

    [Option('d', "DataFolder", Required = false, HelpText = "Data folder to look up masters in.  Uses the detected game install if missing")]
    public string? DataFolder { get; set; }
}