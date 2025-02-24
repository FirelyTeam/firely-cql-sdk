/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Invocation.Toolkit.Internal;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit;


/// <summary>
/// Builder class for creating instances of <see cref="LibrarySetInvoker"/>.
/// </summary>
public sealed class InvocationToolkit : IToolkit<InvocationToolkit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvocationToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">Optional logger factory for logging purposes.</param>
    /// <param name="enumerationExceptionContinuation">The continuation policy to use when an exception occurs during enumeration.</param>
    public InvocationToolkit(
        ILoggerFactory? loggerFactory = null,
        EnumerationExceptionContinuation enumerationExceptionContinuation = EnumerationExceptionContinuation.Throw)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        EnumerationExceptionContinuation = enumerationExceptionContinuation;
        _assemblyBinaries = AssemblyBinaryHashSet.Empty;
        _services = LibrarySetInvokerBuilderServices.Create(loggerFactory);
    }

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <inheritdoc />
    public EnumerationExceptionContinuation EnumerationExceptionContinuation { get; private set; }

    /// <inheritdoc />
    public InvocationToolkit SetEnumerationExceptionContinuation(EnumerationExceptionContinuation continuation)
    {
        EnumerationExceptionContinuation = continuation;
        return this;
    }

    /// <summary>
    /// Gets the set of assembly binaries.
    /// </summary>
    public AssemblyBinaryReadOnlyHashSet AssemblyBinaries => _assemblyBinaries;

    private readonly LibrarySetInvokerBuilderServices _services;
    private AssemblyBinaryHashSet _assemblyBinaries;

    /// <summary>
    /// Sets the assembly binaries.
    /// </summary>
    /// <param name="assemblyBinaries">The assembly binaries to set.</param>
    private void ReplaceAssemblyBinaries(
        AssemblyBinaryHashSet assemblyBinaries) =>
        _assemblyBinaries = assemblyBinaries;

    /// <summary>
    /// Adds assembly binaries to the current set.
    /// </summary>
    /// <param name="assemblyBinary">The assembly binaries to add.</param>
    /// <exception cref="InvalidOperationException">Thrown when AssemblyBytes is null.</exception>
    public InvocationToolkit AddAssemblyBinaries(IEnumerable<AssemblyBinary> assemblyBinary)
    {
        var builder = _assemblyBinaries.ToBuilder();
        var oldCount = builder.Count;
        builder.AddRange(
            assemblyBinary
                             .Select(ad =>
                             {
                                 _services.Logger.LogDebug("Adding assembly binary with {bytesLength} bytes.", ad.AssemblyBytes?.Length ?? 0);
                                 return new AssemblyBinary(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"),
                                                           ad.DebugSymbolsBytes);
                             }));
        if (oldCount != builder.Count)
            ReplaceAssemblyBinaries(builder.ToImmutable());

        return this;
    }

    /// <summary>
    /// Creates a new instance of <see cref="LibrarySetInvoker"/>.
    /// </summary>
    /// <param name="name">The name of the AssemblyLoadContext.</param>
    /// <returns>A new instance of <see cref="LibrarySetInvoker"/>
    /// which must be disposed when no longer in use,
    /// so that the loaded assemblies may unload from the
    /// application domain.</returns>
    public LibrarySetInvoker CreateLibrarySetInvoker(string name = "")
    {
        _services.Logger.LogDebug("Creating LibrarySetInvoker {name}", name);

        var alc = new AssemblyLoadContext(name, true);

        AssemblyBinaries
            .TryForEach(t =>
                {
                    var (assembly, debugSymbols) = t;
                    var asm = alc.LoadFromBytes(assembly!, debugSymbols);
                    _services.Logger.LogInformation("Loaded assembly {assemblyName}", asm.FullName);
                },
                errorStrategy => errorStrategy
                    .SetContinuation(EnumerationExceptionContinuation)
                    .AddLoggerExceptionHandler(
                        _services.Logger,
                        (assemblyBinary, logMessage) => logMessage("Unable to load an assembly from the binary containing {byteLength} byte(s).", assemblyBinary.AssemblyBytes!.Length)));

        return new LibrarySetInvoker(
            alc,
            this.LoggerFactory,
            this.EnumerationExceptionContinuation);
    }
}
