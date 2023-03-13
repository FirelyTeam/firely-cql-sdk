using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class DateExpression : Expression
    {
        public Expression? year { get; set; }
        public Expression? month { get; set; }
        public Expression? day { get; set; }
    }
}
