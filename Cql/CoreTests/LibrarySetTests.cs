/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;

namespace CoreTests;

[TestClass]
public class LibrarySetTests
{

    [TestMethod]
    public void LoadLibraryAndDependencies_ReturnsLibraryAndDependencies_WhenGivenDirectoryAndLibraryName()
    {
        LibrarySet librarySet = new();
        var libraries = librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.DqmQiCore2025.ElmDir,  "CMS125FHIRBreastCancerScreen");
        Assert.IsTrue(libraries.Count == 10, "Expected 10 libraries to load for BreastCancerScreeningFHIR");
        Assert.IsTrue(librarySet.Cast<object>().Count() == 10, "Expected to enumerate over 10 libraries for BreastCancerScreeningFHIR");
    }

    [TestMethod]
    public void LoadLibraryAndDependencies_ReturnsTopologicallyOrderedLibraries_WhenEnumerating()
    {
        LibrarySet librarySet = new();
        var libraries = librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.DqmQiCore2025.ElmDir, "CMS125FHIRBreastCancerScreen");
        var list = string.Join(", ", libraries.Select(l => l.identifier.id));
        Assert.AreEqual("CMS125FHIRBreastCancerScreen, FHIRHelpers, SupplementalDataElements, QICoreCommon, AdultOutpatientEncounters, Hospice, Status, PalliativeCare, AdvancedIllnessandFrailty, CumulativeMedicationDuration", list);
    }
}
