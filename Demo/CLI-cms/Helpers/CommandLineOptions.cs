using CommandLine;

namespace CLI_cms.Helpers;
internal class CommandLineOptions
{
    [Option('l', "library", Required = true, HelpText = "The name of a CMS measure Library resource, which contians name and version.")]
    public string Library { get; set; } = "";

    [Option('t', "testCase", Required = true, HelpText = "The folder name of a test case.")]
    public string TestCase { get; set; } = "";

    public string LibraryName => Library.Split('-')[0];
    public string LibraryVersion => Library.Split('-')[1];
    public string TestRootDirectory => Path.Join(AppContext.BaseDirectory, "Measures");
    public string ValueSetDirectory => Path.Join(TestRootDirectory, Library, "ValueSet");
    public string LibraryDirectory => Path.Join(TestRootDirectory, Library, "Library");
    public string LibraryFile => Path.Join(LibraryDirectory, $"{Library}.json");
    public string TestCaseDirectory => Path.Join(TestRootDirectory, Library, TestCase);
    public string TestCaseBundleFile => Path.Join(TestCaseDirectory, "Bundle.json");
    public string TestCaseInputParametersFile => Path.Join(TestCaseDirectory, "InputParameters.json");

    [Option('a', "assemblySource", Default = AssemblySource.ProjectFile, HelpText = "The source of the assembly.")]
    public AssemblySource AssemblySource { get; set; } = AssemblySource.Resource;

    public static void EnsureValidOptions(CommandLineOptions options)
    {
        // Check if the name of Library contains a single "-"
        if (options.Library.Count(c => c == '-') != 1)
        {
            throw new InvalidOperationException($"The name of the Library resource '{options.Library}' should be written as '<name>-<version>'.");
        }

        // Check if the test case folder name is empty
        if (string.IsNullOrWhiteSpace(options.TestCase))
        {
            throw new InvalidOperationException($"The folder name of the test case '{options.TestCase}' cannot be empty.");
        }

        foreach (var directory in new string[] {
            options.TestRootDirectory,
            options.ValueSetDirectory,
            options.LibraryDirectory,
            options.TestCaseDirectory })
        {
            if (!Directory.Exists(directory))
            {
                throw new InvalidOperationException($"The directory '{directory}' must exist.");
            }
        }

        foreach (var file in new string[] {
            options.LibraryFile,
            options.TestCaseBundleFile,
            options.TestCaseInputParametersFile,
            Path.Join(options.LibraryDirectory, "TupleTypes-Binary.json") })
        {
            if (!File.Exists(file))
            {
                throw new InvalidOperationException($"File '{file}' must exist.");
            }
        }

        if (!Enum.IsDefined(options.AssemblySource))
            throw new InvalidOperationException($"AssemblySource '{options.AssemblySource}' is not a valid value. Valid options are Resource or ProjectFile.");
    }
}

internal enum AssemblySource
{
    Unspecified = 0,
    Resource = 1,
    ProjectFile = 2,
}