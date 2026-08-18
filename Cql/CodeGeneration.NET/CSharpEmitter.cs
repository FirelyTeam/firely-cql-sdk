/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.Primitives;

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

    private readonly Dictionary<CodeLocal, string> _assignedNames = new(ReferenceEqualityComparer.Instance);

    /// <summary>
    /// Hoisted locals whose IR type is <c>bool?</c> but which are DECLARED
    /// <see cref="CqlBoolean"/>, so that a chain of CQL logic reads as
    /// <c>a_ &amp;&amp; b_</c> rather than <c>(CqlBoolean)a_ &amp;&amp; (CqlBoolean)b_</c>.
    ///
    /// <para>The IR type is deliberately left alone: the operator binder matches
    /// <c>ICqlOperators</c> overloads on it by reflection, and a <c>CqlBoolean</c> there cannot bind
    /// to a <c>bool?</c> parameter — a query predicate's <c>Func&lt;T, bool?&gt;</c> being the case
    /// that proves it. So this is a PRINTING decision only, and the printed type and the node type
    /// diverge for exactly these locals. <see cref="AsNullableBool"/> is what repays that
    /// divergence wherever the printed context needs a real <c>bool?</c>.</para>
    /// </summary>
    private readonly HashSet<CodeLocal> _cqlBooleanLocals = new(ReferenceEqualityComparer.Instance);

    /// <summary>Whether <paramref name="atom"/> denotes a local this emitter declared
    /// <see cref="CqlBoolean"/>, so the printed contexts below can stay in that type.</summary>
    private bool IsCqlBooleanLocal(Atom atom) =>
        atom.Node is CodeLocal local && _cqlBooleanLocals.Contains(local);

    /// <summary>
    /// Whether <paramref name="atom"/> already denotes a <see cref="CqlBoolean"/> value: either its
    /// own IR type is one (a short-circuit chain, whose node type genuinely is
    /// <see cref="CqlBoolean"/>), or it is a local this emitter declared as one.
    ///
    /// <para>This is what lets the three-valued questions be asked of a whole EXPRESSION and not
    /// only of a local — <c>(a_ || b_()).IsTrue</c> rather than
    /// <c>((bool?)(a_ || b_())) ?? false</c>.</para>
    ///
    /// <para>Identity and IR type ONLY, never the printed name. An earlier attempt matched names, to
    /// catch <c>implies</c>' <c>!a_</c> (whose node is a <see cref="CodeUnary"/> over the original
    /// expression rather than over the local). Names are allocated from one sequence per emission,
    /// but a deferred local-function body renders in its own scope, so a name can belong to an
    /// unrelated local by the time the match runs — it rewrote <c>b_ is null</c> on a
    /// <c>FhirUri</c> into <c>!b_.HasValue</c>. The compiler caught it; a soundness rule this
    /// cheap to get wrong is not worth a few cosmetic casts.</para>
    /// </summary>
    private bool DenotesCqlBoolean(Atom atom) =>
        CodeTypeRules.IsCqlBoolean(atom.Type)
        || IsCqlBooleanLocal(atom)
        || (atom.Node is CodeUnary { Op: CodeUnaryOp.Not, Operand: CodeLocal negated }
            && _cqlBooleanLocals.Contains(negated));

    /// <summary>
    /// <paramref name="code"/> made safe to hang a member access off. A bare identifier needs
    /// nothing; anything else must be parenthesized, and here that is a CORRECTNESS requirement
    /// rather than tidiness: <c>!e_.IsTrue</c> parses as <c>!(e_.IsTrue)</c>, which disagrees with
    /// <c>(!e_).IsTrue</c> for exactly the unknown value — <c>Null</c> gives <see langword="true"/>
    /// the first way and <see langword="false"/> the second.
    /// </summary>
    private static string MemberReceiver(string code) =>
        System.Text.RegularExpressions.Regex.IsMatch(code, @"^\w+$") ? code : $"({code})";

    /// <summary>
    /// A reference to <paramref name="atom"/> in a position that genuinely needs <c>bool?</c>,
    /// casting back when it denotes a <see cref="CqlBoolean"/>-declared local.
    ///
    /// <para>Deliberately a LAST resort. The three shapes that used to force it —
    /// <c>?? false</c> and the <c>is true</c>/<c>is false</c>/<c>is null</c> patterns — are now
    /// answered inside the type by <see cref="CqlBoolean.IsTrue"/>, <see cref="CqlBoolean.IsFalse"/>
    /// and <see cref="CqlBoolean.HasValue"/>, which return the plain <see cref="bool"/> a branch
    /// condition actually wants. What is left for this is a coalesce whose right operand is not the
    /// constant <c>false</c>, where the result must genuinely stay nullable.</para>
    ///
    /// <para><paramref name="printed"/> is passed in rather than read off the atom so the caller's
    /// parenthesization is preserved — dropping it turned <c>(x as CqlDateTime) ?? false</c> into a
    /// mis-grouped expression and 1,652 compile errors.</para>
    /// </summary>
    /// <remarks>
    /// The condition MUST be the same <see cref="DenotesCqlBoolean"/> the rewrites are gated on.
    /// It used to be the narrower <see cref="IsCqlBooleanLocal"/>, which left a gap: anything that
    /// printed as a <see cref="CqlBoolean"/> without satisfying the narrow test got neither the
    /// rewrite nor this cast, and a bare <c>?? false</c> over a <see cref="CqlBoolean"/> is CS0019.
    /// Sharing one predicate makes the two exhaustive by construction.
    /// </remarks>
    /// <remarks>
    /// Also casts unconditionally for a NEGATION, which is deliberately conservative. Whether
    /// <c>!x</c> prints as a <see cref="CqlBoolean"/> depends on how its operand printed, and finding
    /// that out means linearizing the operand — which cannot be done from here: each
    /// <c>PrintBoth</c> has its OWN memo, so linearizing a grandchild from this level hoists it a
    /// second time and leaves the first copy unreferenced (CS8321, observed twice). A redundant
    /// <c>(bool?)</c> over something already <c>bool?</c> is legal and harmless; a missing one is
    /// CS0019, so the asymmetry is worth paying.
    /// </remarks>
    private string AsNullableBool(Atom atom, string printed) =>
        DenotesCqlBoolean(atom) || atom.Node is CodeUnary { Op: CodeUnaryOp.Not }
            ? $"((bool?){printed})"
            : printed;

    /// <param name="typeToCSharpConverter">Renders .NET types as C# type syntax.</param>
    /// <param name="namingConventions">The generated-class naming conventions the printed
    /// bodies must agree with (see <see cref="ICSharpNamingConventions"/>); provided by the
    /// library scaffolding writer.</param>
    public CSharpEmitter(
        TypeToCSharpConverter typeToCSharpConverter,
        ICSharpNamingConventions namingConventions)
    {
        _typeToCSharpConverter = typeToCSharpConverter;
        _namingConventions = namingConventions;
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
        _cqlBooleanLocals.Clear();

        var scope = Scope.CreateRoot(this, lambda.Parameters);
        var result = scope.Linearize(BodyWithoutRootBoolConversion(lambda), tailPosition: true);

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
    /// The body to linearize for a member or local function, with the builder's outbound
    /// <see cref="CqlBoolean"/>-to-<c>bool?</c> conversion dropped when it sits at the ROOT.
    ///
    /// <para>At the root it is always redundant, because the declared return type is computed
    /// from the un-unwrapped <c>Lambda.Body.Type</c> — by the scaffolding writer for a member,
    /// by <c>HoistLocalFunction</c> for a local function — so it stays <c>bool?</c> either way,
    /// and <c>return</c>-ing a <see cref="CqlBoolean"/> into a <c>bool?</c> signature converts
    /// implicitly. Dropping it at print time rather than in the builder is exactly what keeps
    /// the signature intact: only the printed body changes.</para>
    ///
    /// <para>Only at the root. Everywhere else the same conversion is load-bearing and must
    /// stay, because <c>?? false</c>, a lifted <c>!</c> and the null patterns each genuinely
    /// need a <c>bool?</c> and have no implicit conversion to fall back on (see #1514).</para>
    /// </summary>

    private static CodeExpression BodyWithoutRootBoolConversion(CodeLambda lambda) =>
        lambda.Body is CodeCast { Type: var castType, Operand: { Type: var operandType } inner }
        && CodeTypeRules.IsNullableBool(castType)
        // bool as well as CqlBoolean: both convert to bool? implicitly at the return, so the cast is
        // redundant either way. The bool case is what IsTrue/IsFalse produce.
        && (CodeTypeRules.IsCqlBoolean(operandType) || CodeTypeRules.IsPlainBool(operandType))
            ? inner
            : lambda.Body;

    /// <summary>
    /// The expression under an inbound <see cref="CqlBoolean"/> conversion the builder added.
    ///
    /// <para>Redundant in every position that can absorb the conversion implicitly, of which there
    /// are two: a local function's body, whose <c>return</c> converts into a
    /// <see cref="CqlBoolean"/>-declared signature; and a short-circuit operator's RIGHT operand,
    /// because overload resolution for the user-defined <c>&amp;</c>/<c>|</c> backing
    /// <c>&amp;&amp;</c>/<c>||</c> applies an implicit conversion to that operand.</para>
    ///
    /// <para>Not the LEFT operand, which is not a matter of taste: C# synthesises
    /// <c>&amp;&amp;</c>/<c>||</c> from the left operand's own <c>operator true</c>/
    /// <c>operator false</c>, so a <c>bool?</c> left operand has no <c>&amp;&amp;</c> at all and its
    /// conversion is load-bearing.</para>
    /// </summary>
    private static CodeExpression UnwrapCqlBooleanConversion(CodeExpression node) =>
        node is CodeCast { Type: var castType, Operand: { } inner } && CodeTypeRules.IsCqlBoolean(castType)
            ? inner
            : node;

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
        _cqlBooleanLocals.Clear();

        var scope = Scope.CreateRoot(this, lambda.Parameters);
        var result = scope.Linearize(BodyWithoutRootBoolConversion(lambda), tailPosition: true);
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
