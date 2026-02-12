/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using System.Diagnostics;
using static Hl7.Cql.Elm.Library;
using DateTime = System.DateTime;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests.Packaging;

[TestClass]
public class LibraryPackagerTests
{
    private static readonly FhirTypeResolver TypeResolver = new(ModelInfo.ModelInspector);
    private readonly CqlTypeToFhirTypeMapper _mapper = new(TypeResolver);

    private static readonly VersionedIdentifier VersionedIdentifier = new() { id = "test-lib", system = "name.space", version = "1.2.3" };
    private static readonly byte[] ElmBytes = [0xff, 0x00, 0x00, 0x01];
    private static readonly byte[] CqlBytes = [0xff, 0x00, 0x00, 0x10];
    private static readonly byte[] AssemblyBytes = [0xff, 0x00, 0x01, 0x00];
    private static readonly byte[] DebugSymbolBytes = [0xff, 0x01, 0x00, 0x00];
    private static readonly DateTime Date = new(2001, 2, 3, 4, 5, 6, DateTimeKind.Local);
    private static readonly string TestUrl = "test.firely";
    private static readonly string CSharpString = "namespace Test {}";
    private static readonly string CSharpFileName = "dummy.g.cs";

    [TestMethod]
    public void CreateLibraryResource_TestProperties()
    {
        // Arrange/Act
        var library = CreateFhirLibrary();

        // Assert
        Assert.AreEqual($"7a03c0bb-{VersionedIdentifier.id}-{VersionedIdentifier.version}", library.Id);
        Assert.AreEqual("Library", library.TypeName);
        Assert.AreEqual(VersionedIdentifier.id, library.Name);
        Assert.AreEqual(VersionedIdentifier.id, library.Title);
        Assert.AreEqual(null, library.Description);
        Assert.AreEqual(VersionedIdentifier.version, library.Version);
        var expectedDate = new DateTimeIso8601(Date.ToLocalTime(), Hl7.Cql.Iso8601.DateTimePrecision.Millisecond).ToString();
        Assert.AreEqual(expectedDate, library.Date);
        Assert.AreEqual(TestUrl, library.Url);
    }

    [TestMethod]
    public void CreateLibraryResource_TestAttachments()
    {
        // Arrange/Act
        var library = CreateFhirLibrary();

        // Assert
        var attachmentsByElementId =
            library.Content.ToDictionary(c => c.ElementId, c => (c.ContentType, c.Data));

        string id = new CqlVersionedLibraryIdentifier(
                CqlLibraryIdentifier.NewVerbatim(VersionedIdentifier.id),
                CqlLibraryVersion.NewVerbatim(VersionedIdentifier.version))
            .ToString();

        Assert.AreEqual(("application/elm+json", ElmBytes), RemoveByElementId($"{id}+elm"));
        Assert.AreEqual(("text/cql", CqlBytes), RemoveByElementId($"{id}+cql"));
        Assert.AreEqual(("application/octet-stream", AssemblyBytes), RemoveByElementId($"{id}+dll"));
        Assert.AreEqual(("application/octet-stream", DebugSymbolBytes), RemoveByElementId($"{id}+pdb"));
        var cSharpAttachment = RemoveByElementId($"{CSharpFileName}+csharp");
        Assert.AreEqual(("text/plain", CSharpString), (cSharpAttachment.contentType, Encoding.UTF8.GetString(cSharpAttachment.data)));
        Assert.IsEmpty(attachmentsByElementId, "additional attachments that were not tested for, were found.");

        (string contentType, byte[] data) RemoveByElementId(string elementId)
        {
            if (attachmentsByElementId.Remove(elementId, out var removed))
                return removed;

            Assert.Fail($"The elementId {elementId} was not found in the library attachments.");
            throw new UnreachableException();
        }
    }

    private Hl7.Fhir.Model.Library CreateFhirLibrary()
    {
        var versionedIdentifier = VersionedIdentifier;
        var elmLibrary = new Library(versionedIdentifier);
        // Act
        var library = Hl7.Fhir.Model.Library.Create(
            typeCrosswalk: _mapper,
            elmLibrary: elmLibrary,
            elmBytes: ElmBytes,
            cqlBytes: CqlBytes,
            assemblyBytes: AssemblyBytes,
            debugSymbols: DebugSymbolBytes,
            cSharpSourceCodeById: [new(CSharpFileName, CSharpString)],
            elmLibrarySet: new LibrarySet("", [elmLibrary]),
            resourceCanonicalBuilder: (
                _,
                _,
                _) => TestUrl,
            elmFileLastWriteTimeUtc: Date);
        Assert.IsNotNull(library);
        return library;
    }

    [DataTestMethod]
    [DataRow("Input/ELM/Test/ParameterTest_ResultTypeSpecifier.json", FHIRAllTypes.Integer)]
    [DataRow("Input/ELM/Test/ParameterTest_ParameterTypeSpecifier.json", FHIRAllTypes.Integer)]
    [DataRow("Input/ELM/Test/ParameterTest_ResultTypeName.json", FHIRAllTypes.Integer)]
    [DataRow("Input/ELM/Test/ParameterTest_ParameterType.json", FHIRAllTypes.Integer)]
    public void ElmParameterToFhir_ParameterTypeCanBeDerivedFromDifferentSources(string filename, FHIRAllTypes expectedType)
    {
        // Arrange
        var elmLibrary = LoadFromJson(new FileInfo(filename));
        // Act
        var library = Hl7.Fhir.Model.Library.Create(
            typeCrosswalk: _mapper,
            elmLibrary: elmLibrary,
            elmBytes: File.ReadAllBytes(filename),
            cqlBytes: [],
            assemblyBytes: [],
            debugSymbols: [],
            cSharpSourceCodeById: [],
            elmLibrarySet: new LibrarySet("", [elmLibrary]),
            resourceCanonicalBuilder: (
                _,
                _,
                _) => "");

        // Assert
        Assert.IsNotNull(library);
        var inputParameter = library.Parameter.Single(pd => pd.Use == OperationParameterUse.In);
        Assert.AreEqual("param", inputParameter.Name);
        Assert.AreEqual(expectedType, inputParameter.Type);
    }

    [DataTestMethod]
    [DataRow("Input/ELM/Test/ParameterTest_ResultTypeSpecifier.json", false)]
    [DataRow("Input/ELM/HL7/ConceptDefTest.json", true)]
    public void ElmContextToFhir_LibraryTypeIsBasedOnContext(string filename, bool contextExpected)
    {
        // Arrange
        var elmLibrary = LoadFromJson(new FileInfo(filename));
        var fhirHelpers = LoadFromJson(new FileInfo("Input/ELM/HL7/FHIRHelpers-4.0.1.json"));
        // Act
        var library = Hl7.Fhir.Model.Library.Create(
            typeCrosswalk: _mapper,
            elmLibrary: elmLibrary,
            elmBytes: File.ReadAllBytes(filename),
            cqlBytes: [],
            assemblyBytes: [],
            debugSymbols: [],
            cSharpSourceCodeById: [],
            elmLibrarySet: new LibrarySet(
                "",
                [elmLibrary, fhirHelpers]),
                resourceCanonicalBuilder: (_, _, _) => "");

        // Assert
        Assert.IsNotNull(library);
        var subjectType = library.Subject as CodeableConcept;
        subjectType?.Coding?.Any(coding => "http://hl7.org/fhir/resource-types".Equals(coding.System) && "Patient".Equals(coding.Code)).Should()
                   .Be(contextExpected);
    }
}