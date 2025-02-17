namespace Hl7.Cql.Model
{
    internal class ClassTypeElementDefinition
    {

        public ClassTypeElementDefinition(string name, TypeSpecifier type, string? targetCql)
        {
            Name = name;
            Type = type;
            TargetCql = targetCql;
        }

        public string Name { get; }

        public TypeSpecifier Type { get; }

        public string? TargetCql { get; }

    }
}
