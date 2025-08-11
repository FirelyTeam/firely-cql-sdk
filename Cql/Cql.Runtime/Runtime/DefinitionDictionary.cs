/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents a specialized dictionary for managing definitions, organized by library name,
/// definition name, and their associated signatures. This class provides functionality to add,
/// retrieve, query, and merge definitions based on their signatures and library context.
/// </summary>
/// <typeparam name="T">
/// The type of the definitions stored in the dictionary. This type must be a reference type.
/// </typeparam>
/// <remarks>
/// This class is designed to support scenarios where definitions are grouped by libraries and
/// further categorized by their names and signatures. It allows efficient lookup and management
/// of definitions, including support for merging multiple dictionaries and selecting definitions
/// by library or globally.
/// </remarks>
public class DefinitionDictionary<T> where T : class
{
    private readonly Dictionary<
        /* libraryName:             */string,
        /* signaturesPerDefinition: */Dictionary<
            /* definitionName:       */string,
            /* signatureDefinitions: */List<(Type[] Signature, T Definition)>>> _signatureDefinitionsPerDefinitionNamePerLibraryName = new();

    /// <summary>
    /// Gets the definition associated with the specified library name and definition signature.
    /// </summary>
    /// <param name="libraryName">
    /// The name of the library containing the definition. If <see langword="null"/>, an empty string is used.
    /// </param>
    /// <param name="definitionSignature">
    /// The signature of the definition, including its name and parameter types.
    /// </param>
    /// <returns>
    /// The definition of type <typeparamref name="T"/> that matches the specified library name and definition signature.
    /// </returns>
    /// <exception cref="KeyNotFoundException">
    /// Thrown when no matching definition is found for the specified library name and definition signature.
    /// </exception>
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

    /// <summary>
    /// Determines whether a definition with the specified library name and definition signature exists in the dictionary.
    /// </summary>
    /// <param name="libraryName">
    /// The name of the library containing the definition. If <c>null</c>, an empty string is used as the library name.
    /// </param>
    /// <param name="definitionSignature">
    /// The signature of the definition to check for existence.
    /// </param>
    /// <returns>
    /// <c>true</c> if a definition with the specified library name and signature exists; otherwise, <c>false</c>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown if <paramref name="definitionSignature"/> is <c>null</c>.
    /// </exception>
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

    /// <summary>
    /// Attempts to retrieve a definition from the dictionary based on the specified library name and definition signature.
    /// </summary>
    /// <param name="libraryName">
    /// The name of the library containing the definition. If <c>null</c>, an empty string is used as the default library name.
    /// </param>
    /// <param name="definitionSignature">
    /// The signature of the definition to retrieve, including its name and parameter types.
    /// </param>
    /// <param name="definition">
    /// When this method returns, contains the definition associated with the specified library name and signature,
    /// if found; otherwise, <c>null</c>. This parameter is passed uninitialized.
    /// </param>
    /// <returns>
    /// <c>true</c> if a matching definition is found; otherwise, <c>false</c>.
    /// </returns>
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

    /// <summary>
    /// Adds a new definition to the dictionary for a specified library.
    /// </summary>
    /// <param name="libraryName">
    /// The name of the library to which the definition belongs.
    /// This value cannot be null, empty, or consist only of whitespace.
    /// </param>
    /// <param name="definitionSignature">
    /// The signature of the definition, which includes its name and parameter types.
    /// </param>
    /// <param name="definition">
    /// The definition object to be added to the dictionary.
    /// </param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="libraryName"/> is null, empty, or consists only of whitespace,
    /// or when a definition with the same signature already exists in the specified library.
    /// </exception>
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
    /// Gets a read-only collection of library names that are currently defined in the dictionary.
    /// </summary>
    /// <value>
    /// A collection of strings representing the names of the libraries.
    /// </value>
    /// <remarks>
    /// This property provides access to the keys of the internal dictionary that stores definitions
    /// grouped by library names. It can be used to enumerate all libraries for which definitions
    /// have been added.
    /// </remarks>
    public IReadOnlyCollection<string> Libraries => _signatureDefinitionsPerDefinitionNamePerLibraryName.Keys;

    /// <summary>
    /// Retrieves all definitions associated with the specified library name.
    /// </summary>
    /// <param name="libraryName">
    /// The name of the library for which definitions are to be retrieved.
    /// If <see langword="null"/>, an empty string is used as the library name.
    /// </param>
    /// <returns>
    /// An enumerable collection of tuples, where each tuple contains a <see cref="DefinitionSignature"/>
    /// representing the signature of a definition and the corresponding definition of type <typeparamref name="T"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the specified library name does not exist in the dictionary.
    /// </exception>
    public IEnumerable<(DefinitionSignature definitionSignature, T definition)> SelectDefinitionsByLibraryName(string? libraryName)
    {
        libraryName ??= string.Empty;
        if (!_signatureDefinitionsPerDefinitionNamePerLibraryName.TryGetValue(libraryName, out var signatureDefinitionsPerDefinition))
            throw new ArgumentException($"No library {libraryName} exists", nameof(libraryName));

        foreach (var (definitionName, signatureDefinitions) in signatureDefinitionsPerDefinition)
            foreach (var (signature, definition) in signatureDefinitions)
                yield return (new (definitionName, signature), definition);
    }

    /// <summary>
    /// Retrieves all definitions stored in the dictionary, including their associated library names
    /// and definition signatures.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of tuples, where each tuple contains:
    /// <list type="bullet">
    /// <item>
    /// <description>The library name as a <see cref="string"/>.</description>
    /// </item>
    /// <item>
    /// <description>The <see cref="DefinitionSignature"/> associated with the definition.</description>
    /// </item>
    /// <item>
    /// <description>The definition of type <typeparamref name="T"/>.</description>
    /// </item>
    /// </list>
    /// </returns>
    /// <remarks>
    /// This method iterates through all libraries, definition names, and their associated signatures
    /// to return a complete list of definitions stored in the dictionary.
    /// </remarks>

    public IEnumerable<(string libraryName, DefinitionSignature definitionSignature, T definition)> SelectDefinitions()
    {
        foreach (var (libraryName, definitions) in _signatureDefinitionsPerDefinitionNamePerLibraryName)
            foreach (var (definitionName, signatureDefinitions) in definitions)
                foreach (var (signature, definition) in signatureDefinitions)
                    yield return (libraryName, new (definitionName, signature), definition);
    }

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

    /// <summary>
    /// Merges the specified <see cref="DefinitionDictionary{T}"/> instances into the current dictionary.
    /// </summary>
    /// <param name="dictionaries">
    /// An array of <see cref="DefinitionDictionary{T}"/> instances to merge into the current dictionary.
    /// </param>
    /// <remarks>
    /// This method adds all definitions from the provided dictionaries into the current dictionary.
    /// If a library already exists in the current dictionary, its definitions are not overwritten.
    /// </remarks>
    public void Merge(params DefinitionDictionary<T>[] dictionaries)
    {
        foreach (var dictionary in dictionaries)
            foreach (var libKey in dictionary.Libraries)
            {
                // don't overwrite existing libraries
                if (Libraries.Contains(libKey))
                    continue;

                foreach (var (definitionSignature, definition) in dictionary.SelectDefinitionsByLibraryName(libKey))
                    AddDefinition(libKey, definitionSignature, definition);
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
        IEnumerable<(Type[] Signature, T Definition)> signatureDefinitions,
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
            return item0.ToArray() is [{ } itemOnly] ? itemOnly.Definition : null;

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