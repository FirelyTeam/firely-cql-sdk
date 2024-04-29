/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Expressions;

namespace Hl7.Cql.Compiler
{
    partial class ExpressionBuilderContext
    {
        protected Expression? Combine(Elm.Combine e)
        {
            var source = Translate(e.source!);
            var operand = e.separator == null
                              ? NullExpression.String
                              : Translate(e.separator);
            return BindCqlOperator(CqlOperator.Combine, null, source, operand);
        }

        protected Expression Indexer(Elm.Indexer e)
        {
            var left = Translate(e!.operand![0]!);
            var right = Translate(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return BindCqlOperator(CqlOperator.CharAt, null, left, right);
            }

            if (_typeResolver.IsListType(left.Type))
            {
                return BindCqlOperator(CqlOperator.ListElementAt, null, left, right);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Length(Elm.Length len)
        {
            var operand = Translate(len.operand!);
            if (_typeResolver.IsListType(operand.Type))
            {
                return BindCqlOperator(CqlOperator.ListLength, null, operand);
            }

            if (operand.Type == typeof(string))
            {
                return BindCqlOperator(CqlOperator.StringLength, null, operand);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ReplaceMatches(Elm.ReplaceMatches e)
        {
            var source = Translate(e.operand![0]!);
            var pattern = Translate(e.operand![1]!);
            var substitution = Translate(e.operand![2]!);
            return BindCqlOperator(CqlOperator.ReplaceMatches, null, source, pattern, substitution);
        }

        protected Expression Split(Elm.Split e)
        {
            var stringToSplit = Translate(e.stringToSplit!);
            var separator = Translate(e.separator!);
            return BindCqlOperator(CqlOperator.Split, null, stringToSplit, separator);
        }

        protected Expression? Substring(Elm.Substring e)
        {
            var stringToSub = Translate(e!.stringToSub!);
            var startIndex = Translate(e!.startIndex!);
            var length = e.length == null
                             ? NullExpression.Int32
                             : Translate(e.length);
            return BindCqlOperator(CqlOperator.Substring, null, stringToSub, startIndex, length);
        }
    }
}