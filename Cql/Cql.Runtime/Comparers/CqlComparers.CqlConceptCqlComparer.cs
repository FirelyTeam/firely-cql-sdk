/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// Compares <see cref="CqlConcept"/> values by the semantics of the clinical operators (spec §9.B, Clinical
    /// Operators): equality is tuple equality over <see cref="CqlConcept.codes"/> and <see cref="CqlConcept.display"/>,
    /// and equivalence is a non-empty intersection of the codes.
    /// </summary>
    /// <remarks>
    /// A concept is null only when the reference is null: a concept without codes, or without a display, is still a
    /// concept. <c>memberComparer</c> compares the codes and the display, so each element is equal, and
    /// hashes, by its own type's semantics.
    /// </remarks>
    private class CqlConceptCqlComparer(CqlComparers memberComparer) :
        CqlComparer<CqlConcept>(CqlComparerEqualsImplementation.Compare)
    {
        private static IEqualityComparer<CqlCode> NewCodeEquivalenceComparer(
            CqlComparers codeComparer,
            string? precision) =>
            EqualityComparerFactory.Create<CqlCode>(
                (a, b) => codeComparer.Equivalent(a, b, precision),
                c => codeComparer.GetHashCodeValue(c));

        private readonly IEqualityComparer<CqlCode> _codeEquivalenceComparerNoPrecision = NewCodeEquivalenceComparer(memberComparer, null);

        /// <summary>
        /// Equality by tuple semantics, spec §9.B, Clinical Operators, Equal: "the operator will return true if and only
        /// if the values for each element by name are equal. If either argument is null, or has different components
        /// specified, the result is null."
        /// </summary>
        /// <remarks>
        /// An element that neither concept specifies takes no part, as for any tuple (§9.B, Comparison Operators, Equal),
        /// so two concepts without codes are equal exactly when their displays are. Of the elements both specify, one
        /// known to differ makes the concepts unequal; otherwise one whose equality is unknown makes the result null.
        /// </remarks>
        protected override int? CompareValues(
            CqlConcept x,
            CqlConcept y,
            string? precision)
        {
            if ((x.codes is null) != (y.codes is null) || (x.display is null) != (y.display is null))
                return null;

            int? codes = (x.codes, y.codes) is ({ } xCodes, { } yCodes) ? CompareCodes(xCodes, yCodes, precision) : 0;
            if (codes is not (null or 0))
                return codes;

            int? display = (x.display, y.display) is ({ } xDisplay, { } yDisplay)
                ? memberComparer.Compare(xDisplay, yDisplay, precision)
                : 0;
            if (display is not (null or 0))
                return display;

            return codes is null || display is null ? null : 0;
        }

        /// <summary>
        /// List equality over the codes, spec §9.B, List Operators, Equal: the same codes by value, in the same order,
        /// with two null codes equal. A code known to differ makes the lists unequal; otherwise a code whose equality is
        /// unknown makes the result null.
        /// </summary>
        private int? CompareCodes(
            IReadOnlyList<CqlCode> x,
            IReadOnlyList<CqlCode> y,
            string? precision)
        {
            if (x.Count != y.Count)
                return x.Count - y.Count;

            var unknown = false;
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] is null && y[i] is null)
                    continue;

                var compare = memberComparer.Compare(x[i], y[i], precision);
                if (compare is null)
                    unknown = true;
                else if (compare != 0)
                    return compare;
            }

            return unknown ? null : 0;
        }

        /// <summary>
        /// Equivalence, spec §9.B, Clinical Operators, Equivalent: "For Concept values, equivalence is defined as a
        /// non-empty intersection of the codes in each Concept using Code equivalence to determine the intersection. The
        /// display element is ignored for the purposes of determining Concept equivalence."
        /// </summary>
        protected override bool EquivalentValues(
            CqlConcept x,
            CqlConcept y,
            string? precision)
        {
            if (x.codes is not { } xCodes || y.codes is not { } yCodes)
                return false;

            var codeEquivalenceComparer = precision switch
            {
                null => _codeEquivalenceComparerNoPrecision,
                _    => NewCodeEquivalenceComparer(memberComparer, precision)
            };

            // Build the hash set from the shorter list.
            var (codesSet, compareSet) =
                xCodes.Count < yCodes.Count
                    ? (new HashSet<CqlCode>(xCodes, codeEquivalenceComparer), yCodes)
                    : (new HashSet<CqlCode>(yCodes, codeEquivalenceComparer), xCodes);
            return codesSet.Overlaps(compareSet);
        }

        /// <summary>
        /// Hashes the codes, in order, and the display, each by <c>memberComparer</c>, so that concepts
        /// that are equal hash alike.
        /// </summary>
        protected override int GetHashCodeValue(CqlConcept value)
        {
            var hash = new HashCode();
            if (value.codes is { } codes)
            {
                foreach (var code in codes)
                    hash.Add(memberComparer.GetHashCode(code));
            }

            hash.Add(memberComparer.GetHashCode(value.display));
            return hash.ToHashCode();
        }
    }
}
