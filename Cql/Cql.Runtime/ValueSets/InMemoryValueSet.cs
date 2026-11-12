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
    /// An <see cref="IValueSetFacade"/> that has all the codes in memory.
    /// </summary>
    public class InMemoryValueSet : IValueSetFacade
    {
        private const string NullCodeSystem = "\0";

        private static readonly ICqlComparer<CqlCode> DefaultComparer = CqlCodeCqlComparer.OrdinalIgnoreCase;

        internal static readonly InMemoryValueSet Empty = new([]);

        private readonly Lazy<IReadOnlySet<CqlCode>> _lazyContents;

        private readonly Lazy<IReadOnlySet<CqlCode>> _lazyContentsByCode;

        private readonly Lazy<bool> _lazyHoldsCodesFromSeveralSystems;

        private IReadOnlySet<CqlCode> Contents => _lazyContents.Value;

        private IReadOnlySet<CqlCode> ContentsByCode => _lazyContentsByCode.Value;

        /// <summary>
        /// Creates a new <see cref="InMemoryValueSet"/> with the given <paramref name="contents"/>.
        /// If will use the default <see cref="CqlCodeCqlComparer.OrdinalIgnoreCase"/>.
        /// </summary>
        public InMemoryValueSet(IEnumerable<CqlCode> contents) : this(contents, DefaultComparer)
        {
            // nothing
        }


        /// <summary>
        /// Creates a new <see cref="InMemoryValueSet"/> with the given <paramref name="contents"/>, which
        /// will use a specific <paramref name="comparer"/>.
        /// </summary>
        public InMemoryValueSet(IEnumerable<CqlCode> contents, ICqlComparer<CqlCode> comparer)
        {
            if (contents is null) throw new ArgumentNullException(nameof(contents));

            if (contents is InMemoryValueSet imvs)
            {
                // Since the InMemoryValueSet is immutable, we can simply re-use its contents.
                _lazyContents = imvs._lazyContents;
                _lazyContentsByCode = imvs._lazyContentsByCode;
                _lazyHoldsCodesFromSeveralSystems = imvs._lazyHoldsCodesFromSeveralSystems;
            }
            else
            {
                var equalityComparer = comparer?.ToEqualityComparer() ?? throw new ArgumentNullException(nameof(comparer));
                _lazyContents = new Lazy<IReadOnlySet<CqlCode>>(() => new HashSet<CqlCode>(contents, equalityComparer));

                var equivalenceComparer = comparer.ToEqualityComparer(useEquivalence: true);
                _lazyContentsByCode = new Lazy<IReadOnlySet<CqlCode>>(() => new HashSet<CqlCode>(contents.Concat(makeContentsWithNullSystem()), equivalenceComparer));

                IEnumerable<CqlCode> makeContentsWithNullSystem() => contents.Select(c => new CqlCode(c.code, NullCodeSystem));

                _lazyHoldsCodesFromSeveralSystems = new Lazy<bool>(() => HoldsCodesFromSeveralSystems(Contents));
            }
        }

        // Code systems are told apart ignoring case, as the default comparer compares them. A code without a system
        // names no system, so it does not add one, and an entry without a code is no code at all.
        private static bool HoldsCodesFromSeveralSystems(IEnumerable<CqlCode> codes)
        {
            string? firstSystem = null;
            foreach (var code in codes)
            {
                if (code.code is null || code.system is null)
                    continue;

                if (firstSystem is null)
                    firstSystem = code.system;
                else if (!StringComparer.OrdinalIgnoreCase.Equals(firstSystem, code.system))
                    return true;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Contents).GetEnumerator();

        IEnumerator<CqlCode> IEnumerable<CqlCode>.GetEnumerator() => Contents.GetEnumerator();

        /// <inheritdoc/>
        /// <exception cref="CqlException{TError}">
        /// This value set holds codes from more than one code system; the error is a
        /// <see cref="CqlAmbiguousStringInValueSetError"/>. Tested on its own, this value set does not know its
        /// canonical URI, so the error's <see cref="CqlAmbiguousStringInValueSetError.ValueSetUri"/> is
        /// <see langword="null"/>; a dictionary that holds it names the value set.
        /// </exception>
        public bool IsCodeInValueSet(string code) => IsStringInValueSet(valueSetUri: null, code);

        /// <summary>
        /// The membership test of a code without a system, as <see cref="IsCodeInValueSet(string)"/> makes it, for an
        /// <see cref="IValueSetDictionary"/> that holds this value set as <paramref name="valueSetUri"/> and names it in
        /// the error.
        /// </summary>
        /// <remarks>
        /// A <see langword="null"/> code is not in the value set, whatever code systems the value set holds.
        /// </remarks>
        internal bool IsStringInValueSet(string? valueSetUri, string? code)
        {
            if (code is null)
                return false;

            // CQL 9.B, In (Valueset): the code cannot say which code system it is from, so a value set of several
            // systems makes the test ambiguous, which is a run-time error.
            if (_lazyHoldsCodesFromSeveralSystems.Value)
                throw new CqlAmbiguousStringInValueSetError(valueSetUri, code).ToException();

            return ContentsByCode.Contains(new CqlCode(code, NullCodeSystem));
        }

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string code, string? system) => ContentsByCode.Contains(new CqlCode(code, system));

        /// <inheritdoc/>
        public bool IsCodeInValueSet(CqlCode code) => Contents.Contains(code);
    }
}