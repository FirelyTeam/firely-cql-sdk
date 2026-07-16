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
        public void VersionedIdentifier_CaseInsensitiveMatch()
        {
            var x = vi("FoO", "1.0");
            var y = vi("fOo", "1.0");
            x.CompareTo(y).Should().Be(0);
            x.Equals(y).Should().BeTrue();
            Equals(x, y).Should().BeTrue();
            y.CompareTo(x).Should().Be(0);
            y.Equals(x).Should().BeTrue();
            Equals(y, x).Should().BeTrue();
        }

        [TestMethod]
        public void VersionedIdentifier_CaseInsensitiveMatch_HashSetContains()
        {
            var x = vi("FoO", "1.0");
            var y = vi("fOo", "1.0");
            var set = new HashSet<Elm.VersionedIdentifier> { x };

            set.Contains(y).Should().BeTrue();
            set.Add(y).Should().BeFalse();
            set.Count.Should().Be(1);
        }

        [TestMethod]
        public void VersionedIdentifier_SemanticallyEqualVersion_HashSetContains()
        {
            var x = vi("foo", "1.0");
            var y = vi("foo", "1.0.0");
            var set = new HashSet<Elm.VersionedIdentifier> { x };

            x.CompareTo(y).Should().Be(0);
            x.Equals(y).Should().BeTrue();
            Equals(x, y).Should().BeTrue();
            x.GetHashCode().Should().Be(y.GetHashCode());
            set.Contains(y).Should().BeTrue();
            set.Add(y).Should().BeFalse();
            set.Count.Should().Be(1);
        }

        [TestMethod]
        public void VersionedIdentifier_Null_HashSetContains_DoesNotThrow()
        {
            var x = vi("foo", "1.0");
            var set = new HashSet<Elm.VersionedIdentifier> { x };

            set.Contains(null!).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Different_Names()
        {
            var x = vi("foo", "1.0");
            var y = vi("food", "1.0");
            x.CompareTo(y).Should().Be(-1);
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().Be(1);
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Different_Minors()
        {
            var x = vi("foo", "1.0");
            var y = vi("foo", "1.1");
            x.CompareTo(y).Should().Be(-1);
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().Be(1);
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Assume_Zero_Minor()
        {
            var x = vi("foo", "1");
            var y = vi("foo", "1.1");
            x.CompareTo(y).Should().Be(-1);
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().Be(1);
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Different_Revisions()
        {
            var x = vi("foo", "1.1");
            var y = vi("foo", "1.1.1");
            x.CompareTo(y).Should().Be(-1);
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().Be(1);
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }

        [TestMethod]
        public void VersionedIdentifier_Version_Against_Missing()
        {
            var x = vi("foo", "1.1");
            var y = vi("foo", null);
            x.CompareTo(y).Should().Be(1);
            x.Equals(y).Should().BeFalse();
            Equals(x, y).Should().BeFalse();
            y.CompareTo(x).Should().Be(-1);
            y.Equals(x).Should().BeFalse();
            Equals(y, x).Should().BeFalse();
        }
    }
}
