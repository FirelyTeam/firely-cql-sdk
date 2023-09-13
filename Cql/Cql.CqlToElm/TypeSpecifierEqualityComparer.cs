using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (x is NamedTypeSpecifier ntsX && y is NamedTypeSpecifier ntsY)
                return NamedTypesEqual(ntsX, ntsY);

            return false;
        }

        private bool NamedTypesEqual(NamedTypeSpecifier x, NamedTypeSpecifier y) =>
           NameComparer.Equals(x.name?.Name, y.name?.Name);


        public int GetHashCode([DisallowNull] TypeSpecifier obj) => obj?.GetHashCode() ?? typeof(TypeSpecifier).GetHashCode();
    }
}