/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// <c>HighBoundary</c> and <c>LowBoundary</c> with a null precision use the greatest precision of the input's
    /// type. CQL 1.5.3 Errata 2, Appendix B - CQL Reference, sections "HighBoundary" and "LowBoundary": "If no
    /// precision is specified, the greatest precision of the type of the input value is used (i.e. at least 8 for
    /// Decimal, 4 for Date, at least 17 for DateTime, and at least 9 for Time). If the precision is greater than the
    /// maximum possible precision of the implementation, the result is null." The greatest precision of a Date is its
    /// day (8). The HL7 CQL conformance suite (CqlArithmeticFunctionsTest) expects
    /// <c>HighBoundaryNullPrecision</c> and <c>LowBoundaryNullPrecision</c> below.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class BoundaryNullPrecisionTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlDate Date(string value) =>
            CqlDate.TryParse(value, out var date) ? date! : throw new ArgumentException(value);

        private static CqlDateTime DateTime(string value) =>
            CqlDateTime.TryParse(value, out var dateTime) ? dateTime! : throw new ArgumentException(value);

        private static CqlTime Time(string value) =>
            CqlTime.TryParse(value, out var time) ? time! : throw new ArgumentException(value);

        // The string pins the precision of the result; the round trip through the parser and Equal pins that
        // the result is a valid value of its type equal to the expectation.
        private static void AssertDate(string expected, CqlDate? actual)
        {
            Assert.AreEqual(expected, actual?.ToString());
            Assert.AreEqual(true, Context.Operators.Equal(actual, Date(expected)));
        }

        private static void AssertDateTime(string expected, CqlDateTime? actual)
        {
            Assert.AreEqual(expected, actual?.ToString());
            Assert.AreEqual(true, Context.Operators.Equal(actual, DateTime(expected)));
        }

        private static void AssertTime(string expected, CqlTime? actual)
        {
            Assert.AreEqual(expected, actual?.ToString());
            Assert.AreEqual(true, Context.Operators.Equal(actual, Time(expected)));
        }

        private static void AssertDecimal(string expected, decimal? actual) =>
            Assert.AreEqual(expected, actual?.ToString(CultureInfo.InvariantCulture));

        [TestMethod]
        public void HighBoundary_Decimal_NullPrecision_UsesPrecision8() =>
            // Conformance case HighBoundaryNullPrecision.
            AssertDecimal("1.58888999", Context.Operators.HighBoundary(1.58888m, null));

        [TestMethod]
        public void LowBoundary_Decimal_NullPrecision_UsesPrecision8() =>
            // Conformance case LowBoundaryNullPrecision.
            AssertDecimal("1.58888000", Context.Operators.LowBoundary(1.58888m, null));

        [TestMethod]
        public void Boundary_Decimal_ExplicitPrecision_UsesThatPrecision()
        {
            AssertDecimal("1.58799999", Context.Operators.HighBoundary(1.587m, 8));
            AssertDecimal("1.58700000", Context.Operators.LowBoundary(1.587m, 8));
        }

        [TestMethod]
        public void Boundary_WholeNumberDecimal_CompletesEveryDecimal()
        {
            // A whole number has no decimals, so every decimal place is free: the boundaries are the greatest and
            // least values with 8 decimals that round down to it.
            AssertDecimal("1.99999999", Context.Operators.HighBoundary(1m, null));
            AssertDecimal("1.00000000", Context.Operators.LowBoundary(1m, null));
            AssertDecimal("1.99999999", Context.Operators.HighBoundary(1m, 8));
            AssertDecimal("1.00000000", Context.Operators.LowBoundary(1m, 8));
            // A decimal written with a zero decimal keeps that decimal.
            AssertDecimal("1.09999999", Context.Operators.HighBoundary(1.0m, null));
            AssertDecimal("1.00000000", Context.Operators.LowBoundary(1.0m, null));
        }

        [TestMethod]
        public void HighBoundary_Date_NullPrecision_UsesDayPrecision()
        {
            AssertDate("2014-01-15", Context.Operators.HighBoundary(Date("2014-01-15"), null));
            AssertDate("2014-02-28", Context.Operators.HighBoundary(Date("2014-02"), null));
            AssertDate("2012-02-29", Context.Operators.HighBoundary(Date("2012-02"), null));
            AssertDate("2014-12-31", Context.Operators.HighBoundary(Date("2014"), null));
        }

        [TestMethod]
        public void LowBoundary_Date_NullPrecision_UsesDayPrecision()
        {
            AssertDate("2014-01-15", Context.Operators.LowBoundary(Date("2014-01-15"), null));
            AssertDate("2014-02-01", Context.Operators.LowBoundary(Date("2014-02"), null));
            AssertDate("2014-01-01", Context.Operators.LowBoundary(Date("2014"), null));
        }

        [TestMethod]
        public void Boundary_Date_ExplicitPrecision_UsesThatPrecision()
        {
            AssertDate("2014-12", Context.Operators.HighBoundary(Date("2014"), 6));
            AssertDate("2014-01", Context.Operators.LowBoundary(Date("2014"), 6));
            AssertDate("2014-01-15", Context.Operators.HighBoundary(Date("2014-01-15"), 8));
            AssertDate("2014-01-15", Context.Operators.LowBoundary(Date("2014-01-15"), 8));
        }

        [TestMethod]
        public void Boundary_Date_PrecisionAboveDay_IsNull()
        {
            Assert.IsNull(Context.Operators.HighBoundary(Date("2014-01-15"), 10));
            Assert.IsNull(Context.Operators.LowBoundary(Date("2014-01-15"), 10));
        }

        [TestMethod]
        public void HighBoundary_DateTime_NullPrecision_UsesMillisecondPrecision()
        {
            AssertDateTime("2014-01-01T08:59:59.999", Context.Operators.HighBoundary(DateTime("2014-01-01T08"), null));
            AssertDateTime("2014-01-15T08:30:59.999+01:00", Context.Operators.HighBoundary(DateTime("2014-01-15T08:30+01:00"), null));
            AssertDateTime("2014-02-28T23:59:59.999", Context.Operators.HighBoundary(DateTime("2014-02"), null));
            AssertDateTime("2012-02-29T23:59:59.999", Context.Operators.HighBoundary(DateTime("2012-02"), null));
        }

        [TestMethod]
        public void Boundary_DateTime_NullPrecision_InputAtMillisecond_IsTheInput()
        {
            AssertDateTime("2014-01-15T08:30:45.123+01:00", Context.Operators.HighBoundary(DateTime("2014-01-15T08:30:45.123+01:00"), null));
            AssertDateTime("2014-01-15T08:30:45.123+01:00", Context.Operators.LowBoundary(DateTime("2014-01-15T08:30:45.123+01:00"), null));
        }

        [TestMethod]
        public void LowBoundary_DateTime_NullPrecision_UsesMillisecondPrecision()
        {
            AssertDateTime("2014-01-01T08:00:00.000", Context.Operators.LowBoundary(DateTime("2014-01-01T08"), null));
            AssertDateTime("2014-01-15T08:30:00.000+01:00", Context.Operators.LowBoundary(DateTime("2014-01-15T08:30+01:00"), null));
            AssertDateTime("2014-02-01T00:00:00.000", Context.Operators.LowBoundary(DateTime("2014-02"), null));
        }

        [TestMethod]
        public void Boundary_DateTime_ExplicitPrecision_UsesThatPrecision()
        {
            AssertDateTime("2014-01-01T08:59:59.999", Context.Operators.HighBoundary(DateTime("2014-01-01T08"), 17));
            AssertDateTime("2014-01-01T08:00:00.000", Context.Operators.LowBoundary(DateTime("2014-01-01T08"), 17));
            AssertDateTime("2014-04-30T23:59:59.999", Context.Operators.HighBoundary(DateTime("2014-04"), 17));
        }

        [TestMethod]
        public void Boundary_DateTime_PrecisionAboveMillisecond_IsNull()
        {
            Assert.IsNull(Context.Operators.HighBoundary(DateTime("2014-01-01T08"), 18));
            Assert.IsNull(Context.Operators.LowBoundary(DateTime("2014-01-01T08"), 18));
        }

        [TestMethod]
        public void HighBoundary_Time_NullPrecision_UsesMillisecondPrecision() =>
            AssertTime("10:30:59.999", Context.Operators.HighBoundary(Time("10:30"), null));

        [TestMethod]
        public void LowBoundary_Time_NullPrecision_UsesMillisecondPrecision() =>
            AssertTime("10:30:00.000", Context.Operators.LowBoundary(Time("10:30"), null));

        [TestMethod]
        public void Boundary_Time_NullPrecision_InputAtMillisecond_IsTheInput()
        {
            AssertTime("10:30:15.250", Context.Operators.HighBoundary(Time("10:30:15.250"), null));
            AssertTime("10:30:15.250", Context.Operators.LowBoundary(Time("10:30:15.250"), null));
        }

        [TestMethod]
        public void Boundary_Time_ExplicitPrecision_UsesThatPrecision()
        {
            AssertTime("10:30:59.999", Context.Operators.HighBoundary(Time("10:30"), 9));
            AssertTime("10:30:00.000", Context.Operators.LowBoundary(Time("10:30"), 9));
        }

        [TestMethod]
        public void Boundary_Time_PrecisionAboveMillisecond_IsNull()
        {
            Assert.IsNull(Context.Operators.HighBoundary(Time("10:30"), 10));
            Assert.IsNull(Context.Operators.LowBoundary(Time("10:30"), 10));
        }

        [TestMethod]
        public void Boundary_NullInput_NullPrecision_IsNull()
        {
            Assert.IsNull(Context.Operators.HighBoundary((decimal?)null, null));
            Assert.IsNull(Context.Operators.LowBoundary((decimal?)null, null));
            Assert.IsNull(Context.Operators.HighBoundary((CqlDate?)null, null));
            Assert.IsNull(Context.Operators.LowBoundary((CqlDate?)null, null));
            Assert.IsNull(Context.Operators.HighBoundary((CqlDateTime?)null, null));
            Assert.IsNull(Context.Operators.LowBoundary((CqlDateTime?)null, null));
            Assert.IsNull(Context.Operators.HighBoundary((CqlTime?)null, null));
            Assert.IsNull(Context.Operators.LowBoundary((CqlTime?)null, null));
        }
    }
}
