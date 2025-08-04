/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Primitives;

namespace CoreTests.Tuples;

[TestClass]
public class CqlTupleMetadataTests
{
    [TestMethod]
    public void Constructor_SetsItemNamesAndTypes()
    {
        // Arrange
        var types = new[] { typeof(string), typeof(int) };
        var names = new[] { "Name", "Age" };

        // Act
        var metadata = new CqlTupleMetadata(types, names);

        // Assert
        CollectionAssert.AreEqual(names, metadata.ItemNames.ToArray());
        CollectionAssert.AreEqual(types, metadata.ItemTypes.ToArray());
    }

    [TestMethod]
    public void Equals_ReturnsTrueForSameNamesAndTypes()
    {
        // Arrange
        var m1 = new CqlTupleMetadata([typeof(string), typeof(int)], ["Name", "Age"]);
        var m2 = new CqlTupleMetadata([typeof(string), typeof(int)], ["Name", "Age"]);

        // Act & Assert
        Assert.IsTrue(m1.Equals(m2));
        Assert.IsTrue(m1.Equals((object)m2));
        Assert.AreEqual(m1.GetHashCode(), m2.GetHashCode());
    }

    [TestMethod]
    public void Equals_ReturnsFalseForDifferentNamesOrTypes()
    {
        // Arrange
        var m1 = new CqlTupleMetadata([typeof(string), typeof(int)], ["Name", "Age"]);
        var m2 = new CqlTupleMetadata([typeof(string)], ["Name"]);
        var m3 = new CqlTupleMetadata([typeof(string), typeof(int)], ["FirstName", "Age"]);

        // Act & Assert
        Assert.IsFalse(m1.Equals(m2));
        Assert.IsFalse(m1.Equals(m3));
    }

    [TestMethod]
    public void ToString_ReturnsSignatureWithNames()
    {
        // Arrange
        var metadata = new CqlTupleMetadata([typeof(string), typeof(int)], ["Name", "Age"]);

        // Act
        var str = metadata.ToString();

        // Assert
        Assert.AreEqual("[\"Name\", \"Age\"]", str);
    }

    [TestMethod]
    public void BuildSignatureHashString_ReturnsExpectedFormat()
    {
        // Arrange
        var props = new[] { (typeof(string), "Name"), (typeof(int), "Age") };

        // Act
        var signature = CqlTupleMetadata.BuildSignatureHashString(props);

        // Assert
        Assert.AreEqual("COYHiUGZgWUZAKEBBFZOcbQMe", signature);
    }
}
