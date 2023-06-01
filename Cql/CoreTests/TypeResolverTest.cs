using Hl7.Cql.Model;
using Hl7.Cql.Runtime.FhirR4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    [TestClass]
    public class TypeResolverTest
    {
        [TestMethod]
        public void Resolve_Types()
        {
            var typeResolver = FhirTypeResolver.Default;
            var model = Models.Fhir401;
            foreach (var typeInfo in model.typeInfo.OfType<ClassInfo>())
            {
                var elmId = $"{{{model.url}}}{typeInfo.name}";
                var type = typeResolver.ResolveType(elmId);
                Assert.IsNotNull(type);
            }
        }

        [TestMethod]
        public void Resolve_Properties()
        {
            var typeResolver = FhirTypeResolver.Default;
            var model = Models.Fhir401;
            foreach (var typeInfo in model.typeInfo.OfType<ClassInfo>())
            {
                var elmId = $"{{{model.url}}}{typeInfo.name}";
                var type = typeResolver.ResolveType(elmId);
                foreach (var element in typeInfo.element ?? Enumerable.Empty<ClassInfoElement>())
                {
                    var property = typeResolver.GetProperty(type, element.name);
                    Assert.IsNotNull(property);
                }
            }
        }

    }
}
