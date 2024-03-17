using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler.Infrastructure.Graphs;
using Hl7.Cql.Compiler.Infrastructure.Sets;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Contains a set of libraries ordered topologically.
/// </summary>
public class LibrarySet : IReadOnlyCollection<Library>, IReadOnlyDictionary<string, Library>
{
    /// <summary>
    /// The name of this library set. An example could be the directory name containing the libraries.
    /// </summary>
    public string Name { get; }

    private IReadOnlyCollection<Library> TopologicallySortedLibraries { get; set; }

    private IReadOnlySet<Library> RootLibraries { get; set; }

    private readonly Dictionary<string, (Library library, List<Library> dependencies)> _libraryInfosByKey; // Key is the NameAndVersion of a Library

    /// <summary>
    /// Initializes a new instance of the <see cref="LibrarySet"/> class.
    /// </summary>
    /// <param name="name">The name of the library set.</param>
    public LibrarySet(string name = "")
    {
        Name = name;
        TopologicallySortedLibraries = Array.Empty<Library>();
        RootLibraries = EmptySet<Library>.Empty;
        _libraryInfosByKey = new Dictionary<string, (Library library, List<Library> dependencies)>();
    }

    /// <exception cref="CqlException{KeyNotFoundError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    private bool TryGetLibraryInfoByKey(
        string? key,
        bool throwError,
        out (Library library, List<Library> dependencies) info)
    {
        info = default;
        if (key is not (null or ""))
        {
            if (_libraryInfosByKey.TryGetValue(key, out info))
                return true;
        }

        if (throwError) throw new KeyNotFoundError(key ?? "(null)", "Library").ToException();
        return false;
    }

    /// <summary>
    /// Gets the library with the specified key.
    /// </summary>
    /// <param name="key">The key of the library to retrieve.</param>
    /// <param name="throwError">Indicates whether to throw an exception if the library is not found.</param>
    /// <returns>The library with the specified key, or <c>null</c> if the library is not found.</returns>
    /// <exception cref="CqlException{KeyNotFoundError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public Library? GetLibrary(string key, bool throwError = true) =>
        TryGetLibraryInfoByKey(key, throwError, out var info) ? info.library : null;


    /// <summary>
    /// Gets the dependencies of the library with the specified key.
    /// </summary>
    /// <param name="key">The key of the library to retrieve the dependencies for.</param>
    /// <param name="throwError">Indicates whether to throw an exception if the library is not found.</param>
    /// <returns>The dependencies of the library with the specified key, or an empty list if the library is not found.</returns>
    /// <exception cref="CqlException{KeyNotFoundError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public IReadOnlyList<Library> GetLibraryDependencies(string key, bool throwError = true) =>
        TryGetLibraryInfoByKey(key, throwError, out var info) ? info.dependencies : Array.Empty<Library>();

    /// <summary>
    /// Loads the libraries from the specified collection of files.
    /// </summary>
    /// <param name="files">The collection of files to load the libraries from.</param>
    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="CqlException{LibraryMissingNameAndVersionError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    /// <exception cref="CqlException{NotAValidLibraryFileError}"></exception>
    public void LoadLibraries(IReadOnlyCollection<FileInfo> files)
    {
        // Loading libraries in parallel

        (FileInfo file, int index)[] input = files
            .Select((file, ordinal) => (file, index: ordinal))
            .ToArray();

        var libraries = new Library[input.Length];

        Parallel.ForEach(input, t =>
        {
            var library = Library.LoadFromJson(t.file)!;
            libraries[t.index] = library;
        });

        foreach (var library in libraries)
        {
            try
            {
                _libraryInfosByKey.Add(library.NameAndVersion!, (library, new List<Library>()));
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                // This will be due to a duplicate key
                throw new LibraryIdentifierMustBeUniqueError(library).ToException();
            }
        }

        // Determining root libraries i.e. those that are not dependencies for others.

        var fromToPairs = _libraryInfosByKey
            .Values
            .SelectMany(
                value => value.library.includes ?? Array.Empty<IncludeDef>(),
                (tuple, includeDef) =>
                {
                    var fromLib = tuple.library;
                    var fromKey = fromLib.NameAndVersion!;

                    var toKey = includeDef.NameAndVersion() ?? throw new LibraryMissingIncludeDefPathError(fromLib, includeDef).ToException();
                    var toLib = GetLibrary(toKey, false) ?? throw new LibraryIncludeDefUnresolvedError(fromLib, includeDef).ToException();
                    _libraryInfosByKey[fromKey].dependencies.Add(toLib);

                    return (From: fromLib, To: toLib);
                });

        HashSet<Library> rootLibraries = new();
        foreach (var root in fromToPairs.Roots())
        {
            rootLibraries.Add(root);
        }
        RootLibraries = rootLibraries;

        // Topological sort libraries so that most dependent libraries are placed before less dependent ones

        const Library RootOfRoots = null!;
        var sortedKeys = Traversal.TopologicalSort<Library>(
                RootOfRoots!,
                fromLibrary => fromLibrary switch
                {
                    RootOfRoots => RootLibraries,
                    _ => _libraryInfosByKey[fromLibrary.NameAndVersion!].dependencies
                })
            .SkipLast(1)
            .ToList();
        Debug.Assert(sortedKeys.Count == _libraryInfosByKey.Count);
        TopologicallySortedLibraries = sortedKeys;
    }

    IEnumerator<KeyValuePair<string, Library>> IEnumerable<KeyValuePair<string, Library>>.GetEnumerator() =>
        TopologicallySortedLibraries.Select(lib => KeyValuePair.Create(lib.NameAndVersion!, lib)).GetEnumerator();

    /// <inheritdoc/>
    public IEnumerator<Library> GetEnumerator() => TopologicallySortedLibraries.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
    /// <inheritdoc/>
    public int Count => TopologicallySortedLibraries.Count;

    /// <inheritdoc/>
    bool IReadOnlyDictionary<string, Library>.ContainsKey(string key) =>
        _libraryInfosByKey.ContainsKey(key);

    /// <inheritdoc/>
    bool IReadOnlyDictionary<string, Library>.TryGetValue(string key, [NotNullWhen(true)] out Library? value)
    {
        if (_libraryInfosByKey.TryGetValue(key, out var t))
        {
            value = t.library;
            return true;
        }

        value = default;
        return false;
    }

    /// <inheritdoc/>
    Library IReadOnlyDictionary<string, Library>.this[string key] => _libraryInfosByKey[key].library;
    
    /// <inheritdoc/>
    IEnumerable<string> IReadOnlyDictionary<string, Library>.Keys => _libraryInfosByKey.Keys;
    
    /// <inheritdoc/>
    IEnumerable<Library> IReadOnlyDictionary<string, Library>.Values => _libraryInfosByKey.Values.Select(v => v.library).ToArray();
}
