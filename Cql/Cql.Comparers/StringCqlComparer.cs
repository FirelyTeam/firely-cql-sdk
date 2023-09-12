/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// Compares normalized strings given <see cref="_comparer"/>.
    /// </summary>
    /// <remarks>
    /// Strings are normalized using <see cref="string.Normalize()"/>.
    /// </remarks>
    internal class StringCqlComparer : ICqlComparer, ICqlComparer<string?>
    {
        private readonly StringComparer _comparer;

        /// <summary>
        /// Creates an instance that uses the indicated <see cref="StringComparer"/> on normalized string.
        /// </summary>
        public StringCqlComparer(StringComparer idComparer)
        {
            _comparer = idComparer ?? throw new ArgumentNullException(nameof(idComparer));
        }

        /// <inheritdoc/>
        public int? Compare(object? x, object? y, string? precision = null) => Compare(x as string, y as string, null);

        /// <inheritdoc/>
        public int? Compare(string? x, string? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;
            return _comparer.Compare(x.Normalize(), y.Normalize());
        }

        /// <inheritdoc/>
        public bool? Equals(string? x, string? y, string? precision = null) => Compare(x, y, precision) == 0;

        /// <inheritdoc/>
        public bool? Equals(object? x, object? y, string? precision = null) => Compare(x as string, y as string, precision) == 0;

        /// <inheritdoc/>
        public bool Equivalent(object? x, object? y, string? precision = null) =>
            Equivalent(x as string, y as string, precision);

        /// <inheritdoc/>
        public bool Equivalent(string? x, string? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;
            var thisNormalized = x!.Normalize();
            var otherNormalized = y!.Normalize();
            var areEqual = _comparer.Equals(thisNormalized, otherNormalized);
            return areEqual;
        }

        /// <inheritdoc/>
        public int GetHashCode(string? x) =>
            x == null
            ? typeof(string).GetHashCode()
            : x.GetHashCode();

        /// <inheritdoc/>
        public int GetHashCode(object? x) => GetHashCode(x as string);
    }
}

#nullable restore