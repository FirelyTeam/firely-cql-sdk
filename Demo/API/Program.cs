using System.Diagnostics;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm.Extensions;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Runtime.Extensions;
using Hl7.Cql.Fhir;
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

        // Get CqlApi from DI
        IServiceProvider serviceProvider = services.BuildServiceProvider();
        var cqlApi = serviceProvider.GetRequiredService<CqlApi>();

        // Setup and use CqlApi
        cqlApi.AddCqlLibrariesFromDirectory(new DirectoryInfo("input/cql/"));
        cqlApi.Translate();
        cqlApi.SaveElmFileToDirectory(new DirectoryInfo("output/elm/"));

        // Setup and use ElmApi
        var elmApi = cqlApi.CreateElmApi();
        elmApi.Compile();
        elmApi.SaveCSharpFilesToDirectory(new DirectoryInfo("output/csharp/"));
        elmApi.SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/assemblies/"));

        // Setup RuntimeApi
        var runtimeApi = elmApi.CreateRuntimeApi();
        var runtimeScope = runtimeApi.CreateRuntimeScope();

        // Execute CQL
        var threePlusTwo = runtimeScope.GetLibraryDefinitionResult(
            FhirCqlContext.ForBundle(),
            CqlVersionedLibraryIdentifier.ParseFromNameAndVersion("Add3and2", "1.0.0"),
            "ThreePlusTwo");

        Debug.Assert(threePlusTwo is 5);
    }
}

