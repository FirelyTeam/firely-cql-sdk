/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace XsdToCSharpConverter;

class Program
{
    static int Main(string[] args)
    {
        try
        {
            var options = ParseArguments(args);
            if (options == null)
            {
                PrintUsage();
                return 1;
            }

            // On Windows, use xsd.exe for compatibility
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return RunXsdExe(options);
            }
            else
            {
                Console.Error.WriteLine("Error: This tool currently only supports Windows.");
                Console.Error.WriteLine("The xsd.exe tool is required for generating C# code that matches the existing format.");
                Console.Error.WriteLine("Please run this tool on a Windows system.");
                return 1;
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            if (args.Contains("--verbose") || args.Contains("-v"))
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
            return 1;
        }
    }

    static int RunXsdExe(CommandLineOptions options)
    {
        // Build xsd.exe command line
        var xsdArgs = new StringBuilder("/c");

        foreach (var schemaFile in options.SchemaFiles)
        {
            xsdArgs.Append($" \"{schemaFile}\"");
        }

        if (!string.IsNullOrEmpty(options.OutputPath))
        {
            xsdArgs.Append($" /o:\"{options.OutputPath}\"");
        }

        if (!string.IsNullOrEmpty(options.Namespace))
        {
            xsdArgs.Append($" /n:{options.Namespace}");
        }

        // Suppress output if requested
        if (options.SuppressOutput)
        {
            xsdArgs.Append(" > NUL");
        }

        Console.WriteLine($"Running: xsd {xsdArgs}");

        // Try to find xsd.exe
        var xsdPath = FindXsdExe();
        if (xsdPath == null)
        {
            Console.Error.WriteLine("Error: xsd.exe not found.");
            Console.Error.WriteLine("Please ensure the .NET Framework SDK is installed.");
            Console.Error.WriteLine("Typical locations:");
            Console.Error.WriteLine("  C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\");
            return 1;
        }

        Console.WriteLine($"Using xsd.exe from: {xsdPath}");

        // Run xsd.exe
        var psi = new ProcessStartInfo
        {
            FileName = xsdPath,
            Arguments = xsdArgs.ToString().Replace(" > NUL", ""),
            UseShellExecute = false,
            RedirectStandardOutput = options.SuppressOutput,
            RedirectStandardError = true,
            CreateNoWindow = true
        };

        using var process = Process.Start(psi);
        if (process == null)
        {
            Console.Error.WriteLine("Error: Failed to start xsd.exe");
            return 1;
        }

        var errorOutput = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(errorOutput))
        {
            Console.Error.WriteLine(errorOutput);
        }

        if (process.ExitCode != 0)
        {
            Console.Error.WriteLine($"Error: xsd.exe exited with code {process.ExitCode}");
            return process.ExitCode;
        }

        // Post-process the generated file if requested
        if (options.PostProcessing != null && options.PostProcessing.Enabled)
        {
            PostProcessGeneratedFile(options);
        }

        return 0;
    }

    static string? FindXsdExe()
    {
        // Check PATH first
        var pathVar = Environment.GetEnvironmentVariable("PATH") ?? "";
        foreach (var path in pathVar.Split(';'))
        {
            var xsdPath = Path.Combine(path, "xsd.exe");
            if (File.Exists(xsdPath))
            {
                return xsdPath;
            }
        }

        // Check common SDK locations
        var sdkPaths = new[]
        {
            @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\",
            @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.2 Tools\",
            @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\",
            @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7 Tools\",
            @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\",
            @"C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools\",
            @"C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\",
        };

        foreach (var sdkPath in sdkPaths)
        {
            var xsdPath = Path.Combine(sdkPath, "xsd.exe");
            if (File.Exists(xsdPath))
            {
                return xsdPath;
            }
        }

        return null;
    }

