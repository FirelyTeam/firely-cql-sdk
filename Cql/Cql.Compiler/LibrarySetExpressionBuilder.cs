using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Hl7.Cql.Elm;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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

internal class LibrarySet
{
    private readonly Dictionary<string, (string filePath, Library library)> _librariesByKey; // Key is the NameAndVersion

    public LibrarySet()
    {
        _librariesByKey = new Dictionary<string, (string filePath, Library library)>();
    }


    public void LoadLibraries(IReadOnlyCollection<FileInfo> files)
    {
        (FileInfo file, int index)[] input = files
            .Select((file, ordinal) => (file, index: ordinal))
            .ToArray();

        var libraries = new Library[input.Length];

        Parallel.ForEach(input, t =>
        {
            var library = Library.LoadFromJson(t.file);
            if (string.IsNullOrEmpty(library.NameAndVersion))
            {
                throw new ElmLibraryMissingNameAndVersionError(t.file.FullName, library).ToException();
            }
            libraries[t.index] = library;
        });

        for (var index = 0; index < libraries.Length; index++)
        {
            var library = libraries[index];
            string filePath = input[index].file.FullName;

            try
            {
                _librariesByKey.Add(library.NameAndVersion!, (filePath, library));
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                // This will be due to a duplicate key
                throw new ElmLibraryNameAndVersionMustBeUniqueError(filePath, library).ToException();
            }
        }

    }
}

internal interface IElmLibraryError : ICqlError
{
    string FilePath { get; }
    Library Library { get; }
}

internal readonly record struct ElmLibraryMissingNameAndVersionError(string FilePath, Library Library) : IElmLibraryError
{
    public string FilePath { get; init; } = FilePath;
    public Library Library { get; init; } = Library;
    public string GetMessage() => $"Library must have a valid name and version. Path: '{FilePath}'";
}

internal readonly record struct ElmLibraryNameAndVersionMustBeUniqueError(string FilePath, Library Library) : IElmLibraryError
{
    public string FilePath { get; init; } = FilePath;
    public Library Library { get; init; } = Library;
    public string GetMessage() => $"Library must have a unique name and version in the set. Collision: '{Library.NameAndVersion}', Path: '{FilePath}'";
}