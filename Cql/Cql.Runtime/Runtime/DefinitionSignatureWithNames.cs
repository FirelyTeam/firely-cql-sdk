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
    /// <param name="parameters">
    /// A collection of tuples where each tuple contains a parameter name and its corresponding type.
    /// </param>
    [UsedImplicitly]
    public DefinitionSignatureWithNames(string name, params (string name, Type type)[] parameters) : this(
        name, parameters.SelectToArray(p => p.name), parameters.SelectToArray(p => p.type)) { }

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
    /// Retrieves an array of tuples, where each tuple contains a parameter name and its corresponding type.
    /// </summary>
    /// <returns>
    /// An array of tuples, where each tuple consists of a parameter name as a <see cref="string"/>
    /// and its corresponding type as a <see cref="Type"/>.
    /// </returns>
    public (string name, Type type)[] GetParameterTypeNames() =>
        ParameterTypes.Zip(ParameterNames, (type, name) => (name, type)).ToArray();

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
        if (ParameterTypes.Any())
        {
            var parameters = GetParameterTypeNames().Select(t => $"{t.type.ToCSharpString()} {t.name}");
            return $"{Name}({string.Join(", ", parameters)})";
        }

        return Name;
    }

    /// <summary>
    /// Returns the hash code for the current instance.
    /// </summary>
    /// <returns>The hash code for the current instance.</returns>
    public override int GetHashCode() => _hashCode;

    /// <summary>
    /// Deconstructs the current <see cref="DefinitionSignatureWithNames"/> instance into its name
    /// and a collection of parameter type-name pairs.
    /// </summary>
    /// <param name="name">The name of the definition.</param>
    /// <param name="parameters">
    /// An array of tuples, where each tuple contains a parameter name as a <see cref="string"/>
    /// and its corresponding type as a <see cref="Type"/>.
    /// </param>
    public void Deconstruct(out string name, out (string name, Type type)[] parameters)
    {
        name = Name;
        parameters = GetParameterTypeNames();
    }

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