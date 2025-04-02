/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

internal static class CqlComparerSharedMethods
{
    internal static Maybe<bool?> EqualsNulls(bool leftIsNull, bool rightIsNull)
    {
        var result = (leftIsNull, rightIsNull) switch
        {
            (true, true) => null,
            (true, _)    => null,
            (_, true)    => null,
            // (true, true) => true,   // null,
            // (true, _)    => false,  // null,
            // (_, true)    => false,  // null,
            _            => Maybe.NoValueOf<bool?>(),
        };
        return result;
    }

    internal static Maybe<int?> CompareAnyNullReturnsNull(
        bool leftIsNull,
        bool rightIsNull) =>
        (leftIsNull, rightIsNull) switch
        {
            (true, true) => null,
            (true, _)    => null,
            (_, true)    => null,
            _            => NoValueOf<int?>(),
        };

    internal static bool EquivalenceFromCompare(int? comparison) =>
        comparison switch
        {
            null => true,
            0    => true,
            _    => false,
        };

    internal static ICqlComparer ToPlainCqlComparer<T>(this ICqlComparer<T> genericComparer) =>
        genericComparer as ICqlComparer // All derived from CqlComparer<T> will also be ICqlComparer
        ?? new PlainCqlComparerWrapper<T>(genericComparer); // This is a fallback for external ICqlComparer<T> implementations
}

file class PlainCqlComparerWrapper<T>(ICqlComparer<T> genericComparer) :
    CqlComparerWrapper<object, T>(genericComparer, t => (T?)t);