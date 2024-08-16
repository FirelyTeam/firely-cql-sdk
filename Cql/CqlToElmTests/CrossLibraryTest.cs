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
            var foo = MakeLibraryBuilder(services,  @"
                library Foo version '1.0.0'

                define F: 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.Identifier.id, foo.Identifier.version, foo);

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

            var foo = MakeLibraryBuilder(services, @"
                library Foo version '1.0.0'

                define F: 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.Identifier!.id, foo.Identifier!.version, foo);

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
            var foo = MakeLibraryBuilder(services, @"
                library Foo version '1.0.0'

                define function Foo(): 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.Identifier!.id, foo.Identifier!.version, foo);

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
            var foo = MakeLibraryBuilder(services, @"
                library Foo version '1.0.0'

                define function Foo(): 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();
            libraryProvider.Libraries.Add(foo.Identifier!.id, foo.Identifier!.version, foo);

            MakeLibrary(services, @"
                library Bar version '1.0.0'

                include Foo version '1.0.0' called foo

                define G: foo.DoesNotExist()
            ", "Could not resolve call to operator DoesNotExist with signature ().");
        }

        [TestMethod]
        public void Fluent_Function_Conflict()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            var foo = MakeLibraryBuilder(services, @"
                library Foo version '1.0.0'

                define fluent function Conflict(x Integer): 'foo'
            ");
            libraryProvider.Libraries.Add(foo.Identifier!.id, foo.Identifier!.version, foo);

            var bar = MakeLibraryBuilder(services, @"
                library Bar version '1.0.0'

                define fluent function Conflict(x Integer): 'bar'
            ");
            libraryProvider.Libraries.Add(bar.Identifier!.id, bar.Identifier!.version, bar);

            var baz = MakeLibraryBuilder(services, @"
                library Baz version '1.0.0'

                include Foo version '1.0.0'
                include Bar version '1.0.0'

                define callsConflict: 1.Conflict()
            ", "Call to operator Conflict(Integer) is ambiguous with:\r\n\t- Conflict(Integer) in Foo-1.0.0\r\n\t- Conflict(Integer) in Bar-1.0.0\r\n");
        }

        [TestMethod]
        public void Fluent_Function_Conflict_Not_Called()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            var foo = MakeLibraryBuilder(services, @"
                library Foo version '1.0.0'

                define fluent function Conflict(x Integer): 'foo'

            ");
            libraryProvider.Libraries.Add(foo.Identifier!.id, foo.Identifier!.version, foo);

            var bar = MakeLibraryBuilder(services, @"
                library Bar version '1.0.0'

                define fluent function Conflict(x Integer): 'bar'
                define fluent function Conflict(x String): 'bar'

            ");
            libraryProvider.Libraries.Add(bar.Identifier!.id, bar.Identifier!.version, bar);

            // no error because the conflicting function is never called.
            var baz = MakeLibraryBuilder(services, @"
                library Baz version '1.0.0'

                include Foo version '1.0.0'
                include Bar version '1.0.0'

                define callsConflict: 'hello'.Conflict()
            ");
        }
    }
}
