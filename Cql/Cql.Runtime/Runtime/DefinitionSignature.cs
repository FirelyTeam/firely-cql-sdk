/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

    namespace Hl7.Cql.Runtime;

    /// <summary>
    /// Represents the signature of a definition, including its name and parameter types.
    /// </summary>
    /// <param name="Name">The name of the definition.</param>
    /// <param name="ParameterTypes">The types of the parameters for the definition.</param>
    public sealed record DefinitionSignature(string Name, params Type[] ParameterTypes)
    {
        /// <summary>
        /// Gets the types of the parameters for the definition.
        /// </summary>
        public Type[] ParameterTypes { get; } = CalcParameterTypes(ParameterTypes);

        /// <summary>
        /// Ensures that the parameter types array is not null and returns an empty array if it is null or empty.
        /// </summary>
        /// <param name="parameterTypes">The parameter types array to process.</param>
        /// <returns>A non-null array of parameter types.</returns>
        private static Type[] CalcParameterTypes(Type[] parameterTypes) =>
            parameterTypes is { Length: > 0 } ? parameterTypes : [];

        /// <summary>
        /// Determines whether the current instance is equal to another <see cref="DefinitionSignature"/> instance.
        /// </summary>
        /// <param name="other">The other <see cref="DefinitionSignature"/> instance to compare.</param>
        /// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(DefinitionSignature? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (Name != other.Name) return false;
            return ParameterTypes.SequenceEqual(other.ParameterTypes);
        }

        /// <summary>
        /// Returns the hash code for the current instance.
        /// </summary>
        /// <returns>The hash code for the current instance.</returns>
        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(Name);
            if (ParameterTypes.Length > 0)
                foreach (var type in ParameterTypes)
                    hashCode.Add(type);
            return hashCode.ToHashCode();
        }

        /// <summary>
        /// Implicitly converts a string to a <see cref="DefinitionSignature"/> instance.
        /// </summary>
        /// <param name="name">The string value to be converted into a <see cref="DefinitionSignature"/>.</param>
        public static implicit operator DefinitionSignature(string name) => new(name);
    }
