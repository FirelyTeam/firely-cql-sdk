/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.IO;

namespace CqlSdkExamplesPreview;

internal partial class Program
{
    public void PickExample(string? code)
    {
        // <codegen-switch>
        switch (code)
        {
            case "000": RunAll(); return;
        }
        // </codegen-switch>
    }

    private void SetCurrentDirectory(string path)
    {
        DirectoryPreparationStrategy.CreateIfNotExists(new DirectoryInfo(path));
        Environment.CurrentDirectory = path;
    }

    private static readonly string InitialCurrentDirectory = Environment.CurrentDirectory;

    private static readonly string LibrarySetsDirectory =
        (new DirectoryInfo(Environment.CurrentDirectory)
             .FindParentDirectoryContaining("LibrarySets")
         ?? throw new DirectoryNotFoundException("Could not find LibrarySets directory in any of the parent directories.")
        )
        .CreateSubdirectory("LibrarySets")
        .FullName;
}

file static class DirectoryInfoExtensions
{
    public static IEnumerable<DirectoryInfo> SelfAndParents(
        this DirectoryInfo dir)
    {
        var current = dir;
        while (current != null)
        {
            yield return current;
            current = current.Parent;
        }
    }

    public static DirectoryInfo? FindParentDirectoryContaining(
        this DirectoryInfo dir,
        string searchPattern,
        SearchOption searchOption = SearchOption.TopDirectoryOnly) =>
        dir.SelfAndParents()
           .FirstOrDefault(d => d.EnumerateFileSystemInfos(searchPattern, searchOption).Any());
}
