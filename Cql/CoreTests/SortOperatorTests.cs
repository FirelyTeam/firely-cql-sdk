/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// The sort operators give a deferred sequence: <see cref="ICqlOperators.SortBy{T}"/> and
/// <see cref="ICqlOperators.ListSort{T}"/> read and sort their source when the result is first enumerated, once.
/// <see cref="ICqlOperators.Collapse(IEnumerable{CqlInterval{int?}}, string)"/> enumerates its input once.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class SortOperatorTests
{
    private static ICqlOperators Sut() => FhirCqlContext.WithDataSource().Operators;

    /// <summary>A sequence that counts how often it is enumerated.</summary>
    private sealed class CountingSequence<T>(IReadOnlyList<T> items) : IEnumerable<T>
    {
        public int Enumerations { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            Enumerations++;
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [TestMethod]
    public void SortBy_ResultNotEnumerated_ReadsNoElementAndCallsNoKeySelector()
    {
        var source = new CountingSequence<int?>([3, 1, 2]);
        var keySelectorCalls = 0;

        var sorted = Sut().SortBy(source, item => { keySelectorCalls++; return item!; }, ListSortDirection.Ascending);

        Assert.IsNotNull(sorted);
        Assert.AreEqual(0, source.Enumerations);
        Assert.AreEqual(0, keySelectorCalls);
    }

    [TestMethod]
    public void SortBy_ResultEnumeratedTwice_ReadsTheSourceOnceAndCallsTheKeySelectorOncePerElement()
    {
        var source = new CountingSequence<int?>([3, 1, 2]);
        var keySelectorCalls = 0;
        var sorted = Sut().SortBy(source, item => { keySelectorCalls++; return item!; }, ListSortDirection.Ascending)!;

        var first = sorted.ToList();
        var second = sorted.ToList();

        CollectionAssert.AreEqual(new int?[] { 1, 2, 3 }, first);
        CollectionAssert.AreEqual(first, second);
        Assert.AreEqual(1, source.Enumerations);
        Assert.AreEqual(3, keySelectorCalls);
    }

    [TestMethod]
    public void SortBy_Ascending_PutsElementsWithoutKeyFirstAndKeepsTheOrderOfEqualKeys()
    {
        (string Name, int? Key)[] source = [("c", 2), ("x", null), ("a", 1), ("b", 1), ("y", null)];

        var sorted = Sut().SortBy(source, item => item.Key!, ListSortDirection.Ascending)!;

        CollectionAssert.AreEqual(new[] { "x", "y", "a", "b", "c" }, sorted.Select(item => item.Name).ToList());
    }

    [TestMethod]
    public void SortBy_Descending_PutsElementsWithoutKeyLastAndKeepsTheOrderOfEqualKeys()
    {
        (string Name, int? Key)[] source = [("a", 1), ("x", null), ("c", 2), ("b", 1), ("y", null)];

        var sorted = Sut().SortBy(source, item => item.Key!, ListSortDirection.Descending)!;

        CollectionAssert.AreEqual(new[] { "c", "a", "b", "x", "y" }, sorted.Select(item => item.Name).ToList());
    }

    [TestMethod]
    public void SortBy_KeySelectorThrows_ThrowsWhenEnumeratedAndNotWhenCalled()
    {
        int?[] source = [3, 1, 2];

        var sorted = Sut().SortBy<int?>(source, _ => throw new InvalidOperationException("key"), ListSortDirection.Ascending)!;

        Assert.ThrowsExactly<InvalidOperationException>(() => sorted.ToList());
        Assert.ThrowsExactly<InvalidOperationException>(() => sorted.ToList());
    }

    [TestMethod]
    public void SortBy_NullSource_GivesNull() =>
        Assert.IsNull(Sut().SortBy<int?>(null, item => item!, ListSortDirection.Ascending));

    [TestMethod]
    public void SortBy_UnknownOrder_ThrowsWhenCalled() =>
        Assert.ThrowsExactly<NotSupportedException>(() => Sut().SortBy<int?>([1], item => item!, (ListSortDirection)42));

    [TestMethod]
    public void ListSort_ResultNotEnumerated_ReadsNoElement()
    {
        var source = new CountingSequence<int?>([3, 1, 2]);

        var sorted = Sut().ListSort(source, ListSortDirection.Ascending);

        Assert.IsNotNull(sorted);
        Assert.AreEqual(0, source.Enumerations);
    }

    [TestMethod]
    public void ListSort_ResultEnumeratedTwice_ReadsTheSourceOnce()
    {
        var source = new CountingSequence<int?>([3, null, 1, 2]);
        var sorted = Sut().ListSort(source, ListSortDirection.Ascending)!;

        var first = sorted.ToList();
        var second = sorted.ToList();

        CollectionAssert.AreEqual(new int?[] { null, 1, 2, 3 }, first);
        CollectionAssert.AreEqual(first, second);
        Assert.AreEqual(1, source.Enumerations);
    }

    [TestMethod]
    public void ListSort_Ascending_PutsNullsFirstAndKeepsTheOrderOfEqualElements()
    {
        // One gram and a thousand milligrams compare as equal and are two values.
        var gram = new CqlQuantity(1m, "g");
        var milligrams = new CqlQuantity(1000m, "mg");
        CqlQuantity?[] source = [new CqlQuantity(2m, "g"), gram, null, milligrams];

        var sorted = Sut().ListSort(source, ListSortDirection.Ascending)!.ToList();

        Assert.AreEqual(4, sorted.Count);
        Assert.IsNull(sorted[0]);
        Assert.AreSame(gram, sorted[1]);
        Assert.AreSame(milligrams, sorted[2]);
        Assert.AreSame(source[0], sorted[3]);
    }

    [TestMethod]
    public void ListSort_Descending_PutsNullsLastAndReversesTheOrderOfEqualElements()
    {
        var gram = new CqlQuantity(1m, "g");
        var milligrams = new CqlQuantity(1000m, "mg");
        CqlQuantity?[] source = [gram, null, new CqlQuantity(2m, "g"), milligrams];

        var sorted = Sut().ListSort(source, ListSortDirection.Descending)!.ToList();

        Assert.AreEqual(4, sorted.Count);
        Assert.AreSame(source[2], sorted[0]);
        Assert.AreSame(milligrams, sorted[1]);
        Assert.AreSame(gram, sorted[2]);
        Assert.IsNull(sorted[3]);
    }

    [TestMethod]
    public void ListSort_NullSource_GivesNull() =>
        Assert.IsNull(Sut().ListSort<int?>(null, ListSortDirection.Ascending));

    [TestMethod]
    public void ListSort_UnknownOrder_ThrowsWhenCalled() =>
        Assert.ThrowsExactly<NotSupportedException>(() => Sut().ListSort<int?>([1], (ListSortDirection)42));

    [TestMethod]
    public void Collapse_InputIsADeferredSequence_EnumeratesItOnce()
    {
        var source = new CountingSequence<CqlInterval<int?>?>(
        [
            new CqlInterval<int?>(5, 9, true, true),
            new CqlInterval<int?>(1, 3, true, true),
            new CqlInterval<int?>(2, 6, true, true),
        ]);

        var collapsed = Sut().Collapse(source, null)!.ToList();

        Assert.AreEqual(1, collapsed.Count);
        Assert.AreEqual(1, collapsed[0]!.low);
        Assert.AreEqual(9, collapsed[0]!.high);
        Assert.AreEqual(1, source.Enumerations);
    }

    [TestMethod]
    public void Collapse_InputIsTheResultOfSortBy_ReadsTheUnsortedSourceOnce()
    {
        var source = new CountingSequence<CqlInterval<int?>?>(
        [
            new CqlInterval<int?>(5, 9, true, true),
            new CqlInterval<int?>(1, 3, true, true),
        ]);
        var keySelectorCalls = 0;
        var sut = Sut();
        var sorted = sut.SortBy(source, interval => { keySelectorCalls++; return interval!.low!; }, ListSortDirection.Ascending);

        var collapsed = sut.Collapse(sorted, null)!.ToList();

        Assert.AreEqual(2, collapsed.Count);
        Assert.AreEqual(1, source.Enumerations);
        Assert.AreEqual(2, keySelectorCalls);
    }
}
