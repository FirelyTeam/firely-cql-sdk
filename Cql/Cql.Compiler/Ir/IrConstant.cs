/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A constant value, printed as a C# literal (or <c>null</c>). Replaces both
/// <c>ConstantExpression</c> and the old <c>NullExpression</c> helpers: a typed null is
/// simply <c>new IrConstant(null, type)</c>.
/// </summary>
internal sealed class IrConstant : IrExpression
{
    public IrConstant(object? value, Type type)
    {
        if (value is not null && !IrTypeRules.CanBeAssigned(value.GetType(), type))
            throw new ArgumentException($"Constant value of type {value.GetType()} is not assignable to {type}.");
        if (value is null && !IrTypeRules.IsNullAssignable(type))
            throw new ArgumentException($"A null constant cannot have non-nullable type {type}.");

        Value = value;
        Type = type;
    }

    /// <summary>The constant's value; null prints as the <c>null</c> literal.</summary>
    public object? Value { get; }

    public override Type Type { get; }
}

/// <summary>
/// The C# <c>default</c> value for a type, printed as <c>null</c> for nullable types and
/// <c>default(T)</c> otherwise.
/// </summary>
internal sealed class IrDefault(Type type) : IrExpression
{
    public override Type Type { get; } = type;
}

/// <summary>
/// Throws an exception. Used only for the generator's error-recovery stubs; carries a result
/// type so it can stand in for an expression of any type.
/// </summary>
internal sealed class IrThrow : IrExpression
{
    public IrThrow(IrExpression exception, Type resultType)
    {
        if (!typeof(Exception).IsAssignableFrom(exception.Type))
            throw new ArgumentException($"Throw operand must be an Exception, not {exception.Type}.");
        Exception = exception;
        Type = resultType;
    }

    public IrExpression Exception { get; }

    public override Type Type { get; }
}
