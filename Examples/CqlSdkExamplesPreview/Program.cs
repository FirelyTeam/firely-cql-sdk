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

Console.WriteLine("CQL SDK Examples Preview");
Console.WriteLine("=======================");
Console.WriteLine();

// This is a basic example copied from the main CqlSdkExamples project
// This preview version can access internal members of the SDK projects for experimental features

var enableDebugging = true; // Try stepping through InvokeLibraryDefinition during debugging
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
            enableDebugging ? new ElmToolkitConfig(DebugSymbolsFormat.Embedded) : null);

CqlContext cqlContext = FhirCqlContext.WithDataSource();

object? result = librarySetInvoker.InvokeLibraryDefinition(
    cqlContext: cqlContext,
    libraryIdentifier: cql.LibraryIdentifier,
    definitionSignature: "HelloWorld");

Console.WriteLine($"Result: {result}");
Console.WriteLine();

// Demonstrate access to internal members - this would not be available to regular projects
Console.WriteLine("Demonstrating internal access:");
try
{
    // Access internal StringBuilderExtensions class from Cql.Invocation
    // This internal extension method is not available to external projects
    var sb = new System.Text.StringBuilder();
    sb.AppendMember("test value", "TestProperty");
    var output = sb.ToString();
    Console.WriteLine($"✓ Successfully used internal StringBuilderExtensions.AppendMember: {output}");
}
catch (Exception ex)
{
    Console.WriteLine($"✗ Failed to access internal types: {ex.Message}");
}

Console.WriteLine();
Console.WriteLine("This preview project has internal access to SDK projects for experimental features.");