/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A two-way conditional, printed as a ternary (<c>a ? b : c</c>) when simple. The emitter
/// may rewrite nested conditionals into an <see cref="IrIfChain"/> for readability, exactly
/// as <c>SimplifyExpressionsVisitor</c> did.
/// </summary>
internal sealed class IrConditional : IrExpression
{
    public IrConditional(IrExpression test, IrExpression ifTrue, IrExpression ifFalse, Type type)
    {
        if (test.Type != typeof(bool) && test.Type != typeof(bool?))
            throw new ArgumentException($"Conditional test must be bool or bool?, not {test.Type}.");
        IrTypeRules.ValidateAssignment(ifTrue, type, "Conditional true branch");
        IrTypeRules.ValidateAssignment(ifFalse, type, "Conditional false branch");

        Test = test;
        IfTrue = ifTrue;
        IfFalse = ifFalse;
        Type = type;
    }

    public IrExpression Test { get; }

    public IrExpression IfTrue { get; }

    public IrExpression IfFalse { get; }

    public override Type Type { get; }
}

/// <summary>
/// A multi-way conditional producing a value, printed as an <c>if / else if / else</c>
/// statement chain whose branches assign or return. Replaces the old
/// <c>CaseWhenThenExpression</c> custom node — natively statement-shaped, so no lambda-wrap
/// tricks are needed to host it in an expression tree.
/// </summary>
internal sealed class IrIfChain : IrExpression
{
    public IrIfChain(IReadOnlyList<(IrExpression When, IrExpression Then)> cases, IrExpression @else, Type type)
    {
        if (cases.Count == 0)
            throw new ArgumentException("An if-chain requires at least one case.");
        foreach (var (when, then) in cases)
        {
            if (when.Type != typeof(bool) && when.Type != typeof(bool?))
                throw new ArgumentException($"If-chain condition must be bool or bool?, not {when.Type}.");
            IrTypeRules.ValidateAssignment(then, type, "If-chain case value");
        }
        IrTypeRules.ValidateAssignment(@else, type, "If-chain else value");

        Cases = cases;
        Else = @else;
        Type = type;
    }

    public IReadOnlyList<(IrExpression When, IrExpression Then)> Cases { get; }

    public IrExpression Else { get; }

    public override Type Type { get; }
}
