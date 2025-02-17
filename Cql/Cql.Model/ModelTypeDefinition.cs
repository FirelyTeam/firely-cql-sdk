namespace Hl7.Cql.Model
{
    /// <summary>
    /// Defines the type of a model.
    /// </summary>
    internal class ModelTypeDefinition : TypeDefinition
    {

        public ModelTypeDefinition(ModelDefinition model) : base(model.Name, model, AccessModifier.Public)
        {
        }

        public override TypeSpecifier ToTypeSpecifier() => new NamedTypeSpecifier(this);
    }
}
