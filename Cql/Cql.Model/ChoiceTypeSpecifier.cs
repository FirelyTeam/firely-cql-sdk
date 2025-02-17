using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Model
{
    internal class ChoiceTypeSpecifier : TypeSpecifier
    {
        public ChoiceTypeSpecifier(TypeSpecifier[] choices)
        {
            Choices = choices;
        }

        public TypeSpecifier[] Choices { get; }

        public override bool Equals(TypeSpecifier? other)
        {
            if (other is ChoiceTypeSpecifier otherChoice)
                return setEquals(Choices, otherChoice.Choices);
            else return false;
            // TODO: this is a copy from the ELM version
            bool setEquals<T>(IEnumerable<T>? a, IEnumerable<T>? b)
            {
                // tried using HashSet<>.SetEquals and it does not work even though all hashcodes are equal
                var bCodes = b?
                    .Select(_b => _b?.GetHashCode() ?? default)
                    .ToArray()
                    ?? Array.Empty<int>();
                if (a?.Count() != b?.Count())
                    return false;
                foreach (var aCode in a?.Select(_a => _a?.GetHashCode() ?? default) ?? Enumerable.Empty<int>())
                {
                    if (!bCodes.Contains(aCode))
                        return false;
                }
                return true;
            }
        }

        // choice types are never subtypes of other types
        public override bool IsSubtypeOf(TypeSpecifier other) => false;
        // choices don't have a single type definition
        protected internal override TypeDefinition? GetTypeDefinition() => null;

        public override string ToString() =>
            $"Choice<{string.Join(", ", Choices.Select(c=>c.ToString()))}>";

        public override int GetHashCode()
        {
            var code = typeof(ChoiceTypeSpecifier).GetHashCode();
            foreach(var choice in Choices)
            {
                code ^= choice.GetHashCode();
            }
            return code;
        }

    }
}
