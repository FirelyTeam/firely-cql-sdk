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
    /*
     *
     * Equivalence : https://cql.hl7.org/04-logicalspecification.html#equivalent
     *
     * The Equivalent operator returns:
     * - true if the arguments are the same value, or if they are both null;
     * - and false otherwise.
     *
     * With the exception of null behavior and the semantics for specific types defined below, equivalence is the same as equality.
     */

    internal static bool? EquivalentOnNullsOnly<T>(
        [NoEnumeration, NotNullWhen(true)] T? left,
        [NoEnumeration, NotNullWhen(true)] T? right) =>
        (left, right) switch
        {
            (null, null) => true,
            (null, _)    => false,
            (_, null)    => false,
            _            => null
        };

    internal static int? CompareOnNullsOnly<T>(
        [NoEnumeration, NotNullWhen(true)] T? left,
        [NoEnumeration, NotNullWhen(true)] T? right) =>
        (left, right) switch
        {
            (null, null) => 0,
            (null, _)    => -1,
            (_, null)    => 1,
            _            => null
        };

    internal static int GetHashCodeForType<T>() => typeof(T).GetHashCode();

    internal static ICqlComparer<object> CreateCqlComparerAndUnwrapNonGeneric(Type comparerType, params object[] args)
    {
        var icqlComparerType = comparerType.GetTypeImplementingGenericTypeDefinition(typeof(ICqlComparer<>));
        if (icqlComparerType is null)
            throw new ArgumentException("comparerType must be ICqlComparer<T>", nameof(comparerType));

        object comparer = Activator.CreateInstance(comparerType, args)!;
        if (comparer is ICqlComparer<object> objComparer)
            return objComparer;

        var icqlComparerTypeArg = icqlComparerType.GetGenericArguments()[0];
        ICqlComparer<object> nonGenericComparer = (ICqlComparer<object>)MethodInfoWrapNonGeneric.MakeGenericMethod(icqlComparerTypeArg).Invoke(null, [comparer])!;
        return nonGenericComparer;
    }

    private static readonly MethodInfo MethodInfoWrapNonGeneric =
        ReflectionUtility.GenericMethodDefinitionOf(() => WrapNonGeneric<object>(null!));

    internal static ICqlComparer<object> WrapNonGeneric<T>(this ICqlComparer<T> genericComparer) =>
        genericComparer as CqlComparer<object>
        ?? new NonGenericAdapterCqlComparer<T>(genericComparer);

    internal static ICqlComparer<T>? UnwrapGeneric<T>(this ICqlComparer<object> prev) =>
        prev is IAdapter { Inner: CqlComparer<T> inner }
            ? inner
            : prev as CqlComparer<T> // In this case T will be object
    ;
}

file class NonGenericAdapterCqlComparer<T>(ICqlComparer<T> genericComparer) : CqlComparerAdapter<T, object>(genericComparer, t => (T?)t);