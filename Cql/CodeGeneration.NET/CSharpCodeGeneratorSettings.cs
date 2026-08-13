/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Settings controlling how <see cref="LibrarySetCSharpCodeGenerator"/> formats the C# it
/// emits. Behavior-neutral by contract: two runs differing only in these settings produce
/// code with identical semantics.
/// </summary>
/// <param name="PreferFlattenElseBlocks">
/// When <see langword="true"/>, a conditional whose branches all exit (return or throw)
/// prints guard-clause style — plain sequential <c>if</c> blocks, final value flat — instead
/// of an <c>if</c>/<c>else</c> chain. Default <see langword="false"/>: <c>else</c> blocks
/// are kept. See <c>ElmToolkitConfig.CSharpPreferFlattenElseBlocks</c>.
/// </param>
internal sealed record CSharpCodeGeneratorSettings(bool PreferFlattenElseBlocks = false)
{
    public static CSharpCodeGeneratorSettings Default { get; } = new();
}
