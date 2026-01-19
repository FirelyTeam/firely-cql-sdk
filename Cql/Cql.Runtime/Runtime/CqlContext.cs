/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Contains information required to execute CQL.
    /// </summary>
    public partial class CqlContext
    {
        /// <summary>
        /// Contains all definitions required during execution.
        /// </summary>
        public DelegateDefinitionDictionary Definitions { get; } = new();

        /// <summary>
        /// Gets the implementation of <see cref="ICqlOperators"/> this execution uses.
        /// </summary>
        public ICqlOperators Operators { get; }

        /// <summary>
        /// Gets the values of library parameters for this execution.
        /// </summary>
        /// <remarks>
        /// To scope a parameter to an individual library, use it's name and version string (e.g., "library-version") followed by <see cref="ParameterDelimiter"/> followed by the parameter name,
        /// e.g. "library-version.parameter name".
        /// To scope a parameter globally, omit the library name and version.  If two libraries define the same parameter name but use different types, runtime errors will occur.
        /// If the value provided for a given parameter name is the incorrect type, a runtime error will occur.
        /// </remarks>
        public IDictionary<string, object> Parameters { get; }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="operators">The <see cref="ICqlOperators"/> implementation to use.</param>
        /// <param name="parameters">The input parameters, or <see langword="null"/>. </param>
        protected internal CqlContext(
            ICqlOperators operators,
            IDictionary<string, object>? parameters = null)
        {
            Operators = operators;
            Parameters = parameters ?? new Dictionary<string, object>();
        }

        /// <summary>
        /// Notifies subscribers when a CQL Message has been dispatched.
        /// </summary>
        public event EventHandler<MessageEventArgs>? MessageReceived
        {
            add => Operators.MessageReceived += value;
            remove => Operators.MessageReceived -= value;
        }

        /// <summary>
        /// Notifies subscribers when a generic event is raised in the engine.
        /// </summary>
        public event EventHandler<ContextEventArgs>? ContextEvent;

        /// <summary>
        /// Raise the <see cref="ContextEvent"/> event.
        /// </summary>
        public CqlContext RaiseContextEvent(ContextEventArgs eventData)
        {
            ContextEvent?.Invoke(this, eventData);
            return this;
        }

        /// <summary>
        /// Defines the delimiter separating library names from parameter names.
        /// </summary>
        private const string ParameterDelimiter = ".";

        /// <summary>
        /// Gets the value of the parameter in <see cref="Parameters"/> given the library and parameter name.
        /// </summary>
        /// <param name="libraryVersionedIdentifier">The library name and version.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="defaultValue">The value to returns when the parameter could not be resolved.</param>
        /// <returns>The value of the parameter or <see langword="null"/> if not defined.</returns>
        public object? ResolveParameter(string libraryVersionedIdentifier, string parameterName, object? defaultValue)
        {
            var fullyQualified = $"{libraryVersionedIdentifier}{ParameterDelimiter}{parameterName}";
            if (Parameters.TryGetValue(fullyQualified, out var parameter))
                return parameter;

            if (Parameters.TryGetValue(parameterName, out var resolveParameter))
                return resolveParameter;

            return defaultValue;
        }

        /// <summary>
        /// Invalidates the current cache, forcing subsequent operations to use fresh data.
        /// </summary>
        /// <remarks>Call this method to clear any cached data and ensure that future operations do not use stale
        /// information. This is useful when the underlying data source has changed and the cache needs to be
        /// refreshed.</remarks>
        public void UseNewCache()
        {
            // Use array size that accommodates typical library sizes (1-20 definitions)
            // while keeping it small for cache efficiency. Power of 2 for better modulo performance.
            const int DefaultCacheSize = 64;
            _cache = new CacheEntry[DefaultCacheSize];
            _cacheCallCount = 0;
            _cacheFactoryInvocations = 0;
        }

        /// <summary>
        /// Disables caching for subsequent operations by resetting the cache state.
        /// </summary>
        /// <remarks>Call this method to ensure that future operations do not use any previously cached data. This
        /// may impact performance if caching is typically used to improve efficiency.</remarks>
        public void DontUseCaching()
        {
            _cache = null;
            _cacheCallCount = 0;
            _cacheFactoryInvocations = 0;
        }
    }
}
