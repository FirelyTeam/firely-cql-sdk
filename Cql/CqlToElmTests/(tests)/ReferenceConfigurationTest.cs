/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Pins the toolkit's defaults to the reference configuration recorded in <c>Cql/Cql.CqlToElm/README.md</c>:
    /// the options the Java translator produces the repository's reference ELM with.
    /// </summary>
    [TestClass]
    public class ReferenceConfigurationTest
    {
        private static CqlToolkit DefaultToolkit() => new(config: CqlToolkitConfig.Default);

        [TestMethod]
        public void CqlToolkitConfig_And_CqlToElmOptions_Default_To_The_Reference_Configuration()
        {
            var config = new CqlToolkitConfig();
            var options = new CqlToElmOptions();

            config.DisableListPromotion.Should().BeFalse();
            config.DisableListDemotion.Should().BeFalse();
            config.EnableIntervalPromotion.Should().BeFalse();
            config.EnableIntervalDemotion.Should().BeFalse();
            config.AmbiguousTypeBehavior.Should().Be(AmbiguousTypeBehavior.PreferModel);

            options.DisableListPromotion.Should().Be(config.DisableListPromotion);
            options.DisableListDemotion.Should().Be(config.DisableListDemotion);
            options.EnableIntervalPromotion.Should().Be(config.EnableIntervalPromotion);
            options.EnableIntervalDemotion.Should().Be(config.EnableIntervalDemotion);
            options.AmbiguousTypeBehavior.Should().Be(config.AmbiguousTypeBehavior);
        }

        [TestMethod]
        public void A_Single_Value_Is_Promoted_To_A_List_By_Default()
        {
            var library = DefaultToolkit().MakeLibrary("""
                library ListPromotion version '1.0.0'

                define Total: Count(5)
                """);

            library.statements.Single(s => s.name == "Total").expression.Should().BeOfType<Count>()
                   .Which.source.Should().BeOfType<ToList>();
        }

        [TestMethod]
        [Ignore("List promotion does not rank overloads by the element conversion; tracked by #1981.")]
        public void A_Single_Value_Is_Promoted_To_The_List_Overload_Without_Element_Conversion()
        {
            // The Java translator resolves this to Sum(ToList(5)) with signature List<Integer>.
            var library = DefaultToolkit().MakeLibrary("""
                library ListPromotionRanking version '1.0.0'

                define Total: Sum(5)
                """);

            library.statements.Single(s => s.name == "Total").expression.Should().BeOfType<Sum>()
                   .Which.source.Should().BeOfType<ToList>();
        }

        [TestMethod]
        public void A_Value_Set_Passed_As_A_List_Is_Expanded_Not_Promoted()
        {
            // The Java translator prefers the ValueSet to List<Code> conversion over list promotion:
            // Count(ExpandValueSet(ValueSetRef)), not Count(ToList(ValueSetRef)).
            var library = DefaultToolkit().MakeLibrary("""
                library ValueSetExpansion version '1.0.0'

                valueset "Unknown": 'http://example.org/ValueSet/unknown'

                define Expanded: Count("Unknown")
                """);

            library.statements.Single(s => s.name == "Expanded").expression.Should().BeOfType<Count>()
                   .Which.source.Should().BeOfType<ExpandValueSet>();
        }

        [DataTestMethod]
        [DataRow("Code { code: 'x', system: 'http://example.org' }", "Code")]
        [DataRow("@2020-01-01", "Date")]
        public void A_Promoted_Value_Keeps_Its_Own_Type_Over_An_Equally_Costly_Conversion(string value, string elementType)
        {
            // Promoting the value and promoting its implicit conversion (Code to Concept, Date to DateTime) cost the
            // same; the Java translator keeps the value's own type: Count(ToList(value)) with signature List<value type>.
            var library = DefaultToolkit().MakeLibrary($"""
                library PromotionInference version '1.0.0'

                define Counted: Count({value})
                """);

            var toList = library.statements.Single(s => s.name == "Counted").expression.Should().BeOfType<Count>()
                                .Which.source.Should().BeOfType<ToList>().Subject;
            toList.resultTypeSpecifier.Should().BeOfType<ListTypeSpecifier>()
                  .Which.elementType.Should().BeOfType<NamedTypeSpecifier>()
                  .Which.name.Name.Should().Be($"{{urn:hl7-org:elm-types:r1}}{elementType}");
        }

        [TestMethod]
        public void Coalesce_Of_Intervals_Resolves_Without_Interval_Promotion()
        {
            // The Java translator resolves this with interval promotion disabled, binding T to Interval<Integer>.
            var library = DefaultToolkit().MakeLibrary("""
                library CoalesceIntervals version '1.0.0'

                define C: Coalesce(Interval[1, 2], Interval[3, 4])
                """);

            var coalesce = library.statements.Single(s => s.name == "C").expression.Should().BeOfType<Coalesce>().Subject;
            coalesce.GetErrors().Should().BeEmpty();
            coalesce.resultTypeSpecifier.ToString().Should().Be("Interval<Integer>");
        }

        [TestMethod]
        public void A_Point_On_Or_After_An_Interval_Becomes_A_Point_Interval_By_Default()
        {
            // SameOrAfter has no point-interval overload; the Java translator converts the point to a point interval
            // in this phrase even with interval promotion disabled, as if 6 is null then null else Interval[6, 6].
            var library = DefaultToolkit().MakeLibrary("""
                library OnOrAfterPoint version '1.0.0'

                define OnOrAfter: Interval[6, 10] on or after 6
                """);

            var pointInterval = library.statements.Single(s => s.name == "OnOrAfter").expression.Should().BeOfType<SameOrAfter>()
                                       .Which.operand[1].Should().BeOfType<If>().Subject;
            pointInterval.condition.Should().BeOfType<IsNull>();
            pointInterval.then.Should().BeOfType<Null>();
            pointInterval.@else.Should().BeOfType<Interval>();
        }

        [TestMethod]
        public void A_Point_On_Or_After_An_Interval_Of_Another_Point_Type_Is_Converted_Before_It_Becomes_A_Point_Interval()
        {
            // The Java translator converts the point first: if ToDecimal(6) is null then null else
            // Interval[ToDecimal(6), ToDecimal(6)], an Interval<Decimal>, not a converted Interval<Integer>.
            var library = DefaultToolkit().MakeLibrary("""
                library OnOrAfterPoint version '1.0.0'

                define OnOrAfter: Interval[6.0, 10.0] on or after 6
                """);

            var pointInterval = library.statements.Single(s => s.name == "OnOrAfter").expression.Should().BeOfType<SameOrAfter>()
                                       .Which.operand[1].Should().BeOfType<If>().Subject;
            pointInterval.resultTypeSpecifier.ToString().Should().Be("Interval<Decimal>");
            pointInterval.condition.Should().BeOfType<IsNull>().Which.operand.Should().BeOfType<As>().Which.operand.Should().BeOfType<ToDecimal>();
            pointInterval.then.Should().BeOfType<Null>();
            var interval = pointInterval.@else.Should().BeOfType<Interval>().Subject;
            interval.low.Should().BeOfType<ToDecimal>();
            interval.high.Should().BeOfType<ToDecimal>();
        }

        [DataTestMethod]
        [DataRow("[Encounter] E where E.period on or after Interval[@2020-01-01T00:00:00, @2021-01-01T00:00:00]")]
        [DataRow("[Observation] O where O.effective on or after Interval[@2020-01-01T00:00:00, @2021-01-01T00:00:00]")]
        [DataRow("[Observation] O where Interval[@2020-01-01T00:00:00, @2021-01-01T00:00:00] on or before O.issued")]
        [DataRow("[Encounter] E where E.period on or after @2020-01-01T00:00:00")]
        [DataRow("[Encounter] E where @2020-01-01T00:00:00 on or before E.period")]
        [DataRow("[Observation] O where O.issued on or after Interval[@2020-01-01, @2021-01-01]")]
        public void A_Model_Operand_On_Or_Before_Or_After_Translates_And_Compiles_By_Default(string expression)
        {
            // A FHIR Period converts to an interval itself, also when the other operand is a point, which becomes a
            // point interval; a choice is left to overload resolution; and a FHIR instant is a point. The Java translator
            // translates all of these. The generated C# must compile, so no operand is an interval of an invalid point type.
            var toolkit = DefaultToolkit().AddFHIRHelpers();
            toolkit.MakeLibrary($"""
                library ModelOperand version '1.0.0'

                using FHIR version '4.0.1'

                include FHIRHelpers version '4.0.1'

                context Patient

                define Result: {expression}
                """);

            _ = toolkit.CompileToAssemblies();
        }

        [TestMethod]
        public void A_Fhir_Period_On_Or_After_A_Point_Compares_Its_Interval_With_A_Point_Interval()
        {
            // As the Java translator does: FHIRHelpers.ToInterval(E.period) on or after Interval[point, point].
            var library = DefaultToolkit().AddFHIRHelpers().MakeLibrary("""
                library PeriodPoint version '1.0.0'

                using FHIR version '4.0.1'

                include FHIRHelpers version '4.0.1'

                context Patient

                define Result: [Encounter] E where E.period on or after @2020-01-01T00:00:00
                """);

            var where = library.statements.Single(s => s.name == "Result").expression.Should().BeOfType<Query>().Which.where;
            var sameOrAfter = where.Should().BeOfType<SameOrAfter>().Subject;
            sameOrAfter.operand[0].Should().BeOfType<FunctionRef>().Which.name.Should().Be("ToInterval");
            sameOrAfter.operand[1].Should().BeOfType<If>().Which.@else.Should().BeOfType<Interval>();
        }

        [TestMethod]
        public void A_Fhir_Instant_On_Or_After_A_Date_Interval_Becomes_A_DateTime_Point_Interval()
        {
            // The instant does not convert to Date, and an Interval<FHIR.instant> is not a valid interval, so it is
            // converted to DateTime, the point type it converts to. The Java translator instead demotes the Date
            // interval to a point (PointFrom), which fails at run time for an interval of more than one point.
            var library = DefaultToolkit().AddFHIRHelpers().MakeLibrary("""
                library InstantDate version '1.0.0'

                using FHIR version '4.0.1'

                include FHIRHelpers version '4.0.1'

                context Patient

                define Result: [Observation] O where O.issued on or after Interval[@2020-01-01, @2021-01-01]
                """);

            var where = library.statements.Single(s => s.name == "Result").expression.Should().BeOfType<Query>().Which.where;
            var pointInterval = where.Should().BeOfType<SameOrAfter>().Which.operand[0].Should().BeOfType<If>().Subject;
            pointInterval.resultTypeSpecifier.ToString().Should().Be("Interval<DateTime>");
            pointInterval.@else.Should().BeOfType<Interval>().Which.low.Should().BeOfType<FunctionRef>().Which.name.Should().Be("ToDateTime");
        }

        [TestMethod]
        public void A_Value_That_Cannot_Be_A_Point_Is_Reported_As_Written()
        {
            DefaultToolkit().MakeLibrary("""
                library NotAPoint version '1.0.0'

                define OnOrAfter: Interval[1, 10] on or after 'a'
                """,
                "Could not resolve call to operator SameOrAfter with signature (Interval<Integer>, String)*");
        }

        [TestMethod]
        public void A_Point_Is_Not_Promoted_To_An_Interval_By_Default()
        {
            // The Java translator reports the same error for this call.
            DefaultToolkit().MakeLibrary("""
                library IntervalPromotion version '1.0.0'

                define Overlaps: Interval[1, 10] overlaps 5
                """,
                "Could not resolve call to operator Overlaps with signature (Interval<Integer>, Integer)*");
        }
    }
}
