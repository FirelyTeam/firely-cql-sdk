#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

namespace CoreTests.Infrastructure
{
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
            .GetMethod("ReturnNullableStruct")!
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
                (NullableStructType.IsNullableValueType(out underlyingType), underlyingType),
                (true, StructType));

            Assert.AreEqual(
                (StructType.IsNullableValueType(out underlyingType), underlyingType),
                (false, null));

            Assert.AreEqual(
                (ReferenceType.IsNullableValueType(out underlyingType), underlyingType),
                (false, null));

            Assert.AreEqual(
                (NullableEnumType.IsNullableValueType(out underlyingType), underlyingType),
                (true, EnumType));

            Assert.AreEqual(
                (EnumType.IsNullableValueType(out underlyingType), underlyingType),
                (false, null));

            Assert.AreEqual(
                (GenericDefinitionType.IsNullableValueType(out underlyingType), underlyingType),
                (false, null));

            Assert.AreEqual(
                (GenericStructTypeDefinition.IsNullableValueType(out underlyingType), underlyingType),
                (false, null));

            Assert.AreEqual(
                (NullableGenericStructTypeDefinition.IsNullableValueType(out underlyingType), underlyingType),
                (true, GenericStructTypeDefinition));
        }


        [TestMethod]
        public void IsNullable_ShouldReturnCorrectResults()
        {
            // Arrange
            Type? underlyingType;

            // Act / Assert
            Assert.AreEqual(
                (NullableStructType.IsNullable(out underlyingType), underlyingType),
                (true, StructType));

            Assert.AreEqual(
                (StructType.IsNullable(out underlyingType), underlyingType),
                (false, StructType));

            Assert.AreEqual(
                (ReferenceType.IsNullable(out underlyingType), underlyingType),
                (true, ReferenceType));

            Assert.AreEqual(
                (NullableEnumType.IsNullable(out underlyingType), underlyingType),
                (true, EnumType));

            Assert.AreEqual(
                (EnumType.IsNullable(out underlyingType), underlyingType),
                (false, EnumType));

            Assert.AreEqual(
                (GenericDefinitionType.IsNullable(out underlyingType), underlyingType),
                (true, GenericDefinitionType));

            Assert.AreEqual(
                (GenericStructTypeDefinition.IsNullable(out underlyingType), underlyingType),
                (false, GenericStructTypeDefinition));

            Assert.AreEqual(
                (NullableGenericStructTypeDefinition.IsNullable(out underlyingType), underlyingType),
                (true, GenericStructTypeDefinition));
        }

        [TestMethod]
        public void MakeNullable_ShouldReturnCorrectResults()
        {
            // Act / Assert
            Assert.AreEqual(
                NullableStructType.MakeNullable(),
                NullableStructType);

            Assert.AreEqual(
                StructType.MakeNullable(),
                NullableStructType);

            Assert.AreEqual(
                ReferenceType.MakeNullable(),
                ReferenceType);

            Assert.AreEqual(
                NullableEnumType.MakeNullable(),
                NullableEnumType);

            Assert.AreEqual(
                EnumType.MakeNullable(),
                NullableEnumType);

            Assert.AreEqual(
                GenericDefinitionType.MakeNullable(),
                GenericDefinitionType);

            Assert.AreEqual(
                GenericStructTypeDefinition.MakeNullable(),
                NullableGenericStructTypeDefinition);

            Assert.AreEqual(
                NullableGenericStructTypeDefinition.MakeNullable(),
                NullableGenericStructTypeDefinition);
        }

        [TestMethod]
        public void IsEnum_ShouldReturnCorrectResults()
        {
            // Act / Assert
            Assert.IsFalse(NullableStructType.IsEnum());
            Assert.IsFalse(StructType.IsEnum());
            Assert.IsFalse(ReferenceType.IsEnum());
            Assert.IsTrue(EnumType.IsEnum());
            Assert.IsTrue(NullableEnumType.IsEnum());
            Assert.IsFalse(GenericDefinitionType.IsEnum());
            Assert.IsFalse(GenericStructTypeDefinition.IsEnum());
            Assert.IsFalse(NullableGenericStructTypeDefinition.IsEnum());
        }

        [TestMethod]
        public void IsImplementingGenericTypeDefinition_ShouldReturnCorrectResults()
        {
            // Arrange
            var nonGenericInterface = typeof(INonGenericInterface);
            var genericTypeDefinition = typeof(IGenericInterface<>);
            var genericType = typeof(IGenericInterface<int>);

            // Act / Assert
            Assert.IsTrue(MyClassType.IsImplementingGenericTypeDefinition(genericTypeDefinition));
            Assert.IsTrue(MyClassGenericType.IsImplementingGenericTypeDefinition(genericTypeDefinition));
            Assert.IsTrue(MyClassGenericDefinitionType.IsImplementingGenericTypeDefinition(genericTypeDefinition));

            Assert.IsInstanceOfType<ArgumentException>(Catch(() => MyClassType.IsImplementingGenericTypeDefinition(genericType)));
            Assert.IsInstanceOfType<ArgumentException>(Catch(() => MyClassType.IsImplementingGenericTypeDefinition(nonGenericInterface)));
            Assert.IsInstanceOfType<ArgumentException>(Catch(() => MyClassType.IsImplementingGenericTypeDefinition(ReferenceType)));
            Assert.IsInstanceOfType<ArgumentException>(Catch(() => MyClassType.IsImplementingGenericTypeDefinition(StructType)));

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
        public unsafe void ToCSharpString_ShouldReturnCorrectResults()
        {
            (Type type, string expected)[] testCases =
            [
                // Keywords
                (typeof(void), "void"),
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
                (typeof(EmptyStruct.Nested1.Nested2), "EmptyStruct+Nested1+Nested2"),
                // Nullable Value Type
                (typeof(int?), "int?"),
                // Generic
                (typeof(IDictionary<string?, int?>), "IDictionary<string,int?>"),
                (typeof(IDictionary<,>), "IDictionary<,>"),
            ];

            foreach (var (type, expected) in testCases)
            {
                var actual = type.ToCSharpString(
                    new(HideNamespaces: true, PreferKeywords: true));
                Assert.AreEqual(expected, actual);
            }

            Assert.AreEqual(
                "System.Collections.Generic.IDictionary<,>",
                typeof(IDictionary<,>).ToCSharpString(new()));

            Assert.AreEqual(
                "IDictionary<TKey,TValue>",
                typeof(IDictionary<,>).ToCSharpString(
                    new(
                        HideNamespaces: true,
                        PreferKeywords: true,
                        ShowGenericTypeParameterNames:true)));

            Assert.AreEqual(
                "System.Collections.Generic.IDictionary<TKey, TValue>",
                typeof(IDictionary<,>).ToCSharpString(
                    new(
                        HideNamespaces: false,
                        PreferKeywords: true,
                        ShowGenericTypeParameterNames:true,
                        TypeArgDelimited:", ")));
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
    public readonly record struct EmptyStruct
    {
        public readonly record struct Nested1
        {
            public readonly record struct Nested2 { }
        };
    }
}
