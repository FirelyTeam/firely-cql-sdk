using CommandLine;

namespace CLI_cms.Helpers;
internal class CommandLineOptions
{
    [Option('l', "libraryFile", Required = true, HelpText = "A CMS library/measure CQL file to run.")]
    public string LibraryFile { get; set; } = "";

    [Option('v', "valueSetDirectory", Required = true, HelpText = "The local directory where all ValueSet can be found.")]
    public string ValueSetDirectory { get; set; } = "";

    [Option('b', "testingBundleFile", Required = true, HelpText = "A Bundle file contains all testing data.")]
    public string TestingBundleFile { get; set; } = "";

    public static void EnsureValidOptions(CommandLineOptions options)
    {
        if (!File.Exists(options.LibraryFile))
        {
            throw new InvalidOperationException($"CQL file '{options.LibraryFile}' cannot be found.");
        }

        if (!Directory.Exists(options.ValueSetDirectory))
        {
            throw new InvalidOperationException($"The ValueSet directory '{options.ValueSetDirectory}' must exist.");
        }

        if (!File.Exists(options.TestingBundleFile))
        {
            throw new InvalidOperationException($"Testing Bundle file '{options.TestingBundleFile}' cannot be found.");
        }
    }
}
