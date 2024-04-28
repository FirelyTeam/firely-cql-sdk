using System;
using System.Linq;
using FluentAssertions;
using Hl7.Cql.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CoreTests.Infrastructure.TypeExtensionsTests;

namespace CoreTests;

[TestClass]
[TestCategory("UnitTest")]
public class MatchExactTypeDictionaryTests

{
    [TestMethod]
    public void Add_ShouldAddKeyValuePair()
    {
        // Arrange
        var dictionary = new MatchExactTypeDictionary<int>();
        var key = typeof(string);
        var value = 42;

        // Act
        dictionary.Add(key, value);

        // Assert
        dictionary.TryGetValue(key, out var retrievedValue).Should().BeTrue();
        retrievedValue.Should().Be(value);
    }

    [TestMethod]
    public void Add_DuplicateKey_ShouldThrowArgumentException()
    {
        // Arrange
        var dictionary = new MatchExactTypeDictionary<int>();
        var key = typeof(string);
        var value1 = 42;
        var value2 = 24;
        dictionary.Add(key, value1);

        // Act
        Action act = () => dictionary.Add(key, value2);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [TestMethod]
    public void TryGetValue_ExistingKey_ShouldReturnTrueAndRetrieveValue()
    {
        // Arrange
        var dictionary = new MatchExactTypeDictionary<int>();
        var key = typeof(string);
        var value = 42;
        dictionary.Add(key, value);

        // Act
        var result = dictionary.TryGetValue(key, out var retrievedValue);

        // Assert
        result.Should().BeTrue();
        retrievedValue.Should().Be(value);
    }

    [TestMethod]
    public void TryGetValue_NonExistingKey_ShouldReturnFalseAndDefault()
    {
        // Arrange
        var dictionary = new MatchExactTypeDictionary<int>();
        var key = typeof(string);

        // Act
        var result = dictionary.TryGetValue(key, out var retrievedValue);

        // Assert
        result.Should().BeFalse();
        retrievedValue.Should().Be(default(int));
    }

    [TestMethod]
    public void IsEmpty_EmptyDictionary_ShouldReturnTrue()
    {
        // Arrange
        var dictionary = new MatchExactTypeDictionary<int>();

        // Act
        var result = dictionary.IsEmpty;

        // Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void IsEmpty_NonEmptyDictionary_ShouldReturnFalse()
    {
        // Arrange
        var dictionary = new MatchExactTypeDictionary<int>();
        dictionary.Add(typeof(string), 42);

        // Act
        var result = dictionary.IsEmpty;

        // Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GetEnumerator_ShouldEnumerateAllKeyValuePairs()
    {
        // Arrange
        var dictionary = new MatchExactTypeDictionary<int>();
        dictionary.Add(typeof(string), 42);
        dictionary.Add(typeof(int), 24);

        // Act
        var keyValuePairs = dictionary.ToList();

        // Assert
        keyValuePairs.Should().HaveCount(2);
        keyValuePairs.Should().Contain(x => x.Key == typeof(string) && x.Value == 42);
        keyValuePairs.Should().Contain(x => x.Key == typeof(int) && x.Value == 24);
    }
}

[TestClass]
[TestCategory("UnitTest")]
public class MatchDerivedTypesDictionaryTests
{
    [TestMethod]
    public void Add_ShouldAddKeyValuePair()
    {
        // Arrange
        var dictionary = new MatchDerivedTypesDictionary<int>();
        var key = typeof(string);
        var value = 42;

        // Act
        dictionary.Add(key, value);

        // Assert
        dictionary.TryGetValue(key, out var retrievedValue).Should().BeTrue();
        retrievedValue.Should().Be(value);
    }

    [TestMethod]
    public void TryGetValue_WithMatchingType_ShouldReturnTrueAndRetrieveValue()
    {
        // Arrange
        var dictionary = new MatchDerivedTypesDictionary<int>();
        var key = typeof(object);
        var value = 42;
        dictionary.Add(key, value);

        // Act
        var result = dictionary.TryGetValue(key, out var retrievedValue);

        // Assert
        result.Should().BeTrue();
        retrievedValue.Should().Be(value);
    }

    [TestMethod]
    public void TryGetValue_WithDerivedType_ShouldReturnTrueAndRetrieveValue()
    {
        // Arrange
        var dictionary = new MatchDerivedTypesDictionary<int>();
        var key = typeof(MyClass);
        var value = 42;
        dictionary.Add(key, value);

        // Act
        var result = dictionary.TryGetValue(typeof(MyDerivedClass), out var retrievedValue);

        // Assert
        result.Should().BeTrue();
        retrievedValue.Should().Be(value);
    }

    [TestMethod]
    public void TryGetValue_WithGenericTypeDefinition_ShouldReturnTrueAndRetrieveValue()
    {
        // Arrange
        var dictionary = new MatchDerivedTypesDictionary<int>();
        var key = typeof(MyGenericClassBase<>);
        var value = 42;
        dictionary.Add(key, value);

        // Act
        var result = dictionary.TryGetValue(typeof(MyGenericClassDerived<>), out var retrievedValue);

        // Assert
        result.Should().BeTrue();
        retrievedValue.Should().Be(value);
    }


    [TestMethod]
    public void TryGetValue_WithConstructedGenericType_ShouldReturnTrueAndRetrieveValue()
    {
        var dictionary = new MatchDerivedTypesDictionary<int>();
        var key = typeof(MyGenericClassBase<>);
        var value = 42;
        dictionary.Add(key, value);

        // Act
        var result = dictionary.TryGetValue(typeof(MyGenericClassDerived<string>), out var retrievedValue);

        // Assert
        result.Should().BeTrue();
        retrievedValue.Should().Be(value);
    }

    [TestMethod]
    public void TryGetValue_WithNoMatchingType_ShouldReturnFalseAndDefault()
    {
        // Arrange
        var dictionary = new MatchDerivedTypesDictionary<int>();
        var key = typeof(string);
        var value = 42;
        dictionary.Add(key, value);

        // Act
        var result = dictionary.TryGetValue(typeof(object), out var retrievedValue);

        // Assert
        result.Should().BeFalse();
        retrievedValue.Should().Be(default);
    }
}