namespace Hl7.Cql.Elm.Expressions
{
    public class InValueSetExpression: Expression
    {
        public Expression? code { get; set; }
        public ValueSetRefExpression? valueset { get; set; }
    }
}
