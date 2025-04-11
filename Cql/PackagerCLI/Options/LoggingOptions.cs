/*
 * Copyright(c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Options;

internal record LoggingOptions : IOptionsEx
{
    public const string ConfigSection = "Logging";
    static string IOptionsEx.ConfigSection => ConfigSection;

    public static LoggingOptions Default { get; } = new();

    public bool Debug { get; init; }
    public bool Append { get; init; }
}