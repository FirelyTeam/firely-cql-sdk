using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.Packager;

internal class PackagerCliOptions {
    public const string ConfigSection = "PackagerCli";


    public static void BindConfig(PackagerCliOptions opt, IConfiguration config)
    {
        var section = config.GetRequiredSection(ConfigSection);
        section.Bind(opt);

        // DirectoryInfos cannot be bound directly from IConfiguration, so we do it manually.
        opt.OutDirectoryAssemblies = GetDirectoryInfo(nameof(OutDirectoryAssemblies))!;
        opt.OutDirectoryCSharp = GetDirectoryInfo(nameof(OutDirectoryCSharp))!;

        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }

    public DirectoryInfo? OutDirectoryCSharp { get; set; }
    public DirectoryInfo? OutDirectoryAssemblies { get; set; }
}