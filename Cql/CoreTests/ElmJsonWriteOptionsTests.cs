/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.Loader;
using System.Threading;
using Hl7.Cql.Elm;
using Hl7.Cql.Elm.Serialization;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

/// <summary>
/// The ELM writer has one set of serializer options and sets the indentation on the <see cref="Utf8JsonWriter"/>.
/// These tests hold its output to what a second, indented set of options wrote.
/// </summary>
[TestClass]
public class ElmJsonWriteOptionsTests
{
    private const int DeepStackBytes = 64 * 1024 * 1024;

    private static string ReadFile(string relativePath) =>
        File.ReadAllText(Path.Combine(ElmJsonRoundTripTests.RepositoryRoot.FullName, relativePath));

    // The configuration that this change removed: a second option instance that asks for indentation itself.
    private static JsonSerializerOptions OptionsWithWriteIndented(bool writeIndented)
    {
        var options = new JsonSerializerOptions(LibraryJsonSerializer.BuildSerializerOptions(allowOldStyleTypeDiscriminators: false))
        {
            WriteIndented = writeIndented,
        };
        return options;
    }

    private static string SerializeWithOptions(Library library, bool writeIndented) =>
        JsonSerializer.Serialize(new LibraryContainer(library), OptionsWithWriteIndented(writeIndented));

    private static byte[] WriteJsonBytes(Library library, bool writeIndented)
    {
        using var stream = new MemoryStream();
        library.WriteJson(stream, writeIndented);
        return stream.ToArray();
    }

    [TestMethod]
    [DynamicData(nameof(ElmJsonRoundTripTests.ElmFiles), typeof(ElmJsonRoundTripTests))]
    public void SerializeToJsonAndWriteJson_MatchTheWriteIndentedOptions(string relativePath)
    {
        var library = Library.ParseFromJson(ReadFile(relativePath));

        foreach (var writeIndented in new[] { false, true })
        {
            var expected = SerializeWithOptions(library, writeIndented);

            (library.SerializeToJson(writeIndented) == expected)
                .Should().BeTrue($"SerializeToJson({writeIndented}) of {relativePath} should not change");
            Encoding.UTF8.GetBytes(expected).SequenceEqual(WriteJsonBytes(library, writeIndented))
                .Should().BeTrue($"WriteJson({writeIndented}) of {relativePath} should not change");
        }
    }

    [TestMethod]
    public void SerializeToJsonAndWriteJson_ExpressionNestedTwoThousandDeep_MatchTheWriteIndentedOptions()
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
                var library = Library.ParseFromJson(json);

                foreach (var writeIndented in new[] { false, true })
                {
                    var expected = SerializeWithOptions(library, writeIndented);
                    (library.SerializeToJson(writeIndented) == expected).Should().BeTrue();
                    Encoding.UTF8.GetBytes(expected).SequenceEqual(WriteJsonBytes(library, writeIndented)).Should().BeTrue();
                }
            }
            catch (Exception e) { failure = e; }
        }, DeepStackBytes);
        thread.Start();
        thread.Join();

        failure.Should().BeNull();
    }

    // The serializer's metadata is built once per options instance and is most of what a first write allocates. A
    // second instance for indented output would charge it twice, so a process that writes both formats has to
    // allocate it once. Elm is loaded into a context of its own so that its static options are fresh.
    [TestMethod]
    public void FreshProcess_WritesCompactThenIndented_BuildsTheWriteMetadataOnce()
    {
        var path = Path.Combine("Input", "ELM", "Libs", "FHIRHelpers-4.0.1.json");
        var context = new FreshElmContext();
        try
        {
            var elm = context.LoadFromAssemblyPath(typeof(Library).Assembly.Location);
            var libraryType = elm.GetType(typeof(Library).FullName!)!;
            var parse = libraryType.GetMethod(nameof(Library.ParseFromJson), [typeof(string), typeof(bool)])!;
            var serialize = libraryType.GetMethod(nameof(Library.SerializeToJson))!;
            var toJsonUtf8 = libraryType.GetMethod("ToJsonUtf8", BindingFlags.Instance | BindingFlags.NonPublic)!;

            var library = parse.Invoke(null, [File.ReadAllText(path), true])!;

            var compact = Allocated(() => serialize.Invoke(library, [false]));
            var indented = Allocated(() => serialize.Invoke(library, [true]));
            var indentedUtf8 = Allocated(() => toJsonUtf8.Invoke(library, [true]));

            indented.Should().BeLessThan(compact / 10);
            indentedUtf8.Should().BeLessThan(compact / 10);
        }
        finally
        {
            context.Unload();
        }
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void WriteJson_WhenSerializationThrows_WritesNothingToTheStream(bool writeIndented)
    {
        var library = Library.ParseFromJson(ReadFile("Cql/CoreTests/Input/ELM/HL7/FHIRHelpers-4.0.1.json"));
        Expression expression = new Literal { value = "true", valueType = new System.Xml.XmlQualifiedName("Boolean", "urn:hl7-org:elm-types:r1") };
        for (var i = 0; i < 5000; i++)
            expression = new Not { operand = expression };
        library.statements[0].expression = expression;

        var stream = new MemoryStream();
        Exception? failure = null;
        var thread = new Thread(() =>
        {
            try { library.WriteJson(stream, writeIndented); }
            catch (Exception e) { failure = e; }
        }, DeepStackBytes);
        thread.Start();
        thread.Join();

        failure.Should().NotBeNull();
        stream.Length.Should().Be(0);
    }

    private static long Allocated(Action action)
    {
        var before = GC.GetAllocatedBytesForCurrentThread();
        action();
        return GC.GetAllocatedBytesForCurrentThread() - before;
    }

    private sealed class FreshElmContext() : AssemblyLoadContext(isCollectible: true)
    {
        protected override Assembly? Load(AssemblyName assemblyName) => null;
    }
}
