using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class ParameterDeclarationExpression: Expression
    {
        public string? name { get; set; }

        public TypeSpecifierExpression? parameterTypeSpecifier { get; set; }

        public Expression? @default { get; set; }
    }
}
