/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packager.Options;

public record CqlOptions : CqlToolkitConfig, IConfigureBindOptions<CqlOptions>
{
    public const string ConfigSection = "Cql";
    static string IBindOptions.ConfigSection => ConfigSection;

    /// <summary>
    /// Configures the Models
    /// </summary>
    public static void Configure(
        CqlOptions options,
        IConfiguration configuration)
    {
        if (configuration
            .GetSection(ConfigSection)
            .GetSection(nameof(Models))
            .Get<CqlModel[]>() is {} cqlModels)
        {
            var cqlModelsSet = options.Models.NewImmutableHashSet(cqlModels);
            typeof(CqlOptions)
                .GetProperty(nameof(Models))!
                .SetValue(options, cqlModelsSet);
        }
    }
}

file static class X
{
    /// <summary>
    /// Create a new immutable hash set with the same type as the prototype.
    /// </summary>
    public static IImmutableSet<T> NewImmutableHashSet<T>(
        this ImmutableHashSet<T> prototype,
        IEnumerable<T> source) =>
        source.ToImmutableHashSet();
}