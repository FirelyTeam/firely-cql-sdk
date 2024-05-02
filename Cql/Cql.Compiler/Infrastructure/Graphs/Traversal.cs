/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Compiler.Infrastructure.Graphs;

internal static class Traversal
{
    public static IEnumerable<T> DepthFirst<T>(
        T current,
        Func<T, IEnumerable<T>> getNextItems,
        TraversalCallbacks<T> callbacks = default,
        T? previous = default)
    {
        callbacks.Enter?.Invoke((previous, current));
        yield return current;

        foreach (var next in getNextItems(current))
        {
            if (callbacks.AllowEnter?.Invoke((previous, current, next)) ?? true)
            {
                foreach (var grandChild in DepthFirst(next, getNextItems, callbacks, current))
                    yield return grandChild;
            }
        }
        callbacks.Exit?.Invoke((previous, current));
    }


    public static IEnumerable<T> GetRoots<T>(
        this IEnumerable<T> allItems,
        Func<T, IEnumerable<T>> getNextItems)
    {
        HashSet<T> allItemsSet = [..allItems];
        HashSet<T> notARootSet = [..allItems.SelectMany(getNextItems)];
        IEnumerable<T> roots = allItemsSet.Except(notARootSet);
        return roots;
    }

    public static IEnumerable<(T From, T To)> GetEdges<T>(
        this IEnumerable<T> allItems,
        Func<T, IEnumerable<T>> getNextItems) =>
        allItems.SelectMany(getNextItems, (f, t) => (f, t));

    public static IEnumerable<T> TopologicalSort<T>(
        this IEnumerable<T> allItems,
        Func<T, IEnumerable<T>> getNextItems)
    {
        HashSet<T> unvisited = [..allItems];
        switch (unvisited.Count)
        {
            case 0:
                return [];
            case 1:
                return EnumerateSingle(unvisited.First());
        }

        HashSet<T> visited = [];
        Queue<T> results = new();
        TraversalCallbacks<T> traversalCallbacks =
            new(
                Enter: t =>
                {
                    visited.Add(t.Current);
                    unvisited.Remove(t.Current);
                },
                Exit: t =>
                {
                    results.Enqueue(t.Current);
                },
                AllowEnter: t =>
                {
                    var allow = !visited.Contains(t.Next);
                    return allow;
                });

        while (unvisited.Count > 0)
        {
            foreach (var _ in DepthFirst(unvisited.First(), getNextItems, traversalCallbacks))
            {
                // We have to enumerate, even though the resulting item is not used.
            }
        }

        return results;
    }

    private static IEnumerable<T> EnumerateSingle<T>(T first)
    {
        yield return first;
    }
}