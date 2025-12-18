using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir.Serialization.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Validation;

namespace Hl7.Cql.Packaging.Internal;

/// <summary>
/// Provides utility methods for loading, extracting, and processing FHIR Library resources and their dependencies. 
/// </summary>
/// <remarks>This static class includes methods to load FHIR libraries from files, resolve dependencies, and
/// extract specific content such as CQL source, ELM JSON, and assembly binaries from FHIR Library resources. The
/// utilities are designed to support scenarios involving Clinical Quality Language (CQL) and FHIR-based library
/// management. All members are thread-safe and intended for use in applications that process FHIR Library
/// artifacts.</remarks>
[EditorBrowsable(EditorBrowsableState.Advanced)]
public static partial class FhirLibraryUtilities
{
    /// <summary>
    /// Loads a FHIR Library and all of its transitive dependencies, returning each as a deserialized FhirLibrary
    /// instance.
    /// </summary>
    /// <remarks>The returned libraries are traversed in pre-order, starting from the specified root library.
    /// Each library is loaded only once, even if referenced multiple times. Related libraries are discovered via the
    /// RelatedArtifact property of each FhirLibrary. This method does not guarantee any particular order beyond
    /// pre-order traversal.</remarks>
    /// <param name="logger">The logger to use for diagnostic and debug output during the loading process.</param>
    /// <param name="libraryIdentifier">The identifier of the root FHIR Library to load, including its name and version.</param>
    /// <param name="fhirFileResolver">A delegate that resolves a CqlVersionedLibraryIdentifier to the corresponding FHIR Library file on disk.</param>
    /// <param name="filePredicate">An optional predicate to filter which files should be loaded. If specified, only files for which the predicate
    /// returns <see langword="true"/> are included.</param>
    /// <param name="configureJsonSerializerOptions">An optional delegate to configure the JsonSerializerOptions used when deserializing FHIR Library files.</param>
    /// <returns>An enumerable collection of FhirLibrary instances representing the root library and all libraries referenced by
    /// it, directly or indirectly. The collection is empty if the root library cannot be found.</returns>
    /// <exception cref="InvalidOperationException">Thrown if a FHIR Library file is found but cannot be loaded or deserialized. See the inner exception for
    /// details.</exception>
    /// <exception cref="FileNotFoundException">Thrown if a required FHIR Library file does not exist at the resolved path.</exception>
    public static IEnumerable<FhirLibrary> LoadFhirLibraryAndDependencies(
        ILogger logger,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        ResourceFileInfoResolver fhirFileResolver,
        Func<FileInfo, bool>? filePredicate = null,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null)
    {
        HashSet<string> resourceIds = new();

        return Compiler.Infrastructure.Graphs.Traversal.PreOrder(
                           default(FhirLibrary),
                           GetDirectDependencies)
                       .OfType<FhirLibrary>();

        IEnumerable<FhirLibrary> GetDirectDependencies(FhirLibrary? fhirLib)
        {
            if (fhirLib is null)
            {
                if (LoadFhirLibraryFromIdentifier(libraryIdentifier) is { } fhirLibRoot)
                {
                    yield return fhirLibRoot;
                }
            }
            else
            {
                var relatedResources = GetRelatedResources(fhirLib);
                var relatedLibraryIds = ParseResourceToLibraryIds(relatedResources);
                foreach (var libraryId in relatedLibraryIds)
                {
                    if (LoadFhirLibraryFromIdentifier(libraryId) is { } lib)
                    {
                        yield return lib;
                    }
                }
            }
        }

        CqlVersionedLibraryIdentifier? ParseResourceToLibrary(string resource)
        {
            var m = FhirLibraryResourceRegex().Match(resource);
            if (m.Success)
            {
                var resourceType = m.Groups[1].Value;    // "Library"
                var libraryName = m.Groups[2].Value;           // "NCQAAdvancedIllnessandFrailty"
                var version = m.Groups[3].Success ? m.Groups[3].Value : null; // "1.0.0" or null
                if (resourceType == "Library")
                {
                    return CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(libraryName, version);
                }
            }
            logger.LogDebug("Resource '{resource}' is not parsable into a library identifier.", resource);
            return null;
        }

        IEnumerable<CqlVersionedLibraryIdentifier> ParseResourceToLibraryIds(IEnumerable<string> resources)
        {
            foreach (var resource in resources)
            {
                if (ParseResourceToLibrary(resource) is { } id)
                {
                    yield return id;
                }
            }
        }

        IEnumerable<string> GetRelatedResources(FhirLibrary library)
        {
            foreach (var relatedArtifact in library.RelatedArtifact ?? [])
            {
                var resource = relatedArtifact.Resource;
                if (!string.IsNullOrEmpty(resource))
                {
                    if (resourceIds.Add(resource))
                    {
                        // Example resource: https://fire.ly/fhir/Library/NCQAAdvancedIllnessandFrailty|1.0.0
                        yield return resource;
                    }
                    else
                    {
                        logger.LogDebug("Library '{lib}' related resource '{resource}' skipped, loaded already.", library.Name, resource);
                    }
                }
            }
        }

        FhirLibrary? LoadFhirLibraryFromIdentifier(CqlVersionedLibraryIdentifier identifier)
        {
            var file = ResolveResourceFileInfo(identifier);
            if (file is null)
                return null; // Skipped

            try
            {
                var fhirLibrary = LoadFhirLibraryFromFileInfo(file, configureJsonSerializerOptions);
                return fhirLibrary;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Could not load library '{identifier}' from file `{file}`. See InnerException for details.", e);
            }
        }

        FileInfo? ResolveResourceFileInfo(CqlVersionedLibraryIdentifier identifier)
        {
            var file = fhirFileResolver(identifier);
            var shouldInclude = filePredicate?.Invoke(file) ?? true;
            if (shouldInclude)
            {
                if (!file.Exists)
                    throw new FileNotFoundException($"No file exists '{file}' for FHIR library '{identifier}'.", file.FullName);
                return file;
            }
            logger.LogDebug("Skipped loading file '{file}' by predicate.", file);
            return null;
        }
    }

