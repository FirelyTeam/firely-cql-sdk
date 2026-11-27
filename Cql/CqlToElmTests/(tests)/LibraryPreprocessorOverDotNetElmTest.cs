/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json.Nodes;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.CqlToElm.Test.ElmComparison;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hl7.Cql.CqlToElm.Test;

/// <summary>
/// Runs the ELM preprocessor, whose correctors compensate for the reference translator's ELM, over ELM the .NET
/// translator emits. Each test first shows that the ELM has the shape its corrector looks for, so that it is not
/// vacuous, and then that the corrector leaves the ELM as it is, because the .NET translator already emits what the
/// corrector would make of it.
/// </summary>
[TestClass]
public class LibraryPreprocessorOverDotNetElmTest
{
    private const string Integer = "{urn:hl7-org:elm-types:r1}Integer";
    private const string Decimal = "{urn:hl7-org:elm-types:r1}Decimal";
    private const string String = "{urn:hl7-org:elm-types:r1}String";

    /// <summary>
    /// <see cref="ExpressionRefCorrector"/> fills in a missing <c>signature</c> on a call to a function that is not
    /// overloaded, and a missing result type on an expression or function reference.
    /// </summary>
    [TestMethod]
    public void ExpressionRefCorrector_Leaves_References_That_Carry_Their_Signature_And_Result_Type()
    {
        var (before, after) = Preprocess("""
            library Refs version '1.0.0'

            define function F(x Integer): x + 1
            define X: 1
            define Y: X + F(2)
            """);

        var functionRef = Nodes(before).Single(n => (string?)n["type"] == "FunctionRef");
        functionRef["signature"].Should().BeOfType<JsonArray>().Which.Should().ContainSingle();
        ResultType(functionRef).Should().Be(Integer);
        ResultType(Nodes(before).Single(n => (string?)n["type"] == "ExpressionRef")).Should().Be(Integer);

        ShouldBeUnchanged(before, after);
    }

    /// <summary>
    /// <see cref="MissingResultTypeSpecifierCorrector"/> fills in the result types of return clauses and tuples, and
    /// turns a result type given only by name into a type specifier.
    /// </summary>
    [TestMethod]
    public void MissingResultTypeSpecifierCorrector_Leaves_Return_Clauses_And_Tuples_That_Carry_Their_Types()
    {
        var (before, after) = Preprocess("""
            library Queries version '1.0.0'

            define T: ({1, 2, 3}) N return Tuple { n: N }
            define M: from ({1}) A, ({2}) B return Tuple { a: A, b: B }
            define L: ({1, 2}) N where N > 1
            """);

        var returnClauses = Nodes(before).Where(n => n["return"] is JsonObject).Select(n => n["return"]!.AsObject()).ToList();
        returnClauses.Should().HaveCount(2).And.OnlyContain(r => r["resultTypeSpecifier"] != null);
        Nodes(before).Where(n => (string?)n["type"] == "Tuple").Should().HaveCount(2).And.OnlyContain(t => t["resultTypeSpecifier"] != null);
        Nodes(before).Where(n => n["resultTypeName"] != null).Should().OnlyContain(n => n["resultTypeSpecifier"] != null);

        ShouldBeUnchanged(before, after);
    }

    /// <summary>
    /// <see cref="PowerResultTypeCorrector"/> declares every <c>Power</c> as <c>Decimal</c>, which is what the runtime
    /// computes. Whatever the translator declares, after preprocessing the declared type matches the runtime. Which type
    /// the translator itself should declare for Integer and Long operands is not asserted here: the specification says
    /// Integer and Long, the runtime returns Decimal, and #1757 tracks aligning them.
    /// </summary>
    [TestMethod]
    public void PowerResultTypeCorrector_Declares_Power_As_The_Runtime_Computes_It()
    {
        var (before, after) = Preprocess("""
            library Pow version '1.0.0'

            define I: 2 ^ 3
            define L: 2L ^ 3L
            define D: 2.0 ^ 3.0
            """);

        Nodes(before).Where(n => (string?)n["type"] == "Power").Should().HaveCount(3);
        Nodes(after).Where(n => (string?)n["type"] == "Power").Select(ResultType).Should().Equal(Decimal, Decimal, Decimal);
    }

    /// <summary>
    /// The control for the tests above: the preprocessor does run over the ELM these tests give it, and changes what
    /// a corrector targets.
    /// </summary>
    [TestMethod]
    public void The_Preprocessor_Changes_What_A_Corrector_Targets()
    {
        var (before, after) = Preprocess("""
            library Pow version '1.0.0'

            define I: 2 ^ 3
            """, mutate: library =>
        {
            var power = Nodes(library).Single(n => (string?)n["type"] == "Power");
            power["resultTypeName"] = Integer;
            power["resultTypeSpecifier"] = new JsonObject { ["type"] = "NamedTypeSpecifier", ["name"] = Integer };
        });

        ResultType(Nodes(before).Single(n => (string?)n["type"] == "Power")).Should().Be(Integer);
        ResultType(Nodes(after).Single(n => (string?)n["type"] == "Power")).Should().Be(Decimal);
    }

