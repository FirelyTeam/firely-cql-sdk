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
		var a_ = (Coverage C) =>
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

		return context?.Operators.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, a_);
	}


    [CqlDeclaration("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals) =>
		NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(Intervals);


    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		var a_ = (CqlInterval<CqlDate> _Coverage1) => Intervals;
		var b_ = (CqlInterval<CqlDate> _Coverage1, CqlInterval<CqlDate> _Coverage2) =>
		{
			var a_ = _Coverage1;
			var b_ = _Coverage2;

			return new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = a_,
				Coverage2 = b_,
			};
		};
		var c_ = context?.Operators.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, a_, b_);
		var d_ = (Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk) =>
		{
			var a_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage1;
			var b_ = context?.Operators.End(a_);
			var c_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.Quantity(1m, "day");
			var f_ = context?.Operators.Subtract(d_, e_);
			var g_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var h_ = context?.Operators.Start(g_);
			var i_ = context?.Operators.Quantity(1m, "day");
			var j_ = context?.Operators.Add(h_, i_);
			var k_ = context?.Operators.Interval(f_, j_, true, true);
			var l_ = context?.Operators.ElementInInterval<CqlDate>(b_, k_, null);
			var m_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var n_ = context?.Operators.Start(m_);
			var o_ = (bool?)(n_ == null);
			var p_ = context?.Operators.Not(o_);

			return context?.Operators.And(l_, p_);
		};
		var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(c_, d_);
		var f_ = (Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk) =>
		{
			var a_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage1;
			var b_ = context?.Operators.Start(a_);
			var c_ = tuple_gdeceaqjofqdgfgxnexuvihlk?.Coverage2;
			var d_ = context?.Operators.End(c_);

			return context?.Operators.Interval(b_, d_, true, true);
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(e_, f_);
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
		var a_ = (Coverage C) =>
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

		return context?.Operators.SelectOrNull<Coverage, Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, a_);
	}


    [CqlDeclaration("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var a_ = (Coverage C) =>
		{
			var a_ = (C?.Type?.Coding as IEnumerable<Coding>);
			var b_ = (Coding cTypeCoding) =>
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
			var c_ = context?.Operators.WhereOrNull<Coding>(a_, b_);

			return context?.Operators.ExistsInList<Coding>(c_);
		};
		var b_ = context?.Operators.WhereOrNull<Coverage>(Coverage, a_);
		var c_ = (Coverage HPCoverageResource) =>
		{
			var a_ = (bool?)(HPCoverageResource == null);

			return context?.Operators.Not(a_);
		};

		return context?.Operators.WhereOrNull<Coverage>(b_, c_);
	}


    [CqlDeclaration("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        if ((context?.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
		{
			var a_ = this.All_Coverage_Info(Coverage, participationPeriod);
			var b_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
			{
				var a_ = (bool?)(@this?.CollapsedFinal == null);

				return context?.Operators.Not(a_);
			};
			var c_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(a_, b_);
			var d_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
			var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(c_, d_);
			var f_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(e_);
			var g_ = (CqlInterval<CqlDate> FinalInterval) => context?.Operators.ElementInInterval<CqlDate>(AnchorDate, FinalInterval, null);
			var h_ = context?.Operators.WhereOrNull<CqlInterval<CqlDate>>(f_, g_);

			return context?.Operators.ExistsInList<CqlInterval<CqlDate>>(h_);
		}
        else if ((context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null)) ?? false))
		{
			var a_ = (Coverage @this) =>
			{
				var a_ = (bool?)(@this?.Period == null);

				return context?.Operators.Not(a_);
			};
			var b_ = context?.Operators.WhereOrNull<Coverage>(Coverage, a_);
			var c_ = (Coverage @this) => @this?.Period;
			var d_ = context?.Operators.SelectOrNull<Coverage, Period>(b_, c_);
			var e_ = (Period Cperiod) =>
			{
				var a_ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
				var b_ = context?.Operators.Start(a_);
				var c_ = context?.Operators.DateFrom(b_);
				var d_ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
				var e_ = context?.Operators.End(d_);
				var f_ = context?.Operators.DateFrom(e_);
				var g_ = context?.Operators.Interval(c_, f_, true, true);

				return context?.Operators.ElementInInterval<CqlDate>(AnchorDate, g_, null);
			};
			var f_ = context?.Operators.WhereOrNull<Period>(d_, e_);

			return context?.Operators.ExistsInList<Period>(f_);
		}
        else if ((AnchorDate == null))
            return (bool?)true;
        else
            return (bool?)false;
    }


    [CqlDeclaration("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Health_Plan_Coverage_Resources(Coverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		var c_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = (bool?)(@this?.CollapsedFinal == null);

			return context?.Operators.Not(a_);
		};
		var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		var e_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		var j_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var a_ = (GapsInEnrollment?.Interval_Count as object);
			var b_ = ((int?)1 as object);
			var c_ = context?.Operators.LessOrEqual(a_, b_);
			var d_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
			var e_ = context?.Operators.LessOrEqual(d_, (AllowedGapDays as object));
			var f_ = context?.Operators.And(c_, e_);
			var g_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);

			return context?.Operators.And(f_, g_);
		};
		var k_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);

		return context?.Operators.SingleOrNull<bool?>(k_);
	}


    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var a_ = (Coverage C) =>
		{
			var a_ = (C?.Type?.Coding as IEnumerable<Coding>);
			var b_ = (Coding cTypeCoding) =>
			{
				var a_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
				var b_ = (NCQATerminology_1_0_0.drug_policy() as object);

				return context?.Operators.Equivalent(a_, b_);
			};
			var c_ = context?.Operators.WhereOrNull<Coding>(a_, b_);

			return context?.Operators.ExistsInList<Coding>(c_);
		};
		var b_ = context?.Operators.WhereOrNull<Coverage>(Coverage, a_);
		var c_ = (Coverage pharmacyCoverageResource) =>
		{
			var a_ = (bool?)(pharmacyCoverageResource == null);

			return context?.Operators.Not(a_);
		};

		return context?.Operators.WhereOrNull<Coverage>(b_, c_);
	}


    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		var c_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = (bool?)(@this?.CollapsedFinal == null);

			return context?.Operators.Not(a_);
		};
		var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		var e_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		var j_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var a_ = (GapsInEnrollment?.Interval_Count as object);
			var b_ = ((int?)1 as object);
			var c_ = context?.Operators.LessOrEqual(a_, b_);
			var d_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
			var e_ = context?.Operators.LessOrEqual(d_, (AllowedGapDays as object));
			var f_ = context?.Operators.And(c_, e_);
			var g_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);

			return context?.Operators.And(f_, g_);
		};
		var k_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);

		return context?.Operators.SingleOrNull<bool?>(k_);
	}


    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var a_ = (Coverage C) =>
		{
			var a_ = (C?.Type?.Coding as IEnumerable<Coding>);
			var b_ = (Coding cTypeCoding) =>
			{
				var a_ = (FHIRHelpers_4_0_001.ToCode(cTypeCoding) as object);
				var b_ = (NCQATerminology_1_0_0.mental_health_policy() as object);

				return context?.Operators.Equivalent(a_, b_);
			};
			var c_ = context?.Operators.WhereOrNull<Coding>(a_, b_);

			return context?.Operators.ExistsInList<Coding>(c_);
		};
		var b_ = context?.Operators.WhereOrNull<Coverage>(Coverage, a_);
		var c_ = (Coverage mentalHealthCoverageResource) =>
		{
			var a_ = (bool?)(mentalHealthCoverageResource == null);

			return context?.Operators.Not(a_);
		};

		return context?.Operators.WhereOrNull<Coverage>(b_, c_);
	}


    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		var c_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) =>
		{
			var a_ = (bool?)(@this?.CollapsedFinal == null);

			return context?.Operators.Not(a_);
		};
		var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		var e_ = (Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => @this?.CollapsedFinal;
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context?.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		var j_ = (Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment) =>
		{
			var a_ = (GapsInEnrollment?.Interval_Count as object);
			var b_ = ((int?)1 as object);
			var c_ = context?.Operators.LessOrEqual(a_, b_);
			var d_ = (GapsInEnrollment?.Total_Days_In_Longest_Interval as object);
			var e_ = context?.Operators.LessOrEqual(d_, (AllowedGapDays as object));
			var f_ = context?.Operators.And(c_, e_);
			var g_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);

			return context?.Operators.And(f_, g_);
		};
		var k_ = context?.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);

		return context?.Operators.SingleOrNull<bool?>(k_);
	}


}