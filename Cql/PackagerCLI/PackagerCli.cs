/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Packaging.Fluent;
using Hl7.Cql.Packaging;

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

            var packagingToolkit = new PackagingToolkit(loggerFactory)
                .SetExceptionHandlingToIgnore();

            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory)
                .SetExceptionHandlingToIgnore()
                .AddCqlLibrariesFromDirectory(opt.CqlInDirectory);

            if (!cqlToolkit.CqlToolkitConversions.Any())
                logger.LogWarning("Exiting: No CQL libraries were found in the CQL input directory.");

            ElmToolkit elmToolkit;
            if (translateCql)
            {
                cqlToolkit.TranslateCqlToElm();

                if (opt.ElmOutDirectory is { } elmOutDir)
                    cqlToolkit.SaveElmFilesToDirectory(
                        elmOutDir,
                        writeIndented:true,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

                elmToolkit = cqlToolkit.ToFluentElmToolkit();
            }
            else
            {
                elmToolkit = new ElmToolkit(loggerFactory)
                             .SetExceptionHandlingToIgnore()
                             .AddElmFilesFromDirectory(
                                 opt.ElmInDirectory!,
                                 filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name));
            }

            if (opt.CSharpOutDirectory is { } dirOutCS)
                elmToolkit
                    .CompileElmToAssemblies()
                    .SaveCSharpFilesToDirectory(dirOutCS, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

            if (opt.AssemblyOutDirectory is { } dirOutDll)
                elmToolkit
                    .CompileElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
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
                    .PackageFhirResources(canonicalRootUrl, overrideDate)
                    .SaveFhirResources(dirOutFhir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));
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