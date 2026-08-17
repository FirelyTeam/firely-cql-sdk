/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// Type rules shared by the IR node constructors. These mirror what the C# compiler will
/// accept in the generated code, so that violations are caught at tree-construction time
/// (with ELM context available) instead of at C# compilation time.
/// </summary>
internal static class CodeTypeRules
{
    /// <summary>
    /// Determines whether an expression of type <paramref name="from"/> can be used where a
    /// value of type <paramref name="to"/> is expected without an explicit cast, i.e. via an
    /// identity, reference, boxing or nullable-lifting conversion. A null constant is
    /// assignable to any type that can hold null; callers check that case separately via
    /// <see cref="IsNullAssignable"/>.
    /// </summary>
    public static bool CanBeAssigned(Type from, Type to)
    {
        if (to.IsAssignableFrom(from))
            return true;

        // T -> T? (implicit nullable lifting)
        if (Nullable.GetUnderlyingType(to) is { } underlyingTo && underlyingTo.IsAssignableFrom(from))
            return true;

        return false;
    }

    /// <summary>
    /// Determines whether a null value can be assigned to <paramref name="type"/>
    /// (any reference type or <see cref="Nullable{T}"/>).
    /// </summary>
    public static bool IsNullAssignable(Type type) =>
        !type.IsValueType || Nullable.GetUnderlyingType(type) is not null;

    /// <summary>
    /// Determines whether C# defines a conversion (identity, reference, unboxing, numeric/enum,
    /// or user-defined) between the two types, ignoring <see cref="Nullable{T}"/> wrappers.
    /// This governs whether an explicit cast is legal in the generated C#.
    /// </summary>
    public static bool HasCSharpConversion(Type from, Type to)
    {
        // User-defined conversions are matched on the operator's DECLARED signature, so they must
        // be checked before any nullability unwrapping: a type declaring
        // `implicit operator bool?` converts to bool? exactly, and the unwrapped comparison
        // (… -> bool) would miss it.
        if (HasConversionOperator(from, from, to) || HasConversionOperator(to, from, to))
            return true;

        from = Nullable.GetUnderlyingType(from) ?? from;
        to = Nullable.GetUnderlyingType(to) ?? to;

        if (from == to || to.IsAssignableFrom(from) || from.IsAssignableFrom(to))
            return true;

        // Explicit reference conversions between an interface and any non-sealed type (or
        // another interface) are legal in C# even without a subtype relation.
        if (from.IsInterface && !to.IsSealed || to.IsInterface && !from.IsSealed)
            return true;

        static bool IsNumericOrChar(Type t) => Type.GetTypeCode(t) is >= TypeCode.Char and <= TypeCode.Decimal;
        if ((IsNumericOrChar(from) || from.IsEnum) && (IsNumericOrChar(to) || to.IsEnum))
            return true;

        return HasConversionOperator(from, from, to) || HasConversionOperator(to, from, to);
    }

    private static bool HasConversionOperator(Type declaring, Type from, Type to) =>
        declaring.GetMethods()
                 .Any(m => m is { IsStatic: true, Name: "op_Implicit" or "op_Explicit" }
                        && m.ReturnType == to
                        && m.GetParameters() is [{ ParameterType: var p }] && p == from);

    /// <summary>
    /// Validates that <paramref name="argument"/> can be passed to a parameter of type
    /// <paramref name="parameterType"/>, throwing an <see cref="ArgumentException"/> with the
    /// given <paramref name="what"/> in the message otherwise.
    /// </summary>
    public static void ValidateAssignment(CodeExpression argument, Type parameterType, string what)
    {
        if (argument is CodeConstant { Value: null })
        {
            if (!IsNullAssignable(parameterType))
                throw new ArgumentException($"{what}: null is not assignable to non-nullable type {parameterType}.");
            return;
        }

        if (!CanBeAssigned(argument.Type, parameterType))
            throw new ArgumentException($"{what}: an expression of type {argument.Type} is not assignable to {parameterType}.");
    }
}
