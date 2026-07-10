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

                default:
                {
                    // Compound node: linearize the children, print this node shallowly over
                    // the child atoms, and hoist it into a named local (deduplicated).
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
                    isb.AppendLine($"return {result.Code};");
            }
            isb.AppendLine("}");
            _statements.Add(isb);

            return new Atom(functionName, functionLocal);
        }

        private Atom LinearizeConditional(IrConditional conditional)
        {
            var test = Linearize(conditional.Test)!;

            // When neither branch needs hoisted statements the conditional prints as an
            // inline ternary (the readable common case); otherwise it becomes an if/else
            // statement so each branch's work stays inside its branch, preserving
            // conditional evaluation exactly like the previous pipeline's CaseWhenThen
            // rewrite. A branch needs hoisting if and only if it is a compound node, so
            // this is a static test — no trial linearization (which would burn names).
            if (IsSimple(conditional.IfTrue) && IsSimple(conditional.IfFalse))
            {
                var trueAtom = Linearize(conditional.IfTrue)!;
                var falseAtom = Linearize(conditional.IfFalse)!;
                return Hoist($"{test.Code} ? {trueAtom.Code} : {falseAtom.Code}", conditional);
            }

            return EmitBranches(conditional.Type, [(test, conditional.IfTrue)], conditional.IfFalse);
        }

        /// <summary>True for nodes that print in place without hoisting any statements.</summary>
        private static bool IsSimple(IrExpression node) =>
            node is IrConstant or IrDefault or IrContextParameter or IrLocal;

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
                    isb.AppendLine(assignTo is null ? $"return {atom.Code};" : $"{assignTo} = {atom.Code};");
            }
            isb.AppendLine("}");
        }
    }
}
