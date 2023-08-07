﻿using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using System.Xml;

namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {

        protected Expression CalculateAge(elm.CalculateAge e, ExpressionBuilderContext ctx)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand!, ctx);
            return OperatorBinding.Bind(CqlOperator.CalculateAge, ctx.RuntimeContextParameter, birthDate, units);
        }

        protected Expression CalculateAgeAt(elm.CalculateAgeAt e, ExpressionBuilderContext ctx)
        {
            var units = Precision(e.precision, e.precisionSpecified);
            var birthDate = TranslateExpression(e.operand![0], ctx);
            var asOf = TranslateExpression(e.operand[1], ctx); // should be "as of" argument
            return OperatorBinding.Bind(CqlOperator.CalculateAgeAt, ctx.RuntimeContextParameter, birthDate, asOf, units);
        }


        protected Expression InValueSet(elm.InValueSet e, ExpressionBuilderContext ctx)
        {
            var code = TranslateExpression(e.code!, ctx);
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet), ctx);
            var codeType = code.Type;
            if (codeType == TypeResolver.CodeType)
            {
                return OperatorBinding.Bind(CqlOperator.CodeInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == TypeResolver.ConceptType)
            {
                return OperatorBinding.Bind(CqlOperator.ConceptInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return OperatorBinding.Bind(CqlOperator.StringInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else throw new NotImplementedException();
        }

        private Expression AnyInValueSet(elm.AnyInValueSet e, ExpressionBuilderContext ctx)
        {
            var codes = TranslateExpression(e.codes!, ctx);
            if (!IsOrImplementsIEnumerableOfT(codes.Type))
                throw new ArgumentException("Only List types are allowed for AnyInValueSet", nameof(e));
            var codeType = TypeResolver.GetListElementType(codes.Type, true)!;
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet), ctx);
            if (codeType == TypeResolver.CodeType)
            {
                return OperatorBinding.Bind(CqlOperator.CodesInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == TypeResolver.ConceptType)
            {
                return OperatorBinding.Bind(CqlOperator.ConceptsInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return OperatorBinding.Bind(CqlOperator.StringsInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else throw new NotImplementedException($"AnyInValueSet not implemented for element type {TypeManager.PrettyTypeName(codeType)}");

        }

        public Expression ExpandValueSet(elm.ExpandValueSet e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            var ctor = typeof(ValueSetFacade).GetConstructor(new[] { typeof(CqlValueSet), typeof(IValueSetDictionary) });
            var operatorsProperty = typeof(CqlContext).GetProperty(nameof(CqlContext.Operators));
            var createFacadeMethod = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.CreateValueSetFacade));
            var property = Expression.Property(ctx.RuntimeContextParameter, operatorsProperty);
            var call = Expression.Call(property, createFacadeMethod, operand);
            return call;
        }
    }
}
