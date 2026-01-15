/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace CoreTests;

internal static class LibrarySetsDirs
{
    private static DirectoryInfo SolutionDir { get; } = GetDir();

    public static class Demo
    {
        public static DirectoryInfo ElmDir { get; } = GetDir("LibrarySets", "Demo", "Elm");
        public static DirectoryInfo ResourcesDir { get; } = GetDir("LibrarySets", "Demo", "Resources");
    }

    public static class DqmQiCore2025
    {
        public static DirectoryInfo ElmDir { get; } = GetDir("LibrarySets", "dqm-content-qicore-2025", "Elm");
    }

    private static DirectoryInfo GetDir(params string[] subPaths)
    {
        if (subPaths?.Length > 0)
        {
            var paths = new string[subPaths.Length + 1];
            paths[0] = SolutionDir.FullName;
            subPaths.CopyTo(paths, 1);
            return new DirectoryInfo(Path.Combine(paths));
        }

        var currentDir = new DirectoryInfo(Directory.GetCurrentDirectory());
        var solDir =
            currentDir.FindParentDirectoryContaining("*.sln")
            ?? currentDir.FindParentDirectoryContaining("*.slnx")
            ?? throw new InvalidOperationException("Could not find an parent directory containing a solution file.");
        return solDir;
    }
}
