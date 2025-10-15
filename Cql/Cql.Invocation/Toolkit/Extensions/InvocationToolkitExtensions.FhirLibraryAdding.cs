/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir.Serialization.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Validation;
using System.Text.Json;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

partial class InvocationToolkitExtensions
{
    /// <summary>
    /// Adds the assemblies contained inside FHIR libraries from the specified directory to the invocation toolkit.
    /// </summary>
    /// <param name="invocationToolkit">The invocation toolkit to add the FHIR libraries to.</param>
    /// <param name="directory">The directory containing the FHIR library files.</param>
    /// <param name="configureJsonSerializerOptions">Optional mutator to configure JSON serializer options.</param>
    /// <param name="options">Optional enumeration options for directory enumeration.</param>
    /// <param name="filePredicate">Optional predicate to filter files.</param>
    /// <returns>The updated invocation toolkit with the added FHIR libraries.</returns>
    public static InvocationToolkit AddAssemblyBinariesInFhirLibrariesFromDirectory(
        this InvocationToolkit invocationToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null)
    {
        var logger = invocationToolkit.LoggerFactory.CreateLogger(typeof(InvocationToolkitExtensions));
        var files = directory.EnumerateFiles("Library-*.json", options ?? Defaults.EnumerationOptions);

        if (filePredicate is not null)
            files = files
                    .Where(filePredicate)
                    .ToList();

        var assemblyBinaries = files
                               .TrySelect(info => FhirLibraryUtilities.LoadFhirLibraryFromFileInfo(info, configureJsonSerializerOptions),
                                          s => s
                                               .SetContinuation(invocationToolkit.BatchProcessExceptionContinuation)
                                               .AddLoggerExceptionHandler(
                                                   logger,
                                                   (fileInfo, logMessage) => logMessage("Could not load FHIR library resource from file: {file}", fileInfo)))
                               .TrySelect(FhirLibraryUtilities.ExtractAssemblyBinary,
                                          s => s
                                               .SetContinuation(invocationToolkit.BatchProcessExceptionContinuation)
                                               .AddLoggerExceptionHandler(
                                                   logger,
                                                   (fhirLibrary, logMessage) =>
                                                       logMessage("Could not extract assembly binary from FHIR library resource: {id}",
                                                                  CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(
                                                                      fhirLibrary.Name!, fhirLibrary.Version))))
                               .ToList()
            ;

        return invocationToolkit.AddAssemblyBinaries(assemblyBinaries);
    }

    /// <summary>
    /// Adds assembly binaries from a specified FHIR library and its dependencies to the <see cref="InvocationToolkit"/>.
    /// </summary>
    /// <param name="invocationToolkit">
    /// The <see cref="InvocationToolkit"/> instance to which the assembly binaries will be added.
    /// </param>
    /// <param name="libraryIdentifier">
    /// The identifier of the FHIR library, including its version, to load the assembly binaries from.
    /// </param>
    /// <param name="fhirFileResolver">
    /// A delegate that resolves the file information for a given FHIR library identifier.
    /// </param>
    /// <param name="filePredicate">
    /// An optional predicate to filter the files to be processed. If <c>null</c>, all files are processed.
    /// </param>
    /// <param name="configureJsonSerializerOptions">
    /// An optional mutator to configure the <see cref="JsonSerializerOptions"/> used during processing.
    /// </param>
    /// <returns>
    /// The updated <see cref="InvocationToolkit"/> instance with the added assembly binaries.
    /// </returns>
    /// <remarks>
    /// This method processes the specified FHIR library and its dependencies to extract assembly binaries.
    /// It applies the provided file predicate and JSON serializer configuration during the process.
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown if <paramref name="invocationToolkit"/>, <paramref name="libraryIdentifier"/>, or <paramref name="fhirFileResolver"/> is <c>null</c>.
    /// </exception>
    public static InvocationToolkit AddAssemblyBinariesFromFhirLibraryAndDependencies(
        this InvocationToolkit invocationToolkit,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        ResourceFileInfoResolver fhirFileResolver,
        Func<FileInfo, bool>? filePredicate = null,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null)
    {
        var logger = invocationToolkit.LoggerFactory.CreateLogger(typeof(InvocationToolkitExtensions));
        using var logScope = logger.BeginScope("Adding FHIR Library '{lib}' and Dependencies to InvocationToolkit", libraryIdentifier);

        var assemblyBinaries =
            FhirLibraryUtilities.LoadFhirLibraryAndDependencies(
                                    logger,
                                    libraryIdentifier,
                                    fhirFileResolver,
                                    filePredicate,
                                    configureJsonSerializerOptions)
                                .TrySelect(FhirLibraryUtilities.ExtractAssemblyBinary,
                                           s => s
                                                .SetContinuation(invocationToolkit.BatchProcessExceptionContinuation)
                                                .AddLoggerExceptionHandler(
                                                    invocationToolkit.LoggerFactory.CreateLogger(typeof(InvocationToolkitExtensions)),
                                                    (fhirLibrary, logMessage) =>
                                                        logMessage("Could not extract assembly binary from FHIR library resource: {id}",
                                                                   CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(
                                                                       fhirLibrary.Name!, fhirLibrary.Version))))
                                .ToList();
        return invocationToolkit.AddAssemblyBinaries(assemblyBinaries);
    }
}

internal static partial class FhirLibraryUtilities
{
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
                var resourceType = m.Groups[1].Value;                          // "Library"
                var libraryName = m.Groups[2].Value;                                 // "NCQAAdvancedIllnessandFrailty"
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
}