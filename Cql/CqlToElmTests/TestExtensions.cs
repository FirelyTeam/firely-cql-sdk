/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
