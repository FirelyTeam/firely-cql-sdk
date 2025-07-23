/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;

namespace Hl7.Cql.Packager.Options;

public sealed class PdbOptionsValidator(
    ILogger<PdbOptionsValidator> logger)
{
    public int GetExitCodeForInvalidPdbConfiguration(
        DebugSymbolsFormat? debugInformationFormat,
        DirectoryInfo? pdbDir,
        DirectoryInfo? dllDir,
        DirectoryInfo? fhirDir)
    {
        switch (debugInformationFormat, pdbDir, dllDir, fhirDir)
        {
            case (not DebugSymbolsFormat.PortablePdb, { }, _, _):
                logger.LogInformation("Exiting. If --pdb is specified, then --debug-symbols must be PortablePdb.");
                return ExitCode.PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb;
            case (DebugSymbolsFormat.PortablePdb, { }, null, _):
                logger.LogInformation("Exiting. If --pdb is specified, then --dll is required.");
                return ExitCode.DllDirIsRequiredWhenPdbDirIsSpecified;
            case (DebugSymbolsFormat.PortablePdb, null, _, null):
                logger.LogInformation("Exiting. If --debug-symbols is PortablePdb, then (--dll with --pdb) or (--fhir) must be specified.");
                return ExitCode.PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb;
            default:
                return ExitCode.Normal;
        }
    }
}