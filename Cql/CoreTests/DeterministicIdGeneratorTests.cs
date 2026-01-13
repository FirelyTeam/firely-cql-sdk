/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;

namespace CoreTests;

[TestClass]
public class DeterministicIdGeneratorTests
{
    [TestMethod]
    public void GenerateCacheKey_WithSameInputsAndSalt_ShouldReturnDeterministicKeys()
    {
        // Arrange
        var generator1 = new DeterministicIdGenerator("test-salt");
        var generator2 = new DeterministicIdGenerator("test-salt");
        var libraryIdentifier = "TestLibrary-1.0.0";
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator1.GenerateCacheKey(libraryIdentifier, definitionName);
        var key2 = generator2.GenerateCacheKey(libraryIdentifier, definitionName);

        // Assert - Same inputs with same salt should produce identical keys
        Assert.AreEqual(key1, key2, "Same inputs with same salt should produce identical keys");
    }

    [TestMethod]
    public void GenerateCacheKey_WithSameInputs_ShouldIncrementVersion()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");
        var libraryIdentifier = "TestLibrary-1.0.0";
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator.GenerateCacheKey(libraryIdentifier, definitionName);
        var key2 = generator.GenerateCacheKey(libraryIdentifier, definitionName);
        var key3 = generator.GenerateCacheKey(libraryIdentifier, definitionName);

