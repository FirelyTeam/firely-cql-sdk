namespace Hl7.Cql.Elm.Expressions
{
    public class QuantityExpression: Expression
    {
        public decimal? value { get; set; }

        public string? unit { get; set; }
    }
}
