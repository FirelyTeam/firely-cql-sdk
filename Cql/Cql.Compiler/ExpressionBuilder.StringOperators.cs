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
using Microsoft.Extensions.Logging;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilderContext
    {

        protected Expression? Combine(elm.Combine e)
        {
            var source = this.TranslateExpression(e.source!);
            var operand = e.separator == null
                ? Expression.Constant(null, typeof(string))
                : this.TranslateExpression(e.separator);
            var call = this.OperatorBinding.Bind(CqlOperator.Combine, this.RuntimeContextParameter, source, operand);
            return call;
        }

        protected Expression Concatenate(elm.Concatenate e) =>
            NaryOperator(CqlOperator.Concatenate, e);

        protected Expression? EndsWith(elm.EndsWith e) =>
            BinaryOperator(CqlOperator.EndsWith, e);

        protected Expression Indexer(elm.Indexer e)
        {
            var left = this.TranslateExpression(e!.operand![0]!);
            var right = this.TranslateExpression(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return this.OperatorBinding.Bind(CqlOperator.CharAt, this.RuntimeContextParameter, left, right);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return this.OperatorBinding.Bind(CqlOperator.ElementAt, this.RuntimeContextParameter, left, right);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? LastPositionOf(elm.LastPositionOf e)
        {
            var @string = this.TranslateExpression(e!.@string!);
            var pattern = this.TranslateExpression(e!.pattern!);
            return this.OperatorBinding.Bind(CqlOperator.LastPositionOf, this.RuntimeContextParameter, @string, pattern);
        }

        protected Expression? Length(elm.Length len)
        {
            var operand = this.TranslateExpression(len.operand!);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                return this.OperatorBinding.Bind(CqlOperator.ListLength, this.RuntimeContextParameter, operand);
            }
            else if (operand.Type == typeof(string))
            {
                return this.OperatorBinding.Bind(CqlOperator.StringLength, this.RuntimeContextParameter, operand);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Lower(elm.Lower e) =>
            UnaryOperator(CqlOperator.Lower, e);

        protected Expression? Matches(elm.Matches e) =>
            BinaryOperator(CqlOperator.Matches, e);

        protected Expression PositionOf(elm.PositionOf e)
        {
            var @string = this.TranslateExpression(e!.@string!);
            var pattern = this.TranslateExpression(e!.pattern!);
            return this.OperatorBinding.Bind(CqlOperator.PositionOf, this.RuntimeContextParameter, pattern, @string);

        }

        protected Expression? ReplaceMatches(elm.ReplaceMatches e)
        {
            var source = this.TranslateExpression(e.operand![0]!);
            var pattern = this.TranslateExpression(e.operand![1]!);
            var substitution = this.TranslateExpression(e.operand![2]!);
            return this.OperatorBinding.Bind(CqlOperator.ReplaceMatches, this.RuntimeContextParameter, source, pattern, substitution);
        }

        protected Expression Split(elm.Split e)
        {
            ExpressionBuilderContext ctx = this;
            var stringToSplit = ctx.TranslateExpression(e.stringToSplit!);
            var separator = ctx.TranslateExpression(e.separator!);
            return ctx.OperatorBinding.Bind(CqlOperator.Split, ctx.RuntimeContextParameter, stringToSplit, separator);
        }

        protected Expression? StartsWith(elm.StartsWith e) =>
            BinaryOperator(CqlOperator.StartsWith, e);

        protected Expression? Substring(elm.Substring e)
        {
            var stringToSub = this.TranslateExpression(e!.stringToSub!);
            var startIndex = this.TranslateExpression(e!.startIndex!);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : this.TranslateExpression(e.length);
            return this.OperatorBinding.Bind(CqlOperator.Substring, this.RuntimeContextParameter, stringToSub, startIndex, length);
        }

        protected Expression? Upper(elm.Upper e) =>
            UnaryOperator(CqlOperator.Upper, e);
    }
}
