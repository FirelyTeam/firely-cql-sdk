using System;

namespace Hl7.Cql.Elm.Expressions
{
    public class TypeSpecifierExpression : Expression
    {
        public TypeSpecifierExpression? elementType { get; set; }
        public TypeSpecifierExpression? pointType { get; set; }
        public string? name { get; set; }
        public TupleElementDefinition[]? element { get; set; }
        public TypeSpecifierExpression[]? choice { get; set; }
    }

    public class TupleElementDefinition
    {
        public string? name { get; set; }
        [Obsolete]
        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public TypeSpecifierExpression? type { get; set; }
        public TypeSpecifierExpression? elementType { get; set; }
    }

}