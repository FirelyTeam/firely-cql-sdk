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
                ? NullConstantExpression.String
                : TranslateExpression(e.separator);
            return _operatorsBinder.BindToMethod(CqlOperator.Combine, source, operand);
        }

        protected Expression Indexer(Elm.Indexer e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.CharAt, left, right);
            }

            if (_typeResolver.IsListType(left.Type))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.ListElementAt, left, right);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Length(Elm.Length len)
        {
            var operand = TranslateExpression(len.operand!);
            if (_typeResolver.IsListType(operand.Type))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.ListLength, operand);
            }

            if (operand.Type == typeof(string))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.StringLength, operand);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ReplaceMatches(Elm.ReplaceMatches e)
        {
            var source = TranslateExpression(e.operand![0]!);
            var pattern = TranslateExpression(e.operand![1]!);
            var substitution = TranslateExpression(e.operand![2]!);
            return _operatorsBinder.BindToMethod(CqlOperator.ReplaceMatches, source, pattern, substitution);
        }

        protected Expression Split(Elm.Split e)
        {
            var stringToSplit = TranslateExpression(e.stringToSplit!);
            var separator = TranslateExpression(e.separator!);
            return _operatorsBinder.BindToMethod(CqlOperator.Split, stringToSplit, separator);
        }

        protected Expression? Substring(Elm.Substring e)
        {
            var stringToSub = TranslateExpression(e!.stringToSub!);
            var startIndex = TranslateExpression(e!.startIndex!);
            var length = e.length == null
                ? NullConstantExpression.Int32
                : TranslateExpression(e.length);
            return _operatorsBinder.BindToMethod(CqlOperator.Substring, stringToSub, startIndex, length);
        }
    }
}
