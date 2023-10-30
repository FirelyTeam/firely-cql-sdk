using FluentAssertions;
using FluentAssertions.Collections;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static Hl7.Cql.CqlToElm.Test.TestExtensions;
using M = Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Test
{
    internal static class TestExtensions
    {
        internal static readonly IModelProvider Provider = new ModelProvider(M.Models.ElmR1, M.Models.Fhir401);
        internal static readonly NamedTypeSpecifier Patient = ForFhir("Patient");
        internal static readonly NamedTypeSpecifier Observation = ForFhir("Observation");
        internal static readonly NamedTypeSpecifier Resource = ForFhir("Resource");
        internal static readonly NamedTypeSpecifier DomainResource = ForFhir("DomainResource");
        internal static readonly NamedTypeSpecifier HumanName = ForFhir("HumanName");
        internal static readonly NamedTypeSpecifier Element = ForFhir("Element");

        internal static NamedTypeSpecifier ForFhir(string typeName) =>
            new() { name = M.QualifiedName.MakeQualifiedTypeName(M.Models.Fhir401, typeName) };

        public static readonly ParameterTypeSpecifier T = new() { parameterName = "T" };
        public static readonly ParameterTypeSpecifier U = new() { parameterName = "U" };

        public static ResolveResult<Expression> ShouldBe(this ResolveResult<Expression> result, int cost, Expression[]? e = null)
        {
            result.Success.Should().BeTrue();
            result.Error.Should().BeNull();
            result.Cost.Should().Be(cost);

            if (e is not null)
                result.Result.Should().BeOfType<FunctionRef>().Subject.operand.Should().BeEquivalentTo(e);

            return result;
        }

        public static ResolveResult<Expression> Fails(this ResolveResult<Expression> result)
        {
            result.Success.Should().BeFalse();
            result.Error.Should().NotBeNull();

            return result;
        }

        public static ResolveResult<Expression> Cast(this FunctionDef def, Expression[] arguments)
        {
            var builder = new InvocationBuilder(Provider);
            var result = builder.Build(def, arguments);
            return result;
        }

        public static ResolveResult<Expression> Assigned(this ResolveResult<Expression> result, TypeSpecifier t, TypeSpecifier? u = null)
        {
            if (u is null)
                result.Result.resultTypeSpecifier.Should().Be(new ChoiceTypeSpecifier { choice = new TypeSpecifier[] { t, U, SystemTypes.BooleanType } });
            else
                result.Result.resultTypeSpecifier.Should().Be(new ChoiceTypeSpecifier { choice = new TypeSpecifier[] { t, u, SystemTypes.BooleanType } });

            return result;
        }

        public static A ContainSingleOfType<A>(this GenericCollectionAssertions<Expression> assertions) =>
            (A)(object)assertions.AllBeOfType<A>().And.ContainSingle().Subject!;
    }

    [TestClass]
    public class TestCastBuilder
    {
        private static readonly ChoiceTypeSpecifier testReturnType = new() { choice = new TypeSpecifier[] { T, U, SystemTypes.BooleanType } };

        private FunctionDef buildF(params TypeSpecifier[] args) =>
            new()
            {
                name = "test",
                resultTypeSpecifier = testReturnType,
                operand = args.Select((t, i) => new OperandDef { name = $"arg_{i + 1}", operandTypeSpecifier = t }).ToArray()
            };

        private Expression[] buildA(params TypeSpecifier[] arg) => arg.Select(a => new Literal { resultTypeSpecifier = a }).ToArray();

        [TestMethod]
        public void SubclassesBecomeIdentityCast()
        {
            var f = buildF(DomainResource);

            var args = buildA(Patient);
            f.Cast(args).ShouldBe(cost: 0, args);

            var args2 = buildA(DomainResource);
            f.Cast(args2).ShouldBe(cost: 0, args2);

            f.Cast(buildA(Resource)).Fails();
            f.Cast(buildA(SystemTypes.CodeType)).Fails();
            f.Cast(buildA(SystemTypes.AnyType)).Fails();
        }

        [TestMethod]
        public void AssignsToGeneric()
        {
            var f = buildF(T);

            var args = buildA(Patient);
            f.Cast(args).ShouldBe(cost: 0, args).Assigned(Patient);

            var f2 = buildF(T, T);
            var args2 = buildA(Patient, Patient);
            f2.Cast(args2).ShouldBe(cost: 0, args2).Assigned(Patient);

            var args3 = buildA(Patient, Observation);
            f2.Cast(args3).Fails();  // T cannot be both Patient and Observation

            var f3 = buildF(T, U);
            var args4 = buildA(Patient, Observation.ToListType());
            f3.Cast(args4).ShouldBe(cost: 0, args4).Assigned(Patient, Observation.ToListType());
        }

        [TestMethod]
        public void AssignNullToAny()
        {
            var f = buildF(SystemTypes.DecimalType);
            var arg = new[] { new Null { } }; // untyped null
            var @as = f.Cast(arg).ShouldBe(cost: 1).Result.Should().BeOfType<FunctionRef>().Subject.operand.Should().ContainSingleOfType<As>();
            @as.operand.Should().Be(arg[0]);
            @as.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType);

            var f2 = buildF(T.ToListType());
            var @as2 = f2.Cast(arg).ShouldBe(cost: 100).Result.Should().BeOfType<FunctionRef>().Subject.operand.Should().ContainSingleOfType<As>();
            @as2.operand.Should().Be(arg[0]);
            @as2.resultTypeSpecifier.Should().Be(SystemTypes.AnyType.ToListType());
        }

        [TestMethod]
        public void WorksWithMultipleArguments()
        {
            var f = buildF(Resource, SystemTypes.BooleanType, SystemTypes.AnyType);

            var args = buildA(Patient, SystemTypes.BooleanType, HumanName);
            f.Cast(args).ShouldBe(cost: 0, args);

            var args2 = buildA(Resource, SystemTypes.BooleanType, SystemTypes.BooleanType);
            f.Cast(args2).ShouldBe(cost: 0, args2);

            f.Cast(buildA(Patient, SystemTypes.CodeType, SystemTypes.AnyType)).Fails();
            f.Cast(buildA(SystemTypes.CodeType, SystemTypes.CodeType, SystemTypes.BooleanType)).Fails();

            var f2 = buildF(T, T.ToListType());
            var args3 = buildA(Patient, Patient.ToListType());
            f2.Cast(args3).ShouldBe(cost: 0, args3).Assigned(Patient);

            // test covariance
            var f3 = buildF(T, T);
            var args4 = buildA(SystemTypes.AnyType.ToListType(), Patient.ToListType());
            f3.Cast(args4).ShouldBe(cost: 0, args4).Assigned(SystemTypes.AnyType.ToListType());

            var f4 = buildF(T, U.ToListType());
            var args5 = buildA(Patient, Observation.ToListType());
            f4.Cast(args5).ShouldBe(cost: 0, args5).Assigned(Patient, Observation);
        }
    }
}
