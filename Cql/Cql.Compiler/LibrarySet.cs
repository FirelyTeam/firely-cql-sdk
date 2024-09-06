/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
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
using Hl7.Cql.Compiler.Infrastructure.Diagramming;
using Hl7.Cql.Compiler.Infrastructure.Graphs;
using Hl7.Cql.Compiler.Infrastructure.Sets;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Contains a set of libraries ordered topologically.
/// </summary>
[DebuggerDisplay("LibrarySet {Name}")]
public class LibrarySet : IReadOnlyCollection<Library>//, IReadOnlyDictionary<string, Library>
{
    /// <summary>
    /// The name of this library set. An example could be the directory name containing the libraries.
    /// </summary>
    public string Name { get; }

    private readonly Dictionary<string, (Library library, LibraryByNameAndVersionHashSet dependencies)> _libraryInfosByKey; // Key is the NameAndVersion of a Library

    private (IReadOnlySet<Library> RootLibraries, IReadOnlyCollection<Library> TopologicallySortedLibraries) _calculatedState;

    private readonly LibraryByNameAndVersionHashSet _librariesNotCalculatedYet;

    private static readonly (IReadOnlySet<Library> RootLibraries, IReadOnlyCollection<Library> TopologicallySortedLibraries)
        EmptyCached = (EmptySet<Library>.Instance, Array.Empty<Library>());

    private readonly LibrarySetDefinitionCache _librarySetDefinitionCache;

    /// <summary>
    /// Initializes a new instance of the <see cref="LibrarySet"/> class.
    /// </summary>
    /// <param name="name">The name of the library set.</param>
    /// <param name="libraries">A set of libraries.</param>
    public LibrarySet(string name = "", params Library[] libraries)
    {
        Name = name;
        _librariesNotCalculatedYet = [];
        _calculatedState = EmptyCached;
        _libraryInfosByKey = new Dictionary<string, (Library library, LibraryByNameAndVersionHashSet dependencies)>();
        AsReadOnlyDictionary = new ReadOnlyDictionaryAdapter(this);
        AddLibraries(libraries);

        _librarySetDefinitionCache = new LibrarySetDefinitionCache(this);
    }

