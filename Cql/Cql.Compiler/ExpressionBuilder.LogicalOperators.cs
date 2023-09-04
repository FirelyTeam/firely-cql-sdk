#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {

        /// <summary>
        /// The and operator returns true if both its arguments are true. If either argument is false, the result is false. Otherwise, the result is null.
        /// </summary>
        /// <remarks>See https://cql.hl7.org/09-b-cqlreference.html#and</remarks>
        protected Expression And(elm.And e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.And, e, ctx);

        /// <summary>
        /// The or operator returns true if either of its arguments are true. If both arguments are false, the result is false. Otherwise, the result is null.
        /// </summary>
        /// <remarks>See https://cql.hl7.org/09-b-cqlreference.html#or</remarks>
        protected Expression Or(elm.Or e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Or, e, ctx);
        protected Expression Not(elm.Not e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Not, e, ctx);
        protected Expression Xor(elm.Xor e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Xor, e, ctx);


    }
}
