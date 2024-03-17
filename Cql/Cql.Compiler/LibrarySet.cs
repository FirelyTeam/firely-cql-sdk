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

internal class LibrarySet : IReadOnlyCollection<Library>, IReadOnlyDictionary<string, Library>
{
    public string Name { get; }
    private IReadOnlyCollection<Library> TopologicallySortedLibraries { get; set; }
    private IReadOnlySet<Library> RootLibraries { get; set; }

    private readonly Dictionary<string, (Library library, List<Library> dependencies)> _libraryInfosByKey; // Key is the NameAndVersion of a Library

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

    /// <exception cref="CqlException{KeyNotFoundError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public Library? GetLibrary(string key, bool throwError = false) => 
        TryGetLibraryInfoByKey(key, throwError, out var info) ? info.library : null;


    /// <exception cref="CqlException{KeyNotFoundError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public IReadOnlyList<Library> GetLibraryDependencies(string key, bool throwError = false) =>
        TryGetLibraryInfoByKey(key, throwError, out var info) ? info.dependencies : Array.Empty<Library>();

    /// <exception cref="CqlException{LibraryMissingNameAndVersionError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public void LoadLibraries(IReadOnlyCollection<FileInfo> files)
    {
        // Loading libraries in parallel

        (FileInfo file, int index)[] input = files
            .Select((file, ordinal) => (file, index: ordinal))
            .ToArray();

        var libraries = new Library[input.Length];

        Parallel.ForEach(input, t =>
        {
            var library = Library.LoadFromJson(t.file);
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
                    var toLib = GetLibrary(toKey) ?? throw new LibraryIncludeDefUnresolvedError(fromLib, includeDef).ToException();
                    _libraryInfosByKey[fromKey].dependencies.Add(toLib);
                    
                    return (From:fromLib, To:toLib);
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

    public IEnumerator<Library> GetEnumerator() => TopologicallySortedLibraries.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public int Count => TopologicallySortedLibraries.Count;

    bool IReadOnlyDictionary<string, Library>.ContainsKey(string key) => 
        _libraryInfosByKey.ContainsKey(key);

    bool IReadOnlyDictionary<string, Library>.TryGetValue(string key, [NotNullWhen(true)]out Library? value)
    {
        if (_libraryInfosByKey.TryGetValue(key, out var t))
        {
            value = t.library;
            return true;
        }

        value = default;
        return false;
    }

    public Library this[string key] => _libraryInfosByKey[key].library;
    IEnumerable<string> IReadOnlyDictionary<string, Library>.Keys => _libraryInfosByKey.Keys;
    IEnumerable<Library> IReadOnlyDictionary<string, Library>.Values => _libraryInfosByKey.Values.Select(v => v.library).ToArray();
}