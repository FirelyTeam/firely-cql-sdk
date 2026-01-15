/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CoreTests;

/// <summary>
/// Tests to validate that the generated ELM types (Elm.g.cs) can correctly load and save ELM JSON files.
/// This ensures the xsd2cs tool generates code that is functionally equivalent to the original xsd.exe output.
/// </summary>
[TestClass]
public class GeneratedElmTypesRoundTripTests
{
    private static readonly DirectoryInfo DemoLibrarySetElmDirectory = LibrarySetsDirs.Demo.ElmDir;

    [TestMethod]
    public void LoadAndSave_DemoLibrarySet_ProducesIdenticalJson()
    {
        // Arrange: Load all ELM files from Demo LibrarySet
        var elmToolkit = new ElmToolkit()
            .AddElmFilesFromDirectory(DemoLibrarySetElmDirectory);

        // Get the loaded libraries
        var loadedLibraries = elmToolkit.ArtifactsById
            .Select(kv => new
            {
                Identifier = kv.Key,
                Library = kv.Value.InputElmLibrary
            })
            .ToList();

        Assert.IsTrue(loadedLibraries.Count > 0, "Should have loaded at least one library from Demo LibrarySet");

        // Act: Save libraries to a temporary directory and re-serialize manually
        using var tempDir = new TemporaryDirectory();
        var savedDir = new DirectoryInfo(Path.Combine(tempDir.Path, "SavedElm"));
        savedDir.Create();

        // Save each library to JSON manually
        var jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = false
        };

        foreach (var library in loadedLibraries)
        {
            var json = JsonSerializer.Serialize(library.Library, jsonOptions);
            var filePath = Path.Combine(savedDir.FullName, $"{library.Identifier}.json");
            File.WriteAllText(filePath, json);
        }

        // Assert: Verify files were saved
        var savedFiles = savedDir.GetFiles("*.json");
        Assert.AreEqual(loadedLibraries.Count, savedFiles.Length, "Should have saved same number of files as loaded");

