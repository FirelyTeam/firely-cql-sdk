using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class DefinitionExpression: Expression
    {
        public Annotation[]? annotation { get; set; }
        public string? name { get; set; }
        public string? accessLevel { get; set; }
        public string? context { get; set; }
        public Expression? expression { get; set; }
        public bool? external { get; set; }
        public DefinitionOperand[]? operand { get; set; }
    }

    /// <summary>
    /// Used for parameters to definitions whose type is FunctionDef
    /// </summary>
    public class DefinitionOperand
    {
        public string? name { get; set; }
        public Expression? operandTypeSpecifier { get; set; }

    }
}
