/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Maps library, definition, and signatures to values.
/// </summary>
/// <typeparam name="T">The value mapped by the keys in this dictionary.</typeparam>
public class DefinitionDictionary<T> where T : class
{
    private readonly Dictionary<
        /* libraryName:             */string,
        /* signaturesPerDefinition: */Dictionary<
            /* definitionName:       */string,
            /* signatureExpressions: */List<(Type[] Signature, T T)>>> _signatureExpressionsPerDefinitionPerLibrary = new();

    /// <summary>
    /// Gets the value for the given <paramref name="libraryName"/> and <paramref name="definitionName"/>.
    /// This indexer should be used for CQL definitions.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <returns>The value, if present.</returns>
    /// <exception cref="KeyNotFoundException">If the library &amp; definition pair is not found in the dictionary.</exception>
    public T this[
        string? libraryName,
        string definitionName]
    {
        get
        {
            libraryName ??= string.Empty;
            if (!_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signaturesExpressionsPerDefinition)
                || signaturesExpressionsPerDefinition[definitionName] is not [{ Signature.Length: 0 } signatureExpression0])
                throw new KeyNotFoundException($"No matching overload for {definitionName} in {libraryName} could be found.");

            return signatureExpression0.T;
        }
    }

    /// <summary>
    /// Gets the value for the given <paramref name="libraryName"/>, <paramref name="definitionName"/>, and signature.
    /// This indexer should be used for CQL functions.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="signature">The signature of the definition.</param>
    /// <returns>The value, if present.</returns>
    /// <exception cref="KeyNotFoundException">If the library, definition, &amp; signature is not found in the dictionary.</exception>
    public T this[
        string? libraryName,
        string definitionName,
        params Type[] signature]
    {
        get
        {
            libraryName ??= string.Empty;
            if (!_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition))
                throw new KeyNotFoundException($"No overload of {definitionName} matches the arguments {string.Join(",", signature.Select(p => p.Name))}");

            var signatureExpressions = signatureExpressionsPerDefinition[definitionName];
            var expression = BestMatch(signature, signatureExpressions);
            return expression ?? throw new KeyNotFoundException($"Key {libraryName}.{definitionName} matching this signature does not exist.");
        }
    }

    // internal T Resolve(string? libraryName, string definitionName, Func<Type,Type,bool> conversionCheck, params Type[] signature)
    // {
    //     libraryName ??= string.Empty;
    //     if (!_signaturesPerDefinitionPerLibrary.TryGetValue(libraryName, out var signaturesPerDefinition))
    //         throw new KeyNotFoundException($"The library {libraryName} is unknown here.");
    //
    //     var signatures = signaturesPerDefinition[definitionName];
    //     var match = BestMatch(signature, signatures, conversionCheck);
    //     return match ?? throw new KeyNotFoundException($"No overload of {definitionName} matches the arguments {string.Join(",", signature.Select(p => p.Name))}");
    // }
    //
    // /// <summary>
    // /// Returns <see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.
    // /// </summary>
    // /// <param name="libraryName">The name of the library.</param>
    // /// <returns><see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.</returns>
    // public bool ContainsLibrary(string libraryName) => _signaturesPerDefinitionPerLibrary.ContainsKey(libraryName);

    /// <summary>
    /// Returns <see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definitionName"/> is present in this dictionary.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definitionName"/> is present in this dictionary.</returns>
    public bool ContainsKey(
        string? libraryName,
        string definitionName)
    {
        libraryName ??= string.Empty;
        return _signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition)
               && signatureExpressionsPerDefinition.ContainsKey(definitionName);
    }

    /// <summary>
    /// Returns <see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="signature"/> is present in this dictionary.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="signature">The signature of the definition.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="signature"/> is present in this dictionary.</returns>
    public bool ContainsKey(
        string? libraryName,
        string definitionName,
        Type[] signature)
    {
        libraryName ??= string.Empty;
        if (!_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition)
            || !signatureExpressionsPerDefinition.TryGetValue(definitionName, out var signatureExpressions))
            return false;

        foreach (var signatureExpression in signatureExpressions)
        {
            var score = Score(signature, signatureExpression.Signature);
            if (score == 0)
                return true;
        }

        return false;
    }

    /// <summary>
    /// Tries to get the value for the given library and definition.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="expression">The <see langword="out"/> parameter containing the result.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definitionName"/> is present in this dictionary.</returns>
    public bool TryGetValue(
        string? libraryName,
        string definitionName,
        [NotNullWhen(true)] out T? expression)
    {
        libraryName ??= string.Empty;
        expression = null;

        if (_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition)
            && signatureExpressionsPerDefinition.TryGetValue(definitionName, out var signatureExpressions)
            && signatureExpressions is [{ Signature.Length: 0 } signatureExpression0])
            expression = signatureExpression0.T;

        return expression != null;
    }


    /// <summary>
    /// Tries to get the best match value for <see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="signature"/>.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="signature">The signature of the definition.</param>
    /// <param name="expression">The <see langword="out"/> parameter containing the result.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="signature"/> is present in this dictionary.</returns>
    public bool TryGetValue(
        string? libraryName,
        string definitionName,
        Type[] signature,
        [NotNullWhen(true)] out T? expression)
    {
        libraryName ??= string.Empty;
        expression = null;

        if (_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition)
            && signatureExpressionsPerDefinition.TryGetValue(definitionName, out var signatureExpressions))
            expression = BestMatch(signature, signatureExpressions);

        return expression != null;
    }

    /// <summary>
    /// Adds the value for the given library and definition.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="expression">The value to add.</param>
    /// <exception cref="ArgumentException">If a value already exists for this library and definition.</exception>
    public void Add(
        string libraryName,
        string definitionName,
        T expression)
    {
        if (string.IsNullOrWhiteSpace(libraryName))
            throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));

        libraryName ??= string.Empty;
        if (!_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition))
        {
            signatureExpressionsPerDefinition = new Dictionary<string, List<(Type[], T)>>();
            _signatureExpressionsPerDefinitionPerLibrary.Add(libraryName, signatureExpressionsPerDefinition);
        }

        if (!signatureExpressionsPerDefinition.TryGetValue(definitionName, out var signatureExpressions))
        {
            signatureExpressions = [];
            signatureExpressionsPerDefinition.Add(definitionName, signatureExpressions);
        }
        else if (signatureExpressions.Any(o => o.Signature.Length == 0))
            throw new ArgumentException($"An overload for {definitionName} with no parameters has already been added to this dictionary.",
                                        nameof(definitionName));

        signatureExpressions.Add((Type.EmptyTypes, expression));
    }

    /// <summary>
    /// Adds the value for the given library, definition, and signature.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="signature">The signature of the definition.</param>
    /// <param name="expression">The value to add.</param>
    /// <exception cref="ArgumentException">If a value already exists for this library and definition.</exception>
    public void Add(
        string libraryName,
        string definitionName,
        Type[] signature,
        T expression)
    {
        if (string.IsNullOrWhiteSpace(libraryName))
            throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));

        libraryName ??= string.Empty;
        if (!_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition))
        {
            signatureExpressionsPerDefinition = new Dictionary<string, List<(Type[], T)>>();
            _signatureExpressionsPerDefinitionPerLibrary.Add(libraryName, signatureExpressionsPerDefinition);
        }

        if (ContainsKey(libraryName, definitionName, signature))
            throw new ArgumentException("Overload already exists.");

        if (!signatureExpressionsPerDefinition.TryGetValue(definitionName, out var signatureExpressions))
        {
            signatureExpressions = [];
            signatureExpressionsPerDefinition.Add(definitionName, signatureExpressions);
        }

        signatureExpressions.Add((signature, expression));
    }

    /// <summary>
    /// Gets the libraries defined in this dictionary.
    /// </summary>
    public IReadOnlyCollection<string> Libraries => _signatureExpressionsPerDefinitionPerLibrary.Keys;

    /// <summary>
    /// Enumerates all definitions, their signatures, and their associated expressions for a given library name.
    /// </summary>
    /// <param name="libraryName">The name of the library to enumerate definitions expressions for.</param>
    /// <returns>
    /// An enumerable collection of tuples, where each tuple contains:
    /// <list type="bullet">
    /// <item><description>The definition name.</description></item>
    /// <item><description>The type signature of the definition's expression.</description></item>
    /// <item><description>The associated expression.</description></item>
    /// </list>
    /// </returns>
    /// <exception cref="ArgumentException">Thrown if the specified library does not exist in the dictionary.</exception>
    public IEnumerable<(string definitionName, Type[] signature, T expression)> EnumerateExpressionsByLibraryName(string? libraryName)
    {
        libraryName ??= string.Empty;
        if (!_signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition))
            throw new ArgumentException($"No library {libraryName} exists", nameof(libraryName));

        foreach (var (definitionName, signatureExpressions) in signatureExpressionsPerDefinition)
            foreach (var (signature, expression) in signatureExpressions)
                yield return (definitionName, signature, expression);
    }

    /// <summary>
    /// Enumerates all definitions, their signatures, and their associated expressions across all libraries.
    /// </summary>
    /// <returns>
    /// An enumerable collection of tuples, where each tuple contains:
    /// <list type="bullet">
    /// <item><description>The library name.</description></item>
    /// <item><description>The definition name.</description></item>
    /// <item><description>The type signature of the definition's expression.</description></item>
    /// <item><description>The associated expression.</description></item>
    /// </list>
    /// </returns>
    public IEnumerable<(string libraryName, string definitionName, Type[] signature, T expression)> EnumerateExpressions()
    {
        foreach (var (libraryName, definitions) in _signatureExpressionsPerDefinitionPerLibrary)
            foreach (var (definitionName, signatureExpressions) in definitions)
                foreach (var (signature, expression) in signatureExpressions)
                    yield return (libraryName, definitionName, signature, expression);
    }

    /// <summary>
    /// Tries to get key-value pairs of definitions and their values.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitions">The <see langword="out"/> parameter containing the result.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.</returns>
    public bool TryGetDefinitionsForLibrary(
        string? libraryName,
        [NotNullWhen(true)] out IEnumerable<KeyValuePair<string, List<(Type[], T)>>>? definitions)
    {
        definitions = null;
        if (!string.IsNullOrWhiteSpace(libraryName)
            && _signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var signatureExpressionsPerDefinition))
            definitions = signatureExpressionsPerDefinition;

        return definitions != null;
    }

    // /// <summary>
    // /// Tries to get key-value pairs of definitions and their values.
    // /// This method only returns CQL <code>define</code> statements and not <code>define function</code> statements.
    // /// </summary>
    // /// <param name="libraryName">The name of the library.</param>
    // /// <param name="definitions">The <see langword="out"/> parameter containing the result.</param>
    // /// <returns><see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.</returns>
    // public bool TryGetDefinesForLibrary(
    //     string? libraryName,
    //     [NotNullWhen(true)] out IEnumerable<KeyValuePair<string, T>>? definitions)
    // {
    //     if (!string.IsNullOrWhiteSpace(libraryName) && _signatureExpressionsPerDefinitionPerLibrary.TryGetValue(libraryName, out var library))
    //     {
    //         var allDefinitions = library;
    //         var defines = new Dictionary<string, T>();
    //
    //         foreach (var (defName, overloads) in allDefinitions)
    //         {
    //             foreach (var (paramTypes, del) in overloads)
    //             {
    //                 if (paramTypes.Length == 0)
    //                 {
    //                     defines.Add(defName, del);
    //                 }
    //             }
    //         }
    //
    //         definitions = defines.ToArray();
    //
    //         return true;
    //     }
    //     else
    //     {
    //         definitions = null;
    //         return false;
    //     }
    // }

    // /// <summary>
    // /// Adds a tag to the definition with the specified signature.
    // /// </summary>
    // /// <param name="library">The library identifier in which <paramref name="definition"/> is defined.</param>
    // /// <param name="definition">The definition name whose tags to retrieve.</param>
    // /// <param name="signature">The signature, or an empty array for non-function definitions.</param>
    // /// <param name="name">The name of the tag.</param>
    // /// <param name="values">One or more values for the specified tag.</param>
    // public void AddTag(
    //     string library,
    //     string definition,
    //     Type[] signature,
    //     string name,
    //     params string[] values)
    // {
    //     if (values?.Length > 0)
    //     {
    //         if (!TagsByLibrary.TryGetValue(library, out var tags))
    //         {
    //             tags = [];
    //             TagsByLibrary.Add(library, tags);
    //         }
    //
    //         foreach (var value in values)
    //         {
    //             var tag = new Tag(library, definition, signature ?? [], name, value);
    //             tags.Add(tag);
    //         }
    //     }
    // }

    // /// <summary>
    // /// Gets a dictionary of tags for the <paramref name="library"/> and <paramref name="definition"/>.
    // /// </summary>
    // /// <param name="library">The library identifier in which <paramref name="definition"/> is defined.</param>
    // /// <param name="definition">The definition name whose tags to retrieve.</param>
    // /// <param name="signature">The list of types to select the correct definition.</param>
    // /// <param name="tags">The <see langword="out"/> parameter to hold the resulting lookup of tags and their values.</param>
    // /// <returns><see langword="true"/> if the definiton has tags and thus <paramref name="tags"/> is not <see langword="null"/>; otherwise, <see langword="false"/>.</returns>
    // public bool TryGetTags(
    //     string library,
    //     string definition,
    //     Type[] signature,
    //     [NotNullWhen(true)] out ILookup<string, string>? tags)
    // {
    //     signature ??= [];
    //     if (TagsByLibrary.TryGetValue(library, out var tagsList))
    //     {
    //         foreach (var tag in tagsList)
    //         {
    //             if (signature.Length == 0)
    //             {
    //                 var lookup = tagsList
    //                              .Where(t => t.Definition == definition)
    //                              .ToLookup(t => t.Name, t => t.Value);
    //                 if (lookup.Count > 0)
    //                 {
    //                     tags = lookup;
    //                     return true;
    //                 }
    //             }
    //             else
    //             {
    //                 var lookup = tagsList
    //                              .Where(t => t.Definition == definition
    //                                          && t.Signature != null
    //                                          && Score(signature, t.Signature) == 0)
    //                              .ToLookup(t => t.Name, t => t.Value);
    //                 if (lookup.Count > 0)
    //                 {
    //                     tags = lookup;
    //                     return true;
    //                 }
    //             }
    //         }
    //     }
    //
    //     tags = null;
    //     return false;
    // }

    /// <summary>
    /// Merges <paramref name="dictionaries"/> into this dictionary, with existing keys remaining preserved.
    /// This means that if a key exists in this dictionary, it will not be overwritten by the value of keys in <paramref name="dictionaries"/>.
    /// </summary>
    /// <param name="dictionaries">The dictionaries to merge into this dictionary.</param>
    public void Merge(params DefinitionDictionary<T>[] dictionaries)
    {
        foreach (var dictionary in dictionaries)
            foreach (var libKey in dictionary.Libraries)
            {
                // don't overwrite existing libraries
                if (Libraries.Contains(libKey))
                    continue;

                foreach (var (definitionName, signature, expression) in dictionary.EnumerateExpressionsByLibraryName(libKey))
                    Add(libKey, definitionName, signature, expression);
            }
    }

    /// <summary>
    /// One method is closer than another if all of its parameter types are narrower than (or the same as) the parameter types of the other method.
    /// If neither method's parameters are narrower than the other, then there is no way for to determine which method is closer to the arguments.
    /// </summary>
    /// <param name="signature">The type of the parameters being passed to the method</param>
    /// <param name="signatureDefinitions">The signatures of overloads available</param>
    /// <param name="conversionCheck"></param>
    /// <returns>The best match for <paramref name="signature"/>, or <c>null</c> if no match exists</returns>
    internal T? BestMatch(
        Type[] signature,
        IEnumerable<(Type[] Signature, T T)> signatureDefinitions,
        Func<Type, Type, bool>? conversionCheck = null)
    {
        var groups = (from overload in signatureDefinitions
                      let score = Score(signature, overload.Signature, conversionCheck)
                      where score != null
                      group overload by score
                      into g
                      orderby g.Key
                      select g).ToArray();

        if (groups is [{ } item0, ..])
            return item0.ToArray() is [{ } itemOnly] ? itemOnly.T : null;

        return null;
    }

    /// <summary>
    /// Calculates a score (lower is better) for matching <paramref name="parameterTypes"/> to the overload <paramref name="signature"/>.
    /// </summary>
    /// <returns>0 for exact matches; greater than 0 for signatures that can be bound through polymorphism; and <c>null</c> for incompatibility</returns>
    internal int? Score(
        Type[] parameterTypes,
        Type[] signature,
        Func<Type, Type, bool>? conversionCheck = null)
    {
        int? distance = 0;
        if (parameterTypes.Length == signature.Length)
        {
            for (int i = 0; i < parameterTypes.Length; i++)
            {
                var parameterType = parameterTypes[i];
                var signatureType = signature[i];

                // this parameter's type matches the signature's type exactly; add nothing to the score
                if (parameterType == signatureType)
                    continue;

                // parameterTypes[i] is derived from signature[i]
                if (signatureType.IsAssignableFrom(parameterType))
                {
                    var baseType = parameterType.BaseType;
                    var distanceP = 1;
                    while (baseType != null && baseType != signatureType)
                    {
                        distanceP += 1;
                        baseType = baseType.BaseType;
                    }

                    distance += distanceP;
                }
                else if (parameterType == typeof(object)) //@ TODO: Choice type?
                {
                    distance += 7;
                }
                else if (conversionCheck is not null)
                {
                    if (conversionCheck(parameterType, signatureType))
                        distance += 5;
                    else
                        return null;
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
}