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
    internal partial class ExpressionBuilderContext
    {
        protected Expression? Distinct(elm.Distinct e) =>
            UnaryOperator(CqlOperator.Distinct, e);

        protected Expression Exists(elm.Exists e) =>
            UnaryOperator(CqlOperator.Exists, e);

        protected Expression Flatten(elm.Flatten e) =>
            UnaryOperator(CqlOperator.Flatten, e);

        protected Expression First(elm.First e)
        {
            ExpressionBuilderContext ctx = this;
            var operand = ctx.TranslateExpression(e.source!);
            var call = ctx.OperatorBinding.Bind(CqlOperator.First, ctx.RuntimeContextParameter, operand);
            return call;
        }

        protected Expression IndexOf(elm.IndexOf e)
        {
            ExpressionBuilderContext ctx = this;
            var source = ctx.TranslateExpression(e.source!);
            var element = ctx.TranslateExpression(e.element!);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.IndexOf, ctx.RuntimeContextParameter, source, element);
            }
            throw new NotImplementedException().WithContext(ctx);
        }

        protected Expression Last(elm.Last e)
        {
            ExpressionBuilderContext ctx = this;
            var operand = ctx.TranslateExpression(e.source!);
            var call = ctx.OperatorBinding.Bind(CqlOperator.Last, ctx.RuntimeContextParameter, operand);
            return call;
        }

        private Expression SingletonFrom(elm.SingletonFrom e) =>
            UnaryOperator(CqlOperator.Single, e);


        private Expression? Slice(elm.Slice slice)
        {
            ExpressionBuilderContext ctx = this;
            var source = ctx.TranslateExpression(slice.source!);
            var start = slice.startIndex == null || slice.startIndex is elm.Null
                ? Expression.Constant(null, typeof(int?))
                : ctx.TranslateExpression(slice.startIndex!);
            var end = slice.endIndex == null || slice.endIndex is elm.Null
                ? Expression.Constant(null, typeof(int?))
                : ctx.TranslateExpression(slice.endIndex!);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.Slice, ctx.RuntimeContextParameter, source, start, end);
            }
            throw new NotImplementedException().WithContext(ctx);
        }
    }
}
