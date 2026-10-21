/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void PackageWithElmOnlyDependencySaveFhirResourcesToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "241 Package with a dependency available only as ELM, Save FHIR Resources to dir"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // DevDays comes with its CQL. FHIRHelpers, which DevDays includes, is available only as ELM,
        // as it is when a host loads a published library by its ELM.
        var cqlToolkit = new CqlToolkit(loggerFactory)
            .AddCqlLibrariesFromDirectory(new DirectoryInfo("input/cql"));

        var elmToolkit = new ElmToolkit(loggerFactory)
            .AddElmFilesFromDirectory(new DirectoryInfo("input/elm"));

        // Packages DevDays only. FHIRHelpers resolves its include and is not packaged itself.
        var packagingToolkit = elmToolkit.PackageToFhirResources(cqlToolkit);

        // DevDays still gets its data requirements, and a depends-on related artifact for FHIRHelpers.
        foreach (var (libraryIdentifier, resultArtifacts) in packagingToolkit.GetPackagingResults())
        {
            var types = resultArtifacts.FhirLibrary.DataRequirement.Select(dataRequirement => dataRequirement.Type);
            Console.WriteLine($"{libraryIdentifier}: data requirements for {string.Join(", ", types)}");
        }

        packagingToolkit.SaveFhirResourcesToDirectory(new DirectoryInfo("output/fhir"));
    }
}
