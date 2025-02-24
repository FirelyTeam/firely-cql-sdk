/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit.Internal;

internal sealed class LibraryInvoker_2_0_8_0 : LibraryInvokerOnInstance
{
    private record LibraryMethodInfo(
        MethodInfo Method,
        IReadOnlyDictionary<string, string> TagValuesByName,
        string? ValueSetId,
        string? DeclarationName)
    {
        public LibraryMethodInfo(MethodInfo Method) : this(
            Method,
            TagValuesByName: Method.GetCustomAttributes<CqlTagAttribute>().ToArray() switch
                                 {
                                     { Length: > 0 } tags => tags.ToDictionary(a => a.Name, a => a.Value).AsReadOnly(),
                                     _ => ReadOnlyDictionary<string, string>.Empty
                                 },
            ValueSetId: Method.GetCustomAttribute<CqlValueSetAttribute>()?.Id,
            DeclarationName: Method.GetCustomAttribute<CqlDeclarationAttribute>()?.Name) { }
    }

    private LibraryInvoker_2_0_8_0(
        LibrarySetInvoker librarySetInvoker,
        ILibrary library) : base(librarySetInvoker, library)
    {
        var libraryType = library.GetType();
        var libraryMethodInfos = libraryType
                                 .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                                 .SelectToArray(m => new LibraryMethodInfo(m));
        Definitions = libraryMethodInfos
                       .SelectWhereNotNull(o => o.DeclarationName is { } declarationName
                                                && o.Method.GetParameters() is [{ } p0]
                                                && p0.ParameterType == typeof(CqlContext)
                                                    ? (Toolkit.DefinitionInvoker)new DefinitionInvoker(declarationName, Library, o.Method, o.TagValuesByName, o.ValueSetId)
                                                    : null)
                       .ToImmutableDictionary(o => o.DefinitionName);
    }

    public override IReadOnlyDictionary<string, Toolkit.DefinitionInvoker> Definitions { get; }

    private static object GetLibraryFromStaticInstanceProperty(Type libraryType)
    {
        return libraryType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
               ?? throw new InvalidOperationException($"Unable to create an instance of {libraryType.FullName}");
    }

    public static bool TryCreate(
        LibrarySetInvoker librarySetInvoker,
        Type libraryType,
        [NotNullWhen(true)] out LibraryInvoker? libraryInvoker)
    {
        libraryInvoker = null;
        var logger = librarySetInvoker.CreateLogger<LibraryInvoker_2_0_8_0>();

        if (GetLibraryFromStaticInstanceProperty(libraryType) is not ILibrary asILibrary)
        {
            logger?.LogDebug(
                "Skipping type {type} because it does not implement ILibrary.",
                libraryType.FullName);
            return false;
        }

        libraryInvoker = new LibraryInvoker_2_0_8_0(librarySetInvoker, asILibrary);
        return true;
    }

    public static bool SupportsVersion(Version cqlToolVersion)
    {
        return cqlToolVersion >= new Version(2, 0, 8);
    }

    private class DefinitionInvoker(
        string definitionName,
        ILibrary library,
        MethodInfo methodInfo,
        IReadOnlyDictionary<string, string> tagValuesByName,
        string? valueSetId) : Toolkit.DefinitionInvoker(definitionName, library, methodInfo, tagValuesByName, valueSetId)
    {
        public override object? Invoke(CqlContext cqlContext)
        {
            return InvokeMethod(cqlContext);
        }
    }
}

