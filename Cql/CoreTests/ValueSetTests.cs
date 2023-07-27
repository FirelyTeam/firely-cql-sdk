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
    public class ValueSetFacadeTests
    {
        private static readonly IEnumerable<CqlCode> TestCodesA = new[] {
            new CqlCode("a", "http://nu.nl"),
            new CqlCode("b", "http://nu.nl"), new CqlCode("B", "http://nu.nl"),
            new CqlCode("c", "HTTP://nu.nl"),
            new CqlCode("d", null) };

        private static readonly IEnumerable<CqlCode> TestCodesB = new[] {
            new CqlCode("e", "http://nu.nl", display: "Letters"),
            new CqlCode("f", "http://nu.nl", display: "LETTERS"),
            new CqlCode("g", null, display: "Letters"),
            new CqlCode("h", "http://nu.nl"),new CqlCode("h", "http://nu.nl"),new CqlCode("h", "http://nu.nl", display: "Letters"),
        };

        private const string nu = "http://nu.nl";
        private const string NU = "HTTP://NU.NL";
        private const string letters = "Letters";
        private const string LETTERS = "LETTERS";

        private static IValueSetFacade? inMemoryVS;
        private static IValueSetFacade? unionVS;

        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            inMemoryVS = new InMemoryValueSet(TestCodesA.Concat(TestCodesB));
            unionVS = new InMemoryValueSet(TestCodesA).Union(new InMemoryValueSet(TestCodesB));
        }

        [TestMethod]
        [DataRow("a", null, null, true, false, false)]
        [DataRow("_", null, null, false, false, false)]
        [DataRow("A", null, null, true, false, false)]
        [DataRow("b", null, null, true, false, false)]
        [DataRow("_", null, null, false, false, false)]
        [DataRow("A", null, null, true, false, false)]
        [DataRow("f", null, null, true, false, false)]

        [DataRow("a", nu, null, true, true, true)]
        [DataRow("a", NU, null, true, true, true)]
        [DataRow("a", "crap", null, true, false, false)]
        [DataRow("d", null, null, true, true, true)]  // null is the explicit codesystem here
        [DataRow("f", nu, null, true, true, false)]

        [DataRow("a", nu, letters, true, true, false)]
        [DataRow("e", nu, letters, true, true, true)]
        [DataRow("e", NU, letters, true, true, true)]
        [DataRow("e", nu, LETTERS, true, true, true)]
        [DataRow("e", nu, null, true, true, false)]
        [DataRow("e", "crap", null, true, false, false)]
        [DataRow("e", nu, "crap", true, true, false)]
        [DataRow("g", null, letters, true, true, true)]
        [DataRow("g", null, "crap", true, true, false)]

        public void InMemoryValueSetFindsCodeWithDefaultComparer(string code, string? system, string? display, bool resultC, bool resultEquiv, bool resultEqual)
        {
            var mf = inMemoryVS!;
            mf.IsCodeInValueSet(code).Should().Be(resultC);
            mf.IsCodeInValueSet(code, system).Should().Be(resultEquiv);
            mf.IsCodeInValueSet(new CqlCode(code, system, display: display)).Should().Be(resultEqual);
        }

        [TestMethod]
        public void EnumerateUniqueCodes()
        {
            var mf = unionVS!;
            var comparer = new CqlCodeCqlComparer().ToEqualityComparer();

            mf.Count().Should().Be(9);  // b and B are the same, h should appear with and without description

            mf.Count(c => c.code!.ToLower() == "b").Should().Be(1);
            mf.Count(c => c.code!.ToLower() == "h").Should().Be(2);
            mf.Contains(new CqlCode("h", nu), comparer).Should().BeTrue();
            mf.Contains(new CqlCode("h", nu, display: letters), comparer).Should().BeTrue();
        }
    }

    [TestClass]
    public class ValueSetTests
    {

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

            Assert.IsTrue(codes1009!.All(c => intensional!.Contains(c)));
            Assert.IsTrue(codes1013!.All(c => intensional!.Contains(c)));
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

            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1009", out var codes1009));
            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1013", out var codes1013));
            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/intensional-value-set", out var intensional));
            Assert.IsTrue(codes1009!.All(c => intensional!.Contains(c)));
            Assert.IsTrue(codes1013!.All(c => intensional!.Contains(c)));

            Assert.IsTrue(vsd.TryGetCodesInValueSet("https://www.ncqa.org/fhir/valueset/intensional-value-set-2", out var intensional2));
            Assert.IsTrue(codes1009!.All(c => intensional2!.Contains(c)));
            Assert.IsTrue(codes1013!.All(c => intensional2!.Contains(c)));

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