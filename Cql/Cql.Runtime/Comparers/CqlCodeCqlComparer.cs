/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using static System.StringComparer;

namespace Hl7.Cql.Comparers;

/// <summary>
/// An CQL comparer that compares two <see cref="CqlCode"/> instances.
/// </summary>
internal class CqlCodeCqlComparer(StringComparer codeComparer) : ICqlComparer<CqlCode>
{
    /// <summary>
    /// The default comparer, which uses <see cref="StringComparer.OrdinalIgnoreCase"/>.
    /// </summary>
    public static readonly CqlCodeCqlComparer Default = new(OrdinalIgnoreCase);

    /// <inheritdoc/>
    public int? Compare(CqlCode? x, CqlCode? y, string? precision)
    {
        if (x == null || y == null)
            return null;

        if (x.code == null || y.code == null)
            return null;

        var result = codeComparer.Compare(x.code, y.code);
        if (result != 0)
            return result;

        if ((x.system == null) ^ (y.system == null))
            return null;

        result = OrdinalIgnoreCase.Compare(x.system, y.system);
        if (result != 0)
            return result;

        if ((x.version == null) ^ (y.version == null))
            return null;

        result = OrdinalIgnoreCase.Compare(x.version, y.version);
        if (result != 0)
            return result;

        if ((x.display == null) ^ (y.display == null))
            return null;

        result = OrdinalIgnoreCase.Compare(x.display, y.display);
        return result;
    }

    /// <inheritdoc/>
    public bool Equivalent(CqlCode? x, CqlCode? y, string? precision)
    {
        if (EquivalentOnNullsOnly(x?.code, y?.code) is { } r)
            return r;

        var result = codeComparer.Compare(x!.code, y!.code);
        if (result != 0)
            return false;

        if ((x.system == null) ^ (y.system == null))
            return false;

        result = OrdinalIgnoreCase.Compare(x.system, y.system);
        return result == 0;
    }

    /// <inheritdoc/>
    public int GetHashCode(CqlCode? x) =>
        x == null
            ? GetHashCodeForType<CqlCode>()
            : HashCode.Combine(
                OrdinalIgnoreCase.GetHashCode(x.code ?? string.Empty),
                OrdinalIgnoreCase.GetHashCode(x.system ?? string.Empty));
}