using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class AgeTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private void TestCalculateAgeAt(string type, DateTimePrecision unit)
        {
            var lib = MakeLibrary($@"
                library AgeTest version '1.0.0'

                using FHIR version '4.0.1'

                define function CalculateAgeAt(birthDate {type}, at {type}):
                    CalculateAgeIn{Enum.GetName(unit)}sAt(birthDate,at)
            ");
            var caa = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<CalculateAgeAt>();
            caa.precisionSpecified.Should().BeTrue();
            caa.precision.Should().Be(unit);
        }

        private void TestAgeAt(string type, DateTimePrecision unit)
        {
            var lib = MakeLibrary($@"
                library AgeTest version '1.0.0'

                using FHIR version '4.0.1'

                define function AgeAt(at {type}):
                    AgeIn{Enum.GetName(unit)}sAt(at)
            ");
            var caa = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<CalculateAgeAt>();
            caa.precisionSpecified.Should().BeTrue();
            caa.precision.Should().Be(unit);
        }

        private void TestCalculateAge(string type, DateTimePrecision unit)
        {
            var lib = MakeLibrary($@"
                library AgeTest version '1.0.0'

                using FHIR version '4.0.1'

                define function CalculateAge(birthDate {type}):
                    CalculateAgeIn{Enum.GetName(unit)}s(birthDate)
            ");
            var caa = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<CalculateAge>();
            caa.precisionSpecified.Should().BeTrue();
            caa.precision.Should().Be(unit);
        }

        private void TestAge(string type, DateTimePrecision unit)
        {
            var lib = MakeLibrary($@"
                library AgeTest version '1.0.0'

                using FHIR version '4.0.1'

                define value: AgeIn{Enum.GetName(unit)}s()
            ");
            var caa = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<CalculateAge>();
            caa.precisionSpecified.Should().BeTrue();
            caa.precision.Should().Be(unit);
        }

        [TestMethod]
        public void CalculateAgeAt_Date_FHIRTypes()
        {
            TestCalculateAgeAt("FHIR.date", DateTimePrecision.Year);
            TestCalculateAgeAt("FHIR.date", DateTimePrecision.Month);
            TestCalculateAgeAt("FHIR.date", DateTimePrecision.Week);
            TestCalculateAgeAt("FHIR.date", DateTimePrecision.Day);
        }
        [TestMethod]
        public void CalculateAgeAt_Date_SystemTypes()
        {
            TestCalculateAgeAt("System.Date", DateTimePrecision.Year);
            TestCalculateAgeAt("System.Date", DateTimePrecision.Month);
            TestCalculateAgeAt("System.Date", DateTimePrecision.Week);
            TestCalculateAgeAt("System.Date", DateTimePrecision.Day);
        }


        [TestMethod]
        public void CalculateAgeAt_DateTime_FHIRTypes()
        {
            TestCalculateAgeAt("FHIR.dateTime", DateTimePrecision.Year);
            TestCalculateAgeAt("FHIR.dateTime", DateTimePrecision.Month);
            TestCalculateAgeAt("FHIR.dateTime", DateTimePrecision.Week);
            TestCalculateAgeAt("FHIR.dateTime", DateTimePrecision.Day);
            TestCalculateAgeAt("FHIR.dateTime", DateTimePrecision.Hour);
            TestCalculateAgeAt("FHIR.dateTime", DateTimePrecision.Minute);
            TestCalculateAgeAt("FHIR.dateTime", DateTimePrecision.Second);
        }

        [TestMethod]
        public void CalculateAgeAt_DateTime_SystemTypes()
        {
            TestCalculateAgeAt("System.DateTime", DateTimePrecision.Year);
            TestCalculateAgeAt("System.DateTime", DateTimePrecision.Month);
            TestCalculateAgeAt("System.DateTime", DateTimePrecision.Week);
            TestCalculateAgeAt("System.DateTime", DateTimePrecision.Day);
            TestCalculateAgeAt("System.DateTime", DateTimePrecision.Hour);
            TestCalculateAgeAt("System.DateTime", DateTimePrecision.Minute);
            TestCalculateAgeAt("System.DateTime", DateTimePrecision.Second);
        }

        [TestMethod]
        public void AgeAt_Date_FHIRTypes()
        {
            TestAgeAt("FHIR.date", DateTimePrecision.Year);
            TestAgeAt("FHIR.date", DateTimePrecision.Month);
            TestAgeAt("FHIR.date", DateTimePrecision.Week);
            TestAgeAt("FHIR.date", DateTimePrecision.Day);
        }

        [TestMethod]
        public void AgeAt_Date_SystemTypes()
        {
            TestAgeAt("System.Date", DateTimePrecision.Year);
            TestAgeAt("System.Date", DateTimePrecision.Month);
            TestAgeAt("System.Date", DateTimePrecision.Week);
            TestAgeAt("System.Date", DateTimePrecision.Day);
        }

        [TestMethod]
        public void AgeAt_DateTime_FHIRTypes()
        {
            TestAgeAt("FHIR.dateTime", DateTimePrecision.Year);
            TestAgeAt("FHIR.dateTime", DateTimePrecision.Month);
            TestAgeAt("FHIR.dateTime", DateTimePrecision.Week);
            TestAgeAt("FHIR.dateTime", DateTimePrecision.Day);
            TestAgeAt("FHIR.dateTime", DateTimePrecision.Hour);
            TestAgeAt("FHIR.dateTime", DateTimePrecision.Minute);
            TestAgeAt("FHIR.dateTime", DateTimePrecision.Second);
        }

        [TestMethod]
        public void AgeAt_DateTime_SystemTypes()
        {
            TestAgeAt("System.DateTime", DateTimePrecision.Year);
            TestAgeAt("System.DateTime", DateTimePrecision.Month);
            TestAgeAt("System.DateTime", DateTimePrecision.Week);
            TestAgeAt("System.DateTime", DateTimePrecision.Day);
            TestAgeAt("System.DateTime", DateTimePrecision.Hour);
            TestAgeAt("System.DateTime", DateTimePrecision.Minute);
            TestAgeAt("System.DateTime", DateTimePrecision.Second);
        }

        [TestMethod]
        public void CalculateAge_Date_FHIRTypes()
        {
            TestCalculateAge("FHIR.date", DateTimePrecision.Year);
            TestCalculateAge("FHIR.date", DateTimePrecision.Month);
            TestCalculateAge("FHIR.date", DateTimePrecision.Week);
            TestCalculateAge("FHIR.date", DateTimePrecision.Day);
        }
        [TestMethod]
        public void CalculateAge_Date_SystemTypes()
        {
            TestCalculateAge("System.Date", DateTimePrecision.Year);
            TestCalculateAge("System.Date", DateTimePrecision.Month);
            TestCalculateAge("System.Date", DateTimePrecision.Week);
            TestCalculateAge("System.Date", DateTimePrecision.Day);
        }


        [TestMethod]
        public void CalculateAge_DateTime_FHIRTypes()
        {
            TestCalculateAge("FHIR.dateTime", DateTimePrecision.Year);
            TestCalculateAge("FHIR.dateTime", DateTimePrecision.Month);
            TestCalculateAge("FHIR.dateTime", DateTimePrecision.Week);
            TestCalculateAge("FHIR.dateTime", DateTimePrecision.Day);
            TestCalculateAge("FHIR.dateTime", DateTimePrecision.Hour);
            TestCalculateAge("FHIR.dateTime", DateTimePrecision.Minute);
            TestCalculateAge("FHIR.dateTime", DateTimePrecision.Second);
        }
        [TestMethod]
        public void CalculateAge_DateTime_SystemTypes()
        {
            TestCalculateAge("System.DateTime", DateTimePrecision.Year);
            TestCalculateAge("System.DateTime", DateTimePrecision.Month);
            TestCalculateAge("System.DateTime", DateTimePrecision.Week);
            TestCalculateAge("System.DateTime", DateTimePrecision.Day);
            TestCalculateAge("System.DateTime", DateTimePrecision.Hour);
            TestCalculateAge("System.DateTime", DateTimePrecision.Minute);
            TestCalculateAge("System.DateTime", DateTimePrecision.Second);
        }


        [TestMethod]
        public void Age_Date_SystemTypes()
        {
            TestAge("System.Date", DateTimePrecision.Year);
            TestAge("System.Date", DateTimePrecision.Month);
            TestAge("System.Date", DateTimePrecision.Week);
            TestAge("System.Date", DateTimePrecision.Day);
        }

        [TestMethod]
        public void Age_DateTime_FHIRTypes()
        {
            TestAge("FHIR.dateTime", DateTimePrecision.Year);
            TestAge("FHIR.dateTime", DateTimePrecision.Month);
            TestAge("FHIR.dateTime", DateTimePrecision.Week);
            TestAge("FHIR.dateTime", DateTimePrecision.Day);
            TestAge("FHIR.dateTime", DateTimePrecision.Hour);
            TestAge("FHIR.dateTime", DateTimePrecision.Minute);
            TestAge("FHIR.dateTime", DateTimePrecision.Second);
        }

    }
}