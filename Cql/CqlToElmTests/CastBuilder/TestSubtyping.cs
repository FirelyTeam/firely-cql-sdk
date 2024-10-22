using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using M = Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class TestSubtyping
    {
        private readonly M.IModelProvider provider = new M.ModelProviders.BuiltInModelProvider();
        private readonly NamedTypeSpecifier Patient = forFhir("Patient");
        private readonly NamedTypeSpecifier Observation = forFhir("Observation");
        private readonly NamedTypeSpecifier Resource = forFhir("Resource");
        private readonly NamedTypeSpecifier DomainResource = forFhir("DomainResource");
        private readonly NamedTypeSpecifier HumanName = forFhir("HumanName");
        private readonly NamedTypeSpecifier Element = forFhir("Element");

        private static NamedTypeSpecifier forFhir(string typeName) =>
            new NamedTypeSpecifier("http://hl7.org/fhir", typeName);

        private void yes(TypeSpecifier sub, TypeSpecifier super) =>
            TypeBridge.ToModelSpecifier(sub, provider)
                .IsSubtypeOf(TypeBridge.ToModelSpecifier(super, provider))
            .Should().BeTrue();

        private void no(TypeSpecifier sub, TypeSpecifier super) =>
            TypeBridge.ToModelSpecifier(sub, provider)
                .IsSubtypeOf(TypeBridge.ToModelSpecifier(super, provider))
            .Should().BeFalse();

        [TestMethod]
        public void TypesAreSubtypesOfThemselves()
        {
            yes(Patient, Patient);
            yes(Resource, Resource);
            yes(SystemTypes.BooleanType, SystemTypes.BooleanType);
            yes(SystemTypes.AnyType, SystemTypes.AnyType);
        }

        [TestMethod]
        public void TypesAreNotProperSubtypesOfThemselves()
        {
            no(Patient, Patient);
            no(Resource, Resource);
            yes(Patient, Resource);
            no(SystemTypes.BooleanType, SystemTypes.BooleanType);
            yes(SystemTypes.AnyType, SystemTypes.AnyType); // Any is a subtype of Any?
        }

        [TestMethod]
        public void BaseclassesAreSubtypes()
        {
            yes(Patient, Resource);
            yes(Patient, DomainResource);
            yes(Patient, SystemTypes.AnyType);

            yes(HumanName, Element);
            yes(HumanName, SystemTypes.AnyType);

            yes(SystemTypes.BooleanType, SystemTypes.AnyType);
            yes(SystemTypes.ValueSetType, SystemTypes.VocabularyType);
            yes(SystemTypes.ValueSetType, SystemTypes.AnyType);
        }

        [TestMethod]
        public void NotBaseclasses()
        {
            no(Patient, Observation);
            no(Observation, Patient);
            no(SystemTypes.BooleanType, SystemTypes.ValueSetType);
            no(SystemTypes.DecimalType, SystemTypes.IntegerType);
            no(SystemTypes.IntegerType, SystemTypes.DecimalType);
            no(Patient, Element);
        }

    }
}
