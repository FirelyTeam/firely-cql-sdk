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
public class DefinitionInfoTests
{
    [TestMethod]
    public void Constructor_WithNameTypesAndNames_ShouldCreateInstance()
    {
        // Arrange
        const string name = "TestFunction";
        string[] paramNames = ["param1", "param2"];
        Type[] paramTypes = [typeof(int), typeof(string)];

        // Act
        var signature = new DefinitionInfo(name, paramNames, paramTypes, typeof(void));

        // Assert
        Assert.AreEqual(name, signature.Name);
        CollectionAssert.AreEqual(paramNames, signature.ParameterNames);
        CollectionAssert.AreEqual(paramTypes, signature.ParameterTypes);
        Assert.AreEqual(typeof(void), signature.ReturnType);
    }

    [TestMethod]
    public void Constructor_WithTupleParameters_ShouldCreateInstance()
    {
        // Arrange
        const string name = "TestFunction";
        (string, Type)[] parameters = [("param1", typeof(int)), ("param2", typeof(string))];

        // Act
        var signature = new DefinitionInfo(name, typeof(int), parameters);

        // Assert
        Assert.AreEqual(name, signature.Name);
        CollectionAssert.AreEqual(new string[] { "param1", "param2" }, signature.ParameterNames);
        CollectionAssert.AreEqual(new Type[] { typeof(int), typeof(string) }, signature.ParameterTypes);
        Assert.AreEqual(typeof(int), signature.ReturnType);
    }

    [TestMethod]
    public void Constructor_WithNullName_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.ThrowsException<ArgumentNullException>(() => new DefinitionInfo(null!, ["param1"], [typeof(int)], typeof(void)));
    }

    [TestMethod]
    public void Constructor_WithMismatchedArrayLengths_ShouldThrowArgumentException()
    {
        // Act & Assert
        var ex = Assert.ThrowsException<ArgumentException>(() => new DefinitionInfo("TestFunction", ["param1", "param2"], [typeof(int)], typeof(void)));
        Assert.IsTrue(ex.Message.Contains("same length"));
    }

    [TestMethod]
    public void Constructor_WithEmptyArrays_ShouldCreateInstanceWithEmptyArrays()
    {
        // Arrange
        const string name = "TestFunction";

        // Act
        var signature = new DefinitionInfo(name, Array.Empty<string>(), Array.Empty<Type>(), typeof(string));

        // Assert
        Assert.AreEqual(name, signature.Name);
        Assert.AreEqual(0, signature.ParameterNames.Length);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
        Assert.AreEqual(typeof(string), signature.ReturnType);
    }

    [TestMethod]
    public void Constructor_WithNullArrays_ShouldCreateInstanceWithEmptyArrays()
    {
        // Arrange
        const string name = "TestFunction";

        // Act
        var signature = new DefinitionInfo(name, null!, null!, typeof(void));

        // Assert
        Assert.AreEqual(name, signature.Name);
        Assert.AreEqual(0, signature.ParameterNames.Length);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void Equals_WithSameContent_ShouldReturnTrue()
    {
        // Arrange
        var signature1 = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));
        var signature2 = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));

        // Act & Assert
        Assert.IsTrue(signature1.Equals(signature2));
        Assert.IsTrue(signature1 == signature2);
        Assert.AreEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void Equals_WithDifferentNames_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionInfo("TestFunction1", new[] { "param1" }, new[] { typeof(int) }, typeof(bool));
        var signature2 = new DefinitionInfo("TestFunction2", new[] { "param1" }, new[] { typeof(int) }, typeof(bool));

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void Equals_WithDifferentParameterTypes_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionInfo("TestFunction", new[] { "param1" }, new[] { typeof(int) }, typeof(int));
        var signature2 = new DefinitionInfo("TestFunction", new[] { "param1" }, new[] { typeof(string) }, typeof(int));

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void Equals_WithDifferentParameterNames_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionInfo("TestFunction", new[] { "param1" }, new[] { typeof(int) }, typeof(int));
        var signature2 = new DefinitionInfo("TestFunction", new[] { "param2" }, new[] { typeof(int) }, typeof(int));

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void GetHashCode_WithSameContent_ShouldBeSame()
    {
        // Arrange
        var signature1 = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));
        var signature2 = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));

        // Act & Assert
        Assert.AreEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void GetHashCode_WithDifferentContent_ShouldBeDifferent()
    {
        // Arrange
        var signature1 = new DefinitionInfo("TestFunction1", new[] { "param1" }, new[] { typeof(int) }, typeof(bool));
        var signature2 = new DefinitionInfo("TestFunction2", new[] { "param1" }, new[] { typeof(int) }, typeof(bool));

        // Act & Assert
        Assert.AreNotEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void GetHashCode_ShouldBeCached()
    {
        // Arrange
        var signature = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));

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
        var signature = new DefinitionInfo("TestFunction", Array.Empty<string>(), Array.Empty<Type>(), typeof(void));

        // Act
        var result = signature.ToString();

        // Assert
        Assert.AreEqual("TestFunction", result);
    }

    [TestMethod]
    public void ToString_WithParameters_ShouldIncludeParameterTypesAndNames()
    {
        // Arrange
        var signature = new DefinitionInfo("TestFunction", new[] { "count", "name" }, new[] { typeof(int), typeof(string) }, typeof(double));

        // Act
        var result = signature.ToString();

        // Assert
        Assert.AreEqual("TestFunction(System.Int32 count, System.String name)", result);
    }

    [TestMethod]
    public void GetParameterTypeNames_ShouldReturnTupleArray()
    {
        // Arrange
        var signature = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));

        // Act
        var result = signature.GetParameterTypeNames();

        // Assert
        Assert.AreEqual(2, result.Length);
        Assert.AreEqual(("param1", typeof(int)), result[0]);
        Assert.AreEqual(("param2", typeof(string)), result[1]);
    }

    [TestMethod]
    public void GetParameterTypeNames_WithNoParameters_ShouldReturnEmptyArray()
    {
        // Arrange
        var signature = new DefinitionInfo("TestFunction", Array.Empty<string>(), Array.Empty<Type>(), typeof(void));

        // Act
        var result = signature.GetParameterTypeNames();

        // Assert
        Assert.AreEqual(0, result.Length);
    }

    [TestMethod]
    public void Deconstruct_ShouldProvideNameAndParameterTuples()
    {
        // Arrange
        var signature = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));

        // Act
        var (name, parameters) = signature;

        // Assert
        Assert.AreEqual("TestFunction", name);
        Assert.AreEqual(2, parameters.Length);
        Assert.AreEqual(("param1", typeof(int)), parameters[0]);
        Assert.AreEqual(("param2", typeof(string)), parameters[1]);
    }

    [TestMethod]
    public void ImplicitConversion_FromString_ShouldCreateSignature()
    {
        // Arrange
        const string functionName = "TestFunction";

        // Act
        DefinitionInfo signature = functionName;

        // Assert
        Assert.AreEqual(functionName, signature.Name);
        Assert.AreEqual(0, signature.ParameterNames.Length);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void ImplicitConversion_ToDefinitionSignature_ShouldPreserveName()
    {
        // Arrange
        var signatureWithNames = new DefinitionInfo("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) }, typeof(void));

        // Act
        DefinitionSignature signature = signatureWithNames;

        // Assert
        Assert.AreEqual("TestFunction", signature.Name);
        CollectionAssert.AreEqual(new[] { typeof(int), typeof(string) }, signature.ParameterTypes);
    }
}