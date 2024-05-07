/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using CLI_cms;
using CLI_cms.Helpers;
using CommandLine;

namespace CLI.cms;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(RunCommand)
                .WithNotParsed(HandleErrors);
            Console.WriteLine($"Exit code: {(int)ExitCode.Success}");
            //Environment.Exit((int)ExitCode.Success);
        }
        catch (InvalidOperationException invalidOptionException)
        {
            Console.WriteLine(invalidOptionException);
            Console.WriteLine($"Exit code: {(int)ExitCode.InvalidOptions}");
            Environment.Exit((int)ExitCode.InvalidOptions);
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException);
            Console.WriteLine($"Exit code: {(int)ExitCode.ArgumentException}");
            Environment.Exit((int)ExitCode.InvalidOptions);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            Console.WriteLine($"Exit code: {(int)ExitCode.UnknownError}");
            Environment.Exit((int)ExitCode.UnknownError);
        }
    }

    private static void RunCommand(CommandLineOptions options)
    {
        CommandLineOptions.EnsureValidOptions(options);
        switch (options.AssemblySource)
        {
            case AssemblySource.Project:
                LibraryRunner.RunWithMeasureCmsProject(options);
                break;
            default:
            case AssemblySource.Resource:
                LibraryRunner.RunWithResources(options);
                break;
        }
    }

    static void HandleErrors(IEnumerable<Error> errs)
    {
        //throw new InvalidOperationException("Invalid command line arguments.");
        Environment.Exit((int)ExitCode.InvalidOptions);
    }
}
