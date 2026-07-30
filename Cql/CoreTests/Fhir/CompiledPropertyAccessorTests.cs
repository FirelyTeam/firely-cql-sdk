/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Fhir.Model;

namespace CoreTests.Fhir
{
    [TestClass]
    public class CompiledPropertyAccessorTests
    {
        private class NonPublicGetter
        {
            public string Value { private get; set; } = "hidden";

            public static PropertyInfo Property => typeof(NonPublicGetter).GetProperty(nameof(Value))!;
        }

        private class Indexed
        {
            public string this[int index] => index.ToString();

            public static PropertyInfo Property => typeof(Indexed).GetProperty("Item")!;
        }

        [TestMethod]
        public void For_CompiledGetter_ReturnsNullForInstanceOfUnrelatedType()
        {
            var getter = CompiledPropertyAccessor.For(typeof(Observation).GetProperty(nameof(Observation.Code))!);

            getter(new Patient()).Should().BeNull();
        }

        [TestMethod]
        public void For_ReflectionFallback_ReturnsNullForInstanceOfUnrelatedType()
        {
            var getter = CompiledPropertyAccessor.For(NonPublicGetter.Property);

            getter(new Patient()).Should().BeNull();
        }

        [TestMethod]
        public void For_IndexerProperty_ReturnsNull()
        {
            var getter = CompiledPropertyAccessor.For(Indexed.Property);

            getter(new Indexed()).Should().BeNull();
        }

        [TestMethod]
        public void GetterIdentity_SeparatePropertyInfoInstancesForSameProperty_AreEqual()
        {
            var resolver = new FhirTypeResolver(ModelInfo.ModelInspector);
            var observationType = resolver.ResolveType("{http://hl7.org/fhir}Observation")!;

            var first = CompiledPropertyAccessor.GetterIdentity(resolver.GetProperty(observationType, "code")!);
            var second = CompiledPropertyAccessor.GetterIdentity(resolver.GetProperty(observationType, "code")!);

            second.Should().Be(first);
        }
    }
}
