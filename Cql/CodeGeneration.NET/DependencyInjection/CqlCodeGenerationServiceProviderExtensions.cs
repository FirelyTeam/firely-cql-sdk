/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.CodeGeneration.NET;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;


internal static class CqlCodeGenerationServiceProviderExtensions
{
    public static TypeToCSharpConverter GetTypeToCSharpConverter(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<TypeToCSharpConverter>();

    public static LibrarySetCSharpCodeGenerator GetLibrarySetCSharpCodeGenerator(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

    public static AssemblyCompiler GetAssemblyCompiler(this IServiceProvider serviceProvider) => serviceProvider.GetRequiredService<AssemblyCompiler>();
}