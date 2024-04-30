using System.IO;
using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Represents the options for the CSharpResourceWriter.
/// </summary>
public class CSharpCodeWriterOptions

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
    internal const string ArgNameTypeFormat = "--cs-typeformat";

    /// <summary>
    /// Gets or sets a value indicating whether to prefer 'var' over explicit types.
    /// </summary>
    public CSharpCodeWriterTypeFormat TypeFormat { get; set; }

    /// <summary>
    /// Binds the configuration values to the CSharpResourceWriterOptions object.
    /// </summary>
    /// <param name="opt">The CSharpResourceWriterOptions object to bind the configuration values to.</param>
    /// <param name="config">The IConfiguration object containing the configuration values.</param>
    public static void BindConfig(CSharpCodeWriterOptions opt, IConfiguration config)
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

/// <summary>
/// How to format types in C# output
/// </summary>
public enum CSharpCodeWriterTypeFormat
{
    /// <summary>
    /// Use 'var' over explicit types.
    /// </summary>
    Var,

    /// <summary>
    /// Use explicit types.
    /// </summary>
    Explicit
}