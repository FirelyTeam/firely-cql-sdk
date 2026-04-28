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
    public class CrossLibraryTest : Base
    {
        [TestMethod]
        public void ExpressionRef_Across_Library()
        {
            var cqlToolkit = CreateCqlToolkit();

            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define F: 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.F
                                         """);
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ExpressionRef>();
        }

        [TestMethod]
        public void ExpressionRef_Across_Library_NotFound()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define F: 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            cqlToolkit.MakeLibrary("""
                               library Bar version '1.0.0'

                               include Foo version '1.0.0' called foo

                               define G: foo.DoesNotExist
                               """,
                               "Could not resolve identifier DoesNotExist in library Foo.");
        }

        [TestMethod]
        public void FunctionRef_Across_Library()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.Foo()
                                         """);
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
        }


        [TestMethod]
        public void FunctionRef_Across_Library_NotFound()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            cqlToolkit.MakeLibrary("""
                               library Bar version '1.0.0'

                               include Foo version '1.0.0' called foo

                               define G: foo.DoesNotExist()
                               """,
                               "Could not resolve call to operator DoesNotExist with signature ().");
        }

        [TestMethod]
        public void FunctionRef_Across_Library_HasLibraryName()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.Foo()
                                         """);
            var funcRef = bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
            funcRef.libraryName.Should().Be("foo");
        }

        [TestMethod]
        public void FunctionRef_Across_Library_Overloaded_HasLibraryName()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function MyFunc(a Integer): a * 2
                                         define function MyFunc(a String): a + a
                                         """);
            foo.GetErrors().Should().BeEmpty();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.MyFunc(3)
                                         """);
            var funcRef = bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
            funcRef.libraryName.Should().Be("foo");
        }
    }
}
