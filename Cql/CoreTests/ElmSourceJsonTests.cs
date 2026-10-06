/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

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
    private const string Lf = "\n";
    private const string CrLf = "\r\n";

    private static FileInfo ElmFile => new(Path.Combine("Input", "ELM", "HL7", "CqlBooleanTest.json"));

    [TestMethod]
    public void LoadFromJson_FromFile_RetainsTheSourceBytesWithNormalizedNewLines()
    {
        var library = Library.LoadFromJson(ElmFile);

        Assert.IsNotNull(library.SourceJsonUtf8);
        Assert.IsFalse(
            library.SourceJsonUtf8!.Contains((byte)'\r'),
            "Retained source bytes should carry no CR, whatever the file was checked out with.");
        CollectionAssert.AreEqual(
            ToLf(File.ReadAllBytes(ElmFile.FullName)),
            library.SourceJsonUtf8);
    }

    /// <summary>
    /// A source file is checked out with whatever line endings the platform uses, and these bytes are
    /// embedded verbatim as a base64 attachment that git cannot normalize. Without normalizing them the
    /// same library packaged on Windows and on Unix yields different attachments.
    /// </summary>
    [TestMethod]
    public void SourceJson_IsTheSameWhicheverNewLineTheFileUses()
    {
        var lfBytes = ToLf(File.ReadAllBytes(ElmFile.FullName));
        var lfFile = WriteTempCopy(lfBytes, toCrLf: false);
        var crlfFile = WriteTempCopy(lfBytes, toCrLf: true);

        try
        {
            Assert.IsTrue(
                new FileInfo(crlfFile).Length > new FileInfo(lfFile).Length,
                "The CRLF copy should be the larger file, or this test exercises nothing.");

            var fromLf = Library.LoadFromJson(new FileInfo(lfFile));
            var fromCrLf = Library.LoadFromJson(new FileInfo(crlfFile));

            CollectionAssert.AreEqual(fromLf.SourceJsonUtf8, fromCrLf.SourceJsonUtf8);
        }
        finally
        {
            File.Delete(lfFile);
            File.Delete(crlfFile);
        }
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

    [TestMethod]
    public void NormalizeNewLinesUtf8_LeavesTextWithoutCarriageReturnsAlone()
    {
        var utf8 = Encoding.UTF8.GetBytes($"{{{Lf}  \"a\": 1{Lf}}}");

        Assert.AreSame(utf8, LibraryJsonSerializer.NormalizeNewLinesUtf8(utf8));
    }

    [TestMethod]
    public void NormalizeNewLinesUtf8_RewritesCrLfAndALoneCr()
    {
        var utf8 = Encoding.UTF8.GetBytes($"a{CrLf}b\rc{Lf}d");

        var normalized = Encoding.UTF8.GetString(LibraryJsonSerializer.NormalizeNewLinesUtf8(utf8));

        Assert.AreEqual($"a{Lf}b{Lf}c{Lf}d", normalized);
    }

    /// <summary>
    /// A CR inside a JSON string is escaped rather than literal, so normalizing the bytes cannot corrupt
    /// a value that genuinely contains one.
    /// </summary>
    [TestMethod]
    public void NormalizeNewLinesUtf8_DoesNotTouchAnEscapedCarriageReturn()
    {
        var json = "{\"a\":\"x\\r\\ny\"}";
        var utf8 = Encoding.UTF8.GetBytes(json.Replace("\"}", $"\"}}{CrLf}"));

        var normalized = Encoding.UTF8.GetString(LibraryJsonSerializer.NormalizeNewLinesUtf8(utf8));

        StringAssert.Contains(normalized, "x\\r\\ny");
        Assert.AreEqual($"{json}{Lf}", normalized);
    }

    private static byte[] ToLf(byte[] utf8) =>
        Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(utf8).Replace(CrLf, Lf).Replace("\r", Lf));

    private static string WriteTempCopy(byte[] lfBytes, bool toCrLf)
    {
        var text = Encoding.UTF8.GetString(lfBytes);
        if (toCrLf)
            text = text.Replace(Lf, CrLf);

        var path = Path.Combine(Path.GetTempPath(), $"elm-{Guid.NewGuid():N}.json");
        File.WriteAllBytes(path, Encoding.UTF8.GetBytes(text));
        return path;
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
