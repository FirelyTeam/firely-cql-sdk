namespace Hl7.Cql.Model
{
    internal abstract class TypeDefinition
    {
        protected TypeDefinition(string name, ModelDefinition model, AccessModifier access)
        {
            Name = name;
            Model = model;
            Access = access;
        }

        public string Name { get; internal set; }

        public AccessModifier Access { get; internal set; }

        /// <summary>
        /// The canonical URI of the profile of this type, if applicable.
        /// </summary>
        public string? Identifier { get; internal set; }

        public TypeDefinition? BaseType { get; internal set; }

        public ModelDefinition Model { get; internal set; }

        public abstract TypeSpecifier ToTypeSpecifier();
    }
}
