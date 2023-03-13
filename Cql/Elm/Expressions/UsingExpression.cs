using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class UsingExpression: Expression
    {
        public string? localIdentifier { get; set; }
        public string? path { get; set; }
        public string? version { get; set; }
    }
}
