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
        DirectoryInfo? fhirDir,
        DirectoryInfo? librariesDir,
        DirectoryInfo? measuresDir)
    {
        bool hasFhirOutput = fhirDir is not null || (librariesDir is not null && measuresDir is not null);

        switch (debugInformationFormat, pdbDir, dllDir, hasFhirOutput)
        {
            case (not DebugSymbolsFormat.PortablePdb, { }, _, _):
                logger.LogError(ExitCodes.PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb.ExitingMessage);
                return ExitCodes.PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb.Code;
            case (DebugSymbolsFormat.PortablePdb, { }, null, _):
                logger.LogError(ExitCodes.DllDirIsRequiredWhenPdbDirIsSpecified.ExitingMessage);
                return ExitCodes.DllDirIsRequiredWhenPdbDirIsSpecified.Code;
            case (DebugSymbolsFormat.PortablePdb, null, _, false):
                logger.LogError(ExitCodes.PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb.ExitingMessage);
                return ExitCodes.PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb.Code;
            default:
                return ExitCodes.Success.Code;
        }
    }
}
