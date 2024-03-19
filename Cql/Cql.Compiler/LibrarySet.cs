using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Abstractions.Infrastructure;
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

    private readonly Dictionary<string, (Library library, LibraryByNameAndVersionHashSet dependencies)> _libraryInfosByKey; // Key is the NameAndVersion of a Library
    
    private (IReadOnlySet<Library> Roots, IReadOnlyCollection<Library> TopologicallySorted) _calculatedState;
    private readonly LibraryByNameAndVersionHashSet _librariesNotCalculatedYet;

    private bool ShouldRecalculateState() => _librariesNotCalculatedYet.Any();


    private static readonly (IReadOnlySet<Library> Roots, IReadOnlyCollection<Library> TopologicallySorted)
        EmptyCached = (EmptySet<Library>.Instance, Array.Empty<Library>());

    /// <summary>
    /// Initializes a new instance of the <see cref="LibrarySet"/> class.
    /// </summary>
    /// <param name="name">The name of the library set.</param>
    public LibrarySet(string name = "")
    {
        Name = name;
        _librariesNotCalculatedYet = new();
        _calculatedState = EmptyCached;
        _libraryInfosByKey = new Dictionary<string, (Library library, LibraryByNameAndVersionHashSet dependencies)>();
    }

    /// <exception cref="CqlException{KeyNotFoundError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    private bool TryGetLibraryInfoByKey(
        string? key,
        bool throwError,
        out (Library library, LibraryByNameAndVersionHashSet dependencies) info)
    {
        if (ShouldRecalculateState())
            RecalculateState();

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
    public IReadOnlySet<Library> GetLibraryDependencies(string key, bool throwError = true) =>
        TryGetLibraryInfoByKey(key, throwError, out var info) ? info.dependencies : EmptySet<Library>.Instance;

    /// <summary>
    /// Loads the libraries from the specified collection of files.
    /// </summary>
    /// <param name="files">The collection of files to load the libraries from.</param>
    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="CqlException{LibraryMissingNameAndVersionError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    /// <exception cref="CqlException{NotAValidLibraryFileError}"></exception>
    public IReadOnlyCollection<Library> LoadLibraries(IReadOnlyCollection<FileInfo> files)
    {
        // Loading libraries in parallel

        (FileInfo file, int index)[] input = files
            .Select((file, ordinal) => (file, index: ordinal))
            .ToArray();

        Library[] libraries = new Library[input.Length];
        Parallel.ForEach(input, t =>
        {
            var library = Library.LoadFromJson(t.file)!;
            libraries[t.index] = library;
        });

        foreach (var library in libraries)
        {
            try
            {
                _libraryInfosByKey.Add(library.NameAndVersion()!, (library, new ()));
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

        _librariesNotCalculatedYet.AddRange(libraries);

        return libraries;
    }

    private (IReadOnlySet<Library> Roots, IReadOnlyCollection<Library> TopologicallySorted) GetCalculatedState()
    {
        if (ShouldRecalculateState()) 
            RecalculateState();

        return _calculatedState;
    }

    private void RecalculateState()
    {
        foreach (var library in _librariesNotCalculatedYet)
        {
            var dependencies = _libraryInfosByKey[library.NameAndVersion()!].dependencies;
            if (library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    var toKey = includeDef.NameAndVersion(true)!;
                    var toLib = _libraryInfosByKey.GetValueOrDefault(toKey).library ?? throw new LibraryIncludeDefUnresolvedError(library, includeDef).ToException();
                    dependencies.Add(toLib);
                }
            }
        }
        _librariesNotCalculatedYet.Clear();


        // Determining root libraries i.e. those that are not dependencies for others.

        var allLibraries = _libraryInfosByKey
            .Values
            .Select(v => v.library);

        var rootLibraries = new LibraryByNameAndVersionHashSet(
            allLibraries
            .GetRoots(lib => GetLibraryDependencies(lib.NameAndVersion()!)));

        // Topological sort libraries so that most dependent libraries are placed before less dependent ones

        var topologicallySortedLibraries = allLibraries
            .TopologicalSort(lib => GetLibraryDependencies(lib.NameAndVersion()!))
            .ToList();
        Debug.Assert(topologicallySortedLibraries.Count == _libraryInfosByKey.Count);
        
        // Set calculation state
        _calculatedState = (rootLibraries, topologicallySortedLibraries);
    }

    IEnumerator<KeyValuePair<string, Library>> IEnumerable<KeyValuePair<string, Library>>.GetEnumerator() =>
        GetCalculatedState().TopologicallySorted.Select(lib => KeyValuePair.Create(lib.NameAndVersion()!, lib)).GetEnumerator();

    /// <inheritdoc/>
    public IEnumerator<Library> GetEnumerator() => 
        GetCalculatedState().TopologicallySorted.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
    /// <inheritdoc/>
    public int Count => _libraryInfosByKey.Count;

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

    /// <summary>
    /// Loads the specified library and its dependencies from the specified directory.
    /// </summary>
    /// <param name="elmDirectory">The directory containing the ELM files.</param>
    /// <param name="lib">The name of the library to load.</param>
    /// <param name="version">The version of the library to load.</param>
    /// <returns>A collection of loaded libraries, including the specified library and its dependencies.</returns>
    public IReadOnlyCollection<Library> LoadLibraryAndDependencies(
        DirectoryInfo elmDirectory,
        string lib,
        string version = "")
    {
        List<Library> libraries = new();
        List<(string lib, string version)> librariesToLoad = new() { (lib, version) };

        while (librariesToLoad.Any())
        {
            var librariesToLoadWithOrdinals = librariesToLoad.Select((lib, i) => (lib, ordinal:i)).ToList();
            Library[] librariesLoaded = new Library[librariesToLoad.Count];
            Parallel.ForEach(librariesToLoadWithOrdinals, t =>
            {
                var library = Library.LoadFromJson(elmDirectory, t.lib.lib, t.lib.version)!;
                librariesLoaded[t.ordinal] = library;
            });
            librariesToLoad.Clear();

            foreach (var library in librariesLoaded)
            {
                if (!_libraryInfosByKey.TryAdd(library.NameAndVersion()!, (library, new())))
                    continue; // Already loaded, skip

                if (library.includes is { Length: > 0 } includeDefs)
                {
                    foreach (var includeDef in includeDefs)
                    {
                        if (_libraryInfosByKey.ContainsKey($"{includeDef.path}-{includeDef.version}"))
                            continue; // Already loaded, skip

                        librariesToLoad.Add((includeDef.path, includeDef.version));
                    }
                }
                libraries.Add(library);
            }
        }

        _librariesNotCalculatedYet.AddRange(libraries);

        return libraries;
    }
}
