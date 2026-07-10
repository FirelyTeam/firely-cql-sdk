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
        private readonly List<string> _statements = [];
        private readonly Dictionary<string, Atom> _dedup = [];

        private Scope(CSharpIrEmitter emitter, VariableNameGenerator names)
        {
            _emitter = emitter;
            _names = names;
        }

        public static Scope CreateRoot(CSharpIrEmitter emitter, IReadOnlyList<IrLocal> parameters)
        {
            var names = new VariableNameGenerator(
                reserved: parameters.Select(p => p.NameHint).OfType<string>(),
                postfix: "_");
            var scope = new Scope(emitter, names);
            scope.NameParameters(parameters);
            return scope;
        }

        private Scope CreateNested(IReadOnlyList<IrLocal> parameters)
        {
            var nested = new Scope(_emitter, _names.ForNewScope(parameters.Select(p => p.NameHint).OfType<string>()));
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
        /// not a C# keyword and not already used in this emission — duplicate hints, or a
        /// hint colliding with a generated name, would print duplicate or shadowing
        /// declarations (CS0100/CS0136).
        /// </summary>
        private string AllocateName(string? hint)
        {
            if (hint is not null
                && SyntaxFacts.GetKeywordKind(hint) == SyntaxKind.None
                && _emitter._usedNames.Add(hint))
                return hint;

            string name;
            do
            {
                name = _names.Next();
            } while (!_emitter._usedNames.Add(name));
            return name;
        }

        /// <summary>True when linearization hoisted at least one statement onto this scope —
        /// i.e. the linearized body cannot print as a single expression.</summary>
        public bool HasStatements => _statements.Count > 0;

        public void WriteStatements(IndentedStringBuilder isb)
        {
            foreach (var statement in _statements)
                isb.AppendLine(statement);
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
                    return new Atom(_emitter.PrintShallow(node, child => Linearize(child)!), node);

                default:
                {
                    // Spine node (calls, constructions, null-conditional access, type tests,
                    // logical operators): linearize the children, print this node shallowly
                    // over the child atoms, and hoist it into a named local (deduplicated).
                    var printed = _emitter.PrintShallow(node, child => Linearize(child)!);
                    return Hoist(printed, node);
                }
            }
        }

        private Atom Hoist(string code, IrExpression node)
        {
            var typeSyntax = _emitter._typeToCSharpConverter.ToCSharp(node.Type);
            var dedupKey = $"{code}::{typeSyntax}";
            if (_dedup.TryGetValue(dedupKey, out var existing))
                return existing;

            var local = new IrLocal(node.Type);
            var name = AllocateName(null);
            _emitter._assignedNames[local] = name;
            _statements.Add($"{typeSyntax} {name} = {code};");

            var atom = new Atom(name, local);
            _dedup[dedupKey] = atom;
            return atom;
        }

        private Atom HoistLocalFunction(IrLambda lambda)
        {
            var nested = CreateNested(lambda.Parameters);
            var result = nested.Linearize(lambda.Body, tailPosition: true);

            var functionLocal = new IrLocal(lambda.Type);
            var functionName = AllocateName(null);
            _emitter._assignedNames[functionLocal] = functionName;

            var parameterList = string.Join(", ",
                lambda.Parameters.Select(p => $"{_emitter._typeToCSharpConverter.ToCSharp(p.Type)} {_emitter._assignedNames[p]}"));

            var isb = new IndentedStringBuilder();
            isb.AppendLine($"{_emitter._typeToCSharpConverter.ToCSharp(lambda.Body.Type)} {functionName}({parameterList})");
            isb.AppendLine("{");
            using (isb.Indent())
            {
                nested.WriteStatements(isb);
                if (result is not null)
                    isb.AppendLine(TailStatement(result));
            }
            isb.AppendLine("}");
            _statements.Add(isb);

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

            // Flatten the else-if chain (old: ToCwt) and emit as statement form. The old
            // pipeline wrapped this in an invoked lambda; the native if/else chain is the
            // documented intentional divergence (docs/linq-expression-removal-plan.md).
            var cases = new List<(Atom Test, IrExpression Then)>();
            IrExpression current = conditional;
            while (current is IrConditional c)
            {
                cases.Add((Linearize(c.Test)!, c.IfTrue));
                current = c.IfFalse;
            }
            return EmitBranches(conditional.Type, cases, current);
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

        private Atom? LinearizeIfChain(IrIfChain chain, bool tailPosition)
        {
            var linearizedCases = chain.Cases
                .Select(c => (Test: Linearize(c.When)!, c.Then))
                .ToList();

            if (tailPosition)
            {
                // In tail position each branch returns directly — the style the previous
                // pipeline printed for case/when in a definition body.
                var isb = new IndentedStringBuilder();
                bool first = true;
                foreach (var (test, then) in linearizedCases)
                {
                    isb.AppendLine(first ? $"if ({test.Code})" : $"else if ({test.Code})");
                    EmitBranchBlock(isb, then, assignTo: null);
                    first = false;
                }
                isb.AppendLine("else");
                EmitBranchBlock(isb, chain.Else, assignTo: null);
                _statements.Add(((string)isb).TrimEnd());
                return null;
            }

            return EmitBranches(chain.Type, linearizedCases, chain.Else);
        }

        /// <summary>
        /// Emits a value-position multi-branch as a declared local assigned in an
        /// <c>if</c>/<c>else if</c>/<c>else</c> chain, and returns that local.
        /// </summary>
        private Atom EmitBranches(
            Type resultType,
            IReadOnlyList<(Atom Test, IrExpression Then)> cases,
            IrExpression @else)
        {
            var resultLocal = new IrLocal(resultType);
            var resultName = AllocateName(null);
            _emitter._assignedNames[resultLocal] = resultName;
            var typeSyntax = _emitter._typeToCSharpConverter.ToCSharp(resultType);

            var isb = new IndentedStringBuilder();
            isb.AppendLine($"{typeSyntax} {resultName};");
            bool first = true;
            foreach (var (test, then) in cases)
            {
                isb.AppendLine(first
                    ? $"if ({test.Code})"
                    : $"else if ({test.Code})");
                EmitBranchBlock(isb, then, assignTo: resultName);
                first = false;
            }
            isb.AppendLine("else");
            EmitBranchBlock(isb, @else, assignTo: resultName);
            _statements.Add(((string)isb).TrimEnd());

            return new Atom(resultName, resultLocal);
        }

        /// <summary>
        /// Emits <c>{ …hoisted…; assignTo = value; }</c> for a branch, or a
        /// <c>return value;</c> tail when <paramref name="assignTo"/> is null.
        /// </summary>
        private void EmitBranchBlock(IndentedStringBuilder isb, IrExpression value, string? assignTo)
        {
            isb.AppendLine("{");
            using (isb.Indent())
            {
                var branchScope = CreateNested([]);
                var atom = branchScope.Linearize(value, tailPosition: assignTo is null);
                branchScope.WriteStatements(isb);
                if (atom is not null)
                    isb.AppendLine(assignTo is null ? TailStatement(atom) : $"{assignTo} = {atom.Code};");
            }
            isb.AppendLine("}");
        }
    }
}
