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
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ContextualExpressionBuilder
    {

        protected Expression CalculateAge(elm.CalculateAge e)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand!);
            return OperatorBinding.Bind(CqlOperator.CalculateAge, RuntimeContextParameter, birthDate, units);
        }

        protected Expression CalculateAgeAt(elm.CalculateAgeAt e)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand![0]);
            var asOf = TranslateExpression(e.operand[1]); // should be "as of" argument
            return OperatorBinding.Bind(CqlOperator.CalculateAgeAt, RuntimeContextParameter, birthDate, asOf, units);
        }


        protected Expression InValueSet(elm.InValueSet e)
        {
            var code = TranslateExpression(e.code!);
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet));
            var codeType = code.Type;
            if (codeType == _typeManager.Resolver.CodeType)
            {
                return OperatorBinding.Bind(CqlOperator.CodeInValueSet, RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == _typeManager.Resolver.ConceptType)
            {
                return OperatorBinding.Bind(CqlOperator.ConceptInValueSet, RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return OperatorBinding.Bind(CqlOperator.StringInValueSet, RuntimeContextParameter, code, valueSet);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        private Expression AnyInValueSet(elm.AnyInValueSet e)
        {
            var codes = TranslateExpression(e.codes!);
            if (!IsOrImplementsIEnumerableOfT(codes.Type))
                throw this.NewExpressionBuildingException("Only List types are allowed for AnyInValueSet");
            var codeType = _typeManager.Resolver.GetListElementType(codes.Type, true)!;
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet));
            if (codeType == _typeManager.Resolver.CodeType)
            {
                return OperatorBinding.Bind(CqlOperator.CodesInValueSet, RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == _typeManager.Resolver.ConceptType)
            {
                return OperatorBinding.Bind(CqlOperator.ConceptsInValueSet, RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return OperatorBinding.Bind(CqlOperator.StringsInValueSet, RuntimeContextParameter, codes, valueSet);
            }
            else throw new NotImplementedException($"AnyInValueSet not implemented for element type {TypeManager.PrettyTypeName(codeType)}").WithContext(this);

        }

        public Expression ExpandValueSet(elm.ExpandValueSet e)
        {
            var operand = TranslateExpression(e.operand!);
            var call = CallCreateValueSetFacade(operand);
            return call;
        }
    }
}
