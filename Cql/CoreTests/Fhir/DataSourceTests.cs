using FluentAssertions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CoreTests.Fhir
{
    [TestClass]
    public class DataSourceTests
    {
        [TestMethod]
        public void FiltersOnResourceType()
        {
            var dr = buildDataSource();

            var results = dr.RetrieveByCodes<Patient>();
            results.Should().HaveCount(2);
            results.Should().AllBeOfType<Patient>();
        }

        [TestMethod]
        public void FiltersOnDefaultProp()
        {
            var dr = buildDataSource();

            var results = dr.RetrieveByCodes<Observation>(new[] { new CqlCode("x", "http://nu.nl", null, null) });
            results.Should().HaveCount(1);
            results.Should().AllBeOfType<Observation>().And.AllSatisfy(o => o.Code.Coding[0].Code.Should().Be("x"));

            results = dr.RetrieveByCodes<Observation>(new[] { new CqlCode("z", "http://nu.nl", null, null) });
            results.Should().BeEmpty();

            Assert.ThrowsException<InvalidOperationException>(() =>
                dr.RetrieveByCodes<Patient>(new[] { new CqlCode("x", "http://nu.nl", null, null) }));

            results = dr.RetrieveByCodes<Observation>(new[] { new CqlCode("x", "http://nu.nl", null, null), new CqlCode("y", "http://nu.nl", null, null) });
            results.Should().HaveCount(2);
            results.Should().AllBeOfType<Observation>().And.AllSatisfy(o => o.Code.Coding[0].System.Should().Be("http://nu.nl"));
        }

        [TestMethod]
        public void FiltersOnSpecificProp()
        {
            var dr = buildDataSource();
            var model = new FhirTypeResolver(ModelInfo.ModelInspector);
            var genderProp = model.GetProperty(model.ResolveType("{http://hl7.org/fhir}Patient"), "gender");
            genderProp.Should().NotBeNull();

            var results = dr.RetrieveByCodes<Patient>(new[] { new CqlCode("male", "http://hl7.org/fhir/administrative-gender", null, null) }, genderProp);
            results.Should().HaveCount(1);
            results.Should().AllBeOfType<Patient>().And.AllSatisfy(p => p.Gender.Should().Be(AdministrativeGender.Male));

            var activeProp = model.GetProperty(model.ResolveType("{http://hl7.org/fhir}Patient"), "active");
            Assert.ThrowsException<NotSupportedException>(() =>
                dr.RetrieveByCodes<Patient>(new[] { new CqlCode("male", "http://hl7.org/fhir/administrative-gender", null, null) }, activeProp).ToList());
        }

        private BundleDataSource buildDataSource()
        {
            var resources = new Resource[]
            {
                new Patient { Active = true, Gender = AdministrativeGender.Male },  // uncoded
                new Patient { Active = true, Gender = AdministrativeGender.Female }, // uncoded
                new Observation { Code = new CodeableConcept("http://nu.nl", "x"), Status = ObservationStatus.Final }, // coded on Code
                new Observation { Code = new CodeableConcept("http://nu.nl", "y"), Status = ObservationStatus.Preliminary }, // coded on Code
            };

            var bundle = new Bundle();
            foreach (var r in resources) { bundle.AddResourceEntry(r, $"http://someresource/{r.GetHashCode()}"); }

            return new BundleDataSource(bundle, new HashValueSetDictionary());  // we're not calling IsInValueSet, so we can pass an empty dict
        }
    }
}