        // Assert - Multiple calls should produce different keys (different versions)
        Assert.AreNotEqual(key1, key2, "Second call should produce different key (version 1)");
        Assert.AreNotEqual(key2, key3, "Third call should produce different key (version 2)");
        Assert.AreNotEqual(key1, key3, "First and third keys should be different");
    }

    [TestMethod]
    public void GenerateCacheKey_WithDifferentLibraries_ShouldReturnDifferentKeys()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator.GenerateCacheKey("Library1-1.0.0", definitionName);
        var key2 = generator.GenerateCacheKey("Library2-1.0.0", definitionName);

        // Assert
        Assert.AreNotEqual(key1, key2, "Different libraries should generate different keys");
    }

    [TestMethod]
    public void GenerateCacheKey_WithDifferentDefinitions_ShouldReturnDifferentKeys()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");
        var libraryIdentifier = "TestLibrary-1.0.0";

        // Act
        var key1 = generator.GenerateCacheKey(libraryIdentifier, "Definition1");
        var key2 = generator.GenerateCacheKey(libraryIdentifier, "Definition2");

        // Assert
        Assert.AreNotEqual(key1, key2, "Different definitions should generate different keys");
    }

    [TestMethod]
    public void GenerateCacheKey_WithDifferentVersions_ShouldReturnDifferentKeys()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator.GenerateCacheKey("TestLibrary-1.0.0", definitionName);
        var key2 = generator.GenerateCacheKey("TestLibrary-2.0.0", definitionName);

        // Assert
        Assert.AreNotEqual(key1, key2, "Different versions should generate different keys");
    }

    [TestMethod]
    public void GenerateCacheKey_WithDifferentSalts_ShouldReturnDifferentKeys()
    {
        // Arrange
        var generator1 = new DeterministicIdGenerator("salt1");
        var generator2 = new DeterministicIdGenerator("salt2");
        var libraryIdentifier = "TestLibrary-1.0.0";
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator1.GenerateCacheKey(libraryIdentifier, definitionName);
        var key2 = generator2.GenerateCacheKey(libraryIdentifier, definitionName);

        // Assert
        Assert.AreNotEqual(key1, key2, "Different salts should generate different keys");
    }

    [TestMethod]
    public void GenerateCacheKey_ShouldReturnNonZeroKey()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");

        // Act
        var key = generator.GenerateCacheKey("TestLibrary-1.0.0", "TestDefinition");

        // Assert
        Assert.AreNotEqual(0L, key, "Generated key should not be zero");
    }

    [TestMethod]
    public void GenerateCacheKey_WithEmptyStrings_ShouldGenerateValidKey()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");

        // Act
        var key = generator.GenerateCacheKey("", "");

        // Assert
        Assert.AreNotEqual(0L, key, "Should generate valid key even with empty strings");
    }

    [TestMethod]
    public void GenerateCacheKey_WithSpecialCharacters_ShouldGenerateValidKey()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");

        // Act
        var key1 = generator.GenerateCacheKey("Library-1.0.0", "Definition@#$%");
        var key2 = generator.GenerateCacheKey("Library-1.0.0", "Definition!&*()");

        // Assert
        Assert.AreNotEqual(0L, key1, "Should generate valid key with special characters");
        Assert.AreNotEqual(0L, key2, "Should generate valid key with special characters");
        Assert.AreNotEqual(key1, key2, "Different special characters should generate different keys");
    }

    [TestMethod]
    public void GenerateCacheKey_WithLongStrings_ShouldGenerateValidKey()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");
        var longLibrary = new string('A', 1000);
        var longDefinition = new string('B', 1000);

        // Act
        var key = generator.GenerateCacheKey(longLibrary, longDefinition);

        // Assert
        Assert.AreNotEqual(0L, key, "Should generate valid key with long strings");
    }

    [TestMethod]
    public void GenerateCacheKey_WithUnicodeCharacters_ShouldGenerateValidKey()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");

        // Act
        var key1 = generator.GenerateCacheKey("Library-1.0.0", "测试定义");
        var key2 = generator.GenerateCacheKey("Library-1.0.0", "テスト定義");

        // Assert
        Assert.AreNotEqual(0L, key1, "Should generate valid key with Chinese characters");
        Assert.AreNotEqual(0L, key2, "Should generate valid key with Japanese characters");
        Assert.AreNotEqual(key1, key2, "Different unicode strings should generate different keys");
    }

    [TestMethod]
    public void GenerateCacheKey_ParallelGeneration_ShouldGenerateUniqueKeysForDifferentInputs()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");
        var keys = new System.Collections.Concurrent.ConcurrentBag<long>();

        // Act - Generate many keys in parallel
        Parallel.For(0, 100, i =>
        {
            var key = generator.GenerateCacheKey($"Library-{i}", $"Definition-{i}");
            keys.Add(key);
        });

        // Assert - All keys should be unique
        var uniqueKeys = keys.Distinct().ToList();
        Assert.AreEqual(100, uniqueKeys.Count, "All parallel generated keys should be unique");
    }

    [TestMethod]
    public void GenerateCacheKey_WithNullSalt_ShouldUseEmptyString()
    {
        // Arrange
        var generator1 = new DeterministicIdGenerator(null);
        var generator2 = new DeterministicIdGenerator(string.Empty);

        // Act
        var key1 = generator1.GenerateCacheKey("TestLibrary-1.0.0", "TestDefinition");
        var key2 = generator2.GenerateCacheKey("TestLibrary-1.0.0", "TestDefinition");

        // Assert - Null salt should behave same as empty string
        Assert.AreEqual(key1, key2, "Null salt should produce same key as empty string");
    }

    [TestMethod]
    public void GenerateCacheKey_MultipleCalls_ShouldBeThreadSafe()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");
        var keys = new System.Collections.Concurrent.ConcurrentBag<long>();
        var libraryIdentifier = "TestLibrary-1.0.0";
        var definitionName = "TestDefinition";

        // Act - Generate same key multiple times in parallel
        Parallel.For(0, 100, i =>
        {
            var key = generator.GenerateCacheKey(libraryIdentifier, definitionName);
            keys.Add(key);
        });

        // Assert - All keys should be unique (different versions)
        var uniqueKeys = keys.Distinct().ToList();
        Assert.AreEqual(100, uniqueKeys.Count, "All keys should be unique due to version increment");
    }

    [TestMethod]
    public void GenerateCacheKey_Deterministic_SameInputsSameSalt()
    {
        // Arrange
        var salt = "my-library-set";
        var generator1 = new DeterministicIdGenerator(salt);
        var generator2 = new DeterministicIdGenerator(salt);

        // Act
        var key1_1 = generator1.GenerateCacheKey("Lib-1.0.0", "Def1");
        var key2_1 = generator2.GenerateCacheKey("Lib-1.0.0", "Def1");

        // Assert - First call from each generator should produce same key
        Assert.AreEqual(key1_1, key2_1, "Deterministic: same inputs and salt should produce same keys");
    }

    [TestMethod]
    public void GenerateCacheKey_SHA256_ProducesDifferentKeysForSlightlyDifferentInputs()
    {
        // Arrange
        var generator = new DeterministicIdGenerator("test-salt");

        // Act
        var key1 = generator.GenerateCacheKey("TestLibrary-1.0.0", "TestDefinition");
        var key2 = generator.GenerateCacheKey("TestLibrary-1.0.1", "TestDefinition"); // Tiny version change

        // Assert - SHA256 should produce very different outputs for similar inputs
        Assert.AreNotEqual(key1, key2, "SHA256 should produce different keys for slightly different inputs");
    }
}
