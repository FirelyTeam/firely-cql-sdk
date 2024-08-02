/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.IO;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.CodeGeneration.NET;

internal class CSharpSourceCodeWriterCallbacks
{

    private readonly Predicate<string>? _shouldWriteLibrary;
    private readonly Func<string, string?> _libraryNameToClassName;
    private readonly Action<CSharpSourceCodeStep>? _onAfterStep;
    private readonly HashSet<string> _streamsAlreadyCreated;

    /// <param name="libraryNameToClassName">Generating a class name for the library name.</param>
    /// <param name="shouldWriteLibrary">A function that determines whether the given library should be generated or not; default is <see langword="null" />.  When <see langword="null" />, all libraries are written.</param>
    /// <param name="onAfterStep">For handling a stream directly after the code was generated.</param>
    public CSharpSourceCodeWriterCallbacks(
        Func<string, string?>? libraryNameToClassName = null,
        Predicate<string>? shouldWriteLibrary = null,
        Action<CSharpSourceCodeStep>? onAfterStep = null)
    {

        _libraryNameToClassName = libraryNameToClassName ?? GetDefaultLibraryNameToClassName;
        _shouldWriteLibrary = shouldWriteLibrary;
        _onAfterStep = onAfterStep;
        _streamsAlreadyCreated = new();
    }

    private static string? GetDefaultLibraryNameToClassName(string libraryName) =>
        VariableNameGenerator.NormalizeIdentifier(libraryName);

    public Stream GetStreamForLibraryName(string libraryName) =>
        _streamsAlreadyCreated.Add(libraryName)
            ? new MemoryStream()
            : throw new AlreadyCreatedAStreamForLibraryNameError(libraryName).ToException();

    public bool ShouldWriteLibrary(string libraryName) =>
        _shouldWriteLibrary?.Invoke(libraryName) ?? true;

    public string? LibraryNameToClassName(string libraryName) =>
        _libraryNameToClassName(libraryName);

    public void Step(string libraryName, Stream stream) =>
        _onAfterStep?.Invoke(new CSharpSourceCodeStep.OnStream(libraryName, stream));

    public void Done() =>
        _onAfterStep?.Invoke(new CSharpSourceCodeStep.OnDone());
}
internal abstract record CSharpSourceCodeStep
{
    public record OnStream(string Name, Stream Stream) : CSharpSourceCodeStep;

    public record OnDone() : CSharpSourceCodeStep;
}

internal readonly record struct AlreadyCreatedAStreamForLibraryNameError(string LibraryName) : ICqlError
{
    public string GetMessage() => $"Already created a stream for this library name before. Library Name: '{LibraryName}'";
}