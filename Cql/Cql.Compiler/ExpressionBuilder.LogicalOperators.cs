#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {

        /// <summary>
        /// The and operator returns true if both its arguments are true. If either argument is false, the result is false. Otherwise, the result is null.
        /// </summary>
        /// <remarks>See https://cql.hl7.org/09-b-cqlreference.html#and</remarks>
        protected Expression And(Elm.And e) =>
            BinaryOperator(CqlOperator.And, e);
        /// <summary>
        /// The implies operator returns the logical implication of its arguments. This means that if the left operand evaluates to true, this operator returns the boolean evaluation of the right operand. If the left operand evaluates to false, this operator returns true. Otherwise, this operator returns true if the right operand evaluates to true, and null otherwise.
        /// </summary>
        /// <remarks>See https://cql.hl7.org/09-b-cqlreference.html#implies</remarks>
        protected Expression Implies(Elm.Implies e) =>
            BinaryOperator(CqlOperator.Implies, e);
        /// <summary>
        /// The or operator returns true if either of its arguments are true. If both arguments are false, the result is false. Otherwise, the result is null.
        /// </summary>
        /// <remarks>See https://cql.hl7.org/09-b-cqlreference.html#or</remarks>
        protected Expression Or(Elm.Or e) =>
            BinaryOperator(CqlOperator.Or, e);
        protected Expression Not(Elm.Not e) =>
            UnaryOperator(CqlOperator.Not, e);
        protected Expression Xor(Elm.Xor e) =>
            BinaryOperator(CqlOperator.Xor, e);
    }
}
