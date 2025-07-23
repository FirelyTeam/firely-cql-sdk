using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void InvokingCqlHelloWorldWithFunctionArgument()
    {
        var enableDebugging = true; // Try stepping through InvokeLibraryDefinition during debugging
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        CqlToolkit cqlToolkit = new(loggerFactory);

        var cql = (CqlLibraryString)"""
                                    library HelloWorldLib version '1.0.0'

                                    define function "HelloWorld"(greeting String) : 'CQL Says: ' + (if greeting is null then '*Nothing*' else '"' + greeting + '"')
                                    """;
        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(cql)
                .CreateLibrarySetInvoker(
                    enableDebugging ? new ElmToolkitConfig(DebugSymbolsFormat.Embedded) : null);

        CqlContext cqlContext = FhirCqlContext.WithDataSource();

        object? result = librarySetInvoker.InvokeLibraryDefinition(
            cqlContext: cqlContext,
            libraryIdentifier: cql.LibraryIdentifier,
            definitionSignature: new DefinitionSignature("HelloWorld", typeof(string)),
            args: "Hello World");

        Console.WriteLine(result);
    }
}