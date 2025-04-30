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
            /* signatureDefinitions: */List<(Type[] Signature, T T)>>> _signatureDefinitionsPerDefinitionNamePerLibraryName = new();

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
            if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName)
                || signaturesDefinitionsPerDefinitionName[definitionName] is not [{ Signature.Length: 0 } signatureDefinition0])
                throw new KeyNotFoundException($"No matching overload for {definitionName} in {libraryName} could be found.");

            return signatureDefinition0.T;
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
            if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName))
                throw new KeyNotFoundException($"No overload of {definitionName} matches the arguments {string.Join(",", signature.Select(p => p.Name))}");

            var signatureDefinitions = signaturesDefinitionsPerDefinitionName[definitionName];
            var definition = BestMatch(signature, signatureDefinitions);
            return definition ?? throw new KeyNotFoundException($"Key {libraryName}.{definitionName} matching this signature does not exist.");
        }
    }

    /// <summary>
    /// Returns <see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definitionName"/> is present in this dictionary.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definitionName"/> is present in this dictionary.</returns>
    public bool ContainsDefinition(
        string? libraryName,
        string definitionName)
    {
        libraryName ??= string.Empty;
        return _signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName)
               && signaturesDefinitionsPerDefinitionName.ContainsKey(definitionName);
    }

    /// <summary>
    /// Returns <see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="definitionSignature"/> is present in this dictionary.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="definitionSignature">The signature of the definition.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="definitionSignature"/> is present in this dictionary.</returns>
    public bool ContainsDefinition(
        string? libraryName,
        string definitionName,
        Type[] definitionSignature)
    {
        libraryName ??= string.Empty;
        if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName)
            || !signaturesDefinitionsPerDefinitionName.TryGetValue(definitionName, out var signatureDefinitions))
            return false;

        foreach (var signatureDefinition in signatureDefinitions)
        {
            var score = Score(definitionSignature, signatureDefinition.Signature);
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
    /// <param name="definition">The <see langword="out"/> parameter containing the result.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/> and <paramref name="definitionName"/> is present in this dictionary.</returns>
    public bool TryGetValue(
        string? libraryName,
        string definitionName,
        [NotNullWhen(true)] out T? definition)
    {
        libraryName ??= string.Empty;
        definition = null;

        if (_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName)
            && signaturesDefinitionsPerDefinitionName.TryGetValue(definitionName, out var signatureDefinitions)
            && signatureDefinitions is [{ Signature.Length: 0 } signatureDefinition])
            definition = signatureDefinition.T;

        return definition != null;
    }


    /// <summary>
    /// Tries to get the best match value for <see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="signature"/>.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="signature">The signature of the definition.</param>
    /// <param name="definition">The <see langword="out"/> parameter containing the result.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/>, <paramref name="definitionName"/>, and <paramref name="signature"/> is present in this dictionary.</returns>
    public bool TryGetValue(
        string? libraryName,
        string definitionName,
        Type[] signature,
        [NotNullWhen(true)] out T? definition)
    {
        libraryName ??= string.Empty;
        definition = null;

        if (_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName)
            && signaturesDefinitionsPerDefinitionName.TryGetValue(definitionName, out var signatureDefinitions))
            definition = BestMatch(signature, signatureDefinitions);

        return definition != null;
    }

    /// <summary>
    /// Adds the value for the given library and definition.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="definition">The value to add.</param>
    /// <exception cref="ArgumentException">If a value already exists for this library and definition.</exception>
    public void Add(
        string libraryName,
        string definitionName,
        T definition)
    {
        if (string.IsNullOrWhiteSpace(libraryName))
            throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));

        libraryName ??= string.Empty;
        if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signatureDefinitionsPerDefinition))
        {
            signatureDefinitionsPerDefinition = new Dictionary<string, List<(Type[], T)>>();
            _signatureDefinitionsPerDefinitionNamePerLibraryName.Add(libraryName, signatureDefinitionsPerDefinition);
        }

        if (!signatureDefinitionsPerDefinition.TryGetValue(definitionName, out var signatureDefinitions))
        {
            signatureDefinitions = [];
            signatureDefinitionsPerDefinition.Add(definitionName, signatureDefinitions);
        }
        else if (signatureDefinitions.Any(o => o.Signature.Length == 0))
            throw new ArgumentException($"An overload for {definitionName} with no parameters has already been added to this dictionary.",
                                        nameof(definitionName));

        signatureDefinitions.Add((Type.EmptyTypes, definition));
    }

    /// <summary>
    /// Adds the value for the given library, definition, and signature.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <param name="signature">The signature of the definition.</param>
    /// <param name="definition">The value to add.</param>
    /// <exception cref="ArgumentException">If a value already exists for this library and definition.</exception>
    public void Add(
        string libraryName,
        string definitionName,
        Type[] signature,
        T definition)
    {
        if (string.IsNullOrWhiteSpace(libraryName))
            throw new ArgumentException($"'{nameof(libraryName)}' cannot be null or whitespace.", nameof(libraryName));

        libraryName ??= string.Empty;
        if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signatureDefinitionsPerDefinition))
        {
            signatureDefinitionsPerDefinition = new Dictionary<string, List<(Type[], T)>>();
            _signatureDefinitionsPerDefinitionNamePerLibraryName.Add(libraryName, signatureDefinitionsPerDefinition);
        }

        if (ContainsDefinition(libraryName, definitionName, signature))
            throw new ArgumentException("Overload already exists.");

        if (!signatureDefinitionsPerDefinition.TryGetValue(definitionName, out var signatureDefinitions))
        {
            signatureDefinitions = [];
            signatureDefinitionsPerDefinition.Add(definitionName, signatureDefinitions);
        }

        signatureDefinitions.Add((signature, definition));
    }

    /// <summary>
    /// Gets the libraries defined in this dictionary.
    /// </summary>
    public IReadOnlyCollection<string> Libraries => _signatureDefinitionsPerDefinitionNamePerLibraryName.Keys;

    /// <summary>
    /// Enumerates all definitions, their signatures, and their associated definitions for a given library name.
    /// </summary>
    /// <param name="libraryName">The name of the library to enumerate definitions definitions for.</param>
    /// <returns>
    /// An enumerable collection of tuples, where each tuple contains:
    /// <list type="bullet">
    /// <item><description>The definition name.</description></item>
    /// <item><description>The type signature of the definition's definition.</description></item>
    /// <item><description>The associated definition.</description></item>
    /// </list>
    /// </returns>
    /// <exception cref="ArgumentException">Thrown if the specified library does not exist in the dictionary.</exception>
    public IEnumerable<(string definitionName, Type[] signature, T definition)> SelectDefinitionsByLibraryName(string? libraryName)
    {
        libraryName ??= string.Empty;
        if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signatureDefinitionsPerDefinition))
            throw new ArgumentException($"No library {libraryName} exists", nameof(libraryName));

        foreach (var (definitionName, signatureDefinitions) in signatureDefinitionsPerDefinition)
            foreach (var (signature, definition) in signatureDefinitions)
                yield return (definitionName, signature, definition);
    }

    /// <summary>
    /// Enumerates all definitions, their signatures, and their associated definitions across all libraries.
    /// </summary>
    /// <returns>
    /// An enumerable collection of tuples, where each tuple contains:
    /// <list type="bullet">
    /// <item><description>The library name.</description></item>
    /// <item><description>The definition name.</description></item>
    /// <item><description>The type signature of the definition's definition.</description></item>
    /// <item><description>The associated definition.</description></item>
    /// </list>
    /// </returns>
    public IEnumerable<(string libraryName, string definitionName, Type[] signature, T definition)> SelectDefinitions()
    {
        foreach (var (libraryName, definitions) in _signatureDefinitionsPerDefinitionNamePerLibraryName)
            foreach (var (definitionName, signatureDefinitions) in definitions)
                foreach (var (signature, definition) in signatureDefinitions)
                    yield return (libraryName, definitionName, signature, definition);
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
            && _signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signatureDefinitionsPerDefinition))
            definitions = signatureDefinitionsPerDefinition;

        return definitions != null;
    }

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

                foreach (var (definitionName, signature, definition) in dictionary.SelectDefinitionsByLibraryName(libKey))
                    Add(libKey, definitionName, signature, definition);
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