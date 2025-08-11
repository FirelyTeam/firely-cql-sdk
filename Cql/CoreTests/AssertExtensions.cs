/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
#nullable enable
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CoreTests;

internal static class AssertExtensions
{
    public static void DoesNotThrow(
        this Assert assert,
        Action action)
    {
        try
        {
            action();
        }
        catch (Exception e)
        {
            throw new AssertFailedException("Assertion failed, an exception was not supposed to be thrown. See InnerException for details. ", e);
        }
    }

    [DebuggerStepThrough]
    public static void MultilinesAreEqual(
        this Assert assert,
        string expected,
        string actual,
        string? message = null,
        params object?[] parameters)
    {
        string normalizedExpected = NormalizeNewLines(expected);
        string normalizedActual = NormalizeNewLines(actual);
        Assert.AreEqual(normalizedExpected, normalizedActual, message, parameters);
        string NormalizeNewLines(string multilineString) =>
            Regex.Replace(multilineString, @"\r\n?|\n", "\n");
    }

}
