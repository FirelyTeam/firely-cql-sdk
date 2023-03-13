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
