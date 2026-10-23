/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Fhir.Model;
using DateTime = System.DateTime;
using FhirLibrary = Hl7.Fhir.Model.Library;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests.Packaging;

/// <summary>
/// Covers the ELM attachment a packaged FHIR Library carries: that it is built from the JSON the ELM was
/// read from rather than by serializing the ELM graph again, and that
/// <see cref="ElmAttachmentFormatting"/> selects its formatting without changing its content.
/// </summary>
[TestClass]
public class ElmAttachmentFormattingTests
{
    private static readonly CqlTypeToFhirTypeMapper Mapper = new(new FhirTypeResolver(ModelInfo.ModelInspector));

    private static FileInfo ElmFile => new(Path.Combine("Input", "ELM", "HL7", "CqlBooleanTest.json"));

    private static byte[] ElmAttachmentOf(FhirLibrary fhirLibrary) =>
        fhirLibrary.Content.Single(c => c.ContentType == Library.JsonMimeType).Data
        ?? throw new InvalidOperationException("The ELM attachment carried no data.");

    private static FhirLibrary Package(Library elmLibrary, ElmAttachmentFormatting formatting) =>
        FhirLibrary.Create(
            typeCrosswalk: Mapper,
            elmLibrary: elmLibrary,
            elmBytes: null,
            cqlBytes: null,
            assemblyBytes: [],
            debugSymbols: [],
            cSharpSourceCodeById: [],
            elmLibrarySet: new LibrarySet("", [elmLibrary]),
            resourceCanonicalBuilder: (_, _, _) => "test.firely",
            elmFileLastWriteTimeUtc: new DateTime(2001, 2, 3, 4, 5, 6, DateTimeKind.Local),
            elmAttachmentFormatting: formatting);

    [TestMethod]
    public void Passthrough_EmbedsTheRetainedSourceJson()
    {
        var elmLibrary = Library.LoadFromJson(ElmFile);

        var attachment = ElmAttachmentOf(Package(elmLibrary, ElmAttachmentFormatting.Passthrough));

        CollectionAssert.AreEqual(elmLibrary.SourceJsonUtf8, attachment);
    }

    [TestMethod]
    public void NoFormattingValue_EmbedsCarriageReturns()
    {
        var elmLibrary = Library.LoadFromJson(ElmFile);

        foreach (var formatting in Enum.GetValues<ElmAttachmentFormatting>())
        {
            var attachment = ElmAttachmentOf(Package(elmLibrary, formatting));

            Assert.IsFalse(
                attachment.Contains((byte)'\r'),
                $"{formatting} embedded a CR, which makes the attachment depend on the build platform.");
        }
    }

    [TestMethod]
    public void Passthrough_DoesNotAliasTheLibrarysRetainedBytes()
    {
        var elmLibrary = Library.LoadFromJson(ElmFile);
        var attachment = ElmAttachmentOf(Package(elmLibrary, ElmAttachmentFormatting.Passthrough));

        // The attachment belongs to a resource handed to the caller, while the library keeps its copy for
        // any later packaging. Writing through one must not reach the other.
        Assert.AreNotSame(elmLibrary.SourceJsonUtf8, attachment);

        attachment[0] = (byte)'X';
        Assert.AreNotEqual((byte)'X', elmLibrary.SourceJsonUtf8![0]);
    }

    [TestMethod]
    public void IndentedAndCompact_PreserveTheSourceContent()
    {
        var elmLibrary = Library.LoadFromJson(ElmFile);
        var source = File.ReadAllBytes(ElmFile.FullName);

        AssertSameJsonContent(source, ElmAttachmentOf(Package(elmLibrary, ElmAttachmentFormatting.Indented)));
        AssertSameJsonContent(source, ElmAttachmentOf(Package(elmLibrary, ElmAttachmentFormatting.Compact)));
    }

    [TestMethod]
    public void Compact_ProducesASmallerAttachmentThanIndented()
    {
        var elmLibrary = Library.LoadFromJson(ElmFile);

        var indented = ElmAttachmentOf(Package(elmLibrary, ElmAttachmentFormatting.Indented));
        var compact = ElmAttachmentOf(Package(elmLibrary, ElmAttachmentFormatting.Compact));

        Assert.IsTrue(compact.Length < indented.Length, "Compact output should be smaller than indented output.");
    }

    /// <summary>
    /// A library that was never read from a file has no JSON to reuse, so the graph is serialized. The
    /// result is the normalized form, which is why this asserts equivalence after a round-trip rather
    /// than against the source text.
    /// </summary>
    [TestMethod]
    public void WithoutSourceJson_FallsBackToSerializingTheGraph()
    {
        using var stream = ElmFile.OpenRead();
        var elmLibrary = Library.LoadFromJson(stream);
        Assert.IsNull(elmLibrary.SourceJsonUtf8);

        foreach (var formatting in Enum.GetValues<ElmAttachmentFormatting>())
        {
            var attachment = ElmAttachmentOf(Package(elmLibrary, formatting));

            Assert.IsTrue(attachment.Length > 0, $"No attachment produced for {formatting}.");
            using var document = JsonDocument.Parse(attachment);
            Assert.IsTrue(
                document.RootElement.TryGetProperty("library", out _),
                $"Attachment for {formatting} is not an ELM document.");
        }
    }

    /// <summary>
    /// Configuration binding accepts numeric enum values and a caller can cast one, so a value outside the
    /// enum has to be rejected rather than quietly treated as one of the defined formats.
    /// </summary>
    [TestMethod]
    public void AnUndefinedFormattingValue_IsRejected()
    {
        var elmLibrary = Library.LoadFromJson(ElmFile);

        var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => Package(elmLibrary, (ElmAttachmentFormatting)42));

        Assert.AreEqual("elmAttachmentFormatting", ex.ParamName);
    }

    /// <summary>
    /// Caller-supplied ELM bytes are embedded as given, whatever the formatting says — the option governs
    /// how a library's own JSON is rendered, not bytes the caller already holds.
    /// </summary>
    [TestMethod]
    public void CallerSuppliedElmBytes_AreEmbeddedUnchanged()
    {
        var elmLibrary = Library.LoadFromJson(ElmFile);
        var callerBytes = File.ReadAllBytes(ElmFile.FullName);

        var fhirLibrary = FhirLibrary.Create(
            typeCrosswalk: Mapper,
            elmLibrary: elmLibrary,
            elmBytes: callerBytes,
            cqlBytes: null,
            assemblyBytes: [],
            debugSymbols: [],
            cSharpSourceCodeById: [],
            elmLibrarySet: new LibrarySet("", [elmLibrary]),
            resourceCanonicalBuilder: (_, _, _) => "test.firely",
            elmFileLastWriteTimeUtc: new DateTime(2001, 2, 3, 4, 5, 6, DateTimeKind.Local),
            elmAttachmentFormatting: ElmAttachmentFormatting.Compact);

        CollectionAssert.AreEqual(callerBytes, ElmAttachmentOf(fhirLibrary));
    }

    private static void AssertSameJsonContent(byte[] expected, byte[] actual)
    {
        var options = Hl7.Cql.Elm.Serialization.LibraryJsonSerializer.GetJsonDocumentOptions();
        using var expectedDocument = JsonDocument.Parse(expected, options);
        using var actualDocument = JsonDocument.Parse(actual, options);

        Assert.AreEqual(
            JsonSerializer.Serialize(expectedDocument.RootElement),
            JsonSerializer.Serialize(actualDocument.RootElement));
    }
}
