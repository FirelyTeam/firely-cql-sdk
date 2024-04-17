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
            var source = Translate(e.source!);
            var operand = e.separator == null
                ? NullConstantExpression.String
                : Translate(e.separator);
            return BindCqlOperator(CqlOperator.Combine, source, operand);
        }

        protected Expression Indexer(Elm.Indexer e)
        {
            var left = Translate(e!.operand![0]!);
            var right = Translate(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return BindCqlOperator(CqlOperator.CharAt, left, right);
            }

            if (_typeResolver.IsListType(left.Type))
            {
                return BindCqlOperator(CqlOperator.ListElementAt, left, right);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Length(Elm.Length len)
        {
            var operand = Translate(len.operand!);
            if (_typeResolver.IsListType(operand.Type))
            {
                return BindCqlOperator(CqlOperator.ListLength, operand);
            }

            if (operand.Type == typeof(string))
            {
                return BindCqlOperator(CqlOperator.StringLength, operand);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ReplaceMatches(Elm.ReplaceMatches e)
        {
            var source = Translate(e.operand![0]!);
            var pattern = Translate(e.operand![1]!);
            var substitution = Translate(e.operand![2]!);
            return BindCqlOperator(CqlOperator.ReplaceMatches, source, pattern, substitution);
        }

        protected Expression Split(Elm.Split e)
        {
            var stringToSplit = Translate(e.stringToSplit!);
            var separator = Translate(e.separator!);
            return BindCqlOperator(CqlOperator.Split, stringToSplit, separator);
        }

        protected Expression? Substring(Elm.Substring e)
        {
            var stringToSub = Translate(e!.stringToSub!);
            var startIndex = Translate(e!.startIndex!);
            var length = e.length == null
                ? NullConstantExpression.Int32
                : Translate(e.length);
            return BindCqlOperator(CqlOperator.Substring, stringToSub, startIndex, length);
        }
    }
}
