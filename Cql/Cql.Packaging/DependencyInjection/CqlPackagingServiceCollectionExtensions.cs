/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Microsoft.Extensions.DependencyInjection;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;


internal static class CqlPackagingServiceCollectionExtensions
{
    public static IServiceCollection AddCqlPackagingServices(this IServiceCollection services)
    {
        services.AddCqlCodeGenerationServices();

        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();

        services.TryAddSingletonSwitch<FhirResourcePostProcessor, WriteToFileFhirResourcePostProcessor, StubFhirResourcePostProcessor>(
            sp => sp.GetOptionsValue<FhirResourceWriterOptions>().OutDirectory switch
            {
                null => 1,
                _    => 0
            });


        services.TryAddSingleton<AssemblyCompiler>();

        services.TryAddSingleton<ResourcePackager>();

        services.TryAddSingleton<CqlToResourcePackagingPipeline>();

        return services;
    }
}