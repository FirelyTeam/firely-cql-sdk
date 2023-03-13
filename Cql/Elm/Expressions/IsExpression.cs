using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class IsExpression : UnaryExpression
    {
        public Expression? isTypeSpecifier { get; set; }
    }
}
