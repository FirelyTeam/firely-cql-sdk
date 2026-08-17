/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// End-to-end coverage for the short-circuit lowering of <c>and</c>/<c>or</c>/<c>not</c>
/// (issue #1514): CQL in <c>Input/ELM/HL7/ShortCircuitLogicTest.cql</c> whose generated C#
/// contains the guarded control-flow form, executed here for its real results.
///
/// <para>The truth-table tests pin CQL's three-valued logic (spec §9.B) through generated
/// code rather than through <c>ICqlOperators</c> directly — the operands are expression refs,
/// so every combination goes through the guard. The Message tests are the observable evidence
/// that the right operand is skipped exactly when the left operand decides the result
/// (<c>false</c> for <c>and</c>, <c>true</c> for <c>or</c>) and is NOT skipped on
/// <c>null</c> — <c>null and false</c> is <c>false</c>, so a null left operand must still
/// evaluate the right.</para>
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class ShortCircuitLogicCqlTest
{
    private static ShortCircuitLogicTest_1_0_0 Library => ShortCircuitLogicTest_1_0_0.Instance;

    private static CqlContext Context() => FhirCqlContext.ForBundle();

    #region Truth tables (CQL spec §9.B) through generated code

    [TestMethod]
    public void And_TruthTable()
    {
        Assert.AreEqual(true, Library.TrueAndTrue(Context()));
        Assert.AreEqual(false, Library.TrueAndFalse(Context()));
        Assert.IsNull(Library.TrueAndNull(Context()));
        Assert.AreEqual(false, Library.FalseAndTrue(Context()));
        Assert.AreEqual(false, Library.FalseAndFalse(Context()));
        Assert.AreEqual(false, Library.FalseAndNull(Context()));
        Assert.IsNull(Library.NullAndTrue(Context()));
        Assert.AreEqual(false, Library.NullAndFalse(Context()));
        Assert.IsNull(Library.NullAndNull(Context()));
    }

    [TestMethod]
    public void Or_TruthTable()
    {
        Assert.AreEqual(true, Library.TrueOrTrue(Context()));
        Assert.AreEqual(true, Library.TrueOrFalse(Context()));
        Assert.AreEqual(true, Library.TrueOrNull(Context()));
        Assert.AreEqual(true, Library.FalseOrTrue(Context()));
        Assert.AreEqual(false, Library.FalseOrFalse(Context()));
        Assert.IsNull(Library.FalseOrNull(Context()));
        Assert.AreEqual(true, Library.NullOrTrue(Context()));
        Assert.IsNull(Library.NullOrFalse(Context()));
        Assert.IsNull(Library.NullOrNull(Context()));
    }

    [TestMethod]
    public void Not_TruthTable()
    {
        Assert.AreEqual(false, Library.NotTrue(Context()));
        Assert.AreEqual(true, Library.NotFalse(Context()));
        Assert.IsNull(Library.NotNull(Context()));
    }

    /// <summary>
    /// <c>implies</c>: the only one of these operators whose skip the spec calls out explicitly
    /// ("implies may use short-circuit evaluation in the case that the first operand evaluates
    /// to false"). Note the deciding left value and the deciding RESULT differ — every
    /// <c>false implies X</c> is <see langword="true"/> — and that <c>null implies true</c> is
    /// true while <c>null implies false</c> is null, so null decides nothing here either.
    /// </summary>
    [TestMethod]
    public void Implies_TruthTable()
    {
        Assert.AreEqual(true, Library.TrueImpliesTrue(Context()));
        Assert.AreEqual(false, Library.TrueImpliesFalse(Context()));
        Assert.IsNull(Library.TrueImpliesNull(Context()));
        Assert.AreEqual(true, Library.FalseImpliesTrue(Context()));
        Assert.AreEqual(true, Library.FalseImpliesFalse(Context()));
        Assert.AreEqual(true, Library.FalseImpliesNull(Context()));
        Assert.AreEqual(true, Library.NullImpliesTrue(Context()));
        Assert.IsNull(Library.NullImpliesFalse(Context()));
        Assert.IsNull(Library.NullImpliesNull(Context()));
    }

    /// <summary>
    /// The generated code must agree with the runtime operators it no longer calls — the
    /// runtime implementation is the reference the lowering is checked against.
    /// </summary>
    [TestMethod]
    public void GeneratedCode_AgreesWithRuntimeOperators()
    {
        var ops = Context().Operators;
        bool?[] values = [true, false, null];

        var generatedAnd = new Func<CqlContext, bool?>[,]
        {
            { Library.TrueAndTrue, Library.TrueAndFalse, Library.TrueAndNull },
            { Library.FalseAndTrue, Library.FalseAndFalse, Library.FalseAndNull },
            { Library.NullAndTrue, Library.NullAndFalse, Library.NullAndNull },
        };
        var generatedOr = new Func<CqlContext, bool?>[,]
        {
            { Library.TrueOrTrue, Library.TrueOrFalse, Library.TrueOrNull },
            { Library.FalseOrTrue, Library.FalseOrFalse, Library.FalseOrNull },
            { Library.NullOrTrue, Library.NullOrFalse, Library.NullOrNull },
        };
        var generatedImplies = new Func<CqlContext, bool?>[,]
        {
            { Library.TrueImpliesTrue, Library.TrueImpliesFalse, Library.TrueImpliesNull },
            { Library.FalseImpliesTrue, Library.FalseImpliesFalse, Library.FalseImpliesNull },
            { Library.NullImpliesTrue, Library.NullImpliesFalse, Library.NullImpliesNull },
        };

        for (var l = 0; l < 3; l++)
        {
            for (var r = 0; r < 3; r++)
            {
                Assert.AreEqual(ops.And(values[l], values[r]), generatedAnd[l, r](Context()), $"and: left={values[l]}, right={values[r]}");
                Assert.AreEqual(ops.Or(values[l], values[r]), generatedOr[l, r](Context()), $"or: left={values[l]}, right={values[r]}");
                Assert.AreEqual(ops.Implies(values[l], values[r]), generatedImplies[l, r](Context()), $"implies: left={values[l]}, right={values[r]}");
            }
        }

        Assert.AreEqual(ops.Not(true), Library.NotTrue(Context()));
        Assert.AreEqual(ops.Not(false), Library.NotFalse(Context()));
        Assert.AreEqual(ops.Not(null), Library.NotNull(Context()));
    }

    #endregion

    #region Skip evidence via Message

    private static (bool? result, int messages) RunCountingMessages(Func<CqlContext, bool?> definition)
    {
        var context = Context();
        var messages = 0;
        context.MessageReceived += (_, e) =>
        {
            if (e.Code == "ShortCircuitLogicTest.RightEvaluated")
                messages++;
        };
        var result = definition(context);
        return (result, messages);
    }

    [TestMethod]
    public void FalseAndMessage_SkipsRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.FalseAndMessage);
        Assert.AreEqual(false, result);
        Assert.AreEqual(0, messages, "false decides 'and'; the right operand must not be evaluated.");
    }

    [TestMethod]
    public void NullAndMessage_EvaluatesRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.NullAndMessage);
        Assert.IsNull(result); // null and true = null
        Assert.AreEqual(1, messages, "null does NOT decide 'and' (null and false = false); the right operand must be evaluated.");
    }

    [TestMethod]
    public void TrueOrMessage_SkipsRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.TrueOrMessage);
        Assert.AreEqual(true, result);
        Assert.AreEqual(0, messages, "true decides 'or'; the right operand must not be evaluated.");
    }

    [TestMethod]
    public void NullOrMessage_EvaluatesRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.NullOrMessage);
        Assert.AreEqual(true, result); // null or true = true
        Assert.AreEqual(1, messages, "null does NOT decide 'or' (null or false = null); the right operand must be evaluated.");
    }

    [TestMethod]
    public void FalseImpliesMessage_SkipsRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.FalseImpliesMessage);
        Assert.AreEqual(true, result); // false implies X is true for every X
        Assert.AreEqual(0, messages, "false decides 'implies'; the right operand must not be evaluated.");
    }

    [TestMethod]
    public void TrueImpliesMessage_EvaluatesRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.TrueImpliesMessage);
        Assert.AreEqual(true, result); // true implies X = X
        Assert.AreEqual(1, messages, "true does NOT decide 'implies' — the result IS the right operand.");
    }

    [TestMethod]
    public void NullImpliesMessage_EvaluatesRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.NullImpliesMessage);
        Assert.AreEqual(true, result); // null implies true = true
        Assert.AreEqual(1, messages, "null does NOT decide 'implies' (null implies true is true); the right operand must be evaluated.");
    }

    /// <summary>
    /// A guarded <c>and</c> inside the TEST of a conditional with simple branches: the emitter
    /// must not classify that conditional as an inline ternary, because the guard's
    /// let-binding has no inline print form (HEDIS-corpus regression; the fixture define
    /// exists to keep a public repro). Value-wise: <c>true and Message(true, ...)</c> is
    /// true — the right operand runs (true does not decide <c>and</c>) — so the result is 1
    /// and the message fires exactly once.
    /// </summary>
    [TestMethod]
    public void GuardInConditionalTest_PrintsAsStatements_AndEvaluates()
    {
        var context = Context();
        var messages = 0;
        context.MessageReceived += (_, e) =>
        {
            if (e.Code == "ShortCircuitLogicTest.RightEvaluated")
                messages++;
        };
        Assert.AreEqual(1, Library.GuardInConditionalTest(context));
        Assert.AreEqual(1, messages);
    }

    /// <summary>
    /// Deciding constant operands fold at build time on either side, cascading through
    /// nested chains: `X or true` collapses to `true` (Kleene: even `null or true` is true),
    /// erasing the left operand and its side effects entirely — permitted, since CQL does
    /// not prescribe evaluation of logical operands, and disclosed in the release note.
    /// </summary>
    [TestMethod]
    public void DecidingConstantOperands_CollapseWholeChains()
    {
        var (orResult, orMessages) = RunCountingMessages(Library.OrTrueCollapses);
        Assert.AreEqual(true, orResult);
        Assert.AreEqual(0, orMessages, "X or true folds to true at build time; X must not be evaluated.");

        var (andResult, andMessages) = RunCountingMessages(Library.AndFalseCollapses);
        Assert.AreEqual(false, andResult);
        Assert.AreEqual(0, andMessages, "X and false folds to false at build time; X must not be evaluated.");

        var (nestedResult, nestedMessages) = RunCountingMessages(Library.NestedOrTrueCollapses);
        Assert.AreEqual(true, nestedResult);
        Assert.AreEqual(0, nestedMessages, "the fold cascades: e1 or (e2 or (e3 or true)) collapses outright.");
    }

    /// <summary>
    /// The UNGUARDED merge path: function parameters are already-evaluated values, so
    /// MergeAnd/MergeOr compile to plain lifted operators with no guard, and AndNotY to the
    /// inline-ternary guard form. All nine combinations, against the runtime oracle.
    /// </summary>
    [TestMethod]
    public void MergePath_TruthTables_AgreeWithRuntimeOperators()
    {
        var ops = Context().Operators;
        bool?[] values = [true, false, null];
        foreach (var x in values)
        {
            foreach (var y in values)
            {
                Assert.AreEqual(ops.And(x, y), Library.MergeAnd(Context(), x, y), $"merge and: x={x}, y={y}");
                Assert.AreEqual(ops.Or(x, y), Library.MergeOr(Context(), x, y), $"merge or: x={x}, y={y}");
                Assert.AreEqual(ops.And(x, ops.Not(y)), Library.AndNotY(Context(), x, y), $"and-not: x={x}, y={y}");
            }
        }
    }

    /// <summary>
    /// The fold matrix beyond the right-deciding collapse: left-deciding constants skip the
    /// right operand at build time; neutral constants reduce to the other operand, which
    /// still evaluates (with its side effects); a null CONSTANT left merges guard-free and
    /// the right operand always runs — this define is also the committed regression test for
    /// the CS8310 shape (`null as bool?` must print legally in operator position).
    /// </summary>
    [TestMethod]
    public void ConstantFoldMatrix_SkipsAndKeepsTheRightOperands()
    {
        var (r1, m1) = RunCountingMessages(Library.FalseConstAndMessage);
        Assert.AreEqual(false, r1);
        Assert.AreEqual(0, m1, "false-and folds at build time; the right operand must not be evaluated.");

        var (r2, m2) = RunCountingMessages(Library.TrueConstOrMessage);
        Assert.AreEqual(true, r2);
        Assert.AreEqual(0, m2, "true-or folds at build time; the right operand must not be evaluated.");

        var (r3, m3) = RunCountingMessages(Library.AndTrueKeepsLeft);
        Assert.AreEqual(true, r3);
        Assert.AreEqual(1, m3, "X and true reduces to X; X must still be evaluated.");

        var (r4, m4) = RunCountingMessages(Library.OrFalseKeepsLeft);
        Assert.AreEqual(true, r4);
        Assert.AreEqual(1, m4, "X or false reduces to X; X must still be evaluated.");

        var (r5, m5) = RunCountingMessages(Library.NullConstAndMessage);
        Assert.IsNull(r5); // null and true = null
        Assert.AreEqual(1, m5, "a null constant left decides nothing; the right operand must be evaluated.");

        Assert.IsNull(Library.NotNullConst(Context()));
    }

    /// <summary>CQL's without clause lowers through the same not-lowering (lifted !).</summary>
    [TestMethod]
    public void WithoutClause_EvaluatesCorrectly()
    {
        Assert.AreEqual(true, Library.WithoutClause(Context()));
    }

    #endregion

    /// <summary>
    /// The short-circuited path must not allocate — that is its advantage over the
    /// <c>Lazy&lt;bool?&gt;</c> overloads, which cost a Lazy plus a closure per operand
    /// (#1514). <c>GuardedAnd</c> is a function (not memoized), called directly with a
    /// deciding left operand, so every iteration takes the skip path.
    /// </summary>
    [TestMethod]
    public void SkippedPath_DoesNotAllocate()
    {
        var context = Context();

        // Warm up: JIT the path and let the context's lazy internals settle.
        for (var i = 0; i < 100; i++)
            Library.GuardedAnd(context, false);

        var before = GC.GetAllocatedBytesForCurrentThread();
        for (var i = 0; i < 1_000; i++)
            Library.GuardedAnd(context, false);
        var allocated = GC.GetAllocatedBytesForCurrentThread() - before;

        // Sub-1-byte-per-iteration bound rather than exactly 0: the invariant is that the
        // SKIP PATH allocates nothing per call; an exact-0 assert would also fail on any
        // single runtime-internal allocation landing on this thread (tiering, instrumented
        // collectors), which is not a regression in the generated code.
        Assert.IsTrue(allocated < 1_000, $"the skip path of a short-circuited 'and' must not allocate (measured {allocated} bytes over 1000 calls).");
    }

    /// <summary>
    /// The results above would still hold if the guard stopped firing and plain merges were
    /// emitted, so this pins the emitted shape: regenerating the fixture's C# from its ELM
    /// must produce the origin-tagged guards and native operators, and no
    /// <c>ICqlOperators</c> calls for and/or/not.
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_UsesGuardedNativeOperators()
    {
        var generated = GenerateFixtureCSharp(ElmToolkitConfig.Default);

        StringAssert.Contains(generated, "// CQL 'and' (", "Expected origin-tagged 'and' guards.");
        StringAssert.Contains(generated, "/* CQL 'and' (", "Expected the inline-ternary guard form (AndNotY) with its block-comment tag.");
        StringAssert.Contains(generated, "// CQL 'or' (", "Expected origin-tagged 'or' guards.");
        StringAssert.Contains(generated, "right operand skipped when left is false", "Expected the 'and' guard explanation.");
        StringAssert.Contains(generated, "right operand skipped when left is true", "Expected the 'or' guard explanation.");

        foreach (var call in new[] { "Operators.And(", "Operators.Or(", "Operators.Not(" })
            Assert.IsFalse(generated.Contains(call), $"{call} call survived; and/or/not must lower to native operators.");

        // No Lazy-based short-circuiting either — the guard replaces it allocation-free.
        Assert.IsFalse(generated.Contains("Lazy<"), "A Lazy-based operand survived; the guard form must not allocate.");
    }

    /// <summary>
    /// An emitted guard is always an <c>if</c>/<c>else</c> chain — in tail position (every
    /// branch returns, as in the truth-table defines) as well as in assign form (the branches
    /// assign a result local, like the guard inside <c>GuardInConditionalTest</c> that produces
    /// a value for an if-test). There is no guard-clause variant: the assign form needs the
    /// <c>else</c> to guarantee exactly one branch runs, and the tail form matches it.
    /// <para>Both assertions match the guard's OWN <c>if</c>/<c>else</c>, anchored on its origin
    /// comment. Counting <c>else</c> keywords over the whole method cannot fail here: the
    /// assign-form fixture also contains the CQL <c>if</c>'s own else, which would keep the
    /// count above zero even if the guard stopped emitting one.</para>
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_GuardChainsKeepElseBlocks()
    {
        var generated = GenerateFixtureCSharp(ElmToolkitConfig.Default);

        StringAssert.Matches(
            ExtractComputeMethod(generated, "TrueAndTrue_Compute"),
            GuardFollowedByElse("return false;"),
            "A tail-position guard must keep its else block.");

        StringAssert.Matches(
            ExtractComputeMethod(generated, "GuardInConditionalTest_Compute"),
            GuardFollowedByElse(@"\w+ = false;"),
            "An assign-form guard must keep its else block.");
    }

    /// <summary>The guard's own if/else: origin comment, <c>if (x is false)</c>, the deciding
    /// branch (<paramref name="decidingStatement"/>), its closing brace, then <c>else</c>.</summary>
    private static System.Text.RegularExpressions.Regex GuardFollowedByElse(string decidingStatement) =>
        new($@"// CQL 'and' \([^)]*\): right operand skipped when left is false\s*\r?\n\s*if \(\w+ is false\)\s*\r?\n\s*\{{\s*\r?\n\s*{decidingStatement}\s*\r?\n\s*\}}\s*\r?\n\s*else\b");

    private static string ExtractComputeMethod(string code, string methodName)
    {
        // Anchor on the DEFINITION ("name(") — the GetOrCompute wrapper references the method
        // as a bare method group ("name)"), which a plain IndexOf(name) would find first and
        // widen the slice over the wrapper and cache field.
        var start = code.IndexOf(methodName + "(", StringComparison.Ordinal);
        Assert.IsTrue(start >= 0, $"Method {methodName} not found in generated code.");
        var end = code.IndexOf("[CqlExpressionDefinition", start, StringComparison.Ordinal);
        return end < 0 ? code[start..] : code[start..end];
    }

    /// <summary>
    /// <see cref="ElmToolkitConfig.CSharpNamespace"/> wraps the generated code in that
    /// namespace; null (the default) and empty (what a JSON <c>null</c> binds to — the JSON
    /// configuration provider has no null) both produce namespace-less code.
    /// </summary>
    [TestMethod]
    public void CSharpNamespace_WrapsGeneratedCode()
    {
        StringAssert.Contains(
            GenerateFixtureCSharp(new ElmToolkitConfig(CSharpNamespace: "My.Ns")),
            "namespace My.Ns;", "a namespace set in the config must be emitted.");

        Assert.IsFalse(
            GenerateFixtureCSharp(ElmToolkitConfig.Default).Contains("namespace "),
            "the default (null) must emit namespace-less code.");

        Assert.IsFalse(
            GenerateFixtureCSharp(new ElmToolkitConfig(CSharpNamespace: "")).Contains("namespace "),
            "an empty value (JSON null binds as \"\") must emit namespace-less code.");
    }

    private static string GenerateFixtureCSharp(ElmToolkitConfig config)
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "ShortCircuitLogicTest", "1.0.0");

        return new ElmToolkit(config: config)
            .AddElmLibraries(librarySet)
            .CompileToAssemblies()
            .GetElmToCSharpResults()
            .Single()
            .cSharp;
    }
}
