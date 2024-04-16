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

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {

        protected Expression CalculateAge(Elm.CalculateAge e)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand!);
            return _operatorsBinder.BindToMethod(CqlOperator.CalculateAge, birthDate, units);
        }

        protected Expression CalculateAgeAt(Elm.CalculateAgeAt e)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand![0]);
            var asOf = TranslateExpression(e.operand[1]); // should be "as of" argument
            return _operatorsBinder.BindToMethod(CqlOperator.CalculateAgeAt, birthDate, asOf, units);
        }


        protected Expression InValueSet(Elm.InValueSet e)
        {
            var code = TranslateExpression(e.code!);
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet));
            var codeType = code.Type;
            if (codeType == _typeResolver.CodeType)
            {
                return _operatorsBinder.BindToMethod(CqlOperator.CodeInValueSet, code, valueSet);
            }
            else if (codeType == _typeResolver.ConceptType)
            {
                return _operatorsBinder.BindToMethod(CqlOperator.ConceptInValueSet, code, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.StringInValueSet, code, valueSet);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        private Expression AnyInValueSet(Elm.AnyInValueSet e)
        {
            var codes = TranslateExpression(e.codes!);
            if (!_typeResolver.ImplementsGenericIEnumerable(codes.Type))
                throw this.NewExpressionBuildingException("Only List types are allowed for AnyInValueSet");
            var codeType = _typeResolver.GetListElementType(codes.Type, true)!;
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet));
            if (codeType == _typeResolver.CodeType)
            {
                return _operatorsBinder.BindToMethod(CqlOperator.CodesInValueSet, codes, valueSet);
            }
            else if (codeType == _typeResolver.ConceptType)
            {
                return _operatorsBinder.BindToMethod(CqlOperator.ConceptsInValueSet, codes, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.StringsInValueSet, codes, valueSet);
            }
            else throw new NotImplementedException($"AnyInValueSet not implemented for element type {TypeManager.PrettyTypeName(codeType)}").WithContext(this);

        }

        public Expression ExpandValueSet(Elm.ExpandValueSet e)
        {
            var operand = TranslateExpression(e.operand!);
            var call = CallCreateValueSetFacade(operand);
            return call;
        }
    }
}
