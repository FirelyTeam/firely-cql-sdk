using System;
using System.Globalization;
using System.Reflection;

namespace Hl7.Cql.Runtime;

#pragma warning disable RS0016
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


public class CqlChoiceType : Type
{
    #region Virtual Override

    public override int GetHashCode() => Name.GetHashCode();

    public override string ToString() => Name;

    public override bool IsSZArray => false;

    public override bool IsByRefLike => false;

    

    #endregion

    #region Anstract Override

    public override object[] GetCustomAttributes(bool inherit)
    {
        return Array.Empty<Attribute>();
    }

    public override object[] GetCustomAttributes(Type attributeType, bool inherit)
    {
        return Array.Empty<Attribute>();
    }

    public override bool IsDefined(Type attributeType, bool inherit)
    {
        return false;
    }

    public override string Name => "CqlChoice";

    protected override TypeAttributes GetAttributeFlagsImpl() => TypeAttributes.Class | TypeAttributes.Public;

    protected override ConstructorInfo? GetConstructorImpl(
        BindingFlags bindingAttr,
        Binder? binder,
        CallingConventions callConvention,
        Type[] types,
        ParameterModifier[]? modifiers)
    {
        throw new NotImplementedException();
    }

    public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override Type? GetElementType()
    {
        throw new NotImplementedException();
    }

    public override EventInfo? GetEvent(string name, BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override EventInfo[] GetEvents(BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override FieldInfo? GetField(string name, BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override FieldInfo[] GetFields(BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override Type? GetInterface(string name, bool ignoreCase)
    {
        throw new NotImplementedException();
    }

    public override Type[] GetInterfaces() => EmptyTypes;

    public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    protected override MethodInfo? GetMethodImpl(
        string name,
        BindingFlags bindingAttr,
        Binder? binder,
        CallingConventions callConvention,
        Type[]? types,
        ParameterModifier[]? modifiers)
    {
        throw new NotImplementedException();
    }

    public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override Type? GetNestedType(string name, BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override Type[] GetNestedTypes(BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
    {
        throw new NotImplementedException();
    }

    protected override PropertyInfo? GetPropertyImpl(
        string name,
        BindingFlags bindingAttr,
        Binder? binder,
        Type? returnType,
        Type[]? types,
        ParameterModifier[]? modifiers)
    {
        throw new NotImplementedException();
    }

    protected override bool HasElementTypeImpl() => false;

    public override object? InvokeMember(
        string name,
        BindingFlags invokeAttr,
        Binder? binder,
        object? target,
        object?[]? args,
        ParameterModifier[]? modifiers,
        CultureInfo? culture,
        string[]? namedParameters)
    {
        throw new NotImplementedException();
    }

    protected override bool IsArrayImpl() => false;

    protected override bool IsByRefImpl() => false;

    protected override bool IsCOMObjectImpl()
    {
        throw new NotImplementedException();
    }

    protected override bool IsPointerImpl() => false;

    protected override bool IsPrimitiveImpl()
    {
        throw new NotImplementedException();
    }

    public override Assembly Assembly { get; }
    public override string? AssemblyQualifiedName { get; }
    public override Type? BaseType { get; }
    public override string? FullName { get; }
    public override Guid GUID { get; }
    public override Module Module { get; }
    public override string? Namespace { get; }
    public override Type UnderlyingSystemType { get; }

    #endregion
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore RS0016
