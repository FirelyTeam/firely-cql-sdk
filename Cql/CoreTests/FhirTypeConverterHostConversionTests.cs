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
    }
}
