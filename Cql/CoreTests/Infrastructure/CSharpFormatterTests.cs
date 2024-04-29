#nullable enable
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

using System;
using System.Collections.Generic;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.Infrastructure;

[TestClass]
[TestCategory("UnitTest")]
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
            // Generic+Nested
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>), "EmptyStruct.Nested1.GenericNested2<int,int>"),
            // Generic+Nested+Nullable
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>?), "EmptyStruct.Nested1.GenericNested2<int,int>?"),
            // Generic+Nested+Array
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>[]), "EmptyStruct.Nested1.GenericNested2<int,int>[]"),
            // Generic+Nested+Array+Nullable
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>?[]), "EmptyStruct.Nested1.GenericNested2<int,int>?[]"),
        ];

        var typeToCSharpStringOptions = new TypeFormatterOptions(HideNamespaces: true, PreferKeywords: true);
        foreach (var (type, expected) in testCases)
        {
            var actual = type.WriteCSharp(typeFormatterOptions: typeToCSharpStringOptions).ToString()!;
            Assert.AreEqual(expected: expected, actual: actual);
        }

        Assert.AreEqual(
            expected: "System.Collections.Generic.IDictionary<,>",
            actual: typeof(IDictionary<,>).WriteCSharp(typeFormatterOptions: new()).ToString()!);

        Assert.AreEqual(
            expected: "IDictionary<TKey,TValue>",
            actual: typeof(IDictionary<,>).WriteCSharp(
                typeFormatterOptions: new(
                    HideNamespaces: true,
                    PreferKeywords: true,
                    ShowGenericTypeParameterNames: true)).ToString()!);

        Assert.AreEqual(
            expected: "System.Collections.Generic.IDictionary<TKey, TValue>",
            actual: typeof(IDictionary<,>).WriteCSharp(
                typeFormatterOptions: new(
                    HideNamespaces: false,
                    PreferKeywords: true,
                    ShowGenericTypeParameterNames: true,
                    TypeDelimiter: ", ")).ToString()!);

        Assert.AreEqual(
            expected: "CoreTests.Infrastructure.EmptyStruct+Nested1+Nested2",
            actual: typeof(EmptyStruct.Nested1.Nested2).WriteCSharp(
                typeFormatterOptions: new(
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
                methodFormatterOptions: new(
                    methodFormat: method => $"function {method.Name}({method.Parameters}): {method.ReturnType};",
                    parameterFormatting: new (
                        parameterFormat: parameter => $"{parameter.Name}: {parameter.Type}",
                        typeFormatting: new(
                            PreferKeywords:true,
                            HideNamespaces:true)),
                    parameterSeparator: "; "
                    )).ToString()!);
    }
}