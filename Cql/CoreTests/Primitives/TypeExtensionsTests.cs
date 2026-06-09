/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;

namespace CoreTests.Primitives;

[TestClass]
public class TypeExtensionsTests
{
    [TestMethod]
    public void IsCqlInterval_ShouldReturnTrueAndSetElementType_WhenTypeIsCqlInterval()
    {
        // Arrange
        Type type = typeof(CqlInterval<int>);
        Type elementType;

        // Act
        bool result = type.IsCqlInterval(out elementType);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(typeof(int), elementType);
    }

    [TestMethod]
    public void IsCqlInterval_ShouldReturnFalseAndSetElementTypeToNull_WhenTypeIsNotCqlInterval()
    {
        // Arrange
        Type type = typeof(string);
        Type elementType;

        // Act
        bool result = type.IsCqlInterval(out elementType);

        // Assert
        Assert.IsFalse(result);
        Assert.IsNull(elementType);
    }

    [TestMethod]
    public void IsCqlValueTuple_ShouldReturnTrue_WhenTypeIsCqlValueTuple()
    {
        // Arrange
        Type type = typeof(ValueTuple<CqlTupleMetadata, int>);

        // Act
        bool result = type.IsCqlValueTuple();

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsCqlValueTuple_ShouldReturnTrue_WhenTypeIsNullableCqlValueTuple()
    {
        // Arrange
        Type type = typeof(ValueTuple<CqlTupleMetadata, int>?);

        // Act
        bool result = type.IsCqlValueTuple();

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsCqlValueTuple_ShouldReturnFalse_WhenTypeIsNotCqlValueTuple()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.IsCqlValueTuple();

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsCqlValueTuple_ShouldReturnTrue_WhenTypeIsLargeCqlValueTuple()
    {
        // Arrange - Test large tuples with more than 8 items
        var tuple9 = (new CqlTupleMetadata([], []), "item1", 2, 3, 4, 5, 6, 7, 8, 9);
        var tuple10 = (new CqlTupleMetadata([], []), "item1", 2, 3, 4, 5, 6, 7, 8, 9, 10);
        var tuple15 = (new CqlTupleMetadata([], []), "item1", 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

        // Act
        bool result9 = tuple9.GetType().IsCqlValueTuple();
        bool result10 = tuple10.GetType().IsCqlValueTuple();
        bool result15 = tuple15.GetType().IsCqlValueTuple();

        // Assert
        Assert.IsTrue(result9, "9-item tuple should be recognized as CqlValueTuple");
        Assert.IsTrue(result10, "10-item tuple should be recognized as CqlValueTuple");
        Assert.IsTrue(result15, "15-item tuple should be recognized as CqlValueTuple");
    }
}
