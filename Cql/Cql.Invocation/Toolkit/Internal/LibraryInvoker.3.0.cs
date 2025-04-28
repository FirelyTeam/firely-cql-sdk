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

internal sealed class LibraryInvoker_3_0 : LibraryInvokerOnInstance
{
    private record LibraryMethodInfo
    (
        MethodInfo Method,
        IReadOnlyDictionary<string, IReadOnlySet<string>> TagValuesByName,
        CqlDefinitionAttribute? CqlDeclarationAttribute)
    {
        public LibraryMethodInfo(MethodInfo Method) : this(
            Method,
            TagValuesByName: Method
                .GetCustomAttributes<CqlTagAttribute>()
                .Select(t => (t.Name, t.Value))
                .GroupBy(t => t.Name, (Name, items) => (Name, Values: (IReadOnlySet<string>)items.Select(i => i.Value).ToFrozenSet()))
                .ToArray() switch
            {
                { Length: > 0 } tags => tags.ToDictionary(a => a.Name, a => a.Values).AsReadOnly(),
                _                    => ReadOnlyDictionary<string, IReadOnlySet<string>>.Empty
            },
            CqlDeclarationAttribute: Method.GetCustomAttribute<CqlDefinitionAttribute>()) { }
    }

    private LibraryInvoker_3_0(
        LibrarySetInvoker librarySetInvoker,
        ILibrary library) : base(librarySetInvoker, library)
    {
        var libraryType = library.GetType();
        var libraryMethodInfos = libraryType
                                 .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                                 .SelectToArray(m => new LibraryMethodInfo(m));
        Definitions = libraryMethodInfos
                      .SelectWhereNotNull(o =>
                                              o.CqlDeclarationAttribute?.DefinitionName is { } declarationName
                                              && o.Method.GetParameters() is [{ } p0]
                                              && p0.ParameterType == typeof(CqlContext)
                                                  ? (DefinitionInvoker)new DefinitionInvoker_3_0(
                                                      libraryInvoker: this,
                                                      definitionName: declarationName,
                                                      library: Library,
                                                      methodInfo: o.Method,
                                                      tagValuesByName: o.TagValuesByName,
                                                      valueSetId: o.CqlDeclarationAttribute is CqlValueSetDefinitionAttribute vsa ? vsa.ValueSetId : null)
                                                  : null)
                      .ToImmutableDictionary(o => o.DefinitionName);
    }

    public override IReadOnlyDictionary<string, DefinitionInvoker> Definitions { get; }

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
        var logger = librarySetInvoker.CreateLogger<LibraryInvoker_3_0>();

        if (GetLibraryFromStaticInstanceProperty(libraryType) is not ILibrary asILibrary)
        {
            logger?.LogDebug(
                "Skipping type {type} because it does not implement ILibrary.",
                libraryType.FullName);
            return false;
        }

        libraryInvoker = new LibraryInvoker_3_0(librarySetInvoker, asILibrary);
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
    LibraryInvoker libraryInvoker,
    string definitionName,
    ILibrary library,
    MethodInfo methodInfo,
    IReadOnlyDictionary<string, IReadOnlySet<string>> tagValuesByName,
    string? valueSetId) : DefinitionInvoker(libraryInvoker, definitionName, methodInfo, tagValuesByName, valueSetId)
{
    public override object? Invoke(CqlContext cqlContext) =>
        MethodInfo.Invoke(library, BindingFlags.DoNotWrapExceptions, null, [cqlContext], CultureInfo.InvariantCulture);
}