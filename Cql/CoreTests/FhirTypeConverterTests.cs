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

        [TestMethod]
        public void ConvertCqlTime_HourPrecision_PadsAndAddsTimePrecisionExtension()
        {
            var time = new CqlTime(10, null, null, null, null, null);
            var converted = FhirTypeConverter.Convert<Time>(time);

            Assert.IsNotNull(converted);
            Assert.AreEqual("10:00:00", converted.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlTime_MinutePrecision_PadsAndAddsTimePrecisionExtension()
        {
            var time = new CqlTime(10, 30, null, null, null, null);
            var converted = FhirTypeConverter.Convert<Time>(time);

            Assert.IsNotNull(converted);
            Assert.AreEqual("10:30:00", converted.Value);
            Assert.AreEqual("min", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlTime_SecondPrecision_NoTimePrecisionExtension()
        {
            var time = new CqlTime(10, 30, 15, null, null, null);
            var converted = FhirTypeConverter.Convert<Time>(time);

            Assert.IsNotNull(converted);
            Assert.AreEqual("10:30:15", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_HourPrecision_PadsAndAddsTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, null, null, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual("2014-02-01T10:00:00", converted.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_MinutePrecisionWithOffset_PadsAndAddsTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, 30, null, null, 1, 30);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual("2014-02-01T10:30:00+01:30", converted.Value);
            Assert.AreEqual("min", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_HourPrecisionUtc_PadsAndAddsTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, 10, null, null, null, 0, 0);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual("2014-02-01T10:00:00Z", converted.Value);
            Assert.AreEqual("h", GetTimePrecisionCode(converted));
        }

        [TestMethod]
        public void ConvertCqlDateTime_DayPrecision_UnchangedWithoutTimePrecisionExtension()
        {
            var dateTime = new CqlDateTime(2014, 2, 1, null, null, null, null, null, null);
            var converted = FhirTypeConverter.Convert<FhirDateTime>(dateTime);

            Assert.IsNotNull(converted);
            Assert.AreEqual("2014-02-01", converted.Value);
            Assert.IsNull(GetTimePrecisionCode(converted));
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
        public void ConvertFhirDateTime_TimePrecisionExtension_DoesNotPolluteDateTimeCache()
        {
            var converter = Hl7.Cql.Fhir.FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector, cacheSize: 128);

            var adorned = new FhirDateTime("2014-02-01T10:00:00Z");
            adorned.AddExtension(TimePrecisionExtensionUrl, new Code("h"));
            var partial = converter.Convert<CqlDateTime>(adorned);
            Assert.AreEqual(DateTimePrecision.Hour, partial!.Precision);

            // The same lexical value without the extension must not be served from a cache entry
            // keyed only by the string, and vice versa.
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
            Assert.AreEqual("2014-02-01T10:00:00", converted.Start);
            Assert.AreEqual("h", GetTimePrecisionCode(converted.StartElement));
            Assert.AreEqual("2014-02-01T12:30:00", converted.End);
            Assert.AreEqual("min", GetTimePrecisionCode(converted.EndElement));
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
            Assert.AreEqual("0001-01-01T10:00:00", converted.Start);
            Assert.AreEqual("h", GetTimePrecisionCode(converted.StartElement));
            Assert.AreEqual("0001-01-01T12:30:00", converted.End);
            Assert.AreEqual("min", GetTimePrecisionCode(converted.EndElement));
        }


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