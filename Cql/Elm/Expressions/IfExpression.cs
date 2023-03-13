using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class IfExpression: Expression
    {
        public Expression? condition { get; set; }
        public Expression? then { get; set; }
        public Expression? @else { get; set; }


    }
}
