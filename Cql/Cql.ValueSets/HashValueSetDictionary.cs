/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Uses hash sets to identify code membership within value sets.
    /// </summary>
    public class HashValueSetDictionary : IValueSetDictionary
    {
        public HashValueSetDictionary(ICqlComparer<CqlCode> comparer) => _comparer = comparer;

        public HashValueSetDictionary() : this(new CqlCodeCqlComparer())
        {
            // nothing
        }

        /// <summary>
        /// Adds the code to the given value set by its canonical URI.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to add.</param>
        /// <exception cref="ArgumentException">If <paramref name="code"/> already exists in the specified value set.</exception>
        public void Add(string valueSetUri, CqlCode code)
        {
            if (string.IsNullOrEmpty(valueSetUri)) throw new ArgumentException($"'{nameof(valueSetUri)}' cannot be null or empty.", nameof(valueSetUri));
            if (code is null) throw new ArgumentNullException(nameof(code));

            if (!CodesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new InMemoryValueSet(new[] { code }, _comparer);
                CodesInValueSet.Add(valueSetUri, codes);
            }
            else
                codes.Add(code);
        }

        /// <summary>
        /// Adds or overwrites the code to the given value set by its canonical URI, and will not throw if the code exists already.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to add.</param>
        public void Set(string valueSetUri, CqlCode code)
        {
            if (!CodesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new InMemoryValueSet(new[] { code }, _comparer);
                CodesInValueSet.Add(valueSetUri, codes);
            }
            else if (!codes.Contains(code))
                codes.Add(code);
        }

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string valueSetUri, string code) =>
             CodesInValueSet.TryGetValue(valueSetUri, out var vs) && vs.IsCodeInValueSet(code);

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string valueSetUri, string code, string? systemUriOrOid) =>
            CodesInValueSet.TryGetValue(valueSetUri, out var vs) && vs.IsCodeInValueSet(code, systemUriOrOid);

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string valueSetUri, CqlCode code) =>
            CodesInValueSet.TryGetValue(valueSetUri, out var vs) && vs.IsCodeInValueSet(code);

        /// <summary>
        /// Tries to ge the codes in the value set as an <see cref="IReadOnlyCollection{CqlCode}"/>.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="codes">The <see langword="out"/> parameter for the value set's codes, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the given value set is defined; otherwise, <see langword="false"/>.</returns>
        public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes)
        {
            if (CodesInValueSet.TryGetValue(valueSetUri, out var codeSet))
            {
                codes = codeSet;
                return true;
            }
            codes = null!;
            return false;
        }

        private readonly Dictionary<string, InMemoryValueSet> CodesInValueSet = new(StringComparer.OrdinalIgnoreCase);
        private readonly ICqlComparer<CqlCode> _comparer;
    }
}
