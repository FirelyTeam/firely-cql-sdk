/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.Packager;

/// <summary>
/// Extension methods for CqlToolkit that support preserving subdirectory structure.
/// </summary>
internal static class CqlToolkitSubdirExtensions
{
    /// <summary>
    /// Saves the ELM files to the specified directory, optionally preserving subdirectory structure.
    /// </summary>
    public static CqlToolkit SaveElmFilesToDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        SubdirectoryMapper? subDirMapper = null,
        bool writeIndented = false,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        if (subDirMapper is null)
        {
            // Use default behavior - call original extension from CqlToElm
            return CqlToElm.Toolkit.Extensions.CqlToolkitExtensions.SaveElmFilesToDirectory(
                cqlToolkit,
                directory,
                writeIndented,
                directoryPreparationStrategy);
        }

        var prepElmDir = true;
        var logger = cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitSubdirExtensions));

        foreach (var (libraryIdentifier, elmLibrary) in cqlToolkit.GetCqlToolkitResults())
        {
            if (prepElmDir)
            {
                prepElmDir = false;
                (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);
            }

            var fileName = $"{libraryIdentifier}.json";
            var fullPath = subDirMapper.GetOutputPath(directory, libraryIdentifier, fileName);

            File.WriteAllText(fullPath, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fullPath);
        }

        return cqlToolkit;
    }
}
