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
        private readonly IModelProvider provider = new BuiltinModelProvider(M.Models.ElmR1, M.Models.Fhir401);
        private readonly NamedTypeSpecifier Patient = forFhir("Patient");
        private readonly NamedTypeSpecifier Observation = forFhir("Observation");
        private readonly NamedTypeSpecifier Resource = forFhir("Resource");
        private readonly NamedTypeSpecifier DomainResource = forFhir("DomainResource");
        private readonly NamedTypeSpecifier HumanName = forFhir("HumanName");
        private readonly NamedTypeSpecifier Element = forFhir("Element");

        private static NamedTypeSpecifier forFhir(string typeName) =>
           new() { name = M.QualifiedName.MakeQualifiedTypeName(M.Models.Fhir401, typeName) };

        private void yes(TypeSpecifier sub, TypeSpecifier super) =>
            sub.IsSubtypeOf(super, provider).Should().BeTrue();

        private void no(TypeSpecifier sub, TypeSpecifier super) =>
            sub.IsSubtypeOf(super, provider).Should().BeFalse();

        [TestMethod]
        public void TypesAreNotSubtypesOfThemselves()
        {
            no(Patient, Patient);
            no(Resource, Resource);
            no(SystemTypes.BooleanType, SystemTypes.BooleanType);
            no(SystemTypes.AnyType, SystemTypes.AnyType);
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
