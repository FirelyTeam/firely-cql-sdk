/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Packaging.Internal;
using Hl7.Cql.Primitives;

namespace CqlSdkExamples;

partial class Program
{
    void InvokingFromFhirResourceAndDependenciesInDirectory()
    {
        // This example first packages ELM libraries into FHIR resources,
        // then loads the packaged resources and invokes them.

        var enableDebugging = true; // Try stepping through InvokeLibraryDefinition during debugging
        var ignoreErrors = true;    // This ignores errors and tries to continue processing other definitions

        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "410 Invoke from all FHIR Resource and Dependencies in Directory"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add ELM libraries from Demos directory
        var elmDirectory = new DirectoryInfo(Path.Combine(LibrarySetsDirectory, "Demo", "Elm"));
        var elmToolkit = new ElmToolkit(loggerFactory, enableDebugging ? new ElmToolkitConfig(DebugSymbolsFormat.Embedded) : null);
        if (ignoreErrors)
            elmToolkit = elmToolkit.SetIgnoreEnumerationExceptions();
        elmToolkit.AddElmFilesFromDirectory(elmDirectory);

        var cqlDirectory = new DirectoryInfo(Path.Combine(LibrarySetsDirectory, "Demo", "Cql"));
        var cqlToolkit = new CqlToolkit(loggerFactory);
        if (ignoreErrors)
            cqlToolkit = cqlToolkit.SetIgnoreEnumerationExceptions();
        cqlToolkit.AddCqlLibrariesFromDirectory(cqlDirectory);

        // Package into FHIR Resources (Translate CQL to ELM, then compile ELM to C# and DLLs)
        var packagingToolkit = elmToolkit.PackageToFhirResources(cqlToolkit);

        // Save packaged resources
        packagingToolkit.SaveFhirResourcesToDirectory(new DirectoryInfo("output/fhir"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");

        // Load the packaged resources
        var libraryIdentifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("BCSEHEDISMY2022", "1.0.0");
        var invocationToolkit = new InvocationToolkit();
        if (ignoreErrors)
            invocationToolkit = invocationToolkit.SetIgnoreEnumerationExceptions();
        invocationToolkit = invocationToolkit.AddAssemblyBinariesFromFhirLibraryAndDependencies(
            libraryIdentifier,
            ResourceFileInfoResolvers.FromDirectory(new DirectoryInfo("output/fhir")));
        Debug.Assert(invocationToolkit.AssemblyBinaries.Count == 12);

        using var librarySetInvoker = invocationToolkit.CreateLibrarySetInvoker();

        List<(DefinitionInvoker DefinitionInvoker, Exception Exception)> errors = new List<(DefinitionInvoker DefinitionInvoker, Exception Exception)>();

        var patientEverything = new Bundle();                                // Add data
        var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary(); // Add valuesets
        var cqlContext = FhirCqlContext.ForBundle(patientEverything, MY2023, valueSets);

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

    private readonly IDictionary<string, object> MY2023 =
        new Dictionary<string, object>
        {
            {
                "Measurement Period",
                new CqlInterval<CqlDateTime>(
                    new CqlDateTime(2023, 1, 1, 0, 0, 0, 0, 0, 0),
                    new CqlDateTime(2023, 12, 31, 0, 0, 0, 0, 0, 0),
                    true,
                    true)
            }
        };

}
