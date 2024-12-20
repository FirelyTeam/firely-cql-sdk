using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype;

public class CustomConsoleLogger(string? name, CustomConsoleLoggerProvider provider) : ILogger
{
    private readonly string _name = name ?? "";
    private readonly CustomConsoleLoggerProvider _provider = provider;

    public IDisposable BeginScope<TState>(TState state)
        where TState : notnull =>
        throw new NotSupportedException();

    public bool IsEnabled(LogLevel logLevel) => true;

    public void Log<TState>(
        LogLevel logLevel,
        EventId eventId,
        TState state,
        Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        if (!IsEnabled(logLevel))
            return;

        string message = formatter(state, exception);
        if (string.IsNullOrEmpty(message))
            return;

        var (logLevelText, logLevelConsoleColor) = GetLogLevelString(logLevel);
        var foregroundColorEscapeCode = GetForegroundColorEscapeCode(logLevelConsoleColor);
        var logRecord = $"[{foregroundColorEscapeCode}{logLevelText}{DefaultForegroundColor}] {message}";
        if (exception != null)
        {
            logRecord += Environment.NewLine + exception;
        }

        Console.WriteLine(logRecord);
    }

    #region Colors

    private static (string logLevelText, ConsoleColor logLevelConsoleColor) GetLogLevelString(LogLevel logLevel) =>
        logLevel switch
        {
            // @formatter: off
            LogLevel.Trace       => ("trce", ConsoleColor.DarkBlue),
            LogLevel.Debug       => ("dbug", ConsoleColor.DarkCyan),
            LogLevel.Information => ("info", ConsoleColor.White),
            LogLevel.Warning     => ("warn", ConsoleColor.Yellow),
            LogLevel.Error       => ("fail", ConsoleColor.Red),
            LogLevel.Critical    => ("crit", ConsoleColor.Magenta),
            _                    => throw new ArgumentOutOfRangeException(nameof(logLevel))
            // @formatter: on
        };

    private static string GetForegroundColorEscapeCode(ConsoleColor color) =>
        color switch
        {
            // @formatter: off
            ConsoleColor.Black       => "\x1B[30m",
            ConsoleColor.DarkRed     => "\x1B[31m",
            ConsoleColor.DarkGreen   => "\x1B[32m",
            ConsoleColor.DarkYellow  => "\x1B[33m",
            ConsoleColor.DarkBlue    => "\x1B[34m",
            ConsoleColor.DarkMagenta => "\x1B[35m",
            ConsoleColor.DarkCyan    => "\x1B[36m",
            ConsoleColor.Gray        => "\x1B[37m",
            ConsoleColor.Red         => "\x1B[1m\x1B[31m",
            ConsoleColor.Green       => "\x1B[1m\x1B[32m",
            ConsoleColor.Yellow      => "\x1B[1m\x1B[33m",
            ConsoleColor.Blue        => "\x1B[1m\x1B[34m",
            ConsoleColor.Magenta     => "\x1B[1m\x1B[35m",
            ConsoleColor.Cyan        => "\x1B[1m\x1B[36m",
            ConsoleColor.White       => "\x1B[1m\x1B[37m",
            _                        => DefaultForegroundColor // default foreground color
            // @formatter: on
        };

    private const string DefaultForegroundColor = "\x1B[39m\x1B[22m"; // reset to default foreground color

    #endregion
}