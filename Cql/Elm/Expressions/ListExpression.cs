using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class ListExpression : Expression
    {
        public Expression[]? element { get; set; }
    }
}
