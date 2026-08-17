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

        // Dedup entries of ENCLOSING scopes whose locals are already declared textually above
        // this scope's block, so this scope may reuse them instead of recomputing the same
        // value. Lookup only — a new hoist always lands in _dedup, never here. Null for the
        // root scope and for a hoisted local function's body (see HoistLocalFunction).
        private readonly VisibleDedup? _inheritedDedup;

        /// <summary>
        /// Lookup-only view of what an enclosing scope had hoisted at the moment a deferred render
        /// was queued. Each level freezes a copy of its OWN entries and chains by reference to the
        /// already-frozen level outside it, so visibility reaches all the way out without copying
        /// the whole table at every nesting level (a scope nest of depth d over n entries would
        /// otherwise cost O(d·n) per emission path).
        /// <para>The per-level copy is what makes it a snapshot rather than a live view, and that
        /// is load-bearing: entries its scope hoists AFTER the render is queued are declared
        /// textually BELOW it, so reusing one from inside a branch would be a
        /// use-before-declaration.</para>
        /// </summary>
        private sealed class VisibleDedup(Dictionary<string, Atom> frozen, VisibleDedup? outer)
        {
            public bool TryGetValue(string key, out Atom atom) =>
                frozen.TryGetValue(key, out atom!) || (outer is not null && outer.TryGetValue(key, out atom));
        }

        private Scope(
            CSharpEmitter emitter,
            VariableNameGenerator names,
            VisibleDedup? inheritedDedup = null)
        {
            _emitter = emitter;
            _names = names;
            _inheritedDedup = inheritedDedup;
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

        private Scope CreateNested(
            IReadOnlyList<CodeLocal> parameters,
            VisibleDedup? inheritedDedup = null)
        {
            var nested = new Scope(
                _emitter,
                // The GENERATED letter sequence must never collide with a hint name visible in
                // this lineage: the old VariableNameGenerator.Reserved list, threaded the same
                // way (ForNewScope conses the new scope's names onto a copy of the parent's).
                _names.ForNewScope(parameters.Select(p => p.NameHint).OfType<string>()),
                inheritedDedup);
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

                case CodeLet let:
                    return LinearizeLet(let, tailPosition);

                // A short-circuit operator's right operand cannot be hoisted into a statement — that
                // would evaluate it unconditionally and destroy the skip — so it has to print
                // inline. When it is too big for that, or has no inline form at all (a let, an
                // if-chain), it moves into a zero-argument LOCAL FUNCTION instead and the operand
                // becomes a call to it: `left && f_()`. Statements live in the function body, one
                // per line, and the call still only happens when the operator does not skip.
                //
                // A local function that is only ever CALLED (never converted to a delegate) does
                // not allocate: Roslyn gives it a struct closure passed by ref. So this keeps the
                // allocation-free property that motivated the whole lowering, unlike the
                // Lazy<bool?> overloads it replaced.
                //
                // The condition is stated in full rather than relying on case order — these two
                // cases must not depend on their position in the switch.
                case CodeBinary shortCircuit when CodeBinary.ShortCircuits(shortCircuit.Op)
                                                 && !PrintsInlineAsShortCircuitOperand(shortCircuit.Right):
                    return LinearizeShortCircuitCallingRightOperand(shortCircuit);

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
                    or CodeUnary:
                case CodeBinary shortCircuit when CodeBinary.ShortCircuits(shortCircuit.Op)
                                                  && PrintsInlineAsShortCircuitOperand(shortCircuit.Right):
                case CodeBinary passThrough when CodeBinary.PrintsInlineOverChildren(passThrough.Op):
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
            // Origin tags are excluded from the KEY rendering, for the same reason the inline
            // conditional excludes them: a tag embeds a CQL source span, so two structurally
            // identical subexpressions written at different spans would never deduplicate.
            var keyPrinted = _emitter.PrintShallow(node, child => Child(child) with { Code = Child(child).KeyCode }, includeOriginTags: false);
            return (printed, keyPrinted);
        }

        private Atom Hoist(string code, string keyCode, CodeExpression node)
        {
            var typeSyntax = _emitter._typeToCSharpConverter.ToCSharp(node.Type);
            var dedupKey = $"{keyCode}::{typeSyntax}";
            // A duplicate reuses the original's local — name, key identity and all. (The old
            // pipeline allocated a fresh name for the duplicate before the deduper removed its
            // statement, which burned a letter out of the naming sequence and, because that
            // burned name keyed the duplicate for its parents, kept identical parent
            // expressions from ever deduplicating with each other.)
            if (_dedup.TryGetValue(dedupKey, out var existing))
                return existing;

            // An enclosing scope may already hold this value in a local that is declared above
            // this block and still in scope here — reuse it rather than recomputing. Without
            // this, every branch and test block of a lowered conditional recomputed whatever
            // its enclosing scope had already hoisted (a retrieve, a ToInterval chain), which
            // is how the short-circuit lowering came to ADD hundreds of operator calls to the
            // corpora while skipping right operands.
            if (_inheritedDedup is not null && _inheritedDedup.TryGetValue(dedupKey, out var inherited))
                return inherited;

            var local = new CodeLocal(node.Type);
            var name = AllocateName(null);
            _emitter._assignedNames[local] = name;
            var statement = $"{typeSyntax} {name} = {code};";
            _statements.Add(() => statement);

            var atom = new Atom(name, name, local);
            _dedup[dedupKey] = atom;
            return atom;
        }

        /// <param name="declaredReturnType">Overrides the return type the function is DECLARED with,
        /// where the body's own type converts to it implicitly. Used for a short-circuit operand,
        /// whose function returns <see cref="CqlBoolean"/> over a <c>bool?</c> body: the implicit
        /// conversion happens at the <c>return</c>, so neither the body nor the call site needs a
        /// cast.</param>
        private Atom HoistLocalFunction(CodeLambda lambda, Type? declaredReturnType = null)
        {
            // The function's own name is allocated now (it participates in this scope's
            // naming sequence), but its interior renders deferred — see _statements.
            var functionLocal = new CodeLocal(lambda.Type);
            var functionName = AllocateName(null);
            _emitter._assignedNames[functionLocal] = functionName;

            _statements.Add(() =>
            {
                // Deliberately NO inherited dedup: a local function may be declared before the
                // enclosing local it would reuse (use-before-declaration), and reaching out to
                // an enclosing local turns it into captured closure state — an allocation the
                // guard form exists to avoid.
                var nested = CreateNested(lambda.Parameters);
                var result = nested.Linearize(BodyWithoutRootBoolConversion(lambda), tailPosition: true);

                var parameterList = string.Join(", ",
                    lambda.Parameters.Select(p => $"{_emitter._typeToCSharpConverter.ToCSharp(p.Type)} {_emitter._assignedNames[p]}"));
                // Deliberately lambda.Body.Type, NOT the unwrapped body's: the declared type must
                // stay bool? so only the printed body loses the conversion.
                var returnType = _emitter._typeToCSharpConverter.ToCSharp(declaredReturnType ?? lambda.Body.Type);

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

        private Atom? LinearizeConditional(CodeConditional conditional, bool tailPosition)
        {
            // A "simple" conditional (IfFalse is not itself a conditional, and neither branch
            // would hoist anything) prints as one inline ternary — its entire subtree, the
            // test included (however complex). Everything else flattens the else-chain into
            // native if/else statement form. A statement-shaped node (a let, an if-chain)
            // anywhere in the TEST vetoes the inline form: the branches are checked by
            // IsInlineOnly, but the test prints fully inline "however complex", and those
            // nodes have no inline print (found via the HEDIS 2025 corpus: an and/or guard's
            // CodeLet inside the test of an if-expression with simple branches).
            if (conditional.IfFalse is not CodeConditional
                && IsInlineOnly(conditional.IfTrue)
                && IsInlineOnly(conditional.IfFalse)
                && !ContainsStatementShape(conditional.Test))
            {
                // The origin tag is an annotation, not part of the value, so it is rendered into
                // Code but kept OUT of KeyCode: it embeds the CQL source span, and two
                // structurally identical guards written at different spans would otherwise key
                // differently and never deduplicate — a comment silently disabling
                // common-subexpression elimination.
                return new Atom(
                    _emitter.PrintInlineConditional(conditional, node => _emitter.PrintFullyInline(node)),
                    _emitter.PrintInlineConditional(
                        conditional,
                        node => _emitter.PrintFullyInline(node, includeOriginTags: false),
                        includeOriginTag: false),
                    conditional);
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
            return LinearizeConditionalStatements(conditional.Type, cases, current, tailPosition, OriginComment(conditional));
        }

        /// <summary>The <c>// tag: detail</c> comment for a lowered conditional's statement
        /// form, or null when the conditional carries no origin (if/case constructs).</summary>
        private static string? OriginComment(CodeConditional conditional) =>
            conditional.OriginTag is null
                ? null
                : conditional.OriginDetail is null
                    ? $"// {conditional.OriginTag}"
                    : $"// {conditional.OriginTag}: {conditional.OriginDetail}";

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
                CodeBinary b when CodeBinary.PrintsInlineOverChildren(b.Op) =>
                    IsInlineOnly(b.Left) && IsInlineOnly(b.Right),
                CodeUnary u => IsInlineOnly(u.Operand),
                CodeConditional nested =>
                    nested.IfFalse is not CodeConditional
                    && IsInlineOnly(nested.IfTrue)
                    && IsInlineOnly(nested.IfFalse)
                    // The old trial visit left a nested simple conditional's test unexamined;
                    // that stays, EXCEPT for statement-shaped nodes (lets, if-chains), which
                    // the old pipeline could never put inside a test and which cannot print
                    // inline.
                    && !ContainsStatementShape(nested.Test),
                _ => false,
            };

        /// <summary>
        /// True when the subtree contains a node with no inline print form — a let-binding or
        /// an if-chain — anywhere <see cref="CSharpEmitter.PrintFullyInline"/> would reach it,
        /// including conditional TESTS (which the inline-only classification deliberately
        /// leaves unexamined otherwise) and inline lambda bodies.
        /// </summary>
        private static bool ContainsStatementShape(CodeExpression node) =>
            node switch
            {
                CodeLet or CodeIfChain => true,
                CodeConstant or CodeDefault or CodeContextParameter or CodeLocal => false,
                CodeProperty p => p.Receiver is { } r && ContainsStatementShape(r),
                CodeCast c => ContainsStatementShape(c.Operand),
                CodeTypeIs t => ContainsStatementShape(t.Operand),
                CodeUnary u => ContainsStatementShape(u.Operand),
                CodeBinary b => ContainsStatementShape(b.Left) || ContainsStatementShape(b.Right),
                CodeThrow t => ContainsStatementShape(t.Exception),
                CodeNew n => n.Arguments.Any(ContainsStatementShape),
                CodeNewArray a => a.Items.Any(ContainsStatementShape),
                CodeNewArrayBounds b => ContainsStatementShape(b.Length),
                CodeMemberInit m => ContainsStatementShape(m.New) || m.Bindings.Any(binding => ContainsStatementShape(binding.Value)),
                CodeTupleInit t => t.Elements.Any(element => ContainsStatementShape(element.Value)),
                CodeInvoke i => (i.Receiver is { } receiver && ContainsStatementShape(receiver)) || i.Arguments.Any(ContainsStatementShape),
                CodeDefinitionCall d => d.Arguments.Any(ContainsStatementShape),
                CodeLambda l => ContainsStatementShape(l.Body),
                CodeConditional c => ContainsStatementShape(c.Test) || ContainsStatementShape(c.IfTrue) || ContainsStatementShape(c.IfFalse),
                _ => true, // unknown node type: assume the worst so it hoists instead of throwing mid-print
            };

        private Atom? LinearizeIfChain(CodeIfChain chain, bool tailPosition) =>
            LinearizeConditionalStatements(chain.Type, chain.Cases, chain.Else, tailPosition);

        /// <summary>
        /// Whether a short-circuit operator's right operand is small enough, and simple enough, to
        /// print inline. It cannot be hoisted, so inline is the only alternative to a local
        /// function — and an operand that hoists several spine nodes would print as one enormous
        /// line (measured at 2,139 characters before this budget existed).
        /// <para>The budget is the same "one hoist-worth of complexity" rule
        /// <see cref="ConditionPrintsInline"/> applies to chain conditions, so the two places that
        /// choose between inline and statement form agree.</para>
        /// </summary>
        private static bool PrintsInlineAsShortCircuitOperand(CodeExpression right) =>
            !ContainsStatementShape(right) && CountSpineNodes(right) <= 1;

        /// <summary>
        /// A short-circuit operator whose right operand is too big to inline: the operand moves into
        /// a zero-argument local function and the operand position becomes a CALL to it, so
        /// evaluation still happens only when the operator does not skip.
        /// </summary>
        private Atom LinearizeShortCircuitCallingRightOperand(CodeBinary node)
        {
            // The left operand is always evaluated, so hoisting it is free and desirable.
            var left = Linearize(node.Left)!;

            // The function is DECLARED to return CqlBoolean while its body stays the plain bool?
            // expression, so the conversion happens implicitly at the `return` and nothing needs a
            // cast: neither the body (`return t_;`) nor the call site (`f_()`). Returning bool?
            // instead would produce `return (bool?)((CqlBoolean)t_);` in the body AND
            // `(CqlBoolean)f_()` at the call site — three conversions to move one value through
            // unchanged.
            //
            // CqlBoolean, NOT CqlBoolean?: && is not lifted over nullable types, so a nullable
            // return would leave the call site unable to short-circuit at all — which is the whole
            // reason this type exists. CqlBoolean already carries its own null.
            var body = UnwrapCqlBooleanConversion(node.Right);
            var function = HoistLocalFunction(new CodeLambda([], body), declaredReturnType: typeof(CqlBoolean));
            var right = $"{function.Code}()";

            return new Atom(
                _emitter.FormatShortCircuit(node.Op, left.Code, right, node.OriginTag),
                _emitter.FormatShortCircuit(node.Op, left.KeyCode, right, originTag: null),
                node);
        }

        /// <summary>
        /// Binds the let's value to its local exactly once, then linearizes the body. The
        /// binding must survive any number of references from the body — including from
        /// positions that print fully inline, which would otherwise re-print (re-evaluate)
        /// the value expression — so any value whose linearized atom is not already a plain
        /// variable or constant reference is forced into a hoisted local, even shapes
        /// (a coalesce, a property access, a simple ternary) that Linearize normally
        /// passes through inline.
        /// </summary>
        private Atom? LinearizeLet(CodeLet let, bool tailPosition)
        {
            var valueAtom = Linearize(let.Value)!;
            // A CONSTANT is deliberately not exempt from the hoist, unlike a local or the
            // context parameter: Linearize folds a constant-test conditional to its surviving
            // branch, so a value like `if true then A else B` arrives here as a constant, and
            // binding the local straight to that literal makes the guard print as a
            // constant-vs-constant test (`true is false`) — dead code Roslyn flags as an
            // always-false pattern. Hoisting keeps the guard reading a variable.
            if (valueAtom.Node is not (CodeLocal or CodeContextParameter))
                valueAtom = Hoist(valueAtom.Code, valueAtom.KeyCode, let.Value);

            // Locals resolve by reference identity through the emitter-wide name map, so
            // nested branch scopes see the binding. CAUTION: the binding is a single mutable
            // slot. Re-linearizing the SAME CodeLet instance is safe only when every read of
            // the binding happens after the rebind that produced it — true for eager bodies,
            // for sequential renders that re-run LinearizeLet themselves, and for a repeat
            // within one scope (dedup hands back the same atom, so the rebind is a no-op) —
            // but NOT for a deferred chain render queued before another scope rebound the
            // local, which would then print a name declared inside that other scope (CS0103).
            //
            // Sharing needs no code change to become reachable, so do not rely on "the builder
            // makes a fresh CodeLet per ELM node" as protection: CodeBuilderContext.Query.cs
            // translates a query let's expression ONCE and splices that instance at every
            // QueryLetRef, so `let f: (X and Y) ... where f ... return f` shares this guard's
            // CodeLet across both references. What keeps it latent is only that no corpus
            // writes a query let over an and/or — CQL input, not SDK code, is all it takes.
            // Design options (occurrence-scoped bindings, cloning on splice) are in #1566.
            _emitter._assignedNames[let.Local] = valueAtom.Code;
            return Linearize(let.Body, tailPosition);
        }

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
            bool tailPosition,
            string? originComment = null)
        {
            // Freeze what this scope has hoisted SO FAR, and chain to what it inherited itself, so
            // a branch sees every enclosing local rather than only its immediate parent's: those
            // are all declared textually above this chain. See VisibleDedup for why the snapshot
            // (rather than a live view) is the load-bearing part.
            var visibleDedup = new VisibleDedup(new Dictionary<string, Atom>(_dedup), _inheritedDedup);

            if (tailPosition)
            {
                if (originComment is not null)
                    _statements.Add(() => originComment);
                _statements.Add(() => RenderChain(resultName: null, cases, @else, visibleDedup));
                return null;
            }

            var resultLocal = new CodeLocal(resultType);
            var resultName = AllocateName(null);
            _emitter._assignedNames[resultLocal] = resultName;

            // Declared without an initializer; the compiler's definite-assignment analysis
            // verifies every branch of the chain below assigns it (or throws).
            _statements.Add(() => $"{_emitter._typeToCSharpConverter.ToCSharp(resultType)} {resultName};");
            if (originComment is not null)
                _statements.Add(() => originComment);
            _statements.Add(() => RenderChain(resultName, cases, @else, visibleDedup));
            return new Atom(resultName, resultLocal);
        }

        /// <summary>Renders deferred (like every hoisted interior — see <c>_statements</c>),
        /// so nested scopes allocate their names in block order.</summary>
        private string RenderChain(
            string? resultName,
            IReadOnlyList<(CodeExpression When, CodeExpression Then)> cases,
            CodeExpression @else,
            VisibleDedup visibleDedup)
        {
            var isb = new IndentedStringBuilder();
            EmitChainLevel(isb, resultName, cases, 0, @else, visibleDedup);
            return isb.ToString().TrimEnd('\r', '\n');
        }

        private void EmitChainLevel(
            IndentedStringBuilder isb,
            string? resultName,
            IReadOnlyList<(CodeExpression When, CodeExpression Then)> cases,
            int start,
            CodeExpression @else,
            VisibleDedup visibleDedup)
        {
            // Both forms print an if/else chain. The assign form needs one — its branches
            // assign and fall through, so the else is what guarantees exactly one of them
            // runs — and the tail form (resultName null, every branch returning or throwing)
            // keeps it too, so a single shape covers both.
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
                    var testScope = CreateNested([], visibleDedup);
                    var atom = testScope.Linearize(when)!;
                    testScope.WriteStatements(isb);
                    test = atom.Code;

                    // Those statements print at THIS level, above every branch of the chain, so
                    // the branches may reuse them: a condition that hoists
                    // `DateTimeComponentFrom(x, "month")` and a branch that needs the same value
                    // would otherwise compute it twice.
                    visibleDedup = new VisibleDedup(new Dictionary<string, Atom>(testScope._dedup), visibleDedup);
                }
                else
                {
                    // A later condition's statements may only run after all earlier
                    // conditions tested false: continue the chain nested in the else.
                    isb.AppendLine("else");
                    isb.AppendLine("{");
                    using (isb.Indent())
                        EmitChainLevel(isb, resultName, cases, i, @else, visibleDedup);
                    isb.AppendLine("}");
                    return;
                }

                isb.AppendLine(first ? $"if ({test})" : $"else if ({test})");
                EmitBranchBlock(isb, resultName, then, visibleDedup);
                first = false;
            }

            isb.AppendLine("else");
            EmitBranchBlock(isb, resultName, @else, visibleDedup);
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
                CodeBinary b when CodeBinary.PrintsInlineOverChildren(b.Op) =>
                    CountSpineNodes(b.Left) + CountSpineNodes(b.Right),
                CodeUnary u => CountSpineNodes(u.Operand),
                // A conditional containing a statement-shaped node anywhere (test included)
                // cannot print as isSimpleWhen's raw inline ternary — force statement form.
                CodeConditional c when ContainsStatementShape(c) => 2,
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
        private void EmitBranchBlock(
            IndentedStringBuilder isb,
            string? resultName,
            CodeExpression value,
            VisibleDedup visibleDedup)
        {
            isb.AppendLine("{");
            using (isb.Indent())
            {
                var branchScope = CreateNested([], visibleDedup);
                var atom = branchScope.Linearize(value, tailPosition: resultName is null);
                branchScope.WriteStatements(isb);
                if (atom is not null)
                    isb.AppendLine(resultName is null || atom.Node is CodeThrow
                        ? TailStatement(atom)
                        : $"{resultName} = {atom.Code};");
            }
            isb.AppendLine("}");
        }
    }
}
