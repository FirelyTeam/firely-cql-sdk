/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class ParameterDeclarationExpression : Expression
    {
        public Annotation[]? annotation { get; set; }

        public string? name { get; set; }

        public TypeSpecifierExpression? parameterTypeSpecifier { get; set; }

        public Expression? @default { get; set; }
    }
}
