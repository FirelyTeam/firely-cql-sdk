/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Toolkit;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void InvokingFromFhirResources()
    {
        // This example first packages CQL libraries into FHIR resources,
        // then loads the packaged resources and invokes them.

        var enableDebugging = true; // Try stepping through InvokeLibraryDefinition during debugging
        var ignoreErrors = true;    // This ignores errors and tries to continue processing other definitions

        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "400 Invoke from FHIR Resources"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from directory
        var cqlDirectory = new DirectoryInfo("input/cql");
        var cqlToolkit = new CqlToolkit(loggerFactory);
        if (ignoreErrors)
            cqlToolkit = cqlToolkit.SetIgnoreEnumerationExceptions();
        cqlToolkit.AddCqlLibrariesFromDirectory(cqlDirectory);

        // Package into FHIR Resources (Translate CQL to ELM, then compile ELM to C# and DLLs)
        var packagingToolkit = cqlToolkit.PackageToFhirResources(
            elmToolkitConfig: enableDebugging ? new ElmToolkitConfig(DebugSymbolsFormat.Embedded) : null);

        // Save packaged resources
        packagingToolkit.SaveFhirResourcesToDirectory(new DirectoryInfo("output/fhir"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");

        // Load the packaged resources
        var invocationToolkit = new InvocationToolkit();
        if (ignoreErrors)
            invocationToolkit = invocationToolkit.SetIgnoreEnumerationExceptions();
        invocationToolkit = invocationToolkit.AddAssemblyBinariesInFhirLibrariesFromDirectory(new DirectoryInfo("output/fhir"));

        using var librarySetInvoker = invocationToolkit.CreateLibrarySetInvoker();

        var cqlContext = FhirCqlContext.WithDataSource();

        List<(DefinitionInvoker DefinitionInvoker, Exception Exception)> errors = new List<(DefinitionInvoker DefinitionInvoker, Exception Exception)>();

        var results = librarySetInvoker
                      .SelectExpressions()
                      .ToList()
                      .SelectResults(
                          cqlContext,
                          selectResultsOptions:new SelectResultsOptions(
                              InvocationExceptionCallback: (definition, exception, _) => errors.Add((definition,exception))))
                      .ToList();

        if (errors.Count > 0)
            Console.WriteLine($"There were {errors.Count} definition result(s) that failed.");
        
        Console.WriteLine($"There were {results.Count} definition result(s) that succeeded.");
    }
}
