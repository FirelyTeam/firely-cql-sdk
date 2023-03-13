namespace Ncqa.Elm.Expressions
{
    public class IncludeExpression : Expression
    { 
        public string? path { get; set; }
        public string? version { get; set; }
        public string? localIdentifier { get; set; }
    }

}