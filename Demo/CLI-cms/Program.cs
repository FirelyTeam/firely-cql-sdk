using CLI_cms;
using CLI_cms.Helpers;
using CommandLine;

namespace CLI.cms;

internal class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            await Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsedAsync(RunCommandAsync);
            Console.WriteLine($"Exit code: {(int)ExitCode.Success}");
            Environment.Exit((int)ExitCode.Success);
        }
        catch (InvalidOperationException invalidOptionException)
        {
            Console.WriteLine(invalidOptionException.Message);
            Console.WriteLine($"Exit code: {(int)ExitCode.InvalidOptions}");
            Environment.Exit((int)ExitCode.InvalidOptions);
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
            Console.WriteLine($"Exit code: {(int)ExitCode.ArgumentException}");
            Environment.Exit((int)ExitCode.InvalidOptions);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine($"Exit code: {(int)ExitCode.UnknownError}");
            Environment.Exit((int)ExitCode.UnknownError);
        }
    }

    static async Task RunCommandAsync(CommandLineOptions options)
    {
        CommandLineOptions.EnsureValidOptions(options);
        LibraryRunner.Run(options);
    }
}
