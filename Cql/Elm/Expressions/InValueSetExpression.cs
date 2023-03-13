using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class InValueSetExpression: Expression
    {
        public Expression? code { get; set; }
        public ValueSetRefExpression? valueset { get; set; }
    }
}
