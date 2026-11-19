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
using Hl7.Cql.Packager.Commands.ReplaceLibraryAttachments;
using Hl7.Cql.Packager.Options;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Options;
using DateTime = System.DateTime;
using FhirLibrary = Hl7.Fhir.Model.Library;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests.Packaging;

/// <summary>
/// Covers the two places that read ELM bytes through a stream rather than through a decoded string:
/// <c>replace-library-attachments</c>, and <see cref="FhirLibraryExtensions"/>'s <c>Create</c> given ELM bytes alone.
/// </summary>
[TestClass]
public class ElmBytesParsingTests
{
    private static readonly byte[] Utf8Bom = [0xEF, 0xBB, 0xBF];

    private static readonly CqlTypeToFhirTypeMapper Mapper = new(new FhirTypeResolver(ModelInfo.ModelInspector));

    private static FileInfo ElmFile => new(Path.Combine("Input", "ELM", "HL7", "CqlBooleanTest.json"));

    private const string FhirLibraryJson =
        """{"resourceType":"Library","id":"existing","name":"CqlBooleanTest","version":"1.0.000","status":"active","type":{"coding":[{"system":"http://terminology.hl7.org/CodeSystem/library-type","code":"logic-library"}]}}""";

    private static byte[] ElmBytes => File.ReadAllBytes(ElmFile.FullName);

    private static byte[] WithBom(byte[] bytes) => [.. Utf8Bom, .. bytes];

    /// <summary>The same ELM with one byte that is not valid UTF-8 inside the string value of <c>signatureLevel</c>.</summary>
    private static byte[] ElmBytesWithInvalidUtf8InAString()
    {
        var text = File.ReadAllText(ElmFile.FullName);
        const string marker = "\"signatureLevel\" : \"All\"";
        text.Should().Contain(marker);

        var split = text.IndexOf(marker, StringComparison.Ordinal) + marker.Length - 2;
        return
        [
            .. Encoding.UTF8.GetBytes(text[..split]),
            0xFF,
            .. Encoding.UTF8.GetBytes(text[split..]),
        ];
    }

