/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Abstractions;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// Compares enum values against strings and each other.
    /// </summary>
    internal class EnumComparer : ICqlComparer
    {
        /// <summary>
        /// Gets the default instance of this comparer.
        /// </summary>
        public static readonly EnumComparer Default = new EnumComparer();
        private EnumComparer() { }

        /// <inheritdoc/>
        public int? Compare(object? x, object? y, string? precision)
        {
            if (x == null || y == null) return null;
            var xType = x.GetType();
            var yType = y.GetType();
            if (xType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(x, y);
                else if (typeof(string).IsAssignableFrom(yType))
                    return CompareEnumToString(x, (string)y);
            }
            else if (yType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(x, y);
                else if (typeof(string).IsAssignableFrom(xType))
                    return CompareEnumToString(y, (string)x) * -1;
            }
            return null;
        }

        private static int CompareEnumToString(object @enum, string value)
        {
            var leftValue = Enum.GetName(@enum.GetType(), @enum);
            return string.Compare(leftValue, value, StringComparison.OrdinalIgnoreCase);
        }

        /// <inheritdoc/>
        public bool? Equals(object? x, object? y, string? precision)
        {
            var result = Compare(x, y, precision);
            if (result == null) return null;
            else return result == 0;
        }

        /// <inheritdoc/>
        public bool Equivalent(object? x, object? y, string? precision) => (Equals(x, y, precision) ?? false) == false;

        /// <inheritdoc/>
        public int GetHashCode(object x)
        {
            if (x == null) return typeof(object).GetHashCode();
            else return x.GetHashCode();
        }
    }
}
