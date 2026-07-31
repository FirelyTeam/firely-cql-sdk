/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

namespace CoreTests.Fhir
{
    /// <summary>
    /// Tests for sharing one index over a bundle between data sources that each bind their own value sets,
    /// see https://github.com/FirelyTeam/firely-cql-sdk/issues/1466.
    /// </summary>
    [TestClass]
    public class SharedBundleIndexTests
    {
        private const string NuSystem = "http://nu.nl";
        private const string ValueSetUri = "http://example.org/fhir/ValueSet/observations";

        private static Bundle BuildBundle()
        {
            Resource[] resources =
            [
                new Patient { Id = "pat", Active = true },
                new Observation { Id = "obs-x", Code = new CodeableConcept(NuSystem, "x"), Status = ObservationStatus.Final },
                new Observation { Id = "obs-y", Code = new CodeableConcept(NuSystem, "y"), Status = ObservationStatus.Final },
                new Condition { Id = "con-x", Code = new CodeableConcept(NuSystem, "x") }
            ];

            var bundle = new Bundle();
            foreach (var resource in resources)
                bundle.AddResourceEntry(resource, $"http://example.org/{resource.TypeName}/{resource.Id}");

            return bundle;
        }

        private static BundleDataSource BuildDataSource() =>
            new(BuildBundle(), new HashValueSetDictionary());

        private static RetrieveParameters ByValueSet() => new(null, new CqlValueSet(ValueSetUri, null), null, null);

        /// <summary>
        /// A value set dictionary that reports exactly the codes it was given as members of every value set.
        /// </summary>
        private sealed class StubValueSets(params string[] members) : IValueSetDictionary
        {
            private readonly HashSet<string> _members = [.. members];

            public bool IsCodeInValueSet(string valueSetUri, CqlCode code) => IsCodeInValueSet(valueSetUri, code.code, code.system);

            public bool IsCodeInValueSet(string valueSetUri, string code) => _members.Contains(code);

            public bool IsCodeInValueSet(string valueSetUri, string code, string system) => _members.Contains(code);

            public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode> codes)
            {
                codes = _members.Select(code => new CqlCode(code, NuSystem)).ToList();
                return true;
            }
        }

        [TestMethod]
        public void WithValueSets_ReusesTheIndexOfTheSourceItWasCreatedFrom()
        {
            var source = BuildDataSource();

            var clone = source.WithValueSets(new StubValueSets());

            clone.Should().NotBeSameAs(source);
            clone.Bundle.Should().BeSameAs(source.Bundle, "the index must be shared, not rebuilt");
        }

        [TestMethod]
        public void WithValueSets_SameValueSets_ReturnsTheSourceItself()
        {
            var valueSets = new StubValueSets();
            var source = new BundleDataSource(BuildBundle(), valueSets);

            source.WithValueSets(valueSets).Should().BeSameAs(source);
        }

        [TestMethod]
        public void WithValueSets_NullValueSets_Throws()
        {
            var source = BuildDataSource();

            Assert.ThrowsException<ArgumentNullException>(() => source.WithValueSets(null));
        }

        [TestMethod]
        public void RetrieveByType_OnASourceSharingAnIndex_ReturnsTheSameResourcesAsTheOriginal()
        {
            var source = BuildDataSource();
            var clone = source.WithValueSets(new StubValueSets());

            var original = source.Retrieve<Observation>(null).ToList();
            var shared = clone.Retrieve<Observation>(null).ToList();

            shared.Should().Equal(original);
            shared.Select(o => o.Id).Should().Equal("obs-x", "obs-y");
            clone.Retrieve<Patient>(null).Select(p => p.Id).Should().Equal("pat");
        }

        [TestMethod]
        public void RetrieveByValueSet_OnSourcesSharingAnIndex_ConsultsTheValueSetsOfTheSourceRetrievedFrom()
        {
            var source = BuildDataSource();
            var knowsX = source.WithValueSets(new StubValueSets("x"));
            var knowsY = source.WithValueSets(new StubValueSets("y"));

            knowsX.Retrieve<Observation>(ByValueSet()).Select(o => o.Id).Should().Equal("obs-x");
            knowsY.Retrieve<Observation>(ByValueSet()).Select(o => o.Id).Should().Equal("obs-y");

            // The source they were created from keeps its own (empty) value sets.
            source.Retrieve<Observation>(ByValueSet()).Should().BeEmpty();
        }

        [TestMethod]
        public void Retrieve_OnSourcesSharingAnIndexFromParallelTasks_ReturnsCorrectResults()
        {
            var source = BuildDataSource();
            var knowsX = source.WithValueSets(new StubValueSets("x"));
            var knowsY = source.WithValueSets(new StubValueSets("y"));

            var tasks = Enumerable.Range(0, 8)
                .Select(index => Task.Run(() =>
                {
                    var (dataSource, expected) = index % 2 == 0 ? (knowsX, "obs-x") : (knowsY, "obs-y");

                    for (var repeat = 0; repeat < 50; repeat++)
                    {
                        dataSource.Retrieve<Observation>(ByValueSet()).Select(o => o.Id).Should().Equal(expected);
                        dataSource.Retrieve<Observation>(null).Select(o => o.Id).Should().Equal("obs-x", "obs-y");
                    }
                }))
                .ToArray();

            Task.WaitAll(tasks);
        }

        [TestMethod]
        public void DataSourceForBundle_ReturnsASourceOverTheBundle()
        {
            var source = FhirCqlContext.DataSourceForBundle(BuildBundle());

            source.Retrieve<Observation>(null).Select(o => o.Id).Should().Equal("obs-x", "obs-y");
        }

        [TestMethod]
        public void DataSourceForBundle_NullBundle_Throws()
        {
            Assert.ThrowsException<ArgumentNullException>(() => FhirCqlContext.DataSourceForBundle(null));
        }

        [TestMethod]
        public void WithDataSource_ReusedBundleDataSource_BindsTheValueSetsOfEachContext()
        {
            var source = (BundleDataSource)FhirCqlContext.DataSourceForBundle(BuildBundle());

            var first = FhirCqlContext.WithDataSource(source, valueSets: new StubValueSets("x"));
            var second = FhirCqlContext.WithDataSource(source, valueSets: new StubValueSets("y"));

            first.Operators.Retrieve<Observation>(ByValueSet()).Select(o => o.Id).Should().Equal("obs-x");
            second.Operators.Retrieve<Observation>(ByValueSet()).Select(o => o.Id).Should().Equal("obs-y");

            // Neither context rebuilt the index over the bundle.
            DataSourceOf(first).Bundle.Should().BeSameAs(source.Bundle);
            DataSourceOf(second).Bundle.Should().BeSameAs(source.Bundle);

            static BundleDataSource DataSourceOf(CqlContext context) => (BundleDataSource)((CqlOperators)context.Operators).DataSource;
        }
    }
}
