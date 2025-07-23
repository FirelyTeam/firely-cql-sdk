/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ConvertTest : Base
    {
        [TestMethod]
        public void Convert_Integer_to_String()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("convert 5 to String");
            library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToString>();
        }

        [TestMethod]
        public void Convert_String_to_DateTime()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("ToDateTime('2014-01-01T12:05:05.955-01:15')");
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
            var library = CreateCqlToolkit().MakeLibraryFromExpression("ToConcept(Code { code: '8480-6' })");
            var toConcept = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToConcept>();
            var result = Run<CqlConcept>(toConcept, library);
        }

        [TestMethod]
        public void Convert_Quantity_To_Weeks()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""

                                library Test version '1.0.0'

                                define function f(q Quantity):
                                    convert q to weeks
                """);
            lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ConvertQuantity>();

        }

        [TestMethod]
        public void Convert_Meters_to_Centimeters()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("convert 5 'm' to 'cm'");
            var quantity = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ConvertQuantity>();
            var result = Run(quantity, library);
            var q = result.Should().BeOfType<CqlQuantity>().Subject;
            q.value.Should().Be(500m);
            q.unit.Should().Be("cm");
        }

        [TestMethod]
        [Ignore("Mass units are not yet defined and respective conversions not yet implemented, see UcumUnits.cs and UnitConverter.cs")]
        public void Convert_Grams_to_Kilograms()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("convert 500 'g' to 'kg'");
            var quantity = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ConvertQuantity>();
            var result = Run(quantity, library);
            var q = result.Should().BeOfType<CqlQuantity>().Subject;
            q.value.Should().Be(0.5m);
            q.unit.Should().Be("kg");
        }
    }
}
