using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class CoalesceExpression: Expression
    {
        public Expression[]? operand { get; set; }
    }
}
