/* 
 * Copyright (c) 2023, NCQA and contributors
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
    /// Implements comparison through <see cref="Comparer{T}.Default"/>.
    /// </summary>
    /// <typeparam name="T">The type to compare.</typeparam>
    internal class DefaultCqlComparer<T> : ICqlComparer, ICqlComparer<T>
    {
        /// <inheritdoc />
        public int? Compare(object? x, object? y, string? precision = null)
        {
            if (x is T tx)
            {
                if (y is T ty)
                    return Compare(tx, ty, precision);
            }
            return -1;
        }

        /// <inheritdoc />
        public int? Compare(T? x, T? y, string? precision = null) => Comparer<T>.Default.Compare(x, y);

        /// <inheritdoc />
        public bool? Equals(object? x, object? y, string? precision = null) =>
            Compare(x, y, precision) == 0;

        /// <inheritdoc />
        public bool? Equals(T? x, T? y, string? precision = null) => Comparer<T>.Default.Compare(x, y) == 0;

        /// <inheritdoc />
        public bool Equivalent(object? x, object? y, string? precision = null) =>
            Compare(x, y, precision) == 0;

        /// <inheritdoc />
        public bool Equivalent(T? x, T? y, string? precision = null) => Compare(x, y, precision) == 0;

        /// <inheritdoc />
        public int GetHashCode(T x) => x is not null ? EqualityComparer<T>.Default.GetHashCode(x) : typeof(T).GetHashCode();

        /// <inheritdoc />
        public int GetHashCode(object x) =>
            x is T t
            ? GetHashCode(t)
            : throw new InvalidCastException();
    }
}
