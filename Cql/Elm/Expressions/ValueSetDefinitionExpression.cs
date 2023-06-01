using Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Elm
{
    public class ValueSetDefinitionExpression : Expression
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? version { get; set; }
    }
}
