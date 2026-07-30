/*
 * Copyright (c) 2026, Firely, NCQA and contributors
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
        // Per spec/cql/condensed/03-developersguide.md §Libraries: "If the reference includes a
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
        // CQL is case-sensitive per spec/cql/condensed/03-developersguide.md §3.4.1.
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

        [TestMethod]
        // Version specifiers are arbitrary CQL string literals, not guaranteed to be
        // dot-separated integers (e.g. "R4", "2021-05-01") - comparing them must degrade
        // gracefully to ordinal ordering instead of throwing.
        public void VersionComparer_NonNumericVersions_DoesNotThrow()
        {
            VersionComparer.Instance.Compare("R4", "STU3").Should().NotBe(0);
            VersionComparer.Instance.Compare("1.0", "R4").Should().NotBe(0);
            VersionComparer.Instance.Compare("2021-05-01", "2021-06-01").Should().NotBe(0);
            VersionComparer.Instance.Compare("1..0", "1.0").Should().NotBe(0);
            VersionComparer.Instance.Compare("99999999999.0", "1.0").Should().NotBe(0);
            VersionComparer.Instance.Compare("R4", "R4").Should().Be(0);
        }

        [TestMethod]
        public void VersionComparer_NonNumericVersions_UsableInDictionary()
        {
            var dict = new VersionedIdentifierDictionary<string>();
            dict.Add("Foo", "R4", "the-r4-library");
            dict.Add("Foo", "STU3", "the-stu3-library");

            dict.TryGet("Foo", "R4", out var r4).Should().BeTrue();
            r4.Should().Be("the-r4-library");
            dict.TryGet("Foo", "STU3", out var stu3).Should().BeTrue();
            stu3.Should().Be("the-stu3-library");
        }

        [TestMethod]
        // versions is sorted ascending by VersionComparer, so TryGetLatest/
        // HasUnambiguousLatestVersion must read from the end, not the start.
        public void TryGetLatest_ReturnsHighestVersion_NotLowest()
        {
            var dict = new VersionedIdentifierDictionary<string>();
            dict.Add("Foo", "1.0.0", "v1.0.0");
            dict.Add("Foo", "2.0.0", "v2.0.0");
            dict.Add("Foo", "1.9", "v1.9");
            dict.Add("Foo", "1.10", "v1.10");

            dict.TryGetLatest("Foo", out var version, out var t).Should().BeTrue();
            version.Should().Be("2.0.0");
            t.Should().Be("v2.0.0");
        }

        [TestMethod]
        public void HasUnambiguousLatestVersion_ChecksHighestVersion_NotLowest()
        {
            var dict = new VersionedIdentifierDictionary<string>();
            // Lowest version ("1.0") has a single entry, but the true latest ("2.0") is
            // ambiguous - HasUnambiguousLatestVersion must reflect the latter.
            dict.Add("Foo", "1.0", "v1.0");
            dict.Add("Foo", "2.0", "v2.0-a");
            dict.Add("Foo", "2.0", "v2.0-b");

            dict.HasUnambiguousLatestVersion("Foo").Should().BeFalse();
        }
    }
}
