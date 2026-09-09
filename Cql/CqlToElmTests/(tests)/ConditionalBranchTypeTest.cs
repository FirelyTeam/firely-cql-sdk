/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// How an <c>if</c> / <c>else if</c> chain reconciles branches whose types differ.
    /// </summary>
    /// <remarks>
    /// The invariant these pin is that reconciliation only ever <em>widens</em>. Typing the whole
    /// chain as one branch's type means every other branch is cast down to it, and for tuple lists
    /// - lowered to nullable value tuples by the C# generator - such a cast is null at run time,
    /// with no error and no warning (see #1594). Evaluating the chain end to end is the assertion
    /// that actually catches that: the ELM could carry the right result type while the emitted cast
    /// still discards the value.
    /// </remarks>
    [TestClass]
    public class ConditionalBranchTypeTest : Base
    {
        private const string DivergentTupleListsCql = """
            library TupleChoice version '1.0.0'

            define function MakeA(x String): Tuple{ kind: 'a', value: x }
            define function MakeB(x String): Tuple{ kind: 'b', value: x, extra: { Tuple{ note: x } } }

            define "Selector": {0}

            define "Result":
              if Selector = 1 then { MakeA('one') }
              else if Selector = 2 then { MakeB('two') }
              else if Selector = 3 then { MakeA('three') }
              else null
            """;

        [TestMethod]
        public void DivergentTupleLists_ChainIsTypedAsTheChoice_NotTheFirstBranch()
        {
            var library = CreateCqlToolkit().MakeLibrary(DivergentTupleListsCql.Replace("{0}", "2"));
            var result = library.statements!.Single(s => s.name == "Result").expression!;

            // Typing the chain as List<Tuple{kind,value}> - the first branch - is the defect: it
            // makes the MakeB branch an As down to a type it can never be.
            result.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>(
                "a chain whose branches have no common type is typed as the choice of them, never as one of them.");

            var alternatives = ((ChoiceTypeSpecifier)result.resultTypeSpecifier!).choice!;
            alternatives.Should().HaveCount(2, "the two distinct branch list types, listed once each.");
            alternatives.Should().AllBeOfType<ListTypeSpecifier>();
        }

        [TestMethod]
        [DataRow(1, "one", DisplayName = "first branch")]
        [DataRow(2, "two", DisplayName = "divergent branch")]
        [DataRow(3, "three", DisplayName = "later branch of the first type")]
        public void DivergentTupleLists_EveryBranchReturnsItsList(int selector, string expectedValue)
        {
            var result = Evaluate(DivergentTupleListsCql.Replace("{0}", selector.ToString()), "Result");

            Assert.IsNotNull(result, $"branch {selector} must return its list, not null.");
            var items = ((System.Collections.IEnumerable)result).Cast<object?>().ToList();
            Assert.AreEqual(1, items.Count, "each branch builds a one-element list.");
            Assert.IsNotNull(items[0]);
            StringAssert.Contains(items[0]!.ToString(), expectedValue);
        }

        [TestMethod]
        public void DivergentTupleLists_BranchOrderDoesNotDecideWhichBranchWorks()
        {
            // The defect was order-sensitive: the chain took its type from the first branch, so
            // every later branch of a different type was cast down to it. Reversing which type
            // comes first must therefore change nothing. The middle branch is the one selected
            // here, because the branches after the first are what form the inner choice that the
            // first branch's type then narrowed.
            const string reordered = """
                library TupleChoiceReordered version '1.0.0'

                define function MakeA(x String): Tuple{ kind: 'a', value: x }
                define function MakeB(x String): Tuple{ kind: 'b', value: x, extra: { Tuple{ note: x } } }

                define "Selector": 2

                define "Result":
                  if Selector = 1 then { MakeB('one') }
                  else if Selector = 2 then { MakeA('two') }
                  else if Selector = 3 then { MakeB('three') }
                  else null
                """;

            var result = Evaluate(reordered, "Result");

            Assert.IsNotNull(result, "a MakeA branch must survive a chain whose first branch is MakeB.");
            var items = ((System.Collections.IEnumerable)result).Cast<object?>().ToList();
            Assert.AreEqual(1, items.Count);
            StringAssert.Contains(items[0]!.ToString(), "two");
        }

        [TestMethod]
        public void AnyTypedElseBranch_DoesNotWidenTheThenBranchToAny()
        {
            // Regression test for #1601. An else branch typed Any - here, a call the translator
            // could not resolve to anything more specific than Any, the same outcome an
            // AllowUnresolvedExternals call or a Message(null, ...) source produces - used to
            // reconcile by the general cost-based path below, which measured coercing the Boolean
            // then branch *up* to Any as cheaper than coercing the Any else branch down to Boolean,
            // and picked it. That silently widened an otherwise-Boolean conditional to Any; anywhere
            // that conditional fed a lambda expecting bool? (a such that clause, for instance -
            // see QueryTest.SuchThat_WithAnyTypedElseBranch_TypesAsBoolean), Cql.Compiler's binder
            // then had no Func<T, object> overload to bind to.
            //
            // An Any-typed branch has no static type of its own to contribute, on either side - see
            // AnyTypedThenBranch_DoesNotWidenTheElseBranchToAny for the exact mirror, and
            // IfAndCase_AgreeOnAnyTypedBranchHandling for why this must be symmetric.
            var library = CreateCqlToolkit().MakeLibrary("""
                library ReproIf version '1.0.0'

                define function "Error"(message String): Message(null, true, 'E1', 'Error', message)

                define "IfElseAny": if true then true else "Error"('not supported')
                """);

            var ifExpression = library.ShouldDefine<ExpressionDef>("IfElseAny").expression!;
            ifExpression.resultTypeSpecifier.Should().Be(
                SystemTypes.BooleanType,
                "the then branch's static type must govern when the else branch is Any-typed, per the CQL specification's If semantics.");
        }

        [TestMethod]
        public void AnyTypedThenBranch_DoesNotWidenTheElseBranchToAny()
        {
            // The exact mirror of AnyTypedElseBranch_DoesNotWidenTheThenBranchToAny, and the case
            // that stayed broken after the first fix for #1601 handled only the else side: a
            // then branch typed Any fell through to the same cost-based reconciliation, which
            // preferred widening the Boolean else branch *up* to Any (a cheap Subtype coercion) over
            // casting the Any then branch down (a costlier MoreCompatible coercion), so the whole
            // conditional stayed typed Any. See IfAndCase_AgreeOnAnyTypedBranchHandling for why an
            // Any-typed branch on either side must reconcile the same way.
            var library = CreateCqlToolkit().MakeLibrary("""
                library ReproIfThenAny version '1.0.0'

                define function "Error"(message String): Message(null, true, 'E1', 'Error', message)

                define "IfThenAny": if true then "Error"('not supported') else true
                """);

            var ifExpression = library.ShouldDefine<ExpressionDef>("IfThenAny").expression!;
            ifExpression.resultTypeSpecifier.Should().Be(
                SystemTypes.BooleanType,
                "the else branch's static type must govern when the then branch is Any-typed, exactly as the mirror case already requires of the else branch.");
        }

        [TestMethod]
        public void IfAndCase_AgreeOnAnyTypedBranchHandling()
        {
            // Pinned since #1595 ("if behaves the way case already did") as an explicit invariant:
            // If and Case must not diverge on how they treat an Any-typed branch, regardless of
            // which branch carries it or which construct is used. Case already resolves this
            // symmetrically - VisitCaseExpressionTerm drops Any from the set of branch result types
            // regardless of which branch(es) it came from - so If reconciling asymmetrically (only
            // one side generalized past a literal null) would make the two constructs disagree about
            // the exact same CQL shape translated two different ways.
            //
            // A function declared `returns Any` (FunctionDefinitionTest.OptionalReturnTypesMayBeSupertype)
            // is statically Any at every call site regardless of what its body evaluates to, so using
            // one in a branch here means that branch's real value gets cast down to the other
            // branch's type if that one wins - true for Case today already, so If doing the same is
            // consistency with existing behavior, not a new class of defect. (The Java reference
            // translator instead honors what the body evaluates to rather than the Any declaration;
            // that divergence is a separate concern from whether If and Case agree with each other.)
            const string cql = """
                library IfCaseParity version '1.0.0'

                define function "Error"(message String): Message(null, true, 'E1', 'Error', message)

                define "IfThenAny": if true then "Error"('not supported') else true
                define "IfElseAny": if true then true else "Error"('not supported')
                define "CaseThenAny": case when true then "Error"('not supported') else true end
                define "CaseElseAny": case when true then true else "Error"('not supported') end
                """;

            var library = CreateCqlToolkit().MakeLibrary(cql);
            foreach (var name in new[] { "IfThenAny", "IfElseAny", "CaseThenAny", "CaseElseAny" })
            {
                library.ShouldDefine<ExpressionDef>(name).expression!.resultTypeSpecifier.Should().Be(
                    SystemTypes.BooleanType,
                    $"{name} must type as Boolean - If and Case must agree on Any-branch handling regardless of which branch carries Any or which construct is used.");
            }
        }

        [TestMethod]
        public void PartiallyOverlappingChoiceBranches_UnionTheAlternatives()
        {
            // Both branches are already choices, overlapping only in String. CanBeCast is satisfied
            // by a *single* alternative matching, so casting either branch to the other's type is a
            // Cast that drops an alternative - Integer one way, Boolean the other. Neither pair
            // collapses on its own (Integer/String and String/Boolean have no common type), which is
            // what keeps the two choices intact for the outer chain to reconcile.
            var library = CreateCqlToolkit().MakeLibraryFromExpression(
                "if true then (if true then 1 else 'a') else (if true then 'a' else true)");
            var @if = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();

            var choice = @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>().Subject;
            choice.choice.Should().BeEquivalentTo(
                new TypeSpecifier[] { SystemTypes.IntegerType, SystemTypes.StringType, SystemTypes.BooleanType },
                "no alternative reachable from either branch may be dropped, and String - common to both - is listed once.");
        }

        [TestMethod]
        public void ChoiceBranchesOverlappingByConversion_StillUnionTheAlternatives()
        {
            // Integer converts implicitly to Decimal, so the two branch types look coercible - but
            // the coercion being weighed is a Cast, answered with a single As over the whole choice.
            // That As is a type test: it does not convert the Integer to a Decimal, it discards it.
            // An implicit conversion is therefore not evidence that an alternative survives, and
            // this chain must widen to all three rather than casting one choice to the other.
            var library = CreateCqlToolkit().MakeLibraryFromExpression(
                "if true then (if true then 1 else 'a') else (if true then 2.0 else 'a')");
            var @if = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();

            var choice = @if.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>().Subject;
            choice.choice.Should().BeEquivalentTo(
                new TypeSpecifier[] { SystemTypes.IntegerType, SystemTypes.StringType, SystemTypes.DecimalType },
                "Integer is not covered by Choice<Decimal|String> under a cast, so it has to stay in the union.");
        }

        [TestMethod]
        public void DivergentTupleLists_InACase_AlreadyWidensToTheChoice()
        {
            // `case` is the reference behavior the `if` chain above was brought in line with: its
            // branches are coerced *into* the choice rather than one of them being cast down to
            // another, so the divergent branch's list survives. Pinned so a future change to
            // conditional typing cannot regress `case` while leaving `if` correct.
            const string caseCql = """
                library CaseTupleChoice version '1.0.0'

                define function MakeA(x String): Tuple{ kind: 'a', value: x }
                define function MakeB(x String): Tuple{ kind: 'b', value: x, extra: { Tuple{ note: x } } }

                define "Selector": 2

                define "Result":
                  case
                    when Selector = 1 then { MakeA('one') }
                    when Selector = 2 then { MakeB('two') }
                    else { MakeA('fallback') }
                  end
                """;

            var library = CreateCqlToolkit().MakeLibrary(caseCql);
            var caseExpression = library.statements!.Single(s => s.name == "Result").expression!;
            caseExpression.resultTypeSpecifier.Should().BeOfType<ChoiceTypeSpecifier>();

            var result = Evaluate(caseCql, "Result");

            Assert.IsNotNull(result, "the divergent case branch must return its list.");
            var items = ((System.Collections.IEnumerable)result).Cast<object?>().ToList();
            Assert.AreEqual(1, items.Count);
            StringAssert.Contains(items[0]!.ToString(), "two");
        }

        /// <summary>
        /// Compiles <paramref name="cql"/> the whole way to an assembly and invokes
        /// <paramref name="definition"/>, returning its value. Evaluating rather than inspecting the
        /// ELM is deliberate: the ELM can carry the right result type while the emitted cast still
        /// discards the value.
        /// </summary>
        private static object? Evaluate(string cql, string definition)
        {
            var library = CreateCqlToolkit().MakeLibrary(cql);
            var elmToolkit = CreateElmToolkit();
            var definitions = elmToolkit.ProcessLibrary(library);
            LibrarySet librarySet = new("ConditionalBranchTypeTest", library);

            var generated = elmToolkit
                .GetLibrarySetCSharpCodeGenerator()
                .GenerateEachLibraryToCSharp(librarySet, definitions)
                .ToList();

            var compiled = elmToolkit
                .GetAssemblyCompiler()
                .CompileEachLibraryToAssemblies(generated, librarySet, elmToolkit.Config.DebugSymbolsFormat)
                .ToList();

            using var invoker = new InvocationToolkit()
                .AddAssemblyBinaries(AssemblyBinary.Default with { AssemblyBytes = compiled.Single().assemblyBinaryWithSourceCode.AssemblyBytes })
                .CreateLibrarySetInvoker();

            return invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), library.VersionedLibraryIdentifier, definition);
        }
    }
}
