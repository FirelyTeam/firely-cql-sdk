using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Uses hash sets to identify code membership within value sets.
    /// </summary>
    public class HashValueSetDictionary : IValueSetDictionary
    {
        private const string NullCodeSystem = "\0";
        private readonly CqlCodeHasher CodeHasher = new();

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

            CodesByHash.Add(GetKey(valueSetUri, code.code, code.system), code);
            var nullKey = GetKey(valueSetUri, code.code, NullCodeSystem);
            if (!CodesByHash.ContainsKey(nullKey))
                CodesByHash.Add(nullKey, code);
            if (!CodesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new HashSet<CqlCode>(CodeHasher);
                codes.Add(code);
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
            CodesByHash[GetKey(valueSetUri, code.code, code.system)] = code;
            CodesByHash[GetKey(valueSetUri, code.code, NullCodeSystem)] = code;
            if (!CodesInValueSet.TryGetValue(valueSetUri, out var codes))
            {
                codes = new HashSet<CqlCode>(CodeHasher)
                {
                    code
                };
                CodesInValueSet.Add(valueSetUri, codes);
            }
            else if (!codes.Contains(code))
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
            CodesByHash.ContainsKey(GetKey(valueSetUri, code, NullCodeSystem));

        /// <summary>
        /// Returns <see langword="true"/> if the given code is present in the given value set.
        /// This method approaches an O(1) operation.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to check.</param>
        /// <param name="systemUriOrOid">The code system's canonical URI or its OID.</param>
        /// <returns><see langword="true"/> if the given code is present in the given value set.</returns>
        public bool IsCodeInValueSet(string valueSetUri, string code, string systemUri) =>
            CodesByHash.ContainsKey(GetKey(valueSetUri, code, systemUri));

        /// <summary>
        /// Tries to ge the codes in the value set as an <see cref="IReadOnlyCollection{CqlCode}"/>.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="codes">The <see langword="out"/> parameter for the value set's codes, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the given value set is defined; otherwise, <see langword="false"/>.</returns>
        public bool TryGetCodesInValueSet(string valueSetUri, out IReadOnlyCollection<CqlCode>? codes)
        {
            if (CodesInValueSet.TryGetValue(valueSetUri, out var codeSet))
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
        public int Count => CodesByHash.Count / 2;

        private string GetKey(string valueSetUri, string? code, string? systemUri) =>
            $"{valueSetUri?.ToLowerInvariant()}\0{systemUri?.ToLowerInvariant() ?? ""}\0{code?.ToLowerInvariant() ?? ""}";

        private Dictionary<string, CqlCode> CodesByHash = new();
        private Dictionary<string, HashSet<CqlCode>> CodesInValueSet =
            new(StringComparer.OrdinalIgnoreCase);

        private class CqlCodeHasher : IEqualityComparer<CqlCode>
        {
            public bool Equals(CqlCode x, CqlCode y) => true;

            // we're using low ASCII values that are invalid in real codes
            public int GetHashCode(CqlCode obj) =>
                ($"{obj.code ?? "\x1"}\x1").GetHashCode()
                ^ ($"{obj.system ?? "\x2"}\x2").GetHashCode();

        }

    }
}
