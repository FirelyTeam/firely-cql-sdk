/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
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

        IEnumerator<CqlCode> IEnumerable<CqlCode>.GetEnumerator()
        {
            // If there is more than one source, create an in-memory hash to serve the enumerable.
            // From now on, this in-memory hash will be used to servce the other methods in the
            // interface as well.
            // TODO: If this interface would not require codes to be unique, we could make this more performant.
            // Uniqueness could then be done by the Union operator itself, not the IEnumerable.
            if (_facades.Length > 1)
            {
                // TODO: it's undefined what comparator to use for the equality of the Union operator,
                // so we assume our default here, which is probably wrong.
                var unifiedFacade = new InMemoryValueSet(_facades.SelectMany(f => f));
                _facades = new[] { unifiedFacade };
            }
            else if (_facades.Length == 0)
                return Enumerable.Empty<CqlCode>().GetEnumerator();

            return _facades[0].GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<CqlCode>)this).GetEnumerator();

        /// <inheritdoc/>
        public bool IsCodeInValueSet(CqlCode code) => _facades.Any(f => f.IsCodeInValueSet(code));

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string code, string? system) => _facades.Any(f => f.IsCodeInValueSet(code, system));

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string code) => _facades.Any(f => f.IsCodeInValueSet(code));
    }
}
