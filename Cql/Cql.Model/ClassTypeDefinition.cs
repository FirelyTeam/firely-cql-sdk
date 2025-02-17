using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hl7.Cql.Model
{
    internal class ClassTypeDefinition : TypeDefinition
    {
        internal ClassTypeDefinition(string name,
            ModelDefinition model,
            AccessModifier access) : base(name, model,access)
        {
            Elements = new(ElementsByName);
        }

        private Dictionary<string, ClassTypeElementDefinition> ElementsByName { get; } = new();

        internal void AddElement(ClassTypeElementDefinition element) =>
            ElementsByName.Add(element.Name, element);

        internal ReadOnlyDictionary<string, ClassTypeElementDefinition> Elements { get; }

        public bool TryGetElement(string name, [NotNullWhen(true)] out ClassTypeElementDefinition? element) =>
            Elements.TryGetValue(name, out element);

        /// <summary>
        /// If this type is retrievable, this element definition is the code path to use
        /// in retrieves when no code property is explicitly declared.
        /// </summary>
        public ClassTypeElementDefinition? PrimaryCodePath { get; internal set; }

        public override TypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);
    }
}
