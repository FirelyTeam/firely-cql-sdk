/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class VersionTest
    {
        private Elm.VersionedIdentifier vi(string id, string? version) =>
            new Elm.VersionedIdentifier { id = id, version = version };

        [TestMethod]
        public void VersionedIdentifier_ExactMatch()
        {
            var x = vi("foo", "1.0");
            var y = vi("foo", "1.0");
            x.CompareTo(y).Should().Be(0);
            x.Equals(y).Should().BeTrue();
            Equals(x, y).Should().BeTrue();
            y.CompareTo(x).Should().Be(0);
            y.Equals(x).Should().BeTrue();
            Equals(y, x).Should().BeTrue();
        }

        [TestMethod]
        // CQL is case-sensitive per spec/cql/condensed/03-developersguide.md §3.4.1 "Case-Sensitivity":
        // "CQL is a case-sensitive language. This means that case is considered when matching
        //  keywords and identifiers in the language."
        // Library identifiers are CQL identifiers, so "FoO" and "foo" are different.
        public void VersionedIdentifier_CaseSensitive_DifferentCase_NotEqual()
        {
            var x = vi("FoO", "1.0");
            var y = vi("fOo", "1.0");
            x.CompareTo(y).Should().NotBe(0);
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_CaseSensitive_SameCase_HashSetContains()
        {
            var x = vi("Foo", "1.0");
            var y = vi("Foo", "1.0");
            var set = new HashSet<Elm.VersionedIdentifier> { x };

            set.Contains(y).Should().BeTrue();
            set.Add(y).Should().BeFalse();
            set.Count.Should().Be(1);
        }

        [TestMethod]
        // Version specifiers must match exactly per spec/cql/condensed/03-developersguide.md §3.2 "Libraries":
        // "If the reference includes a version specifier, the library with that version specifier
        //  must be used."
        // The version is an opaque string identifier, not a semantic version to be normalized.
        public void VersionedIdentifier_ExactVersion_Required_DifferentFormat_NotEqual()
        {
            var x = vi("foo", "1.0");
            var y = vi("foo", "1.0.0");
            var set = new HashSet<Elm.VersionedIdentifier> { x };

            x.CompareTo(y).Should().NotBe(0);
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            x.GetHashCode().Should().NotBe(y.GetHashCode());
            set.Contains(y).Should().BeFalse();
            set.Add(y).Should().BeTrue();
            set.Count.Should().Be(2);
        }

        [TestMethod]
        public void VersionedIdentifier_Null_HashSetContains_DoesNotThrow()
        {
            var x = vi("foo", "1.0");
            var set = new HashSet<Elm.VersionedIdentifier> { x };

            set.Contains(null!).Should().BeFalse();
        }

        [TestMethod]
        // `id` is a plain mutable string on this XSD-generated type - the default constructor
        // leaves it null, so a null id is trivially reachable (not just a null reference).
        // Equals must never throw for a valid non-null argument, even when id is null on either
        // side - GetHashCode already tolerates it, so Equals/CompareTo must be consistent.
        public void VersionedIdentifier_NullId_DoesNotThrow()
        {
            var withNullId = vi(null!, "1.0");
            var withRealId = vi("foo", "1.0");

            withNullId.GetHashCode();
            withNullId.Equals(withRealId).Should().BeFalse();
            withRealId.Equals(withNullId).Should().BeFalse();

            var set = new HashSet<Elm.VersionedIdentifier> { withRealId };
            set.Contains(withNullId).Should().BeFalse();
            set.Add(withNullId).Should().BeTrue();
            set.Count.Should().Be(2);
        }

        [TestMethod]
        public void VersionedIdentifier_NullId_HashCollision_DoesNotThrow()
        {
            var nullId1 = vi(null!, "1.0");
            var nullId2 = vi(null!, "1.0");
            nullId1.GetHashCode().Should().Be(nullId2.GetHashCode());

            var set = new HashSet<Elm.VersionedIdentifier> { nullId1 };
            set.Contains(nullId2).Should().BeTrue();
            set.Add(nullId2).Should().BeFalse();
            set.Count.Should().Be(1);
        }

        [TestMethod]
        // Ordering must stay numeric ("1.9" before "1.10"), not lexicographic, for "most
        // appropriate version" selection - lexicographic would put "1.10" first since '1' < '9'
        // at the second character.
        public void VersionedIdentifier_OrdersVersionsNumerically_NotLexicographically()
        {
            var x = vi("foo", "1.9");
            var y = vi("foo", "1.10");
            x.CompareTo(y).Should().BeNegative();
            y.CompareTo(x).Should().BePositive();
        }

        [TestMethod]
        public void VersionedIdentifier_Different_Names()
        {
            var x = vi("foo", "1.0");
            var y = vi("food", "1.0");
            x.CompareTo(y).Should().BeNegative();
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().BePositive();
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Different_Minors()
        {
            var x = vi("foo", "1.0");
            var y = vi("foo", "1.1");
            x.CompareTo(y).Should().BeNegative();
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().BePositive();
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Assume_Zero_Minor()
        {
            var x = vi("foo", "1");
            var y = vi("foo", "1.1");
            x.CompareTo(y).Should().BeNegative();
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().BePositive();
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Different_Revisions()
        {
            var x = vi("foo", "1.1");
            var y = vi("foo", "1.1.1");
            x.CompareTo(y).Should().BeNegative();
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().BePositive();
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Version_Against_Missing()
        {
            var x = vi("foo", "1.1");
            var y = vi("foo", null);
            x.CompareTo(y).Should().BePositive();
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().BeNegative();
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }
    }
}
