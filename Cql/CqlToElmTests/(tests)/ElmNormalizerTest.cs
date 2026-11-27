/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json.Nodes;
using Hl7.Cql.CqlToElm.Test.ElmComparison;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// Each normalization rule on hand-built ELM: two spellings of the same structure normalize to the same JSON, and a
/// difference in structure survives.
/// </summary>
[TestClass]
public class ElmNormalizerTest
{
    private const string Integer = "{urn:hl7-org:elm-types:r1}Integer";
    private const string Decimal = "{urn:hl7-org:elm-types:r1}Decimal";

    [TestMethod]
    public void Locators_Local_Ids_Annotations_And_Signatures_Are_Dropped()
    {
        ShouldNormalizeAlike(
            Statement("""{ "name": "X", "locator": "3:1-3:9", "localId": "4", "annotation": [ { "type": "Annotation" } ], "expression": { "type": "Add", "localId": "3", "signature": [ { "type": "NamedTypeSpecifier", "name": "{urn:hl7-org:elm-types:r1}Integer" } ], "operand": [] } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Add", "operand": [] } }"""));
    }

    [TestMethod]
    public void A_Result_Type_Name_Is_The_Same_As_A_Named_Type_Specifier()
    {
        ShouldNormalizeAlike(
            Statement($$"""{ "name": "X", "expression": { "type": "Literal", "resultTypeName": "{{Integer}}", "value": "1" } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "Literal", "resultTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Integer}}" }, "value": "1" } }"""));
    }

    [TestMethod]
    public void An_As_Type_Is_The_Same_As_An_As_Type_Specifier()
    {
        ShouldNormalizeAlike(
            Statement($$"""{ "name": "X", "expression": { "type": "As", "asType": "{{Integer}}", "operand": { "type": "Null" } } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "As", "asTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Integer}}" }, "operand": { "type": "Null" } } }"""));
    }

    [TestMethod]
    public void A_Different_Result_Type_Survives_Normalization()
    {
        ShouldNormalizeApart(
            Statement($$"""{ "name": "X", "expression": { "type": "Literal", "resultTypeName": "{{Integer}}", "value": "1" } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "Literal", "resultTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Decimal}}" }, "value": "1" } }"""));
    }

    [TestMethod]
    public void Absent_And_Empty_Collections_Are_The_Same()
    {
        ShouldNormalizeAlike(
            """{ "identifier": { "id": "L" }, "includes": { "def": [] }, "statements": { "def": [ { "name": "X", "expression": { "type": "Retrieve", "codeFilter": [], "include": [] } } ] } }""",
            """{ "identifier": { "id": "L" }, "statements": { "def": [ { "name": "X", "expression": { "type": "Retrieve" } } ] } }""");
    }

    [TestMethod]
    public void Schema_Defaults_Are_The_Same_As_Absent_Attributes()
    {
        ShouldNormalizeAlike(
            Statement("""{ "name": "X", "accessLevel": "Public", "expression": { "type": "As", "strict": false, "operand": { "type": "Null" } } }"""),
            Statement("""{ "name": "X", "expression": { "type": "As", "operand": { "type": "Null" } } }"""));
    }

    [TestMethod]
    public void A_Non_Default_Attribute_Survives_Normalization()
    {
        ShouldNormalizeApart(
            Statement("""{ "name": "X", "accessLevel": "Private", "expression": { "type": "Null" } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Null" } }"""));
    }

    [TestMethod]
    public void An_Is_Type_Is_The_Same_As_An_Is_Type_Specifier()
    {
        ShouldNormalizeAlike(
            Statement($$"""{ "name": "X", "expression": { "type": "Is", "isType": "{{Integer}}", "operand": { "type": "Null" } } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "Is", "isTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Integer}}" }, "operand": { "type": "Null" } } }"""));
    }

    [TestMethod]
    public void A_To_Type_Is_The_Same_As_A_To_Type_Specifier()
    {
        ShouldNormalizeAlike(
            Statement($$"""{ "name": "X", "expression": { "type": "Convert", "toType": "{{Decimal}}", "operand": { "type": "Null" } } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "Convert", "toTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Decimal}}" }, "operand": { "type": "Null" } } }"""));
    }

