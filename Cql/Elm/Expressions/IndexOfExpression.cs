using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class IndexOfExpression: Expression
    {
        public Expression? source { get; set; }
        public Expression? element { get; set; }

    }
}
