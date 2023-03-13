using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class LiteralExpression: Expression
    {
        public string? value { get; set; }

        public string? valueType { get; set; }

    }
}