    [TestMethod]
    public void Interval_Closedness_And_Include_Media_Type_Defaults_Are_The_Same_As_Absent()
    {
        ShouldNormalizeAlike(
            """{ "includes": { "def": [ { "localIdentifier": "Y", "path": "Y", "mediaType": "application/elm+xml" } ] }, "statements": { "def": [ { "name": "X", "expression": { "type": "Interval", "lowClosed": true, "highClosed": true, "low": { "type": "Null" } } } ] } }""",
            """{ "includes": { "def": [ { "localIdentifier": "Y", "path": "Y" } ] }, "statements": { "def": [ { "name": "X", "expression": { "type": "Interval", "low": { "type": "Null" } } } ] } }""");
        ShouldNormalizeApart(
            Statement("""{ "name": "X", "expression": { "type": "Interval", "lowClosed": false, "low": { "type": "Null" } } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Interval", "low": { "type": "Null" } } }"""));
    }

    [TestMethod]
    public void The_Distinct_Default_Depends_On_The_Clause()
    {
        // The schema defaults distinct to true on a return clause and to false on an aggregate clause.
        ShouldNormalizeAlike(
            Statement("""{ "name": "X", "expression": { "type": "Query", "return": { "distinct": true, "expression": { "type": "Null" } }, "aggregate": { "distinct": false, "identifier": "A", "expression": { "type": "Null" } } } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Query", "return": { "expression": { "type": "Null" } }, "aggregate": { "identifier": "A", "expression": { "type": "Null" } } } }"""));
        ShouldNormalizeApart(
            Statement("""{ "name": "X", "expression": { "type": "Query", "return": { "distinct": false, "expression": { "type": "Null" } } } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Query", "return": { "expression": { "type": "Null" } } } }"""));
        ShouldNormalizeApart(
            Statement("""{ "name": "X", "expression": { "type": "Query", "aggregate": { "distinct": true, "identifier": "A", "expression": { "type": "Null" } } } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Query", "aggregate": { "identifier": "A", "expression": { "type": "Null" } } } }"""));
    }

    [TestMethod]
    public void A_Result_Type_On_A_Type_Specifier_Is_Dropped()
    {
        ShouldNormalizeAlike(
            Statement($$"""{ "name": "X", "expression": { "type": "As", "asTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Integer}}", "resultTypeName": "{{Integer}}" }, "operand": { "type": "Null" } } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "As", "asTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Integer}}" }, "operand": { "type": "Null" } } }"""));
    }

    [TestMethod]
    public void The_Order_Of_Choice_Types_And_Tuple_Type_Elements_Carries_No_Meaning()
    {
        ShouldNormalizeAlike(
            Statement($$"""{ "name": "X", "expression": { "type": "Null", "resultTypeSpecifier": { "type": "ChoiceTypeSpecifier", "choice": [ { "type": "NamedTypeSpecifier", "name": "{{Integer}}" }, { "type": "NamedTypeSpecifier", "name": "{{Decimal}}" } ] } } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "Null", "resultTypeSpecifier": { "type": "ChoiceTypeSpecifier", "choice": [ { "type": "NamedTypeSpecifier", "name": "{{Decimal}}" }, { "type": "NamedTypeSpecifier", "name": "{{Integer}}" } ] } } }"""));
        ShouldNormalizeAlike(
            Statement($$"""{ "name": "X", "expression": { "type": "Null", "resultTypeSpecifier": { "type": "TupleTypeSpecifier", "element": [ { "name": "b", "elementType": { "type": "NamedTypeSpecifier", "name": "{{Integer}}" } }, { "name": "a", "elementType": { "type": "NamedTypeSpecifier", "name": "{{Decimal}}" } } ] } } }"""),
            Statement($$"""{ "name": "X", "expression": { "type": "Null", "resultTypeSpecifier": { "type": "TupleTypeSpecifier", "element": [ { "name": "a", "elementType": { "type": "NamedTypeSpecifier", "name": "{{Decimal}}" } }, { "name": "b", "elementType": { "type": "NamedTypeSpecifier", "name": "{{Integer}}" } } ] } } }"""));
    }

