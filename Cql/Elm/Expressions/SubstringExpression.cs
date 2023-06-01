namespace Hl7.Cql.Elm.Expressions
{
    public class SubstringExpression: Expression
    {
        public Expression? stringToSub { get; set; }

        public Expression? startIndex { get; set; }

        public Expression? length { get; set; }

    }
}
