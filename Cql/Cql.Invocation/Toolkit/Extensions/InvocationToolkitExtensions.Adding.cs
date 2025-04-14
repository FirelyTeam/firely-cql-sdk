using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

partial class InvocationToolkitExtensions
{
    /// <summary>
    /// Adds the specified assembly binaries to the <see cref="InvocationToolkit"/>.
    /// </summary>
    /// <param name="invocationToolkit">The <see cref="InvocationToolkit"/> to add the assembly binaries to.</param>
    /// <param name="assemblyBinary">The assembly binaries to add.</param>
    /// <returns>The <see cref="InvocationToolkit"/> with the added assembly binaries.</returns>
    public static InvocationToolkit AddAssemblyBinaries(
        this InvocationToolkit invocationToolkit,
        params AssemblyBinary[] assemblyBinary) =>
        invocationToolkit.AddAssemblyBinaries(assemblyBinary.AsEnumerable());

    /// <summary>
    /// Adds multiple Assembly binaries to the Invocation toolkit.
    /// </summary>
    /// <param name="invocationToolkit">The Invocation toolkit to add the files to.</param>
    /// <param name="files">The collection of Assembly binaries to add.</param>
    /// <returns>The updated Invocation toolkit.</returns>
    public static InvocationToolkit AddAssemblyBinaryFiles(
        this InvocationToolkit invocationToolkit,
        IEnumerable<FileInfo> files)
    {
        var logger = invocationToolkit.CreateLogger();
        var libraries = files
            .TrySelect(f =>
                       {
                           logger.LogInformation("Loading assembly binary from file: {file}", f);
                           var assemblyBinary = AssemblyBinary.Default.LoadFromFile(f);
                           return assemblyBinary;
                       },
                       s => s
                            .SetContinuation(invocationToolkit.BatchProcessExceptionContinuation)
                            .AddLoggerExceptionHandler(
                                logger,
                                (fileInfo, logMessage) => logMessage("Could not load assembly binary from file: {file}", fileInfo.FullName))); // Log errors
        return invocationToolkit.AddAssemblyBinaries(libraries);
    }

    /// <summary>
    /// Adds Assembly binaries from a specified directory to the Invocation toolkit.
    /// </summary>
    /// <param name="invocationToolkit">The Invocation toolkit to add the files to.</param>
    /// <param name="directory">The directory containing the Assembly binaries.</param>
    /// <param name="options">Optional enumeration options for file retrieval.</param>
    /// <param name="filePredicate">Optional predicate to filter files.</param>
    /// <returns>The updated Invocation toolkit.</returns>
    public static InvocationToolkit AddAssemblyBinaryFilesFromDirectory(
        this InvocationToolkit invocationToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.dll", options ?? Defaults.EnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return invocationToolkit.AddAssemblyBinaryFiles(files);
    }
}