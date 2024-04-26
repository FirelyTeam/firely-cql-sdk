using System;
using Tuples;
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
			CqlInterval<CqlDateTime> c_ = NCQAFHIRBase_1_0_0.Normalize_Interval((C?.Period as object));
			CqlDateTime d_ = context.Operators.Start(c_);
			CqlDate e_ = context.Operators.DateFrom(d_);
			CqlDateTime g_ = context.Operators.End(c_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			CqlInterval<CqlDate> i_ = context.Operators.Interval(e_, h_, true, true);
			CqlDate j_ = context.Operators.Start(participationPeriod);
			CqlDate k_ = context.Operators.End(participationPeriod);
			CqlInterval<CqlDate> l_ = context.Operators.Interval(j_, k_, true, true);
			CqlInterval<CqlDate> m_ = context.Operators.IntervalIntersect<CqlDate>(i_, l_);

			return m_;
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
		IEnumerable<ValueTuple<CqlInterval<CqlDate>,CqlInterval<CqlDate>>> a_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
		Tuple_GDEcEaQjOFQDGfGXNEXUVihLK b_(ValueTuple<CqlInterval<CqlDate>,CqlInterval<CqlDate>> _valueTuple)
		{
			Tuple_GDEcEaQjOFQDGfGXNEXUVihLK h_ = new Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = _valueTuple.Item1,
				Coverage2 = _valueTuple.Item2,
			};

			return h_;
		};
		IEnumerable<Tuple_GDEcEaQjOFQDGfGXNEXUVihLK> c_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>,CqlInterval<CqlDate>>, Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(a_, b_);
		bool? d_(Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			CqlDate i_ = context.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1);
			CqlDate j_ = context.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2);
			CqlQuantity k_ = context.Operators.Quantity(1m, "day");
			CqlDate l_ = context.Operators.Subtract(j_, k_);
			CqlDate o_ = context.Operators.Add(j_, k_);
			CqlInterval<CqlDate> p_ = context.Operators.Interval(l_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDate>(i_, p_, null);
			bool? s_ = context.Operators.Not((bool?)(j_ is null));
			bool? t_ = context.Operators.And(q_, s_);

			return t_;
		};
		IEnumerable<Tuple_GDEcEaQjOFQDGfGXNEXUVihLK> e_ = context.Operators.Where<Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(c_, d_);
		CqlInterval<CqlDate> f_(Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			CqlDate u_ = context.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1);
			CqlDate v_ = context.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2);
			CqlInterval<CqlDate> w_ = context.Operators.Interval(u_, v_, true, true);

			return w_;
		};
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Select<Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Collapsed Final Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Collapsed_Coverage_Intervals(collapsedI);
		IEnumerable<CqlInterval<CqlDate>> b_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(a_, b_);
		IEnumerable<CqlInterval<CqlDate>> d_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("All Coverage Info")]
	public IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC a_(Coverage C)
		{
			IEnumerable<CqlInterval<CqlDate>> c_ = this.CoverageIntervals(Coverage, participationPeriod);
			IEnumerable<CqlInterval<CqlDate>> e_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> g_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> h_ = this.Collapsed_Coverage_Adjacent_Intervals(g_);
			IEnumerable<CqlInterval<CqlDate>> j_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> l_ = this.Collapsed_Coverage_Intervals(c_);
			IEnumerable<CqlInterval<CqlDate>> m_ = this.Collapsed_Coverage_Adjacent_Intervals(l_);
			IEnumerable<CqlInterval<CqlDate>> n_ = this.Collapsed_Final_Coverage_Intervals(j_, m_);
			Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC o_ = new Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC
			{
				IntervalInfo = c_,
				Collapsed = e_,
				Adjacent = h_,
				CollapsedFinal = n_,
			};

			return o_;
		};
		IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> b_ = context.Operators.Select<Coverage, Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Health Plan Coverage Resources")]
	public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			bool? e_(Coding cTypeCoding)
			{
				CqlCode h_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				CqlCode i_ = NCQATerminology_1_0_0.managed_care_policy();
				bool? j_ = context.Operators.Equivalent(h_, i_);
				CqlCode l_ = NCQATerminology_1_0_0.retiree_health_program();
				bool? m_ = context.Operators.Equivalent(h_, l_);
				bool? n_ = context.Operators.Or(j_, m_);
				CqlCode p_ = NCQATerminology_1_0_0.subsidized_health_program();
				bool? q_ = context.Operators.Equivalent(h_, p_);
				bool? r_ = context.Operators.Or(n_, q_);

				return r_;
			};
			IEnumerable<Coding> f_ = context.Operators.Where<Coding>((C?.Type?.Coding as IEnumerable<Coding>), e_);
			bool? g_ = context.Operators.Exists<Coding>(f_);

			return g_;
		};
		IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage HPCoverageResource)
		{
			bool? s_ = context.Operators.Not((bool?)(HPCoverageResource is null));

			return s_;
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
				bool? c_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, null);
				bool? d_ = context.Operators.Not(c_);

				return (d_ ?? false);
			};
			if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
			{
				IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> e_ = this.All_Coverage_Info(Coverage, participationPeriod);
				bool? f_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
				{
					bool? n_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

					return n_;
				};
				IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> g_ = context.Operators.Where<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(e_, f_);
				IEnumerable<CqlInterval<CqlDate>> h_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
					@this?.CollapsedFinal;
				IEnumerable<IEnumerable<CqlInterval<CqlDate>>> i_ = context.Operators.Select<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(g_, h_);
				IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Flatten<CqlInterval<CqlDate>>(i_);
				bool? k_(CqlInterval<CqlDate> FinalInterval)
				{
					bool? o_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, null);

					return o_;
				};
				IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Where<CqlInterval<CqlDate>>(j_, k_);
				bool? m_ = context.Operators.Exists<CqlInterval<CqlDate>>(l_);

				return m_;
			}
			else if (b_())
			{
				bool? p_(Coverage @this)
				{
					bool? w_ = context.Operators.Not((bool?)(@this?.Period is null));

					return w_;
				};
				IEnumerable<Coverage> q_ = context.Operators.Where<Coverage>(Coverage, p_);
				Period r_(Coverage @this) => 
					@this?.Period;
				IEnumerable<Period> s_ = context.Operators.Select<Coverage, Period>(q_, r_);
				bool? t_(Period Cperiod)
				{
					CqlInterval<CqlDateTime> x_ = NCQAFHIRBase_1_0_0.Normalize_Interval((Cperiod as object));
					CqlDateTime y_ = context.Operators.Start(x_);
					CqlDate z_ = context.Operators.DateFrom(y_);
					CqlDateTime ab_ = context.Operators.End(x_);
					CqlDate ac_ = context.Operators.DateFrom(ab_);
					CqlInterval<CqlDate> ad_ = context.Operators.Interval(z_, ac_, true, true);
					bool? ae_ = context.Operators.In<CqlDate>(AnchorDate, ad_, null);

					return ae_;
				};
				IEnumerable<Period> u_ = context.Operators.Where<Period>(s_, t_);
				bool? v_ = context.Operators.Exists<Period>(u_);

				return v_;
			}
			else if ((AnchorDate is null))
			{
				return true;
			}
			else
			{
				return false;
			};
		};

		return a_();
	}

    [CqlDeclaration("Health Plan Enrollment Criteria")]
	public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		IEnumerable<Coverage> a_ = this.Health_Plan_Coverage_Resources(Coverage);
		IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			bool? m_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

			return m_;
		};
		IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> d_ = context.Operators.Where<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
			@this?.CollapsedFinal;
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[] i_ = new Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			bool? n_ = context.Operators.LessOrEqual(GapsInEnrollment?.Interval_Count, 1);
			bool? o_ = context.Operators.LessOrEqual(GapsInEnrollment?.Total_Days_In_Longest_Interval, AllowedGapDays);
			bool? p_ = context.Operators.And(n_, o_);
			bool? q_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);
			bool? r_ = context.Operators.And(p_, q_);

			return r_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
	public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			bool? e_(Coding cTypeCoding)
			{
				CqlCode h_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				CqlCode i_ = NCQATerminology_1_0_0.drug_policy();
				bool? j_ = context.Operators.Equivalent(h_, i_);

				return j_;
			};
			IEnumerable<Coding> f_ = context.Operators.Where<Coding>((C?.Type?.Coding as IEnumerable<Coding>), e_);
			bool? g_ = context.Operators.Exists<Coding>(f_);

			return g_;
		};
		IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage pharmacyCoverageResource)
		{
			bool? k_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

			return k_;
		};
		IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
	public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		IEnumerable<Coverage> a_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			bool? m_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

			return m_;
		};
		IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> d_ = context.Operators.Where<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
			@this?.CollapsedFinal;
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[] i_ = new Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			bool? n_ = context.Operators.LessOrEqual(GapsInEnrollment?.Interval_Count, 1);
			bool? o_ = context.Operators.LessOrEqual(GapsInEnrollment?.Total_Days_In_Longest_Interval, AllowedGapDays);
			bool? p_ = context.Operators.And(n_, o_);
			bool? q_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);
			bool? r_ = context.Operators.And(p_, q_);

			return r_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
	public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			bool? e_(Coding cTypeCoding)
			{
				CqlCode h_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				CqlCode i_ = NCQATerminology_1_0_0.mental_health_policy();
				bool? j_ = context.Operators.Equivalent(h_, i_);

				return j_;
			};
			IEnumerable<Coding> f_ = context.Operators.Where<Coding>((C?.Type?.Coding as IEnumerable<Coding>), e_);
			bool? g_ = context.Operators.Exists<Coding>(f_);

			return g_;
		};
		IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
		bool? c_(Coverage mentalHealthCoverageResource)
		{
			bool? k_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

			return k_;
		};
		IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
	public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		IEnumerable<Coverage> a_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			bool? m_ = context.Operators.Not((bool?)(@this?.CollapsedFinal is null));

			return m_;
		};
		IEnumerable<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> d_ = context.Operators.Where<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this) => 
			@this?.CollapsedFinal;
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[] i_ = new Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			bool? n_ = context.Operators.LessOrEqual(GapsInEnrollment?.Interval_Count, 1);
			bool? o_ = context.Operators.LessOrEqual(GapsInEnrollment?.Total_Days_In_Longest_Interval, AllowedGapDays);
			bool? p_ = context.Operators.And(n_, o_);
			bool? q_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);
			bool? r_ = context.Operators.And(p_, q_);

			return r_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

}
