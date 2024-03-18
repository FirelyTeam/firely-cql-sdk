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
        HashSet<T> allItemsSet = new HashSet<T>(allItems);
        HashSet<T> notARootSet = new HashSet<T>(allItems.SelectMany(getNextItems));
        IEnumerable<T> roots = allItemsSet.Except(notARootSet);
        return roots;
    }

    public static IEnumerable<T> TopologicalSort<T>(
        this IEnumerable<T> allItems,
        Func<T, IEnumerable<T>> getNextItems)
    {
        HashSet<T> unvisited = new(allItems);
        HashSet<T> visited = new();
        Queue<T> results = new();
        TraversalCallbacks<T> callbacks2 =
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
            foreach (var _ in DepthFirst(unvisited.First(), getNextItems, callbacks2))
            {
                // We have to enumerate, even though the resulting item is not used.
            }
        }

        return results;
    }
}