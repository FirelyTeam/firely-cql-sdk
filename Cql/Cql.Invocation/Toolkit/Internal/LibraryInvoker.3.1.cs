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

internal sealed class LibraryInstanceInvoker_3_1 : LibraryInstanceInvoker
{
    private LibraryInstanceInvoker_3_1(
        LibrarySetInvoker librarySetInvoker,
        ILibrary library) : base(librarySetInvoker, library)
    {
        Definitions = library
                      .GetType()
                      .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                      .SelectWhere(methodInfo => DefinitionInvoker_3_1.TryCreate(Library, this, methodInfo))
                      .ToFrozenDictionary(o => (DefinitionSignature)o.DefinitionInfo, o => o)
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
        var logger = librarySetInvoker.CreateLogger<LibraryInstanceInvoker_3_1>();

        if (GetLibraryFromStaticInstanceProperty(libraryType) is not ILibrary asILibrary)
        {
            logger?.LogDebug("Skipping type {type} because it does not implement ILibrary.", libraryType.FullName);
            return false;
        }

        libraryInvoker = new LibraryInstanceInvoker_3_1(librarySetInvoker, asILibrary);
        return true;
    }

    /// <summary>
    /// Determines whether the specified CQL tool version is supported.
    /// The current CQL tool version can be referenced by <see cref="LibrarySetCSharpCodeGenerator.GeneratorToolVersion"/>.
    /// </summary>
    public static bool SupportsVersion(Version cqlToolVersion) =>
        cqlToolVersion >= new Version(3, 1, 0, 0)
        && cqlToolVersion < new Version(4, 0, 0, 0);
}

file sealed class DefinitionInvoker_3_1(
    ILibrary library,
    LibraryInvoker libraryInvoker,
    MethodInfo methodInfo,
    CqlDefinitionAttribute cqlDefinitionAttribute) : DefinitionInvoker(
    libraryInvoker,
    new DefinitionInfo(
        cqlDefinitionAttribute.Name,
        methodInfo.ReturnType, methodInfo.GetParameters()
                                         .Skip(1) // Skip CqlContext
                                         .Select(p =>
                                                     p.GetCustomAttribute<CqlFunctionParameterAttribute>()?.CqlParameterName ?? p.Name!)
                                         .ToArray(), methodInfo.GetParameters()
                                                               .Skip(1) // Skip CqlContext
                                                               .Select(p => p.ParameterType)
                                                               .ToArray()),
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

        var definitionInvoker = new DefinitionInvoker_3_1(library, libraryInvoker, methodInfo, cqlDefinitionAttribute);
        return (true, definitionInvoker);
    }

    public override object? Invoke(CqlContext cqlContext, params object?[] args)
    {
        object?[] methodArgs = args is { Length: > 0 }
                             ? [cqlContext, ..args]
                             : [cqlContext];
        return methodInfo.Invoke(
            library,
            BindingFlags.DoNotWrapExceptions,
            null,
            methodArgs,
            CultureInfo.InvariantCulture);
    }
}