using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

internal static class DependencyInjection
{
    public static void AddPackagerServices(this IServiceCollection services)
    {
        services.AddTransient<PackagerService>();

        services.AddOptions<PackagerOptions>()
            .BindConfiguration(PackagerOptions.ConfigSection)
            .Configure<IConfiguration>((opt, config) => { PackagerOptions.BindDirectoryInfos(config, opt); })
            .ValidateOnStart();
        services.AddSingleton<IValidateOptions<PackagerOptions>, PackagerOptions.Validator>();
    }
}