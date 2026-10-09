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
    /// <summary>
    /// The Ratio conversions of CQL 1.5.3, Appendix B - CQL Reference, Type Operators:
    /// ToRatio(String), ConvertsToRatio(Any) and ToQuantity(Ratio), translated and evaluated end to end.
    /// </summary>
    [TestClass]
    public class RatioConversionTest : Base
    {
        [TestMethod]
        public void ToRatio_well_formed_string_is_a_ratio()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("""ToRatio('1.0 \'mg\':2.0 \'mg\'')""");
            var toRatio = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToRatio>();
            toRatio.Should().HaveType(SystemTypes.RatioType);
            toRatio.operand.Should().BeLiteralString("1.0 'mg':2.0 'mg'");

            var result = Run<CqlRatio>(toRatio, lib);

            result.Should().NotBeNull();
            result!.numerator.Should().BeEquivalentTo(new CqlQuantity(1.0m, "mg"));
            result.denominator.Should().BeEquivalentTo(new CqlQuantity(2.0m, "mg"));
        }

        [TestMethod]
        public void ToRatio_string_without_units_has_default_units()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ToRatio('1:128') = 1:128");
            var equal = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equal>();
            Run<bool?>(equal, lib).Should().BeTrue();
        }

        [TestMethod]
        public void ToRatio_malformed_string_is_null()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("""ToRatio('1.0 \'mg\';2.0 \'mg\'')""");
            var toRatio = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToRatio>();
            Run<CqlRatio>(toRatio, lib).Should().BeNull();
        }

        [TestMethod]
        public void ToRatio_null_is_null()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ToRatio(null)");
            var toRatio = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToRatio>();
            toRatio.Should().HaveType(SystemTypes.RatioType);
            Run<CqlRatio>(toRatio, lib).Should().BeNull();
        }

        [TestMethod]
        public void ToRatio_of_ToString_round_trips()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ToRatio(ToString(1.5 'mg':3 'mL')) = 1.5 'mg':3 'mL'");
            var equal = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equal>();
            Run<bool?>(equal, lib).Should().BeTrue();
        }

        [TestMethod]
        public void Convert_string_to_Ratio_converts_like_ToRatio()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("""convert '1 \'mg\':2 \'mL\'' to Ratio""");
            var convert = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Elm.Convert>();
            convert.Should().HaveType(SystemTypes.RatioType);

            var result = Run<CqlRatio>(convert, lib);

            result.Should().NotBeNull();
            result!.numerator.Should().BeEquivalentTo(new CqlQuantity(1m, "mg"));
            result.denominator.Should().BeEquivalentTo(new CqlQuantity(2m, "mL"));
        }

        [TestMethod]
        [DataRow("""ConvertsToRatio('1.0 \'mg\':2.0 \'mg\'')""", true, DisplayName = "Well-formed string")]
        [DataRow("ConvertsToRatio('1:128')", true, DisplayName = "String without units")]
        [DataRow("""ConvertsToRatio('1.0 \'mg\';2.0 \'mg\'')""", false, DisplayName = "Malformed string")]
        [DataRow("ConvertsToRatio('1:2:3')", false, DisplayName = "Three parts")]
        [DataRow("ConvertsToRatio(1 'mg':2 'mL')", true, DisplayName = "Ratio")]
        [DataRow("ConvertsToRatio(5)", false, DisplayName = "Integer")]
        [DataRow("ConvertsToRatio(5 'mg')", false, DisplayName = "Quantity")]
        public void ConvertsToRatio_returns_whether_the_argument_converts(string expression, bool expected)
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression(expression);
            var convertsToRatio = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ConvertsToRatio>();
            convertsToRatio.Should().HaveType(SystemTypes.BooleanType);

            Run<bool?>(convertsToRatio, lib).Should().Be(expected);
        }

        [TestMethod]
        public void ConvertsToRatio_null_is_null()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ConvertsToRatio(null)");
            var convertsToRatio = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ConvertsToRatio>();
            Run<bool?>(convertsToRatio, lib).Should().BeNull();
        }

        [TestMethod]
        public void ToQuantity_of_a_ratio_divides_numerator_by_denominator()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ToQuantity(6 'mg':2 'mL')");
            var toQuantity = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToQuantity>();
            toQuantity.Should().HaveType(SystemTypes.QuantityType);
            toQuantity.operand.Should().BeOfType<Ratio>().Which.Should().HaveType(SystemTypes.RatioType);

            var result = Run<CqlQuantity>(toQuantity, lib);
            result.Should().NotBeNull();

            // Quantity division expresses a quotient of different units in UCUM canonical units;
            // the quantity is equal to 3 'mg/mL', whatever the spelling of its unit.
            var equal = CreateCqlToolkit().MakeLibraryFromExpression("ToQuantity(6 'mg':2 'mL') = 3 'mg/mL'");
            Run<bool?>(equal.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equal>(), equal).Should().BeTrue();
        }

        [TestMethod]
        public void ToQuantity_of_a_ratio_with_equal_units_has_the_default_unit()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ToQuantity(1 'mg':4 'mg')");
            var toQuantity = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToQuantity>();
            Run<CqlQuantity>(toQuantity, lib).Should().BeEquivalentTo(new CqlQuantity(0.25m, "1"));
        }

        [TestMethod]
        public void ToQuantity_of_a_ratio_with_a_zero_denominator_is_null()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ToQuantity(1 'mg':0 'mL')");
            var toQuantity = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToQuantity>();
            Run<CqlQuantity>(toQuantity, lib).Should().BeNull();
        }

        [TestMethod]
        public void ToQuantity_of_a_null_ratio_is_null()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("ToQuantity(null as Ratio)");
            var toQuantity = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToQuantity>();
            toQuantity.Should().HaveType(SystemTypes.QuantityType);
            Run<CqlQuantity>(toQuantity, lib).Should().BeNull();
        }
    }
}
