using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("NCQAHealthPlanEnrollment", "1.0.0")]
public class NCQAHealthPlanEnrollment_1_0_0
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public NCQAHealthPlanEnrollment_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        NCQACQLBase_1_0_0 = new NCQACQLBase_1_0_0(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQATerminology_1_0_0 = new NCQATerminology_1_0_0(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);

    }
    #region Dependencies

    public NCQACQLBase_1_0_0 NCQACQLBase_1_0_0 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQATerminology_1_0_0 NCQATerminology_1_0_0 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }

    #endregion

    [CqlDeclaration("CoverageIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> CoverageIntervals(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        Func<Coverage,CqlInterval<CqlDate>> m_ = (C) => 
        {
            var a_ = (C?.Period as object);
            var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
            var c_ = context?.Operators.Start(b_);
            var d_ = context?.Operators.DateFrom(c_);
            var g_ = context?.Operators.End(b_);
            var h_ = context?.Operators.DateFrom(g_);
            var i_ = context?.Operators.Interval(d_, 
				h_, 
				true, 
				true);
            var j_ = context?.Operators.Start(participationPeriod);
            var k_ = context?.Operators.End(participationPeriod);
            var l_ = context?.Operators.Interval(j_, 
				k_, 
				true, 
				true);
            return context?.Operators.IntervalIntersectsInterval<CqlDate>(i_, 
				l_);
        };
        return context?.Operators.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, 
			m_);
    }

    [CqlDeclaration("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        return NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(Intervals);
    }

    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        Func<CqlInterval<CqlDate>,IEnumerable<CqlInterval<CqlDate>>> a_ = (_Coverage1) => Intervals;
        Func<CqlInterval<CqlDate>,CqlInterval<CqlDate>,Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK> d_ = (_Coverage1, _Coverage2) => 
        {
            var b_ = _Coverage1;
            var c_ = _Coverage2;
            return new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = b_,
				Coverage2 = c_,
			};
        };
        var e_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, 
			a_, 
			d_);
        Func<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK,bool?> q_ = (tuple_gdeceaqjofqdgfgxnexuvihlk) => 
        {
            var f_ = context?.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage1);
            var g_ = context?.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2);
            var h_ = context?.Operators.Quantity(1m, 
				"day");
            var i_ = context?.Operators.Subtract(g_, 
				h_);
            var l_ = context?.Operators.Add(g_, 
				h_);
            var m_ = context?.Operators.Interval(i_, 
				l_, 
				true, 
				true);
            var n_ = context?.Operators.ElementInInterval<CqlDate>(f_, 
				m_, 
				null);
            bool? o_ = ((bool?)(context?.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2) == null));
            var p_ = context?.Operators.Not(o_);
            return context?.Operators.And(n_, 
				p_);
        };
        var r_ = context?.Operators.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(e_, 
			q_);
        Func<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK,CqlInterval<CqlDate>> u_ = (tuple_gdeceaqjofqdgfgxnexuvihlk) => 
        {
            var s_ = context?.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage1);
            var t_ = context?.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2);
            return context?.Operators.Interval(s_, 
				t_, 
				true, 
				true);
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(r_, 
			u_);
    }

    [CqlDeclaration("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        var a_ = this.Collapsed_Coverage_Intervals(collapsedI);
        var b_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
        var c_ = context?.Operators.ListUnion<CqlInterval<CqlDate>>(a_, 
			b_);
        return NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(c_);
    }

    [CqlDeclaration("All Coverage Info")]
    public IEnumerable<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        Func<Coverage,Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> m_ = (C) => 
        {
            var a_ = this.CoverageIntervals(Coverage, 
				participationPeriod);
            var b_ = this.Collapsed_Coverage_Intervals(a_);
            var d_ = this.Collapsed_Coverage_Adjacent_Intervals(b_);
            var g_ = this.Collapsed_Final_Coverage_Intervals(b_, 
				d_);
            return new Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC
			{
				IntervalInfo = a_,
				Collapsed = b_,
				Adjacent = d_,
				CollapsedFinal = g_,
			};
        };
        return context?.Operators.SelectOrNull<Coverage, Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, 
			m_);
    }

    [CqlDeclaration("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
    {
        Func<Coverage,bool?> n_ = (C) => 
        {
            var a_ = (C?.Type?.Coding as IEnumerable<Coding>);
            Func<Coding,bool?> l_ = (cTypeCoding) => 
            {
                var b_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
                var c_ = (NCQATerminology_1_0_0.managed_care_policy() as object);
                var d_ = context?.Operators.Equivalent(b_, 
					c_);
                var f_ = (NCQATerminology_1_0_0.retiree_health_program() as object);
                var g_ = context?.Operators.Equivalent(b_, 
					f_);
                var h_ = context?.Operators.Or(d_, 
					g_);
                var j_ = (NCQATerminology_1_0_0.subsidized_health_program() as object);
                var k_ = context?.Operators.Equivalent(b_, 
					j_);
                return context?.Operators.Or(h_, 
					k_);
            };
            var m_ = context?.Operators.WhereOrNull<Coding>(a_, 
				l_);
            return context?.Operators.ExistsInList<Coding>(m_);
        };
        var o_ = context?.Operators.WhereOrNull<Coverage>(Coverage, 
			n_);
        Func<Coverage,bool?> q_ = (HPCoverageResource) => 
        {
            bool? p_ = ((bool?)(HPCoverageResource == null));
            return context?.Operators.Not(p_);
        };
        return context?.Operators.WhereOrNull<Coverage>(o_, 
			q_);
    }

    [CqlDeclaration("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        if ((context?.Operators.ElementInInterval<CqlDate>(AnchorDate, 
				participationPeriod, 
				null) ?? false))
            {
                var a__ = this.All_Coverage_Info(Coverage, 
					participationPeriod);
                Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,bool?> c__ = (@this) => 
                {
                    bool? b__ = ((bool?)(@this?.CollapsedFinal == null));
                    return context?.Operators.Not(b__);
                };
                var d__ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(a__, 
					c__);
                Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,IEnumerable<CqlInterval<CqlDate>>> e__ = (@this) => 
                {
                    return @this?.CollapsedFinal;
                };
                var f__ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d__, 
					e__);
                var g__ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(f__);
                Func<CqlInterval<CqlDate>,bool?> h__ = (FinalInterval) => 
                {
                    return context?.Operators.ElementInInterval<CqlDate>(AnchorDate, 
						FinalInterval, 
						null);
                };
                var i__ = context?.Operators.WhereOrNull<CqlInterval<CqlDate>>(g__, 
					h__);
                return context?.Operators.ExistsInList<CqlInterval<CqlDate>>(i__);
            }
        else if ((context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(AnchorDate, 
					participationPeriod, 
					null)) ?? false))
            {
                Func<Coverage,bool?> b__ = (@this) => 
                {
                    bool? a__ = ((bool?)(@this?.Period == null));
                    return context?.Operators.Not(a__);
                };
                var c__ = context?.Operators.WhereOrNull<Coverage>(Coverage, 
					b__);
                Func<Coverage,Period> d__ = (@this) => 
                {
                    return @this?.Period;
                };
                var e__ = context?.Operators.SelectOrNull<Coverage, Period>(c__, 
					d__);
                Func<Period,bool?> o__ = (Cperiod) => 
                {
                    var f__ = (Cperiod as object);
                    var g__ = NCQAFHIRBase_1_0_0.Normalize_Interval(f__);
                    var h__ = context?.Operators.Start(g__);
                    var i__ = context?.Operators.DateFrom(h__);
                    var l__ = context?.Operators.End(g__);
                    var m__ = context?.Operators.DateFrom(l__);
                    var n__ = context?.Operators.Interval(i__, 
						m__, 
						true, 
						true);
                    return context?.Operators.ElementInInterval<CqlDate>(AnchorDate, 
						n__, 
						null);
                };
                var p__ = context?.Operators.WhereOrNull<Period>(e__, 
					o__);
                return context?.Operators.ExistsInList<Period>(p__);
            }
        else if ((AnchorDate == null))
            return ((bool?)true);

        else 
            return ((bool?)false);

    }


    [CqlDeclaration("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        var c_ = this.Health_Plan_Coverage_Resources(Coverage);
        var d_ = this.All_Coverage_Info(c_, 
			participationPeriod);
        Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,bool?> f_ = (@this) => 
        {
            bool? e_ = ((bool?)(@this?.CollapsedFinal == null));
            return context?.Operators.Not(e_);
        };
        var g_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(d_, 
			f_);
        Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,IEnumerable<CqlInterval<CqlDate>>> h_ = (@this) => 
        {
            return @this?.CollapsedFinal;
        };
        var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(g_, 
			h_);
        var j_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(i_);
        var b_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, 
			j_);
        var a_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			b_,
		};
        Func<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD,bool?> s_ = (GapsInEnrollment) => 
        {
            var k_ = (GapsInEnrollment?.Interval_Count as object);
            var l_ = (((int?)1) as object);
            var m_ = context?.Operators.LessOrEqual(k_, 
				l_);
            var n_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
            var o_ = (AllowedGapDays as object);
            var p_ = context?.Operators.LessOrEqual(n_, 
				o_);
            var q_ = context?.Operators.And(m_, 
				p_);
            var r_ = this.Anchor_Date_Criteria(Coverage, 
				AnchorDate, 
				participationPeriod);
            return context?.Operators.And(q_, 
				r_);
        };
        var t_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(a_, 
			s_);
        return context?.Operators.SingleOrNull<bool?>(t_);
    }

    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
    {
        Func<Coverage,bool?> f_ = (C) => 
        {
            var a_ = (C?.Type?.Coding as IEnumerable<Coding>);
            Func<Coding,bool?> d_ = (cTypeCoding) => 
            {
                var b_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
                var c_ = (NCQATerminology_1_0_0.drug_policy() as object);
                return context?.Operators.Equivalent(b_, 
					c_);
            };
            var e_ = context?.Operators.WhereOrNull<Coding>(a_, 
				d_);
            return context?.Operators.ExistsInList<Coding>(e_);
        };
        var g_ = context?.Operators.WhereOrNull<Coverage>(Coverage, 
			f_);
        Func<Coverage,bool?> i_ = (pharmacyCoverageResource) => 
        {
            bool? h_ = ((bool?)(pharmacyCoverageResource == null));
            return context?.Operators.Not(h_);
        };
        return context?.Operators.WhereOrNull<Coverage>(g_, 
			i_);
    }

    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        var c_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
        var d_ = this.All_Coverage_Info(c_, 
			participationPeriod);
        Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,bool?> f_ = (@this) => 
        {
            bool? e_ = ((bool?)(@this?.CollapsedFinal == null));
            return context?.Operators.Not(e_);
        };
        var g_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(d_, 
			f_);
        Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,IEnumerable<CqlInterval<CqlDate>>> h_ = (@this) => 
        {
            return @this?.CollapsedFinal;
        };
        var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(g_, 
			h_);
        var j_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(i_);
        var b_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, 
			j_);
        var a_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			b_,
		};
        Func<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD,bool?> s_ = (GapsInEnrollment) => 
        {
            var k_ = (GapsInEnrollment?.Interval_Count as object);
            var l_ = (((int?)1) as object);
            var m_ = context?.Operators.LessOrEqual(k_, 
				l_);
            var n_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
            var o_ = (AllowedGapDays as object);
            var p_ = context?.Operators.LessOrEqual(n_, 
				o_);
            var q_ = context?.Operators.And(m_, 
				p_);
            var r_ = this.Anchor_Date_Criteria(PharmCoverage, 
				AnchorDate, 
				participationPeriod);
            return context?.Operators.And(q_, 
				r_);
        };
        var t_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(a_, 
			s_);
        return context?.Operators.SingleOrNull<bool?>(t_);
    }

    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
    {
        Func<Coverage,bool?> f_ = (C) => 
        {
            var a_ = (C?.Type?.Coding as IEnumerable<Coding>);
            Func<Coding,bool?> d_ = (cTypeCoding) => 
            {
                var b_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
                var c_ = (NCQATerminology_1_0_0.mental_health_policy() as object);
                return context?.Operators.Equivalent(b_, 
					c_);
            };
            var e_ = context?.Operators.WhereOrNull<Coding>(a_, 
				d_);
            return context?.Operators.ExistsInList<Coding>(e_);
        };
        var g_ = context?.Operators.WhereOrNull<Coverage>(Coverage, 
			f_);
        Func<Coverage,bool?> i_ = (mentalHealthCoverageResource) => 
        {
            bool? h_ = ((bool?)(mentalHealthCoverageResource == null));
            return context?.Operators.Not(h_);
        };
        return context?.Operators.WhereOrNull<Coverage>(g_, 
			i_);
    }

    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        var c_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
        var d_ = this.All_Coverage_Info(c_, 
			participationPeriod);
        Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,bool?> f_ = (@this) => 
        {
            bool? e_ = ((bool?)(@this?.CollapsedFinal == null));
            return context?.Operators.Not(e_);
        };
        var g_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(d_, 
			f_);
        Func<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC,IEnumerable<CqlInterval<CqlDate>>> h_ = (@this) => 
        {
            return @this?.CollapsedFinal;
        };
        var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(g_, 
			h_);
        var j_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(i_);
        var b_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, 
			j_);
        var a_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			b_,
		};
        Func<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD,bool?> s_ = (GapsInEnrollment) => 
        {
            var k_ = (GapsInEnrollment?.Interval_Count as object);
            var l_ = (((int?)1) as object);
            var m_ = context?.Operators.LessOrEqual(k_, 
				l_);
            var n_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
            var o_ = (AllowedGapDays as object);
            var p_ = context?.Operators.LessOrEqual(n_, 
				o_);
            var q_ = context?.Operators.And(m_, 
				p_);
            var r_ = this.Anchor_Date_Criteria(MHCoverage, 
				AnchorDate, 
				participationPeriod);
            return context?.Operators.And(q_, 
				r_);
        };
        var t_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(a_, 
			s_);
        return context?.Operators.SingleOrNull<bool?>(t_);
    }

}