    private sealed class CapturingLogger<T> : ILogger<T>
    {
        public List<(LogLevel Level, string Message)> Entries { get; } = [];

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) =>
            Entries.Add((logLevel, formatter(state, exception)));
    }

    private sealed record Replaced(FhirLibrary Library, byte[] ElmAttachment, CapturingLogger<ReplaceLibraryAttachmentsProgram> Log);

    private static Replaced RunReplaceLibraryAttachments(byte[] elmBytes)
    {
        var directory = Directory.CreateTempSubdirectory("replace-library-attachments-");
        try
        {
            var libraryFile = new FileInfo(Path.Combine(directory.FullName, "library.json"));
            var elmFile = new FileInfo(Path.Combine(directory.FullName, "library.elm.json"));
            File.WriteAllText(libraryFile.FullName, FhirLibraryJson);
            File.WriteAllBytes(elmFile.FullName, elmBytes);

            var log = new CapturingLogger<ReplaceLibraryAttachmentsProgram>();
            var program = new ReplaceLibraryAttachmentsProgram(
                log,
                Options.Create(new PackagingOptions()),
                Options.Create(new ReplaceLibraryAttachmentsOptions { LibraryFile = libraryFile, ElmFile = elmFile }));

            program.Run().Should().Be(0, "the command should succeed");

            var library = FhirLibrary.ReadLibraryFromJson(File.ReadAllText(libraryFile.FullName));
            return new Replaced(library, ElmAttachmentOf(library), log);
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    private static void AssertCqlOptionsWritten(FhirLibrary library)
    {
        var options = library.Contained.OfType<Parameters>().Single(p => p.Id == "options");
        options.Parameter.Single(p => p.Name == "translatorVersion").Value.Should().BeOfType<FhirString>()
               .Which.Value.Should().Be("5.0.0");
        options.Parameter.Where(p => p.Name == "option").Select(p => ((FhirString)p.Value!).Value!)
               .Should().Equal("EnableLocators", "EnableResultTypes");
        options.Parameter.Single(p => p.Name == "signatureLevel").Value.Should().BeOfType<FhirString>()
               .Which.Value.Should().Be("All");

        library.Extension.Should().ContainSingle(e => e.Url == Constants.Hl7FhirStructureDefinitionCqlOptions);
    }

    private static FhirLibrary Package(byte[] elmBytes) =>
        FhirLibrary.Create(
            typeCrosswalk: Mapper,
            elmLibrary: null,
            elmBytes: elmBytes,
            cqlBytes: null,
            assemblyBytes: [],
            debugSymbols: [],
            cSharpSourceCodeById: [],
            elmLibrarySet: new LibrarySet("", [Library.LoadFromJson(ElmFile)]),
            resourceCanonicalBuilder: (_, _, _) => "test.firely",
            elmFileLastWriteTimeUtc: new DateTime(2001, 2, 3, 4, 5, 6, DateTimeKind.Local));

    private static byte[] ElmAttachmentOf(FhirLibrary fhirLibrary) =>
        fhirLibrary.Content.Single(c => c.ContentType == Library.JsonMimeType).Data
        ?? throw new InvalidOperationException("The ELM attachment carried no data.");

    [TestMethod]
    public void ReplaceLibraryAttachments_WithAnElmFile_WritesTheCqlOptions()
    {
        var elmBytes = ElmBytes;

        var replaced = RunReplaceLibraryAttachments(elmBytes);

        AssertCqlOptionsWritten(replaced.Library);
        CollectionAssert.AreEqual(elmBytes, replaced.ElmAttachment);
        replaced.Log.Entries.Should().NotContain(e => e.Level >= LogLevel.Warning);
    }

    [TestMethod]
    public void ReplaceLibraryAttachments_WithAnElmFileThatStartsWithABom_WritesTheCqlOptionsAndDropsTheBom()
    {
        var replaced = RunReplaceLibraryAttachments(WithBom(ElmBytes));

        AssertCqlOptionsWritten(replaced.Library);
        CollectionAssert.AreEqual(ElmBytes, replaced.ElmAttachment, "the attachment holds the file's bytes without the BOM");
        AssertParsesAsBytes(replaced.ElmAttachment);
        replaced.Log.Entries.Should().NotContain(e => e.Level >= LogLevel.Warning);
    }

    [TestMethod]
    public void Create_WithElmBytesAlone_PackagesThem()
    {
        var elmBytes = ElmBytes;

        var fhirLibrary = Package(elmBytes);

        AssertCqlOptionsWritten(fhirLibrary);
        CollectionAssert.AreEqual(elmBytes, ElmAttachmentOf(fhirLibrary));
        fhirLibrary.Name.Should().Be("CqlBooleanTest");
    }

    [TestMethod]
    public void Create_WithElmBytesThatStartWithABom_PackagesThemWithoutTheBom()
    {
        var fhirLibrary = Package(WithBom(ElmBytes));

        AssertCqlOptionsWritten(fhirLibrary);
        CollectionAssert.AreEqual(ElmBytes, ElmAttachmentOf(fhirLibrary), "the attachment holds the bytes without the BOM");
        AssertParsesAsBytes(ElmAttachmentOf(fhirLibrary));
    }

    [TestMethod]
    public void LoadFromJson_OfAFileThatStartsWithABom_ReadsItAndKeepsItsSourceWithoutTheBom()
    {
        var file = new FileInfo(Path.GetTempFileName());
        try
        {
            File.WriteAllBytes(file.FullName, WithBom(ElmBytes));

            var library = Library.LoadFromJson(file);

            library.identifier!.id.Should().Be("CqlBooleanTest");
            var source = library.SourceJsonUtf8!;
            source.AsSpan().StartsWith(Utf8Bom).Should().BeFalse("the kept source JSON has no BOM");
            AssertParsesAsBytes(source);
        }
        finally
        {
            file.Delete();
        }
    }

    /// <summary>A reader that takes UTF-8 as bytes, as a consumer of the attachment would, rejects a leading BOM.</summary>
    private static void AssertParsesAsBytes(byte[] utf8Json)
    {
        using var document = JsonDocument.Parse(utf8Json);
        document.RootElement.ValueKind.Should().Be(JsonValueKind.Object);
    }

    [TestMethod]
    public void ReadingBytesThroughAStream_GivesTheSameLibraryAsReadingTheirText()
    {
        var elmBytes = ElmBytes;

        using var stream = new MemoryStream(elmBytes, writable: false);
        var fromStream = Library.LoadFromJson(stream).SerializeToJson(writeIndented: false);
        var fromText = Library.ParseFromJson(Encoding.UTF8.GetString(elmBytes)).SerializeToJson(writeIndented: false);

        (fromStream == fromText).Should().BeTrue();
    }

    /// <summary>
    /// An invalid UTF-8 byte inside a string value reads the same on both routes: the string route decodes it to
    /// U+FFFD before parsing, and the stream route's reader substitutes U+FFFD when it reads the value.
    /// </summary>
    [TestMethod]
    public void InvalidUtf8InAStringValue_ReadsAsTheReplacementCharacterOnBothRoutes()
    {
        var elmBytes = ElmBytesWithInvalidUtf8InAString();

        var viaString = Library.ParseFromJson(Encoding.UTF8.GetString(elmBytes));
        using var stream = new MemoryStream(elmBytes, writable: false);
        var viaStream = Library.LoadFromJson(stream);

        viaString.annotation!.OfType<Hl7.Cql.Elm.CqlToElmInfo>().Single().signatureLevel.Should().Be("Al�l");
        viaStream.annotation!.OfType<Hl7.Cql.Elm.CqlToElmInfo>().Single().signatureLevel.Should().Be("Al�l");
        (viaStream.SerializeToJson(writeIndented: false) == viaString.SerializeToJson(writeIndented: false)).Should().BeTrue();
    }
}
