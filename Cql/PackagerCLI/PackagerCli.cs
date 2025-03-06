/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Runtime.IO;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Packager;

internal class PackagerCli(
    ILoggerFactory loggerFactory,
    ILogger<PackagerCli> logger,
    OptionsConsoleDumper optionsConsoleDumper,
    IOptions<PackagerCliOptions> packagerCliOptions)
{
    public int Run(bool translateCql = false)
    {
        try
        {
            optionsConsoleDumper.DumpToConsole();

            var opt = packagerCliOptions.Value;
            if (opt.CqlFromDirectory is not { Exists:true })
            {
                logger.LogWarning("Exiting: Cql input directory must be specified and exist.");
                return -1;
            }

            if (!translateCql && opt.ElmFromDirectory is not { Exists: true })
            {
                logger.LogWarning("Exiting: ELM input directory must be specified and exist.");
                return -1;
            }

            if (opt.GetOutDirectories().All(o => o.dir is null))
            {
                logger.LogWarning("Exiting: At least one output directory must be specified for a particular type.");
                return -1;
            }

            var packagingToolkit = new PackagingToolkit(loggerFactory)
                .SetIgnoreEnumerationExceptions();

            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory)
                                    .SetIgnoreEnumerationExceptions()
                                    .AddCqlLibrariesFromDirectory(opt.CqlFromDirectory);

            if (!cqlToolkit.Conversions.Any())
                logger.LogWarning("Exiting: No CQL libraries were found in the CQL input directory.");

            ElmToolkit elmToolkit;
            if (translateCql)
            {
                cqlToolkit.ConvertCqlToElm();

                if (opt.ElmOutDirectory is { } elmOutDir)
                    cqlToolkit.SaveElmFilesToDirectory(
                        elmOutDir,
                        writeIndented:true,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

                elmToolkit = cqlToolkit.CreateElmToolkit();
            }
            else
            {
                elmToolkit = new ElmToolkit(loggerFactory).SetIgnoreEnumerationExceptions(false)
                                                          .AddElmFilesFromDirectory(
                                                              opt.ElmFromDirectory!,
                                                              filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name));
            }

            if (opt.CSharpOutDirectory is { } dirOutCS)
                elmToolkit
                    .ConvertElmToAssemblies()
                    .SaveCSharpFilesToDirectory(dirOutCS, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

            if (opt.AssemblyOutDirectory is { } dirOutDll)
                elmToolkit
                    .ConvertElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectory(dirOutDll, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));

            if (opt is
                {
                    FhirOutDirectory: { } dirOutFhir,
                    FhirCanonicalRootUrl: var canonicalRootUrl,
                    FhirOverrideDate: var overrideDate
                })
            {
                packagingToolkit
                    .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit)
                    .ConvertToFhirResources(canonicalRootUrl, overrideDate)
                    .SaveFhirResourcesToDirectory(dirOutFhir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));
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