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
    /// <remarks>
    /// This class is sealed to enable JIT optimizations including devirtualization and aggressive inlining
    /// of hot-path methods like <see cref="GetOrCompute{T}"/>, which is called frequently during CQL expression evaluation.
    /// Sealing allows the JIT to optimize method calls by eliminating virtual dispatch overhead and improving
    /// performance in the critical expression caching code path.
    /// </remarks>
    public sealed partial class CqlContext
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
        internal CqlContext(
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
        /// Gets or computes a cached value for the specified cache index.
        /// </summary>
        /// <typeparam name="T">The type of the cached value.</typeparam>
        /// <param name="cacheIndex">The cache index identifying the cached expression.</param>
        /// <param name="factory">A function to compute the value if it's not in the cache.</param>
        /// <returns>The cached or newly computed value.</returns>
        /// <remarks>
        /// <para>
        /// <strong>⚠️ INTERNAL USE ONLY</strong> - This method is intended to be called only by generated CQL libraries.
        /// Do not call this method directly in application code.
        /// </para>
        /// <para>
        /// This method provides direct access to the invocation cache without interface casting overhead,
        /// enabling better JIT inlining and performance for the hot-path expression evaluation in generated libraries.
        /// </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [EditorBrowsable(EditorBrowsableState.Never)] // Hide from IntelliSense
        [Browsable(false)] // Hide from property grids and designers
        public T GetOrCompute<T>(int cacheIndex, Func<CqlContext, T> factory)
        {
            var cache = _cache;
            if (cache is null)
                return factory(this);

            return cache.GetOrCompute(cacheIndex, factory, this);
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
    }
}
