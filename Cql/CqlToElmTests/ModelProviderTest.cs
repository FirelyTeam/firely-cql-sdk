using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ModelProviderTest
    {
        [TestMethod]
        public void LoadFHIRModel()
        {
            var provider = new BuiltinModelProvider(Models.ElmR1, Models.Fhir401);
            Assert.AreEqual("http://hl7.org/fhir", provider.GetModelFromName("FHIR", "4.0.1").url);
            Assert.AreEqual("urn:hl7-org:elm-types:r1", provider.GetModelFromName("System", "1.0.0").url);
        }
        [TestMethod]
        public void FHIRQuantityDerivedTypes()
        {
            var provider = new BuiltinModelProvider(Models.ElmR1, Models.Fhir401);
            var fhirModel = provider.GetModelFromName("FHIR", "4.0.1");
            var quantityType = fhirModel.FindTypeInfo("Quantity");

            var qc = quantityType.Should().BeOfType<ClassInfo>().Subject;
            var ageType = fhirModel.FindTypeInfo("Age");
            var ac = ageType.Should().BeOfType<ClassInfo>().Subject;
            var derived = provider.FindDerivedTypes(qc).ToArray();
            derived.Should().HaveCount(6);
            derived.Any(t => t.Name == ac.Name).Should().BeTrue();
        }
        [TestMethod]
        public void FHIRConversionAgeToQuantity()
        {
            var provider = new BuiltinModelProvider(Models.ElmR1, Models.Fhir401);
            provider.TryGetConversionFunctionName("FHIR.Age", "System.Quantity", out var funcName)
                .Should().BeTrue();
            funcName.Should().Be("FHIRHelpers.ToQuantity");
        }
    }
}
