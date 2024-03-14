using System;
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// This creates all services necessary for a <see cref="LibrarySetExpressionBuilder"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class LibrarySetExpressionBuilderFactory : LibraryExpressionBuilderFactory
{
    private readonly Lazy<LibrarySetExpressionBuilder> _librarySetExpressionBuilder;

    public LibrarySetExpressionBuilderFactory(ILoggerFactory loggerFactory, int cacheSize = 0) : base(loggerFactory, cacheSize)
    {
        _librarySetExpressionBuilder = Deferred(() => new LibrarySetExpressionBuilder(Logger<LibrarySetExpressionBuilder>(), LibraryExpressionBuilder));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
    }

    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder => _librarySetExpressionBuilder.Value;
}