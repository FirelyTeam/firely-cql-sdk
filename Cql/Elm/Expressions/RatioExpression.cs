using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class RatioExpression: Expression
    {
        public RatioSide? numerator { get; set; }
        public RatioSide? denominator { get; set; }
    }

    public class RatioSide { 
        public int? value { get; set; }
        public string? unit { get; set; }
    }

}
