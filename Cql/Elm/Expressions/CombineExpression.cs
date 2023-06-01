namespace Hl7.Cql.Elm.Expressions
{
    public class CombineExpression : Expression
    {
        public Expression? source { get; set; }
        public Expression? separator { get; set; }

    }
}
