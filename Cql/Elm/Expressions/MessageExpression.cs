using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class MessageExpression: Expression
    {
        public Expression? source { get; set; }
        public Expression? condition { get; set; }
        public Expression? code { get; set; }
        public Expression? severity { get; set; }
        public Expression? message { get; set; }

    }
}
