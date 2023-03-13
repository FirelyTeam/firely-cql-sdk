namespace Ncqa.Elm.Expressions
{
    public class FunctionRefExpression : Expression
    {
        public string? name { get; set; }
        public string? libraryName { get; set; }
        public Expression[]? operand { get; set; }
    }
}
