#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ContextualExpressionBuilder
    {
        protected Expression? Distinct(elm.Distinct e) =>
            UnaryOperator(CqlOperator.Distinct, e);

        protected Expression Exists(elm.Exists e) =>
            UnaryOperator(CqlOperator.Exists, e);

        protected Expression Flatten(elm.Flatten e) =>
            UnaryOperator(CqlOperator.Flatten, e);

        protected Expression First(elm.First e)
        {
            var operand = TranslateExpression(e.source!);
            var call = OperatorBinding.Bind(CqlOperator.First, RuntimeContextParameter, operand);
            return call;
        }

        protected Expression IndexOf(elm.IndexOf e)
        {
            var source = TranslateExpression(e.source!);
            var element = TranslateExpression(e.element!);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return OperatorBinding.Bind(CqlOperator.IndexOf, RuntimeContextParameter, source, element);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Last(elm.Last e)
        {
            var operand = TranslateExpression(e.source!);
            var call = OperatorBinding.Bind(CqlOperator.Last, RuntimeContextParameter, operand);
            return call;
        }

        private Expression SingletonFrom(elm.SingletonFrom e) =>
            UnaryOperator(CqlOperator.Single, e);


        private Expression? Slice(elm.Slice slice)
        {
            var source = TranslateExpression(slice.source!);
            var start = slice.startIndex == null || slice.startIndex is elm.Null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.startIndex!);
            var end = slice.endIndex == null || slice.endIndex is elm.Null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.endIndex!);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return OperatorBinding.Bind(CqlOperator.Slice, RuntimeContextParameter, source, start, end);
            }
            throw new NotImplementedException().WithContext(this);
        }
    }
}
