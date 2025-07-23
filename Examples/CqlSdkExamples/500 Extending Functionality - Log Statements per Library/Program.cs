using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void ExtendingFunctionalityLogLibraryStatements()
    {
        // This example first packages CQL libraries into FHIR resources,
        // then loads the packaged resources and invokes them.

        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "500 Extending Functionality - Log Statements per Library"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from directory
        //var cqlDirectory = new DirectoryInfo("input/cql");
        var cql = """
                  library System.Identifier version 'Version'
                  """;
        var cqlToolkit = new CqlToolkit(loggerFactory);
        var cqlLibraryString = CqlLibraryString.Parse(cql);
        cqlToolkit.AddCqlLibraries(cqlLibraryString);

        // Translate CQL to ELM0
        cqlToolkit.TranslateToElm();

        // Log the statements per library
        cqlToolkit.LogLibrariesAndDefinitions();
    }
}

internal static class CqlToolkitExampleExtensions
{
    public static CqlToolkit LogLibrariesAndDefinitions(
        this CqlToolkit cqlToolkit)
    {
        var logger = cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitExampleExtensions));

        foreach (var (libraryIdentifier, elmLibrary) in cqlToolkit.GetCqlToolkitResults())
        {
            string[] statements = elmLibrary.statements.Select(s => s.name).Distinct().ToArray();
            logger.LogInformation("Library {library} has statements [{statements}]", libraryIdentifier, statements);
        }

        return cqlToolkit;
    }
}