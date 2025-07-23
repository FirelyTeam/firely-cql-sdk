/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
    void InvokingCqlHelloWorld()
    {
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

        Console.WriteLine(result);
    }
}
