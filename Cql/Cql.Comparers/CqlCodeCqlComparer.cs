/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// An <see cref="ICqlComparer"/> that compares two <see cref="CqlCode"/> instances.
    /// </summary>
    public class CqlCodeCqlComparer : ICqlComparer<CqlCode>, ICqlComparer
    {
        /// <summary>
        /// Create a comparer that uses a given <see cref="IComparer{T}"/> to compare the code part of the CqlCode.
        /// </summary>
        public CqlCodeCqlComparer(IComparer<string> codeComparer)
        {
            CodeComparer = codeComparer ?? throw new ArgumentNullException(nameof(codeComparer));
        }

        /// <summary>
        /// Create a comparer that uses the default <see cref="IComparer{T}"/> to compare the code part of the CqlCode.
        /// </summary>
        /// <remarks>The default comparer uses <see cref="StringComparer.OrdinalIgnoreCase"/></remarks> to compare the code.
        public CqlCodeCqlComparer() : this(StringComparer.OrdinalIgnoreCase)
        {
            // Nothing
        }

        /// <summary>
        /// The 
        /// </summary>
        public IComparer<string> CodeComparer { get; }

        /// <inheritdoc/>
        public int? Compare(CqlCode? x, CqlCode? y, string? precision)
        {
            if (x == null || y == null)
                return null;
            if (x.code == null || y.code == null)
                return null;
            else
            {
                var cc = CodeComparer.Compare(x.code, y.code);
                if (cc == 0)
                {
                    if ((x.system == null) ^ (y.system == null))
                        return null;
                    var sc = StringComparer.OrdinalIgnoreCase.Compare(x.system, y.system);
                    if (sc == 0)
                    {
                        if ((x.version == null) ^ (y.version == null))
                            return null;
                        var vc = StringComparer.OrdinalIgnoreCase.Compare(x.version, y.version);
                        if (vc == 0)
                        {
                            if ((x.display == null) ^ (y.display == null))
                                return null;
                            var dc = StringComparer.OrdinalIgnoreCase.Compare(x.display, y.display);
                            return dc;
                        }
                        else return vc;
                    }
                    else return sc;
                }
                else return cc;
            }
        }

        /// <inheritdoc/>
        public int? Compare(object? x, object? y, string? precision) => Compare(x as CqlCode, y as CqlCode, precision);


        /// <inheritdoc/>
        public bool? Equals(CqlCode? x, CqlCode? y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var compare = Compare(x, y, precision);
            if (compare == null)
                return null;
            else return compare == 0;
        }

        /// <inheritdoc/>
        public bool? Equals(object? x, object? y, string? precision) => Equals(x as CqlCode, y as CqlCode, precision);

        /// <inheritdoc/>
        public bool Equivalent(CqlCode? x, CqlCode? y, string? precision)
        {
            if (x == null || y == null)
                return false;

            if (x.code == null || y.code == null)
                return false;

            else
            {
                var cc = CodeComparer.Compare(x.code, y.code);
                if (cc == 0)
                {
                    if (x.system == null ^ y.system == null)
                        return false;
                    var sc = StringComparer.OrdinalIgnoreCase.Compare(x.system, y.system);
                    return sc == 0;
                }
                else
                    return false;
            }
        }

        /// <inheritdoc/>
        public bool Equivalent(object? x, object? y, string? precision) => Equivalent(x as CqlCode, y as CqlCode, precision);

        /// <inheritdoc/>
        public int GetHashCode(CqlCode? x) =>
            x == null
            ? typeof(CqlCode).GetHashCode()
            : $"{x.code?.ToLowerInvariant() ?? "null"}\0{x.system?.ToLowerInvariant() ?? "null"}\0".GetHashCode();

        /// <inheritdoc/>
        public int GetHashCode(object? x) => GetHashCode(x as CqlCode);
    }
}
