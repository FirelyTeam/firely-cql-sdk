/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using static Hl7.Fhir.Model.Parameters;

namespace CoreTests
{
    using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

    [TestClass]
    [TestCategory("UnitTest")]
    public class FhirTypeConverterTests
    {
        internal static readonly TypeConverter FhirTypeConverter = Hl7.Cql.Fhir.FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector);

        [TestMethod]
        public void ConvertParameters_Integer()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Integer(1),
            };

            var converted = FhirTypeConverter.Convert<int?>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]

        public void ConvertParameters_Markdown()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Hl7.Fhir.Model.Markdown("hi")
            };
            var converted = FhirTypeConverter.Convert<string>(parameter);
            Assert.AreEqual(converted,"hi");
        }

        [TestMethod]
        public void ConvertParameters_Instant()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Hl7.Fhir.Model.Instant(new DateTimeOffset(new DateTime(2024, 12, 31, 12, 10, 10))),
            };

            var converted = FhirTypeConverter.Convert<CqlDateTime>(parameter);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlDateTime);

            Assert.AreEqual(2024, converted.Value.Year);
            Assert.AreEqual(12, converted.Value.Month);
            Assert.AreEqual(31, converted.Value.Day);
            Assert.AreEqual(12, converted.Value.Hour);
            Assert.AreEqual(10, converted.Value.Minute);
            Assert.AreEqual(10, converted.Value.Second);
        }

        [TestMethod]
        public void ConvertParameters_FhirUrl()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirUrl("hi"),
            };
            var converted = FhirTypeConverter.Convert<string>(parameter);

            Assert.AreEqual(converted, "hi");
        }

        [TestMethod]
        public void ConvertParameters_Integer_To_UnsignedInt()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Integer(1),
            };
            var converted = FhirTypeConverter.Convert<UnsignedInt>(parameter);
            Assert.AreEqual(1,converted.Value);
        }

        [TestMethod]
        public void ConvertParameters_Integer_To_PositiveInt()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Integer(1),
            };
            var converted = FhirTypeConverter.Convert<PositiveInt>(parameter);
            Assert.AreEqual(1, converted.Value);
        }

        [TestMethod]
        public void ConvertParameters_Code()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Code("hi"),
            };
            var converted = FhirTypeConverter.Convert<string>(parameter);
            Assert.AreEqual("hi", converted);
        }

        [TestMethod]
        public void ConvertParameters_String()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("hi"),
            };

            var converted = FhirTypeConverter.Convert<string>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual("hi", converted);
        }

        [TestMethod]
        public void ConvertParameters_Decimal()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirDecimal(1m),
            };

            var converted = FhirTypeConverter.Convert<decimal?>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual(1m, converted);
        }


        [TestMethod]
        public void ConvertParameters_Boolean()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirBoolean(true),
            };

            var converted = FhirTypeConverter.Convert<bool?>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void ConvertParameters_Date()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Date(new Hl7.Cql.Iso8601.DateIso8601(2022, 01, 01, false).ToString())
            };

            var converted = FhirTypeConverter.Convert<CqlDate>(parameter);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlDate);

            Assert.AreEqual(2022, converted.Value.Year);
            Assert.AreEqual(1, converted.Value.Month);
            Assert.AreEqual(1, converted.Value.Day);
        }


        [Ignore, TestMethod]
        public void ConvertParameters_Date_Macro()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("@Today"),
            };

            var converted = FhirTypeConverter.Convert<CqlDate>(parameter);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlDate);

            Assert.AreEqual(DateTime.Now.Year, converted.Value.Year);
            Assert.AreEqual(DateTime.Now.Month, converted.Value.Month);
            Assert.AreEqual(DateTime.Now.Day, converted.Value.Day);
        }



        [Ignore, TestMethod]
        public void ConvertParameters_Date_MacroAddOperator()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("@Today + 2 day")
            };

            var converted = FhirTypeConverter.Convert<CqlDate>(parameter);

            Assert.IsNotNull(converted);

            var expected = DateTime.Now.AddDays(2);

            Assert.IsTrue(converted is CqlDate);

            Assert.AreEqual(expected.Year, converted.Value.Year);
            Assert.AreEqual(expected.Month, converted.Value.Month);
            Assert.AreEqual(expected.Day, converted.Value.Day);
        }

        [Ignore, TestMethod]
        public void ConvertParameters_Date_MacroSubtractOperator()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("@Today - 2 day"),
            };

            var converted = FhirTypeConverter.Convert<CqlDate>(parameter);

            Assert.IsNotNull(converted);

            var expected = DateTime.Now.AddDays(-2);

            Assert.IsTrue(converted is CqlDate);

            Assert.AreEqual(expected.Year, converted.Value.Year);
            Assert.AreEqual(expected.Month, converted.Value.Month);
            Assert.AreEqual(expected.Day, converted.Value.Day);
        }


        [TestMethod]
        public void ConvertParameters_DateTime()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirDateTime(new Hl7.Cql.Iso8601.DateTimeIso8601(2022, 01, 01, 1, 1, 1, 1, 0, 0, false).ToString())
            };

            var converted = FhirTypeConverter.Convert<CqlDateTime>(parameter);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlDateTime);

            Assert.AreEqual(2022, converted.Value.Year);
            Assert.AreEqual(1, converted.Value.Month);
            Assert.AreEqual(1, converted.Value.Day);
            Assert.AreEqual(1, converted.Value.Hour);
            Assert.AreEqual(1, converted.Value.Minute);
            Assert.AreEqual(1, converted.Value.Second);
            Assert.AreEqual(1, converted.Value.Millisecond);
        }

        [Ignore, TestMethod]
        public void ConvertParameters_DateTime_Macro()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("@Today"),
            };

            var converted = FhirTypeConverter.Convert<CqlDateTime>(parameter);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlDateTime);

            Assert.AreEqual(DateTime.Now.Year, converted.Value.Year);
            Assert.AreEqual(DateTime.Now.Month, converted.Value.Month);
            Assert.AreEqual(DateTime.Now.Day, converted.Value.Day);
        }

        [TestMethod]
        public void ConvertParameters_Time()
        {
            var parameters = new ParameterComponent()
            {
                Name = "param1",
                Value = new Time(new TimeIso8601(1, 1, 1, 1, null, null, false).ToString()),
            };

            var converted = FhirTypeConverter.Convert<CqlTime>(parameters);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Value.Hour);
            Assert.AreEqual(1, converted.Value.Minute);
            Assert.AreEqual(1, converted.Value.Second);
            Assert.AreEqual(1, converted.Value.Millisecond);
        }

        [TestMethod]
        public void ConvertStringToTime_WithTimezoneOffset_StripsTimezone()
        {
            var converted = FhirTypeConverter.Convert<CqlTime?>("T14:30:00.0+05:30");

            Assert.IsNotNull(converted);
            Assert.AreEqual("14:30:00.000", converted.ToString());
            Assert.IsNull(converted.Value.OffsetHour);
            Assert.IsNull(converted.Value.OffsetMinute);
        }

        [TestMethod]
        public void ConvertParameters_Quantity()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Quantity(1, "oranges"),
            };

            var converted = FhirTypeConverter.Convert<CqlQuantity>(parameter);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.value);
            Assert.AreEqual("oranges", converted.unit);
        }

        [Ignore, TestMethod]
        public void ConvertParameters_IntervalDateTime_Period_ExplicitRange()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("2022-01-01 to 2022-03-31")
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<CqlDateTime>>(parameter);

            Assert.IsNotNull(converted);

            Assert.AreEqual(2022, converted.low.Value.Year);
            Assert.AreEqual(1, converted.low.Value.Month);
            Assert.AreEqual(1, converted.low.Value.Day);

            Assert.AreEqual(2022, converted.high.Value.Year);
            Assert.AreEqual(3, converted.high.Value.Month);
            Assert.AreEqual(31, converted.high.Value.Day);

            Assert.AreEqual(true, converted.lowClosed);
            Assert.AreEqual(true, converted.highClosed);
        }

        [Ignore, TestMethod]
        public void ConvertParameters_IntervalDateTime_Period_Marco()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("@ThisYear")
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<CqlDateTime>>(parameter);

            Assert.IsNotNull(converted);


            Assert.AreEqual(DateTime.Now.Year, converted.low.Value.Year);
            Assert.AreEqual(1, converted.low.Value.Month);
            Assert.AreEqual(1, converted.low.Value.Day);

            Assert.AreEqual(DateTime.Now.Year, converted.high.Value.Year);
            Assert.AreEqual(12, converted.high.Value.Month);
            Assert.AreEqual(31, converted.high.Value.Day);

            Assert.AreEqual(true, converted.lowClosed);
            Assert.AreEqual(true, converted.highClosed);
        }


        [Ignore, TestMethod]
        public void ConvertParameters_IntervalDate_Period_ExplicitRange()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("2022-01-01 to 2022-03-31")
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<CqlDate>>(parameter);

            Assert.IsNotNull(converted);


            Assert.AreEqual(2022, converted.low.Value.Year);
            Assert.AreEqual(1, converted.low.Value.Month);
            Assert.AreEqual(1, converted.low.Value.Day);

            Assert.AreEqual(2022, converted.high.Value.Year);
            Assert.AreEqual(3, converted.high.Value.Month);
            Assert.AreEqual(31, converted.high.Value.Day);

            Assert.AreEqual(true, converted.lowClosed);
            Assert.AreEqual(true, converted.highClosed);
        }

        [Ignore, TestMethod]
        public void ConvertParameters_IntervalDate_Period_Marco()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new FhirString("@ThisYear")
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<CqlDate>>(parameter);

            Assert.IsNotNull(converted);


            Assert.AreEqual(DateTime.Now.Year, converted.low.Value.Year);
            Assert.AreEqual(1, converted.low.Value.Month);
            Assert.AreEqual(1, converted.low.Value.Day);

            Assert.AreEqual(DateTime.Now.Year, converted.high.Value.Year);
            Assert.AreEqual(12, converted.high.Value.Month);
            Assert.AreEqual(31, converted.high.Value.Day);

            Assert.AreEqual(true, converted.lowClosed);
            Assert.AreEqual(true, converted.highClosed);
        }

        [TestMethod]
        public void ConvertParameters_IntervalDate_Period()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Period(
                    start: new FhirDateTime(new Hl7.Cql.Iso8601.DateTimeIso8601(2022, 01, 01, 1, 1, 1, 1, 0, 0, false).ToString()),
                    end: new FhirDateTime(new Hl7.Cql.Iso8601.DateTimeIso8601(2022, 3, 31, 1, 1, 1, 1, 0, 0, false).ToString()))
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<CqlDateTime>>(parameter);

            Assert.IsNotNull(converted);


            Assert.AreEqual(2022, converted.low.Value.Year);
            Assert.AreEqual(1, converted.low.Value.Month);
            Assert.AreEqual(1, converted.low.Value.Day);

            Assert.AreEqual(2022, converted.high.Value.Year);
            Assert.AreEqual(3, converted.high.Value.Month);
            Assert.AreEqual(31, converted.high.Value.Day);

            Assert.AreEqual(true, converted.lowClosed);
            Assert.AreEqual(true, converted.highClosed);
        }


        [TestMethod]
        public void ConvertParameters_Interval_Range()
        {
            var parameter = new ParameterComponent()
            {
                Name = "param1",
                Value = new Hl7.Fhir.Model.Range()
                {
                    High = new Quantity(10, "oranges"),
                    Low = new Quantity(1, "oranges"),
                }
            };

            var converted = FhirTypeConverter.Convert<CqlInterval<CqlQuantity>>(parameter);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.low.value);
            Assert.AreEqual(10, converted.high.value);
        }

        [TestMethod]
        public void ConvertCqlDate_FhirDate()
        {
            var date = new CqlDate(2022, 1, 1);
            var converted = FhirTypeConverter.Convert<Date>(date);

            Assert.IsNotNull(converted);

            Assert.IsTrue(DateIso8601.TryParse(converted.Value, out var isoDate));

            Assert.AreEqual(2022, isoDate.Year);
            Assert.AreEqual(1, isoDate.Month);
            Assert.AreEqual(1, isoDate.Day);
        }

        [TestMethod]
        public void ConvertCqlDateTime_FhirDateTime()
        {
            var date = new CqlDateTime(2022, 1, 1, 1, 1, 1, 1, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(date);

            Assert.IsNotNull(converted);

            Assert.IsTrue(DateTimeIso8601.TryParse(converted.Value, out var isoDateTime));


            Assert.AreEqual(2022, isoDateTime.Year);
            Assert.AreEqual(1, isoDateTime.Month);
            Assert.AreEqual(1, isoDateTime.Day);
            Assert.AreEqual(1, isoDateTime.Hour);
            Assert.AreEqual(1, isoDateTime.Minute);
            Assert.AreEqual(1, isoDateTime.Second);
            Assert.AreEqual(1, isoDateTime.Millisecond);
        }

        [TestMethod]
        public void ConvertFhirDateTime_CqlDateTime()
        {
            var date = new FhirDateTime(2022, 1, 1, 1, 1, 1, TimeSpan.Zero);
            var converted = FhirTypeConverter.Convert<CqlDateTime>(date);

            Assert.IsNotNull(converted);
            var isoDateTime = converted.Value;
            Assert.IsNotNull(isoDateTime);

            Assert.AreEqual(2022, isoDateTime.Year);
            Assert.AreEqual(1, isoDateTime.Month);
            Assert.AreEqual(1, isoDateTime.Day);
            Assert.AreEqual(1, isoDateTime.Hour);
            Assert.AreEqual(1, isoDateTime.Minute);
            Assert.AreEqual(1, isoDateTime.Second);

            var nullDateTime = new FhirDateTime(null);
            var nullConverted = FhirTypeConverter.Convert<CqlDateTime>(nullDateTime);
            Assert.IsNull(nullConverted);
        }


        [TestMethod]
        public void ConvertFhirDate_CqlDateTime()
        {
            var date = new Date(2022, 1, 1);
            var converted = FhirTypeConverter.Convert<CqlDateTime>(date);

            Assert.IsNotNull(converted);
            var isoDateTime = converted.Value;
            Assert.IsNotNull(isoDateTime);

            Assert.AreEqual(2022, isoDateTime.Year);
            Assert.AreEqual(1, isoDateTime.Month);
            Assert.AreEqual(1, isoDateTime.Day);
            Assert.AreEqual(0, isoDateTime.Hour);
            Assert.AreEqual(0, isoDateTime.Minute);
            Assert.AreEqual(0, isoDateTime.Second);
        }

        [TestMethod]
        public void ConvertCqlTime_FhirTime()
        {
            var date = new CqlTime(1, 1, 1, 1, null, null);
            var converted = FhirTypeConverter.Convert<Time>(date);

            Assert.IsNotNull(converted);

            Assert.IsTrue(TimeIso8601.TryParse(converted.Value, out var isoTime));

            Assert.AreEqual(1, isoTime.Hour);
            Assert.AreEqual(1, isoTime.Minute);
            Assert.AreEqual(1, isoTime.Second);
            Assert.AreEqual(1, isoTime.Millisecond);
        }

        private const string TimePrecisionExtensionUrl = Hl7.Cql.Fhir.FhirTypeConverter.TimePrecisionExtensionUrl;

        private static string? GetTimePrecisionCode(Element element) =>
            (element.GetExtension(TimePrecisionExtensionUrl)?.Value as Code)?.Value;

        // These helpers use the Firely primitive validators as a real oracle: they enforce the same
        // rules as FHIR validators, and any emission test that would otherwise pin an invalid value
        // will fail here instead.
        private static void AssertIsValidFhirTime(string? value)
        {
            Assert.IsNotNull(value, "Expected a non-null FHIR time value");
            Assert.IsTrue(Time.IsValidValue(value), $"'{value}' is not a valid FHIR time value");
        }

        private static void AssertIsValidFhirDateTime(string? value)
        {
            Assert.IsNotNull(value, "Expected a non-null FHIR dateTime value");
            Assert.IsTrue(FhirDateTime.IsValidValue(value), $"'{value}' is not a valid FHIR dateTime value");
        }

        [TestMethod]
        public void ConvertCqlTime_HourPrecision_PadsAndAddsTimePrecisionExtension()
        {
            var time = new CqlTime(10, null, null, null, null, null);
            var converted = FhirTypeConverter.Convert<Time>(time);

            Assert.IsNotNull(converted);
            AssertIsValidFhirTime(converted.Value);
            Assert.AreEqual("10:00:00", converted.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlTime_MinutePrecision_PadsAndAddsTimePrecisionExtension()
        {
            var time = new CqlTime(10, 30, null, null, null, null);
            var converted = FhirTypeConverter.Convert<Time>(time);

            Assert.IsNotNull(converted);
            AssertIsValidFhirTime(converted.Value);
            Assert.AreEqual("10:30:00", converted.Value);
            Assert.AreEqual("min", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlTime_SecondPrecision_NoTimePrecisionExtension()
        {
            var time = new CqlTime(10, 30, 15, null, null, null);
            var converted = FhirTypeConverter.Convert<Time>(time);

            Assert.IsNotNull(converted);
            AssertIsValidFhirTime(converted.Value);
            Assert.AreEqual("10:30:15", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_HourPrecisionWithoutOffset_PadsAndDefaultsToUtcWithoutRequestOffset()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, null, null, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01T10:00:00Z", converted.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_MinutePrecisionWithoutOffset_PadsAndDefaultsToUtcWithoutRequestOffset()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, 30, null, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01T10:30:00Z", converted.Value);
            Assert.AreEqual("min", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_SecondPrecisionWithoutOffset_DefaultsToUtcWithoutTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, 30, 15, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01T10:30:15Z", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_MillisecondPrecisionWithoutOffset_DefaultsToUtcWithoutTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01T10:30:15.123Z", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_ZeroOffset_RendersZuluOnEveryPath()
        {
            string?[] values = [
                FhirTypeConverter.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, null, null, null, 0, 0))!.Value,
                FhirTypeConverter.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, null, null, 0, 0))!.Value,
                FhirTypeConverter.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, null, 0, 0))!.Value,
                FhirTypeConverter.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, 0, 0))!.Value,
            ];
            foreach (var v in values) AssertIsValidFhirDateTime(v);
            Assert.AreEqual("2014-02-01T10:00:00Z", values[0]);
            Assert.AreEqual("2014-02-01T10:30:00Z", values[1]);
            Assert.AreEqual("2014-02-01T10:30:15Z", values[2]);
            Assert.AreEqual("2014-02-01T10:30:15.123Z", values[3]);
        }

        [TestMethod]
        public void ConvertCqlDateTime_ExplicitOffset_PreservedOnEveryPath()
        {
            string?[] values = [
                FhirTypeConverter.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, null, null, null, -5, 0))!.Value,
                FhirTypeConverter.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, null, 2, 0))!.Value,
                FhirTypeConverter.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, -5, 30))!.Value,
            ];
            foreach (var v in values) AssertIsValidFhirDateTime(v);
            Assert.AreEqual("2014-02-01T10:00:00-05:00", values[0]);
            Assert.AreEqual("2014-02-01T10:30:15+02:00", values[1]);
            Assert.AreEqual("2014-02-01T10:30:15.123-05:30", values[2]);
        }

        [TestMethod]
        public void ConvertCqlDateTime_MinutesOnlyOffset_RendersHourZeroOffsetOnEveryPath()
        {
            // CqlDateTime's component constructor is strict and rejects an offset minute without an
            // offset hour, but its DateTimeIso8601 constructor accepts a non-strict value that pairs
            // them that way; such a 30-minute offset is real and must not be flattened to UTC.
            string?[] values = [
                FhirTypeConverter.Convert<FhirDateTime>(
                    new CqlDateTime(new DateTimeIso8601(2014, 2, 1, 10, 30, null, null, null, 30)))!.Value,
                FhirTypeConverter.Convert<FhirDateTime>(
                    new CqlDateTime(new DateTimeIso8601(2014, 2, 1, 10, 30, 15, null, null, 30)))!.Value,
                FhirTypeConverter.Convert<FhirDateTime>(
                    new CqlDateTime(new DateTimeIso8601(2014, 2, 1, 10, 30, 15, 123, null, -30)))!.Value,
            ];
            foreach (var v in values) AssertIsValidFhirDateTime(v);
            Assert.AreEqual("2014-02-01T10:30:00+00:30", values[0]);
            Assert.AreEqual("2014-02-01T10:30:15+00:30", values[1]);
            Assert.AreEqual("2014-02-01T10:30:15.123-00:30", values[2]);
        }

        [TestMethod]
        public void ConvertCqlDateTime_MinutePrecisionWithOffset_PadsAndAddsTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, 30, null, null, 1, 30);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01T10:30:00+01:30", converted.Value);
            Assert.AreEqual("min", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_HourPrecisionUtc_PadsAndAddsTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, null, null, null, 0, 0);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01T10:00:00Z", converted.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_DayPrecision_UnchangedWithoutTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, null, null, null, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_DayPrecisionWithOffset_StaysOffsetFree()
        {
            // A day-precision CqlDateTime carrying an offset is unusual but constructible; FHIR forbids
            // an offset without a time component, so the output must stay offset-free.
            var dateTime = new CqlDateTime(new DateTimeIso8601(2014, 2, 1, null, null, null, null, 2, 0));
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_YearPrecision_UnchangedWithoutTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, null, null, null, null, null, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDate_FhirDateTime_StaysOffsetFree()
        {
            // FHIR forbids a timezone offset on a dateTime without a time component.
            var converted = FhirTypeConverter.Convert<FhirDateTime>(new CqlDate(2014, 2, 1));

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void RoundTripCqlDateTime_FhirDateTime_RestoresPrecisionAndAcquiresTheDefaultOffset()
        {
            // FHIR cannot express "no offset" on a time-bearing dateTime, so an offset-less CQL value
            // comes back as UTC; the time-precision extension still restores its original precision.
            var dateTime = new CqlDateTime(2014, 2, 1, 10, 30, null, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Value);
            Assert.AreEqual("2014-02-01T10:30:00Z", converted.Value);

            var roundTripped = FhirTypeConverter.Convert<CqlDateTime>(converted);

            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(DateTimePrecision.Minute, roundTripped.Precision);
            Assert.AreEqual(10, roundTripped.Value.Hour);
            Assert.AreEqual(30, roundTripped.Value.Minute);
            Assert.IsNull(roundTripped.Value.Second);
            Assert.AreEqual(0, roundTripped.Value.OffsetHour);
            Assert.AreEqual(0, roundTripped.Value.OffsetMinute);
            Assert.AreEqual("2014-02-01T10:30Z", roundTripped.ToString());
        }

        [TestMethod]
        public void ConvertFhirTime_TimePrecisionExtension_RestoresPartialPrecision()
        {
            var fhirTime = new Time("10:00:00");
            fhirTime.AddExtension(TimePrecisionExtensionUrl, new Code("h"));
            var converted = FhirTypeConverter.Convert<CqlTime>(fhirTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual(DateTimePrecision.Hour, converted.Precision);
            Assert.AreEqual(10, converted.Value.Hour);
            Assert.IsNull(converted.Value.Minute);

            fhirTime = new Time("10:30:00");
            fhirTime.AddExtension(TimePrecisionExtensionUrl, new Code("min"));
            converted = FhirTypeConverter.Convert<CqlTime>(fhirTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual(DateTimePrecision.Minute, converted.Precision);
            Assert.AreEqual(30, converted.Value.Minute);
            Assert.IsNull(converted.Value.Second);
        }

        [TestMethod]
        public void ConvertFhirTime_SecondAndMillisecondPrecisionCodes_Honored()
        {
            // "s" marks padded milliseconds; "ms" declares the value complete.
            var fhirTime = new Time("10:30:15.123");
            fhirTime.AddExtension(TimePrecisionExtensionUrl, new Code("s"));
            var converted = FhirTypeConverter.Convert<CqlTime>(fhirTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual(DateTimePrecision.Second, converted.Precision);
            Assert.AreEqual(15, converted.Value.Second);
            Assert.IsNull(converted.Value.Millisecond);

            fhirTime = new Time("10:30:15.123");
            fhirTime.AddExtension(TimePrecisionExtensionUrl, new Code("ms"));
            converted = FhirTypeConverter.Convert<CqlTime>(fhirTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual(DateTimePrecision.Millisecond, converted.Precision);
            Assert.AreEqual(123, converted.Value.Millisecond);
        }

        [TestMethod]
        public void ConvertFhirDateTime_TimePrecisionExtension_RestoresPartialPrecision()
        {
            var fhirDateTime = new FhirDateTime("2014-02-01T10:00:00Z");
            fhirDateTime.AddExtension(TimePrecisionExtensionUrl, new Code("h"));
            var converted = FhirTypeConverter.Convert<CqlDateTime>(fhirDateTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual(DateTimePrecision.Hour, converted.Precision);
            Assert.AreEqual(10, converted.Value.Hour);
            Assert.IsNull(converted.Value.Minute);
            Assert.AreEqual(0, converted.Value.OffsetHour);
        }

        [TestMethod]
        public void ConvertFhirDateTime_TimePrecisionExtension_DoesNotAffectUnadornedValues()
        {
            var converter = Hl7.Cql.Fhir.FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector);

            var adorned = new FhirDateTime("2014-02-01T10:00:00Z");
            adorned.AddExtension(TimePrecisionExtensionUrl, new Code("h"));
            var partial = converter.Convert<CqlDateTime>(adorned);
            Assert.AreEqual(DateTimePrecision.Hour, partial!.Precision);

            // The precision the extension declares belongs to the value carrying it: the same lexical
            // value without the extension keeps its full precision, and vice versa.
            var unadorned = new FhirDateTime("2014-02-01T10:00:00Z");
            var full = converter.Convert<CqlDateTime>(unadorned);
            Assert.AreEqual(DateTimePrecision.Second, full!.Precision);

            partial = converter.Convert<CqlDateTime>(adorned);
            Assert.AreEqual(DateTimePrecision.Hour, partial!.Precision);
        }

        [TestMethod]
        public void ConvertCqlDateTimeInterval_PartialPrecisionBounds_PadsPeriodWithTimePrecisionExtension()
        {
            var interval = new CqlInterval<CqlDateTime>(
                new CqlDateTime(2014, 2, 1, 10, null, null, null, null, null),
                new CqlDateTime(2014, 2, 1, 12, 30, null, null, null, null),
                lowClosed: true, highClosed: true);
            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("2014-02-01T10:00:00Z", converted.Start);
            Assert.AreEqual("h", GetTimePrecisionCode(converted.StartElement));
            Assert.AreEqual("2014-02-01T12:30:00Z", converted.End);
            Assert.AreEqual("min", GetTimePrecisionCode(converted.EndElement));
        }

        [TestMethod]
        public void ConvertCqlDateTimeInterval_Period_AppliesTheOffsetRuleToBothBoundaries()
        {
            var interval = new CqlInterval<CqlDateTime>(
                new CqlDateTime(2014, 2, 1, 10, 30, 15, null, null, null),
                new CqlDateTime(2014, 2, 1, 12, 30, 15, null, -5, 0),
                lowClosed: true, highClosed: true);
            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("2014-02-01T10:30:15Z", converted.Start);
            Assert.AreEqual("2014-02-01T12:30:15-05:00", converted.End);
        }

        [TestMethod]
        public void ConvertCqlTimeInterval_PartialPrecisionBounds_PadsPeriodWithTimePrecisionExtension()
        {
            var interval = new CqlInterval<CqlTime>(
                new CqlTime(10, null, null, null, null, null),
                new CqlTime(12, 30, null, null, null, null),
                lowClosed: true, highClosed: true);
            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("0001-01-01T10:00:00Z", converted.Start);
            Assert.AreEqual("h", GetTimePrecisionCode(converted.StartElement));
            Assert.AreEqual("0001-01-01T12:30:00Z", converted.End);
            Assert.AreEqual("min", GetTimePrecisionCode(converted.EndElement));
        }

        [TestMethod]
        public void ConvertCqlTimeInterval_Period_RendersZeroOffsetAsZulu()
        {
            var interval = new CqlInterval<CqlTime>(
                new CqlTime(10, null, null, null, 0, 0),
                new CqlTime(12, 30, 15, null, 0, 0),
                lowClosed: true, highClosed: true);
            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.AreEqual("0001-01-01T10:00:00Z", converted.Start);
            Assert.AreEqual("0001-01-01T12:30:15Z", converted.End);
        }

        // The offset a converter applies to an offset-less CQL value is the evaluation request's; these
        // tests build one directly with a non-zero offset, which is what FhirCqlContext threads in from
        // the 'now' argument.
        private static readonly TypeConverter ConverterWithPlusTwo =
            Hl7.Cql.Fhir.FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector, TimeSpan.FromHours(2));

        private static readonly TypeConverter ConverterWithMinusFive =
            Hl7.Cql.Fhir.FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector, TimeSpan.FromHours(-5));

        private static readonly TypeConverter ConverterWithMinusFiveThirty =
            Hl7.Cql.Fhir.FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector, TimeSpan.FromHours(-5.5));

        [TestMethod]
        public void ConvertCqlDateTime_WithoutOffset_TakesTheDefaultTimezoneOffsetOnEveryPath()
        {
            var hour = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, null, null, null, null, null))!;
            var minute = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, null, null, null, null))!;
            var second = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, null, null, null))!;
            var millisecond = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, null, null))!;

            foreach (var v in new[] { hour, minute, second, millisecond }) AssertIsValidFhirDateTime(v.Value);
            Assert.AreEqual("2014-02-01T10:00:00+02:00", hour.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(hour));
            Assert.AreEqual("2014-02-01T10:30:00+02:00", minute.Value);
            Assert.AreEqual("min", GetTimePrecisionCode(minute));
            Assert.AreEqual("2014-02-01T10:30:15+02:00", second.Value);
            Assert.IsNull(GetTimePrecisionCode(second));
            Assert.AreEqual("2014-02-01T10:30:15.123+02:00", millisecond.Value);
            Assert.IsNull(GetTimePrecisionCode(millisecond));
        }

        [TestMethod]
        public void ConvertCqlDateTime_ExplicitOffset_WinsOverTheDefaultTimezoneOffset()
        {
            string[] values = [
                ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, null, null, null, -5, 0))!.Value,
                ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, null, -5, 0))!.Value,
                // A zero offset is an explicit offset, and still renders as 'Z' under a non-zero default.
                ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, null, null, null, 0, 0))!.Value,
                ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, 0, 0))!.Value,
            ];
            foreach (var v in values) AssertIsValidFhirDateTime(v);
            Assert.AreEqual("2014-02-01T10:00:00-05:00", values[0]);
            Assert.AreEqual("2014-02-01T10:30:15-05:00", values[1]);
            Assert.AreEqual("2014-02-01T10:00:00Z", values[2]);
            Assert.AreEqual("2014-02-01T10:30:15.123Z", values[3]);
        }

        [TestMethod]
        public void ConvertCqlDateTime_NegativeHalfHourDefault_RendersTheSignedOffset()
        {
            string[] values = [
                ConverterWithMinusFiveThirty.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, null, null, null, null, null))!.Value,
                ConverterWithMinusFiveThirty.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, null, null))!.Value,
            ];
            foreach (var v in values) AssertIsValidFhirDateTime(v);
            Assert.AreEqual("2014-02-01T10:00:00-05:30", values[0]);
            Assert.AreEqual("2014-02-01T10:30:15.123-05:30", values[1]);
        }

        [TestMethod]
        public void ConvertCqlDateTime_DateOnly_StaysOffsetFreeUnderADefaultTimezoneOffset()
        {
            // FHIR forbids an offset on a dateTime without a time component, whatever the default is.
            var dayPrecision = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(2014, 2, 1, null, null, null, null, null, null))!;
            var fromCqlDate = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDate(2014, 2, 1))!;
            var asFhirDate = ConverterWithPlusTwo.Convert<Date>(new CqlDate(2014, 2, 1))!;

            AssertIsValidFhirDateTime(dayPrecision.Value);
            AssertIsValidFhirDateTime(fromCqlDate.Value);
            Assert.AreEqual("2014-02-01", dayPrecision.Value);
            Assert.AreEqual("2014-02-01", fromCqlDate.Value);
            Assert.AreEqual("2014-02-01", asFhirDate.Value);
        }

        [TestMethod]
        public void ConvertCqlTime_Time_HasNoOffsetUnderADefaultTimezoneOffset()
        {
            // FHIR time SHALL NOT carry a timezone offset, so the default must not leak into it.
            string[] values = [
                ConverterWithPlusTwo.Convert<Time>(new CqlTime(10, null, null, null, null, null))!.Value,
                ConverterWithPlusTwo.Convert<Time>(new CqlTime(10, 30, null, null, null, null))!.Value,
                ConverterWithPlusTwo.Convert<Time>(new CqlTime(10, 30, 15, null, null, null))!.Value,
                ConverterWithPlusTwo.Convert<Time>(new CqlTime(10, 30, 15, 123, null, null))!.Value,
            ];
            foreach (var v in values) AssertIsValidFhirTime(v);
            Assert.AreEqual("10:00:00", values[0]);
            Assert.AreEqual("10:30:00", values[1]);
            Assert.AreEqual("10:30:15", values[2]);
            Assert.AreEqual("10:30:15.123", values[3]);
        }

        [TestMethod]
        public void ConvertCqlDateTimeInterval_Period_AppliesTheDefaultTimezoneOffsetToBothBoundaries()
        {
            var interval = new CqlInterval<CqlDateTime>(
                new CqlDateTime(2014, 2, 1, 10, null, null, null, null, null),
                new CqlDateTime(2014, 2, 1, 12, 30, 15, null, null, null),
                lowClosed: true, highClosed: true);
            var converted = ConverterWithPlusTwo.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Start);
            AssertIsValidFhirDateTime(converted.End);
            Assert.AreEqual("2014-02-01T10:00:00+02:00", converted.Start);
            Assert.AreEqual("h", GetTimePrecisionCode(converted.StartElement));
            Assert.AreEqual("2014-02-01T12:30:15+02:00", converted.End);
        }

        [TestMethod]
        public void ConvertCqlTimeInterval_Period_AnchorsOffsetLessBoundariesInUtcUnderADefaultTimezoneOffset()
        {
            // A Time has no timezone to default, and the 0001-01-01 anchor leaves no room below it, so
            // the boundaries stay UTC however the converter's default is set.
            var interval = new CqlInterval<CqlTime>(
                new CqlTime(10, null, null, null, null, null),
                new CqlTime(12, 30, 15, 123, null, null),
                lowClosed: true, highClosed: true);
            var converted = ConverterWithPlusTwo.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Start);
            AssertIsValidFhirDateTime(converted.End);
            Assert.AreEqual("0001-01-01T10:00:00Z", converted.Start);
            Assert.AreEqual("h", GetTimePrecisionCode(converted.StartElement));
            Assert.AreEqual("0001-01-01T12:30:15.123Z", converted.End);
        }

        [TestMethod]
        public void ConvertCqlTimeInterval_Period_BoundariesBelowThePositiveDefault_StayReadable()
        {
            // A time of day earlier than a positive default would denote an instant before year 1 if the
            // default were applied to the anchor date, which is neither valid FHIR nor readable back.
            var interval = new CqlInterval<CqlTime>(
                new CqlTime(0, 0, 0, null, null, null),
                new CqlTime(1, 30, 0, null, null, null),
                lowClosed: true, highClosed: true);
            var converted = ConverterWithPlusTwo.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Start);
            AssertIsValidFhirDateTime(converted.End);
            Assert.AreEqual("0001-01-01T00:00:00Z", converted.Start);
            Assert.AreEqual("0001-01-01T01:30:00Z", converted.End);

            Assert.IsNotNull(ConverterWithPlusTwo.Convert<CqlDateTime>(converted.StartElement));
            Assert.IsNotNull(ConverterWithPlusTwo.Convert<CqlDateTime>(converted.EndElement));
        }

        [TestMethod]
        public void ConvertCqlTimeInterval_Period_DropsVestigialBoundaryOffsets()
        {
            // CqlTime has no timezone concept; vestigial offsets are always dropped regardless of the
            // default — all anchored dateTime boundaries carry Z.
            var interval = new CqlInterval<CqlTime>(
                new CqlTime(10, 30, 15, null, 5, 0),
                new CqlTime(12, 30, 15, null, 0, 0),
                lowClosed: true, highClosed: true);
            var converted = ConverterWithPlusTwo.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            AssertIsValidFhirDateTime(converted.Start);
            AssertIsValidFhirDateTime(converted.End);
            Assert.AreEqual("0001-01-01T10:30:15Z", converted.Start);
            Assert.AreEqual("0001-01-01T12:30:15Z", converted.End);

            // A minutes-only offset is also a vestigial offset and is dropped.
            var minutesOnly = new CqlInterval<CqlTime>(
                new CqlTime(new TimeIso8601(10, 30, 15, null, null, 30)),
                new CqlTime(new TimeIso8601(12, 30, null, null, null, 30)),
                lowClosed: true, highClosed: true);
            var convertedMinutesOnly = ConverterWithPlusTwo.Convert<Period>(minutesOnly);

            Assert.IsNotNull(convertedMinutesOnly);
            AssertIsValidFhirDateTime(convertedMinutesOnly.Start);
            AssertIsValidFhirDateTime(convertedMinutesOnly.End);
            Assert.AreEqual("0001-01-01T10:30:15Z", convertedMinutesOnly.Start);
            Assert.AreEqual("0001-01-01T12:30:00Z", convertedMinutesOnly.End);
            Assert.AreEqual("min", GetTimePrecisionCode(convertedMinutesOnly.EndElement));
        }

        [TestMethod]
        public void ConvertCqlDateTime_AtTheStartOfTheRepresentableRange_KeepsUtc()
        {
            // 0001-01-01T00:30:00+02:00 denotes an instant before year 1, so the default cannot apply;
            // 0001-01-01T02:30:00+02:00 is exactly at the boundary and can.
            var second = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(1, 1, 1, 0, 30, 0, null, null, null))!;
            var padded = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(1, 1, 1, 0, null, null, null, null, null))!;
            var atTheBoundary = ConverterWithPlusTwo.Convert<FhirDateTime>(new CqlDateTime(1, 1, 1, 2, 30, 0, null, null, null))!;

            foreach (var v in new[] { second, padded, atTheBoundary }) AssertIsValidFhirDateTime(v.Value);
            Assert.AreEqual("0001-01-01T00:30:00Z", second.Value);
            Assert.AreEqual("0001-01-01T00:00:00Z", padded.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(padded));
            Assert.AreEqual("0001-01-01T02:30:00+02:00", atTheBoundary.Value);
        }

        [TestMethod]
        public void ConvertCqlDateTime_AtTheEndOfTheRepresentableRange_KeepsUtc()
        {
            // 9999-12-31T23:30:00-05:00 denotes an instant past year 9999, so the default cannot apply;
            // 9999-12-31T18:00:00-05:00 still lands inside the last day and can.
            var second = ConverterWithMinusFive.Convert<FhirDateTime>(new CqlDateTime(9999, 12, 31, 23, 30, 0, null, null, null))!;
            var padded = ConverterWithMinusFive.Convert<FhirDateTime>(new CqlDateTime(9999, 12, 31, 23, 30, null, null, null, null))!;
            var insideTheRange = ConverterWithMinusFive.Convert<FhirDateTime>(new CqlDateTime(9999, 12, 31, 18, 0, 0, null, null, null))!;

            foreach (var v in new[] { second, padded, insideTheRange }) AssertIsValidFhirDateTime(v.Value);
            Assert.AreEqual("9999-12-31T23:30:00Z", second.Value);
            Assert.AreEqual("9999-12-31T23:30:00Z", padded.Value);
            Assert.AreEqual("min", GetTimePrecisionCode(padded));
            Assert.AreEqual("9999-12-31T18:00:00-05:00", insideTheRange.Value);
        }

        [TestMethod]
        public void CreateWithDefaultTimezoneOffset_SubMinuteOrOutOfRange_Throws()
        {
            var model = Hl7.Fhir.Model.ModelInfo.ModelInspector;
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromSeconds(90)));
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromMilliseconds(1)));
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(15)));
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(-15)));
            // ±14:00 is the widest offset FHIR admits, and is accepted.
            Assert.IsNotNull(Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(14)));
            Assert.IsNotNull(Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(-14)));
        }

        [TestMethod]
        public void CreateWithDefaultTimezoneOffset_ReusesConvertersPerOffset()
        {
            var model = Hl7.Fhir.Model.ModelInfo.ModelInspector;

            // A zero offset renders exactly like no default at all, so it must not cost a second converter.
            Assert.AreSame(
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model),
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.Zero));
            Assert.AreSame(
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model, null),
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model));

            Assert.AreSame(
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(2)),
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(2)));

            Assert.AreNotSame(
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(2)),
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(3)));
            Assert.AreNotSame(
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model),
                Hl7.Cql.Fhir.FhirTypeConverter.Create(model, TimeSpan.FromHours(2)));
        }

        [TestMethod]
        public void CreateWithDefaultTimezoneOffset_DefaultModel_SurvivesAFullGarbageCollection()
        {
            // A converter over the default model is rooted, so a service building a context per request
            // on a host that is not on UTC does not rebuild it after every generation-2 collection.
            var weakRef = CreateConverterWithoutRooting(TimeSpan.FromHours(2));

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Assert.IsTrue(weakRef.TryGetTarget(out var survivor), "the converter was not held across a full GC");
            Assert.AreSame(survivor, Hl7.Cql.Fhir.FhirTypeConverter.Create(
                Hl7.Fhir.Model.ModelInfo.ModelInspector,
                TimeSpan.FromHours(2)));
        }

        // The converter must not be rooted by the calling frame, or the assertion above would hold for a
        // purely weak cache too.
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static WeakReference<TypeConverter> CreateConverterWithoutRooting(TimeSpan offset) =>
            new(Hl7.Cql.Fhir.FhirTypeConverter.Create(
                Hl7.Fhir.Model.ModelInfo.ModelInspector,
                offset));


        [TestMethod]
        public void ConvertCqlQuantity_Quantity()
        {
            var quantity = new CqlQuantity(1, "oranges");
            var converted = FhirTypeConverter.Convert<Quantity>(quantity);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Value);
            Assert.AreEqual("oranges", converted.Unit);
        }

        [TestMethod]
        public void ConvertQuantity_Int()
        {
            var quantity = new Quantity(1, "oranges");
            var converted = FhirTypeConverter.Convert<int?>(quantity);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Value);
        }

        [TestMethod]
        public void ConvertQuantity_Decimal()
        {
            var quantity = new Quantity(1, "oranges");
            var converted = FhirTypeConverter.Convert<decimal?>(quantity);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Value);
        }

        [TestMethod]
        public void ConvertCqlQuantityInterval_Range()
        {
            var quantityInterval = new CqlInterval<CqlQuantity>(
                new CqlQuantity(1, "oranges"),
                new CqlQuantity(10, "oranges"),
                true, true);
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Low.Value);
            Assert.AreEqual("oranges", converted.Low.Unit);

            Assert.AreEqual(10, converted.High.Value);
            Assert.AreEqual("oranges", converted.High.Unit);
        }

        [TestMethod]
        public void ConvertCqlDecimalInterval_Range()
        {
            var quantityInterval = new CqlInterval<decimal?>(
                1, 10, true, true
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Low.Value);
            Assert.AreEqual("1", converted.Low.Unit);
            Assert.AreEqual(Hl7.Fhir.ElementModel.Types.Quantity.UCUM, converted.Low.System);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(10, converted.High.Value);
            Assert.AreEqual("1", converted.High.Unit);
            Assert.AreEqual(Hl7.Fhir.ElementModel.Types.Quantity.UCUM, converted.High.System);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlDecimalInterval_Range_KeepsPrecisionOfClosedBounds()
        {
            var decimalInterval = new CqlInterval<decimal?>(
                1.0m, 10.000m, true, true
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(decimalInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1.0m, converted.Low.Value);
            Assert.AreEqual(1, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(10.000m, converted.High.Value);
            Assert.AreEqual(3, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlDecimalInterval_Range_ConvertsOpenBoundsToClosed()
        {
            // Interval[1.0, 10.0] except Interval[4.0, 10.0] evaluates to Interval[1.0, 4.0), which FHIR - whose
            // Range bounds are always inclusive - has to express as [1.0, 3.99999999].
            var decimalInterval = new CqlInterval<decimal?>(
                1.0m, 4.0m, true, false
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(decimalInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1.0m, converted.Low.Value);
            Assert.AreEqual(1, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(3.99999999m, converted.High.Value);
            Assert.AreEqual(8, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlDecimalInterval_Range_ConvertsOpenLowBoundToClosed()
        {
            // Open low bound: successor of 1.05 is 1.05 + MinDecimalPrecisionValue = 1.05000001.
            var decimalInterval = new CqlInterval<decimal?>(
                1.05m, 4.0m, false, true
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(decimalInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1.05000001m, converted.Low.Value);
            Assert.AreEqual(8, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(4.0m, converted.High.Value);
            Assert.AreEqual(1, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlIntInterval_Range()
        {
            var quantityInterval = new CqlInterval<int?>(
                1, 10, true, true
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Low.Value);
            Assert.AreEqual("1", converted.Low.Unit);
            Assert.AreEqual(Hl7.Fhir.ElementModel.Types.Quantity.UCUM, converted.Low.System);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(10, converted.High.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlIntInterval_Range_ConvertsOpenBoundsToClosed()
        {
            var intInterval = new CqlInterval<int?>(
                1, 10, false, false
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(intInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(2, converted.Low.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(9, converted.High.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlIntInterval_Range_OmitsBoundForNullLowEndpoint()
        {
            var intInterval = new CqlInterval<int?>(null, 10, false, true);
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(intInterval);

            Assert.IsNotNull(converted);

            Assert.IsNull(converted.Low);
            Assert.AreEqual(10, converted.High.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlIntInterval_Range_OmitsBoundForNullHighEndpoint()
        {
            var intInterval = new CqlInterval<int?>(1, null, true, false);
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(intInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Low.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.Low));
            Assert.IsNull(converted.High);
        }

        [TestMethod]
        public void ConvertCqlLongInterval_Range()
        {
            var longInterval = new CqlInterval<long?>(
                1L, 10L, true, true
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(longInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Low.Value);
            Assert.AreEqual("1", converted.Low.Unit);
            Assert.AreEqual(Hl7.Fhir.ElementModel.Types.Quantity.UCUM, converted.Low.System);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(10, converted.High.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlLongInterval_Range_ConvertsOpenBoundsToClosed()
        {
            var longInterval = new CqlInterval<long?>(
                1L, 10L, false, false
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(longInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(2, converted.Low.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(9, converted.High.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlLongInterval_Range_OmitsBoundForNullLowEndpoint()
        {
            var longInterval = new CqlInterval<long?>(null, 10L, false, true);
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(longInterval);

            Assert.IsNotNull(converted);

            Assert.IsNull(converted.Low);
            Assert.AreEqual(10, converted.High.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.High));
        }

        [TestMethod]
        public void ConvertCqlLongInterval_Range_OmitsBoundForNullHighEndpoint()
        {
            var longInterval = new CqlInterval<long?>(1L, null, true, false);
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(longInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Low.Value);
            Assert.AreEqual(0, QuantityPrecisionOf(converted.Low));
            Assert.IsNull(converted.High);
        }

        [TestMethod]
        public void ConvertCqlInterval_Range_OmitsBoundsForNullEndpoints()
        {
            var decimalInterval = new CqlInterval<decimal?>(
                null, 4.0m, false, false
            );
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(decimalInterval);

            Assert.IsNotNull(converted);

            Assert.IsNull(converted.Low);
            Assert.AreEqual(3.99999999m, converted.High.Value);
        }

        [TestMethod]
        public void ConvertCqlInterval_Range_OmitsBoundForNullHighEndpoint()
        {
            var decimalInterval = new CqlInterval<decimal?>(1.0m, null, true, false);
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(decimalInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1.0m, converted.Low.Value);
            Assert.AreEqual(1, QuantityPrecisionOf(converted.Low));
            Assert.IsNull(converted.High);
        }

        [TestMethod]
        public void ConvertCqlInterval_Range_BothBoundsNull_ReturnsEmptyRange()
        {
            var decimalInterval = new CqlInterval<decimal?>(null, null, false, false);
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(decimalInterval);

            Assert.IsNotNull(converted);
            Assert.IsNull(converted.Low);
            Assert.IsNull(converted.High);
        }

        [TestMethod]
        public void ConvertNullCqlDecimalInterval_Range_ReturnsNull()
        {
            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>((CqlInterval<decimal?>)null!);
            Assert.IsNull(converted);
        }

        [TestMethod]
        public void ConvertCqlDecimalInterval_Range_DecimalIntervalExcept1to3()
        {
            // The official CQL test suite's CqlIntervalOperatorsTest / DecimalIntervalExcept1to3:
            // Interval[1.0, 10.0] except Interval[4.0, 10.0] is expected to be Interval[1.0, 3.99999999].
            var operators = Hl7.Cql.Fhir.FhirCqlContext.WithDataSource().Operators;
            var result = operators.Except(
                new CqlInterval<decimal?>(1.0m, 10.0m, true, true),
                new CqlInterval<decimal?>(4.0m, 10.0m, true, true));

            var converted = FhirTypeConverter.Convert<Hl7.Fhir.Model.Range>(result);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1.0m, converted.Low.Value);
            Assert.AreEqual(1, QuantityPrecisionOf(converted.Low));
            Assert.AreEqual(3.99999999m, converted.High.Value);
            Assert.AreEqual(8, QuantityPrecisionOf(converted.High));
        }

        private static int? QuantityPrecisionOf(Quantity quantity) =>
            (quantity.GetExtension(Hl7.Cql.Fhir.FhirTypeConverter.QuantityPrecisionExtensionUrl)?.Value as Integer)?.Value;

        [TestMethod]
        public void Convert_Range_CqlIntInterval()
        {
            var range = new Hl7.Fhir.Model.Range() { Low = new Quantity { Value = 1, Unit = "a"}, High = new Quantity { Value = 10, Unit = "a" } };
            var converted = FhirTypeConverter.Convert<CqlInterval<int?>>(range);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.low.Value);
            Assert.AreEqual(10, converted.high.Value);
        }

        [TestMethod]
        public void Convert_Range_CqlDecimalInterval()
        {
            var range = new Hl7.Fhir.Model.Range() { Low = new Quantity { Value = 1, Unit = "a" }, High = new Quantity { Value = 10, Unit = "a" } };
            var converted = FhirTypeConverter.Convert<CqlInterval<decimal?>>(range);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.low.Value);
            Assert.AreEqual(10, converted.high.Value);
        }


        [TestMethod]
        public void ConvertCqlRatio_Ratio()
        {
            var quantityInterval = new CqlRatio(
                new CqlQuantity(1, "widgets"),
                new CqlQuantity(10, "widgets"));
            var converted = FhirTypeConverter.Convert<Ratio>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.Numerator.Value);
            Assert.AreEqual("widgets", converted.Numerator.Unit);

            Assert.AreEqual(10, converted.Denominator.Value);
            Assert.AreEqual("widgets", converted.Denominator.Unit);
        }


        [TestMethod]
        public void ConvertCqlCode_Coding()
        {
            var code = new CqlCode("123", "http://example.org", "1.0", "Example display");
            var converted = FhirTypeConverter.Convert<Coding>(code);

            Assert.IsNotNull(converted);
            Assert.AreEqual("123", converted.Code);
            Assert.AreEqual("http://example.org", converted.System);
            Assert.AreEqual("1.0", converted.Version);
            Assert.AreEqual("Example display", converted.Display);
        }

        [TestMethod]
        public void ConvertCqlConcept_CodeableConcept()
        {
            var concept = new CqlConcept(
                [
                    new CqlCode("123", "http://example.org", "1.0", "First"),
                    new CqlCode("456", "http://example.org", "1.0", "Second"),
                ],
                "Concept display");
            var converted = FhirTypeConverter.Convert<CodeableConcept>(concept);

            Assert.IsNotNull(converted);
            Assert.AreEqual("Concept display", converted.Text);
            Assert.AreEqual(2, converted.Coding.Count);
            Assert.AreEqual("123", converted.Coding[0].Code);
            Assert.AreEqual("http://example.org", converted.Coding[0].System);
            Assert.AreEqual("First", converted.Coding[0].Display);
            Assert.AreEqual("456", converted.Coding[1].Code);
            Assert.AreEqual("Second", converted.Coding[1].Display);
        }

        [TestMethod]
        public void ConvertCqlConcept_CodeableConcept_NullCodes()
        {
            var concept = new CqlConcept(null, "Concept display");
            var converted = FhirTypeConverter.Convert<CodeableConcept>(concept);

            Assert.IsNotNull(converted);
            Assert.AreEqual("Concept display", converted.Text);
            Assert.IsNotNull(converted.Coding);
            Assert.AreEqual(0, converted.Coding.Count);
        }


        [TestMethod]
        public void ConvertCqlIntervalDateTime_Period()
        {
            var interval = new CqlInterval<CqlDateTime>(
                new CqlDateTime(2022, 01, 01, 1, 1, 1, 1, 0, 0),
                new CqlDateTime(2022, 3, 31, 1, 1, 1, 1, 0, 0),
                true, true
            );
            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.IsTrue(DateTimeIso8601.TryParse(converted.Start, out var start));
            Assert.IsTrue(DateTimeIso8601.TryParse(converted.End, out var end));


            Assert.AreEqual(2022, start.Year);
            Assert.AreEqual(1, start.Month);
            Assert.AreEqual(1, start.Day);
            Assert.AreEqual(1, start.Hour);
            Assert.AreEqual(1, start.Minute);
            Assert.AreEqual(1, start.Second);
            Assert.AreEqual(1, start.Millisecond);

            Assert.AreEqual(2022, end.Year);
            Assert.AreEqual(3, end.Month);
            Assert.AreEqual(31, end.Day);
            Assert.AreEqual(1, end.Hour);
            Assert.AreEqual(1, end.Minute);
            Assert.AreEqual(1, end.Second);
            Assert.AreEqual(1, end.Millisecond);
        }

        [TestMethod]
        public void ConvertCqlIntervalDate_Period()
        {
            var interval = new CqlInterval<CqlDate>(
                new CqlDate(2022, 01, 01),
                new CqlDate(2022, 3, 31),
                true, true
            );
            var converted = FhirTypeConverter.Convert<Period>(interval);

            Assert.IsNotNull(converted);
            Assert.IsTrue(DateTimeIso8601.TryParse(converted.Start, out var start));
            Assert.IsTrue(DateTimeIso8601.TryParse(converted.End, out var end));

            Assert.AreEqual(2022, start.Year);
            Assert.AreEqual(1, start.Month);
            Assert.AreEqual(1, start.Day);
            Assert.IsNull(start.Hour);
            Assert.IsNull(start.Minute);
            Assert.IsNull(start.Second);
            Assert.IsNull(start.Millisecond);

            Assert.AreEqual(2022, end.Year);
            Assert.AreEqual(3, end.Month);
            Assert.AreEqual(31, end.Day);
            Assert.IsNull(end.Hour);
            Assert.IsNull(end.Minute);
            Assert.IsNull(end.Second);
            Assert.IsNull(end.Millisecond);
        }

        [TestMethod]
        public void ConvertFhirDateTime_CqlDate()
        {
            var date = new FhirDateTime(2022, 1, 1, 1, 1, 1, TimeSpan.Zero);
            var converted = FhirTypeConverter.Convert<CqlDate>(date);

            Assert.IsNotNull(converted);
            var isoDateTime = converted.Value;
            Assert.IsNotNull(isoDateTime);

            Assert.AreEqual(2022, isoDateTime.Year);
            Assert.AreEqual(1, isoDateTime.Month);
            Assert.AreEqual(1, isoDateTime.Day);

            var nullDateTime = new FhirDateTime(null);
            var nullConverted = FhirTypeConverter.Convert<CqlDateTime>(nullDateTime);
            Assert.IsNull(nullConverted);
        }
    }
}