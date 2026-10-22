/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Comparisons of a Date with a DateTime. The comparison operators take two operands of one type,
    /// and a Date converts implicitly to a DateTime (§3 Table 3-J), so the translator wraps the Date in
    /// a <see cref="ToDateTime"/> and the runtime compares two DateTime values. §9.B After: "When this
    /// operator is called with both Date and DateTime inputs, the Date values will be implicitly
    /// converted to DateTime values as defined by the ToDateTime operator."
    /// </summary>
    [TestClass]
    public class DateDateTimeComparisonTest : Base
    {
        [TestMethod]
        [DataRow("@2024-01-01 after @2030-01-01T00:00:00", 0, false)]
        [DataRow("@2030-01-01T00:00:00 after @2024-01-01", 1, true)]
        [DataRow("@2024-01-01 before @2030-01-01T00:00:00", 0, true)]
        [DataRow("@2030-01-01T00:00:00 before @2024-01-01", 1, false)]
        [DataRow("@2024-01-01 after year of @2030-01-01T00:00:00", 0, false)]
        [DataRow("@2030-01-01T00:00:00 after year of @2024-01-01", 1, true)]
        [DataRow("@2024-01-01 > @2030-01-01T00:00:00", 0, false)]
        [DataRow("@2030-01-01T00:00:00 > @2024-01-01", 1, true)]
        [DataRow("@2024-01-01 >= @2030-01-01T00:00:00", 0, false)]
        [DataRow("@2024-01-01 < @2030-01-01T00:00:00", 0, true)]
        [DataRow("@2024-01-01 <= @2030-01-01T00:00:00", 0, true)]
        [DataRow("@2030-01-01T00:00:00 < @2024-01-01", 1, false)]
        [DataRow("@2024-01-01 = @2030-01-01T00:00:00", 0, false)]
        [DataRow("@2030-01-01T00:00:00 = @2024-01-01", 1, false)]
        // §9.B Greater, "DateTimeGreaterIsNull", and §9.B Equal, "DateTimeEqualIsNull": the converted
        // Date has no hour, so the comparison stops there with null.
        [DataRow("@2012-01-01 > @2012-01-01T12", 0, null)]
        [DataRow("@2012-01-01 = @2012-01-01T12", 0, null)]
        public void DateComparedWithDateTime_ConvertsTheDateToADateTime(string expression, int dateOperand, bool? expected)
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression(expression);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(BinaryExpression));
            var comparison = (BinaryExpression)library.statements[0].expression;

            Assert.IsNotNull(comparison.operand);
            Assert.AreEqual(2, comparison.operand.Length);
            Assert.IsInstanceOfType(comparison.operand[dateOperand], typeof(ToDateTime));
            var conversion = (ToDateTime)comparison.operand[dateOperand];
            Assert.AreEqual($"{{{SystemUri}}}Date", conversion.operand.resultTypeName.Name);
            Assert.AreEqual($"{{{SystemUri}}}DateTime", comparison.operand[1 - dateOperand].resultTypeName.Name);

            var result = Run(comparison, library, FhirCqlContext.ForBundle());
            Assert.AreEqual(expected, result, expression);
        }
    }
}
