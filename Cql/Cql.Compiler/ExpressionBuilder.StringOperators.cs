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

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {

        protected Expression? Combine(Elm.Combine e)
        {
            var source = TranslateExpression(e.source!);
            var operand = e.separator == null
                ? Expression.Constant(null, typeof(string))
                : TranslateExpression(e.separator);
            var call = BindCqlOperator(CqlOperator.Combine, source, operand);
            return call;
        }

        protected Expression Indexer(Elm.Indexer e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return BindCqlOperator(CqlOperator.CharAt, left, right);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return BindCqlOperator(CqlOperator.ListElementAt, left, right);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? LastPositionOf(Elm.LastPositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            return BindCqlOperator(CqlOperator.LastPositionOf, @string, pattern);
        }

        protected Expression? Length(Elm.Length len)
        {
            var operand = TranslateExpression(len.operand!);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                return BindCqlOperator(CqlOperator.ListLength, operand);
            }
            else if (operand.Type == typeof(string))
            {
                return BindCqlOperator(CqlOperator.StringLength, operand);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression PositionOf(Elm.PositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            return BindCqlOperator(CqlOperator.PositionOf, pattern, @string);

        }

        protected Expression? ReplaceMatches(Elm.ReplaceMatches e)
        {
            var source = TranslateExpression(e.operand![0]!);
            var pattern = TranslateExpression(e.operand![1]!);
            var substitution = TranslateExpression(e.operand![2]!);
            return BindCqlOperator(CqlOperator.ReplaceMatches, source, pattern, substitution);
        }

        protected Expression Split(Elm.Split e)
        {
            var stringToSplit = TranslateExpression(e.stringToSplit!);
            var separator = TranslateExpression(e.separator!);
            return BindCqlOperator(CqlOperator.Split, stringToSplit, separator);
        }

        protected Expression? Substring(Elm.Substring e)
        {
            var stringToSub = TranslateExpression(e!.stringToSub!);
            var startIndex = TranslateExpression(e!.startIndex!);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(e.length);
            return BindCqlOperator(CqlOperator.Substring, stringToSub, startIndex, length);
        }
    }
}
