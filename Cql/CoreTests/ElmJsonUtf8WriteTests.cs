/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Encodings.Web;
using Hl7.Cql.Elm;
using Hl7.Cql.Elm.Serialization;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

/// <summary>
/// <c>ToJsonUtf8</c> writes UTF-8 directly. These tests hold its bytes to what the string route and the
/// <see cref="MemoryStream"/> route, followed by a newline pass, wrote before.
/// </summary>
[TestClass]
public class ElmJsonUtf8WriteTests
{
    private const int DeepStackBytes = 64 * 1024 * 1024;

    // The route this change replaced when the library has no source: serialize to a string, encode, replace CR LF.
    private static byte[] OldSerializedBytes(Library library, bool writeIndented) =>
        Encoding.UTF8.GetBytes(library.SerializeToJson(writeIndented).Replace("\r\n", "\n"));

    // The route this change replaced when the library keeps its source: a document written through a MemoryStream
    // by a writer with the default maximum depth of 1,000, unless a depth is given.
    private static byte[] OldReformattedBytes(byte[] source, bool writeIndented, int writerMaxDepth = 0)
    {
        using var document = JsonDocument.Parse(source, new JsonDocumentOptions { MaxDepth = 4096 });
        using var stream = new MemoryStream(writeIndented ? source.Length * 2 : source.Length);
        using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions
        {
            Indented = writeIndented,
            MaxDepth = writerMaxDepth,
            SkipValidation = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        }))
        {
            document.RootElement.WriteTo(writer);
        }

        return LibraryJsonSerializer.NormalizeNewLinesUtf8(stream.ToArray());
    }

    [TestMethod]
    [DynamicData(nameof(ElmJsonRoundTripTests.ElmFiles), typeof(ElmJsonRoundTripTests))]
    public void ToJsonUtf8_MatchesTheStringAndMemoryStreamRoutes(string relativePath)
    {
        var path = Path.Combine(ElmJsonRoundTripTests.RepositoryRoot.FullName, relativePath);
        var withSource = Library.LoadFromJson(new FileInfo(path));
        var withoutSource = Library.ParseFromJson(File.ReadAllText(path));

        withSource.SourceJsonUtf8.Should().NotBeNull();
        withoutSource.SourceJsonUtf8.Should().BeNull();

        foreach (var writeIndented in new[] { false, true })
        {
            withoutSource.ToJsonUtf8(writeIndented).SequenceEqual(OldSerializedBytes(withoutSource, writeIndented))
                .Should().BeTrue($"ToJsonUtf8({writeIndented}) of {relativePath} without source should not change");
            withSource.ToJsonUtf8(writeIndented).SequenceEqual(OldReformattedBytes(withSource.SourceJsonUtf8!, writeIndented))
                .Should().BeTrue($"ToJsonUtf8({writeIndented}) of {relativePath} with source should not change");
        }
    }

    [TestMethod]
    public void ToJsonUtf8_ExpressionNestedTwoThousandDeep_WritesWithAndWithoutSource()
    {
        Exception? failure = null;
        var thread = new Thread(() =>
        {
            try
            {
                var expressionJson = new StringBuilder();
                for (var i = 0; i < 2000; i++)
                    expressionJson.Append("""{"type":"Not","operand":""");
                expressionJson.Append("""{"type":"Literal","value":"true","valueType":"{urn:hl7-org:elm-types:r1}Boolean"}""");
                expressionJson.Append('}', 2000);
                var json = """{"library":{"identifier":{"id":"T","version":"1"},"statements":{"def":[{"name":"A","context":"Unfiltered","accessLevel":"Public","expression":""" + expressionJson + "}]}}}";

                var withoutSource = Library.ParseFromJson(json);
                var withSource = Library.ParseFromJson(json);
                withSource.SourceJsonUtf8 = Encoding.UTF8.GetBytes(json);

                foreach (var writeIndented in new[] { false, true })
                {
                    var serialized = withoutSource.ToJsonUtf8(writeIndented);
                    serialized.SequenceEqual(OldSerializedBytes(withoutSource, writeIndented)).Should().BeTrue();

                    var reformatted = withSource.ToJsonUtf8(writeIndented);
                    var oldRoute = () => OldReformattedBytes(withSource.SourceJsonUtf8!, writeIndented);
                    oldRoute.Should().Throw<InvalidOperationException>();
                    reformatted.SequenceEqual(OldReformattedBytes(withSource.SourceJsonUtf8!, writeIndented, writerMaxDepth: 4096)).Should().BeTrue();

                    // Both read back to a library of the same depth.
                    Library.ParseFromJson(Encoding.UTF8.GetString(serialized)).Should().NotBeNull();
                    Library.ParseFromJson(Encoding.UTF8.GetString(reformatted)).Should().NotBeNull();
                }
            }
            catch (Exception e) { failure = e; }
        }, DeepStackBytes);
        thread.Start();
        thread.Join();

        failure.Should().BeNull();
    }

    [TestMethod]
    public void ToJsonUtf8_IndentedOutput_UsesLfWhateverThePlatformNewLineIs()
    {
        var path = Path.Combine(ElmJsonRoundTripTests.RepositoryRoot.FullName, "Cql", "CoreTests", "Input", "ELM", "Libs", "FHIRHelpers-4.0.1.json");
        var withSource = Library.LoadFromJson(new FileInfo(path));
        var withoutSource = Library.ParseFromJson(File.ReadAllText(path));

        withSource.ToJsonUtf8(true).Should().NotContain((byte)'\r');
        withoutSource.ToJsonUtf8(true).Should().NotContain((byte)'\r');
    }
}
