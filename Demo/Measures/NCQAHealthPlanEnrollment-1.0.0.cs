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
		var m_ = (Coverage C) =>
		{
			var a_ = (C?.Period as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = context?.Operators.Start(b_);
			var d_ = context?.Operators.DateFrom(c_);
			var e_ = (C?.Period as object);
			var f_ = NCQAFHIRBase_1_0_0.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = context?.Operators.DateFrom(g_);
			var i_ = context?.Operators.Interval(d_, h_, true, true);
			var j_ = context?.Operators.Start(participationPeriod);
			var k_ = context?.Operators.End(participationPeriod);
			var l_ = context?.Operators.Interval(j_, k_, true, true);

			return context?.Operators.IntervalIntersectsInterval<CqlDate>(i_, l_);
		};

		return context?.Operators.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, m_);
	}


    [CqlDeclaration("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals) =>
		NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(Intervals);


    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		var w_ = (CqlInterval<CqlDate> _Coverage1) => Intervals;
		var x_ = (CqlInterval<CqlDate> _Coverage1, CqlInterval<CqlDate> _Coverage2) =>
		{
			var a_ = _Coverage1;
			var b_ = _Coverage2;

			return new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = a_,
				Coverage2 = b_,
			};
		};
		var y_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, w_, x_);
		var z_ = (Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk) =>
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
			var q_ = (bool?)(p_ == null);
			var r_ = context?.Operators.Not(q_);

			return context?.Operators.And(n_, r_);
		};
		var aa_ = context?.Operators.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(y_, z_);
		var ab_ = (Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk) =>
		{
			var s_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage1;
			var t_ = context?.Operators.Start(s_);
			var u_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var v_ = context?.Operators.End(u_);

			return context?.Operators.Interval(t_, v_, true, true);
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(aa_, ab_);
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
		var o_ = (Coverage C) =>
		{
			var k_ = (C?.Type?.Coding as IEnumerable<Coding>);
			var l_ = (Coding cTypeCoding) =>
			{
				var a_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
				var b_ = (NCQATerminology_1_0_0.managed_care_policy() as object);
				var c_ = context?.Operators.Equivalent(a_, b_);
				var d_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
				var e_ = (NCQATerminology_1_0_0.retiree_health_program() as object);
				var f_ = context?.Operators.Equivalent(d_, e_);
				var g_ = context?.Operators.Or(c_, f_);
				var h_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
				var i_ = (NCQATerminology_1_0_0.subsidized_health_program() as object);
				var j_ = context?.Operators.Equivalent(h_, i_);

				return context?.Operators.Or(g_, j_);
			};
			var m_ = context?.Operators.WhereOrNull<Coding>(k_, l_);

			return context?.Operators.ExistsInList<Coding>(m_);
		};
		var p_ = context?.Operators.WhereOrNull<Coverage>(Coverage, o_);
		var q_ = (Coverage HPCoverageResource) =>
		{
			var n_ = (bool?)(HPCoverageResource == null);

			return context?.Operators.Not(n_);
		};

		return context?.Operators.WhereOrNull<Coverage>(p_, q_);
	}


    [CqlDeclaration("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        if ((context?.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
		{
			var b__ = this.All_Coverage_Info(Coverage, participationPeriod);
			var c__ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
			{
				var a__ = (bool?)(@this?.CollapsedFinal == null);

				return context?.Operators.Not(a__);
			};
			var d__ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b__, c__);
			var e__ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
			var f__ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d__, e__);
			var g__ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(f__);
			var h__ = (CqlInterval<CqlDate> FinalInterval) => context?.Operators.ElementInInterval<CqlDate>(AnchorDate, FinalInterval, null);
			var i__ = context?.Operators.WhereOrNull<CqlInterval<CqlDate>>(g__, h__);

			return context?.Operators.ExistsInList<CqlInterval<CqlDate>>(i__);
		}
        else if ((context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null)) ?? false))
		{
			var i__ = (Coverage @this) =>
			{
				var a__ = (bool?)(@this?.Period == null);

				return context?.Operators.Not(a__);
			};
			var j__ = context?.Operators.WhereOrNull<Coverage>(Coverage, i__);
			var k__ = (Coverage @this) => @this?.Period;
			var l__ = context?.Operators.SelectOrNull<Coverage, Period>(j__, k__);
			var m__ = (Period Cperiod) =>
			{
				var b__ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
				var c__ = context?.Operators.Start(b__);
				var d__ = context?.Operators.DateFrom(c__);
				var e__ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
				var f__ = context?.Operators.End(e__);
				var g__ = context?.Operators.DateFrom(f__);
				var h__ = context?.Operators.Interval(d__, g__, true, true);

				return context?.Operators.ElementInInterval<CqlDate>(AnchorDate, h__, null);
			};
			var n__ = context?.Operators.WhereOrNull<Period>(l__, m__);

			return context?.Operators.ExistsInList<Period>(n__);
		}
        else if ((AnchorDate == null))
            return (bool?)true;
        else
            return (bool?)false;
    }


    [CqlDeclaration("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var i_ = this.Health_Plan_Coverage_Resources(Coverage);
		var j_ = this.All_Coverage_Info(i_, participationPeriod);
		var k_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = (bool?)(@this?.CollapsedFinal == null);

			return context?.Operators.Not(a_);
		};
		var l_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(j_, k_);
		var m_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var n_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(l_, m_);
		var o_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(n_);
		var p_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, o_);
		var q_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			p_,
		};
		var r_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var b_ = (GapsInEnrollment?.Interval_Count as object);
			var c_ = ((int?)1 as object);
			var d_ = context?.Operators.LessOrEqual(b_, c_);
			var e_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
			var f_ = context?.Operators.LessOrEqual(e_, (AllowedGapDays as object));
			var g_ = context?.Operators.And(d_, f_);
			var h_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);

			return context?.Operators.And(g_, h_);
		};
		var s_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(q_, r_);

		return context?.Operators.SingleOrNull<bool?>(s_);
	}


    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var g_ = (Coverage C) =>
		{
			var c_ = (C?.Type?.Coding as IEnumerable<Coding>);
			var d_ = (Coding cTypeCoding) =>
			{
				var a_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
				var b_ = (NCQATerminology_1_0_0.drug_policy() as object);

				return context?.Operators.Equivalent(a_, b_);
			};
			var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);

			return context?.Operators.ExistsInList<Coding>(e_);
		};
		var h_ = context?.Operators.WhereOrNull<Coverage>(Coverage, g_);
		var i_ = (Coverage pharmacyCoverageResource) =>
		{
			var f_ = (bool?)(pharmacyCoverageResource == null);

			return context?.Operators.Not(f_);
		};

		return context?.Operators.WhereOrNull<Coverage>(h_, i_);
	}


    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var i_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		var j_ = this.All_Coverage_Info(i_, participationPeriod);
		var k_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = (bool?)(@this?.CollapsedFinal == null);

			return context?.Operators.Not(a_);
		};
		var l_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(j_, k_);
		var m_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var n_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(l_, m_);
		var o_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(n_);
		var p_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, o_);
		var q_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			p_,
		};
		var r_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var b_ = (GapsInEnrollment?.Interval_Count as object);
			var c_ = ((int?)1 as object);
			var d_ = context?.Operators.LessOrEqual(b_, c_);
			var e_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
			var f_ = context?.Operators.LessOrEqual(e_, (AllowedGapDays as object));
			var g_ = context?.Operators.And(d_, f_);
			var h_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);

			return context?.Operators.And(g_, h_);
		};
		var s_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(q_, r_);

		return context?.Operators.SingleOrNull<bool?>(s_);
	}


    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var g_ = (Coverage C) =>
		{
			var c_ = (C?.Type?.Coding as IEnumerable<Coding>);
			var d_ = (Coding cTypeCoding) =>
			{
				var a_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
				var b_ = (NCQATerminology_1_0_0.mental_health_policy() as object);

				return context?.Operators.Equivalent(a_, b_);
			};
			var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);

			return context?.Operators.ExistsInList<Coding>(e_);
		};
		var h_ = context?.Operators.WhereOrNull<Coverage>(Coverage, g_);
		var i_ = (Coverage mentalHealthCoverageResource) =>
		{
			var f_ = (bool?)(mentalHealthCoverageResource == null);

			return context?.Operators.Not(f_);
		};

		return context?.Operators.WhereOrNull<Coverage>(h_, i_);
	}


    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var i_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		var j_ = this.All_Coverage_Info(i_, participationPeriod);
		var k_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = (bool?)(@this?.CollapsedFinal == null);

			return context?.Operators.Not(a_);
		};
		var l_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(j_, k_);
		var m_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var n_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(l_, m_);
		var o_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(n_);
		var p_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, o_);
		var q_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			p_,
		};
		var r_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var b_ = (GapsInEnrollment?.Interval_Count as object);
			var c_ = ((int?)1 as object);
			var d_ = context?.Operators.LessOrEqual(b_, c_);
			var e_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
			var f_ = context?.Operators.LessOrEqual(e_, (AllowedGapDays as object));
			var g_ = context?.Operators.And(d_, f_);
			var h_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);

			return context?.Operators.And(g_, h_);
		};
		var s_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(q_, r_);

		return context?.Operators.SingleOrNull<bool?>(s_);
	}


}