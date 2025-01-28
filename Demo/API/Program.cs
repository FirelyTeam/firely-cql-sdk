using System.Diagnostics;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Cql.Fluent.Extensions;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Invocation.Extensions;
using CqlSdkPrototype.Invocation.Fluent.Extensions;
using Hl7.Cql.Fhir;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace API;

internal static class Program
{
    private static void Main(string[] args)
    {
        // Create a logger factory via the Microsoft.Extensions.Logging API
        var services = new ServiceCollection();
        services.AddLogging(builder => builder.AddConsole());
        IServiceProvider serviceProvider = services.BuildServiceProvider();
        var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToElmTranslatorConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]); // TODO:CqlToElmConversionConfig
        FluentCqlToolkit cqlToolkit = new FluentCqlToolkit(loggerFactory, cqlToElmProcessorSettings);

        // Add CQL libraries from a directory and process them to ELM, then save the ELM files to a directory
        cqlToolkit
            .AddCqlLibrariesFromDirectory(new DirectoryInfo("input/cql/"))
            .TranslateCqlToElm() // TODO:ConvertCqlToElm
            .SaveElmFilesToDirectory(new DirectoryInfo("output/elm/"));

        // Create fluent elm toolkit as a continuation of the cql toolkit
        var elmToolkit = cqlToolkit.ToFluentElmToolkit();

        // Process the ELM files to assemblies, then save the C# files and assembly binaries to directories
        elmToolkit
            .CompileElmToAssemblies() // TODO:ConvertElmToAssemblies
            .SaveCSharpFilesToDirectory(new DirectoryInfo("output/csharp/"))
            .SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/assemblies/"));

        // Setup RuntimeApi
        var invocationToolkit = elmToolkit.ToFluentInvocationToolkit();
        using var librarySetInvoker = invocationToolkit.ToLibrarySetInvoker(); // NOTE: 'librarySetInvoker' is a disposable object!

        // Execute CQL
        var threePlusTwo = librarySetInvoker.GetLibraryDefinitionResult(
            FhirCqlContext.ForBundle(),
            CqlVersionedLibraryIdentifier.ParseFromNameAndVersion("Add3and2", "1.0.0"),
            "ThreePlusTwo");

        Debug.Assert(threePlusTwo is 5);
    }
}

