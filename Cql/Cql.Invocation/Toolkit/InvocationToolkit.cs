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
    /// <param name="batchProcessExceptionContinuation">The continuation policy to use when an exception occurs during batch processing.</param>
    public InvocationToolkit(
        ILoggerFactory? loggerFactory = null,
        BatchProcessExceptionContinuation batchProcessExceptionContinuation = BatchProcessExceptionContinuation.Throw)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation;
        _assemblyBinaries = AssemblyBinaryHashSet.Empty;
        _services = LibrarySetInvokerBuilderServices.Create(loggerFactory);
    }

    /// <summary>
    /// Gets the minimum generator tool version supported by this invocation toolkit.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="LibrarySetInvoker.MinSupportedGeneratorToolVersion"/>.
    /// </remarks>
    public static readonly Version MinSupportedGeneratorToolVersion = LibrarySetInvoker.MinSupportedGeneratorToolVersion;

    /// <summary>
    /// Gets the first generator tool version that this invocation toolkit does not support for executing generated code.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="LibrarySetInvoker.FirstUnsupportedGeneratorToolVersion"/>.
    /// </remarks>
    public static readonly Version FirstUnsupportedGeneratorToolVersion = LibrarySetInvoker.FirstUnsupportedGeneratorToolVersion;

    /// <summary>
    /// Determines whether this toolkit runs code written by the specified version of the code generator.
    /// </summary>
    /// <param name="generatorToolVersion">
    /// The version of the code generator, as a generated library type's <see cref="GeneratedCodeAttribute"/> names it.
    /// </param>
    /// <returns>
    /// <see langword="true"/> when the version lies from <see cref="MinSupportedGeneratorToolVersion"/> (inclusive)
    /// to <see cref="FirstUnsupportedGeneratorToolVersion"/> (exclusive); otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// A component the version leaves out counts as 0, so <c>6.0</c> is treated as <c>6.0.0.0</c>.
    /// </remarks>
    /// <exception cref="ArgumentNullException"><paramref name="generatorToolVersion"/> is null.</exception>
    public static bool IsGeneratorToolVersionSupported(Version generatorToolVersion)
    {
        ArgumentNullException.ThrowIfNull(generatorToolVersion);
        return CqlLibraryTypeRule.IsGeneratorToolVersionSupported(generatorToolVersion);
    }

    /// <summary>
    /// Reads the CQL libraries that the code generator wrote into an assembly, from the assembly's metadata,
    /// without loading the assembly.
    /// </summary>
    /// <param name="assemblyBinary">
    /// The assembly, such as one built from the <c>+dll</c> attachment of a FHIR Library. Its debug symbols are not
    /// read, only carried to the result.
    /// </param>
    /// <returns>
    /// The libraries the assembly holds, each with the version of the code generator that wrote it, together with
    /// <paramref name="assemblyBinary"/> itself, ready to pass to <see cref="AddAssemblyBinaries"/>. Its
    /// <see cref="CqlAssemblyInfo.Libraries"/> are empty when the assembly holds no library the code
    /// generator wrote.
    /// </returns>
    /// <remarks>
    /// <para>
    /// A type counts as a library when it carries a <see cref="Hl7.Cql.Abstractions.CqlLibraryAttribute"/> and a
    /// <see cref="GeneratedCodeAttribute"/> naming the code generator: the same rule
    /// <see cref="CreateLibrarySetInvoker(string)"/> applies to the types it loads.
    /// </para>
    /// <para>
    /// A supported generator version is necessary for this toolkit to run a library, but not sufficient: loading
    /// it can still fail for other reasons, such as a missing dependency.
    /// </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException"><paramref name="assemblyBinary"/> is null.</exception>
    /// <exception cref="ArgumentException"><paramref name="assemblyBinary"/> holds no assembly bytes.</exception>
    /// <exception cref="BadImageFormatException">
    /// The bytes are not a .NET assembly, are a module without an assembly manifest, or hold metadata that
    /// cannot be read.
    /// </exception>
    /// <exception cref="InvalidOperationException">The assembly holds two library types with the same identifier.</exception>
    /// <seealso cref="TryReadCqlAssemblyInfo"/>
    public static CqlAssemblyInfo ReadCqlAssemblyInfo(AssemblyBinary assemblyBinary) =>
        CqlAssemblyInfoReader.Read(assemblyBinary);

    /// <summary>
    /// Tries to read the CQL libraries that the code generator wrote into an assembly, from the assembly's
    /// metadata, without loading the assembly and without throwing.
    /// </summary>
    /// <param name="assemblyBinary">
    /// The assembly, such as one built from the <c>+dll</c> attachment of a FHIR Library. Its debug symbols are not
    /// read, only carried to the result.
    /// </param>
    /// <param name="cqlAssemblyInfo">
    /// The libraries the assembly holds, together with <paramref name="assemblyBinary"/> itself, when it can be read;
    /// otherwise, <see langword="null"/>.
    /// </param>
    /// <returns>
    /// <see langword="false"/> wherever <see cref="ReadCqlAssemblyInfo"/> throws, including for a null
    /// <paramref name="assemblyBinary"/> or one that holds no assembly bytes; <see langword="true"/> otherwise,
    /// including for an assembly that holds no library the code generator wrote. Call
    /// <see cref="ReadCqlAssemblyInfo"/> to learn why a read failed.
    /// </returns>
    public static bool TryReadCqlAssemblyInfo(
        AssemblyBinary? assemblyBinary,
        [NotNullWhen(true)] out CqlAssemblyInfo? cqlAssemblyInfo) =>
        CqlAssemblyInfoReader.TryRead(assemblyBinary, out cqlAssemblyInfo);

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <inheritdoc />
    public BatchProcessExceptionContinuation BatchProcessExceptionContinuation { get; private set; }

    /// <inheritdoc />
    public InvocationToolkit SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation continuation)
    {
        BatchProcessExceptionContinuation = continuation;
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
    /// <param name="librarySetName">The name of the library set which is used in the AssemblyLoadContext.</param>
    /// <returns>A new instance of <see cref="LibrarySetInvoker"/>
    /// which must be disposed when no longer in use,
    /// so that the loaded assemblies may unload from the
    /// application domain.</returns>
    public LibrarySetInvoker CreateLibrarySetInvoker(string librarySetName = "") =>
        CreateLibrarySetInvoker(librarySetName, isPoolOwned: false);

    /// <summary>
    /// Creates a new instance of <see cref="LibrarySetInvoker"/>, optionally marking it as owned by a
    /// <see cref="LibrarySetInvokerPool"/> so that its <see cref="LibrarySetInvoker.Dispose"/> becomes
    /// inert and the pool controls when the assemblies unload.
    /// </summary>
    internal LibrarySetInvoker CreateLibrarySetInvoker(string librarySetName, bool isPoolOwned) =>
        CreateLibrarySetInvoker(librarySetName, isPoolOwned, AssemblyBinaries, BatchProcessExceptionContinuation);

    /// <summary>
    /// Creates a <see cref="LibrarySetInvoker"/> from an explicit snapshot of the inputs rather than from
    /// this toolkit's current state.
    /// </summary>
    /// <remarks>
    /// <see cref="LibrarySetInvokerPool"/> needs this: it derives its cache key from the toolkit's inputs
    /// and only loads them later, when the entry's lazy value is forced. Re-reading the toolkit at that
    /// point would let a concurrent <see cref="AddAssemblyBinaries"/> (or a continuation change) file an
    /// entry under a key that no longer describes what was loaded, so the pool passes the same snapshot to
    /// both. <see cref="AssemblyBinaries"/> is already immutable, so the snapshot costs nothing.
    /// </remarks>
    internal LibrarySetInvoker CreateLibrarySetInvoker(
        string librarySetName,
        bool isPoolOwned,
        AssemblyBinaryReadOnlyHashSet assemblyBinaries,
        BatchProcessExceptionContinuation batchProcessExceptionContinuation)
    {
        _services.Logger.LogDebug("Creating LibrarySetInvoker {name}", librarySetName);

        var alc = new AssemblyLoadContext(librarySetName, true);

        try
        {
            assemblyBinaries
                .TryForEach(t =>
                    {
                        var (assembly, debugSymbols) = t;
                        var asm = alc.LoadFromBytes(assembly!, debugSymbols);
                        _services.Logger.LogInformation("Loaded assembly {assemblyName}", asm.FullName);
                    },
                    errorStrategy => errorStrategy
                        .SetContinuation(batchProcessExceptionContinuation)
                        .AddLoggerExceptionHandler(
                            _services.Logger,
                            (assemblyBinary, logMessage) => logMessage("Unable to load an assembly from the binary containing {byteLength} byte(s).", assemblyBinary.AssemblyBytes!.Length)));

            return new LibrarySetInvoker(
                alc,
                LoggerFactory,
                batchProcessExceptionContinuation,
                librarySetName,
                isPoolOwned);
        }
        catch
        {
            // No LibrarySetInvoker took ownership of the context, so nothing else will ever unload it.
            // Unloading a collectible context is cooperative and does not even begin until Unload() is
            // called, so without this a failed load leaves the context - and any assemblies that did
            // load into it - resident for the lifetime of the process.
            _services.Logger.LogDebug(
                "Unloading the assembly load context for {name} after a failed load.",
                librarySetName);
            alc.Unload();
            throw;
        }
    }
}
