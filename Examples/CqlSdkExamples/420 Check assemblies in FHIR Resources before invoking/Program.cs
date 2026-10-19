/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void CheckAssembliesInFhirResourcesBeforeInvoking()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "420 Check assemblies in FHIR Resources before invoking"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Package CQL libraries into FHIR Library resources, each carrying its compiled assembly as a +dll attachment.
        new CqlToolkit(loggerFactory)
            .AddCqlLibrariesFromDirectory(new DirectoryInfo("input/cql"))
            .PackageToFhirResources()
            .SaveFhirResourcesToDirectory(new DirectoryInfo("output/fhir"));

        // A host that receives such Libraries, for example a FHIR server, checks each assembly before loading it:
        // the toolkit only runs code from a supported version of the code generator.
        Console.WriteLine(
            $"This toolkit runs code generator versions {InvocationToolkit.MinSupportedGeneratorToolVersion} " +
            $"up to, but not including, {InvocationToolkit.FirstUnsupportedGeneratorToolVersion}.");

        var deserializer = new BaseFhirJsonDeserializer(ModelInfo.ModelInspector);
        List<AssemblyBinary> supportedAssemblies = [];
        foreach (var file in new DirectoryInfo("output/fhir").EnumerateFiles("Library-*.json"))
        {
            if (!deserializer.TryDeserializeResource(File.ReadAllText(file.FullName), out var resource, out _)
                || resource is not Library fhirLibrary
                || fhirLibrary.Content.FirstOrDefault(IsAssemblyAttachment)?.Data is not { } assemblyBytes)
                continue;

            // Reads the assembly's metadata without loading it, and never throws.
            if (!InvocationToolkit.TryReadCqlAssemblyInfo(new AssemblyBinary(assemblyBytes), out var cqlAssemblyInfo))
            {
                Console.WriteLine($"{fhirLibrary.Name}: the +dll attachment is not a readable .NET assembly.");
                continue;
            }

            foreach (var cqlLibraryInfo in cqlAssemblyInfo.Libraries.Values)
            {
                Console.WriteLine(
                    $"{cqlLibraryInfo.LibraryIdentifier}: written by code generator {cqlLibraryInfo.GeneratorToolVersion}, " +
                    (cqlLibraryInfo.IsSupported ? "supported." : "not supported: compile it from its ELM instead."));
            }

            // Load only the assemblies whose libraries this toolkit runs. The result carries the assembly it was read
            // from, so the check and the load use the same bytes.
            if (cqlAssemblyInfo.IsSupported)
                supportedAssemblies.Add(cqlAssemblyInfo.AssemblyBinary);
        }

        using var librarySetInvoker = new InvocationToolkit(loggerFactory)
                                      .AddAssemblyBinaries(supportedAssemblies)
                                      .CreateLibrarySetInvoker();

        Console.WriteLine(
            $"Loaded {librarySetInvoker.LibraryInvokers.Count} CQL libraries from {supportedAssemblies.Count} supported assemblies.");

        static bool IsAssemblyAttachment(Attachment attachment) =>
            attachment is { ContentType: "application/octet-stream", ElementId: { } id } && id.EndsWith("+dll");
    }
}
