using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Model;
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
        public void Resolve_Types(object tr)
        {
            var typeResolver = (TypeResolver)tr;

            var model = Models.Fhir401;
            foreach (var classInfo in model.typeInfo.OfType<ClassInfo>())
            {
                var elmId = $"{{{model.url}}}{classInfo.name}";
                var type = typeResolver.ResolveType(elmId);
                Assert.IsNotNull(type);
            }
            foreach (var simpleTypeInfo in model.typeInfo.OfType<SimpleTypeInfo>())
            {
                var elmId = $"{{{model.url}}}{simpleTypeInfo.name}";
                var type = typeResolver.ResolveType(elmId);
                Assert.IsNotNull(type);
            }
        }

        [TestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void Resolve_Properties(object tr)
        {
            var typeResolver = (TypeResolver)tr;
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
            yield return new object[] { new FhirTypeResolver(Hl7.Fhir.Model.ModelInfo.ModelInspector) };
        }
    }
}
