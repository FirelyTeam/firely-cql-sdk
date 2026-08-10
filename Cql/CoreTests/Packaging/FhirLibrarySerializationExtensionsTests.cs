/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir.Serialization.Extensions;

namespace CoreTests.Packaging;

[TestClass]
public class FhirLibrarySerializationExtensionsTests
{
    // Minimal valid FHIR Library JSON
    private const string ValidLibraryJson = """
        {
          "resourceType": "Library",
          "id": "test-library",
          "name": "TestLibrary",
          "version": "1.0.0",
          "status": "active",
          "type": { "coding": [{ "code": "logic-library" }] }
        }
        """;

    // FHIR Library with a non-standard 'url' value (no http:// scheme — still parseable under NoOverflow)
    private const string LibraryWithNonConformantUrlJson = """
        {
          "resourceType": "Library",
          "id": "test-library-nc-url",
          "name": "TestLibraryNonConformantUrl",
          "version": "1.0.0",
          "status": "active",
          "type": { "coding": [{ "code": "logic-library" }] },
          "url": "Library/TestLibraryNonConformantUrl"
        }
        """;

    [TestMethod]
    public void ReadFhirLibraryFromJson_ValidJson_ReturnsLibrary()
    {
        var library = FhirLibrarySerializationExtensions.ReadFhirLibraryFromJson(ValidLibraryJson);

        library.Should().NotBeNull();
        library.Name.Should().Be("TestLibrary");
        library.Version.Should().Be("1.0.0");
    }

    [TestMethod]
    public void ReadFhirLibraryFromJson_LibraryWithNonConformantUrl_Succeeds()
    {
        // Libraries with non-standard url values (e.g. no http:// scheme) should deserialize
        // without throwing, since we use BaseFhirJsonDeserializer with DeserializationMode.NoOverflow.
        var library = FhirLibrarySerializationExtensions.ReadFhirLibraryFromJson(LibraryWithNonConformantUrlJson);

        library.Should().NotBeNull();
        library.Name.Should().Be("TestLibraryNonConformantUrl");
    }

    [TestMethod]
    public void ReadFhirLibraryFromJson_InvalidJson_ThrowsWithDiagnostics()
    {
        // JSON that fails FHIR validation (underscore in id field is not allowed per FHIR spec)
        // should throw InvalidOperationException with diagnostic details.
        const string badJson = """{ "resourceType": "Library", "id": "invalid_id_underscore" }""";

        var act = () => FhirLibrarySerializationExtensions.ReadFhirLibraryFromJson(badJson);

        act.Should().Throw<InvalidOperationException>()
           .WithMessage("*Issues:*");
    }

    [TestMethod]
    public void ReadFhirLibraryFromJson_NonLibraryResource_ThrowsInvalidOperation()
    {
        const string patientJson = """{ "resourceType": "Patient", "id": "p1" }""";

        var act = () => FhirLibrarySerializationExtensions.ReadFhirLibraryFromJson(patientJson);

        act.Should().Throw<InvalidOperationException>()
           .WithMessage("*not a FHIR Library*");
    }

    [TestMethod]
    public void WriteFhirResourceToJson_RoundTrips()
    {
        var library = FhirLibrarySerializationExtensions.ReadFhirLibraryFromJson(ValidLibraryJson);
        var json = FhirLibrarySerializationExtensions.WriteFhirResourceToJson(library);

        json.Should().Contain("\"resourceType\"");
        json.Should().Contain("\"Library\"");
        json.Should().Contain("\"TestLibrary\"");
    }

    [TestMethod]
    public void WriteFhirResourceToJson_WriteIndented_ProducesIndentedJson()
    {
        var library = FhirLibrarySerializationExtensions.ReadFhirLibraryFromJson(ValidLibraryJson);

        var compact = FhirLibrarySerializationExtensions.WriteFhirResourceToJson(library, writeIndented: false);
        var indented = FhirLibrarySerializationExtensions.WriteFhirResourceToJson(library, writeIndented: true);

        indented.Should().Contain("\n");
        compact.Should().NotContain("\n");
    }
}
