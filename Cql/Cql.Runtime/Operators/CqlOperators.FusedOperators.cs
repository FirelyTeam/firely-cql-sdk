#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Operators
{
    /// <remarks>
    /// Fused list operators. Generated CQL is in strict SSA form, so a <c>Where</c>/<c>Select</c>
    /// result is almost always assigned to a local that is read exactly once, as the source of the
    /// next list operator. Each of those intermediate locals is a fully materialized
    /// <see cref="List{T}"/> that exists only to be walked once and dropped. The operators below
    /// collapse the most common producer/consumer pairs into a single pass, removing the
    /// intermediate list.
    /// <para>
    /// Every one of them is deliberately NON-short-circuiting: the predicate and/or selector is
    /// invoked for exactly the same elements, in the same relative order, as the composed form, so
    /// that null-source handling, null-element handling, thrown exceptions and
    /// <see cref="ICqlOperators.Message{T}"/> side effects are preserved. The only thing removed is
    /// the intermediate materialization. Note in particular that <see cref="WhereAny{T}"/> does not
    /// stop at the first satisfying element even though <see cref="CqlOperators.Exists{T}"/> does:
    /// in the composed form <c>Where</c> has already evaluated the predicate over the whole source
    /// before <c>Exists</c> ever looks at the result.
    /// </para>
    /// <para>
    /// The result lists are intentionally not presized from the source's count: all of these
    /// operators may emit fewer elements than they consume, and the composed form they replace also
    /// grows its result list dynamically, so presizing would allocate a larger buffer than the code
    /// being replaced.
    /// </para>
    /// </remarks>
    internal partial class CqlOperators
    {
        #region WhereAny

        /// <summary>
        /// Equivalent to <c>Exists(Where(source, lambda))</c>.
        /// </summary>
        public bool? WhereAny<T>(IEnumerable<T>? source, Func<T, bool?> lambda)
        {
            // Where(null) is null, and Exists(null) is false.
            if (source == null)
                return false;

            var any = false;
            foreach (var element in source)
            {
                // Where evaluates the predicate for every element before Exists sees anything, so
                // the predicate must be evaluated for every element here too - no early exit.
                if ((lambda(element) ?? false) && element != null)
                    any = true;
            }
            return any;
        }

        #endregion

        #region WhereSelect

        /// <summary>
        /// Equivalent to <c>Select(Where(source, lambda), select)</c>.
        /// </summary>
        public IEnumerable<TR>? WhereSelect<T, TR>(IEnumerable<T>? source, Func<T, bool?> lambda, Func<T?, TR> select)
        {
            // Where(null) is null, and Select(null) is null.
            if (source == null)
                return null;

            var result = new List<TR>();
            foreach (var element in source)
            {
                if (lambda(element) ?? false)
                    result.Add(select(element));
            }
            return result;
        }

        #endregion

        #region SelectWhere

        /// <summary>
        /// Equivalent to <c>Where(Select(source, select), lambda)</c>.
        /// </summary>
        public IEnumerable<TR>? SelectWhere<T, TR>(IEnumerable<T?>? source, Func<T?, TR> select, Func<TR, bool?> lambda)
        {
            // Select(null) is null, and Where(null) is null.
            if (source == null)
                return null;

            var result = new List<TR>();
            foreach (var element in source)
            {
                // The selector runs for every source element, exactly as Select would.
                var projected = select(element);
                if (lambda(projected) ?? false)
                    result.Add(projected);
            }
            return result;
        }

        #endregion

        #region SelectDistinct

        /// <summary>
        /// Equivalent to <c>Distinct(Select(source, select))</c>.
        /// </summary>
        public IEnumerable<TR>? SelectDistinct<T, TR>(IEnumerable<T?>? source, Func<T?, TR> select)
        {
            // Select(null) is null, and Distinct(null) is null.
            if (source == null)
                return null;

            // Same shape as Distinct: a List<object?> of the kept items, one HashSet keyed by the
            // shared EqualityComparer, at most one null, and an array as the result.
            var result = new List<object?>();
            var seen = new HashSet<object>(EqualityComparer);
            var nullAdded = false;
            foreach (var element in source)
            {
                object? item = select(element);
                if (item == null)
                {
                    if (!nullAdded)
                    {
                        result.Add(null);
                        nullAdded = true;
                    }
                }
                else if (seen.Add(item))
                {
                    result.Add(item);
                }
            }
            return result.CastToArray<object?, TR>();
        }

        #endregion
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
