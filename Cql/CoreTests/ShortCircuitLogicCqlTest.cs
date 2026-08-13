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

        for (var l = 0; l < 3; l++)
        {
            for (var r = 0; r < 3; r++)
            {
                Assert.AreEqual(ops.And(values[l], values[r]), generatedAnd[l, r](Context()), $"and: left={values[l]}, right={values[r]}");
                Assert.AreEqual(ops.Or(values[l], values[r]), generatedOr[l, r](Context()), $"or: left={values[l]}, right={values[r]}");
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

        Assert.AreEqual(0, allocated, "the skip path of a short-circuited 'and' must not allocate.");
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
        StringAssert.Contains(generated, "// CQL 'or' (", "Expected origin-tagged 'or' guards.");
        StringAssert.Contains(generated, "right operand skipped when left is false", "Expected the 'and' guard explanation.");
        StringAssert.Contains(generated, "right operand skipped when left is true", "Expected the 'or' guard explanation.");

        foreach (var call in new[] { "Operators.And(", "Operators.Or(", "Operators.Not(" })
            Assert.IsFalse(generated.Contains(call), $"{call} call survived; and/or/not must lower to native operators.");

        // No Lazy-based short-circuiting either — the guard replaces it allocation-free.
        Assert.IsFalse(generated.Contains("Lazy<"), "A Lazy-based operand survived; the guard form must not allocate.");
    }

    /// <summary>
    /// <see cref="ElmToolkitConfig.CSharpPreferFlattenElseBlocks"/> flattens tail-position
    /// chains to guard-clause style. This fixture's only conditionals are the short-circuit
    /// guards, so with the option on the output contains no <c>else</c> at all; the default
    /// keeps the <c>else</c> chains. Formatting only — both variants must compile (both go
    /// through <c>CompileToAssemblies</c>).
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_PreferFlattenElseBlocks_FlattensTailChains()
    {
        var withElse = GenerateFixtureCSharp(ElmToolkitConfig.Default);
        StringAssert.Contains(withElse, "else", "The default must keep else blocks.");

        var flattened = GenerateFixtureCSharp(ElmToolkitConfig.Default with { CSharpPreferFlattenElseBlocks = true });
        Assert.IsFalse(flattened.Contains("else"), "With CSharpPreferFlattenElseBlocks, every tail-position chain must print guard-clause style.");
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
