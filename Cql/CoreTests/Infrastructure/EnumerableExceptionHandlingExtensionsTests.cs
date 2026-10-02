/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Runtime;

namespace CoreTests.Infrastructure;

[TestClass]
public class EnumerableExceptionHandlingExtensionsTests
{
    [TestMethod]
    public void TrySelectToArray_Continue_SkipsFailuresAndPreservesInputIndexes()
    {
        var result = new[] { "a", "b", "c" }.TrySelectToArray(
            (value, index) => value == "b"
                ? throw new InvalidOperationException()
                : $"{index}:{value}",
            _ => new(BatchProcessExceptionContinuation.Continue));

        CollectionAssert.AreEqual(new[] { "0:a", "2:c" }, result);
    }

    [TestMethod]
    public void TrySelectToArray_Break_StopsAfterFirstFailure()
    {
        var visited = new List<int>();
        var result = new[] { 1, 2, 3 }.TrySelectToArray(
            value =>
            {
                visited.Add(value);
                return value == 2
                    ? throw new InvalidOperationException()
                    : value;
            },
            _ => new(BatchProcessExceptionContinuation.Break));

        CollectionAssert.AreEqual(new[] { 1 }, result);
        CollectionAssert.AreEqual(new[] { 1, 2 }, visited);
    }

    [TestMethod]
    public void TryForEach_Continue_ReturnsSuccessfulActionCount()
    {
        var result = new[] { 1, 2, 3 }.TryForEach(
            value =>
            {
                if (value == 2)
                    throw new InvalidOperationException();
            },
            _ => new(BatchProcessExceptionContinuation.Continue));

        Assert.AreEqual(2, result);
    }
}
