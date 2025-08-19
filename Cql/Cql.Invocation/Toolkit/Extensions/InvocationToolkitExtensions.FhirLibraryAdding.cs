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
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Fhir.Utility;

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
                                                                      fhirLibrary.Name, fhirLibrary.Version))))
                               .ToList()
            ;

        return invocationToolkit.AddAssemblyBinaries(assemblyBinaries);
    }


    public static InvocationToolkit AddAssemblyBinariesFromFhirLibraryAndDependencies(
        this InvocationToolkit invocationToolkit,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        ResourceFileInfoFromIdentifierResolver fhirFileResolver,
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
                                                                       fhirLibrary.Name, fhirLibrary.Version))))
                                .ToList();
        return invocationToolkit.AddAssemblyBinaries(assemblyBinaries);
    }
}

public static partial class FhirLibraryUtilities
{
    public static IEnumerable<FhirLibrary> LoadFhirLibraryAndDependencies(
        ILogger logger,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        ResourceFileInfoFromIdentifierResolver fhirFileResolver,
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
                    throw new ArgumentException($"No file exists '{file}' for FHIR library '{identifier}'.");
                return file;
            }
            logger.LogDebug("Skipped loading file '{file}' by predicate.", file);
            return null;
        }
    }

    // Regex to extract "Library", "NCQAAdvancedIllnessandFrailty", and optional "1.0.0" from resource string
    // Example: https://fire.ly/fhir/Library/NCQAAdvancedIllnessandFrailty|1.0.0
    // Groups: 1=resourceType, 2=libraryName, 3=version (optional)
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
            opt.Ignoring([CodedValidationException.ID_LITERAL_INVALID_CODE]);
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