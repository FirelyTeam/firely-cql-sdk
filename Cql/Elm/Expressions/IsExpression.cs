namespace Hl7.Cql.Elm.Expressions
{
    public class IsExpression : UnaryExpression
    {
        public string? isType { get; set; }
        public Expression? isTypeSpecifier { get; set; }
    }
}
