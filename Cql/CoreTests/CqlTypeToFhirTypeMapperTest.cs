using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    public class CqlTypeToFhirTypeMapperTest
    {
        #region Cql to FHIR
        
        [TestMethod]
        public void CqlDate_MapToFhirType()
        {
            var cqlType = typeof(CqlDate);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Date, typeEntry.FhirType.Value);
        }

        [TestMethod]
        public void CqlIntervalOfDate_MapToFhirType()
        {
            var cqlType = typeof(CqlInterval<CqlDate>);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Period, typeEntry.FhirType.Value);
            Assert.AreEqual(FHIRAllTypes.Date, typeEntry.ElementType.FhirType.Value);
        }

        [TestMethod]
        public void Claim_MapToFhirType()
        {
            var cqlType = typeof(Hl7.Fhir.Model.Claim);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Claim, typeEntry.FhirType.Value);
        }

        #endregion


        #region FHIR to CQL
        [TestMethod]
        public void FHIRDateTime_MapToCqlType()
        {
            var fhirType = typeof(FhirDateTime);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(fhirType);
            Assert.IsNotNull(typeEntry, $"Unable to express {fhirType} as a CQL type");
            Assert.AreEqual(CqlPrimitiveType.DateTime, typeEntry.CqlType.Value);
        }
        #endregion
    }
}
