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
/// IR counterpart of the old <c>Hl7.Cql.Abstractions.CqlDefinition</c>: the base class for the
/// definitions the expression builder produces for a library (expressions, functions,
/// parameters, codes, code systems, concepts and value sets).
///
/// <para>This is a mechanical port onto the typed IR (phase 4 of the Linq.Expressions removal,
/// see <c>docs/linq-expression-removal-plan.md</c>). Unlike the old <c>CqlDefinition</c>, this
/// class does <b>not</b> derive from <c>System.Linq.Expressions.Expression</c> — that base was
/// only needed to host definitions inside expression trees, which the IR pipeline never does.
/// Only the surface the builder actually writes/reads is mirrored.</para>
/// </summary>
internal abstract class CqlDefinition(string name)
{
    public string Name { get; } = name;

    public abstract Type ReturnType { get; }
}

/// <summary>
/// IR counterpart of the old <c>Hl7.Cql.Abstractions.CqlLambdaDefinition</c>: a definition whose
/// body is a lambda (expression definitions, functions and parameters).
/// </summary>
internal abstract class CqlLambdaDefinition(
    IrLambda lambda,
    string name) : CqlDefinition(name)
{
    public IrLambda Lambda { get; } = lambda;

    /// <summary>The <c>Func&lt;…&gt;</c> delegate type of <see cref="Lambda"/>, mirroring
    /// <c>CqlLambdaDefinition.Type</c> (note: the IR lambda does not carry the implicit
    /// <c>CqlContext</c> parameter the old <c>LambdaExpression</c> was prefixed with).</summary>
    public Type Type => Lambda.Type;

    public override Type ReturnType => Lambda.Body.Type;
}

/// <summary>
/// IR counterpart of the old <c>CqlExpressionDefinition</c>.
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
/// IR counterpart of the old <c>CqlFunctionDefinition</c>.
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
/// IR counterpart of the old <c>CqlParameterDefinition</c>.
/// </summary>
internal class CqlParameterDefinition(
    IrLambda lambda,
    string name)
    : CqlLambdaDefinition(lambda, name);

/// <summary>
/// IR counterpart of the old <c>CqlCodeSystemDefinition</c>.
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
/// IR counterpart of the old <c>CqlConceptDefinition</c>.
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
/// IR counterpart of the old <c>CqlCodeDefinition</c>.
/// </summary>
internal class CqlCodeDefinition(
    string name,
    CqlCode code)
    : CqlDefinition(name)
{
    public CqlCode Code { get; } = code;

    // NOTE(phase4/6): faithful to the old (deleted) CqlCodeDefinition.ReturnType, which (likely
    // unintentionally) returned the definition class itself rather than typeof(CqlCode). Phase 6
    // of the Linq.Expressions removal (docs/linq-expression-removal-plan.md) deleted that class,
    // so the same "returns its own wrapper type" bug is preserved here by self-reference instead
    // -- this remains deliberately un-fixed (deferred, see the phase-6 checklist) since nothing
    // has been found to observe this value; a real fix (typeof(CqlCode)) is still out of scope.
    public override Type ReturnType => typeof(CqlCodeDefinition);
}

/// <summary>
/// IR counterpart of the old <c>CqlValueSetDefinition</c>.
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
/// IR counterpart of <c>CqlDefinitionDictionary</c> (the
/// <c>DefinitionDictionary&lt;CqlDefinition&gt;</c> global-using alias): the definitions
/// dictionary the IR library contexts read and write. <see cref="DefinitionDictionary{T}"/>
/// itself is Expression-free, so it is reused directly; this subclass only exists to give the
/// closed generic a name usable across the IR pipeline without touching the (old-pipeline)
/// global usings.
/// </summary>
internal sealed class CqlDefinitionDictionary : DefinitionDictionary<CqlDefinition>;
