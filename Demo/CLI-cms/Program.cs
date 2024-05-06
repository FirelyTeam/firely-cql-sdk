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
        LibraryRunner.Run(options);
    }

    static void HandleErrors(IEnumerable<Error> errs)
    {
        throw new InvalidOperationException("Invalid command line arguments.");
    }
}
