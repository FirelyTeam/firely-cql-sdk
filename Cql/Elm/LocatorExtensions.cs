/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Moves source positions between an <see cref="Element"/>'s <see cref="Element.locator"/> string and the
    /// position fields of a <see cref="Locator"/> annotation, such as a <see cref="CqlToElmError"/>.
    /// </summary>
    internal static class LocatorExtensions
    {
        /// <summary>
        /// Whether <paramref name="target"/> already carries a source position.
        /// </summary>
        public static bool HasPosition(this Locator target) => target.startLineSpecified;

        /// <summary>
        /// Sets the position fields of <paramref name="target"/> from an element locator, which is either
        /// <c>line:char-line:char</c> or, for a span of one character, <c>line:char</c>.
        /// </summary>
        /// <returns><see langword="false"/> when <paramref name="locator"/> is <see langword="null"/> or not in
        /// either form, in which case <paramref name="target"/> is left unchanged.</returns>
        public static bool TrySetPosition(this Locator target, string? locator)
        {
            if (!TryParse(locator, out var startLine, out var startChar, out var endLine, out var endChar))
                return false;

            target.startLine = startLine;
            target.startLineSpecified = true;
            target.startChar = startChar;
            target.startCharSpecified = true;
            target.endLine = endLine;
            target.endLineSpecified = true;
            target.endChar = endChar;
            target.endCharSpecified = true;
            return true;
        }

        /// <summary>
        /// Gives every <see cref="CqlToElmError"/> annotation on <paramref name="node"/> that has no position yet
        /// the position of <paramref name="locator"/>.
        /// </summary>
        public static void FillErrorPositions(this Element node, string? locator)
        {
            if (locator is null || node.annotation is not { } annotations)
                return;

            foreach (var error in annotations.OfType<CqlToElmError>())
            {
                if (!error.HasPosition())
                    error.TrySetPosition(locator);
            }
        }

        /// <summary>
        /// Gives every <see cref="CqlToElmError"/> in the tree rooted in <paramref name="root"/> that has no position
        /// yet the position of the closest element, the error's own element or one of its ancestors, that has a
        /// locator.
        /// </summary>
        public static void FillMissingErrorPositions(this Element root)
        {
            if (root.GetErrors().All(e => e.HasPosition()))
                return;

            new ErrorPositionFiller().Start(root);
        }

        private sealed class ErrorPositionFiller : BaseElmTreeWalker
        {
            protected override bool Process(object node)
            {
                if (node is Element { annotation: { } annotations }
                    && annotations.OfType<CqlToElmError>().Any(e => !e.HasPosition()))
                {
                    // The context stack runs from the root to this node.
                    var locator = Enumerable.Reverse(GetContextStack())
                                  .Select(t => (t.node as Element)?.locator)
                                  .FirstOrDefault(l => l is not null);
                    ((Element)node).FillErrorPositions(locator);
                }

                return false;
            }
        }

        private static bool TryParse(string? locator, out int startLine, out int startChar, out int endLine, out int endChar)
        {
            startLine = startChar = endLine = endChar = 0;
            if (string.IsNullOrWhiteSpace(locator))
                return false;

            var parts = locator!.Split('-');
            if (parts.Length is not (1 or 2))
                return false;

            if (!tryParsePoint(parts[0], out startLine, out startChar))
                return false;

            if (parts.Length == 1)
            {
                (endLine, endChar) = (startLine, startChar);
                return true;
            }

            return tryParsePoint(parts[1], out endLine, out endChar);

            static bool tryParsePoint(string point, out int line, out int @char)
            {
                line = @char = 0;
                var lc = point.Split(':');
                return lc.Length == 2
                       && int.TryParse(lc[0], NumberStyles.None, CultureInfo.InvariantCulture, out line)
                       && int.TryParse(lc[1], NumberStyles.None, CultureInfo.InvariantCulture, out @char);
            }
        }
    }
}
