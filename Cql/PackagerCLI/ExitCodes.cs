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
        public const string Message = "0 - Success";
    }

    internal static class NoCqlLibsInDir
    {
        public const int Code = 1;
        public const string Message = "1  - No CQL libraries found in the CQL input directory";
    }

    internal static class NoElmLibsInDir
    {
        public const int Code = 2;
        public const string Message = "2  - No ELM libraries found in the ELM input directory";
    }

    internal static class NoElmLibsCompiled
    {
        public const int Code = 3;
        public const string Message = "3  - No ELM libraries compiled";
    }

    internal static class CantPackageNoCqlElmMatches
    {
        public const int Code = 4;
        public const string Message = "4  - Cannot package: No matching CQL-ELM pairs found";
    }

    internal static class NoOutputDirs
    {
        public const int Code = 5;
        public const string Message = "5  - No output directories specified";
    }

    internal static class NoCqlDirRequiredForFhir
    {
        public const int Code = 6;
        public const string Message = "6  - CQL directory is required when FHIR output is requested";
    }

    internal static class PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb
    {
        public const int Code = 7;
        public const string Message = "7  - If --pdb is specified, then --debug-symbols must be PortablePdb";
    }

    internal static class DllDirIsRequiredWhenPdbDirIsSpecified
    {
        public const int Code = 8;
        public const string Message = "8  - If --pdb is specified, then --dll is required";
    }

    internal static class PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb
    {
        public const int Code = 9;
        public const string Message = "9  - If --debug-symbols is PortablePdb, then (--dll with --pdb) or (--fhir) must be specified";
    }

    internal static class LibraryExtractionError
    {
        public const int Code = 10;
        public const string Message = "10 - Library extraction error occurred";
    }

    internal static class NoInputFiles
    {
        public const int Code = 11;
        public const string Message = "11 - No input files specified or one or more input files do not exist";
    }

    internal static class InvalidLibraryJson
    {
        public const int Code = 12;
        public const string Message = "12 - Invalid library JSON";
    }

    internal static class NoCqlLibsInDirWhenFhirRequested
    {
        public const int Code = 13;
        public const string Message = "13 - No CQL libraries found in the CQL input directory (when FHIR output is requested)";
    }

    internal static class InvalidLibraryMissingNameOrVersion
    {
        public const int Code = 14;
        public const string Message = "14 - Invalid FHIR library, missing required Name and Version";
    }

    internal static class LibraryMissingName
    {
        public const int Code = 15;
        public const string Message = "15 - FHIR Library must have a Name property";
    }

    internal static class NoCqlLibsConvertedToElm
    {
        public const int Code = 16;
        public const string Message = "16 - No CQL libraries converted to ELM";
    }

    internal static class UnknownError
    {
        public const int Code = 99;
        public const string Message = "99 - Unknown error occurred during processing";
    }
}