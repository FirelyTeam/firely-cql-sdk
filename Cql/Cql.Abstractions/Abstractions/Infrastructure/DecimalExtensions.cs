/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Abstractions.Infrastructure;

internal static class DecimalExtensions
{
    /// <summary>
    /// Returns the scale of <paramref name="value"/>, i.e. its number of digits after the decimal point,
    /// counting trailing zeros - so <c>1.50m</c> yields <c>2</c>, not <c>1</c>.
    /// </summary>
    /// <remarks>
    /// CQL reads this as a value's precision when comparing for equivalence, when making a Range bound's
    /// precision explicit, and when deciding whether an interval's per step is integral.
    /// </remarks>
    public static int GetScale(this decimal value) =>
        // GetBits() returns the decimal's 96-bit integer part in [0..2] and its flags word in [3]. In the flags
        // word, bits 16-23 hold the scale - the power of ten that integer part is divided by, which is the digit
        // count we are after - and bit 31 holds the sign. Shifting right by 16 and masking off everything above
        // the low byte therefore isolates the scale.
        (decimal.GetBits(value)[3] >> 16) & 0xFF;
}
