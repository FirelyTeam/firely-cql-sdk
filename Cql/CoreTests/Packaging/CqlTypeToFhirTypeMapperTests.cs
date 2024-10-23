using System;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.Packaging;

[TestClass]
public class CqlTypeToFhirTypeMapperTests
{
    [TestMethod]
    public void TypeEntryFor_CqlPrimitiveTypeBoolean_ReturnsFhirBoolean()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);

        // Act
        var result = mapper.TypeEntryFor(CqlPrimitiveType.Boolean);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(FHIRAllTypes.Boolean, result.FhirType);
        Assert.AreEqual(CqlPrimitiveType.Boolean, result.CqlType);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TypeEntryFor_CqlPrimitiveTypeListWithoutElementType_ThrowsArgumentNullException()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);

        // Act
        mapper.TypeEntryFor(CqlPrimitiveType.List);
    }

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void TypeEntryFor_CqlPrimitiveTypeLong_ThrowsNotSupportedException()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);

        // Act
        mapper.TypeEntryFor(CqlPrimitiveType.Long);
    }

    [TestMethod]
    public void TypeEntryFor_CqlPrimitiveTypeListWithElementType_ReturnsFhirList()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var elementType = new CqlTypeToFhirMapping(FHIRAllTypes.String, CqlPrimitiveType.String);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);

        // Act
        var result = mapper.TypeEntryFor(CqlPrimitiveType.List, elementType);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(FHIRAllTypes.List, result.FhirType);
        Assert.AreEqual(CqlPrimitiveType.List, result.CqlType);
        Assert.AreEqual(elementType, result.ElementType);
    }
}
