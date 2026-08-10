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
    /// invoked for exactly the same elements, in the same relative order, as the composed form.
    /// While every lambda runs to completion that makes the two forms indistinguishable — same
    /// result, same null-source and null-element handling, same
    /// <see cref="ICqlOperators.Message{T}"/> side effects — and the only thing removed is the
    /// intermediate materialization. Note in particular that <see cref="WhereAny{T}"/> does not
    /// stop at the first satisfying element even though <see cref="CqlOperators.Exists{T}"/> does:
    /// in the composed form <c>Where</c> has already evaluated the predicate over the whole source
    /// before <c>Exists</c> ever looks at the result.
    /// </para>
    /// <para>
    /// A throwing lambda is the one case where the two forms diverge, and only in the two-lambda
    /// operators. The composed form runs the first lambda over the whole source before the second
    /// one sees anything, so an exception out of the first leaves the second uninvoked; the fused
    /// operators interleave the two per element, so the other lambda has already run for the
    /// elements preceding the failure — with whatever side effects it carries. Over
    /// <c>["a", "b"]</c> with a predicate that throws on <c>"b"</c>,
    /// <c>Select(Where(s, p), f)</c> invokes the selector for nothing while
    /// <see cref="WhereSelect{T,TR}"/> has already invoked it for <c>"a"</c>;
    /// <see cref="SelectWhere{T,TR}"/> is symmetric for a throwing selector. As long as only one of
    /// the two lambdas ever throws, the exception that surfaces is the same one either way and all
    /// that differs is the work already done when it does. Only if both would throw, on different
    /// elements, can the surfacing exception itself differ: the fused form surfaces whichever throw
    /// its single pass reaches first, which need not be the one the composition reaches. Extend the
    /// example above with a selector that also throws, on <c>"a"</c>, and
    /// <see cref="WhereSelect{T,TR}"/> surfaces the selector's exception where
    /// <c>Select(Where(s, p), f)</c> still surfaces the predicate's.
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
