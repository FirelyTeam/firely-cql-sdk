using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packager.Options;

internal record CqlOptions : CqlToolkitConfig
{
    public const string ConfigSection = "Cql";

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