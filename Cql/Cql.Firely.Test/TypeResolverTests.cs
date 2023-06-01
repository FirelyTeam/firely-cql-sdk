using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ncqa.Cql.Model;

namespace Cql.Firely.Test
{
    [TestClass]
    public class TypeResolverTests
    {
        [TestMethod]
        public void RegisterResources()
        {
            var resolver = new FirelyTypeResolver(Models.Fhir401);
        }
    }
}