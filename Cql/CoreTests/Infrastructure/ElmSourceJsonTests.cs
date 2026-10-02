/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Text.Json;
using Hl7.Cql.Elm;

namespace CoreTests.Infrastructure;

[TestClass]
public class ElmSourceJsonTests
{
    private static FileInfo ElmFile => new(Path.Combine("Input", "ELM", "HL7", "CqlBooleanTest.json"));

    [TestMethod]
    public void LoadFromJson_FromFile_RetainsSourceBytesVerbatim()
    {
        var library = Library.LoadFromJson(ElmFile);

        Assert.IsNotNull(library.SourceJsonUtf8);
        CollectionAssert.AreEqual(File.ReadAllBytes(ElmFile.FullName), library.SourceJsonUtf8);
    }

    [TestMethod]
    public void LoadFromJson_FromStream_HasNoSourceBytes()
    {
        using var stream = ElmFile.OpenRead();
        var library = Library.LoadFromJson(stream);

        // Only the file overload holds the bytes; the stream overload has nothing to retain, and
        // callers fall back to serializing the graph.
        Assert.IsNull(library.SourceJsonUtf8);
    }

    [TestMethod]
    public void ToJsonUtf8_ChangesWhitespaceOnly()
    {
        var library = Library.LoadFromJson(ElmFile);

        var indented = library.ToJsonUtf8(writeIndented: true);
        var compact = library.ToJsonUtf8(writeIndented: false);

        Assert.IsTrue(compact.Length < indented.Length, "Compact output should be smaller than indented output.");
        AssertSameJson(library.SourceJsonUtf8!, indented);
        AssertSameJson(library.SourceJsonUtf8!, compact);
    }

    [TestMethod]
    public void ToJsonUtf8_RoundTripsBackToAnEquivalentLibrary()
    {
        var library = Library.LoadFromJson(ElmFile);

        foreach (var writeIndented in new[] { true, false })
        {
            using var stream = new MemoryStream(library.ToJsonUtf8(writeIndented));
            var reloaded = Library.LoadFromJson(stream);

            Assert.AreEqual(
                library.VersionedLibraryIdentifier,
                reloaded.VersionedLibraryIdentifier,
                $"Round-tripping with writeIndented: {writeIndented} changed the library identifier.");
        }
    }

    [TestMethod]
    public void ToJsonUtf8_WithoutSourceBytes_SerializesTheGraph()
    {
        using var stream = ElmFile.OpenRead();
        var library = Library.LoadFromJson(stream);

        var json = library.ToJsonUtf8(writeIndented: false);

        Assert.IsNull(library.SourceJsonUtf8);
        Assert.IsTrue(json.Length > 0);
        // Serializing normalizes, so this is deliberately only checked for well-formedness.
        using var document = JsonDocument.Parse(json);
        Assert.IsTrue(document.RootElement.TryGetProperty("library", out _));
    }

    private static void AssertSameJson(byte[] expected, byte[] actual)
    {
        var options = Hl7.Cql.Elm.Serialization.LibraryJsonSerializer.GetJsonDocumentOptions();
        using var expectedDocument = JsonDocument.Parse(expected, options);
        using var actualDocument = JsonDocument.Parse(actual, options);

        // Comparing the minified form of both documents compares content while ignoring the whitespace
        // that is the only thing these values are allowed to change.
        Assert.AreEqual(
            JsonSerializer.Serialize(expectedDocument.RootElement),
            JsonSerializer.Serialize(actualDocument.RootElement));
    }
}
