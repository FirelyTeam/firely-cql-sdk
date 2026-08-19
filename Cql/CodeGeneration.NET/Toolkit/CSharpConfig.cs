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
/// Settings that control the C# source the generator emits, as opposed to how ELM is translated.
/// </summary>
/// <param name="NullabilityEnabled">
/// When <see langword="true"/> (the default), generated files opt into nullable reference types
/// with <c>#nullable enable</c> and declarations carry nullable annotations. When
/// <see langword="false"/>, no <c>#nullable</c> directive is emitted and declarations are
/// null-oblivious, which is how the generator behaved before nullable emission was added.
/// </param>
/// <param name="Namespace">The C# namespace to use for generated code. If <see langword="null"/> or empty, no namespace is generated.</param>
/// <param name="AllowInvalidCSharp">
/// Gets a value indicating whether invalid C# code is allowed.
/// Invalid C# code is code that does not compile.
/// When <see langword="true"/>, the generated C# code may contain syntax errors or other issues that prevent it from compiling,
/// but may be useful for debugging or testing purposes.
/// </param>
public record CSharpConfig(
    bool NullabilityEnabled = true,
    string? Namespace = null,
    bool AllowInvalidCSharp = false)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static CSharpConfig Default { get; } = new();
}
