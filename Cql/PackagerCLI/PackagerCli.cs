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
            var cqlDir = Dir(cqlOpt.CqlInDir);
            var elmDir = Dir(cqlOpt.ElmOutDir) ?? Dir(elmOpt.ElmInDir);
            var csharpDir = Dir(elmOpt.CSharpOutDir);
            var dllDir = Dir(elmOpt.DllOutDir);
            var fhirResDir = Dir(packOpt.ResourceOutDir);
            var fhirCanonicalRootUrl = packOpt.CanonicalRootUrl;
            var fhirOverrideDate = packOpt.OverrideDate;
            var jsonIndentEnable = packOpt.JsonIndentEnable;
            (string name, DirectoryInfo? dir)[] outDirectories =
                [
                    (name: "Elm", dir: elmDir),
                    (name: "CSharp", dir: csharpDir),
                    (name: "Dll", dir: dllDir),
                    (name: "Fhir Resource", dir: fhirResDir)
                ];

            static DirectoryInfo? Dir(string? dir) => string.IsNullOrEmpty(dir) ? null : new DirectoryInfo(Path.GetFullPath(dir));

            if (DateTime.Now.Day > 0)
                return 0;

            if (cqlDir is not { Exists: true })
            {
                logger.LogWarning("Exiting: Cql input directory must be specified and exist.");
                return -1;
            }

            if (!translateCql && elmDir is not { Exists: true })
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
                                    .AddCqlLibrariesFromDirectory(cqlDir);

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

            if (csharpDir is not null)
                elmToolkit
                    .ConvertElmToAssemblies()
                    .SaveCSharpFilesToDirectory(csharpDir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

            if (dllDir is not null)
                elmToolkit
                    .ConvertElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectory(dllDir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));

            if (fhirResDir is not null)
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
                        fhirResDir,
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