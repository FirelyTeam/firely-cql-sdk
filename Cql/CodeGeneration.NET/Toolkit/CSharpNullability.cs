/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.CodeGeneration.NET.Toolkit;

/// <summary>
/// How much of C#'s nullable reference types the generated code opts into. The three values
/// correspond exactly to the <c>#nullable</c> directive the generator emits.
/// </summary>
public enum CSharpNullability
{
    /// <summary>
    /// No <c>#nullable</c> directive and no annotations — the null-oblivious output the generator
    /// produced before nullable emission was added.
    /// </summary>
    Disabled,

    /// <summary>
    /// Emits <c>#nullable enable annotations</c>: declarations carry honest <c>T?</c> annotations, so
    /// consumers see the nullability of the generated API, but the compiler does not verify them.
    /// Nothing is emitted purely to satisfy flow analysis — no null-forgiving operators and no
    /// nullability-bridging casts — which keeps the generated source readable.
    /// </summary>
    Annotations,

    /// <summary>
    /// Emits <c>#nullable enable</c>: annotations plus flow analysis. The generator additionally
    /// emits null-forgiving operators and bridging casts where a value's declared nullability
    /// disagrees with its target, so the result compiles warning-free.
    /// </summary>
    Enabled,
}
