using System;

namespace Hl7.Cql.Model
{
    internal abstract class TypeSpecifier: IEquatable<TypeSpecifier>
    {
        public abstract bool Equals(TypeSpecifier? other);
        public abstract bool IsSubtypeOf(TypeSpecifier other);
        protected internal abstract TypeDefinition? GetTypeDefinition();
    }
}
