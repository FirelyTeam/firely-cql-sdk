#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System;
using Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression InValueSetPostProcess(ValueSetRef valueset, Expression expr, bool isList)
        {
            var codeType = isList ? _typeResolver.GetListElementType(expr.Type, throwError: true)! : expr.Type;

            var valueSet = InvokeDefinitionThroughRuntimeContext(valueset.name!, valueset.libraryName, typeof(CqlValueSet));
            if (codeType == _typeResolver.CodeType)
            {
                return _operatorsBinder.BindToMethod(isList ? CqlOperator.CodesInValueSet : CqlOperator.CodeInValueSet, expr, valueSet);
            }

            if (codeType == _typeResolver.ConceptType)
            {
                return _operatorsBinder.BindToMethod(isList ? CqlOperator.ConceptsInValueSet : CqlOperator.ConceptInValueSet, expr, valueSet);
            }

            if (codeType == typeof(string))
            {
                return _operatorsBinder.BindToMethod(isList ? CqlOperator.StringsInValueSet: CqlOperator.StringInValueSet, expr, valueSet);
            }

            throw new NotImplementedException().WithContext(this);
        }
    }
}
