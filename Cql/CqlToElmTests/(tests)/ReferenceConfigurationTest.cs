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
        [Ignore("A generic parameter does not bind to an interval type, so Coalesce over intervals resolves only through interval promotion and demotion; tracked by #1673.")]
        public void Coalesce_Of_Intervals_Resolves_Without_Interval_Promotion()
        {
            // The Java translator resolves this with interval promotion disabled, binding T to Interval<Integer>.
            DefaultToolkit().MakeLibrary("""
                library CoalesceIntervals version '1.0.0'

                define C: Coalesce(Interval[1, 2], Interval[3, 4])
                """);
        }

        [TestMethod]
        public void A_Point_On_Or_After_An_Interval_Becomes_A_Point_Interval_By_Default()
        {
            // SameOrAfter has no point-interval overload; the Java translator converts the point to a point interval
            // in this phrase even with interval promotion disabled.
            var library = DefaultToolkit().MakeLibrary("""
                library OnOrAfterPoint version '1.0.0'

                define OnOrAfter: Interval[6, 10] on or after 6
                """);

            library.statements.Single(s => s.name == "OnOrAfter").expression.Should().BeOfType<SameOrAfter>()
                   .Which.operand[1].Should().BeOfType<Interval>();
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
