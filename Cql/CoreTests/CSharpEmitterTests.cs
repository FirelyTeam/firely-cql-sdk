/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// A plain-old class used as the target of <see cref="CodeNew"/>/<see cref="CodeMemberInit"/> tests.
/// Kept at namespace scope (not nested in the test class) so <see cref="TypeToCSharpConverter"/>
/// prints its name without a declaring-type prefix.
/// </summary>
internal sealed class CSharpEmitterTestWidget
{
    public CSharpEmitterTestWidget() { }

    public int Count { get; set; }
}

/// <summary>
/// A CQL-tuple-shaped type (derives from <see cref="TupleBaseType"/>, the marker
/// <c>IsTupleBaseType()</c> checks for) used by the <see cref="CodeTupleInit"/> and tuple
/// <see cref="CodeTypeIs"/> tests. Real tuple types are normally reflection-emitted by
/// <c>TupleBuilderCache</c>, but a plain subclass with public properties satisfies the same
/// contract (<c>IsAssignableTo(TupleBaseType)</c> plus <c>GetProperties()</c>) without the
/// ceremony of dynamic IL generation.
/// </summary>
internal sealed class CSharpEmitterTestTuple : TupleBaseType
{
    public int? A { get; set; }

    public string B { get; set; }
}

/// <summary>Helper invoked by the local-function test so an <see cref="CodeLambda"/> has a real
/// <c>Func&lt;,&gt;</c>-typed parameter to be hoisted into.</summary>
internal static class CSharpEmitterTestHelpers
{
    public static int? ApplyFunc(Func<int, int?> f, int x) => f(x);
}

/// <summary>
/// Unit tests for <see cref="CSharpEmitter"/>: builds small typed-IR trees directly via the
/// <c>Hl7.Cql.Compiler.CodeModel.*</c> node constructors and asserts on the exact C# text the emitter
/// produces. The output shape (variable naming, hoisting, dedup, statement-vs-expression
/// printing) is the contract this component exists to fulfill, so most assertions compare the
/// full emitted block text rather than just checking substrings.
/// </summary>
[TestClass]
public class CSharpEmitterTests
{
    /// <summary>Test stand-in for the scaffolding writer's naming conventions.</summary>
    private sealed class TestNamingConventions : ICSharpNamingConventions
    {
        public string TupleMetadataFieldName(Type tupleType) => "CqlTupleMetadata_TEST";

        public string DefinitionTarget(CodeDefinitionCall dc) => dc.IsLocalLibrary
            ? $"this.{dc.DefinitionName}"
            : $"{dc.LibraryName}_{dc.LibraryVersion.Replace('.', '_')}.Instance.{dc.DefinitionName}";
    }

    private static CSharpEmitter CreateEmitter() => new(
        new TypeToCSharpConverter(),
        new TestNamingConventions());

    /// <summary>Emits a definition body and normalizes line endings so assertions are stable
    /// across checkouts with different <c>core.autocrlf</c> settings.</summary>
    private static string EmitBody(CodeLambda lambda) =>
        CreateEmitter().EmitBodyBlock(lambda).Replace("\r\n", "\n");

    private static readonly MethodInfo MathAbsInt =
        typeof(Math).GetMethod(nameof(Math.Abs), [typeof(int)])!;

    [TestMethod]
    public void TrivialConstantBody_EmitsReturnStatement()
    {
        var lambda = new CodeLambda([], new CodeConstant(3, typeof(int?)));

        Assert.AreEqual("{\n    return 3;\n}", EmitBody(lambda));
    }

