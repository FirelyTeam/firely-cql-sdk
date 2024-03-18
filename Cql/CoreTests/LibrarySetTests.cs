using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using Hl7.Cql.Compiler;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class LibrarySetTests
{
    public static DirectoryInfo CmsDirectory { get; } = GetCmsDirectory();

    private static DirectoryInfo GetCmsDirectory()
    {
        var solutionDirectory = GetSolutionDirectory();
        var dir = new DirectoryInfo(Path.Combine(solutionDirectory.FullName, "LibrarySets", "CMS", "Elm"));
        return dir;
    }


    [TestMethod]
    public void LoadLibraryAndDependencies_ReturnsLibraryAndDependencies_WhenGivenDirectoryAndLibraryName()
    {
        LibrarySet librarySet = new();
        var libraries = librarySet.LoadLibraryAndDependencies(CmsDirectory, "DischargedonAntithromboticTherapyFHIR");
        Assert.IsTrue(libraries.Count == 6, "Expected 6 libraries to load for DischargedonAntithromboticTherapyFHIR");
        Assert.IsTrue(librarySet.Cast<object>().Count() == 6, "Expected 6 libraries to load for DischargedonAntithromboticTherapyFHIR");
    }


    [TestMethod]
    public void LoadLibraryAndDependencies_CrossLibraryCodeSystems()
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(CmsDirectory, "CumulativeMedicationDuration");
        var f = new LibrarySetExpressionBuilderFactory(NullLoggerFactory.Instance);
        var defs = f.LibrarySetExpressionBuilder.ProcessLibrarySet(librarySet);
        var lambdaExpression = defs["CumulativeMedicationDuration-4.0.000", "Every eight hours (qualifier value)"];
        Assert.IsNotNull(lambdaExpression);

        var del = lambdaExpression.Compile(true);
        var res = (CqlCode)del.DynamicInvoke(new CqlContext(CqlOperators.Create(f.FhirTypeResolver, f.TypeConverter)));
        Assert.AreEqual(("307469008", "http://snomed.info/sct"), (res.code, res.system));
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