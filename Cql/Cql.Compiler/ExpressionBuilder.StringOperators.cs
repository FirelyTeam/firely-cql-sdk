﻿#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {

        protected Expression? Combine(Elm.Combine e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e.source!, ctx);
            var operand = e.separator == null
                ? Expression.Constant(null, typeof(string))
                : TranslateExpression(e.separator, ctx);
            var call = OperatorBinding.Bind(CqlOperator.Combine, ctx.RuntimeContextParameter, source, operand);
            return call;
        }

        protected Expression Concatenate(Elm.Concatenate e, ExpressionBuilderContext ctx) =>
            NaryOperator(CqlOperator.Concatenate, e, ctx);

        protected Expression? EndsWith(Elm.EndsWith e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.EndsWith, e, ctx);

        protected Expression Indexer(Elm.Indexer e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e!.operand![1]!, ctx);
            if (left.Type == typeof(string))
            {
                return OperatorBinding.Bind(CqlOperator.CharAt, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ElementAt, ctx.RuntimeContextParameter, left, right);
            }
            else throw new NotImplementedException();
        }

        protected Expression? LastPositionOf(Elm.LastPositionOf e, ExpressionBuilderContext ctx)
        {
            var @string = TranslateExpression(e!.@string!, ctx);
            var pattern = TranslateExpression(e!.pattern!, ctx);
            return OperatorBinding.Bind(CqlOperator.LastPositionOf, ctx.RuntimeContextParameter, @string, pattern);
        }

        protected Expression? Length(Elm.Length len, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(len.operand!, ctx);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ListLength, ctx.RuntimeContextParameter, operand);
            }
            else if (operand.Type == typeof(string))
            {
                return OperatorBinding.Bind(CqlOperator.StringLength, ctx.RuntimeContextParameter, operand);
            }
            else throw new NotImplementedException();
        }

        protected Expression? Lower(Elm.Lower e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Lower, e, ctx);

        protected Expression? Matches(Elm.Matches e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Matches, e, ctx);

        protected Expression PositionOf(Elm.PositionOf e, ExpressionBuilderContext ctx)
        {
            var @string = TranslateExpression(e!.@string!, ctx);
            var pattern = TranslateExpression(e!.pattern!, ctx);
            return OperatorBinding.Bind(CqlOperator.PositionOf, ctx.RuntimeContextParameter, pattern, @string);

        }

        protected Expression? ReplaceMatches(Elm.ReplaceMatches e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e.operand![0]!, ctx);
            var pattern = TranslateExpression(e.operand![1]!, ctx);
            var substitution = TranslateExpression(e.operand![2]!, ctx);
            return OperatorBinding.Bind(CqlOperator.ReplaceMatches, ctx.RuntimeContextParameter, source, pattern, substitution);
        }

        protected Expression Split(Elm.Split e, ExpressionBuilderContext ctx)
        {
            var stringToSplit = TranslateExpression(e.stringToSplit!, ctx);
            var separator = TranslateExpression(e.separator!, ctx);
            return OperatorBinding.Bind(CqlOperator.Split, ctx.RuntimeContextParameter, stringToSplit, separator);
        }

        protected Expression? StartsWith(Elm.StartsWith e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.StartsWith, e, ctx);

        protected Expression? Substring(Elm.Substring e, ExpressionBuilderContext ctx)
        {
            var stringToSub = TranslateExpression(e!.stringToSub!, ctx);
            var startIndex = TranslateExpression(e!.startIndex!, ctx);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(e.length, ctx);
            return OperatorBinding.Bind(CqlOperator.Substring, ctx.RuntimeContextParameter, stringToSub, startIndex, length);
        }

        protected Expression? Upper(Elm.Upper e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Upper, e, ctx);



    }
}
