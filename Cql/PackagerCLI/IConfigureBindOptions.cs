namespace Hl7.Cql.Packager;

public interface IConfigureBindOptions<in TSelf> : IBindOptions
    where TSelf : IBindOptions
{
    public static abstract void Configure(TSelf options, IConfiguration configuration);
}