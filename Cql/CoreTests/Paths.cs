using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreTests;

internal static class LibrarySetsDirs
{
    private static DirectoryInfo SolutionDir { get; } = GetDir();

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
                         .Enumerate(d => d.Parent)
                         .TakeWhile(d => d is not null)
                         .LastOrDefault(d => d.EnumerateFiles("*.sln", SearchOption.TopDirectoryOnly).Any())
                     ?? throw new InvalidOperationException("Could not find an ancestor directory containing a solution file.");
        return solDir;
    }

    private static IEnumerable<T> Enumerate<T>(
        this T seed,
        Func<T, T> getNext)
    {
        var current = seed;
        while (true)
        {
            yield return current;
            current = getNext(current);
        }
    }
}