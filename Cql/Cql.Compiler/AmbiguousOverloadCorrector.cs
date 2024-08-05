/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Ensures that there are no overloads with exactly the same signature.
/// </summary>
/// <remarks>This happens currently in QICore-based CQL, where the functions only differ
/// by profiles on the same resource, which results in the same signature after the QICore
/// profile names are erased by the compiler. This is a temporary fix that should be
/// corrected in the compiler. Until that moment, we'll just pick the first overload.
/// See https://github.com/FirelyTeam/firely-cql-sdk/issues/438 for more info.
/// </remarks>
internal class AmbiguousOverloadCorrector()
{
    public void Fix(Library library)
    {
        var statementSet = new HashSet<IDefinitionElement>(library.statements, new ExpressionSignatureComparer());

        // Since we just only put ExpressionDefs into the HashSet, we can safely cast them back.
        library.statements = statementSet.Cast<ExpressionDef>().ToArray();
    }
}