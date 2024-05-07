/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CommandLine;
using Dumpify;

namespace CLI_cms.Helpers;
internal class CommandLineOptions
{
    private string? _resourceDirectory;

    [Option('l', "library", Required = true, HelpText = "The name of a CMS measure Library resource, which contains name and version.")]
    public string Library { get; set; } = "";

    [Option('t', "testCase", Required = true, HelpText = "The folder name of a test case.")]
    public string TestCase { get; set; } = "";

    public string LibraryName => Library.Split('-')[0];
    public string LibraryVersion => Library.Split('-')[1];
    public string TestRootDirectory => Path.Join(AppContext.BaseDirectory, "Measures");
    public string ValueSetDirectory => Path.Join(TestRootDirectory, Library, "ValueSet");

    [Option('r', "resourceDirectory", HelpText = "The directory where the library resources are stored.")]
    public string ResourceDirectory
    {
        get => _resourceDirectory ?? Path.Join(TestRootDirectory, Library, "Resources");
        set => _resourceDirectory = value;
    }

    public string LibraryFile => Path.Join(ResourceDirectory, $"{Library}.json");
    public string TestCaseDirectory => Path.Join(TestRootDirectory, Library, "TestCases", TestCase);
    public string TestCaseBundleFile => Path.Join(TestCaseDirectory, "Bundle.json");
    public string TestCaseInputParametersFile => Path.Join(TestCaseDirectory, "InputParameters.json");

    [Option('a', "assemblySource", Default = AssemblySource.Resource, HelpText = "The source of the assembly.")]
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
            options.ResourceDirectory,
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
            Path.Join(options.ResourceDirectory, "TupleTypes-Binary.json") })
        {
            if (!File.Exists(file))
            {
                throw new InvalidOperationException($"File '{file}' must exist.");
            }
        }

        if (!Enum.IsDefined(options.AssemblySource))
            throw new InvalidOperationException($"AssemblySource '{options.AssemblySource}' is not a valid value. Valid options are Resource or Project.");
    }

    public void DumpConsole()
    {
        new
        {
            Library,
            TestCase,
            AssemblySource,
            TestCaseDirectory,
            ResourceDirectory,
            ValueSetDirectory
        }.DumpConsole("Options");
    }
}

internal enum AssemblySource
{
    Unspecified = 0,
    Resource = 1,
    Project = 2,
}