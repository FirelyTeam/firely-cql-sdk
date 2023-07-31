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
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// An <see cref="IValueSetFacade"/> that has all the codes in memory.
    /// </summary>
    public class InMemoryValueSet : IValueSetFacade
    {
        private const string NullCodeSystem = "\0";

        private static readonly ICqlComparer<CqlCode> _defaultComparer = new CqlCodeCqlComparer();

        public static readonly InMemoryValueSet EMPTY = new(Enumerable.Empty<CqlCode>());

        private readonly Lazy<IReadOnlySet<CqlCode>> _lazyContents;

        private readonly Lazy<IReadOnlySet<CqlCode>> _lazyContentsByCode;

        private IReadOnlySet<CqlCode> _contents => _lazyContents.Value;

        private IReadOnlySet<CqlCode> _contentsByCode => _lazyContentsByCode.Value;

        public InMemoryValueSet(IEnumerable<CqlCode> contents) : this(contents, _defaultComparer)
        {
            // nothing
        }

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
                _lazyContents = new(() => new HashSet<CqlCode>(contents, equalityComparer));

                var equivalenceComparer = comparer.ToEqualityComparer(useEquivalence: true);
                _lazyContentsByCode = new(() => new HashSet<CqlCode>(contents.Concat(makeContentsWithNullSystem()), equivalenceComparer));

                IEnumerable<CqlCode> makeContentsWithNullSystem() => contents.Select(c => new CqlCode(c.code, NullCodeSystem));
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_contents).GetEnumerator();

        IEnumerator<CqlCode> IEnumerable<CqlCode>.GetEnumerator() => _contents.GetEnumerator();

        public bool IsCodeInValueSet(string code) => _contentsByCode.Contains(new CqlCode(code, NullCodeSystem));

        public bool IsCodeInValueSet(string code, string? system) => _contentsByCode.Contains(new CqlCode(code, system));

        public bool IsCodeInValueSet(CqlCode code) => _contents.Contains(code);
    }
}
