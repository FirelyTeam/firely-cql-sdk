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
        protected Expression IndexOf(Elm.IndexOf e)
        {
            var source = TranslateExpression(e.source!);
            var element = TranslateExpression(e.element!);
            if (!_typeResolver.ImplementsGenericIEnumerable(source.Type))
                throw new NotImplementedException().WithContext(this);

            return _operatorsBinder.BindToMethod(CqlOperator.ListIndexOf, source, element);
        }

        private Expression? Slice(Elm.Slice slice)
        {
            var source = TranslateExpression(slice.source!);
            var start = slice.startIndex == null || slice.startIndex is Elm.Null
                ? CqlExpressions.Null_ConstantExpression<int?>()
                : TranslateExpression(slice.startIndex!);
            var end = slice.endIndex == null || slice.endIndex is Elm.Null
                ? CqlExpressions.Null_ConstantExpression<int?>()
                : TranslateExpression(slice.endIndex!);
            if (!_typeResolver.ImplementsGenericIEnumerable(source.Type))
                throw new NotImplementedException().WithContext(this);

            return _operatorsBinder.BindToMethod(CqlOperator.Slice, source, start, end);
        }
    }
}
