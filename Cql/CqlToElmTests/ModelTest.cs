using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ModelTest : Base
    {
        [TestMethod]
        public void Quantity_Is_Ambiguous()
        {
            var cqlApi = CreateCqlApi(AmbiguousTypeBehavior: AmbiguousTypeBehavior.Error);
            var lib = cqlApi.MakeLibrary("""
                                         library Test version '1.0.0'

                                         using FHIR version '4.0.1'

                                         define function f(q Quantity): q
                                         """,
                                         "The type Quantity is ambiguous between System.Quantity, FHIR.Quantity.");
        }


        [TestMethod]
        public void Quantity_Prefer_System()
        {
            var cqlApi = CreateCqlApi(AmbiguousTypeBehavior: AmbiguousTypeBehavior.PreferSystem);
            var lib = cqlApi.MakeLibrary("""
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                define function f(q Quantity): q
                """);
            var or = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<OperandRef>();
            or.Should().HaveType(SystemTypes.QuantityType);
        }

        [TestMethod]
        public void Quantity_Prefer_Model()
        {
            var cqlApi = CreateCqlApi(AmbiguousTypeBehavior: AmbiguousTypeBehavior.PreferModel);
            var lib = cqlApi.MakeLibrary("""
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                define function f(q Quantity): q
                """);
            var or = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<OperandRef>();
            or.resultTypeName.Name.Should().Be("{http://hl7.org/fhir}Quantity");
        }
    }
}