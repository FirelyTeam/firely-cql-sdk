using FluentAssertions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Hl7.Cql.Operators;

namespace CoreTests.Fhir
{
    [TestClass]
    public class DataSourceTests
    {
        [TestMethod]
        public void FiltersOnResourceType()
        {
            var dr = buildDataSource();

            var results = dr.Retrieve<Patient>(null);
            results.Should().HaveCount(2);
            results.Should().AllBeOfType<Patient>();
        }

        private static RetrieveParameters Pars(params CqlCode[] codes) => new(null, null, codes, null);

        [TestMethod]
        public void FiltersOnDefaultProp()
        {
            var dr = buildDataSource();

            var results = dr.Retrieve<Observation>(Pars(new CqlCode("x", "http://nu.nl")));
            results.Should().HaveCount(1);
            results.Should().AllBeOfType<Observation>().And.AllSatisfy(o => o.Code.Coding[0].Code.Should().Be("x"));

            results = dr.Retrieve<Observation>(Pars(new CqlCode("z", "http://nu.nl")));
            results.Should().BeEmpty();

            Assert.ThrowsException<InvalidOperationException>(
                () => dr.Retrieve<Patient>(Pars(new CqlCode("x", "http://nu.nl"))));

            results = dr.Retrieve<Observation>(Pars(new CqlCode("x", "http://nu.nl"), new CqlCode("y", "http://nu.nl")));
            results.Should().HaveCount(2);
            results.Should().AllBeOfType<Observation>().And.AllSatisfy(o => o.Code.Coding[0].System.Should().Be("http://nu.nl"));
        }

        [TestMethod]
        public void FiltersOnSpecificProp()
        {
            var dr = buildDataSource();
            var model = new FhirTypeResolver(ModelInfo.ModelInspector);
            var genderProp = model.GetProperty(model.ResolveType("{http://hl7.org/fhir}Patient")!, "gender");
            genderProp.Should().NotBeNull();

            var results = dr.Retrieve<Patient>(new RetrieveParameters(genderProp, null,
                [new CqlCode("male", "http://hl7.org/fhir/administrative-gender")], null));
            results.Should().HaveCount(1);
            results.Should().AllBeOfType<Patient>().And.AllSatisfy(p => p.Gender.Should().Be(AdministrativeGender.Male));

            var activeProp = model.GetProperty(model.ResolveType("{http://hl7.org/fhir}Patient")!, "active");
            Assert.ThrowsException<NotSupportedException>(() =>
                dr.Retrieve<Patient>(new RetrieveParameters(activeProp, null,
                [new CqlCode("male", "http://hl7.org/fhir/administrative-gender")], null)).ToList());
        }

        private BundleDataSource buildDataSource()
        {
            Resource[] resources =
            [
                new Patient { Active = true, Gender = AdministrativeGender.Male },  // uncoded
                new Patient { Active = true, Gender = AdministrativeGender.Female }, // uncoded
                new Observation { Code = new CodeableConcept("http://nu.nl", "x"), Status = ObservationStatus.Final }, // coded on Code
                new Observation { Code = new CodeableConcept("http://nu.nl", "y"), Status = ObservationStatus.Preliminary } // coded on Code
            ];

            var bundle = new Bundle();
            foreach (var r in resources) { bundle.AddResourceEntry(r, $"http://someresource/{r.GetHashCode()}"); }

            return new BundleDataSource(bundle, new HashValueSetDictionary());  // we're not calling IsInValueSet, so we can pass an empty dict
        }
    }
}