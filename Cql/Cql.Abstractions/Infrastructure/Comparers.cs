/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Abstractions.Infrastructure;


#region Comparer

internal class DelegatedComparer<T>(Func<T?, T?, int> compare) : IComparer<T>
{
    public int Compare(T? x, T? y) => compare(x, y);
}

internal static class ComparerFactory
{
    public static class For<T>
    {
        public static IComparer<T> Create(Func<T?, T?, int> compare) => new DelegatedComparer<T>(compare);

        public static IComparer<T> CreateByKey<TKey>(
            Func<T, TKey> getKey,
            Func<TKey, TKey, int> compare)
            where TKey : notnull => new DelegatedComparer<T>((x, y) => compare(getKey(x!), getKey(y!)));

        public static IComparer<T> CreateByKey<TKey>(Func<T, TKey> getKey)
            where TKey : notnull =>
            CreateByKey(getKey, Comparer<TKey>.Default.Compare);
    }

    public static IComparer<T> Create<T>(Func<T?, T?, int> compare) => For<T>.Create(compare);

    public static IComparer<T> CreateByKey<T, TKey>(
        Func<T, TKey> getKey,
        Func<TKey, TKey, int> compare)
        where T : notnull
        where TKey : notnull => For<T>.CreateByKey(getKey, compare);

    public static IComparer<T> CreateByKey<T, TKey>(Func<T, TKey> getKey)
        where T : notnull
        where TKey : notnull => For<T>.CreateByKey(getKey);
}

#endregion

#region EqualityComparer

internal class DelegatedEqualityComparer<T>(
    Func<T?, T?, bool> equals,
    Func<T, int> getHashCode)
    : IEqualityComparer<T>
{
    public bool Equals(T? x, T? y) => equals(x, y);

    public int GetHashCode([DisallowNull] T obj) => getHashCode(obj);
}

internal static class EqualityComparerFactory
{
    public static class For<T>
    {
        public static IEqualityComparer<T> Create(
            Func<T?, T?, bool> equals,
            Func<T, int> getHashCode) => new DelegatedEqualityComparer<T>(equals, getHashCode);

        public static IEqualityComparer<T> CreateByKey<TKey>(
            Func<T, TKey> getKey,
            Func<TKey, TKey, bool> equals,
            Func<TKey, int> getHashCode)
            where TKey : notnull => new DelegatedEqualityComparer<T>(
                (x, y) => equals(getKey(x!), getKey(y!)),
                o => getHashCode(getKey(o)));

        public static IEqualityComparer<T> CreateByKey<TKey>(Func<T, TKey> getKey)
            where TKey : notnull =>
            CreateByKey(getKey, EqualityComparer<TKey>.Default.Equals, EqualityComparer<TKey>.Default.GetHashCode);
    }

    public static IEqualityComparer<T> Create<T>(
        Func<T?, T?, bool> equals,
        Func<T, int> getHashCode) =>
        For<T>.Create(equals, getHashCode);

    public static IEqualityComparer<T> CreateByKey<T, TKey>(
        Func<T, TKey> getKey,
        Func<TKey, TKey, bool> equals,
        Func<TKey, int> getHashCode)
        where T : notnull
        where TKey : notnull =>
        For<T>.CreateByKey(getKey, equals, getHashCode);

    public static IEqualityComparer<T> CreateByKey<T, TKey>(Func<T, TKey> getKey)
        where T : notnull
        where TKey : notnull =>
        For<T>.CreateByKey(getKey);
}

#endregion