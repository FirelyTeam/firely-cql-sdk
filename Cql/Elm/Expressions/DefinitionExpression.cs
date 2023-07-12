/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class DefinitionExpression : Expression
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
