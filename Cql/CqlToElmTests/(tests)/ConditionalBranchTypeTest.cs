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
