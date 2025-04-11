/*
 * Copyright(c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;

namespace Hl7.Cql.Packager.Options;

internal record ElmOptions : ElmToolkitConfig, IOptionsEx
{
    public const string ConfigSection = "Elm";
    static string IOptionsEx.ConfigSection => ConfigSection;

    public string[] SkipFiles { get; init; } = [];
}