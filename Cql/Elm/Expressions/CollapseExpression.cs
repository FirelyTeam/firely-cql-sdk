namespace Hl7.Cql.Elm.Expressions
{
    public class CollapseExpression: Expression
    {
        /// <summary>
        /// One or two parameters; the first is always a List of Intervals.  The second is optional and defines a precision.
        /// </summary>
        public Expression[]? operand { get; set; }


    }
}
