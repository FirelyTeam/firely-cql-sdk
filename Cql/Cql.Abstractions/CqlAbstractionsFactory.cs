using System;
using System.Threading;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Abstractions;

internal abstract class CqlFactoryBase
{
    protected CqlFactoryBase(ILoggerFactory loggerFactory) => LoggerFactory = loggerFactory;

    protected ILoggerFactory LoggerFactory { get; }

    protected virtual ILogger<T> Logger<T>() => Transient(LoggerFactory.CreateLogger<T>);

    protected virtual IOptions<T> Options<T>(T options) where T : class => Singleton(() => Microsoft.Extensions.Options.Options.Create(options));

    protected static T Transient<T>(Func<T> fn) => fn();

    protected static T Singleton<T>(Func<T> fn)
    {
        var oldFn = Interlocked.CompareExchange(ref CachedSingleton<T>.CachedFunc, fn, null);

        if (oldFn is null)
            return CachedSingleton<T>.CachedValue = fn();

        if (oldFn == fn)
            return CachedSingleton<T>.CachedValue;

        throw new InvalidOperationException("Not allowed to factory method for a given singleton type."); ;
    }

    private static class CachedSingleton<T>
    {
        public static Func<T>? CachedFunc;
        public static T CachedValue = default!;
    }
}

internal class CqlAbstractionsFactory : CqlFactoryBase
{
    public CqlAbstractionsFactory(ILoggerFactory loggerFactory) : base(loggerFactory)
    {
    }
}