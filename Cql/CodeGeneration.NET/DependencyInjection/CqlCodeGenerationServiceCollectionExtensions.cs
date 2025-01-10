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
        this IServiceCollection services,
        Action<CSharpCodeWriterOptions>? configureCSharpCodeWriterOptions = null)
    {
        services.AddCqlCompilerServices();

        services.TryAddSingleton<TypeToCSharpConverter>();

        services.TryAddSingleton<CSharpCodeGenerator>();

        services.TryAddSingleton<AssemblyCompiler>();

        services.AddOptions(BuildCSharpCodeWriterOptions());

        Action<OptionsBuilder<CSharpCodeWriterOptions>> BuildCSharpCodeWriterOptions()
        {
            return configureCSharpCodeWriterOptions is { } fn
                       ? builder => builder.Configure(fn)
                       : _ => { };
        }

        return services;
    }
}