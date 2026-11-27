/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Test.ElmComparison;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// Each kind of divergence on hand-built ELM pairs, and the rules that keep one difference from being counted more
/// than once.
/// </summary>
[TestClass]
public class ElmStructuralDiffTest
{
    private const string Integer = "{urn:hl7-org:elm-types:r1}Integer";
    private const string Decimal = "{urn:hl7-org:elm-types:r1}Decimal";

    private const string One = """{ "type": "Literal", "valueType": "{urn:hl7-org:elm-types:r1}Integer", "value": "1" }""";
    private const string Two = """{ "type": "Literal", "valueType": "{urn:hl7-org:elm-types:r1}Integer", "value": "2" }""";

    [TestMethod]
    public void Identical_Libraries_Have_No_Divergences()
    {
        Compare(Expression(One), Expression(One)).Should().BeEmpty();
    }

    [TestMethod]
    public void Libraries_That_Differ_Only_In_Spelling_Have_No_Divergences()
    {
        Compare(
                Expression($$"""{ "type": "Literal", "localId": "1", "locator": "1:1", "resultTypeName": "{{Integer}}", "valueType": "{{Integer}}", "value": "1" }"""),
                Expression($$"""{ "type": "Literal", "resultTypeSpecifier": { "type": "NamedTypeSpecifier", "name": "{{Integer}}" }, "valueType": "{{Integer}}", "value": "1" }"""))
            .Should().BeEmpty();
    }

    [TestMethod]
    public void A_Conversion_On_This_Side_Only_Is_Reported_Once_And_Its_Operand_Compared()
    {
        var divergences = Compare(
            Expression($$"""{ "type": "ToDecimal", "operand": {{Two}} }"""),
            Expression(One));

        divergences.Select(d => d.Kind).Should().Equal(DivergenceKind.ConversionPlacement, DivergenceKind.ValueDifference);
        divergences[0].Detail.Should().Be("ToDecimal vs none");
        divergences[1].Path.Should().Be("statements[X].expression.value");
    }

    [TestMethod]
    public void A_Conversion_On_The_Reference_Side_Only_Is_Reported()
    {
        var divergences = Compare(
            Expression(One),
            Expression($$"""{ "type": "As", "asType": "{{Decimal}}", "operand": {{One}} }"""));

        divergences.Should().ContainSingle().Which.Should().Be(
            new Divergence(DivergenceKind.ConversionPlacement, "statements[X].expression", "none vs As"));
    }

    [TestMethod]
    public void Two_Different_Conversions_Of_The_Same_Operand_Are_One_Conversion_Divergence()
    {
        Compare(
                Expression($$"""{ "type": "As", "asType": "{{Decimal}}", "operand": {{One}} }"""),
                Expression($$"""{ "type": "ToDecimal", "operand": {{One}} }"""))
            .Should().ContainSingle().Which.Kind.Should().Be(DivergenceKind.ConversionPlacement);
    }

    [TestMethod]
    public void A_Model_Conversion_Function_Counts_As_A_Conversion()
    {
        Compare(
                Expression($$"""{ "type": "FunctionRef", "libraryName": "FHIRHelpers", "name": "ToDecimal", "operand": [ {{One}} ] }"""),
                Expression(One))
            .Should().ContainSingle().Which.Kind.Should().Be(DivergenceKind.ConversionPlacement);
    }

    [TestMethod]
    public void Another_Function_Does_Not_Count_As_A_Conversion()
    {
        Compare(
                Expression($$"""{ "type": "FunctionRef", "libraryName": "Common", "name": "ToDecimal", "operand": [ {{One}} ] }"""),
                Expression(One))
            .Should().ContainSingle().Which.Kind.Should().Be(DivergenceKind.ReplacedNode);
    }

    [TestMethod]
    public void A_Replaced_Node_Is_Reported_Once_Without_Comparing_What_Is_Below_It()
    {
        Compare(
                Expression($$"""{ "type": "Add", "operand": [ {{One}}, {{One}} ] }"""),
                Expression($$"""{ "type": "Multiply", "operand": [ {{Two}}, {{Two}} ] }"""))
            .Should().ContainSingle().Which.Should().Be(
                new Divergence(DivergenceKind.ReplacedNode, "statements[X].expression", "Add vs Multiply"));
    }

    [TestMethod]
    public void A_Missing_And_An_Extra_Definition_Are_Reported_By_Name()
    {
        var divergences = Compare(
            """{ "statements": { "def": [ { "name": "A", "expression": { "type": "Null" } } ] } }""",
            """{ "statements": { "def": [ { "name": "B", "expression": { "type": "Null" } } ] } }""");

        divergences.Should().Equal(
            new Divergence(DivergenceKind.ExtraNode, "statements[A]", "ExpressionDef A vs absent"),
            new Divergence(DivergenceKind.MissingNode, "statements[B]", "absent vs ExpressionDef B"));
    }

    [TestMethod]
    public void Definitions_Are_Matched_By_Name_Not_Position()
    {
        Compare(
                """{ "statements": { "def": [ { "name": "A", "expression": { "type": "Null" } }, { "name": "B", "expression": { "type": "Null" } } ] } }""",
                """{ "statements": { "def": [ { "name": "B", "expression": { "type": "Null" } }, { "name": "A", "expression": { "type": "Null" } } ] } }""")
            .Should().BeEmpty();
    }

