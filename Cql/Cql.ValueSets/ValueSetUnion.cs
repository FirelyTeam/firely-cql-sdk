/* 
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Creates a facade for value set unions.
    /// </summary>
    internal class ValueSetUnion : IValueSetFacade
    {
        /// <summary>
        /// Creates a union from the listed child facades.
        /// </summary>
        public ValueSetUnion(IEnumerable<IValueSetFacade> facades) : this(facades.ToArray())
        {
            // Nothing
        }

        /// <summary>
        /// Creates a union from the listed child facades.
        /// </summary>
        public ValueSetUnion(params IValueSetFacade[] facades)
        {
            _facades = facades;
        }

        private IValueSetFacade[] _facades;

        /// <summary>
        /// Enumerates the code in this value set facade union.
        /// </summary>
        IEnumerator<CqlCode> IEnumerable<CqlCode>.GetEnumerator()
        {
            // If there is more than one source, create an in-memory hash to serve the enumerable.
            // From now on, this in-memory hash will be used to servce the other methods in the
            // interface as well.
            if (_facades.Length > 1)
            {
                var unifiedFacade = new InMemoryValueSet(_facades.SelectMany(f => f));
                _facades = [unifiedFacade];
            }

            return _facades[0].GetEnumerator();
        }

        /// <summary>
        /// Enumerates the code in this value set facade union.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<CqlCode>)this).GetEnumerator();

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set union.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <returns><see langword="true"/> if <paramref name="code"/> is in this value set.</returns>
        public bool? IsCodeInValueSet(CqlCode? code)
        {
            if (code == null) return null;

            return _facades.Any(f => f.IsCodeInValueSet(code) == true);
        }

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set union.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <param name="system">The code system to check.</param>
        /// <returns><see langword="true"/> if the code is in this value set.</returns>
        public bool? IsCodeInValueSet(string? code, string? system)
        {
            if (code == null) return null;

            return _facades.Any(f => f.IsCodeInValueSet(code, system) == true);
        }
    }
}
