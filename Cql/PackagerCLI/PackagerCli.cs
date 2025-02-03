/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Cql.Fluent.Extensions;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Packaging.Fluent;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using System;

namespace Hl7.Cql.Packager;

internal class PackagerCli
(
    ILoggerFactory loggerFactory,
    ILogger<PackagerCli> logger,
    OptionsConsoleDumper optionsConsoleDumper,
    IOptions<PackagerCliOptions> packagerCliOptions,
    ResourcePackager resourcePackager,
    FhirResourceFileWriter fhirResourceFileWriter)
{
    public int Run(bool translateCql = false)
    {
        // REVIEW: Remove these parameters before merging the PR!
        _ = resourcePackager;
        _ = fhirResourceFileWriter;

        try
        {
            optionsConsoleDumper.DumpToConsole();

            var opt = packagerCliOptions.Value;
            if (opt.CqlInDirectory is not { Exists:true })
            {
                logger.LogWarning("Exiting: Cql input directory must be specified and exist.");
                return -1;
            }

            if (!translateCql && opt.ElmInDirectory is not { Exists: true })
            {
                logger.LogWarning("Exiting: ELM input directory must be specified and exist.");
                return -1;
            }

            if (opt.GetOutDirectories().All(o => o.dir is null))
            {
                logger.LogWarning("Exiting: At least one output directory must be specified for a particular type.");
                return -1;
            }

            var packagingToolkit = new FluentPackagingToolkit(loggerFactory)
                .SetExceptionHandlingToIgnore();

            FluentCqlToolkit cqlToolkit = new FluentCqlToolkit(loggerFactory)
                .SetExceptionHandlingToIgnore()
                .AddCqlLibrariesFromDirectory(opt.CqlInDirectory);

            if (!cqlToolkit.CqlToElmTranslations.Any())
                logger.LogWarning("Exiting: No CQL libraries were found in the CQL input directory.");

            FluentElmToolkit elmToolkit;
            if (translateCql)
            {
                cqlToolkit.TranslateCqlToElm();

                if (opt.ElmOutDirectory is { } elmOutDir)
                    cqlToolkit.SaveElmFilesToDirectory(
                        elmOutDir,
                        writeIndented:true,
                        DirectoryPreparationStrategy.DeleteFiles("*.json"));

                elmToolkit = cqlToolkit.ToFluentElmToolkit();
            }
            else
            {
                elmToolkit = new FluentElmToolkit(loggerFactory)
                             .SetExceptionHandlingToIgnore()
                             .AddElmFilesFromDirectory(
                                 opt.ElmInDirectory!,
                                 filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name));
            }

            if (opt.CSharpOutDirectory is { } dirOutCS)
                elmToolkit
                    .CompileElmToAssemblies()
                    .SaveCSharpFilesToDirectory(dirOutCS, DirectoryPreparationStrategy.DeleteFiles("*.g.cs"));

            if (opt.AssemblyOutDirectory is { } dirOutDll)
                elmToolkit
                    .CompileElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectory(dirOutDll, DirectoryPreparationStrategy.DeleteFiles("*.dll"));

            if (opt is
                {
                    FhirOutDirectory: { } dirOutFhir,
                    FhirCanonicalRootUrl: var canonicalRootUrl,
                    FhirOverrideDate: var overrideDate
                })
            {
                packagingToolkit
                    .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit)
                    .PackageFhirResources(canonicalRootUrl, overrideDate)
                    .SaveFhirResources(dirOutFhir, DirectoryPreparationStrategy.DeleteFiles("*.json"));
            }

            /*
            if (opt is
                    // Check that we have all the required options
                    {
                        CqlInDirectory: { } cqlInDir,
                        ElmInDirectory: { } elmInDir,
                        FhirOutDirectory: { } fhirOutDir,
                        FhirCanonicalRootUrl: var canonicalRootUrl,
                        FhirOverrideDate: var overrideDate
                    }
                // Check that we have the libraries produced by the ElmToolkit
                && elmToolkit.GetCompletedElmToAssemblyCompilations(t => t.elmLibrary)
                             .ToArray() is { Length: > 0 } libraries
                // Check that we have the assemblies produced by the ElmToolkit
                && elmToolkit.GetCompletedElmToAssemblyCompilations()
                             .ToDictionary(
                                 t => t.versionedLibraryIdentifier.ToString(),
                                 t => new AssemblyBinaryWithSourceCode(
                                     assemblyBytes: t.assemblyBinary,
                                     sourceCodeFileName: "", // Won't get used
                                     sourceCode: t.csharpSourceCode,
                                     debugSymbolsBytes: t.debugSymbolsBinary)) is { } assembliesByLibraryName)
            {
                _ = resourcePackager;
                LibrarySet elmLibrarySet = new LibrarySet("", libraries);
                IReadOnlyCollection<Resource> resources = resourcePackager.PackageResources(
                    elmInDir,
                    cqlInDir,
                    canonicalRootUrl?.ToString(),
                    elmLibrarySet,
                    assembliesByLibraryName);

                fhirOutDir.Recreate();
                foreach (var resource in resources)
                    fhirResourceFileWriter.SaveResource(resource, fhirOutDir, overrideDate);
            }
            */

            return 0;
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred while running the packager");
            Console.Error.WriteLine(
                "An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
    }
}

file static class X
{
    public static TSelf PickValueAndSwitch<TSelf, TValue>(
        this TSelf self,
        Func<TSelf, TValue?> valueSelector,
        Action<TSelf, TValue>? ifHasValue = null,
        Action<TSelf>? ifNoValue = null)
        where TValue : class
    {
        if (valueSelector(self) is { } val)
            ifHasValue?.Invoke(self, val);
        else
            ifNoValue?.Invoke(self);
        return self;
    }

    public static void Recreate(this DirectoryInfo dir)
    {
        if (dir.Exists) dir.Delete(true);
        dir.Create();
    }
}