/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;

namespace CoreTests
{
    [TestClass]
    public class RetrieveProfileFilterTests
    {
        private const string QICore = "http://hl7.org/fhir/us/qicore/StructureDefinition/";

        private static Bundle ServiceRequestBundle() => new()
        {
            Entry =
            {
                new Bundle.EntryComponent
                {
                    Resource = new ServiceRequest { Id = "positive", DoNotPerform = false }
                },
                new Bundle.EntryComponent
                {
                    Resource = new ServiceRequest { Id = "negated", DoNotPerform = true }
                },
                new Bundle.EntryComponent
                {
                    Resource = new ServiceRequest { Id = "unspecified" }
                },
            }
        };

        private static IEnumerable<T> Retrieve<T>(Bundle bundle, string? templateId, FhirCqlContextOptions? options = null)
            where T : class
        {
            var ctx = FhirCqlContext.ForBundle(bundle, options: options);
            return ctx.Operators.Retrieve<T>(new RetrieveParameters(null, null, null, templateId))!;
        }

        [TestMethod]
        public void NegationProfileRetrieve_OnlyReturnsNegatedInstances()
        {
            var results = Retrieve<ServiceRequest>(ServiceRequestBundle(), QICore + "qicore-servicenotrequested").ToList();

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("negated", results[0].Id);
        }

        [TestMethod]
        public void PositiveProfileRetrieve_ExcludesNegatedInstances()
        {
            var results = Retrieve<ServiceRequest>(ServiceRequestBundle(), QICore + "qicore-servicerequest").ToList();

            CollectionAssert.AreEquivalent(new[] { "positive", "unspecified" }, results.Select(r => r.Id).ToList());
        }

        [TestMethod]
        public void UnknownProfileRetrieve_ReturnsEverything()
        {
            var results = Retrieve<ServiceRequest>(ServiceRequestBundle(), QICore + "qicore-some-unknown-profile").ToList();

            Assert.AreEqual(3, results.Count);
        }

        [TestMethod]
        public void RetrieveWithoutTemplateId_ReturnsEverything()
        {
            var results = Retrieve<ServiceRequest>(ServiceRequestBundle(), null).ToList();

            Assert.AreEqual(3, results.Count);
        }

        [TestMethod]
        public void ObservationCancelledRetrieve_FiltersByStatus()
        {
            var bundle = new Bundle
            {
                Entry =
                {
                    new Bundle.EntryComponent { Resource = new Observation { Id = "final", Status = ObservationStatus.Final } },
                    new Bundle.EntryComponent { Resource = new Observation { Id = "cancelled", Status = ObservationStatus.Cancelled } },
                }
            };

            var cancelled = Retrieve<Observation>(bundle, QICore + "qicore-observationcancelled").ToList();
            var positive = Retrieve<Observation>(bundle, QICore + "qicore-observation-screening-assessment").ToList();

            Assert.AreEqual("cancelled", cancelled.Single().Id);
            Assert.AreEqual("final", positive.Single().Id);
        }

        [TestMethod]
        public void OverriddenFilter_DisablesFiltering()
        {
            var options = new FhirCqlContextOptions { OverrideRetrieveProfileFilter = new NoProfileFilter() };

            var results = Retrieve<ServiceRequest>(ServiceRequestBundle(), QICore + "qicore-servicenotrequested", options).ToList();

            Assert.AreEqual(3, results.Count);
        }

        private class NoProfileFilter : IRetrieveProfileFilter
        {
            public Predicate<Resource>? GetFilter(string templateId) => null;
        }
    }
}
