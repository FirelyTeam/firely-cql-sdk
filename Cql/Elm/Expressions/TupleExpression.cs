/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class TupleExpression : Expression
    {
        public TupleExpressionElement[]? element { get; set; }
    }

    public class TupleExpressionElement
    {
        public string? name { get; set; }
        public Expression? value { get; set; }
        public TypeSpecifierExpression? elementType { get; set; }
    }

}
