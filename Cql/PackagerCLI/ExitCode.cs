/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager;

internal static class ExitCode
{
    public const int Normal = 0;
    public const int NoCqlLibsInDir = 1;
    public const int NoElmLibsInDir = 2;
    public const int NoElmLibsCompiled = 3;
    public const int CantPackageNoCqlElmMatches = 4;
    public const int NoOutputDirs = 5;
    public const int NoCqlDirRequiredForFhir = 6;
    public const int PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb = 7;
    public const int DllDirIsRequiredWhenPdbDirIsSpecified = 8;
    public const int PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb = 9;
    public const int LibraryExtractionError = 10;
}