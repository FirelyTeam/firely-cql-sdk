/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A property or field access, optionally null-conditional (<c>x?.Member</c>). Replaces both
/// <c>MemberExpression</c> and the old <c>NullConditionalMemberExpression</c> custom node.
/// </summary>
internal sealed class IrProperty : IrExpression
{
    public IrProperty(IrExpression? receiver, MemberInfo member, bool nullConditional = false)
    {
        var memberType = member switch
        {
            PropertyInfo p => p.PropertyType,
            FieldInfo f => f.FieldType,
            _ => throw new ArgumentException($"Member {member.Name} must be a property or field, not a {member.MemberType}.")
        };

        bool isStatic = member switch
        {
            PropertyInfo p => (p.GetMethod ?? p.SetMethod)!.IsStatic,
            FieldInfo f => f.IsStatic,
            _ => false
        };
        if (isStatic != receiver is null)
            throw new ArgumentException(isStatic
                ? $"Static member {member.Name} cannot have a receiver."
                : $"Instance member {member.Name} requires a receiver.");
        if (receiver is not null && !IrTypeRules.CanBeAssigned(receiver.Type, member.DeclaringType!))
            throw new ArgumentException($"Receiver of type {receiver.Type} does not declare member {member.Name} (expected {member.DeclaringType}).");
        if (nullConditional && receiver is null)
            throw new ArgumentException($"A null-conditional access to {member.Name} requires a receiver.");

        Receiver = receiver;
        Member = member;
        NullConditional = nullConditional;

        // x?.Member yields null when x is null, so the result type must admit null.
        Type = nullConditional && memberType.IsValueType && Nullable.GetUnderlyingType(memberType) is null
            ? typeof(Nullable<>).MakeGenericType(memberType)
            : memberType;
    }

    /// <summary>The instance whose member is accessed, or null for static members.</summary>
    public IrExpression? Receiver { get; }

    public MemberInfo Member { get; }

    /// <summary>True to print <c>?.</c> instead of <c>.</c>.</summary>
    public bool NullConditional { get; }

    public override Type Type { get; }
}
