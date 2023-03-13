using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class WithExpression: Expression
    {
        public string? alias { get; set; }
        public Expression? expression { get; set; }
        public Expression? suchThat { get; set; }
    }
}
