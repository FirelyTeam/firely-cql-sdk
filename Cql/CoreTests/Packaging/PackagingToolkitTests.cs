/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Fhir.Model;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests.Packaging;

[TestClass]
public class PackagingToolkitTests
{
    [TestMethod]
    public void PackageToFhirResources_WithADependencyAvailableOnlyAsElm_PackagesTheIncludingLibraryWithItsDataRequirements()
    {
        // Arrange - FHIRHelpers is held as ELM alone, as a host that loads published libraries by their ELM holds it.
        var elmToolkit = CreateElmToolkit();
        var cqlToolkit = CreateCqlToolkit();

        // Act
        var packagingToolkit = elmToolkit.PackageToFhirResources(cqlToolkit);

        // Assert - Condition, Patient and ServiceRequest are from TestRetrieve, Observation is from TestRetrieveInclude
        var packagedLibraries = CollectPackagedLibraries(packagingToolkit);
        packagedLibraries.Keys.Should().BeEquivalentTo(["TestRetrieve-1.0.1", "TestRetrieveInclude-1.0.1"]);
        var testRetrieve = packagedLibraries["TestRetrieve-1.0.1"];
        testRetrieve.DataRequirement.Select(dataRequirement => dataRequirement.Type).Should().BeEquivalentTo(
            [FHIRAllTypes.Patient, FHIRAllTypes.ServiceRequest, FHIRAllTypes.Condition, FHIRAllTypes.Observation]);
        testRetrieve.RelatedArtifact
            .Where(relatedArtifact => relatedArtifact.Type == RelatedArtifact.RelatedArtifactType.DependsOn)
            .Select(relatedArtifact => relatedArtifact.Resource)
            .Should().Contain(resource => resource.Contains("Library/FHIRHelpers|4.0.1"));
    }

    [TestMethod]
    public void AddReferenceLibraries_WithTheIdentifierOfAPackagingInput_IgnoresTheReferenceLibrary()
    {
        // Arrange
        var elmToolkit = CreateElmToolkit();
        var cqlToolkit = CreateCqlToolkit();
        var packagingToolkit = elmToolkit.CreatePackagingToolkit(cqlToolkit);

        // Act
        packagingToolkit
            .AddReferenceLibraries([ReadElm("TestRetrieveInclude.json")])
            .ConvertToFhirResources();

        // Assert
        CollectPackagedLibraries(packagingToolkit).Keys.Should().BeEquivalentTo(["TestRetrieve-1.0.1", "TestRetrieveInclude-1.0.1"]);
    }

    private static ElmToolkit CreateElmToolkit() =>
        new ElmToolkit()
            .AddElmLibraries([
                ReadElm("TestRetrieve.json"),
                ReadElm("TestRetrieveInclude.json"),
                ReadElm("FHIRHelpers-4.0.1.json")]);

    // The packager attaches the CQL as given; the ELM is what it analyzes.
    private static CqlToolkit CreateCqlToolkit() =>
        new CqlToolkit()
            .AddCqlLibraries([
                CqlLibraryString.Parse("library TestRetrieve version '1.0.1'"),
                CqlLibraryString.Parse("library TestRetrieveInclude version '1.0.1'")]);

    private static Dictionary<string, Hl7.Fhir.Model.Library> CollectPackagedLibraries(PackagingToolkit packagingToolkit) =>
        packagingToolkit.ArtifactsById.Values
            .Where(artifacts => artifacts.Result is not null)
            .ToDictionary(artifacts => artifacts.LibraryIdentifier.ToString(), artifacts => artifacts.Result!.Value.FhirLibrary);

    private static Library ReadElm(string fileName) =>
        Library.ParseFromJson(File.ReadAllText(Path.Combine("Input", "ELM", "HL7", fileName)));
}
