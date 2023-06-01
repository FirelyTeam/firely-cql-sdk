using System.Linq.Expressions;
using elm = Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {
        protected Expression AllTrue(elm.AllTrueExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AllTrue, e, ctx);

        protected Expression AnyTrue(elm.AnyTrueExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AnyTrue, e, ctx);

        protected Expression Avg(elm.AvgExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Avg, e, ctx);

        protected Expression Count(elm.CountExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Count, e, ctx);

        protected Expression? GeometricMean(elm.GeometricMeanExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.GeometricMean, e, ctx);

        protected Expression Max(elm.MaxExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MaxElementInList, e, ctx);

        protected Expression Min(elm.MinExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MinElementInList, e, ctx);

        protected Expression? Median(elm.MedianExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Median, e, ctx);

        protected Expression? Mode(elm.ModeExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Mode, e, ctx);


        protected Expression? PopulationStdDev(elm.PopulationStdDevExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationStdDev, e, ctx);

        protected Expression? PopulationVariance(elm.PopulationVarianceExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationVariance, e, ctx);

        protected Expression Product(elm.ProductExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Product, e, ctx);

        protected Expression? StdDev(elm.StdDevExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.StdDev, e, ctx);

        protected Expression Sum(elm.SumExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Sum, e, ctx);

        protected Expression? Variance(elm.VarianceExpression e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Variance, e, ctx);
    }
}
