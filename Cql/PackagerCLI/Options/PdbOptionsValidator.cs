using Hl7.Cql.CodeGeneration.NET;

namespace Hl7.Cql.Packager.Options;

public sealed class PdbOptionsValidator(
    ILogger<PdbOptionsValidator> logger)
{
    public int GetExitCodeForInvalidPdbConfiguration(
        AssemblyCompilerDebugInformationFormat? debugInformationFormat,
        DirectoryInfo? pdbDir,
        DirectoryInfo? dllDir,
        DirectoryInfo? fhirDir)
    {
        switch (debugInformationFormat, pdbDir, dllDir, fhirDir)
        {
            case (not AssemblyCompilerDebugInformationFormat.PortablePdb, { }, _, _):
                logger.LogInformation("Exiting. If --pdb is specified, then --debug-symbols must be PortablePdb.");
                return ExitCode.PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb;
            case (AssemblyCompilerDebugInformationFormat.PortablePdb, { }, null, _):
                logger.LogInformation("Exiting. If --pdb is specified, then --dll is required.");
                return ExitCode.DllDirIsRequiredWhenPdbDirIsSpecified;
            case (AssemblyCompilerDebugInformationFormat.PortablePdb, null, _, null):
                logger.LogInformation("Exiting. If --debug-symbols is PortablePdb, then (--dll with --pdb) or (--fhir) must be specified.");
                return ExitCode.PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb;
            default:
                return ExitCode.Normal;
        }
    }
}