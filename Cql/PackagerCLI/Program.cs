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
        RootCommand rootCommand = BuildRootCommand();
        var systemConsole = new SystemConsole();
        var result = rootCommand.Invoke(args, systemConsole);
        return result;
    }

    private static Option<T> Option<T>(string name, string description) => new(name, description);

    private static IHostBuilder CreateHostBuilder(
        IConsole console,
        LegacyProgramArgs legacyProgramArgs) =>
        Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(
                (context, config) =>
                    config.AddPackagerCliAppSettings(legacyProgramArgs))
            .ConfigureLogging(
                (context, logging) =>
                    logging.AddPackagerCLiLogging(context.Configuration))
            .ConfigureServices(
                (context, services) =>
                    services
                        .AddPackagerCliOptions()
                        .AddSingleton(legacyProgramArgs)
                        .AddSingleton(console))
            .UseConsoleLifetime();
}

internal static class X
{
    public static Option<T> Required<T>(this Option<T> option)
    {
        option.IsRequired = true;
        return option;
    }

    public static TCommand SetHandler<TCommand>(
        this TCommand command,
        string methodName)
        where TCommand : Command
    {
        var methodInfo = typeof(Program).GetMethod(methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                         ?? throw new MissingMethodException(typeof(Program).AssemblyQualifiedName, methodName);

        var commandHandler = CommandHandler.Create(methodInfo);
        command.Handler = commandHandler;
        return command;
    }
}