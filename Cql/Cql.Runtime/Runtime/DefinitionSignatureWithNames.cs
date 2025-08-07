/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents the signature of a definition with parameter names, including its name, parameter types, and parameter names.
/// </summary>
/// <param name="Name">The name of the definition.</param>
/// <param name="ParameterTypes">The types of the parameters for the definition.</param>
/// <param name="ParameterNames">The names of the parameters for the definition.</param>
[DebuggerDisplay($"{{{nameof(ToString)}(),nq}}")]
public readonly record struct DefinitionSignatureWithNames(string Name, string[] ParameterNames, Type[] ParameterTypes)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DefinitionSignatureWithNames"/> struct with the specified name
    /// and a collection of parameter type-name pairs.
    /// </summary>
    /// <param name="name">The name of the definition.</param>
    /// <param name="parameterTypeNamePairs">
    /// A collection of key-value pairs, where each key represents the name of a parameter,
    /// and each value represents the type of the corresponding parameter.
    /// </param>
    public DefinitionSignatureWithNames(string name, params KeyValuePair<string, Type>[] parameterTypeNamePairs)
        : this(
            name,
            parameterTypeNamePairs.SelectToArray(p => p.Key),
            parameterTypeNamePairs.SelectToArray(p => p.Value))
    {
    }

    /// <summary>
    /// Gets the name of the definition.
    /// </summary>
    public string Name { get; } = Name ?? throw new ArgumentNullException(nameof(Name));

    /// <summary>
    /// Gets the names of the parameters for the definition.
    /// </summary>
    public string[] ParameterNames { get; } = ParameterNames is { Length: > 0 } ? ParameterNames : [];

    /// <summary>
    /// Gets the types of the parameters for the definition.
    /// </summary>
    public Type[] ParameterTypes { get; } = ParameterTypes is { Length: > 0 } ? ParameterTypes : [];

    /// <summary>
    /// Gets a collection of key-value pairs representing the parameter names and their corresponding types.
    /// </summary>
    /// <remarks>
    /// Each key in the collection represents the name of a parameter, and each value represents the type of the corresponding parameter.
    /// </remarks>
    /// <returns>
    ///     An array of <see cref="KeyValuePair{TKey, TValue}"/> where the key is a <see cref="string"/> representing the parameter name,
    ///     and the value is a <see cref="Type"/> representing the parameter type.
    /// </returns>
    public KeyValuePair<string, Type>[] GetParameterTypeNamePairs() =>
        ParameterTypes.Zip(ParameterNames, (type, name) => new KeyValuePair<string, Type>(name, type)).ToArray();

    /// <summary>
    /// Cached hash code for performance optimization.
    /// </summary>
    private readonly int _hashCode = CalculateHashCode(Name, ParameterTypes, ParameterNames);

    /// <summary>
    /// Calculates the hash code for the given name, parameter types, and parameter names.
    /// </summary>
    /// <param name="name">The name to include in the hash code calculation.</param>
    /// <param name="parameterTypes">The parameter types to include in the hash code calculation.</param>
    /// <param name="parameterNames">The parameter names to include in the hash code calculation.</param>
    /// <returns>The calculated hash code.</returns>
    private static int CalculateHashCode(string name, Type[] parameterTypes, string[] parameterNames)
    {
        var parameterTypesLength = parameterTypes?.Length ?? 0;
        var parameterNamesLength = parameterNames?.Length ?? 0;
        if (parameterTypesLength != parameterNamesLength)
            throw new ArgumentException("Parameter types and parameter names must have the same length.");

        var hashCode = new HashCode();
        hashCode.Add(name);
        if (parameterTypesLength > 0)
        {
            foreach (var type in parameterTypes!)
                hashCode.Add(type);
            foreach (var paramName in parameterNames!)
                hashCode.Add(paramName);
        }
        return hashCode.ToHashCode();
    }

    /// <summary>
    /// Determines whether the current instance is equal to another <see cref="DefinitionSignatureWithNames"/> instance.
    /// </summary>
    /// <param name="other">The other <see cref="DefinitionSignatureWithNames"/> instance to compare.</param>
    /// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
    public bool Equals(DefinitionSignatureWithNames other)
    {
        if (_hashCode != other._hashCode) return false;
        if (Name != other.Name) return false;
        if (!ParameterTypes.SequenceEqual(other.ParameterTypes)) return false;
        return ParameterNames.SequenceEqual(other.ParameterNames);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var parameters = ParameterTypes.Zip(ParameterNames, (type, name) => $"{type.ToCSharpString()} {name}");
        return $"{Name}({string.Join(", ", parameters)})";
    }

    /// <summary>
    /// Returns the hash code for the current instance.
    /// </summary>
    /// <returns>The hash code for the current instance.</returns>
    public override int GetHashCode() => _hashCode;

    /// <summary>
    /// Implicitly converts a string to a <see cref="DefinitionSignatureWithNames"/> instance.
    /// </summary>
    /// <param name="name">The string value to be converted into a <see cref="DefinitionSignatureWithNames"/>.</param>
    public static implicit operator DefinitionSignatureWithNames(string name) => new(name);

    /// <summary>
    /// Implicitly converts a <see cref="DefinitionSignatureWithNames"/> to a <see cref="DefinitionSignature"/> instance.
    /// </summary>
    /// <param name="signature">The <see cref="DefinitionSignatureWithNames"/> value to be converted into a <see cref="DefinitionSignature"/>.</param>
    public static implicit operator DefinitionSignature(DefinitionSignatureWithNames signature) => new (signature.Name, signature.ParameterTypes);
}