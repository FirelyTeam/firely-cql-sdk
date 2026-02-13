/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager;

/// <summary>
/// Contains string constants for exit code messages used in command help text.
/// Each message includes the exit code number and description for direct use in help text.
/// </summary>
internal static class ExitCodeMessages
{
    public const string Normal = "0  - Success";
    public const string NoCqlLibsInDir = "1  - No CQL libraries found in the CQL input directory";
    public const string NoElmLibsInDir = "2  - No ELM libraries found in the ELM input directory";
    public const string NoElmLibsCompiled = "3  - No ELM libraries compiled";
    public const string CantPackageNoCqlElmMatches = "4  - Cannot package: No matching CQL-ELM pairs found";
    public const string NoOutputDirs = "5  - No output directories specified";
    public const string NoCqlDirRequiredForFhir = "6  - CQL directory is required when FHIR output is requested";
    public const string LibraryExtractionError = "10 - Library extraction error occurred";
    public const string NoInputFiles = "11 - No input files specified or one or more input files do not exist";
    public const string InvalidLibraryJson = "12 - Invalid library JSON";
    public const string InvalidLibraryJsonOrMissingProperties = "12 - Invalid library JSON or missing required library properties (Name, Version)";
    public const string NoCqlLibsInDirWhenFhirRequested = "13 - No CQL libraries found in the CQL input directory (when FHIR output is requested)";
    public const string UnknownError = "99 - Unknown error occurred during processing";
}
