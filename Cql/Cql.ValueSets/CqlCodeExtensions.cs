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
using Hl7.Cql.Abstractions;

namespace Hl7.Cql.ValueSets
{
    internal static class CqlCodeExtensions
    {
        public static IValueSetFacade GetValueSet(this IValueSetDictionary all, string canonical) => new CqlValueSetFacade(canonical, all);

        public static IValueSetFacade GetValueSet(this IValueSetDictionary all, CqlValueSet valueset) => new CqlValueSetFacade(valueset, all);

        public static IEnumerable<CqlCode> Union(this IEnumerable<CqlCode> left, IEnumerable<CqlCode> right)
        {
            var l = left is IValueSetFacade facl ? facl : new InMemoryValueSet(left);
            var r = right is IValueSetFacade facr ? facr : new InMemoryValueSet(right);

            return l.Union(r);
        }

        public static IValueSetFacade Union(this IValueSetFacade left, IValueSetFacade right) => new ValueSetUnion(left, right);

        public static IEqualityComparer<CqlCode> ToEqualityComparer(this ICqlComparer comparer) =>
            new CqlCodeEqualityHasher(comparer ?? throw new ArgumentNullException(nameof(comparer)));

        private class CqlCodeEqualityHasher : IEqualityComparer<CqlCode>
        {
            public ICqlComparer Comparer { get; }

            public CqlCodeEqualityHasher(ICqlComparer comparer)
            {
                Comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
            }

            public bool Equals(CqlCode? x, CqlCode? y) => Comparer.Compare(x, y, null) == 0;

            public int GetHashCode(CqlCode obj) =>
                (obj.code ?? "code").GetHashCode()
                ^ (obj.system ?? "system").GetHashCode()
                ^ (obj.display ?? "display").GetHashCode()
                ^ (obj.version ?? "version").GetHashCode();

        }
    }
}
