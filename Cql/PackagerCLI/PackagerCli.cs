/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.App;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using static Hl7.Cql.Abstractions.Exceptions.ProcessBatchItemExceptionHandling;

namespace Hl7.Cql.Packager;

internal class PackagerCli
(
    IEnumerable<ILoggerProvider> loggerProviders,
    ILogger<PackagerCli> logger,
    OptionsConsoleDumper optionsConsoleDumper,
    IOptions<PackagerCliOptions> packagerCliOptions,
    ResourcePackager resourcePackager)
{
    public int Run(bool translateCql = false)
    {
        try
        {
            optionsConsoleDumper.DumpToConsole();
            var opt = packagerCliOptions.Value;

            var loggingOptions = LoggingOptions.Default with { LoggerProviders = [.. loggerProviders] };

            ElmApi elmApi;
            if (translateCql)
            {
                elmApi = CqlApi
                         .Create(CqlApiOptions.Default with
                         {
                             LoggingOptions = loggingOptions,
                             ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
                         })
                         .UseValue(
                             _ => opt.CqlInDirectory,
                             withValue: (api, cql) => api.AddCqlLibrariesFromDirectory(cql),
                             withNoValue: _ => logger.LogWarning("No input directory specified for ELM. Nothing to do."))
                         .Translate()
                         .UseValue(
                             _ => opt.ElmOutDirectory,
                             withValue: (api, elm) =>
                             {
                                 elm.Recreate();
                                 api.SaveElmFileToDirectory(elm);
                             },
                             withNoValue: _ => logger.LogInformation("No out directory specified for ELM."))
                         .Compile();
            }
            else
            {
                elmApi = ElmApi
                         .Create(ElmApiOptions.Default with
                         {
                             LoggingOptions = loggingOptions,
                             ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
                         })
                         .UseValue(
                             _ => opt.ElmInDirectory,
                             withValue: (api, elm) => api.AddElmFilesFromDirectory(elm, filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name)),
                             withNoValue: _ => logger.LogWarning("No input directory specified for ELM. Nothing to do."))
                         .Compile();
            }

            if (opt.CSharpOutDirectory is { } dirOutCS)
            {
                dirOutCS.Recreate();
                elmApi.SaveCSharpFilesToDirectory(dirOutCS);
            }

            if (opt.AssemblyOutDirectory is { } dirOutDll)
            {
                dirOutDll.Recreate();
                elmApi.SaveAssemblyBinariesToDirectory(dirOutDll);
            }

            if (opt is
                {
                    CqlInDirectory: { } inDirCql,
                    ElmInDirectory: { } inDirElm,
                    FhirOutDirectory: { } dirOutFhir,
                    FhirCanonicalRootUrl: var canonicalRootUrl
                })
            {
                _ = resourcePackager;
                /*dirOutFhir.Recreate();
                LibrarySet elmLibrarySet = null!;
                IReadOnlyDictionary<string, AssemblyDataWithSourceCode> assembliesByLibraryName = null!;
                IReadOnlyCollection<Resource> resources = resourcePackager.PackageResources(
                    inDirElm,
                    inDirCql,
                    canonicalRootUrl?.ToString(),
                    elmLibrarySet,
                    assembliesByLibraryName);*/
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
    public static TSelf UseValue<TSelf, TValue>(
        this TSelf self,
        Func<TSelf, TValue?> maybeSelector,
        Action<TSelf, TValue>? withValue = null,
        Action<TSelf>? withNoValue = null)
        where TValue : class
    {
        if (maybeSelector(self) is { } val)
            withValue?.Invoke(self, val);
        else
            withNoValue?.Invoke(self);
        return self;
    }

    public static void Recreate(this DirectoryInfo dir)
    {
        if (dir.Exists) dir.Delete(true);
        dir.Create();
    }
}