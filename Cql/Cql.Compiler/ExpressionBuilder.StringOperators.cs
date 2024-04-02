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
            var call = _operatorBinding.Bind(CqlOperator.Combine, LibraryDefinitionsBuilder.ContextParameter, source, operand);
            return call;
        }

        protected Expression Concatenate(Elm.Concatenate e) =>
            NaryOperator(CqlOperator.Concatenate, e);

        protected Expression? EndsWith(Elm.EndsWith e) =>
            BinaryOperator(CqlOperator.EndsWith, e);

        protected Expression Indexer(Elm.Indexer e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return _operatorBinding.Bind(CqlOperator.CharAt, LibraryDefinitionsBuilder.ContextParameter, left, right);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ElementAt, LibraryDefinitionsBuilder.ContextParameter, left, right);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? LastPositionOf(Elm.LastPositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            return _operatorBinding.Bind(CqlOperator.LastPositionOf, LibraryDefinitionsBuilder.ContextParameter, @string, pattern);
        }

        protected Expression? Length(Elm.Length len)
        {
            var operand = TranslateExpression(len.operand!);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListLength, LibraryDefinitionsBuilder.ContextParameter, operand);
            }
            else if (operand.Type == typeof(string))
            {
                return _operatorBinding.Bind(CqlOperator.StringLength, LibraryDefinitionsBuilder.ContextParameter, operand);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Lower(Elm.Lower e) =>
            UnaryOperator(CqlOperator.Lower, e);

        protected Expression? Matches(Elm.Matches e) =>
            BinaryOperator(CqlOperator.Matches, e);

        protected Expression PositionOf(Elm.PositionOf e)
        {
            var @string = TranslateExpression(e!.@string!);
            var pattern = TranslateExpression(e!.pattern!);
            return _operatorBinding.Bind(CqlOperator.PositionOf, LibraryDefinitionsBuilder.ContextParameter, pattern, @string);

        }

        protected Expression? ReplaceMatches(Elm.ReplaceMatches e)
        {
            var source = TranslateExpression(e.operand![0]!);
            var pattern = TranslateExpression(e.operand![1]!);
            var substitution = TranslateExpression(e.operand![2]!);
            return _operatorBinding.Bind(CqlOperator.ReplaceMatches, LibraryDefinitionsBuilder.ContextParameter, source, pattern, substitution);
        }

        protected Expression Split(Elm.Split e)
        {
            var stringToSplit = TranslateExpression(e.stringToSplit!);
            var separator = TranslateExpression(e.separator!);
            return _operatorBinding.Bind(CqlOperator.Split, LibraryDefinitionsBuilder.ContextParameter, stringToSplit, separator);
        }

        protected Expression? StartsWith(Elm.StartsWith e) =>
            BinaryOperator(CqlOperator.StartsWith, e);

        protected Expression? Substring(Elm.Substring e)
        {
            var stringToSub = TranslateExpression(e!.stringToSub!);
            var startIndex = TranslateExpression(e!.startIndex!);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(e.length);
            return _operatorBinding.Bind(CqlOperator.Substring, LibraryDefinitionsBuilder.ContextParameter, stringToSub, startIndex, length);
        }

        protected Expression? Upper(Elm.Upper e) =>
            UnaryOperator(CqlOperator.Upper, e);
    }
}
