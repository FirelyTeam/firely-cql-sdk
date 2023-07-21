/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class InstanceExpression : Expression
    {
        public InstanceExpressionElement[]? element { get; set; }
        public string? classType { get; set; }
    }

    public class InstanceExpressionElement
    {
        public string? name { get; set; }

        public Expression? value { get; set; }

    }
}
