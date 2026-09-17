/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Comparers;

/// <summary>
/// The minimum or maximum value of the <c>Any</c> point type. An interval over <c>Any</c> can
/// only carry null boundaries, so its Start and End are one of these two values, which order
/// below and above each other and equal to themselves.
/// </summary>
internal sealed class AnyExtreme
{
    public static readonly AnyExtreme Minimum = new(-1);

    public static readonly AnyExtreme Maximum = new(1);

    private AnyExtreme(int order) => Order = order;

    /// <summary>
    /// The position of this extreme relative to the other: -1 for the minimum, 1 for the maximum.
    /// </summary>
    public int Order { get; }

    public override string ToString() => Order < 0 ? "minimum of Any" : "maximum of Any";
}

/// <summary>
/// Orders the two <see cref="AnyExtreme"/> values.
/// </summary>
internal sealed class AnyExtremeComparer() : CqlComparer<AnyExtreme>(CqlComparerEqualsImplementation.Compare, CqlComparerEquivalentImplementation.Compare)
{
    protected override int? CompareValues(AnyExtreme x, AnyExtreme y, string? precision) => x.Order.CompareTo(y.Order);

    protected override int GetHashCodeValue(AnyExtreme value) => value.Order;
}
