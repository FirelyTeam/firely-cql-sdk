/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Packager.Options;
using Hl7.Cql.Runtime.IO;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Packager.Commands.CqlToElm;

public class CqlToElmProgram
(
    ILoggerFactory loggerFactory,
    ILogger<CqlToElmProgram> logger,
    IOptions<CqlBindOptions> cqlOptions,
    IOptions<CqlToElmOptions> cqlToElmOptions) : IProgram
{
    public static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        CqlToElmCommand cqlToElmCommand) =>
        RunProgram<CqlToElmProgram>(
            console,
            loggingCommand,
            cqlToElmCommand.GetConfigMapping,
            (_, services) =>
                services.AddAndBindOptions<CqlToElmOptions>());

    public int Run()
    {
        var opt = cqlToElmOptions.Value;
        var cqlOpt = cqlOptions.Value;

        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt)
                                .SetIgnoreEnumerationExceptions()
                                .AddCqlLibrariesFromDirectory(opt.Cql);

        if (cqlToolkit.Conversions.Count == 0)
        {
            logger.LogInformation($"Exiting. No CQL libraries found in directory {opt.Cql}.");
            return ExitCode.NoCqlLibsInDir;
        }

        var cqlToolkitResultRecords =
            cqlToolkit.ConvertCqlToElm()
                      .GetCqlToolkitResults()
                      .ToList();

        if (cqlToolkitResultRecords.Count == 0)
        {
            logger.LogInformation("Exiting. No CQL libraries converted.");
            return ExitCode.NoElmLibsCompiled;
        }

        cqlToolkit.SaveElmFilesToDirectory(opt.Elm, writeIndented: opt.JsonPretty, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

        return ExitCode.Normal;
    }
}