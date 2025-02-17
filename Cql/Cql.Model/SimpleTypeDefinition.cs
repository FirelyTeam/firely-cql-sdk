namespace Hl7.Cql.Model
{
    internal class SimpleTypeDefinition : TypeDefinition
    {
        internal SimpleTypeDefinition(string name, ModelDefinition model, AccessModifier access)
            : base(name, model, access)
        {
        }
        public override TypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);
    }
}
