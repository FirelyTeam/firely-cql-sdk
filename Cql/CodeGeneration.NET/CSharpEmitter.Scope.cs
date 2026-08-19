/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.CodeModel;

namespace Hl7.Cql.CodeGeneration.NET;

internal partial class CSharpEmitter
{
    /// <summary>
    /// One statement scope (a method body or local-function body). Holds the statements
    /// hoisted so far, the dedup table for this scope, and the name reservations. The name
    /// sequence itself is shared across nested scopes so generated names never collide.
    /// </summary>
    private sealed class Scope
    {
        private readonly CSharpEmitter _emitter;
        private readonly VariableNameGenerator _names;

        // Statements are deferred renderers: plain declarations resolve immediately, but a
        // hoisted local function's INTERIOR renders only when the enclosing scope writes out.
        // This reproduces the old RenameVariablesVisitor naming order, which named all of a
        // block's own variables before descending into nested function bodies (so an inner
        // local is named h_ even though textually it precedes the d_..g_ that follow its
        // enclosing function definition).
        private readonly List<Func<string>> _statements = [];
        private readonly Dictionary<string, Atom> _dedup = [];

        private Scope(CSharpEmitter emitter, VariableNameGenerator names)
        {
            _emitter = emitter;
            _names = names;
        }

        public static Scope CreateRoot(CSharpEmitter emitter, IReadOnlyList<CodeLocal> parameters)
        {
            var names = new VariableNameGenerator(
                reserved: parameters.Select(p => p.NameHint).OfType<string>(),
                postfix: "_");
            var scope = new Scope(emitter, names);
            scope.NameParameters(parameters);
            return scope;
        }

        private Scope CreateNested(IReadOnlyList<CodeLocal> parameters)
        {
            var nested = new Scope(
                _emitter,
                // The GENERATED letter sequence must never collide with a hint name visible in
                // this lineage: the old VariableNameGenerator.Reserved list, threaded the same
                // way (ForNewScope conses the new scope's names onto a copy of the parent's).
                _names.ForNewScope(parameters.Select(p => p.NameHint).OfType<string>()));
            nested.NameParameters(parameters);
            return nested;
        }

        private void NameParameters(IReadOnlyList<CodeLocal> parameters)
        {
            foreach (var p in parameters)
            {
                if (!_emitter._assignedNames.ContainsKey(p))
                    _emitter._assignedNames[p] = AllocateName(p.NameHint);
            }
        }

        /// <summary>
        /// Allocates a variable name, honoring <paramref name="hint"/> UNCONDITIONALLY when it
        /// is not a C# keyword — exactly like the old pipeline, whose
        /// RenameVariablesVisitor only ever named unnamed BLOCK variables and never touched
        /// lambda parameters: the old writer printed a parameter's <c>p.Name</c> (the CQL
        /// alias) verbatim wherever it occurred (BuildLambdaExpressionParameters /
        /// GetOrCreateName). In particular a nested lambda's alias reuses the ancestor's name
        /// verbatim, shadowing it — HEDIS 2025's PCR_Details maps over "stay" tuples inside a
        /// lambda whose own parameter is already named "stay", and the old output prints both
        /// as <c>stay</c>. (An earlier lineage-reservation rule here renamed the inner one to
        /// a generated name; that was stricter than old and broke byte parity.)
        /// <para>Also deliberately NOT guarded (matching the old pipeline exactly): a hint
        /// that happens to collide with a GENERATED name (an alias literally shaped like
        /// <c>a_</c>) is used verbatim — such an alias would produce the same non-compiling
        /// output from both pipelines.</para>
        /// <para>The keyword guard is a deliberate DEVIATION from old: the old writer printed
        /// the declaration <c>@keyword</c>-escaped (EscapeKeywords) but the REFERENCES
        /// unescaped (GetOrCreateName uses the raw name), i.e. non-compiling output. No
        /// corpus exercises a keyword-named CQL alias; falling back to a generated name keeps
        /// the output legal. Recorded in the plan doc's post-parity ledger.</para>
        /// </summary>
        private string AllocateName(string? hint)
        {
            if (hint is not null
                && SyntaxFacts.GetKeywordKind(hint) == SyntaxKind.None)
                return hint;

            // The generated-letter sequence (_names) is shared and monotonically increasing
            // across the whole emission, so it never repeats a value; VariableNameGenerator's
            // own Reserved list (threaded per-lineage via ForNewScope) already skips any name
            // reserved by this lineage's hints, so no further legality check is needed here.
            return _names.Next();
        }

