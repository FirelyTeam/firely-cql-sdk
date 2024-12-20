using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace CqlSdkPrototype.ElmToAssembly;

public partial record ElmCompilationCreateOptions
{
    public static ElmCompilationCreateOptions Default { get; }

    static ElmCompilationCreateOptions()
    {
        Default = new DefaultElmCompilationCreateOptions();
    }

    private ElmCompilationCreateOptions() { }

    public Func<ElmCompilationError, bool>? ShouldThrowError { get; init; }

    public ILoggerProvider LoggerProvider { get; init; } = NullLoggerProvider.Instance;
}

partial record ElmCompilationCreateOptions
{
    internal record DefaultElmCompilationCreateOptions : ElmCompilationCreateOptions
    {
        internal ElmCompilation? DefaultElmCompilation { get; private set; } // Only ever set once. Needs lock?

        internal override ElmCompilation CreateElmCompilation()
        {
            DefaultElmCompilation ??= new ElmCompilation(this, BuildServiceProvider());
            return DefaultElmCompilation;
        }
    }

    internal virtual ElmCompilation CreateElmCompilation()
    {
        return Equals(Default) switch
        {
            true => Default.CreateElmCompilation(),
            _    => new ElmCompilation(this, BuildServiceProvider())
        };
    }

    private ServiceProvider BuildServiceProvider()
    {
        var serviceProvider =
            new ServiceCollection()
                .AddLogging(lb => lb
                                  .ClearProviders()
                                  .AddProvider(LoggerProvider))
                .AddCqlCodeGenerationServices()
                .BuildServiceProvider(validateScopes: true);
        return serviceProvider;
    }

}