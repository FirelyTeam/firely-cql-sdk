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
    public static int Main(string[] args)
    {
        var rootCommand = BuildRootCommand();
        var systemConsole = new SystemConsole();
        var result = rootCommand.Invoke(args, systemConsole);
        return result;
    }

    private static Option<T> Option<T>(string name, string description) => new(name, description);

    private static IHostBuilder CreateHostBuilder(
        IConsole console,
        LegacyCommandArgs legacyCommandArgs) =>
        Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(
                (context, config) =>
                    config.AddPackagerCliAppSettings(legacyCommandArgs))
            .ConfigureLogging(
                (context, logging) =>
                    logging.AddPackagerCLiLogging(context.Configuration))
            .ConfigureServices(
                (context, services) =>
                    services
                        .AddPackagerCliOptions()
                        .AddSingleton(legacyCommandArgs)
                        .AddSingleton(console))
            .UseConsoleLifetime();

    private static int RunProgram<TProgram>(
        IConsole console,
        LegacyCommandArgs legacyCommandArgs,
        Action<HostBuilderContext, IServiceCollection>? configureAdditionalServices = null)
        where TProgram : class, IProgram =>
        CreateHostBuilder(console, legacyCommandArgs)
            .ConfigureServices(configureAdditionalServices ?? delegate { })
            .RunProgram<TProgram>();
}