    [TestMethod]
    public void A_Missing_Or_Extra_Operand_Is_Reported()
    {
        Compare(
                Expression($$"""{ "type": "Concatenate", "operand": [ {{One}} ] }"""),
                Expression($$"""{ "type": "Concatenate", "operand": [ {{One}}, {{Two}} ] }"""))
            .Should().ContainSingle().Which.Should().Be(
                new Divergence(DivergenceKind.MissingNode, "statements[X].expression.operand[1]", "absent vs Literal"));
        Compare(
                Expression($$"""{ "type": "Concatenate", "operand": [ {{One}}, {{Two}} ] }"""),
                Expression($$"""{ "type": "Concatenate", "operand": [ {{One}} ] }"""))
            .Should().ContainSingle().Which.Kind.Should().Be(DivergenceKind.ExtraNode);
    }

    [TestMethod]
    public void A_Different_Type_Is_A_Type_Difference()
    {
        Compare(
                Expression($$"""{ "type": "Null", "resultTypeName": "{{Integer}}" }"""),
                Expression($$"""{ "type": "Null", "resultTypeName": "{{Decimal}}" }"""))
            .Should().ContainSingle().Which.Should().Be(
                new Divergence(DivergenceKind.TypeDifference, "statements[X].expression.resultTypeSpecifier", "Integer vs Decimal"));
    }

    [TestMethod]
    public void Types_Of_The_Same_Name_In_Different_Models_Are_Told_Apart()
    {
        Compare(
                Expression("""{ "type": "Null", "resultTypeName": "{http://hl7.org/fhir}Encounter" }"""),
                Expression("""{ "type": "Null", "resultTypeName": "{http://hl7.org/fhir/us/qicore}Encounter" }"""))
            .Should().ContainSingle().Which.Detail.Should().Be("fhir.Encounter vs qicore.Encounter");
    }

    [TestMethod]
    public void A_Result_Type_On_One_Side_Only_Is_Not_A_Divergence()
    {
        Compare(
                Expression($$"""{ "type": "Null", "resultTypeName": "{{Integer}}" }"""),
                Expression("""{ "type": "Null" }"""))
            .Should().BeEmpty();
    }

    [TestMethod]
    public void A_Converted_Type_On_One_Side_Only_Is_A_Type_Difference()
    {
        Compare(
                Expression("""{ "type": "As", "operand": { "type": "Null" } }"""),
                Expression($$"""{ "type": "As", "asType": "{{Decimal}}", "operand": { "type": "Null" } }"""))
            .Should().ContainSingle().Which.Should().Be(
                new Divergence(DivergenceKind.TypeDifference, "statements[X].expression.asTypeSpecifier", "absent vs Decimal"));
    }

    [TestMethod]
    public void A_Different_Literal_Type_Is_A_Type_Difference()
    {
        Compare(
                Expression($$"""{ "type": "Literal", "valueType": "{{Integer}}", "value": "1" }"""),
                Expression($$"""{ "type": "Literal", "valueType": "{{Decimal}}", "value": "1" }"""))
            .Should().ContainSingle().Which.Should().Be(
                new Divergence(DivergenceKind.TypeDifference, "statements[X].expression.valueType", "Integer vs Decimal"));
    }

    [TestMethod]
    public void A_List_On_One_Side_Only_Is_A_Missing_Or_Extra_Node()
    {
        Compare(
                Expression("""{ "type": "Tuple" }"""),
                Expression($$"""{ "type": "Tuple", "element": [ { "name": "a", "value": {{One}} } ] }"""))
            .Should().ContainSingle().Which.Should().Be(
                new Divergence(DivergenceKind.MissingNode, "statements[X].expression.element", "absent vs array of 1"));
        Compare(
                Expression($$"""{ "type": "Tuple", "element": [ { "name": "a", "value": {{One}} } ] }"""),
                Expression("""{ "type": "Tuple" }"""))
            .Should().ContainSingle().Which.Kind.Should().Be(DivergenceKind.ExtraNode);
    }

    [TestMethod]
    public void A_Different_Attribute_Is_A_Value_Difference()
    {
        Compare(
                Expression("""{ "type": "Property", "path": "birthDate", "source": { "type": "AliasRef", "name": "P" } }"""),
                Expression("""{ "type": "Property", "path": "birthDate.value", "scope": "P" }"""))
            .Should().ContainSingle().Which.Should().Be(
                new Divergence(DivergenceKind.ValueDifference, "statements[X].expression.path", "\"birthDate\" vs \"birthDate.value\""));
    }

    private static string Expression(string expression) =>
        $$"""{ "statements": { "def": [ { "name": "X", "expression": {{expression}} } ] } }""";

    private static List<Divergence> Compare(string actual, string reference) =>
        ElmStructuralDiff.Compare(
            ElmNormalizer.NormalizeLibraryJson($$"""{ "library": {{actual}} }"""),
            ElmNormalizer.NormalizeLibraryJson($$"""{ "library": {{reference}} }""")).ToList();
}
