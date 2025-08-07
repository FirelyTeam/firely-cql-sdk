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
/// Represents the signature of a definition, including its name and parameter types.
/// </summary>
/// <param name="Name">The name of the definition.</param>
/// <param name="ParameterTypes">The types of the parameters for the definition.</param>
[DebuggerDisplay($"{{{nameof(ToString)}(),nq}}")]
public readonly record struct DefinitionSignature(string Name, params Type[] ParameterTypes)
{
    /// <summary>
    /// Gets the name of the definition.
    /// </summary>
    public string Name { get; } = Name ?? throw new ArgumentNullException(nameof(Name));

    /// <summary>
    /// Gets the types of the parameters for the definition.
    /// </summary>
    public Type[] ParameterTypes { get; } = ParameterTypes is { Length: > 0 } ? ParameterTypes : [];

    /// <summary>
    /// Cached hash code for performance optimization.
    /// </summary>
    private readonly int _hashCode = CalculateHashCode(Name, ParameterTypes);

    /// <summary>
    /// Calculates the hash code for the given name and parameter types.
    /// </summary>
    /// <param name="name">The name to include in the hash code calculation.</param>
    /// <param name="parameterTypes">The parameter types to include in the hash code calculation.</param>
    /// <returns>The calculated hash code.</returns>
    private static int CalculateHashCode(string name, Type[] parameterTypes)
    {
        var hashCode = new HashCode();
        hashCode.Add(name);
        if (parameterTypes is { Length: > 0})
            foreach (var type in parameterTypes)
                hashCode.Add(type);
        return hashCode.ToHashCode();
    }

    /// <summary>
    /// Determines whether the current instance is equal to another <see cref="DefinitionSignature"/> instance.
    /// </summary>
    /// <param name="other">The other <see cref="DefinitionSignature"/> instance to compare.</param>
    /// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
    public bool Equals(DefinitionSignature other)
    {
        if (_hashCode != other._hashCode) return false;
        if (Name != other.Name) return false;
        return ParameterTypes.SequenceEqual(other.ParameterTypes);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Name}({string.Join(", ", ParameterTypes.Select(t => t.ToCSharpString()))})";
    }

    /// <summary>
    /// Returns the hash code for the current instance.
    /// </summary>
    /// <returns>The hash code for the current instance.</returns>
    public override int GetHashCode() => _hashCode;

    /// <summary>
    /// Implicitly converts a string to a <see cref="DefinitionSignature"/> instance.
    /// </summary>
    /// <param name="name">The string value to be converted into a <see cref="DefinitionSignature"/>.</param>
    public static implicit operator DefinitionSignature(string name) => new(name);
}

/// <summary>
/// Represents the signature of a definition with parameter names, including its name, parameter types, and parameter names.
/// </summary>
/// <param name="Name">The name of the definition.</param>
/// <param name="ParameterTypes">The types of the parameters for the definition.</param>
/// <param name="ParameterNames">The names of the parameters for the definition.</param>
[DebuggerDisplay($"{{{nameof(ToString)}(),nq}}")]
public readonly record struct DefinitionSignatureWithNames(string Name, Type[] ParameterTypes, params string[] ParameterNames)
{
    /// <summary>
    /// Gets the name of the definition.
    /// </summary>
    public string Name { get; } = Name ?? throw new ArgumentNullException(nameof(Name));

    /// <summary>
    /// Gets the types of the parameters for the definition.
    /// </summary>
    public Type[] ParameterTypes { get; } = ParameterTypes is { Length: > 0 } ? ParameterTypes : [];

    /// <summary>
    /// Gets the names of the parameters for the definition.
    /// </summary>
    public string[] ParameterNames { get; } = ParameterNames is { Length: > 0 } ? ParameterNames : [];

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
        var hashCode = new HashCode();
        hashCode.Add(name);
        if (parameterTypes is { Length: > 0})
            foreach (var type in parameterTypes)
                hashCode.Add(type);
        if (parameterNames is { Length: > 0})
            foreach (var paramName in parameterNames)
                hashCode.Add(paramName);
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
    public static implicit operator DefinitionSignatureWithNames(string name) => new(name, [], []);
}
