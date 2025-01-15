using System.Collections.Generic;
using FluentAssertions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class ValueSetExpressionTests

{
    private Dictionary<string, object> _parameters;
    private CqlContext ctx;
    private static IValueSetDictionary _valueSets = null!;



    [TestInitialize]
    public void TestInitialize()
    {
        _parameters = new();
        ctx = FhirCqlContext.ForBundle(
            valueSets: _valueSets,
            parameters: _parameters);
    }

    [TestMethod]
    public void ChoseCodeIsA1A_And_SubCategory1_ResultShouldBeA()
    {
        var lib = ValueSetExprExample_1_0_0.Instance;
        lib.ChosenSubCategory(ctx).Should().Be("1");
        lib.ChosenCode(ctx)?.code.Should().Be("A-1-A");
        lib.ValueSetA(ctx)?.id.Should().Be(ValueSetIdFor("A", "1"));
        lib.ValueSetB(ctx)?.id.Should().Be(ValueSetIdFor("B", "1"));
        lib.Result(ctx).Should().Be("a");
    }

    [TestMethod]
    public void ChosenCodeIsA1C_And_SubCategory1_ResultShouldBeNull()
    {
        _parameters["ChosenCode"] = new CqlCode { code = "A-1-C" }; ;

        var lib = ValueSetExprExample_1_0_0.Instance;
        lib.ChosenSubCategory(ctx).Should().Be("1");
        lib.ChosenCode(ctx)?.code.Should().Be("A-1-C");
        lib.ValueSetA(ctx)?.id.Should().Be(ValueSetIdFor("A", "1"));
        lib.ValueSetB(ctx)?.id.Should().Be(ValueSetIdFor("B", "1"));
        lib.Result(ctx).Should().BeNull();
    }

    [TestMethod]
    public void ChosenCodeIsB2A_And_SubCategory2_ResultShouldBeB()
    {
        _parameters["ChosenSubCategory"] = "2";
        _parameters["ChosenCode"] = new CqlCode { code = "B-2-A" }; ;

        var lib = ValueSetExprExample_1_0_0.Instance;
        lib.ChosenSubCategory(ctx).Should().Be("2");
        lib.ChosenCode(ctx)?.code.Should().Be("B-2-A");
        lib.ValueSetA(ctx)?.id.Should().Be(ValueSetIdFor("A", "2"));
        lib.ValueSetB(ctx)?.id.Should().Be(ValueSetIdFor("B", "2"));
        lib.Result(ctx).Should().Be("b");
    }

    [ClassInitialize]
    public static void ClassInitialize(TestContext _)
    {
        _valueSets = new[]
        {
            ValueSet("A", "1"),
            ValueSet("A", "2"),
            ValueSet("B", "1"),
            ValueSet("B", "2"),
        }.ToValueSetDictionary();
    }

    private static ValueSet ValueSet(string category, string subCategory) =>
        new()
        {
            Id = ValueSetIdFor(category, subCategory),
            Url = ValueSetIdFor(category, subCategory),
            Expansion = new ValueSet.ExpansionComponent
            {
                Contains =
                [
                    new()
                    {
                        Code = $"{category}-{subCategory}-A",
                        System = "http://fire.ly/CodeSystem/Test"
                    },
                    new()
                    {
                        Code = $"{category}-{subCategory}-B",
                        System = "http://fire.ly/CodeSystem/Test"
                    },
                ]
            }
        };

    private static string ValueSetIdFor(string category, string subCategory) =>
        $"http://fire.ly/ValueSet/ValueSet-{category}-{subCategory}";

}