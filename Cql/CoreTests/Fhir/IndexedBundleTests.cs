/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Fhir.Model;

namespace CoreTests.Fhir
{
    [TestClass]
    public class IndexedBundleTests
    {
        private static readonly FhirTypeResolver Model = new(ModelInfo.ModelInspector);

        private static PropertyInfo ResolveCodeProperty() =>
            Model.GetProperty(Model.ResolveType("{http://hl7.org/fhir}Observation")!, "code")!;

        private static IndexedBundle BuildBundle() =>
            new([
                new Bundle.EntryComponent
                {
                    Resource = new Observation
                    {
                        Id = "obs-1",
                        Code = new CodeableConcept("http://nu.nl", "x")
                    }
                }
            ]);

        [TestMethod]
        public void FilterByType_SeparatelyResolvedPropertyInfoForSameProperty_ExtractsCodingsOnce()
        {
            var bundle = BuildBundle();
            var extractions = 0;

            IEnumerable<Coding> CountingGetCodes(Observation observation)
            {
                extractions++;
                return observation.Code.Coding;
            }

            bundle.FilterByType<Observation>(_ => true, ResolveCodeProperty(), CountingGetCodes).ToList();
            var extractionsAfterFirstRetrieve = extractions;

            // A retrieve resolving the same property again must reuse the codings extracted by the first one,
            // even though the resolver hands out a fresh PropertyInfo wrapper per lookup.
            var second = bundle.FilterByType<Observation>(_ => true, ResolveCodeProperty(), CountingGetCodes).ToList();

            extractionsAfterFirstRetrieve.Should().Be(1);
            extractions.Should().Be(extractionsAfterFirstRetrieve);
            second.Select(o => o.Id).Should().Equal("obs-1");
        }
    }
}
