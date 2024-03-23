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
    internal partial class ExpressionBuilderContext
    {

        protected Expression CalculateAge(elm.CalculateAge e)
        {
            ExpressionBuilderContext ctx = this;
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = ctx.TranslateExpression(e.operand!);
            return ctx.OperatorBinding.Bind(CqlOperator.CalculateAge, ctx.RuntimeContextParameter, birthDate, units);
        }

        protected Expression CalculateAgeAt(elm.CalculateAgeAt e)
        {
            ExpressionBuilderContext ctx = this;
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = ctx.TranslateExpression(e.operand![0]);
            var asOf = ctx.TranslateExpression(e.operand[1]); // should be "as of" argument
            return ctx.OperatorBinding.Bind(CqlOperator.CalculateAgeAt, ctx.RuntimeContextParameter, birthDate, asOf, units);
        }


        protected Expression InValueSet(elm.InValueSet e)
        {
            ExpressionBuilderContext ctx = this;
            var code = ctx.TranslateExpression(e.code!);
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet));
            var codeType = code.Type;
            if (codeType == _typeManager.Resolver.CodeType)
            {
                return ctx.OperatorBinding.Bind(CqlOperator.CodeInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == _typeManager.Resolver.ConceptType)
            {
                return ctx.OperatorBinding.Bind(CqlOperator.ConceptInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.StringInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else throw new NotImplementedException().WithContext(ctx);
        }

        private Expression AnyInValueSet(elm.AnyInValueSet e)
        {
            ExpressionBuilderContext ctx = this;
            var codes = ctx.TranslateExpression(e.codes!);
            if (!IsOrImplementsIEnumerableOfT(codes.Type))
                throw ctx.NewExpressionBuildingException("Only List types are allowed for AnyInValueSet");
            var codeType = _typeManager.Resolver.GetListElementType(codes.Type, true)!;
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet));
            if (codeType == _typeManager.Resolver.CodeType)
            {
                return ctx.OperatorBinding.Bind(CqlOperator.CodesInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == _typeManager.Resolver.ConceptType)
            {
                return ctx.OperatorBinding.Bind(CqlOperator.ConceptsInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.StringsInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else throw new NotImplementedException($"AnyInValueSet not implemented for element type {TypeManager.PrettyTypeName(codeType)}").WithContext(ctx);

        }

        public Expression ExpandValueSet(elm.ExpandValueSet e)
        {
            ExpressionBuilderContext ctx = this;
            var operand = ctx.TranslateExpression(e.operand!);
            var call = ctx.CallCreateValueSetFacade(operand);
            return call;
        }
    }
}
