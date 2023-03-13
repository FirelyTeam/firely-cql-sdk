using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class SplitExpression: Expression
    {
        public Expression? stringToSplit { get; set; }
        public Expression? separator { get; set; }

    }
}
