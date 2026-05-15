/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InTest : Base
    {
         [TestMethod]
        public void Starts_Properly_Within_Start()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library InTest version '1.0.0'

                define private Starts_Properly_Within_Start: Interval[@2023, @2030] starts properly within 1 year of start Interval[@2022, @2030]
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
            {
                var includedIn = (In)library.statements[0].expression;
                Assert.IsFalse(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Start));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Starts_Within_Start()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library InTest version '1.0.0'

                define f: Interval[@2023, @2030] starts within 1 year of start Interval[@2022, @2030]
                """);
            library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
        }


        [TestMethod]
        public void Properly_Within_Start()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library InTest version '1.0.0'

                define private Properly_Within_Start: Interval[@2023, @2030] properly within 1 year of start Interval[@2022, @2030]
                """);
            var @in = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
        }

        [TestMethod]
        public void TestInNullBoundaries()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("5 in Interval[null as Integer, null as Integer]");
            var @in = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
            var result = Run<bool?>(@in, lib);
            Assert.IsFalse(result);
        }

        public void NullContains5()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("null contains 5");
            var @in = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Contains>();
        }

        [TestMethod]
        public void Starts_Within_PointInterval()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library InTest version '1.0.0'

                define f:
                    Interval[@2024-07-23, @2024-07-30] starts within 1 day of end of Interval[@2024-07-17, @2024-07-24]
                """);
            library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
        }

        // Integration test for the bug described in the issue: @2026-05-14 in c.onset
        // Bug 1: Date → DateTime coercion should use ToDateTime (not As)
        // Bug 2: Choice<..., Period, ...> → Interval<DateTime> should unwrap to Period and call FHIRHelpers.ToInterval
        [TestMethod]
        public void DateInFhirConditionOnset()
        {
            var library = CreateCqlToolkit().AddFHIRHelpers().MakeLibrary("""
                library Test
                using FHIR version '4.0.1'
                include FHIRHelpers version '4.0.1'

                define test:
                    from [Condition] c
                    where @2026-05-14 in c.onset
                    return c.id
                """);

            // Before the fix, the CQL-to-ELM translator would produce incorrect As nodes
            // instead of ToDateTime and FHIRHelpers.ToInterval. This test verifies the fix.
            library.GetErrors().Should().BeEmpty();

            // Locate the In expression within the query's where clause
            var testStatement = library.statements.FirstOrDefault(s => s.name == "test");
            Assert.IsNotNull(testStatement, "Expected a 'test' statement in the library");
            var query = testStatement.expression as Query;
            Assert.IsNotNull(query, $"Expected a Query but got {testStatement.expression?.GetType().Name ?? "null"}");

            Assert.IsInstanceOfType(query.where, typeof(In));
            var inExpr = (In)query.where;

            // Left operand: ToDateTime(@2026-05-14) — Bug 1 fix
            Assert.IsInstanceOfType(inExpr.operand[0], typeof(ToDateTime),
                $"Expected ToDateTime but got {inExpr.operand[0]?.GetType().Name}");

            // Right operand: FHIRHelpers.ToInterval(c.onset as FHIR.Period) — Bug 2 fix
            Assert.IsInstanceOfType(inExpr.operand[1], typeof(FunctionRef),
                $"Expected FunctionRef but got {inExpr.operand[1]?.GetType().Name}");
            var fr = (FunctionRef)inExpr.operand[1];
            Assert.AreEqual("FHIRHelpers", fr.libraryName);
            Assert.AreEqual("ToInterval", fr.name);
            Assert.AreEqual(1, fr.operand?.Length);
            Assert.IsInstanceOfType(fr.operand![0], typeof(As));
        }
    }
}