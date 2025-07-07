/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;

namespace Hl7.Cql.Packager.Commands.ElmToFhir;

internal record ElmToFhirOptions : IBindOptions
{
    public const string ConfigSection = "ElmToFhir";
    static string IBindOptions.ConfigSection => ConfigSection;

    public required DirectoryInfo? CqlInDir { get; set; }
    public required DirectoryInfo ElmInDir { get; set; }
    public DirectoryInfo? CSharpOutDir { get; set; }
    public DirectoryInfo? DllOutDir { get; set; }
    public DirectoryInfo? PdbOutDir { get; set; }
    public required DirectoryInfo? FhirOutDir { get; set; }
    public AssemblyCompilerDebugInformationFormat? DebugSymbols { get; set; }
}