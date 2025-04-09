/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
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

internal class PackagerCli
(
    ILoggerFactory loggerFactory,
    ILogger<PackagerCli> logger,
    OptionsConsoleDumper optionsConsoleDumper,
    IOptions<PackagerCliOptions> packagerCliOptions,
    IOptions<CqlOptions> cqlOptions,
    IOptions<ElmOptions> elmOptions)
{
    public int Run(bool translateCql = false)
    {
        try
        {
            optionsConsoleDumper.DumpToConsole();
            CqlOptions cqlOpt = cqlOptions.Value;
            ElmOptions elmOpt = elmOptions.Value;

            var opt = packagerCliOptions.Value;
            var cqlFromDirectory = opt.CqlFromDirectory;
            var elmFromDirectory = opt.ElmFromDirectory;
            var elmOutDirectory = opt.ElmOutDirectory;
            var cSharpOutDirectory = opt.CSharpOutDirectory;
            var assemblyOutDirectory = opt.AssemblyOutDirectory;
            var fhirOutDirectory = opt.FhirOutDirectory;
            var fhirCanonicalRootUrl = opt.FhirCanonicalRootUrl;
            var fhirOverrideDate = opt.FhirOverrideDate;
            var jsonIndentEnable = opt.JsonIndentEnable;
            var outDirectories = opt.GetOutDirectories();

            if (DateTime.Now.Day > 0)
                return 0;

            if (cqlFromDirectory is not { Exists: true })
            {
                logger.LogWarning("Exiting: Cql input directory must be specified and exist.");
                return -1;
            }

            if (!translateCql && elmFromDirectory is not { Exists: true })
            {
                logger.LogWarning("Exiting: ELM input directory must be specified and exist.");
                return -1;
            }

            if (outDirectories.All(o => o.dir is null))
            {
                logger.LogWarning("Exiting: At least one output directory must be specified for a particular type.");
                return -1;
            }

            var packagingToolkit = new PackagingToolkit(loggerFactory)
                .SetIgnoreEnumerationExceptions();

            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt)
                                    .SetIgnoreEnumerationExceptions()
                                    .AddCqlLibrariesFromDirectory(cqlFromDirectory);

            if (!cqlToolkit.Conversions.Any())
                logger.LogWarning("Exiting: No CQL libraries were found in the CQL input directory.");

            ElmToolkit elmToolkit;
            if (translateCql)
            {
                cqlToolkit.ConvertCqlToElm();

                if (elmOutDirectory is { } elmOutDir)
                    cqlToolkit.SaveElmFilesToDirectory(
                        elmOutDir,
                        writeIndented: true,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

                elmToolkit = cqlToolkit.CreateElmToolkit(elmOpt);
            }
            else
            {
                elmToolkit = new ElmToolkit(loggerFactory, elmOpt)
                             .SetIgnoreEnumerationExceptions(false)
                             .AddElmFilesFromDirectory(
                                 elmFromDirectory!,
                                 filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name));
            }

            if (cSharpOutDirectory is not null)
                elmToolkit
                    .ConvertElmToAssemblies()
                    .SaveCSharpFilesToDirectory(cSharpOutDirectory, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

            if (assemblyOutDirectory is not null)
                elmToolkit
                    .ConvertElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectory(assemblyOutDirectory, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));

            if (fhirOutDirectory is not null)
            {
                Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null;
                if (jsonIndentEnable)
                    configureJsonSerializerOptions = options =>
                    {
                        options.WriteIndented = true;
                        return options;
                    };

                packagingToolkit
                    .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit)
                    .ConvertToFhirResources(fhirCanonicalRootUrl, fhirOverrideDate)
                    .SaveFhirResourcesToDirectory(
                        fhirOutDirectory,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                        configureJsonSerializerOptions);
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