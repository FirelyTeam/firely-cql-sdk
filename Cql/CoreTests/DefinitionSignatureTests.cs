/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class DefinitionSignatureTests
{
    [TestMethod]
    public void Constructor_WithValidNameAndTypes_ShouldCreateInstance()
    {
        // Arrange
        const string name = "TestFunction";
        Type[] paramTypes = [typeof(int), typeof(string)];

        // Act
        var signature = new DefinitionSignature(name, paramTypes);

        // Assert
        Assert.AreEqual(name, signature.Name);
        CollectionAssert.AreEqual(paramTypes, signature.ParameterTypes);
    }

    [TestMethod]
    public void Constructor_WithValidNameAndNoTypes_ShouldCreateInstance()
    {
        // Arrange
        const string name = "TestFunction";

        // Act
        var signature = new DefinitionSignature(name);

        // Assert
        Assert.AreEqual(name, signature.Name);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void Constructor_WithNullName_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.ThrowsException<ArgumentNullException>(() => new DefinitionSignature(null!, typeof(int)));
    }

    [TestMethod]
    public void Constructor_WithNullParameterTypes_ShouldCreateEmptyArray()
    {
        // Arrange
        const string name = "TestFunction";

        // Act
        var signature = new DefinitionSignature(name, null!);

        // Assert
        Assert.AreEqual(name, signature.Name);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void Equals_WithSameNameAndTypes_ShouldReturnTrue()
    {
        // Arrange
        var signature1 = new DefinitionSignature("TestFunction", typeof(int), typeof(string));
        var signature2 = new DefinitionSignature("TestFunction", typeof(int), typeof(string));

        // Act & Assert
        Assert.IsTrue(signature1.Equals(signature2));
        Assert.IsTrue(signature1 == signature2);
        Assert.AreEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void Equals_WithDifferentNames_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionSignature("TestFunction1", typeof(int));
        var signature2 = new DefinitionSignature("TestFunction2", typeof(int));

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void Equals_WithDifferentParameterTypes_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionSignature("TestFunction", typeof(int));
        var signature2 = new DefinitionSignature("TestFunction", typeof(string));

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void Equals_WithDifferentParameterCount_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionSignature("TestFunction", typeof(int));
        var signature2 = new DefinitionSignature("TestFunction", typeof(int), typeof(string));

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void GetHashCode_WithSameContent_ShouldBeSame()
    {
        // Arrange
        var signature1 = new DefinitionSignature("TestFunction", typeof(int), typeof(string));
        var signature2 = new DefinitionSignature("TestFunction", typeof(int), typeof(string));

        // Act & Assert
        Assert.AreEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void GetHashCode_WithDifferentContent_ShouldBeDifferent()
    {
        // Arrange
        var signature1 = new DefinitionSignature("TestFunction1", typeof(int));
        var signature2 = new DefinitionSignature("TestFunction2", typeof(int));

        // Act & Assert
        Assert.AreNotEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void GetHashCode_ShouldBeCached()
    {
        // Arrange
        var signature = new DefinitionSignature("TestFunction", typeof(int), typeof(string));

        // Act
        var hash1 = signature.GetHashCode();
        var hash2 = signature.GetHashCode();

        // Assert
        Assert.AreEqual(hash1, hash2);
    }

    [TestMethod]
    public void ToString_WithNoParameters_ShouldReturnNameOnly()
    {
        // Arrange
        var signature = new DefinitionSignature("TestFunction");

        // Act
        var result = signature.ToString();

        // Assert
        Assert.AreEqual("TestFunction()", result);
    }

    [TestMethod]
    public void ToString_WithParameters_ShouldIncludeParameterTypes()
    {
        // Arrange
        var signature = new DefinitionSignature("TestFunction", typeof(int), typeof(string));

        // Act
        var result = signature.ToString();

        // Assert
        Assert.AreEqual("TestFunction(System.Int32, System.String)", result);
    }

    [TestMethod]
    public void ImplicitConversion_FromString_ShouldCreateSignature()
    {
        // Arrange
        const string functionName = "TestFunction";

        // Act
        DefinitionSignature signature = functionName;

        // Assert
        Assert.AreEqual(functionName, signature.Name);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void Deconstruct_ShouldProvideNameAndParameterTypes()
    {
        // Arrange
        var signature = new DefinitionSignature("TestFunction", typeof(int), typeof(string));

        // Act
        var (name, parameterTypes) = signature;

        // Assert
        Assert.AreEqual("TestFunction", name);
        CollectionAssert.AreEqual(new Type[] { typeof(int), typeof(string) }, parameterTypes);
    }
}