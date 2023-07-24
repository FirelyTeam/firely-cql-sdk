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
using System.Diagnostics;
using System.Linq;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Implements <see cref="IValueSetFacade"/>.
    /// </summary>
    [DebuggerDisplay("{Uri}")]
    public class ValueSetFacade : IValueSetFacade
    {
        /// <summary>
        /// Creates an interface for <paramref name="valueSet"/>.
        /// </summary>
        /// <param name="valueSet">The value set for this facade.</param>
        /// <param name="valueSets">The dictionary of valuesets.</param>
        /// <exception cref="ArgumentNullException">If any argument is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">If <paramref name="valueSet"/> has a <see langword="null" /> <see cref="CqlVocabulary.id"/> property.</exception>
        public ValueSetFacade(CqlValueSet valueSet, IValueSetDictionary valueSets)
        {
            if (valueSet is null)
                throw new ArgumentNullException(nameof(valueSet));
            Id = valueSet.id ?? throw new ArgumentException("Value set is missing an ID", nameof(valueSet));
            ValueSets = valueSets ?? throw new ArgumentNullException(nameof(valueSets));
        }
        /// <summary>
        /// The ID of the value set.
        /// </summary>
        public string Id { get; }

        public IValueSetDictionary ValueSets { get; }

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
                var @in = ValueSets.IsCodeInValueSet(Id, code.code, code.system);
                return @in;
            }
            else
            {
                var @in = ValueSets.IsCodeInValueSet(Id, code.code);
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
            else return ValueSets.IsCodeInValueSet(Id, code, system);
        }

        /// <summary>
        /// Enumerates the code in this value set facade.
        /// </summary>
        public IEnumerator<CqlCode> GetEnumerator()
        {
            if (ValueSets.TryGetCodesInValueSet(Id, out var cqlCodes))
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
