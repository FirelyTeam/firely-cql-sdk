/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

/// <summary>
/// A comparer that compares the values of one type, or some pairs of values of different types.
/// </summary>
internal interface ITypedCqlComparer
{
    /// <summary>
    /// Whether this comparer compares <paramref name="x"/> with <paramref name="y"/>: whether both are
    /// of the type it compares, or they are a pair of types it compares with each other. A pair it
    /// does not compare has no order, and its two values are not equal.
    /// </summary>
    bool CanCompare(object x, object y);
}
