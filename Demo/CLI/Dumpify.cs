/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Dumpify;

/// <summary>
/// The Dumpify Nuget package is problematic because it does not have a strong name.
/// To keep the current code intact after removing the Dumpify package,
/// we can create a dummy class with the same extension methods.
/// </summary>
internal static class DumpifyExtensions
{
    public static T DumpConsole<T>(this T obj, string? header = null) => obj;
}