/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// A constructor call, <c>new T(args)</c>.
/// </summary>
internal sealed class CodeNew : CodeExpression
{
    public CodeNew(ConstructorInfo constructor, params CodeExpression[] arguments)
    {
        var parameters = constructor.GetParameters();
        if (parameters.Length != arguments.Length)
            throw new ArgumentException($"Constructor of {constructor.DeclaringType} takes {parameters.Length} argument(s), got {arguments.Length}.");
        for (int i = 0; i < arguments.Length; i++)
            CodeTypeRules.ValidateAssignment(arguments[i], parameters[i].ParameterType, $"Argument {i} of new {constructor.DeclaringType?.Name}");

        Constructor = constructor;
        Arguments = arguments;
    }

    public ConstructorInfo Constructor { get; }

    public IReadOnlyList<CodeExpression> Arguments { get; }

    public override Type Type => Constructor.DeclaringType!;
}

/// <summary>
/// A constructor call with an object initializer, <c>new T { A = x, B = y }</c>.
/// </summary>
internal sealed class CodeMemberInit : CodeExpression
{
    public CodeMemberInit(CodeNew @new, IReadOnlyList<(MemberInfo Member, CodeExpression Value)> bindings)
    {
        foreach (var (member, value) in bindings)
        {
            var memberType = member switch
            {
                PropertyInfo p => p.PropertyType,
                FieldInfo f => f.FieldType,
                _ => throw new ArgumentException($"Initializer member {member.Name} must be a property or field.")
            };
            CodeTypeRules.ValidateAssignment(value, memberType, $"Initializer of {@new.Type.Name}.{member.Name}");
        }

        New = @new;
        Bindings = bindings;
    }

    public CodeNew New { get; }

    public IReadOnlyList<(MemberInfo Member, CodeExpression Value)> Bindings { get; }

    public override Type Type => New.Type;
}

/// <summary>
/// A CQL tuple construction. The <see cref="Type"/> is the reflection-emitted tuple class
/// from <c>TupleBuilderCache</c> (which serves as the type identity for overload resolution),
/// but the emitter prints the C# value-tuple form
/// <c>(CqlTupleMetadata_…, element1, element2, …)</c>.
/// </summary>
internal sealed class CodeTupleInit : CodeExpression
{
    public CodeTupleInit(Type tupleType, IReadOnlyList<(string Name, CodeExpression Value)> elements)
    {
        foreach (var (name, value) in elements)
        {
            var property = tupleType.GetProperty(name)
                ?? throw new ArgumentException($"Tuple type {tupleType.Name} has no element '{name}'.");
            CodeTypeRules.ValidateAssignment(value, property.PropertyType, $"Tuple element {name}");
        }

        Type = tupleType;
        Elements = elements;
    }

    public IReadOnlyList<(string Name, CodeExpression Value)> Elements { get; }

    public override Type Type { get; }
}

/// <summary>
/// An array created from element expressions, <c>new T[] { a, b, … }</c>
/// (or a collection expression, matching whatever the current writer emits).
/// </summary>
internal sealed class CodeNewArray : CodeExpression
{
    public CodeNewArray(Type elementType, params CodeExpression[] items)
    {
        foreach (var item in items)
            CodeTypeRules.ValidateAssignment(item, elementType, $"Array element of {elementType.Name}[]");

        ElementType = elementType;
        Items = items;
        Type = elementType.MakeArrayType();
    }

    public Type ElementType { get; }

    public IReadOnlyList<CodeExpression> Items { get; }

    public override Type Type { get; }
}

/// <summary>
/// An array created with a length, <c>new T[n]</c>.
/// </summary>
internal sealed class CodeNewArrayBounds : CodeExpression
{
    public CodeNewArrayBounds(Type elementType, CodeExpression length)
    {
        if (length.Type != typeof(int))
            throw new ArgumentException($"Array length must be int, not {length.Type}.");
        ElementType = elementType;
        Length = length;
        Type = elementType.MakeArrayType();
    }

    public Type ElementType { get; }

    public CodeExpression Length { get; }

    public override Type Type { get; }
}
