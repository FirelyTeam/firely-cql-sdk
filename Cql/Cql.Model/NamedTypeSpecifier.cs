namespace Hl7.Cql.Model
{
    internal class NamedTypeSpecifier: TypeSpecifier
    {
        public NamedTypeSpecifier(TypeDefinition type)
        {
            Type = type;
        }

        public TypeDefinition Type { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is NamedTypeSpecifier otherNts)
                return Type.Name == otherNts.Type.Name;
            else return false;
        }

        protected internal override TypeDefinition? GetTypeDefinition() => Type;
        public override bool IsSubtypeOf(TypeSpecifier other)
        {
            var otherType = other.GetTypeDefinition();
            if (otherType != null)
            {
                var t = Type;
                while (t != null)
                {
                    if (t.Equals(otherType))
                        return true;
                    else t = t.BaseType;
                }
                return false;
            }
            return false;
        }

        public override string ToString() => Type.Model is not null ? $"{Type.Model.Name}.{Type.Name}" : Type.Name;

        public override int GetHashCode() => typeof(NamedTypeSpecifier).GetHashCode() ^ Type.Name.GetHashCode();

        
    }
}
