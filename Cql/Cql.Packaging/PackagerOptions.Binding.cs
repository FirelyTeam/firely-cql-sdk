using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.Packaging;

partial class PackagerOptions
{
    internal static void BindDirectoryInfos(IConfiguration config, PackagerOptions opt)
    {
        var section = config.GetRequiredSection(ConfigSection);
        opt.ElmDirectory = GetDirectoryInfo(nameof(ElmDirectory))!;
        opt.CqlDirectory = GetDirectoryInfo(nameof(CqlDirectory))!;
        opt.CSharpDirectory = GetDirectoryInfo(nameof(CSharpDirectory));
        opt.FhirDirectory = GetDirectoryInfo(nameof(FhirDirectory));

        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }
}