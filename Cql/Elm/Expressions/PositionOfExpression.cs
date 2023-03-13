using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class PositionOfExpression : Expression
    {
        public Expression? pattern { get; set; }
        public Expression? @string { get; set; }

    }
}
