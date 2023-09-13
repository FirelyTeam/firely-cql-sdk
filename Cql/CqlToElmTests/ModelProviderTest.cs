using Hl7.Cql.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ModelProviderTest
    {
        [TestMethod]
        public void LoadFHIRModel()
        {
            var provider = new ModelProvider(Models.ElmR1, Models.Fhir401);
            Assert.AreEqual("http://hl7.org/fhir", provider.ModelFromName("FHIR", "4.0.1")?.url);
            Assert.AreEqual("urn:hl7-org:elm-types:r1", provider.ModelFromName("System", "1.0.0")?.url);
        }

    }
}
