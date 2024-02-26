﻿using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal static class DependencyInjection
{
    public static void AddPackagerServices(this IServiceCollection services, IConfiguration config)
    {
        TryAddPackagerOptions(services, config);
        services.TryAddTransient<PackagerService>();
    }

    private static void TryAddPackagerOptions(IServiceCollection services, IConfiguration config)
    {
        if (services.Any(s => s.ServiceType == typeof(IValidateOptions<PackagerOptions>)))
            return;

        services
            .AddOptions<PackagerOptions>()
            .Configure<IConfiguration>(PackagerOptions.BindConfig)
            .ValidateOnStart();

        services.AddSingleton<IValidateOptions<PackagerOptions>, PackagerOptions.Validator>();
    }

    public static void AddResourcePackager(this IServiceCollection services, IConfiguration config)
    {
        TryAddPackagerOptions(services, config);
        services.TryAddSingleton<ResourcePackager>();
        TryAddConfiguredResourceWriters(services, config);
    }

    /// <summary>
    ///     Load the options for the Fhir and CSharp resource writers, and only load them up as services when necessary.
    /// </summary>
    /// <remarks>
    ///     Only the resource writers that are configured, will be loaded as keyed services, as well as IEnumerable
    ///     of resource writer (which is loaded into the ResourcePackager)
    /// </remarks>
    private static void TryAddConfiguredResourceWriters(IServiceCollection services, IConfiguration config)
    {
        PackagerOptions packagerOptions = new();
        PackagerOptions.BindConfig(packagerOptions, config);

        FhirResourceWriterOptions fhirResourceWriterOptions = new();
        FhirResourceWriterOptions.BindConfig(fhirResourceWriterOptions, config);

        CSharpResourceWriterOptions cSharpResourceWriterOptions = new();
        CSharpResourceWriterOptions.BindConfig(cSharpResourceWriterOptions, config);

        List<ServiceDescriptor> resourceWritersServiceDescriptors = new(2);

        if (fhirResourceWriterOptions.OutDirectory is {})
        {
            resourceWritersServiceDescriptors.Add(ServiceDescriptor.Singleton<ResourceWriter, FhirResourceWriter>());
            services
                .AddOptions<FhirResourceWriterOptions>()
                .Configure<IConfiguration>(FhirResourceWriterOptions.BindConfig)
                .ValidateOnStart();
        }

        if (cSharpResourceWriterOptions.OutDirectory is {} csharpDir)
        {
            resourceWritersServiceDescriptors.Add(ServiceDescriptor.Singleton<ResourceWriter, CSharpResourceWriter>());
            services
                .AddOptions<CSharpResourceWriterOptions>()
                .Configure<IConfiguration>(CSharpResourceWriterOptions.BindConfig)
                .ValidateOnStart();
        }

        if (resourceWritersServiceDescriptors.Count > 0)
        {
            services.TryAddEnumerable(resourceWritersServiceDescriptors);
        }
    }
}