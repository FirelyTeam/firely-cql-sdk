using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.Packaging.ResourceWriters;

/// <summary>
/// Represents the options for the CSharpResourceWriter.
/// </summary>
public class CSharpResourceWriterOptions

{
    /// <summary>
    /// The name of the config setting.
    /// </summary>
    internal const string ConfigSection = "CSharpResourceWriter";

    /// <summary>
    /// Gets or sets the output directory.
    /// </summary>
    public DirectoryInfo? OutDirectory { get; set; }

    internal const string ArgNameOutDirectory = "--cs";

    /// <summary>
    /// Binds the configuration values to the CSharpResourceWriterOptions object.
    /// </summary>
    /// <param name="opt">The CSharpResourceWriterOptions object to bind the configuration values to.</param>
    /// <param name="config">The IConfiguration object containing the configuration values.</param>
    public static void BindConfig(CSharpResourceWriterOptions opt, IConfiguration config)
    {
        var section = config.GetSection(ConfigSection);
        section.Bind(opt);

        // DirectoryInfos cannot be bound directly from IConfiguration, so we do it manually.
        opt.OutDirectory = GetDirectoryInfo(nameof(OutDirectory))!;

        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }
}