using System.Diagnostics;

namespace Hl7.Cql.Model
{
    [DebuggerDisplay("{Name}")]
    internal class SimpleTypeDefinition : TypeDefinition
    {
        internal SimpleTypeDefinition(string name, ModelDefinition model, AccessModifier access)
            : base(name, model, access)
        {
        }
        public override TypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);

        public override string ToString() => Name;
    }
}
