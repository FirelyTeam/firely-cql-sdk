using Ncqa.Cql.Runtime;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public class CacheInvokedDefinitionsMutator : IExpressionMutator
    {
        public CacheInvokedDefinitionsMutator(string thisLibrary, string cacheKey)
        {
            ThisLibrary = thisLibrary;
            CacheKey = cacheKey;
        }

        public string ThisLibrary { get; }
        public string CacheKey { get; }

        public IEnumerable<(string, Type)> RuntimeContextKeys
        {
            get
            {
                yield return (CacheKey, typeof(ConcurrentDictionary<string,object>));
            }
        }

        private static MethodInfo CacheGMD = typeof(CacheInvokedDefinitionsMutator).GetMethod(nameof(Cache));


        public Expression Mutate(Expression linqExpression, elm.Expression elmExpression, ExpressionBuilderContext context)
        {
            if (elmExpression is elm.ExpressionRefExpression refExpression)
            {
                var method = CacheGMD.MakeGenericMethod(linqExpression.Type);
                string? lib = null;
                if (!string.IsNullOrWhiteSpace(refExpression.libraryName))
                    lib = context.LocalLibraryIdentifiers[refExpression.libraryName!];
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
