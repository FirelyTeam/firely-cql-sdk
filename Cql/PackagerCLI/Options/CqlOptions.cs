using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packager.Options;

internal record CqlOptions : CqlToolkitConfig
{
    public const string ConfigSection = "Cql";
    private const string ModelsConfigSection = nameof(Models);

    /// <summary>
    /// Configures the Models
    /// </summary>
    public static void Configure(
        CqlOptions options,
        IConfiguration configuration)
    {
        var cqlModels = configuration
            .GetSection(ConfigSection)
            .GetSection(ModelsConfigSection)
            .Get<CqlModel[]>();
        if (cqlModels is not null)
        {
            var cqlModelsSet = options.Models.NewImmutableHashSet(cqlModels);
            typeof(CqlOptions)
                .GetProperty(ModelsConfigSection)!
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