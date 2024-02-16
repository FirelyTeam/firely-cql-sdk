using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.Packager;

partial class PackagerOptions
{
    public static void BindConfig(PackagerOptions opt, IConfiguration config)
    {
        var section = config.GetRequiredSection(ConfigSection);
        section.Bind(opt);

        // DirectoryInfos cannot be bound directly from IConfiguration, so we do it manually.
        opt.ElmDirectory = GetDirectoryInfo(nameof(ElmDirectory))!;
        opt.CqlDirectory = GetDirectoryInfo(nameof(CqlDirectory))!;
        opt.CSharpDirectory = GetDirectoryInfo(nameof(CSharpDirectory));

        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }
}