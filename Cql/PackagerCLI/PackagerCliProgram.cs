/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using static Hl7.Cql.Abstractions.Exceptions.ProcessBatchItemExceptionHandling;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram
(
    ILogger<PackagerCliProgram> logger,
    OptionsConsoleDumper optionsConsoleDumper,
    IServiceProvider serviceProvider,
    IOptions<CqlToResourcePackagingOptions> packagingOptions,
    IOptions<CSharpCodeWriterOptions> cSharpOptions,
    IOptions<AssemblyDataWriterOptions> asmOptions)
{
    public int Run(bool translateCql = false)
    {
        try
        {
            optionsConsoleDumper.DumpToConsole();
            var packagingOpt = packagingOptions.Value;
            var cSharpOpt = cSharpOptions.Value;
            var asmOpt = asmOptions.Value;

            ElmApi elmApi;
            if (translateCql)
            {
                packagingOpt.ElmDirectory.Delete(true);
                elmApi = CqlApi.Create(serviceProvider)
                            .WithOptions(o => o with
                            {
                                ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
                            })
                            .AddCqlLibrariesFromDirectory(packagingOpt.CqlDirectory)
                            .Translate()
                            .SaveElmFileToDirectory(packagingOpt.ElmDirectory)
                            .Compile();

            }
            else
            {
                elmApi = ElmApi.Create(serviceProvider)
                            .WithOptions(o => o with
                            {
                                ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
                            })
                            .AddElmFilesFromDirectory(packagingOpt.ElmDirectory,
                                                      filePredicate: file =>
                                                          !HardCodedSkipElmFiles.FileNames.Contains(file.Name))
                            .Compile();
            }

            if (cSharpOpt.OutDirectory != null)
            {
                cSharpOpt.OutDirectory.Delete(true);
                elmApi = elmApi.SaveCSharpFilesToDirectory(cSharpOpt.OutDirectory);
            }

            if (asmOpt.OutDirectory != null)
            {
                asmOpt.OutDirectory.Delete(true);
                elmApi = elmApi.SaveAssemblyBinariesToDirectory(asmOpt.OutDirectory);
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

// internal class PackagerCliProgramOld
// (
//     ILogger<PackagerCliProgram> logger,
//     OptionsConsoleDumper optionsConsoleDumper,
//     CqlToResourcePackagingPipeline cqlToResourcePackagingPipeline)
// {
//     public int Run()
//     {
//         try
//         {
//             optionsConsoleDumper.DumpToConsole();
//             cqlToResourcePackagingPipeline.ProcessCqlToResources();
//             return 0;
//         }
//         catch (Exception e)
//         {
//             logger.LogError(e, "An error occurred while running the packager");
//             Console.Error.WriteLine(
//                 "An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
//             return -1;
//         }
//     }
// }