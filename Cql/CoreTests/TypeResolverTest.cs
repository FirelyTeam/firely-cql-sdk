using Hl7.Cql;
using Hl7.Cql.Firely;
using Hl7.Cql.Model;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CoreTests
{
    [TestClass]
    public class TypeResolverTest
    {
        [TestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void Resolve_Types(TypeResolver typeResolver)
        {
            var model = Models.Fhir401;
            foreach (var typeInfo in model.typeInfo.OfType<ClassInfo>())
            {
                var elmId = $"{{{model.url}}}{typeInfo.name}";
                var type = typeResolver.ResolveType(elmId);
                Assert.IsNotNull(type);
            }
        }

        [TestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void Resolve_Properties(TypeResolver typeResolver)
        {
            var model = Models.Fhir401;
            foreach (var typeInfo in model.typeInfo.OfType<ClassInfo>())
            {
                var elmId = $"{{{model.url}}}{typeInfo.name}";
                var type = typeResolver.ResolveType(elmId);
                foreach (var element in typeInfo.element ?? Enumerable.Empty<ClassInfoElement>())
                {
                    var property = typeResolver.GetProperty(type, element.name);
                    Assert.IsNotNull(property, $"Missing property {element.name} in {typeInfo.name}.");
                }
            }
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new FirelyTypeResolver(Hl7.Fhir.Model.ModelInfo.ModelInspector) };
        }
    }
}
