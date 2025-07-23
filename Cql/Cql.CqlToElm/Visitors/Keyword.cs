/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Antlr4.Runtime.Tree;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class Keyword
    {
        public static CqlKeyword? Parse(this IParseTree tree)
        {
            var text = tree.GetText().Replace(' ', '_');
            return Enum.TryParse<CqlKeyword>(text, ignoreCase: true, out var keyword) ? keyword : null;
        }
    }
}