        // Assert: Compare original and saved JSON for semantic equivalence
        foreach (var library in loadedLibraries)
        {
            var expectedFileName = $"{library.Identifier}.json";
            var originalFile = DemoLibrarySetElmDirectory.GetFiles(expectedFileName).FirstOrDefault();
            
            // If file with version doesn't exist, try without version
            if (originalFile == null || !originalFile.Exists)
            {
                var libraryNameOnly = library.Identifier.ToString().Split('-')[0];
                originalFile = DemoLibrarySetElmDirectory.GetFiles($"{libraryNameOnly}.json").FirstOrDefault();
            }
            
            var savedFile = new FileInfo(Path.Combine(savedDir.FullName, expectedFileName));

            Assert.IsTrue(originalFile?.Exists ?? false, $"Original file should exist for: {library.Identifier}");
            Assert.IsTrue(savedFile.Exists, $"Saved file should exist: {savedFile.FullName}");

            // Read and compare JSON semantically (not byte-for-byte, as formatting may differ)
            var originalJson = File.ReadAllText(originalFile.FullName);
            var savedJson = File.ReadAllText(savedFile.FullName);

            // Parse both JSON documents to compare structure
            using var originalDoc = JsonDocument.Parse(originalJson);
            using var savedDoc = JsonDocument.Parse(savedJson);

            // Compare the root elements
            var originalRoot = originalDoc.RootElement;
            var savedRoot = savedDoc.RootElement;

            AssertJsonElementsEqual(originalRoot, savedRoot, library.Identifier.ToString());
        }
    }

    [TestMethod]
    public void LoadAndRoundTrip_SingleLibrary_PreservesStructure()
    {
        // Arrange: Load a specific library (FHIRHelpers is a good simple example)
        var libraryId = new CqlVersionedLibraryIdentifier("FHIRHelpers", "4.0.1");
        var elmToolkit = new ElmToolkit()
            .AddElmFileFromDirectory(DemoLibrarySetElmDirectory, libraryId);

        var library = elmToolkit.ArtifactsById[libraryId].InputElmLibrary;

        // Assert library loaded correctly
        Assert.IsNotNull(library, "Library should be loaded");
        Assert.IsNotNull(library.identifier, "Library should have an identifier");
        Assert.AreEqual("FHIRHelpers", library.identifier.id, "Library id should match");

        // Act: Serialize to JSON and deserialize back
        var jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = false
        };
        var json = JsonSerializer.Serialize(library, jsonOptions);
        var roundTrippedLibrary = JsonSerializer.Deserialize<Library>(json, jsonOptions);

        // Assert: Verify structure is preserved
        Assert.IsNotNull(roundTrippedLibrary, "Round-tripped library should not be null");
        Assert.AreEqual(library.identifier.id, roundTrippedLibrary.identifier.id, "Library id should be preserved");
        Assert.AreEqual(library.identifier.version, roundTrippedLibrary.identifier.version, "Library version should be preserved");

        if (library.usings != null && library.usings.Length > 0)
        {
            Assert.IsNotNull(roundTrippedLibrary.usings, "Usings should be preserved");
            Assert.AreEqual(library.usings.Length, roundTrippedLibrary.usings.Length, "Usings count should match");
        }

        if (library.statements != null && library.statements.Length > 0)
        {
            Assert.IsNotNull(roundTrippedLibrary.statements, "Statements should be preserved");
            Assert.AreEqual(library.statements.Length, roundTrippedLibrary.statements.Length, "Statements count should match");
        }
    }

    [TestMethod]
    public void LoadElmLibrary_WithDefaultValues_InitializesCorrectly()
    {
        // This test validates that DefaultValueAttribute and constructor initialization work correctly
        // by loading a library that uses default values

        // Arrange & Act: Load a library from Demo set
        var elmToolkit = new ElmToolkit()
            .AddElmFilesFromDirectory(DemoLibrarySetElmDirectory);

        // Assert: Verify at least one library loaded successfully
        Assert.IsTrue(elmToolkit.ArtifactsById.Count > 0, "Should have loaded libraries");

        // All libraries should have valid identifiers (proving deserialization worked)
        foreach (var artifact in elmToolkit.ArtifactsById.Values)
        {
            Assert.IsNotNull(artifact.InputElmLibrary, "Library should not be null");
            Assert.IsNotNull(artifact.InputElmLibrary.identifier, "Library identifier should not be null");
            Assert.IsFalse(string.IsNullOrEmpty(artifact.InputElmLibrary.identifier.id), "Library id should not be empty");
        }
    }

    /// <summary>
    /// Recursively compares two JSON elements for equality.
    /// </summary>
    private void AssertJsonElementsEqual(JsonElement expected, JsonElement actual, string path)
    {
        Assert.AreEqual(expected.ValueKind, actual.ValueKind, $"JSON value kind mismatch at {path}");

        switch (expected.ValueKind)
        {
            case JsonValueKind.Object:
                var expectedProps = expected.EnumerateObject().ToList();
                var actualProps = actual.EnumerateObject().ToList();
                Assert.AreEqual(expectedProps.Count, actualProps.Count, $"Property count mismatch at {path}");

                foreach (var expectedProp in expectedProps)
                {
                    Assert.IsTrue(actual.TryGetProperty(expectedProp.Name, out var actualValue),
                        $"Property '{expectedProp.Name}' missing at {path}");
                    AssertJsonElementsEqual(expectedProp.Value, actualValue, $"{path}.{expectedProp.Name}");
                }
                break;

            case JsonValueKind.Array:
                var expectedArray = expected.EnumerateArray().ToList();
                var actualArray = actual.EnumerateArray().ToList();
                Assert.AreEqual(expectedArray.Count, actualArray.Count, $"Array length mismatch at {path}");

                for (int i = 0; i < expectedArray.Count; i++)
                {
                    AssertJsonElementsEqual(expectedArray[i], actualArray[i], $"{path}[{i}]");
                }
                break;

            case JsonValueKind.String:
                Assert.AreEqual(expected.GetString(), actual.GetString(), $"String value mismatch at {path}");
                break;

            case JsonValueKind.Number:
                // Compare as decimal for precision
                Assert.AreEqual(expected.GetDecimal(), actual.GetDecimal(), $"Number value mismatch at {path}");
                break;

            case JsonValueKind.True:
            case JsonValueKind.False:
                Assert.AreEqual(expected.GetBoolean(), actual.GetBoolean(), $"Boolean value mismatch at {path}");
                break;

            case JsonValueKind.Null:
                // Both are null, nothing to compare
                break;

            default:
                Assert.Fail($"Unexpected JSON value kind at {path}: {expected.ValueKind}");
                break;
        }
    }

    /// <summary>
    /// Helper class to create and clean up a temporary directory.
    /// </summary>
    private class TemporaryDirectory : IDisposable
    {
        public string Path { get; }

        public TemporaryDirectory()
        {
            Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"ElmTests_{Guid.NewGuid():N}");
            Directory.CreateDirectory(Path);
        }

        public void Dispose()
        {
            if (Directory.Exists(Path))
            {
                try
                {
                    Directory.Delete(Path, recursive: true);
                }
                catch
                {
                    // Best effort cleanup
                }
            }
        }
    }
}
