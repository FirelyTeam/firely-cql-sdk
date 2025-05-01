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
internal class DefinitionDictionary<T> where T : class
{
    private readonly Dictionary<
        /* libraryName:             */string,
        /* signaturesPerDefinition: */Dictionary<
            /* definitionName:       */string,
            /* signatureDefinitions: */List<(Type[] Signature, T T)>>> _signatureDefinitionsPerDefinitionNamePerLibraryName = new();

    public T this[
        string? libraryName,
        DefinitionSignature definitionSignature]
    {
        get
        {
            libraryName ??= string.Empty;
            var (definitionName, signature) = definitionSignature;
            if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName))
                throw new KeyNotFoundException($"No overload of {definitionName} matches the arguments {string.Join(",", signature.Select(p => p.Name))}");

            var signatureDefinitions = signaturesDefinitionsPerDefinitionName[definitionName];
            var definition = BestMatch(signature, signatureDefinitions);
            return definition ?? throw new KeyNotFoundException($"Key {libraryName}.{definitionName} matching this signature does not exist.");
        }
    }

    public bool ContainsDefinition(
        string? libraryName,
        DefinitionSignature definitionSignature)
    {
        libraryName ??= string.Empty;
        if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName)
            || !signaturesDefinitionsPerDefinitionName.TryGetValue(definitionSignature.Name, out var signatureDefinitions))
            return false;

        foreach (var signatureDefinition in signatureDefinitions)
        {
            var score = Score(definitionSignature.ParameterTypes, signatureDefinition.Signature);
            if (score == 0)
                return true;
        }

        return false;
    }

    public bool TryGetDefinition(
        string? libraryName,
        DefinitionSignature definitionSignature,
        [NotNullWhen(true)] out T? definition)
    {
        libraryName ??= string.Empty;
        var (definitionName, signature) = definitionSignature;
        definition = null;

        if (_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signaturesDefinitionsPerDefinitionName)
            && signaturesDefinitionsPerDefinitionName.TryGetValue(definitionName, out var signatureDefinitions))
            definition = BestMatch(signature, signatureDefinitions);

        return definition != null;
    }

    public void AddDefinition(
        string libraryName,
        DefinitionSignature definitionSignature,
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

        if (ContainsDefinition(libraryName, definitionSignature))
            throw new ArgumentException("Overload already exists.");

        if (!signatureDefinitionsPerDefinition.TryGetValue(definitionSignature.Name, out var signatureDefinitions))
        {
            signatureDefinitions = [];
            signatureDefinitionsPerDefinition.Add(definitionSignature.Name, signatureDefinitions);
        }

        signatureDefinitions.Add((definitionSignature.ParameterTypes, definition));
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

    public IEnumerable<(string libraryName, DefinitionSignature definitionSignature, T definition)> SelectDefinitions()
    {
        foreach (var (libraryName, definitions) in _signatureDefinitionsPerDefinitionNamePerLibraryName)
            foreach (var (definitionName, signatureDefinitions) in definitions)
                foreach (var (signature, definition) in signatureDefinitions)
                    yield return (libraryName, new (definitionName, signature), definition);
    }

    /// <summary>
    /// Tries to get key-value pairs of definitions and their values.
    /// </summary>
    /// <param name="libraryName">The name of the library.</param>
    /// <param name="definitions">The <see langword="out"/> parameter containing the result.</param>
    /// <returns><see langword="true"/> if the <paramref name="libraryName"/> is present in this dictionary.</returns>
    internal bool TryGetDefinitionsForLibrary(
        string? libraryName,
        [NotNullWhen(true)] out IEnumerable<KeyValuePair<string, List<(Type[], T)>>>? definitions)
    {
        definitions = null;
        if (!string.IsNullOrWhiteSpace(libraryName)
            && _signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signatureDefinitionsPerDefinition))
            definitions = signatureDefinitionsPerDefinition;

        return definitions != null;
    }

    public void Merge(params DefinitionDictionary<T>[] dictionaries)
    {
        foreach (var dictionary in dictionaries)
            foreach (var libKey in dictionary.Libraries)
            {
                // don't overwrite existing libraries
                if (Libraries.Contains(libKey))
                    continue;

                foreach (var (definitionName, signature, definition) in dictionary.SelectDefinitionsByLibraryName(libKey))
                    AddDefinition(libKey, new(definitionName, signature), definition);
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