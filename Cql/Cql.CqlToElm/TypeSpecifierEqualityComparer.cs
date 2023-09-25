using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.CqlToElm
{
    internal class TypeSpecifierEqualityComparer : IEqualityComparer<TypeSpecifier>
    {
        public StringComparer NameComparer { get; }

        public TypeSpecifierEqualityComparer(StringComparer? nameComparer = null)
        {
            NameComparer = nameComparer ?? StringComparer.OrdinalIgnoreCase;
        }

        public bool Equals(TypeSpecifier? x, TypeSpecifier? y)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;

            if (x is ListTypeSpecifier ltsX && y is ListTypeSpecifier ltsY)
                return Equals(ltsX.elementType, ltsY.elementType);
            else if (x is NamedTypeSpecifier ntsX && y is NamedTypeSpecifier ntsY)
                return NamedTypesEqual(ntsX, ntsY);

            // TODO:
            else if (x is ChoiceTypeSpecifier ctsX && y is ChoiceTypeSpecifier ctsY)
                return false;
            else if (x is TupleTypeSpecifier ttsX && y is TupleTypeSpecifier ttsY)
                return false;
            else if (x is IntervalTypeSpecifier itsX && y is IntervalTypeSpecifier itsY)
                return false;
            else if (x is ParameterTypeSpecifier ptsX && y is ParameterTypeSpecifier ptsY)
                return false;
            else
                return false;
        }

        private bool NamedTypesEqual(NamedTypeSpecifier x, NamedTypeSpecifier y) =>
           NameComparer.Equals(x.name?.Name, y.name?.Name);


        public int GetHashCode([DisallowNull] TypeSpecifier obj) => obj?.GetHashCode() ?? typeof(TypeSpecifier).GetHashCode();
    }
}