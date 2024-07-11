using System.IO;
using System.Linq;
using FluentAssertions;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

[TestClass]
public class DataRequirementsAnalyzerTests
{
    [TestMethod]
    public void ConvertRetrievesToDataRequirements()
    {
        // Arrange
        var mainFile = new FileInfo("Input/ELM/HL7/TestRetrieve.json");
        var main = Library.LoadFromJson(mainFile);

        // Act
        var analyzer = new DataRequirementsAnalyzer(main);
        var dataRequirements = analyzer.Analyze();

        // Assert
        dataRequirements.Select(dr => dr.Type).Should()
                        .BeEquivalentTo([FHIRAllTypes.Patient, FHIRAllTypes.DiagnosticReport,
                                            FHIRAllTypes.Condition, FHIRAllTypes.ServiceRequest ]);
    }

}