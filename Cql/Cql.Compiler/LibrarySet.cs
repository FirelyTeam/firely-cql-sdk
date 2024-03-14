using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Infrastructure.Graphs;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

internal class LibrarySet
{
    private List<string> _sortedKeys;
    private readonly HashSet<string> _rootKeys;
    private readonly Dictionary<string, (string filePath, Library library, List<Library> dependencies)> _libraryInfosByKey; // Key is the NameAndVersion of a Library

    public LibrarySet()
    {
        _sortedKeys = new List<string>();
        _rootKeys = new HashSet<string>();
        _libraryInfosByKey = new Dictionary<string, (string filePath, Library library, List<Library> dependencies)>();
    }

    /// <exception cref="CqlException{TError}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    private bool TryGetLibraryInfoByKey(
        string? key,
        bool throwError,
        out (string filePath, Library library, List<Library> dependencies) info)
    {
        info = default;
        if (key is not (null or ""))
        {
            if (_libraryInfosByKey.TryGetValue(key, out info))
                return true;
        }

        if (throwError) throw new LibraryNotFoundByKey(key ?? "(null)").ToException();
        return false;
    }

    /// <exception cref="CqlException{LibraryNotFoundByKey}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public Library? GetLibrary(string key, bool throwError = false) => 
        TryGetLibraryInfoByKey(key, throwError, out var info) ? info.library : null;


    /// <exception cref="CqlException{LibraryNotFoundByKey}">If no library was found by the specified key and if throwError is set to <c>true</c>.</exception>
    public IReadOnlyList<Library> GetLibraryDependencies(string key, bool throwError = false) =>
        TryGetLibraryInfoByKey(key, throwError, out var info) ? info.dependencies : Array.Empty<Library>();

    public void LoadLibraries(IReadOnlyCollection<FileInfo> files)
    {
        _rootKeys.Clear();
        _sortedKeys.Clear();

        // Loading libraries in parallel

        (FileInfo file, int index)[] input = files
            .Select((file, ordinal) => (file, index: ordinal))
            .ToArray();

        var libraries = new Library[input.Length];

        Parallel.ForEach(input, t =>
        {
            var library = Library.LoadFromJson(t.file);
            if (string.IsNullOrEmpty(library.NameAndVersion))
            {
                throw new LibraryMissingNameAndVersionError(t.file.FullName, library).ToException();
            }
            libraries[t.index] = library;
        });

        for (var index = 0; index < libraries.Length; index++)
        {
            var library = libraries[index];
            string filePath = input[index].file.FullName;

            try
            {
                _libraryInfosByKey.Add(library.NameAndVersion!, (filePath, library, new List<Library>()));
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                // This will be due to a duplicate key
                throw new LibraryNameAndVersionMustBeUniqueError(filePath, library).ToException();
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
                    var toKey = includeDef.NameAndVersion() 
                                ?? throw new LibraryMissingIncludeDefPathError(tuple.filePath, fromLib,
                                    includeDef).ToException();
                    
                    // Make sure we actually have the 'to' library, and add it as a dependency on the 'from' library
                    var toLib = GetLibrary(toKey)
                                ?? throw new LibraryIncludeDefUnresolvedError(tuple.filePath, fromLib, includeDef)
                                    .ToException();
                    _libraryInfosByKey[fromKey].dependencies.Add(toLib);
                    return (From:fromKey, To:toKey);
                });

        foreach (var root in fromToPairs.Roots())
        {
            _rootKeys.Add(root);
        }

        // Topological sort libraries so that most dependent libraries are placed before less dependent ones

        _sortedKeys = Traversal.TopologicalSort(
                "",
                key => key is ""
                    ? _rootKeys
                    : _libraryInfosByKey[key].dependencies.Select(lib => lib.NameAndVersion!))
            .ToList();
    }
}