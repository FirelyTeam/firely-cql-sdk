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
internal class CqlPackagerFactory : CqlCompilerFactory
{
    public CqlToResourcePackagingOptions CqlToResourcePackagingOptions { get; }
    public CSharpCodeWriterOptions CSharpCodeWriterOptions { get; }
    public FhirResourceWriterOptions FhirResourceWriterOptions { get; }

    public CqlPackagerFactory(
        ILoggerFactory loggerFactory,
        int cacheSize = 0,
        CqlToResourcePackagingOptions? cqlToResourcePackagingOptions = default,
        CSharpCodeWriterOptions? cSharpCodeWriterOptions = default,
        FhirResourceWriterOptions? fhirResourceWriterOptions = default) : base(loggerFactory, cacheSize)
    {
        CqlToResourcePackagingOptions = cqlToResourcePackagingOptions ?? new();
        CSharpCodeWriterOptions = cSharpCodeWriterOptions ?? new();
        FhirResourceWriterOptions = fhirResourceWriterOptions ?? new();
    }

    public virtual CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper => Singleton(NewCqlTypeToFhirTypeMapper);
    protected virtual CqlTypeToFhirTypeMapper NewCqlTypeToFhirTypeMapper() => new(TypeResolver);

    public virtual CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter => Singleton(NewCSharpLibrarySetToStreamsWriter);
    protected virtual CSharpLibrarySetToStreamsWriter NewCSharpLibrarySetToStreamsWriter() => new(
        Logger<CSharpLibrarySetToStreamsWriter>(),
        Options(CSharpCodeWriterOptions),
        TypeResolver);

    public virtual CSharpCodeStreamPostProcessor? CSharpCodeStreamPostProcessor => Singleton(NewCSharpCodeStreamPostProcessorOrNull);
    protected virtual CSharpCodeStreamPostProcessor? NewCSharpCodeStreamPostProcessorOrNull() =>
        CSharpCodeWriterOptions is { OutDirectory: { } } opt
            ? NewWriteToFileCSharpCodeStreamPostProcessor(opt)
            : default(CSharpCodeStreamPostProcessor);

    protected virtual WriteToFileCSharpCodeStreamPostProcessor NewWriteToFileCSharpCodeStreamPostProcessor(
        CSharpCodeWriterOptions opt) =>
        new(Options(opt), Logger<WriteToFileCSharpCodeStreamPostProcessor>());

    public virtual FhirResourcePostProcessor? FhirResourcePostProcessor => Singleton(NewFhirResourcePostProcessorOrNull);
    protected virtual FhirResourcePostProcessor? NewFhirResourcePostProcessorOrNull() =>
        FhirResourceWriterOptions is { OutDirectory: {} } opt
            ? NewWriteToFileFhirResourcePostProcessor(opt)
            : default(FhirResourcePostProcessor);
    protected virtual WriteToFileFhirResourcePostProcessor NewWriteToFileFhirResourcePostProcessor(
        FhirResourceWriterOptions opt) =>
        new(Options(opt), Logger<WriteToFileFhirResourcePostProcessor>());


    public AssemblyCompiler AssemblyCompiler => Singleton(NewAssemblyCompiler);
    protected virtual AssemblyCompiler NewAssemblyCompiler() => new(CSharpLibrarySetToStreamsWriter, TypeManager, CSharpCodeStreamPostProcessor);

    public ResourcePackager ResourcePackager => Singleton(NewResourcePackager);
    protected virtual ResourcePackager NewResourcePackager() => new(TypeResolver, FhirResourcePostProcessor);

    public CqlToResourcePackagingPipeline CqlToResourcePackagingPipeline => Singleton(NewCqlToResourcePackagingPipeline);
    protected virtual CqlToResourcePackagingPipeline NewCqlToResourcePackagingPipeline() =>
        new(Options(CqlToResourcePackagingOptions), ResourcePackager, LibrarySetExpressionBuilder, AssemblyCompiler);
}