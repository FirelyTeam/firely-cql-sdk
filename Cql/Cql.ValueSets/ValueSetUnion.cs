/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Creates a facade for value set unions.
    /// </summary>
    public class ValueSetUnion : IValueSetFacade
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="facades">The facades to combine in a union.</param>
        /// <param name="valueSets">The collection of valuesets.</param>
        /// <param name="comparer">The <see cref="ICqlComparer"/> to use when comparing codes.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ValueSetUnion(ValueSetFacade[] facades, IValueSetDictionary valueSets, ICqlComparer comparer)
        {
            Facades = facades.ToArray();
            Hasher = new CqlCodeEqualityHasher(comparer);
            DistinctCodes = new Lazy<HashSet<CqlCode>>(() =>
            {
                var codes = new HashSet<CqlCode>(Hasher);
                foreach (var facade in Facades)
                {
                    if (valueSets.TryGetCodesInValueSet(facade.Id, out var cqlCodes))
                    {
                        foreach (var cqlCode in cqlCodes!)
                        {
                            if (!codes.Contains(cqlCode))
                                codes.Add(cqlCode);
                        }
                    }
                }
                return codes;
            }, true);
        }
        /// <summary>
        /// The facades that comprise this union.
        /// </summary>
        public ValueSetFacade[] Facades { get; }
        /// <summary>
        /// The comparer which hashes <see cref="CqlCode"/> instances.
        /// </summary>
        public IEqualityComparer<CqlCode> Hasher { get; }

        private readonly Lazy<HashSet<CqlCode>> DistinctCodes;

        /// <summary>
        /// Enumerates the code in this value set facade union.
        /// </summary>
        public IEnumerator<CqlCode> GetEnumerator() => DistinctCodes.Value.GetEnumerator();

        /// <summary>
        /// Enumerates the code in this value set facade union.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set union.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <returns><see langword="true"/> if <paramref name="code"/> is in this value set.</returns>
        public bool? IsCodeInValueSet(CqlCode? code)
        {
            if (code == null)
                return null;
            foreach (var facade in Facades)
                if (facade.IsCodeInValueSet(code) == true)
                    return true;
            return false;
        }

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set union.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <param name="system">The code system to check.</param>
        /// <returns><see langword="true"/> if the code is in this value set.</returns>
        public bool? IsCodeInValueSet(string? code, string? system)
        {
            if (code == null)
                return null;
            foreach (var facade in Facades)
                if (facade.IsCodeInValueSet(code, system) == true)
                    return true;
            return false;
        }

        private class CqlCodeEqualityHasher : IEqualityComparer<CqlCode>
        {
            public ICqlComparer Comparer { get; }

            public CqlCodeEqualityHasher(ICqlComparer comparer)
            {
                Comparer = comparer;
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
