/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Model;

namespace Hl7.Cql.Comparers;

internal class BaseComparer(CqlComparers valueComparer) : CqlComparer<Base>
{
    /// <inheritdoc />
    protected override int? CompareValues(Base x, Base y, string? precision) =>
        x == y ? 0 :
        valueComparer.Compare(x.EnumerateElements(), y.EnumerateElements(), precision);

    /// <inheritdoc />
    protected override bool? EqualsValues(Base x, Base y, string? precision) =>
        x == y ? true :
        valueComparer.Equals(x.EnumerateElements(), y.EnumerateElements(), precision);

    /// <inheritdoc />
    protected override bool EquivalentValues(Base x, Base y, string? precision) =>
        x == y || valueComparer.Equivalent(x.EnumerateElements(), y.EnumerateElements(), precision);

    /// <inheritdoc />
    protected override int GetHashCodeValue(Base value) =>
        valueComparer.GetHashCode(value.EnumerateElements());
}