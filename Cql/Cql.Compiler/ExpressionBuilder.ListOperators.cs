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
        protected Expression? Distinct(Elm.Distinct e) =>
            UnaryOperator(CqlOperator.Distinct, e);

        protected Expression Exists(Elm.Exists e) =>
            UnaryOperator(CqlOperator.Exists, e);

        protected Expression Flatten(Elm.Flatten e) =>
            UnaryOperator(CqlOperator.Flatten, e);

        protected Expression First(Elm.First e)
        {
            var operand = TranslateExpression(e.source!);
            var call = _operatorBinding.Bind(CqlOperator.First, LibraryDefinitionsBuilder.ContextParameter, operand);
            return call;
        }

        protected Expression IndexOf(Elm.IndexOf e)
        {
            var source = TranslateExpression(e.source!);
            var element = TranslateExpression(e.element!);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListIndexOf, LibraryDefinitionsBuilder.ContextParameter, source, element);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Last(Elm.Last e)
        {
            var operand = TranslateExpression(e.source!);
            var call = _operatorBinding.Bind(CqlOperator.Last, LibraryDefinitionsBuilder.ContextParameter, operand);
            return call;
        }

        private Expression SingletonFrom(Elm.SingletonFrom e) =>
            UnaryOperator(CqlOperator.Single, e);


        private Expression? Slice(Elm.Slice slice)
        {
            var source = TranslateExpression(slice.source!);
            var start = slice.startIndex == null || slice.startIndex is Elm.Null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.startIndex!);
            var end = slice.endIndex == null || slice.endIndex is Elm.Null
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.endIndex!);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return _operatorBinding.Bind(CqlOperator.Slice, LibraryDefinitionsBuilder.ContextParameter, source, start, end);
            }
            throw new NotImplementedException().WithContext(this);
        }
    }
}
