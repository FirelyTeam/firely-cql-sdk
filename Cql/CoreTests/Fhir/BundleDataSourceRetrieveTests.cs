/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace CoreTests.Fhir
{
    [TestClass]
    public class BundleDataSourceRetrieveTests
    {
        private const string NuSystem = "http://nu.nl";
        private const string OtherSystem = "http://ergens.anders.nl";
        private const string ObservationsValueSet = "http://example.org/fhir/ValueSet/observations";

        private static readonly FhirTypeResolver Model = new(ModelInfo.ModelInspector);

        private static PropertyInfo Prop(string typeName, string propertyName) =>
            Model.GetProperty(Model.ResolveType($"{{http://hl7.org/fhir}}{typeName}")!, propertyName);

        private static RetrieveParameters ByCodes(PropertyInfo codeProperty, params CqlCode[] codes) =>
            new(codeProperty, null, codes, null);

        private static RetrieveParameters ByValueSet(PropertyInfo codeProperty, string valueSetId) =>
            new(codeProperty, new CqlValueSet(valueSetId, null), null, null);

        private static BundleDataSource BuildDataSource(
            ICqlComparer<string> codeComparer = null,
            ICqlComparer<string> systemComparer = null)
        {
            Resource[] resources =
            [
                new Patient { Id = "pat", Active = true, Gender = AdministrativeGender.Male },
                new Observation
                {
                    Id = "obs-x",
                    Code = new CodeableConcept(NuSystem, "x"),
                    Category = [new CodeableConcept(NuSystem, "cat1")],
                    Status = ObservationStatus.Final
                },
                new Observation
                {
                    Id = "obs-multi",
                    Code = new CodeableConcept
                    {
                        Coding =
                        [
                            new Coding(NuSystem, "m1"),
                            new Coding(NuSystem, "m2"),
                            new Coding(OtherSystem, "m3")
                        ]
                    },
                    Category = [new CodeableConcept(NuSystem, "m1"), new CodeableConcept(NuSystem, "m2")],
                    Status = ObservationStatus.Final
                },
                new Observation
                {
                    Id = "obs-nosys",
                    Code = new CodeableConcept { Coding = [new Coding(null, "nosys")] },
                    Status = ObservationStatus.Final
                },
                new Condition { Id = "con-x", Code = new CodeableConcept(NuSystem, "x") }
            ];

            var bundle = new Bundle();
            foreach (var resource in resources)
                bundle.AddResourceEntry(resource, $"http://example.org/{resource.TypeName}/{resource.Id}");

            var valueSets = new HashValueSetDictionary();
            valueSets.Add(ObservationsValueSet, [new CqlCode("x", NuSystem)]);

            return new BundleDataSource(bundle, valueSets, codeComparer, systemComparer);
        }

        private static BundleDataSource EmptyDataSource() =>
            new(new Bundle(), new HashValueSetDictionary());

        [TestMethod]
        public void RetrieveByValueSetOnPrimaryCodePath_ReturnsResourcesWithACodeInTheValueSet()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<Observation>(ByValueSet(null, ObservationsValueSet));

            results.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByValueSetOnPrimaryCodePath_ReturnsSameResultsOnSuccessiveRetrieves()
        {
            var dr = BuildDataSource();

            var first = dr.Retrieve<Observation>(ByValueSet(null, ObservationsValueSet)).ToList();
            var second = dr.Retrieve<Observation>(ByValueSet(null, ObservationsValueSet)).ToList();

            second.Should().Equal(first);
            second.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnPrimaryCodePath_ReturnsSameResultsOnSuccessiveRetrieves()
        {
            var dr = BuildDataSource();

            var first = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", NuSystem))).ToList();
            var second = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", NuSystem))).ToList();

            second.Should().Equal(first);
            second.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnCodeProperty_ReturnsSameResultsOnSuccessiveRetrieves()
        {
            var dr = BuildDataSource();
            var codeProp = Prop("Observation", "code");

            var first = dr.Retrieve<Observation>(ByCodes(codeProp, new CqlCode("x", NuSystem))).ToList();
            var second = dr.Retrieve<Observation>(ByCodes(codeProp, new CqlCode("x", NuSystem))).ToList();

            second.Should().Equal(first);
            second.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnSeparatelyResolvedCodeProperty_ReturnsSameResults()
        {
            var dr = BuildDataSource();

            // Resolving the same property twice hands out two distinct PropertyInfo instances.
            var first = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("x", NuSystem))).ToList();
            var second = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("x", NuSystem))).ToList();

            second.Should().Equal(first);
            second.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnScalarDataTypeProperty_ReturnsResourcesWithAMatchingCode()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("x", NuSystem)));

            results.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnListDataTypeProperty_ReturnsResourcesWithAMatchingCode()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "category"), new CqlCode("cat1", NuSystem)));

            results.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnDifferentCodeProperties_FiltersOnTheRequestedProperty()
        {
            var dr = BuildDataSource();

            var byCode = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("cat1", NuSystem)));
            var byCategory = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "category"), new CqlCode("cat1", NuSystem)));

            byCode.Should().BeEmpty();
            byCategory.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnDifferentTypes_FiltersOnTheRequestedType()
        {
            var dr = BuildDataSource();

            var observations = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", NuSystem)));
            var conditions = dr.Retrieve<Condition>(ByCodes(null, new CqlCode("x", NuSystem)));

            observations.Select(o => o.Id).Should().Equal("obs-x");
            conditions.Select(c => c.Id).Should().Equal("con-x");
        }

        [TestMethod]
        public void RetrieveByCodeWithoutSystem_OnlyMatchesCodingsWithoutASystem()
        {
            var dr = BuildDataSource();

            var withoutSystem = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("nosys")));
            var withSystem = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("nosys", NuSystem)));

            withoutSystem.Select(o => o.Id).Should().Equal("obs-nosys");
            withSystem.Should().BeEmpty();
        }

        [TestMethod]
        public void RetrieveByCodesDifferingInCase_MatchesCaseInsensitively()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("X", "HTTP://NU.NL")));

            results.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnPrimaryCodePath_ReturnsResourceOnceWhenMultipleCodingsMatch()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<Observation>(ByCodes(null, new CqlCode("m1", NuSystem), new CqlCode("m2", NuSystem)));

            results.Select(o => o.Id).Should().Equal("obs-multi");
        }

        [TestMethod]
        public void RetrieveByCodesOnCodeProperty_ReturnsResourceOnceWhenMultipleCodingsMatch()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "category"),
                new CqlCode("m1", NuSystem), new CqlCode("m2", NuSystem)));

            results.Select(o => o.Id).Should().Equal("obs-multi");
        }

        [TestMethod]
        public void RetrieveOnBaseType_ReturnsResourcesOfAllDerivedTypes()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<DomainResource>(null);

            results.Select(r => r.Id).Should().BeEquivalentTo(["pat", "obs-x", "obs-multi", "obs-nosys", "con-x"]);
        }

        [TestMethod]
        public void RetrieveByCodesOnBaseType_OnlyReturnsResourcesThatHaveTheCodeProperty()
        {
            var dr = BuildDataSource();

            var results = dr.Retrieve<DomainResource>(ByCodes(Prop("Observation", "code"), new CqlCode("x", NuSystem)));

            results.Select(r => r.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesOnEmptyBundle_ReturnsEmpty()
        {
            var dr = EmptyDataSource();

            dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", NuSystem))).Should().BeEmpty();
            dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("x", NuSystem))).Should().BeEmpty();
            dr.Retrieve<Observation>(null).Should().BeEmpty();
        }

        [TestMethod]
        public void RetrieveByCodesWithCustomCodeComparer_UsesThatComparer()
        {
            var caseSensitive = new StringCqlComparer(StringComparer.Ordinal);
            var dr = BuildDataSource(codeComparer: caseSensitive);

            dr.Retrieve<Observation>(ByCodes(null, new CqlCode("X", NuSystem))).Should().BeEmpty();
            dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", NuSystem))).Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        [DataRow("nosys", null, "obs-nosys")]
        [DataRow("nosys", NuSystem, null)]
        [DataRow("x", NuSystem, "obs-x")]
        [DataRow("X", "HTTP://NU.NL", "obs-x")]
        [DataRow("x", null, null)]
        [DataRow(null, NuSystem, null)]
        public void RetrieveByCodes_WithSuppliedComparersEquivalentToTheDefaults_GivesTheSameResult(string code, string system, string expectedId)
        {
            // The supplied comparers are the defaults' equivalent, so the scan they force must agree with
            // the set lookup that the default comparers allow.
            var equivalentToDefault = new StringCqlComparer(StringComparer.OrdinalIgnoreCase);
            var expected = expectedId is null ? [] : new[] { expectedId };

            var withDefaults = BuildDataSource();
            var withSupplied = BuildDataSource(codeComparer: equivalentToDefault, systemComparer: equivalentToDefault);

            withDefaults.Retrieve<Observation>(ByCodes(null, new CqlCode(code, system))).Select(o => o.Id).Should().Equal(expected);
            withSupplied.Retrieve<Observation>(ByCodes(null, new CqlCode(code, system))).Select(o => o.Id).Should().Equal(expected);
        }

        [TestMethod]
        public void RetrieveByCodesGivenAValueSetFacade_LetsTheFacadeDecideMembership()
        {
            var dr = BuildDataSource();
            var facade = new InMemoryValueSet([new CqlCode("x", NuSystem)]);

            var results = dr.Retrieve<Observation>(new RetrieveParameters(null, null, facade, null));

            results.Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public void RetrieveByCodesWithCustomSystemComparer_UsesThatComparer()
        {
            var caseSensitive = new StringCqlComparer(StringComparer.Ordinal);
            var dr = BuildDataSource(systemComparer: caseSensitive);

            dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", "HTTP://NU.NL"))).Should().BeEmpty();
            dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", NuSystem))).Select(o => o.Id).Should().Equal("obs-x");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task RetrieveByCodesOnPrimaryCodePath_ConcurrentAccessToSameCacheKey_YieldsConsistentResults()
        {
            var dr = BuildDataSource();
            var expected = new[] { "obs-x" };
            const int threadCount = 32;

            var tasks = Enumerable.Range(0, threadCount).Select(_ => System.Threading.Tasks.Task.Run(() =>
                dr.Retrieve<Observation>(ByCodes(null, new CqlCode("x", NuSystem)))
                  .Select(o => o.Id)
                  .ToList()));

            var results = await System.Threading.Tasks.Task.WhenAll(tasks);

            foreach (var result in results)
                result.Should().Equal(expected);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task RetrieveByCodesOnCodeProperty_ConcurrentAccessToSameCacheKey_YieldsConsistentResults()
        {
            var dr = BuildDataSource();
            var expected = new[] { "obs-x" };
            const int threadCount = 32;

            var tasks = Enumerable.Range(0, threadCount).Select(_ => System.Threading.Tasks.Task.Run(() =>
                dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("x", NuSystem)))
                  .Select(o => o.Id)
                  .ToList()));

            var results = await System.Threading.Tasks.Task.WhenAll(tasks);

            foreach (var result in results)
                result.Should().Equal(expected);
        }

        /// <summary>
        /// A retrieve is walked repeatedly - a cached definition read from several expressions, the inner source of
        /// a cross join - and must answer the same both times without asking the filter again, which it can only do
        /// by having decided membership up front.
        /// </summary>
        [TestMethod]
        public void RetrieveByCodes_IsDecidedOnceAndYieldsTheSameResultOnEveryWalk()
        {
            var dr = BuildDataSource();

            var observations = dr.Retrieve<Observation>(ByCodes(Prop("Observation", "code"), new CqlCode("x", NuSystem)));

            observations.Select(o => o.Id).Should().Equal("obs-x");
            observations.Select(o => o.Id).Should().Equal("obs-x");

            observations.Should().BeAssignableTo<IReadOnlyCollection<Observation>>(
                "a retrieve hands back its matches, not a query that decides them again on every walk");
        }

        [TestMethod]
        public void RetrieveWithoutParameters_YieldsTheSameResultOnEveryWalk()
        {
            var dr = BuildDataSource();

            var patients = dr.Retrieve<Patient>(null);

            patients.Select(p => p.Id).Should().Equal("pat");
            patients.Select(p => p.Id).Should().Equal("pat");
        }
    }
}
