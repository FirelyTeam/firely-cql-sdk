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
        var paramTypes = new[] { typeof(int), typeof(string) };

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
        CollectionAssert.AreEqual(new[] { typeof(int), typeof(string) }, parameterTypes);
    }
}

[TestClass]
public class DefinitionParametersUnitTests
{
    [TestMethod]
    public void Constructor_WithNameTypesAndNames_ShouldCreateInstance()
    {
        // Arrange
        const string name = "TestFunction";
        var paramNames = new[] { "param1", "param2" };
        var paramTypes = new[] { typeof(int), typeof(string) };

        // Act
        var signature = new DefinitionParameters(name, paramNames, paramTypes);

        // Assert
        Assert.AreEqual(name, signature.Name);
        CollectionAssert.AreEqual(paramNames, signature.ParameterNames);
        CollectionAssert.AreEqual(paramTypes, signature.ParameterTypes);
    }

    [TestMethod]
    public void Constructor_WithTupleParameters_ShouldCreateInstance()
    {
        // Arrange
        const string name = "TestFunction";
        var parameters = new[] { ("param1", typeof(int)), ("param2", typeof(string)) };

        // Act
        var signature = new DefinitionParameters(name, parameters);

        // Assert
        Assert.AreEqual(name, signature.Name);
        CollectionAssert.AreEqual(new[] { "param1", "param2" }, signature.ParameterNames);
        CollectionAssert.AreEqual(new[] { typeof(int), typeof(string) }, signature.ParameterTypes);
    }

    [TestMethod]
    public void Constructor_WithNullName_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.ThrowsException<ArgumentNullException>(() => new DefinitionParameters(null!, new[] { "param1" }, new[] { typeof(int) }));
    }

    [TestMethod]
    public void Constructor_WithMismatchedArrayLengths_ShouldThrowArgumentException()
    {
        // Act & Assert
        var ex = Assert.ThrowsException<ArgumentException>(() => new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int) }));
        Assert.IsTrue(ex.Message.Contains("same length"));
    }

    [TestMethod]
    public void Constructor_WithEmptyArrays_ShouldCreateInstanceWithEmptyArrays()
    {
        // Arrange
        const string name = "TestFunction";

        // Act
        var signature = new DefinitionParameters(name, Array.Empty<string>(), Array.Empty<Type>());

        // Assert
        Assert.AreEqual(name, signature.Name);
        Assert.AreEqual(0, signature.ParameterNames.Length);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void Constructor_WithNullArrays_ShouldCreateInstanceWithEmptyArrays()
    {
        // Arrange
        const string name = "TestFunction";

        // Act
        var signature = new DefinitionParameters(name, null!, null!);

        // Assert
        Assert.AreEqual(name, signature.Name);
        Assert.AreEqual(0, signature.ParameterNames.Length);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void Equals_WithSameContent_ShouldReturnTrue()
    {
        // Arrange
        var signature1 = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });
        var signature2 = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });

        // Act & Assert
        Assert.IsTrue(signature1.Equals(signature2));
        Assert.IsTrue(signature1 == signature2);
        Assert.AreEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void Equals_WithDifferentNames_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionParameters("TestFunction1", new[] { "param1" }, new[] { typeof(int) });
        var signature2 = new DefinitionParameters("TestFunction2", new[] { "param1" }, new[] { typeof(int) });

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void Equals_WithDifferentParameterTypes_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionParameters("TestFunction", new[] { "param1" }, new[] { typeof(int) });
        var signature2 = new DefinitionParameters("TestFunction", new[] { "param1" }, new[] { typeof(string) });

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void Equals_WithDifferentParameterNames_ShouldReturnFalse()
    {
        // Arrange
        var signature1 = new DefinitionParameters("TestFunction", new[] { "param1" }, new[] { typeof(int) });
        var signature2 = new DefinitionParameters("TestFunction", new[] { "param2" }, new[] { typeof(int) });

        // Act & Assert
        Assert.IsFalse(signature1.Equals(signature2));
        Assert.IsFalse(signature1 == signature2);
    }

    [TestMethod]
    public void GetHashCode_WithSameContent_ShouldBeSame()
    {
        // Arrange
        var signature1 = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });
        var signature2 = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });

        // Act & Assert
        Assert.AreEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void GetHashCode_WithDifferentContent_ShouldBeDifferent()
    {
        // Arrange
        var signature1 = new DefinitionParameters("TestFunction1", new[] { "param1" }, new[] { typeof(int) });
        var signature2 = new DefinitionParameters("TestFunction2", new[] { "param1" }, new[] { typeof(int) });

        // Act & Assert
        Assert.AreNotEqual(signature1.GetHashCode(), signature2.GetHashCode());
    }

    [TestMethod]
    public void GetHashCode_ShouldBeCached()
    {
        // Arrange
        var signature = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });

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
        var signature = new DefinitionParameters("TestFunction", Array.Empty<string>(), Array.Empty<Type>());

        // Act
        var result = signature.ToString();

        // Assert
        Assert.AreEqual("TestFunction", result);
    }

    [TestMethod]
    public void ToString_WithParameters_ShouldIncludeParameterTypesAndNames()
    {
        // Arrange
        var signature = new DefinitionParameters("TestFunction", new[] { "count", "name" }, new[] { typeof(int), typeof(string) });

        // Act
        var result = signature.ToString();

        // Assert
        Assert.AreEqual("TestFunction(System.Int32 count, System.String name)", result);
    }

    [TestMethod]
    public void GetParameterTypeNames_ShouldReturnTupleArray()
    {
        // Arrange
        var signature = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });

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
        var signature = new DefinitionParameters("TestFunction", Array.Empty<string>(), Array.Empty<Type>());

        // Act
        var result = signature.GetParameterTypeNames();

        // Assert
        Assert.AreEqual(0, result.Length);
    }

    [TestMethod]
    public void Deconstruct_ShouldProvideNameAndParameterTuples()
    {
        // Arrange
        var signature = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });

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
        DefinitionParameters signature = functionName;

        // Assert
        Assert.AreEqual(functionName, signature.Name);
        Assert.AreEqual(0, signature.ParameterNames.Length);
        Assert.AreEqual(0, signature.ParameterTypes.Length);
    }

    [TestMethod]
    public void ImplicitConversion_ToDefinitionSignature_ShouldPreserveName()
    {
        // Arrange
        var signatureWithNames = new DefinitionParameters("TestFunction", new[] { "param1", "param2" }, new[] { typeof(int), typeof(string) });

        // Act
        DefinitionSignature signature = signatureWithNames;

        // Assert
        Assert.AreEqual("TestFunction", signature.Name);
        CollectionAssert.AreEqual(new[] { typeof(int), typeof(string) }, signature.ParameterTypes);
    }
}