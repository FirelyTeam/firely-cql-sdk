using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class SliceExpression: AggregateExpression
    {
        public Expression? startIndex { get; set; }
        public Expression? endIndex { get; set; }

    }
}
