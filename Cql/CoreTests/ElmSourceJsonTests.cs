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
using Hl7.Cql.Elm.Serialization;

namespace CoreTests;

/// <summary>
/// Covers the ELM JSON a library retains from the file it was read from, and the reformatting that
/// reuses it instead of serializing the ELM graph again.
/// </summary>
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

        // Only the file overload retains the bytes. The stream overload would have to buffer a stream of
        // unknown length to do the same, so callers fall back to serializing the graph.
        Assert.IsNull(library.SourceJsonUtf8);
    }

    [TestMethod]
    public void ToJsonUtf8_PreservesContentExactly()
    {
        var library = Library.LoadFromJson(ElmFile);

        AssertSameJsonContent(library.SourceJsonUtf8!, library.ToJsonUtf8(writeIndented: true));
        AssertSameJsonContent(library.SourceJsonUtf8!, library.ToJsonUtf8(writeIndented: false));
    }

    [TestMethod]
    public void ToJsonUtf8_Compact_IsSmallerThanIndented()
    {
        var library = Library.LoadFromJson(ElmFile);

        Assert.IsTrue(
            library.ToJsonUtf8(writeIndented: false).Length < library.ToJsonUtf8(writeIndented: true).Length,
            "Compact output should be smaller than indented output.");
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
        using var document = JsonDocument.Parse(json);
        Assert.IsTrue(document.RootElement.TryGetProperty("library", out _));
    }

    /// <summary>
    /// The default <see cref="System.Text.Json"/> encoder escapes characters that need no escaping in
    /// JSON, which ELM carries in the CQL text of its annotations. Reformatting must not rewrite them,
    /// or every annotation containing a comparison operator changes on the way through.
    /// </summary>
    [TestMethod]
    public void ReformatUtf8Json_LeavesCharactersThatNeedNoEscapingAlone()
    {
        var source = Encoding.UTF8.GetBytes("""{"cql":"define X: A < B and C > D and E & F","plus":"a+b","unicode":"café"}""");

        foreach (var writeIndented in new[] { true, false })
        {
            var reformatted = Encoding.UTF8.GetString(LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented));

            StringAssert.Contains(reformatted, "A < B", $"'<' was escaped (writeIndented: {writeIndented}).");
            StringAssert.Contains(reformatted, "C > D", $"'>' was escaped (writeIndented: {writeIndented}).");
            StringAssert.Contains(reformatted, "E & F", $"'&' was escaped (writeIndented: {writeIndented}).");
            StringAssert.Contains(reformatted, "a+b", $"'+' was escaped (writeIndented: {writeIndented}).");
            StringAssert.Contains(reformatted, "café", $"Non-ASCII was escaped (writeIndented: {writeIndented}).");
        }
    }

    [TestMethod]
    public void ReformatUtf8Json_ChangesFormattingOnly()
    {
        var source = Encoding.UTF8.GetBytes("""{"a":[1,2,{"b":null,"c":[]}],"d":{},"e":"x"}""");

        var indented = LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented: true);
        var compact = LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented: false);

        // Empty objects and arrays survive: reformatting is not serialization, which drops them.
        AssertSameJsonContent(source, indented);
        AssertSameJsonContent(source, compact);
        Assert.IsTrue(indented.Length > compact.Length);
    }

    /// <summary>
    /// Compares two JSON documents by content, ignoring the whitespace and string escaping that
    /// reformatting is allowed to change.
    /// </summary>
    private static void AssertSameJsonContent(byte[] expected, byte[] actual)
    {
        var options = LibraryJsonSerializer.GetJsonDocumentOptions();
        using var expectedDocument = JsonDocument.Parse(expected, options);
        using var actualDocument = JsonDocument.Parse(actual, options);

        Assert.AreEqual(
            JsonSerializer.Serialize(expectedDocument.RootElement),
            JsonSerializer.Serialize(actualDocument.RootElement));
    }
}
