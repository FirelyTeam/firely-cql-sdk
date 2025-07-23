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
    public void IsCqlValueTuple_ShouldReturnFalse_WhenTypeIsNotCqlValueTuple()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.IsCqlValueTuple();

        // Assert
        Assert.IsFalse(result);
    }
}
