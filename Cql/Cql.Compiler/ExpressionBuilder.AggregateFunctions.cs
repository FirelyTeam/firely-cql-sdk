#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Abstractions;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression AllTrue(Elm.AllTrue e) =>
            AggregateOperator(CqlOperator.AllTrue, e);

        protected Expression AnyTrue(Elm.AnyTrue e) =>
            AggregateOperator(CqlOperator.AnyTrue, e);

        protected Expression Avg(Elm.Avg e) =>
            AggregateOperator(CqlOperator.Avg, e);

        protected Expression Count(Elm.Count e) =>
            AggregateOperator(CqlOperator.Count, e);

        protected Expression? GeometricMean(Elm.GeometricMean e) =>
            AggregateOperator(CqlOperator.GeometricMean, e);

        protected Expression Max(Elm.Max e) =>
            AggregateOperator(CqlOperator.MaxElementInList, e);

        protected Expression Min(Elm.Min e) =>
            AggregateOperator(CqlOperator.MinElementInList, e);

        protected Expression? Median(Elm.Median e) =>
            AggregateOperator(CqlOperator.Median, e);

        protected Expression? Mode(Elm.Mode e) =>
            AggregateOperator(CqlOperator.Mode, e);


        protected Expression? PopulationStdDev(Elm.PopulationStdDev e) =>
            AggregateOperator(CqlOperator.PopulationStdDev, e);

        protected Expression? PopulationVariance(Elm.PopulationVariance e) =>
            AggregateOperator(CqlOperator.PopulationVariance, e);

        protected Expression Product(Elm.Product e) =>
            AggregateOperator(CqlOperator.Product, e);

        protected Expression? StdDev(Elm.StdDev e) =>
            AggregateOperator(CqlOperator.StdDev, e);

        protected Expression Sum(Elm.Sum e) =>
            AggregateOperator(CqlOperator.Sum, e);

        protected Expression? Variance(Elm.Variance e) =>
            AggregateOperator(CqlOperator.Variance, e);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member