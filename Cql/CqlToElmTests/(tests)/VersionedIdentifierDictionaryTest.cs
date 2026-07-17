/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class VersionedIdentifierDictionaryTest
    {
        [TestMethod]
        // Per spec/condensed/03-developersguide.md §Libraries: "If the reference includes a
        // version specifier, the library with that version specifier must be used" - "1.0" and
        // "1.0.0" are different specifiers, so referencing one must not resolve the other.
        public void TryGet_ExactVersion_DifferentFormat_DoesNotMatch()
        {
            var dict = new VersionedIdentifierDictionary<string>();
            dict.Add("Foo", "1.0.0", "the-1.0.0-library");

            dict.TryGet("Foo", "1.0.0", out var exact).Should().BeTrue();
            exact.Should().Be("the-1.0.0-library");

            dict.TryGet("Foo", "1.0", out _).Should().BeFalse();
        }

        [TestMethod]
        // CQL is case-sensitive per spec/condensed/03-developersguide.md §3.4.1.
        public void TryGet_CaseSensitive_DifferentCase_DoesNotMatch()
        {
            var dict = new VersionedIdentifierDictionary<string>();
            dict.Add("Foo", "1.0", "the-library");

            dict.TryGet("Foo", "1.0", out _).Should().BeTrue();
            dict.TryGet("foo", "1.0", out _).Should().BeFalse();
        }

        [TestMethod]
        // Registering both "1.0" and "1.0.0" must produce two distinct entries, not one -
        // otherwise the exact-match fix above would be undone by SortedList treating them as
        // the same key internally.
        public void Add_NumericallyEquivalentButTextuallyDifferent_AreDistinctEntries()
        {
            var dict = new VersionedIdentifierDictionary<string>();
            dict.Add("Foo", "1.0", "v1.0");
            dict.Add("Foo", "1.0.0", "v1.0.0");

            dict.TryGet("Foo", "1.0", out var exactShort).Should().BeTrue();
            exactShort.Should().Be("v1.0");
            dict.TryGet("Foo", "1.0.0", out var exactLong).Should().BeTrue();
            exactLong.Should().Be("v1.0.0");
        }

        [TestMethod]
        // VersionComparer still orders numerically (so "1.9" sorts before "1.10") for "most
        // appropriate version" selection - naive lexicographic ordering would put "1.10" first
        // since '1' < '9' at the second character, which is wrong for version ordering.
        public void VersionComparer_OrdersNumerically_NotLexicographically()
        {
            VersionComparer.Instance.Compare("1.9", "1.10").Should().BeNegative();
            VersionComparer.Instance.Compare("1.10", "1.9").Should().BePositive();
        }

        [TestMethod]
        // The core fix: numerically-equivalent-but-textually-different versions must never
        // compare equal, even though they still order correctly relative to each other and to
        // genuinely different versions.
        public void VersionComparer_NumericallyEquivalent_DifferentText_NeverCompareEqual()
        {
            VersionComparer.Instance.Compare("1.0", "1.0.0").Should().NotBe(0);
            VersionComparer.Instance.Compare("1.0.0", "1.0").Should().NotBe(0);
            VersionComparer.Instance.Compare("1.0", "1.0").Should().Be(0);
        }
    }
}
