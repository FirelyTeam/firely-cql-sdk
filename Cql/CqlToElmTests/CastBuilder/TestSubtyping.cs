using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using M = Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class TestSubtyping
    {
        private readonly IModelProvider provider = new ModelProvider(M.Models.ElmR1, M.Models.Fhir401);
        private readonly NamedTypeSpecifier Patient = forFhir("Patient");
        private readonly NamedTypeSpecifier Observation = forFhir("Observation");
        private readonly NamedTypeSpecifier Resource = forFhir("Resource");
        private readonly NamedTypeSpecifier DomainResource = forFhir("DomainResource");
        private readonly NamedTypeSpecifier HumanName = forFhir("HumanName");
        private readonly NamedTypeSpecifier Element = forFhir("Element");

        private static NamedTypeSpecifier forFhir(string typeName) =>
           new() { name = M.ModelInfoExtensions.MakeQualifiedTypeName(M.Models.Fhir401, typeName) };

        private void yes(TypeSpecifier sub, TypeSpecifier super) =>
            sub.IsSubtypeOf(super, provider).Should().BeTrue();

        private void no(TypeSpecifier sub, TypeSpecifier super) =>
            sub.IsSubtypeOf(super, provider).Should().BeFalse();

        [TestMethod]
        public void TypesAreSubtypesOfThemselves()
        {
            yes(Patient, Patient);
            yes(Resource, Resource);
            yes(SystemTypes.BooleanType, SystemTypes.BooleanType);
            yes(SystemTypes.AnyType, SystemTypes.AnyType);
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

        [TestMethod]
        public void CovariantSubtypes()
        {
            yes(Patient.ToListType(), Patient.ToListType());
            yes(Patient.ToListType(), Resource.ToListType());
            yes(SystemTypes.DecimalType.ToListType(), SystemTypes.AnyType.ToListType());
            no(Patient.ToListType(), Observation.ToListType());

            yes(Patient.ToIntervalType(), Patient.ToIntervalType());
            yes(Patient.ToIntervalType(), Resource.ToIntervalType());
            yes(SystemTypes.DecimalType.ToIntervalType(), SystemTypes.AnyType.ToIntervalType());
            no(Patient.ToIntervalType(), Observation.ToIntervalType());

            no(Patient.ToListType(), Patient);
            no(Patient, Patient.ToListType());
            no(Patient.ToIntervalType(), Patient.ToListType());
        }

        [TestMethod]
        public void CovariantTuples()
        {
            var tt1 = new TupleTypeSpecifier
            {
                element = new[]
                {
                    new TupleElementDefinition { name = "a", elementType = Patient },
                }
            };

            var ttS1 = new TupleTypeSpecifier
            {
                element = new[]
                {
                    new TupleElementDefinition { name = "a", elementType = Patient },
                }
            };


            var ttS2 = new TupleTypeSpecifier
            {
                element = new[]
               {
                    new TupleElementDefinition { name = "a", elementType = Resource },
               }
            };

            var tt3 = new TupleTypeSpecifier
            {
                element = new[]
                {
                    new TupleElementDefinition { name = "a", elementType = Observation },
                }
            };

            var tt4 = new TupleTypeSpecifier
            {
                element = new[]
                {
                    new TupleElementDefinition { name = "b", elementType = Patient },
                }
            };

            var tt5 = new TupleTypeSpecifier
            {
                element = new[]
                {
                    new TupleElementDefinition { name = "a", elementType = Patient },
                    new TupleElementDefinition { name = "b", elementType = Observation },
                }
            };

            yes(tt1, ttS1);
            yes(tt1, ttS1);
            no(tt1, tt3);
            no(tt1, tt4);
            no(tt1, tt5);
        }
    }
}
