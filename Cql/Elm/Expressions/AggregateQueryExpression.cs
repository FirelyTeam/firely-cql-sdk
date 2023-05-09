using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class AggregateQueryExpression: Expression
    {
        public Expression? expression { get; set; }
        public Expression? starting { get; set; }
        public string? identifier { get; set; }
    }

}
