using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.Packaging;

partial class CqlToResourcePackagingOptions
{
    public static void BindConfig(CqlToResourcePackagingOptions opt, IConfiguration config)
    {
        var section = config.GetRequiredSection(ConfigSection);
        section.Bind(opt);

        // DirectoryInfos cannot be bound directly from IConfiguration, so we do it manually.
        opt.ElmDirectory = GetDirectoryInfo(nameof(ElmDirectory))!;
        opt.CqlDirectory = GetDirectoryInfo(nameof(CqlDirectory))!;

        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }
}