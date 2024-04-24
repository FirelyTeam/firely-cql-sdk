#nullable enable
using System;
using System.Collections.Generic;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;
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
}


[TestClass]
public class CSharpFormatterTests
{

    [TestMethod]
    public void TypeToCSharpString_ShouldReturnCorrectResults()
    {
        (Type type, string expected)[] testCases =
        [
            // Keywords
            (typeof(void), "void"),
            (typeof(bool), "bool"),
            (typeof(byte), "byte"),
            (typeof(sbyte), "sbyte"),
            (typeof(char), "char"),
            (typeof(short), "short"),
            (typeof(ushort), "ushort"),
            (typeof(int), "int"),
            (typeof(uint), "uint"),
            (typeof(nint), "nint"),
            (typeof(nuint), "nuint"),
            (typeof(long), "long"),
            (typeof(ulong), "ulong"),
            (typeof(float), "float"),
            (typeof(double), "double"),
            (typeof(decimal), "decimal"),
            (typeof(string), "string"),
            (typeof(object), "object"),
            // Arrays
            (typeof(int[]), "int[]"),
            (typeof(int[][]), "int[][]"),
            (typeof(int[,]), "int[,]"),
            (typeof(int[][,]), "int[,][]"),
            (typeof(int[,][]), "int[][,]"),
            // Pointers
            (typeof(int*), "int*"),
            (typeof(int**), "int**"),
            // Mixed Pointers/Arrays
            (typeof(int*[]*), "int*[]*"),
            (typeof(int*[,]*), "int*[,]*"),
            // Nested
            (typeof(EmptyStruct), "EmptyStruct"),
            (typeof(EmptyStruct.Nested1.Nested2), "EmptyStruct.Nested1.Nested2"),
            // Nullable Value Type
            (typeof(int?), "int?"),
            // Generic
            (typeof(IDictionary<string?, int?>), "IDictionary<string,int?>"),
            (typeof(IDictionary<,>), "IDictionary<,>"),
        ];

        var typeToCSharpStringOptions = new CSharpWriteTypeOptions(HideNamespaces: true, PreferKeywords: true);
        foreach (var (type, expected) in testCases)
        {
            var actual = type.WriteCSharp(typeOptions: typeToCSharpStringOptions).ToString()!;
            Assert.AreEqual(expected: expected, actual: actual);
        }

        Assert.AreEqual(
            expected: "System.Collections.Generic.IDictionary<,>",
            actual: typeof(IDictionary<,>).WriteCSharp(typeOptions: new()).ToString()!);

        Assert.AreEqual(
            expected: "IDictionary<TKey,TValue>",
            actual: typeof(IDictionary<,>).WriteCSharp(
                typeOptions: new(
                    HideNamespaces: true,
                    PreferKeywords: true,
                    ShowGenericTypeParameterNames: true)).ToString()!);

        Assert.AreEqual(
            expected: "System.Collections.Generic.IDictionary<TKey, TValue>",
            actual: typeof(IDictionary<,>).WriteCSharp(
                typeOptions: new(
                    HideNamespaces: false,
                    PreferKeywords: true,
                    ShowGenericTypeParameterNames: true,
                    TypeDelimiter: ", ")).ToString()!);

        Assert.AreEqual(
            expected: "CoreTests.Infrastructure.EmptyStruct+Nested1+Nested2",
            actual: typeof(EmptyStruct.Nested1.Nested2).WriteCSharp(
                typeOptions: new(
                    NestedTypeDelimiter:"+")).ToString()!);
    }

    [TestMethod]
    public void MethodToCSharpString_ShouldReturnCorrectResults()
    {
        MethodInfo m = ReflectionUtility.MethodOf(fnToMethodCall: () => default(TypeExtensionsTests.INonGenericInterface)!.Join(0, 0, 0));

        // NOTE: We do not show the declaring type name for methods
        Assert.AreEqual(
            expected: "System.Collections.Generic.IList<System.Int32> Join(System.Int32 a, System.Int32 b, System.Int32 c)",
            actual: m.WriteCSharp().ToString()!);

        // Delphi-ish style to demonstrate flexibility
        Assert.AreEqual(
            expected: "function Join(a: int; b: int; c: int): IList<int>;",
            actual: m.WriteCSharp(
                methodOptions: new(
                    methodFormat: t => $"function {t.name}({t.parameters}): {t.returnType};",
                    parameterDelimiter: "; ",
                    parameterOptions: new(
                        parameterFormat: t => $"{t.name}: {t.type}",
                        typeOptions: new(
                            PreferKeywords:true,
                            HideNamespaces:true)))).ToString()!);
    }
}

public readonly record struct EmptyStruct
{
    public readonly record struct Nested1
    {
        public readonly record struct Nested2 { }
    };
}