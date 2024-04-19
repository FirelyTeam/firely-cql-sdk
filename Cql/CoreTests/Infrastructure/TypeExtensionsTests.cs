#nullable enable
using System;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        public enum MyEnum
        {
            Value1,
            Value2
        }

        public interface IGenericInterface<T>
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
}
