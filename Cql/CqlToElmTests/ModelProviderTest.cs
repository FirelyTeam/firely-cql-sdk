using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    }
}
