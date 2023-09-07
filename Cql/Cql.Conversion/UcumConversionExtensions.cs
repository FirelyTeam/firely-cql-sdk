/* 
 * Copyright (c) 2023, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */

using Hl7.Cql.Primitives;
using System;
using M = Fhir.Metrics;

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// Utility functions for working with Fireky's UCUM library, which allows full support for conversions within the UCUM unit system.
    /// </summary>
    internal static class Ucum
    {
        private static readonly Lazy<M.SystemOfUnits> _system = new(M.UCUM.Load);
        private static readonly M.SystemOfUnits SYSTEM = _system.Value;

        /// <summary>
        /// Try to canonicalize the system type quantity to Umum base quantity. So a 1,000 cm will be 10 m. Or an inch will be converted to a meter.
        /// </summary>
        /// <param name="quantity">A system type Quantity of system Ucum</param>
        /// <param name="canonicalizedQuantity">The converted system type Quantity when the conversion was a success.</param>
        /// <returns><c>true</c> when the conversion succeeded. Or <c>false</c> otherwise.</returns>
        public static bool TryCanonicalize(this CqlQuantity quantity, out CqlQuantity? canonicalizedQuantity)
        {
            if (quantity.value is null || quantity.unit is null)
            {
                canonicalizedQuantity = null;
                return false;
            }

            try
            {
                M.Quantity metricsQuantity = quantity.value.Value.toUnitsOfMeasureQuantity(quantity.unit);
                metricsQuantity = SYSTEM.Canonical(metricsQuantity);
                canonicalizedQuantity = new(metricsQuantity.Value.ToDecimal(), metricsQuantity.Metric.ToString());
                return true;
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidCastException)
            {
                canonicalizedQuantity = null;
                return false;
            }
        }

        /// <summary>
        /// Try to convert a quantity to another unit.
        /// </summary>
        /// <returns>false if the conversion was not possible, true otherwise.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool TryConvert(this CqlQuantity quantity, string unit, out CqlQuantity? convertedQuantity)
        {
            if (quantity.value is null) throw new ArgumentException("Quantity should have a value for UCUM conversion.", nameof(quantity));
            if (quantity.unit is null) throw new ArgumentException("Quantity should have a unit for UCUM conversion.", nameof(quantity));

            try
            {
                M.Quantity metricsQuantity = quantity.value.Value.toUnitsOfMeasureQuantity(quantity.unit);
                metricsQuantity = SYSTEM.Convert(metricsQuantity, unit);
                convertedQuantity = new(metricsQuantity.Value.ToDecimal(), metricsQuantity.Metric.ToString());
                return true;
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidCastException)
            {
                convertedQuantity = null;
                return false;
            }

        }

        private static M.Quantity toUnitsOfMeasureQuantity(this decimal value, string unit)
        {
            var metric = SYSTEM.Metric(unit);
            return new M.Quantity(value, metric);
        }
    }
}
