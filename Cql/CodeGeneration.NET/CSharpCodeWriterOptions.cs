/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.CodeGeneration.NET;

/// <nodoc/>
public partial class CSharpCodeWriterOptions

{
    private DirectoryInfo? _outDirectory;

    /// <summary>
    /// The name of the config setting.
    /// </summary>
    internal const string ConfigSection = "CSharpCodeWriter";

    /// <summary>
    /// Gets or sets the output directory.
    /// </summary>
    public DirectoryInfo? OutDirectory
    {
        get => _outDirectory;
        set => _outDirectory = value;
    }

    /// <summary>
    /// Binds the configuration values to the <see cref="CSharpCodeWriterOptions"/> object.
    /// </summary>
    /// <param name="opt">The <see cref="CSharpCodeWriterOptions"/> object to bind the configuration values to.</param>
    /// <param name="config">The <see cref="IConfiguration"/> object containing the configuration values.</param>
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