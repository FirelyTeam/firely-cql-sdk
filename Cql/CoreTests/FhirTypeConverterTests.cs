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
            Assert.AreEqual(10, converted.High.Value);
            Assert.AreEqual("1", converted.Low.Unit);
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
            Assert.AreEqual(10, converted.High.Value);
        }


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