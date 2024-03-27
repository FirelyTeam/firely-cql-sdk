using System.Linq;
using Hl7.Cql.Compiler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class LibrarySetTests
{

    [TestMethod]
    public void LoadLibraryAndDependencies_ReturnsLibraryAndDependencies_WhenGivenDirectoryAndLibraryName()
    {
        LibrarySet librarySet = new();
        var libraries = librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.Cms.ElmDir,"DischargedonAntithromboticTherapyFHIR");
        Assert.IsTrue(libraries.Count == 6, "Expected 6 libraries to load for DischargedonAntithromboticTherapyFHIR");
        Assert.IsTrue(librarySet.Cast<object>().Count() == 6, "Expected 6 libraries to load for DischargedonAntithromboticTherapyFHIR");
    }

    [TestMethod]
    public void LoadLibraryAndDependencies_ReturnsTopologicallyOrderedLibraries_WhenEnumerating()
    {
        LibrarySet librarySet = new();
        var libraries = librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.Cms.ElmDir, "DischargedonAntithromboticTherapyFHIR");
        Assert.IsTrue(libraries.Count == 6, "Expected 6 libraries to load for DischargedonAntithromboticTherapyFHIR");
        Assert.IsTrue(librarySet.Cast<object>().Count() == 6, "Expected 6 libraries to load for DischargedonAntithromboticTherapyFHIR");
        var list = string.Join(", ", libraries.Select(l => l.identifier.id));
        Assert.AreEqual("DischargedonAntithromboticTherapyFHIR, FHIRHelpers, CQMCommon, QICoreCommon, SupplementalDataElements, TJCOverall", list);
    }
}