/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class SingletonTest : Base
    {
        [TestMethod]
        public void Singleton_From_Integers()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integers: singleton from { 1 }
                """);
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

                var ctx = FhirCqlContext.ForBundle();
                var result = Run(singletonFrom, library, ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Singleton_From_Empty()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library SingletonTest version '1.0.0'

                define private Singleton_From_Empty: singleton from ({} as List<Integer>)
                """);
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
                var ctx = FhirCqlContext.ForBundle();
                var result = Run(singletonFrom, library, ctx);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Singleton_From_Integers_Null()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integers_Null: singleton from (null as List<Integer>)
                """);
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

                var ctx = FhirCqlContext.ForBundle();
                var result = Run(singletonFrom, library, ctx);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Singleton_From_Integers_Error()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integers_Error: singleton from { 1, 2, 3 }
                """);
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

                var ctx = FhirCqlContext.ForBundle();
                // The invoker does not wrap exceptions, so the runtime error surfaces directly.
                Assert.ThrowsException<InvalidOperationException>(() => Run(singletonFrom, library, ctx));
            }
        }

        [TestMethod]
        public void Singleton_From_Integer_With_List_Promotion()
        {
            var library = CreateCqlToolkit(DisableListPromotion:false).MakeLibrary("""
                library SingletonTest version '1.0.0'

                define private Singleton_From_Integer_With_List_Promotion: singleton from 1
                """);

            var singletonFrom = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SingletonFrom>();
            var toList = singletonFrom.operand.Should().BeOfType<ToList>().Subject;
            toList.operand.Should().BeLiteralInteger(1);

            AssertResult(singletonFrom, 1);
        }
    }
}
