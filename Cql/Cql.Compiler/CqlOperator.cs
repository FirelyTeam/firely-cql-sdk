using Hl7.Cql.Operators;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Enumerates the operators in the CQL specification.
    /// </summary>
    internal static class CqlOperator
    {
        public const string Select                           = nameof(ICqlOperators.Select);
        public const string Convert                          = nameof(ICqlOperators.Convert);
        public const string Coalesce                         = nameof(ICqlOperators.Coalesce);
        public const string Equal                            = nameof(ICqlOperators.Equal);
        public const string ListEquivalent                   = nameof(ICqlOperators.ListEquivalent);
        public const string Negate                           = nameof(ICqlOperators.Negate);
        public const string Collapse                         = nameof(ICqlOperators.Collapse);
        public const string ListContains                     = nameof(ICqlOperators.ListContains);
        public const string IntervalContains                 = nameof(ICqlOperators.IntervalContains);
        public const string Ends                             = nameof(ICqlOperators.Ends);
        public const string ListExcept                       = nameof(ICqlOperators.ListExcept);
        public const string IntervalExcept                   = nameof(ICqlOperators.IntervalExcept);
        public const string Expand                           = nameof(ICqlOperators.Expand); 
        public const string ListIncludesList                 = nameof(ICqlOperators.ListIncludesList);
        public const string ListIncludesElement              = nameof(ICqlOperators.ListIncludesElement);
        public const string IntervalIncludesInterval         = nameof(ICqlOperators.IntervalIncludesInterval);
        public const string IntervalIncludesElement          = nameof(ICqlOperators.IntervalIncludesElement);
        public const string ListIntersect                    = nameof(ICqlOperators.ListIntersect);
        public const string IntervalIntersect                = nameof(ICqlOperators.IntervalIntersect);
        public const string Meets                            = nameof(ICqlOperators.Meets);
        public const string Overlaps                         = nameof(ICqlOperators.Overlaps);
        public const string IntervalProperlyIncludesInterval = nameof(ICqlOperators.IntervalProperlyIncludesInterval);
        public const string ListProperlyIncludesList         = nameof(ICqlOperators.ListProperlyIncludesList);
        public const string ListProperlyIncludesElement      = nameof(ICqlOperators.ListProperlyIncludesElement);
        public const string IntervalProperlyIncludesElement  = nameof(ICqlOperators.IntervalProperlyIncludesElement);
        public const string Starts                           = nameof(ICqlOperators.Starts);
        public const string ListUnion                        = nameof(ICqlOperators.ListUnion);
        public const string IntervalUnion                    = nameof(ICqlOperators.IntervalUnion);
        public const string Width                            = nameof(ICqlOperators.Width);
        public const string Flatten                          = nameof(ICqlOperators.Flatten); // FlattenLateBoundList
        public const string CodeInValueSet                   = nameof(ICqlOperators.CodeInValueSet);
        public const string ConceptInValueSet                = nameof(ICqlOperators.ConceptInValueSet);
        public const string StringInValueSet                 = nameof(ICqlOperators.StringInValueSet);
        public const string Message                          = nameof(ICqlOperators.Message);
        public const string SelectMany                       = nameof(ICqlOperators.SelectMany); // SelectManyResults
        public const string Where                            = nameof(ICqlOperators.Where);
        public const string ListSort                         = nameof(ICqlOperators.ListSort);
        public const string SortBy                           = nameof(ICqlOperators.SortBy);
        public const string MeetsAfter                       = nameof(ICqlOperators.MeetsAfter);
        public const string MeetsBefore                      = nameof(ICqlOperators.MeetsBefore);
        public const string Ratio                            = nameof(Ratio);
        public const string OverlapsBefore                   = nameof(ICqlOperators.OverlapsBefore);
        public const string OverlapsAfter                    = nameof(ICqlOperators.OverlapsAfter);
        public const string ToList                           = nameof(ICqlOperators.ToList);
        public const string CodesInValueSet                  = nameof(ICqlOperators.CodesInValueSet);
        public const string ConceptsInValueSet               = nameof(ICqlOperators.ConceptsInValueSet);
        public const string StringsInValueSet                = nameof(ICqlOperators.StringsInValueSet);
        public const string Retrieve                         = nameof(Retrieve);
        public const string LateBoundProperty                = nameof(ICqlOperators.LateBoundProperty);
        public const string MinValue                         = nameof(MinValue);
        public const string MaxValue                         = nameof(MaxValue);
        public const string Aggregate                        = nameof(ICqlOperators.Aggregate);
        public const string CrossJoin                        = nameof(ICqlOperators.CrossJoin);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member