    /// <exception cref="KeyNotFoundError">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    private bool TryGetLibraryInfoByKey(
        string? nameAndVersion,
        bool throwError,
        out (Library library, LibraryByNameAndVersionHashSet dependencies) info)
    {
        RecalculateStateIfNecessary();

        info = default;
        if (nameAndVersion is not (null or ""))
        {
            if (_libraryInfosByKey.TryGetValue(nameAndVersion, out info))
                return true;
        }

        if (throwError) throw new KeyNotFoundError(nameAndVersion ?? "(null)", "Library").ToException();
        return false;
    }

    /// <summary>
    /// Gets the library with the specified key.
    /// </summary>
    /// <param name="nameAndVersion">The key of the library to retrieve.</param>
    /// <param name="throwError">Indicates whether to throw an exception if the library is not found.</param>
    /// <returns>The library with the specified key, or <c>null</c> if the library is not found.</returns>
    /// <exception cref="KeyNotFoundError">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public Library? GetLibrary(string nameAndVersion, bool throwError = true) =>
        TryGetLibraryInfoByKey(nameAndVersion, throwError, out var info) ? info.library : null;


    /// <summary>
    /// Gets the dependencies of the library with the specified key.
    /// </summary>
    /// <param name="nameAndVersion">The key of the library to retrieve the dependencies for.</param>
    /// <param name="throwError">Indicates whether to throw an exception if the library is not found.</param>
    /// <returns>The dependencies of the library with the specified key, or an empty list if the library is not found.</returns>
    /// <exception cref="KeyNotFoundError">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public IReadOnlySet<Library> GetLibraryDependencies(string? nameAndVersion, bool throwError = true) =>
        TryGetLibraryInfoByKey(nameAndVersion, throwError, out var info) ? info.dependencies : EmptySet<Library>.Instance;

    /// <summary>
    /// Loads the libraries from the specified collection of files.
    /// </summary>
    /// <param name="files">The collection of files to load the libraries from.</param>
    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="CouldNotDeserializeFileError"></exception>
    /// <exception cref="CouldNotValidateLibraryError"></exception>
    /// <exception cref="LibraryMissingIncludeDefPathError"></exception>
    public IReadOnlyCollection<Library> LoadLibraries(IReadOnlyCollection<FileInfo> files)
    {
        // Loading libraries in parallel

        (FileInfo file, int index)[] input = files.SelectToArray((file, ordinal) => (file, index: ordinal));

        Library[] libraries = new Library[input.Length];
        Parallel.ForEach(input, t =>
        {
            var library = Library.LoadFromJson(t.file);
            libraries[t.index] = library;
        });

        AddLibraries(libraries);
        return libraries;
    }

    /// <summary>
    /// Adds the specified libraries to the LibrarySet.
    /// </summary>
    /// <param name="libraries">The libraries to add.</param>
    public void AddLibraries(IEnumerable<Library> libraries)
    {
        foreach (var library in libraries)
        {
            try
            {
                _libraryInfosByKey.Add(library.NameAndVersion()!, (library, []));
                _librariesNotCalculatedYet.Add(library);
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
    }

    private (IReadOnlySet<Library> RootLibraries, IReadOnlyCollection<Library> TopologicallySortedLibraries) GetCalculatedState()
    {
        RecalculateStateIfNecessary();
        return _calculatedState;
    }

    private void RecalculateStateIfNecessary()
    {
        if (_librariesNotCalculatedYet.Count == 0)
            return ;

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

    /// <inheritdoc/>
    public IEnumerator<Library> GetEnumerator() =>
        GetCalculatedState().TopologicallySortedLibraries.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc/>
    public int Count => _libraryInfosByKey.Count;

    /// <summary>
    /// Loads the specified library and its dependencies from the specified directory.
    /// </summary>
    /// <param name="elmDirectory">The directory containing the ELM files.</param>
    /// <param name="libraryName">The name of the library to load.</param>
    /// <param name="version">The version of the library to load.</param>
    /// <returns>A collection of loaded libraries, including the specified library and its dependencies.</returns>
    /// <remarks>Supply the name of the library in <paramref name="libraryName"/>, not the name of the file.</remarks>
    public IReadOnlyCollection<Library> LoadLibraryAndDependencies(
        DirectoryInfo elmDirectory,
        string libraryName,
        string version = "")
    {
        if (Path.GetExtension(libraryName).Equals(".cql", StringComparison.InvariantCultureIgnoreCase))
            libraryName = Path.GetFileNameWithoutExtension(libraryName);

        List<Library> libraries = [];
        List<(string lib, string version)> librariesToLoad = [(libraryName, version)];

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
                if (!_libraryInfosByKey.TryAdd(library.NameAndVersion()!, (library, [])))
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

    internal string MermaidDiagram => this.BuildMermaidFlowChart(
        getNextItems: lib => GetLibraryDependencies(lib.NameAndVersion(false)),
        formatItem: lib => lib.NameAndVersion(false) ?? "???");

    /// <summary>
    /// Given a reference that appears in a library, this method will attempt to resolve the definition.
    /// </summary>
    /// <param name="refContext">The library where <paramref name="reference"/> was found.</param>
    /// <param name="reference">The reference to resolve</param>
    /// <param name="def">The resolved definition, or null if resolution failed.</param>
    /// <typeparam name="TDefinition">The type of definition to resolve.</typeparam>
    internal bool TryResolveDefinition<TDefinition>(
        Library refContext,
        IReferenceElement reference,
        [NotNullWhen(true)] out TDefinition? def)
        where TDefinition : IDefinitionElement =>
        _librarySetDefinitionCache.TryResolveDefinition(refContext, reference, out def);

    /// <summary>
    /// Given a reference that appears in a library, this method will attempt to resolve the definition.
    /// </summary>
    /// <param name="refContext">The library where the reference was found.</param>
    /// <param name="name">The name of the definition to resolve.</param>
    /// <param name="libraryAlias">Qualifier alias for the name, or null if unqualified.</param>
    /// <param name="def">The resolved definition, or null if resolution failed.</param>
    /// <typeparam name="TDefinition">The type of definition to resolve.</typeparam>
    internal bool TryResolveDefinition<TDefinition>(
        Library refContext,
        string name,
        string? libraryAlias,
        [NotNullWhen(true)] out TDefinition? def)
        where TDefinition : IDefinitionElement =>
        _librarySetDefinitionCache.TryResolveDefinition(refContext, name, libraryAlias, out def);

    /// <summary>
    /// Returns this LibrarySet as a <see cref="T:IReadOnlyDictionary{string,Library}"/>
    /// which is also topologically sorted.
    /// </summary>
    /// <remarks>
    /// Keep internal for now, but could be made public if needed.
    /// </remarks>>
    internal IReadOnlyDictionary<string, Library> AsReadOnlyDictionary { get; }

    private readonly record struct ReadOnlyDictionaryAdapter(LibrarySet LibrarySet) : IReadOnlyDictionary<string, Library>
    {
        /// <inheritdoc/>
        public int Count => LibrarySet.Count;

        /// <inheritdoc/>
        public bool ContainsKey(string key) =>
            LibrarySet._libraryInfosByKey.ContainsKey(key);

        /// <inheritdoc/>
        public bool TryGetValue(string key, [NotNullWhen(true)] out Library? value)
        {
            if (LibrarySet._libraryInfosByKey.TryGetValue(key, out var tuple))
            {
                value = tuple.library;
                return true;
            }

            value = null;
            return false;
        }

        /// <inheritdoc/>
        public Library this[string key] =>
            LibrarySet._libraryInfosByKey[key].library;

        /// <inheritdoc/>
        public IEnumerable<Library> Values =>
            LibrarySet.GetCalculatedState().TopologicallySortedLibraries;

        /// <inheritdoc/>
        public IEnumerable<string> Keys =>
            LibrarySet.GetCalculatedState().TopologicallySortedLibraries.Select(lib => lib.NameAndVersion(true)!);

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc/>
        public IEnumerator<KeyValuePair<string, Library>> GetEnumerator() =>
            LibrarySet
                .GetCalculatedState()
                .TopologicallySortedLibraries
                .Select(lib => KeyValuePair.Create(lib.NameAndVersion(true)!, lib))
                .GetEnumerator();
    }
}