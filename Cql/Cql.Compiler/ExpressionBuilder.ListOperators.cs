#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
        protected Expression IndexOf(Elm.IndexOf e)
        {
            var source = Translate(e.source!);
            var element = Translate(e.element!);
            if (!_typeResolver.IsListType(source.Type))
                throw new NotImplementedException().WithContext(this);

            return BindCqlOperator(CqlOperator.ListIndexOf, null, source, element);
        }

        private Expression? Slice(Elm.Slice slice)
        {
            var source = Translate(slice.source!);
            var start = slice.startIndex == null || slice.startIndex is Elm.Null
                            ? NullExpression.Int32
                            : Translate(slice.startIndex!);
            var end = slice.endIndex == null || slice.endIndex is Elm.Null
                          ? NullExpression.Int32
                          : Translate(slice.endIndex!);
            if (!_typeResolver.IsListType(source.Type))
                throw new NotImplementedException().WithContext(this);

            return BindCqlOperator(CqlOperator.Slice, null, source, start, end);
        }
    }
}