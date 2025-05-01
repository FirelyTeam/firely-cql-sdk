    namespace Hl7.Cql.Runtime;

    /// <summary>
    /// Represents the signature of a definition, including its name and parameter types.
    /// </summary>
    /// <param name="name">The name of the definition.</param>
    /// <param name="parameterTypes">The types of the parameters for the definition.</param>
    public sealed class DefinitionSignature(string name, params Type[] parameterTypes) : IEquatable<DefinitionSignature>
    {
        /// <summary>
        /// Determines whether two <see cref="DefinitionSignature"/> instances are equal.
        /// </summary>
        /// <param name="left">The first <see cref="DefinitionSignature"/> to compare.</param>
        /// <param name="right">The second <see cref="DefinitionSignature"/> to compare.</param>
        /// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(DefinitionSignature? left, DefinitionSignature? right) => Equals(left, right);

        /// <summary>
        /// Determines whether two <see cref="DefinitionSignature"/> instances are not equal.
        /// </summary>
        /// <param name="left">The first <see cref="DefinitionSignature"/> to compare.</param>
        /// <param name="right">The second <see cref="DefinitionSignature"/> to compare.</param>
        /// <returns><c>true</c> if the instances are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(DefinitionSignature? left, DefinitionSignature? right) => !Equals(left, right);

        private readonly int _hashCode = CalcHashCode(name, CalcParameterTypes(parameterTypes));

        /// <summary>
        /// Gets the name of the definition.
        /// </summary>
        public string Name { get; } = name;

        /// <summary>
        /// Gets the types of the parameters for the definition.
        /// </summary>
        public Type[] ParameterTypes { get; } = CalcParameterTypes(parameterTypes);

        /// <summary>
        /// Ensures that the parameter types array is not null and returns an empty array if it is null or empty.
        /// </summary>
        /// <param name="parameterTypes">The parameter types array to process.</param>
        /// <returns>A non-null array of parameter types.</returns>
        private static Type[] CalcParameterTypes(Type[] parameterTypes) =>
            parameterTypes is { Length: > 0 } ? parameterTypes : [];

        /// <summary>
        /// Calculates a hash code for the <see cref="DefinitionSignature"/> instance based on its name and parameter types.
        /// </summary>
        /// <param name="name">The name of the definition.</param>
        /// <param name="types">The parameter types of the definition.</param>
        /// <returns>The calculated hash code.</returns>
        private static int CalcHashCode(string name, Type[] types)
        {
            var hashCode = new HashCode();
            hashCode.Add(name);
            if (types.Length > 0)
                foreach (var type in types)
                    hashCode.Add(type);
            return hashCode.ToHashCode();
        }

        /// <summary>
        /// Determines whether the current instance is equal to another <see cref="DefinitionSignature"/> instance.
        /// </summary>
        /// <param name="other">The other <see cref="DefinitionSignature"/> instance to compare.</param>
        /// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
        bool IEquatable<DefinitionSignature>.Equals(DefinitionSignature? other) =>
            other is not null
            && (ReferenceEquals(this, other) || Equals(other));

        /// <summary>
        /// Compares the current instance with another <see cref="DefinitionSignature"/> instance for equality.
        /// </summary>
        /// <param name="other">The other <see cref="DefinitionSignature"/> instance to compare.</param>
        /// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
        private bool Equals(DefinitionSignature other)
        {
            if (_hashCode != other._hashCode) return false;
            if (Name != other.Name) return false;
            if (!ParameterTypes.SequenceEqual(other.ParameterTypes)) return false;
            return true;
        }

        /// <summary>
        /// Determines whether the current instance is equal to another object.
        /// </summary>
        /// <param name="other">The object to compare with the current instance.</param>
        /// <returns><c>true</c> if the object is equal to the current instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return Equals((DefinitionSignature)other);
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
