namespace Hl7.Cql.Elm.Expressions
{
    public class AnyInValueSetExpression: Expression
    {
        public ValueSetRefExpression? valueset { get; set; }

        public Expression? codes { get; set; }

    }
}
