/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Runtime.IO;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    public static CqlToolkit SaveElmFilesToDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        bool writeIndented = true,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);

        var logger = cqlToolkit.CreateLogger();

        foreach (var (libraryIdentifier, elmLibrary) in cqlToolkit.GetCqlToolkitResults())
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryIdentifier}.json");
            File.WriteAllText(fileName, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }

        return cqlToolkit;
    }
}
