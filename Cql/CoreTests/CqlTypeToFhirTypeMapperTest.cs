/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

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
        public void CqlIntervalOfTime_MapToFhirType()
        {
            var cqlType = typeof(CqlInterval<CqlTime>);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Period, typeEntry.FhirType.Value);
            Assert.AreEqual(FHIRAllTypes.DateTime, typeEntry.ElementType.FhirType.Value);
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
        public void Long_MapToFhirType()
        {
            var cqlType = typeof(long);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.String, typeEntry.FhirType.Value);
            Assert.AreEqual(CqlPrimitiveType.Long, typeEntry.CqlType.Value);
        }

        [TestMethod]
        public void NullableLong_MapToFhirType()
        {
            var cqlType = typeof(long?);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(cqlType);
            Assert.IsNotNull(typeEntry, $"Unable to express {cqlType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.String, typeEntry.FhirType.Value);
            Assert.AreEqual(CqlPrimitiveType.Long, typeEntry.CqlType.Value);
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
            List<object> list = [new Claim() { Id = "claim1" }];

            var linqResult = list.Cast<Claim>();

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(linqResult.GetType());
            Assert.IsNotNull(typeEntry, $"Unable to express {linqResult.GetType()} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.List, typeEntry.FhirType.Value);
            Assert.AreEqual(FHIRAllTypes.Claim, typeEntry.ElementType.FhirType);
        }

        [TestMethod]
        public void NullableValueTuple_MapToFhirType()
        {
            // CQL tuples are represented at runtime as value tuples whose first element is a
            // CqlTupleMetadata. List/query results wrap these in Nullable<T>, which must still
            // be recognized as a CQL tuple (mapping to FHIR Basic).
            var type = typeof(ValueTuple<CqlTupleMetadata, string>?);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(type);
            Assert.IsNotNull(typeEntry, $"Unable to express {type} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.Basic, typeEntry.FhirType.Value);
            Assert.AreEqual(CqlPrimitiveType.Tuple, typeEntry.CqlType.Value);
        }

        [TestMethod]
        public void ListOfTupleResult_MapToFhirType()
        {
            // Reproduces a query/list returning tuples, e.g. "({ 1 }) X return Tuple { key: ... }",
            // whose runtime type is List<Nullable<ValueTuple<CqlTupleMetadata, ...>>>.
            var type = typeof(List<ValueTuple<CqlTupleMetadata, string>?>);

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(type);
            Assert.IsNotNull(typeEntry, $"Unable to express {type} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.List, typeEntry.FhirType.Value);
            Assert.IsNotNull(typeEntry.ElementType, "List element type should be mapped");
            Assert.AreEqual(FHIRAllTypes.Basic, typeEntry.ElementType.FhirType);
            Assert.AreEqual(CqlPrimitiveType.Tuple, typeEntry.ElementType.CqlType.Value);
        }

        [TestMethod]
        public void CqlLibraryTupleQueryResult_MapToFhirType()
        {
            var cql = (CqlLibraryString)"""
                library Test version '1.0.0'
                define "TupleQueryResult":
                  ({ 1 }) X
                    return Tuple { key: 'ExampleConcept' }
                """;

            using var librarySetInvoker = new CqlToolkit()
                .AddCqlLibraries(cql)
                .CreateLibrarySetInvoker();

            var returnType = librarySetInvoker
                .LibraryInvokers[cql.LibraryIdentifier]
                .Definitions.Values
                .Single(d => d.DefinitionName == "TupleQueryResult")
                .ReturnType;

            var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
            var typeEntry = crosswalk.TypeEntryFor(returnType);
            Assert.IsNotNull(typeEntry, $"Unable to express {returnType} as a FHIR type");
            Assert.AreEqual(FHIRAllTypes.List, typeEntry.FhirType.Value);
            Assert.IsNotNull(typeEntry.ElementType, "List element type should be mapped");
            Assert.AreEqual(FHIRAllTypes.Basic, typeEntry.ElementType.FhirType);
            Assert.AreEqual(CqlPrimitiveType.Tuple, typeEntry.ElementType.CqlType.Value);
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
