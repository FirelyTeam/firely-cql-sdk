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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("NCQAHealthPlanEnrollment", "1.0.0")]
public class NCQAHealthPlanEnrollment_1_0_0
{

    public static NCQAHealthPlanEnrollment_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("CoverageIntervals")]
	public IEnumerable<CqlInterval<CqlDate>> CoverageIntervals(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		CqlInterval<CqlDate> a_(Coverage C)
		{
			var c_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (C?.Period as object));
			var d_ = context.Operators.Start(c_);
			var e_ = context.Operators.DateFrom(d_);
			var g_ = context.Operators.End(c_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = context.Operators.Interval(e_, h_, true, true);
			var j_ = context.Operators.Start(participationPeriod);
			var k_ = context.Operators.End(participationPeriod);
			var l_ = context.Operators.Interval(j_, k_, true, true);
			var m_ = context.Operators.IntervalIntersectsInterval<CqlDate>(i_, l_);

			return m_;
		};
		var b_ = context.Operators.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Collapsed Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		var a_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);

		return a_;
	}

    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_(CqlInterval<CqlDate> _Coverage1) => 
			Intervals;
		Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK b_(CqlInterval<CqlDate> _Coverage1, CqlInterval<CqlDate> _Coverage2)
		{
			var h_ = new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = _Coverage1,
				Coverage2 = _Coverage2,
			};

			return h_;
		};
		var c_ = context.Operators.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, a_, b_);
		bool? d_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var i_ = context.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1);
			var j_ = context.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2);
			var k_ = context.Operators.Quantity(1m, "day");
			var l_ = context.Operators.Subtract(j_, k_);
			var o_ = context.Operators.Add(j_, k_);
			var p_ = context.Operators.Interval(l_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlDate>(i_, p_, null);
			var s_ = context.Operators.Not((bool?)(j_ is null));
			var t_ = context.Operators.And(q_, s_);

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(c_, d_);
		CqlInterval<CqlDate> f_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var u_ = context.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1);
			var v_ = context.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2);
			var w_ = context.Operators.Interval(u_, v_, true, true);

			return w_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Collapsed Final Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		var a_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
		var b_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
		var c_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(a_, b_);
		var d_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, c_);

		return d_;
	}

    [CqlDeclaration("All Coverage Info")]
	public IEnumerable<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC a_(Coverage C)
		{
			var c_ = this.CoverageIntervals(context, Coverage, participationPeriod);
			var e_ = this.Collapsed_Coverage_Intervals(context, c_);
			var g_ = this.Collapsed_Coverage_Intervals(context, c_);
			var h_ = this.Collapsed_Coverage_Adjacent_Intervals(context, g_);
			var j_ = this.Collapsed_Coverage_Intervals(context, c_);
			var l_ = this.Collapsed_Coverage_Intervals(context, c_);
			var m_ = this.Collapsed_Coverage_Adjacent_Intervals(context, l_);
			var n_ = this.Collapsed_Final_Coverage_Intervals(context, j_, m_);
			var o_ = new Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC
			{
				IntervalInfo = c_,
				Collapsed = e_,
				Adjacent = h_,
				CollapsedFinal = n_,
			};

			return o_;
		};
		var b_ = context.Operators.SelectOrNull<Coverage, Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Health Plan Coverage Resources")]
	public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			bool? e_(Coding cTypeCoding)
			{
				var h_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
				var i_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
				var j_ = context.Operators.Equivalent(h_, i_);
				var l_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
				var m_ = context.Operators.Equivalent(h_, l_);
				var n_ = context.Operators.Or(j_, m_);
				var p_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
				var q_ = context.Operators.Equivalent(h_, p_);
				var r_ = context.Operators.Or(n_, q_);

				return r_;
			};
			var f_ = context.Operators.WhereOrNull<Coding>((C?.Type?.Coding as IEnumerable<Coding>), e_);
			var g_ = context.Operators.ExistsInList<Coding>(f_);

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<Coverage>(Coverage, a_);
		bool? c_(Coverage HPCoverageResource)
		{
			var s_ = context.Operators.Not((bool?)(HPCoverageResource is null));

			return s_;
		};
		var d_ = context.Operators.WhereOrNull<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Anchor Date Criteria")]
	public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
	{
		bool? a_()
		{
			if ((context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
			{
				var b_ = this.All_Coverage_Info(context, Coverage, participationPeriod);
				bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
				{
					var k_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

					return k_;
				};
				var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
				IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
					@this?.CollapsedFinal;
				var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
				var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
				bool? h_(CqlInterval<CqlDate> FinalInterval)
				{
					var l_ = context.Operators.ElementInInterval<CqlDate>(AnchorDate, FinalInterval, null);

					return l_;
				};
				var i_ = context.Operators.WhereOrNull<CqlInterval<CqlDate>>(g_, h_);
				var j_ = context.Operators.ExistsInList<CqlInterval<CqlDate>>(i_);

				return j_;
			}
			else if ((context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null)) ?? false))
			{
				bool? m_(Coverage @this)
				{
					var t_ = context.Operators.Not((bool?)(@this?.Period is null));

					return t_;
				};
				var n_ = context.Operators.WhereOrNull<Coverage>(Coverage, m_);
				Period o_(Coverage @this) => 
					@this?.Period;
				var p_ = context.Operators.SelectOrNull<Coverage, Period>(n_, o_);
				bool? q_(Period Cperiod)
				{
					var u_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (Cperiod as object));
					var v_ = context.Operators.Start(u_);
					var w_ = context.Operators.DateFrom(v_);
					var y_ = context.Operators.End(u_);
					var z_ = context.Operators.DateFrom(y_);
					var aa_ = context.Operators.Interval(w_, z_, true, true);
					var ab_ = context.Operators.ElementInInterval<CqlDate>(AnchorDate, aa_, null);

					return ab_;
				};
				var r_ = context.Operators.WhereOrNull<Period>(p_, q_);
				var s_ = context.Operators.ExistsInList<Period>(r_);

				return s_;
			}
			else if ((AnchorDate is null))
			{
				return (bool?)true;
			}
			else
			{
				return (bool?)false;
			};
		};

		return a_();
	}

    [CqlDeclaration("Health Plan Enrollment Criteria")]
	public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Health_Plan_Coverage_Resources(context, Coverage);
		var b_ = this.All_Coverage_Info(context, a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var m_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
			@this?.CollapsedFinal;
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var n_ = context.Operators.LessOrEqual(GapsInEnrollment?.Interval_Count, (int?)1);
			var o_ = context.Operators.LessOrEqual(GapsInEnrollment?.Total_Days_In_Longest_Interval, AllowedGapDays);
			var p_ = context.Operators.And(n_, o_);
			var q_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
			var r_ = context.Operators.And(p_, q_);

			return r_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		var l_ = context.Operators.SingleOrNull<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
	public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			bool? e_(Coding cTypeCoding)
			{
				var h_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
				var i_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
				var j_ = context.Operators.Equivalent(h_, i_);

				return j_;
			};
			var f_ = context.Operators.WhereOrNull<Coding>((C?.Type?.Coding as IEnumerable<Coding>), e_);
			var g_ = context.Operators.ExistsInList<Coding>(f_);

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<Coverage>(Coverage, a_);
		bool? c_(Coverage pharmacyCoverageResource)
		{
			var k_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

			return k_;
		};
		var d_ = context.Operators.WhereOrNull<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
	public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
		var b_ = this.All_Coverage_Info(context, a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var m_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
			@this?.CollapsedFinal;
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var n_ = context.Operators.LessOrEqual(GapsInEnrollment?.Interval_Count, (int?)1);
			var o_ = context.Operators.LessOrEqual(GapsInEnrollment?.Total_Days_In_Longest_Interval, AllowedGapDays);
			var p_ = context.Operators.And(n_, o_);
			var q_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
			var r_ = context.Operators.And(p_, q_);

			return r_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		var l_ = context.Operators.SingleOrNull<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
	public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			bool? e_(Coding cTypeCoding)
			{
				var h_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
				var i_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
				var j_ = context.Operators.Equivalent(h_, i_);

				return j_;
			};
			var f_ = context.Operators.WhereOrNull<Coding>((C?.Type?.Coding as IEnumerable<Coding>), e_);
			var g_ = context.Operators.ExistsInList<Coding>(f_);

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<Coverage>(Coverage, a_);
		bool? c_(Coverage mentalHealthCoverageResource)
		{
			var k_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

			return k_;
		};
		var d_ = context.Operators.WhereOrNull<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
	public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
		var b_ = this.All_Coverage_Info(context, a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var m_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
			@this?.CollapsedFinal;
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var n_ = context.Operators.LessOrEqual(GapsInEnrollment?.Interval_Count, (int?)1);
			var o_ = context.Operators.LessOrEqual(GapsInEnrollment?.Total_Days_In_Longest_Interval, AllowedGapDays);
			var p_ = context.Operators.And(n_, o_);
			var q_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
			var r_ = context.Operators.And(p_, q_);

			return r_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		var l_ = context.Operators.SingleOrNull<bool?>(k_);

		return l_;
	}

}