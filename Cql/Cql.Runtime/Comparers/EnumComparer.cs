/*
 * Copyright (c) 2023, Firely, NCQA and contributors
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
    /// <summary>
    /// Gets the default instance of this comparer.
    /// </summary>
    public static readonly EnumComparer Default = new();

    private EnumComparer() :
        base(CqlComparerEqualsMethod.Compare, CqlComparerNullComparisonStrategy.EitherNullReturnsNull, CqlComparerEquivalentMethod.Equals){ }

    protected internal override int? CompareValues(
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

    private static int CompareEnumToString(object @enum, string value)
    {
        var leftValue = Enum.GetName(@enum.GetType(), @enum);
        return string.Compare(leftValue, value, StringComparison.OrdinalIgnoreCase);
    }
}