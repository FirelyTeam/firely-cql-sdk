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
    public void ReformatUtf8Json_KeepsEscapedStringsAndNamesAsTheirCharacters()
    {
        var source = Encoding.UTF8.GetBytes("""{"a\u0041\n":"q\"uote \\ \/ \t \u00e9 \ud83d\ude00 \u0001"}""");

        var compact = Encoding.UTF8.GetString(LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented: false));

        // Names and values are the same characters, re-escaped by the writer's relaxed encoder.
        Assert.AreEqual("""{"aA\n":"q\"uote \\ / \t é \uD83D\uDE00 \u0001"}""", compact);
        using var document = JsonDocument.Parse(compact);
        Assert.AreEqual("aA\n", document.RootElement.EnumerateObject().Single().Name);
    }

    [TestMethod]
    public void ReformatUtf8Json_InvalidUtf8InALongEscapedString_ThrowsAsForAShortOne()
    {
        // The scratch buffer for an escaped token over 256 bytes is rented, so the long form takes the path
        // that must give the rental back when copying throws. Reading accepts an invalid byte in an escaped
        // string; the copy is what rejects it. (An unpaired surrogate escape does not throw: it becomes
        // U+FFFD.) The pool's state is not observable: ArrayPool<byte>.Shared exposes no count of its rentals.
        static byte[] Source(int padding) =>
            [.. "{\"a\":\"\\n"u8, 0xFF, .. Encoding.UTF8.GetBytes(new string('x', padding)), .. "\"}"u8];

        var shortFailure = Assert.ThrowsException<InvalidOperationException>(() => LibraryJsonSerializer.ReformatUtf8Json(Source(10), writeIndented: false));
        var longFailure = Assert.ThrowsException<InvalidOperationException>(() => LibraryJsonSerializer.ReformatUtf8Json(Source(400), writeIndented: false));

        Assert.AreEqual(shortFailure.Message, longFailure.Message);
    }

    [TestMethod]
    public void ReformatUtf8Json_KeepsEveryFormOfNumberAsWritten()
    {
        const string numbers = "[0,-0,7,-12,1.5,-0.25,1e10,1E+2,1.0e-5,12345678901234567890,0.10000000000000000001]";

        var compact = Encoding.UTF8.GetString(LibraryJsonSerializer.ReformatUtf8Json(Encoding.UTF8.GetBytes(numbers), writeIndented: false));

        Assert.AreEqual(numbers, compact);
    }

    [TestMethod]
    public void ReformatUtf8Json_KeepsLiteralsAndScalarRoots()
    {
        Assert.AreEqual("[true,false,null]", Encoding.UTF8.GetString(LibraryJsonSerializer.ReformatUtf8Json("[ true , false ,null ]"u8.ToArray(), writeIndented: false)));
        Assert.AreEqual("\"x\"", Encoding.UTF8.GetString(LibraryJsonSerializer.ReformatUtf8Json(" \"x\" "u8.ToArray(), writeIndented: false)));
        Assert.AreEqual("42", Encoding.UTF8.GetString(LibraryJsonSerializer.ReformatUtf8Json("42"u8.ToArray(), writeIndented: false)));
    }

    [TestMethod]
    public void ReformatUtf8Json_ReformatsNestingOfAThousandLevels()
    {
        const int depth = 1000;
        var source = Encoding.UTF8.GetBytes(new string('[', depth) + new string(']', depth));

        var compact = LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented: false);
        var indented = LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented: true);

        CollectionAssert.AreEqual(source, compact);
        // The indented text differs from the compact text only by whitespace.
        Assert.AreEqual(Encoding.UTF8.GetString(compact), System.Text.RegularExpressions.Regex.Replace(Encoding.UTF8.GetString(indented), @"\s+", ""));
    }

    [TestMethod]
    [DataRow("")]
    [DataRow("  \n ")]
    [DataRow("{")]
    [DataRow("""{"a":""")]
    [DataRow("""{"a" 1}""")]
    [DataRow("[1,]")]
    [DataRow("{} {}")]
    [DataRow("[1] x")]
    [DataRow("\"unterminated")]
    [DataRow("[01]")]
    [DataRow("// c\n{}")]
    public void ReformatUtf8Json_OfEmptyOrMalformedJson_ThrowsJsonException(string text)
    {
        var source = Encoding.UTF8.GetBytes(text);

        foreach (var writeIndented in new[] { false, true })
            Assert.Throws<JsonException>(() => LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented), text);
    }

    [TestMethod]
    public void ReformatUtf8Json_OfNestingDeeperThanTheMaximumDepth_ThrowsJsonException()
    {
        const int depth = 4097;
        var source = Encoding.UTF8.GetBytes(new string('[', depth) + new string(']', depth));

        Assert.Throws<JsonException>(() => LibraryJsonSerializer.ReformatUtf8Json(source, writeIndented: false));
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

    [TestMethod]
    [DynamicData(nameof(CorpusFiles))]
    public void NormalizeNewLinesUtf8_MatchesTheByteLoop_OnEveryElmFile(string relativePath)
    {
        var lfBytes = ToLf(File.ReadAllBytes(Path.Combine(ElmJsonRoundTripTests.RepositoryRoot.FullName, relativePath)));
        var crlfBytes = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(lfBytes).Replace(Lf, CrLf));

        CollectionAssert.AreEqual(ByteLoop(lfBytes), LibraryJsonSerializer.NormalizeNewLinesUtf8(lfBytes), relativePath);
        CollectionAssert.AreEqual(ByteLoop(crlfBytes), LibraryJsonSerializer.NormalizeNewLinesUtf8(crlfBytes), relativePath);
        Assert.AreSame(lfBytes, LibraryJsonSerializer.NormalizeNewLinesUtf8(lfBytes));
    }

    private static IEnumerable<object[]> CorpusFiles => ElmJsonRoundTripTests.ElmFiles;

    [TestMethod]
    public void NormalizeNewLinesUtf8_MatchesTheByteLoop_OnEdgeCases()
    {
        byte[][] cases =
        [
            [],
            "abc"u8.ToArray(),
            "\r"u8.ToArray(),
            "ab\r"u8.ToArray(),
            "ab\r\n"u8.ToArray(),
            "a\r\r\nb"u8.ToArray(),
            "\r\n\r\n"u8.ToArray(),
            "\n\r"u8.ToArray(),
        ];

        foreach (var input in cases)
            AssertMatchesByteLoop(input);

        // A CRLF and a lone CR at every position of buffers up to 130 bytes, which crosses the 16-, 32-
        // and 64-byte vector boundaries.
        for (var length = 1; length <= 130; length++)
        {
            for (var position = 0; position < length; position++)
            {
                var filler = new byte[length];
                Array.Fill(filler, (byte)'x');

                var lone = (byte[])filler.Clone();
                lone[position] = (byte)'\r';
                AssertMatchesByteLoop(lone);

                if (position + 1 < length)
                {
                    var pair = (byte[])filler.Clone();
                    pair[position] = (byte)'\r';
                    pair[position + 1] = (byte)'\n';
                    AssertMatchesByteLoop(pair);
                }
            }
        }
    }

    private static void AssertMatchesByteLoop(byte[] input) =>
        CollectionAssert.AreEqual(
            ByteLoop(input),
            LibraryJsonSerializer.NormalizeNewLinesUtf8((byte[])input.Clone()),
            $"Input: {System.Convert.ToHexString(input)}");

    private static byte[] ByteLoop(byte[] utf8Json)
    {
        var normalized = new byte[utf8Json.Length];
        var length = 0;

        for (var i = 0; i < utf8Json.Length; i++)
        {
            var b = utf8Json[i];
            if (b == (byte)'\r')
            {
                if (i + 1 < utf8Json.Length && utf8Json[i + 1] == (byte)'\n')
                    i++;
                b = (byte)'\n';
            }

            normalized[length++] = b;
        }

        return normalized[..length];
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
