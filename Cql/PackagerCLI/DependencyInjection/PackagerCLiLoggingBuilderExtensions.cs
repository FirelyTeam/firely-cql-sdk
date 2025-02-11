/*
 *Copyright(c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Logging;
using Serilog;
using Serilog.Events;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCLiLoggingBuilderExtensions
{
    public static ILoggingBuilder AddPackagerCLiLogging(
        this ILoggingBuilder logging,
        IConfiguration configuration)
    {
        logging.ClearProviders();

         // If we debugging, keep the existing console logger
        bool enableDebugLogging = Debugger.IsAttached;
        enableDebugLogging = enableDebugLogging || configuration.GetCommandLineSwitchValue<bool>("--log-debug");
        var minLogLevel = enableDebugLogging ? LogLevel.Trace : LogLevel.Information;

        if (enableDebugLogging) logging.AddDebug();

        bool shouldClearLog = !configuration.GetCommandLineSwitchValue<bool>("--log-dont-clear");

        logging.AddFilter(level => level >= minLogLevel);
        logging.AddProvider(new ColorConsoleLoggerProvider());

        var logFile = Path.Combine(".", "build.log");

        if (shouldClearLog)
            File.WriteAllText(logFile, ""); // Create or clear the log file
        //File.Delete(logFile);
        else
            File.OpenText(logFile).Close(); // Touch the file

        Log.Logger = new LoggerConfiguration()
                     .Enrich.FromLogContext()
                     .MinimumLevel.Is(MapToSeriLogLogEventLevel(minLogLevel)!.Value)
                     .WriteTo.File(
                         logFile,
                         outputTemplate: "____{NewLine}{Level:u4}: {Message:lj}{NewLine}{Exception}",
                         formatProvider: CultureInfo.InvariantCulture)
                     .CreateLogger();

        return logging.AddSerilog();
    }

    private static LogEventLevel? MapToSeriLogLogEventLevel(LogLevel logLevel) =>
        logLevel switch
        {
            // @formatter: off
            /* 0 */
            LogLevel.Trace => /* 0 */ LogEventLevel.Verbose,
            /* 1 */
            LogLevel.Debug => /* 1 */ LogEventLevel.Debug,
            /* 2 */
            LogLevel.Information => /* 2 */ LogEventLevel.Information,
            /* 3 */
            LogLevel.Warning => /* 3 */ LogEventLevel.Warning,
            /* 4 */
            LogLevel.Error => /* 4 */ LogEventLevel.Error,
            /* 5 */
            LogLevel.Critical => /* 5 */ LogEventLevel.Fatal,
            /* 6 */
            LogLevel.None => /* n/a */ null,
            // @formatter: on
            _ => throw new SwitchExpressionException("Invalid LogLevel."),
        };
}