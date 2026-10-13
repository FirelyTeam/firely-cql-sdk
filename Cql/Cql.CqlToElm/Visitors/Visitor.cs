/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal abstract class Visitor<T> : cqlBaseVisitor<T> where T : class
    {
        /// <summary>
        /// The results produced by <see cref="UnhandledRule"/>, so that a rule built from unhandled
        /// rules is reported as a whole instead of passing up the result of one of its parts.
        /// </summary>
        private readonly HashSet<T> _unhandledRuleResults = new(ReferenceEqualityComparer.Instance);

        /// <summary>
        /// Dispatches a parser rule that has no dedicated visit method.
        /// </summary>
        /// <remarks>
        /// A rule with a single child is a wrapper and yields whatever that child yields. A rule with
        /// several children yields the result of its one child that produced a result; results of parts
        /// that were themselves unhandled do not count, since such parts (an identifier, a display clause)
        /// carry no value of their own. Any other outcome (no result, or several results) means the rule
        /// has no translation, and the rule yields <see cref="UnhandledRule"/>.
        /// </remarks>
        public override T VisitChildren(IRuleNode node)
        {
            if (node is not ParserRuleContext context)
                return base.VisitChildren(node);

            if (context.ChildCount == 1)
                return Visit(context.GetChild(0)) ?? unhandled()!;

            T? single = null;
            var resultCount = 0;

            for (var i = 0; i < context.ChildCount; i++)
            {
                if (!ShouldVisitNextChild(node, single!))
                    break;

                var result = context.GetChild(i).Accept(this);
                if (result is null || _unhandledRuleResults.Contains(result))
                    continue;

                single = result;
                resultCount++;
            }

            return resultCount == 1
                ? single!
                : unhandled() ?? single!;

            T? unhandled()
            {
                var result = UnhandledRule(context);
                if (result is not null)
                    _unhandledRuleResults.Add(result);
                return result;
            }
        }

        /// <summary>
        /// Produces the result for a parser rule that this visitor has no translation for.
        /// </summary>
        /// <returns>The result to use in place of the rule, or <see langword="null"/> to fall back to the
        /// last result produced by one of the rule's children.</returns>
        protected virtual T? UnhandledRule(ParserRuleContext context) => null;

        /// <summary>
        /// The name of the grammar rule <paramref name="context"/> was parsed from.
        /// </summary>
        protected static string RuleName(ParserRuleContext context) =>
            context.RuleIndex >= 0 && context.RuleIndex < cqlParser.ruleNames.Length
                ? cqlParser.ruleNames[context.RuleIndex]
                : context.GetType().Name;

        /// <summary>
        /// The source text <paramref name="context"/> was parsed from, including whitespace and comments.
        /// </summary>
        protected static string SourceText(ParserRuleContext context) =>
            context.Start is { } start && context.Stop is { } stop && stop.StopIndex >= start.StartIndex
                ? start.InputStream.GetText(Antlr4.Runtime.Misc.Interval.Of(start.StartIndex, stop.StopIndex))
                : context.GetText();

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
