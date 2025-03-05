using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

partial class InvocationToolkitExtensions
{
    /// <summary>
    /// Adds the assemblies contained inside FHIR libraries from the specified directory to the invocation toolkit.
    /// </summary>
    /// <param name="invocationToolkit">The invocation toolkit to add the FHIR libraries to.</param>
    /// <param name="directory">The directory containing the FHIR library files.</param>
    /// <param name="options">Optional enumeration options for directory enumeration.</param>
    /// <param name="filePredicate">Optional predicate to filter files.</param>
    /// <returns>The updated invocation toolkit with the added FHIR libraries.</returns>
    public static InvocationToolkit AddAssemblyBinariesInFhirLibrariesFromDirectory(
        this InvocationToolkit invocationToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var logger = invocationToolkit.LoggerFactory.CreateLogger(typeof(InvocationToolkitExtensions));
        var files =
                directory
                    .EnumerateFiles("Library-*.json", options ?? Defaults.EnumerationOptions)
            ;

        if (filePredicate is not null)
            files = files
                    .Where(filePredicate)
                    .ToList();

        var assemblyBinaries = files
                               .TrySelect(FhirLibraryUtilities.LoadFhirLibrary,
                                   s => s
                                        .SetContinuation(invocationToolkit.BatchProcessExceptionContinuation)
                                        .AddLoggerExceptionHandler(
                                            logger, (fileInfo, logMessage) => logMessage("Could not load FHIR library resource from file: {file}", fileInfo)))
                               .TrySelect(FhirLibraryUtilities.ExtractAssemblyBinary,
                                   s => s
                                        .SetContinuation(invocationToolkit.BatchProcessExceptionContinuation)
                                        .AddLoggerExceptionHandler(
                                            logger,
                                            (fhirLibrary, logMessage) =>
                                                logMessage("Could not extract assembly binary from FHIR library resource: {id}",
                                                           CqlVersionedLibraryIdentifier.ParseFromNameAndVersion(fhirLibrary.Name, fhirLibrary.Version))))
                               .ToList()
            ;

        return invocationToolkit.AddAssemblyBinaries(assemblyBinaries);
    }
}

file static class FhirLibraryUtilities
{
    /// <summary>
    /// Loads a FHIR library from the specified file.
    /// </summary>
    /// <param name="file">The file to load the FHIR library from.</param>
    /// <returns>The loaded FHIR library.</returns>
    public static FhirLibrary LoadFhirLibrary(FileInfo file)
    {
        using var fs = file.OpenRead();
        return fs.DeserializeJsonToFhir<FhirLibrary>();
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