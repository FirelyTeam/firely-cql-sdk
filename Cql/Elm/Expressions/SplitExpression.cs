namespace Hl7.Cql.Elm.Expressions
{
    public class SplitExpression: Expression
    {
        public Expression? stringToSplit { get; set; }
        public Expression? separator { get; set; }

    }
}
