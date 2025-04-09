using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packager;

internal record CqlOptions : CqlToolkitConfig
{
    public const string ConfigSection = "Cql";
    private const string ModelsConfigSection = nameof(Models);

    public CqlOptions(CqlModel[]? models) : base(Models:models?.ToImmutableHashSet())
    {
    }

    public string? CqlInDir { get; init; }
    public string? ElmOutDir { get; init; }

    /// <summary>
    /// This only creates the CqlOptions object with the models, it does not do a full binding.
    /// </summary>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public static CqlOptions CreateCqlOptions(IConfiguration configuration)
    {
        var section = configuration.GetSection(CqlOptions.ConfigSection);

        // Special handling to load Models from the configuration and pass it to the constructor
        var models = section.GetSection(CqlOptions.ModelsConfigSection).Get<CqlModel[]>();

        // Validate
        if (models is not null)
            foreach (var model in models)
                if (!Enum.IsDefined(typeof(CqlModel), model))
                    throw new InvalidEnumArgumentException(CqlOptions.ModelsConfigSection, (int)model, typeof(CqlModel));

        CqlOptions config = new CqlOptions(models);
        return config;
    }
}