        /// <summary>True when linearization hoisted at least one statement onto this scope —
        /// i.e. the linearized body cannot print as a single expression.</summary>
        public bool HasStatements => _statements.Count > 0;

        public void WriteStatements(IndentedStringBuilder isb)
        {
            foreach (var statement in _statements)
                isb.AppendLine(statement());
        }

        /// <summary>
        /// Linearizes <paramref name="node"/>: hoists compound subexpressions into
        /// <c>T a_ = …;</c> statements on this scope and returns the resulting simple
        /// expression — or null when the node was a tail-position if-chain emitted entirely
        /// as <c>return</c>-ing statements.
        /// </summary>
        public Atom? Linearize(CodeExpression node, bool tailPosition = false)
        {
            // if(true, A, B) => A / if(false, A, B) => B before dispatch, so the discarded
            // branch is never linearized — the old RedundantCastsTransformer fold (#1361).
            node = FoldConstantTest(node);

            switch (node)
            {
                // Simple expressions print in place, nothing to hoist.
                case CodeConstant or CodeDefault or CodeContextParameter:
                    return new Atom(_emitter.PrintSimple(node), node);

                case CodeLocal local:
                    return new Atom(_emitter._assignedNames.TryGetValue(local, out var name)
                        ? name
                        : throw new InvalidOperationException($"Local '{local}' is used before it is introduced by any lambda or hoisted assignment."),
                        local);

                case CodeLambda lambda:
                    return HoistLocalFunction(lambda);

                case CodeConditional conditional:
                    return LinearizeConditional(conditional, tailPosition);

                case CodeIfChain chain:
                    return LinearizeIfChain(chain, tailPosition);

                // Pass-through composites: printed inline over their (spine-linearized)
                // children instead of being hoisted into a local. This mirrors the old
                // SimplifyExpressionsVisitor's dispatch exactly — Constant/Parameter/New/
                // Member/ElmAs/Default passed straight through, Convert/TypeAs/Throw unaries
                // and Equal/NotEqual/Coalesce binaries were not simplified — balancing
                // unnecessary hoisting against per-line readability.
                case CodeProperty { NullConditional: false }
                    or CodeCast
                    or CodeNew
                    or CodeThrow
                    or CodeBinary { Op: CodeBinaryOp.Equal or CodeBinaryOp.NotEqual or CodeBinaryOp.Coalesce }:
                {
                    var (printed, keyPrinted) = PrintBoth(node);
                    return new Atom(printed, keyPrinted, node);
                }

                default:
                {
                    // Spine node (calls, constructions, null-conditional access, type tests,
                    // logical operators): linearize the children, print this node shallowly
                    // over the child atoms, and hoist it into a named local (deduplicated).
                    var (printed, keyPrinted) = PrintBoth(node);
                    return Hoist(printed, keyPrinted, node);
                }
            }
        }

        /// <summary>Prints <paramref name="node"/> shallowly twice over the same linearized
        /// children: once with replacement codes (the real output) and once with
        /// pre-replacement key codes (for dedup decisions). Children are linearized exactly
        /// once via the memo.</summary>
        private (string printed, string keyPrinted) PrintBoth(CodeExpression node)
        {
            Dictionary<CodeExpression, Atom> memo = new(ReferenceEqualityComparer.Instance);
            Atom Child(CodeExpression child) =>
                memo.TryGetValue(child, out var atom) ? atom : memo[child] = Linearize(child)!;

            var printed = _emitter.PrintShallow(node, child => Child(child));
            var keyPrinted = _emitter.PrintShallow(node, child => Child(child) with { Code = Child(child).KeyCode });
            return (printed, keyPrinted);
        }

