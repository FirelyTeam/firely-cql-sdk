#nullable enable
using System;
using System.Collections.Generic;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

namespace CoreTests.Abstractions;


[TestClass]
[TestCategory("UnitTest")]
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
    private static readonly Type MyClassGenericType = typeof(MyGenericClassDerived<int>);
    private static readonly Type MyClassGenericDefinitionType = typeof(MyGenericClassDerived<>);

    [TestMethod]
    public void IsObjectNullOrDefault_ShouldThrowNotSupportedException_WhenTypeArgumentNotObject()
    {
        // Don't use IsObjectNullOrDefault on specific types, it must be boxed to an object first

        Assert.ThrowsException<NotSupportedException>(() => 0.IsObjectNullOrDefault());

        Assert.ThrowsException<NotSupportedException>(() => default(int?).IsObjectNullOrDefault());
    }

    [TestMethod]
    public void IsObjectNullOrDefault_ShouldReturnCorrectResults_ForObject()
    {
        object? obj = null;
        Assert.IsTrue(obj.IsObjectNullOrDefault());

        obj = new();
        Assert.IsFalse(obj.IsObjectNullOrDefault());
    }

    [TestMethod]
    public void IsObjectNullOrDefault_ShouldReturnCorrectResults_ForEnum()
    {
        TestEnum? testEnum = null;
        Assert.IsTrue(testEnum.IsObjectNullOrDefault<object>());

        testEnum = TestEnum.Zero; // default
        Assert.IsTrue(testEnum.IsObjectNullOrDefault<object>());

        testEnum = TestEnum.One;
        Assert.IsFalse(testEnum.IsObjectNullOrDefault<object>());
    }

    [TestMethod]
    public void IsObjectNullOrDefault_ShouldReturnCorrectResults_ForInt32()
    {
        int? testInt32 = null;
        Assert.IsTrue(testInt32.IsObjectNullOrDefault<object>());

        testInt32 = 0;
        Assert.IsTrue(testInt32.IsObjectNullOrDefault<object>());

        testInt32 = 1;
        Assert.IsFalse(testInt32.IsObjectNullOrDefault<object>());
    }

    [TestMethod]
    public void IsObjectNullOrDefault_ShouldReturnCorrectResults_ForGuids()
    {
        Guid? testGuid = null;
        Assert.IsTrue(testGuid.IsObjectNullOrDefault<object>());

        testGuid = Guid.Empty;
        Assert.IsTrue(testGuid.IsObjectNullOrDefault<object>());

        testGuid = Guid.NewGuid();
        Assert.IsFalse(testGuid.IsObjectNullOrDefault<object>());
    }

    [TestMethod]
    public void IsObjectNullOrDefault_ShouldReturnCorrectResults_ForStrings()
    {
        string? testString = null;
        Assert.IsTrue(testString.IsObjectNullOrDefault<object>());

        testString = "";
        Assert.IsFalse(testString.IsObjectNullOrDefault<object>());
    }

    private enum TestEnum
    {
        Zero = 0,
        One = 1
    };

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
            actual: (false, StructType));

        Assert.AreEqual(
            expected: (ReferenceType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, ReferenceType));

        Assert.AreEqual(
            expected: (NullableEnumType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (true, EnumType));

        Assert.AreEqual(
            expected: (EnumType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, EnumType));

        Assert.AreEqual(
            expected: (GenericDefinitionType.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, GenericDefinitionType));

        Assert.AreEqual(
            expected: (GenericStructTypeDefinition.IsNullableValueType(underlyingType: out underlyingType), underlyingType),
            actual: (false, GenericStructTypeDefinition));

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

    [TestMethod]
    public void BaseTypeFixed_ShouldReturnCorrectResults()
    {
        // Shows the quirks when getting base type on a generic type definition. Here we expected to see true, but that turns out to be not the case
        Assert.IsFalse(typeof(MyGenericClassDerived<>).BaseType == typeof(MyGenericClassBase<>));

        // Why are they not the same? Because BaseType returns the constructed generic base type, while it should have remained a generic type definition.
        Assert.IsTrue(typeof(MyGenericClassDerived<>).IsGenericTypeDefinition);
        Assert.IsTrue(typeof(MyGenericClassDerived<>).BaseType!.IsConstructedGenericType);
        Assert.IsFalse(typeof(MyGenericClassDerived<>).BaseType!.IsGenericTypeDefinition);

        // So, when getting the base type on a type definition, we always have to request the generic type definition of that!
        Assert.IsTrue(typeof(MyGenericClassDerived<>).BaseType!.GetGenericTypeDefinition() == typeof(MyGenericClassBase<>));
        Assert.IsTrue(typeof(MyGenericClassDerived<>).BaseTypeFixed() == typeof(MyGenericClassBase<>));
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

        IList<int> NonGenericMethod(
            int a,
            int b,
            int c);

        IList<T> GenericMethod<T1, T2, T3, T>(
            T1 a,
            T2[] b,
            IEnumerable<T3>[] c)
            where T1 : struct, IComparable
            where T2 : notnull, new()
            where T3 : class, new();
    }

    public abstract class MyGenericClassBase<T> : IGenericInterface<T>
    {
        public void Method(T value)
        {
        }
    }

    public abstract class MyGenericClassDerived<T> : MyGenericClassBase<T>
    { }

    public class MyClass : MyGenericClassDerived<int>
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

        public readonly record struct GenericNested2<T1, T2> { }

        public delegate TOut NestedFunc<in TIn, out TOut>(TIn input)
            where TIn : notnull;
    };
}