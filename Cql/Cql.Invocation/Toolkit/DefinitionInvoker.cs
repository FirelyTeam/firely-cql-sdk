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
using static Hl7.Cql.Invocation.Toolkit.StringBuilderExtensions;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Represents an abstract base class for invoking CQL definitions within a library context.
/// </summary>
/// <param name="libraryInvoker">The invoker for the library containing the CQL definition.</param>
/// <param name="returnType">The return type of the definition.</param>
/// <param name="operands">The operand information for the definition, containing both CQL names and types.</param>
/// <param name="cqlDefinitionAttribute">The attribute containing metadata about the CQL definition.</param>
/// <param name="cqlTagAttributes">The attributes used to tag the CQL definition for categorization or filtering.</param>
/// <remarks>
/// This class provides the core functionality for invoking CQL definitions, including metadata
/// such as the library identifier, definition name, parameter names and types, and return type.
/// The definition name is obtained from the <see cref="CqlDefinitionAttribute.Name"/> property.
/// It also supports tagging definitions with attributes for categorization or filtering.
/// </remarks>
/// <example>
/// Example usage:
/// <code>
/// // Access definition metadata directly
/// var definitionInvoker = libraryInvoker.Definitions.Values.First();
/// Console.WriteLine($"Function: {definitionInvoker.DefinitionName}");
/// Console.WriteLine($"Return Type: {definitionInvoker.ReturnType.Name}");
///
/// // Access parameter information using Operands
/// foreach (var operand in definitionInvoker.Operands)
/// {
///     Console.WriteLine($"Parameter: {operand.Name} ({operand.Type.Name})");
/// }
///
/// // Invoke the definition
/// var result = definitionInvoker.Invoke(cqlContext);
/// </code>
/// </example>
public abstract class DefinitionInvoker(
    LibraryInvoker libraryInvoker,
    Type returnType,
    CqlOperandInfo[] operands,
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
    /// Gets the name of the definition.
    /// </summary>
    public string DefinitionName { get; } = cqlDefinitionAttribute.Name;

    /// <summary>
    /// Gets the return type of the definition.
    /// </summary>
    public Type ReturnType { get; } = returnType ?? throw new ArgumentNullException(nameof(returnType));

    /// <summary>
    /// Gets the operand information for the definition, containing both CQL names and types.
    /// </summary>
    public CqlOperandInfo[] Operands { get; } = operands ?? throw new ArgumentNullException(nameof(operands));

    /// <summary>
    /// Invokes the definition with the given CQL context.
    /// </summary>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="args">Any additional arguments for the invocation.</param>
    /// <returns>The result of the invocation (typically when calling a function definition).</returns>
    public abstract object? Invoke(CqlContext cqlContext, params object?[] args);

    /// <summary>
    /// Returns a string representation of the definition invoker, including library information,
    /// definition name, return type, and parameter details.
    /// </summary>
    /// <returns>A formatted string containing definition metadata.</returns>
    /// <example>
    /// Example output:
    /// <code>
    /// {LibrarySetName: MyLibrarySet, LibraryIdentifier: TestLib-1.0.0, DefinitionName: MyFunction,
    ///  DefinitionType: Function, ReturnType: System.Boolean,
    ///  Operands: {System.Int32 count, System.String name}}
    /// </code>
    /// </example>
    public override string ToString() =>
        StartBrace()
            .AppendMemberIf(LibrarySetName, LibrarySetName is { Length: > 0 })
            .AppendMember(LibraryIdentifier)
            .AppendMember(DefinitionName)
            .AppendMember(CqlDefinitionAttribute.GetType().Name["Cql".Length .. ^"DefinitionAttribute".Length], "DefinitionType")
            .AppendMember(ReturnType.ToCSharpString(), nameof(ReturnType))
            .AppendMemberIf(GetDefinitionString(), Operands.Any(), "Operands")
            .EndBrace();

    private string GetDefinitionString()
    {
        if (Operands.Any())
        {
            var parameters = Operands.Select(op => $"{op.Type.ToCSharpString()} {op.Name}");
            return $"{{{string.Join(", ", parameters)}}}";
        }

        return "";
    }
}