        private Atom Hoist(string code, string keyCode, CodeExpression node)
        {
            var typeSyntax = _emitter.ToCSharpDeclaration(node);
            var dedupKey = $"{keyCode}::{typeSyntax}";
            // A duplicate reuses the original's local — name, key identity and all. (The old
            // pipeline allocated a fresh name for the duplicate before the deduper removed its
            // statement, which burned a letter out of the naming sequence and, because that
            // burned name keyed the duplicate for its parents, kept identical parent
            // expressions from ever deduplicating with each other.)
            if (_dedup.TryGetValue(dedupKey, out var existing))
                return existing;

            var local = new CodeLocal(node.Type);
            var name = AllocateName(null);
            _emitter._assignedNames[local] = name;
            var statement = $"{typeSyntax} {name} = {code};";
            _statements.Add(() => statement);

            var atom = new Atom(name, name, local);
            _dedup[dedupKey] = atom;
            return atom;
        }

        private Atom HoistLocalFunction(CodeLambda lambda)
        {
            // The function's own name is allocated now (it participates in this scope's
            // naming sequence), but its interior renders deferred — see _statements.
            var functionLocal = new CodeLocal(lambda.Type);
            var functionName = AllocateName(null);
            _emitter._assignedNames[functionLocal] = functionName;

            _statements.Add(() =>
            {
                var nested = CreateNested(lambda.Parameters);
                var result = nested.Linearize(lambda.Body, tailPosition: true);

                var parameterList = string.Join(", ",
                    lambda.Parameters.Select(p => $"{_emitter._typeToCSharpConverter.ToCSharpDeclaration(p.Type)} {_emitter._assignedNames[p]}"));
                var objectReturn = lambda.Body.Type == typeof(object);
                var returnType = objectReturn
                    ? _emitter._typeToCSharpConverter.ToCSharp(lambda.Body.Type)
                    : _emitter._typeToCSharpConverter.ToCSharpDeclaration(lambda.Body.Type);

                // A body that linearizes without hoisting any statement prints expression-
                // bodied ("=> expr;"), matching the old writer's BuildLambdaOperator, which
                // used the block ("{ }") form only `lambda.Body is BlockExpression` — i.e. only
                // when simplification actually produced a multi-statement block. The old
                // BuildBlockExpression's "give local function definitions some space" rule also
                // keyed on the body being a BlockExpression, so the expression-bodied form gets
                // none of the surrounding blank lines either.
                if (!nested.HasStatements && result is not null)
                {
                    var expressionBody = objectReturn ? $"{result.Code.ParenthesizeIfNeeded()}!" : result.Code;
                    return $"{returnType} {functionName}({parameterList}) => {expressionBody};";
                }

                // Old format: blank line before the definition, opening brace on the
                // signature line, blank line after (via the trailing newline).
                var isb = new IndentedStringBuilder();
                isb.AppendLine("");
                isb.AppendLine($"{returnType} {functionName}({parameterList}) {{");
                using (isb.Indent())
                {
                    nested.WriteStatements(isb);
                    if (result is not null)
                    {
                        if (objectReturn && result.Node is not CodeThrow)
                            isb.AppendLine($"return {result.Code.ParenthesizeIfNeeded()}!;");
                        else
                            isb.AppendLine(TailStatement(result));
                    }
                }
                isb.AppendLine("}");
                return isb;
            });

            return new Atom(functionName, functionLocal);
        }

