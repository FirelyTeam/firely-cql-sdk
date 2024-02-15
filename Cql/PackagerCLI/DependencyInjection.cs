using System.Runtime.InteropServices.ComTypes;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal static class DependencyInjection
{
    public static void AddPackagerServices(this IServiceCollection services)
    {
        services.TryAddPackagerOptions();
        services.TryAddTransient<PackagerService>();
    }

    private static void TryAddPackagerOptions(this IServiceCollection services)
    {
        if (services.Any(s => s.ServiceType == typeof(IValidateOptions<PackagerOptions>)))
            return;

        services.AddOptions<PackagerOptions>()
            .BindConfiguration(PackagerOptions.ConfigSection)
            .Configure<IConfiguration>((opt, config) => { PackagerOptions.BindDirectoryInfos(config, opt); })
            .ValidateOnStart();
        services.AddSingleton<IValidateOptions<PackagerOptions>, PackagerOptions.Validator>();
    }

    public static void AddResourcePackager(this IServiceCollection services)
    {
        services.TryAddPackagerOptions();
        services.TryAddSingleton<ResourcePackager>();

        var unvalidatedPackagerOptions = TryGetPackagerOptions(services);
        if (unvalidatedPackagerOptions != null)
        {
            List<ServiceDescriptor> descriptors = new(2);

            if (unvalidatedPackagerOptions.FhirDirectory is {} fhirDir)
            {
                services.TryAddKeyedSingleton("Fhir", fhirDir);
                descriptors.Add(ServiceDescriptor.Singleton<ResourceWriter, FhirResourceWriter>());
            }

            if (unvalidatedPackagerOptions.CSharpDirectory is {} csharpDir)
            {
                services.TryAddKeyedSingleton("CSharp", csharpDir);
                descriptors.Add(ServiceDescriptor.Singleton<ResourceWriter, CSharpResourceWriter>());
            }

            if (descriptors.Count > 0)
            {
                services.TryAddEnumerable(descriptors);
            }
        }
    }

    private static PackagerOptions? TryGetPackagerOptions(IServiceCollection services)
    {
        using var sp = services.BuildServiceProvider(new ServiceProviderOptions { ValidateOnBuild = false, ValidateScopes = false });
        var opt = sp.GetService<IOptions<PackagerOptions>>();
        return opt?.Value;
    }
}