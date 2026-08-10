/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace CoreTests.Fhir
{
    /// <summary>
    /// Covers the materialization of retrieve results: a retrieve decides membership once and hands back a
    /// materialized result, instead of a lazy chain that re-runs the cast, the code filter and the profile
    /// filter on every walk.
    /// </summary>
    /// <remarks>
    /// Two groups of tests live here. The <c>BehaviorLock_</c> tests pin the elements and the order every
    /// retrieve shape produces; they pass against the lazy implementation too, and exist so a change in
    /// <i>when</i> the work happens cannot quietly change <i>what</i> comes out. The <c>Materialized_</c> tests
    /// pin the materialization itself and fail against the lazy implementation, which is the point of them.
    /// </remarks>
    [TestClass]
    [TestCategory("UnitTest")]
    public class RetrieveMaterializationTests
    {
        private const string NuSystem = "http://nu.nl";
        private const string ObservationsValueSet = "http://example.org/fhir/ValueSet/observations";
        private const string CancelledObservationProfile =
            "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled";

        private static readonly FhirTypeResolver Model = new(ModelInfo.ModelInspector);

        private static PropertyInfo Prop(string typeName, string propertyName) =>
            Model.GetProperty(Model.ResolveType($"{{http://hl7.org/fhir}}{typeName}")!, propertyName)!;

        private static RetrieveParameters ByCodes(PropertyInfo? codeProperty, params CqlCode[] codes) =>
            new(codeProperty, null, codes, null);

        private static RetrieveParameters ByValueSet(PropertyInfo? codeProperty, string valueSetId) =>
            new(codeProperty, new CqlValueSet(valueSetId, null), null, null);

        /// <summary>
        /// The resources of the test bundle, held by reference so the tests can assert on element identity
        /// rather than on ids or counts.
        /// </summary>
        private sealed class Fixture
        {
            public Patient Patient { get; } = new() { Id = "pat", Active = true };

            public Observation ObsX { get; } = new()
            {
                Id = "obs-x",
                Code = new CodeableConcept(NuSystem, "x"),
                Category = [new CodeableConcept(NuSystem, "cat1")],
                Status = ObservationStatus.Final
            };

            public Observation ObsY { get; } = new()
            {
                Id = "obs-y",
                Code = new CodeableConcept(NuSystem, "y"),
                Category = [new CodeableConcept(NuSystem, "cat1")],
                Status = ObservationStatus.Cancelled
            };

            public Observation ObsZ { get; } = new()
            {
                Id = "obs-z",
                Code = new CodeableConcept(NuSystem, "z"),
                Category = [new CodeableConcept(NuSystem, "cat2")],
                Status = ObservationStatus.Final
            };

            /// <summary>
            /// Carries two matching codings on both its primary code path and its category, so a filter that
            /// accepts both still has to yield the resource exactly once.
            /// </summary>
            public Observation ObsDup { get; } = new()
            {
                Id = "obs-dup",
                Code = new CodeableConcept
                {
                    Coding = [new Coding(NuSystem, "dup1"), new Coding(NuSystem, "dup2")]
                },
                Category =
                [
                    new CodeableConcept(NuSystem, "cat3"),
                    new CodeableConcept(NuSystem, "cat4")
                ],
                Status = ObservationStatus.Final
            };

            public Condition Condition { get; } = new() { Id = "con-x", Code = new CodeableConcept(NuSystem, "x") };

            /// <summary>The bundle's entries, in order. Retrieves must preserve this relative order.</summary>
            public Resource[] InBundleOrder => [Patient, ObsX, ObsY, ObsZ, ObsDup, Condition];

            public Observation[] ObservationsInBundleOrder => [ObsX, ObsY, ObsZ, ObsDup];

            public Bundle Bundle
            {
                get
                {
                    var bundle = new Bundle();
                    foreach (var resource in InBundleOrder)
                        bundle.AddResourceEntry(resource, $"http://example.org/{resource.TypeName}/{resource.Id}");
                    return bundle;
                }
            }
        }

        private static HashValueSetDictionary ValueSets()
        {
            var valueSets = new HashValueSetDictionary();
            // Matches obs-x and obs-z, but not obs-y - so the value set retrieve is a real filter.
            valueSets.Add(ObservationsValueSet, [new CqlCode("x", NuSystem), new CqlCode("z", NuSystem)]);
            return valueSets;
        }

        private static BundleDataSource DataSource(
            Fixture fixture,
            IValueSetDictionary? valueSets = null,
            IRetrieveProfileFilter? profileFilter = null) =>
            new(fixture.Bundle, valueSets ?? ValueSets(), profileFilter: profileFilter);

        /// <summary>
        /// An <see cref="IRetrieveProfileFilter"/> that records how often the profile predicate was applied to an
        /// instance. Everything else is delegated to <see cref="QICoreRetrieveProfileFilter.Default"/>, so the
        /// retrieve keeps exactly the results it has without the counter.
        /// </summary>
        private sealed class CountingProfileFilter(IRetrieveProfileFilter inner) : IRetrieveProfileFilter
        {
            /// <summary>The number of instances the profile predicate was applied to.</summary>
            public int FilterApplications { get; private set; }

            public Predicate<Resource>? GetFilter(string templateId)
            {
                if (inner.GetFilter(templateId) is not { } filter)
                    return null;

                return resource =>
                {
                    FilterApplications++;
                    return filter(resource);
                };
            }
        }

        /// <summary>
        /// An <see cref="IValueSetDictionary"/> that records how often membership was asked for. Everything
        /// else is delegated, so the retrieve behaves exactly as it would with the wrapped dictionary.
        /// </summary>
        private sealed class CountingValueSetDictionary(IValueSetDictionary inner) : IValueSetDictionary
        {
            /// <summary>The number of <c>IsCodeInValueSet(uri, code, system)</c> calls, i.e. membership decisions.</summary>
            public int MembershipChecks { get; private set; }

            public bool IsCodeInValueSet(string valueSetUri, CqlCode code)
            {
                MembershipChecks++;
                return inner.IsCodeInValueSet(valueSetUri, code);
            }

            public bool IsCodeInValueSet(string valueSetUri, string code)
            {
                MembershipChecks++;
                return inner.IsCodeInValueSet(valueSetUri, code);
            }

            public bool IsCodeInValueSet(string valueSetUri, string code, string? system)
            {
                MembershipChecks++;
                return inner.IsCodeInValueSet(valueSetUri, code, system);
            }

            public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes) =>
                inner.TryGetCodesInValueSet(valueSetUri, out codes);
        }

        #region Behavior lock - elements and order per retrieve shape (must hold for a lazy result too)

        [TestMethod]
        public void BehaviorLock_RetrieveByTypeOnly_ReturnsEveryResourceOfThatTypeInBundleOrder()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            var results = dr.Retrieve<Observation>(null);

            results.Should().Equal(fixture.ObservationsInBundleOrder, ReferenceEquals);
        }

        [TestMethod]
        public void BehaviorLock_RetrieveByCodeList_ReturnsTheMatchingResourcesInBundleOrder()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            var results = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("z", NuSystem), new CqlCode("x", NuSystem)));

            // Bundle order, not the order the codes were listed in.
            results.Should().Equal(new[] { fixture.ObsX, fixture.ObsZ }, ReferenceEquals);
        }

        [TestMethod]
        public void BehaviorLock_RetrieveByValueSet_ReturnsTheMatchingResourcesInBundleOrder()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            var results = dr.Retrieve<Observation>(ByValueSet(null, ObservationsValueSet));

            results.Should().Equal(new[] { fixture.ObsX, fixture.ObsZ }, ReferenceEquals);
        }

        [TestMethod]
        public void BehaviorLock_RetrieveWithExplicitCodeProperty_FiltersOnThatProperty()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            var byCategory = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "category"), new CqlCode("cat1", NuSystem)));
            var byCode = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("cat1", NuSystem)));

            byCategory.Should().Equal(new[] { fixture.ObsX, fixture.ObsY }, ReferenceEquals);
            byCode.Should().BeEmpty();
        }

        [TestMethod]
        public void BehaviorLock_RetrieveByValueSetOnExplicitCodeProperty_FiltersOnThatProperty()
        {
            var fixture = new Fixture();
            var valueSets = ValueSets();
            valueSets.Add("http://example.org/fhir/ValueSet/categories", [new CqlCode("cat2", NuSystem)]);
            var dr = DataSource(fixture, valueSets);

            var results = dr.Retrieve<Observation>(
                ByValueSet(Prop("Observation", "category"), "http://example.org/fhir/ValueSet/categories"));

            results.Should().Equal(new[] { fixture.ObsZ }, ReferenceEquals);
        }

        [TestMethod]
        public void BehaviorLock_RetrieveWhereSeveralCodingsOfAResourceMatch_ReturnsThatResourceOnce()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            // obs-dup carries two matching codings on each of these paths; the filter's at-most-once guard
            // must collapse them, whether the codings are tested lazily or up front.
            var onPrimaryCodePath = dr.Retrieve<Observation>(
                ByCodes(null, new CqlCode("dup1", NuSystem), new CqlCode("dup2", NuSystem))).ToList();
            var onCodeProperty = dr.Retrieve<Observation>(
                ByCodes(Prop("Observation", "category"), new CqlCode("cat3", NuSystem), new CqlCode("cat4", NuSystem))).ToList();

            onPrimaryCodePath.Should().HaveCount(1);
            onPrimaryCodePath.Should().Equal(new[] { fixture.ObsDup }, ReferenceEquals);
            onCodeProperty.Should().HaveCount(1);
            onCodeProperty.Should().Equal(new[] { fixture.ObsDup }, ReferenceEquals);
        }

        [TestMethod]
        public void BehaviorLock_RetrieveByACodeThatMatchesNothing_ReturnsEmpty()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            dr.Retrieve<Observation>(ByCodes(null, new CqlCode("nope", NuSystem))).Should().BeEmpty();
            dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("nope", NuSystem))).Should().BeEmpty();
            dr.Retrieve<Observation>(ByValueSet(null, "http://example.org/fhir/ValueSet/unknown")).Should().BeEmpty();
        }

        [TestMethod]
        public void BehaviorLock_RetrieveOfATypeNotInTheBundle_ReturnsEmpty()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            dr.Retrieve<Procedure>(null).Should().BeEmpty();
            dr.Retrieve<Procedure>(ByCodes(null, new CqlCode("x", NuSystem))).Should().BeEmpty();
            dr.Retrieve<Procedure>(ByValueSet(null, ObservationsValueSet)).Should().BeEmpty();
        }

        [TestMethod]
        public void BehaviorLock_RetrieveOnABaseType_ReturnsAllDerivedResourcesInBundleOrder()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            var results = dr.Retrieve<DomainResource>(null);

            results.Should().Equal(fixture.InBundleOrder, ReferenceEquals);
        }

        [TestMethod]
        public void BehaviorLock_RetrieveWithAProfileFilter_ReturnsOnlyConformingResourcesInBundleOrder()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            // qicore-observationcancelled keeps only cancelled observations.
            var results = dr.Retrieve<Observation>(new RetrieveParameters(null, null, null, CancelledObservationProfile));

            results.Should().Equal(new[] { fixture.ObsY }, ReferenceEquals);
        }

        [TestMethod]
        public void BehaviorLock_RetrieveEnumeratedTwice_YieldsTheSameElementsInTheSameOrder()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            foreach (var parameters in new RetrieveParameters?[]
                     {
                         null,
                         ByCodes(null, new CqlCode("x", NuSystem), new CqlCode("z", NuSystem)),
                         ByValueSet(null, ObservationsValueSet),
                         ByCodes(Prop("Observation", "category"), new CqlCode("cat1", NuSystem)),
                         new RetrieveParameters(null, null, null, CancelledObservationProfile)
                     })
            {
                var results = dr.Retrieve<Observation>(parameters);

                var first = results.ToList();
                var second = results.ToList();

                second.Should().Equal(first, ReferenceEquals);
            }
        }

        #endregion

        #region Materialization - expected to FAIL against the lazy implementation on develop

        /// <summary>
        /// NEW BEHAVIOR - fails against <c>develop</c>, where <c>FilterByType&lt;T&gt;()</c> returns a fresh
        /// <c>resources.Cast&lt;T&gt;()</c> per call, so the two calls are never the same object.
        /// </summary>
        [TestMethod]
        public void Materialized_FilterByTypeCalledTwice_ReturnsTheSameInstance()
        {
            var fixture = new Fixture();
            var bundle = new IndexedBundle(fixture.Bundle.Entry);

            var first = bundle.FilterByType<Observation>();
            var second = bundle.FilterByType<Observation>();

            second.Should().BeSameAs(first);
            first.Should().Equal(fixture.ObservationsInBundleOrder, ReferenceEquals);
        }

        /// <summary>
        /// NEW BEHAVIOR - fails against <c>develop</c>, where the untyped retrieve hands back a lazy cast that
        /// is a different object on every retrieve of the same type.
        /// </summary>
        [TestMethod]
        public void Materialized_RetrieveByTypeOnlyTwice_ReturnsTheSameInstance()
        {
            var fixture = new Fixture();
            var dr = DataSource(fixture);

            var first = dr.Retrieve<Observation>(null);
            var second = dr.Retrieve<Observation>(null);

            second.Should().BeSameAs(first);
        }

        /// <summary>
        /// NEW BEHAVIOR - fails against <c>develop</c>, where <c>IndexedBundle.Filter</c> is a
        /// <c>yield return</c> iterator: every walk of the retrieve result re-asks
        /// <see cref="IValueSetDictionary.IsCodeInValueSet(string, string, string?)"/> for each candidate
        /// coding, so the second walk doubles the number of membership decisions.
        /// </summary>
        [TestMethod]
        public void Materialized_ValueSetRetrieveEnumeratedTwice_ChecksMembershipOnlyOnce()
        {
            var fixture = new Fixture();
            var counting = new CountingValueSetDictionary(ValueSets());
            var dr = DataSource(fixture, counting);

            var results = dr.Retrieve<Observation>(ByValueSet(null, ObservationsValueSet));

            var firstWalk = results.ToList();
            var checksAfterFirstWalk = counting.MembershipChecks;

            var secondWalk = results.ToList();
            var checksAfterSecondWalk = counting.MembershipChecks;

            // The filter really ran - otherwise "no extra checks" would be vacuously true.
            checksAfterFirstWalk.Should().BeGreaterThan(0);
            checksAfterSecondWalk.Should().Be(checksAfterFirstWalk,
                "the bundle is immutable during an evaluation, so membership is decided once and the result reused");

            secondWalk.Should().Equal(firstWalk, ReferenceEquals);
            firstWalk.Should().Equal(new[] { fixture.ObsX, fixture.ObsZ }, ReferenceEquals);
        }

        /// <summary>
        /// NEW BEHAVIOR - fails against <c>develop</c>, for the same reason as
        /// <see cref="Materialized_ValueSetRetrieveEnumeratedTwice_ChecksMembershipOnlyOnce"/>, but with the
        /// code filter reached through an explicit code property rather than the primary code path.
        /// </summary>
        [TestMethod]
        public void Materialized_ValueSetRetrieveOnCodePropertyEnumeratedTwice_ChecksMembershipOnlyOnce()
        {
            var fixture = new Fixture();
            var valueSets = ValueSets();
            valueSets.Add("http://example.org/fhir/ValueSet/categories", [new CqlCode("cat2", NuSystem)]);
            var counting = new CountingValueSetDictionary(valueSets);
            var dr = DataSource(fixture, counting);

            var results = dr.Retrieve<Observation>(
                ByValueSet(Prop("Observation", "category"), "http://example.org/fhir/ValueSet/categories"));

            results.ToList();
            var checksAfterFirstWalk = counting.MembershipChecks;

            results.ToList();

            checksAfterFirstWalk.Should().BeGreaterThan(0);
            counting.MembershipChecks.Should().Be(checksAfterFirstWalk);
        }

        /// <summary>
        /// NEW BEHAVIOR - fails against <c>develop</c>. The profile filter is the third eager path: on
        /// <c>develop</c> it is a lazy <c>Where</c>, so every walk of the retrieve result re-applies the profile
        /// predicate to each candidate. Counting the applications is what distinguishes the two, as the elements
        /// a <c>Where</c> chain yields are identical.
        /// </summary>
        [TestMethod]
        public void Materialized_ProfileFilteredRetrieveEnumeratedTwice_AppliesTheProfileFilterOnlyOnce()
        {
            var fixture = new Fixture();
            var counting = new CountingProfileFilter(QICoreRetrieveProfileFilter.Default);
            var dr = DataSource(fixture, profileFilter: counting);

            // qicore-observationcancelled keeps only cancelled observations.
            var results = dr.Retrieve<Observation>(new RetrieveParameters(null, null, null, CancelledObservationProfile));

            var firstWalk = results.ToList();
            var applicationsAfterFirstWalk = counting.FilterApplications;

            var secondWalk = results.ToList();

            // The filter really ran - otherwise "no extra applications" would be vacuously true.
            applicationsAfterFirstWalk.Should().BeGreaterThan(0);
            counting.FilterApplications.Should().Be(applicationsAfterFirstWalk,
                "the bundle is immutable during an evaluation, so the profile decision is made once and the result reused");

            secondWalk.Should().Equal(firstWalk, ReferenceEquals);
            firstWalk.Should().Equal(new[] { fixture.ObsY }, ReferenceEquals);
        }

        #endregion
    }
}
