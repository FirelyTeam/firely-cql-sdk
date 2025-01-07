namespace CqlSdkPrototype.Runtime;

public record CqlRuntimeApiOptions(
    IServiceProvider ServiceProvider)
{
    public IServiceProvider ServiceProvider { get; init; } = ServiceProvider ?? throw new ArgumentNullException(nameof(ServiceProvider));

    public static CqlRuntimeApiOptions Create(
        IServiceProvider serviceProvider) =>
        new(serviceProvider);
}