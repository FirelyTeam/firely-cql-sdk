using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
		var o_ = (Coverage C) =>
		{
			var a_ = C?.Period;
			var b_ = (a_ as object);
			var c_ = NCQAFHIRBase_1_0_0.Normalize_Interval(b_);
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.DateFrom(d_);
			var f_ = C?.Period;
			var g_ = (f_ as object);
			var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.DateFrom(i_);
			var k_ = context?.Operators.Interval(e_, j_, true, true);
			var l_ = context?.Operators.Start(participationPeriod);
			var m_ = context?.Operators.End(participationPeriod);
			var n_ = context?.Operators.Interval(l_, m_, true, true);

			return context?.Operators.IntervalIntersectsInterval<CqlDate>(k_, n_);
		};

		return context?.Operators.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, o_);
	}


    [CqlDeclaration("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals) =>
		NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(Intervals);


    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		var x_ = (CqlInterval<CqlDate> _Coverage1) => Intervals;
		var y_ = (CqlInterval<CqlDate> _Coverage1, CqlInterval<CqlDate> _Coverage2) =>
		{
			var a_ = _Coverage1;
			var b_ = _Coverage2;

			return new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = a_,
				Coverage2 = b_,
			};
		};
		var z_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, x_, y_);
		var aa_ = (Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk) =>
		{
			var c_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage1;
			var d_ = context?.Operators.End(c_);
			var e_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var f_ = context?.Operators.Start(e_);
			var g_ = context?.Operators.Quantity(1m, "day");
			var h_ = context?.Operators.Subtract(f_, g_);
			var i_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var j_ = context?.Operators.Start(i_);
			var k_ = context?.Operators.Quantity(1m, "day");
			var l_ = context?.Operators.Add(j_, k_);
			var m_ = context?.Operators.Interval(h_, l_, true, true);
			var n_ = context?.Operators.ElementInInterval<CqlDate>(d_, m_, null);
			var o_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var p_ = context?.Operators.Start(o_);
			var q_ = (p_ == null);
			var r_ = (bool?)q_;
			var s_ = context?.Operators.Not(r_);

			return context?.Operators.And(n_, s_);
		};
		var ab_ = context?.Operators.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(z_, aa_);
		var ac_ = (Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk) =>
		{
			var t_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage1;
			var u_ = context?.Operators.Start(t_);
			var v_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var w_ = context?.Operators.End(v_);

			return context?.Operators.Interval(u_, w_, true, true);
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(ab_, ac_);
	}


    [CqlDeclaration("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		var a_ = this.Collapsed_Coverage_Intervals(collapsedI);
		var b_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
		var c_ = context?.Operators.ListUnion<CqlInterval<CqlDate>>(a_, b_);

		return NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(c_);
	}


    [CqlDeclaration("All Coverage Info")]
    public IEnumerable<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		var m_ = (Coverage C) =>
		{
			var a_ = this.CoverageIntervals(Coverage, participationPeriod);
			var b_ = this.CoverageIntervals(Coverage, participationPeriod);
			var c_ = this.Collapsed_Coverage_Intervals(b_);
			var d_ = this.CoverageIntervals(Coverage, participationPeriod);
			var e_ = this.Collapsed_Coverage_Intervals(d_);
			var f_ = this.Collapsed_Coverage_Adjacent_Intervals(e_);
			var g_ = this.CoverageIntervals(Coverage, participationPeriod);
			var h_ = this.Collapsed_Coverage_Intervals(g_);
			var i_ = this.CoverageIntervals(Coverage, participationPeriod);
			var j_ = this.Collapsed_Coverage_Intervals(i_);
			var k_ = this.Collapsed_Coverage_Adjacent_Intervals(j_);
			var l_ = this.Collapsed_Final_Coverage_Intervals(h_, k_);

			return new Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC
			{
				IntervalInfo = a_,
				Collapsed = c_,
				Adjacent = f_,
				CollapsedFinal = l_,
			};
		};

		return context?.Operators.SelectOrNull<Coverage, Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, m_);
	}


    [CqlDeclaration("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var x_ = (Coverage C) =>
		{
			var q_ = C?.Type;
			var r_ = q_?.Coding;
			var s_ = (r_ as IEnumerable<Coding>);
			var t_ = (Coding cTypeCoding) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var b_ = (a_ as object);
				var c_ = NCQATerminology_1_0_0.managed_care_policy();
				var d_ = (c_ as object);
				var e_ = context?.Operators.Equivalent(b_, d_);
				var f_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var g_ = (f_ as object);
				var h_ = NCQATerminology_1_0_0.retiree_health_program();
				var i_ = (h_ as object);
				var j_ = context?.Operators.Equivalent(g_, i_);
				var k_ = context?.Operators.Or(e_, j_);
				var l_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var m_ = (l_ as object);
				var n_ = NCQATerminology_1_0_0.subsidized_health_program();
				var o_ = (n_ as object);
				var p_ = context?.Operators.Equivalent(m_, o_);

				return context?.Operators.Or(k_, p_);
			};
			var u_ = context?.Operators.WhereOrNull<Coding>(s_, t_);

			return context?.Operators.ExistsInList<Coding>(u_);
		};
		var y_ = context?.Operators.WhereOrNull<Coverage>(Coverage, x_);
		var z_ = (Coverage HPCoverageResource) =>
		{
			var v_ = (HPCoverageResource == null);
			var w_ = (bool?)v_;

			return context?.Operators.Not(w_);
		};

		return context?.Operators.WhereOrNull<Coverage>(y_, z_);
	}


    [CqlDeclaration("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        if ((context?.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
		{
			var d__ = this.All_Coverage_Info(Coverage, participationPeriod);
			var e__ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
			{
				var a__ = @this?.CollapsedFinal;
				var b__ = (a__ == null);
				var c__ = (bool?)b__;

				return context?.Operators.Not(c__);
			};
			var f__ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(d__, e__);
			var g__ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
			var h__ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(f__, g__);
			var i__ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(h__);
			var j__ = (CqlInterval<CqlDate> FinalInterval) => context?.Operators.ElementInInterval<CqlDate>(AnchorDate, FinalInterval, null);
			var k__ = context?.Operators.WhereOrNull<CqlInterval<CqlDate>>(i__, j__);

			return context?.Operators.ExistsInList<CqlInterval<CqlDate>>(k__);
		}
        else if ((context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null)) ?? false))
		{
			var k__ = (Coverage @this) =>
			{
				var a__ = @this?.Period;
				var b__ = (a__ == null);
				var c__ = (bool?)b__;

				return context?.Operators.Not(c__);
			};
			var l__ = context?.Operators.WhereOrNull<Coverage>(Coverage, k__);
			var m__ = (Coverage @this) => @this?.Period;
			var n__ = context?.Operators.SelectOrNull<Coverage, Period>(l__, m__);
			var o__ = (Period Cperiod) =>
			{
				var d__ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
				var e__ = context?.Operators.Start(d__);
				var f__ = context?.Operators.DateFrom(e__);
				var g__ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
				var h__ = context?.Operators.End(g__);
				var i__ = context?.Operators.DateFrom(h__);
				var j__ = context?.Operators.Interval(f__, i__, true, true);

				return context?.Operators.ElementInInterval<CqlDate>(AnchorDate, j__, null);
			};
			var p__ = context?.Operators.WhereOrNull<Period>(n__, o__);

			return context?.Operators.ExistsInList<Period>(p__);
		}
        else if ((AnchorDate == null))
            return (bool?)true;
        else
            return (bool?)false;
    }


    [CqlDeclaration("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var n_ = this.Health_Plan_Coverage_Resources(Coverage);
		var o_ = this.All_Coverage_Info(n_, participationPeriod);
		var p_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = @this?.CollapsedFinal;
			var b_ = (a_ == null);
			var c_ = (bool?)b_;

			return context?.Operators.Not(c_);
		};
		var q_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(o_, p_);
		var r_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var s_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(q_, r_);
		var t_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(s_);
		var u_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, t_);
		var v_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			u_,
		};
		var w_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var d_ = GapsInEnrollment?.Interval_Count;
			var e_ = d_;
			var f_ = (int?)1;
			var g_ = f_;
			var h_ = context?.Operators.LessOrEqual(e_, g_);
			var i_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var j_ = i_;
			var k_ = context?.Operators.LessOrEqual(j_, AllowedGapDays);
			var l_ = context?.Operators.And(h_, k_);
			var m_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);

			return context?.Operators.And(l_, m_);
		};
		var x_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(v_, w_);

		return context?.Operators.SingleOrNull<bool?>(x_);
	}


    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var l_ = (Coverage C) =>
		{
			var e_ = C?.Type;
			var f_ = e_?.Coding;
			var g_ = (f_ as IEnumerable<Coding>);
			var h_ = (Coding cTypeCoding) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var b_ = (a_ as object);
				var c_ = NCQATerminology_1_0_0.drug_policy();
				var d_ = (c_ as object);

				return context?.Operators.Equivalent(b_, d_);
			};
			var i_ = context?.Operators.WhereOrNull<Coding>(g_, h_);

			return context?.Operators.ExistsInList<Coding>(i_);
		};
		var m_ = context?.Operators.WhereOrNull<Coverage>(Coverage, l_);
		var n_ = (Coverage pharmacyCoverageResource) =>
		{
			var j_ = (pharmacyCoverageResource == null);
			var k_ = (bool?)j_;

			return context?.Operators.Not(k_);
		};

		return context?.Operators.WhereOrNull<Coverage>(m_, n_);
	}


    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var n_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		var o_ = this.All_Coverage_Info(n_, participationPeriod);
		var p_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = @this?.CollapsedFinal;
			var b_ = (a_ == null);
			var c_ = (bool?)b_;

			return context?.Operators.Not(c_);
		};
		var q_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(o_, p_);
		var r_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var s_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(q_, r_);
		var t_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(s_);
		var u_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, t_);
		var v_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			u_,
		};
		var w_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var d_ = GapsInEnrollment?.Interval_Count;
			var e_ = d_;
			var f_ = (int?)1;
			var g_ = f_;
			var h_ = context?.Operators.LessOrEqual(e_, g_);
			var i_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var j_ = i_;
			var k_ = context?.Operators.LessOrEqual(j_, AllowedGapDays);
			var l_ = context?.Operators.And(h_, k_);
			var m_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);

			return context?.Operators.And(l_, m_);
		};
		var x_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(v_, w_);

		return context?.Operators.SingleOrNull<bool?>(x_);
	}


    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var l_ = (Coverage C) =>
		{
			var e_ = C?.Type;
			var f_ = e_?.Coding;
			var g_ = (f_ as IEnumerable<Coding>);
			var h_ = (Coding cTypeCoding) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var b_ = (a_ as object);
				var c_ = NCQATerminology_1_0_0.mental_health_policy();
				var d_ = (c_ as object);

				return context?.Operators.Equivalent(b_, d_);
			};
			var i_ = context?.Operators.WhereOrNull<Coding>(g_, h_);

			return context?.Operators.ExistsInList<Coding>(i_);
		};
		var m_ = context?.Operators.WhereOrNull<Coverage>(Coverage, l_);
		var n_ = (Coverage mentalHealthCoverageResource) =>
		{
			var j_ = (mentalHealthCoverageResource == null);
			var k_ = (bool?)j_;

			return context?.Operators.Not(k_);
		};

		return context?.Operators.WhereOrNull<Coverage>(m_, n_);
	}


    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var n_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		var o_ = this.All_Coverage_Info(n_, participationPeriod);
		var p_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = @this?.CollapsedFinal;
			var b_ = (a_ == null);
			var c_ = (bool?)b_;

			return context?.Operators.Not(c_);
		};
		var q_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(o_, p_);
		var r_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var s_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(q_, r_);
		var t_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(s_);
		var u_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, t_);
		var v_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			u_,
		};
		var w_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var d_ = GapsInEnrollment?.Interval_Count;
			var e_ = d_;
			var f_ = (int?)1;
			var g_ = f_;
			var h_ = context?.Operators.LessOrEqual(e_, g_);
			var i_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var j_ = i_;
			var k_ = context?.Operators.LessOrEqual(j_, AllowedGapDays);
			var l_ = context?.Operators.And(h_, k_);
			var m_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);

			return context?.Operators.And(l_, m_);
		};
		var x_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(v_, w_);

		return context?.Operators.SingleOrNull<bool?>(x_);
	}


}