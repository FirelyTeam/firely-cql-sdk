/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="ElmToolkit"/>.
/// </summary>
/// <param name="DebugSymbolsFormat">The format of the debug information emitted by the compiler.</param>
/// <param name="AllowScopeRedefinition">Allows a child scope to redefine an existing parent scope. Default is <see langword="true" />.</param>
/// <param name="AllowUnresolvedExternals">
/// When <see langword="true"/>, functions declared external will throw <see cref="NotImplementedException"/> at runtime
/// if they are not found in customImplementations. When <see langword="false"/>, an
/// <see cref="InvalidOperationException"/> will be thrown during compilation if they are not found in customImplementations.
/// The default value is <see langword="true"/>.
/// </param>
/// <param name="AllowInvalidCSharp">
/// Gets a value indicating whether invalid C# code is allowed.
/// Invalid C# code is code that does not compile.
/// When <see langword="true"/>, the generated C# code may contain syntax errors or other issues that prevent it from compiling,
/// but may be useful for debugging or testing purposes.
/// </param>
/// <param name="CSharpNamespace">The C# namespace to use for generated code. If <see langword="null"/> or empty, no namespace is generated.
/// Superseded: this setting's canonical home is <see cref="Toolkit.CSharpGeneratingConfig.CSharpNamespace"/> (a value set there wins);
/// this flat property remains as a backwards-compatible fallback and will be removed at the next major release.</param>
public record ElmToolkitConfig(
    DebugSymbolsFormat DebugSymbolsFormat = DebugSymbolsFormat.None,
    bool AllowScopeRedefinition = true,
    bool AllowUnresolvedExternals = true,
    bool AllowInvalidCSharp = false,
    string? CSharpNamespace = null)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static ElmToolkitConfig Default { get; } = new();

    /// <summary>
    /// Settings controlling how the C# code generator formats the code it emits — purely
    /// formatting choices; the emitted behavior is identical. Grouped in their own type so
    /// future C#-generation options compose here rather than accumulating on this record.
    /// </summary>
    public CSharpGeneratingConfig CSharpGeneratingConfig { get; init; } = CSharpGeneratingConfig.Default;

    /// <summary>
    /// Allows a child scope to redefine an existing parent scope. Default is <see langword="true" />.
    /// </summary>
    /// <remarks>
    /// For example, consider this query:
    /// <code>
    /// IinCC X
    ///    return
    ///    (
    ///        Tuple
    ///        {
    ///            sdate: start of X,
    ///            edate:
    ///            end of X,
    ///            ndate:
    ///            end of X + System.Quantity { value: DDiff, unit: 'day' }
    ///        }
    ///    ) X
    ///         return Tuple
    ///         {
    ///             CInterval: Interval[X.sdate, X.edate],
    ///             RInterval: Interval[X.sdate, X.ndate]
    ///         }
    /// </code>
    /// Here, X is being used twice, because the source is a subquery. X is used in the subquery and is also used
    /// in the main query. ELM does not limit the scope of the first X to only the subquery as it probably should.
    /// </remarks>
    public bool AllowScopeRedefinition { get; init; } = AllowScopeRedefinition;

    /// <summary>
    /// When <see langword="true"/>, functions declared external will throw <see cref="NotImplementedException"/> at runtime
    /// if they are not found in customImplementations. When <see langword="false"/>, an
    /// <see cref="InvalidOperationException"/> will be thrown during compilation if they are not found in customImplementations.
    /// The default value is <see langword="true"/>.
    /// </summary>
    public bool AllowUnresolvedExternals { get; init; } = AllowUnresolvedExternals;

    /// <summary>
    /// Converts the current configuration settings to <see cref="CodeBuilderSettings"/>.
    /// </summary>
    /// <returns>An instance of <see cref="CodeBuilderSettings"/> with the current configuration settings.</returns>
    internal CodeBuilderSettings ToCodeBuilderSettings() => new()
    {
        AllowScopeRedefinition = AllowScopeRedefinition,
        AllowUnresolvedExternals = AllowUnresolvedExternals
    };
}