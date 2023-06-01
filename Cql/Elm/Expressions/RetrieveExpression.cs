namespace Hl7.Cql.Elm.Expressions
{
    public class RetrieveExpression: Expression
    {
        public string? codeProperty { get; set; }

        public Expression? codes { get; set; }

        public string? templateId { get; set; }


    }
}
