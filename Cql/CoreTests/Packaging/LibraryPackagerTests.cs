using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
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
        var elmFile = new FileInfo(filename);

        // Act
        var library = LibraryPackager.CreateLibraryResource(
            typeCrosswalk: _mapper,
            elmLibrary: Library.LoadFromJson(new FileInfo(filename)),
            elmBytes: File.ReadAllBytes(filename),
            cqlBytes: [],
            assemblyBytes: [],
            cSharpSourceCodeById: []);

        // Assert
        Assert.IsNotNull(library);
        var inputParameter = library.Parameter.Single(pd => pd.Use == OperationParameterUse.In);
        Assert.AreEqual("param", inputParameter.Name);
        Assert.AreEqual(expectedType, inputParameter.Type);
    }
}
