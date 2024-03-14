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

    public static IEnumerable<T> Roots<T>(this IEnumerable<(T From, T To)> edges)
    {
        HashSet<T> froms = new HashSet<T>();
        HashSet<T> tos = new HashSet<T>();
        foreach (var edge in edges)
        {
            froms.Add(edge.From);
            tos.Add(edge.To);
        }

        return froms.Except(tos);
    }

    public static IEnumerable<T> TopologicalSort<T>(
        T current,
        Func<T, IEnumerable<T>> getNextItems)
    {
        // Get the whole graph first (assuming everything is reachable from the current node)
        HashSet<T> unvisited = new();
        foreach (var next in DepthFirst(current, getNextItems))
        {
            unvisited.Add(next);
        }

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