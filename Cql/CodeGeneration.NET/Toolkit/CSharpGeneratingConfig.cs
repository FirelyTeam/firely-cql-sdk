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
/// Settings controlling how the C# code generator formats the code it emits, exposed as
/// <see cref="ElmToolkitConfig.CSharpGeneratingConfig"/> and bindable from the CQL packager's
/// <c>appsettings.json</c> under <c>Elm:CSharpGeneratingConfig</c>. These settings never
/// change what the generated code COMPUTES — CQL semantics are identical across any values —
/// but <see cref="CSharpNamespace"/> does change the generated types' identities (their
/// namespace), so two runs differing in it are not binary-interchangeable.
/// </summary>
public record CSharpGeneratingConfig
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static CSharpGeneratingConfig Default { get; } = new();

    /// <summary>
    /// When <see langword="true"/>, a generated conditional whose branches all exit (every
    /// branch returns or throws — e.g. the short-circuit form of CQL's <c>and</c>/<c>or</c>
    /// in tail position) prints guard-clause style: plain sequential <c>if</c> blocks with
    /// the final value flat after them, instead of an <c>if</c>/<c>else</c> chain. The
    /// default is <see langword="false"/>: <c>else</c> blocks are kept.
    /// </summary>
    public bool PreferNoElseBlocks { get; init; } = false;

    /// <summary>
    /// The C# namespace to use for generated code. If <see langword="null"/> or empty, no
    /// namespace is generated.
    /// </summary>
    public string? CSharpNamespace { get; init; } = null;
}
