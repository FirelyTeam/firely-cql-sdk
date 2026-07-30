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
    /// <para>
    /// <b>Thread safety.</b> One instance may be shared by several threads that evaluate definitions
    /// concurrently, as long as the following contract is honoured. Outside this contract an instance is
    /// meant to be used by a single thread at a time.
    /// </para>
    /// <list type="bullet">
    /// <item><description>
    /// <see cref="Definitions"/> and <see cref="Parameters"/> must be fully populated before the concurrent
    /// evaluation starts, and must not be mutated while it runs. Both are ordinary, non-concurrent
    /// collections: concurrent reads of them are safe, a concurrent write is not.
    /// </description></item>
    /// <item><description>
    /// The definition/expression memoization cache is safe for concurrent use.
    /// <see cref="ICqlContextInternals.GetOrCompute{T}"/> reads without taking a lock and writes through a
    /// <see cref="ConcurrentDictionary{TKey,TValue}"/>. Two threads that miss on the same key may both
    /// evaluate that definition, and the value which loses the race is discarded; this is harmless because
    /// CQL expression bodies are pure, but it does mean the number of factory invocations is bounded rather
    /// than exactly one per key. Create the cache with <see cref="UseNewCache(int,int)"/> and a concurrency
    /// level matching the expected degree of parallelism, so that concurrent cache writes do not serialize on
    /// a single lock.
    /// </description></item>
    /// <item><description>
    /// The <see cref="Operators"/> implementation — in particular the data source and the value set
    /// implementations reachable through it — must tolerate concurrent reads. The data behind them is
    /// expected to be immutable for the duration of the evaluation; changing it while threads are evaluating
    /// produces undefined results and leaves stale values in the cache.
    /// </description></item>
    /// </list>
    /// </remarks>
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
        /// <param name="initialCapacity">The initial capacity of the definition/expression memoization cache.
        /// Sizing this to (an upper bound of) the number of definitions/expressions expected to be cached during
        /// the evaluation avoids internal resizing of the cache. Must be at least <see cref="MinimumCacheInitialCapacity"/>.
        /// Defaults to <see cref="CacheInitialCapacity"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="initialCapacity"/> is less than
        /// <see cref="MinimumCacheInitialCapacity"/>.</exception>
        /// <remarks>Call this method to clear any cached data and ensure that future operations do not use stale
        /// information. This is useful when the underlying data source has changed and the cache needs to be
        /// refreshed.
        /// <para>The cache is created for sequential evaluation. To size it for evaluation spread over several
        /// threads, use <see cref="UseNewCache(int,int)"/>.</para></remarks>
        // RS0027 wants the overload carrying optional parameters to be the one with the most parameters. This
        // overload has shipped with its default and cannot grow a parameter without breaking binary compatibility,
        // so the concurrency level is offered through a separate, fully explicit overload instead.
#pragma warning disable RS0027 // API with optional parameter(s) should have the most parameters amongst its public overloads
        public void UseNewCache(int initialCapacity = CacheInitialCapacity) =>
            UseNewCache(initialCapacity, SequentialCacheConcurrencyLevel);
#pragma warning restore RS0027

        /// <summary>
        /// Invalidates the current cache, forcing subsequent operations to use fresh data, and sizes the new cache
        /// for the given degree of write concurrency.
        /// </summary>
        /// <param name="initialCapacity">The initial capacity of the definition/expression memoization cache.
        /// Sizing this to (an upper bound of) the number of definitions/expressions expected to be cached during
        /// the evaluation avoids internal resizing of the cache. Must be at least <see cref="MinimumCacheInitialCapacity"/>.</param>
        /// <param name="concurrencyLevel">The number of threads expected to write to the cache concurrently.
        /// Must be at least <see cref="SequentialCacheConcurrencyLevel"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="initialCapacity"/> is less than
        /// <see cref="MinimumCacheInitialCapacity"/>, or <paramref name="concurrencyLevel"/> is less than
        /// <see cref="SequentialCacheConcurrencyLevel"/>.</exception>
        /// <remarks>
        /// <para>Call this method to clear any cached data and ensure that future operations do not use stale
        /// information.</para>
        /// <para><paramref name="concurrencyLevel"/> determines how many internal locks the cache spreads its
        /// writes over. Reads never take a lock, whatever the value, so this only affects the cost of caching a
        /// newly computed value: with the sequential level of <see cref="SequentialCacheConcurrencyLevel"/> all
        /// cache misses on all threads contend for one write lock, while a higher level lets misses on different
        /// keys be stored in parallel. Set it to (an estimate of) the number of threads that will evaluate
        /// definitions over this context at the same time — for example <see cref="Environment.ProcessorCount"/>
        /// when fanning evaluation out over the available cores. Sharing a context across threads additionally
        /// requires the contract documented on <see cref="CqlContext"/>.</para>
        /// </remarks>
        public void UseNewCache(int initialCapacity, int concurrencyLevel)
        {
            if (initialCapacity < MinimumCacheInitialCapacity)
                throw new ArgumentOutOfRangeException(
                    nameof(initialCapacity),
                    initialCapacity,
                    $"The initial cache capacity must be at least {MinimumCacheInitialCapacity}.");

            if (concurrencyLevel < SequentialCacheConcurrencyLevel)
                throw new ArgumentOutOfRangeException(
                    nameof(concurrencyLevel),
                    concurrencyLevel,
                    $"The cache concurrency level must be at least {SequentialCacheConcurrencyLevel}.");

            // Pre-size the cache to avoid repeated resizes, which acquire all internal locks and dominated the
            // write cost with the default settings. A cache populated by mostly-sequential definition evaluation
            // only needs a single lock; more locks pay off once several threads store cache misses at once.
            _cache = new ConcurrentDictionary<long, object?>(concurrencyLevel, capacity: initialCapacity);
            _cacheCallCount = 0;
            _cacheFactoryInvocations = 0;
        }

        /// <summary>
        /// The default initial capacity of the definition/expression memoization cache. Sized to hold the
        /// cached results of a typical measure evaluation (all definitions across all libraries in
        /// a library set) without internal resizing.
        /// </summary>
        public const int CacheInitialCapacity = 1024;

        /// <summary>
        /// The smallest initial capacity accepted by <see cref="UseNewCache(int)"/>. Values below this are
        /// rejected because they defeat the purpose of pre-sizing the cache: it would immediately need to be
        /// resized as definitions/expressions are evaluated.
        /// </summary>
        public const int MinimumCacheInitialCapacity = 16;

        /// <summary>
        /// The cache concurrency level used for sequential evaluation, and the smallest value accepted by
        /// <see cref="UseNewCache(int,int)"/>. At this level every cache write goes through one internal lock.
        /// </summary>
        public const int SequentialCacheConcurrencyLevel = 1;

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
