/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager;

public partial class Program
{
    private static readonly Option[] GlobalOptions = [
        Option<bool>("--log-debug", "Debug-level logging"),

        Option<bool>("--log-append", "Append to existing log file, instead of clearing"),
    ];

    public static int Main(string[] args)
    {
        var rootCommand = BuildRootCommand();
        rootCommand.AddCommand(BuildElmToFhirCommand());
        rootCommand.AddCommand(BuildCqlToElmCommand());
        // rootCommand.AddCommand(BuildCqlToFhirCommand());
        var systemConsole = new SystemConsole();
        var result = rootCommand.Invoke(args, systemConsole);
        return result;
    }

    private static Command BuildCqlToElmCommand()
    {
        return new Command("cql-to-elm", "Convert CQL to ELM");
    }

    // private static Command BuildCqlToFhirCommand()
    // {
    //     return new Command("cql-to-fhir", "Convert CQL to ELM, C# and .NET assemblies, then package them into FHIR resources.");
    // }
    //
    private static Option<T> Option<T>(string name, string description) => new(name, description);

    private static IHostBuilder CreateHostBuilder(
        IConsole console,
        Func<IEnumerable<KeyValuePair<string, string?>>>? additionalConfiguration = null) =>
        Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(
                (context, config) =>
                    config.AddPackagerCliAppSettings(additionalConfiguration))
            .ConfigureLogging(
                (context, logging) =>
                    logging.AddPackagerCLiLogging(context.Configuration))
            .ConfigureServices(
                (context, services) =>
                    services
                        .AddPackagerCliOptions()
                        .AddSingleton<OptionsConsoleDumper>()
                        .AddSingleton(console))
            .UseConsoleLifetime();

    private static int RunProgram<TProgram>(
        IConsole console,
        LoggingCommandArgs loggingCommandArgs,
        Func<IEnumerable<KeyValuePair<string, string?>>>? additionalConfiguration = null,
        Action<HostBuilderContext, IServiceCollection>? configureAdditionalServices = null)
        where TProgram : class, IProgram =>
        CreateHostBuilder(console, () =>
            {
                var globalData = loggingCommandArgs.MapToConfiguration();
                if (additionalConfiguration?.Invoke() is {} additionalData)
                    globalData = globalData.Concat(additionalData);
                return globalData;
            })
            .ConfigureServices(configureAdditionalServices ?? delegate { })
            .RunProgram<TProgram>();

    private static RootCommand BuildRootCommand() =>
        new RootCommand(ElmToFhirDescription)
            .AddOptions(ElmToFhirOptions)
            .AddGlobalOptions(GlobalOptions)
            .SetHandler(nameof(RunElmToFhir));
}
