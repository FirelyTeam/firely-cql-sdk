/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

#nullable enable

namespace Hl7.Cql.Firely
{
    public class BundleDataRetriever : IDataRetriever
    {
        public BundleDataRetriever(Bundle bundle,
            IValueSetDictionary valueSets,
            ICqlComparer? codeComparer = null, ICqlComparer? systemComparer = null)
        {
            ValueSets = valueSets ?? throw new ArgumentNullException(nameof(valueSets));
            _codeComparer = codeComparer ?? DefaultStringComparer.Value;
            _systemComparer = systemComparer ?? DefaultStringComparer.Value;
            Bundle = bundle is not null ? new IndexedBundle(bundle.Entry) : throw new ArgumentNullException(nameof(bundle));
        }


        private static readonly Lazy<ICqlComparer> DefaultStringComparer = new(() =>
            new StringCqlComparer(StringComparer.OrdinalIgnoreCase));

        private IndexedBundle Bundle { get; init; }
        private IValueSetDictionary ValueSets { get; }

        private readonly ICqlComparer _codeComparer;
        private readonly ICqlComparer _systemComparer;

        public IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? allowedCodes = null) where T : class
        {
            if (allowedCodes is not null)
            {
                if (!typeof(T).IsAssignableTo(typeof(ICoded)))
                    throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T)}. None is defined.");

                if (allowedCodes is IValueSetFacade valueSet)
                {
                    return Bundle.FilterByType<T>(c => valueSet.IsCodeInValueSet(c.Code, c.System) == true);
                }
                else
                {
                    return Bundle.FilterByType<T>(isAllowed);
                }

                bool isAllowed(Coding l) => allowedCodes.Any(allowed =>
                    allowed is not null &&
                    _systemComparer.Equivalent(l.System, allowed.system, null) &&
                    _codeComparer.Equivalent(l.Code, allowed.code, null));
            }
            else
            {
                return Bundle.FilterByType<T>();
            }
        }

        public IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null) where T : class
        {
            if (valueSet != null && valueSet.id != null)
            {
                if (!typeof(T).IsAssignableTo(typeof(ICoded)))
                    throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T)}. None is defined.");

                return Bundle.FilterByType<T>(c => ValueSets.IsCodeInValueSet(valueSet.id, c.Code, c.System));
            }
            else
            {
                return Bundle.FilterByType<T>();
            }
        }
    }
}

#nullable disable