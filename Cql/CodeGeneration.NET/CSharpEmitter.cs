/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.CodeModel;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Prints <see cref="CodeExpression"/> trees as C#.
///
/// <list type="bullet">
/// <item>nested expressions are linearized into sequential <c>T a_ = …;</c> declarations at
/// print time;</item>
/// <item>variable names are allocated per method scope from a shared sequence;</item>
/// <item>identical right-hand sides reuse the earlier local, keyed on the printed code and
/// declared type;</item>
/// <item>lambdas print as local functions, and if-chains as native <c>if</c>/<c>else</c>
/// statements.</item>
/// </list>
///
/// <para>The printed output is pinned by the golden-file tests
/// (<c>CSharpGenerationGoldenTests</c>); changing it requires regenerating the checked-in
/// golden files and bumping <c>GeneratorToolVersion</c>.</para>
///
/// <para>Instances are not thread-safe: naming state is per emission, reset at the start of
/// each <see cref="EmitBodyBlock"/>/<see cref="TryEmitExpressionBody"/> call.</para>
/// </summary>
internal partial class CSharpEmitter
{
    private readonly TypeToCSharpConverter _typeToCSharpConverter;
    private readonly ICSharpNamingConventions _namingConventions;
    private readonly Toolkit.CSharpGeneratingConfig _csharpGeneratingConfig;

    private readonly Dictionary<CodeLocal, string> _assignedNames = new(ReferenceEqualityComparer.Instance);

    /// <param name="typeToCSharpConverter">Renders .NET types as C# type syntax.</param>
    /// <param name="namingConventions">The generated-class naming conventions the printed
    /// bodies must agree with (see <see cref="ICSharpNamingConventions"/>); provided by the
    /// library scaffolding writer.</param>
    /// <param name="csharpGeneratingConfig">Formatting settings;
    /// <see cref="Toolkit.CSharpGeneratingConfig.Default"/> when omitted.</param>
    public CSharpEmitter(
        TypeToCSharpConverter typeToCSharpConverter,
        ICSharpNamingConventions namingConventions,
        Toolkit.CSharpGeneratingConfig? csharpGeneratingConfig = null)
    {
        _typeToCSharpConverter = typeToCSharpConverter;
        _namingConventions = namingConventions;
        _csharpGeneratingConfig = csharpGeneratingConfig ?? Toolkit.CSharpGeneratingConfig.Default;
    }

    /// <summary>
    /// Emits the body of a definition as a C# block statement, including the final
    /// <c>return</c>. Parameter names are taken from the lambda's <see cref="CodeLocal"/>
    /// name hints where legal (generated names on collision or keyword hints).
    /// </summary>
    public string EmitBodyBlock(CodeLambda lambda)
    {
        // Naming is scoped to one definition body: each emission starts fresh, so earlier
        // emissions can neither cause collisions nor grow the maps without bound.
        _assignedNames.Clear();

        var scope = Scope.CreateRoot(this, lambda.Parameters);
        var result = scope.Linearize(lambda.Body, tailPosition: true);

        var isb = new IndentedStringBuilder();
        isb.AppendLine("{");
        using (isb.Indent())
        {
            scope.WriteStatements(isb);
            if (result is not null) // null when the tail was emitted as a return-ing if-chain
                isb.AppendLine(TailStatement(result));
        }
        isb.Append("}");
        return isb;
    }

    /// <summary>The final statement for a block whose tail value is <paramref name="result"/>:
    /// a <c>return</c>, except before a throw-expression (the old writer's
    /// BuildBlockExpression rule — <c>return throw …</c> is not legal C#).</summary>
    private static string TailStatement(Atom result) =>
        result.Node is CodeThrow ? $"{result.Code};" : $"return {result.Code};";

    /// <summary>
    /// Emits the body of a definition as a single C# expression when it linearizes without
    /// hoisting any statements (e.g. a constant body), for the scaffolding writer's
    /// expression-bodied (<c>=> expr;</c>) member form. Returns <see langword="null"/> when
    /// the body needs hoisted statements — use <see cref="EmitBodyBlock"/> then instead.
    /// Semantically this is exactly the case where <see cref="EmitBodyBlock"/> would produce
    /// a block whose only statement is <c>return expr;</c>.
    /// </summary>
    public string? TryEmitExpressionBody(CodeLambda lambda)
    {
        _assignedNames.Clear();

        var scope = Scope.CreateRoot(this, lambda.Parameters);
        var result = scope.Linearize(lambda.Body, tailPosition: true);
        return scope.HasStatements || result is null ? null : result.Code;
    }

    /// <summary>
    /// The name the emitter assigned to each parameter of <paramref name="lambda"/> in the
    /// last <see cref="EmitBodyBlock"/>/<see cref="TryEmitExpressionBody"/> call, for the
    /// scaffolding writer to print the parameter list.
    /// </summary>
    public IReadOnlyList<string> GetParameterNames(CodeLambda lambda) =>
        [.. lambda.Parameters.Select(p => _assignedNames.TryGetValue(p, out var n) ? n : p.NameHint ?? "?")];

    /// <summary>A linearized subexpression: the C# code of a simple (non-compound)
    /// expression, plus the IR node it denotes (for type-driven peepholes).
    /// <para><see cref="KeyCode"/> is the code as it would print WITHOUT duplicate
    /// elimination — a deduplicated local contributes its own (burned) name here, not its
    /// replacement. Dedup decisions key on it, reproducing the old LocalVariableDeduper's
    /// single-pass behavior: duplicates whose operands only become identical AFTER
    /// replacement are NOT collapsed (no fixpoint), and every duplicate still consumed a
    /// name from the sequence before being removed (the letter gaps in the old output).</para></summary>
    private sealed record Atom(string Code, string KeyCode, CodeExpression Node)
    {
        public Atom(string code, CodeExpression node) : this(code, code, node) { }

        public Type Type => Node.Type;
    }
}
