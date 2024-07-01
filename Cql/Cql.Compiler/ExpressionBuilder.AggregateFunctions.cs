#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Abstractions;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression AllTrue(Elm.AllTrue e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AllTrue, e, ctx);

        protected Expression AnyTrue(Elm.AnyTrue e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AnyTrue, e, ctx);

        protected Expression Avg(Elm.Avg e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Avg, e, ctx);

        protected Expression Count(Elm.Count e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Count, e, ctx);

        protected Expression? GeometricMean(Elm.GeometricMean e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.GeometricMean, e, ctx);

        protected Expression Max(Elm.Max e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MaxElementInList, e, ctx);

        protected Expression Min(Elm.Min e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MinElementInList, e, ctx);

        protected Expression? Median(Elm.Median e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Median, e, ctx);

        protected Expression? Mode(Elm.Mode e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Mode, e, ctx);


        protected Expression? PopulationStdDev(Elm.PopulationStdDev e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationStdDev, e, ctx);

        protected Expression? PopulationVariance(Elm.PopulationVariance e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationVariance, e, ctx);

        protected Expression Product(Elm.Product e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Product, e, ctx);

        protected Expression? StdDev(Elm.StdDev e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.StdDev, e, ctx);

        protected Expression Sum(Elm.Sum e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Sum, e, ctx);

        protected Expression? Variance(Elm.Variance e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Variance, e, ctx);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member