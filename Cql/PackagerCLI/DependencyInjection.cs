using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal static class DependencyInjection
{
    public static void AddPackagerServices(this IServiceCollection services, IConfiguration config)
    {
        TryAddPackagerOptions(services, config);
        services.TryAddTransient<PackagerCliProgram>();
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

    public static void TryAddResourceWriters(this IServiceCollection services, IConfiguration config)
    {
        TryAddPackagerOptions(services, config);
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

        CSharpCodeWriterOptions cSharpCodeWriterOptions = new();
        CSharpCodeWriterOptions.BindConfig(cSharpCodeWriterOptions, config);

        List<ServiceDescriptor> resourceWritersServiceDescriptors = new(2);

        if (fhirResourceWriterOptions.OutDirectory is {})
        {
            resourceWritersServiceDescriptors.Add(ServiceDescriptor.Singleton<ResourceWriter, FhirResourceWriter>());
            services
                .AddOptions<FhirResourceWriterOptions>()
                .Configure<IConfiguration>(FhirResourceWriterOptions.BindConfig)
                .ValidateOnStart();
        }

        if (cSharpCodeWriterOptions.OutDirectory is {} csharpDir)
        {
            services.AddSingleton<CSharpStreamToFileWriter>();
            services
                .AddOptions<CSharpCodeWriterOptions>()
                .Configure<IConfiguration>(CSharpCodeWriterOptions.BindConfig)
                .ValidateOnStart();
        }

        if (resourceWritersServiceDescriptors.Count > 0)
        {
            services.TryAddEnumerable(resourceWritersServiceDescriptors);
        }
    }


    public static void TryAddCompilationServices(this IServiceCollection services)
    {
        services.TryAddSingleton<OperatorBinding, CqlOperatorsBinding>();
        services.TryAddSingleton<CSharpLibrarySetToStreamsWriter>();
        services.TryAddSingleton<AssemblyCompiler>();
    }

    public static void TryAddTypeServices(this IServiceCollection services)
    {
        services.TryAddSingleton(ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver>(FhirTypeResolver.Default);
        services.TryAddSingleton<TypeConverter>(FhirTypeConverter.Default);
        services.TryAddSingleton<TypeManager>();
    }

    public static void TryAddBuilders(this IServiceCollection services)
    {
        services.TryAddSingleton<ResourcePackager, ResourcePackagerInjected>();
        services.TryAddSingleton<LibraryPackager>();
        services.TryAddSingleton<ExpressionBuilder>();
        services.TryAddSingleton<LibraryExpressionBuilder>();
        services.TryAddSingleton<LibrarySetExpressionBuilder>();
    }
}

file class ResourcePackagerInjected : ResourcePackager
{
    public ResourcePackagerInjected(LibraryPackager libraryPackager,
        ILoggerFactory logFactory,
        IEnumerable<ResourceWriter> resourceWriters) : base(libraryPackager, logFactory, resourceWriters)
    {
    }
}