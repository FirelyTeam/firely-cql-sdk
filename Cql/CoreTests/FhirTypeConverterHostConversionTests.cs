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
using Hl7.Fhir.Model;

namespace CoreTests
{
    using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

    [TestClass]
    [TestCategory("UnitTest")]
    public class FhirTypeConverterHostConversionTests
    {
        internal static readonly TypeConverter FhirTypeConverter =
            Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInfo.ModelInspector);

        [TestMethod]
        public void ConvertCqlIntervalOfTime_Period_AnchorsTimesOnMinimumFhirDate()
        {
            var low = new CqlTime(10, 30, 0, null, 0, 0);
            var high = new CqlTime(16, 45, 15, 123, 0, 0);
            var interval = new CqlInterval<CqlTime>(low, high, lowClosed: true, highClosed: true);

            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("0001-01-01T10:30:00+00:00", converted.Start);
            Assert.AreEqual("0001-01-01T16:45:15.123+00:00", converted.End);
        }

        [TestMethod]
        public void ConvertCqlIntervalOfTime_Period_KeepsOffsetsThatUnderflowTheMinimumFhirDate()
        {
            // 0001-01-01T00:30:00+02:00 denotes a UTC instant before DateTime.MinValue, so it has no
            // DateTimeOffset representation — but it is a valid FHIR dateTime and must convert.
            var low = new CqlTime(0, 30, 0, null, 2, 0);
            var high = new CqlTime(1, 0, 0, null, 2, 0);
            var interval = new CqlInterval<CqlTime>(low, high, lowClosed: true, highClosed: true);

            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("0001-01-01T00:30:00+02:00", converted.Start);
            Assert.AreEqual("0001-01-01T01:00:00+02:00", converted.End);
        }

        [TestMethod]
        public void ConvertCqlIntervalOfTime_Period_RendersNegativeOffsets()
        {
            var low = new CqlTime(10, 30, 0, null, -5, 0);
            var interval = new CqlInterval<CqlTime>(low, null, lowClosed: true, highClosed: true);

            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("0001-01-01T10:30:00-05:00", converted.Start);
            Assert.IsNull(converted.End);
        }

        [TestMethod]
        public void ConvertCqlIntervalOfTime_Period_RendersNegativeOffsetsWithMinutes()
        {
            var low = new CqlTime(10, 30, 0, null, -5, 30);
            var interval = new CqlInterval<CqlTime>(low, null, lowClosed: true, highClosed: true);

            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("0001-01-01T10:30:00-05:30", converted.Start);
        }

        [TestMethod]
        public void ConvertCqlIntervalOfTime_Period_PreservesPrecisionAndAbsentOffset()
        {
            // A time with minute precision and no timezone offset keeps both characteristics.
            var low = new CqlTime(10, 30, null, null, null, null);
            var interval = new CqlInterval<CqlTime>(low, null, lowClosed: true, highClosed: true);

            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("0001-01-01T10:30", converted.Start);
        }

        [TestMethod]
        public void ConvertCqlCode_Code()
        {
            var code = new CqlCode { code = "123" };

            var converted = FhirTypeConverter.Convert<Code>(code);

            Assert.IsNotNull(converted);
            Assert.AreEqual("123", converted.Value);
        }

        [TestMethod]
        public void ConvertCqlCodeToFhir_BareCode_WhenOnlyCodePopulated()
        {
            var code = new CqlCode { code = "123" };

            var converted = FhirTypeConverter.ConvertCqlCodeToFhir(code);

            var fhirCode = converted as Code;
            Assert.IsNotNull(fhirCode);
            Assert.AreEqual("123", fhirCode.Value);
        }

        [TestMethod]
        public void ConvertCqlCodeToFhir_Null_WhenNothingPopulated()
        {
            var code = new CqlCode();

            var converted = FhirTypeConverter.ConvertCqlCodeToFhir(code);

            Assert.IsNull(converted);
        }

