/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using CqlLibraryString = Hl7.Cql.CqlToElm.CqlLibraryString;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    public static CqlToolkit AddCqlLibraries(
        this CqlToolkit cqlToolkit,
        params CqlLibraryString[] cqlLibraries)
    {
        return cqlToolkit.AddCqlLibraries(cqlLibraries);
    }

    public static CqlToolkit AddCqlLibrariesFromDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.cql", options ?? Defaults.EnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return cqlToolkit.AddCqlLibraryFiles(files);
    }

    public static CqlToolkit AddCqlLibraryFiles(
        this CqlToolkit cqlToolkit,
        IEnumerable<FileInfo> files)
    {
        var logger = cqlToolkit.CreateLogger();
        var cqlLibraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading CQL from file: {file}", f);
                var cqlContent = File.ReadAllText(f.FullName);
                var cqlLibrary = CqlLibraryString.Parse(cqlContent);
                return cqlLibrary;
            }); // Log errors

        return cqlToolkit.AddCqlLibraries(cqlLibraries);
    }
}
