using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.AllowNullIntervals = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Starts_Properly_Within_Start()
        {
            var library = MakeLibrary(@"
                library InTest version '1.0.0'

                define private Starts_Properly_Within_Start: Interval[@2023, @2030] starts properly within 1 year of start Interval[@2022, @2030]
            ");
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
            var library = MakeLibrary(@"
                library InTest version '1.0.0'

                define f: Interval[@2023, @2030] starts within 1 year of start Interval[@2022, @2030]
            ");
            library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
        }


        [TestMethod]
        public void Properly_Within_Start()
        {
            var library = MakeLibrary(@"
                library InTest version '1.0.0'

                define private Properly_Within_Start: Interval[@2023, @2030] properly within 1 year of start Interval[@2022, @2030]
            ");
            var @in = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
        }

        [TestMethod]
        public void TestInNullBoundaries()
        {
            var lib = CreateLibraryForExpression("5 in Interval[null as Integer, null as Integer]");
            var @in = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
            var result = Run<bool?>(@in, lib);
            Assert.IsFalse(result);
        }

        public void NullContains5()
        {
            var lib = CreateLibraryForExpression("null contains 5");
            var @in = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Contains>();
        }

        [TestMethod]
        public void Starts_Within_PointInterval()
        {
            var library = MakeLibrary(@"
                library InTest version '1.0.0'

                define f:
                    Interval[@2024-07-23, @2024-07-30] starts within 1 day of end of Interval[@2024-07-17, @2024-07-24]
            ");
            library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
        }
    }
}