        [TestMethod]
        public void ConvertCqlCodeToFhir_Null_WhenCodeIsEmptyAndNoMetadata()
        {
            var code = new CqlCode { code = "" };

            var converted = FhirTypeConverter.ConvertCqlCodeToFhir(code);

            Assert.IsNull(converted);
        }

        [TestMethod]
        public void ConvertCqlCodeToFhir_Coding_WhenSystemPopulated()
        {
            var code = new CqlCode("123", "http://example.org", "1.0", "Example display");

            var converted = FhirTypeConverter.ConvertCqlCodeToFhir(code);

            var coding = converted as Coding;
            Assert.IsNotNull(coding);
            Assert.AreEqual("123", coding.Code);
            Assert.AreEqual("http://example.org", coding.System);
            Assert.AreEqual("1.0", coding.Version);
            Assert.AreEqual("Example display", coding.Display);
        }

        [TestMethod]
        public void ConvertCqlCodeToFhir_Coding_WhenOnlyVersionPopulated()
        {
            var code = new CqlCode { code = "123", version = "1.0" };

            var converted = FhirTypeConverter.ConvertCqlCodeToFhir(code);

            var coding = converted as Coding;
            Assert.IsNotNull(coding);
            Assert.AreEqual("123", coding.Code);
            Assert.IsNull(coding.System);
            Assert.AreEqual("1.0", coding.Version);
            Assert.IsNull(coding.Display);
        }

        [TestMethod]
        public void ConvertCqlCodeToFhir_Coding_WhenOnlyDisplayPopulated()
        {
            var code = new CqlCode { code = "123", display = "Example display" };

            var converted = FhirTypeConverter.ConvertCqlCodeToFhir(code);

            var coding = converted as Coding;
            Assert.IsNotNull(coding);
            Assert.AreEqual("123", coding.Code);
            Assert.IsNull(coding.System);
            Assert.IsNull(coding.Version);
            Assert.AreEqual("Example display", coding.Display);
        }

        [TestMethod]
        public void ConvertCode_CqlCode()
        {
            var converted = FhirTypeConverter.Convert<CqlCode>(new Code("123"));

            Assert.IsNotNull(converted);
            Assert.AreEqual("123", converted.code);
            Assert.IsNull(converted.system);
        }

        [TestMethod]
        public void ConvertCoding_CqlCode()
        {
            var coding = new Coding("http://example.org", "123", "Example display") { Version = "1.0" };

            var converted = FhirTypeConverter.Convert<CqlCode>(coding);

            Assert.IsNotNull(converted);
            Assert.AreEqual("123", converted.code);
            Assert.AreEqual("http://example.org", converted.system);
            Assert.AreEqual("1.0", converted.version);
            Assert.AreEqual("Example display", converted.display);
        }

        [TestMethod]
        public void ConvertLong_FhirString()
        {
            var converted = FhirTypeConverter.Convert<FhirString>(42L);

            Assert.IsNotNull(converted);
            Assert.AreEqual("42", converted.Value);
        }

