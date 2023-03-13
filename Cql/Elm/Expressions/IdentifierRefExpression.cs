using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class IdentifierRefExpression: Expression
    {
        public string? name { get; set; }
    }
}
