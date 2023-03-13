using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Linq.Expressions;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public partial class ExpressionBuilder
    {

        protected Expression CalculateAge(elm.CalculateAgeExpression e, ExpressionBuilderContext ctx)
        {
            var units = Expression.Constant(e.precision, typeof(string));
            var birthDate = TranslateExpression(e.operand!, ctx);
            return Operators.Bind(CqlOperator.CalculateAge, ctx.RuntimeContextParameter, birthDate, units);
        }

        protected Expression CalculateAgeAt(elm.CalculateAgeAtExpression e, ExpressionBuilderContext ctx)
        {
            var units = Expression.Constant(e.precision, typeof(string));
            var birthDate = TranslateExpression(e.operand![0], ctx);
            var asOf = TranslateExpression(e.operand[1], ctx); // should be "as of" argument
            return Operators.Bind(CqlOperator.CalculateAgeAt, ctx.RuntimeContextParameter, birthDate, asOf, units);
        }


        protected Expression InValueSet(elm.InValueSetExpression e, ExpressionBuilderContext ctx)
        {
            var code = TranslateExpression(e.code!, ctx);
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet), ctx);
            var codeType = code.Type;
            if (codeType == TypeResolver.CodeType)
            {
                return Operators.Bind(CqlOperator.CodeInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == TypeResolver.ConceptType)
            {
                return Operators.Bind(CqlOperator.ConceptInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return Operators.Bind(CqlOperator.StringInValueSet, ctx.RuntimeContextParameter, code, valueSet);
            }
            else throw new NotImplementedException();
        }

        private Expression AnyInValueSet(elm.AnyInValueSetExpression e, ExpressionBuilderContext ctx)
        {
            var codes = TranslateExpression(e.codes!, ctx);
            if (!IsOrImplementsIEnumerableOfT(codes.Type))
                throw new ArgumentException("Only List types are allowed for AnyInValueSet", nameof(e));
            var codeType = TypeResolver.GetElementType(codes.Type, true)!;
            var valueSet = InvokeDefinitionThroughRuntimeContext(e.valueset!.name!, e.valueset.libraryName, typeof(CqlValueSet), ctx);
            if (codeType == TypeResolver.CodeType)
            {
                return Operators.Bind(CqlOperator.CodesInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == TypeResolver.ConceptType)
            {
                return Operators.Bind(CqlOperator.ConceptsInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else if (codeType == typeof(string))
            {
                return Operators.Bind(CqlOperator.StringsInValueSet, ctx.RuntimeContextParameter, codes, valueSet);
            }
            else throw new NotImplementedException($"AnyInValueSet not implemented for element type {TypeManager.PrettyTypeName(codeType)}");

        }

        public Expression ExpandValueSet(elm.ExpandValueSetExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            var ctor = typeof(ValueSetFacade).GetConstructor(new[] { typeof(CqlValueSet), typeof(RuntimeContext) });
            var @new = Expression.New(ctor, operand, ctx.RuntimeContextParameter);
            return @new;
        }

    }
}
