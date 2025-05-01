namespace Hl7.Cql.Elm;

internal static class LibraryExtensions
{
    public static IReadOnlyDictionary<string, LibraryDependencyNode> ToLibraryDependencyNodesByVersionedIdentifiers(this IEnumerable<Library> libraries)
    {
        var nodesById =
            libraries
                .Select(l => new LibraryDependencyNode(l.VersionedLibraryIdentifier, l, []))
                .ToDictionary(l => l.VersionedIdentifier);

        foreach (var node in nodesById.Values)
        {
            var dependencyNodes =
                (node.Library!.includes ?? [])
                    .Select(includeDef => includeDef.VersionedLibraryIdentifier)
                    .Select(includeId =>
                                nodesById
                                    .GetValueOrDefault(includeId)
                                    ?? new LibraryDependencyNode(includeId, null, []));
            node.Dependencies.AddRange(dependencyNodes);
        }

        return nodesById;
    }
}

internal record LibraryDependencyNode(
    string VersionedIdentifier,
    Library? Library,
    List<LibraryDependencyNode> Dependencies)
{
    public bool HasMissingDependencies => Dependencies.Any(d => d.Library is null);
    public bool HasMissingDependenciesRecursive => Dependencies.Any(d => d.Library is null || d.HasMissingDependenciesRecursive);
}