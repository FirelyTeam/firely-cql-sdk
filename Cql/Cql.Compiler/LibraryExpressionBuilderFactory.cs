// using System;
// using Hl7.Cql.Compiler;
// using Microsoft.Extensions.Logging;
//
// namespace Hl7.Cql.Packaging;
//
// /// <summary>
// /// This creates all services necessary for a <see cref="LibraryExpressionBuilder"/>.
// /// The idea is not to inject this into service types, it's purpose is to
// /// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
// /// </summary>
// internal class LibraryExpressionBuilderFactory : ExpressionBuilderFactory
// {
//     private readonly Lazy<LibraryExpressionBuilder> _libraryExpressionsBuilder;
//
//     public LibraryExpressionBuilderFactory(ILoggerFactory loggerFactory, int cacheSize = 0) : base(loggerFactory, cacheSize)
//     {
//         _libraryExpressionsBuilder = Deferred(() => new LibraryExpressionBuilder(loggerFactory, ExpressionBuilder, CqlOperatorsBinding, TypeManager));
//
//
//         static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);
//
//         //ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
//     }
//
//     public LibraryExpressionBuilder LibraryExpressionBuilder => _libraryExpressionsBuilder.Value;
// }