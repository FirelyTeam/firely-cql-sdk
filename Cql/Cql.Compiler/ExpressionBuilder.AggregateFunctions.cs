#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression AllTrue(elm.AllTrue e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AllTrue, e, ctx);

        private Expression AnyTrue(elm.AnyTrue e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.AnyTrue, e, ctx);

        private Expression Avg(elm.Avg e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Avg, e, ctx);

        private Expression Count(elm.Count e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Count, e, ctx);

        private Expression? GeometricMean(elm.GeometricMean e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.GeometricMean, e, ctx);

        private Expression Max(elm.Max e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MaxElementInList, e, ctx);

        private Expression Min(elm.Min e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.MinElementInList, e, ctx);

        private Expression? Median(elm.Median e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Median, e, ctx);

        private Expression? Mode(elm.Mode e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Mode, e, ctx);


        private Expression? PopulationStdDev(elm.PopulationStdDev e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationStdDev, e, ctx);

        private Expression? PopulationVariance(elm.PopulationVariance e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.PopulationVariance, e, ctx);

        private Expression Product(elm.Product e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Product, e, ctx);

        private Expression? StdDev(elm.StdDev e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.StdDev, e, ctx);

        private Expression Sum(elm.Sum e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Sum, e, ctx);

        private Expression? Variance(elm.Variance e, ExpressionBuilderContext ctx) =>
            AggregateOperator(CqlOperator.Variance, e, ctx);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member