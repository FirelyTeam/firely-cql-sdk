/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;
using Hl7.Cql.Compiler.DependencyInjection;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Packaging.DependencyInjection;

internal class CqlPackagerServices(IServiceProvider serviceProvider)
    : CqlCompilerServices(serviceProvider)
{
    public CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper => ServiceProvider.GetRequiredService<CqlTypeToFhirTypeMapper>();

    public TypeToCSharpConverter TypeToCSharpConverter => ServiceProvider.GetRequiredService<TypeToCSharpConverter>();

    public CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter => ServiceProvider.GetRequiredService<CSharpLibrarySetToStreamsWriter>();

    public CSharpCodeStreamPostProcessor CSharpCodeStreamPostProcessor => ServiceProvider.GetRequiredService<CSharpCodeStreamPostProcessor>();

    public AssemblyDataPostProcessor AssemblyDataPostProcessor => ServiceProvider.GetRequiredService<AssemblyDataPostProcessor>();

    public FhirResourcePostProcessor FhirResourcePostProcessor => ServiceProvider.GetRequiredService<FhirResourcePostProcessor>();

    public AssemblyCompiler AssemblyCompiler => ServiceProvider.GetRequiredService<AssemblyCompiler>();

    public ResourcePackager ResourcePackager => ServiceProvider.GetRequiredService<ResourcePackager>();

    public CqlToResourcePackagingPipeline CqlToResourcePackagingPipeline => ServiceProvider.GetRequiredService<CqlToResourcePackagingPipeline>();
}