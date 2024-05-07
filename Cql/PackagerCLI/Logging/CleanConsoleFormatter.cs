/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Hl7.Cql.Abstractions.Infrastructure;
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

internal sealed partial class CleanConsoleFormatter : ConsoleFormatter
{
    private readonly IOptionsMonitor<CleanConsoleFormatterOptionsInternal> _optionsMonitor;
    public const string FormatterName = "NoCategory";

    public CleanConsoleFormatter(
        IOptionsMonitor<CleanConsoleFormatterOptionsInternal> optionsMonitor) : base(FormatterName) =>
        _optionsMonitor = optionsMonitor;

    public override void Write<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider? scopeProvider, TextWriter textWriter)
    {
        var message = GetFormatterMessage(logEntry);
        var (logLevelText, logLevelConsoleColor) = GetLogLevelString(logEntry.LogLevel);
        var (escLogLevelForegroundColor, escDefaultForegroundColor) =
            NoColor
                ? ("", "")
                : (GetForegroundColorEscapeCode(logLevelConsoleColor), DefaultForegroundColor);
        textWriter.WriteLine($"____\n{escLogLevelForegroundColor}{logLevelText.ToUpperInvariant()}{escDefaultForegroundColor}: {message}");
        if (logEntry.Exception is not null)
            textWriter.WriteLine(logEntry.Exception.ToString());
    }

    private bool NoColor => _optionsMonitor.CurrentValue.Options.NoColor;

    [GeneratedRegex("""\{(?<tagName>[^:,}]+)(?<rest>[^}]*)\}""", RegexOptions.Compiled)]
    private static partial Regex ExtractTagsRegex();



    private string GetFormatterMessage<TState>(LogEntry<TState> logEntry)
    {
        if (NoColor)
        {
            var noColorMessage = logEntry.Formatter(logEntry.State, logEntry.Exception);
            return noColorMessage;
        }

        var state = (IReadOnlyCollection<KeyValuePair<string, object?>>)logEntry.State!;
        var last = state.Last();
        Debug.Assert(last.Key == "{OriginalFormat}");
        var originalFormat = (string)last.Value!;

        if (state.Count == 1)
            return originalFormat; // Nothing to format, return as is

        var colorFormat = GetOrdinalStringFormat(state, originalFormat);
        var colorMessage = string.Format(CultureInfo.InvariantCulture, colorFormat, state.SelectToArray(s => s.Value));
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
                    {
                        bool isString = kv.val is string or StringBuilder or StringWriter;
                        var foregroundColorEscapeCode = GetForegroundColorEscapeCode(isString ? ConsoleColor.Cyan : ConsoleColor.Magenta);
                        return $"{foregroundColorEscapeCode}{{{kv.i}{rest}}}{DefaultForegroundColor}";
                    }
                    return m.Value;
                });

                return finalFormat;
            });

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