/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Xml;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// The branches of <c>if</c> and <c>case</c>, and the elements of a list selector, are unified to one type the
    /// way the reference translator does it: an implicit conversion where one exists, otherwise a choice (or, for a
    /// list selector, <c>Any</c>).
    /// </summary>
    [TestClass]
    public class BranchUnificationTest : Base
    {
        private static NamedTypeSpecifier Fhir(string name) => new XmlQualifiedName($"{{http://hl7.org/fhir}}{name}").ToNamedType();

        private static Library FhirLibrary(string body) =>
            CreateCqlToolkit(AmbiguousTypeBehavior: AmbiguousTypeBehavior.PreferModel)
                .AddFHIRHelpers()
                .MakeLibrary($"""
                    library BranchUnification version '1.0.0'
                    using FHIR version '4.0.1'
                    include FHIRHelpers version '4.0.1'
                    context Patient
                    {body}
                    """);

        [TestMethod]
        public void Case_IntervalDateTime_And_IntervalDate_IsIntervalDateTime()
        {
            var @case = CreateCqlToolkit().MakeLibraryFromExpression("""
                case
                    when true then Interval[@2020-01-01T00:00:00.000, @2020-01-02T00:00:00.000]
                    when false then Interval[@2020-01-01, @2020-01-02]
                    else null
                end
                """).Should().BeACorrectlyInitializedLibraryWithStatementOfType<Case>();

            var expected = SystemTypes.DateTimeType.ToIntervalType();
            @case.resultTypeSpecifier.Should().Be(expected);
            @case.caseItem[0].then.resultTypeSpecifier.Should().Be(expected);
            @case.caseItem[1].then.resultTypeSpecifier.Should().Be(expected, "the Interval<Date> branch is converted through its point type");
            @case.@else.resultTypeSpecifier.Should().Be(expected);
        }

        [TestMethod]
        public void If_Integer_And_Decimal_IsDecimal()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then 1 else 2.5")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType);
            @if.then.Should().BeOfType<ToDecimal>();
            AssertResult(@if, 1.0m);
        }

        [TestMethod]
        public void If_Integer_And_Long_IsLong()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then 1 else 2L")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.LongType);
            @if.then.Should().BeOfType<ToLong>();
            AssertResult(@if, 1L);
        }

        [TestMethod]
        public void If_Date_And_DateTime_IsDateTime()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then @2020-01-01 else @2020-01-01T00:00:00.000")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.DateTimeType);
            @if.then.Should().BeOfType<ToDateTime>();
        }

        [TestMethod]
        public void If_Code_And_Concept_IsConcept()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression(
                "if true then Code { code: 'a', system: 'urn:x' } else Concept { codes: { Code { code: 'a', system: 'urn:x' } } }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.ConceptType);
            @if.then.Should().BeOfType<ToConcept>();
        }

        [TestMethod]
        public void If_Null_And_Integer_IsInteger()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then null else 1")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
            @if.then.Should().BeOfType<As>().Which.operand.Should().BeOfType<Null>();
            AssertNullResult(@if);
        }

        [TestMethod]
        public void If_BothNull_IsAny()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then null else null")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
        }

        [TestMethod]
        public void Case_AllBranchesNull_IsAny()
        {
            var @case = CreateCqlToolkit().MakeLibraryFromExpression("case when true then null else null end")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<Case>();
            @case.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
        }

        [TestMethod]
        public void If_ListInteger_And_ListDecimal_IsListDecimal()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then {1, 2} else {1.5}")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType.ToListType());
            @if.then.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType.ToListType(), "the List<Integer> branch is converted through its element type");
        }

        [TestMethod]
        public void If_UnrelatedLists_IsChoiceOfLists()
        {
            var library = FhirLibrary("""define "X": if true then [Condition] else [Procedure]""");
            var @if = library.ShouldDefine<ExpressionDef>("X").expression.Should().BeOfType<If>().Subject;
            var choice = @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>().Subject;
            choice.choice.Should().BeEquivalentTo(
                new TypeSpecifier[] { Fhir("Condition").ToListType(), Fhir("Procedure").ToListType() },
                "lists of unrelated element types form a choice of lists, not a list of a choice");
            @if.then.Should().BeOfType<As>();
            @if.@else.Should().BeOfType<As>();
        }

        [TestMethod]
        public void If_TuplesWithDifferentElementTypes_IsChoice()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then Tuple { a: 1 } else Tuple { a: 2.5 }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>()
                .Which.choice.Should().HaveCount(2, "tuple types are not converted into each other");
        }

        [TestMethod]
        public void Case_Integer_Decimal_Long_IsDecimal()
        {
            var @case = CreateCqlToolkit().MakeLibraryFromExpression("case when true then 1 when false then 2.5 else 3L end")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<Case>();
            @case.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType);
            @case.caseItem[0].then.Should().BeOfType<ToDecimal>();
            @case.caseItem[1].then.Should().BeOfType<Literal>();
            @case.@else.Should().BeOfType<ToDecimal>();
            AssertResult(@case, 1.0m);
        }

        [TestMethod]
        public void If_Choice_And_Alternative_KeepsTheChoice()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then (if true then 1 else 'a') else 2")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>()
                .Which.choice.Should().BeEquivalentTo(new TypeSpecifier[] { SystemTypes.IntegerType, SystemTypes.StringType });
            @if.then.Should().BeOfType<If>("the branch that already has the choice type is not wrapped");
            @if.@else.Should().BeOfType<As>();
        }

        [TestMethod]
        public void If_Choice_And_OtherType_WidensTheChoice()
        {
            var @if = CreateCqlToolkit().MakeLibraryFromExpression("if true then (if true then 1 else 'a') else 2.5")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>()
                .Which.choice.Should().BeEquivalentTo(
                    new TypeSpecifier[] { SystemTypes.IntegerType, SystemTypes.StringType, SystemTypes.DecimalType },
                    "no conversion is attempted when a branch is a choice, so the choice widens");
        }

        [TestMethod]
        public void If_Interval_And_Point_WithoutIntervalPromotionOrDemotion_IsChoice()
        {
            var @if = CreateCqlToolkit(EnableIntervalPromotion: false, EnableIntervalDemotion: false)
                .MakeLibraryFromExpression("if true then Interval[1, 2] else 3")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>()
                .Which.choice.Should().BeEquivalentTo(new TypeSpecifier[] { SystemTypes.IntegerType.ToIntervalType(), SystemTypes.IntegerType });
        }

        [TestMethod]
        public void If_ModelPrimitive_And_SystemType_WithoutDirectConversion_IsChoice()
        {
            var library = FhirLibrary("""define "X": if true then Patient.birthDate else @2020-01-01T00:00:00.000""");
            var @if = library.ShouldDefine<ExpressionDef>("X").expression.Should().BeOfType<If>().Subject;
            @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>()
                .Which.choice.Should().BeEquivalentTo(
                    new TypeSpecifier[] { Fhir("date"), SystemTypes.DateTimeType },
                    "FHIR.date converts to Date, not to DateTime, and conversions are not chained");
        }

        [TestMethod]
        public void Case_OverChoiceParameter_WithDateAndDateTimeIntervals_IsIntervalDateTime()
        {
            var library = FhirLibrary("""
                define function toInterval(choice Choice<DateTime, Quantity, Interval<DateTime>, Interval<Quantity>>):
                  case
                    when choice is DateTime then Interval[choice as DateTime, choice as DateTime]
                    when choice is Interval<DateTime> then choice as Interval<DateTime>
                    when choice is Quantity then Interval[Patient.birthDate + (choice as Quantity), Patient.birthDate + (choice as Quantity) + 1 year)
                    when choice is Interval<Quantity> then Interval[Patient.birthDate + ((choice as Interval<Quantity>).low), Patient.birthDate + ((choice as Interval<Quantity>).high) + 1 year)
                    else null as Interval<DateTime>
                  end
                """);
            var function = library.ShouldDefine<FunctionDef>("toInterval");
            function.expression.resultTypeSpecifier.Should().Be(SystemTypes.DateTimeType.ToIntervalType(),
                "the Interval<Date> branches built from the birth date are converted to Interval<DateTime>");
            function.resultTypeSpecifier.Should().Be(SystemTypes.DateTimeType.ToIntervalType());
        }

        [TestMethod]
        public void List_Code_And_Concept_IsListConcept()
        {
            var list = CreateCqlToolkit().MakeLibraryFromExpression(
                "{ Code { code: 'a', system: 'urn:x' }, Concept { codes: { Code { code: 'a', system: 'urn:x' } } } }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<List>();
            list.resultTypeSpecifier.Should().Be(SystemTypes.ConceptType.ToListType());
            list.element[0].Should().BeOfType<ToConcept>();
        }

        [TestMethod]
        public void List_Date_And_DateTime_IsListDateTime()
        {
            var list = CreateCqlToolkit().MakeLibraryFromExpression("{ @2020-01-01, @2020-01-01T00:00:00.000 }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<List>();
            list.resultTypeSpecifier.Should().Be(SystemTypes.DateTimeType.ToListType());
            list.element[0].Should().BeOfType<ToDateTime>();
        }

        [TestMethod]
        public void List_Integer_Long_Decimal_IsListDecimal()
        {
            var list = CreateCqlToolkit().MakeLibraryFromExpression("{ 1, 2L, 3.5 }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<List>();
            list.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType.ToListType());
            list.element[0].Should().BeOfType<ToDecimal>();
            list.element[1].Should().BeOfType<ToDecimal>();
        }

        [TestMethod]
        public void List_WithDeclaredElementType_ConvertsTheElements()
        {
            var list = CreateCqlToolkit().MakeLibraryFromExpression("List<Decimal>{ 1, 2 }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<List>();
            list.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType.ToListType());
            list.element.Should().AllSatisfy(e => e.Should().BeOfType<ToDecimal>());
        }

        [TestMethod]
        public void List_Integer_And_Null_IsListInteger()
        {
            var list = CreateCqlToolkit().MakeLibraryFromExpression("{ 1, null }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<List>();
            list.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType.ToListType());
            list.element[1].Should().BeOfType<As>().Which.operand.Should().BeOfType<Null>();
        }

        [TestMethod]
        public void List_WithoutCommonType_IsListAny()
        {
            var list = CreateCqlToolkit().MakeLibraryFromExpression("{ 1, 'a' }")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<List>();
            list.resultTypeSpecifier.Should().Be(SystemTypes.AnyType.ToListType(), "a list selector falls back to Any, not to a choice");
        }
    }
}
