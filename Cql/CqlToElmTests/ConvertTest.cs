using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ConvertTest : Base
    {
        [TestMethod]
        public void Convert_Integer_to_String()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("convert 5 to String");
            library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToString>();
        }

        [TestMethod]
        public void Convert_String_to_DateTime()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("ToDateTime('2014-01-01T12:05:05.955-01:15')");
            var toDateTime = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToDateTime>();
            var result = Run(toDateTime, library);
            var dt = result.Should().BeOfType<CqlDateTime>().Subject;
            dt.Value.OffsetHour.Should().Be(-1);
            dt.Value.OffsetMinute.Should().Be(-15);
            dt.Value.DateTimeOffset.Offset.Should().Be(TimeSpan.FromMinutes(-75));
        }

        [TestMethod]
        public void Convert_Code_To_Concept()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("ToConcept(Code { code: '8480-6' })");
            var toConcept = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToConcept>();
            var result = Run<CqlConcept>(toConcept, library);
        }

        [TestMethod]
        public void Convert_Quantity_To_Weeks()
        {
            var lib = CreateCqlApi().MakeLibrary("""

                                library Test version '1.0.0'

                                define function f(q Quantity):
                                    convert q to weeks
                """);
            lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ConvertQuantity>();

        }

    }
}