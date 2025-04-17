/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime.Logging;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Packaging.Toolkit.Internal;

internal readonly record struct PackagingToolkitServices(
    ServiceProvider ServiceProvider,
    ILogger<PackagingToolkit> Logger,
    ResourcePackager ResourcePackager)
{
    public static PackagingToolkitServices Create(
        ILoggerFactory loggerFactory,
        PackagingToolkitConfig config)
    {
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        services.TryAddSingleton(_ => FhirModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();
        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();
        services.TryAddSingleton<IResourceCanonicalBuilder>(_ => new ResourceCanonicalBuilder(config.CanonicalRootUrl));
        services.TryAddSingleton<ResourcePackager>();
        services.TryAddSingleton((IServiceProvider _, ModelInspector modelInspector) => new JsonSerializerOptions().ForFhir(modelInspector));
        var serviceProvider = services.BuildServiceProvider();
        return ActivatorUtilities.CreateInstance<PackagingToolkitServices>(serviceProvider, serviceProvider);
    }
}

file static class Extensions
{
    public static void TryAddSingleton<TService, TDep1>(
        this IServiceCollection services,
        Func<IServiceProvider, TDep1, TService> implementationFactory)
        where TService : class
        where TDep1 : notnull
    {
        services.TryAddSingleton(sp => implementationFactory(sp, sp.GetRequiredService<TDep1>()));
    }
}