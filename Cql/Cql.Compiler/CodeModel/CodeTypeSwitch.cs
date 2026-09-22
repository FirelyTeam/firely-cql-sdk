/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// A dispatch on the runtime type of a value: the value is evaluated once, the first arm whose
/// type the value has produces the result with the value narrowed to that type, and
/// <see cref="Otherwise"/> produces it when no arm matches (including when the value is null).
///
/// <para>This states what a type test followed by a cast of the same value only implies: that the
/// arms test one value, and that each arm's value is known to have its type, so it is never null.
/// How it prints (a switch expression, a conditional, or an <c>if</c> chain with declaration
/// patterns) is the emitter's choice.</para>
/// </summary>
internal sealed class CodeTypeSwitch : CodeExpression
{
    public CodeTypeSwitch(CodeExpression operand, IReadOnlyList<CodeTypeSwitchArm> arms, CodeExpression otherwise, Type type)
    {
        if (arms.Count == 0)
            throw new ArgumentException("A type switch requires at least one arm.");
        foreach (var arm in arms)
            CodeTypeRules.ValidateAssignment(arm.Body, type, "Type switch arm value");
        CodeTypeRules.ValidateAssignment(otherwise, type, "Type switch otherwise value");

        Operand = operand;
        Arms = arms;
        Otherwise = otherwise;
        Type = type;
    }

    /// <summary>The value dispatched on.</summary>
    public CodeExpression Operand { get; }

    /// <summary>The arms, tested in order.</summary>
    public IReadOnlyList<CodeTypeSwitchArm> Arms { get; }

    /// <summary>The value when no arm matches.</summary>
    public CodeExpression Otherwise { get; }

    public override Type Type { get; }
}

/// <summary>
/// One arm of a <see cref="CodeTypeSwitch"/>: when the operand has the type of
/// <see cref="Narrowed"/>, the switch produces <see cref="Body"/>, in which
/// <see cref="Narrowed"/> is the operand as that type.
/// </summary>
internal sealed class CodeTypeSwitchArm
{
    public CodeTypeSwitchArm(CodeLocal narrowed, CodeExpression body)
    {
        if (!narrowed.IsNotNull)
            throw new ArgumentException("The variable a type switch arm binds never holds null and must be declared so.");
        if (Nullable.GetUnderlyingType(narrowed.Type) is not null)
            throw new ArgumentException($"A type switch arm cannot test for the nullable type {narrowed.Type}; test for its underlying type.");

        Narrowed = narrowed;
        Body = body;
    }

    /// <summary>The operand, narrowed to the type this arm tests for; its type is that type.</summary>
    public CodeLocal Narrowed { get; }

    /// <summary>The arm's value; occurrences of <see cref="Narrowed"/> in it are that same instance.</summary>
    public CodeExpression Body { get; }
}
