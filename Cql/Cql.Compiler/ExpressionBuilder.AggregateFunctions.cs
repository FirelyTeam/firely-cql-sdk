#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression AllTrue(elm.AllTrue e) =>
            AggregateOperator(CqlOperator.AllTrue, e);

        protected Expression AnyTrue(elm.AnyTrue e) =>
            AggregateOperator(CqlOperator.AnyTrue, e);

        protected Expression Avg(elm.Avg e) =>
            AggregateOperator(CqlOperator.Avg, e);

        protected Expression Count(elm.Count e) =>
            AggregateOperator(CqlOperator.Count, e);

        protected Expression? GeometricMean(elm.GeometricMean e) =>
            AggregateOperator(CqlOperator.GeometricMean, e);

        protected Expression Max(elm.Max e) =>
            AggregateOperator(CqlOperator.MaxElementInList, e);

        protected Expression Min(elm.Min e) =>
            AggregateOperator(CqlOperator.MinElementInList, e);

        protected Expression? Median(elm.Median e) =>
            AggregateOperator(CqlOperator.Median, e);

        protected Expression? Mode(elm.Mode e) =>
            AggregateOperator(CqlOperator.Mode, e);


        protected Expression? PopulationStdDev(elm.PopulationStdDev e) =>
            AggregateOperator(CqlOperator.PopulationStdDev, e);

        protected Expression? PopulationVariance(elm.PopulationVariance e) =>
            AggregateOperator(CqlOperator.PopulationVariance, e);

        protected Expression Product(elm.Product e) =>
            AggregateOperator(CqlOperator.Product, e);

        protected Expression? StdDev(elm.StdDev e) =>
            AggregateOperator(CqlOperator.StdDev, e);

        protected Expression Sum(elm.Sum e) =>
            AggregateOperator(CqlOperator.Sum, e);

        protected Expression? Variance(elm.Variance e) =>
            AggregateOperator(CqlOperator.Variance, e);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member