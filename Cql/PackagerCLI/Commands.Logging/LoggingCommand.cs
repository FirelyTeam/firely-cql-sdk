/*
 * Copyright(c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Commands.Logging;

[UsedImplicitly]
public record LoggingCommand(
    bool? LogAppend,
    LogLevel? ConsoleLogLevel,
    LogLevel? FileLogLevel) {

    public static readonly Option[] Options =
    [
        Option<bool>(
            "--log-append",
            """
            Append to existing log file, instead of clearing
            """),

        Option<LogLevel?>(
            "--console-log-level",
            """
            The minimum log level to output to the console
            """),

        Option<LogLevel>(
            "--file-log-level",
            """
            The minimum log level to output to file
            """),
    ];

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (LogAppend, [LoggingOptions.ConfigSection, nameof(LoggingOptions.Append)]),
        (ConsoleLogLevel, [LoggingOptions.ConfigSection, nameof(LoggingOptions.ConsoleLogLevel)]),
        (FileLogLevel, [LoggingOptions.ConfigSection, nameof(LoggingOptions.FileLogLevel)]),
    ];
}