namespace Hl7.Cql.Elm.Expressions
{
    public class InstanceExpression: Expression
    {
        public InstanceExpressionElement[]? element { get; set; }
        public string? classType { get; set; }
    }

    public class InstanceExpressionElement
    {
        public string? name { get; set; }

        public Expression? value { get; set; }

    }
}
