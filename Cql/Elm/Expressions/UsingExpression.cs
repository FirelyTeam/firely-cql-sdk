namespace Hl7.Cql.Elm.Expressions
{
    public class UsingExpression: Expression
    {
        public string? localIdentifier { get; set; }
        public string? path { get; set; }
        public string? version { get; set; }
    }
}
