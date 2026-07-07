/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Comparers;

namespace CoreTests;

[TestClass]
public class CqlComparersTests
{
    private class BaseThing
    {
        public int Value;
    }

    private sealed class DerivedThing : BaseThing;

    private sealed class BaseThingComparer : CqlComparer<BaseThing>
    {
        // CqlComparers (the top-level dispatcher under test) is configured with
        // equalsImplementation: Compare, so its Equals always delegates to CompareValues on the
        // resolved comparer, never EqualsValues -- override CompareValues here to match.
        protected override int? CompareValues(BaseThing x, BaseThing y, string? precision) =>
            x.Value.CompareTo(y.Value);

        protected override int GetHashCodeValue(BaseThing value) =>
            value.Value;
    }

    /// <summary>
    /// Only <see cref="BaseThing"/> is registered; <see cref="DerivedThing"/> must be resolved by
    /// walking up the type hierarchy. Regression test for the fix that made
    /// <c>CqlComparers.GetHashCodeValue</c> use the same BaseType-walk resolution as
    /// Compare/Equals/Equivalent -- previously it only did a direct dictionary lookup and threw
    /// for any type only reachable via an ancestor registration, even though Equals/Compare
    /// already succeeded for that same type via the walk.
    /// </summary>
    [TestMethod]
    public void UnregisteredDerivedType_ResolvesViaBaseTypeWalk_ForBothEqualsAndGetHashCode()
    {
        var comparers = new CqlComparers();
        comparers.Register(typeof(BaseThing), new BaseThingComparer());

        var a = new DerivedThing { Value = 42 };
        var b = new DerivedThing { Value = 42 };
        var c = new DerivedThing { Value = 7 };

        Assert.AreEqual(true, comparers.Equals(a, b, null));
        Assert.AreEqual(false, comparers.Equals(a, c, null));

        // Before the fix, this line threw ArgumentException ("Cannot generate a hash code for
        // DerivedThing") even though the Equals calls above succeeded for the identical type.
        Assert.AreEqual(comparers.GetHashCode(a), comparers.GetHashCode(b));
        Assert.AreNotEqual(comparers.GetHashCode(a), comparers.GetHashCode(c));
    }

    /// <summary>
    /// A HashSet using CqlComparers as its comparer is exactly how CqlOperators.Distinct/Union/
    /// Except behave -- this proves an unregistered-but-inheriting type can be deduplicated via
    /// hashing end-to-end, not just via the two APIs in isolation.
    /// </summary>
    [TestMethod]
    public void UnregisteredDerivedType_CanBeDeduplicated_ViaHashSetUsingCqlComparers()
    {
        var comparers = new CqlComparers();
        comparers.Register(typeof(BaseThing), new BaseThingComparer());

        var items = new object[]
        {
            new DerivedThing { Value = 1 },
            new DerivedThing { Value = 2 },
            new DerivedThing { Value = 1 },
        };

        var distinct = new HashSet<object>(items, new EqualityComparerAdapter(comparers));

        Assert.AreEqual(2, distinct.Count);
    }

    private sealed class EqualityComparerAdapter(CqlComparers comparers) : IEqualityComparer<object>
    {
        public new bool Equals(object? x, object? y) =>
            comparers.Equals(x, y, null) ?? false;

        public int GetHashCode(object obj) =>
            comparers.GetHashCode(obj);
    }
}
