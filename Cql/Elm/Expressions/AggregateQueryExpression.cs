namespace Hl7.Cql.Elm.Expressions
{
    public class AggregateQueryExpression: Expression
    {
        public Expression? expression { get; set; }
        public Expression? starting { get; set; }
        public string? identifier { get; set; }
    }

}
