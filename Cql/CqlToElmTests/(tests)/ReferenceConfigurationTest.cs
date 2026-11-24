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
