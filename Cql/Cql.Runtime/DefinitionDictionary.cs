/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Maps library, definition, and signatures to values.
    /// </summary>
    /// <typeparam name="T">The value mapped by the keys in this dictionary.</typeparam>
    public class DefinitionDictionary<T>
        where T : class
    {

        private readonly Dictionary<string, Dictionary<string, List<(Type[] Signature, T T)>>> ExpressionsByLibrary = new();

        private readonly Dictionary<string, List<Tag>> TagsByLibrary = new();

        /// <summary>
        /// Gets the value for the given <paramref name="libraryName"/>, <paramref name="definition"/>, and signature.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definition">The name of the definition.</param>
        /// <param name="signature">The signature of the definition.</param>
        /// <returns>The value, if present.</returns>
        /// <exception cref="KeyNotFoundException">If the library, definition, &amp; signature is not found in the dictionary.</exception>
        public T this[string? libraryName, string definition, params Type[] signature]
        {
            get
            {
                libraryName ??= string.Empty;
                if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
                {
                    var overloads = library[definition];
                    var t = BestMatch(signature, overloads);
                    if (t == default)
                        throw new KeyNotFoundException($"Key {libraryName}.{definition} matching this signature does not exist.");
                    else return t;
                }
                throw new KeyNotFoundException($"No overload of {definition} matches the arguments {string.Join(",", signature.Select(p => p.Name))}");
            }
        }

        /// <summary>
        /// Returns <see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <returns><see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.</returns>
        public bool ContainsLibrary(string libraryName) => ExpressionsByLibrary.ContainsKey(libraryName);

        /// <summary>
        /// Returns <see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definition"/> is present in this dictionary.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definition">The name of the definition.</param>
        /// <returns><see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definition"/> is present in this dictionary.</returns>
        public bool ContainsKey(string? libraryName, string definition)
        {
            libraryName ??= string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                return library.ContainsKey(definition);
            }
            return false;
        }

        /// <summary>
        /// Returns <see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definition"/>, and <paramref name="signature"/> is present in this dictionary.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definition">The name of the definition.</param>
        /// <param name="signature">The signature of the definition.</param>
        /// <returns><see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definition"/>, and <paramref name="signature"/> is present in this dictionary.</returns>
        public bool ContainsKey(string? libraryName, string definition, Type[] signature)
        {
            libraryName ??= string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {

                if (library.TryGetValue(definition, out var overloads))
                {
                    foreach (var overload in overloads)
                    {
                        var score = Score(signature, overload.Signature);
                        if (score == 0)
                            return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Tries to get the value for the given library and definition.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definition">The name of the definition.</param>
        /// <param name="expression">The <see langword="out"/> parameter containing the result.</param>
        /// <returns><see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definition"/> is present in this dictionary.</returns>
        public bool TryGetValue(string? libraryName, string definition, out T? expression)
        {
            libraryName ??= string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                if (library.TryGetValue(definition, out var overloads))
                {
                    if (overloads.Count == 1 && overloads[0].Signature.Length == 0)
                    {
                        expression = overloads[0].T;
                        return true;
                    }
                }
            }
            expression = default;
            return false;
        }



        /// <summary>
        /// Tries to get the value for <see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definition"/>, and <paramref name="signature"/>.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definition">The name of the definition.</param>
        /// <param name="signature">The signature of the definition.</param>
        /// <param name="expression">The <see langword="out"/> parameter containing the result.</param>
        /// <returns><see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definition"/>, and <paramref name="signature"/> is present in this dictionary.</returns>
        public bool TryGetValue(string? libraryName, string definition, Type[] signature, out T? expression)
        {
            libraryName ??= string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                if (library.TryGetValue(definition, out var overloads))
                {
                    expression = BestMatch(signature, overloads);
                    return expression != default;
                }
            }
            expression = default;
            return false;
        }

        /// <summary>
        /// Adds the value for the given library and definition.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definition">The name of the definition.</param>
        /// <param name="expression">The value to add.</param>
        /// <exception cref="ArgumentException">If a value already exists for this library and definition.</exception>
        public void Add(string libraryName, string definition, T expression)
        {
            if (string.IsNullOrWhiteSpace(libraryName))
            {
                throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));
            }
            libraryName ??= string.Empty;
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
            else if (overloads.Any(o => o.Signature.Length == 0))
                throw new ArgumentException($"An overload for {definition} with no parameters has already been added to this dictionary.", nameof(definition));
            overloads.Add((Type.EmptyTypes, expression));
        }

        /// <summary>
        /// Adds the value for the given library, definition, and signature.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definition">The name of the definition.</param>
        /// <param name="signature">The signature of the definition.</param>
        /// <param name="expression">The value to add.</param>
        /// <exception cref="ArgumentException">If a value already exists for this library and definition.</exception>
        public void Add(string libraryName, string definition, Type[] signature, T expression)
        {
            if (string.IsNullOrWhiteSpace(libraryName))
            {
                throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));
            }
            libraryName ??= string.Empty;
            if (!ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                library = new Dictionary<string, List<(Type[], T)>>();
                ExpressionsByLibrary.Add(libraryName, library);
            }

            if (ContainsKey(libraryName, definition, signature))
                throw new ArgumentException("Overload already exists.");

            if (!library.TryGetValue(definition, out var overloads))
            {
                overloads = new List<(Type[], T)>();
                library.Add(definition, overloads);
            }
            overloads.Add((signature.ToArray(), expression));

        }

        /// <summary>
        /// Gets the libraries defined in this dictionary.
        /// </summary>
        public IEnumerable<string> Libraries => ExpressionsByLibrary.Keys;

        /// <summary>
        /// Gets key-value pairs of definitions and their values.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <returns>Key-value pairs of definitions and their values.</returns>
        /// <exception cref="ArgumentException">If <paramref name="libraryName"/> does not exist in the dictionary.</exception>
        public IEnumerable<KeyValuePair<string, List<(Type[] Signature, T T)>>> DefinitionsForLibrary(string? libraryName)
        {
            libraryName ??= string.Empty;
            if (ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                return library;
            }
            else throw new ArgumentException($"No library {libraryName} exists", nameof(libraryName));
        }

        /// <summary>
        /// Tries to get key-value pairs of definitions and their values.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definitions">The <see langword="out"/> parameter containing the result.</param>
        /// <returns><see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.</returns>
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

        /// <summary>
        /// Tries to get key-value pairs of definitions and their values.
        /// This method only returns CQL <code>define</code> statements and not <code>define function</code> statements.
        /// </summary>
        /// <param name="libraryName">The name of the library.</param>
        /// <param name="definitions">The <see langword="out"/> parameter containing the result.</param>
        /// <returns><see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.</returns>
        public bool TryGetDefinesForLibrary(string? libraryName, out IEnumerable<KeyValuePair<string, T>>? definitions)
        {
            if (!string.IsNullOrWhiteSpace(libraryName) && ExpressionsByLibrary.TryGetValue(libraryName, out var library))
            {
                var allDefinitions = library;
                var defines = new Dictionary<string, T>();

                foreach (var (defName, overloads) in allDefinitions)
                {
                    foreach (var (paramTypes, del) in overloads)
                    {
                        if (paramTypes.Length == 0)
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

        /// <summary>
        /// Adds a tag to the definition with the specified signature.
        /// </summary>
        /// <param name="library">The library identifier in which <paramref name="definition"/> is defined.</param>
        /// <param name="definition">The definition name whose tags to retrieve.</param>
        /// <param name="signature">The signature, or an empty array for non-function definitions.</param>
        /// <param name="name">The name of the tag.</param>
        /// <param name="values">One or more values for the specified tag.</param>
        public void AddTag(string library, string definition, Type[] signature, string name, params string[] values)
        {
            if (values?.Length > 0)
            {
                if (!TagsByLibrary.TryGetValue(library, out var tags))
                {
                    tags = new();
                    TagsByLibrary.Add(library, tags);
                }
                foreach (var value in values)
                {
                    var tag = new Tag(library, definition, signature ?? new Type[0], name, value);
                    tags.Add(tag);
                }
            }
        }

        /// <summary>
        /// Gets a dictionary of tags for the <paramref name="library"/> and <paramref name="definition"/>.
        /// </summary>
        /// <param name="library">The library identifier in which <paramref name="definition"/> is defined.</param>
        /// <param name="definition">The definition name whose tags to retrieve.</param>
        /// <param name="signature">The list of types to select the correct definition.</param>
        /// <param name="tags">The <see langword="out"/> parameter to hold the resulting lookup of tags and their values.</param>
        /// <returns><see langword="true"/> if the definiton has tags and thus <paramref name="tags"/> is not <see langword="null"/>; otherwise, <see langword="false"/>.</returns>
        public bool TryGetTags(string library, string definition, Type[] signature, out ILookup<string, string>? tags)
        {
            signature ??= new Type[0];
            if (TagsByLibrary.TryGetValue(library, out var tagsList))
            {
                foreach (var tag in tagsList)
                {
                    if (signature.Length == 0)
                    {
                        var lookup = tagsList
                             .Where(t => t.Definition == definition)
                             .ToLookup(t => t.Name, t => t.Value);
                        if (lookup.Count > 0)
                        {
                            tags = lookup;
                            return true;
                        }
                    }
                    else
                    {
                        var lookup = tagsList
                            .Where(t => t.Definition == definition
                                && t.Signature != null
                                && Score(signature, t.Signature) == 0)
                            .ToLookup(t => t.Name, t => t.Value);
                        if (lookup.Count > 0)
                        {
                            tags = lookup;
                            return true;
                        }
                    }
                }
            }
            tags = null;
            return false;
        }

        /// <summary>
        /// Merges <paramref name="dictionaries"/> into this dictionary, with existing keys remaining preserved.
        /// This means that if a key exists in this dictionary, it will not be overwritten by the value of keys in <paramref name="dictionaries"/>.
        /// </summary>
        /// <param name="dictionaries">The dictionaries to merge into this dictionary.</param>
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
                    }
                }

                foreach (var tagKey in dictionary.TagsByLibrary)
                {
                    if (!TagsByLibrary.Contains(tagKey))
                    {
                        TagsByLibrary.Add(tagKey.Key, tagKey.Value);
                    }
                }
            }
        }

        /// <summary>
        /// One method is closer than another if all of its parameter types are narrower than (or the same as) the parameter types of the other method. 
        /// If neither method's parameters are narrower than the other, then there is no way for to determine which method is closer to the arguments.
        /// </summary>
        /// <param name="parameterTypes">The type of the parameters being passed to the method</param>
        /// <param name="overloads">The signatures of overloads available</param>
        /// <returns>The best match for <paramref name="parameterTypes"/>, or <c>null</c> if no match exists</returns>
        internal T? BestMatch(Type[] parameterTypes, IEnumerable<(Type[] Signature, T T)> overloads)
        {
            var groups = (from overload in overloads
                          let score = Score(parameterTypes, overload.Signature)
                          where score != null
                          group overload by score into g
                          orderby g.Key
                          select g).ToArray();
            if (groups.Length > 0)
            {
                var candidate = groups[0];
                if (candidate != null)
                {
                    var list = candidate.ToArray();
                    if (list.Length == 1)
                        return list[0].T;

                }
            }
            return default;
        }

        /// <summary>
        /// Calculates a score (lower is better) for matching <paramref name="parameterTypes"/> to the overload <paramref name="signature"/>.
        /// </summary>
        /// <returns>0 for exact matches; greater than 0 for signatures that can be bound through polymorphism; and <c>null</c> for incompatibility</returns>
        internal int? Score(Type[] parameterTypes, Type[] signature)
        {
            int? distance = 0;
            if (parameterTypes.Length == signature.Length)
            {
                for (int i = 0; i < parameterTypes.Length; i++)
                {
                    // this parameter's type matches the signature's type exactly; add nothing to the score
                    if (parameterTypes[i] == signature[i])
                        continue;
                    // parameterTypes[i] is derived from signature[i]
                    else if (signature[i].IsAssignableFrom(parameterTypes[i]))
                    {
                        var baseType = parameterTypes[i].BaseType;
                        var distanceP = 1;
                        while (baseType != null && baseType != signature[i])
                        {
                            distanceP += 1;
                            baseType = baseType.BaseType;
                        }
                        distance += distanceP;
                    }
                    else
                    {
                        // The parameter[i] is not compatible with the signature[i]
                        return null;
                    }
                }
                return distance;
            }
            else return null;
        }

        internal class Tag
        {
           
            public string Library { get; }
            public string Definition { get; }
            public Type[] Signature { get; }
            public string Value { get; }
            public string Name { get; }

            /// <summary>
            /// Constructor to create a tag.
            /// </summary>
            /// <param name="library">The library identifier in which <paramref name="definition"/> is defined.</param>
            /// <param name="definition">The definition name whose tags to set.</param>
            /// <param name="signature">The signature, or an empty array for non-function definitions.</param>
            /// <param name="name">The name of the tag.</param>
            /// <param name="value">The value of the tag.</param>
            public Tag(string library, string definition, Type[] signature, string name, string value)
            {
                Library = library;
                Definition = definition;
                Signature = signature;
                Name = name;
                Value = CleanValue(value);
            }

            /// <summary>
            /// Removes all whitespace from the value, except for a single space between 'words'.
            /// All newlines, tabs, and other whitespace characters will be replaced by a single space.            
            /// </summary>
            /// <param name="value"></param>
            /// <returns>The <paramref name="value"/> string with only single spaces</returns>
            private static string CleanValue(string value)
            {
                value = value.Trim();
                if (string.IsNullOrEmpty(value)) return value;
                return Regex.Replace(value, @"\s+", " ");
            }


        }
    }
}
