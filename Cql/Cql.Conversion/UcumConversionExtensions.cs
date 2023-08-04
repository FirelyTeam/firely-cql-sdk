/* 
 * Copyright (c) 2023, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */

#nullable enable

using Hl7.Cql.Primitives;
using System;
using M = Fhir.Metrics;

namespace Hl7.Fhir.ElementModel.Types
{
    /// <summary>
    /// Utility functions for working with Fireky's UCUM library, which allows full support for conversions within the UCUM unit system.
    /// </summary>
    public static class Ucum
    {
        private static readonly Lazy<M.SystemOfUnits> SYSTEM = new(M.UCUM.Load);

        /// <summary>
        /// Try to canonicalize the system type quantity to Umum base quantity. So a 1,000 cm will be 10 m. Or an inch will be converted to a meter.
        /// </summary>
        /// <param name="quantity">A system type Quantity of system Ucum</param>
        /// <param name="canonicalizedQuantity">The converted system type Quantity when the conversion was a success.</param>
        /// <returns><c>true</c> when the conversion succeeded. Or <c>false</c> otherwise.</returns>
        public static bool TryCanonicalize(this CqlQuantity quantity, out CqlQuantity? canonicalizedQuantity)
        {
            if (quantity.value is null) throw new ArgumentException("Quantity should have a value for UCUM canonicalization.", nameof(quantity));
            if (quantity.unit is null) throw new ArgumentException("Quantity should have a unit for UCUM canonicalization.", nameof(quantity));

            try
            {
                M.Quantity metricsQuantity = quantity.value.Value.toUnitsOfMeasureQuantity(quantity.unit);
                metricsQuantity = SYSTEM.Value.Canonical(metricsQuantity);
                canonicalizedQuantity = new(metricsQuantity.Value.ToDecimal(), metricsQuantity.Metric.ToString());
                return true;
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidCastException)
            {
                canonicalizedQuantity = null;
                return false;
            }
        }

        private static M.Quantity toUnitsOfMeasureQuantity(this decimal value, string unit)
        {
            var metric = SYSTEM.Value.Metric(unit);
            return new M.Quantity(value, metric);
        }
    }
}

#nullable restore