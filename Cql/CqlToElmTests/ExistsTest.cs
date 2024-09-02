using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ExistsTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Exists_True()
        {
            var library = MakeLibrary(@"
                library ExistsTest version '1.0.0'

                define private Empty_List: exists { 1, 3, 5, 7 }
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Exists));
            {
                var exists = (Exists)library.statements[0].expression;
                Assert.IsNotNull(exists.operand);
                Assert.IsInstanceOfType(exists.operand, typeof(List));
                var list = (List)exists.operand;
                AssertListType(list.resultTypeSpecifier, $"{{{SystemUri}}}Integer");
                AssertList(list, new int?[] { 1, 3, 5, 7 });
                AssertExists(exists, true);
            }
        }

        [TestMethod]
        public void Exists_Empty_List()
        {
            var library = MakeLibrary(@"
                library ExistsTest version '1.0.0'

                define private Empty_List: exists { }
            ");

            var exists = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Exists>();
            {
                Assert.IsNotNull(exists.operand);
                Assert.IsInstanceOfType(exists.operand, typeof(List));
                var list = (List)exists.operand;
                list.resultTypeSpecifier.Should().Be(SystemTypes.AnyType.ToListType());
                AssertList(list, Array.Empty<object>());
                AssertExists(exists, false);
            }
        }

        [TestMethod]
        public void Exists_Null()
        {
            var library = MakeLibrary(@"
                library ExistsTest version '1.0.0'

                define private Empty_List: exists null
            ");

            var exists = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Exists>();
            {
                Assert.IsNotNull(exists.operand);
                Assert.IsInstanceOfType(exists.operand, typeof(As));
                var @as = (As)exists.operand;
                AssertListType(@as.resultTypeSpecifier, $"{{{SystemUri}}}Any");
                Assert.IsNotNull(@as.operand);
                Assert.IsInstanceOfType(@as.operand, typeof(Null));
                AssertExists(exists, false);
            }
        }

        [TestMethod]
        public void Exists_List_Nulls()
        {
            var library = MakeLibrary(@"
                library ExistsTest version '1.0.0'

                define private Empty_List: exists { null }
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Exists));
            {
                var exists = (Exists)library.statements[0].expression;
                Assert.IsNotNull(exists.operand);
                Assert.IsInstanceOfType(exists.operand, typeof(List));
                var list = (List)exists.operand;
                AssertListType(list.resultTypeSpecifier, $"{{{SystemUri}}}Any");
                AssertList(list, new object?[] { null });
                AssertExists(exists, false);
            }
        }


        private void AssertExists(Exists exists, bool? expected)
        {
            var lambda = LibraryExpressionBuilder.Lambda(exists);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(bool?));
            Assert.AreEqual(result, expected);
        }
    }
}
