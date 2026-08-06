/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Comparers;
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

        private static readonly FhirTypeResolver Model = new(ModelInfo.ModelInspector);

        private static PropertyInfo ObservationCodeProperty() =>
            Model.GetProperty(Model.ResolveType("{http://hl7.org/fhir}Observation")!, "code")!;

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

        private static RetrieveParameters ByCodes(params CqlCode[] codes) => new(null, null, codes, null);

        private static RetrieveParameters ByCodeProperty(params CqlCode[] codes)
        {
            var prop = ObservationCodeProperty();
            return new(prop, null, codes, null);
        }

        /// <summary>
        /// A value set dictionary that reports exactly the codes it was given as members of every value set.
        /// </summary>
        private sealed class StubValueSets(params string[] members) : IValueSetDictionary
        {
            private readonly HashSet<string> _members = [.. members];

            public bool IsCodeInValueSet(string valueSetUri, CqlCode code) => code.code is { } bareCode && IsCodeInValueSet(valueSetUri, bareCode, code.system);

            public bool IsCodeInValueSet(string valueSetUri, string code) => _members.Contains(code);

            public bool IsCodeInValueSet(string valueSetUri, string code, string? system) => _members.Contains(code);

            public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes)
            {
                codes = _members.Select(code => new CqlCode(code, NuSystem)).ToList();
                return true;
            }
        }

        /// <summary>
        /// A profile filter that accepts only resources whose id starts with a given prefix.
        /// </summary>
        private sealed class IdPrefixFilter(string prefix) : IRetrieveProfileFilter
        {
            public Predicate<Resource>? GetFilter(string templateId) =>
                templateId == "urn:test:profile" ? r => r.Id?.StartsWith(prefix) == true : null;
        }

        // ─── index sharing ──────────────────────────────────────────────────────────

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

            Assert.ThrowsException<ArgumentNullException>(() => source.WithValueSets(null!));
        }

        // ─── retrieve by type ────────────────────────────────────────────────────────

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

        // ─── retrieve by value set ────────────────────────────────────────────────────

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

        // ─── retrieve by codes ────────────────────────────────────────────────────────

        [TestMethod]
        public void RetrieveByCodes_OnAClone_UsesDefaultComparersFromTheSource()
        {
            var source = BuildDataSource();
            var clone = source.WithValueSets(new StubValueSets());

            // Default comparers are case-insensitive; "X" should match code "x".
            var result = clone.Retrieve<Observation>(ByCodes(new CqlCode("X", NuSystem))).ToList();

            result.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodes_CloneInheritsNonDefaultComparers()
        {
            // Build a source with case-sensitive comparers (so "X" does NOT match "x").
            var caseSensitiveComparer = new StringCqlComparer(StringComparer.Ordinal);
            var source = new BundleDataSource(BuildBundle(), new HashValueSetDictionary(),
                codeComparer: caseSensitiveComparer, systemComparer: caseSensitiveComparer);

            var clone = source.WithValueSets(new StubValueSets());

            // Case-sensitive: "X" does not match "x"; "x" does.
            clone.Retrieve<Observation>(ByCodes(new CqlCode("X", NuSystem))).Should().BeEmpty();
            clone.Retrieve<Observation>(ByCodes(new CqlCode("x", NuSystem)))
                 .Select(o => o.Id).Should().Equal("obs-x");
        }

        // ─── retrieve by code property (_codedByProperty) ────────────────────────────

        [TestMethod]
        public void RetrieveByCodeProperty_OnAClone_UsesTheSharedPropertyCache()
        {
            var source = BuildDataSource();
            var cloneA = source.WithValueSets(new StubValueSets());
            var cloneB = source.WithValueSets(new StubValueSets());

            var fromA = cloneA.Retrieve<Observation>(ByCodeProperty(new CqlCode("x", NuSystem))).ToList();
            var fromB = cloneB.Retrieve<Observation>(ByCodeProperty(new CqlCode("x", NuSystem))).ToList();

            // Both clones see the same resources and they share the same property cache.
            fromA.Select(o => o.Id).Should().Equal("obs-x");
            fromB.Should().Equal(fromA);
            cloneA.Bundle.Should().BeSameAs(cloneB.Bundle, "both clones share the same IndexedBundle");
        }

        // ─── profile filter ──────────────────────────────────────────────────────────

        [TestMethod]
        public void WithValueSets_InheritsProfileFilterFromSource()
        {
            var filter = new IdPrefixFilter("obs-x");
            var source = new BundleDataSource(BuildBundle(), new HashValueSetDictionary(), profileFilter: filter);
            var clone = source.WithValueSets(new StubValueSets());

            // Profile filter on the clone should drop obs-y (its id does not start with "obs-x").
            var templateIdParams = new RetrieveParameters(null, null, null, "urn:test:profile");
            var result = clone.Retrieve<Observation>(templateIdParams).ToList();

            result.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void WithValueSets_ProfileFilterOverrideTakesPrecedenceOverSourceFilter()
        {
            // Source uses a filter that accepts only obs-x.
            var sourceFilter = new IdPrefixFilter("obs-x");
            var source = new BundleDataSource(BuildBundle(), new HashValueSetDictionary(), profileFilter: sourceFilter);

            // Clone overrides the filter to accept only obs-y.
            var cloneFilter = new IdPrefixFilter("obs-y");
            var clone = source.WithValueSets(new StubValueSets(), profileFilter: cloneFilter);

            var templateIdParams = new RetrieveParameters(null, null, null, "urn:test:profile");

            // Source still uses its own filter.
            source.Retrieve<Observation>(templateIdParams).Select(o => o.Id).Should().Equal("obs-x");
            // Clone uses the override filter.
            clone.Retrieve<Observation>(templateIdParams).Select(o => o.Id).Should().Equal("obs-y");
        }

        // ─── sentinel ────────────────────────────────────────────────────────────────

        [TestMethod]
        public void DataSourceForBundle_DirectRetrieveByValueSet_Throws()
        {
            var source = FhirCqlContext.DataSourceForBundle(BuildBundle());

            // Retrieving by value set without rebinding must throw, not silently return empty.
            Assert.ThrowsException<InvalidOperationException>(
                () => source.Retrieve<Observation>(ByValueSet()).ToList());
        }

        [TestMethod]
        public void DataSourceForBundle_DirectRetrieveByType_Succeeds()
        {
            // Type-only retrieves do not consult value sets, so the sentinel must not block them.
            var source = FhirCqlContext.DataSourceForBundle(BuildBundle());

            source.Retrieve<Observation>(null).Select(o => o.Id).Should().Equal("obs-x", "obs-y");
        }

        // ─── public API ──────────────────────────────────────────────────────────────

        [TestMethod]
        public void DataSourceForBundle_NullBundle_Throws()
        {
            Assert.ThrowsException<ArgumentNullException>(() => FhirCqlContext.DataSourceForBundle(null!));
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

        [TestMethod]
        public void WithDataSource_ProfileFilterOptionOverridesSourceFilter()
        {
            // Source built with a filter that accepts only obs-x.
            var sourceFilter = new IdPrefixFilter("obs-x");
            var source = (BundleDataSource)FhirCqlContext.DataSourceForBundle(BuildBundle(),
                new FhirCqlContextOptions { OverrideRetrieveProfileFilter = sourceFilter });

            // WithDataSource overrides the filter to accept only obs-y.
            var overrideFilter = new IdPrefixFilter("obs-y");
            var ctx = FhirCqlContext.WithDataSource(source, valueSets: new StubValueSets(),
                options: new FhirCqlContextOptions { OverrideRetrieveProfileFilter = overrideFilter });

            var templateIdParams = new RetrieveParameters(null, null, null, "urn:test:profile");
            ctx.Operators.Retrieve<Observation>(templateIdParams).Select(o => o.Id).Should().Equal("obs-y");
        }

        [TestMethod]
        public void WithDataSource_CompositeContainingBundleDataSource_RebindsValueSetsOnTheBundlePart()
        {
            var bundleSource = FhirCqlContext.DataSourceForBundle(BuildBundle());
            var composite = new CompositeDataSource(bundleSource);

            var ctx = FhirCqlContext.WithDataSource(composite, valueSets: new StubValueSets("x"));

            // The bundle part has been rebound; value-set retrieve must work.
            ctx.Operators.Retrieve<Observation>(ByValueSet()).Select(o => o.Id).Should().Equal("obs-x");
        }

        // ─── concurrency ─────────────────────────────────────────────────────────────

        [TestMethod]
        public void Retrieve_OnSourcesSharingAnIndexFromParallelTasks_ReturnsCorrectResults()
        {
            var source = BuildDataSource();
            var knowsX = source.WithValueSets(new StubValueSets("x"));
            var knowsY = source.WithValueSets(new StubValueSets("y"));
            var codePropertyParams = ByCodeProperty(new CqlCode("x", NuSystem));

            // Gate all 8 tasks so they start retrieves simultaneously, exercising concurrent cache access.
            using var gate = new System.Threading.ManualResetEventSlim(false);

            var tasks = Enumerable.Range(0, 8)
                .Select(index => Task.Run(() =>
                {
                    gate.Wait();

                    var (dataSource, expectedVs) = index % 2 == 0 ? (knowsX, "obs-x") : (knowsY, "obs-y");

                    for (var repeat = 0; repeat < 50; repeat++)
                    {
                        dataSource.Retrieve<Observation>(ByValueSet()).Select(o => o.Id).Should().Equal(expectedVs);
                        dataSource.Retrieve<Observation>(null).Select(o => o.Id).Should().Equal("obs-x", "obs-y");
                        dataSource.Retrieve<Observation>(codePropertyParams).Select(o => o.Id).Should().Equal("obs-x");
                    }
                }))
                .ToArray();

            gate.Set();
            Task.WaitAll(tasks);
        }
    }
}