        private Atom? LinearizeConditional(CodeConditional conditional, bool tailPosition)
        {
            // A "simple" conditional (IfFalse is not itself a conditional, and neither branch
            // would hoist anything) prints as one inline ternary — its entire subtree, the
            // test included (however complex). Everything else flattens the else-chain into
            // native if/else statement form.
            if (conditional.IfFalse is not CodeConditional
                && IsInlineOnly(conditional.IfTrue)
                && IsInlineOnly(conditional.IfFalse))
            {
                return new Atom(_emitter.PrintInlineConditional(conditional, _emitter.PrintFullyInline), conditional);
            }

            var cases = new List<(CodeExpression When, CodeExpression Then)>();
            CodeExpression current = conditional;
            while (current is CodeConditional c)
            {
                cases.Add((c.Test, c.IfTrue));
                // Fold constant-test conditionals while walking the else-chain too, so a
                // folded link collapses into its surviving branch instead of becoming a case.
                current = FoldConstantTest(c.IfFalse);
            }
            return LinearizeConditionalStatements(conditional.Type, cases, current, tailPosition);
        }

        /// <summary>
        /// True when linearizing <paramref name="node"/> would hoist no statements — the IR
        /// equivalent of the old visitor's trial visit yielding zero assignments. Spine nodes
        /// (calls, constructions, null-conditional access, type tests, logical operators,
        /// lambdas, if-chains) always hoist; pass-through nodes are inline-only when all
        /// their children are. A nested conditional counts as inline-only when it is itself
        /// "simple" — its test is not examined, exactly like the old trial visit (which
        /// returned simple conditionals unvisited).
        /// </summary>
        private static bool IsInlineOnly(CodeExpression node) =>
            node switch
            {
                CodeConstant or CodeDefault or CodeContextParameter or CodeLocal => true,
                CodeProperty { NullConditional: false } p => p.Receiver is null || IsInlineOnly(p.Receiver),
                CodeCast c => IsInlineOnly(c.Operand),
                CodeNew n => n.Arguments.All(IsInlineOnly),
                CodeThrow t => IsInlineOnly(t.Exception),
                CodeBinary { Op: CodeBinaryOp.Equal or CodeBinaryOp.NotEqual or CodeBinaryOp.Coalesce } b =>
                    IsInlineOnly(b.Left) && IsInlineOnly(b.Right),
                CodeConditional nested =>
                    nested.IfFalse is not CodeConditional
                    && IsInlineOnly(nested.IfTrue)
                    && IsInlineOnly(nested.IfFalse),
                _ => false,
            };

        private Atom? LinearizeIfChain(CodeIfChain chain, bool tailPosition) =>
            LinearizeConditionalStatements(chain.Type, chain.Cases, chain.Else, tailPosition);

        /// <summary>
        /// Emits a multi-branch conditional as native if/else statements. In tail position
        /// the branch blocks <c>return</c> directly and no atom is returned; otherwise a
        /// result local is declared up front, every branch block assigns it (or throws), and
        /// that local is the conditional's value.
        ///
        /// <para>Conditions within the old isSimpleWhen budget (at most one hoist-worth of
        /// complexity, see <see cref="ConditionPrintsInline"/>) print fully inline, giving
        /// flat <c>else if</c> chains for the common case. A condition that needs its own
        /// statements may only evaluate after all earlier conditions have tested false, so
        /// the chain nests instead: the remainder moves into the <c>else</c> block, where
        /// the condition's statements print before a fresh <c>if</c>. This preserves the
        /// as-late-as-possible evaluation the old pipeline got from wrapping such conditions
        /// (and the whole chain) in zero-argument local functions — without the functions.</para>
        /// </summary>
        private Atom? LinearizeConditionalStatements(
            Type resultType,
            IReadOnlyList<(CodeExpression When, CodeExpression Then)> cases,
            CodeExpression @else,
            bool tailPosition)
        {
            if (tailPosition)
            {
                _statements.Add(() => RenderChain(resultName: null, cases, @else));
                return null;
            }

            var resultLocal = new CodeLocal(resultType);
            var resultName = AllocateName(null);
            _emitter._assignedNames[resultLocal] = resultName;

            // Declared without an initializer; the compiler's definite-assignment analysis
            // verifies every branch of the chain below assigns it (or throws).
            _statements.Add(() =>
            {
                var typeSyntax = _emitter._typeToCSharpConverter.ToCSharp(resultType);
                if (!resultType.IsValueType
                    && !resultType.IsPointer
                    && !resultType.IsByRef
                    && !resultType.IsGenericParameter
                    && !_emitter._typeToCSharpConverter.ShouldUseTupleType(resultType))
                {
                    typeSyntax += "?";
                }

                return $"{typeSyntax} {resultName};";
            });
            _statements.Add(() => RenderChain(resultName, cases, @else));
            return new Atom(resultName, resultLocal);
        }

