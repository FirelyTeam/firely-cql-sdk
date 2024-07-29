/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// A method group is a collection of methods with the same name, which we modelled here as a
/// subclass of ExpressionDef, so we can fit them into the same dictionary as other definitions.
/// </summary>
internal class MethodGroup : ExpressionDef
{
    public MethodGroup(string name, IEnumerable<ExpressionDef> methods)
    {
        this.name = name;
        Methods = methods.ToList();
    }

    public List<ExpressionDef> Methods { get; set; }

    public IReadOnlyCollection<ExpressionDef> GetOverloads(TypeSpecifier[] signature)
    {
        return Methods.Where(match).ToArray();

        bool match(ExpressionDef candidate) =>
            candidate switch
            {
                IHasSignature hasSig => hasSig.GetSignature().ExactlyMatches(signature),
                _                    => signature.Length == 0
            };
    }
}