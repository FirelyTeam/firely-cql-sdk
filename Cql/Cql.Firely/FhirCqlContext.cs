/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
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
    public class FhirCqlContext : CqlContext
    {
        internal FhirCqlContext(IDataRetriever? retriever = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null,
            FhirModelBindingOptions? options = null) :
            base(
                new FhirModelBindingSetup(retriever, valueSets, now, options).Operators,
                parameters,
                delegates,
                extensionState: null)
        {
            // Nothing
        }

        /// <summary>
        /// Factory method for creating a setup of the engine with the given <see cref="Bundle"/>.
        /// </summary>
        public static FhirCqlContext ForBundle(Bundle? bundle = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null,
            FhirModelBindingOptions? options = null)
        {
            IDataRetriever retriever = bundle is not null ?
              new BundleDataRetriever(bundle, valueSets ?? new HashValueSetDictionary()) :
              new CompositeDataRetriever();

            return WithRetriever(retriever, parameters, valueSets, now, delegates, options);
        }

        /// <summary>
        /// Factory method for creating a setup of the engine with the given <see cref="IDataRetriever"/>.
        /// </summary>
        public static FhirCqlContext WithRetriever(IDataRetriever? retriever = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null,
            FhirModelBindingOptions? options = null)
        {
            return new(retriever, parameters, valueSets, now, delegates, options);
        }
    }
}
