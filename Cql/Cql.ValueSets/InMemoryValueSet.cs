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
using Hl7.Cql.Abstractions;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// An <see cref="IValueSetFacade"/> that has all the codes in memory.
    /// </summary>
    internal class InMemoryValueSet : IValueSetFacade
    {
        private static readonly ICqlComparer _defaultComparer = new StringCqlComparer(StringComparer.OrdinalIgnoreCase);

        private readonly Lazy<HashSet<CqlCode>> _lazyContents;
        private HashSet<CqlCode> _contents => _lazyContents.Value;

        public InMemoryValueSet(IEnumerable<CqlCode> contents) : this(contents, _defaultComparer)
        {
            // nothing
        }

        public InMemoryValueSet(IEnumerable<CqlCode> contents, ICqlComparer comparer)
        {
            if (contents is null) throw new ArgumentNullException(nameof(contents));

            var hasher = comparer?.ToEqualityComparer() ?? throw new ArgumentNullException(nameof(comparer));
            _lazyContents = new Lazy<HashSet<CqlCode>>(() => new(contents, hasher));
        }

        public bool? IsCodeInValueSet(CqlCode? code) => code is not null ? _contents.Contains(code) : false;

        public bool? IsCodeInValueSet(string? code, string? system) => IsCodeInValueSet(new CqlCode(code, system, null, null));

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_contents).GetEnumerator();

        IEnumerator<CqlCode> IEnumerable<CqlCode>.GetEnumerator() => _contents.GetEnumerator();
    }
}
