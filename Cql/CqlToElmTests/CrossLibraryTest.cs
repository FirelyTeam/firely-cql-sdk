using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class CrossLibraryTest : Base
    {
        [TestMethod]
        public void ExpressionRef_Across_Library()
        {
            var cqlApi = CreateCqlApi();

            var foo = cqlApi.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define F: 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlApi.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.F
                                         """);
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ExpressionRef>();
        }

        [TestMethod]
        public void ExpressionRef_Across_Library_NotFound()
        {
            var cqlApi = CreateCqlApi();
            var foo = cqlApi.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define F: 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            cqlApi.MakeLibrary("""
                               library Bar version '1.0.0'

                               include Foo version '1.0.0' called foo

                               define G: foo.DoesNotExist
                               """,
                               "Could not resolve identifier DoesNotExist in library Foo.");
        }

        [TestMethod]
        public void FunctionRef_Across_Library()
        {
            var cqlApi = CreateCqlApi();
            var foo = cqlApi.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlApi.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.Foo()
                                         """);
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
        }


        [TestMethod]
        public void FunctionRef_Across_Library_NotFound()
        {
            var cqlApi = CreateCqlApi();
            var foo = cqlApi.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            cqlApi.MakeLibrary("""
                               library Bar version '1.0.0'

                               include Foo version '1.0.0' called foo

                               define G: foo.DoesNotExist()
                               """,
                               "Could not resolve call to operator DoesNotExist with signature ().");
        }
    }
}