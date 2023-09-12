#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression AllTrue(elm.AllTrue e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AllTrue, e, ctx);

        protected Expression AnyTrue(elm.AnyTrue e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AnyTrue, e, ctx);

        protected Expression Avg(elm.Avg e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Avg, e, ctx);

        protected Expression Count(elm.Count e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Count, e, ctx);

        protected Expression? GeometricMean(elm.GeometricMean e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.GeometricMean, e, ctx);

        protected Expression Max(elm.Max e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MaxElementInList, e, ctx);

        protected Expression Min(elm.Min e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MinElementInList, e, ctx);

        protected Expression? Median(elm.Median e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Median, e, ctx);

        protected Expression? Mode(elm.Mode e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Mode, e, ctx);


        protected Expression? PopulationStdDev(elm.PopulationStdDev e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationStdDev, e, ctx);

        protected Expression? PopulationVariance(elm.PopulationVariance e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationVariance, e, ctx);

        protected Expression Product(elm.Product e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Product, e, ctx);

        protected Expression? StdDev(elm.StdDev e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.StdDev, e, ctx);

        protected Expression Sum(elm.Sum e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Sum, e, ctx);

        protected Expression? Variance(elm.Variance e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Variance, e, ctx);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member