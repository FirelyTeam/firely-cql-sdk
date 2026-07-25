/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Comparers;
using Hl7.Cql.Fhir;
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
    // equivalence to consider unit conversion. The matching hash code fix is #1418, tested below.

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

    // Regression tests for #1418: GetHashCodeValue used to hash CqlQuantity.ToString(), which
    // disagrees with both Equals and Equivalent. Quantities that differ only by unit conversion
    // (1 'cm' / 0.01 'm') or by decimal scale (1.0 'cm' / 1.00 'cm') compare equal yet hashed into
    // different buckets, so the HashSet-backed operators (Distinct, Union, Except) failed to
    // deduplicate them. Unit conversion and scale are the whole of what a hash can cover here:
    // equivalence rounds both operands to the least precise of the two, which is non-transitive
    // (0.15 ~ 0.2 and 0.2 ~ 0.24, but 0.15 !~ 0.24) and so has no consistent hash, and the '1' unit
    // compares equal against every other unit.

    /// <summary>
    /// The case from the issue: convertible units, equal per both <c>=</c> and <c>~</c>, so the
    /// hash codes must agree too.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_ConvertibleUnitsSameMagnitude_HashCodesAgree()
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(1m, "cm");
        var y = new CqlQuantity(0.01m, "m");

        Assert.AreEqual(true, comparers.Equals(x, y, null));
        Assert.AreEqual(comparers.GetHashCode(x), comparers.GetHashCode(y));
    }

    /// <summary>
    /// Trailing zeros are not part of a decimal's value, and CQL comparison ignores them, so
    /// same-unit quantities differing only in scale must hash alike -- <c>decimal.ToString()</c>
    /// preserves the scale, which is how the old <c>ToString()</c>-based hash broke this.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_SameUnitDifferentDecimalScale_HashCodesAgree()
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(1.0m, "cm");
        var y = new CqlQuantity(1.00m, "cm");

        Assert.AreEqual(true, comparers.Equals(x, y, null));
        Assert.AreEqual(comparers.GetHashCode(x), comparers.GetHashCode(y));
    }

    /// <summary>
    /// A unit UCUM cannot canonicalize takes the fallback path, which must still scale-normalize
    /// the value and must not throw. Quantities with a null value or unit reach
    /// <c>GetHashCodeValue</c> too -- the comparer's <c>IsNull</c> only rejects a null
    /// <see cref="CqlQuantity"/> reference, not a null <c>value</c>/<c>unit</c>.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_UncanonicalizableOrPartlyNull_HashesWithoutThrowing()
    {
        var comparers = new CqlComparers();

        Assert.AreEqual(
            comparers.GetHashCode(new CqlQuantity(1.0m, "widgets")),
            comparers.GetHashCode(new CqlQuantity(1.00m, "widgets")));

        Assert.AreEqual(
            comparers.GetHashCode(new CqlQuantity(null, "widgets")),
            comparers.GetHashCode(new CqlQuantity(null, "widgets")));

        Assert.AreEqual(
            comparers.GetHashCode(new CqlQuantity(1.0m, null)),
            comparers.GetHashCode(new CqlQuantity(1.00m, null)));

        Assert.AreEqual(
            comparers.GetHashCode(new CqlQuantity(null, null)),
            comparers.GetHashCode(new CqlQuantity(null, null)));
    }

    /// <summary>
    /// Quantities that are not equal should be kept as separate elements by <c>Distinct</c>.
    /// Verifies semantic behavior (via <c>Distinct</c>) rather than asserting hash inequality —
    /// hash functions are permitted to collide, and asserting inequality would over-specify
    /// and risk flakiness.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_UnequalQuantities_AreNotDeduplicated()
    {
        var operators = FhirCqlContext.WithDataSource().Operators;

        // Different magnitude in the same unit must not be collapsed.
        var differentMagnitude = operators.Distinct<CqlQuantity>(
        [
            new CqlQuantity(1.0m, "cm"),
            new CqlQuantity(1.01m, "cm"),
        ])!.ToList();
        Assert.AreEqual(2, differentMagnitude.Count);

        // Incommensurable units (cm vs g) must not be collapsed.
        var incommensurable = operators.Distinct<CqlQuantity>(
        [
            new CqlQuantity(1m, "cm"),
            new CqlQuantity(1m, "g"),
        ])!.ToList();
        Assert.AreEqual(2, incommensurable.Count);
    }

    /// <summary>
    /// End-to-end: <c>Distinct</c> puts every element through a <see cref="HashSet{T}"/> keyed on
    /// the runtime comparer, so it only collapses unit-converted duplicates once the hash agrees
    /// with equality.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_Distinct_DeduplicatesAcrossUnitConversionAndScale()
    {
        var operators = FhirCqlContext.WithDataSource().Operators;

        var deduplicated = operators.Distinct<CqlQuantity>(
        [
            new CqlQuantity(1m, "cm"),
            new CqlQuantity(0.01m, "m"),
        ])!.ToList();

        Assert.AreEqual(1, deduplicated.Count);

        var scaleDeduplicated = operators.Distinct<CqlQuantity>(
        [
            new CqlQuantity(1.0m, "cm"),
            new CqlQuantity(1.00m, "cm"),
        ])!.ToList();

        Assert.AreEqual(1, scaleDeduplicated.Count);
    }

    // Regression tests for #1417: CqlQuantityCqlComparer.CompareValues canonicalized each quantity
    // independently and then compared only the canonicalized values. TryCanonicalize succeeds for
    // any valid UCUM unit, so quantities measuring different base quantities were compared as if
    // both were dimensionless: 1 'cm' = 0.01 'g' returned true, and ordering across dimensions
    // returned a numeric answer. CompareValues now requires the canonical units to agree, the same
    // guard EquivalentValues got in #1415.

    /// <summary>
    /// The case from the issue. Both units canonicalize, but to different base metrics, so the
    /// comparison takes the unsupported path -- which for <c>=</c> means the
    /// <see cref="NotSupportedException"/> surfaces to the caller, exactly as it already did for a
    /// unit UCUM cannot canonicalize at all.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_IncommensurableUnits_ComparisonIsNotSupported()
    {
        var comparers = new CqlComparers();

        var x = new CqlQuantity(1m, "cm");
        var y = new CqlQuantity(0.01m, "g");

        Assert.ThrowsException<NotSupportedException>(() => comparers.Equals(x, y, null));
        Assert.ThrowsException<NotSupportedException>(() => comparers.Compare(x, y, null));

        // Ordering across dimensions, which used to answer 0/-1/1 off the canonicalized values.
        Assert.ThrowsException<NotSupportedException>(
            () => comparers.Compare(new CqlQuantity(1m, "cm"), new CqlQuantity(1m, "g"), null));
    }

    /// <summary>
    /// Convertible units are unaffected: equality and ordering both still canonicalize and compare.
    /// </summary>
    [TestMethod]
    public void CqlQuantity_ConvertibleUnits_ComparisonUnchanged()
    {
        var comparers = new CqlComparers();

        Assert.AreEqual(true, comparers.Equals(new CqlQuantity(1m, "cm"), new CqlQuantity(0.01m, "m"), null));
        Assert.AreEqual(0, comparers.Compare(new CqlQuantity(1m, "cm"), new CqlQuantity(0.01m, "m"), null));

        Assert.AreEqual(-1, comparers.Compare(new CqlQuantity(1m, "cm"), new CqlQuantity(1m, "m"), null));
        Assert.AreEqual(1, comparers.Compare(new CqlQuantity(1m, "m"), new CqlQuantity(1m, "cm"), null));
    }

    /// <summary>
    /// An interval's comparer answers equivalence by borrowing its own comparison implementation
    /// (<c>CqlComparerEquivalentImplementation.Compare</c>), so an interval over incommensurable
    /// quantities reaches <c>CqlQuantityCqlComparer.CompareValues</c> along an equivalence path.
    /// Equivalence never signals an error, so the unsupported comparison has to come back as
    /// <see langword="false"/> -- before this fix these intervals were equivalent, comparing
    /// 0.01 'm' against 0.01 'g' as bare numbers. Interval equality, in contrast, propagates the
    /// error like the scalar case does.
    /// </summary>
    [TestMethod]
    public void CqlIntervalOfQuantity_IncommensurableBounds_IsNotEquivalent_AndDoesNotThrow()
    {
        // Interval comparers are registered by the operators, not by the bare CqlComparers ctor.
        var operators = FhirCqlContext.WithDataSource().Operators;

        var centimeters = new CqlInterval<CqlQuantity>(new CqlQuantity(1m, "cm"), new CqlQuantity(2m, "cm"), true, true);
        var grams = new CqlInterval<CqlQuantity>(new CqlQuantity(0.01m, "g"), new CqlQuantity(0.02m, "g"), true, true);
        var meters = new CqlInterval<CqlQuantity>(new CqlQuantity(0.01m, "m"), new CqlQuantity(0.02m, "m"), true, true);

        Assert.AreEqual(false, operators.Equivalent(centimeters, grams));
        Assert.ThrowsException<NotSupportedException>(() => operators.Equal(centimeters, grams));

        // Convertible bounds unchanged.
        Assert.AreEqual(true, operators.Equivalent(centimeters, meters));
        Assert.AreEqual(true, operators.Equal(centimeters, meters));
    }
}
