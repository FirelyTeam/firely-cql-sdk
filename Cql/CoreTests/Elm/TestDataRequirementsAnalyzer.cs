/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
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

        // Condition+Patient+ServiceRequest is from TestRetrieve, Observation is from TestRetrieveInclude
        actual.Should().BeEquivalentTo([FHIRAllTypes.Patient, FHIRAllTypes.ServiceRequest, FHIRAllTypes.Condition, FHIRAllTypes.Observation]);
    }

    [TestMethod]
    public void ResolveCrossLibraryCodeSystemRef()
    {
        // Arrange - load a library that references a code from an included library,
        // where the code's code system is defined in the included library only.
        var lset = new LibrarySet();
        lset.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "TestCodeSystemRetrieve");
        var main = lset.GetLibrary("TestCodeSystemRetrieve-1.0.0");

        // Act - this should not throw "Cannot resolve CodeSystemRef with name TaskCodeSystem"
        var analyzer = new DataRequirementsAnalyzer(lset, main);
        var dataRequirements = analyzer.Analyze();

        // Assert
        var taskRequirement = dataRequirements.FirstOrDefault(dr => dr.Type == FHIRAllTypes.Task);
        taskRequirement.Should().NotBeNull();
        taskRequirement!.CodeFilter.Should().HaveCount(1);
        taskRequirement.CodeFilter[0].Code.Should().HaveCount(1);
        taskRequirement.CodeFilter[0].Code[0].Code.Should().Be("fulfill");
        taskRequirement.CodeFilter[0].Code[0].System.Should().Be("http://hl7.org/fhir/CodeSystem/task-code");
    }

    [TestMethod]
    public void ResolveCrossLibraryCodeSystemRefFromConceptCodeRefAlias()
    {
        // Arrange - load a library with a local ConceptDef that references a code
        // from an included library via CodeRef.libraryName.
        var lset = new LibrarySet();
        lset.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "TestCodeSystemConceptRetrieve");
        var main = lset.GetLibrary("TestCodeSystemConceptRetrieve-1.0.0");

        // Act
        var analyzer = new DataRequirementsAnalyzer(lset, main);
        var dataRequirements = analyzer.Analyze();

        // Assert
        var taskRequirement = dataRequirements.FirstOrDefault(dr => dr.Type == FHIRAllTypes.Task);
        taskRequirement.Should().NotBeNull();
        taskRequirement!.CodeFilter.Should().HaveCount(1);
        taskRequirement.CodeFilter[0].Code.Should().HaveCount(1);
        taskRequirement.CodeFilter[0].Code[0].Code.Should().Be("fulfill");
        taskRequirement.CodeFilter[0].Code[0].System.Should().Be("http://hl7.org/fhir/CodeSystem/task-code");
    }

	[TestMethod]
	public void TestSimplifyRequirements()
    {
        // Create a few DataRequirements with overlapping codes and types
        var dr1 = new DataRequirement
        {
            Type = FHIRAllTypes.Condition,
            ProfileElement = [new Canonical("http://example.org/a"), new Canonical("http://example.org/b")],
            MustSupportElement = [new FhirString("code"), new FhirString("subject")],
            CodeFilter =
            [
                new DataRequirement.CodeFilterComponent()
                {
                    Path = "code",
                    ValueSet = "http://example.org/ValueSet/ConditionCodes"
                }
            ]
        };

        var dr2 = new DataRequirement
        {
            Type = FHIRAllTypes.Condition,
            ProfileElement = [new Canonical("http://example.org/a"), new Canonical("http://example.org/z")],
            MustSupportElement = [new FhirString("active")],
            CodeFilter =
            [
                new DataRequirement.CodeFilterComponent()
                {
                    Path = "code",
                    ValueSet = "http://example.org/ValueSet/ConditionCodes2"
                }
            ]
        };

        var dr3 = new DataRequirement
        {
            Type = FHIRAllTypes.Observation,
            ProfileElement = [new Canonical("http://example.org/o")],
        };

        var result = DataRequirementsAnalyzer.Combine([dr1, dr2, dr3]);

        // Check that the result has the expected properties
        result.Count.Should().Be(2);
        result[0].Type.Should().Be(FHIRAllTypes.Condition);
        result[0].ProfileElement.Should().BeEquivalentTo([new Canonical("http://example.org/a"), new Canonical("http://example.org/b"), new Canonical("http://example.org/z")]);
        result[0].MustSupportElement.Should().BeEquivalentTo([new FhirString("code"), new FhirString("subject"), new FhirString("active")]);
        result[0].CodeFilter.Count.Should().Be(2);
        result[0].CodeFilter[0].Path.Should().Be("code");
        result[0].CodeFilter[0].ValueSet.Should().Be("http://example.org/ValueSet/ConditionCodes");
        result[0].CodeFilter[1].Path.Should().Be("code");
        result[0].CodeFilter[1].ValueSet.Should().Be("http://example.org/ValueSet/ConditionCodes2");
        result[1].Type.Should().Be(FHIRAllTypes.Observation);
        result[1].ProfileElement.Should().BeEquivalentTo([new Canonical("http://example.org/o")]);
        result[1].MustSupportElement.Should().BeEmpty();
        result[1].CodeFilter.Should().BeEmpty();
    }
}
