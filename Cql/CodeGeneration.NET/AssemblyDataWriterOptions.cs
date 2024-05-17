// /*
//  * Copyright (c) 2024, NCQA and contributors
//  * See the file CONTRIBUTORS for details.
//  *
//  * This file is licensed under the BSD 3-Clause license
//  * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
//  */

using System.IO;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;
using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Represents the options for the <see cref="AssemblyDataPostProcessor"/>.
/// </summary>
public class AssemblyDataWriterOptions
{
    /// <summary>
    /// The name of the config setting.
    /// </summary>
    internal const string ConfigSection = "AssemblyDataWriter";

    /// <summary>
    /// Gets or sets the output directory.
    /// </summary>
    public DirectoryInfo? OutDirectory { get; set; }

    internal const string ArgNameOutDirectory = "--dll";

    /// <summary>
    /// Binds the configuration values to the <see cref="AssemblyDataWriterOptions"/> object.
    /// </summary>
    /// <param name="opt">The <see cref="AssemblyDataWriterOptions"/> object to bind the configuration values to.</param>
    /// <param name="config">The <see cref="IConfiguration"/> object containing the configuration values.</param>
    public static void BindConfig(AssemblyDataWriterOptions opt, IConfiguration config)
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