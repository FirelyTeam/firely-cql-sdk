using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager.Logging;

internal sealed class CleanConsoleFormatterOptions
{
    public bool NoColor { get; set; }
}
internal sealed class CleanConsoleFormatterOptionsInternal : ConsoleFormatterOptions
{
    public CleanConsoleFormatterOptions Options { get; } = new();
}

internal sealed class CleanConsoleFormatter : ConsoleFormatter
{
    private readonly IOptionsMonitor<CleanConsoleFormatterOptionsInternal> _optionsMonitor;
    public const string FormatterName = "NoCategory";

    public CleanConsoleFormatter(
        IOptionsMonitor<CleanConsoleFormatterOptionsInternal> optionsMonitor) : base(FormatterName) =>
        _optionsMonitor = optionsMonitor;

    public override void Write<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider? scopeProvider, TextWriter textWriter)
    {
        var options = _optionsMonitor.CurrentValue.Options;

        var message = logEntry.Formatter(logEntry.State, logEntry.Exception);
        var (logLevelText, logLevelConsoleColor) = GetLogLevelString(logEntry.LogLevel);
        var (escLogLevelForegroundColor, escDefaultForegroundColor) = 
            options.NoColor
                ? ("", "")
                : (GetForegroundColorEscapeCode(logLevelConsoleColor), DefaultForegroundColor);
        textWriter.WriteLine($"____\n{escLogLevelForegroundColor}{logLevelText.ToUpperInvariant()}{escDefaultForegroundColor}: {message}");
    }

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
            _            => throw new ArgumentOutOfRangeException(nameof(logLevel))
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
            _                => DefaultForegroundColor // default foreground color
            // @formatter: on
        };

    private const string DefaultForegroundColor = "\x1B[39m\x1B[22m"; // reset to default foreground color
}