        [TestMethod]
        public void ConvertPeriodToCqlInterval_DateHint_ReturnsIntervalOfCqlDate()
        {
            var period = new Period(new FhirDateTime(2024, 1, 1), new FhirDateTime(2024, 12, 31));

            var converted = FhirTypeConverter.ConvertPeriodToCqlInterval(period, "Date");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<CqlDate>));
        }

        [TestMethod]
        public void ConvertPeriodToCqlInterval_NoHint_ReturnsIntervalOfCqlDateTime()
        {
            var period = new Period(new FhirDateTime(2024, 1, 1), new FhirDateTime(2024, 12, 31));

            var converted = FhirTypeConverter.ConvertPeriodToCqlInterval(period, null);

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<CqlDateTime>));
        }

        [TestMethod]
        public void ConvertPeriodToCqlInterval_WrappedDateHint_ReturnsIntervalOfCqlDate()
        {
            var period = new Period(new FhirDateTime(2024, 1, 1), new FhirDateTime(2024, 12, 31));

            var converted = FhirTypeConverter.ConvertPeriodToCqlInterval(period, "Interval<Date>");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<CqlDate>));
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval()
        {
            // 5000000000 does not fit an Integer, which is what makes the Long reading of a Range necessary.
            var range = new Hl7.Fhir.Model.Range
            {
                Low = new Quantity { Value = 1, Unit = "1" },
                High = new Quantity { Value = 5000000000m, Unit = "1" }
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(converted);
            Assert.AreEqual(1L, converted.low);
            Assert.AreEqual(5000000000L, converted.high);
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval_BoundsAreClosed()
        {
            var range = new Hl7.Fhir.Model.Range
            {
                Low = new Quantity { Value = 1, Unit = "1" },
                High = new Quantity { Value = 10, Unit = "1" }
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(converted);
            Assert.IsTrue(converted.lowClosed);
            Assert.IsTrue(converted.highClosed);
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval_OmitsBoundForAbsentLowBound()
        {
            var range = new Hl7.Fhir.Model.Range { High = new Quantity { Value = 10, Unit = "1" } };

            var converted = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(converted);
            Assert.IsNull(converted.low);
            Assert.AreEqual(10L, converted.high);
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval_OmitsBoundForAbsentHighBound()
        {
            var range = new Hl7.Fhir.Model.Range { Low = new Quantity { Value = 1, Unit = "1" } };

            var converted = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(converted);
            Assert.AreEqual(1L, converted.low);
            Assert.IsNull(converted.high);
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval_OmitsBoundForBoundWithoutValue()
        {
            var range = new Hl7.Fhir.Model.Range { Low = new Quantity { Unit = "1" }, High = new Quantity { Unit = "1" } };

            var converted = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(converted);
            Assert.IsNull(converted.low);
            Assert.IsNull(converted.high);
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval_TruncatesFractionalBoundsTowardsZero()
        {
            // Same semantics as the Integer reading of a Range: the C# decimal->integral conversion
            // rounds towards zero.
            var range = new Hl7.Fhir.Model.Range
            {
                Low = new Quantity { Value = -2.7m, Unit = "1" },
                High = new Quantity { Value = 10.9m, Unit = "1" }
            };

            var convertedLong = FhirTypeConverter.Convert<CqlInterval<long?>>(range);
            var convertedInt = FhirTypeConverter.Convert<CqlInterval<int?>>(range);

            Assert.IsNotNull(convertedLong);
            Assert.AreEqual(-2L, convertedLong.low);
            Assert.AreEqual(10L, convertedLong.high);

            Assert.IsNotNull(convertedInt);
            Assert.AreEqual(-2, convertedInt.low);
            Assert.AreEqual(10, convertedInt.high);
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval_ThrowsForBoundOutsideLongRange()
        {
            // Also the behaviour of the Integer reading for a value outside its range.
            var range = new Hl7.Fhir.Model.Range { Low = new Quantity { Value = 20000000000000000000m, Unit = "1" } };

            Assert.ThrowsExactly<OverflowException>(() => FhirTypeConverter.Convert<CqlInterval<long?>>(range));
        }

        [TestMethod]
        public void Convert_Range_CqlLongInterval_ThrowsForBoundBelowLongRange()
        {
            var range = new Hl7.Fhir.Model.Range { Low = new Quantity { Value = -20000000000000000000m, Unit = "1" } };

            Assert.ThrowsExactly<OverflowException>(() => FhirTypeConverter.Convert<CqlInterval<long?>>(range));
        }

        [TestMethod]
        public void RoundTrip_CqlLongInterval_Range_PreservesBounds()
        {
            var interval = new CqlInterval<long?>(1L, 5000000000L, lowClosed: true, highClosed: true);

            var range = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(interval);
            var roundTripped = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(interval.low, roundTripped.low);
            Assert.AreEqual(interval.high, roundTripped.high);
            Assert.IsTrue(roundTripped.lowClosed);
            Assert.IsTrue(roundTripped.highClosed);
        }

        [TestMethod]
        public void RoundTrip_CqlLongInterval_Range_ReadsBoundsCarryingTheQuantityPrecisionExtension()
        {
            var interval = new CqlInterval<long?>(1L, 10L, lowClosed: true, highClosed: true);

            var range = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(interval);

            Assert.IsNotNull(range);
            Assert.IsNotNull(range.Low.GetExtension(Hl7.Cql.Fhir.FhirTypeConverter.QuantityPrecisionExtensionUrl));
            Assert.IsNotNull(range.High.GetExtension(Hl7.Cql.Fhir.FhirTypeConverter.QuantityPrecisionExtensionUrl));

            var roundTripped = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(1L, roundTripped.low);
            Assert.AreEqual(10L, roundTripped.high);
        }

        [TestMethod]
        public void RoundTrip_CqlLongInterval_Range_ExpressesOpenBoundsAsTheirClosedEquivalent()
        {
            var interval = new CqlInterval<long?>(1L, 10L, lowClosed: false, highClosed: false);

            var range = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(interval);
            var roundTripped = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(2L, roundTripped.low);
            Assert.AreEqual(9L, roundTripped.high);
            Assert.IsTrue(roundTripped.lowClosed);
            Assert.IsTrue(roundTripped.highClosed);
        }

        [TestMethod]
        public void RoundTrip_CqlLongInterval_Range_OmitsAbsentBound()
        {
            var interval = new CqlInterval<long?>(null, 5000000000L, lowClosed: true, highClosed: true);

            var range = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(interval);
            var roundTripped = FhirTypeConverter.Convert<CqlInterval<long?>>(range);

            Assert.IsNotNull(roundTripped);
            Assert.IsNull(roundTripped.low);
            Assert.AreEqual(5000000000L, roundTripped.high);
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_IntegerHint_ReturnsIntervalOfInteger()
        {
            var converted = FhirTypeConverter.ConvertRangeToCqlInterval(UnitlessRange(), "Integer");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<int?>));
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_DecimalHint_ReturnsIntervalOfDecimal()
        {
            var converted = FhirTypeConverter.ConvertRangeToCqlInterval(UnitlessRange(), "Decimal");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<decimal?>));
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_LongHint_ReturnsIntervalOfLong()
        {
            var converted = FhirTypeConverter.ConvertRangeToCqlInterval(UnitlessRange(), "Long");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<long?>));
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_WrappedLongHint_ReturnsIntervalOfLong()
        {
            var converted = FhirTypeConverter.ConvertRangeToCqlInterval(UnitlessRange(), "Interval<Long>");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<long?>));
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_NoHint_ReturnsIntervalOfCqlQuantity()
        {
            var converted = FhirTypeConverter.ConvertRangeToCqlInterval(UnitlessRange(), null);

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<CqlQuantity>));
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_EmptyHint_ReturnsIntervalOfCqlQuantity()
        {
            var converted = FhirTypeConverter.ConvertRangeToCqlInterval(UnitlessRange(), "");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<CqlQuantity>));
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_UnrecognizedHint_ReturnsIntervalOfCqlQuantity()
        {
            var converted = FhirTypeConverter.ConvertRangeToCqlInterval(UnitlessRange(), "Quantity");

            Assert.IsInstanceOfType(converted, typeof(CqlInterval<CqlQuantity>));
        }

        [TestMethod]
        public void ConvertRangeToCqlInterval_NullRange_ReturnsNull()
        {
            Assert.IsNull(FhirTypeConverter.ConvertRangeToCqlInterval(null, "Long"));
            Assert.IsNull(FhirTypeConverter.ConvertRangeToCqlInterval(null, null));
        }

        private static Hl7.Fhir.Model.Range UnitlessRange() =>
            new()
            {
                Low = new Quantity { Value = 1, Unit = "1" },
                High = new Quantity { Value = 10, Unit = "1" }
            };
    }
}
