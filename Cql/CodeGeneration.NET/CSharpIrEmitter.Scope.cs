/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Ir;

namespace Hl7.Cql.CodeGeneration.NET;

internal partial class CSharpIrEmitter
{
    /// <summary>
    /// One statement scope (a method body or local-function body). Holds the statements
    /// hoisted so far, the dedup table for this scope, and the name reservations. The name
    /// sequence itself is shared across nested scopes so generated names never collide.
    /// </summary>
    private sealed class Scope
    {
        private readonly CSharpIrEmitter _emitter;
        private readonly VariableNameGenerator _names;

        // Hint names (original CQL alias names, e.g. a lambda parameter's NameHint) reserved
        // in THIS LINEAGE only: copied — not shared — into each nested scope, exactly like the
        // old VariableNameGenerator.Reserved list (ForNewScope conses onto a copy of the
        // parent's list). A hint used by an earlier SIBLING scope (e.g. one "where" lambda's
        // alias) is therefore free to be reused by a later, unrelated lambda with the same CQL
        // alias — reproducing CMS56's "LowerBodyFracture" reused verbatim as the parameter of
        // two separate (sibling) local functions in the same method. Only an ANCESTOR scope's
        // hint (still live/capturable from a nested closure) blocks reuse.
        private readonly HashSet<string> _reservedHints;

        // Statements are deferred renderers: plain declarations resolve immediately, but a
        // hoisted local function's INTERIOR renders only when the enclosing scope writes out.
        // This reproduces the old RenameVariablesVisitor naming order, which named all of a
        // block's own variables before descending into nested function bodies (so an inner
        // local is named h_ even though textually it precedes the d_..g_ that follow its
        // enclosing function definition).
        private readonly List<Func<string>> _statements = [];
        private readonly Dictionary<string, Atom> _dedup = [];

        private Scope(CSharpIrEmitter emitter, VariableNameGenerator names, HashSet<string> reservedHints)
        {
            _emitter = emitter;
            _names = names;
            _reservedHints = reservedHints;
        }

        public static Scope CreateRoot(CSharpIrEmitter emitter, IReadOnlyList<IrLocal> parameters)
        {
            var names = new VariableNameGenerator(
                reserved: parameters.Select(p => p.NameHint).OfType<string>(),
                postfix: "_");
            var scope = new Scope(emitter, names, []);
            scope.NameParameters(parameters);
            return scope;
        }

        private Scope CreateNested(IReadOnlyList<IrLocal> parameters)
        {
            var nested = new Scope(
                _emitter,
                _names.ForNewScope(parameters.Select(p => p.NameHint).OfType<string>()),
                [.. _reservedHints]); // copy, not share: see _reservedHints
            nested.NameParameters(parameters);
            return nested;
        }

        private void NameParameters(IReadOnlyList<IrLocal> parameters)
        {
            foreach (var p in parameters)
            {
                if (!_emitter._assignedNames.ContainsKey(p))
                    _emitter._assignedNames[p] = AllocateName(p.NameHint);
            }
        }

