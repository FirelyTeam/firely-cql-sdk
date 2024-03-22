using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreTests;

internal static class TestUtility
{
    public static DirectoryInfo SolutionDirectory { get; } = GetSolutionDirectory();
    public static DirectoryInfo CmsElmDirectory { get; } = GetCmsElmDirectory();

    private static DirectoryInfo GetSolutionDirectory() =>
        new DirectoryInfo(Directory.GetCurrentDirectory())
            .Enumerate(d => d.Parent)
            .TakeWhile(d => d is not null)
            .LastOrDefault(d => d.EnumerateFiles("*.sln", SearchOption.TopDirectoryOnly).Any())
        ?? throw new InvalidOperationException("Could not find an ancestor directory containing a solution file.");

    private static DirectoryInfo GetCmsElmDirectory()
    {
        var solutionDirectory = GetSolutionDirectory();
        var dir = new DirectoryInfo(Path.Combine(solutionDirectory.FullName, "LibrarySets", "CMS", "Elm"));
        return dir;
    }

    public static IEnumerable<T> Enumerate<T>(
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