using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Model.ModelProviders;
using Hl7.Cql.Model.Xml;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ModelLoader = Hl7.Cql.Model.Xml.ModelLoader;

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


        [TestMethod]
        public void QICore_Loads()
        {
            var qicore = Models.QICore411;

            var lib = MakeLibrary(@"
                library ModelTest version '1.0.0'

                using QICore version '4.1.1'

                define d: 1
            ");
            lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>()
                .value.Should().Be("1"); 
        }

        [TestMethod]
        public void Load_System_Xml()
        {
            var modelLoader = new BuiltInModelProvider();
            modelLoader.Load(Models.ElmR1);
            modelLoader.TryGetModel(Models.ElmR1.name, null, out var elm).Should().BeTrue();
            elm!.TypeDefinitions.Should().HaveCount(18);
        }

        [TestMethod]
        public void Load_Fhir_Xml()
        {
            var modelLoader = new BuiltInModelProvider();
            modelLoader.Load(Models.Fhir401);
            modelLoader.TryGetModel(Models.Fhir401.name, null, out var fhir).Should().BeTrue();
            fhir!.TypeDefinitions.Should().HaveCount(931);
        }

        [TestMethod]
        public void Write_System_Xml_To_Cql()
        {
            var modelLoader = new BuiltInModelProvider();
            modelLoader.Load(Models.ElmR1);
            modelLoader.TryGetModel(Models.ElmR1.name, null, out var elm).Should().BeTrue();
            var writer = new ModelWriter();
            var file = new FileInfo($"{elm!.Name}-{elm.Version}.cql");
            var fs = new FileStream(file.FullName, FileMode.Create, FileAccess.Write, FileShare.Read);
            var sw = new StreamWriter(fs);
            writer.Write(elm, sw);
            sw.Flush();
        }

        //[TestMethod]
        public void Write_Fhir_Xml_To_Cql()
        {
            var modelLoader = new BuiltInModelProvider();
            modelLoader.Load(Models.Fhir401);
            modelLoader.TryGetModel(Models.Fhir401.name, null, out var fhir).Should().BeTrue();
            fhir!.TypeDefinitions.Should().HaveCount(931);
            var writer = new ModelWriter();
            var file = new FileInfo($"{fhir!.Name}-{fhir.Version}.cql");
            var fs = new FileStream(file.FullName, FileMode.Create, FileAccess.Write, FileShare.Read);
            var sw = new StreamWriter(fs);
            writer.Write(fhir, sw);
            sw.Flush();
        }

    }
}