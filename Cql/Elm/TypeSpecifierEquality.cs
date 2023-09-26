#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hl7.Cql.Elm
{
    public partial class TypeSpecifier
    {
        public override bool Equals(object? obj) => base.Equals(obj);

        public override int GetHashCode() => base.GetHashCode();

        public static bool operator ==(TypeSpecifier? a, TypeSpecifier? b) => a?.Equals(b) ?? b is null;

        public static bool operator !=(TypeSpecifier? a, TypeSpecifier? b) => !(a == b);
    }

    public partial class ChoiceTypeSpecifier
    {
        public override string ToString() => $"Choice<{string.Join(", ", choice.AsEnumerable())}>";
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is ChoiceTypeSpecifier c)
                return Enumerable.SequenceEqual(c.choice, choice);

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(typeof(ChoiceTypeSpecifier), choice.Length, choice.FirstOrDefault());
    }

    public partial class ParameterTypeSpecifier
    {
        public override string ToString() => parameterName;
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is ParameterTypeSpecifier par)
                return par.parameterName == parameterName;

            return false;
        }

        public override int GetHashCode() => parameterName.GetHashCode();
    }

    public partial class TupleElementDefinition
    {
        public override string ToString() => $"{name} {type}";
        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is TupleElementDefinition tuple)
                return tuple.name == name && tuple.type == type;

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(name, type);
    }


    public partial class TupleTypeSpecifier
    {
        public override string ToString() => $"Tuple {{ {string.Join(", ", element.AsEnumerable())} }}";

        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is TupleTypeSpecifier tuple)
                return Enumerable.SequenceEqual(element, tuple.element);

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(typeof(IntervalTypeSpecifier), element.Length, element.FirstOrDefault());
    }

    public partial class IntervalTypeSpecifier
    {
        public override string ToString() => $"Interval<{pointType}>";

        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is IntervalTypeSpecifier interval)
                return pointType == interval.pointType;

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(typeof(IntervalTypeSpecifier), pointType);
    }

    public partial class NamedTypeSpecifier
    {
        public override string ToString() => name.ToString();

        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is NamedTypeSpecifier nt)
                return name == nt.name;

            return false;
        }

        public override int GetHashCode() => name.GetHashCode();
    }

    public partial class ListTypeSpecifier
    {
        public override string ToString() => $"List<{elementType}>";

        public override bool Equals([NotNullWhen(true)] object? other)
        {
            if (base.Equals(other))
                return true;

            if (other is ListTypeSpecifier list)
                return list.elementType == elementType;

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(typeof(ListTypeSpecifier), elementType);
    }
}
