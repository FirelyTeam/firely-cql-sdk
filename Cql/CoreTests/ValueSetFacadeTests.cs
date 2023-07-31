#nullable enable

using FluentAssertions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
        private static IValueSetFacade? cqlValueSetVS;

        [ClassInitialize]
        public static void Initialize(TestContext x)
        {
            var all = TestCodesA.Concat(TestCodesB);
            inMemoryVS = new InMemoryValueSet(all);
            unionVS = new InMemoryValueSet(TestCodesA).Union(new InMemoryValueSet(TestCodesB));

            var dict = new InMemoryValueSetDictionary();
            dict.Add("valuesetA", all);
            cqlValueSetVS = dict.GetValueSet("valuesetA");
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

        public void FacadeFindsCodeWithDefaultComparer(string code, string? system, string? display, bool resultC, bool resultEquiv, bool resultEqual)
        {
            test(inMemoryVS!, "in-mem");
            test(unionVS!, "union");
            test(cqlValueSetVS!, "facade");

            void test(IValueSetFacade f, string where)
            {
                f.IsCodeInValueSet(code).Should().Be(resultC, because: $"we're using {where}.");
                f.IsCodeInValueSet(code, system).Should().Be(resultEquiv, because: $"we're using {where}.");
                f.IsCodeInValueSet(new CqlCode(code, system, display: display)).Should().Be(resultEqual, because: $"we're using {where}.");
            }
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
}

#nullable restore