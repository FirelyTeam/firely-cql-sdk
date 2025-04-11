/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Commands.CqlToFhir;

public class CqlToFhirOptions : IBindOptions
{
    public const string ConfigSection = "CqlToElm";
    static string IBindOptions.ConfigSection => ConfigSection;

    public required DirectoryInfo Cql { get; set; }
    public DirectoryInfo? Elm { get; set; }
    public DirectoryInfo? Cs { get; set; }
    public DirectoryInfo? Dll { get; set; }
    public required DirectoryInfo? Fhir { get; set; }
    public bool JsonPretty { get; set; }
}