using FluentAssertions;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class CrossLibraryTest: Base
    {

        [TestMethod]
        public void ExpressionRef_Across_Library()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            var foo = MakeLibrary(services, @"
                library Foo version '1.0.0'

                define F: 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.identifier!.id, foo.identifier!.version, foo);

            var bar = MakeLibrary(services, @"
                library Bar version '1.0.0'

                include Foo version '1.0.0' called foo

                define G: foo.F
            ");
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ExpressionRef>();

        }

        [TestMethod]
        public void ExpressionRef_Across_Library_NotFound()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();

            var foo = MakeLibrary(services, @"
                library Foo version '1.0.0'

                define F: 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.identifier!.id, foo.identifier!.version, foo);

            MakeLibrary(services, @"
                library Bar version '1.0.0'

                include Foo version '1.0.0' called foo

                define G: foo.DoesNotExist
            ", "Could not resolve identifier DoesNotExist in library Foo.");
        }

        [TestMethod]
        public void FuncionRef_Across_Library()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            var foo = MakeLibrary(services, @"
                library Foo version '1.0.0'

                define function Foo(): 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.identifier!.id, foo.identifier!.version, foo);

            var bar = MakeLibrary(services, @"
                library Bar version '1.0.0'

                include Foo version '1.0.0' called foo

                define G: foo.Foo()
            ");
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
        }


        [TestMethod]
        public void FunctionRef_Across_Library_NotFound()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            var foo = MakeLibrary(services, @"
                library Foo version '1.0.0'

                define function Foo(): 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.identifier!.id, foo.identifier!.version, foo);

            MakeLibrary(services, @"
                library Bar version '1.0.0'

                include Foo version '1.0.0' called foo

                define G: foo.DoesNotExist()
            ", "Could not resolve call to operator DoesNotExist with signature ().");
        }
    }
}
