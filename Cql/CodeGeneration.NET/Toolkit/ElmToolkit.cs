/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit;

/// <summary>
/// Compiles ELM (Expression Logical Model) into .NET assemblies.
/// </summary>
public sealed class ElmToolkit : IToolkit<ElmToolkit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ElmToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration for the toolkit.</param>
    /// <param name="batchProcessExceptionContinuation">The continuation policy to use when an exception occurs during batch processing.</param>
    public ElmToolkit(
        ILoggerFactory? loggerFactory = null,
        ElmToolkitConfig? config = null,
        BatchProcessExceptionContinuation batchProcessExceptionContinuation = BatchProcessExceptionContinuation.Throw)
    {
        config ??= ElmToolkitConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _conversions = ElmToolkitConversionDictionary.Empty;
        Config = config;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation;
        _services = ElmToolkitServices.Create(loggerFactory, config);
    }

    private ElmToolkitConversionDictionary _conversions;
    private readonly ElmToolkitServices _services;

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <summary>
    /// Gets the configuration used by the toolkit.
    /// </summary>
    public ElmToolkitConfig Config { get; }

    /// <inheritdoc />
    public BatchProcessExceptionContinuation BatchProcessExceptionContinuation { get; private set; }

    /// <inheritdoc />
    public ElmToolkit SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation continuation)
    {
        BatchProcessExceptionContinuation = continuation;
        return this;
    }

    /// <summary>
    /// Gets the dictionary of ELM to assembly compilations.
    /// </summary>
    public ElmToolkitConversionReadOnlyDictionary Conversions => _conversions;

    /// <summary>
    /// Sets the conversions for the ELM to assembly compilations.
    /// </summary>
    /// <param name="conversions">The dictionary of ELM to assembly compilations.</param>
    private void ReplaceConversions(
        ElmToolkitConversionDictionary conversions)
    {
        _conversions = conversions;
    }

    /// <summary>
    /// Adds ELM libraries to the compiler.
    /// </summary>
    /// <param name="elmLibraries">The libraries to add.</param>
    public ElmToolkit AddElmLibraries(IEnumerable<ElmLibrary> elmLibraries)
    {
        var conversions = _conversions.ToBuilder();
        var logger = _services.Logger;
        var count = elmLibraries
                    .Select(elmLibrary => new ElmToolkitConversionRecord(elmLibrary))
                    .TryForEach(conversionRecord =>
                                {
                                    var libId = conversionRecord.LibraryIdentifier;
                                    logger.LogInformation("Adding ELM library to ElmToolkit: {lib}", libId);
                                    conversions.Add(libId, conversionRecord); // This fails on duplicate key and value
                                },
                                errorStrategy => errorStrategy
                                                 .SetContinuation(BatchProcessExceptionContinuation)
                                                 .AddLoggerExceptionHandler(
                                                     logger,
                                                     (conversionRecord, logMessage) =>
                                                         logMessage("Could not add ELM library to ElmToolkit: {lib}", conversionRecord.LibraryIdentifier)));

        if (count > 0)
            ReplaceConversions(conversions: conversions.ToImmutable());

        return this;
    }

    /// <summary>
    /// Compiles the ELM libraries into .NET assemblies.
    /// </summary>
    public ElmToolkit CompileToAssemblies()
    {
        var entries = _conversions;
        if (entries.Values.All(predicate: lc => lc is { ResultAssemblyBinary: not null }))
            return this;

        var logger = _services.Logger;
        using var servicesScope = _services.CreateScopedState();

        logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        var debugInformationFormat = Config.AssemblyCompilerDebugInformationFormat;
        AssemblyCompiler assemblyCompiler = _services.AssemblyCompiler;
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor = _services.LibrarySetCSharpCodeGenerator;
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.LibrarySetExpressionBuilder;
        ElmLibrary[] libraries = entries.Values.Select(selector: v => v.SourceElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet(name: "", libraries: libraries);

        var removedLibraries = librarySet.RemoveLibrariesWithMissingDependencies();
        foreach (var (id, _) in removedLibraries)
            logger.LogWarning(message: "Removed library with missing dependencies: {id}", args: id);

        var librarySetDefinitions = BuildLibrarySetDefinitions(librarySetExpressionBuilderScoped, librarySet);
        var cSharps = GenerateCSharp(cSharpCodeProcessor, librarySet, librarySetDefinitions);
        var assemblyBinaries = CompileAssemblies(assemblyCompiler, librarySet, cSharps, debugInformationFormat);

        var entriesBuilder = entries.ToBuilder();
        var hasChanged = UpdateConversions(assemblyBinaries, entriesBuilder, logger);
        if (hasChanged)
            ReplaceConversions(conversions: entriesBuilder.ToImmutable());

        return this;
    }

    /// <summary>
    /// Updates the state entries with the compiled assemblies.
    /// </summary>
    /// <param name="assemblyBinaries">The compiled assemblies.</param>
    /// <param name="conversions">The builder for the entries dictionary.</param>
    /// <param name="logger">The logger to use for logging.</param>
    /// <returns><see langword="true"/> if the state entries were updated; otherwise, <see langword="false"/>.</returns>
    private static bool UpdateConversions(
        IEnumerable<(ElmLibrary library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> assemblyBinaries,
        ElmToolkitConversionDictionary.Builder conversions,
        ILogger<ElmToolkit> logger)
    {
        bool hasChanged = false;
        foreach (var (library, (assemblyBinary, sourceCodePerName, debugSymbols)) in assemblyBinaries)
        {
            var elmVersionedIdentifier = library.identifier.ToCqlVersionedLibraryIdentifier();
            var libraryCompilation = conversions[key: elmVersionedIdentifier];
            if (libraryCompilation.ResultCSharpSourceCode is not null
                || libraryCompilation.ResultAssemblyBinary is not null)
            {
                logger.LogInformation(message: "Library already compiled: {lib}", args: elmVersionedIdentifier);
                continue;
            }

            var cSharpSourceCode = sourceCodePerName!.Values.Single(); // We always expect a single source file
            libraryCompilation = libraryCompilation with
            {
                ResultCSharpSourceCode = cSharpSourceCode,
                ResultAssemblyBinary = assemblyBinary,
                ResultDebugSymbolsBinary = debugSymbols,
            };
            conversions[key: elmVersionedIdentifier] = libraryCompilation;
            hasChanged = true;
        }

        return hasChanged;
    }

    /// <summary>
    /// Compiles the C# code into .NET assemblies.
    /// </summary>
    /// <param name="assemblyCompiler">The assembly compiler to use.</param>
    /// <param name="librarySet">The set of libraries to compile.</param>
    /// <param name="cSharps">The C# code to compile.</param>
    /// <param name="debugInformationFormat">The format for debug information.</param>
    /// <returns>The compiled assemblies.</returns>
    private IEnumerable<(ElmLibrary library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> CompileAssemblies(
        AssemblyCompiler assemblyCompiler,
        LibrarySet librarySet,
        IEnumerable<(ElmLibrary library, string cSharp)> cSharps,
        AssemblyCompilerDebugInformationFormat debugInformationFormat) =>
        assemblyCompiler
            .CompileEachLibraryToAssemblies(
                cSharps.WithEach(t => _services.Logger.LogInformation("Compiling C# into .NET Assembly: {lib}", t.library.identifier)),
                librarySet,
                debugInformationFormat,
                errorStrategy => errorStrategy
                                 .SetContinuation(BatchProcessExceptionContinuation)
                                 .AddLoggerExceptionHandler(
                                     _services.Logger,
                                     (pair, logMessage) =>
                                         logMessage("Could not compile C# to .NET Assembly: {lib}", pair.library.GetVersionedIdentifier()!)));

    /// <summary>
    /// Generates the C# code for the libraries.
    /// </summary>
    /// <param name="cSharpCodeProcessor">The C# code processor to use.</param>
    /// <param name="librarySet">The set of libraries to generate code for.</param>
    /// <param name="librarySetDefinitions">The definitions for the library set.</param>
    /// <returns>The generated C# code.</returns>
    private IEnumerable<(ElmLibrary library, string cSharp)> GenerateCSharp(
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor,
        LibrarySet librarySet,
        DefinitionDictionary<CqlDefinition> librarySetDefinitions) =>
        cSharpCodeProcessor
            .GenerateEachLibraryToCSharp(
                librarySet,
                librarySetDefinitions,
                errorStrategy => errorStrategy
                                 .SetContinuation(BatchProcessExceptionContinuation)
                                 .AddLoggerExceptionHandler(
                                     _services.Logger,
                                     (library, log) => log("Could not generate definitions into C#: {lib}", library.GetVersionedIdentifier())),
                library => _services.Logger.LogInformation("Generating definitions into C#: {lib} ", library.GetVersionedIdentifier()));

    /// <summary>
    /// Builds the library set definitions.
    /// </summary>
    /// <param name="librarySetExpressionBuilderScoped">The library set expression builder to use.</param>
    /// <param name="librarySet">The set of libraries to build definitions for.</param>
    /// <returns>The dictionary of library set definitions.</returns>
    private DefinitionDictionary<CqlDefinition> BuildLibrarySetDefinitions(
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped,
        LibrarySet librarySet)
    {
        DefinitionDictionary<CqlDefinition> librarySetDefinitions = new();
        librarySetExpressionBuilderScoped
            .BuildEachLibraryDefinitions(
                librarySet,
                librarySetDefinitions,
                errorStrategy => errorStrategy
                                 .SetContinuation(BatchProcessExceptionContinuation)
                                 .AddLoggerExceptionHandler(
                                     _services.Logger,
                                     (library, logMessage) =>
                                         logMessage("Could not convert ELM into definitions for {id}", library.GetVersionedIdentifier())),
                library => _services.Logger.LogInformation("Converting ELM Library into definitions for {id}", library.GetVersionedIdentifier()))
            .ForEach(); // Important to enumerate
        return librarySetDefinitions;
    }
}
