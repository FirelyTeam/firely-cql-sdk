using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Model
{
    internal class GenericTypeSpecifier : TypeSpecifier
    {
        public GenericTypeSpecifier(GenericTypeDefinition type, IEnumerable<TypeSpecifier> arguments)
        {
            Type = type;
            Arguments = arguments.ToList().AsReadOnly();
        }

        public GenericTypeDefinition Type { get; }

        public IReadOnlyList<TypeSpecifier> Arguments { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is GenericTypeSpecifier otherGts)
            {
                return Type.Name == otherGts.Type.Name
                    && Arguments.SequenceEqual(otherGts.Arguments);
            }
            else
                return false;
        }

        public override bool IsSubtypeOf(TypeSpecifier other)
        {
            var otherType = other.GetTypeDefinition();
            if (otherType != null)
            {
                TypeDefinition? t = Type;
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

        public override string ToString() =>
            $"{Type.Name}<{string.Join(", ", Arguments.Select(c=>c.ToString()))}>";

        protected internal override TypeDefinition? GetTypeDefinition() => Type;

        public override int GetHashCode()
        {
            var code = typeof(GenericArgumentSpecifier).GetHashCode() ^ Type.Name.GetHashCode();
            foreach (var arg in Arguments)
            {
                code ^= arg.GetHashCode();
            }
            return code;
        }
    }
}
