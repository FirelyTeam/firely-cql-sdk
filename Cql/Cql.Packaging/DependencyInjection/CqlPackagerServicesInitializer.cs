/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.DependencyInjection;
using Hl7.Cql.Compiler.DependencyInjection;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hl7.Cql.Packaging.DependencyInjection;

internal static class CqlPackagerServicesInitializer
{
    internal static CqlPackagerServices GetCqlPackagerServices(this IServiceProvider serviceProvider) =>
        new CqlPackagerServices(serviceProvider);

    public static IServiceCollection AddCqlPackagerServices(this IServiceCollection services)
    {
        services.AddCqlCodeGenerationServices();

        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();

        services.TryAddSingletonSwitch<FhirResourcePostProcessor, WriteToFileFhirResourcePostProcessor, StubFhirResourcePostProcessor>(
            sp => sp.GetOptions<FhirResourceWriterOptions>().Value.OutDirectory switch
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

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection TryAddSingletonSwitch<TService, TImpl0, TImpl1>(
        this IServiceCollection services,
        Func<IServiceProvider, int> switchFn)
        where TService : class
        where TImpl0 : class, TService
        where TImpl1 : class, TService
    {
        services.TryAddSingleton<TService>(
            sp => switchFn(sp) switch
            {
                0 => ActivatorUtilities.CreateInstance<TImpl0>(sp),
                1 => ActivatorUtilities.CreateInstance<TImpl1>(sp),
                _ => throw new InvalidOperationException("Invalid switch value")
            });
        return services;
    }
}