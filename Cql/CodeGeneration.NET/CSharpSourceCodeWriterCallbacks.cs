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
    private readonly Action<CSharpSourceCodeStep>? _onAfterStep;
    private readonly HashSet<string> _streamsAlreadyCreated;

    /// <param name="onAfterStep">For handling a stream directly after the code was generated.</param>
    public CSharpSourceCodeWriterCallbacks(
        Action<CSharpSourceCodeStep>? onAfterStep = null)
    {
        _onAfterStep = onAfterStep;
        _streamsAlreadyCreated = new();
    }

    public Stream GetStreamForLibraryName(string libraryName) =>
        _streamsAlreadyCreated.Add(libraryName)
            ? new MemoryStream()
            : throw new AlreadyCreatedAStreamForLibraryNameError(libraryName).ToException();

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