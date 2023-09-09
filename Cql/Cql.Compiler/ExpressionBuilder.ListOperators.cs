#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression? Distinct(elm.Distinct e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Distinct, e, ctx);

        protected Expression Exists(elm.Exists e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Exists, e, ctx);

        protected Expression Flatten(elm.Flatten e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Flatten, e, ctx);

        protected Expression First(elm.First e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.source!, ctx);
            var call = OperatorBinding.Bind(CqlOperator.First, ctx.RuntimeContextParameter, operand);
            return call;
        }

        protected Expression IndexOf(elm.IndexOf e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e.source!, ctx);
            var element = TranslateExpression(e.element!, ctx);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return OperatorBinding.Bind(CqlOperator.IndexOf, ctx.RuntimeContextParameter, source, element);
            }
            throw new NotImplementedException();
        }

        protected Expression Last(elm.Last e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.source!, ctx);
            var call = OperatorBinding.Bind(CqlOperator.Last, ctx.RuntimeContextParameter, operand);
            return call;
        }

        private Expression SingletonFrom(elm.SingletonFrom e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Single, e, ctx);


        private Expression? Slice(elm.Slice slice, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(slice.source!, ctx);
            var start = slice.startIndex == null || slice.startIndex is elm.Null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.startIndex!, ctx);
            var end = slice.endIndex == null || slice.endIndex is elm.Null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.endIndex!, ctx);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return OperatorBinding.Bind(CqlOperator.Slice, ctx.RuntimeContextParameter, source, start, end);
            }
            throw new NotImplementedException();
        }

    }
}
