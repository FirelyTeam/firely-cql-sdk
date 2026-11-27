/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json.Nodes;
using Hl7.Cql.CqlToElm.Test.ElmComparison;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// The independent checkers accept ELM this translator emits and reject ELM that is not valid, so that a passing
/// census row means something.
/// </summary>
[TestClass]
public class ElmOutputCheckersTest : Base
{
    private static readonly Lazy<ElmOutputCheckers> Checkers = new(() =>
    {
        var repositoryRoot = new DirectoryInfo(AppContext.BaseDirectory).FindParentDirectoryContaining("Cql-Sdk.slnf")
                             ?? throw new InvalidOperationException("Could not find the repository root.");
        return new ElmOutputCheckers(Path.Combine(repositoryRoot.FullName, "Cql", "Elm", "Schema"));
    });

    [TestMethod]
    public void Emitted_Elm_Reads_Back_As_Written_And_Is_Valid_Against_The_Schema()
    {
        var library = CreateCqlToolkit().MakeLibraryFromExpression("if 1 < 2 then { 1, 2 } else null");

        Checkers.Value.Check(library.SerializeToJson(writeIndented: false)).Should().BeEmpty();
    }

    [TestMethod]
    public void An_Element_The_Schema_Does_Not_Allow_Is_Reported()
    {
        var xml = SerializeToXml(ValidLibrary()).Replace("<statements>", "<statements><unknown />", StringComparison.Ordinal);

        Checkers.Value.ValidateXml(xml).Should().ContainSingle().Which.Should().Contain("unknown");
    }

    [TestMethod]
    public void A_Missing_Required_Attribute_Is_Reported()
    {
        var library = ValidLibrary();
        library.codeSystems = [new CodeSystemDef { id = "http://loinc.org" }];

        Checkers.Value.ValidateAgainstSchema(library).Should().ContainSingle().Which.Should().Contain("'name'");
    }

    [TestMethod]
    public void A_Valid_Library_Has_No_Schema_Findings()
    {
        Checkers.Value.ValidateAgainstSchema(ValidLibrary()).Should().BeEmpty();
    }

    [TestMethod]
    public void Json_That_The_Reader_Rejects_Is_Reported()
    {
        Checkers.Value.Check("""{ "library": { "statements": { "def": [ { "name": "X", "expression": { "type": "NoSuchNode" } } ] } } }""")
                .Should().ContainSingle().Which.Should().StartWith("reader:");
    }

    [TestMethod]
    public void An_Absent_And_An_Empty_Collection_Read_Back_Alike()
    {
        ElmOutputCheckers.FirstDifference(JsonNode.Parse("""{ "a": 1 }"""), JsonNode.Parse("""{ "a": 1, "b": { "def": [] }, "c": [] }"""), "$")
                         .Should().BeNull();
    }

    [TestMethod]
    public void A_Value_That_Does_Not_Read_Back_Is_Reported()
    {
        ElmOutputCheckers.FirstDifference(JsonNode.Parse("""{ "a": { "b": [ 1, 2 ] } }"""), JsonNode.Parse("""{ "a": { "b": [ 1, 3 ] } }"""), "$")
                         .Should().Be("$.a.b[1]: 2 written, 3 read back");
    }

    private static Library ValidLibrary() =>
        new()
        {
            identifier = new VersionedIdentifier { id = "L", version = "1.0.0" },
            schemaIdentifier = new VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
            statements = [new ExpressionDef { name = "X", expression = new Null() }],
        };

    private static string SerializeToXml(Library library)
    {
        using var writer = new StringWriter(CultureInfo.InvariantCulture);
        new XmlSerializer(typeof(Library)).Serialize(writer, library);
        return writer.ToString();
    }
}
