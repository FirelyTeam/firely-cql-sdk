/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packager.Logging;

internal static class CleanConsoleLoggingExtensions
{
    public static void AddCleanConsole(
        this ILoggingBuilder logging,
        Action<CleanConsoleFormatterOptions> configure) =>
        logging
            .AddConsole(opt => opt.FormatterName = CleanConsoleFormatter.FormatterName)
            .AddConsoleFormatter<CleanConsoleFormatter, CleanConsoleFormatterOptionsInternal>(opt => configure.Invoke(opt.Options));

}