    [TestMethod]
    public void Constants_PrintExpectedLiterals()
    {
        static string EmitConstant(object? value, Type type) =>
            EmitBody(new CodeLambda([], new CodeConstant(value, type)));

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
        var inner = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int)));
        var outer = new CodeInvoke(null, MathAbsInt, inner);
        var lambda = new CodeLambda([], outer);

        Assert.AreEqual(
            "{\n    int a_ = Math.Abs(-5);\n    int b_ = Math.Abs(a_);\n    return b_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void Dedup_IdenticalSubexpressionHoistedOnce()
    {
        // Two separately-constructed, but structurally identical, CodeInvoke nodes: the emitter
        // dedups on printed code + type, so only one "Math.Abs(-5)" local is introduced even
        // though it is referenced twice. The deduped duplicate still burns a name from the
        // sequence (the old LocalVariableDeduper's letter-gap behavior — see Hoist's
        // "burnedName" in CSharpEmitter.Scope.cs), so the array itself is named "c_", not
        // "b_"; arrays also print as multi-line collection expressions (see
        // ObjectCreation_NewArrayAndNewArrayBounds).
        var call1 = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int)));
        var call2 = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int)));
        var array = new CodeNewArray(typeof(int), call1, call2);
        var lambda = new CodeLambda([], array);

        Assert.AreEqual(
            "{\n    int a_ = Math.Abs(-5);\n    int[] c_ = [\n        a_,\n        a_,\n    ];\n    return c_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void LocalFunction_LambdaArgumentPrintsAsLocalFunction()
    {
        var applyFunc = typeof(CSharpEmitterTestHelpers).GetMethod(nameof(CSharpEmitterTestHelpers.ApplyFunc))!;
        var p = new CodeLocal(typeof(int), "n");
        // Casts are pass-through, so the function body returns the cast inline; the
        // function's own generated name comes first in the a_, b_, ... sequence. The body
        // linearizes without hoisting any statement, so the local function prints expression-
        // bodied ("=> expr;", no surrounding blank lines) — the old writer's
        // BuildLambdaOperator/BuildBlockExpression rule, keyed on the body actually being a
        // multi-statement block (see HoistLocalFunction in CSharpEmitter.Scope.cs).
        var innerLambda = new CodeLambda([p], new CodeCast(p, typeof(int?), CodeCastKind.Cast));
        var call = new CodeInvoke(null, applyFunc, innerLambda, new CodeConstant(5, typeof(int)));
        var lambda = new CodeLambda([], call);

        var expected =
            "{\n" +
            "    int? a_(int n) => (int?)n;\n" +
            "    int? b_ = CSharpEmitterTestHelpers.ApplyFunc(a_, 5);\n" +
            "    return b_;\n" +
            "}";
        Assert.AreEqual(expected, EmitBody(lambda));
    }

    [TestMethod]
    public void Conditional_TrivialBranches_PrintsInlineTernary()
    {
        var test = new CodeLocal(typeof(bool), "c");
        var conditional = new CodeConditional(test, new CodeConstant(1, typeof(int)), new CodeConstant(2, typeof(int)), typeof(int));
        var lambda = new CodeLambda([test], conditional);

        Assert.AreEqual(
            "{\n    return (c\n        ? 1\n        : 2);\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void Conditional_CompoundBranch_PrintsIfElseStatement()
    {
        var test = new CodeLocal(typeof(bool), "c");
        // The true branch needs its own hoisted statement, so the conditional can no longer
        // print as a single-expression ternary and must flatten into the old pipeline's
        // CaseWhenThen form instead: a hoisted zero-parameter local function containing the
        // if/else chain (branches `return`, a stray `;` after the final else block), invoked
        // where the value is needed (see HoistConditionalFunction in
        // CSharpEmitter.Scope.cs).
        var ifTrue = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int)));
        var ifFalse = new CodeConstant(2, typeof(int));
        var conditional = new CodeConditional(test, ifTrue, ifFalse, typeof(int));
        var lambda = new CodeLambda([test], conditional);

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
    public void Conditional_DefinitionCallCoalesceWhen_PrintsInline()
    {
        // CountSpineNodes (CSharpEmitter.Scope.cs) was missing a case for CodeDefinitionCall, so
        // it fell to the "any other spine node" default (2) and a when-condition shaped
        // "Coalesce(DefinitionCall, false)" always hoisted into its own zero-arg bool function,
        // where the old pipeline's isSimpleWhen rule (SimplifyExpressionsVisitor.cs's
        // VisitCaseWhenThenExpression: "testVisitor.Assignments.Count <= 1") leaves it fully
        // inline instead — a single definition/function call is exactly one hoist-worth of
        // complexity. The CQL shape is a "case when <boolean expr> then ... else ..." whose
        // when-clause is nullable-boolean-valued: Case()'s "if (caseWhen.Type.
        // IsNullableValueType(out _)) caseWhen = caseWhen.Coalesce();" wraps it in
        // Coalesce(_, false) before it ever reaches the writer. Found via the HEDIS 2025 corpus
        // (AAB_Details and ~130 other libraries all define a "Check_data_source(context)"-shaped
        // guard this way). The printed condition also picks up the old writer's
        // ParenthesizeIfNeeded quirk: "this.Foo(context)" ends with ')' but doesn't start with
        // '(', so the XOR rule wraps it in an extra pair of parens even though it has no
        // whitespace.
        var definitionCall = new CodeDefinitionCall(
            "MyLib", "1.0.0", "Foo", isLocalLibrary: true, [CodeContextParameter.Instance], typeof(bool?));
        var when = new CodeBinary(CodeBinaryOp.Coalesce, definitionCall, new CodeConstant(false, typeof(bool)));
        var ifTrue = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int))); // needs its own hoisted statement
        var ifFalse = new CodeConstant(2, typeof(int));
        var conditional = new CodeConditional(when, ifTrue, ifFalse, typeof(int));
        var lambda = new CodeLambda([], conditional);

        var expected =
            "{\n" +
            "\n" +
            "    int a_() {\n" +
            "        if ((this.Foo(context)) ?? false)\n" +
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
        Assert.AreEqual(expected, EmitBody(lambda));
    }

    [TestMethod]
    public void Conditional_NonSimpleConditionalWhen_PrintsInlineTernary()
    {
        // A when-condition that is itself a NON-simple conditional still prints inline: the
        // old trial visit (SimplifyExpressionsVisitor.VisitConditional over a non-simple
        // conditional) converted it via ToCwt + VisitCaseWhenThenExpression, whose branch
        // contents went to NESTED visitors — only "MakeLet(caseStatementLambda)" landed on
        // the trial visitor, so isSimpleWhen's "Assignments.Count <= 1" held and the when
        // printed as the raw unvisited ternary, branches and all (see CountSpineNodes'
        // CodeConditional => 1 arm in CSharpEmitter.Scope.cs). Found via the HEDIS 2025
        // corpus (TRC_Elements/IET_Elements/AISE_Reporting/HEDIS's
        // "if (((X) ?? false ? A : B))" when-conditions).
        var isNullOrEmpty = typeof(string).GetMethod(nameof(string.IsNullOrEmpty), [typeof(string)])!;
        var c = new CodeLocal(typeof(bool), "c");
        var s = new CodeLocal(typeof(string), "s");
        // Non-simple: the true branch is a call, which would hoist if linearized.
        var when = new CodeConditional(c,
            new CodeInvoke(null, isNullOrEmpty, s), new CodeConstant(false, typeof(bool)), typeof(bool));
        var ifTrue = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int))); // forces statement form
        var conditional = new CodeConditional(when, ifTrue, new CodeConstant(2, typeof(int)), typeof(int));
        var lambda = new CodeLambda([c, s], conditional);

        var expected =
            "{\n" +
            "\n" +
            "    int a_() {\n" +
            "        if ((c\n" +
            "            ? string.IsNullOrEmpty(s)\n" +
            "            : false))\n" +
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
        Assert.AreEqual(expected, EmitBody(lambda));
    }

    [TestMethod]
    public void IfChain_TailPosition_PrintsReturningIfElseChain()
    {
        // If-chains flatten into the same hoisted-local-function CaseWhenThen form as a
        // compound conditional (see HoistConditionalFunction in CSharpEmitter.Scope.cs);
        // here neither the "when" (a bare local) nor either branch (bare constants) hoists
        // anything, so the function body is just the if/else chain itself.
        var when = new CodeLocal(typeof(bool), "w");
        var chain = new CodeIfChain(
            [(when, new CodeConstant(1, typeof(int)))],
            new CodeConstant(2, typeof(int)),
            typeof(int));
        var lambda = new CodeLambda([when], chain);

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
        var x = new CodeLocal(typeof(string), "x");

        var instance = new CodeProperty(x, stringLength, nullConditional: false);
        Assert.AreEqual(
            "{\n    return x.Length;\n}",
            EmitBody(new CodeLambda([x], instance)));
        Assert.AreEqual(typeof(int), instance.Type);

        var nullConditional = new CodeProperty(x, stringLength, nullConditional: true);
        Assert.AreEqual(typeof(int?), nullConditional.Type);
        Assert.AreEqual(
            "{\n    int? a_ = x?.Length;\n    return a_;\n}",
            EmitBody(new CodeLambda([x], nullConditional)));

        var newLine = typeof(Environment).GetProperty(nameof(Environment.NewLine))!;
        var staticProperty = new CodeProperty(null, newLine);
        Assert.AreEqual(
            "{\n    return Environment.NewLine;\n}",
            EmitBody(new CodeLambda([], staticProperty)));
    }

    [TestMethod]
    public void Cast_ExplicitAndAs()
    {
        var explicitCast = new CodeCast(new CodeConstant(3, typeof(int)), typeof(long), CodeCastKind.Cast);
        Assert.AreEqual(
            "{\n    return (long)3;\n}",
            EmitBody(new CodeLambda([], explicitCast)));

        var o = new CodeLocal(typeof(object), "o");
        var safeCast = new CodeCast(o, typeof(string), CodeCastKind.As);
        Assert.AreEqual(
            "{\n    return o as string;\n}",
            EmitBody(new CodeLambda([o], safeCast)));
    }

    [TestMethod]
    public void Cast_OfNullConstant_CollapsesToDefaultLiteral()
    {
        // ElmAsExpression.Reduce() (Cql.Compiler/Expressions/ElmAsExpression.cs): "if
        // (Expression is ConstantExpression { Value: null }) return Constant(null, AsType);" —
        // an As/Cast wrapping an ALREADY-CONSTANT null collapses to a plain null constant of the
        // cast's own target type, printing as a bare "default" — not "null as T"/"(T)null". This
        // is the shape produced by the old As() branch that resolves a plain type NAME (as
        // opposed to a nested type-specifier): its operand goes through the ordinary ELM Null
        // dispatch ("Null e => NullExpression.ForType(TypeFor(e)!)", a real ConstantExpression),
        // not the asTypeSpecifier branch's special-cased Expression.Default(type). Found via the
        // HEDIS 2025 corpus (a parameter's "Interval[3, null]" default value:
        // "context.Operators.Interval(3, default, true, true)").
        var castOfNullConstant = new CodeCast(new CodeConstant(null, typeof(object)), typeof(int?), CodeCastKind.As);
        Assert.AreEqual(
            "{\n    return default;\n}",
            EmitBody(new CodeLambda([], castOfNullConstant)));

        // An CodeDefault operand (the OTHER As() branch — a Null CQL operand under an
        // asTypeSpecifier, which builds Expression.Default(type) directly, never a
        // ConstantExpression) does NOT qualify for the collapse and keeps printing "null as T",
        // matching Cast_ExplicitAndAs's plain "as" case.
        var castOfDefault = new CodeCast(new CodeDefault(typeof(int?)), typeof(int?), CodeCastKind.As);
        Assert.AreEqual(
            "{\n    return null as int?;\n}",
            EmitBody(new CodeLambda([], castOfDefault)));
    }

    [TestMethod]
    public void Cast_ToObject_SurvivesOnlyForCqlAsOperatorCasts()
    {
        // Reference-typed casts to object are redundant C# and the old
        // RedundantCastsTransformer stripped them — but ONLY the raw Convert/TypeAs nodes its
        // single tree pass could see. Casts built by the builder's As() for an ELM "as"
        // operator were ElmAsExpression wrappers that reduced to a real TypeAs at print time,
        // AFTER the transformer ran, so they always survived and printed "x as object"
        // (whatever their operand — HEDIS AMR_Details returns a definition-call result this
        // way). CodeCast.FromCqlAsOperator records that origin; see PrintCast in
        // CSharpEmitter.Print.cs.
        var s = new CodeLocal(typeof(string), "s");

        var fromCqlAs = new CodeCast(s, typeof(object), CodeCastKind.As, fromCqlAsOperator: true);
        Assert.AreEqual(
            "{\n    return s as object;\n}",
            EmitBody(new CodeLambda([s], fromCqlAs)));

        // A conversion-helper cast (old: raw Expression.TypeAs) strips like the old
        // transformer's reference-type rule.
        var fromConversion = new CodeCast(s, typeof(object), CodeCastKind.As);
        Assert.AreEqual(
            "{\n    return s;\n}",
            EmitBody(new CodeLambda([s], fromConversion)));

        // Value-typed operands always strip — the old StripBoxing ran at PRINT time inside
        // BuildUnaryExpression, so it applied to reduced ElmAsExpression nodes too.
        var i = new CodeLocal(typeof(int?), "i");
        var boxing = new CodeCast(i, typeof(object), CodeCastKind.As, fromCqlAsOperator: true);
        Assert.AreEqual(
            "{\n    return i;\n}",
            EmitBody(new CodeLambda([i], boxing)));
    }

    [TestMethod]
    public void Cast_ObjectRoutingPeephole()
    {
        // A bool constant typed as object prints as its bare literal ("true"), whose static
        // type is bool -- not object. bool has no direct C# conversion to decimal?, so the
        // emitter must route the cast through object to avoid a CS0030 in the generated code.
        var cast = new CodeCast(new CodeConstant(true, typeof(object)), typeof(decimal?), CodeCastKind.Cast);
        var lambda = new CodeLambda([], cast);

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
        var y = new CodeLocal(typeof(int?), "y");
        var typeIs = new CodeTypeIs(y, typeof(int?));
        var lambda = new CodeLambda([y], typeIs);

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
        var x = new CodeLocal(typeof(CSharpEmitterTestTuple), "x");
        var typeIs = new CodeTypeIs(x, typeof(CSharpEmitterTestTuple));
        var lambda = new CodeLambda([x], typeIs);

        Assert.AreEqual(
            "{\n    bool a_ = ((object)x) is ValueTuple<CqlTupleMetadata, int?, string>;\n    return a_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void Binary_CoalesceAndNullChecks()
    {
        var x = new CodeLocal(typeof(int?), "x");
        var coalesce = new CodeBinary(CodeBinaryOp.Coalesce, x, new CodeConstant(5, typeof(int)));
        Assert.AreEqual(typeof(int), coalesce.Type);
        Assert.AreEqual(
            "{\n    return x ?? 5;\n}",
            EmitBody(new CodeLambda([x], coalesce)));

        var s = new CodeLocal(typeof(string), "s");
        // A null comparison peephole only fires when the right side actually prints the "null"
        // token, which requires the constant to be typed `object` (typed `string` prints
        // "default" instead -- see Constants_PrintExpectedLiterals).
        var equalNull = new CodeBinary(CodeBinaryOp.Equal, s, new CodeConstant(null, typeof(object)));
        Assert.AreEqual(
            "{\n    return s is null;\n}",
            EmitBody(new CodeLambda([s], equalNull)));

        // #1361 — the old RedundantCastsTransformer's constant coalesce folds, mirrored at
        // print time. Without the first, Message(source, true, ...) emits the invalid C#
        // `true ?? false` (CS0019: ?? needs a nullable left operand).
        var trueCoalesce = new CodeBinary(CodeBinaryOp.Coalesce,
            new CodeConstant(true, typeof(bool?)), new CodeConstant(false, typeof(bool?)));
        Assert.AreEqual( // a (not null) ?? x => a
            "{\n    return true;\n}",
            EmitBody(new CodeLambda([], trueCoalesce)));

        var nullCoalesce = new CodeBinary(CodeBinaryOp.Coalesce,
            new CodeConstant(null, typeof(int?)), new CodeConstant(5, typeof(int?)));
        Assert.AreEqual( // null_constant ?? x => x
            "{\n    return 5;\n}",
            EmitBody(new CodeLambda([], nullCoalesce)));

        var defaultCoalesce = new CodeBinary(CodeBinaryOp.Coalesce,
            new CodeDefault(typeof(int?)), new CodeConstant(5, typeof(int?)));
        Assert.AreEqual( // default ?? x => x
            "{\n    return 5;\n}",
            EmitBody(new CodeLambda([], defaultCoalesce)));

        var notEqualNull = new CodeBinary(CodeBinaryOp.NotEqual, s, new CodeConstant(null, typeof(object)));
        Assert.AreEqual(
            "{\n    return s is not null;\n}",
            EmitBody(new CodeLambda([s], notEqualNull)));
    }

    [TestMethod]
    public void Binary_RightOperandNeverParenthesized()
    {
        // LambdaDefinitionWriter.BuildBinaryExpression parenthesizes ONLY the left operand
        // ("leftCode = leftCode.ParenthesizeIfNeeded();") -- rightCode is used verbatim,
        // however it printed, e.g. an "as" cast: "g ?? h as string", never
        // "g ?? (h as string)". Found via the HEDIS 2025 corpus (Claims/ExplanationOfBenefits'
        // "g_ ?? h_ as IEnumerable<CodeableConcept>").
        var g = new CodeLocal(typeof(string), "g");
        var h = new CodeLocal(typeof(object), "h");
        var coalesceWithAsRight = new CodeBinary(CodeBinaryOp.Coalesce, g, new CodeCast(h, typeof(string), CodeCastKind.As));

        Assert.AreEqual(
            "{\n    return g ?? h as string;\n}",
            EmitBody(new CodeLambda([g, h], coalesceWithAsRight)));
    }

    [TestMethod]
    public void ObjectCreation_NewAndMemberInit()
    {
        var listCtor = typeof(List<int>).GetConstructor([typeof(int)])!;
        var @new = new CodeNew(listCtor, new CodeConstant(4, typeof(int)));
        Assert.AreEqual(
            "{\n    return new List<int>(4);\n}",
            EmitBody(new CodeLambda([], @new)));

        var widgetCtor = typeof(CSharpEmitterTestWidget).GetConstructor(Type.EmptyTypes)!;
        var widgetNew = new CodeNew(widgetCtor);
        var countProperty = typeof(CSharpEmitterTestWidget).GetProperty(nameof(CSharpEmitterTestWidget.Count))!;
        var memberInit = new CodeMemberInit(widgetNew, [(countProperty, new CodeConstant(7, typeof(int)))]);
        // LambdaDefinitionWriter.BuildMemberInitExpression prints a multi-line block: "new
        // Type" (no parens — that form is never routed through BuildNewExpression/PrintNew),
        // "{" on its own line, one "Member = value," per indented line (trailing comma even on
        // the last binding), closing "}" back at the original indent (see PrintMemberInit in
        // CSharpEmitter.Print.cs). This replaced an earlier single-line "new Type() { ... }"
        // rendering that never matched the old pipeline (found via the HEDIS 2025 corpus —
        // ResultParameters/HFS_Elements construct a FHIR Parameters resource this way).
        Assert.AreEqual(
            "{\n    CSharpEmitterTestWidget a_ = new CSharpEmitterTestWidget\n    {\n        Count = 7,\n    };\n    return a_;\n}",
            EmitBody(new CodeLambda([], memberInit)));
    }

    [TestMethod]
    public void ObjectCreation_NewArrayAndNewArrayBounds()
    {
        // Arrays print as multi-line collection expressions with trailing commas, matching
        // the old writer's array format (see CSharpEmitter.Print.cs PrintNewArray).
        var newArray = new CodeNewArray(typeof(int), new CodeConstant(1, typeof(int)), new CodeConstant(2, typeof(int)));
        Assert.AreEqual(
            "{\n    int[] a_ = [\n        1,\n        2,\n    ];\n    return a_;\n}",
            EmitBody(new CodeLambda([], newArray)));

        // LambdaDefinitionWriter.BuildNewArrayExpression: "case ExpressionType.NewArrayBounds:
        // return "[]";" — unconditional, regardless of the bounds value; the old builder only
        // ever constructs this node with a literal zero bound (empty untyped/typed lists), so
        // it never had to print anything else. Found via the HEDIS 2025 corpus (many libraries
        // build an empty typed array this way, e.g. "Immunization[] k_ = [];").
        var newArrayBounds = new CodeNewArrayBounds(typeof(string), new CodeConstant(0, typeof(int)));
        Assert.AreEqual(
            "{\n    string[] a_ = [];\n    return a_;\n}",
            EmitBody(new CodeLambda([], newArrayBounds)));

        // A non-zero length has no print form (no builder path produces one); the emitter
        // fails loudly rather than silently printing an empty collection expression.
        var nonZeroBounds = new CodeNewArrayBounds(typeof(string), new CodeConstant(3, typeof(int)));
        Assert.ThrowsException<NotSupportedException>(() => EmitBody(new CodeLambda([], nonZeroBounds)));
    }

    [TestMethod]
    public void TupleInit_PrintsValueTupleLiteralWithMetadataField()
    {
        var tupleType = typeof(CSharpEmitterTestTuple);
        var tupleInit = new CodeTupleInit(tupleType,
            [("A", new CodeConstant(1, typeof(int?))), ("B", new CodeConstant("x", typeof(string)))]);
        var lambda = new CodeLambda([], tupleInit);

        Assert.AreEqual(
            "{\n    (CqlTupleMetadata, int? A, string B)? a_ = (CqlTupleMetadata_TEST, 1, \"x\");\n    return a_;\n}",
            EmitBody(lambda));
    }

    [TestMethod]
    public void TupleInit_ElementsOutOfCanonicalOrder_PrintInDeclaredPropertyOrder()
    {
        // #1362: values are looked up by name and emitted in the tuple type's declared
        // property order (A, B) regardless of the stored (CQL-authored) order — the
        // positional value-tuple literal would otherwise silently transpose same-typed
        // fields. Mirrors the old writer's BuildMemberInitTupleExpression.
        var tupleType = typeof(CSharpEmitterTestTuple);
        var tupleInit = new CodeTupleInit(tupleType,
            [("B", new CodeConstant("x", typeof(string))), ("A", new CodeConstant(1, typeof(int?)))]);

        Assert.AreEqual(
            "{\n    (CqlTupleMetadata, int? A, string B)? a_ = (CqlTupleMetadata_TEST, 1, \"x\");\n    return a_;\n}",
            EmitBody(new CodeLambda([], tupleInit)));
    }

    [TestMethod]
    public void TupleInit_UnboundElement_PrintsDefault()
    {
        // Properties without a binding print "default", exactly like the old
        // BuildMemberInitTupleExpression's GetValueOrDefault fallback.
        var tupleType = typeof(CSharpEmitterTestTuple);
        var tupleInit = new CodeTupleInit(tupleType, [("B", new CodeConstant("x", typeof(string)))]);

        Assert.AreEqual(
            "{\n    (CqlTupleMetadata, int? A, string B)? a_ = (CqlTupleMetadata_TEST, default, \"x\");\n    return a_;\n}",
            EmitBody(new CodeLambda([], tupleInit)));
    }

    [TestMethod]
    public void Conditional_ConstantTest_FoldsToSurvivingBranch()
    {
        // if(true, A, B) => A / if(false, A, B) => B — the old RedundantCastsTransformer's
        // VisitConditional fold (#1361). The discarded branch would hoist a call; folding
        // before dispatch means no statement is ever emitted for it.
        var discarded = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int)));
        var foldTrue = new CodeConditional(
            new CodeConstant(true, typeof(bool)), new CodeConstant(1, typeof(int)), discarded, typeof(int));
        Assert.AreEqual("{\n    return 1;\n}", EmitBody(new CodeLambda([], foldTrue)));

        var foldFalse = new CodeConditional(
            new CodeConstant(false, typeof(bool)), discarded, new CodeConstant(2, typeof(int)), typeof(int));
        Assert.AreEqual("{\n    return 2;\n}", EmitBody(new CodeLambda([], foldFalse)));
    }

    [TestMethod]
    public void Conditional_CoalescedConstantTest_FoldsToSurvivingBranch()
    {
        // The old RedundantCastsTransformer.VisitConditional ran Visit(node.Test) BEFORE
        // matching it against a bool constant, so its own bottom-up VisitBinary coalesce fold
        // ("a (not null) ?? x => a") had already reduced Coalesce(Constant(true), false) to
        // Constant(true) — the shape the builder's If() produces for CQL's
        // "if true then ... else null" idiom (test coalesced via .Coalesce()). Mirrored by
        // TryFoldTestToBoolConstant in CSharpEmitter.Print.cs; found via the HEDIS 2025
        // corpus (CQL_Common's Error/Warning function bodies).
        var discarded = new CodeInvoke(null, MathAbsInt, new CodeConstant(-5, typeof(int)));
        var coalescedTest = new CodeBinary(CodeBinaryOp.Coalesce,
            new CodeConstant(true, typeof(bool?)), new CodeConstant(false, typeof(bool)));
        var kept = new CodeInvoke(null, MathAbsInt, new CodeConstant(-7, typeof(int)));
        var conditional = new CodeConditional(coalescedTest, kept, discarded, typeof(int));

        Assert.AreEqual(
            "{\n    int a_ = Math.Abs(-7);\n    return a_;\n}",
            EmitBody(new CodeLambda([], conditional)));
    }

    [TestMethod]
    public void DefinitionCall_LocalAndForeign()
    {
        var localCall = new CodeDefinitionCall(
            "MyLib", "1.0.0", "Foo", isLocalLibrary: true, [CodeContextParameter.Instance], typeof(int?));
        Assert.AreEqual(
            "{\n    int? a_ = this.Foo(context);\n    return a_;\n}",
            EmitBody(new CodeLambda([], localCall)));

        var innerArgument = new CodeInvoke(null, MathAbsInt, new CodeConstant(-3, typeof(int)));
        var foreignCall = new CodeDefinitionCall(
            "FHIRHelpers", "4.0.1", "ToCode", isLocalLibrary: false,
            [CodeContextParameter.Instance, innerArgument], typeof(string));
        Assert.AreEqual(
            "{\n    int a_ = Math.Abs(-3);\n    string b_ = FHIRHelpers_4_0_1.Instance.ToCode(context, a_);\n    return b_;\n}",
            EmitBody(new CodeLambda([], foreignCall)));
    }

    [TestMethod]
    public void Invoke_NullConditional_PrintsQuestionDot_AndWrapsValueReturnType()
    {
        var indexOf = typeof(string).GetMethod(nameof(string.IndexOf), [typeof(char)])!;
        var s = new CodeLocal(typeof(string), "s");
        var call = new CodeInvoke(s, indexOf, nullConditional: true, new CodeConstant('x', typeof(char)));

        // x?.Method() yields null when x is null, so the value return type is lifted to int?.
        Assert.AreEqual(typeof(int?), call.Type);
        Assert.AreEqual(
            "{\n    int? a_ = s?.IndexOf('x');\n    return a_;\n}",
            EmitBody(new CodeLambda([s], call)));

        // A null-conditional call without a receiver is rejected at construction.
        Assert.ThrowsException<ArgumentException>(() =>
            new CodeInvoke(null, MathAbsInt, nullConditional: true, new CodeConstant(1, typeof(int))));
    }

    [TestMethod]
    public void NameHints_HonoredVerbatim_KeywordsFallBackToGeneratedNames()
    {
        // Hints print VERBATIM, duplicates included — the old pipeline never renamed lambda
        // parameters (RenameVariablesVisitor only named unnamed block variables; the writer
        // printed p.Name as-is), so a repeated alias prints repeated (the pre-existing #1343
        // shape) and a nested lambda's alias shadows an ancestor's verbatim (HEDIS
        // PCR_Details' "stay"). Test updated when an earlier, stricter lineage-reservation
        // rule was removed for byte parity — see AllocateName in CSharpEmitter.Scope.cs.
        // The keyword fallback is a deliberate deviation from old (old printed an @-escaped
        // declaration but unescaped references, i.e. non-compiling; ledger note).
        var keyword = new CodeLocal(typeof(int), "class");
        var x1 = new CodeLocal(typeof(int), "x");
        var x2 = new CodeLocal(typeof(int), "x");
        var lambda = new CodeLambda([keyword, x1, x2], x2);

        var emitter = CreateEmitter();
        var body = emitter.EmitBodyBlock(lambda).Replace("\r\n", "\n");
        var names = emitter.GetParameterNames(lambda);

        Assert.AreNotEqual("class", names[0]);
        Assert.AreEqual("x", names[1]);
        Assert.AreEqual("x", names[2]);
        Assert.AreEqual("{\n    return x;\n}", body);
    }

    [TestMethod]
    public void NameHints_NestedLambdaReusesAncestorHintVerbatim()
    {
        // A nested lambda whose parameter carries the SAME CQL alias as an enclosing lambda's
        // parameter prints it verbatim, shadowing the ancestor — the old pipeline never
        // renamed parameters, so HEDIS PCR_Details' Select over "stay" tuples inside a
        // "stay" lambda prints both as "stay". (See AllocateName in CSharpEmitter.Scope.cs.)
        var applyFunc = typeof(CSharpEmitterTestHelpers).GetMethod(nameof(CSharpEmitterTestHelpers.ApplyFunc))!;
        var outer = new CodeLocal(typeof(int), "stay");
        var inner = new CodeLocal(typeof(int), "stay");
        var innerLambda = new CodeLambda([inner], new CodeCast(inner, typeof(int?), CodeCastKind.Cast));
        var call = new CodeInvoke(null, applyFunc, innerLambda, outer);
        var lambda = new CodeLambda([outer], call);

        var expected =
            "{\n" +
            "    int? a_(int stay) => (int?)stay;\n" +
            "    int? b_ = CSharpEmitterTestHelpers.ApplyFunc(a_, stay);\n" +
            "    return b_;\n" +
            "}";
        Assert.AreEqual(expected, EmitBody(lambda));
    }

    [TestMethod]
    public void Constant_BoxedDefaultStructValue_PrintsDefault()
    {
        // default(DateTime) has no C# literal; boxed default struct values print as
        // "default", exactly like the previous pipeline's IsObjectNullOrDefault handling.
        var constant = new CodeConstant(default(DateTime), typeof(object));

        Assert.AreEqual(
            "{\n    return default;\n}",
            EmitBody(new CodeLambda([], constant)));
    }

    [TestMethod]
    public void Validation_ConstructorsThrowOnInvalidInput()
    {
        // CodeInvoke: argument count must match the method's parameter count.
        Assert.ThrowsException<ArgumentException>(() =>
            new CodeInvoke(null, MathAbsInt, new CodeConstant(1, typeof(int)), new CodeConstant(2, typeof(int))));

        // CodeCast: no C# conversion exists between bool and decimal (and neither side is
        // `object`, which would otherwise defer the check to print time).
        Assert.ThrowsException<ArgumentException>(() =>
            new CodeCast(new CodeLocal(typeof(bool?), "b"), typeof(decimal?), CodeCastKind.Cast));

        // CodeConditional: the test must already be plain bool (CQL's three-valued logic must be
        // coerced before reaching the IR), not bool?, int, or anything else.
        Assert.ThrowsException<ArgumentException>(() =>
            new CodeConditional(new CodeConstant(1, typeof(int)), new CodeConstant(1, typeof(int)), new CodeConstant(2, typeof(int)), typeof(int)));

        // CodeConstant: a null value requires a type that can hold null.
        Assert.ThrowsException<ArgumentException>(() =>
            new CodeConstant(null, typeof(int)));
    }
}
