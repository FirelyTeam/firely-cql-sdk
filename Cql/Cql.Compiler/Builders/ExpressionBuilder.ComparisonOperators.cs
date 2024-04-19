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

namespace Hl7.Cql.Compiler.Builders;

partial class ExpressionBuilderContext
{
    protected Expression Equivalent(Elm.Equivalent eqv)
    {
        var left = Translate(eqv.operand[0]);
        var right = Translate(eqv.operand[1]);
        if (!_typeResolver.IsListType(left.Type))
            return BindCqlOperator(CqlOperator.Equivalent, null, left, right);

        var leftElementType = _typeResolver.GetListElementType(left.Type);
        if (!_typeResolver.IsListType(right.Type))
            throw new NotImplementedException().WithContext(this);

        var rightElementType = _typeResolver.GetListElementType(right.Type);
        if (leftElementType != rightElementType)
        {
            // This appears in the CQL tests:
            //  { 'a', 'b', 'c' } ~ { 1, 2, 3 } = false
            return Expression.Constant(false, typeof(bool?));
        }

        return BindCqlOperator(CqlOperator.ListEquivalent, null, left, right);
    }
}