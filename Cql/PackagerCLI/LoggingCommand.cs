/*
 * Copyright(c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager;

[UsedImplicitly]
public record LoggingCommand(
    bool? LogDebug,
    bool? LogAppend) {

    public static readonly Option[] Options =
    [
        Option<bool>("--log-debug", "Debug-level logging"),
        Option<bool>("--log-append", "Append to existing log file, instead of clearing"),
    ];

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (LogDebug, [Packager.Options.LoggingOptions.ConfigSection, nameof(Packager.Options.LoggingOptions.Debug)]),
        (LogAppend, [Packager.Options.LoggingOptions.ConfigSection, nameof(Packager.Options.LoggingOptions.Append)])
    ];
}