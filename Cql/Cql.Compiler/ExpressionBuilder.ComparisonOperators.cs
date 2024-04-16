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
        protected Expression Equivalent(Elm.Equivalent eqv)
        {
            var left = TranslateExpression(eqv.operand![0]);
            var right = TranslateExpression(eqv.operand![1]);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var leftElementType = _typeResolver.GetListElementType(left.Type);
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    var rightElementType = _typeResolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                    {
                        // This appears in the CQL tests:
                        //  { 'a', 'b', 'c' } ~ { 1, 2, 3 } = false
                        return Expression.Constant(false, typeof(bool?));
                    }

                    return _operatorsBinder.BindToMethod(CqlOperator.ListEquivalent, left, right);
                }
                else
                {
                    throw new NotImplementedException().WithContext(this);
                }
            }
            else
            {
                return _operatorsBinder.BindToMethod(CqlOperator.Equivalent, left, right);
            }
        }
    }
}
