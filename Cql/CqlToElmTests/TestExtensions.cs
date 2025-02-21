using FluentAssertions.Collections;
using Hl7.Cql.Elm;
using Expression = Hl7.Cql.Elm.Expression;
using M = Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Test;

internal static class TestExtensions
{
    internal static NamedTypeSpecifier ForFhir(string typeName) =>
        new() { name = M.QualifiedName.MakeQualifiedTypeName(M.Models.Fhir401, typeName) };

    public static A ContainSingleOfType<A>(this GenericCollectionAssertions<Expression> assertions) =>
        (A)(object)assertions.AllBeOfType<A>().And.ContainSingle().Subject!;
}