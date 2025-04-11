/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packager.Options;

public record CqlBindOptions : CqlToolkitConfig, IConfigureBindOptions<CqlBindOptions>
{
    public const string ConfigSection = "Cql";
    static string IBindOptions.ConfigSection => ConfigSection;

    /// <summary>
    /// Configures the Models
    /// </summary>
    public static void Configure(
        CqlBindOptions bindOptions,
        IConfiguration configuration)
    {
        if (configuration
            .GetSection(ConfigSection)
            .GetSection(nameof(Models))
            .Get<CqlModel[]>() is {} cqlModels)
        {
            var cqlModelsSet = bindOptions.Models.NewImmutableHashSet(cqlModels);
            typeof(CqlBindOptions)
                .GetProperty(nameof(Models))!
                .SetValue(bindOptions, cqlModelsSet);
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