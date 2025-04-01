/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Comparers;

internal static class CqlComparerSharedMethods
{
    internal static Maybe<bool?> EqualsNulls(bool leftIsNull, bool rightIsNull)
    {
        var result = (leftIsNull, rightIsNull) switch
        {
            (true, true) => true,   // null,
            (true, _)    => false,  // null,
            (_, true)    => false,  // null,
            _            => Maybe.NoValueOf<bool?>(),
        };
        return result;
    }

    /// <summary>
    /// The Equivalent operator returns:
    /// <list type="bullet">
    ///     <item>true if the arguments are the same value, or if they are both null;</item>
    ///     <item>false otherwise</item>
    /// </list>
    /// <para>
    ///     Equivalence is the same as equality except for null behavior and the semantics for specific types.
    /// </para>
    /// <para>
    ///     For more read <a href="https://cql.hl7.org/04-logicalspecification.html#equivalent">the spec</a>.
    /// </para>
    /// </summary>
    internal static Maybe<bool> EquivalentNulls(bool leftIsNull, bool rightIsNull)
    {
        var result = (leftIsNull, rightIsNull) switch
        {
            (true, true) => true,
            (true, _)    => false,
            (_, true)    => false,
            _            => NoValueOf<bool>(),
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

    internal static Maybe<int?> CompareEitherNullReturnsNull(
        bool leftIsNull,
        bool rightIsNull) =>
        (leftIsNull, rightIsNull) switch
        {
            (true, true) => 0,
            (true, _)    => null,
            (_, true)    => null,
            _            => NoValueOf<int?>(),
        };

    internal static Maybe<int?> CompareEitherNullReturnsValue(
        bool leftIsNull,
        bool rightIsNull) =>
        (leftIsNull, rightIsNull) switch
        {
            (true, true) => 0,
            (true, _)    => 1,
            (_, true)    => -1,
            _            => NoValueOf<int?>(),
        };

    internal static bool? EqualsFromCompare(int? comparison) =>
        comparison switch
        {
            null => null,
            0    => true,
            _    => false,
        };

    internal static bool EquivalenceFromCompare(int? comparison) =>
        comparison switch
        {
            null => true,
            0    => true,
            _    => false,
        };

    internal static bool EquivalenceFromEquals(bool? equals) =>
        equals switch
        {
            null  => true,
            true  => true,
            false => false,
        };

    internal static ICqlComparer<object> ToObjectCqlComparer(object comparer)
    {
        if (comparer is ICqlComparer<object> objComparer)
            return objComparer;

        var comparerType = comparer.GetType();
        var icqlComparerType = comparerType.GetTypeImplementingInterface(typeof(ICqlComparer<>));
        if (icqlComparerType is null)
            throw new ArgumentException("comparerType must be ICqlComparer<T>", nameof(comparerType));

        var icqlComparerTypeArg = icqlComparerType.GetGenericArguments()[0];
        ICqlComparer<object> nonGenericComparer =
            (ICqlComparer<object>)MethodInfoWrapNonGeneric.MakeGenericMethod(icqlComparerTypeArg).Invoke(null, [comparer])!;
        return nonGenericComparer;
    }

    private static readonly MethodInfo MethodInfoWrapNonGeneric =
        ReflectionUtility.GenericMethodDefinitionOf(() => ToObjectCqlComparer<object>(null!));

    internal static ICqlComparer<object> ToObjectCqlComparer<T>(this ICqlComparer<T> genericComparer) =>
        genericComparer as CqlComparer<object>
        ?? new ObjectCqlComparerWrapper<T>(genericComparer);

    internal static ICqlComparer<T>? ToTypedCqlComparer<T>(this ICqlComparer<object> prev) =>
        prev is IWrapper { Inner: CqlComparer<T> inner }
            ? inner
            : prev as CqlComparer<T> // In this case T will be object
    ;
}

file class ObjectCqlComparerWrapper<T>(ICqlComparer<T> genericComparer) :
    CqlComparerWrapper<object, T>(genericComparer, t => (T?)t);