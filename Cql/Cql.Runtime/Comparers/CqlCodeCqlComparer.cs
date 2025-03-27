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
internal class CqlCodeCqlComparer(StringComparer codeComparer) : CqlComparer<CqlCode>
{
    protected internal override int GetEqualsStrategy() => EQUALS_VIA_COMPARE;

    protected internal override bool CompareReturnNullOnAnyNull() => true;

    /// <summary>
    /// The default comparer, which uses <see cref="StringComparer.OrdinalIgnoreCase"/>.
    /// </summary>
    public static readonly CqlCodeCqlComparer Default = new(OrdinalIgnoreCase);

    protected override int? CompareValues(
        CqlCode left,
        CqlCode right,
        string? precision)
    {
        var result = codeComparer.Compare(left.code, right.code);
        if (result != 0)
            return result;

        if ((left.system == null) ^ (right.system == null))
            return null;

        result = OrdinalIgnoreCase.Compare(left.system, right.system);
        if (result != 0)
            return result;

        if ((left.version == null) ^ (right.version == null))
            return null;

        result = OrdinalIgnoreCase.Compare(left.version, right.version);
        if (result != 0)
            return result;

        if ((left.display == null) ^ (right.display == null))
            return null;

        result = OrdinalIgnoreCase.Compare(left.display, right.display);
        return result;
    }

    protected override bool IsNull([NotNullWhen(false)] CqlCode? value)
    {
        return value?.code is null;
    }

    // /// <inheritdoc/>
    // public int? Compare(CqlCode? left, CqlCode? right, string? precision)
    // {
    //     if (left == null || right == null)
    //         return null;
    //
    //     if (left.code == null || right.code == null)
    //         return null;
    //
    //     var result = codeComparer.Compare(left.code, right.code);
    //     if (result != 0)
    //         return result;
    //
    //     if ((left.system == null) ^ (right.system == null))
    //         return null;
    //
    //     result = OrdinalIgnoreCase.Compare(left.system, right.system);
    //     if (result != 0)
    //         return result;
    //
    //     if ((left.version == null) ^ (right.version == null))
    //         return null;
    //
    //     result = OrdinalIgnoreCase.Compare(left.version, right.version);
    //     if (result != 0)
    //         return result;
    //
    //     if ((left.display == null) ^ (right.display == null))
    //         return null;
    //
    //     result = OrdinalIgnoreCase.Compare(left.display, right.display);
    //     return result;
    // }

    // /// <inheritdoc/>
    // public bool? Equals(CqlCode? left, CqlCode? right, string? precision)
    // {
    //     bool? result = Compare(left, right, precision) switch
    //     {
    //         null  => null,
    //         var c => c == 0
    //     };
    //     return result;
    // }

    protected override bool EquivalentValues(
        CqlCode left,
        CqlCode right,
        string? precision)
    {
        var result = codeComparer.Compare(left!.code, right!.code);
        if (result != 0)
            return false;

        if ((left.system == null) ^ (right.system == null))
            return false;

        result = OrdinalIgnoreCase.Compare(left.system, right.system);
        return result == 0;
    }

    // /// <inheritdoc/>
    // public bool Equivalent(CqlCode? left, CqlCode? right, string? precision)
    // {
    //     if (EquivalentOnNullsOnly(left?.code, right?.code) is { } r)
    //         return r;
    //
    //     var result = codeComparer.Compare(left!.code, right!.code);
    //     if (result != 0)
    //         return false;
    //
    //     if ((left.system == null) ^ (right.system == null))
    //         return false;
    //
    //     result = OrdinalIgnoreCase.Compare(left.system, right.system);
    //     return result == 0;
    // }

    /// <inheritdoc/>
    public override int GetHashCode(CqlCode? value) =>
        value == null
            ? GetHashCodeNull()
            : OrdinalIgnoreCase.GetHashCode(value.code ?? string.Empty) ^
              OrdinalIgnoreCase.GetHashCode(value.system ?? string.Empty);

    // public int GetHashCode(CqlCode? value) =>
    //     value == null
    //     ? typeof(CqlCode).GetHashCode()
    //     : OrdinalIgnoreCase.GetHashCode(value.code ?? string.Empty) ^
    //       OrdinalIgnoreCase.GetHashCode(value.system ?? string.Empty);
}