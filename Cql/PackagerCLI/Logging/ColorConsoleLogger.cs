/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Logging;

/// <remarks>
/// This class is not part of the API. It is used internally by the prototype and the PackagerCLI.
/// It will be moved to the PackagerCLI once the prototype is complete,
/// and then it will move to the PackagerCLI and made internal.
/// </remarks>
public sealed partial class ColorConsoleLogger(
    string categoryName,
    ColorConsoleLoggerProvider provider) : ILogger
{
    private readonly string _categoryName =
        categoryName.Length == 0 || provider.MinLogLevel >= LogLevel.Information
            ? "" : $"{categoryName}: ";

    public IDisposable BeginScope<TState>(TState state)
        where TState : notnull =>
        throw new NotSupportedException();

    public bool IsEnabled(LogLevel logLevel) =>
        logLevel >= provider.MinLogLevel;

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
        var colorEsc = GetForegroundColorEscapeCode(logLevelConsoleColor);
        var defaultColorEsc = GetDefaultForegroundColorEscapeCode();
        var logRecord = $"{colorEsc}{logLevelText}{defaultColorEsc} {_categoryName}{message}";
        if (exception != null)
            logRecord += $"{NewLine}{colorEsc}{exception}{defaultColorEsc}";

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
        var colorMessage = string.Format(CultureInfo.InvariantCulture, colorFormat, state.Select(s => s.Value).ToArray());
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
                        return $"{GetForegroundColorEscapeCode(ConsoleColor.Cyan)}{{{kv.i}{rest}}}{GetDefaultForegroundColorEscapeCode()}";

                    return m.Value;
                });

                return finalFormat;
            });

    [GeneratedRegex("""\{(?<tagName>[^:,}]+)(?<rest>[^}]*)\}""")]
    private static partial Regex ExtractTagsRegex();


    #region Colors

    private static (string logLevelText, ConsoleColor logLevelConsoleColor) GetLogLevelString(LogLevel logLevel) =>
        ConsoleFeatures.NoColor
        ? logLevel switch
        {
            // @formatter: off
            LogLevel.Trace       => ("""(TRC)""", default),
            LogLevel.Debug       => ("""(DBG)""", default),
            LogLevel.Information => ("""(INF)""", default),
            LogLevel.Warning     => ("""(WRN)""", default),
            LogLevel.Error       => ("""(ERR)""", default),
            LogLevel.Critical    => ("""(CRI)""", default),
            _                    => throw new ArgumentOutOfRangeException(nameof(logLevel))
            // @formatter: on
        }
        : logLevel switch
        {
            // @formatter: off
            LogLevel.Trace       => ("""""", ConsoleColor.Cyan),
            LogLevel.Debug       => ("""""", ConsoleColor.DarkCyan),
            LogLevel.Information => (""" """, ConsoleColor.Gray),
            LogLevel.Warning     => ("""""", ConsoleColor.Yellow),
            LogLevel.Error       => ("""""", ConsoleColor.Red),
            LogLevel.Critical    => ("""""", ConsoleColor.Magenta),
            _                    => throw new ArgumentOutOfRangeException(nameof(logLevel))
            // @formatter: on
        };

    private static string GetForegroundColorEscapeCode(ConsoleColor color) =>
        ConsoleFeatures.NoColor
        ? ""
        : color switch
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
            _ => DefaultForegroundColorCodeEscapeCode // default foreground color
            // @formatter: on
        };

    private static string GetDefaultForegroundColorEscapeCode() =>
        ConsoleFeatures.NoColor
        ? ""
        : DefaultForegroundColorCodeEscapeCode;

    private const string DefaultForegroundColorCodeEscapeCode = "\x1B[39m\x1B[22m"; // reset to default foreground color

    #endregion
}

file static class ConsoleFeatures
{
    public static bool NoColor { get; }

    static ConsoleFeatures()
    {
        bool enabled = !Console.IsOutputRedirected;

        if (enabled)
        {
            // We subscribe to the informal standard from https://no-color.org/.  If we'd otherwise emit
            // ANSI color codes but the NO_COLOR environment variable is set, disable emitting them.
            enabled = GetEnvironmentVariable("NO_COLOR") is null;
        }
        else
        {
            // We also support overriding in the other direction.  If we'd otherwise avoid emitting color
            // codes but the DOTNET_SYSTEM_CONSOLE_ALLOW_ANSI_COLOR_REDIRECTION environment variable is
            // set to 1 or true, enable color.
            string? envVar = GetEnvironmentVariable("DOTNET_SYSTEM_CONSOLE_ALLOW_ANSI_COLOR_REDIRECTION");
            enabled = envVar is not null && (envVar == "1" || envVar.Equals("true", StringComparison.OrdinalIgnoreCase));
        }

        NoColor = !enabled;
    }
}
