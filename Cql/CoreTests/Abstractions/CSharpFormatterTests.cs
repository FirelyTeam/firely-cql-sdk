/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;

namespace CoreTests.Abstractions;

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
            // IsByRef
            (typeof(int).MakeByRefType(), "int"),
            // Arrays
            (typeof(int[]), "int[]"),
            (typeof(int[][]), "int[][]"),
            (typeof(int[,]), "int[, ]"),
            (typeof(int[][,]), "int[, ][]"),
            (typeof(int[,][]), "int[][, ]"),
            // Pointers
            (typeof(int*), "int*"),
            (typeof(int**), "int**"),
            // Mixed Pointers/Arrays
            (typeof(int*[]*), "int*[]*"),
            (typeof(int*[,]*), "int*[, ]*"),
            // Nested
            (typeof(EmptyStruct), "EmptyStruct"),
            (typeof(EmptyStruct.Nested1.Nested2), "EmptyStruct.Nested1.Nested2"),
            // Nullable Value Type
            (typeof(int?), "int?"),
            // Generic
            (typeof(IDictionary<string?, int?>), "IDictionary<string, int?>"),
            (typeof(IDictionary<,>), "IDictionary<TKey, TValue>"),
            // Generic+Nested
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>), "EmptyStruct.Nested1.GenericNested2<int, int>"),
            // Generic+Nested+Nullable
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>?), "EmptyStruct.Nested1.GenericNested2<int, int>?"),
            // Generic+Nested+Array
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>[]), "EmptyStruct.Nested1.GenericNested2<int, int>[]"),
            // Generic+Nested+Array+Nullable
            (typeof(EmptyStruct.Nested1.GenericNested2<int, int>?[]), "EmptyStruct.Nested1.GenericNested2<int, int>?[]"),
            // Generic+Nested+Delegate
            (typeof(EmptyStruct.Nested1.NestedFunc<int, int>?[]), "EmptyStruct.Nested1.NestedFunc<int, int>[]"),
            (typeof(EmptyStruct.Nested1.NestedFunc<,>), "EmptyStruct.Nested1.NestedFunc<in TIn, out TOut>")
        ];

        var typeToCSharpStringOptions = new TypeCSharpFormat(NoNamespaces: true, UseKeywords: true);
        foreach (var (type, expected) in testCases)
        {
            var actual = type.ToCSharpString(typeFormatterOptions: typeToCSharpStringOptions);
            Assert.AreEqual(expected: expected, actual: actual);
        }

        Assert.AreEqual(
            expected: "System.Collections.Generic.IDictionary<, >",
            actual: typeof(IDictionary<,>).ToCSharpString(typeFormatterOptions: new(NoGenericTypeParameterNames: true)));

        Assert.AreEqual(
            expected: "IDictionary<TKey, TValue>",
            actual: typeof(IDictionary<,>).ToCSharpString(
                typeFormatterOptions: new(
                    NoNamespaces: true,
                    UseKeywords: true)));

        Assert.AreEqual(
            expected: "System.Collections.Generic.IDictionary<TKey,TValue>",
            actual: typeof(IDictionary<,>).ToCSharpString(
                typeFormatterOptions: new(
                        NoNamespaces: false,
                        UseKeywords: true,
                        GenericArgumentTokens: CSharpTokens.GenericArguments with { Separator = "," })));

        Assert.AreEqual(
            expected: "CoreTests.Abstractions.EmptyStruct+Nested1+Nested2",
            actual: typeof(EmptyStruct.Nested1.Nested2).ToCSharpString(
                typeFormatterOptions: new(
                    NestedTypeSeparator: "+")));

        Assert.AreEqual(
            expected: "System.Nullable<int>",
            actual: typeof(int?).ToCSharpString(
                typeFormatterOptions: new(
                    NoNullableOperator: true,
                    UseKeywords: true)));

        Assert.AreEqual(
            expected: "System.Nullable<System.Int32>",
            actual: typeof(int?).ToCSharpString(
                typeFormatterOptions: new(
                    NoNullableOperator: true)));
    }

    [TestMethod]
    public void MethodToCSharpString_GenericGenericDefinition_ShouldReturnCorrectResults()
    {
        MethodInfo m = ReflectionUtility.GenericMethodDefinitionOf(fnToMethodCall: () => default(TypeExtensionsTests.INonGenericInterface)!.GenericMethod<decimal, int, TypeExtensionsTests.MyDerivedClass, char>(default!, default!, default!));

        Assert.AreEqual(
            expected: "IList<T> GenericMethod<T1, T2, T3, T>(T1 a, T2[] b, IEnumerable<T3>[] c)",
            actual: m.ToCSharpString());
    }

    [TestMethod]
    public void MethodToCSharpString_ParameterModifiers_ShouldReturnCorrectResults()
    {
        object o = null!;
        MethodInfo m = ReflectionUtility.MethodOf(fnToMethodCall: () => default(TypeExtensionsTests.IGenericInterface<object>)!.ParameterModifiers(o, in o, out o, ref o));

        Assert.AreEqual(
            expected: "System.Void ParameterModifiers(System.Object value, in System.Object valueIn, out System.Object valueOut, ref System.Object valueRef, params System.Object[] values)",
            actual: m.ToCSharpString());

        Assert.AreEqual(
            expected: "System.Void ParameterModifiers(System.Object value, System.Object valueIn, System.Object valueOut, System.Object valueRef, System.Object[] values)",
            actual: m.ToCSharpString(
                MethodCSharpFormat.Default with
                {
                    ParameterFormat = ParameterCSharpFormat.Default with
                    {
                        NoModifiers = true,
                    }
                }));

        Assert.AreEqual(
            expected: "void ParameterModifiers(object value, in object& valueIn, out object& valueOut, ref object& valueRef, params object[] values)",
            actual: m.ToCSharpString(
                MethodCSharpFormat.Default with
                {
                    ParameterFormat = ParameterCSharpFormat.Default with
                    {
                        TypeFormat = TypeCSharpFormat.Default with
                        {
                            UseRefOperator = true,
                            UseKeywords = true,
                        }
                    }
                }));

        Assert.AreEqual(
            expected: "void ParameterModifiers(object, in object&, out object&, ref object&, params object[])",
            actual: m.ToCSharpString(
                MethodCSharpFormat.Default with
                {
                    ParameterFormat = ParameterCSharpFormat.Default with
                    {
                        Format = p => $"{p.Modifier}{p.Type}",
                        TypeFormat = TypeCSharpFormat.Default with
                        {
                            UseRefOperator = true,
                            UseKeywords = true,
                        }
                    }
                }));
    }

    [TestMethod]
    public void MethodToCSharpString_NonGeneric_ShouldReturnCorrectResults()
    {
        MethodInfo m = ReflectionUtility.MethodOf(fnToMethodCall: () => default(TypeExtensionsTests.INonGenericInterface)!.NonGenericMethod(0, 0, 0));

        // NOTE: We do not show the declaring type name for methods
        TestTextWriter tw = new TestTextWriter(new StringWriter());
        MethodCSharpFormat.Default.WriteTo(m, tw);
        Assert.AreEqual(
            expected: "System.Collections.Generic.IList<System.Int32> NonGenericMethod(System.Int32 a, System.Int32 b, System.Int32 c)",
            actual: tw.ToString());

        Assert.AreEqual(
            """
            System.Collections.Generic.IList#<#System.Int32#># #NonGenericMethod#(##System.Int32# #a#, ##System.Int32# #b#, ##System.Int32# #c#)
            """,
            string.Join('#', tw.Tokens));

        // Delphi-ish style to demonstrate flexibility
        tw = new TestTextWriter(new StringWriter());
        var methodCSharpFormat = new MethodCSharpFormat(
            Format: method => $"function {method.Name}{method.GenericArguments}{method.Parameters}: {method.ReturnType};",
            ParameterFormat: new(
                Format: parameter => $"{parameter.Name}: {parameter.Type}",
                TypeFormat: new(
                    UseKeywords: true,
                    NoNamespaces: true)),
            ParameterTokens: CSharpTokens.Parameters with { Separator = "; " }
        );
        methodCSharpFormat.WriteTo(m, tw);
        Assert.AreEqual(
            expected: "function NonGenericMethod(a: int; b: int; c: int): IList<int>;",
            actual: tw.ToString());

        Assert.AreEqual(
            """
            function |NonGenericMethod|(|a|: |int|; |b|: |int|; |c|: |int|)|: |IList|<|int|>|;
            """,
            string.Join('|', tw.Tokens));
    }

    private class TestTextWriter(TextWriter Inner) : TextWriter
    {
        public List<string> Tokens { get; } = new();

        public override Encoding Encoding => Inner.Encoding;

        public override void Write(
            char[] buffer,
            int index,
            int count)
        {
            Inner.Write(buffer, index, count);
            Tokens.Add(new string(buffer, index, count));
        }

        public override void Write(char value)
        {
            Inner.Write(value);
            Tokens.Add(value.ToString());
        }

        public override string? ToString() => Inner.ToString();
    }
}