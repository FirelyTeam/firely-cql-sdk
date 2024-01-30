using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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
        public void Element_ResultName_MapToFhirType()
        {
            var element = new Hl7.Cql.Elm.ParameterDef()
            {
                resultTypeName = new System.Xml.XmlQualifiedName("{http://hl7.org/fhir}boolean")
            };

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(element);
            Assert.IsNotNull(typeEntry, $"Unable to express {element} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Boolean, typeEntry.FhirType.Value);
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
        public void CqlIntervalOfInt_MapToFhirType()
        {
            var cqlType = typeof(CqlInterval<int>);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Range, typeEntry.FhirType.Value);
            Assert.AreEqual(FHIRAllTypes.Integer, typeEntry.ElementType.FhirType.Value);
        }

        [TestMethod]
        public void CqlIntervalOfDecimal_MapToFhirType()
        {
            var cqlType = typeof(CqlInterval<decimal>);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Range, typeEntry.FhirType.Value);
            Assert.AreEqual(FHIRAllTypes.Decimal, typeEntry.ElementType.FhirType.Value);
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


        [TestMethod]
        public void String_MapToFhirType()
        {
            var cqlType = typeof(string);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.String, typeEntry.FhirType.Value);
        }

        [TestMethod]
        public void Decimal_MapToFhirType()
        {
            var cqlType = typeof(decimal);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Decimal, typeEntry.FhirType.Value);
        }

        [TestMethod]
        public void Boolean_MapToFhirType()
        {
            var cqlType = typeof(bool);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Boolean, typeEntry.FhirType.Value);
        }
        
        [TestMethod]
        public void LINQResult_MapToFhirType()
        {
            var list = new List<object> { new Claim() { Id = "claim1" } };

            var linqResult = list.Cast<Claim>();

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(linqResult.GetType());
            Assert.IsNotNull(typeEntry, $"Unable to express {linqResult.GetType()} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.List, typeEntry.FhirType.Value);
            Assert.AreEqual(FHIRAllTypes.Claim, typeEntry.ElementType.FhirType);
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
