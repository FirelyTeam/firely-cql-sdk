using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {
        protected Expression? Distinct(elm.DistinctExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Distinct, e, ctx);

        protected Expression Exists(elm.ExistsExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Exists, e, ctx);

        protected Expression Flatten(elm.FlattenExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Flatten, e, ctx);

        protected Expression First(elm.FirstExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.First, e, ctx);

        protected Expression IndexOf(elm.IndexOfExpression e, ExpressionBuilderContext ctx)
        {
            //public static int? IndexOf<T>(IEnumerable<T>? list, T element)
            var source = TranslateExpression(e.source!, ctx);
            var element = TranslateExpression(e.element!, ctx);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return Operators.Bind(CqlOperator.IndexOf, ctx.RuntimeContextParameter, source, element);
            }
            throw new NotImplementedException();
        }

        protected Expression Last(elm.LastExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Last, e, ctx);

        private Expression SingletonFrom(elm.SingletonFromExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Single, e, ctx);


        private Expression? Slice(elm.SliceExpression slice, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(slice.source!, ctx);
            var start = slice.startIndex == null || slice.startIndex is elm.NullExpression
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.startIndex!, ctx);
            var end = slice.endIndex == null || slice.endIndex is elm.NullExpression
                ? Expression.Constant(null, typeof(int?))
                : TranslateExpression(slice.endIndex!, ctx);
            if (IsOrImplementsIEnumerableOfT(source.Type))
            {
                return Operators.Bind(CqlOperator.Slice, ctx.RuntimeContextParameter, source, start, end);
            }
            throw new NotImplementedException();
        }

        private Expression Tail(elm.TailExpression e, ExpressionBuilderContext ctx) =>
             AggregateOperator(CqlOperator.Tail, e, ctx);
     
    }
}
