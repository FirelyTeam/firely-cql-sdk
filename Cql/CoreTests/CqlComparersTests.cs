/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;

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
    /// Regression test for a distinct failure mode from the BaseType-walk one above: a type
    /// resolved via <c>ComparerFactories</c> (e.g. the built-in <c>KeyValuePair&lt;,&gt;</c>
    /// registration), not via a directly-registered type or an ancestor. Before the fix, the
    /// fallback only ever tried <c>xType.BaseType</c>, which for a struct like KeyValuePair walks
    /// to <c>ValueType</c>/<c>object</c> and never retries the generic-factory branch that
    /// Compare/Equals already use via SelectComparer -- so this threw on the very first call.
    /// </summary>
    [TestMethod]
    public void KeyValuePair_GetHashCode_ResolvesViaGenericFactory_NotJustBaseTypeWalk()
    {
        var comparers = new CqlComparers(); // KeyValuePair<,> factory and int/string comparers are registered by the constructor

        var a = new KeyValuePair<int, string>(1, "a");
        var b = new KeyValuePair<int, string>(1, "a");
        var c = new KeyValuePair<int, string>(2, "a");

        Assert.AreEqual(comparers.GetHashCode(a), comparers.GetHashCode(b));
        Assert.AreNotEqual(comparers.GetHashCode(a), comparers.GetHashCode(c));
    }

    /// <summary>
    /// Regression test for a PR review finding: a value-type-element sequence like
    /// <c>List&lt;int&gt;</c> doesn't satisfy <c>IEnumerable&lt;object&gt;</c> (no reference-type
    /// covariance for <c>int</c>), so the <c>GetHashCodeValue</c> fallback's IEnumerable fast path
    /// (originally checking <c>IEnumerable&lt;object&gt;</c>) would miss it, falling through to
    /// <c>SelectComparer</c>, which resolves it to <c>ListEqualComparer</c> (registered for plain
    /// <c>IEnumerable</c>) -- a comparer with structural Compare/Equals but no
    /// <c>GetHashCodeValue</c> override, silently inheriting the reference-identity hash. Two
    /// distinct-but-structurally-equal lists would then compare equal but hash differently.
    /// </summary>
    [TestMethod]
    public void ValueTypeElementList_GetHashCode_IsStructurallyConsistentWithEquals()
    {
        var comparers = new CqlComparers();

        var a = new List<int> { 1, 2, 3 };
        var b = new List<int> { 1, 2, 3 };
        var c = new List<int> { 1, 2, 4 };

        Assert.AreNotSame(a, b);
        Assert.AreEqual(true, comparers.Equals(a, b, null));
        Assert.AreEqual(false, comparers.Equals(a, c, null));

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

    // Regression tests for the CqlConceptCqlComparer.CompareValues performance fix: the method
    // used to re-sort both operands' code lists (an O(n log n) LINQ OrderBy) on every single
    // Compare/Equals call, including every hash-collision check inside a hash-based Distinct/
    // Union/Except over a list of concepts. The fix caches each CqlConcept instance's
    // sorted-by-code array (keyed by reference identity via a ConditionalWeakTable, since
    // CqlConcept.codes is init-only and can't change after construction). These tests prove the
    // caching is purely an optimization: comparison semantics must be byte-for-byte identical to
    // before.

    private static CqlConcept Concept(params string[] codes) =>
        new(codes.Select(c => new CqlCode(c, "sys")).ToArray(), display: null);

    /// <summary>
    /// Same codes, different insertion order -- exercises the OrderBy underneath the cache. Two
    /// concepts with the same set of codes, regardless of original order, must compare as equal.
    /// </summary>
    [TestMethod]
    public void CqlConcept_SameCodesDifferentOrder_ComparesEqual()
    {
        var comparers = new CqlComparers();

        var x = Concept("b", "a", "c");
        var y = Concept("c", "b", "a");

        Assert.AreEqual(0, comparers.Compare(x, y, null));
        Assert.AreEqual(true, comparers.Equals(x, y, null));
    }

    /// <summary>
    /// Two distinct CqlConcept instances that are structurally equal (same code content) must
    /// each still be compared/hashed correctly. This isn't about the cache being "instance
    /// unique" (an implementation detail of the ConditionalWeakTable) -- it's about correctness:
    /// since CqlConcept is a record, x and y here are `==`-equal .NET objects but distinct
    /// references, so this also confirms the cache is keyed in a way that doesn't require
    /// reference equality between compared instances to work.
    /// </summary>
    [TestMethod]
    public void CqlConcept_StructurallyEqualDistinctInstances_CompareAndHashConsistently()
    {
        var comparers = new CqlComparers();

        var x = Concept("a", "b");
        var y = Concept("a", "b");

        Assert.AreNotSame(x, y);
        Assert.AreEqual(0, comparers.Compare(x, y, null));
        Assert.AreEqual(true, comparers.Equals(x, y, null));
        Assert.AreEqual(comparers.GetHashCode(x), comparers.GetHashCode(y));

        // Each instance must still resolve its own correct sorted view when compared against a
        // third, differently-ordered-but-equal concept.
        var z = Concept("b", "a");
        Assert.AreEqual(0, comparers.Compare(x, z, null));
        Assert.AreEqual(0, comparers.Compare(y, z, null));
    }

    /// <summary>
    /// Concepts with different numbers of codes must hit the early-exit length check and report a
    /// non-zero, sign-correct comparison (matching <c>xCodes.Length - yCodes.Length</c>), not
    /// throw or silently truncate via the removed <c>ElementAtOrDefault</c> handling.
    /// </summary>
    [TestMethod]
    public void CqlConcept_DifferentLengths_ComparesByLengthDifference()
    {
        var comparers = new CqlComparers();

        var shorter = Concept("a");
        var longer = Concept("a", "b", "c");

        Assert.AreEqual(-2, comparers.Compare(shorter, longer, null));
        Assert.AreEqual(2, comparers.Compare(longer, shorter, null));
        Assert.AreEqual(false, comparers.Equals(shorter, longer, null));
    }

    /// <summary>
    /// Same length, but no codes in common -- the loop must run through comparing each sorted
    /// pair positionally (not via equivalence/overlap) and report the first non-zero code
    /// comparison, still not equal.
    /// </summary>
    [TestMethod]
    public void CqlConcept_SameLengthNoMatchingCodes_ComparesUnequal()
    {
        var comparers = new CqlComparers();

        var x = Concept("a", "b");
        var y = Concept("x", "y");

        Assert.AreNotEqual(0, comparers.Compare(x, y, null));
        Assert.AreEqual(false, comparers.Equals(x, y, null));
    }

    // Regression tests for #1415: CqlQuantityCqlComparer.EquivalentValues used to return false as
    // soon as the two units weren't textually equivalent, even though CompareValues (and therefore
    // = and the comparison operators) already canonicalized via UCUM. Spec §9.B requires quantity
    // equivalence to consider unit conversion.
    // Note: GetHashCodeValue still hashes CqlQuantity.ToString(), so two quantities that are now
    // equivalent (or equal) via unit conversion hash differently. That inconsistency predates this
    // fix -- it applies equally to the = path -- and is deliberately left alone here.

    /// <summary>
    /// Different but convertible units with the same magnitude are equivalent -- the spec's own
    /// example (`100 'cm' ~ 1 'm'`), here in the form the XmlTest suite exercises it.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_ConvertibleUnitsSameMagnitude_IsEquivalent()
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(1m, "cm");
        var y = new CqlQuantity(0.01m, "m");

        Assert.IsTrue(comparers.Equivalent(x, y, null));

        // The Compare-based paths already handled this; assert they still agree.
        Assert.AreEqual(true, comparers.Equals(x, y, null));
        Assert.AreEqual(0, comparers.Compare(x, y, null));
    }

    /// <summary>
    /// Convertible units, but the magnitudes differ once canonicalized -- the fallback must compare
    /// the canonicalized values, not just report equivalence because the units are commensurable.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_ConvertibleUnitsDifferentMagnitude_IsNotEquivalent()
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(2m, "cm");
        var y = new CqlQuantity(0.01m, "m");

        Assert.IsFalse(comparers.Equivalent(x, y, null));
    }

    /// <summary>
    /// Incommensurable units canonicalize to different base metrics. Equivalence must report false
    /// rather than signalling an error (contrast <c>CompareValues</c>, which throws
    /// <see cref="NotSupportedException"/> for units it cannot canonicalize at all).
    /// </summary>
    [TestMethod]
    public void CqlQuantity_IncommensurableUnits_IsNotEquivalent_AndDoesNotThrow()
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(1m, "cm");
        var y = new CqlQuantity(1m, "g");

        Assert.IsFalse(comparers.Equivalent(x, y, null));

        // Numerically equal canonicalized values across different base metrics must not be
        // mistaken for equivalence: 1 'cm' canonicalizes to 0.01 'm', 0.01 'g' to 0.01 'g'.
        Assert.IsFalse(comparers.Equivalent(x, new CqlQuantity(0.01m, "g"), null));
    }

    /// <summary>
    /// A unit that isn't valid UCUM at all cannot be canonicalized; equivalence must still report
    /// false instead of throwing.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_UncanonicalizableUnit_IsNotEquivalent_AndDoesNotThrow()
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(1m, "widgets");
        var y = new CqlQuantity(1m, "m");

        Assert.IsFalse(comparers.Equivalent(x, y, null));
    }

    /// <summary>
    /// Spec §9.B lists UCUM definite-time durations as equivalent to their calendar-duration
    /// counterparts (`1 year ~ 1 'a'`). Before the #1415 fix these returned false -- the unit
    /// comparer treats 'year'/'a' as plain strings -- so it is the canonicalizing fallback (via
    /// Ucum.CalendarDurationMapping) that makes them equivalent.
    /// </summary>
    [DataTestMethod]
    [DataRow("year", "a")]
    [DataRow("month", "mo")]
    [DataRow("week", "wk")]
    [DataRow("day", "d")]
    [DataRow("hour", "h")]
    [DataRow("minute", "min")]
    [DataRow("second", "s")]
    [DataRow("millisecond", "ms")]
    public void CqlQuantity_CalendarDurationAndUcumCounterpart_IsEquivalent(string calendarUnit, string ucumUnit)
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(1m, calendarUnit);
        var y = new CqlQuantity(1m, ucumUnit);

        Assert.IsTrue(comparers.Equivalent(x, y, null));
    }

    /// <summary>
    /// The default unit `'1'` short-circuits ahead of the canonicalizing fallback, comparing the
    /// values directly. Unaffected by the #1415 fix.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_DefaultUnit_ComparesValuesDirectly()
    {
        var comparers = new CqlComparers();

        Assert.IsTrue(comparers.Equivalent(new CqlQuantity(1m, "1"), new CqlQuantity(1m, "cm"), null));
        Assert.IsFalse(comparers.Equivalent(new CqlQuantity(2m, "1"), new CqlQuantity(1m, "cm"), null));
    }
}
