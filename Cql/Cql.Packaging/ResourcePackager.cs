/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging;

internal class ResourcePackager(
    TypeResolver typeResolver,
    ResourceCanonicalBuilder resourceCanonicalBuilder)
{
    private readonly CqlTypeToFhirTypeMapper _cqlTypeToFhirTypeMapper = new(typeResolver);

    public readonly record struct InputArtifacts
    (
        string CqlString,
        ElmLibrary ElmLibrary,
        string CSharpSourceCode,
        byte[] AssemblyBinary,
        byte[]? DebugSymbols);

    public IEnumerable<(string libraryIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure)> PackageEachElmLibraryToFhirResources(
        ElmLibrarySet librarySet,
        Func<string, InputArtifacts> inputsById,
        SysDateTime? overrideDate = null,
        BatchProcessExceptionHandlingStrategyBuilder<ElmLibrary>? buildExceptionHandlingStrategy = null,
        Action<ElmLibrary>? onNextLibrary = null)
    {
        return librarySet.TrySelect(PackageResource, buildExceptionHandlingStrategy);

        (string versionedIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure) PackageResource(ElmLibrary elmLibrary)
        {
            onNextLibrary?.Invoke(elmLibrary);

            string versionedIdentifier = elmLibrary.VersionedLibraryIdentifier;
            var localOverrideDate = overrideDate ?? SysDateTime.Now;
            var (cqlString, elmLibraryInput, cSharpSourceCode, assemblyBinary, debugSymbols) = inputsById(versionedIdentifier);
            if (versionedIdentifier != elmLibraryInput.VersionedLibraryIdentifier) throw new InvalidOperationException("Versioned identifiers do not match.");

            var fhirLibrary = FhirLibrary.Create(
                _cqlTypeToFhirTypeMapper,
                elmLibrary,
                null,
                Encoding.Default.GetBytes(cqlString),
                assemblyBinary,
                debugSymbols,
                GetCSharpSourceCodeByName(),
                librarySet,
                resourceCanonicalBuilder,
                localOverrideDate);

            IEnumerable<KeyValuePair<string, string>>? GetCSharpSourceCodeByName()
            {
                yield return KeyValuePair.Create(versionedIdentifier, cSharpSourceCode);
            }

            fhirLibrary.TryCreateMeasure(elmLibrary,
                          out var fhirMeasure,
                          resourceCanonicalBuilder, localOverrideDate);
            return (versionedIdentifier, fhirLibrary, fhirMeasure);
        }
    }

    internal static string BuildResourceUrl(
        string resourceCanonicalRootUrl,
        string resourceType,
        string name,
        string? version = null)
    {
        string includeVersionString = string.IsNullOrEmpty(version) ? string.Empty : $"|{version}";
        string includeIdMaybeVersion = $"{resourceCanonicalRootUrl}{resourceType}/{name}{includeVersionString}";
        return includeIdMaybeVersion;
    }
}