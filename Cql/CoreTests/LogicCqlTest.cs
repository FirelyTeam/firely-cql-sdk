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
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// End-to-end coverage for the native lowering of CQL's logical and nullological operators
/// (issue #1514): CQL in <c>Input/ELM/HL7/LogicTest.cql</c> whose generated C# contains the
/// lowered form, executed here for its real results. Covers <c>and</c>, <c>or</c>, <c>not</c>,
/// <c>implies</c> and <c>xor</c> — the four of those that short-circuit, plus <c>not</c> — and
/// the <c>IsTrue</c>/<c>IsFalse</c> patterns, which lower natively but have nothing to skip.
///
/// <para>The truth-table tests pin CQL's three-valued logic (spec §9.B) through generated
/// code rather than through <c>ICqlOperators</c> directly — the operands are expression refs,
/// so every combination goes through the guard. The Message tests are the observable evidence
/// that the right operand is skipped exactly when the left operand decides the result, and each
/// operator decides on a different value: <c>false</c> for <c>and</c> and <c>implies</c>,
/// <c>true</c> for <c>or</c>, and <c>null</c> for <c>xor</c> — the only one where null decides.
/// For and/or/implies a null left operand must NOT skip (<c>null and false</c> is <c>false</c>,
/// <c>null implies true</c> is <c>true</c>), and for xor neither bool value may skip
/// (<c>false xor X</c> is <c>X</c>).</para>
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class LogicCqlTest
{
    private static LogicTest_1_0_0 Library => LogicTest_1_0_0.Instance;

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
    /// <c>xor</c> is the odd one out: its NULL row is constant ("if either or both arguments are
    /// null, the result is null"), so <see langword="null"/> is xor's deciding value where
    /// and/or/implies all decide on a bool. Neither <c>true</c> nor <c>false</c> decides — they
    /// reduce, so the right operand is still evaluated.
    /// </summary>
    [TestMethod]
    public void Xor_TruthTable()
    {
        Assert.AreEqual(false, Library.TrueXorTrue(Context()));
        Assert.AreEqual(true, Library.TrueXorFalse(Context()));
        Assert.IsNull(Library.TrueXorNull(Context()));
        Assert.AreEqual(true, Library.FalseXorTrue(Context()));
        Assert.AreEqual(false, Library.FalseXorFalse(Context()));
        Assert.IsNull(Library.FalseXorNull(Context()));
        Assert.IsNull(Library.NullXorTrue(Context()));
        Assert.IsNull(Library.NullXorFalse(Context()));
        Assert.IsNull(Library.NullXorNull(Context()));
    }

    /// <summary>
    /// <c>IsTrue</c>/<c>IsFalse</c> are total: a null argument yields <see langword="false"/>,
    /// never null. They lower to the <c>is true</c>/<c>is false</c> constant patterns.
    /// </summary>
    [TestMethod]
    public void IsTrue_IsFalse_TruthTables()
    {
        Assert.AreEqual(true, Library.IsTrueOfTrue(Context()));
        Assert.AreEqual(false, Library.IsTrueOfFalse(Context()));
        Assert.AreEqual(false, Library.IsTrueOfNull(Context()));
        Assert.AreEqual(false, Library.IsFalseOfTrue(Context()));
        Assert.AreEqual(true, Library.IsFalseOfFalse(Context()));
        Assert.AreEqual(false, Library.IsFalseOfNull(Context()));
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
        var generatedXor = new Func<CqlContext, bool?>[,]
        {
            { Library.TrueXorTrue, Library.TrueXorFalse, Library.TrueXorNull },
            { Library.FalseXorTrue, Library.FalseXorFalse, Library.FalseXorNull },
            { Library.NullXorTrue, Library.NullXorFalse, Library.NullXorNull },
        };

        for (var l = 0; l < 3; l++)
        {
            for (var r = 0; r < 3; r++)
            {
                Assert.AreEqual(ops.And(values[l], values[r]), generatedAnd[l, r](Context()), $"and: left={values[l]}, right={values[r]}");
                Assert.AreEqual(ops.Or(values[l], values[r]), generatedOr[l, r](Context()), $"or: left={values[l]}, right={values[r]}");
                Assert.AreEqual(ops.Implies(values[l], values[r]), generatedImplies[l, r](Context()), $"implies: left={values[l]}, right={values[r]}");
                Assert.AreEqual(ops.Xor(values[l], values[r]), generatedXor[l, r](Context()), $"xor: left={values[l]}, right={values[r]}");
            }
        }

        var generatedIsTrue = new[] { Library.IsTrueOfTrue, Library.IsTrueOfFalse, Library.IsTrueOfNull };
        var generatedIsFalse = new[] { Library.IsFalseOfTrue, Library.IsFalseOfFalse, Library.IsFalseOfNull };
        for (var i = 0; i < 3; i++)
        {
            Assert.AreEqual(ops.IsTrue(values[i]), generatedIsTrue[i](Context()), $"IsTrue: {values[i]}");
            Assert.AreEqual(ops.IsFalse(values[i]), generatedIsFalse[i](Context()), $"IsFalse: {values[i]}");
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
            if (e.Code == "LogicTest.RightEvaluated")
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

    [TestMethod]
    public void NullXorMessage_SkipsRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.NullXorMessage);
        Assert.IsNull(result); // null xor X is null for every X
        Assert.AreEqual(0, messages, "null decides 'xor'; the right operand must not be evaluated.");
    }

    [TestMethod]
    public void TrueXorMessage_EvaluatesRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.TrueXorMessage);
        Assert.AreEqual(false, result); // true xor true = false
        Assert.AreEqual(1, messages, "true does NOT decide 'xor' (true xor X is not X); the right operand must be evaluated.");
    }

    [TestMethod]
    public void FalseXorMessage_EvaluatesRightOperand()
    {
        var (result, messages) = RunCountingMessages(Library.FalseXorMessage);
        Assert.AreEqual(true, result); // false xor true = true
        Assert.AreEqual(1, messages, "false does NOT decide 'xor' (false xor X is X); the right operand must be evaluated.");
    }

    /// <summary>
    /// A null CONSTANT on either side of <c>xor</c> makes the whole expression null at build
    /// time, erasing the other operand and its side effects — the xor analogue of
    /// <c>X and false</c>.
    /// </summary>
    [TestMethod]
    public void XorNullConstant_CollapsesAndErasesTheOtherOperand()
    {
        var (result, messages) = RunCountingMessages(Library.XorNullConstCollapses);
        Assert.IsNull(result);
        Assert.AreEqual(0, messages, "X xor null folds to null at build time; X must not be evaluated.");
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
            if (e.Code == "LogicTest.RightEvaluated")
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
    /// <c>ICqlOperators</c> calls for any of the lowered operators.
    /// <para>Every one of the seven needs its own absent-call assertion, because the value tests
    /// cannot detect a regression to the runtime operator: they compare against that very
    /// operator, so identical values prove nothing about which code ran. For the total predicates
    /// (<c>IsTrue</c>/<c>IsFalse</c>) there is not even a Message test to notice, since a total
    /// predicate skips nothing.</para>
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_UsesGuardedNativeOperators()
    {
        var generated = LogicTestFixture.DefaultCSharp;

        // and/or/implies short-circuit as EXPRESSIONS over CqlBoolean, so their tags are inline
        // block comments and there is no guard statement to find.
        // Line-spanning: the operator leads its own continuation line, so these patterns must
        // cross a newline (hence [\s\S] rather than .).
        StringAssert.Matches(
            generated,
            new System.Text.RegularExpressions.Regex(@"/\* CQL 'and' \([^)]*\) \*/ &&"),
            "Expected 'and' to lower to a CqlBoolean && expression carrying its origin tag.");
        StringAssert.Matches(
            generated,
            new System.Text.RegularExpressions.Regex(@"/\* CQL 'or' \([^)]*\) \*/ \|\|"),
            "Expected 'or' to lower to a CqlBoolean || expression carrying its origin tag.");
        StringAssert.Matches(
            generated,
            new System.Text.RegularExpressions.Regex(@"!\w+\s*\r?\n\s*/\* CQL 'implies' \([^)]*\) \*/ \|\|"),
            "Expected 'implies' to lower to !left || right over CqlBoolean.");
        // Boolean locals are DECLARED CqlBoolean, which is what removes the per-operand conversions
        // — so the type's presence is pinned on the declaration, not on a cast.
        StringAssert.Matches(
            generated,
            new System.Text.RegularExpressions.Regex(@"\bCqlBoolean \w+_ = "),
            "Expected boolean locals to be declared CqlBoolean.");

        // xor keeps the branching guard: its deciding value is null, and C# has no ^^ to
        // short-circuit with.
        StringAssert.Contains(generated, "// CQL 'xor' (", "Expected origin-tagged 'xor' guards.");
        StringAssert.Contains(generated, "/* CQL 'is true' (", "Expected the 'is true' pattern's inline origin tag.");
        StringAssert.Contains(generated, "/* CQL 'is false' (", "Expected the 'is false' pattern's inline origin tag.");
        // Only xor still carries the "…skipped when…" detail: it explains branching control flow,
        // and xor is the only operator that still emits any. and/or/implies short-circuit as
        // expressions, where the inline tag alone is the traceability.
        StringAssert.Contains(generated, "right operand skipped when left is null", "Expected the 'xor' guard explanation — null is xor's deciding value.");
        Assert.IsFalse(
            generated.Contains("right operand skipped when left is false"),
            "and/implies no longer branch, so the guard explanation must be gone with the guard.");

        // The native forms themselves, so a regression to an operator call cannot hide behind a
        // surviving origin comment. Anchored on the tag immediately followed by the pattern:
        // a bare " is true)" would also match every `or` guard's own test, and " is false)" every
        // `and`/`implies` guard's, which is most of the fixture.
        // IsTrue/IsFalse ARE the `is true`/`is false` patterns, asked on the CqlBoolean itself so the
        // value never leaves the type to be tested — a struct has no constant pattern anyway (CS9135).
        StringAssert.Matches(
            generated,
            new System.Text.RegularExpressions.Regex(@"/\* CQL 'is true' \([^)]*\) \*/ \w+\.IsTrue"),
            "Expected 'is true' to lower to IsTrue on its operand.");
        StringAssert.Matches(
            generated,
            new System.Text.RegularExpressions.Regex(@"/\* CQL 'is false' \([^)]*\) \*/ \w+\.IsFalse"),
            "Expected 'is false' to lower to IsFalse on its operand.");
        StringAssert.Matches(
            generated,
            new System.Text.RegularExpressions.Regex(@"\w+ \^ \w+"),
            "Expected xor to lower to the lifted ^ operator over two operands.");

        foreach (var call in new[]
                 {
                     "Operators.And(", "Operators.Or(", "Operators.Not(",
                     "Operators.Implies(", "Operators.Xor(", "Operators.IsTrue(", "Operators.IsFalse(",
                 })
        {
            Assert.IsFalse(generated.Contains(call), $"{call} call survived; it must lower to a native operator or pattern.");
        }

        // No Lazy-based short-circuiting either — the guard replaces it allocation-free.
        Assert.IsFalse(generated.Contains("Lazy<"), "A Lazy-based operand survived; the guard form must not allocate.");
    }

    /// <summary>
    /// and/or/implies no longer emit ANY branching: over <c>CqlBoolean</c> they are expressions, so
    /// a guard statement in one of their methods would mean the expression form had regressed.
    /// <c>xor</c> is the exception and keeps its <c>if</c>/<c>else</c> — its deciding value is
    /// <see langword="null"/> and C# has no <c>^^</c> to short-circuit with — so it is pinned here
    /// as the one remaining guarded operator.
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_ShortCircuitsAsExpressions_ExceptXor()
    {
        var generated = LogicTestFixture.DefaultCSharp;

        foreach (var method in new[] { "TrueAndTrue_Compute", "TrueOrTrue_Compute", "NullImpliesTrue_Compute" })
        {
            var body = ExtractComputeMethod(generated, method);
            StringAssert.Matches(
                body,
                new System.Text.RegularExpressions.Regex(@"\bCqlBoolean \w+_ = "),
                $"{method} must lower through CqlBoolean, declared on the local.");
            Assert.IsFalse(
                body.Contains("if ("),
                $"{method} must short-circuit as an expression; a guard statement means the expression form regressed.");
        }

        // xor's guard: origin comment naming null as the deciding value, the null test, the
        // deciding branch, then else. The test is `x.IsNull` rather than `x is null`, because a
        // CqlBoolean is a non-nullable struct and has no null pattern (CS9135).
        StringAssert.Matches(
            ExtractComputeMethod(generated, "NullXorMessage_Compute"),
            new System.Text.RegularExpressions.Regex(
                @"// CQL 'xor' \([^)]*\): right operand skipped when left is null\s*\r?\n\s*if \(\w+\.IsNull\)\s*\r?\n\s*\{\s*\r?\n\s*return null as bool\?;\s*\r?\n\s*\}\s*\r?\n\s*else\b"),
            "xor must keep its branching guard, since null is its deciding value and C# has no ^^.");
    }

    /// <summary>
    /// A <c>bool?</c>-declared body does not re-cast its <see cref="CqlBoolean"/> result: the
    /// conversion is implicit at the <c>return</c>, so <c>return (bool?)(…)</c> at the root is
    /// pure noise and must not come back.
    ///
    /// <para>Pinned at BOTH levels, because they are separate emitter paths that regressed
    /// independently while this was built: a definition body
    /// (<c>EmitBodyBlock</c>/<c>TryEmitExpressionBody</c>) and a hoisted local function
    /// (<c>HoistLocalFunction</c>). Correctness is already guaranteed by the corpus compiling
    /// at all — this only guards the readability, which nothing else would catch.</para>
    ///
    /// <para>The complementary half — that the conversion SURVIVES where it is load-bearing —
    /// is what <c>NullXorMessage_Compute</c> above still asserts via its <c>?? false</c> guard.</para>
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_DoesNotReCastCqlBooleanAtBodyRoot()
    {
        var generated = LogicTestFixture.DefaultCSharp;

        foreach (var method in new[] { "TrueAndTrue_Compute", "TrueOrTrue_Compute", "NullImpliesTrue_Compute" })
        {
            var body = ExtractComputeMethod(generated, method);
            StringAssert.Matches(
                body,
                new System.Text.RegularExpressions.Regex(@"\bCqlBoolean \w+_ = "),
                $"{method} must still lower through CqlBoolean.");
            Assert.IsFalse(
                body.Contains("return (bool?)("),
                $"{method} re-casts its CqlBoolean result to bool?; the root conversion is implicit at the return.");
        }

        // A local function declared bool? must likewise return its CqlBoolean body uncast. Any
        // corpus method is fine for this — it is the emitter path, not the CQL, being pinned.
        Assert.IsFalse(
            System.Text.RegularExpressions.Regex.IsMatch(generated, @"bool\? \w+_\([^)]*\)[^;]*\{[^}]*return \(bool\?\)\(/\* CQL '(and|or|implies)'"),
            "A bool?-declared local function re-casts its CqlBoolean result; the conversion is implicit at its return.");
    }

    /// <summary>
    /// Boolean locals are DECLARED <see cref="CqlBoolean"/>, so a logical chain needs no per-operand
    /// conversion on either side — the whole point of typing the locals rather than casting at each
    /// use. Neither operand of a short-circuit may carry one.
    ///
    /// <para>The three-valued questions are asked inside the type too, so the value never
    /// round-trips through <c>bool?</c> just to be tested: <c>IsTrue</c> replaces <c>?? false</c>
    /// and <c>HasValue</c> replaces the <c>is null</c> pattern, which a
    /// <see cref="CqlBoolean"/> cannot have anyway (CS9135).</para>
    ///
    /// <para>Not pinned here, because a runtime test covers it far better: a
    /// <see cref="CqlBoolean"/> local reaching an <c>object</c> parameter must be converted FIRST,
    /// since boxing carries the operand's own type and never applies a user-defined conversion.
    /// <c>CqlBooleanTest.SomethingTrueEqualsTrue_ShouldBeTrue</c> is what catches that — it threw
    /// inside the comparers when this change first landed, which is how the rule was found.</para>
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_NeedsNoPerOperandConversion()
    {
        var generated = LogicTestFixture.DefaultCSharp;

        Assert.IsFalse(
            System.Text.RegularExpressions.Regex.IsMatch(generated, @"(&&|\|\|) \(CqlBoolean\)"),
            "A right operand carries a redundant (CqlBoolean) conversion.");

        // A conversion on a LOCAL is what must be gone. It legitimately survives on two other
        // shapes, which are not locals and cannot be retyped: a method PARAMETER, whose type is
        // part of the signature and stays bool?, and an inline expression that was never hoisted.
        var localOperandConversions = System.Text.RegularExpressions.Regex.Matches(generated, @"\(\(CqlBoolean\)(\w+)\b")
            .Select(m => m.Groups[1].Value)
            .Where(name => System.Text.RegularExpressions.Regex.IsMatch(generated, $@"\bCqlBoolean {System.Text.RegularExpressions.Regex.Escape(name)} = "))
            .ToList();
        Assert.AreEqual(
            0,
            localOperandConversions.Count,
            $"A CqlBoolean-declared local still carries a conversion: {string.Join(", ", localOperandConversions)}.");

        var body = ExtractComputeMethod(generated, "TrueAndTrue_Compute");
        StringAssert.Matches(
            body,
            new System.Text.RegularExpressions.Regex(@"\bCqlBoolean (\w+_) = [\s\S]*?\1\s*\r?\n\s*/\* CQL 'and' \([^)]*\) \*/ &&"),
            "Expected a CqlBoolean local used directly as the left operand, with no conversion between them.");

        // The truthiness and null questions stay inside the type.
        StringAssert.Contains(generated, ".IsTrue", "Expected `?? false` to be asked as IsTrue on the CqlBoolean.");
        Assert.IsFalse(
            System.Text.RegularExpressions.Regex.IsMatch(generated, @"\(\(bool\?\)\w+_\) \?\? false"),
            "A CqlBoolean local is converted back to bool? just to coalesce; IsTrue answers that in the type.");
    }

    /// <summary>
    /// <c>not (X is null)</c> emits the null pattern's COMPLEMENT rather than a three-valued
    /// negation of it (#1576): <c>X is not null</c>, with no <c>(bool?)</c> lift to make the lifted
    /// <c>!</c> applicable and no <c>?? false</c> to bring the result back down. The complement is a
    /// total <see cref="bool"/> — there is no CQL Boolean anywhere in a null test — so all four
    /// conversions the old shape needed are simply unnecessary.
    ///
    /// <para>The three cases pinned here are the three that broke while this was implemented, each
    /// in its own way:</para>
    /// <list type="number">
    /// <item>the plain condition, where the emitted form is the point;</item>
    /// <item><c>(not (X is null)) implies Y</c>, where <c>implies</c> negates its left operand AGAIN
    /// and must produce <c>X is null</c> — re-negating the complement into
    /// <c>!((bool?)(X is not null))</c> is worse than what it replaced;</item>
    /// <item><c>where not (X is null)</c>, where the predicate reaches
    /// <c>ICqlOperators.Where</c> as a METHOD GROUP whose delegate conversion needs the return type
    /// to match <c>Func&lt;T, bool?&gt;</c> exactly — a <see cref="bool"/>-returning predicate does
    /// not bind at all, and the failure is a build error rather than an ugly emission.</item>
    /// </list>
    /// Generation is the assertion for (3): binding happens during it, so reaching the C# at all is
    /// what proves the predicate still binds.
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_NegatedNullTest_EmitsTheComplementPattern()
    {
        var generated = GenerateFromCql("""
            library NegatedNullTest version '1.0.0'

            define Thing: null as System.String

            define NotNull: if not (Thing is null) then 1 else 2

            define NotNullImplies: (not (Thing is null)) implies (Thing = 'x')

            define WhereNotNull: ({ Thing }) T where not (T is null)
            """);

        StringAssert.Contains(
            ExtractComputeMethod(generated, "NotNull"),
            "is not null",
            "Expected `not (X is null)` to emit the `is not null` pattern.");

        // The lift and the coalesce are what the complement makes unnecessary — neither may appear
        // anywhere in this library, whose every Boolean is a null test.
        Assert.IsFalse(
            generated.Contains("!((bool?)"),
            "A negated null test still lifts to bool? so the lifted `!` applies; the complement needs no lift.");
        Assert.IsFalse(
            generated.Contains("?? false"),
            "A negated null test is still coalesced back down; `is not null` is already a total bool.");

        // implies negates its left operand a second time, which must land back on `is null` rather
        // than negate the complement.
        var implies = ExtractComputeMethod(generated, "NotNullImplies");
        StringAssert.Contains(
            implies,
            "is null",
            "Expected `(not (X is null)) implies Y` to emit `X is null` for its negated left operand.");
        Assert.IsFalse(
            System.Text.RegularExpressions.Regex.IsMatch(implies, @"!\(*\w[^;]*is not null"),
            "implies re-negated the complement instead of folding back to the plain null test.");
    }

    /// <summary>The C# generated from inline CQL, for shape assertions that need a construct the
    /// checked-in <c>LogicTest</c> fixture does not contain.</summary>
    private static string GenerateFromCql(string cql)
    {
        var cqlToolkit = new CqlToolkit(config: new CqlToolkitConfig([CqlModel.ElmR1, CqlModel.Fhir401]))
                         .AddCqlLibraries([CqlLibraryString.Parse(cql)])
                         .TranslateToElm();

        return new ElmToolkit()
               .AddElmLibraries([cqlToolkit.GetCqlToolkitResults().First().elmLibrary])
               .CompileToAssemblies()
               .GetElmToCSharpResults()
               .Single()
               .cSharp;
    }

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

}
