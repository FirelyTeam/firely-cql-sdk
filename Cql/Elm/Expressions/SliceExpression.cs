namespace Hl7.Cql.Elm.Expressions
{
    public class SliceExpression: AggregateExpression
    {
        public Expression? startIndex { get; set; }
        public Expression? endIndex { get; set; }

    }
}
