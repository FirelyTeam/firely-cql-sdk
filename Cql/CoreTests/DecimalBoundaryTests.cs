/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// "The HighBoundary function returns the greatest possible value of the input to the specified precision" and
    /// LowBoundary "the least possible value" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, sections "HighBoundary"
    /// and "LowBoundary"; examples <c>HighBoundary(1.587, 8) // 1.58799999</c> and <c>LowBoundary(1.587, 8) //
    /// 1.58700000</c>). A Decimal with some decimals stands for every value that shares those digits, so the missing
    /// decimals are completed with 9s or 0s. The digits belong to the magnitude: for a negative value the greatest
    /// completion is the one with the least magnitude. A Decimal has "a scale (meaning number of possible digits to the
    /// right of the decimal) of 8" (section "Decimal"), and "If the precision is greater than the maximum possible
    /// precision of the implementation, the result is null."
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class DecimalBoundaryTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static string? Text(decimal? value) => value?.ToString(CultureInfo.InvariantCulture);

        [TestMethod]
        [DataRow("1.587", "1.58799999", "1.58700000", DisplayName = "the specification's example")]
        [DataRow("1.58888", "1.58888999", "1.58888000", DisplayName = "conformance cases HighBoundaryNullPrecision and LowBoundaryNullPrecision")]
        [DataRow("1", "1.99999999", "1.00000000", DisplayName = "a whole number has every decimal free")]
        [DataRow("1.0", "1.09999999", "1.00000000", DisplayName = "a decimal written with a zero decimal keeps it")]
        [DataRow("0", "0.99999999", "0.00000000", DisplayName = "zero")]
        [DataRow("1.58799999", "1.58799999", "1.58799999", DisplayName = "an input with every decimal is its own boundary")]
        [DataRow("-1.587", "-1.58700000", "-1.58799999", DisplayName = "a negative value: the greatest completion has the least magnitude")]
        [DataRow("-1", "-1.00000000", "-1.99999999", DisplayName = "a negative whole number")]
        [DataRow("-0.5", "-0.50000000", "-0.59999999", DisplayName = "a negative fraction")]
        public void Boundary_NullPrecision_CompletesTheMissingDecimals(string input, string high, string low)
        {
            var value = decimal.Parse(input, CultureInfo.InvariantCulture);
            Assert.AreEqual(high, Text(Context.Operators.HighBoundary(value, null)), "HighBoundary");
            Assert.AreEqual(low, Text(Context.Operators.LowBoundary(value, null)), "LowBoundary");
            // The greatest precision is 8, so an explicit 8 is the same answer.
            Assert.AreEqual(high, Text(Context.Operators.HighBoundary(value, 8)), "HighBoundary at 8");
            Assert.AreEqual(low, Text(Context.Operators.LowBoundary(value, 8)), "LowBoundary at 8");
        }

        [TestMethod]
        public void Boundary_PrecisionBetweenTheInputsAndTheGreatest_CompletesUpToThatPrecision()
        {
            Assert.AreEqual("1.58799", Text(Context.Operators.HighBoundary(1.587m, 5)));
            Assert.AreEqual("1.58700", Text(Context.Operators.LowBoundary(1.587m, 5)));
            Assert.AreEqual("-1.58700", Text(Context.Operators.HighBoundary(-1.587m, 5)));
            Assert.AreEqual("-1.58799", Text(Context.Operators.LowBoundary(-1.587m, 5)));
        }

        [TestMethod]
        public void Boundary_PrecisionCoarserThanTheInput_KeepsThatManyDecimals()
        {
            // The surplus decimals are dropped, whatever their value and sign.
            Assert.AreEqual("1.58", Text(Context.Operators.HighBoundary(1.587m, 2)));
            Assert.AreEqual("1.58", Text(Context.Operators.LowBoundary(1.587m, 2)));
            Assert.AreEqual("-1.58", Text(Context.Operators.HighBoundary(-1.587m, 2)));
            Assert.AreEqual("-1.58", Text(Context.Operators.LowBoundary(-1.587m, 2)));
            Assert.AreEqual("1", Text(Context.Operators.HighBoundary(1.999m, 0)));
            Assert.AreEqual("1", Text(Context.Operators.LowBoundary(1.999m, 0)));
        }

        [TestMethod]
        public void Boundary_PrecisionBeyondTheGreatest_IsNull()
        {
            Assert.IsNull(Context.Operators.HighBoundary(1.587m, 9));
            Assert.IsNull(Context.Operators.LowBoundary(1.587m, 9));
            Assert.IsNull(Context.Operators.HighBoundary(1.587m, 28));
            Assert.IsNull(Context.Operators.LowBoundary(1.587m, 256));
            Assert.IsNull(Context.Operators.HighBoundary(1.587m, -1));
        }

        [TestMethod]
        public void Boundary_BeyondTheCqlDecimalRange_IsNullWhenTheCompletionCannotBeRepresented()
        {
            // The greatest CQL Decimal, (10^28 - 1) / 10^8, has every decimal, so it is its own boundary.
            Assert.AreEqual("99999999999999999999.99999999", Text(Context.Operators.HighBoundary(99999999999999999999.99999999m, null)));
            Assert.AreEqual("99999999999999999999.99999999", Text(Context.Operators.HighBoundary(99999999999999999999m, null)));
            Assert.AreEqual("-99999999999999999999.99999999", Text(Context.Operators.LowBoundary(-99999999999999999999m, null)));
            // A .NET decimal beyond the CQL range has more digits than a completion with 8 decimals can hold: the
            // addition would round instead of completing, or overflow. Either way the answer is null, not a rounded
            // value and not an exception.
            Assert.IsNull(Context.Operators.HighBoundary(1000000000000000000000m, null));
            Assert.IsNull(Context.Operators.LowBoundary(1000000000000000000000m, null));
            Assert.IsNull(Context.Operators.HighBoundary(-1000000000000000000000m, null));
            Assert.IsNull(Context.Operators.HighBoundary(decimal.MaxValue, null));
            Assert.IsNull(Context.Operators.LowBoundary(decimal.MaxValue, null));
            Assert.IsNull(Context.Operators.HighBoundary(decimal.MinValue, null));
            Assert.IsNull(Context.Operators.LowBoundary(decimal.MinValue, null));
            // With no decimals requested such a value is its own boundary.
            Assert.AreEqual(1000000000000000000000m, Context.Operators.HighBoundary(1000000000000000000000m, 0));
            Assert.AreEqual(decimal.MaxValue, Context.Operators.LowBoundary(decimal.MaxValue, 0));
            Assert.AreEqual(decimal.MinValue, Context.Operators.HighBoundary(decimal.MinValue, 0));
        }

        [TestMethod]
        public void Boundary_NullInput_IsNull()
        {
            Assert.IsNull(Context.Operators.HighBoundary((decimal?)null, 8));
            Assert.IsNull(Context.Operators.LowBoundary((decimal?)null, null));
        }
    }
}
