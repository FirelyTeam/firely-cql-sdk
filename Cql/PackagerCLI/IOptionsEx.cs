namespace Hl7.Cql.Packager;

public interface IOptionsEx
{
    static abstract string ConfigSection { get; }
}

public interface IConfigureOptionsEx<in TSelf> : IOptionsEx
    where TSelf : IOptionsEx
{
    public static abstract void Configure(TSelf options, IConfiguration configuration);
}