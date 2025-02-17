namespace Hl7.Cql.Model
{
    internal class ContextDefinition
    {
        public ContextDefinition(string name, ModelDefinition model, TypeDefinition type)
        {
            Name = name;
            Model = model;
            Type = type;
        }

        public string Name { get; internal set; }
        public ModelDefinition Model { get; }
        public TypeDefinition Type { get; internal set; }
    }
}
