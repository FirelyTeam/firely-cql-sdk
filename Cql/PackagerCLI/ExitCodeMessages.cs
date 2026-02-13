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
/// </summary>
internal static class ExitCodeMessages
{
    public const string Success = "Success";
    public const string NoCqlLibsInDir = "No CQL libraries found in the CQL input directory";
    public const string NoCqlLibsInDirWhenFhirRequested = "No CQL libraries found in the CQL input directory (when FHIR output is requested)";
    public const string NoElmLibsInDir = "No ELM libraries found in the ELM input directory";
    public const string NoElmLibsCompiled = "No ELM libraries compiled";
    public const string CantPackageNoCqlElmMatches = "Cannot package: No matching CQL-ELM pairs found";
    public const string NoOutputDirs = "No output directories specified";
    public const string NoCqlDirRequiredForFhir = "CQL directory is required when FHIR output is requested";
    public const string LibraryExtractionError = "Library extraction error occurred";
    public const string NoInputFiles = "No input files specified or one or more input files do not exist";
    public const string InvalidLibraryJson = "Invalid library JSON";
    public const string InvalidLibraryJsonOrMissingProperties = "Invalid library JSON or missing required library properties (Name, Version)";
    public const string UnknownError = "Unknown error occurred during processing";
}
