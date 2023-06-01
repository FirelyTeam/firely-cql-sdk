namespace Hl7.Cql.Elm.Expressions
{
    public class DateExpression : Expression
    {
        public Expression? year { get; set; }
        public Expression? month { get; set; }
        public Expression? day { get; set; }
    }
}
