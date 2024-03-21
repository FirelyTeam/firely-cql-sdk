using System;
using System.Collections.Generic;
using System.IO;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.CodeGeneration.NET;

internal class CSharpSourceCodeWriterCallbacks
{
    private readonly Func<string, Stream> _getCachedStreamByName;
    private readonly Predicate<string>? _shouldWriteLibrary;
    private readonly Func<string, string?> _libraryNameToClassName;
    public bool CloseStreamsAfterEnumeration { get; }

    /// <param name="getCachedStreamByName">A function that provides a <see cref="Stream"/> to write the source code given the name of the library being generated.</param>
    /// <param name="libraryNameToClassName">Generating a class name for the library name.</param>
    /// <param name="shouldWriteLibrary">A function that determines whether the given library should be generated or not; default is <see langword="null" />.  When <see langword="null" />, all libraries are written.</param>
    /// <param name="closeStreamsAfterEnumeration">Whether to dispose streams after enumeration otherwise they stay open. Default is <c>true</c>.</param>
    public CSharpSourceCodeWriterCallbacks( 
        Func<string, Stream>? getCachedStreamByName = null, 
        Func<string, string?>? libraryNameToClassName = null, 
        Predicate<string>? shouldWriteLibrary = null,
        bool closeStreamsAfterEnumeration = true)
    {

        _getCachedStreamByName = getCachedStreamByName ?? GetDefaultStreamForLibrary();
        _libraryNameToClassName = libraryNameToClassName ?? GetDefaultLibraryNameToClassName;
        CloseStreamsAfterEnumeration = closeStreamsAfterEnumeration;
        _shouldWriteLibrary = shouldWriteLibrary;

    }

    private static Func<string, Stream> GetDefaultStreamForLibrary()
    {
        HashSet<string> streamsAlreadyCreated = new();
        return GetStreamForLibrary;

        Stream GetStreamForLibrary(string name) =>
            streamsAlreadyCreated.Add(name)
                ? new MemoryStream()
                : throw new AlreadyCreatedStreamPreviouslyForLibraryNameError(name).ToException();
    }

    private static string? GetDefaultLibraryNameToClassName(string libraryName) => 
        VariableNameGenerator.NormalizeIdentifier(libraryName);

    public Stream GetStreamForLibraryName(string libraryName) =>
        _getCachedStreamByName(libraryName);

    public bool ShouldWriteLibrary(string libraryName) =>
        _shouldWriteLibrary?.Invoke(libraryName) ?? true;

    public string? LibraryNameToClassName(string libraryName) => 
        _libraryNameToClassName(libraryName);
}

internal readonly record struct AlreadyCreatedStreamPreviouslyForLibraryNameError(string LibraryName) : ICqlError
{
    public string GetMessage() => $"Already created a stream for this library name before. Library Name: '{LibraryName}'";
}