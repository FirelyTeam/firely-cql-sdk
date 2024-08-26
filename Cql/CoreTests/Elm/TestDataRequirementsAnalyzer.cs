using System.IO;
using System.Linq;
using FluentAssertions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

[TestClass]
public class TestDataRequirementsAnalyzer
{
    private static (LibrarySet,Library) LoadTestLibrarySet()
    {
        var lset = new LibrarySet();
        lset.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "TestRetrieve" );
        var main = lset.GetLibrary("TestRetrieve-1.0.1");
        return (lset, main);
    }


    [TestMethod]
    public void ConvertRetrievesToDataRequirements()
    {
        // Arrange
        var (lset, main) = LoadTestLibrarySet();

        // Act
        var analyzer = new DataRequirementsAnalyzer(lset,main);
        var dataRequirements = analyzer.Analyze();

        // Assert
        var actual = dataRequirements.Select(dr => dr.Type).Distinct().ToArray();
        actual.Should().BeEquivalentTo([FHIRAllTypes.Patient]);
    }
}