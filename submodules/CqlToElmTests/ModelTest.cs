using FluentAssertions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ModelTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [TestMethod]
        public void Quantity_Is_Ambiguous()
        {
            var services = ServiceCollection(options =>
            {
                options.AmbiguousTypeBehavior = AmbiguousTypeBehavior.Error;
            }).BuildServiceProvider();

            var lib = MakeLibrary(services, @"
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                define function f(q Quantity): q
            ", "The type Quantity is ambiguous between System.Quantity, FHIR.Quantity.");

        }


        [TestMethod]
        public void Quantity_Prefer_System()
        {
            var services = ServiceCollection(options =>
            {
                options.AmbiguousTypeBehavior = AmbiguousTypeBehavior.PreferSystem;
            }).BuildServiceProvider();

            var lib = MakeLibraryBuilder(services, @"
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                define function f(q Quantity): q
            ").Build();
            var or = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<OperandRef>();
            or.Should().HaveType(SystemTypes.QuantityType);
        }

        [TestMethod]
        public void Quantity_Prefer_Model()
        {
            var services = ServiceCollection(options =>
            {
                options.AmbiguousTypeBehavior = AmbiguousTypeBehavior.PreferModel;
            }).BuildServiceProvider();

            var lib = MakeLibraryBuilder(services, @"
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                define function f(q Quantity): q
            ").Build();
            var or = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<OperandRef>();
            or.resultTypeName.Name.Should().Be("{http://hl7.org/fhir}Quantity");
        }


    }
}