/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Compares two ExpressionDefs by their signature. If they are Expressions, their names are compared, if they
/// are functions, their names and signatures and fluentness are compared.
/// </summary>
internal class ExpressionSignatureComparer : IEqualityComparer<ExpressionDef>
{
    public bool Equals(ExpressionDef? x, ExpressionDef? y)
    {
        if (x == null || y == null) return x == y;

        if (x.Name != y.Name)
            return false;

        // If we're dealing with pure expressiondefs, we're done.
        if (x is not IHasSignature && y is not IHasSignature)
            return true;

        if (x is not IHasSignature left || y is not IHasSignature right)
            return false;

        if (left.Fluent != right.Fluent)
            return false;

        var leftSig = left.BuildSignatureFromOperands();
        var rightSig = right.BuildSignatureFromOperands();

        return leftSig.SequenceEqual(rightSig);
    }

    public int GetHashCode(ExpressionDef obj) => HashCode.Combine(obj.name);
}