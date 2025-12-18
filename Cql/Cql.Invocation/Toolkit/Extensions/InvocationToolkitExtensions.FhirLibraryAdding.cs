/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;
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