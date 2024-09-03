/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;
using Hl7.Cql.Compiler.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.CodeGeneration.NET.Hosting;

internal readonly struct CqlCodeGenerationServices(IServiceProvider serviceProvider)
{
    public IServiceProvider ServiceProvider { get; } = serviceProvider;

    public CqlCompilerServices GetCqlCompilerServices() => new(ServiceProvider);

    public TypeToCSharpConverter TypeToCSharpConverter => ServiceProvider.GetRequiredService<TypeToCSharpConverter>();

    public CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter => ServiceProvider.GetRequiredService<CSharpLibrarySetToStreamsWriter>();

    public CSharpCodeStreamPostProcessor CSharpCodeStreamPostProcessor => ServiceProvider.GetRequiredService<CSharpCodeStreamPostProcessor>();

    public AssemblyDataPostProcessor AssemblyDataPostProcessor => ServiceProvider.GetRequiredService<AssemblyDataPostProcessor>();

    public AssemblyCompiler AssemblyCompiler => ServiceProvider.GetRequiredService<AssemblyCompiler>();
}