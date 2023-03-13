using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public class DefinitionDictionary<T>
        where T : class
    {

        public static string? NameAndVersion(string? name, string? version)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;
            else if (string.IsNullOrWhiteSpace(version))
                return name;
            else
                return $"{name}-{version}";
        }

        private Dictionary<string, Dictionary<string, List<(Type[], T)>>> ExpressionsByLibrary = new Dictionary<string, Dictionary<string, List<(Type[], T)>>>();

        private Dictionary<string, List<Type>> TupleTypes = new Dictionary<string, List<Type>>();

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public T this[string? libraryName, string definition]
        {
            get
            {
                libraryName = libraryName ?? string.Empty;
                if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
                {
                    var overloads = library[definition];
                    if (overloads.Count == 1 && overloads[0].Item1.Length == 0)
                        return overloads[0].Item2;
                }
                throw new KeyNotFoundException($"No matching overload for {definition} in {libraryName} could be found.");
            }
        }

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public T this[string? libraryName, string definition, params Type[] parameters]
        {
            get
            {
                libraryName = libraryName ?? string.Empty;
                if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
                {
                    var overloads = library[definition];
                    foreach (var overload in overloads)
                    {
                        if (overload.Item1.Length == parameters.Length)
                        {
                            var match = true;
                            foreach (var tuple in overload.Item1.Zip(parameters, (x, y) => (x, y)))
                            {
                                if (!tuple.Item1.IsAssignableFrom(tuple.Item2))
                                {
                                    match = false;
                                    break;
                                }
                            }
                            if (match)
                                return overload.Item2;
                        }
                    }
                }
                throw new KeyNotFoundException($"No overload of {definition} matches the arguments {string.Join(",", parameters.Select(p => p.Name))}");
            }
        }

        public bool ContainsLibrary(string libraryName) => ExpressionsByLibrary.ContainsKey(libraryName);

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public bool ContainsKey(string? libraryName, string definition)
        {
            libraryName = libraryName ?? string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                return library.ContainsKey(definition);
            }
            return false;
        }

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public bool ContainsKey(string? libraryName, string definition, Type[] parameters)
        {
            libraryName = libraryName ?? string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {

                if (library.TryGetValue(definition, out var overloads))
                {
                    foreach (var overload in overloads)
                    {
                        if (overload.Item1.Length == parameters.Length)
                        {
                            var match = true;
                            foreach (var tuple in overload.Item1.Zip(parameters, (x, y) => (x, y)))
                            {
                                if (!tuple.Item1.IsAssignableFrom(tuple.Item2))
                                {
                                    match = false;
                                    break;
                                }
                            }
                            if (match)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public bool TryGetValue(string? libraryName, string definition, out T? expression)
        {
            libraryName = libraryName ?? string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                if (library.TryGetValue(definition, out var overloads))
                {
                    if (overloads.Count == 1 && overloads[0].Item1.Length == 0)
                    {
                        expression = overloads[0].Item2;
                        return true;
                    }
                }
            }
            expression = default;
            return false;
        }

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public bool TryGetValue(string? libraryName, string definition, Type[] parameters, out T? expression)
        {
            libraryName = libraryName ?? string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                if (library.TryGetValue(definition, out var overloads))
                {
                    foreach (var overload in overloads)
                    {
                        if (overload.Item1.Length == parameters.Length)
                        {
                            var match = true;
                            foreach (var tuple in overload.Item1.Zip(parameters, (x, y) => (x, y)))
                            {
                                if (!tuple.Item1.IsAssignableFrom(tuple.Item2))
                                {
                                    match = false;
                                    break;
                                }
                            }
                            if (match)
                            {
                                expression = overload.Item2;
                                return true;
                            }
                        }
                    }
                }
            }
            expression = default;
            return false;
        }

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public void Add(string libraryName, string definition, T expression)
        {
            if (string.IsNullOrWhiteSpace(libraryName))
            {
                throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));
            }
            libraryName = libraryName ?? string.Empty;
            if (!ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                library = new Dictionary<string, List<(Type[], T)>>();
                ExpressionsByLibrary.Add(libraryName, library);
            }
            if (!library.TryGetValue(definition, out var overloads))
            {
                overloads = new List<(Type[], T)>();
                library.Add(definition, overloads);
            }
            else if (overloads.Any(o => o.Item1.Length == 0))
                throw new ArgumentException($"An overload for {definition} with no parameters has already been added to this dictionary.", nameof(definition));
            overloads.Add((Type.EmptyTypes, expression));
        }

        public bool Exists(string libraryName, string definition, Type[] parameters)
        {
            if (!ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                library = new Dictionary<string, List<(Type[], T)>>();
                ExpressionsByLibrary.Add(libraryName, library);
            }

            if (library.TryGetValue(definition, out var overloads))
            {
                foreach (var overload in overloads)
                {
                    if (overload.Item1.Length == parameters.Length)
                    {
                        var match = true;
                        foreach (var tuple in overload.Item1.Zip(parameters, (x, y) => (x, y)))
                        {
                            if (!tuple.Item1.IsAssignableFrom(tuple.Item2))
                            {
                                match = false;
                                break;
                            }
                        }
                        if (match)
                            return true;
                    }
                }
            }
            return false;
        }

        /// <param name="libraryName"><see langword="null"/> when using a local definition; a library name otherwise.</param>
        public void Add(string libraryName, string definition, Type[] parameters, T expression)
        {
            if (string.IsNullOrWhiteSpace(libraryName))
            {
                throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));
            }
            libraryName = libraryName ?? string.Empty;
            if (!ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                library = new Dictionary<string, List<(Type[], T)>>();
                ExpressionsByLibrary.Add(libraryName, library);
            }

            if (Exists(libraryName, definition, parameters))
                throw new ArgumentException("Overload already exists.");
            
            if (!library.TryGetValue(definition, out var overloads))
            {
                overloads = new List<(Type[], T)>();
                library.Add(definition, overloads);
            }
            overloads.Add((parameters.ToArray(), expression));

        }

        public void AddTupleType(string? library, Type type)
        {
            library = library ?? string.Empty;
            if (!TupleTypes.TryGetValue(library, out var types))
            {
                types = new List<Type>();
                TupleTypes.Add(library, types);
            }
            types.Add(type);
        }

        public bool TryGetTupleTypes(string? library, out IEnumerable<Type>? types)
        {
            library = library ?? string.Empty;
            if (TupleTypes.TryGetValue(library, out var list))
            {
                types = list;
                return true;
            }
            else
            {
                types = null;
                return false;
            }
        }

        public IEnumerable<string> Libraries => ExpressionsByLibrary.Keys;

        public IEnumerable<KeyValuePair<string, List<(Type[], T)>>> DefinitionsForLibrary(string? libraryName)
        {
            libraryName = libraryName ?? string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                return library;
            }
            else throw new ArgumentException($"No library {libraryName} exists", nameof(libraryName));
        }

        public bool TryGetDefinitionsForLibrary(string? libraryName, out IEnumerable<KeyValuePair<string, List<(Type[], T)>>>? definitions)
        {
            if (!string.IsNullOrWhiteSpace(libraryName) && ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                definitions = library;
                return true;
            }
            else
            {
                definitions = null;
                return false;
            }
        }

        public bool TryGetDefinesForLibrary(string? libraryName, out IEnumerable<KeyValuePair<string, T>>? definitions)
        {
            if (!string.IsNullOrWhiteSpace(libraryName) && ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                var allDefinitions = library;
                var defines = new Dictionary<string, T>();   

                foreach(var (defName, overloads) in allDefinitions)
                {
                    foreach(var (paramTypes, del) in overloads)
                    {
                        if(paramTypes.Length == 0)
                        {
                            defines.Add(defName, del);
                        }
                    }
                }

                definitions = defines.ToArray();

                return true;
            }
            else
            {
                definitions = null;
                return false;
            }
        }


        public static DefinitionDictionary<T> MergeIntoNew(params (string, DefinitionDictionary<T>)[] dictionaries)
        {
            var result = new DefinitionDictionary<T>();
            foreach(var tuple in dictionaries)
            {
                foreach (var lib in tuple.Item2.Libraries)
                {
                    var libKey = lib;
                    if (string.IsNullOrWhiteSpace(lib))
                        libKey = tuple.Item1;
                    foreach (var def in tuple.Item2.DefinitionsForLibrary(lib))
                    {
                        foreach (var overload in def.Value)
                        {
                            result.Add(libKey, def.Key, overload.Item1, overload.Item2);
                        }
                    }
                }
            }
            return result;
        }


        public void Merge(params DefinitionDictionary<T>[] dictionaries)
        {
            foreach (var dictionary in dictionaries)
            {
                foreach (var libKey in dictionary.Libraries)
                {
                    // don't overwrite existing libraries
                    if (!Libraries.Contains(libKey))
                    {
                        foreach (var def in dictionary.DefinitionsForLibrary(libKey))
                        {
                            foreach (var overload in def.Value)
                            {
                                Add(libKey, def.Key, overload.Item1, overload.Item2);
                            }
                        }
                        if (dictionary.TryGetTupleTypes(libKey, out var libTupleTypes))
                        {
                            foreach (var type in libTupleTypes!)
                            {
                                AddTupleType(libKey, type);
                            }
                        }
                    }
                }
            }
        }

    }
}
