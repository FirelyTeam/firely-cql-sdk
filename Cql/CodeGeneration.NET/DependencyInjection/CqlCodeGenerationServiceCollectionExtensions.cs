/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class CqlCodeGenerationServiceCollectionExtensions
{
    public static IServiceCollection AddCqlCodeGenerationServices(
        this IServiceCollection services)
    {
        services.AddCqlCompilerServices();

        services.TryAddSingleton<TypeToCSharpConverter>();
        services.TryAddSingleton<LibrarySetCSharpCodeGenerator>();
        services.TryAddSingleton<AssemblyCompiler>();

        return services;
    }
}