using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
			Period c_ = C?.Period;
			CqlInterval<CqlDateTime> d_ = NCQAFHIRBase_1_0_0.Normalize_Interval(c_ as object);
			CqlDateTime e_ = context.Operators.Start(d_);
			CqlDate f_ = context.Operators.DateFrom(e_);
			CqlInterval<CqlDateTime> h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(c_ as object);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			CqlInterval<CqlDate> k_ = context.Operators.Interval(f_, j_, true, true);
			CqlDate l_ = context.Operators.Start(participationPeriod);
			CqlDate m_ = context.Operators.End(participationPeriod);
			CqlInterval<CqlDate> n_ = context.Operators.Interval(l_, m_, true, true);
			CqlInterval<CqlDate> o_ = context.Operators.Intersect<CqlDate>(k_, n_);

			return o_;
		};
		IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Collapsed Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(Intervals);

		return a_;
	}

    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> a_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
		(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? b_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple)
		{
			(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? h_ = (_valueTuple.Item1, _valueTuple.Item2);

			return h_;
		};
		IEnumerable<(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> c_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(a_, b_);
		bool? d_((CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
		{
			CqlDate i_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
			CqlDate j_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
			CqlQuantity k_ = context.Operators.Quantity(1m, "day");
			CqlDate l_ = context.Operators.Subtract(j_, k_);
			CqlDate o_ = context.Operators.Add(j_, k_);
			CqlInterval<CqlDate> p_ = context.Operators.Interval(l_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDate>(i_, p_, default);
			bool? s_ = context.Operators.Not((bool?)(j_ is null));
			bool? t_ = context.Operators.And(q_, s_);

			return t_;
		};
		IEnumerable<(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> e_ = context.Operators.Where<(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(c_, d_);
		CqlInterval<CqlDate> f_((CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
		{
			CqlDate u_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
			CqlDate v_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
			CqlInterval<CqlDate> w_ = context.Operators.Interval(u_, v_, true, true);

			return w_;
		};
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Select<(CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Collapsed Final Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Collapsed_Coverage_Intervals(collapsedI);
		IEnumerable<CqlInterval<CqlDate>> b_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Union<CqlInterval<CqlDate>>(a_, b_);
		IEnumerable<CqlInterval<CqlDate>> d_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("All Coverage Info")]
	public IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? a_(Coverage C)
		{
			IEnumerable<CqlInterval<CqlDate>> c_ = this.CoverageIntervals(Coverage, participationPeriod);
			IEnumerable<CqlInterval<CqlDate>> e_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> g_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> h_ = this.Collapsed_Coverage_Adjacent_Intervals(g_);
			IEnumerable<CqlInterval<CqlDate>> j_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> l_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> m_ = this.Collapsed_Coverage_Adjacent_Intervals(l_);
			IEnumerable<CqlInterval<CqlDate>> n_ = this.Collapsed_Final_Coverage_Intervals(j_, m_);
			(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? o_ = (c_, e_, h_, n_);

			return o_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = context.Operators.Select<Coverage, (IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Health Plan Coverage Resources")]
	public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			CodeableConcept e_ = C?.Type;
			List<Coding> f_ = e_?.Coding;
			bool? g_(Coding cTypeCoding)
			{
				CqlCode j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				CqlCode k_ = NCQATerminology_1_0_0.managed_care_policy();
				bool? l_ = context.Operators.Equivalent(j_, k_);
				CqlCode n_ = NCQATerminology_1_0_0.retiree_health_program();
				bool? o_ = context.Operators.Equivalent(j_, n_);
				bool? p_ = context.Operators.Or(l_, o_);
				CqlCode r_ = NCQATerminology_1_0_0.subsidized_health_program();
				bool? s_ = context.Operators.Equivalent(j_, r_);
				bool? t_ = context.Operators.Or(p_, s_);

				return t_;
			};
			IEnumerable<Coding> h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
			bool? i_ = context.Operators.Exists<Coding>(h_);

			return i_;
		};
		IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage HPCoverageResource)
		{
			bool? u_ = context.Operators.Not((bool?)(HPCoverageResource is null));

			return u_;
		};
		IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Anchor Date Criteria")]
	public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
	{
		bool? a_()
		{
			bool b_()
			{
				bool? c_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default);
				bool? d_ = context.Operators.Not(c_);

				return d_ ?? false;
			};
			if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default)) ?? false)
			{
				IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> e_ = this.All_Coverage_Info(Coverage, participationPeriod);
				bool? f_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
				{
					IEnumerable<CqlInterval<CqlDate>> n_ = @this?.CollapsedFinal;
					bool? o_ = context.Operators.Not((bool?)(n_ is null));

					return o_;
				};
				IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> g_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(e_, f_);
				IEnumerable<CqlInterval<CqlDate>> h_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
				{
					IEnumerable<CqlInterval<CqlDate>> p_ = @this?.CollapsedFinal;

					return p_;
				};
				IEnumerable<IEnumerable<CqlInterval<CqlDate>>> i_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(g_, h_);
				IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Flatten<CqlInterval<CqlDate>>(i_);
				bool? k_(CqlInterval<CqlDate> FinalInterval)
				{
					bool? q_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, default);

					return q_;
				};
				IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Where<CqlInterval<CqlDate>>(j_, k_);
				bool? m_ = context.Operators.Exists<CqlInterval<CqlDate>>(l_);

				return m_;
			}
			else if (b_())
			{
				bool? r_(Coverage @this)
				{
					Period y_ = @this?.Period;
					bool? z_ = context.Operators.Not((bool?)(y_ is null));

					return z_;
				};
				IEnumerable<Coverage> s_ = context.Operators.Where<Coverage>(Coverage, r_);
				Period t_(Coverage @this)
				{
					Period aa_ = @this?.Period;

					return aa_;
				};
				IEnumerable<Period> u_ = context.Operators.Select<Coverage, Period>(s_, t_);
				bool? v_(Period Cperiod)
				{
					CqlInterval<CqlDateTime> ab_ = NCQAFHIRBase_1_0_0.Normalize_Interval(Cperiod as object);
					CqlDateTime ac_ = context.Operators.Start(ab_);
					CqlDate ad_ = context.Operators.DateFrom(ac_);
					CqlDateTime af_ = context.Operators.End(ab_);
					CqlDate ag_ = context.Operators.DateFrom(af_);
					CqlInterval<CqlDate> ah_ = context.Operators.Interval(ad_, ag_, true, true);
					bool? ai_ = context.Operators.In<CqlDate>(AnchorDate, ah_, default);

					return ai_;
				};
				IEnumerable<Period> w_ = context.Operators.Where<Period>(u_, v_);
				bool? x_ = context.Operators.Exists<Period>(w_);

				return x_;
			}
			else if (AnchorDate is null)
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
		IEnumerable<Coverage> a_ = this.Health_Plan_Coverage_Resources(Coverage);
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			IEnumerable<CqlInterval<CqlDate>> m_ = @this?.CollapsedFinal;
			bool? n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> d_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			IEnumerable<CqlInterval<CqlDate>> o_ = @this?.CollapsedFinal;

			return o_;
		};
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] i_ = [
			h_,
		];
		bool? j_((IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
		{
			int? p_ = GapsInEnrollment?.Interval_Count;
			bool? q_ = context.Operators.LessOrEqual(p_, 1);
			int? r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			bool? s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			bool? t_ = context.Operators.And(q_, s_);
			bool? u_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);
			bool? v_ = context.Operators.And(t_, u_);

			return v_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
	public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			CodeableConcept e_ = C?.Type;
			List<Coding> f_ = e_?.Coding;
			bool? g_(Coding cTypeCoding)
			{
				CqlCode j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				CqlCode k_ = NCQATerminology_1_0_0.drug_policy();
				bool? l_ = context.Operators.Equivalent(j_, k_);

				return l_;
			};
			IEnumerable<Coding> h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
			bool? i_ = context.Operators.Exists<Coding>(h_);

			return i_;
		};
		IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage pharmacyCoverageResource)
		{
			bool? m_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

			return m_;
		};
		IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
	public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		IEnumerable<Coverage> a_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			IEnumerable<CqlInterval<CqlDate>> m_ = @this?.CollapsedFinal;
			bool? n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> d_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			IEnumerable<CqlInterval<CqlDate>> o_ = @this?.CollapsedFinal;

			return o_;
		};
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] i_ = [
			h_,
		];
		bool? j_((IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
		{
			int? p_ = GapsInEnrollment?.Interval_Count;
			bool? q_ = context.Operators.LessOrEqual(p_, 1);
			int? r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			bool? s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			bool? t_ = context.Operators.And(q_, s_);
			bool? u_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);
			bool? v_ = context.Operators.And(t_, u_);

			return v_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
	public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			CodeableConcept e_ = C?.Type;
			List<Coding> f_ = e_?.Coding;
			bool? g_(Coding cTypeCoding)
			{
				CqlCode j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				CqlCode k_ = NCQATerminology_1_0_0.mental_health_policy();
				bool? l_ = context.Operators.Equivalent(j_, k_);

				return l_;
			};
			IEnumerable<Coding> h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
			bool? i_ = context.Operators.Exists<Coding>(h_);

			return i_;
		};
		IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage mentalHealthCoverageResource)
		{
			bool? m_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

			return m_;
		};
		IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
	public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		IEnumerable<Coverage> a_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			IEnumerable<CqlInterval<CqlDate>> m_ = @this?.CollapsedFinal;
			bool? n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> d_ = context.Operators.Where<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_((IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
		{
			IEnumerable<CqlInterval<CqlDate>> o_ = @this?.CollapsedFinal;

			return o_;
		};
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] i_ = [
			h_,
		];
		bool? j_((IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
		{
			int? p_ = GapsInEnrollment?.Interval_Count;
			bool? q_ = context.Operators.LessOrEqual(p_, 1);
			int? r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			bool? s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			bool? t_ = context.Operators.And(q_, s_);
			bool? u_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);
			bool? v_ = context.Operators.And(t_, u_);

			return v_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

}
