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
        }
        catch (InvalidOperationException invalidOptionException)
        {
            Console.WriteLine(invalidOptionException.Message);
            Console.WriteLine($"Exit code: {(int)ExitCode.InvalidOptions}");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine($"Exit code: {(int)ExitCode.UnknownError}");
        }
    }

    static async Task RunCommandAsync(CommandLineOptions options)
    {
        CommandLineOptions.EnsureValidOptions(options);
    }
}
