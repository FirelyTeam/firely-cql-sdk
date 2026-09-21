/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Fhir.Metrics;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// A comparer that compares two <see cref="CqlQuantity"/> instances, possibly by normalizing their values
    /// using the UCUM system.
    /// </summary>
    private class CqlQuantityCqlComparer(
        CqlComparers valueComparer,
        ICqlComparer<string> unitComparer,
        IMetricService? metricService = null) :
        CqlComparer<CqlQuantity>(CqlComparerEqualsImplementation.Compare)
    {
        private CqlComparers ValueComparer { get; } = valueComparer ?? throw new ArgumentNullException(nameof(valueComparer));

        private ICqlComparer<string> UnitComparer { get; } = unitComparer ?? throw new ArgumentNullException(nameof(unitComparer));

        private IMetricService MetricService { get; } = metricService ?? UcumConversionExtensions.Default;

        protected override int? CompareValues(
            CqlQuantity x,
            CqlQuantity y,
            string? precision)
        {
            var unitCompare = UnitComparer.Compare(x.unit, y.unit, precision);
            if (unitCompare == 0 || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = ValueComparer.Compare(x.value, y.value, precision);
                return valueComparison;
            }

            // Redo the comparison with both quantities brought into one common unit. That unit is the
            // finer of the two operand units rather than the canonical base unit: canonicalizing
            // rescales the values, and for a clinical unit far from its base it pushes them below the
            // step size of a CQL Decimal (0.25 'mg/d' canonicalizes to 0.0000000028935185 'g.s-1'),
            // where the Decimal comparer's 8-digit quantization answers 0 for every pair. See
            // UcumConversionExtensions.TryAlignUnits, which also establishes commensurability.
            if (x.TryAlignUnits(y, MetricService, out var left1, out var right1))
            {
                var valueComparison = ValueComparer.Compare(left1!.value!, right1!.value!, precision);
                return valueComparison;
            }

            // Spec §9.B, stated identically for Equal, Less, Greater, LessOrEqual, GreaterOrEqual
            // and between: "For comparisons involving quantities, the dimensions of each quantity
            // must be the same, but not necessarily the unit. [...] Attempting to operate on
            // quantities with invalid units will result in a null." Units that do not reduce to a
            // shared base unit -- incommensurable ('cm' vs 'g') or not valid UCUM at all -- make
            // the comparison unknown, not an error: real measure logic compares dirty clinical
            // data (a '%' against a '/min'), which must degrade to null rather than abort the
            // evaluation of the whole define.
            return null;
        }

        protected override bool EquivalentValues(
            CqlQuantity x,
            CqlQuantity y,
            string? precision)
        {
            var unitCompare = UnitComparer.Equivalent(x!.unit, y!.unit, precision);
            if (unitCompare || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = ValueComparer.Equivalent(x.value, y.value, precision);
                return valueComparison;
            }

            // Spec §9.B: quantity equivalence considers unit conversion, so bring both quantities into
            // one common unit and redo the comparison. Equivalence rounds to the precision of the
            // least precise operand, which makes the choice of that unit matter even more than it does
            // for CompareValues -- rounding two canonical values that both sit below 1e-8 makes every
            // pair of clinical quantities equivalent. The units must be commensurable for the same
            // reason they must in CompareValues, but where that method answers null, equivalence never
            // may -- it "will always return true or false": units that cannot be canonicalized, or that
            // canonicalize to different base metrics (incommensurable), are simply not equivalent
            // (spec example: 3.5 'cm2' ~ 3.5 'cm' is false).
            if (x.TryAlignUnits(y, MetricService, out var left1, out var right1))
            {
                var valueComparison = ValueComparer.Equivalent(left1!.value, right1!.value, precision);
                return valueComparison;
            }

            return false;
        }

        /// <summary>
        /// Every quantity hashes to the same bucket, which is what the <see cref="IEqualityComparer{T}"/>
        /// contract - equal values hash alike - reduces to for an equality relation that is not
        /// transitive.
        /// </summary>
        /// <remarks>
        /// Quantity equality here is not transitive, in three independent ways, and none of them can be
        /// bucketed around:
        /// <list type="bullet">
        /// <item>the <c>'1'</c> unit matches any other unit, so <c>(1, '1')</c> equals both
        /// <c>(1, 'cm')</c> and <c>(1, 'g')</c> while those two are not equal to each other;</item>
        /// <item>values are compared truncated to the CQL Decimal scale in the finer of the two operand
        /// units, so <c>1.000000004 'g'</c> equals both <c>1000.000004 'mg'</c> (compared in <c>'mg'</c>)
        /// and <c>1.000000006 'g'</c> (compared in <c>'g'</c>), which are not equal to each other;</item>
        /// <item>equivalence rounds to the least precise operand (<c>0.15 ~ 0.2</c>, <c>0.2 ~ 0.24</c>,
        /// <c>0.15 !~ 0.24</c>).</item>
        /// </list>
        /// A value-derived hash therefore has to separate some pair that compares equal, which is what
        /// lets <c>Distinct</c>/<c>Union</c>/<c>Except</c> keep two quantities the comparer calls equal.
        /// A constant cannot: it costs the bucket spread - these operators degrade to a linear scan
        /// within the set - and buys the only answer that is correct for every pair.
        /// </remarks>
        protected override int GetHashCodeValue(CqlQuantity value) => 0;

    }
}