        /// <summary>
        /// Allocates a variable name, honoring <paramref name="hint"/> only when it is legal:
        /// not a C# keyword and not already reserved in this lineage (see
        /// <see cref="_reservedHints"/>) — a duplicate hint still live in an ancestor scope, or
        /// one colliding with a generated name from this lineage, would print duplicate or
        /// shadowing declarations (CS0100/CS0136).
        /// </summary>
        private string AllocateName(string? hint)
        {
            if (hint is not null
                && SyntaxFacts.GetKeywordKind(hint) == SyntaxKind.None
                && _reservedHints.Add(hint))
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
        public Atom? Linearize(IrExpression node, bool tailPosition = false)
        {
            switch (node)
            {
                // Simple expressions print in place, nothing to hoist.
                case IrConstant or IrDefault or IrContextParameter:
                    return new Atom(_emitter.PrintSimple(node), node);

                case IrLocal local:
                    return new Atom(_emitter._assignedNames.TryGetValue(local, out var name)
                        ? name
                        : throw new InvalidOperationException($"Local '{local}' is used before it is introduced by any lambda or hoisted assignment."),
                        local);

                case IrLambda lambda:
                    return HoistLocalFunction(lambda);

                case IrConditional conditional:
                    return LinearizeConditional(conditional);

                case IrIfChain chain:
                    return LinearizeIfChain(chain, tailPosition);

                // Pass-through composites: printed inline over their (spine-linearized)
                // children instead of being hoisted into a local. This mirrors the old
                // SimplifyExpressionsVisitor's dispatch exactly — Constant/Parameter/New/
                // Member/ElmAs/Default passed straight through, Convert/TypeAs/Throw unaries
                // and Equal/NotEqual/Coalesce binaries were not simplified — balancing
                // unnecessary hoisting against per-line readability.
                case IrProperty { NullConditional: false }
                    or IrCast
                    or IrNew
                    or IrThrow
                    or IrBinary { Op: IrBinaryOp.Equal or IrBinaryOp.NotEqual or IrBinaryOp.Coalesce }:
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
        private (string printed, string keyPrinted) PrintBoth(IrExpression node)
        {
            Dictionary<IrExpression, Atom> memo = new(ReferenceEqualityComparer.Instance);
            Atom Child(IrExpression child) =>
                memo.TryGetValue(child, out var atom) ? atom : memo[child] = Linearize(child)!;

            var printed = _emitter.PrintShallow(node, child => Child(child));
            var keyPrinted = _emitter.PrintShallow(node, child => Child(child) with { Code = Child(child).KeyCode });
            return (printed, keyPrinted);
        }

        private Atom Hoist(string code, string keyCode, IrExpression node)
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

            var local = new IrLocal(node.Type);
            var name = AllocateName(null);
            _emitter._assignedNames[local] = name;
            var statement = $"{typeSyntax} {name} = {code};";
            _statements.Add(() => statement);

            var atom = new Atom(name, name, local);
            _dedup[dedupKey] = atom;
            return atom;
        }

        private Atom HoistLocalFunction(IrLambda lambda)
        {
            // The function's own name is allocated now (it participates in this scope's
            // naming sequence), but its interior renders deferred — see _statements.
            var functionLocal = new IrLocal(lambda.Type);
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

        private Atom LinearizeConditional(IrConditional conditional)
        {
            // Mirrors the old SimplifyExpressionsVisitor.VisitConditional: a "simple"
            // conditional (IfFalse is not itself a conditional, and neither branch would
            // hoist anything) is returned UNVISITED — its entire subtree, the test included
            // (however complex), prints as one inline ternary. Everything else flattens the
            // else-chain into statement form.
            if (conditional.IfFalse is not IrConditional
                && IsInlineOnly(conditional.IfTrue)
                && IsInlineOnly(conditional.IfFalse))
            {
                return new Atom(_emitter.PrintInlineConditional(conditional, _emitter.PrintFullyInline), conditional);
            }

            // Flatten the else-if chain (old: ToCwt) and emit in the old pipeline's form: a
            // zero-parameter local function containing the if/else chain, invoked where the
            // value is needed. (A native if/else chain would be cleaner — post-parity
            // cleanup, see docs/linq-expression-removal-plan.md.)
            var cases = new List<(IrExpression When, IrExpression Then)>();
            IrExpression current = conditional;
            while (current is IrConditional c)
            {
                cases.Add((c.Test, c.IfTrue));
                current = c.IfFalse;
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
        private static bool IsInlineOnly(IrExpression node) =>
            node switch
            {
                IrConstant or IrDefault or IrContextParameter or IrLocal => true,
                IrProperty { NullConditional: false } p => p.Receiver is null || IsInlineOnly(p.Receiver),
                IrCast c => IsInlineOnly(c.Operand),
                IrNew n => n.Arguments.All(IsInlineOnly),
                IrThrow t => IsInlineOnly(t.Exception),
                IrBinary { Op: IrBinaryOp.Equal or IrBinaryOp.NotEqual or IrBinaryOp.Coalesce } b =>
                    IsInlineOnly(b.Left) && IsInlineOnly(b.Right),
                IrConditional nested =>
                    nested.IfFalse is not IrConditional
                    && IsInlineOnly(nested.IfTrue)
                    && IsInlineOnly(nested.IfFalse),
                _ => false,
            };

        private Atom? LinearizeIfChain(IrIfChain chain, bool tailPosition) =>
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
            IReadOnlyList<(IrExpression When, IrExpression Then)> cases,
            IrExpression @else)
        {
            // The function's own name participates in this scope's naming sequence now; the
            // interior renders deferred, like every hoisted function — see _statements.
            var functionLocal = new IrLocal(resultType);
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
        private string PrintWhen(IrExpression when)
        {
            if (CountSpineNodes(when) <= 1)
                return _emitter.PrintFullyInline(when);

            var atom = HoistLocalFunction(new IrLambda([], when));
            return $"{atom.Code}()";
        }

        /// <summary>The number of statements linearizing <paramref name="node"/> would hoist —
        /// the IR equivalent of the old trial visit's assignment count.</summary>
        private static int CountSpineNodes(IrExpression node) =>
            node switch
            {
                IrConstant or IrDefault or IrContextParameter or IrLocal => 0,
                IrProperty { NullConditional: false } p => p.Receiver is null ? 0 : CountSpineNodes(p.Receiver),
                IrCast c => CountSpineNodes(c.Operand),
                IrNew n => n.Arguments.Sum(CountSpineNodes),
                IrThrow t => CountSpineNodes(t.Exception),
                IrBinary { Op: IrBinaryOp.Equal or IrBinaryOp.NotEqual or IrBinaryOp.Coalesce } b =>
                    CountSpineNodes(b.Left) + CountSpineNodes(b.Right),
                IrConditional c when
                    c.IfFalse is not IrConditional && IsInlineOnly(c.IfTrue) && IsInlineOnly(c.IfFalse) => 0,
                IrInvoke i => 1 + (i.Receiver is null ? 0 : CountSpineNodes(i.Receiver)) + i.Arguments.Sum(CountSpineNodes),
                _ => 2, // any other spine node: treat as "complex enough" to defer
            };

        /// <summary>
        /// Emits <c>{ …hoisted…; return value; }</c> for a branch of the conditional
        /// function, with an optional statement terminator after the closing brace (the old
        /// writer leaves a stray <c>;</c> after the final else block).
        /// </summary>
        private void EmitBranchBlock(IndentedStringBuilder isb, IrExpression value, string? terminator)
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