    /// <summary>
    /// <see cref="ProfiledValueSetPropertyCorrector"/> types the <c>value</c> of a <c>periodUnit</c> as <c>String</c>
    /// and the <c>periodUnit</c> itself as <c>FHIR.UnitsOfTime</c>.
    /// </summary>
    [TestMethod]
    public void ProfiledValueSetPropertyCorrector_Leaves_A_Period_Unit_Value_That_Has_Those_Types()
    {
        var (before, after) = Preprocess("""
            library PeriodUnit version '1.0.0'

            using FHIR version '4.0.1'

            include FHIRHelpers version '4.0.1'

            context Patient

            define U: [MedicationRequest] M return M.dosageInstruction[0].timing.repeat.periodUnit.value
            """, fhir: true);

        var value = Nodes(before).Single(n => (string?)n["type"] == "Property" && (string?)n["path"] == "value" && (string?)n["source"]?["path"] == "periodUnit");
        ResultType(value).Should().Be(String);
        ResultType(value["source"]!.AsObject()).Should().Be("{http://hl7.org/fhir}UnitsOfTime");

        ShouldBeUnchanged(before, after);
    }

    /// <summary>
    /// Under QICore the shape <see cref="ProfiledValueSetPropertyCorrector"/> targets does not arise from the .NET
    /// translator: <c>QICore.UnitsOfTime</c> has no <c>value</c>, and the expression is reported, as the reference
    /// translator reports it.
    /// </summary>
    [TestMethod]
    public void A_Period_Unit_Value_Is_Rejected_Under_QICore_As_By_The_Reference_Translator()
    {
        var toolkit = new CqlToolkit(config: CqlToolkitConfig.Default with { Models = CqlToolkitConfig.DefaultCqlModels.Union([CqlModel.QICore600, CqlModel.USCore610]) })
                      .AddFHIRHelpers();
        toolkit.MakeLibrary("""
            library PeriodUnit version '1.0.0'

            using QICore version '6.0.0'

            include FHIRHelpers version '4.0.1'

            context Patient

            define U: [MedicationRequest] M return M.dosageInstruction[0].timing.repeat.periodUnit.value
            """,
            "Member 'value' not found for type {http://hl7.org/fhir/us/qicore}UnitsOfTime.");
    }

    /// <summary>
    /// Asserts the JSON is exactly the same, so that even an empty collection a corrector adds counts as a change.
    /// </summary>
    private static void ShouldBeUnchanged(JsonNode before, JsonNode after) =>
        JsonNode.DeepEquals(before, after).Should().BeTrue(
            $"the preprocessor should leave the .NET translator's ELM as it is; first difference: {ElmOutputCheckers.FirstDifference(before, after, "$")}");

    private static string? ResultType(JsonObject node) => (string?)node["resultTypeSpecifier"]?["name"];

    /// <summary>
    /// Translates the library with the reference configuration, reads its ELM and that of the libraries it includes
    /// back from JSON, as a consumer of the JSON gets it, and returns its JSON before and after preprocessing.
    /// <paramref name="mutate"/>, if given, changes the library's JSON before it is read back.
    /// </summary>
    private static (JsonNode Before, JsonNode After) Preprocess(string cql, bool fhir = false, Action<JsonNode>? mutate = null)
    {
        var toolkit = new CqlToolkit(config: CqlToolkitConfig.Default);
        if (fhir)
            toolkit.AddFHIRHelpers();
        var library = toolkit.MakeLibrary(cql);

        string Json(Library translated)
        {
            var json = translated.SerializeToJson(writeIndented: false);
            if (mutate is null || translated.VersionedLibraryIdentifier != library.VersionedLibraryIdentifier)
                return json;
            var node = JsonNode.Parse(json, documentOptions: ElmNormalizer.DocumentOptions)!;
            mutate(node);
            return node.ToJsonString();
        }

        var libraries = toolkit.TranslateToElm().ArtifactsById.Values
                               .Select(artifacts => Library.ParseFromJson(Json(artifacts.ResultElmLibrary!)))
                               .ToArray();
        var reread = libraries.Single(l => l.VersionedLibraryIdentifier == library.VersionedLibraryIdentifier);
        var before = JsonNode.Parse(reread.SerializeToJson(writeIndented: false), documentOptions: ElmNormalizer.DocumentOptions)!;

        new LibraryPreprocessor(new LibrarySet("", libraries), NullLoggerFactory.Instance).PreprocessLibrary(reread);

        var after = JsonNode.Parse(reread.SerializeToJson(writeIndented: false), documentOptions: ElmNormalizer.DocumentOptions)!;
        return (before, after);
    }

    private static IEnumerable<JsonObject> Nodes(JsonNode? node)
    {
        switch (node)
        {
            case JsonObject o:
                yield return o;
                foreach (var child in o.SelectMany(p => Nodes(p.Value)))
                    yield return child;
                break;
            case JsonArray a:
                foreach (var child in a.SelectMany(Nodes))
                    yield return child;
                break;
        }
    }
}
