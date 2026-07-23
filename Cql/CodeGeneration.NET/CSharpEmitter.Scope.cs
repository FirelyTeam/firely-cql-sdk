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
                    return LinearizeConditional(conditional);

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
            var typeSyntax = _emitter._typeToCSharpConverter.ToCSharp(node.Type);
            var dedupKey = $"{keyCode}::{typeSyntax}";
            if (_dedup.TryGetValue(dedupKey, out var existing))
            {
                // The old pipeline still named the duplicate before the deduper removed its
                // statement, leaving a gap in the letter sequence; the burned name is the
                // duplicate's key identity for any parent's dedup decision.
                var burnedName = AllocateName(null);
                return existing with { KeyCode = burnedName };
            }

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
                    lambda.Parameters.Select(p => $"{_emitter._typeToCSharpConverter.ToCSharp(p.Type)} {_emitter._assignedNames[p]}"));
                var returnType = _emitter._typeToCSharpConverter.ToCSharp(lambda.Body.Type);

                // A body that linearizes without hoisting any statement prints expression-
                // bodied ("=> expr;"), matching the old writer's BuildLambdaOperator, which
                // used the block ("{ }") form only `lambda.Body is BlockExpression` — i.e. only
                // when simplification actually produced a multi-statement block. The old
                // BuildBlockExpression's "give local function definitions some space" rule also
                // keyed on the body being a BlockExpression, so the expression-bodied form gets
                // none of the surrounding blank lines either.
                if (!nested.HasStatements && result is not null)
                    return $"{returnType} {functionName}({parameterList}) => {result.Code};";

                // Old format: blank line before the definition, opening brace on the
                // signature line, blank line after (via the trailing newline).
                var isb = new IndentedStringBuilder();
                isb.AppendLine("");
                isb.AppendLine($"{returnType} {functionName}({parameterList}) {{");
                using (isb.Indent())
                {
                    nested.WriteStatements(isb);
                    if (result is not null)
                        isb.AppendLine(TailStatement(result));
                }
                isb.AppendLine("}");
                return isb;
            });

            return new Atom(functionName, functionLocal);
        }

        private Atom LinearizeConditional(CodeConditional conditional)
        {
            // Mirrors the old SimplifyExpressionsVisitor.VisitConditional: a "simple"
            // conditional (IfFalse is not itself a conditional, and neither branch would
            // hoist anything) is returned UNVISITED — its entire subtree, the test included
            // (however complex), prints as one inline ternary. Everything else flattens the
            // else-chain into statement form.
            if (conditional.IfFalse is not CodeConditional
                && IsInlineOnly(conditional.IfTrue)
                && IsInlineOnly(conditional.IfFalse))
            {
                return new Atom(_emitter.PrintInlineConditional(conditional, _emitter.PrintFullyInline), conditional);
            }

            // Flatten the else-if chain (old: ToCwt) and emit in the old pipeline's form: a
            // zero-parameter local function containing the if/else chain, invoked where the
            // value is needed. (A native if/else chain would be cleaner — post-parity
            // cleanup, see docs/linq-expression-removal-plan.md.)
            var cases = new List<(CodeExpression When, CodeExpression Then)>();
            CodeExpression current = conditional;
            while (current is CodeConditional c)
            {
                cases.Add((c.Test, c.IfTrue));
                // Fold constant-test conditionals while walking the else-chain too, so a
                // folded link collapses into its surviving branch instead of becoming a case.
                current = FoldConstantTest(c.IfFalse);
            }
            return HoistConditionalFunction(conditional.Type, cases, current);
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
            HoistConditionalFunction(chain.Type, chain.Cases, chain.Else);

        /// <summary>
        /// Emits a multi-branch conditional in the old pipeline's exact form: a hoisted
        /// zero-parameter local function (opening brace on the signature line, a trailing
        /// <c>;</c> after the final else block — quirks of the old CaseWhenThen printing,
        /// preserved for golden parity) whose branches <c>return</c>, invoked as
        /// <c>name()</c> wherever the value is needed.
        /// </summary>
        private Atom HoistConditionalFunction(
            Type resultType,
            IReadOnlyList<(CodeExpression When, CodeExpression Then)> cases,
            CodeExpression @else)
        {
            // The function's own name participates in this scope's naming sequence now; the
            // interior renders deferred, like every hoisted function — see _statements.
            var functionLocal = new CodeLocal(resultType);
            var functionName = AllocateName(null);
            _emitter._assignedNames[functionLocal] = functionName;

            _statements.Add(() =>
            {
                // The whole if/else chain lives inside the function's own scope: hoisted
                // when-functions and branch statements belong to it, and evaluation stays
                // deferred until the function is invoked — the old lambda-wrap semantics.
                var functionScope = CreateNested([]);

                // Every case's when-condition is visited — and, for complex ones, hoisted into
                // its own zero-parameter local function — BEFORE any if/else-if statement
                // prints. This mirrors the old VisitCaseWhenThenExpression, which ran
                // visitCase (and so every when-lambda) for ALL cases via one shared block
                // visitor, collecting their hoisted statements up front, before the
                // CaseWhenThenExpression was rendered into its block.
                var tests = cases.Select(c => functionScope.PrintWhen(c.When)).ToList();

                var isb = new IndentedStringBuilder();
                isb.AppendLine(""); // the old writer's blank line before the function definition
                isb.AppendLine($"{_emitter._typeToCSharpConverter.ToCSharp(resultType)} {functionName}() {{");
                using (isb.Indent())
                {
                    functionScope.WriteStatements(isb); // all when-functions hoisted by PrintWhen, up front

                    bool first = true;
                    for (int i = 0; i < cases.Count; i++)
                    {
                        isb.AppendLine(first ? $"if ({tests[i]})" : $"else if ({tests[i]})");
                        EmitBranchBlock(isb, cases[i].Then, terminator: null);
                        first = false;
                    }
                    isb.AppendLine("else");
                    EmitBranchBlock(isb, @else, terminator: ";");
                }
                isb.AppendLine("}");
                return isb;
            });

            return new Atom($"{functionName}()", functionLocal);
        }

        /// <summary>
        /// Prints a when-condition following the old isSimpleWhen rule: conditions that would
        /// hoist at most one statement print fully inline; more complex ones are wrapped in a
        /// hoisted zero-parameter function and invoked, keeping their evaluation as late as
        /// possible (a later case's condition must not evaluate before the earlier cases have
        /// been tested).
        /// </summary>
        private string PrintWhen(CodeExpression when)
        {
            if (CountSpineNodes(when) <= 1)
                return _emitter.PrintFullyInline(when);

            var atom = HoistLocalFunction(new CodeLambda([], when));
            return $"{atom.Code}()";
        }

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
        /// Emits <c>{ …hoisted…; return value; }</c> for a branch of the conditional
        /// function, with an optional statement terminator after the closing brace (the old
        /// writer leaves a stray <c>;</c> after the final else block).
        /// </summary>
        private void EmitBranchBlock(IndentedStringBuilder isb, CodeExpression value, string? terminator)
        {
            isb.AppendLine("{");
            using (isb.Indent())
            {
                var branchScope = CreateNested([]);
                var atom = branchScope.Linearize(value, tailPosition: true);
                branchScope.WriteStatements(isb);
                if (atom is not null)
                    isb.AppendLine(TailStatement(atom));
            }
            isb.AppendLine($"}}{terminator}");
        }
    }
}