    // Regex to extract "Library", "NCQAAdvancedIllnessandFrailty", and optional "1.0.0" from resource string
    // Example: https://fire.ly/fhir/Library/NCQAAdvancedIllnessandFrailty|1.0.0
    /// <summary>
    /// Regex to extract the resource type, library name, and optional version from a FHIR Library resource string.
    ///
    /// Capture groups:
    ///   1. <b>resourceType</b>: The FHIR resource type (e.g., "Library").
    ///   2. <b>libraryName</b>: The name of the library (e.g., "NCQAAdvancedIllnessandFrailty").
    ///   3. <b>version</b> (optional): The version of the library (e.g., "1.0.0").
    ///
    /// Examples of valid input strings and their capture groups:
    ///   - <c>https://fire.ly/fhir/Library/NCQAAdvancedIllnessandFrailty|1.0.0</c>
    ///       1 = "Library", 2 = "NCQAAdvancedIllnessandFrailty", 3 = "1.0.0"
    ///   - <c>/Library/SomeLibrary|2.3.4</c>
    ///       1 = "Library", 2 = "SomeLibrary", 3 = "2.3.4"
    ///   - <c>/Library/AnotherLibrary</c>
    ///       1 = "Library", 2 = "AnotherLibrary", 3 = null
    ///   - <c>https://example.com/fhir/Library/MyLib</c>
    ///       1 = "Library", 2 = "MyLib", 3 = null
    /// </summary>
    [GeneratedRegex(@"\/([A-Za-z]+)\/([^|\/]+)(?:\|([0-9A-Za-z\.\-\+]+))?$")]
    private static partial Regex FhirLibraryResourceRegex();

    /// <summary>
    /// Loads a FHIR library from the specified file.
    /// </summary>
    /// <param name="file">The file to load the FHIR library from.</param>
    /// <param name="configureJsonSerializerOptions">Optional mutator to configure JSON serializer options.</param>
    /// <returns>The loaded FHIR library.</returns>
    public static FhirLibrary LoadFhirLibraryFromFileInfo(
        FileInfo file,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null)
    {
        configureJsonSerializerOptions += opt =>
        {
            opt.Ignoring([CodedValidationException.LITERAL_INVALID_CODE]);
            return opt;
        };
        using var fs = file.OpenRead();
        return fs.DeserializeJsonToFhir<FhirLibrary>(configureJsonSerializerOptions);
    }

    /// <summary>
    /// Extracts the assembly binary from the specified FHIR library.
    /// </summary>
    /// <param name="library">The FHIR library to extract the assembly binary from.</param>
    /// <returns>The extracted assembly binary.</returns>
    public static AssemblyBinary ExtractAssemblyBinary(FhirLibrary library)
    {
        var attachment = library.Content.Single(AttachmentHasDll);
        var assemblyBinary = new AssemblyBinary(attachment.Data);
        return assemblyBinary;

        bool AttachmentHasDll(Attachment att) =>
            att is
            {
                ContentType: "application/octet-stream",
                ElementId: { } eid
            } && eid.EndsWith("+dll");
    }

    /// <summary>
    /// Extracts the Clinical Quality Language (CQL) source text from the specified FHIR Library resource.
    /// </summary>
    /// <remarks>If the library contains multiple attachments with a content type of "text/cql", only the
    /// first one is used. The method assumes the CQL content is encoded in UTF-8.</remarks>
    /// <param name="library">The FHIR Library resource containing CQL content as an attachment. Must not be null and must contain at least
    /// one attachment with a content type of "text/cql".</param>
    /// <returns>A string containing the CQL source text extracted from the library's attachment.</returns>
    public static string ExtractCqlFromFhirLibrary(FhirLibrary library)
    {
        var attachment = library.Content.Single(AttachmentHasCql);
        var cql = System.Text.Encoding.UTF8.GetString(attachment.Data!);
        return cql;

        bool AttachmentHasCql(Attachment att) =>
            att is
            {
                ContentType: "text/cql",
                //ElementId: { } eid
            } /*&& eid.EndsWith("+cql")*/;
    }

    /// <summary>
    /// Extracts the ELM JSON content from the specified FHIR Library resource.
    /// </summary>
    /// <remarks>If the library contains multiple attachments with the ELM JSON content type, only the first
    /// one is extracted. Throws an exception if no such attachment is found.</remarks>
    /// <param name="library">The FHIR Library resource containing the ELM JSON attachment to extract. Cannot be null and must contain at
    /// least one attachment with a content type of "application/elm+json".</param>
    /// <returns>A string containing the ELM JSON content extracted from the library's attachment.</returns>
    public static string ExtractElmJsonFromFhirLibrary(FhirLibrary library)
    {
        var attachment = library.Content.Single(AttachmentHasElmJson);
        var elmJson = System.Text.Encoding.UTF8.GetString(attachment.Data!);
        return elmJson;

        bool AttachmentHasElmJson(Attachment att) =>
            att is
            {
                ContentType: "application/elm+json",
                //ElementId: { } eid
            } /*&& eid.EndsWith("+elm.json")*/;
    }
}