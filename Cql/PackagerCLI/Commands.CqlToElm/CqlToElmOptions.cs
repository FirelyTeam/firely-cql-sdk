/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Commands.CqlToElm;

public class CqlToElmOptions : IBindOptions
{
    public const string ConfigSection = "CqlToElm";
    static string IBindOptions.ConfigSection => ConfigSection;

    public required DirectoryInfo Cql { get; set; }

    public required DirectoryInfo Elm { get; set; }

    public bool JsonPretty { get; set; }
}