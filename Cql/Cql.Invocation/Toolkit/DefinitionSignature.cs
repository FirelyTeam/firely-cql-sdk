namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Represents the signature of a definition, including its name and parameter types.
/// </summary>
/// <param name="name">The name of the definition.</param>
/// <param name="parameterTypes">The types of the parameters for the definition.</param>
public sealed class DefinitionSignature(string name, params Type[] parameterTypes) : IEquatable<DefinitionSignature>
{
    public static bool operator ==(DefinitionSignature? left, DefinitionSignature? right) => Equals(left, right);

    public static bool operator !=(DefinitionSignature? left, DefinitionSignature? right) => !Equals(left, right);

    private readonly int _hashCode = CalcHashCode(name, CalcParameterTypes(parameterTypes));
    public string Name { get; } = name;
    public Type[] ParameterTypes { get; } = CalcParameterTypes(parameterTypes);

    private static Type[] CalcParameterTypes(Type[] parameterTypes) =>
        parameterTypes is {Length:>0} ? parameterTypes : [];

    private static int CalcHashCode(string name, Type[] types)
    {
        var hashCode = new HashCode();
        hashCode.Add(name);
        if (types.Length > 0)
            foreach (var type in types)
                hashCode.Add(type);
        return hashCode.ToHashCode();
    }

    bool IEquatable<DefinitionSignature>.Equals(DefinitionSignature? other) =>
        other is not null
        && (ReferenceEquals(this, other) || Equals(other));

    private bool Equals(DefinitionSignature other)
    {
        if (_hashCode != other._hashCode) return false;
        if (Name != other.Name) return false;
        if (!ParameterTypes.SequenceEqual(other.ParameterTypes)) return false;
        return true;
    }

    public override bool Equals(object? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        if (other.GetType() != GetType()) return false;
        return Equals((DefinitionSignature)other);
    }

    public override int GetHashCode() => _hashCode;


    /// <summary>
    /// Implicitly converts a string to a <see cref="DefinitionSignature"/> instance.
    /// </summary>
    /// <param name="name">The string value to be converted into a <see cref="DefinitionSignature"/>.</param>
    public static implicit operator DefinitionSignature(string name) => new(name);

    /// <summary>
    /// Deconstructs the <see cref="DefinitionSignature"/> instance into its components.
    /// </summary>
    /// <param name="name">The name of the definition.</param>
    /// <param name="parameterTypes">The types of the parameters for the definition.</param>
    public void Deconstruct(out string name, out Type[] parameterTypes)
    {
        name = Name;
        parameterTypes = ParameterTypes;
    }
}