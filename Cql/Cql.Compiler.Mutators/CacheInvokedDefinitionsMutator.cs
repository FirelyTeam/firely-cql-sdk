using Ncqa.Cql.Runtime;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler.Mutators
{
    /// <summary>
    /// An <see cref="IExpressionMutator"/> which memoizes parameterless functions (e.g., defines).
    /// This is useful when compiling <see cref="DefinitionDictionary{LambdaExpression}"/> to <see cref="DefinitionDictionary{Delegate}"/>.
    /// </summary>
    public class CacheInvokedDefinitionsMutator : IExpressionMutator
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="thisLibrary">The name and version identifier for the library being built by <see cref="ExpressionBuilder.Build"/>.</param>
        /// <param name="cacheKey">The cache key into the <see cref="RuntimeContext.Extensions"/> dictionary this caching mutator will use.</param>
        public CacheInvokedDefinitionsMutator(string thisLibrary, string cacheKey)
        {
            ThisLibrary = thisLibrary;
            CacheKey = cacheKey;
        }

        /// <summary>
        /// The name and version identifier for the library being built by <see cref="ExpressionBuilder.Build"/>.
        /// </summary>
        public string ThisLibrary { get; }

        /// <summary>
        /// Gets the key into the <see cref="RuntimeContext.Extensions"/> dictionary this caching mutator will use.
        /// </summary>
        public string CacheKey { get; }

        /// <summary>
        /// Returns <see cref="CacheKey"/>.
        /// </summary>
        public IEnumerable<(string, Type)> RuntimeContextKeys
        {
            get
            {
                yield return (CacheKey, typeof(ConcurrentDictionary<string,object>));
            }
        }

        private static MethodInfo CacheGMD = typeof(CacheInvokedDefinitionsMutator).GetMethod(nameof(Cache));

        /// <summary>
        /// Mutates <see cref="elm.ExpressionRefExpression"/>  to call <see cref="Cache{T}(string, string, string, string, RuntimeContext)"/> before returning its computed value.
        /// </summary>
        /// <param name="linqExpression">The LINQ expression.</param>
        /// <param name="elmExpression">The ELM expression.</param>
        /// <param name="context">The runtime context.</param>
        /// <returns>A <see cref="MethodCallExpression"/> which calls <see cref="Cache{T}(string, string, string, string, RuntimeContext)"/>.</returns>
        public Expression Mutate(Expression linqExpression, elm.Expression elmExpression, ExpressionBuilderContext context)
        {
            if (elmExpression is elm.ExpressionRefExpression refExpression)
            {
                var method = CacheGMD.MakeGenericMethod(linqExpression.Type);
                string? lib = null;
                if (!string.IsNullOrWhiteSpace(refExpression.libraryName))
                    lib = context.LibraryIdentifiers.Single(kvp => kvp.Key == refExpression.libraryName!).Value;
                var call = Expression.Call(method, 
                    Expression.Constant(lib, typeof(string)), 
                    Expression.Constant(refExpression.name, typeof(string)),
                    Expression.Constant(CacheKey, typeof(string)), 
                    Expression.Constant(ThisLibrary, typeof(string)),
                    context.RuntimeContextParameter);
                return call;
            }
            return linqExpression;
        }

        /// <summary>
        /// Gets the value of the definition, caching its value first if necessary.
        /// </summary>
        /// <typeparam name="T">The result type of the original expression.</typeparam>
        /// <param name="library">The library in which this define is contained.</param>
        /// <param name="name">The name of the definition.</param>
        /// <param name="cacheKey">The <see cref="CacheKey"/> set on the mutator making this call.</param>
        /// <param name="thisLibrary">The value of <see cref="ThisLibrary"/> set on the mutator making this call.</param>
        /// <param name="rtx">The runtime context.</param>
        /// <returns>The cached value.</returns>
        /// <exception cref="InvalidOperationException">If the <see cref="RuntimeContext.Extensions"/> value for <paramref name="cacheKey"/> is not a <see cref="ConcurrentDictionary{string, object}"/>, or the cached value's type is not <typeparamref name="T"/>.</exception>
        public static T Cache<T>(string library, string name, string cacheKey, string thisLibrary, RuntimeContext rtx)
        {
            ConcurrentDictionary<string, object?>? definitionCache = null;
            if (!rtx.Extensions.TryGetValue(cacheKey, out var obj))
            {
                definitionCache = new ConcurrentDictionary<string, object?>();
                rtx.Extensions.TryAdd(cacheKey, definitionCache);
            }
            else if (obj is ConcurrentDictionary<string, object?> d)
            {
                definitionCache = d;
            }
            else throw new InvalidOperationException($"Runtime context key {cacheKey} is not a dictionary, and should be.");

            if (definitionCache.TryGetValue(name!, out var cachedValue))
            {
                if (cachedValue is T t)
                    return t;
                else if (cachedValue is not null)
                    throw new InvalidOperationException($"Cached value in {cacheKey}.{name} is not type {typeof(T).FullName}");
                else return (T)(null as object)!;
            }
            else
            {
                var libName = string.IsNullOrWhiteSpace(library) ? thisLibrary : library;
                var definitionName = name;
                var @delegate = rtx.Definitions[libName, definitionName];
                var value = (T)@delegate.DynamicInvoke(rtx);
                definitionCache.TryAdd(definitionName, value);
                return value;
            }
        }
    }
}
