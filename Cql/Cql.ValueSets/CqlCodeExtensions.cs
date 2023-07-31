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

namespace Hl7.Cql.ValueSets
{
    public static class CqlCodeExtensions
    {
        /// <summary>
        /// Returns a facade on a <see cref="IValueSetDictionary"/> that represents access to the valueset within the dictionary.
        /// </summary>
        /// <remarks>This method does not check that the dictionary contains the given valueset.</remarks>
        public static IValueSetFacade GetValueSet(this IValueSetDictionary all, string canonical) => new CqlValueSetFacade(canonical, all);

        /// <summary>
        /// Returns a facade on a <see cref="IValueSetDictionary"/> that represents access to the valueset within the dictionary.
        /// </summary>
        /// <remarks>This method does not check that the dictionary contains the given valueset.</remarks>
        public static IValueSetFacade GetValueSet(this IValueSetDictionary all, CqlValueSet valueset) =>
                GetValueSet(all, valueset.id ?? throw new ArgumentException("Valueset does not have a canonical."));

        public static IEnumerable<CqlCode> Union(this IEnumerable<CqlCode> left, IEnumerable<CqlCode> right)
        {
            var l = left is IValueSetFacade facl ? facl : new InMemoryValueSet(left);
            var r = right is IValueSetFacade facr ? facr : new InMemoryValueSet(right);

            return l.Union(r);
        }

        public static IValueSetFacade Union(this IValueSetFacade left, IValueSetFacade right) => new ValueSetUnion(left, right);

        public static IEqualityComparer<T> ToEqualityComparer<T>(this ICqlComparer<T> comparer, string? precision = null, bool useEquivalence = false) =>
            new CqlCodeEqualityComparer<T>(comparer ?? throw new ArgumentNullException(nameof(comparer)), precision, useEquivalence);

        private class CqlCodeEqualityComparer<T> : IEqualityComparer<T>
        {
            private readonly string? _precision;
            private readonly bool _useEquivalence;

            public ICqlComparer<T> Comparer { get; }

            public CqlCodeEqualityComparer(ICqlComparer<T> comparer, string? precision = null, bool useEquivalence = false)
            {
                Comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
                _precision = precision;
                _useEquivalence = useEquivalence;
            }

            public bool Equals(T? x, T? y) =>
                ReferenceEquals(x, y) ||
                _useEquivalence ? Comparer.Equivalent(x, y, _precision) == true : Comparer.Equals(x, y, _precision) == true;

            public int GetHashCode(T obj) => Comparer.GetHashCode(obj);
        }
    }
}
