using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class TimeExpression: Expression
    {
        public Expression? hour { get; set; }
        public Expression? minute { get; set; }
        public Expression? second { get; set; }
        public Expression? millisecond { get; set; }

    }
}
