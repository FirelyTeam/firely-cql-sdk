/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// The ConvertsTo* operators and CanConvertQuantity of CQL 1.5.3, Appendix B - CQL Reference, Type Operators,
    /// translated and evaluated end to end.
    /// </summary>
    [TestClass]
    public class ConvertsToTest : Base
    {
        [TestMethod]
        [DataRow("ConvertsToBoolean('true')", true)]
        [DataRow("ConvertsToBoolean(1)", true)]
        [DataRow("ConvertsToBoolean('maybe')", false)]
        [DataRow("ConvertsToBoolean(@2014-01-01)", false)]
        [DataRow("ConvertsToDate('2014-01-01')", true)]
        [DataRow("ConvertsToDate(@2014-01-01T10:00:00)", true)]
        [DataRow("ConvertsToDate('2014-13-01')", false)]
        [DataRow("ConvertsToDate(1)", false)]
        [DataRow("ConvertsToDateTime('2014-01-01T10:00:00')", true)]
        [DataRow("ConvertsToDateTime(@2014-01-01)", true)]
        [DataRow("ConvertsToDateTime('not a date')", false)]
        [DataRow("ConvertsToDecimal('1.5')", true)]
        [DataRow("ConvertsToDecimal(1)", true)]
        [DataRow("ConvertsToDecimal('one')", false)]
        [DataRow("ConvertsToInteger('12')", true)]
        [DataRow("ConvertsToInteger(12L)", true)]
        [DataRow("ConvertsToInteger(2147483648L)", false)]
        [DataRow("ConvertsToInteger('1.5')", false)]
        [DataRow("ConvertsToLong('12')", true)]
        [DataRow("ConvertsToLong(12)", true)]
        [DataRow("ConvertsToLong('twelve')", false)]
        [DataRow("""ConvertsToQuantity('5 \'mg\'')""", true)]
        [DataRow("ConvertsToQuantity(5)", true)]
        [DataRow("ConvertsToQuantity('five')", false)]
        [DataRow("ConvertsToRatio('1:128')", true)]
        [DataRow("ConvertsToRatio(5)", false)]
        [DataRow("ConvertsToString(5)", true)]
        [DataRow("ConvertsToString(@T10:00)", true)]
        [DataRow("ConvertsToString({ 1 })", false)]
        [DataRow("ConvertsToTime('10:00:00')", true)]
        [DataRow("ConvertsToTime('25:00:00')", false)]
        [DataRow("ConvertsToTime(@2014-01-01)", false)]
        public void ConvertsTo_returns_whether_the_argument_converts(string expression, bool expected) =>
            Evaluate(expression).Should().Be(expected);

        [TestMethod]
        [DataRow("ConvertsToBoolean")]
        [DataRow("ConvertsToDate")]
        [DataRow("ConvertsToDateTime")]
        [DataRow("ConvertsToDecimal")]
        [DataRow("ConvertsToInteger")]
        [DataRow("ConvertsToLong")]
        [DataRow("ConvertsToQuantity")]
        [DataRow("ConvertsToRatio")]
        [DataRow("ConvertsToString")]
        [DataRow("ConvertsToTime")]
        public void ConvertsTo_null_is_null(string function) =>
            Evaluate($"{function}(null)").Should().BeNull();

        [TestMethod]
        [DataRow("CanConvertQuantity(5 'mg', 'g')", true)]
        [DataRow("CanConvertQuantity(12 '[in_i]', '[ft_i]')", true)]
        [DataRow("CanConvertQuantity(5 'mg', 's')", false)]
        [DataRow("CanConvertQuantity(null, 'g')", null)]
        [DataRow("CanConvertQuantity(5 'mg', null)", null)]
        public void CanConvertQuantity_returns_whether_the_quantity_converts(string expression, bool? expected) =>
            Evaluate(expression).Should().Be(expected);

        /// <summary>
        /// Translates <paramref name="expression"/>, checks it becomes the ELM node of the function it calls with a
        /// Boolean result, and evaluates it.
        /// </summary>
        private static bool? Evaluate(string expression)
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression(expression);
            lib.Should().NotBeNull();
            lib.statements.Should().ContainSingle();
            var node = lib.statements[0].expression;
            node.GetType().Name.Should().Be(expression[..expression.IndexOf('(')]);
            node.Should().HaveType(SystemTypes.BooleanType);
            return Run<bool?>(node, lib);
        }
    }
}
