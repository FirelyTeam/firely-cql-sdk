using System.IO;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Infrastructure;
using FluentAssertions.Collections;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Options;
using M = Hl7.Cql.Model;
namespace Hl7.Cql.CqlToElm.Test
{
    internal static partial class TestExtensions
    {
        internal static readonly IModelProvider Provider = new BuiltinModelProvider(M.Models.ElmR1, M.Models.Fhir401);
        internal static readonly CoercionProvider CoercionProvider = new CoercionProvider(Provider, new OptionsWrapper<CqlToElmOptions>(CqlToElmOptions.Default));
        internal static readonly NamedTypeSpecifier Patient = ForFhir("Patient");
        internal static readonly NamedTypeSpecifier Observation = ForFhir("Observation");
        internal static readonly NamedTypeSpecifier Resource = ForFhir("Resource");
        internal static readonly NamedTypeSpecifier DomainResource = ForFhir("DomainResource");
        internal static readonly NamedTypeSpecifier HumanName = ForFhir("HumanName");
        internal static readonly NamedTypeSpecifier Element = ForFhir("Element");

        internal static NamedTypeSpecifier ForFhir(string typeName) =>
            new() { name = M.QualifiedName.MakeQualifiedTypeName(M.Models.Fhir401, typeName) };

        public static A ContainSingleOfType<A>(this GenericCollectionAssertions<Expression> assertions) =>
            (A)(object)assertions.AllBeOfType<A>().And.ContainSingle().Subject!;

        public static Expression Expression(
            this CqlApi cqlApi,
            string expression,
            [System.Runtime.CompilerServices.CallerMemberName]
            string memberName = "")
        {
            return cqlApi.MakeLibraryFromExpression(expression, memberName: memberName).statements[0].expression;
        }
    }
}
