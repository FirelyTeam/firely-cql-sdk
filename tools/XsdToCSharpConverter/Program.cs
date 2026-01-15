/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace XsdToCSharpConverter;

sealed class Program
{
    static int Main(string[] args)
    {
        try
        {
            var options = ParseArguments(args);
            if (options is null)
            {
                PrintUsage();
                return 1;
            }

            var generator = new XsdCodeGenerator(options);
            generator.Generate();

            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            return 1;
        }
    }

    static CommandLineOptions? ParseArguments(string[] args)
    {
        if (args.Length == 0)
            return null;

        var options = new CommandLineOptions();
        var schemaFiles = new List<string>();

        foreach (var arg in args)
        {
            var argLower = arg.ToLowerInvariant();

            switch (argLower)
            {
                case "/c":
                    options.GenerateClasses = true;
                    break;
                case var _ when argLower.StartsWith("/o:"):
                    options.OutputPath = arg[3..];
                    break;
                case var _ when argLower.StartsWith("/n:"):
                    options.Namespace = arg[3..];
                    break;
                case var _ when argLower.StartsWith("/out:"):
                    options.OutputFile = arg[5..];
                    break;
                case var _ when !arg.StartsWith('/') && !arg.StartsWith('-'):
                    schemaFiles.Add(arg);
                    break;
            }
        }

        if (schemaFiles.Count == 0)
            return null;

        options.SchemaFiles = schemaFiles;

        // If output file not specified, derive from first schema file
        if (string.IsNullOrEmpty(options.OutputFile))
        {
            options.OutputFile = Path.ChangeExtension(Path.GetFileName(schemaFiles[0]), ".cs");
        }

        return options;
    }

    static void PrintUsage()
    {
        Console.WriteLine("XSD to C# Converter");
        Console.WriteLine();
        Console.WriteLine("Usage: xsd2cs /c [/o:<path>] [/n:<namespace>] [/out:<filename>] schema1.xsd [schema2.xsd ...]");
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine("  /c                Generate classes");
        Console.WriteLine("  /o:<path>         Output directory");
        Console.WriteLine("  /n:<namespace>    Namespace for generated classes");
        Console.WriteLine("  /out:<filename>   Output filename (default: derived from first schema file)");
        Console.WriteLine();
        Console.WriteLine("Example:");
        Console.WriteLine("  xsd2cs /c /o:.. /n:Hl7.Cql.Elm /out:elmv2.g.cs library.xsd expression.xsd");
    }
}
