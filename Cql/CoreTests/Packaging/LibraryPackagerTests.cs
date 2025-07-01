using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging.Abstractions;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests.Packaging;

[TestClass]
public class LibraryPackagerTests
{
    private static readonly FhirTypeResolver TypeResolver = new (ModelInfo.ModelInspector);
    private readonly CqlTypeToFhirTypeMapper _mapper = new (TypeResolver);

    [DataTestMethod]
    [DataRow("Input/ELM/Test/ParameterTest_ResultTypeSpecifier.json", FHIRAllTypes.Integer)]
    [DataRow("Input/ELM/Test/ParameterTest_ParameterTypeSpecifier.json", FHIRAllTypes.Integer)]
    [DataRow("Input/ELM/Test/ParameterTest_ResultTypeName.json", FHIRAllTypes.Integer)]
    [DataRow("Input/ELM/Test/ParameterTest_ParameterType.json", FHIRAllTypes.Integer)]
    public void ElmParameterToFhir_ParameterTypeCanBeDerivedFromDifferentSources(string filename, FHIRAllTypes expectedType)
    {
        // Arrange
        var elmLibrary = Library.LoadFromJson(new FileInfo(filename));
        // Act
        var library = LibraryPackager.CreateLibraryResource(
            NullLoggerFactory.Instance.CreateLogger("Dummy"),
            typeCrosswalk: _mapper,
            elmLibrary: elmLibrary,
            elmBytes: File.ReadAllBytes(filename),
            cqlBytes: [],
            assemblyBytes: [],
            elmLibrarySet: new LibrarySet("", [elmLibrary] ),
            cSharpSourceCodeById: [],
            resourceCanonicalBuilder: (_,_,_) => "");

        // Assert
        Assert.IsNotNull(library);
        var inputParameter = library.Parameter.Single(pd => pd.Use == OperationParameterUse.In);
        Assert.AreEqual("param", inputParameter.Name);
        Assert.AreEqual(expectedType, inputParameter.Type);
    }

    [DataTestMethod]
    [DataRow("Input/ELM/Test/ParameterTest_ResultTypeSpecifier.json", false)]
    [DataRow("Input/HL7/elm/ConceptDefTest.json", true)]
    public void ElmContextToFhir_LibraryTypeIsBasedOnContext(string filename, bool contextExpected)
    {
        // Arrange
        var elmLibrary = Library.LoadFromJson(new FileInfo(filename));
        var fhirHelpers = Library.LoadFromJson(new FileInfo("Input/HL7/elm/FHIRHelpers-4.0.1.json"));
        // Act
        var library = LibraryPackager.CreateLibraryResource(
            NullLoggerFactory.Instance.CreateLogger("Dummy"),
            typeCrosswalk: _mapper,
            elmLibrary: elmLibrary,
            elmBytes: File.ReadAllBytes(filename),
            cqlBytes: [],
            assemblyBytes: [],
            elmLibrarySet: new LibrarySet("", [elmLibrary, fhirHelpers] ),
            cSharpSourceCodeById: [],
            resourceCanonicalBuilder: (_,_,_) => "");

        // Assert
        Assert.IsNotNull(library);
        var subjectType = library.Subject as CodeableConcept;
        subjectType?.Coding?.Any(coding => "http://hl7.org/fhir/resource-types".Equals(coding.System) && "Patient".Equals(coding.Code)).Should().Be(contextExpected);
    }
}
