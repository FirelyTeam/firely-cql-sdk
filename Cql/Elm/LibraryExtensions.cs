using System.Collections.Immutable;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Elm;

internal static class LibraryExtensions
{
    public static bool HasMissingIncludesRecursive(
        this Library library,
        Func<string, Library?> getLibraryByVersionedIdentifier) =>
        library.includes is { Length: > 0 } includeDefs
        && includeDefs.Any(includeDef => getLibraryByVersionedIdentifier(includeDef.GetVersionedIdentifier()!) switch
        {
            null           => true,
            { } includeLib => includeLib.HasMissingIncludesRecursive(getLibraryByVersionedIdentifier),
        });

    public static IReadOnlyDictionary<string, UnresolvedLibraryDependencyNode> ToUnresolvedLibraryDependencyNodesDictionary(this IEnumerable<Library> libraries)
    {
        var nodesById =
            libraries
                .Select(l => new UnresolvedLibraryDependencyNode(l.GetVersionedIdentifier()!, l, []))
                .ToDictionary(l => l.VersionedIdentifier);

        foreach (var node in nodesById.Values)
        {
            var dependencyNodes =
                (node.Library!.includes ?? [])
                    .Select(includeDef => includeDef.GetVersionedIdentifier()!)
                    .Select(includeId =>
                                nodesById
                                    .GetValueOrDefault(includeId)
                                    ?? new UnresolvedLibraryDependencyNode(includeId, null, []));
            node.Dependencies.AddRange(dependencyNodes);
        }

        return nodesById;
    }
}

internal record UnresolvedLibraryDependencyNode
(
    string VersionedIdentifier,
    Library? Library,
    List<UnresolvedLibraryDependencyNode> Dependencies)
{
    public bool HasMissingDependencies => Dependencies.Any(d => d.Library is null);
    public bool HasMissingDependenciesRecursive => Dependencies.Any(d => d.Library is null || d.HasMissingDependenciesRecursive);
}