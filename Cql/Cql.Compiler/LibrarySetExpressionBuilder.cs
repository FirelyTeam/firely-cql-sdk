using Microsoft.Extensions.Logging;
using System;

namespace Hl7.Cql.Compiler;

internal class LibrarySetExpressionBuilder
{
    private readonly ILogger<LibrarySetExpressionBuilder> _logger;

    public LibrarySetExpressionBuilder(ILogger<LibrarySetExpressionBuilder> logger)
    {
        _logger = logger;
    }
}


internal class LibrarySetExpressionBuilderContext : IBuilderContext
{
    // Load a set of ELM libraries from a folder (in parallel) into a dictionary by name and version (maybe also alias?)
    // Topologically sort them by their included libraries


    public IBuilderContext? OuterContext => null; // This is the top level
    public BuilderContextInfo ContextInfo { get; } = new();
}

internal class LibrarySetExpressionBuilderFactory
{
    private Lazy<LibrarySetExpressionBuilder> _librarySetExpressionBuilder;

    public LibrarySetExpressionBuilderFactory(ILoggerFactory loggerFactory)
    {
        _librarySetExpressionBuilder = Deferred(() => new LibrarySetExpressionBuilder(Logger<LibrarySetExpressionBuilder>()));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
    }
    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder => _librarySetExpressionBuilder.Value;
}