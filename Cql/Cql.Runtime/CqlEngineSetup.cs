/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// A factory that creates instances of contexts used by the evaluation engine.
    /// </summary>
    public class CqlEngineSetup
    {
        private readonly ICqlModelBindingProvider _bindingProvider;
        private readonly IDataRetriever? _retriever;
        private readonly IDictionary<string, object>? _parameters;
        private readonly IValueSetDictionary? _valueSets;
        private readonly DateTimeOffset? _now;
        private readonly DefinitionDictionary<Delegate>? _delegates;

        internal CqlEngineSetup(ICqlModelBindingProvider bindingProvider, IDataRetriever? retriever = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null)
        {
            _bindingProvider = bindingProvider;
            _retriever = retriever;
            _parameters = parameters;
            _valueSets = valueSets;
            _now = now;
            _delegates = delegates;
        }

        internal EventHandler<MessageEventArgs>? MessageReceived { get; set; }

        /// <summary>
        /// Creates a new CqlContex, using a new set of operators provided by the
        /// <see cref="ICqlModelBindingProvider"/>.
        /// </summary>
        public CqlContext NewContext()
        {
            var operators = _bindingProvider.NewOperators(_retriever, _valueSets, _now);

            if (MessageReceived is not null)
                operators.MessageReceived += MessageReceived;

            return new CqlContext(operators, _delegates, _parameters);
        }

        /// <summary>
        /// Returns a fresh instance implementing <see cref="ICqlOperators" />.
        /// </summary>
        /// <returns></returns>
        public ICqlOperators NewOperators() => NewContext().Operators;
    }
}
