/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager;

internal static class GlobalMethods
{
    public static Option<T> Option<T>(string name, string description) => new(name, description);

    private static IHostBuilder CreateHostBuilder(
        IConsole console,
        string profile,
        Func<IEnumerable<(object? value, string[] sectionPath)>>? additionalConfiguration = null) =>
        Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => config.AddPackagerCliAppSettings(profile, additionalConfiguration))
            .ConfigureLogging((context, logging) => logging.AddPackagerCLiLogging(context.Configuration))
            .ConfigureServices((context, services) =>
                                   services
                                       .AddPackagerCliOptions()
                                       .AddSingleton<OptionsConsoleDumper>()
                                       .AddSingleton<PdbOptionsValidator>()
                                       .AddSingleton(console))
            .UseConsoleLifetime();

    internal static int RunProgram<TProgram>(
        IConsole console,
        LoggingCommand loggingCommand,
        GlobalCommand globalCommand,
        Func<IEnumerable<(object? value, string[] sectionPath)>>? additionalConfiguration = null,
        Action<HostBuilderContext, IServiceCollection>? configureAdditionalServices = null)
        where TProgram : class, IProgram =>
        CreateHostBuilder(
                console,
                globalCommand.Profile,
                () =>
                {
                    IEnumerable<(object? value, string[] sectionPath)> config = [];
                    config = config.Concat(loggingCommand.GetConfigMapping());

                    if (additionalConfiguration?.Invoke() is { } additionalConfig)
                        config = config.Concat(additionalConfig);

                    return config;
                })
            .ConfigureServices(configureAdditionalServices ?? delegate { })
            .RunProgram<TProgram>();
}