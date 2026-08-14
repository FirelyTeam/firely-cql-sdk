/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// A two-way conditional, printed as a ternary (<c>a ? b : c</c>) when simple. The emitter
/// may rewrite nested conditionals into an <see cref="CodeIfChain"/> for readability, exactly
/// as <c>SimplifyExpressionsVisitor</c> did.
/// </summary>
internal sealed class CodeConditional : CodeExpression
{
    public CodeConditional(
        CodeExpression test,
        CodeExpression ifTrue,
        CodeExpression ifFalse,
        Type type,
        string? originTag = null,
        string? originDetail = null)
    {
        // bool, not bool?: the builder coerces CQL's three-valued logic to bool before
        // testing, exactly as it had to for Expression.Condition.
        if (test.Type != typeof(bool))
            throw new ArgumentException($"Conditional test must be bool, not {test.Type}.");
        CodeTypeRules.ValidateAssignment(ifTrue, type, "Conditional true branch");
        CodeTypeRules.ValidateAssignment(ifFalse, type, "Conditional false branch");

        Test = test;
        IfTrue = ifTrue;
        IfFalse = ifFalse;
        Type = type;
        OriginTag = originTag;
        OriginDetail = originDetail;
    }

    public CodeExpression Test { get; }

    public CodeExpression IfTrue { get; }

    public CodeExpression IfFalse { get; }

    public override Type Type { get; }

    /// <summary>
    /// Short tag naming the CQL construct this conditional was lowered from, including its
    /// source locator when the ELM carries one — e.g. <c>"CQL 'and' (33:5-33:57)"</c>. Printed
    /// as a comment so a reader can trace the generated control flow back to the CQL. Null
    /// for conditionals that ARE the source construct (<c>if</c>/<c>case</c>), which need no
    /// tracing help.
    /// </summary>
    public string? OriginTag { get; }

    /// <summary>
    /// One-line explanation appended to <see cref="OriginTag"/> in the statement form
    /// (<c>// CQL 'and' (33:5-33:57): right operand skipped when left is false</c>). The inline
    /// ternary form prints only the tag, block-commented.
    /// </summary>
    public string? OriginDetail { get; }
}

/// <summary>
/// A multi-way conditional producing a value, printed as an <c>if / else if / else</c>
/// statement chain whose branches assign or return. Replaces the old
/// <c>CaseWhenThenExpression</c> custom node — natively statement-shaped, so no lambda-wrap
/// tricks are needed to host it in an expression tree.
/// </summary>
internal sealed class CodeIfChain : CodeExpression
{
    public CodeIfChain(IReadOnlyList<(CodeExpression When, CodeExpression Then)> cases, CodeExpression @else, Type type)
    {
        if (cases.Count == 0)
            throw new ArgumentException("An if-chain requires at least one case.");
        foreach (var (when, then) in cases)
        {
            if (when.Type != typeof(bool))
                throw new ArgumentException($"If-chain condition must be bool, not {when.Type}.");
            CodeTypeRules.ValidateAssignment(then, type, "If-chain case value");
        }
        CodeTypeRules.ValidateAssignment(@else, type, "If-chain else value");

        Cases = cases;
        Else = @else;
        Type = type;
    }

    public IReadOnlyList<(CodeExpression When, CodeExpression Then)> Cases { get; }

    public CodeExpression Else { get; }

    public override Type Type { get; }
}
