using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS8321

internal readonly record struct LibrarySetEnumerable(
    LibrarySet LibrarySet,
    Action<Library>? OnNextLibrary) : IEnumerable<Library>
{
    public static implicit operator LibrarySetEnumerable(LibrarySet librarySet) => new(librarySet, null);
    public IEnumerator<Library> GetEnumerator() => LibrarySet.WithEach(OnNextLibrary).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

internal static class LibrarySetEnumerableExtensions
{
    public static LibrarySetEnumerable ToLibrarySetEnumerable(
        this LibrarySet librarySet,
        Action<Library>? onNextLibrary = null) =>
        new(librarySet, onNextLibrary);
}