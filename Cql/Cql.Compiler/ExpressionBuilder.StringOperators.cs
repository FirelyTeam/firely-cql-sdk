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
            Expression[] parameters = new[] { source, operand };
            var call = _operatorBinding.Bind(CqlOperator.Combine, parameters);
            return call;
        }

        protected Expression Indexer(Elm.Indexer e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                Expression[] parameters = new[] { left, right };
                return _operatorBinding.Bind(CqlOperator.CharAt, parameters);
            }
            else if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                Expression[] parameters = new[] { left, right };
                return _operatorBinding.Bind(CqlOperator.ListElementAt, parameters);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? LastPositionOf(Elm.LastPositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            Expression[] parameters = new[] { @string, pattern };
            return _operatorBinding.Bind(CqlOperator.LastPositionOf, parameters);
        }

        protected Expression? Length(Elm.Length len)
        {
            var operand = TranslateExpression(len.operand!);
            if (_typeResolver.ImplementsGenericIEnumerable(operand.Type))
            {
                Expression[] parameters = new[] { operand };
                return _operatorBinding.Bind(CqlOperator.ListLength, parameters);
            }
            else if (operand.Type == typeof(string))
            {
                Expression[] parameters = new[] { operand };
                return _operatorBinding.Bind(CqlOperator.StringLength, parameters);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression PositionOf(Elm.PositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            Expression[] parameters = new[] { pattern, @string };
            return _operatorBinding.Bind(CqlOperator.PositionOf, parameters);

        }

        protected Expression? ReplaceMatches(Elm.ReplaceMatches e)
        {
            var source = TranslateExpression(e.operand![0]!);
            var pattern = TranslateExpression(e.operand![1]!);
            var substitution = TranslateExpression(e.operand![2]!);
            Expression[] parameters = new[] { source, pattern, substitution };
            return _operatorBinding.Bind(CqlOperator.ReplaceMatches, parameters);
        }

        protected Expression Split(Elm.Split e)
        {
            var stringToSplit = TranslateExpression(e.stringToSplit!);
            var separator = TranslateExpression(e.separator!);
            Expression[] parameters = new[] { stringToSplit, separator };
            return _operatorBinding.Bind(CqlOperator.Split, parameters);
        }

        protected Expression? Substring(Elm.Substring e)
        {
            var stringToSub = TranslateExpression(e!.stringToSub!);
            var startIndex = TranslateExpression(e!.startIndex!);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(e.length);
            Expression[] parameters = new[] { stringToSub, startIndex, length };
            return _operatorBinding.Bind(CqlOperator.Substring, parameters);
        }
    }
}
