/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// Compares the code and system using the specified comparers.
    /// </summary>
    private class CqlConceptCqlComparer : CqlComparerNew<CqlConcept>
    {
        private IEqualityComparer<CqlCode> NewCodeEquivalenceComparer(string precision) =>
            EqualityComparerFactory.Create<CqlCode>(
                (a, b) => CodeComparer.Equivalent(a, b, precision),
                c => CodeComparer.GetHashCode(c));

        private readonly IEqualityComparer<CqlCode> _codeEquivalenceComparerNoPrecision;

        /// <summary>
        /// Compares the code and system using the specified comparers.
        /// </summary>
        public CqlConceptCqlComparer(ICqlComparer<object> codeComparer)
        {
            CodeComparer = codeComparer;
            _codeEquivalenceComparerNoPrecision = NewCodeEquivalenceComparer(null!);
        }

        private ICqlComparer<object> CodeComparer { get; }

        protected override bool IsNull([NotNullWhen(false)] CqlConcept? value)
        {
            return value?.codes is null;
        }

        protected override int? CompareValues(
            CqlConcept left,
            CqlConcept right,
            string? precision)
        {
            var xCodes = left.codes!.OrderBy(code => code.code).ToArray();
            var yCodes = right.codes!.OrderBy(code => code.code).ToArray();

            if (xCodes.Length != yCodes.Length)
                return xCodes.Length - yCodes.Length;

            for (int i = 0; i < xCodes.Length; i++)
            {
                // Remark: ElementAtOrDefault(i) is used to handle the case where the two arrays are not the same length
                var xCode = xCodes.ElementAtOrDefault(i);
                var yCode = yCodes.ElementAtOrDefault(i);
                var compare = CodeComparer.Compare(xCode, yCode, precision);
                if (compare != 0)
                    return compare;
            }
            return 0;
        }

        // public int? Compare(CqlConcept? left, CqlConcept? right, string? precision = null)
        // {
        //     if (left == null || right == null || left.codes == null || right.codes == null)
        //         return null;
        //
        //     var xCodes = left.codes.OrderBy(code => code.code).ToArray();
        //     var yCodes = right.codes.OrderBy(code => code.code).ToArray();
        //
        //     if (xCodes.Length != yCodes.Length)
        //         return xCodes.Length - yCodes.Length;
        //
        //     for (int i = 0; i < xCodes.Length; i++)
        //     {
        //         // Remark: ElementAtOrDefault(i) is used to handle the case where the two arrays are not the same length
        //         var xCode = xCodes.ElementAtOrDefault(i);
        //         var yCode = yCodes.ElementAtOrDefault(i);
        //         var compare = CodeComparer.Compare(xCode, yCode, precision);
        //         if (compare != 0)
        //             return compare;
        //     }
        //     return 0;
        // }

        protected override int GetEqualsStrategy()
        {
            return EQUALS_VIA_COMPARE;
        }

        // public bool? Equals(CqlConcept? left, CqlConcept? right, string? precision = null)
        // {
        //     if (left == null || right == null)
        //         return null;
        //     else return Compare(left, right, precision) == 0;
        // }

        protected override bool EquivalentValues(
            CqlConcept left,
            CqlConcept right,
            string? precision)
        {
            // Rule:
            // * "For Concept values, equivalence means the values have at least one equivalent code."
            //   See: https://cql.hl7.org/02-authorsguide.html#comparison-operators:~:text=For%20Concept%20values%2C%20equivalence%20means%20the%20values%20have%20at%20least%20one%20equivalent%20code.
            // * "For Concept values, equivalence is defined as a non-empty intersection of the codes in each Concept."
            //   See: https://cql.hl7.org/09-b-cqlreference.html#equivalent:~:text=determining%20Code%20equivalence.-,For%20Concept%20values%2C%20equivalence%20is%20defined%20as%20a%20non%2Dempty%20intersection%20of%20the%20codes%20in%20each%20Concept.,-Note%20that%20this

            // Rule:
            // * "Note that this operator will always return true or false, even if either or both of its arguments are null, or contain null components."
            //   See: https://cql.hl7.org/09-b-cqlreference.html#equivalent:~:text=each%20Concept.-,Note%20that%20this%20operator%20will%20always%20return%20true%20or%20false%2C%20even%20if%20either%20or%20both%20of%20its%20arguments%20are%20null%2C%20or%20contain%20null%20components.,-The%20following%20examples

            var codeEquivalenceComparer = precision switch
            {
                null => _codeEquivalenceComparerNoPrecision,
                _    => NewCodeEquivalenceComparer(precision)
            };

            // More performance to have the hashset with the smallest set
            var (codesSet, compareSet) =
                left.codes!.Length < right.codes!.Length
                    ? (new HashSet<CqlCode>(left.codes, codeEquivalenceComparer), right.codes)
                    : (new HashSet<CqlCode>(right.codes, codeEquivalenceComparer), left.codes);
            bool isEquivalent = codesSet.Overlaps(compareSet);
            return isEquivalent;
        }

        // public bool Equivalent(CqlConcept? left, CqlConcept? right, string? precision = null)
        // {
        //     // Rule:
        //     // * "For Concept values, equivalence means the values have at least one equivalent code."
        //     //   See: https://cql.hl7.org/02-authorsguide.html#comparison-operators:~:text=For%20Concept%20values%2C%20equivalence%20means%20the%20values%20have%20at%20least%20one%20equivalent%20code.
        //     // * "For Concept values, equivalence is defined as a non-empty intersection of the codes in each Concept."
        //     //   See: https://cql.hl7.org/09-b-cqlreference.html#equivalent:~:text=determining%20Code%20equivalence.-,For%20Concept%20values%2C%20equivalence%20is%20defined%20as%20a%20non%2Dempty%20intersection%20of%20the%20codes%20in%20each%20Concept.,-Note%20that%20this
        //
        //     // Rule:
        //     // * "Note that this operator will always return true or false, even if either or both of its arguments are null, or contain null components."
        //     //   See: https://cql.hl7.org/09-b-cqlreference.html#equivalent:~:text=each%20Concept.-,Note%20that%20this%20operator%20will%20always%20return%20true%20or%20false%2C%20even%20if%20either%20or%20both%20of%20its%20arguments%20are%20null%2C%20or%20contain%20null%20components.,-The%20following%20examples
        //
        //     if (left == null || right == null || left.codes == null || right.codes == null)
        //         return false;
        //
        //     var codeEquivalenceComparer = precision switch
        //     {
        //         null => _codeEquivalenceComparerNoPrecision,
        //         _ => NewCodeEquivalenceComparer(precision)
        //     };
        //
        //     // More performance to have the hashset with the smallest set
        //     var (codesSet, compareSet) =
        //         left.codes.Length < right.codes.Length
        //          ? (new HashSet<CqlCode>(left.codes, codeEquivalenceComparer), right.codes)
        //          : (new HashSet<CqlCode>(right.codes, codeEquivalenceComparer), left.codes);
        //     bool isEquivalent = codesSet.Overlaps(compareSet);
        //     return isEquivalent;
        // }

        protected override int GetHashCodeValue(CqlConcept value)
        {
            int baseCode = GetHashCodeNull();
            foreach (var code in value.codes!)
            {
                var codeHashCode = CodeComparer.GetHashCode(code);
                baseCode ^= codeHashCode;
            }
            return baseCode;
        }

        // public int GetHashCode(CqlConcept? value)
        // {
        //     int baseCode = typeof(CqlConcept).GetHashCode();
        //     if (value == null || value.codes == null)
        //         return baseCode;
        //     foreach (var code in value.codes)
        //     {
        //         var codeHashCode = CodeComparer.GetHashCode(code);
        //         baseCode ^= codeHashCode;
        //     }
        //     return baseCode;
        // }
    }
}