        /// <summary>Renders deferred (like every hoisted interior — see <c>_statements</c>),
        /// so nested scopes allocate their names in block order.</summary>
        private string RenderChain(
            string? resultName,
            IReadOnlyList<(CodeExpression When, CodeExpression Then)> cases,
            CodeExpression @else)
        {
            var isb = new IndentedStringBuilder();
            EmitChainLevel(isb, resultName, cases, 0, @else);
            return isb.ToString().TrimEnd('\r', '\n');
        }

        private void EmitChainLevel(
            IndentedStringBuilder isb,
            string? resultName,
            IReadOnlyList<(CodeExpression When, CodeExpression Then)> cases,
            int start,
            CodeExpression @else)
        {
            var first = true;
            for (int i = start; i < cases.Count; i++)
            {
                var (when, then) = cases[i];

                string test;
                if (ConditionPrintsInline(when))
                {
                    test = _emitter.PrintFullyInline(when);
                }
                else if (first)
                {
                    // The first condition at a nesting level can put its statements right
                    // here — nothing needs to run before them at this level.
                    var testScope = CreateNested([]);
                    var atom = testScope.Linearize(when)!;
                    testScope.WriteStatements(isb);
                    test = atom.Code;
                }
                else
                {
                    // A later condition's statements may only run after all earlier
                    // conditions tested false: continue the chain nested in the else.
                    isb.AppendLine("else");
                    isb.AppendLine("{");
                    using (isb.Indent())
                        EmitChainLevel(isb, resultName, cases, i, @else);
                    isb.AppendLine("}");
                    return;
                }

                isb.AppendLine(first ? $"if ({test})" : $"else if ({test})");
                EmitBranchBlock(isb, resultName, then);
                first = false;
            }

            isb.AppendLine("else");
            EmitBranchBlock(isb, resultName, @else);
        }

        /// <summary>
        /// Whether a condition prints fully inline in its <c>if</c>/<c>else if</c> — the old
        /// isSimpleWhen rule: at most one hoist-worth of complexity (a single call, type
        /// test or null-conditional access, plus pass-through wrappers). Conditions above
        /// the budget get statement form instead.
        /// </summary>
        private static bool ConditionPrintsInline(CodeExpression when) =>
            CountSpineNodes(when) <= 1;

