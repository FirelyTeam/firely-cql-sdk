/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// Base class for the typed intermediate representation (IR) produced by the expression
/// builder and consumed by the C# emitter.
///
/// <para>Every node carries the .NET <see cref="Type"/> the printed C# expression will have.
/// This type drives overload resolution in the operator binder (which scores candidate
/// <c>ICqlOperators</c> overloads against argument types) and cast/coercion decisions in the
/// emitter — it plays the role <c>System.Linq.Expressions.Expression.Type</c> played in the
/// previous pipeline.</para>
///
/// <para>Node constructors validate their inputs (argument assignability, cast legality) and
/// throw <see cref="ArgumentException"/> with a precise message, so that type errors surface
/// when the tree is built — while ELM context is still on the stack — rather than as C#
/// compiler diagnostics against generated code.</para>
///
/// <para>Unlike Linq expression trees, the IR is statement-aware at print time only: the tree
/// itself is expression-shaped, and the emitter linearizes nested expressions into sequential
/// local assignments (<c>var a_ = ...;</c>). Nodes are immutable; <see cref="CodeLocal"/> is
/// the only node with reference-identity semantics (two locals are the same variable if and
/// only if they are the same instance).</para>
/// </summary>
internal abstract class CodeExpression
{
    /// <summary>
    /// The .NET type of the C# expression this node prints as.
    /// </summary>
    public abstract Type Type { get; }
}
