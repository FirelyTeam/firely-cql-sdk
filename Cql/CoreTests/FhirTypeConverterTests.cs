using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ncqa.Cql.Runtime.FhirR4;
using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Fhir.R4.Model;
using System;
using static Ncqa.Fhir.R4.Model.Parameters;

namespace CoreTests
{
    [TestClass]
    public class FhirTypeConverterTests
    {
        [TestMethod]
        public void ConvertParameters_Integer()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueInteger = new IntegerElement() { value = 1 },
            };

            var converted = FhirTypeConverter.Default.Convert<int?>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void ConvertParameters_String()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "hi" },
            };

            var converted = FhirTypeConverter.Default.Convert<string>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual("hi", converted);
        }

        [TestMethod]
        public void ConvertParameters_Decimal()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueDecimal = new DecimalElement() { value = 1 },
            };

            var converted = FhirTypeConverter.Default.Convert<decimal?>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual(1, converted);
        }


        [TestMethod]
        public void ConvertParameters_Boolean()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueBoolean = new BooleanElement() { value = true },
            };

            var converted = FhirTypeConverter.Default.Convert<bool?>(parameter);

            Assert.IsNotNull(converted);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void ConvertParameters_Date()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueDate = new DateElement() { value = new Ncqa.Iso8601.DateIso8601(2022, 01, 01, false) },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlDate>(parameter);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlDate);

            Assert.AreEqual(2022, converted.Value.Year);
            Assert.AreEqual(1, converted.Value.Month);
            Assert.AreEqual(1, converted.Value.Day);
        }


        [TestMethod]
        public void ConvertParameters_Date_Macro()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "@Today" },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlDate>(parameter);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlDate);

            Assert.AreEqual(DateTime.Now.Year, converted.Value.Year);
            Assert.AreEqual(DateTime.Now.Month, converted.Value.Month);
            Assert.AreEqual(DateTime.Now.Day, converted.Value.Day);
        }



        [TestMethod]
        public void ConvertParameters_Date_MacroAddOperator()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "@Today + 2 day" },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlDate>(parameter);

            Assert.IsNotNull(converted);

            var expected = DateTime.Now.AddDays(2);

            Assert.IsTrue(converted is CqlDate);

            Assert.AreEqual(expected.Year, converted.Value.Year);
            Assert.AreEqual(expected.Month, converted.Value.Month);
            Assert.AreEqual(expected.Day, converted.Value.Day);
        }

        [TestMethod]
        public void ConvertParameters_Date_MacroSubtractOperator()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "@Today - 2 day" },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlDate>(parameter);

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
                name = "param1",
                valueDateTime = new DateTimeElement() { value = new Ncqa.Iso8601.DateTimeIso8601(2022, 01, 01, 1, 1, 1, 1, 0, 0, false) },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlDateTime>(parameter);

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

        [TestMethod]
        public void ConvertParameters_DateTime_Macro()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "@Today" },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlDateTime>(parameter);

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
                name = "param1",
                valueTime = new TimeElement() { value = new Ncqa.Iso8601.TimeIso8601(1, 1, 1, 1, 0, 0, false) },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlTime>(parameters);

            Assert.IsNotNull(converted);

            Assert.IsTrue(converted is CqlTime);

            Assert.AreEqual(1, converted.Value.Hour);
            Assert.AreEqual(1, converted.Value.Minute);
            Assert.AreEqual(1, converted.Value.Second);
            Assert.AreEqual(1, converted.Value.Millisecond);
        }

        [TestMethod]
        public void ConvertParameters_Quantity()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueQuantity = new Quantity() { value = new DecimalElement() { value = 1 }, unit = new StringElement() { value = "oranges" } },
            };

            var converted = FhirTypeConverter.Default.Convert<CqlQuantity>(parameter);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.value);
            Assert.AreEqual("oranges", converted.unit);
        }

        [TestMethod]
        public void ConvertParameters_IntervalDateTime_Period()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valuePeriod = new Period()
                {
                    start = new DateTimeElement()
                    {
                        value = new Ncqa.Iso8601.DateTimeIso8601(2022, 01, 01, 1, 1, 1, 1, 0, 0, false)
                    },
                    end = new DateTimeElement()
                    {
                        value = new Ncqa.Iso8601.DateTimeIso8601(2022, 3, 31, 1, 1, 1, 1, 0, 0, false)
                    }
                }
            };

            var converted = FhirTypeConverter.Default.Convert<CqlDateTime>(parameter);
        }

        [TestMethod]
        public void ConvertParameters_IntervalDateTime_Period_ExplicitRange()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "2022-01-01 to 2022-03-31"}
            };

            var converted = FhirTypeConverter.Default.Convert<CqlInterval<CqlDateTime>>(parameter);

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
        public void ConvertParameters_IntervalDateTime_Period_Marco()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "@ThisYear" }
            };

            var converted = FhirTypeConverter.Default.Convert<CqlInterval<CqlDateTime>>(parameter);

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
        public void ConvertParameters_IntervalDate_Period_ExplicitRange()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "2022-01-01 to 2022-03-31" }
            };

            var converted = FhirTypeConverter.Default.Convert<CqlInterval<CqlDate>>(parameter);

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
        public void ConvertParameters_IntervalDate_Period_Marco()
        {
            var parameter = new ParameterComponent()
            {
                name = "param1",
                valueString = new StringElement() { value = "@ThisYear" }
            };

            var converted = FhirTypeConverter.Default.Convert<CqlInterval<CqlDate>>(parameter);

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
                name = "param1",
                valuePeriod = new Period()
                {
                    start = new DateTimeElement()
                    {
                        value = new Ncqa.Iso8601.DateTimeIso8601(2022, 01, 01, 1, 1, 1, 1, 0, 0, false)
                    },
                    end = new DateTimeElement()
                    {
                        value = new Ncqa.Iso8601.DateTimeIso8601(2022, 3, 31, 1, 1, 1, 1, 0, 0, false)
                    }
                }
            };

            var converted = FhirTypeConverter.Default.Convert<CqlInterval<CqlDateTime>>(parameter);

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
                name = "param1",
                valueRange = new Ncqa.Fhir.R4.Model.Range()
                {
                    high = new Quantity { value = new DecimalElement() { value = 10 }, unit = "oranges" },
                    low = new Quantity { value = new DecimalElement() { value = 1 }, unit = "oranges" },
                }
            };

            var converted = FhirTypeConverter.Default.Convert<CqlInterval<CqlQuantity>>(parameter);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.low.value);
            Assert.AreEqual(10, converted.high.value);
        }

        [TestMethod]
        public void ConvertCqlDate_FhirDate()
        {
            var date = new CqlDate(2022, 1, 1);
            var converted = FhirTypeConverter.Default.Convert<DateElement>(date);

            Assert.IsNotNull(converted);

            Assert.AreEqual(2022, converted.value.Year);
            Assert.AreEqual(1, converted.value.Month);
            Assert.AreEqual(1, converted.value.Day);
        }

        [TestMethod]
        public void ConvertCqlDateTime_FhirDateTime()
        {
            var date = new CqlDateTime(2022, 1, 1, 1, 1, 1, 1, null, null);
            var converted = FhirTypeConverter.Default.Convert<DateTimeElement>(date);

            Assert.IsNotNull(converted);

            Assert.AreEqual(2022, converted.value.Year);
            Assert.AreEqual(1, converted.value.Month);
            Assert.AreEqual(1, converted.value.Day);
            Assert.AreEqual(1, converted.value.Hour);
            Assert.AreEqual(1, converted.value.Minute);
            Assert.AreEqual(1, converted.value.Second);
            Assert.AreEqual(1, converted.value.Millisecond);
        }

        [TestMethod]
        public void ConvertCqlTime_FhirTime()
        {
            var date = new CqlTime(1, 1, 1, 1, null, null);
            var converted = FhirTypeConverter.Default.Convert<TimeElement>(date);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.value.Hour);
            Assert.AreEqual(1, converted.value.Minute);
            Assert.AreEqual(1, converted.value.Second);
            Assert.AreEqual(1, converted.value.Millisecond);
        }


        [TestMethod]
        public void ConvertCqlQuantity_Quantity()
        {
            var quantity = new CqlQuantity()
            {
                unit = "oranges",
                value = 1
            };
            var converted = FhirTypeConverter.Default.Convert<Quantity>(quantity);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.value.value);
            Assert.AreEqual("oranges", converted.unit.value);
        }

        [TestMethod]
        public void ConvertCqlQuantityInterval_Range()
        {
            var quantityInterval = new CqlInterval<CqlQuantity>(
                new CqlQuantity()
                {
                    unit = "oranges",
                    value = 1
                }, 
                new CqlQuantity()
                {
                    unit = "oranges",
                    value = 10
                }, true, true
            );
            var converted = FhirTypeConverter.Default.Convert<Ncqa.Fhir.R4.Model.Range>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.low.value.value);
            Assert.AreEqual("oranges", converted.low.unit.value);

            Assert.AreEqual(10, converted.high.value.value);
            Assert.AreEqual("oranges", converted.high.unit.value);
        }
        [TestMethod]
        public void ConvertCqlDecimalInterval_Range()
        {
            var quantityInterval = new CqlInterval<decimal?>(
                1, 10, true, true
            );
            var converted = FhirTypeConverter.Default.Convert<Ncqa.Fhir.R4.Model.Range>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.low.value.value);
            Assert.AreEqual(10, converted.high.value.value);
        }

        [TestMethod]
        public void ConvertCqlIntInterval_Range()
        {
            var quantityInterval = new CqlInterval<int?>(
                1, 10, true, true
            );
            var converted = FhirTypeConverter.Default.Convert<Ncqa.Fhir.R4.Model.Range>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.low.value.value);
            Assert.AreEqual(10, converted.high.value.value);
        }

        [TestMethod]
        public void ConvertCqlRatio_Ratio()
        {
            var quantityInterval = new CqlRatio(
                new CqlQuantity()
                {
                    unit = "widgets",
                    value = 1
                },
                new CqlQuantity()
                {
                    unit = "widgets",
                    value = 10
                }
            );
            var converted = FhirTypeConverter.Default.Convert<Ratio>(quantityInterval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(1, converted.numerator.value.value);
            Assert.AreEqual("widgets", converted.numerator.unit.value);

            Assert.AreEqual(10, converted.denominator.value.value);
            Assert.AreEqual("widgets", converted.denominator.unit.value);
        }


        [TestMethod]
        public void ConvertCqlIntervalDateTime_Period()
        {
            var interval = new CqlInterval<CqlDateTime>(
                new CqlDateTime(2022, 01, 01, 1, 1, 1, 1, 0, 0),
                new CqlDateTime(2022, 3, 31, 1, 1, 1, 1, 0, 0),
                true, true
            );
            var converted = FhirTypeConverter.Default.Convert<Period>(interval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(2022, converted.start.value.Year);
            Assert.AreEqual(1, converted.start.value.Month);
            Assert.AreEqual(1, converted.start.value.Day);
            Assert.AreEqual(1, converted.start.value.Hour);
            Assert.AreEqual(1, converted.start.value.Minute);
            Assert.AreEqual(1, converted.start.value.Second);
            Assert.AreEqual(1, converted.start.value.Millisecond);

            Assert.AreEqual(2022, converted.end.value.Year);
            Assert.AreEqual(3, converted.end.value.Month);
            Assert.AreEqual(31, converted.end.value.Day);
            Assert.AreEqual(1, converted.end.value.Hour);
            Assert.AreEqual(1, converted.end.value.Minute);
            Assert.AreEqual(1, converted.end.value.Second);
            Assert.AreEqual(1, converted.end.value.Millisecond);
        }

        [TestMethod]
        public void ConvertCqlIntervalDate_Period()
        {
            var interval = new CqlInterval<CqlDate>(
                new CqlDate(2022, 01, 01),
                new CqlDate(2022, 3, 31),
                true, true
            );
            var converted = FhirTypeConverter.Default.Convert<Period>(interval);

            Assert.IsNotNull(converted);

            Assert.AreEqual(2022, converted.start.value.Year);
            Assert.AreEqual(1, converted.start.value.Month);
            Assert.AreEqual(1, converted.start.value.Day);
            Assert.IsNull(converted.start.value.Hour);
            Assert.IsNull(converted.start.value.Minute);
            Assert.IsNull(converted.start.value.Second);
            Assert.IsNull(converted.start.value.Millisecond);

            Assert.AreEqual(2022, converted.end.value.Year);
            Assert.AreEqual(3, converted.end.value.Month);
            Assert.AreEqual(31, converted.end.value.Day);
            Assert.IsNull(converted.end.value.Hour);
            Assert.IsNull(converted.end.value.Minute);
            Assert.IsNull(converted.end.value.Second);
            Assert.IsNull(converted.end.value.Millisecond);
        }
    }
}
