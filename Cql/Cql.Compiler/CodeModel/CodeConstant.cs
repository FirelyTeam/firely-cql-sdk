/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// A constant value, printed as a C# literal (or <c>null</c>). Replaces both
/// <c>ConstantExpression</c> and the old <c>NullExpression</c> helpers: a typed null is
/// simply <c>new CodeConstant(null, type)</c>.
/// </summary>
internal sealed class CodeConstant : CodeExpression
{
    public CodeConstant(object? value, Type type)
    {
        if (value is not null && !CodeTypeRules.CanBeAssigned(value.GetType(), type))
            throw new ArgumentException($"Constant value of type {value.GetType()} is not assignable to {type}.");
        if (value is null && !CodeTypeRules.IsNullAssignable(type))
            throw new ArgumentException($"A null constant cannot have non-nullable type {type}.");

        Value = value;
        Type = type;
    }

    /// <summary>The constant's value; null prints as the <c>null</c> literal.</summary>
    public object? Value { get; }

    public override Type Type { get; }
}

/// <summary>
/// The C# <c>default</c> value for a type, printed as <c>null</c> for any type that can hold
/// null (reference types and <see cref="Nullable{T}"/>) and <c>default(T)</c> for other
/// value types.
/// </summary>
internal sealed class CodeDefault(Type type) : CodeExpression
{
    public override Type Type { get; } = type;
}
