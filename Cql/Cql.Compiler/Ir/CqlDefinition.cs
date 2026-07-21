/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// The base class for the definitions the expression builder produces for a library
/// (expressions, functions, parameters, codes, code systems, concepts and value sets).
/// </summary>
internal abstract class CqlDefinition(string name)
{
    public string Name { get; } = name;

    public abstract Type ReturnType { get; }
}

/// <summary>
/// A definition whose body is a lambda (expression definitions, functions and parameters).
/// </summary>
internal abstract class CqlLambdaDefinition(
    IrLambda lambda,
    string name) : CqlDefinition(name)
{
    public IrLambda Lambda { get; } = lambda;

    /// <summary>The <c>Func&lt;…&gt;</c> delegate type of <see cref="Lambda"/> (note: the IR
    /// lambda does not carry an implicit <c>CqlContext</c> parameter).</summary>
    public Type Type => Lambda.Type;

    public override Type ReturnType => Lambda.Body.Type;
}

/// <summary>
/// A CQL <c>define</c> statement: a named, parameterless expression.
/// </summary>
internal class CqlExpressionDefinition(
    IrLambda lambda,
    string name,
    (string tagName, string[] tagValues)[]? tags = null)
    : CqlLambdaDefinition(lambda, name)
{
    public (string Name, string[] Values)[] Tags { get; } = tags ?? [];
}

/// <summary>
/// A CQL <c>define function</c> statement.
/// </summary>
internal class CqlFunctionDefinition(
    IrLambda lambda,
    string name,
    IReadOnlyDictionary<string, string>? originalParameterNames = null,
    params (string tagName, string[] tagValues)[] tags) : CqlExpressionDefinition(lambda, name, tags)
{
    /// <summary>
    /// Gets a dictionary mapping normalized C# parameter names to their original CQL parameter names.
    /// Only contains entries where the normalized name differs from the original name.
    /// </summary>
    public IReadOnlyDictionary<string, string> OriginalParameterNames { get; } = originalParameterNames ?? ReadOnlyDictionary<string, string>.Empty;
}

/// <summary>
/// A CQL <c>parameter</c> declaration; the lambda produces the parameter's value
/// (its default, unless overridden at runtime).
/// </summary>
internal class CqlParameterDefinition(
    IrLambda lambda,
    string name)
    : CqlLambdaDefinition(lambda, name);

/// <summary>
/// A CQL <c>codesystem</c> declaration.
/// </summary>
internal class CqlCodeSystemDefinition(
    string name,
    CqlCodeSystem codeSystem)
    : CqlDefinition(name)
{
    public CqlCodeSystem CodeSystem { get; } = codeSystem;
    public override Type ReturnType => typeof(CqlCodeSystem);
}

/// <summary>
/// A CQL <c>concept</c> declaration.
/// </summary>
internal class CqlConceptDefinition(
    string name,
    string? display,
    IReadOnlyList<CqlCode> codes)
    : CqlDefinition(name)
{
    public string? Display { get; } = display;
    public IReadOnlyList<CqlCode> Codes { get; } = codes;
    public override Type ReturnType => typeof(CqlConcept);
}

/// <summary>
/// A CQL <c>code</c> declaration.
/// </summary>
internal class CqlCodeDefinition(
    string name,
    CqlCode code)
    : CqlDefinition(name)
{
    public CqlCode Code { get; } = code;

    // Likely-unintentional legacy behavior, preserved bug-for-bug from the deleted
    // Linq.Expressions pipeline (its CqlCodeDefinition.ReturnType returned the definition
    // class itself rather than typeof(CqlCode)). Deliberately un-fixed since nothing has been
    // found to observe this value; the real fix (typeof(CqlCode)) is tracked in the cleanup
    // checklist of docs/linq-expression-removal-plan.md.
    public override Type ReturnType => typeof(CqlCodeDefinition);
}

/// <summary>
/// A CQL <c>valueset</c> declaration.
/// </summary>
internal class CqlValueSetDefinition(
    string name,
    string valueSetId,
    string? valueSetVersion)
    : CqlDefinition(name)
{
    public string ValueSetId { get; } = valueSetId;
    public string? ValueSetVersion { get; } = valueSetVersion;
    public override Type ReturnType => typeof(CqlValueSet);
}

/// <summary>
/// The definitions dictionary the library contexts read and write; this subclass only exists
/// to give the closed generic <see cref="DefinitionDictionary{T}"/> a short name.
/// </summary>
internal sealed class CqlDefinitionDictionary : DefinitionDictionary<CqlDefinition>;
