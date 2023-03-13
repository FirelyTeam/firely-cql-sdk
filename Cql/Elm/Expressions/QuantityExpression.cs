using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class QuantityExpression: Expression
    {
        public decimal? value { get; set; }

        public string? unit { get; set; }
    }
}
