/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler.Ir;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// A plain-old class used as the target of <see cref="IrNew"/>/<see cref="IrMemberInit"/> tests.
/// Kept at namespace scope (not nested in the test class) so <see cref="TypeToCSharpConverter"/>
/// prints its name without a declaring-type prefix.
/// </summary>
internal sealed class CSharpIrEmitterTestWidget
{
    public CSharpIrEmitterTestWidget() { }

    public int Count { get; set; }
}

/// <summary>
/// A CQL-tuple-shaped type (derives from <see cref="TupleBaseType"/>, the marker
/// <c>IsTupleBaseType()</c> checks for) used by the <see cref="IrTupleInit"/> and tuple
/// <see cref="IrTypeIs"/> tests. Real tuple types are normally reflection-emitted by
/// <c>TupleBuilderCache</c>, but a plain subclass with public properties satisfies the same
/// contract (<c>IsAssignableTo(TupleBaseType)</c> plus <c>GetProperties()</c>) without the
/// ceremony of dynamic IL generation.
/// </summary>
internal sealed class CSharpIrEmitterTestTuple : TupleBaseType
{
    public int? A { get; set; }

    public string B { get; set; }
}

/// <summary>Helper invoked by the local-function test so an <see cref="IrLambda"/> has a real
/// <c>Func&lt;,&gt;</c>-typed parameter to be hoisted into.</summary>
internal static class CSharpIrEmitterTestHelpers
{
    public static int? ApplyFunc(Func<int, int?> f, int x) => f(x);
}

/// <summary>
/// Unit tests for <see cref="CSharpIrEmitter"/>: builds small typed-IR trees directly via the
/// <c>Hl7.Cql.Compiler.Ir.*</c> node constructors and asserts on the exact C# text the emitter
/// produces. The output shape (variable naming, hoisting, dedup, statement-vs-expression
/// printing) is the contract this component exists to fulfill, so most assertions compare the
/// full emitted block text rather than just checking substrings.
/// </summary>
[TestClass]
public class CSharpIrEmitterTests
{
    /// <summary>Test stand-in for the scaffolding writer's naming conventions.</summary>
    private sealed class TestNamingConventions : ICSharpNamingConventions
    {
        public string TupleMetadataFieldName(Type tupleType) => "CqlTupleMetadata_TEST";

        public string DefinitionTarget(IrDefinitionCall dc) => dc.IsLocalLibrary
            ? $"this.{dc.DefinitionName}"
            : $"{dc.LibraryName}_{dc.LibraryVersion.Replace('.', '_')}.Instance.{dc.DefinitionName}";
    }

    private static CSharpIrEmitter CreateEmitter() => new(
        new TypeToCSharpConverter(),
        new TestNamingConventions());

    /// <summary>Emits a definition body and normalizes line endings so assertions are stable
    /// across checkouts with different <c>core.autocrlf</c> settings.</summary>
    private static string EmitBody(IrLambda lambda) =>
        CreateEmitter().EmitBodyBlock(lambda).Replace("\r\n", "\n");

    private static readonly MethodInfo MathAbsInt =
        typeof(Math).GetMethod(nameof(Math.Abs), [typeof(int)])!;

    [TestMethod]
    public void TrivialConstantBody_EmitsReturnStatement()
    {
        var lambda = new IrLambda([], new IrConstant(3, typeof(int?)));

        Assert.AreEqual("{\n    return 3;\n}", EmitBody(lambda));
    }

    [TestMethod]
    public void Constants_PrintExpectedLiterals()
    {
        static string EmitConstant(object? value, Type type) =>
            EmitBody(new IrLambda([], new IrConstant(value, type)));

        Assert.AreEqual("{\n    return 3;\n}", EmitConstant(3, typeof(int)));
        Assert.AreEqual("{\n    return 3L;\n}", EmitConstant(3L, typeof(long)));
        Assert.AreEqual("{\n    return 3.5m;\n}", EmitConstant(3.5m, typeof(decimal)));
        Assert.AreEqual("{\n    return true;\n}", EmitConstant(true, typeof(bool)));
        Assert.AreEqual("{\n    return \"abc\";\n}", EmitConstant("abc", typeof(string)));
        Assert.AreEqual("{\n    return null;\n}", EmitConstant(null, typeof(object)));
        Assert.AreEqual("{\n    return default;\n}", EmitConstant(null, typeof(string)));
        Assert.AreEqual("{\n    return typeof(string);\n}", EmitConstant(typeof(string), typeof(Type)));
    }

