using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using M = Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class TestSubtyping : Base
    {
        private readonly M.IModelProvider provider = new M.ModelProviders.BuiltInModelProvider();
        private readonly CqlToElmOptions options = new CqlToElmOptions();

        private readonly NamedTypeSpecifier Patient = forFhir("Patient");
        private readonly NamedTypeSpecifier Observation = forFhir("Observation");
        private readonly NamedTypeSpecifier Resource = forFhir("Resource");
        private readonly NamedTypeSpecifier DomainResource = forFhir("DomainResource");
        private readonly NamedTypeSpecifier HumanName = forFhir("HumanName");
        private readonly NamedTypeSpecifier Element = forFhir("Element");

        private static NamedTypeSpecifier forFhir(string typeName) =>
            new NamedTypeSpecifier("http://hl7.org/fhir", typeName);

        private void yes(TypeSpecifier sub, TypeSpecifier super) =>
            TypeHelpers.ToModelSpecifier(sub, provider, options)
                .IsSubtypeOf(TypeHelpers.ToModelSpecifier(super, provider, options))
            .Should().BeTrue();

        private void no(TypeSpecifier sub, TypeSpecifier super) =>
            TypeHelpers.ToModelSpecifier(sub, provider, options)
                .IsSubtypeOf(TypeHelpers.ToModelSpecifier(super, provider, options))
            .Should().BeFalse();

        [TestMethod]
        public void TypesAreSubtypesOfThemselves()
        {
            yes(Patient, Patient);
            yes(Resource, Resource);
            yes(SystemLibrary.BooleanType, SystemLibrary.BooleanType);
            yes(SystemLibrary.AnyType, SystemLibrary.AnyType);
        }

        [TestMethod]
        public void TypesAreNotProperSubtypesOfThemselves()
        {
            no(Patient, Patient);
            no(Resource, Resource);
            yes(Patient, Resource);
            no(SystemLibrary.BooleanType, SystemLibrary.BooleanType);
            yes(SystemLibrary.AnyType, SystemLibrary.AnyType); // Any is a subtype of Any?
        }

        [TestMethod]
        public void BaseclassesAreSubtypes()
        {
            yes(Patient, Resource);
            yes(Patient, DomainResource);
            yes(Patient, SystemLibrary.AnyType);

            yes(HumanName, Element);
            yes(HumanName, SystemLibrary.AnyType);

            yes(SystemLibrary.BooleanType, SystemLibrary.AnyType);
            SystemLibrary.Model.TryGetType("System.Vocabulary", out var vocabularyType).Should().BeTrue();
            yes(SystemLibrary.ValueSetType, TypeHelpers.ToElmSpecifier(vocabularyType!.ToTypeSpecifier()));
            yes(SystemLibrary.ValueSetType, SystemLibrary.AnyType);
        }

        [TestMethod]
        public void NotBaseclasses()
        {
            no(Patient, Observation);
            no(Observation, Patient);
            no(SystemLibrary.BooleanType, SystemLibrary.ValueSetType);
            no(SystemLibrary.DecimalType, SystemLibrary.IntegerType);
            no(SystemLibrary.IntegerType, SystemLibrary.DecimalType);
            no(Patient, Element);
        }

    }
}
