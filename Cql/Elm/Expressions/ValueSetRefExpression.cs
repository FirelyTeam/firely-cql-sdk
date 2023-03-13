using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class ValueSetRefExpression: Expression 
    {
        public string? name { get; set; }

        public string? libraryName { get; set; }
    }
}
