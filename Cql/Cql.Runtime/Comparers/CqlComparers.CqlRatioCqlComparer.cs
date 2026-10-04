/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Fhir.Metrics;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// Compares two <see cref="CqlRatio"/> instances. Equality compares the numerators with each other and
    /// the denominators with each other; equivalence compares the ratios the two represent.
    /// </summary>
    /// <remarks>
    /// CQL 1.5.3, Appendix B - CQL Reference, Comparison Operators, "Equal": "For ratios, this means that
    /// the numerator and denominator must be the same, using quantity equality semantics."
    /// <para/>
    /// CQL 1.5.3, Appendix B - CQL Reference, Comparison Operators, "Equivalent": "For ratios, equivalent
    /// means that the numerator and denominator represent the same ratio (e.g. <c>1:100 ~ 10:1000</c>)."
    /// The ratio a ratio represents is its numerator divided by its denominator, so two ratios are
    /// equivalent when those quotients are equivalent quantities. A ratio that cannot be divided (a null
    /// part, a zero denominator, or units the metric service cannot divide) represents no ratio, and is
    /// equivalent to no other ratio.
    /// </remarks>
    private sealed class CqlRatioCqlComparer(
        CqlComparers quantityComparer,
        IMetricService? metricService = null) :
        CqlComparer<CqlRatio>(CqlComparerEqualsImplementation.Compare)
    {
        private CqlComparers QuantityComparer { get; } = quantityComparer ?? throw new ArgumentNullException(nameof(quantityComparer));

        private IMetricService MetricService { get; } = metricService ?? UcumConversionExtensions.Default;

        /// <summary>
        /// Two ratios with the same representation are not equal when a part is null, since a null
        /// quantity cannot be known to be the same as another.
        /// </summary>
        protected override bool DefaultEqualityImpliesEquality => false;

        /// <summary>
        /// A ratio is not equivalent to itself when it represents no ratio, such as one with a zero
        /// denominator or a null part.
        /// </summary>
        protected override bool DefaultEqualityImpliesEquivalence => false;

        /// <summary>
        /// Compares the numerators, then the denominators, using quantity comparison; equality is derived
        /// from this comparison. A part that is known to differ decides the comparison even when the other
        /// part is unknown, so that the derived equality is false rather than unknown.
        /// </summary>
        protected override int? CompareValues(
            CqlRatio x,
            CqlRatio y,
            string? precision)
        {
            var numerator = CompareParts(x.numerator, y.numerator, precision);
            var denominator = CompareParts(x.denominator, y.denominator, precision);

            return numerator switch
            {
                null => denominator is not null and not 0 ? denominator : null,
                0    => denominator,
                _    => numerator,
            };
        }

        private int? CompareParts(
            CqlQuantity? x,
            CqlQuantity? y,
            string? precision) =>
            x is null || y is null
                ? null
                : QuantityComparer.Compare(x, y, precision);

        protected override bool EquivalentValues(
            CqlRatio x,
            CqlRatio y,
            string? precision) =>
            TryDivide(x, out var left)
            && TryDivide(y, out var right)
            && QuantityComparer.Equivalent(left, right, precision);

        /// <summary>
        /// Divides the numerator of <paramref name="ratio"/> by its denominator in the way the CQL Divide
        /// operator divides quantities. This comparer cannot call that operator, since the operators are
        /// built on top of the comparer.
        /// </summary>
        private bool TryDivide(
            CqlRatio ratio,
            [NotNullWhen(true)] out CqlQuantity? quotient)
        {
            quotient = null;
            if (ratio is not
                {
                    numerator: { value: { } numeratorValue, unit: { } numeratorUnit },
                    denominator: { value: { } denominatorValue, unit: { } denominatorUnit },
                }
                || denominatorValue == 0m)
                return false;

            try
            {
                if (numeratorUnit == denominatorUnit)
                    quotient = new CqlQuantity(numeratorValue / denominatorValue, UCUMUnits.Default);
                else if (denominatorUnit == UCUMUnits.Default)
                    quotient = new CqlQuantity(numeratorValue / denominatorValue, numeratorUnit);
                else if (MetricServiceExtensions.TryDivide(
                             MetricService,
                             (numeratorValue, numeratorUnit, UcumConversionExtensions.UcumSystemUrl),
                             (denominatorValue, denominatorUnit, UcumConversionExtensions.UcumSystemUrl),
                             out var result))
                    quotient = new CqlQuantity(result!.Value.Item1, result.Value.Item2);
            }
            // Equivalence always returns true or false, so a quotient beyond the Decimal range, or a
            // metric service that does not implement division, leaves the ratio without a quotient.
            catch (Exception e) when (e is OverflowException or NotImplementedException)
            {
                quotient = null;
            }

            return quotient is not null;
        }

        /// <summary>
        /// Every ratio has the same hash code. Equality compares the parts with quantity equality, which
        /// treats the unit <c>'1'</c> as matching any unit and converts between units, so <c>1:2</c> and
        /// <c>1 'cm':2 'cm'</c> are equal ratios. That leaves no value-dependent hash two equal ratios are
        /// guaranteed to share, so all ratios hash to one bucket and the hash-based list operators
        /// (Distinct, Union, Except) compare them pairwise.
        /// </summary>
        protected override int GetHashCodeValue(CqlRatio value) =>
            typeof(CqlRatio).GetHashCode();
    }
}
