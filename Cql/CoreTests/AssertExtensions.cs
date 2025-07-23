/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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

}
