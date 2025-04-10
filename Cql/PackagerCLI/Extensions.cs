namespace Hl7.Cql.Packager;

internal static class Extensions
{
    public static int RunProgram<TProgram>(this IHostBuilder hostBuilder)
        where TProgram : class, IProgram
    {
        hostBuilder.ConfigureServices((_, services) => services.AddScoped<IProgram, TProgram>());
        using var host = hostBuilder.Build();
        var rootServices = host.Services;

        var dumper = rootServices.GetRequiredService<OptionsConsoleDumper>();
        dumper.DumpToConsole();

        var hostApplicationLifetime = rootServices.GetRequiredService<IHostApplicationLifetime>();
        try
        {
            using IServiceScope scope = rootServices.CreateScope();
            var scopedServices = scope.ServiceProvider;
            var packagerCliProgram = scopedServices.GetRequiredService<IProgram>();
            var result = packagerCliProgram.Run();
            return result;
        }
        catch (Exception e)
        {
            var console = rootServices.GetService<IConsole>();
            var logger = rootServices.GetService<ILogger<Program>>();
            logger?.LogError(e, "An error occurred while running PackagerCLI.");
            console?.Error.WriteLine("An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
        finally
        {
            var hostLifetime = hostApplicationLifetime;
            hostLifetime.StopApplication();
        }
    }

    public static Option<T> IsRequired<T>(this Option<T> option)
    {
        option.IsRequired = true;
        return option;
    }

    public static Option<T> IsGlobalOption<T>(this Option<T> option, ref Action<Command> actions)
    {
        actions += command => command.AddGlobalOption(option);
        return option;
    }

    public static TCommand AddOptions<TCommand>(
        this TCommand command,
        params Option[] options)
        where TCommand : Command
    {
        foreach (var option in options)
            command.AddOption(option);
        return command;
    }

    public static TCommand AddGlobalOptions<TCommand>(
        this TCommand command,
        params Option[] options)
        where TCommand : Command
    {
        foreach (var option in options)
            command.AddGlobalOption(option);
        return command;
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