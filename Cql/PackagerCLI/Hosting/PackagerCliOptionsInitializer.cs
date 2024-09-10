/*
 *Copyright(c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager.Hosting;

internal static class PackagerCliOptionsInitializer
{
    public static IServiceCollection AddPackagerCliOptions(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        if (services.Any(s => s.ServiceType == typeof(IValidateOptions<CqlToResourcePackagingOptions>)))
            return services;

        services.AddSingleton<IValidateOptions<CqlToResourcePackagingOptions>, CqlToResourcePackagingOptions.Validator>();
        services.AddSingleton<IValidateOptions<CSharpCodeWriterOptions>, CSharpCodeWriterOptions.Validator>();

        services
            .AddOptions<CqlToResourcePackagingOptions>()
            .Configure<IConfiguration>(CqlToResourcePackagingOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<FhirResourceWriterOptions>()
            .Configure<IConfiguration>(FhirResourceWriterOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<CSharpCodeWriterOptions>()
            .Configure<IConfiguration>(CSharpCodeWriterOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<AssemblyDataWriterOptions>()
            .Configure<IConfiguration>(AssemblyDataWriterOptions.BindConfig)
            .ValidateOnStart();

        return services;
    }
}