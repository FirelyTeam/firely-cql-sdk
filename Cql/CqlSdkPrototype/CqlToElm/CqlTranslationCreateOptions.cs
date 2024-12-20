namespace CqlSdkPrototype.CqlToElm;

public record CqlTranslationCreateOptions
{
    public static CqlTranslationCreateOptions Default { get; }

    static CqlTranslationCreateOptions()
    {
        Default = new CqlTranslationCreateOptions();
    }

    public Func<CqlTranslationError, bool>? ShouldThrowError { get; init; }

    private CqlTranslationCreateOptions() { }
}