    [TestMethod]
    public void The_Order_Of_Operands_Is_Kept()
    {
        ShouldNormalizeApart(
            Statement("""{ "name": "X", "expression": { "type": "Subtract", "operand": [ { "type": "Literal", "value": "1" }, { "type": "Literal", "value": "2" } ] } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Subtract", "operand": [ { "type": "Literal", "value": "2" }, { "type": "Literal", "value": "1" } ] } }"""));
    }

    [TestMethod]
    public void A_Property_With_A_Scope_Is_The_Same_As_One_With_An_Alias_Source()
    {
        ShouldNormalizeAlike(
            Statement("""{ "name": "X", "expression": { "type": "Property", "path": "status", "scope": "E" } }"""),
            Statement("""{ "name": "X", "expression": { "type": "Property", "path": "status", "source": { "type": "AliasRef", "name": "E" } } }"""));
    }

    [TestMethod]
    public void An_Expression_Definition_Without_A_Type_Is_An_Expression_Def()
    {
        ShouldNormalizeAlike(
            Statement("""{ "name": "X", "expression": { "type": "Null" } }"""),
            Statement("""{ "type": "ExpressionDef", "name": "X", "expression": { "type": "Null" } }"""));
    }

    [TestMethod]
    public void Definitions_Are_Sorted_By_Their_Key()
    {
        ShouldNormalizeAlike(
            """{ "statements": { "def": [ { "name": "B", "expression": { "type": "Null" } }, { "name": "A", "expression": { "type": "Null" } } ] }, "includes": { "def": [ { "localIdentifier": "Y", "path": "Y" }, { "localIdentifier": "X", "path": "X" } ] } }""",
            """{ "statements": { "def": [ { "name": "A", "expression": { "type": "Null" } }, { "name": "B", "expression": { "type": "Null" } } ] }, "includes": { "def": [ { "localIdentifier": "X", "path": "X" }, { "localIdentifier": "Y", "path": "Y" } ] } }""");
    }

    [TestMethod]
    public void The_Key_Of_A_Function_Includes_Its_Operand_Types()
    {
        var library = ElmNormalizer.NormalizeLibrary((JsonObject)JsonNode.Parse($$"""
            { "statements": { "def": [
                { "type": "FunctionDef", "name": "F", "operand": [ { "name": "x", "operandTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Integer}}", "resultTypeName": "{{Integer}}" } } ] },
                { "type": "FunctionDef", "name": "F", "operand": [ { "name": "x", "operandType": "{{Decimal}}" } ] } ] } }
            """)!);

        var keys = library["statements"]!["def"]!.AsArray().Select(d => ElmNormalizer.DefinitionKey("statements", d)).ToList();
        keys.Should().Equal(
            $$"""F({"name":"{{Decimal}}","type":"NamedTypeSpecifier"})""",
            $$"""F({"name":"{{Integer}}","type":"NamedTypeSpecifier"})""");
    }

    private static string Statement(string definition) => $$"""{ "statements": { "def": [ {{definition}} ] } }""";

    private static JsonObject Normalize(string library) =>
        ElmNormalizer.NormalizeLibraryJson($$"""{ "library": {{library}} }""");

    private static void ShouldNormalizeAlike(string first, string second)
    {
        var a = Normalize(first);
        var b = Normalize(second);
        JsonNode.DeepEquals(a, b).Should().BeTrue($"{a.ToJsonString()} should equal {b.ToJsonString()}");
    }

    private static void ShouldNormalizeApart(string first, string second)
    {
        var a = Normalize(first);
        var b = Normalize(second);
        JsonNode.DeepEquals(a, b).Should().BeFalse($"{a.ToJsonString()} should differ from {b.ToJsonString()}");
    }
}
