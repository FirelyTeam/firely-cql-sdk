/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CommandLine;
using Dumpify;

namespace CLI.Helpers
{
    internal class CommandLineOptions
    {
        [Option('l', "library", Required = true, HelpText = "The name of a measure Library resource, which contains name and version.")]
        public string Library { get; set; } = "";
        public string LibraryName => Library.Split('-')[0];
        public string LibraryVersion => Library.Split('-')[1];

        [Option('d', "data", HelpText = "The folder for test data.")]
        public string DataDirectory { get; set; } = "";

        [Option('v', "valuesets", HelpText = "The folder where valuesets are stored.")]
        public string ValueSetsDirectory { get; set; } = "";

        [Option('r', "resourcesDirectory", HelpText = "The directory where the library resources are stored.")]
        public string ResourcesDirectory { get; set; } = "";

        public string LibraryFile => Path.Combine(ResourcesDirectory, $"{Library}.json");

        public AssemblySource AssemblySource { get; private set; } = AssemblySource.Unspecified;

        [Option('a', "assemblyPath", HelpText = "The path of the assembly.")]
        public string AssemblyPath { get; set; } = "";

        [Option('o', "outputPath", HelpText = "The directory path of the output results files.")]
        public string OutputDirectory { get; set; } = "";

        [Option('t', "outputType", HelpText = "The output type for results.")]
        public ResultsType ResultsType { get; set; } = ResultsType.Unspecified;

        public string OutputFile { get; private set; } = "";

        public static void EnsureValidOptions(CommandLineOptions options)
        {
            // Validate the library name format
            if (options.Library.Count(c => c == '-') != 1)
            {
                throw new InvalidOperationException($"The name of the Library resource '{options.Library}' should be written as '<name>-<version>'.");
            }

            // Check if the data directory is set
            if (string.IsNullOrWhiteSpace(options.DataDirectory))
            {
                throw new InvalidOperationException($"The folder name of the test case '{options.DataDirectory}' cannot be empty.");
            }

            // Ensure either AssemblyPath or ResourcesDirectory is set, but not both
            if (string.IsNullOrEmpty(options.AssemblyPath) == string.IsNullOrEmpty(options.ResourcesDirectory))
            {
                throw new ArgumentException("Please choose one: either assemblyPath or resourcesDirectory.");
            }

            // Validate the assembly path or resources directory
            if (!string.IsNullOrEmpty(options.AssemblyPath))
            {
                if (!File.Exists(options.AssemblyPath))
                {
                    throw new InvalidOperationException($"File '{options.AssemblyPath}' must exist.");
                }

                options.AssemblySource = AssemblySource.Project;
            }
            else if (!string.IsNullOrEmpty(options.ResourcesDirectory))
            {
                if (!Directory.Exists(options.ResourcesDirectory))
                {
                    throw new InvalidOperationException($"The directory '{options.ResourcesDirectory}' must exist.");
                }

                ValidateLibraryFiles(options);

                options.AssemblySource = AssemblySource.Resource;
            }

            // Ensure the output directory exists
            CreateDirectoryIfNotExists(options.OutputDirectory);

            // Set the output file path based on results type
            SetOutputFilePath(options);

            // Validate additional directories
            ValidateAdditionalDirectories(options);

            if (!Enum.IsDefined(typeof(AssemblySource), options.AssemblySource))
            {
                throw new InvalidOperationException($"AssemblySource '{options.AssemblySource}' is not a valid value. Valid options are Resource or Project.");
            }
        }

        private static void ValidateLibraryFiles(CommandLineOptions options)
        {
            foreach (var file in new[] { options.LibraryFile, Path.Combine(options.ResourcesDirectory, "TupleTypes-Binary.json") })
            {
                if (!File.Exists(file))
                {
                    throw new InvalidOperationException($"File '{file}' must exist.");
                }
            }
        }

        private static void CreateDirectoryIfNotExists(string? directoryPath)
        {
            if (!string.IsNullOrEmpty(directoryPath))
            {
                var directory = new DirectoryInfo(directoryPath);
                if (!directory.Exists)
                {
                    directory.Create();
                    directory.Refresh();
                }
            }
        }

        private static void SetOutputFilePath(CommandLineOptions options)
        {
            if (!string.IsNullOrEmpty(options.OutputDirectory) && options.ResultsType != ResultsType.Unspecified)
            {
                options.OutputFile = options.ResultsType switch
                {
                    ResultsType.Text => Path.Combine(options.OutputDirectory, $"{options.Library}.txt"),
                    ResultsType.Ndjson => Path.Combine(options.OutputDirectory, $"{options.Library}.json"),
                    _ => ""
                };

                if (File.Exists(options.OutputFile))
                {
                    File.Delete(options.OutputFile);
                }
            }
        }

        private static void ValidateAdditionalDirectories(CommandLineOptions options)
        {
            foreach (var directory in new[] { options.DataDirectory, options.ValueSetsDirectory })
            {
                if (!Directory.Exists(directory))
                {
                    throw new InvalidOperationException($"The directory '{directory}' must exist.");
                }
            }
        }

        public void DumpConsole()
        {
            new
            {
                Library,
                AssemblySource,
                DataDirectory,
                ResourcesDirectory,
                ValueSetsDirectory
            }.DumpConsole("Options");
        }
    }

    internal enum AssemblySource
    {
        Unspecified = 0,
        Resource = 1,
        Project = 2,
    }

    internal enum ResultsType
    {
        Unspecified = 0,
        Ndjson = 1,
        Text = 2,
    }
}
