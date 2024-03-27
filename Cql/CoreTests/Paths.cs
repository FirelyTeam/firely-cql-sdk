using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace CoreTests;

internal static class Paths
{
    private static DirectoryInfo Solution { get; } = GetDir();

    public static class Cms
    {
        public static DirectoryInfo ElmDir { get; } = GetDir("LibrarySets", "CMS", "Elm");
    }

    // public static class Testing
    // {
    //     public static DirectoryInfo ElmDir { get; } = GetDir("LibrarySets", "Testing", "Elm");
    //
    //     public static FileInfo Medication_Request_Example_JsonFile { get; } = GetFile(ElmDir, @"Test\Medication_Request_Example.json");
    //     public static FileInfo FHIRHelpers_JsonFile { get; } = GetFile(ElmDir, @"Libs\\FHIRHelpers-4.0.1.json");
    //     public static FileInfo Aggregates_JsonFile { get; } = GetFile(ElmDir, @"Test\\Aggregates-1.0.0.json");
    //     public static FileInfo FHIRTypeConversionTest_JsonFile { get; } = GetFile(ElmDir, @"HL7\\FHIRTypeConversionTest.json");
    //     public static FileInfo QueriesTest_JsonFile { get; } = GetFile(ElmDir, @"Test\QueriesTest-1.0.0.json");
    // }

    private static FileInfo GetFile(DirectoryInfo root, params string[] subPaths)
    {
        Debug.Assert(subPaths.Length > 0);
        var paths = new string[subPaths.Length + 1];
        paths[0] = root.FullName;
        subPaths.CopyTo(paths, 1);
        return new FileInfo(Path.Combine(paths));
    }

    private static DirectoryInfo GetDir(params string[] subPaths)
    {
        if (subPaths?.Length > 0)
        {
            var paths = new string[subPaths.Length + 1];
            paths[0] = Solution.FullName;
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