/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.IO;
using Hl7.Cql.Abstractions.Infrastructure;

namespace CoreTests;

internal static class LibrarySetsDirs
{
    public static DirectoryInfo SolutionDir { get; } = GetDir();

    public static class Demo
    {
        public static DirectoryInfo ElmDir { get; } = GetDir("LibrarySets", "Demo", "Elm");
        public static DirectoryInfo ResourcesDir { get; } = GetDir("LibrarySets", "Demo", "Resources");
    }

    public static class Cms
    {
        public static DirectoryInfo ElmDir { get; } = GetDir("LibrarySets", "CMS", "Elm");
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