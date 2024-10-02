using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkUseCases;

internal class CqlSdk
{
    public ElmToCSharpSdkProvider ElmToCSharpSdkProvider { get; }
    public CSharpToBinarySdkProvider CSharpToBinarySdkProvider { get; }

    public CqlSdk(
        ElmToCSharpSdkProvider elmToCSharpSdkProvider,
        CSharpToBinarySdkProvider cSharpToBinarySdkProvider)
    {
        ElmToCSharpSdkProvider = elmToCSharpSdkProvider;
        CSharpToBinarySdkProvider = cSharpToBinarySdkProvider;
    }

    public static CqlSdk Build()
    {
        ServiceCollection services = new ServiceCollection();
        services.AddLogging(lb => lb.ClearProviders());
        services.AddCqlCodeGenerationServices();
        services.AddSingleton<ElmToCSharpSdkProvider>();
        services.AddSingleton<CSharpToBinarySdkProvider>();
        services.AddSingleton<CqlSdk>();
        var sp = services.BuildServiceProvider();
        return sp.GetRequiredService<CqlSdk>();
    }
}