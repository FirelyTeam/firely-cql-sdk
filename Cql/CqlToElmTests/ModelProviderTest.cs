using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Model.ModelProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ModelProviderTest
    {
        [TestMethod]
        public void LoadFHIRModel()
        {
            var provider = new BuiltInModelProvider();
            provider.TryGetModel("FHIR", null, out var fhir, out var error)
                .Should().BeTrue();
            fhir.Should().NotBeNull();
            fhir!.Url.Should().Be("http://hl7.org/fhir"); 
        }
        [TestMethod]
        public void FHIRQuantityDerivedTypes()
        {
            throw new NotImplementedException();
            //var provider = new BuiltinModelProvider(Models.ElmR1, Models.Fhir401);
            //var fhirModel = provider.GetModelFromName("FHIR", "4.0.1");
            //var quantityType = fhirModel.FindTypeInfo("Quantity");

            //var qc = quantityType.Should().BeOfType<ClassInfo>().Subject;
            //var ageType = fhirModel.FindTypeInfo("Age");
            //var ac = ageType.Should().BeOfType<ClassInfo>().Subject;
            //var derived = provider.FindDerivedTypes(qc).ToArray();
            //derived.Should().HaveCount(6);
            //derived.Any(t => t.Name == ac.Name).Should().BeTrue();
        }
        [TestMethod]
        public void FHIRConversionAgeToQuantity()
        {
            throw new NotImplementedException();
            //var provider = new BuiltinModelProvider(Models.ElmR1, Models.Fhir401);
            //provider.TryGetConversionFunctionName("FHIR.Age", "System.Quantity", out var funcName)
            //    .Should().BeTrue();
            //funcName.Should().Be("FHIRHelpers.ToQuantity");
        }
    }
}
