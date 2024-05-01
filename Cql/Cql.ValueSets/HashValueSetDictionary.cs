/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Uses hash sets to identify code membership within value sets.
    /// </summary>
    internal class HashValueSetDictionary : IValueSetDictionary
    {
        private const string NullCodeSystem = "\0";
        private readonly CqlCodeHasher _codeHasher = new();

        /// <summary>
        /// Adds the code to the given value set by its canonical URI.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to add.</param>
        /// <exception cref="ArgumentException">If <paramref name="code"/> already exists in the specified value set.</exception>
        public void Add(string valueSetUri, CqlCode code)
        {
            if (string.IsNullOrEmpty(valueSetUri))
            {
                throw new ArgumentException($"'{nameof(valueSetUri)}' cannot be null or empty.", nameof(valueSetUri));
            }

            if (code is null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            _codesByHash.Add(GetKey(valueSetUri, code.code, code.system), code);
            var nullKey = GetKey(valueSetUri, code.code, NullCodeSystem);
            _codesByHash.TryAdd(nullKey, code);
            if (!_codesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new HashSet<CqlCode>(_codeHasher) { code };
                _codesInValueSet.Add(valueSetUri, codes);
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
            _codesByHash[GetKey(valueSetUri, code.code, code.system)] = code;
            _codesByHash[GetKey(valueSetUri, code.code, NullCodeSystem)] = code;
            if (!_codesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new HashSet<CqlCode>(_codeHasher)
                {
                    code
                };
                _codesInValueSet.Add(valueSetUri, codes);
            }
            else
                codes.Add(code);
        }

        /// <summary>
        /// Returns <see langword="true"/> if the given code is present in the given value set.
        /// This method ignores the code system of the codes present in <paramref name="valueSetUri"/>.
        /// This method approaches an O(1) operation.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to check.</param>
        /// <returns><see langword="true"/> if the given code is present in the given value set.</returns>
        public bool IsCodeInValueSet(string valueSetUri, string code) =>
            _codesByHash.ContainsKey(GetKey(valueSetUri, code, NullCodeSystem));

        /// <summary>
        /// Returns <see langword="true"/> if the given code is present in the given value set.
        /// This method approaches an O(1) operation.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to check.</param>
        /// <param name="systemUriOrOid">The code system's canonical URI or its OID.</param>
        /// <returns><see langword="true"/> if the given code is present in the given value set.</returns>
        public bool IsCodeInValueSet(string valueSetUri, string code, string systemUriOrOid) =>
            _codesByHash.ContainsKey(GetKey(valueSetUri, code, systemUriOrOid));

        /// <summary>
        /// Tries to ge the codes in the value set as an <see cref="IReadOnlyCollection{CqlCode}"/>.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="codes">The <see langword="out"/> parameter for the value set's codes, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the given value set is defined; otherwise, <see langword="false"/>.</returns>
        public bool TryGetCodesInValueSet(string valueSetUri, out IReadOnlyCollection<CqlCode>? codes)
        {
            if (_codesInValueSet.TryGetValue(valueSetUri, out var codeSet))
            {
                codes = codeSet;
                return true;
            }
            codes = null!;
            return false;
        }

        /// <summary>
        /// Gets the total number of codes in all value sets in this dictionary.
        /// </summary>
        public int Count => _codesByHash.Count / 2;

        private string GetKey(string valueSetUri, string? code, string? systemUri) =>
            $"{valueSetUri.ToLowerInvariant()}\0{systemUri?.ToLowerInvariant() ?? ""}\0{code?.ToLowerInvariant() ?? ""}";

        private readonly Dictionary<string, CqlCode> _codesByHash = new();
        private readonly Dictionary<string, HashSet<CqlCode>> _codesInValueSet =
            new(StringComparer.OrdinalIgnoreCase);

        private class CqlCodeHasher : IEqualityComparer<CqlCode>
        {
            public bool Equals(CqlCode? x, CqlCode? y) => true;

            // we're using low ASCII values that are invalid in real codes
            public int GetHashCode(CqlCode obj) =>
                ($"{obj.code ?? "\x1"}\x1").GetHashCode()
                ^ ($"{obj.system ?? "\x2"}\x2").GetHashCode();

        }

    }
}
