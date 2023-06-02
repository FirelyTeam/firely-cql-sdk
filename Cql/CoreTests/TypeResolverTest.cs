using Hl7.Cql.Model;
using Hl7.Cql.Firely;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Cql;

namespace CoreTests
{
    [TestClass]
    public class TypeResolverTest
    {
        public static readonly TypeResolver TypeResolver = new FirelyTypeResolver(Models.Fhir401);

        [TestMethod]
        public void Resolve_Types()
        {
            var model = Models.Fhir401;
            foreach (var typeInfo in model.typeInfo.OfType<ClassInfo>())
            {
                var elmId = $"{{{model.url}}}{typeInfo.name}";
                var type = TypeResolver.ResolveType(elmId);
                Assert.IsNotNull(type);
            }
        }

        [TestMethod]
        public void Resolve_Properties()
        {
            var model = Models.Fhir401;
            foreach (var typeInfo in model.typeInfo.OfType<ClassInfo>())
            {
                var elmId = $"{{{model.url}}}{typeInfo.name}";
                var type = TypeResolver.ResolveType(elmId);
                foreach (var element in typeInfo.element ?? Enumerable.Empty<ClassInfoElement>())
                {
                    var property = TypeResolver.GetProperty(type, element.name);
                    Assert.IsNotNull(property);
                }
            }
        }

    }
}
