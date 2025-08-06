/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Provides flexible query capabilities for finding CQL definitions with support for wildcards.
/// Supports searching by definition name, parameter types, parameter names, or any combination.
/// </summary>
public sealed class DefinitionQuery
{
    /// <summary>
    /// Wildcard value that matches any value in a search.
    /// </summary>
    public const string Wildcard = "*";

    /// <summary>
    /// Gets or sets the definition name to search for. Use "*" for wildcard matching.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the parameter types to search for. Use null elements for wildcard positions.
    /// </summary>
    public Type?[]? ParameterTypes { get; set; }

    /// <summary>
    /// Gets or sets the parameter names to search for. Use "*" for wildcard positions.
    /// </summary>
    public string?[]? ParameterNames { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DefinitionQuery"/> class.
    /// </summary>
    public DefinitionQuery()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DefinitionQuery"/> class with a definition name.
    /// </summary>
    /// <param name="name">The definition name to search for.</param>
    public DefinitionQuery(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DefinitionQuery"/> class with name and parameter types.
    /// </summary>
    /// <param name="name">The definition name to search for.</param>
    /// <param name="parameterTypes">The parameter types to search for.</param>
    public DefinitionQuery(string name, params Type[] parameterTypes)
    {
        Name = name;
        ParameterTypes = parameterTypes;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DefinitionQuery"/> class with name, parameter types, and parameter names.
    /// </summary>
    /// <param name="name">The definition name to search for.</param>
    /// <param name="parameterTypes">The parameter types to search for.</param>
    /// <param name="parameterNames">The parameter names to search for.</param>
    public DefinitionQuery(string name, Type[] parameterTypes, string[] parameterNames)
    {
        Name = name;
        ParameterTypes = parameterTypes;
        ParameterNames = parameterNames;
    }

    /// <summary>
    /// Determines if the query matches the specified definition signature.
    /// </summary>
    /// <param name="signature">The definition signature to test.</param>
    /// <returns>True if the signature matches the query criteria.</returns>
    public bool Matches(DefinitionNamedSignature signature)
    {
        // Check name match
        if (Name != null && !IsWildcard(Name) && Name != signature.Name)
            return false;

        // Check parameter types match
        if (ParameterTypes != null)
        {
            if (ParameterTypes.Length != signature.ParameterTypes.Length)
                return false;

            for (int i = 0; i < ParameterTypes.Length; i++)
            {
                if (ParameterTypes[i] != null && ParameterTypes[i] != signature.ParameterTypes[i])
                    return false;
            }
        }

        // Check parameter names match
        if (ParameterNames != null)
        {
            if (ParameterNames.Length != signature.ParameterNames.Length)
                return false;

            for (int i = 0; i < ParameterNames.Length; i++)
            {
                if (ParameterNames[i] != null && !IsWildcard(ParameterNames[i]) && ParameterNames[i] != signature.ParameterNames[i])
                    return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Determines if a string value represents a wildcard.
    /// </summary>
    /// <param name="value">The value to test.</param>
    /// <returns>True if the value is a wildcard.</returns>
    private static bool IsWildcard(string? value) => value == Wildcard;

    /// <summary>
    /// Creates a query that matches definitions by name only.
    /// </summary>
    /// <param name="name">The definition name to search for.</param>
    /// <returns>A new <see cref="DefinitionQuery"/> instance.</returns>
    public static DefinitionQuery ByName(string name) => new(name);

    /// <summary>
    /// Creates a query that matches definitions by name and parameter types.
    /// </summary>
    /// <param name="name">The definition name to search for.</param>
    /// <param name="parameterTypes">The parameter types to search for.</param>
    /// <returns>A new <see cref="DefinitionQuery"/> instance.</returns>
    public static DefinitionQuery ByNameAndTypes(string name, params Type[] parameterTypes) => 
        new(name, parameterTypes);

    /// <summary>
    /// Creates a query that matches definitions by name and parameter names.
    /// </summary>
    /// <param name="name">The definition name to search for.</param>
    /// <param name="parameterNames">The parameter names to search for.</param>
    /// <returns>A new <see cref="DefinitionQuery"/> instance.</returns>
    public static DefinitionQuery ByNameAndParameterNames(string name, params string[] parameterNames) => 
        new() { Name = name, ParameterNames = parameterNames };

    /// <summary>
    /// Creates a query that matches definitions by name, parameter types, and parameter names.
    /// </summary>
    /// <param name="name">The definition name to search for.</param>
    /// <param name="parameterTypes">The parameter types to search for.</param>
    /// <param name="parameterNames">The parameter names to search for.</param>
    /// <returns>A new <see cref="DefinitionQuery"/> instance.</returns>
    public static DefinitionQuery ByNameTypesAndNames(string name, Type[] parameterTypes, string[] parameterNames) => 
        new(name, parameterTypes, parameterNames);
}

/// <summary>
/// Extension methods for searching definitions using queries.
/// </summary>
public static class DefinitionQueryExtensions
{
    /// <summary>
    /// Searches the named definitions dictionary using the specified query.
    /// </summary>
    /// <param name="namedDefinitions">The named definitions dictionary to search.</param>
    /// <param name="query">The query criteria to apply.</param>
    /// <returns>An enumerable of matching definition signature and invoker pairs.</returns>
    public static IEnumerable<KeyValuePair<DefinitionNamedSignature, TInvoker>> Search<TInvoker>(
        this IReadOnlyDictionary<DefinitionNamedSignature, TInvoker> namedDefinitions,
        DefinitionQuery query)
    {
        return namedDefinitions.Where(kvp => query.Matches(kvp.Key));
    }

    /// <summary>
    /// Searches the named definitions dictionary for definitions matching the specified name.
    /// </summary>
    /// <param name="namedDefinitions">The named definitions dictionary to search.</param>
    /// <param name="name">The definition name to search for.</param>
    /// <returns>An enumerable of matching definition signature and invoker pairs.</returns>
    public static IEnumerable<KeyValuePair<DefinitionNamedSignature, TInvoker>> SearchByName<TInvoker>(
        this IReadOnlyDictionary<DefinitionNamedSignature, TInvoker> namedDefinitions,
        string name)
    {
        return namedDefinitions.Search(DefinitionQuery.ByName(name));
    }

    /// <summary>
    /// Searches the named definitions dictionary for definitions matching the specified name and parameter types.
    /// </summary>
    /// <param name="namedDefinitions">The named definitions dictionary to search.</param>
    /// <param name="name">The definition name to search for.</param>
    /// <param name="parameterTypes">The parameter types to search for.</param>
    /// <returns>An enumerable of matching definition signature and invoker pairs.</returns>
    public static IEnumerable<KeyValuePair<DefinitionNamedSignature, TInvoker>> SearchByNameAndTypes<TInvoker>(
        this IReadOnlyDictionary<DefinitionNamedSignature, TInvoker> namedDefinitions,
        string name,
        params Type[] parameterTypes)
    {
        return namedDefinitions.Search(DefinitionQuery.ByNameAndTypes(name, parameterTypes));
    }

    /// <summary>
    /// Searches the named definitions dictionary for definitions matching the specified name and parameter names.
    /// </summary>
    /// <param name="namedDefinitions">The named definitions dictionary to search.</param>
    /// <param name="name">The definition name to search for.</param>
    /// <param name="parameterNames">The parameter names to search for.</param>
    /// <returns>An enumerable of matching definition signature and invoker pairs.</returns>
    public static IEnumerable<KeyValuePair<DefinitionNamedSignature, TInvoker>> SearchByNameAndParameterNames<TInvoker>(
        this IReadOnlyDictionary<DefinitionNamedSignature, TInvoker> namedDefinitions,
        string name,
        params string[] parameterNames)
    {
        return namedDefinitions.Search(DefinitionQuery.ByNameAndParameterNames(name, parameterNames));
    }
}