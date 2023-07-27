#nullable enable

using FluentAssertions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Firely;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreTests
{

    [TestClass]
    public class ValueSetTests
    {
        private static readonly CqlCode[] TestCodesA = new[] {
            new CqlCode("a", "http://nu.nl"),
            new CqlCode("b", "http://nu.nl"),
            new CqlCode("c", "HTTP://nu.nl"),
            new CqlCode("d", null) };

        private static readonly CqlCode[] TestCodesB = new[] {
            new CqlCode("e", "http://nu.nl", display: "Letters"),
            new CqlCode("f", "http://nu.nl", display: "LETTERS"),
            new CqlCode("g", null, display: "Letters"),
            new CqlCode("h", "http://nu.nl"),
            new CqlCode("h", "http://nu.nl", display: "Letters"),
        };


        [TestMethod]
        public void CanReturnAllCodeInValueSet()
        {
            var dict = buildDict();
            dict.TryGetCodesInValueSet("http://valuesetA", out var vsA).Should().BeTrue();
            allCodesInA(vsA!);

            dict.TryGetCodesInValueSet("http://valuesetB", out var vsB).Should().BeTrue();
            allCodesInB(vsB!);
        }

        private void allCodesInA(IEnumerable<CqlCode> vs)
        {
            TestCodesA.All(c => vs.Contains(c)).Should().BeTrue();
            vs.All(c => TestCodesA.Contains(c)).Should().BeTrue();
        }

        private void allCodesInB(IEnumerable<CqlCode> vs)
        {
            TestCodesB.All(c => vs.Contains(c)).Should().BeTrue();
            vs.All(c => TestCodesB.Contains(c)).Should().BeTrue();
        }

        [TestMethod]
        public void CanGetFacade()
        {
            var dict = buildDict();
            dict.TryGetValueSet("http://valuesetA", out var f).Should().BeTrue();
            allCodesInA(f!);
        }

        private HashValueSetDictionary buildDict()
        {
            var dict = new HashValueSetDictionary();

            dict.Add("http://valuesetA", TestCodesA);
            dict.Add("http://valuesetB", TestCodesB);

            return dict;
        }

        [TestMethod]
        public void Intensional_Value_Set()
        {
            var files = new[]
            {
                @"Input\ValueSets\intensional-value-set.json",
                @"Input\ValueSets\2.16.840.1.113883.3.464.1004.1009.json",
                @"Input\ValueSets\2.16.840.1.113883.3.464.1004.1013.json",
            };
            var valueSets = files.Select(path =>
            {
                using var fs = File.OpenRead(path);
                var vs = fs.ParseFhir<ValueSet>();
                return vs;
            }).ToArray();

            var loader = new ValueSetLoader(valueSets, false);
            var vsd = loader.Load();

            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1009", out var codes1009));
            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1013", out var codes1013));
            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/intensional-value-set", out var intensional));

            var comparator = new CqlCodeCqlComparer().ToEqualityComparer();
            Assert.IsTrue(codes1009!.All(c => intensional!.Contains(c, comparator)));
            Assert.IsTrue(codes1013!.All(c => intensional!.Contains(c, comparator)));
        }

        [TestMethod]
        public void Intensional_Value_Set_2_Levels()
        {
            var files = new[]
            {
                @"Input\ValueSets\intensional-value-set-2.json",
                @"Input\ValueSets\intensional-value-set.json",
                @"Input\ValueSets\2.16.840.1.113883.3.464.1004.1009.json",
                @"Input\ValueSets\2.16.840.1.113883.3.464.1004.1013.json",
            };
            var valueSets = files.Select(path =>
            {
                using var fs = File.OpenRead(path);
                var vs = fs.ParseFhir<ValueSet>();
                return vs;
            }).ToArray();

            var loader = new ValueSetLoader(valueSets, false);
            var vsd = loader.Load();
            var comparator = new CqlCodeCqlComparer().ToEqualityComparer();

            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1009", out var codes1009));
            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1013", out var codes1013));
            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/intensional-value-set", out var intensional));
            Assert.IsTrue(codes1009!.All(c => intensional!.Contains(c, comparator)));
            Assert.IsTrue(codes1013!.All(c => intensional!.Contains(c, comparator)));

            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/intensional-value-set-2", out var intensional2));
            Assert.IsTrue(codes1009!.All(c => intensional2!.Contains(c, comparator)));
            Assert.IsTrue(codes1013!.All(c => intensional2!.Contains(c, comparator)));

        }

        [TestMethod]
        public void Intensional_Value_Set_Cycle()
        {
            var files = new[]
{
                @"Input\ValueSets\intensional-value-set-3.json",
                @"Input\ValueSets\intensional-value-set-4.json",

            };
            var valueSets = files.Select(path =>
            {
                using var fs = File.OpenRead(path);
                var vs = fs.ParseFhir<ValueSet>();
                return vs;
            }).ToArray();

            var loader = new ValueSetLoader(valueSets, false);

            Assert.ThrowsException<InvalidOperationException>(() => loader.Load());
        }
    }
}

#nullable restore