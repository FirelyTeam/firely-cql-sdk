/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void LoadCqlFromDirSaveElmToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "210 Load CQL from dir, Save ELM to dir"));
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from a directory
        var cqlToolkit = new CqlToolkit(loggerFactory);
        var cqlDirectory = new DirectoryInfo("input/cql");
        cqlToolkit.AddCqlLibrariesFromDirectory(cqlDirectory);

        // Translate CQL to ELM
        cqlToolkit.TranslateToElm();

        // Save ELM files to a directory
        var elmOutputDirectory = new DirectoryInfo("output/elm");
        cqlToolkit.SaveElmFilesToDirectory(elmOutputDirectory);

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}
