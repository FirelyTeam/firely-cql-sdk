/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class RatioTest : Base
    {
        [TestMethod]
        public void Ratio_literal_evaluates_to_its_numerator_and_denominator()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("6 'g' : 10 'cm3'");
            var ratio = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Ratio>();

            var result = Run<CqlRatio>(ratio, lib);

            result.Should().NotBeNull();
            result!.numerator.Should().BeEquivalentTo(new CqlQuantity(6m, "g"));
            result.denominator.Should().BeEquivalentTo(new CqlQuantity(10m, "cm3"));
        }

        [TestMethod]
        public void Ratio_literal_without_units_uses_the_default_unit()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("1:128");
            var ratio = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Ratio>();

            ratio.numerator.unit.Should().Be("1");
            ratio.denominator.unit.Should().Be("1");

            var result = Run<CqlRatio>(ratio, lib);
            result!.numerator.Should().BeEquivalentTo(new CqlQuantity(1m, "1"));
            result.denominator.Should().BeEquivalentTo(new CqlQuantity(128m, "1"));
        }

        [TestMethod]
        public void Ratio_equal_to_the_same_ratio()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("1'cm':2'cm' = 1'cm':2'cm'");
            var equal = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equal>();
            Run<bool?>(equal, lib).Should().BeTrue();
        }

        [TestMethod]
        public void Ratio_not_equal_to_an_equivalent_ratio()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("1:8 = 2:16");
            var equal = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equal>();
            Run<bool?>(equal, lib).Should().BeFalse();
        }

        [TestMethod]
        public void Ratio_equivalent_to_the_same_ratio_in_other_units()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("1 'mg':2 'mL' ~ 2 'mg':4 'mL'");
            var equivalent = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            Run<bool?>(equivalent, lib).Should().BeTrue();
        }

        [TestMethod]
        public void Ratio_equivalent_to_a_ratio_with_scaled_parts()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("1:100 ~ 10:1000");
            var equivalent = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            Run<bool?>(equivalent, lib).Should().BeTrue();
        }

        [TestMethod]
        public void Ratio_not_equivalent_to_a_different_ratio()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("1'cm':2'cm' ~ 3'cm':2'cm'");
            var equivalent = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            Run<bool?>(equivalent, lib).Should().BeFalse();
        }

        [TestMethod]
        public void Distinct_removes_equal_ratios()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("distinct { 1'cm':2'cm', 1'cm':2'cm' }");
            var distinct = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Distinct>();
            Run<IEnumerable<CqlRatio>>(distinct, lib).Should().ContainSingle();
        }
    }
}
