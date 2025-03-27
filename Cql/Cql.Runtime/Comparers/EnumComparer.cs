/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

/// <summary>
/// Compares enum values against strings and each other.
/// </summary>
internal class EnumComparer : CqlComparer<object>
{
    protected internal override int GetEquivalentStrategy() => EQUIVALENT_VIA_EQUALS;

    protected internal override int GetEqualsStrategy() => EQUIVALENT_VIA_COMPARE;

    protected internal override bool CompareReturnNullOnAnyNull() => true;

    /// <summary>
    /// Gets the default instance of this comparer.
    /// </summary>
    public static readonly EnumComparer Default = new();

    private EnumComparer() { }

    protected override int? CompareValues(
        object left,
        object right,
        string? precision)
    {
        var xType = left.GetType();
        var yType = right.GetType();
        if (xType.IsEnum)
        {
            if (yType == xType)
                return Comparer<object>.Default.Compare(left, right);
            else if (typeof(string).IsAssignableFrom(yType))
                return CompareEnumToString(left, (string)right);
        }
        else if (yType.IsEnum)
        {
            if (yType == xType)
                return Comparer<object>.Default.Compare(left, right);
            else if (typeof(string).IsAssignableFrom(xType))
                return CompareEnumToString(right, (string)left) * -1;
        }
        return null;
    }

    // /// <inheritdoc/>
    // public int? Compare(object? left, object? right, string? precision)
    // {
    //     if (left == null || right == null) return null;
    //     var xType = left.GetType();
    //     var yType = right.GetType();
    //     if (xType.IsEnum)
    //     {
    //         if (yType == xType)
    //             return Comparer<object>.Default.Compare(left, right);
    //         else if (typeof(string).IsAssignableFrom(yType))
    //             return CompareEnumToString(left, (string)right);
    //     }
    //     else if (yType.IsEnum)
    //     {
    //         if (yType == xType)
    //             return Comparer<object>.Default.Compare(left, right);
    //         else if (typeof(string).IsAssignableFrom(xType))
    //             return CompareEnumToString(right, (string)left) * -1;
    //     }
    //     return null;
    // }

    private static int CompareEnumToString(object @enum, string value)
    {
        var leftValue = Enum.GetName(@enum.GetType(), @enum);
        return string.Compare(leftValue, value, StringComparison.OrdinalIgnoreCase);
    }

    // public override bool Equivalent(
    //     object? left,
    //     object? right,
    //     string? precision)
    // {
    //     return EquivalentViaEquals(left, right, precision);
    // }

    // public override bool? Equals(
    //     object? left,
    //     object? right,
    //     string? precision)
    // {
    //     return EqualsViaCompare(left, right, precision);
    // }

    // /// <inheritdoc/>
    // public bool? Equals(object? left, object? right, string? precision)
    // {
    //     var result = Compare(left, right, precision);
    //     if (result == null) return null;
    //     else return result == 0;
    // }
    //
    // /// <inheritdoc/>
    // public bool Equivalent(object? left, object? right, string? precision) => (Equals(left, right, precision) ?? false) == false;
    //
    // /// <inheritdoc/>
    // public int GetHashCode(object? value) =>
    //     value?.GetHashCode() ?? typeof(object).GetHashCode();
}