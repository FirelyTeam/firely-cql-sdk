namespace Hl7.Cql.Elm.Expressions
{
    public class TimeExpression: Expression
    {
        public Expression? hour { get; set; }
        public Expression? minute { get; set; }
        public Expression? second { get; set; }
        public Expression? millisecond { get; set; }

    }
}
