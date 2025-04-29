/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit.Internal;

internal sealed class LibraryInstanceInvoker_3_0 : LibraryInstanceInvoker
{
    private LibraryInstanceInvoker_3_0(
        LibrarySetInvoker librarySetInvoker,
        ILibrary library) : base(librarySetInvoker, library)
    {
        Definitions = library
                      .GetType()
                      .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                      .SelectWhere(methodInfo => DefinitionInvoker_3_0.TryCreate(Library, this, methodInfo))
                      .ToFrozenDictionary(o => new DefinitionSignature(o.DefinitionName, o.ParameterTypes), o => o)
                      .AsReadOnly();
    }

    public override IReadOnlyDictionary<DefinitionSignature, DefinitionInvoker> Definitions { get; }

    private static object GetLibraryFromStaticInstanceProperty(Type libraryType) =>
        libraryType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
        ?? throw new InvalidOperationException($"Unable to create an instance of {libraryType.FullName}");

    public static bool TryCreate(
        LibrarySetInvoker librarySetInvoker,
        Type libraryType,
        [NotNullWhen(true)] out LibraryInvoker? libraryInvoker)
    {
        libraryInvoker = null;
        var logger = librarySetInvoker.CreateLogger<LibraryInstanceInvoker_3_0>();

        if (GetLibraryFromStaticInstanceProperty(libraryType) is not ILibrary asILibrary)
        {
            logger?.LogDebug("Skipping type {type} because it does not implement ILibrary.", libraryType.FullName);
            return false;
        }

        libraryInvoker = new LibraryInstanceInvoker_3_0(librarySetInvoker, asILibrary);
        return true;
    }

    /// <summary>
    /// Determines whether the specified CQL tool version is supported.
    /// The current CQL tool version can be referenced by <see cref="LibrarySetCSharpCodeGenerator.GeneratorToolVersion"/>.
    /// </summary>
    public static bool SupportsVersion(Version cqlToolVersion) =>
        cqlToolVersion >= new Version(3, 0, 0, 0)
        && cqlToolVersion < new Version(4, 0, 0, 0);
}

file class DefinitionInvoker_3_0
(
    ILibrary library,
    LibraryInvoker libraryInvoker,
    MethodInfo methodInfo,
    CqlDefinitionAttribute cqlDefinitionAttribute) : DefinitionInvoker(
    libraryInvoker,
    methodInfo.ReturnType,
    methodInfo.GetParameters()
              .Skip(1) // Skip CqlContext
              .Select(p => p.ParameterType)
              .ToArray(),
    cqlDefinitionAttribute,
    methodInfo.GetCustomAttributes<CqlTagAttribute>()
              .ToArray())
{
    public static (bool success, DefinitionInvoker definitionInvoker) TryCreate(
        ILibrary library,
        LibraryInvoker libraryInvoker,
        MethodInfo methodInfo)
    {
        var cqlDefinitionAttributes = methodInfo.GetCustomAttributes<CqlDefinitionAttribute>().ToArray();
        if (cqlDefinitionAttributes is not [{ } cqlDefinitionAttribute])
            return default;

        var definitionInvoker = new DefinitionInvoker_3_0(library, libraryInvoker, methodInfo, cqlDefinitionAttribute);
        return (true, definitionInvoker);
    }

    public override object? Invoke(CqlContext cqlContext, params object?[] args) =>
        methodInfo.Invoke(
            library,
            BindingFlags.DoNotWrapExceptions,
            null,
            args.Length == 0 ? [cqlContext] : [cqlContext, .. args],
            CultureInfo.InvariantCulture);
}