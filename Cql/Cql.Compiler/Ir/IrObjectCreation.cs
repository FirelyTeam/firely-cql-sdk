/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A constructor call, <c>new T(args)</c>.
/// </summary>
internal sealed class IrNew : IrExpression
{
    public IrNew(ConstructorInfo constructor, params IrExpression[] arguments)
    {
        var parameters = constructor.GetParameters();
        if (parameters.Length != arguments.Length)
            throw new ArgumentException($"Constructor of {constructor.DeclaringType} takes {parameters.Length} argument(s), got {arguments.Length}.");
        for (int i = 0; i < arguments.Length; i++)
            IrTypeRules.ValidateAssignment(arguments[i], parameters[i].ParameterType, $"Argument {i} of new {constructor.DeclaringType?.Name}");

        Constructor = constructor;
        Arguments = arguments;
    }

    public ConstructorInfo Constructor { get; }

    public IReadOnlyList<IrExpression> Arguments { get; }

    public override Type Type => Constructor.DeclaringType!;
}

/// <summary>
/// A constructor call with an object initializer, <c>new T { A = x, B = y }</c>.
/// </summary>
internal sealed class IrMemberInit : IrExpression
{
    public IrMemberInit(IrNew @new, IReadOnlyList<(MemberInfo Member, IrExpression Value)> bindings)
    {
        foreach (var (member, value) in bindings)
        {
            var memberType = member switch
            {
                PropertyInfo p => p.PropertyType,
                FieldInfo f => f.FieldType,
                _ => throw new ArgumentException($"Initializer member {member.Name} must be a property or field.")
            };
            IrTypeRules.ValidateAssignment(value, memberType, $"Initializer of {@new.Type.Name}.{member.Name}");
        }

        New = @new;
        Bindings = bindings;
    }

    public IrNew New { get; }

    public IReadOnlyList<(MemberInfo Member, IrExpression Value)> Bindings { get; }

    public override Type Type => New.Type;
}

/// <summary>
/// A CQL tuple construction. The <see cref="Type"/> is the reflection-emitted tuple class
/// from <c>TupleBuilderCache</c> (which serves as the type identity for overload resolution),
/// but the emitter prints the C# value-tuple form
/// <c>(CqlTupleMetadata_…, element1, element2, …)</c>.
/// </summary>
internal sealed class IrTupleInit : IrExpression
{
    public IrTupleInit(Type tupleType, IReadOnlyList<(string Name, IrExpression Value)> elements)
    {
        foreach (var (name, value) in elements)
        {
            var property = tupleType.GetProperty(name)
                ?? throw new ArgumentException($"Tuple type {tupleType.Name} has no element '{name}'.");
            IrTypeRules.ValidateAssignment(value, property.PropertyType, $"Tuple element {name}");
        }

        Type = tupleType;
        Elements = elements;
    }

    public IReadOnlyList<(string Name, IrExpression Value)> Elements { get; }

    public override Type Type { get; }
}

/// <summary>
/// An array created from element expressions, <c>new T[] { a, b, … }</c>
/// (or a collection expression, matching whatever the current writer emits).
/// </summary>
internal sealed class IrNewArray : IrExpression
{
    public IrNewArray(Type elementType, params IrExpression[] items)
    {
        foreach (var item in items)
            IrTypeRules.ValidateAssignment(item, elementType, $"Array element of {elementType.Name}[]");

        ElementType = elementType;
        Items = items;
        Type = elementType.MakeArrayType();
    }

    public Type ElementType { get; }

    public IReadOnlyList<IrExpression> Items { get; }

    public override Type Type { get; }
}

/// <summary>
/// An array created with a length, <c>new T[n]</c>.
/// </summary>
internal sealed class IrNewArrayBounds : IrExpression
{
    public IrNewArrayBounds(Type elementType, IrExpression length)
    {
        if (length.Type != typeof(int))
            throw new ArgumentException($"Array length must be int, not {length.Type}.");
        ElementType = elementType;
        Length = length;
        Type = elementType.MakeArrayType();
    }

    public Type ElementType { get; }

    public IrExpression Length { get; }

    public override Type Type { get; }
}
