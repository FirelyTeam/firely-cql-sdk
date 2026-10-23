/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets.Errors;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// A valueset dictionary that keeps FHIR valuesets in memory.
    /// </summary>
    public class HashValueSetDictionary : IValueSetDictionary
    {
        // Table with unique CqlCodes, so having many valuesets with identical codes will
        // not result in duplicate codes. Also helps with comparing codes by reference for speed.

        private readonly ConcurrentDictionary<CqlCode, CqlCode> _internHash;

        /// <summary>
        /// Interns the given code, returning the interned code. This makes it easier to compare codes by reference.
        /// </summary>
        public CqlCode Intern(CqlCode code) => _internHash.GetOrAdd(code, code);

        /// <summary>
        /// Creates a new <see cref="HashValueSetDictionary"/> with the given <paramref name="comparer"/>.
        /// </summary>
        public HashValueSetDictionary(ICqlComparer<CqlCode> comparer)
        {
            _comparer = comparer;
            _internHash = new ConcurrentDictionary<CqlCode, CqlCode>(_comparer.ToEqualityComparer());
        }

        /// <summary>
        /// Creates a new <see cref="HashValueSetDictionary"/> with the default comparer.
        /// </summary>
        public HashValueSetDictionary() : this(CqlCodeCqlComparer.OrdinalIgnoreCase)
        {
            // nothing
        }

        /// <summary>
        /// Adds the code to the given value set by its canonical URI.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="codes">The codes to add.</param>
        /// <exception cref="ArgumentException">If the valueset already exists in the dictionary.</exception>
        public void Add(string valueSetUri, IEnumerable<CqlCode> codes)
        {
            if (_codesInValueSet.ContainsKey(valueSetUri))
                throw new ArgumentException($"Valueset {valueSetUri} already exists in dictionary.");

            var internedCodes = codes.Select(Intern);
            _codesInValueSet.Add(valueSetUri, new InMemoryValueSet(internedCodes));
        }

        /// <inheritdoc/>
        /// <exception cref="CqlException{TError}">
        /// The value set was not added to this dictionary; the error is a <see cref="CqlUnresolvedValueSetError"/>.
        /// </exception>
        public bool IsCodeInValueSet(string valueSetUri, string code) =>
            GetAddedValueSet(valueSetUri).IsCodeInValueSet(code);

        /// <inheritdoc/>
        /// <exception cref="CqlException{TError}">
        /// The value set was not added to this dictionary; the error is a <see cref="CqlUnresolvedValueSetError"/>.
        /// </exception>
        public bool IsCodeInValueSet(string valueSetUri, string code, string? systemUriOrOid) =>
            GetAddedValueSet(valueSetUri).IsCodeInValueSet(code, systemUriOrOid);

        /// <inheritdoc/>
        /// <exception cref="CqlException{TError}">
        /// The value set was not added to this dictionary; the error is a <see cref="CqlUnresolvedValueSetError"/>.
        /// </exception>
        public bool IsCodeInValueSet(string valueSetUri, CqlCode code) =>
            GetAddedValueSet(valueSetUri).IsCodeInValueSet(code);

        // A value set this dictionary does not hold cannot answer a membership test: 'false' would claim the code
        // is not in it, so this signals the run-time error the specification requires for a value set reference
        // that cannot be resolved.
        private IValueSetFacade GetAddedValueSet(string valueSetUri) =>
            _codesInValueSet.TryGetValue(valueSetUri, out var vs)
                ? vs
                : throw new CqlUnresolvedValueSetError(valueSetUri).ToException();

        /// <summary>
        /// Tries to get the codes in the value set as an <see cref="IReadOnlyCollection{CqlCode}"/>.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="codes">The <see langword="out"/> parameter for the value set's codes, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the given value set is defined; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// A value set that was not added gives <see langword="false"/> rather than an error, unlike the
        /// <c>IsCodeInValueSet</c> overloads, so expanding it to its codes yields no codes.
        /// </remarks>
        public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes)
        {
            if (_codesInValueSet.TryGetValue(valueSetUri, out var codeSet))
            {
                codes = codeSet;
                return true;
            }
            codes = null!;
            return false;
        }

        private readonly Dictionary<string, IValueSetFacade> _codesInValueSet = new(StringComparer.OrdinalIgnoreCase);
        private readonly ICqlComparer<CqlCode> _comparer;
    }
}