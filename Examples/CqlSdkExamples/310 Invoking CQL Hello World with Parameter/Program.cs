using Microsoft.Extensions.Logging;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;

partial class Program
{
    void InvokingCqlHelloWorldWithParameter()
    {
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        CqlToolkit cqlToolkit = new(loggerFactory);

        var cql = (CqlLibraryString)"""
                                    library HelloWorldLib version '1.0.0'

                                    parameter greeting String

                                    define "HelloWorld" : 'CQL Says: ' + (if greeting is null then '*Nothing*' else '"' + greeting + '"')
                                    """;
        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(cql)
                .CreateLibrarySetInvoker();

        CqlContext cqlContext = FhirCqlContext.WithDataSource(
            parameters: new Dictionary<string, object>()
            {
                // Try removing the parameter to see what happens
                { "greeting", "Hello World" }
            });

        object? result = librarySetInvoker.InvokeLibraryDefinition(
            cqlContext: cqlContext,
            libraryIdentifier: cql.LibraryIdentifier,
            definitionSignature: "HelloWorld");

        Console.WriteLine(result);
    }
}