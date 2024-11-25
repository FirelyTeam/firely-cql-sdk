/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using System.Reflection;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// A <see cref="IDataSource"/> that uses POCO Bundles as a source of information.
    /// </summary>
    /// <remarks>A simple model that assumes the Bundles contain all the information about a
    /// patient, e.g. as the result of a $everything operation.</remarks>
    internal class BundleDataSource : IDataSource
    {
        /// <summary>
        /// Construct a new source passing in the necessary terminology information
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="valueSets"></param>
        /// <param name="codeComparer"></param>
        /// <param name="systemComparer"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public BundleDataSource(Bundle bundle,
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

#if VNEXT
        /// <inheritdoc/>
        /// <remarks>Since it is not possible to monitor changes in a FHIR POCO, this source will not trigger when
        /// external changes are made to the Bundle.</remarks>
        public event EventHandler? DataChanged;
#endif

        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class
        {
            return parameters switch
            {
                null => Bundle.FilterByType<T>(),
                { Codes: { } codes }   => RetrieveByCodes<T>(codes, parameters.CodeProperty),
                { ValueSet: { } valueSet } => RetrieveByValueSet<T>(valueSet, parameters.CodeProperty),
                _ => Bundle.FilterByType<T>()
            };
        }

        /// <inheritdoc/>
        private IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?> allowedCodes, PropertyInfo? codeProperty = null) where T : class
        {
            Predicate<Coding> filter = allowedCodes is IValueSetFacade valueSet ?
                c => valueSet.IsCodeInValueSet(c.Code, c.System) == true
                : listFilter;

            return ExecuteFilter<T>(filter, codeProperty);

            bool listFilter(Coding l) => allowedCodes.Any(allowed =>
                allowed is not null &&
                _systemComparer.Equivalent(l.System, allowed.system, null) &&
                _codeComparer.Equivalent(l.Code, allowed.code, null));
        }

        /// <inheritdoc/>
        private IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet valueSet, PropertyInfo? codeProperty = null) where T : class
        {
            return valueSet.id != null ?
                       ExecuteFilter<T>(c => ValueSets.IsCodeInValueSet(valueSet.id, c.Code, c.System), codeProperty) :
                       Bundle.FilterByType<T>();
        }

        private IEnumerable<T> ExecuteFilter<T>(Predicate<Coding> filter, PropertyInfo? codeProperty) where T : class
        {
            if (codeProperty is null)
            {
                if (!typeof(T).IsAssignableTo(typeof(ICoded)))
                    throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T)}. None is defined.");

                return Bundle.FilterByType<T>(filter);
            }
            else
            {
                IEnumerable<Coding> getCodedValues(T instance)
                {
                    var objectResult = codeProperty!.GetValue(instance);

                    return objectResult switch
                    {
                        IEnumerable<DataType> idt => idt.ToCodings(),
                        DataType dt => dt.ToCodings(),
                        _ => []
                    };
                }

                return Bundle.FilterByType<T>(filter, getCodedValues);
            }
        }
    }
}