    [TestMethod]
    public void Hoisting_NestedCallsProduceSequentialLocals()
    {
        // Math.Abs(Math.Abs(-5)): the inner call must be hoisted (and named) before the outer
        // one so the outer statement can reference it by name.
        var inner = new IrInvoke(null, MathAbsInt, new IrConstant(-5, typeof(int)));
        var outer = new IrInvoke(null, MathAbsInt, inner);
        var lambda = new IrLambda([], outer);

        Assert.AreEqual(
            "{\n    int a_ = Math.Abs(-5);\n    int b_ = Math.Abs(a_);\n    return b_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void Dedup_IdenticalSubexpressionHoistedOnce()
    {
        // Two separately-constructed, but structurally identical, IrInvoke nodes: the emitter
        // dedups on printed code + type, so only one "Math.Abs(-5)" local is introduced even
        // though it is referenced twice. The deduped duplicate still burns a name from the
        // sequence (the old LocalVariableDeduper's letter-gap behavior — see Hoist's
        // "burnedName" in CSharpIrEmitter.Scope.cs), so the array itself is named "c_", not
        // "b_"; arrays also print as multi-line collection expressions (see
        // ObjectCreation_NewArrayAndNewArrayBounds).
        var call1 = new IrInvoke(null, MathAbsInt, new IrConstant(-5, typeof(int)));
        var call2 = new IrInvoke(null, MathAbsInt, new IrConstant(-5, typeof(int)));
        var array = new IrNewArray(typeof(int), call1, call2);
        var lambda = new IrLambda([], array);

        Assert.AreEqual(
            "{\n    int a_ = Math.Abs(-5);\n    int[] c_ = [\n        a_,\n        a_,\n    ];\n    return c_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void LocalFunction_LambdaArgumentPrintsAsLocalFunction()
    {
        var applyFunc = typeof(CSharpIrEmitterTestHelpers).GetMethod(nameof(CSharpIrEmitterTestHelpers.ApplyFunc))!;
        var p = new IrLocal(typeof(int), "n");
        // Casts are pass-through, so the function body returns the cast inline; the
        // function's own generated name comes first in the a_, b_, ... sequence. The body
        // linearizes without hoisting any statement, so the local function prints expression-
        // bodied ("=> expr;", no surrounding blank lines) — the old writer's
        // BuildLambdaOperator/BuildBlockExpression rule, keyed on the body actually being a
        // multi-statement block (see HoistLocalFunction in CSharpIrEmitter.Scope.cs).
        var innerLambda = new IrLambda([p], new IrCast(p, typeof(int?), IrCastKind.Cast));
        var call = new IrInvoke(null, applyFunc, innerLambda, new IrConstant(5, typeof(int)));
        var lambda = new IrLambda([], call);

        var expected =
            "{\n" +
            "    int? a_(int n) => (int?)n;\n" +
            "    int? b_ = CSharpIrEmitterTestHelpers.ApplyFunc(a_, 5);\n" +
            "    return b_;\n" +
            "}";
        Assert.AreEqual(expected, EmitBody(lambda));
    }

    [TestMethod]
    public void Conditional_TrivialBranches_PrintsInlineTernary()
    {
        var test = new IrLocal(typeof(bool), "c");
        var conditional = new IrConditional(test, new IrConstant(1, typeof(int)), new IrConstant(2, typeof(int)), typeof(int));
        var lambda = new IrLambda([test], conditional);

        Assert.AreEqual(
            "{\n    return (c\n        ? 1\n        : 2);\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void Conditional_CompoundBranch_PrintsIfElseStatement()
    {
        var test = new IrLocal(typeof(bool), "c");
        // The true branch needs its own hoisted statement, so the conditional can no longer
        // print as a single-expression ternary and must flatten into the old pipeline's
        // CaseWhenThen form instead: a hoisted zero-parameter local function containing the
        // if/else chain (branches `return`, a stray `;` after the final else block), invoked
        // where the value is needed (see HoistConditionalFunction in
        // CSharpIrEmitter.Scope.cs).
        var ifTrue = new IrInvoke(null, MathAbsInt, new IrConstant(-5, typeof(int)));
        var ifFalse = new IrConstant(2, typeof(int));
        var conditional = new IrConditional(test, ifTrue, ifFalse, typeof(int));
        var lambda = new IrLambda([test], conditional);

        var actual = EmitBody(lambda);

        var expected =
            "{\n" +
            "\n" +
            "    int a_() {\n" +
            "        if (c)\n" +
            "        {\n" +
            "            int b_ = Math.Abs(-5);\n" +
            "            return b_;\n" +
            "        }\n" +
            "        else\n" +
            "        {\n" +
            "            return 2;\n" +
            "        };\n" +
            "    }\n" +
            "\n" +
            "    return a_();\n" +
            "}";
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IfChain_TailPosition_PrintsReturningIfElseChain()
    {
        // If-chains flatten into the same hoisted-local-function CaseWhenThen form as a
        // compound conditional (see HoistConditionalFunction in CSharpIrEmitter.Scope.cs);
        // here neither the "when" (a bare local) nor either branch (bare constants) hoists
        // anything, so the function body is just the if/else chain itself.
        var when = new IrLocal(typeof(bool), "w");
        var chain = new IrIfChain(
            [(when, new IrConstant(1, typeof(int)))],
            new IrConstant(2, typeof(int)),
            typeof(int));
        var lambda = new IrLambda([when], chain);

        var expected =
            "{\n" +
            "\n" +
            "    int a_() {\n" +
            "        if (w)\n" +
            "        {\n" +
            "            return 1;\n" +
            "        }\n" +
            "        else\n" +
            "        {\n" +
            "            return 2;\n" +
            "        };\n" +
            "    }\n" +
            "\n" +
            "    return a_();\n" +
            "}";
        Assert.AreEqual(expected, EmitBody(lambda));
    }

    [TestMethod]
    public void Property_Instance_NullConditional_And_Static()
    {
        var stringLength = typeof(string).GetProperty(nameof(string.Length))!;
        var x = new IrLocal(typeof(string), "x");

        var instance = new IrProperty(x, stringLength, nullConditional: false);
        Assert.AreEqual(
            "{\n    return x.Length;\n}",
            EmitBody(new IrLambda([x], instance)));
        Assert.AreEqual(typeof(int), instance.Type);

        var nullConditional = new IrProperty(x, stringLength, nullConditional: true);
        Assert.AreEqual(typeof(int?), nullConditional.Type);
        Assert.AreEqual(
            "{\n    int? a_ = x?.Length;\n    return a_;\n}",
            EmitBody(new IrLambda([x], nullConditional)));

        var newLine = typeof(Environment).GetProperty(nameof(Environment.NewLine))!;
        var staticProperty = new IrProperty(null, newLine);
        Assert.AreEqual(
            "{\n    return Environment.NewLine;\n}",
            EmitBody(new IrLambda([], staticProperty)));
    }

    [TestMethod]
    public void Cast_ExplicitAndAs()
    {
        var explicitCast = new IrCast(new IrConstant(3, typeof(int)), typeof(long), IrCastKind.Cast);
        Assert.AreEqual(
            "{\n    return (long)3;\n}",
            EmitBody(new IrLambda([], explicitCast)));

        var o = new IrLocal(typeof(object), "o");
        var safeCast = new IrCast(o, typeof(string), IrCastKind.As);
        Assert.AreEqual(
            "{\n    return o as string;\n}",
            EmitBody(new IrLambda([o], safeCast)));
    }

    [TestMethod]
    public void Cast_ObjectRoutingPeephole()
    {
        // A bool constant typed as object prints as its bare literal ("true"), whose static
        // type is bool -- not object. bool has no direct C# conversion to decimal?, so the
        // emitter must route the cast through object to avoid a CS0030 in the generated code.
        var cast = new IrCast(new IrConstant(true, typeof(object)), typeof(decimal?), IrCastKind.Cast);
        var lambda = new IrLambda([], cast);

        Assert.AreEqual(
            "{\n    return (decimal?)((object)true);\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void TypeIs_ValueTypeOperandIsBoxed()
    {
        // C# type patterns cannot target a nullable value type (CS8116) and cannot match a
        // bare value-typed operand without boxing (CS8121); the emitter unwraps int? to int
        // and boxes the operand to satisfy both rules.
        var y = new IrLocal(typeof(int?), "y");
        var typeIs = new IrTypeIs(y, typeof(int?));
        var lambda = new IrLambda([y], typeIs);

        Assert.AreEqual(
            "{\n    bool a_ = ((object)y) is int;\n    return a_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void TypeIs_TupleTestedType()
    {
        // A tuple-typed operand prints its type pattern in ValueTuple<...> form (C# tuple
        // syntax "(...)" is not legal in an `is` pattern), with the metadata slot as the tuple's
        // first element type -- and is boxed like any other value/tuple-shaped operand.
        var x = new IrLocal(typeof(CSharpIrEmitterTestTuple), "x");
        var typeIs = new IrTypeIs(x, typeof(CSharpIrEmitterTestTuple));
        var lambda = new IrLambda([x], typeIs);

        Assert.AreEqual(
            "{\n    bool a_ = ((object)x) is ValueTuple<CqlTupleMetadata, int?, string>;\n    return a_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void Binary_CoalesceAndNullChecks()
    {
        var x = new IrLocal(typeof(int?), "x");
        var coalesce = new IrBinary(IrBinaryOp.Coalesce, x, new IrConstant(5, typeof(int)));
        Assert.AreEqual(typeof(int), coalesce.Type);
        Assert.AreEqual(
            "{\n    return x ?? 5;\n}",
            EmitBody(new IrLambda([x], coalesce)));

        var s = new IrLocal(typeof(string), "s");
        // A null comparison peephole only fires when the right side actually prints the "null"
        // token, which requires the constant to be typed `object` (typed `string` prints
        // "default" instead -- see Constants_PrintExpectedLiterals).
        var equalNull = new IrBinary(IrBinaryOp.Equal, s, new IrConstant(null, typeof(object)));
        Assert.AreEqual(
            "{\n    return s is null;\n}",
            EmitBody(new IrLambda([s], equalNull)));

        var notEqualNull = new IrBinary(IrBinaryOp.NotEqual, s, new IrConstant(null, typeof(object)));
        Assert.AreEqual(
            "{\n    return s is not null;\n}",
            EmitBody(new IrLambda([s], notEqualNull)));
    }

    [TestMethod]
    public void ObjectCreation_NewAndMemberInit()
    {
        var listCtor = typeof(List<int>).GetConstructor([typeof(int)])!;
        var @new = new IrNew(listCtor, new IrConstant(4, typeof(int)));
        Assert.AreEqual(
            "{\n    return new List<int>(4);\n}",
            EmitBody(new IrLambda([], @new)));

        var widgetCtor = typeof(CSharpIrEmitterTestWidget).GetConstructor(Type.EmptyTypes)!;
        var widgetNew = new IrNew(widgetCtor);
        var countProperty = typeof(CSharpIrEmitterTestWidget).GetProperty(nameof(CSharpIrEmitterTestWidget.Count))!;
        var memberInit = new IrMemberInit(widgetNew, [(countProperty, new IrConstant(7, typeof(int)))]);
        Assert.AreEqual(
            "{\n    CSharpIrEmitterTestWidget a_ = new CSharpIrEmitterTestWidget() { Count = 7 };\n    return a_;\n}",
            EmitBody(new IrLambda([], memberInit)));
    }

    [TestMethod]
    public void ObjectCreation_NewArrayAndNewArrayBounds()
    {
        // Arrays print as multi-line collection expressions with trailing commas, matching
        // the old writer's array format (see CSharpIrEmitter.Print.cs PrintNewArray).
        var newArray = new IrNewArray(typeof(int), new IrConstant(1, typeof(int)), new IrConstant(2, typeof(int)));
        Assert.AreEqual(
            "{\n    int[] a_ = [\n        1,\n        2,\n    ];\n    return a_;\n}",
            EmitBody(new IrLambda([], newArray)));

        var newArrayBounds = new IrNewArrayBounds(typeof(string), new IrConstant(3, typeof(int)));
        Assert.AreEqual(
            "{\n    string[] a_ = new string[3];\n    return a_;\n}",
            EmitBody(new IrLambda([], newArrayBounds)));
    }

    [TestMethod]
    public void TupleInit_PrintsValueTupleLiteralWithMetadataField()
    {
        var tupleType = typeof(CSharpIrEmitterTestTuple);
        var tupleInit = new IrTupleInit(tupleType,
            [("A", new IrConstant(1, typeof(int?))), ("B", new IrConstant("x", typeof(string)))]);
        var lambda = new IrLambda([], tupleInit);

        Assert.AreEqual(
            "{\n    (CqlTupleMetadata, int? A, string B)? a_ = (CqlTupleMetadata_TEST, 1, \"x\");\n    return a_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void DefinitionCall_LocalAndForeign()
    {
        var localCall = new IrDefinitionCall(
            "MyLib", "1.0.0", "Foo", isLocalLibrary: true, [IrContextParameter.Instance], typeof(int?));
        Assert.AreEqual(
            "{\n    int? a_ = this.Foo(context);\n    return a_;\n}",
            EmitBody(new IrLambda([], localCall)));

        var innerArgument = new IrInvoke(null, MathAbsInt, new IrConstant(-3, typeof(int)));
        var foreignCall = new IrDefinitionCall(
            "FHIRHelpers", "4.0.1", "ToCode", isLocalLibrary: false,
            [IrContextParameter.Instance, innerArgument], typeof(string));
        Assert.AreEqual(
            "{\n    int a_ = Math.Abs(-3);\n    string b_ = FHIRHelpers_4_0_1.Instance.ToCode(context, a_);\n    return b_;\n}",
            EmitBody(new IrLambda([], foreignCall)));
    }

    [TestMethod]
    public void Invoke_NullConditional_PrintsQuestionDot_AndWrapsValueReturnType()
    {
        var indexOf = typeof(string).GetMethod(nameof(string.IndexOf), [typeof(char)])!;
        var s = new IrLocal(typeof(string), "s");
        var call = new IrInvoke(s, indexOf, nullConditional: true, new IrConstant('x', typeof(char)));

        // x?.Method() yields null when x is null, so the value return type is lifted to int?.
        Assert.AreEqual(typeof(int?), call.Type);
        Assert.AreEqual(
            "{\n    int? a_ = s?.IndexOf('x');\n    return a_;\n}",
            EmitBody(new IrLambda([s], call)));

        // A null-conditional call without a receiver is rejected at construction.
        Assert.ThrowsException<ArgumentException>(() =>
            new IrInvoke(null, MathAbsInt, nullConditional: true, new IrConstant(1, typeof(int))));
    }

    [TestMethod]
    public void NameHints_KeywordAndDuplicateHintsFallBackToGeneratedNames()
    {
        // "class" is a C# keyword and the two "x" hints collide: only the first "x" is
        // honored; the others get generated names so the emitted code compiles.
        var keyword = new IrLocal(typeof(int), "class");
        var x1 = new IrLocal(typeof(int), "x");
        var x2 = new IrLocal(typeof(int), "x");
        var lambda = new IrLambda([keyword, x1, x2], x2);

        var emitter = CreateEmitter();
        var body = emitter.EmitBodyBlock(lambda).Replace("\r\n", "\n");
        var names = emitter.GetParameterNames(lambda);

        Assert.AreEqual("x", names[1]);
        Assert.AreNotEqual("class", names[0]);
        Assert.AreNotEqual("x", names[2]);
        CollectionAssert.AllItemsAreUnique(names.ToList());
        Assert.AreEqual($"{{\n    return {names[2]};\n}}", body);
    }

    [TestMethod]
    public void Constant_BoxedDefaultStructValue_PrintsDefault()
    {
        // default(DateTime) has no C# literal; boxed default struct values print as
        // "default", exactly like the previous pipeline's IsObjectNullOrDefault handling.
        var constant = new IrConstant(default(DateTime), typeof(object));

        Assert.AreEqual(
            "{\n    return default;\n}",
            EmitBody(new IrLambda([], constant)));
    }

    [TestMethod]
    public void Validation_ConstructorsThrowOnInvalidInput()
    {
        // IrInvoke: argument count must match the method's parameter count.
        Assert.ThrowsException<ArgumentException>(() =>
            new IrInvoke(null, MathAbsInt, new IrConstant(1, typeof(int)), new IrConstant(2, typeof(int))));

        // IrCast: no C# conversion exists between bool and decimal (and neither side is
        // `object`, which would otherwise defer the check to print time).
        Assert.ThrowsException<ArgumentException>(() =>
            new IrCast(new IrLocal(typeof(bool?), "b"), typeof(decimal?), IrCastKind.Cast));

        // IrConditional: the test must already be plain bool (CQL's three-valued logic must be
        // coerced before reaching the IR), not bool?, int, or anything else.
        Assert.ThrowsException<ArgumentException>(() =>
            new IrConditional(new IrConstant(1, typeof(int)), new IrConstant(1, typeof(int)), new IrConstant(2, typeof(int)), typeof(int)));

        // IrConstant: a null value requires a type that can hold null.
        Assert.ThrowsException<ArgumentException>(() =>
            new IrConstant(null, typeof(int)));
    }
}
