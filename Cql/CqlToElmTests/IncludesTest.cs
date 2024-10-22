using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class IncludesTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [TestMethod]
        public void Proper_Includes_Day_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Proper_Includes_Day_Start: Interval[@2023-01-01, @2023-06-30] properly includes day of start Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperContains));
            {
                var properContains = (ProperContains)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", properContains.resultTypeName.Name);
                Assert.IsInstanceOfType(properContains.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)properContains.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(properContains.operand);
                Assert.AreEqual(2, properContains.operand.Length);
                Assert.IsInstanceOfType(properContains.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(properContains.operand[1], typeof(Start));
                var result = Run(properContains, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Proper_Includes_Day_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Proper_Includes_Day_End: Interval[@2023-01-01, @2023-06-30] properly includes day of end Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperContains));
            {
                var properContains = (ProperContains)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", properContains.resultTypeName.Name);
                Assert.IsInstanceOfType(properContains.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)properContains.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(properContains.operand);
                Assert.AreEqual(2, properContains.operand.Length);
                Assert.IsInstanceOfType(properContains.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(properContains.operand[1], typeof(End));
                var result = Run(properContains, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Proper_Includes_Year()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Proper_Includes_Day_Start: Interval[@2023, @2023] properly includes year of Interval[@2023, @2023]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIncludes));
            {
                var same = (ProperIncludes)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Proper_Includes()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Proper_Includes: Interval[@2023, @2023] properly includes Interval[@2023, @2023]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIncludes));
            {
                var same = (ProperIncludes)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Includes_Day_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Includes_Day_Start: Interval[@2023-01-01, @2023-06-30] includes day of start Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Contains));
            {
                var contains = (Contains)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", contains.resultTypeName.Name);
                Assert.IsInstanceOfType(contains.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)contains.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(contains.operand);
                Assert.AreEqual(2, contains.operand.Length);
                Assert.IsInstanceOfType(contains.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(contains.operand[1], typeof(Start));
                var result = Run(contains, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Includes_Day_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Includes_Day_End: Interval[@2023-01-01, @2023-06-30] includes day of end Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Contains));
            {
                var contains = (Contains)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", contains.resultTypeName.Name);
                Assert.IsInstanceOfType(contains.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)contains.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(contains.operand);
                Assert.AreEqual(2, contains.operand.Length);
                Assert.IsInstanceOfType(contains.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(contains.operand[1], typeof(End));
                var result = Run(contains, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Includes_Year()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Proper_Includes_Day_Start: Interval[@2023, @2023] includes year of Interval[@2023, @2023]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Includes));
            {
                var same = (Includes)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Includes()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Includes: Interval[@2023, @2023] includes Interval[@2023, @2023]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Includes));
            {
                var same = (Includes)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void EmptyList_Includes_EmptyList()
        {
            // Declare the cost of casting to Any to be higher than an exact match
            // that should make these unambiguous
            var library = MakeLibrary(@"
                library IncludesTest version '1.0.0'

                define private EmptyList_Includes_EmptyList: {} includes {}
            ");
        }


        [TestMethod]
        public void NullBoundariesProperlyIncludesIntegerInterval()
        {
            var library = CreateLibraryForExpression("Interval[null as Integer, null as Integer] properly includes Interval[1, 10]");
            var intersect = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ProperIncludes>();
            var result = Run<bool?>(intersect, library);
            result.Should().BeNull();
        }



    }
}
