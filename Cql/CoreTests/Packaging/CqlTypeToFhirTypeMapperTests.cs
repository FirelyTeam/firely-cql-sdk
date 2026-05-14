/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

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

    [TestMethod]
    public void TypeEntryFor_CqlPrimitiveTypeTuple_ReturnsFhirBasic()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);

        // Act
        var result = mapper.TypeEntryFor(CqlPrimitiveType.Tuple);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(FHIRAllTypes.Basic, result.FhirType);
        Assert.AreEqual(CqlPrimitiveType.Tuple, result.CqlType);
    }

    [TestMethod]
    public void TypeEntryFor_CqlValueTupleType_ReturnsFhirBasic()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);
        var tupleType = typeof((CqlTupleMetadata, string, int)); // A CQL value tuple type

        // Verify the type is actually a CQL value tuple
        Assert.IsTrue(tupleType.IsCqlValueTuple(), "The test type should be detected as a CQL value tuple");

        // Act
        var result = mapper.TypeEntryFor(tupleType);

        // Assert
        Assert.IsNotNull(result, "TypeEntryFor should return a non-null result for CQL value tuples");
        Assert.AreEqual(FHIRAllTypes.Basic, result.FhirType);
        Assert.AreEqual(CqlPrimitiveType.Tuple, result.CqlType);
    }

    [TestMethod]
    public void TypeEntryFor_CqlLongTypeTuple_ReturnsFhirString()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);

        // Act
        var result = mapper.TypeEntryFor(CqlPrimitiveType.Long);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(FHIRAllTypes.String, result.FhirType);
        Assert.AreEqual(CqlPrimitiveType.Long, result.CqlType);
    }

    [TestMethod]
    public void TypeEntryFor_CqlPrimitiveTypeIntervalWithTimeElementType_ReturnsFhirPeriodAndDateTimeElement()
    {
        // Arrange
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var mapper = new CqlTypeToFhirTypeMapper(typeResolver);
        var elementType = new CqlTypeToFhirMapping(FHIRAllTypes.Time, CqlPrimitiveType.Time);

        // Act
        var result = mapper.TypeEntryFor(CqlPrimitiveType.Interval, elementType);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(FHIRAllTypes.Period, result.FhirType);
        Assert.AreEqual(CqlPrimitiveType.Interval, result.CqlType);
        Assert.IsNotNull(result.ElementType);
        Assert.AreEqual(FHIRAllTypes.DateTime, result.ElementType.FhirType);
        Assert.AreEqual(CqlPrimitiveType.Time, result.ElementType.CqlType);
    }
}
