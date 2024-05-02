/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Factory methods to initialize an <see cref="CqlContext"/> that uses the SDK POCO model
    /// as binding for the Cql engine, supplying data using POCO instances.
    /// </summary>
    public static class FhirCqlContext
    {
        internal static CqlContext createContext(IDataSource? dataSource = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null,
            FhirModelBindingOptions? options = null) =>
            new CqlContext(
                new FhirModelBindingSetup(dataSource, valueSets, now, options).Operators,
                parameters,
                delegates);

        /// <summary>
        /// Factory method for creating a setup of the engine with the given <see cref="Bundle"/>.
        /// </summary>
        public static CqlContext ForBundle(Bundle? bundle = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null,
            FhirModelBindingOptions? options = null)
        {
            IDataSource source = bundle is not null ?
              new BundleDataSource(bundle, valueSets ?? new HashValueSetDictionary()) :
              new CompositeDataSource();

            return WithDataSource(source, parameters, valueSets, now, delegates, options);
        }

        /// <summary>
        /// Factory method for creating a setup of the engine with the given <see cref="IDataSource"/>.
        /// </summary>
        public static CqlContext WithDataSource(IDataSource? source = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null,
            FhirModelBindingOptions? options = null)
        {
            return createContext(source, parameters, valueSets, now, delegates, options);
        }
    }
}
