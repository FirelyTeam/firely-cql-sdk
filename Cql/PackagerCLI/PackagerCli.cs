/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using static Hl7.Cql.Abstractions.Exceptions.ProcessBatchItemExceptionHandling;

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
        try
        {
            optionsConsoleDumper.DumpToConsole();
            var opt = packagerCliOptions.Value;

            IElmFluentToolkit elmToolkit;
            if (translateCql)
            {
                elmToolkit = new CqlToolkit(
                                 loggerFactory,
                                 new CqlToolkitSettings(ProcessBatchItemExceptionHandling: IgnoreExceptionAndContinue))
                             .AsFluent()
                             .WithValueSwitch(
                                 valueSelector: _ => opt.CqlInDirectory,
                                 ifHasValue: (api, cql) => api.AddCqlLibrariesFromDirectory(cql),
                                 ifNoValue: _ => logger.LogWarning("No input directory specified for ELM. Nothing to do."))
                             .ProcessCqlToElm()
                             .WithValueSwitch(
                                 valueSelector: _ => opt.ElmOutDirectory,
                                 ifHasValue: (api, elm) =>
                                 {
                                     elm.Recreate();
                                     api.SaveElmFileToDirectory(elm);
                                 },
                                 ifNoValue: _ => logger.LogInformation("No out directory specified for ELM."))
                             .ProcessCqlToAssemblies();
            }
            else
            {
                elmToolkit = new ElmToolkit(loggerFactory, new ElmToolkitSettings(ProcessBatchItemExceptionHandling: IgnoreExceptionAndContinue))
                             .AsFluent()
                             .WithValueSwitch(
                                 _ => opt.ElmInDirectory,
                                 ifHasValue: (api, elm) =>
                                     api.AddElmFilesFromDirectory(elm, filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name)),
                                 ifNoValue: _ => logger.LogWarning("No input directory specified for ELM. Nothing to do."))
                             .ProcessElmToAssemblies();
            }

            if (opt.CSharpOutDirectory is { } dirOutCS
                && elmToolkit.ElmToAssemblyConversions.Any(e => e.Value.CSharpSourceCode is not null))
            {
                dirOutCS.Recreate();
                elmToolkit.SaveCSharpFilesToDirectory(dirOutCS);
            }

            if (opt.AssemblyOutDirectory is { } dirOutDll
                && elmToolkit.ElmToAssemblyConversions.Any(e => e.Value.AssemblyBinary is not null))
            {
                dirOutDll.Recreate();
                elmToolkit.SaveAssemblyBinariesToDirectory(dirOutDll);
            }

            if (opt is
                    // Check that we have all the required options
                    {
                        CqlInDirectory: { } cqlInDir,
                        ElmInDirectory: { } elmInDir,
                        FhirOutDirectory: { } fhirOutDir,
                        FhirCanonicalRootUrl: var canonicalRootUrl,
                        FhirOverrideDate: var overrideDate
                    }
                // Check that we have the libraries produced by the ElmApi
                && elmToolkit.ElmToAssemblyConversions
                             .Select(e => e.Value.ElmLibrary)
                             .ToArray() is { Length: > 0 } libraries
                // Check that we have the assemblies produced by the ElmApi
                && elmToolkit.ElmToAssemblyConversions
                             .Where(e => e.Value is { AssemblyBinary: { }, CSharpSourceCode: { } })
                             .ToDictionary(
                                 e => e.Key.ToString(),
                                 e => new AssemblyDataWithSourceCode(
                                     assemblyBytes: e.Value.AssemblyBinary!,
                                     sourceCodeFileName: "", // Won't get used
                                     sourceCode: e.Value.CSharpSourceCode!,
                                     debugSymbolsBytes: e.Value.DebugSymbolsBinary)) is { } assembliesByLibraryName)
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
    public static TSelf WithValueSwitch<TSelf, TValue>(
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