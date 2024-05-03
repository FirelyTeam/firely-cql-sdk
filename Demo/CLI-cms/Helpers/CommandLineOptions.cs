using CommandLine;

namespace CLI_cms.Helpers;
internal class CommandLineOptions
{
    [Option('m', "measure", Required = true, HelpText = "The name of a CMS measure to run.")]
    public string Measure { get; set; } = "";

    [Option('v', "valueSetDirectory", Required = true, HelpText = "The local directory where all ValueSet can be found.")]
    public string ValueSetDirectory { get; set; } = "";

    public static void EnsureValidOptions(CommandLineOptions options)
    {
        if (!Directory.Exists(options.ValueSetDirectory))
        {
            throw new InvalidOperationException($"The ValueSet directory {options.ValueSetDirectory} must exist.");
        }
    }
}
