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
/// A let-binding: evaluates <see cref="Value"/> exactly once into <see cref="Local"/>, then
/// evaluates <see cref="Body"/>, which may reference the local any number of times — including
/// from positions the emitter would otherwise print inline (a ternary's test and branches),
/// where referencing the value expression directly would duplicate its evaluation.
///
/// <para>Statement-shaped like <see cref="CodeIfChain"/>: the emitter hoists the value into a
/// local ahead of the body's statements, so a let never prints as an inline expression.</para>
/// </summary>
internal sealed class CodeLet : CodeExpression
{
    public CodeLet(CodeLocal local, CodeExpression value, CodeExpression body)
    {
        CodeTypeRules.ValidateAssignment(value, local.Type, "Let-bound value");

        Local = local;
        Value = value;
        Body = body;
    }

    public CodeLocal Local { get; }

    public CodeExpression Value { get; }

    public CodeExpression Body { get; }

    public override Type Type => Body.Type;
}
