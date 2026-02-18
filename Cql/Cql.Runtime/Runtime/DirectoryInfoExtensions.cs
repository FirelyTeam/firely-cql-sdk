/*
 * Copyright (c) 2024, NCQA and contributors
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

    /// <summary>
    /// Compares two directory paths to determine if they refer to the same directory.
    /// Uses normalized full paths with OS-appropriate case sensitivity.
    /// </summary>
    public static bool IsSameDirectory(this DirectoryInfo dir1, DirectoryInfo dir2)
    {
        var comparison = OperatingSystem.IsWindows()
            ? StringComparison.OrdinalIgnoreCase
            : StringComparison.Ordinal;

        return string.Equals(
            Path.GetFullPath(dir1.FullName).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar),
            Path.GetFullPath(dir2.FullName).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar),
            comparison);
    }
}