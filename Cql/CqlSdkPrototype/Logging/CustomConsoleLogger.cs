using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using EnumerableExtensions = Hl7.Cql.Abstractions.Infrastructure.EnumerableExtensions;

namespace CqlSdkPrototype.Logging;

public partial class CustomConsoleLogger(string categoryName, CustomConsoleLoggerProvider provider) : ILogger
{
    private readonly string _categoryName = categoryName.Length == 0 ? "" : $"{categoryName}: ";
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

        var logEntry = new LogEntry<TState>(logLevel, _categoryName, eventId, state, exception, formatter);
        var message = GetFormatterMessage(logEntry);
        //string message = formatter(state, exception);
        if (string.IsNullOrEmpty(message))
            return;

        var (logLevelText, logLevelConsoleColor) = GetLogLevelString(logLevel);
        var foregroundColorEscapeCode = GetForegroundColorEscapeCode(logLevelConsoleColor);
        var logRecord = $"{foregroundColorEscapeCode}{logLevelText}{DefaultForegroundColorCode} {_categoryName}{message}";
        if (exception != null)
            logRecord += $"{Environment.NewLine}{GetForegroundColorEscapeCode(ConsoleColor.DarkRed)}{exception}{DefaultForegroundColorCode}";

        Console.WriteLine(logRecord);
    }

    private string GetFormatterMessage<TState>(LogEntry<TState> logEntry)
    {
        // if (NoColor)
        // {
        //     var noColorMessage = logEntry.Formatter(logEntry.State, logEntry.Exception);
        //     return noColorMessage;
        // }

        var state = (IReadOnlyCollection<KeyValuePair<string, object?>>)logEntry.State!;
        var last = state.Last();
        Debug.Assert(last.Key == "{OriginalFormat}");
        var originalFormat = (string)last.Value!;

        if (state.Count == 1)
            return originalFormat; // Nothing to format, return as is

        var colorFormat = GetOrdinalStringFormat(state, originalFormat);
        var colorMessage = string.Format(CultureInfo.InvariantCulture, colorFormat, EnumerableExtensions.SelectToArray(state, s => s.Value));
        return colorMessage;
    }

    private readonly ConcurrentDictionary<string, string> _colorFormatsByOriginalFormat = new();

    private string GetOrdinalStringFormat(
        IReadOnlyCollection<KeyValuePair<string, object?>> state,
        string originalFormat) =>
        _colorFormatsByOriginalFormat.GetOrAdd(
            originalFormat,
            _ =>
            {
                int i = 0;
                Dictionary<string, (int i, object? val)> dictionary = state.ToDictionary(kv => kv.Key, kv => (i: i++, val: kv.Value));
                string finalFormat = ExtractTagsRegex().Replace(originalFormat, m =>
                {
                    var tagName = m.Groups["tagName"].Value;
                    var rest = m.Groups["rest"].Value;
                    if (dictionary.TryGetValue(tagName, out var kv))
                        return $"{GetForegroundColorEscapeCode(ConsoleColor.Cyan)}{{{kv.i}{rest}}}{DefaultForegroundColorCode}";

                    return m.Value;
                });

                return finalFormat;
            });

    [GeneratedRegex("""\{(?<tagName>[^:,}]+)(?<rest>[^}]*)\}""", RegexOptions.Compiled)]
    private static partial Regex ExtractTagsRegex();


    #region Colors

    private static (string logLevelText, ConsoleColor logLevelConsoleColor) GetLogLevelString(LogLevel logLevel) =>
        logLevel switch
        {
            // @formatter: off
            LogLevel.Trace       => ("""""", ConsoleColor.Cyan),
            LogLevel.Debug       => ("""""", ConsoleColor.DarkCyan),
            LogLevel.Information => ("""""", ConsoleColor.Gray),
            LogLevel.Warning     => ("""""", ConsoleColor.Yellow),
            LogLevel.Error       => ("""""", ConsoleColor.Red),
            LogLevel.Critical    => ("""""", ConsoleColor.Magenta),
            _                    => throw new ArgumentOutOfRangeException(nameof(logLevel))
            // @formatter: on
        };

    private static string GetForegroundColorEscapeCode(ConsoleColor color) =>
        color switch
        {
            // @formatter: off
            ConsoleColor.Black => "\x1B[30m",
            ConsoleColor.DarkRed => "\x1B[31m",
            ConsoleColor.DarkGreen => "\x1B[32m",
            ConsoleColor.DarkYellow => "\x1B[33m",
            ConsoleColor.DarkBlue => "\x1B[34m",
            ConsoleColor.DarkMagenta => "\x1B[35m",
            ConsoleColor.DarkCyan => "\x1B[36m",
            ConsoleColor.Gray => "\x1B[37m",
            ConsoleColor.Red => "\x1B[1m\x1B[31m",
            ConsoleColor.Green => "\x1B[1m\x1B[32m",
            ConsoleColor.Yellow => "\x1B[1m\x1B[33m",
            ConsoleColor.Blue => "\x1B[1m\x1B[34m",
            ConsoleColor.Magenta => "\x1B[1m\x1B[35m",
            ConsoleColor.Cyan => "\x1B[1m\x1B[36m",
            ConsoleColor.White => "\x1B[1m\x1B[37m",
            _ => DefaultForegroundColorCode // default foreground color
            // @formatter: on
        };

    private const string DefaultForegroundColorCode = "\x1B[39m\x1B[22m"; // reset to default foreground color

    #endregion
}