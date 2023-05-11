namespace Hl7.Cql.Elm.Expressions
{
    public class TupleExpression: Expression
    {
        public TupleExpressionElement[]? element { get; set; }
    }

    public class TupleExpressionElement
    {
        public string? name { get; set; }
        public Expression? value { get; set; }
        public TypeSpecifierExpression? elementType { get; set; }
    }

}
