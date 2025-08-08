/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;
using static Hl7.Cql.Invocation.Toolkit.StringBuilderExtensions;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Represents an abstract base class for invoking CQL definitions within a library context.
/// </summary>
/// <param name="libraryInvoker">The invoker for the library containing the CQL definition.</param>
/// <param name="returnType">The return type of the CQL definition.</param>
/// <param name="definitionParameters">The definition parameters including name, parameter types, and parameter names.</param>
/// <param name="cqlDefinitionAttribute">The attribute containing metadata about the CQL definition.</param>
/// <param name="cqlTagAttributes">The attributes used to tag the CQL definition for categorization or filtering.</param>
/// <remarks>
/// This class provides the core functionality for invoking CQL definitions, including metadata
/// such as the library identifier, definition name, parameter types, and return type. It also
/// supports tagging definitions with attributes for categorization or filtering.
/// </remarks>
/// <example>
/// Example usage:
/// <code>
/// var result = definitionInvoker.Invoke(cqlContext);
/// </code>
/// </example>
public abstract class DefinitionInvoker(
    LibraryInvoker libraryInvoker,
    Type returnType,
    DefinitionParameters definitionParameters,
    CqlDefinitionAttribute cqlDefinitionAttribute,
    CqlTagAttribute[] cqlTagAttributes)
{
    /// <summary>
    /// The library invoker that created this instance.
    /// </summary>
    public LibraryInvoker LibraryInvoker { get; } = libraryInvoker;

    /// <summary>
    /// Gets the <see cref="CqlDefinitionAttribute"/> associated with this invoker.
    /// </summary>
    public CqlDefinitionAttribute CqlDefinitionAttribute { get; } = cqlDefinitionAttribute;

    /// <summary>
    /// Gets the tag values by tag name that is associated with the definition.
    /// Where there duplicate tags by name, their values will be combined into a set.
    /// </summary>
    public IReadOnlyDictionary<string, IReadOnlySet<string>> TagValuesByName { get; }
        = cqlTagAttributes
          .GroupBy(a => a.Name)
          .ToFrozenDictionary(
              g => g.Key,
              IReadOnlySet<string> (g) => g.Select(a => a.Value).ToFrozenSet());

    /// <summary>
    /// A convenience property to get the library set name.
    /// </summary>
    public string LibrarySetName => LibraryInvoker.LibrarySetName;

    /// <summary>
    /// A convenience property to get the library identifier of the library that contains this definition.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => LibraryInvoker.LibraryIdentifier;

    /// <summary>
    /// Gets the definition parameters including name, parameter types, and parameter names.
    /// </summary>
    public DefinitionParameters DefinitionParameters { get; } = definitionParameters;

    /// <summary>
    /// Gets the return type of the method.
    /// </summary>
    public Type ReturnType => returnType;

    /// <summary>
    /// Invokes the definition with the given CQL context.
    /// </summary>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="args">Any additional arguments for the invocation.</param>
    /// <returns>The result of the invocation (typically when calling a function definition).</returns>
    public abstract object? Invoke(CqlContext cqlContext, params object?[] args);

    /// <inheritdoc />
    public override string ToString() =>
        StartBrace()
            .AppendMemberIf(LibrarySetName, LibrarySetName is { Length: > 0 })
            .AppendMember(LibraryIdentifier)
            .AppendMember(ReturnType)
            .AppendMember(DefinitionParameters)
            .EndBrace();
}
