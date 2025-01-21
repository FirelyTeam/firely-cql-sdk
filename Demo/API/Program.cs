using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm.Extensions;
using CqlSdkPrototype.Invocation.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace API;

internal static class Program
{
    private static void Main(string[] args)
    {
        //Setup DI
        var services = new ServiceCollection();
        services.AddLogging(builder => builder.AddConsole());
        services.AddSingleton<CqlApiOptions>(new CqlApiOptions(Models: [CqlModel.ElmR1, CqlModel.Fhir401]));
        services.AddSingleton<CqlApi>();
        services.AddSingleton<Example1>();

        IServiceProvider serviceProvider = services.BuildServiceProvider();
        var example1 = serviceProvider.GetRequiredService<Example1>();
        example1.Run();
    }
}

internal class Example1(CqlApi cqlApi)
{
    public void Run()
    {
        // Setup and use CqlApi
        cqlApi
            .AddCqlLibrariesFromDirectory(new DirectoryInfo("input/cql/"))
            .Translate()
            .SaveElmFileToDirectory(new DirectoryInfo("output/elm/"));

        // Setup and use ElmApi
        var elmApi = cqlApi.CreateElmApi();
        elmApi
            .Compile()
            .SaveCSharpFilesToDirectory(new DirectoryInfo("output/csharp/"))
            .SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/assemblies/"));
    }
}