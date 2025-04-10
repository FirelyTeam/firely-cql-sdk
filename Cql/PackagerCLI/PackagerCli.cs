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
    IOptions<CqlOptions> cqlOptions,
    IOptions<ElmOptions> elmOptions,
    IOptions<PackagingOptions> packagingOptions)
{
    public int Run(bool translateCql = false)
    {
        try
        {
            optionsConsoleDumper.DumpToConsole();
            CqlOptions cqlOpt = cqlOptions.Value;
            ElmOptions elmOpt = elmOptions.Value;
            PackagingOptions packOpt = packagingOptions.Value;

            //var opt = packagerCliOptions.Value;
            var cqlInDir = Dir(cqlOpt.CqlInDir);
            var elmOutDir = Dir(cqlOpt.ElmOutDir);
            var elmInDir = Dir(elmOpt.ElmInDir);
            var csharpOutDir = Dir(elmOpt.CSharpOutDir);
            var dllOutDir = Dir(elmOpt.DllOutDir);
            var fhirOutDir = Dir(packOpt.FhirOutDir);
            var fhirCanonicalRootUrl = packOpt.CanonicalRootUrl;
            var fhirOverrideDate = packOpt.OverrideDate;
            var jsonIndentEnable = packOpt.JsonIndentEnable;
            (string name, DirectoryInfo? dir)[] outDirectories =
                [
                    (name: "Elm", dir: elmOutDir),
                    (name: "CSharp", dir: csharpOutDir),
                    (name: "Dll", dir: dllOutDir),
                    (name: "Fhir Resource", dir: fhirOutDir)
                ];

            static DirectoryInfo? Dir(string? dir) => string.IsNullOrEmpty(dir) ? null : new DirectoryInfo(Path.GetFullPath(dir));

            // if (DateTime.Now.Day > 0)
            //     return 0;

            if (cqlInDir is not { Exists: true })
            {
                logger.LogWarning("Exiting: Cql input directory must be specified and exist.");
                return -1;
            }

            if (!translateCql && elmOutDir is not { Exists: true })
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
                                    .AddCqlLibrariesFromDirectory(cqlInDir);

            if (!cqlToolkit.Conversions.Any())
                logger.LogWarning("Exiting: No CQL libraries were found in the CQL input directory.");

            ElmToolkit elmToolkit;
            if (translateCql)
            {
                cqlToolkit.ConvertCqlToElm();

                if (elmDir is not null)
                    cqlToolkit.SaveElmFilesToDirectory(
                        elmDir,
                        writeIndented: true,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

                elmToolkit = cqlToolkit.CreateElmToolkit(elmOpt);
            }
            else
            {
                elmToolkit = new ElmToolkit(loggerFactory, elmOpt)
                             .SetIgnoreEnumerationExceptions(false)
                             .AddElmFilesFromDirectory(
                                 elmDir!,
                                 filePredicate: file => !HardCodedSkipElmFiles.FileNames.Contains(file.Name));
            }

            if (csharpOutDir is not null)
                elmToolkit
                    .ConvertElmToAssemblies()
                    .SaveCSharpFilesToDirectory(csharpOutDir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

            if (dllOutDir is not null)
                elmToolkit
                    .ConvertElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectory(dllOutDir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));

            if (fhirOutDir is not null)
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
                        fhirOutDir,
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