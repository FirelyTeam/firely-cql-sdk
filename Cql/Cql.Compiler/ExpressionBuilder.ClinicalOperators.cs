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
    internal partial class ExpressionBuilder
    {

        protected Expression CalculateAge(elm.CalculateAge e)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand!);
            return _operatorBinding.Bind(CqlOperator.CalculateAge, LibraryDefinitionsBuilder.ContextParameter, birthDate, units);
        }

        protected Expression CalculateAgeAt(elm.CalculateAgeAt e)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand![0]);
            var asOf = TranslateExpression(e.operand[1]); // should be "as of" argument
            return _operatorBinding.Bind(CqlOperator.CalculateAgeAt, LibraryDefinitionsBuilder.ContextParameter, birthDate, asOf, units);
        }


        protected Expression InValueSet(elm.InValueSet e)
        {
            var code = TranslateExpression(e.code!);
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet));
            var codeType = code.Type;
            if (codeType == _typeManager.Resolver.CodeType)
            {
                return _operatorBinding.Bind(CqlOperator.CodeInValueSet, LibraryDefinitionsBuilder.ContextParameter, code, valueSet);
            }
            else if (codeType == _typeManager.Resolver.ConceptType)
            {
                return _operatorBinding.Bind(CqlOperator.ConceptInValueSet, LibraryDefinitionsBuilder.ContextParameter, code, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return _operatorBinding.Bind(CqlOperator.StringInValueSet, LibraryDefinitionsBuilder.ContextParameter, code, valueSet);
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
                return _operatorBinding.Bind(CqlOperator.CodesInValueSet, LibraryDefinitionsBuilder.ContextParameter, codes, valueSet);
            }
            else if (codeType == _typeManager.Resolver.ConceptType)
            {
                return _operatorBinding.Bind(CqlOperator.ConceptsInValueSet, LibraryDefinitionsBuilder.ContextParameter, codes, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return _operatorBinding.Bind(CqlOperator.StringsInValueSet, LibraryDefinitionsBuilder.ContextParameter, codes, valueSet);
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
