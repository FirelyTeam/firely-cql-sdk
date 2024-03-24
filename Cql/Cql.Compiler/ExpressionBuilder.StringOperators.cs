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
    internal partial class ContextualExpressionBuilder
    {

        protected Expression? Combine(elm.Combine e)
        {
            var source = TranslateExpression(e.source!);
            var operand = e.separator == null
                ? Expression.Constant(null, typeof(string))
                : TranslateExpression(e.separator);
            var call = _operatorBinding.Bind(CqlOperator.Combine, ExpressionBuilder.ContextParameter, source, operand);
            return call;
        }

        protected Expression Concatenate(elm.Concatenate e) =>
            NaryOperator(CqlOperator.Concatenate, e);

        protected Expression? EndsWith(elm.EndsWith e) =>
            BinaryOperator(CqlOperator.EndsWith, e);

        protected Expression Indexer(elm.Indexer e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return _operatorBinding.Bind(CqlOperator.CharAt, ExpressionBuilder.ContextParameter, left, right);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ElementAt, ExpressionBuilder.ContextParameter, left, right);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? LastPositionOf(elm.LastPositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            return _operatorBinding.Bind(CqlOperator.LastPositionOf, ExpressionBuilder.ContextParameter, @string, pattern);
        }

        protected Expression? Length(elm.Length len)
        {
            var operand = TranslateExpression(len.operand!);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListLength, ExpressionBuilder.ContextParameter, operand);
            }
            else if (operand.Type == typeof(string))
            {
                return _operatorBinding.Bind(CqlOperator.StringLength, ExpressionBuilder.ContextParameter, operand);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Lower(elm.Lower e) =>
            UnaryOperator(CqlOperator.Lower, e);

        protected Expression? Matches(elm.Matches e) =>
            BinaryOperator(CqlOperator.Matches, e);

        protected Expression PositionOf(elm.PositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            return _operatorBinding.Bind(CqlOperator.PositionOf, ExpressionBuilder.ContextParameter, pattern, @string);

        }

        protected Expression? ReplaceMatches(elm.ReplaceMatches e)
        {
            var source = TranslateExpression(e.operand![0]!);
            var pattern = TranslateExpression(e.operand![1]!);
            var substitution = TranslateExpression(e.operand![2]!);
            return _operatorBinding.Bind(CqlOperator.ReplaceMatches, ExpressionBuilder.ContextParameter, source, pattern, substitution);
        }

        protected Expression Split(elm.Split e)
        {
            var stringToSplit = TranslateExpression(e.stringToSplit!);
            var separator = TranslateExpression(e.separator!);
            return _operatorBinding.Bind(CqlOperator.Split, ExpressionBuilder.ContextParameter, stringToSplit, separator);
        }

        protected Expression? StartsWith(elm.StartsWith e) =>
            BinaryOperator(CqlOperator.StartsWith, e);

        protected Expression? Substring(elm.Substring e)
        {
            var stringToSub = TranslateExpression(e!.stringToSub!);
            var startIndex = TranslateExpression(e!.startIndex!);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(e.length);
            return _operatorBinding.Bind(CqlOperator.Substring, ExpressionBuilder.ContextParameter, stringToSub, startIndex, length);
        }

        protected Expression? Upper(elm.Upper e) =>
            UnaryOperator(CqlOperator.Upper, e);
    }
}
