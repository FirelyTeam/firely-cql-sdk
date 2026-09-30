/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Concurrent;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
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
        Action<ElmLibrary>? onNextLibrary = null,
        string? measureGroupCodeSystem = null)
    {
        // Materialized once, single-threaded: this is also what forces ElmLibrarySet's internal
        // dependency graph (topological sort, root libraries) to be computed. That computation is
        // lazy and not thread-safe, so it must happen here rather than racing across the
        // Parallel.ForEach below the first time each library's dependencies are queried.
        var libraries = librarySet.ToList();

        // Packaging a single library (data requirements analysis, related-artifact/measure
        // construction, JSON-attachment building) is CPU-bound and otherwise independent per
        // library -- it only reads the shared, now-warmed-up, librarySet. Large library sets
        // (e.g. 400+ HEDIS measure/shared libraries) previously packaged one library at a time,
        // which made this step one of the most expensive parts of the overall packaging run;
        // compiling independent libraries' resources in parallel lets it scale with available
        // cores instead.
        var results = new ConcurrentDictionary<CqlVersionedLibraryIdentifier, (FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure)>();
        var failures = new ConcurrentDictionary<CqlVersionedLibraryIdentifier, ExceptionDispatchInfo>();

        Parallel.ForEach(libraries, elmLibrary =>
        {
            onNextLibrary?.Invoke(elmLibrary);
            try
            {
                results[elmLibrary.VersionedLibraryIdentifier] = PackageResource(elmLibrary);
            }
            catch (Exception ex)
            {
                failures[elmLibrary.VersionedLibraryIdentifier] = ExceptionDispatchInfo.Capture(ex);
            }
        });

        return libraries.TrySelect(
            elmLibrary =>
            {
                var identifier = elmLibrary.VersionedLibraryIdentifier;
                if (failures.TryGetValue(identifier, out var edi))
                    edi.Throw();
                var (fhirLibrary, fhirMeasure) = results[identifier];
                return (versionedIdentifier: (string)identifier, fhirLibrary, fhirMeasure);
            },
            buildExceptionHandlingStrategy);

        (FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure) PackageResource(ElmLibrary elmLibrary)
        {
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
                          resourceCanonicalBuilder, localOverrideDate,
                          measureGroupCodeSystem);
            return (fhirLibrary, fhirMeasure);
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