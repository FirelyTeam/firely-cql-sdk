using FluentAssertions;
using FluentAssertions.Collections;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static Hl7.Cql.CqlToElm.Test.TestExtensions;
using M = Hl7.Cql.Model;
namespace Hl7.Cql.CqlToElm.Test
{
    internal static class TestExtensions
    {
        internal static readonly IModelProvider Provider = new BuiltinModelProvider(M.Models.ElmR1, M.Models.Fhir401);
        internal static readonly TypeConverter TypeConverter = new TypeConverter(Provider, new OptionsWrapper<CqlToElmOptions>(CqlToElmOptions.Default));
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

        public static ConversionResult<Expression> ShouldBe(this ConversionResult<Expression> result, int cost, Expression[]? e = null)
        {
            result.Success.Should().BeTrue();
            result.Error.Should().BeNull();
            result.Cost.Should().Be((ConversionCost)cost);

            if (e is not null)
                result.Result.Should().BeOfType<FunctionRef>().Subject.operand.Should().BeEquivalentTo(e);

            return result;
        }

        public static ConversionResult<Expression> Fails(this ConversionResult<Expression> result)
        {
            result.Success.Should().BeFalse();
            result.Error.Should().NotBeNull();

            return result;
        }

        public static ConversionResult<Expression> Cast(this FunctionDef def, Expression[] arguments)
        {
            var builder = new InvocationBuilder(Provider, TypeConverter);
            var result = builder.Invoke(def, null, arguments);
            return new(result, ConversionCost.ExactMatch);
        }

        public static ConversionResult<Expression> Assigned(this ConversionResult<Expression> result, TypeSpecifier t, TypeSpecifier? u = null)
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
}
