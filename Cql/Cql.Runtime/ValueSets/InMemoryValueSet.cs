/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// An <see cref="IValueSetFacade"/> that has all the codes in memory.
    /// </summary>
    public class InMemoryValueSet : IValueSetFacade
    {
        private const string NullCodeSystem = "\0";

        internal static readonly InMemoryValueSet Empty = new([]);

        private readonly Lazy<IReadOnlySet<CqlCode>> _lazyContents;

        private readonly Lazy<IReadOnlySet<CqlCode>> _lazyContentsByCode;

        private IReadOnlySet<CqlCode> Contents => _lazyContents.Value;

        private IReadOnlySet<CqlCode> ContentsByCode => _lazyContentsByCode.Value;

        /// <summary>
        /// Creates a new <see cref="InMemoryValueSet"/> with the given <paramref name="contents"/>.
        /// If will use the default <see cref="CqlCodeCqlComparer.Default"/>.
        /// </summary>
        public InMemoryValueSet(IEnumerable<CqlCode> contents) : this(contents, CqlCodeCqlComparer.Default)
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
            }
            else
            {
                var equalityComparer = comparer?.ToEqualityComparer() ?? throw new ArgumentNullException(nameof(comparer));
                _lazyContents = new Lazy<IReadOnlySet<CqlCode>>(() => new HashSet<CqlCode>(contents, equalityComparer));

                _lazyContentsByCode = new Lazy<IReadOnlySet<CqlCode>>(
                    () => new HashSet<CqlCode>(contents, EqualityComparerFactory.For<CqlCode>.CreateByKey(cqlCode => cqlCode.code ?? "\0")));
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Contents).GetEnumerator();

        IEnumerator<CqlCode> IEnumerable<CqlCode>.GetEnumerator() => Contents.GetEnumerator();

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string code) => ContentsByCode.Contains(new CqlCode(code, NullCodeSystem));

        /// <inheritdoc/>
        public bool IsCodeInValueSet(string code, string? system) => ContentsByCode.Contains(new CqlCode(code, system));

        /// <inheritdoc/>
        public bool IsCodeInValueSet(CqlCode code) => Contents.Contains(code);

#pragma warning disable RS0016
#pragma warning disable CS1591
#pragma warning disable CS1503
        public InMemoryValueSet Add(CqlCode code, ICqlComparer<CqlCode> comparer) => new(Contents.Append(code), comparer);
    }
}