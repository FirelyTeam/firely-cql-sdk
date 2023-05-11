namespace Hl7.Cql.Elm.Expressions
{
    public class IfExpression: Expression
    {
        public Expression? condition { get; set; }
        public Expression? then { get; set; }
        public Expression? @else { get; set; }


    }
}