        /// <summary>The number of statements linearizing <paramref name="node"/> would hoist —
        /// the IR equivalent of the old trial visit's assignment count.</summary>
        private static int CountSpineNodes(CodeExpression node) =>
            node switch
            {
                CodeConstant or CodeDefault or CodeContextParameter or CodeLocal => 0,
                CodeProperty { NullConditional: false } p => p.Receiver is null ? 0 : CountSpineNodes(p.Receiver),
                // A null-conditional member access was the custom NullConditionalMemberExpression
                // in the old pipeline — an extension node, NOT a MemberExpression — so
                // SimplifyExpressionsVisitor.DoVisit fell through to "_ => MakeLet(...)": exactly
                // one assignment for itself plus its receiver's. That keeps a when-condition like
                // "info?.snfStay ?? false" (HEDIS PCR_Elements) or "period?.StartElement is null"
                // (FHIRHelpers ToInterval) within isSimpleWhen's "<= 1" budget, printing inline.
                CodeProperty { NullConditional: true } p => 1 + (p.Receiver is null ? 0 : CountSpineNodes(p.Receiver)),
                CodeCast c => CountSpineNodes(c.Operand),
                CodeNew n => n.Arguments.Sum(CountSpineNodes),
                CodeThrow t => CountSpineNodes(t.Exception),
                CodeBinary { Op: CodeBinaryOp.Equal or CodeBinaryOp.NotEqual or CodeBinaryOp.Coalesce } b =>
                    CountSpineNodes(b.Left) + CountSpineNodes(b.Right),
                CodeConditional c when
                    c.IfFalse is not CodeConditional && IsInlineOnly(c.IfTrue) && IsInlineOnly(c.IfFalse) => 0,
                // A NON-simple conditional still counts exactly ONE hoist as a when-condition:
                // the old trial visit (SimplifyExpressionsVisitor.VisitConditional) converted it
                // via ToCwt and VisitCaseWhenThenExpression, whose branch contents went to
                // NESTED visitors — only "MakeLet(caseStatementLambda)" landed on the trial
                // visitor itself. isSimpleWhen's "<= 1" therefore held and the when printed
                // inline as the raw ternary, branches and all (BuildExpression of the
                // unvisited ConditionalExpression). Found via the HEDIS 2025 corpus
                // (TRC_Elements/IET_Elements/AISE_Reporting/HEDIS's
                // "if (((X) ?? false ? A : B)"-shaped when-conditions).
                CodeConditional => 1,
                CodeInvoke i => 1 + (i.Receiver is null ? 0 : CountSpineNodes(i.Receiver)) + i.Arguments.Sum(CountSpineNodes),
                // A type test (old: TypeBinaryExpression) also had no special case in the old
                // DoVisit — "_ => MakeLet(...)", one assignment plus its operand's. Keeps
                // "proc is CodeableConcept" (HEDIS Claims/Encounters) inline as a when.
                CodeTypeIs t => 1 + CountSpineNodes(t.Operand),
                // A definition/function call is DoVisit's default case in the old visitor too
                // (DefinitionCallExpression/FunctionCallExpression aren't in its pass-through
                // list — Constant/Parameter/New/Member/ElmAs/Default — nor separately handled),
                // so it falls to "_ => MakeLet(base.Visit(node))": exactly one assignment for
                // itself plus whatever its (visited) arguments would need. Without this case
                // (falling through to the "2" default below), a when-condition shaped
                // "Coalesce(DefinitionCall, false)" always hoisted into a zero-arg bool
                // function instead of printing inline like old's
                // "(this.Foo(context)) ?? false" (isSimpleWhen's threshold is "<= 1") —
                // ~131 HEDIS 2025 libraries hit this (e.g. AAB_Details' data-source guards).
                CodeDefinitionCall d => 1 + d.Arguments.Sum(CountSpineNodes),
                _ => 2, // any other spine node: treat as "complex enough" to defer
            };

        /// <summary>
        /// Emits a branch block of an if/else chain: hoisted statements, then either
        /// <c>return value;</c> (tail position, <paramref name="resultName"/> null) or
        /// <c>resultName = value;</c> — or a bare <c>throw</c> when the branch's value is a
        /// throw-expression (neither <c>return throw …</c> nor <c>x = throw …;</c> is wanted
        /// here; the throwing branch needs no assignment for definite assignment).
        /// </summary>
        private void EmitBranchBlock(IndentedStringBuilder isb, string? resultName, CodeExpression value)
        {
            isb.AppendLine("{");
            using (isb.Indent())
            {
                var branchScope = CreateNested([]);
                var atom = branchScope.Linearize(value, tailPosition: resultName is null);
                branchScope.WriteStatements(isb);
                if (atom is not null)
                {
                    if (resultName is null || atom.Node is CodeThrow)
                        isb.AppendLine(TailStatement(atom));
                    else
                        isb.AppendLine($"{resultName} = {atom.Code};");
                }
            }
            isb.AppendLine("}");
        }
    }
}
