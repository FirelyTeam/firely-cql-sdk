#nullable enable
using System;
using System.Collections.Generic;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

namespace CoreTests.Infrastructure;


[TestClass]
public class TypeExtensionsTests
{
    private static readonly Type NullableStructType = typeof(int?);
    private static readonly Type StructType = typeof(int);
    private static readonly Type ReferenceType = typeof(string);
    private static readonly Type NullableEnumType = typeof(MyEnum?);
    private static readonly Type EnumType = typeof(MyEnum);

    // T
    private static readonly Type GenericDefinitionType = typeof(IGenericInterface<>).GetGenericArguments()[0];

    // T where T: struct
    private static readonly Type GenericStructTypeDefinition = typeof(IGenericInterfaceOnStruct<>).GetGenericArguments()[0];

    // T? where T: struct
    private static readonly Type NullableGenericStructTypeDefinition =
        typeof(IGenericInterfaceOnStruct<>)
            .GetMethod(name: "ReturnNullableStruct")!
            .ReturnType;

    private static readonly Type MyClassType = typeof(MyClass);
    private static readonly Type MyClassGenericType = typeof(MyGenericClass<int>);
    private static readonly Type MyClassGenericDefinitionType = typeof(MyGenericClass<>);

    [TestMethod]
    public void IsNullableValueType_ShouldReturnCorrectResults()
    {
        // Arrange
        Type? underlyingType;

        // Act / Assert
        Assert.AreEqual(
            expected: (NullableStructType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (true, StructType));

        Assert.AreEqual(
            expected: (StructType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, null));

        Assert.AreEqual(
            expected: (ReferenceType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, null));

        Assert.AreEqual(
            expected: (NullableEnumType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (true, EnumType));

        Assert.AreEqual(
            expected: (EnumType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, null));

        Assert.AreEqual(
            expected: (GenericDefinitionType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, null));

        Assert.AreEqual(
            expected: (GenericStructTypeDefinition.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, null));

        Assert.AreEqual(
            expected: (NullableGenericStructTypeDefinition.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (true, GenericStructTypeDefinition));
    }


    [TestMethod]
    public void IsNullable_ShouldReturnCorrectResults()
    {
        // Arrange
        Type? underlyingType;

        // Act / Assert
        Assert.AreEqual(
            expected: (NullableStructType.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (true, StructType));

        Assert.AreEqual(
            expected: (StructType.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (false, StructType));

        Assert.AreEqual(
            expected: (ReferenceType.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (true, ReferenceType));

        Assert.AreEqual(
            expected: (NullableEnumType.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (true, EnumType));

        Assert.AreEqual(
            expected: (EnumType.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (false, EnumType));

        Assert.AreEqual(
            expected: (GenericDefinitionType.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (true, GenericDefinitionType));

        Assert.AreEqual(
            expected: (GenericStructTypeDefinition.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (false, GenericStructTypeDefinition));

        Assert.AreEqual(
            expected: (NullableGenericStructTypeDefinition.IsNullable(nonNullableType: out underlyingType), underlyingType),
            actual: (true, GenericStructTypeDefinition));
    }

    [TestMethod]
    public void MakeNullable_ShouldReturnCorrectResults()
    {
        // Act / Assert
        Assert.AreEqual(
            expected: NullableStructType.MakeNullable(),
            actual: NullableStructType);

        Assert.AreEqual(
            expected: StructType.MakeNullable(),
            actual: NullableStructType);

        Assert.AreEqual(
            expected: ReferenceType.MakeNullable(),
            actual: ReferenceType);

        Assert.AreEqual(
            expected: NullableEnumType.MakeNullable(),
            actual: NullableEnumType);

        Assert.AreEqual(
            expected: EnumType.MakeNullable(),
            actual: NullableEnumType);

        Assert.AreEqual(
            expected: GenericDefinitionType.MakeNullable(),
            actual: GenericDefinitionType);

        Assert.AreEqual(
            expected: GenericStructTypeDefinition.MakeNullable(),
            actual: NullableGenericStructTypeDefinition);

        Assert.AreEqual(
            expected: NullableGenericStructTypeDefinition.MakeNullable(),
            actual: NullableGenericStructTypeDefinition);
    }

    [TestMethod]
    public void IsEnum_ShouldReturnCorrectResults()
    {
        // Act / Assert
        Assert.IsFalse(condition: NullableStructType.IsEnum());
        Assert.IsFalse(condition: StructType.IsEnum());
        Assert.IsFalse(condition: ReferenceType.IsEnum());
        Assert.IsTrue(condition: EnumType.IsEnum());
        Assert.IsTrue(condition: NullableEnumType.IsEnum());
        Assert.IsFalse(condition: GenericDefinitionType.IsEnum());
        Assert.IsFalse(condition: GenericStructTypeDefinition.IsEnum());
        Assert.IsFalse(condition: NullableGenericStructTypeDefinition.IsEnum());
    }

    [TestMethod]
    public void IsImplementingGenericTypeDefinition_ShouldReturnCorrectResults()
    {
        // Arrange
        var nonGenericInterface = typeof(INonGenericInterface);
        var genericTypeDefinition = typeof(IGenericInterface<>);
        var genericType = typeof(IGenericInterface<int>);

        // Act / Assert
        Assert.IsTrue(condition: MyClassType.IsImplementingGenericTypeDefinition(genericTypeDefinition: genericTypeDefinition));
        Assert.IsTrue(condition: MyClassGenericType.IsImplementingGenericTypeDefinition(genericTypeDefinition: genericTypeDefinition));
        Assert.IsTrue(condition: MyClassGenericDefinitionType.IsImplementingGenericTypeDefinition(genericTypeDefinition: genericTypeDefinition));

        Assert.IsInstanceOfType<ArgumentException>(value: Catch(action: () => MyClassType.IsImplementingGenericTypeDefinition(genericTypeDefinition: genericType)));
        Assert.IsInstanceOfType<ArgumentException>(value: Catch(action: () => MyClassType.IsImplementingGenericTypeDefinition(genericTypeDefinition: nonGenericInterface)));
        Assert.IsInstanceOfType<ArgumentException>(value: Catch(action: () => MyClassType.IsImplementingGenericTypeDefinition(genericTypeDefinition: ReferenceType)));
        Assert.IsInstanceOfType<ArgumentException>(value: Catch(action: () => MyClassType.IsImplementingGenericTypeDefinition(genericTypeDefinition: StructType)));

        static Exception? Catch(Action action)
        {
            try
            {
                action();
                return null!;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }

    [TestMethod]
    public void IsAssignableTo_ShouldReturnCorrectResults()
    {
        // Not part of TypeExtensions, but does demonstrate the flexibility of the IsAssignableTo method

        Assert.IsTrue(typeof(MyDerivedClass).IsAssignableTo(typeof(MyClass))); // Sub-Types e.g. MyDerivedClass : MyClass
        Assert.IsTrue(typeof(int).IsAssignableTo(typeof(int?))); // Lifting Value Types e.g. int to int?
    }

    public enum MyEnum
    {
        Value1,
        Value2
    }

    public interface IGenericInterface<in T>
    {
        void Method(T value);
    }

    public interface IGenericInterfaceOnStruct<T>
        where T : struct
    {
        void Method(T value);
        T? ReturnNullableStruct();
    }

    public interface INonGenericInterface
    {
        void Method();

        IList<int> Join(
            int a,
            int b,
            int c);
    }

    public abstract class MyGenericClass<T> : IGenericInterface<T>
    {
        public void Method(T value)
        {
        }
    }

    public class MyClass : MyGenericClass<int>
    {
    }

    public class MyDerivedClass : MyClass
    {
    }
}

public readonly record struct EmptyStruct
{
    public readonly record struct Nested1
    {
        public readonly record struct Nested2 { }

        public readonly record struct GenericNested2<T1,T2> { }
    };
}