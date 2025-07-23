/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

internal static class DirectoryInfoExtensions
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

    public static void Recreate(this DirectoryInfo dir)
    {
        if (dir.Exists) dir.Delete(true);
        dir.Create();
    }
}