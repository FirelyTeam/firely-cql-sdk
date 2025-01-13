/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using static Hl7.Cql.Abstractions.Exceptions.ProcessBatchItemExceptionHandling;

namespace Hl7.Cql.Packager;

internal class PackagerCli(
    IEnumerable<ILoggerProvider> loggerProviders,
    ILogger<PackagerCli> logger,
    OptionsConsoleDumper optionsConsoleDumper,
    IOptions<PackagerCliOptions> packagerCliProgramOptions,
    IOptions<CqlToResourcePackagingOptions> packagingOptions)
{
    public int Run(bool translateCql = false)
    {
        try
        {
            optionsConsoleDumper.DumpToConsole();
            var programOpt = packagerCliProgramOptions.Value;
            var packagingOpt = packagingOptions.Value;

            ElmApi elmApi;
            if (translateCql)
            {
                packagingOpt.ElmDirectory.Delete(true);
                elmApi = CqlApi.Create(CqlApiOptions.Default)
                            .WithOptions(o => o with
                            {
                                LoggingOptions = o.LoggingOptions with { LoggerProviders = [.. loggerProviders] },
                                ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
                            })
                            .AddCqlLibrariesFromDirectory(packagingOpt.CqlDirectory)
                            .Translate()
                            .SaveElmFileToDirectory(packagingOpt.ElmDirectory)
                            .Compile();

            }
            else
            {
                elmApi = ElmApi.Create(ElmApiOptions.Default)
                            .WithOptions(o => o with
                            {
                                LoggingOptions = o.LoggingOptions with { LoggerProviders = [.. loggerProviders] },
                                ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
                            })
                            .AddElmFilesFromDirectory(packagingOpt.ElmDirectory,
                                                      filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name))
                            .Compile();
            }

            if (programOpt.OutDirectoryCSharp is {} dirOutCS)
            {
                dirOutCS.Recreate();
                elmApi.SaveCSharpFilesToDirectory(dirOutCS);
            }

            if (programOpt.OutDirectoryAssemblies is {} dirOutDll)
            {
                dirOutDll.Recreate();
                elmApi.SaveAssemblyBinariesToDirectory(dirOutDll);
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
    public static void Recreate(this DirectoryInfo dir)
    {
        if (dir.Exists) dir.Delete(true);
        dir.Create();
    }
}