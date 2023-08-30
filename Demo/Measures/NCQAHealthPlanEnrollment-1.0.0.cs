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
		var a_ = context.Operators;
		CqlInterval<CqlDate> b_(Coverage C)
		{
			var d_ = context.Operators;
			var h_ = C?.Period;
			var i_ = NCQAFHIRBase_1_0_0.Normalize_Interval(h_);
			var j_ = d_.Start(i_);
			var k_ = d_.DateFrom(j_);
			var o_ = NCQAFHIRBase_1_0_0.Normalize_Interval(h_);
			var p_ = d_.End(o_);
			var q_ = d_.DateFrom(p_);
			var r_ = d_.Interval(k_, q_, true, true);
			var u_ = d_.Start(participationPeriod);
			var w_ = d_.End(participationPeriod);
			var x_ = d_.Interval(u_, w_, true, true);
			var y_ = d_.IntervalIntersectsInterval<CqlDate>(r_, x_);

			return y_;
		};
		var c_ = a_.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, b_);

		return c_;
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
		var a_ = context.Operators;
		IEnumerable<CqlInterval<CqlDate>> d_(CqlInterval<CqlDate> _Coverage1) => 
			Intervals;
		Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK e_(CqlInterval<CqlDate> _Coverage1, CqlInterval<CqlDate> _Coverage2)
		{
			var k_ = new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = _Coverage1,
				Coverage2 = _Coverage2,
			};

			return k_;
		};
		var f_ = a_.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, d_, e_);
		bool? g_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var l_ = context.Operators;
			var o_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1;
			var p_ = l_.End(o_);
			var t_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2;
			var u_ = l_.Start(t_);
			var w_ = l_.Quantity(1m, "day");
			var x_ = l_.Subtract(u_, w_);
			var ab_ = l_.Start(t_);
			var ad_ = l_.Quantity(1m, "day");
			var ae_ = l_.Add(ab_, ad_);
			var af_ = l_.Interval(x_, ae_, true, true);
			var ag_ = l_.ElementInInterval<CqlDate>(p_, af_, null);
			var ak_ = l_.Start(t_);
			var al_ = l_.Not((bool?)(ak_ is null));
			var am_ = l_.And(ag_, al_);

			return am_;
		};
		var h_ = a_.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(f_, g_);
		CqlInterval<CqlDate> i_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var an_ = context.Operators;
			var ap_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1;
			var aq_ = an_.Start(ap_);
			var as_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2;
			var at_ = an_.End(as_);
			var au_ = an_.Interval(aq_, at_, true, true);

			return au_;
		};
		var j_ = a_.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Collapsed Final Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		var a_ = context.Operators;
		var b_ = this.Collapsed_Coverage_Intervals(collapsedI);
		var c_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
		var d_ = a_.ListUnion<CqlInterval<CqlDate>>(b_, c_);
		var e_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(d_);

		return e_;
	}

    [CqlDeclaration("All Coverage Info")]
	public IEnumerable<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		var a_ = context.Operators;
		Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC b_(Coverage C)
		{
			var d_ = this.CoverageIntervals(Coverage, participationPeriod);
			var f_ = this.Collapsed_Coverage_Intervals(d_);
			var h_ = this.Collapsed_Coverage_Intervals(d_);
			var i_ = this.Collapsed_Coverage_Adjacent_Intervals(h_);
			var k_ = this.Collapsed_Coverage_Intervals(d_);
			var m_ = this.Collapsed_Coverage_Intervals(d_);
			var n_ = this.Collapsed_Coverage_Adjacent_Intervals(m_);
			var o_ = this.Collapsed_Final_Coverage_Intervals(k_, n_);
			var p_ = new Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC
			{
				IntervalInfo = d_,
				Collapsed = f_,
				Adjacent = i_,
				CollapsedFinal = o_,
			};

			return p_;
		};
		var c_ = a_.SelectOrNull<Coverage, Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, b_);

		return c_;
	}

    [CqlDeclaration("Health Plan Coverage Resources")]
	public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var a_ = context.Operators;
		bool? c_(Coverage C)
		{
			var g_ = context.Operators;
			var i_ = C?.Type;
			var j_ = i_?.Coding;
			bool? k_(Coding cTypeCoding)
			{
				var n_ = context.Operators;
				var q_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var r_ = NCQATerminology_1_0_0.managed_care_policy();
				var s_ = n_.Equivalent(q_, r_);
				var v_ = NCQATerminology_1_0_0.retiree_health_program();
				var w_ = n_.Equivalent(q_, v_);
				var x_ = n_.Or(s_, w_);
				var aa_ = NCQATerminology_1_0_0.subsidized_health_program();
				var ab_ = n_.Equivalent(q_, aa_);
				var ac_ = n_.Or(x_, ab_);

				return ac_;
			};
			var l_ = g_.WhereOrNull<Coding>((j_ as IEnumerable<Coding>), k_);
			var m_ = g_.ExistsInList<Coding>(l_);

			return m_;
		};
		var d_ = a_.WhereOrNull<Coverage>(Coverage, c_);
		bool? e_(Coverage HPCoverageResource)
		{
			var ad_ = context.Operators;
			var ae_ = ad_.Not((bool?)(HPCoverageResource is null));

			return ae_;
		};
		var f_ = a_.WhereOrNull<Coverage>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Anchor Date Criteria")]
	public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
	{
		bool? a_()
		{
			if ((context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
			{
				var b_ = context.Operators;
				var g_ = this.All_Coverage_Info(Coverage, participationPeriod);
				bool? h_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
				{
					var p_ = context.Operators;
					var q_ = @this?.CollapsedFinal;
					var r_ = p_.Not((bool?)(q_ is null));

					return r_;
				};
				var i_ = b_.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(g_, h_);
				IEnumerable<CqlInterval<CqlDate>> j_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
				{
					var s_ = @this?.CollapsedFinal;

					return s_;
				};
				var k_ = b_.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(i_, j_);
				var l_ = b_.FlattenList<CqlInterval<CqlDate>>(k_);
				bool? m_(CqlInterval<CqlDate> FinalInterval)
				{
					var t_ = context.Operators;
					var u_ = t_.ElementInInterval<CqlDate>(AnchorDate, FinalInterval, null);

					return u_;
				};
				var n_ = b_.WhereOrNull<CqlInterval<CqlDate>>(l_, m_);
				var o_ = b_.ExistsInList<CqlInterval<CqlDate>>(n_);

				return o_;
			}
			else if ((context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null)) ?? false))
			{
				var v_ = context.Operators;
				bool? z_(Coverage @this)
				{
					var ag_ = context.Operators;
					var ah_ = @this?.Period;
					var ai_ = ag_.Not((bool?)(ah_ is null));

					return ai_;
				};
				var aa_ = v_.WhereOrNull<Coverage>(Coverage, z_);
				Period ab_(Coverage @this)
				{
					var aj_ = @this?.Period;

					return aj_;
				};
				var ac_ = v_.SelectOrNull<Coverage, Period>(aa_, ab_);
				bool? ad_(Period Cperiod)
				{
					var ak_ = context.Operators;
					var ao_ = NCQAFHIRBase_1_0_0.Normalize_Interval(Cperiod);
					var ap_ = ak_.Start(ao_);
					var aq_ = ak_.DateFrom(ap_);
					var au_ = ak_.End(ao_);
					var av_ = ak_.DateFrom(au_);
					var aw_ = ak_.Interval(aq_, av_, true, true);
					var ax_ = ak_.ElementInInterval<CqlDate>(AnchorDate, aw_, null);

					return ax_;
				};
				var ae_ = v_.WhereOrNull<Period>(ac_, ad_);
				var af_ = v_.ExistsInList<Period>(ae_);

				return af_;
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
	public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = context.Operators;
		var f_ = this.Health_Plan_Coverage_Resources(Coverage);
		var g_ = this.All_Coverage_Info(f_, participationPeriod);
		bool? h_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var r_ = context.Operators;
			var s_ = @this?.CollapsedFinal;
			var t_ = r_.Not((bool?)(s_ is null));

			return t_;
		};
		var i_ = a_.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(g_, h_);
		IEnumerable<CqlInterval<CqlDate>> j_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var u_ = @this?.CollapsedFinal;

			return u_;
		};
		var k_ = a_.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(i_, j_);
		var l_ = a_.FlattenList<CqlInterval<CqlDate>>(k_);
		var m_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, l_);
		var n_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			m_,
		};
		bool? o_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var v_ = context.Operators;
			var y_ = GapsInEnrollment?.Interval_Count;
			var z_ = v_.LessOrEqual(y_, (int?)1);
			var ab_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var ac_ = v_.LessOrEqual(ab_, AllowedGapDays);
			var ad_ = v_.And(z_, ac_);
			var ae_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);
			var af_ = v_.And(ad_, ae_);

			return af_;
		};
		var p_ = a_.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(n_, o_);
		var q_ = a_.SingleOrNull<bool?>(p_);

		return q_;
	}

    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
	public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var a_ = context.Operators;
		bool? c_(Coverage C)
		{
			var g_ = context.Operators;
			var i_ = C?.Type;
			var j_ = i_?.Coding;
			bool? k_(Coding cTypeCoding)
			{
				var n_ = context.Operators;
				var o_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var p_ = NCQATerminology_1_0_0.drug_policy();
				var q_ = n_.Equivalent(o_, p_);

				return q_;
			};
			var l_ = g_.WhereOrNull<Coding>((j_ as IEnumerable<Coding>), k_);
			var m_ = g_.ExistsInList<Coding>(l_);

			return m_;
		};
		var d_ = a_.WhereOrNull<Coverage>(Coverage, c_);
		bool? e_(Coverage pharmacyCoverageResource)
		{
			var r_ = context.Operators;
			var s_ = r_.Not((bool?)(pharmacyCoverageResource is null));

			return s_;
		};
		var f_ = a_.WhereOrNull<Coverage>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
	public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = context.Operators;
		var f_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		var g_ = this.All_Coverage_Info(f_, participationPeriod);
		bool? h_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var r_ = context.Operators;
			var s_ = @this?.CollapsedFinal;
			var t_ = r_.Not((bool?)(s_ is null));

			return t_;
		};
		var i_ = a_.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(g_, h_);
		IEnumerable<CqlInterval<CqlDate>> j_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var u_ = @this?.CollapsedFinal;

			return u_;
		};
		var k_ = a_.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(i_, j_);
		var l_ = a_.FlattenList<CqlInterval<CqlDate>>(k_);
		var m_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, l_);
		var n_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			m_,
		};
		bool? o_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var v_ = context.Operators;
			var y_ = GapsInEnrollment?.Interval_Count;
			var z_ = v_.LessOrEqual(y_, (int?)1);
			var ab_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var ac_ = v_.LessOrEqual(ab_, AllowedGapDays);
			var ad_ = v_.And(z_, ac_);
			var ae_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);
			var af_ = v_.And(ad_, ae_);

			return af_;
		};
		var p_ = a_.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(n_, o_);
		var q_ = a_.SingleOrNull<bool?>(p_);

		return q_;
	}

    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
	public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		var a_ = context.Operators;
		bool? c_(Coverage C)
		{
			var g_ = context.Operators;
			var i_ = C?.Type;
			var j_ = i_?.Coding;
			bool? k_(Coding cTypeCoding)
			{
				var n_ = context.Operators;
				var o_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var p_ = NCQATerminology_1_0_0.mental_health_policy();
				var q_ = n_.Equivalent(o_, p_);

				return q_;
			};
			var l_ = g_.WhereOrNull<Coding>((j_ as IEnumerable<Coding>), k_);
			var m_ = g_.ExistsInList<Coding>(l_);

			return m_;
		};
		var d_ = a_.WhereOrNull<Coverage>(Coverage, c_);
		bool? e_(Coverage mentalHealthCoverageResource)
		{
			var r_ = context.Operators;
			var s_ = r_.Not((bool?)(mentalHealthCoverageResource is null));

			return s_;
		};
		var f_ = a_.WhereOrNull<Coverage>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
	public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = context.Operators;
		var f_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		var g_ = this.All_Coverage_Info(f_, participationPeriod);
		bool? h_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var r_ = context.Operators;
			var s_ = @this?.CollapsedFinal;
			var t_ = r_.Not((bool?)(s_ is null));

			return t_;
		};
		var i_ = a_.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(g_, h_);
		IEnumerable<CqlInterval<CqlDate>> j_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var u_ = @this?.CollapsedFinal;

			return u_;
		};
		var k_ = a_.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(i_, j_);
		var l_ = a_.FlattenList<CqlInterval<CqlDate>>(k_);
		var m_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, l_);
		var n_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			m_,
		};
		bool? o_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var v_ = context.Operators;
			var y_ = GapsInEnrollment?.Interval_Count;
			var z_ = v_.LessOrEqual(y_, (int?)1);
			var ab_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var ac_ = v_.LessOrEqual(ab_, AllowedGapDays);
			var ad_ = v_.And(z_, ac_);
			var ae_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);
			var af_ = v_.And(ad_, ae_);

			return af_;
		};
		var p_ = a_.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(n_, o_);
		var q_ = a_.SingleOrNull<bool?>(p_);

		return q_;
	}

}