/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;


internal static class CqlCodeGenerationServiceProviderExtensions
{
    public static TypeToCSharpConverter GetTypeToCSharpConverter(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<TypeToCSharpConverter>();

    public static CSharpLibrarySetToStreamsWriter GetCSharpLibrarySetToStreamsWriter(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<CSharpLibrarySetToStreamsWriter>();

    public static CSharpCodeStreamPostProcessor GetCSharpCodeStreamPostProcessor(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<CSharpCodeStreamPostProcessor>();

    public static AssemblyDataPostProcessor GetAssemblyDataPostProcessor(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<AssemblyDataPostProcessor>();

    public static AssemblyCompiler GetAssemblyCompiler(this IServiceProvider serviceProvider) => serviceProvider.GetRequiredService<AssemblyCompiler>();
}