/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;


/// <summary>
/// Abstract class representing a definition invoker.
/// </summary>
/// <param name="libraryInvoker">The library invoker that created this instance.</param>
/// <param name="definitionName">The name of the definition.</param>
/// <param name="methodInfo">The method information for the definition.</param>
/// <param name="tagValuesByName">The tag values associated with the definition.</param>
/// <param name="valueSetId">The value set identifier, if any.</param>
public abstract class DefinitionInvoker(
    LibraryInvoker libraryInvoker,
    string definitionName,
    MethodInfo methodInfo,
    IReadOnlyDictionary<string, IReadOnlySet<string>> tagValuesByName,
    string? valueSetId)
{
    /// <summary>
    /// The library invoker that created this instance.
    /// </summary>
    public LibraryInvoker LibraryInvoker { get; } = libraryInvoker;

    /// <summary>
    /// Gets the name of the definition.
    /// </summary>
    public string DefinitionName { get; } = definitionName;

    /// <summary>
    /// A convenience property to get the library identifier of the library that contains this definition.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => LibraryInvoker.LibraryIdentifier;

    /// <summary>
    /// Gets the return type of the method.
    /// </summary>
    public Type ReturnType => MethodInfo.ReturnType;

    /// <summary>
    /// Gets the tag values by tag name that is associated with the definition.
    /// Where there duplicate tags by name, their values will be combined into a set.
    /// </summary>
    public IReadOnlyDictionary<string, IReadOnlySet<string>> TagValuesByName { get; } = tagValuesByName;

    /// <summary>
    /// Gets the value set identifier, if any.
    /// </summary>
    public string? ValueSetId { get; } = valueSetId;

    /// <summary>
    /// Gets the method information for the definition.
    /// </summary>
    protected MethodInfo MethodInfo { get; } = methodInfo;

    /// <summary>
    /// Invokes the definition with the given CQL context.
    /// </summary>
    /// <param name="cqlContext">The CQL context.</param>
    /// <returns>The result of the invocation.</returns>
    public abstract object? Invoke(CqlContext cqlContext);

    /// <inheritdoc />
    public override string ToString() =>
        $"{{{nameof(LibraryIdentifier)}: {LibraryIdentifier}, {nameof(DefinitionName)}: {DefinitionName}, {nameof(ReturnType)}: {ReturnType.ToCSharpString()}}}";
}
