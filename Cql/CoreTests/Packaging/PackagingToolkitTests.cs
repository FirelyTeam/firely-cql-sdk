/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
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
        var elmToolkit = new ElmToolkit()
            .AddElmLibraries([
                ReadElm("TestRetrieve.json"),
                ReadElm("TestRetrieveInclude.json"),
                ReadElm("FHIRHelpers-4.0.1.json")]);
        // The packager attaches the CQL as given; the ELM above is what it analyzes.
        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries([
                CqlLibraryString.Parse("library TestRetrieve version '1.0.1'"),
                CqlLibraryString.Parse("library TestRetrieveInclude version '1.0.1'")]);

        // Act
        var packagingToolkit = elmToolkit.PackageToFhirResources(cqlToolkit);

        // Assert - Condition, Patient and ServiceRequest are from TestRetrieve, Observation is from TestRetrieveInclude
        var packagedLibraries = packagingToolkit.ArtifactsById.Values
            .Where(artifacts => artifacts.Result is not null)
            .ToDictionary(artifacts => artifacts.LibraryIdentifier.ToString(), artifacts => artifacts.Result!.Value.FhirLibrary);
        packagedLibraries.Keys.Should().BeEquivalentTo(["TestRetrieve-1.0.1", "TestRetrieveInclude-1.0.1"]);
        packagedLibraries["TestRetrieve-1.0.1"].DataRequirement.Select(dataRequirement => dataRequirement.Type).Should().BeEquivalentTo(
            [FHIRAllTypes.Patient, FHIRAllTypes.ServiceRequest, FHIRAllTypes.Condition, FHIRAllTypes.Observation]);
    }

    private static Library ReadElm(string fileName) =>
        Library.ParseFromJson(File.ReadAllText(Path.Combine("Input", "ELM", "HL7", fileName)));
}
