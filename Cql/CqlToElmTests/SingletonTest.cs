using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class SingletonTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.EnableListPromotion = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Singleton_From_Integers()
        {
            var library = MakeLibrary(@"
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integers: singleton from { 1 }
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SingletonFrom));
            {
                var singletonFrom = (SingletonFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(singletonFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)singletonFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", singletonFrom.resultTypeName?.Name);
                Assert.IsNotNull(singletonFrom.operand);
                Assert.IsInstanceOfType(singletonFrom.operand, typeof(List));
                var list = (List)singletonFrom.operand;
                AssertListType(list.resultTypeSpecifier, $"{{{SystemUri}}}Integer");
                AssertList(list, new int?[] { 1 });

                var lambda = LibraryExpressionBuilder.Lambda(singletonFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Singleton_From_Empty()
        {
            var library = MakeLibrary(@"
                library SingletonTest version '1.0.0'

                define private Singleton_From_Empty: singleton from ({} as List<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SingletonFrom));
            {
                var singletonFrom = (SingletonFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(singletonFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)singletonFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", singletonFrom.resultTypeName?.Name);
                Assert.IsNotNull(singletonFrom.operand);
                Assert.IsInstanceOfType(singletonFrom.operand, typeof(As));
                var @as = (As)singletonFrom.operand;
                AssertListType(@as.resultTypeSpecifier, $"{{{SystemUri}}}Integer");
                var list = (List)@as.operand;
                Assert.IsInstanceOfType(@as.operand, typeof(List));
                AssertList(list, Array.Empty<object?>()); // empty list typed as Any
                var lambda = LibraryExpressionBuilder.Lambda(singletonFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Singleton_From_Integers_Null()
        {
            var library = MakeLibrary(@"
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integers_Null: singleton from (null as List<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SingletonFrom));
            {
                var singletonFrom = (SingletonFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(singletonFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)singletonFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", singletonFrom.resultTypeName?.Name);
                Assert.IsNotNull(singletonFrom.operand);
                Assert.IsInstanceOfType(singletonFrom.operand, typeof(As));
                var @as = (As)singletonFrom.operand;
                Assert.IsInstanceOfType(@as.operand, typeof(Null));
                AssertListType(@as.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = LibraryExpressionBuilder.Lambda(singletonFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Singleton_From_Integers_Error()
        {
            var library = MakeLibrary(@"
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integers_Error: singleton from { 1, 2, 3 }
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SingletonFrom));
            {
                var singletonFrom = (SingletonFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(singletonFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)singletonFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", singletonFrom.resultTypeName?.Name);
                Assert.IsNotNull(singletonFrom.operand);
                Assert.IsInstanceOfType(singletonFrom.operand, typeof(List));
                var list = (List)singletonFrom.operand;
                AssertListType(list.resultTypeSpecifier, $"{{{SystemUri}}}Integer");
                AssertList(list, new int?[] { 1, 2, 3 });

                var lambda = LibraryExpressionBuilder.Lambda(singletonFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                Assert.ThrowsException<TargetInvocationException>(() => dg.DynamicInvoke(ctx));
            }
        }

        [TestMethod]
        public void Singleton_From_Integer_With_List_Promotion()
        {
            var library = MakeLibrary(@"
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integer_With_List_Promotion: singleton from 1
            ");

            var singletonFrom = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SingletonFrom>();
            var toList = singletonFrom.operand.Should().BeOfType<ToList>().Subject;
            toList.operand.Should().BeLiteralInteger(1);

            AssertResult(singletonFrom, 1);
        }
    }
}

