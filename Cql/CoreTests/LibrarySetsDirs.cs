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

    public static class QICore2024
    {
        public static DirectoryInfo ElmDir { get; } = GetDir("LibrarySets", "ecqm-content-qicore-2024", "Elm");
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

        var solDir = new DirectoryInfo(Directory.GetCurrentDirectory())
                         .FindParentDirectoryContaining("*.sln")
                     ?? throw new InvalidOperationException("Could not find an parent directory containing a solution file.");
        return solDir;
    }
}
