namespace Ncqa.Elm.Expressions
{
    public class CombineExpression : Expression
    {
        public Expression? source { get; set; }
        public Expression? separator { get; set; }

    }
}
