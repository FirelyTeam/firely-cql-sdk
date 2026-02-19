/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager;

internal static class ExitCodes
{
    internal static class Success
    {
        public const int Code = 0;
        public const string Message = "Success";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class NoCqlLibsInDir
    {
        public const int Code = 1;
        public const string Message = "No CQL libraries found in the CQL input directory";
        public const string MessageWithPlaceholder = "No CQL libraries found in directory {Directory}";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
        public static string ExitingMessageWithPlaceholder => $"Exiting. {MessageWithPlaceholder}";
    }

    internal static class NoElmLibsInDir
    {
        public const int Code = 2;
        public const string Message = "No ELM libraries found in the ELM input directory";
        public const string MessageWithPlaceholder = "No ELM libraries found in directory {Directory}";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
        public static string ExitingMessageWithPlaceholder => $"Exiting. {MessageWithPlaceholder}";
    }

    internal static class NoElmLibsCompiled
    {
        public const int Code = 3;
        public const string Message = "No ELM libraries compiled";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class CantPackageNoCqlElmMatches
    {
        public const int Code = 4;
        public const string Message = "Cannot package: No matching CQL-ELM pairs found";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class NoOutputDirs
    {
        public const int Code = 5;
        public const string Message = "No output directories specified";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class NoCqlDirRequiredForFhir
    {
        public const int Code = 6;
        public const string Message = "CQL directory is required when FHIR output is requested";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb
    {
        public const int Code = 7;
        public const string Message = "If --pdb is specified, then --debug-symbols must be PortablePdb";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class DllDirIsRequiredWhenPdbDirIsSpecified
    {
        public const int Code = 8;
        public const string Message = "If --pdb is specified, then --dll is required";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb
    {
        public const int Code = 9;
        public const string Message = "If --debug-symbols is PortablePdb, then (--dll with --pdb) or (--fhir) or (--libraries with --measures) must be specified";
        public static string CodeWithMessage => $"{Code}  - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class LibraryExtractionError
    {
        public const int Code = 10;
        public const string Message = "Library extraction error occurred";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class NoInputFiles
    {
        public const int Code = 11;
        public const string Message = "No input files specified or one or more input files do not exist";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class InvalidLibraryJson
    {
        public const int Code = 12;
        public const string Message = "Invalid library JSON";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class NoCqlLibsInDirWhenFhirRequested
    {
        public const int Code = 13;
        public const string Message = "No CQL libraries found in the CQL input directory (when FHIR output is requested)";
        public const string MessageWithPlaceholder = "No CQL libraries found in directory {Directory} (when FHIR output is requested)";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
        public static string ExitingMessageWithPlaceholder => $"Exiting. {MessageWithPlaceholder}";
    }

    internal static class InvalidLibraryMissingNameOrVersion
    {
        public const int Code = 14;
        public const string Message = "Invalid FHIR library, missing required Name and Version";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class LibraryMissingName
    {
        public const int Code = 15;
        public const string Message = "FHIR Library must have a Name property";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class NoCqlLibsConvertedToElm
    {
        public const int Code = 16;
        public const string Message = "No CQL libraries converted to ELM";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class MixedFhirAndSpecificDirs
    {
        public const int Code = 17;
        public const string Message = "Cannot mix --fhir with --libraries or --measures";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class IncompleteLibrariesMeasuresDirs
    {
        public const int Code = 18;
        public const string Message = "Both --libraries and --measures must be specified together";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }

    internal static class UnknownError
    {
        public const int Code = 99;
        public const string Message = "Unknown error occurred during processing";
        public static string CodeWithMessage => $"{Code} - {Message}";
        public static string ExitingMessage => $"Exiting. {Message}";
    }
}