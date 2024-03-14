using Microsoft.Extensions.Logging;
using System;
using Hl7.Cql.Elm;
using Hl7.Cql.Abstractions;

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
    private readonly Lazy<LibrarySetExpressionBuilder> _librarySetExpressionBuilder;

    public LibrarySetExpressionBuilderFactory(ILoggerFactory loggerFactory)
    {
        _librarySetExpressionBuilder = Deferred(() => new LibrarySetExpressionBuilder(Logger<LibrarySetExpressionBuilder>()));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
    }

    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder => _librarySetExpressionBuilder.Value;
}

internal interface ILibraryError : ICqlError
{
    string FilePath { get; }
    Library Library { get; }
}

internal readonly record struct LibraryNotFoundByKey(string Key) : ICqlError
{
    public string GetMessage() => $"Library was not found by key. Key: '{Key}'";
}

internal readonly record struct LibraryMissingIncludeDefPathError(string FilePath, Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition with a missing path. Library Path: '{FilePath}'";
}

internal readonly record struct LibraryIncludeDefUnresolvedError(string FilePath, Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition that did not resolve to a target library in the set. Library Path: '{FilePath}', IncludeDef: '{IncludeDef.NameAndVersion()}'";
}

internal readonly record struct LibraryMissingNameAndVersionError(string FilePath, Library Library) : ILibraryError
{
    public string GetMessage() => $"Library did not have a valid name and version. Library Path: '{FilePath}'";
}

internal readonly record struct LibraryNameAndVersionMustBeUniqueError(string FilePath, Library Library) : ILibraryError
{
    public string GetMessage() => $"Library did not have a unique name and version in the set. Library Path: '{FilePath}', Duplication: '{Library.NameAndVersion}'";
}