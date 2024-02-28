/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hl7.Cql.Elm
{
    public partial class TypeSpecifier
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj) => base.Equals(obj);

        /// <inheritdoc/>
        public override int GetHashCode() => base.GetHashCode();

        /// <inheritdoc/>
        public static bool operator ==(TypeSpecifier? a, TypeSpecifier? b) => a?.Equals(b) ?? b is null;

        /// <inheritdoc/>
        public static bool operator !=(TypeSpecifier? a, TypeSpecifier? b) => !(a == b);

        internal static bool SequenceEquals<T>(IEnumerable<T>? a, IEnumerable<T>? b) => EmptyIfNull(a).SequenceEqual(EmptyIfNull(b));
        internal static bool SetEquals<T>(IEnumerable<T>? a, IEnumerable<T>? b)
        {
            // tried using HashSet<>.SetEquals and it does not work even though all hashcodes are equal
            var bCodes = b?
                .Select(_b => _b?.GetHashCode() ?? default)
                .ToArray()
                ?? Array.Empty<int>();
            if (a?.Count() != b?.Count())
                return false;
            foreach(var aCode in a?.Select(_a => _a?.GetHashCode() ?? default) ?? Enumerable.Empty<int>())
            {
                if (!bCodes.Contains(aCode))
                    return false;
            }
            return true;
        }

        internal static IEnumerable<T> EmptyIfNull<T>(IEnumerable<T>? a) => a ?? Enumerable.Empty<T>();
    }

    public partial class ChoiceTypeSpecifier: IEquatable<ChoiceTypeSpecifier>
    {
        /// <summary>
        /// Creates an empty Choice type. This is used for deserialization.
        /// </summary>
        public ChoiceTypeSpecifier()
        {
            // deserialization constructor
        }

        /// <summary>
        /// Creates a Choice type with the given choices of types.
        /// </summary>
        public ChoiceTypeSpecifier(params TypeSpecifier[] choice)
        {
            this.choice = choice;
        }

        /// <summary>
        /// Creates a Choice type with the given choices of types.
        /// </summary>
        public ChoiceTypeSpecifier(IEnumerable<TypeSpecifier> choice)
        {
            this.choice = choice.ToArray();
        }

        /// <inheritdoc/>
        public override string ToString() => $"Choice<{string.Join(", ", EmptyIfNull(choice))}>";

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? other) => Equals(other as ChoiceTypeSpecifier);

        /// <inheritdoc/>
        public bool Equals(ChoiceTypeSpecifier? other) => other == null ? false : SetEquals(other.choice, choice);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(typeof(ChoiceTypeSpecifier), choice?.Length, choice?.FirstOrDefault());

    }

    public partial class ParameterTypeSpecifier
    {
        /// <inheritdoc/>
        public override string ToString() => parameterName ?? "Null";

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is ParameterTypeSpecifier par)
                return par.parameterName == parameterName;

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode() => parameterName?.GetHashCode() ?? typeof(ParameterTypeSpecifier).GetHashCode();

    }

    public partial class TupleElementDefinition
    {
        /// <inheritdoc/>
        public override string ToString() => $"{name ?? "null"} {elementType?.ToString() ?? "Null"}";

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is TupleElementDefinition tuple)
                return tuple.name == name && tuple.elementType == elementType;

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(name, elementType);

    }

    public partial class TupleTypeSpecifier
    {
        /// <inheritdoc/>
        public override string ToString() => $"Tuple {{ {string.Join(", ", EmptyIfNull(element))} }}";

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is TupleTypeSpecifier tuple)
                return SetEquals(element, tuple.element);

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(typeof(IntervalTypeSpecifier), element?.Length, element?.FirstOrDefault());

    }

    public partial class IntervalTypeSpecifier
    {
        /// <inheritdoc/>
        public override string ToString() => $"Interval<{pointType}>";

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is IntervalTypeSpecifier interval)
                return pointType == interval.pointType;

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(typeof(IntervalTypeSpecifier), pointType);

    }

    public partial class NamedTypeSpecifier
    {
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        public NamedTypeSpecifier()
        {
            // Deserialization constructor
        }

        /// <summary>
        /// Create a new named type given its uri and name.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="name"></param>
        public NamedTypeSpecifier(string uri, string name)
        {
            this.name = QualifiedName.MakeQualifiedTypeName(uri, name);
        }


        /// <summary>
        /// Gets the model uri and name for this named type.
        /// </summary>
        /// <returns>The uri and the type parts of the name in the specifier.</returns>
        /// <exception cref="ArgumentException">If the name does not match the expected pattern.</exception>
        public void Deconstruct(out string uri, out string name) => (uri, name) = this.name;

        /// <inheritdoc/>
        public override string ToString()
        {
            if (name is null) return "null";

            var (u, n) = name;
            if (u == SystemTypes.SystemModelUri)
                return n;
            else
                return name.ToString();
        }

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is NamedTypeSpecifier nt)
                return name == nt.name;

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode() => name?.GetHashCode() ?? typeof(NamedTypeSpecifier).GetHashCode();
    }

    public partial class ListTypeSpecifier
    {
        /// <inheritdoc/>
        public override string ToString() => $"List<{elementType}>";

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is ListTypeSpecifier list)
                return list.elementType == elementType;

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(typeof(ListTypeSpecifier), elementType);
    }
}
