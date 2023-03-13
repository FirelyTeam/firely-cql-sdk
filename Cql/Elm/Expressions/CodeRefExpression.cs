using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class CodeRefExpression: Expression
    {
        public string? libraryName { get; set; }
        public string? name { get; set; }
    }
}
