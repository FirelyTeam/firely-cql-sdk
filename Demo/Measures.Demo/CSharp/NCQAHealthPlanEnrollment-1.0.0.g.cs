using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
		CqlInterval<CqlDate> a_(Coverage C)
		{
			var c_ = C.Period;
			var d_ = NCQAFHIRBase_1_0_0.Normalize_Interval((c_ as object));
			var e_ = context.Operators.Start(d_);
			var f_ = context.Operators.DateFrom(e_);
			var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval((c_ as object));
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.Interval(f_, j_, true, true);
			var l_ = context.Operators.Start(participationPeriod);
			var m_ = context.Operators.End(participationPeriod);
			var n_ = context.Operators.Interval(l_, m_, true, true);
			var o_ = context.Operators.Intersect<CqlDate>(k_, n_);

			return o_;
		};
		var b_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Collapsed Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		var a_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(Intervals);

		return a_;
	}

    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		var a_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
		(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? b_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple)
		{
			var h_ = (_valueTuple.Item1, _valueTuple.Item2);

			return h_;
		};
		var c_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(a_, b_);
		bool? d_((CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
		{
			var i_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv.Coverage1);
			var j_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv.Coverage2);
			var k_ = context.Operators.Quantity(1m, "day");
			var l_ = context.Operators.Subtract(j_, k_);
			var o_ = context.Operators.Add(j_, k_);
			var p_ = context.Operators.Interval(l_, o_, true, true);
			var q_ = context.Operators.In<CqlDate>(i_, p_, null);
			var s_ = context.Operators.Not((bool?)(j_ is null));
			var t_ = context.Operators.And(q_, s_);

			return t_;
		};
		var e_ = context.Operators.Where<(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(c_, d_);
		CqlInterval<CqlDate> f_((CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
		{
			var u_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv.Coverage1);
			var v_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv.Coverage2);
			var w_ = context.Operators.Interval(u_, v_, true, true);

			return w_;
		};
		var g_ = context.Operators.Select<(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Collapsed Final Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		var a_ = this.Collapsed_Coverage_Intervals(collapsedI);
		var b_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
		var c_ = context.Operators.Union<CqlInterval<CqlDate>>(a_, b_);
		var d_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("All Coverage Info")]
	public IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? a_(Coverage C)
		{
			var c_ = this.CoverageIntervals(Coverage, participationPeriod);
			var e_ = this.Collapsed_Coverage_Intervals(c_);
			var g_ = this.Collapsed_Coverage_Intervals(c_);
			var h_ = this.Collapsed_Coverage_Adjacent_Intervals(g_);
			var j_ = this.Collapsed_Coverage_Intervals(c_);
			var l_ = this.Collapsed_Coverage_Intervals(c_);
			var m_ = this.Collapsed_Coverage_Adjacent_Intervals(l_);
			var n_ = this.Collapsed_Final_Coverage_Intervals(j_, m_);
			var o_ = (c_, e_, h_, n_);

			return o_;
		};
		var b_ = context.Operators.Select<Coverage, (IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Health Plan Coverage Resources")]
	public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var e_ = C.Type;
			var f_ = e_.Coding;
			bool? g_(Coding cTypeCoding)
			{
				var j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var k_ = NCQATerminology_1_0_0.managed_care_policy();
				var l_ = context.Operators.Equivalent(j_, k_);
				var n_ = NCQATerminology_1_0_0.retiree_health_program();
				var o_ = context.Operators.Equivalent(j_, n_);
				var p_ = context.Operators.Or(l_, o_);
				var r_ = NCQATerminology_1_0_0.subsidized_health_program();
				var s_ = context.Operators.Equivalent(j_, r_);
				var t_ = context.Operators.Or(p_, s_);

				return t_;
			};
			var h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
			var i_ = context.Operators.Exists<Coding>(h_);

			return i_;
		};
		var b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage HPCoverageResource)
		{
			var u_ = context.Operators.Not((bool?)(HPCoverageResource is null));

			return u_;
		};
		var d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Anchor Date Criteria")]
	public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
	{
		bool? a_()
		{
			bool b_()
			{
				var c_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, null);
				var d_ = context.Operators.Not(c_);

				return (d_ ?? false);
			};
			if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
			{
				var e_ = this.All_Coverage_Info(Coverage, participationPeriod);
				bool? f_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
				{
					var n_ = @this?.CollapsedFinal;
					var o_ = context.Operators.Not((bool?)(n_ is null));

					return o_;
				};
				var g_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(e_, f_);
				IEnumerable<CqlInterval<CqlDate>> h_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
				{
					var p_ = @this?.CollapsedFinal;

					return p_;
				};
				var i_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(g_, h_);
				var j_ = context.Operators.Flatten<CqlInterval<CqlDate>>(i_);
				bool? k_(CqlInterval<CqlDate> FinalInterval)
				{
					var q_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, null);

					return q_;
				};
				var l_ = context.Operators.Where<CqlInterval<CqlDate>>(j_, k_);
				var m_ = context.Operators.Exists<CqlInterval<CqlDate>>(l_);

				return m_;
			}
			else if (b_())
			{
				bool? r_(Coverage @this)
				{
					var y_ = @this.Period;
					var z_ = context.Operators.Not((bool?)(y_ is null));

					return z_;
				};
				var s_ = context.Operators.Where<Coverage>(Coverage, r_);
				Period t_(Coverage @this)
				{
					var aa_ = @this.Period;

					return aa_;
				};
				var u_ = context.Operators.Select<Coverage, Period>(s_, t_);
				bool? v_(Period Cperiod)
				{
					var ab_ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
					var ac_ = context.Operators.Start(ab_);
					var ad_ = context.Operators.DateFrom(ac_);
					var af_ = context.Operators.End(ab_);
					var ag_ = context.Operators.DateFrom(af_);
					var ah_ = context.Operators.Interval(ad_, ag_, true, true);
					var ai_ = context.Operators.In<CqlDate>(AnchorDate, ah_, null);

					return ai_;
				};
				var w_ = context.Operators.Where<Period>(u_, v_);
				var x_ = context.Operators.Exists<Period>(w_);

				return x_;
			}
			else if ((AnchorDate is null))
			{
				return true;
			}
			else
			{
				return false;
			}
		};

		return a_();
	}

    [CqlDeclaration("Health Plan Enrollment Criteria")]
	public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Health_Plan_Coverage_Resources(Coverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			var m_ = @this?.CollapsedFinal;
			var n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		var d_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			var o_ = @this?.CollapsedFinal;

			return o_;
		};
		var f_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[]
		{
			h_,
		};
		bool? j_((IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
		{
			var p_ = GapsInEnrollment?.Interval_Count;
			var q_ = context.Operators.LessOrEqual(p_, 1);
			var r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			var t_ = context.Operators.And(q_, s_);
			var u_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);
			var v_ = context.Operators.And(t_, u_);

			return v_;
		};
		var k_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>(((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_), j_);
		var l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
	public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var e_ = C.Type;
			var f_ = e_.Coding;
			bool? g_(Coding cTypeCoding)
			{
				var j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var k_ = NCQATerminology_1_0_0.drug_policy();
				var l_ = context.Operators.Equivalent(j_, k_);

				return l_;
			};
			var h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
			var i_ = context.Operators.Exists<Coding>(h_);

			return i_;
		};
		var b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage pharmacyCoverageResource)
		{
			var m_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

			return m_;
		};
		var d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
	public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			var m_ = @this?.CollapsedFinal;
			var n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		var d_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			var o_ = @this?.CollapsedFinal;

			return o_;
		};
		var f_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[]
		{
			h_,
		};
		bool? j_((IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
		{
			var p_ = GapsInEnrollment?.Interval_Count;
			var q_ = context.Operators.LessOrEqual(p_, 1);
			var r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			var t_ = context.Operators.And(q_, s_);
			var u_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);
			var v_ = context.Operators.And(t_, u_);

			return v_;
		};
		var k_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>(((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_), j_);
		var l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
	public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var e_ = C.Type;
			var f_ = e_.Coding;
			bool? g_(Coding cTypeCoding)
			{
				var j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var k_ = NCQATerminology_1_0_0.mental_health_policy();
				var l_ = context.Operators.Equivalent(j_, k_);

				return l_;
			};
			var h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
			var i_ = context.Operators.Exists<Coding>(h_);

			return i_;
		};
		var b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage mentalHealthCoverageResource)
		{
			var m_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

			return m_;
		};
		var d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
	public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			var m_ = @this?.CollapsedFinal;
			var n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		var d_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			var o_ = @this?.CollapsedFinal;

			return o_;
		};
		var f_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[]
		{
			h_,
		};
		bool? j_((IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
		{
			var p_ = GapsInEnrollment?.Interval_Count;
			var q_ = context.Operators.LessOrEqual(p_, 1);
			var r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			var t_ = context.Operators.And(q_, s_);
			var u_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);
			var v_ = context.Operators.And(t_, u_);

			return v_;
		};
		var k_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>(((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_), j_);
		var l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

}
