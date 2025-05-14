using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
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
    void InvokingCqlHelloWorld()
    {
        var enableDebugging = false; // Try setting this to true, then step through InvokeLibraryDefinition
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        CqlToolkit cqlToolkit = new(loggerFactory);

        var cql = (CqlLibraryString)"""
                                    library HelloWorldLib version '1.0.0'

                                    define "HelloWorld" : 'CQL Says: "Hello, DevDays!"'
                                    """;
        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(cql)
                .CreateLibrarySetInvoker(
                    enableDebugging ? null : new ElmToolkitConfig(AssemblyCompilerDebugInformationFormat.Embedded));

        CqlContext cqlContext = FhirCqlContext.WithDataSource();

        object? result = librarySetInvoker.InvokeLibraryDefinition(
            cqlContext: cqlContext,
            libraryIdentifier: cql.LibraryIdentifier,
            definitionSignature: "Hello World");

        Console.WriteLine(result);
    }
}