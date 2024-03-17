using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using Hl7.Cql.Compiler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class LibrarySetTests
{
    [TestMethod]
    public void LibraryLoader_Test()
    {
        var solutionDirectory = GetSolutionDirectory();
        var dir = new DirectoryInfo(Path.Combine(solutionDirectory.FullName, "LibrarySets", "CMS", "Elm"));

        LibrarySet librarySet = new();
        var libraries = librarySet.LoadLibraryAndDependencies(dir, "DischargedonAntithromboticTherapyFHIR");
        Assert.IsTrue(libraries.Count == 13, "Expected 13 libraries to load for DischargedonAntithromboticTherapyFHIR");
    }

    private static DirectoryInfo GetSolutionDirectory() =>
        new DirectoryInfo(Directory.GetCurrentDirectory())
            .Enumerate(d => d.Parent)
            .TakeWhile(d => d is not null)
            .LastOrDefault(d => d.EnumerateFiles("*.sln", SearchOption.TopDirectoryOnly).Any())
        ?? throw new InvalidOperationException("Could not find an ancestor directory containing a solution file.");
}


file static class Helper
{
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