    static void PostProcessGeneratedFile(CommandLineOptions options)
    {
        if (options.PostProcessing == null) return;

        var pp = options.PostProcessing;
        var inputFile = pp.InputFile;
        var outputFile = pp.OutputFile;
        var tempFile = pp.TempFile ?? outputFile + ".tmp";

        if (!File.Exists(inputFile))
        {
            Console.Error.WriteLine($"Warning: Generated file '{inputFile}' not found for post-processing.");
            return;
        }

        Console.WriteLine($"Post-processing: {inputFile} -> {outputFile}");

        var lines = File.ReadAllLines(inputFile);
        using (var writer = new StreamWriter(tempFile, false, Encoding.UTF8))
        {
            for (int i = 0; i < lines.Length; i++)
            {
                int lineNumber = i + 1;

                // Replace specific line (e.g., line 11)
                if (pp.ReplaceLine.HasValue && lineNumber == pp.ReplaceLine.Value)
                {
                    if (!string.IsNullOrEmpty(pp.ReplaceWith))
                    {
                        writer.WriteLine(pp.ReplaceWith);
                    }
                }
                // Insert lines after specific line (e.g., after line 12)
                else if (pp.InsertAfterLine.HasValue && lineNumber == pp.InsertAfterLine.Value)
                {
                    writer.WriteLine(lines[i]);
                    if (pp.InsertLines != null)
                    {
                        foreach (var insertLine in pp.InsertLines)
                        {
                            writer.WriteLine(insertLine);
                        }
                    }
                }
                else
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        // Replace original with processed file
        File.Delete(inputFile);
        if (File.Exists(outputFile))
        {
            File.Delete(outputFile);
        }
        File.Move(tempFile, outputFile);

        Console.WriteLine($"Post-processing complete: {outputFile}");
    }

    static CommandLineOptions? ParseArguments(string[] args)
    {
        if (args.Length == 0)
            return null;

        var options = new CommandLineOptions();
        var schemaFiles = new List<string>();

        for (int i = 0; i < args.Length; i++)
        {
            var arg = args[i].ToLowerInvariant();

            if (arg == "/c" || arg == "-c")
            {
                // Classes mode (default and only supported mode)
                options.GenerateClasses = true;
            }
            else if (arg.StartsWith("/o:") || arg.StartsWith("-o:"))
            {
                options.OutputPath = arg.Substring(3);
            }
            else if (arg == "/o" || arg == "-o")
            {
                if (i + 1 < args.Length)
                {
                    options.OutputPath = args[++i];
                }
            }
            else if (arg.StartsWith("/n:") || arg.StartsWith("-n:"))
            {
                options.Namespace = arg.Substring(3);
            }
            else if (arg == "/n" || arg == "-n")
            {
                if (i + 1 < args.Length)
                {
                    options.Namespace = args[++i];
                }
            }
            else if (arg == "/quiet" || arg == "-quiet" || arg == "/q" || arg == "-q")
            {
                options.SuppressOutput = true;
            }
            else if (arg == "--post-process" || arg == "-pp")
            {
                options.PostProcessing = new PostProcessingOptions { Enabled = true };
            }
            else if (!arg.StartsWith("/") && !arg.StartsWith("-"))
            {
                // Schema file (use original casing)
                schemaFiles.Add(args[i]);
            }
        }

        if (schemaFiles.Count == 0)
            return null;

        options.SchemaFiles = schemaFiles;

        return options;
    }

    static void PrintUsage()
    {
        Console.WriteLine("XSD to C# Converter - Wrapper for xsd.exe with post-processing");
        Console.WriteLine();
        Console.WriteLine("Usage: xsd2cs [options] schema1.xsd [schema2.xsd ...]");
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine("  /c              Generate classes (default)");
        Console.WriteLine("  /o:<path>       Output directory");
        Console.WriteLine("  /n:<namespace>  Namespace for generated classes");
        Console.WriteLine("  /q              Suppress xsd.exe output");
        Console.WriteLine("  --post-process  Enable post-processing of generated file");
        Console.WriteLine();
        Console.WriteLine("Example:");
        Console.WriteLine("  xsd2cs /c /o:.. /n:Hl7.Cql.Elm library.xsd expression.xsd");
        Console.WriteLine();
        Console.WriteLine("Note: This tool requires xsd.exe from the .NET Framework SDK on Windows.");
    }
}

class CommandLineOptions
{
    public List<string> SchemaFiles { get; set; } = [];
    public string OutputPath { get; set; } = string.Empty;
    public string Namespace { get; set; } = string.Empty;
    public bool GenerateClasses { get; set; } = true;
    public bool SuppressOutput { get; set; } = false;
    public PostProcessingOptions? PostProcessing { get; set; }
}

class PostProcessingOptions
{
    public bool Enabled { get; set; }
    public string InputFile { get; set; } = string.Empty;
    public string OutputFile { get; set; } = string.Empty;
    public string? TempFile { get; set; }
    public int? ReplaceLine { get; set; }
    public string? ReplaceWith { get; set; }
    public int? InsertAfterLine { get; set; }
    public List<string>? InsertLines { get; set; }
}
