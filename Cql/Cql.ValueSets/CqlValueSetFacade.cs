/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Implements <see cref="IValueSetFacade"/>.
    /// </summary>
    [DebuggerDisplay("{Uri}")]
    internal class CqlValueSetFacade : IValueSetFacade
    {
        /// <summary>
        /// Creates an interface for a <paramref name="valueSet"/> from a <see cref="IValueSetDictionary"/>.
        /// </summary>
        /// <param name="valueSet">The value set for this facade.</param>
        /// <param name="valueSets">The  <see cref="IValueSetDictionary"/> with all valuesets.</param>
        /// <exception cref="ArgumentNullException">If any argument is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">If <paramref name="valueSet"/> has a <see langword="null" /> <see cref="CqlVocabulary.id"/> property.</exception>
        public CqlValueSetFacade(CqlValueSet valueSet, IValueSetDictionary valueSets)
        {
            if (valueSet is null)
                throw new ArgumentNullException(nameof(valueSet));
            _canonical = valueSet.id ?? throw new ArgumentException("Value set is missing an ID", nameof(valueSet));
            _valuesets = valueSets ?? throw new ArgumentNullException(nameof(valueSets));
        }

        /// <summary>
        /// Creates an interface for a <paramref name="id"/> from a <see cref="IValueSetDictionary"/>.
        /// </summary>
        /// <param name="id">The canonica of the value set for this facade.</param>
        /// <param name="valueSets">The dictionary of valuesets to get the valueset from.</param>
        /// <exception cref="ArgumentNullException">If any argument is <see langword="null" />.</exception>
        public CqlValueSetFacade(string id, IValueSetDictionary valueSets)
        {
            _canonical = id ?? throw new ArgumentNullException(nameof(id));
            _valuesets = valueSets ?? throw new ArgumentNullException(nameof(valueSets));
        }

        private readonly string _canonical;
        private readonly IValueSetDictionary _valuesets;

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <returns><see langword="true"/> if <paramref name="code"/> is in this value set.</returns>
        public bool? IsCodeInValueSet(CqlCode? code)
        {
            if (code == null || code.code == null)
                return null;
            if (code.system != null)
            {
                var @in = _valuesets.IsCodeInValueSet(_canonical, code.code, code.system);
                return @in;
            }
            else
            {
                var @in = _valuesets.IsCodeInValueSet(_canonical, code.code);
                return @in;
            }
        }

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <param name="system">The code system to check.</param>
        /// <returns><see langword="true"/> if the code is in this value set.</returns>
        public bool? IsCodeInValueSet(string? code, string? system)
        {
            if (code == null || system == null)
                return null;
            else return _valuesets.IsCodeInValueSet(_canonical, code, system);
        }

        /// <summary>
        /// Enumerates the code in this value set facade.
        /// </summary>
        public IEnumerator<CqlCode> GetEnumerator()
        {
            if (_valuesets.TryGetCodesInValueSet(_canonical, out var cqlCodes))
            {
                return cqlCodes!.GetEnumerator();
            }
            else return Enumerable.Empty<CqlCode>().GetEnumerator();
        }
        /// <summary>
        /// Enumerates the code in this value set facade.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
