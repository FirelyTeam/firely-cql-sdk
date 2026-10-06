/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Packaging.Toolkit;
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

    /// <summary>Packages each library's FHIR resources.</summary>
    /// <remarks><paramref name="onNextLibrary"/> is invoked concurrently for libraries in arbitrary order.</remarks>
    public IEnumerable<(string libraryIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure)> PackageEachElmLibraryToFhirResources(
        ElmLibrarySet librarySet,
        Func<string, InputArtifacts> inputsById,
        SysDateTime? overrideDate = null,
        BatchProcessExceptionHandlingStrategyBuilder<ElmLibrary>? buildExceptionHandlingStrategy = null,
        Action<ElmLibrary>? onNextLibrary = null,
        string? measureGroupCodeSystem = null,
        ElmAttachmentFormatting elmAttachmentFormatting = ElmAttachmentFormatting.Passthrough)
    {
        // Materialized once, single-threaded: this is also what forces ElmLibrarySet's internal
        // dependency graph (topological sort, root libraries) to be computed. That computation is
        // lazy and not thread-safe, so it must happen here rather than racing across the
        // Parallel.ForEach below the first time each library's dependencies are queried.
        var libraries = librarySet.ToList();

        // Package each library in parallel after materializing the dependency graph.
        var results = new (FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure)?[libraries.Count];
        var failures = new ExceptionDispatchInfo?[libraries.Count];
        var parallelOptions = new ParallelOptions
        {
            MaxDegreeOfParallelism = Math.Min(4, Environment.ProcessorCount)
        };

        Parallel.For(0, libraries.Count, parallelOptions, index =>
        {
            var elmLibrary = libraries[index];
            try
            {
                onNextLibrary?.Invoke(elmLibrary);
                results[index] = PackageResource(elmLibrary);
            }
            catch (Exception ex)
            {
                failures[index] = ExceptionDispatchInfo.Capture(ex);
            }
        });

        return libraries.TrySelectToArray(
            (elmLibrary, index) =>
            {
                if (failures[index] is { } edi)
                    edi.Throw();
                var (fhirLibrary, fhirMeasure) = results[index]!.Value;
                return (versionedIdentifier: (string)elmLibrary.VersionedLibraryIdentifier, fhirLibrary, fhirMeasure);
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
                localOverrideDate,
                elmAttachmentFormatting);

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
}