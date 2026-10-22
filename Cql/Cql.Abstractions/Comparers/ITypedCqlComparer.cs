/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

/// <summary>
/// A comparer that compares the values of one type.
/// </summary>
internal interface ITypedCqlComparer
{
    /// <summary>
    /// Whether <paramref name="x"/> and <paramref name="y"/> are both of the type this comparer
    /// compares. A pair that is not has no order, and its two values are not equal.
    /// </summary>
    bool CanCompare(object x, object y);
}
