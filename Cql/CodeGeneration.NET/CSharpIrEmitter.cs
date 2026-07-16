/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Ir;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Prints the typed IR (<see cref="IrExpression"/>) as C#. This replaces the combination of
/// the four expression-tree rewrite passes and <c>LambdaDefinitionWriter</c> in the previous
/// pipeline:
///
/// <list type="bullet">
/// <item>nested expressions are linearized into sequential <c>T a_ = …;</c> declarations at
/// print time (was <c>SimplifyExpressionsVisitor</c>);</item>
/// <item>variable names are allocated per method scope from a shared sequence
/// (was <c>RenameVariablesVisitor</c>);</item>
/// <item>identical right-hand sides reuse the earlier local, keyed on the printed code and
/// declared type (was <c>LocalVariableDeduper</c>'s DebugView comparison);</item>
/// <item>lambdas print as local functions, if-chains as native <c>if</c>/<c>else</c>
/// statements (no lambda-wrap tricks).</item>
/// </list>
///
/// <para>The printed output deliberately follows the existing generated-code style so that
/// the golden-file tests (<c>CSharpGenerationGoldenTests</c>) can compare the two pipelines
/// during the migration. Once the old pipeline is deleted and byte-parity no longer
/// constrains the output, the printing backend is free to change (e.g. reformatting, or
/// emitting Roslyn syntax trees from the IR) without touching the IR itself.</para>
///
/// <para>Instances are not thread-safe: naming state is per emission, reset at the start of
/// each <see cref="EmitBodyBlock"/> call.</para>
/// </summary>
internal partial class CSharpIrEmitter
{
    private readonly TypeToCSharpConverter _typeToCSharpConverter;
    private readonly ICSharpNamingConventions _namingConventions;

    private readonly Dictionary<IrLocal, string> _assignedNames = new(ReferenceEqualityComparer.Instance);
    private readonly HashSet<string> _usedNames = [];

    /// <param name="typeToCSharpConverter">Renders .NET types as C# type syntax.</param>
    /// <param name="namingConventions">The generated-class naming conventions the printed
    /// bodies must agree with (see <see cref="ICSharpNamingConventions"/>); provided by the
    /// library scaffolding writer.</param>
    public CSharpIrEmitter(
        TypeToCSharpConverter typeToCSharpConverter,
        ICSharpNamingConventions namingConventions)
    {
        _typeToCSharpConverter = typeToCSharpConverter;
        _namingConventions = namingConventions;
    }

    /// <summary>
    /// Emits the body of a definition as a C# block statement, including the final
    /// <c>return</c>. Parameter names are taken from the lambda's <see cref="IrLocal"/>
    /// name hints where legal (generated names on collision or keyword hints).
    /// </summary>
    public string EmitBodyBlock(IrLambda lambda)
    {
        // Naming is scoped to one definition body: each emission starts fresh, so earlier
        // emissions can neither cause collisions nor grow the maps without bound.
        _assignedNames.Clear();
        _usedNames.Clear();

        var scope = Scope.CreateRoot(this, lambda.Parameters);
        var result = scope.Linearize(lambda.Body, tailPosition: true);

        var isb = new IndentedStringBuilder();
        isb.AppendLine("{");
        using (isb.Indent())
        {
            scope.WriteStatements(isb);
            if (result is not null) // null when the tail was emitted as a return-ing if-chain
                isb.AppendLine($"return {result.Code};");
        }
        isb.Append("}");
        return isb;
    }

    /// <summary>
    /// The name the emitter assigned to each parameter of <paramref name="lambda"/> in the
    /// last <see cref="EmitBodyBlock"/> call, for the scaffolding writer to print the
    /// parameter list.
    /// </summary>
    public IReadOnlyList<string> GetParameterNames(IrLambda lambda) =>
        [.. lambda.Parameters.Select(p => _assignedNames.TryGetValue(p, out var n) ? n : p.NameHint ?? "?")];

    /// <summary>A linearized subexpression: the C# code of a simple (non-compound)
    /// expression, plus the IR node it denotes (for type-driven peepholes).</summary>
    private sealed record Atom(string Code, IrExpression Node)
    {
        public Type Type => Node.Type;
    }
}
