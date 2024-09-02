/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging;

/// <summary>
/// This creates all services necessary for a <see cref="ResourcePackager"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class CqlPackagerFactory(
    ILoggerFactory loggerFactory,
    int cacheSize = 0,
    CqlToResourcePackagingOptions? cqlToResourcePackagingOptions = default,
    CSharpCodeWriterOptions? cSharpCodeWriterOptions = default,
    FhirResourceWriterOptions? fhirResourceWriterOptions = default,
    AssemblyDataWriterOptions? assemblyDataWriterOptions = default,
    CancellationToken cancellationToken = default)
    : CqlCompilerFactory(loggerFactory, cancellationToken, cacheSize)
{
    protected virtual AssemblyDataWriterOptions? AssemblyDataWriterOptions { get; } = assemblyDataWriterOptions;
    protected virtual CqlToResourcePackagingOptions CqlToResourcePackagingOptions { get; } = cqlToResourcePackagingOptions ?? new();
    protected virtual CSharpCodeWriterOptions CSharpCodeWriterOptions { get; } = cSharpCodeWriterOptions ?? new();
    protected virtual FhirResourceWriterOptions FhirResourceWriterOptions { get; } = fhirResourceWriterOptions ?? new();

    protected virtual CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper => Singleton(NewCqlTypeToFhirTypeMapper);
    protected virtual CqlTypeToFhirTypeMapper NewCqlTypeToFhirTypeMapper() => new(TypeResolver);

    protected virtual TypeToCSharpConverter TypeToCSharpConverter => Singleton(NewTypeToCSharpConverter);

    protected virtual TypeToCSharpConverter NewTypeToCSharpConverter() =>
        new TypeToCSharpConverter();

    public virtual CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter => Singleton(NewCSharpLibrarySetToStreamsWriter);
    protected virtual CSharpLibrarySetToStreamsWriter NewCSharpLibrarySetToStreamsWriter() => new(
        Logger<CSharpLibrarySetToStreamsWriter>(),
        Options(CSharpCodeWriterOptions),
        TypeResolver,
        TypeToCSharpConverter);

    protected virtual CSharpCodeStreamPostProcessor? CSharpCodeStreamPostProcessor => Singleton(NewCSharpCodeStreamPostProcessorOrNull);
    protected virtual CSharpCodeStreamPostProcessor? NewCSharpCodeStreamPostProcessorOrNull() =>
        CSharpCodeWriterOptions is { OutDirectory: { } } opt
            ? NewWriteToFileCSharpCodeStreamPostProcessor(opt)
            : default(CSharpCodeStreamPostProcessor);

    protected virtual WriteToFileCSharpCodeStreamPostProcessor NewWriteToFileCSharpCodeStreamPostProcessor(
        CSharpCodeWriterOptions opt) =>
        new WriteToFileCSharpCodeStreamPostProcessor(
            Options(opt),
            Logger<WriteToFileCSharpCodeStreamPostProcessor>());

    protected virtual AssemblyDataPostProcessor? AssemblyDataPostProcessor => Singleton(NewAssemblyDataPostProcessorOrNull);
    protected virtual AssemblyDataPostProcessor? NewAssemblyDataPostProcessorOrNull() =>
        AssemblyDataWriterOptions is { OutDirectory: { } } opt
            ? NewWriteToFileAssemblyDataPostProcessor(opt)
            : default(AssemblyDataPostProcessor);

    protected virtual WriteToFileAssemblyDataPostProcessor NewWriteToFileAssemblyDataPostProcessor(
        AssemblyDataWriterOptions opt) =>
        new WriteToFileAssemblyDataPostProcessor(
            Options(opt),
            Logger<WriteToFileAssemblyDataPostProcessor>());

    protected virtual FhirResourcePostProcessor? FhirResourcePostProcessor => Singleton(NewFhirResourcePostProcessorOrNull);
    protected virtual FhirResourcePostProcessor? NewFhirResourcePostProcessorOrNull() =>
        FhirResourceWriterOptions is { OutDirectory: {} } opt
            ? NewWriteToFileFhirResourcePostProcessor(opt)
            : default(FhirResourcePostProcessor);

    protected virtual WriteToFileFhirResourcePostProcessor NewWriteToFileFhirResourcePostProcessor(
        FhirResourceWriterOptions opt) =>
        new WriteToFileFhirResourcePostProcessor(
            Options(opt),
            Logger<WriteToFileFhirResourcePostProcessor>());


    public virtual AssemblyCompiler AssemblyCompiler => Singleton(NewAssemblyCompiler);
    protected virtual AssemblyCompiler NewAssemblyCompiler() =>
        new AssemblyCompiler(
            CSharpLibrarySetToStreamsWriter,
            TypeManager,
            CSharpCodeStreamPostProcessor,
            AssemblyDataPostProcessor);

    protected virtual ResourcePackager ResourcePackager => Singleton(NewResourcePackager);
    protected virtual ResourcePackager NewResourcePackager() =>
        new ResourcePackager(
            TypeResolver,
            FhirResourcePostProcessor);

    public virtual CqlToResourcePackagingPipeline CqlToResourcePackagingPipeline => Singleton(NewCqlToResourcePackagingPipeline);
    protected virtual CqlToResourcePackagingPipeline NewCqlToResourcePackagingPipeline() =>
        new CqlToResourcePackagingPipeline(
            Logger<CqlToResourcePackagingPipeline>(),
            Options(CqlToResourcePackagingOptions),
            ResourcePackager,
            LibrarySetExpressionBuilder,
            AssemblyCompiler);
}