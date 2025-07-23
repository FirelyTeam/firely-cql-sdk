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
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void PackageInclDebugSymbolsViaCqlToolkitsSaveFhirResourcesToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "251 Package incl debug symbols via CQL Toolkit, Save FHIR Resources to dir"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from directory
        var cqlDirectory = new DirectoryInfo("input/cql");
        var cqlToolkit = new CqlToolkit(loggerFactory);
        cqlToolkit.AddCqlLibrariesFromDirectory(cqlDirectory);

        // Package into FHIR Resources (Translate CQL to ELM, then compile ELM to C# and DLLs)
        var packagingToolkit = cqlToolkit.PackageToFhirResources(
            new ElmToolkitConfig(DebugSymbolsFormat.PortablePdb));

        // Save packaged resources
        packagingToolkit.SaveFhirResourcesToDirectory(new DirectoryInfo("output/fhir"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}