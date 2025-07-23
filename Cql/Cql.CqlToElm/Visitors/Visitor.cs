/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal abstract class Visitor<T> : cqlBaseVisitor<T>
    {
        protected static string FormatLocator(int startLine, int startCol, int endLine, int endCol) =>
            $"{startLine}:{startCol}-{endLine}:{endCol}";

        protected static bool UnitsAreCompatible(string unitsX, string unitsY) => unitsX == unitsY;

        protected static TypeSpecifier? PointType(TypeSpecifier? type)
        {
            if (type == null)
                return null;
            else if (type is IntervalTypeSpecifier intervalType)
            {
                return intervalType.pointType;
            }
            return null;
        }

    }
}
