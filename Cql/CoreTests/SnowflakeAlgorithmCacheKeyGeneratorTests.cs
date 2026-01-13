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
public class SnowflakeAlgorithmCacheKeyGeneratorTests
{
    [TestMethod]
    public void GenerateCacheKey_WithSameInputs_ShouldReturnConsistentSequence()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
        var libraryIdentifier = "TestLibrary-1.0.0";
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator.GenerateCacheKey(libraryIdentifier, definitionName);
        var key2 = generator.GenerateCacheKey(libraryIdentifier, definitionName);
        var key3 = generator.GenerateCacheKey(libraryIdentifier, definitionName);

        // Assert - Keys should differ only in the sequence bits (bottom 2 bits)
        var baseKey1 = key1 & ~0x3L; // Remove sequence bits
        var baseKey2 = key2 & ~0x3L;
        var baseKey3 = key3 & ~0x3L;
        
        Assert.AreEqual(baseKey1, baseKey2, "Base keys should be the same");
        Assert.AreEqual(baseKey2, baseKey3, "Base keys should be the same");
        
        // Verify sequence increments
        var seq1 = key1 & 0x3L;
        var seq2 = key2 & 0x3L;
        var seq3 = key3 & 0x3L;
        
        Assert.AreEqual(0L, seq1, "First call should have sequence 0");
        Assert.AreEqual(1L, seq2, "Second call should have sequence 1");
        Assert.AreEqual(2L, seq3, "Third call should have sequence 2");
    }

    [TestMethod]
    public void GenerateCacheKey_WithDifferentLibraries_ShouldReturnDifferentKeys()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
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
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
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
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator.GenerateCacheKey("TestLibrary-1.0.0", definitionName);
        var key2 = generator.GenerateCacheKey("TestLibrary-2.0.0", definitionName);

        // Assert
        Assert.AreNotEqual(key1, key2, "Different versions should generate different keys");
    }

    [TestMethod]
    public void GenerateCacheKey_ShouldReturnNonZeroKey()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();

        // Act
        var key = generator.GenerateCacheKey("TestLibrary-1.0.0", "TestDefinition");

        // Assert
        Assert.AreNotEqual(0L, key, "Generated key should not be zero");
    }

    [TestMethod]
    public void GenerateCacheKey_MultipleCallsSameGenerator_ShouldIncrementSequence()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
        var libraryIdentifier = "TestLibrary-1.0.0";
        var definitionName = "TestDefinition";

        // Act - Generate the same key multiple times in quick succession
        var key1 = generator.GenerateCacheKey(libraryIdentifier, definitionName);
        var key2 = generator.GenerateCacheKey(libraryIdentifier, definitionName);
        var key3 = generator.GenerateCacheKey(libraryIdentifier, definitionName);
        var key4 = generator.GenerateCacheKey(libraryIdentifier, definitionName);

        // Assert - Base keys should be the same (removing sequence bits)
        var baseKey = key1 & ~0x3L;
        Assert.AreEqual(baseKey, key2 & ~0x3L, "Base keys should be equal");
        Assert.AreEqual(baseKey, key3 & ~0x3L, "Base keys should be equal");
        Assert.AreEqual(baseKey, key4 & ~0x3L, "Base keys should be equal");

        // Sequence should increment from 0 to 3
        Assert.AreEqual(0L, key1 & 0x3L, "First sequence should be 0");
        Assert.AreEqual(1L, key2 & 0x3L, "Second sequence should be 1");
        Assert.AreEqual(2L, key3 & 0x3L, "Third sequence should be 2");
        Assert.AreEqual(3L, key4 & 0x3L, "Fourth sequence should be 3");
    }

    [TestMethod]
    public void GenerateCacheKey_WithEmptyStrings_ShouldGenerateValidKey()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();

        // Act
        var key = generator.GenerateCacheKey("", "");

        // Assert
        Assert.AreNotEqual(0L, key, "Should generate valid key even with empty strings");
    }

    [TestMethod]
    public void GenerateCacheKey_WithSpecialCharacters_ShouldGenerateValidKey()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();

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
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
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
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();

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
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
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
    public void GenerateCacheKey_KeyStructure_ShouldContainTimestampComponent()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
        var epoch = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        var beforeSeconds = (uint)(DateTime.UtcNow - epoch).TotalSeconds;

        // Act
        var key = generator.GenerateCacheKey("TestLibrary-1.0.0", "TestDefinition");

        // Extract timestamp component (top 30 bits)
        var timestampFromKey = (uint)((key >> 34) & 0x3FFFFFFFL);

        var afterSeconds = (uint)(DateTime.UtcNow - epoch).TotalSeconds;

        // Assert
        Assert.IsTrue(timestampFromKey >= beforeSeconds && timestampFromKey <= afterSeconds,
            $"Timestamp component should be between {beforeSeconds} and {afterSeconds}, but was {timestampFromKey}");
    }

    [TestMethod]
    public void GenerateCacheKey_SequenceComponent_ShouldBe2Bits()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();

        // Act
        var key = generator.GenerateCacheKey("TestLibrary-1.0.0", "TestDefinition");

        // Extract sequence component (bottom 2 bits)
        var sequence = key & 0x3L;

        // Assert
        Assert.IsTrue(sequence >= 0 && sequence <= 3,
            $"Sequence component should be 0-3 (2 bits), but was {sequence}");
    }

    [TestMethod]
    public void GenerateCacheKey_MultipleGenerators_ShouldGenerateDifferentKeysForSameInput()
    {
        // Arrange - Create separate generator instances
        var generator1 = new SnowflakeAlgorithmCacheKeyGenerator();
        var generator2 = new SnowflakeAlgorithmCacheKeyGenerator();
        
        var libraryIdentifier = "TestLibrary-1.0.0";
        var definitionName = "TestDefinition";

        // Act
        var key1 = generator1.GenerateCacheKey(libraryIdentifier, definitionName);
        
        // Small delay to ensure different timestamp
        Thread.Sleep(1100);
        
        var key2 = generator2.GenerateCacheKey(libraryIdentifier, definitionName);

        // Assert - Keys should be different due to different timestamps
        Assert.AreNotEqual(key1, key2, 
            "Different generator instances with time gap should generate different keys due to timestamp");
    }

    [TestMethod]
    public void GenerateCacheKey_RapidGeneration_ShouldHandleSequenceIncrement()
    {
        // Arrange
        var generator = new SnowflakeAlgorithmCacheKeyGenerator();
        var keys = new HashSet<long>();

        // Act - Generate multiple keys rapidly for same input
        for (int i = 0; i < 4; i++)
        {
            var key = generator.GenerateCacheKey("TestLibrary-1.0.0", $"TestDefinition-{i}");
            keys.Add(key);
        }

        // Assert - All keys should be unique
        Assert.AreEqual(4, keys.Count, "All rapidly generated keys should be unique");
    }
}
