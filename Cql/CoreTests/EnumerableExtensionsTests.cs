/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions.Infrastructure;

namespace CoreTests;

[TestClass]
public class EnumerableExtensionsTests
{
    [TestMethod]
    public void CastToArray_FromList_ProducesArrayWithSameElementsAndOrder()
    {
        var source = new List<object?> { 1, 2, 3 };

        var result = source.CastToArray<object?, int>();

        CollectionAssert.AreEqual(new[] { 1, 2, 3 }, result);
    }

    [TestMethod]
    public void CastToArray_FromArraySource_UsesArrayFastPathAndProducesSameResult()
    {
        object?[] source = ["a", "b", "c"];

        var result = source.CastToArray<object?, string>();

        CollectionAssert.AreEqual(new[] { "a", "b", "c" }, result);
    }

    [TestMethod]
    public void CastToArray_EmptySource_ProducesEmptyArray()
    {
        var source = new List<object?>();

        var result = source.CastToArray<object?, int>();

        Assert.AreEqual(0, result.Length);
    }

    [TestMethod]
    public void CastToArray_WithNullElement_CastsToNullableTargetType()
    {
        var source = new List<object?> { 1, null, 3 };

        var result = source.CastToArray<object?, int?>();

        CollectionAssert.AreEqual(new int?[] { 1, null, 3 }, result);
    }

    [TestMethod]
    public void CastToArray_ElementNotAssignableToTargetType_Throws()
    {
        var source = new List<object?> { 1, "not an int" };

        Assert.ThrowsException<InvalidCastException>(() => source.CastToArray<object?, int>());
    }
}
