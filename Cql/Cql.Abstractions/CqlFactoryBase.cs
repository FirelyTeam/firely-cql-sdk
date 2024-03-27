using System;
using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Abstractions;

internal abstract class CqlFactoryBase
{
    private readonly ConcurrentDictionary<Type, object> _singletons;

    protected CqlFactoryBase(ILoggerFactory loggerFactory)
    {
        _singletons = new ConcurrentDictionary<Type, object>();
        LoggerFactory = loggerFactory;
    }

    protected ILoggerFactory LoggerFactory { get; }

    protected virtual ILogger<T> Logger<T>() => Transient(LoggerFactory.CreateLogger<T>);

    protected virtual IOptions<T> Options<T>(T options) where T : class => Singleton(() => Microsoft.Extensions.Options.Options.Create(options));

    protected virtual T Transient<T>(Func<T> fn) => fn();

    protected virtual T Singleton<T>(Func<T> fn) => (T)_singletons.GetOrAdd(typeof(T), _ => fn()!);
}