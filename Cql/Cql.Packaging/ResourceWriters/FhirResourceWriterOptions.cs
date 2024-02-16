using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.Packaging.ResourceWriters;


/// <summary>
/// Represents the options for the FhirResourceWriter.
/// </summary>
public class FhirResourceWriterOptions

{
    /// <summary>
    /// The name of the config setting.
    /// </summary>
    internal const string ConfigSection = "FhirResourceWriter";

    /// <summary>
    /// Gets or sets the output directory.
    /// </summary>
    public DirectoryInfo? OutDirectory { get; set; }

    internal const string ArgNameOutDirectory = "--fhir";

    /// <summary>
    /// Gets or sets the override date.
    /// </summary>
    public DateTime? OverrideDate { get; set; }

    internal const string ArgNameOverrideDate = "--override-utc-date-time";

    /// <summary>
    /// Binds the configuration values to the FhirResourceWriterOptions object.
    /// </summary>
    /// <param name="opt">The FhirResourceWriterOptions object to bind the configuration values to.</param>
    /// <param name="config">The IConfiguration object containing the configuration values.</param>
    public static void BindConfig(FhirResourceWriterOptions opt, IConfiguration config)
    {
        var section = config.GetSection(ConfigSection);
        section.Bind(opt);

        // DirectoryInfos cannot be bound directly from IConfiguration, so we do it manually.
        opt.OutDirectory = GetDirectoryInfo(nameof(OutDirectory))!;

        // While DateTimes can be bound directly from IConfiguration, we convert to UTC
        opt.OverrideDate = opt.OverrideDate?.ToUniversalTime();

        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }
}