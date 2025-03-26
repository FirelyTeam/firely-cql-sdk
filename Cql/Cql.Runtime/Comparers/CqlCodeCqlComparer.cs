/*
 * Copyright (c) 2023, NCQA and contributors
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
internal class CqlCodeCqlComparer(StringComparer codeComparer) : ICqlComparer<CqlCode>//, ICqlComparer
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

    // /// <inheritdoc/>
    // public int? Compare(object? x, object? y, string? precision) =>
    //     Compare(x as CqlCode, y as CqlCode, precision);

    /// <inheritdoc/>
    public bool? Equals(CqlCode? x, CqlCode? y, string? precision)
    {
        bool? result = Compare(x, y, precision) switch
        {
            null  => null,
            var c => c == 0
        };
        return result;
    }

    // /// <inheritdoc/>
    // public bool? Equals(object? x, object? y, string? precision) =>
    //     Equals(x as CqlCode, y as CqlCode, precision);

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

    // /// <inheritdoc/>
    // public bool Equivalent(object? x, object? y, string? precision) =>
    //     Equivalent((x as CqlCode)!, (y as CqlCode)!, precision);

    /// <inheritdoc/>
    public int GetHashCode(CqlCode? x) =>
        x == null
            ? typeof(CqlCode).GetHashCode()
            : OrdinalIgnoreCase.GetHashCode(x.code ?? string.Empty) ^
              OrdinalIgnoreCase.GetHashCode(x.system ?? string.Empty);

    /*
    /// <inheritdoc/>
    public int GetHashCode(object? x) => GetHashCode(x as CqlCode);
*/
}