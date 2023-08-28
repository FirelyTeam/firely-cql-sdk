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
		CqlInterval<CqlDate> a_(Coverage C)
		{
			var d_ = C.Period;
			var e_ = NCQAFHIRBase_1_0_0.Normalize_Interval(d_);
			var f_ = context.Operators;
			var g_ = f_.Start(e_);
			var i_ = f_.DateFrom(g_);
			var k_ = NCQAFHIRBase_1_0_0.Normalize_Interval(d_);
			var m_ = f_.End(k_);
			var o_ = f_.DateFrom(m_);
			var q_ = f_.Interval(i_, o_, true, true);
			var s_ = f_.Start(participationPeriod);
			var u_ = f_.End(participationPeriod);
			var w_ = f_.Interval(s_, u_, true, true);
			var y_ = f_.IntervalIntersectsInterval<CqlDate>(q_, w_);

			return y_;
		};
		var b_ = context.Operators;
		var c_ = b_.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, a_);

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
		IEnumerable<CqlInterval<CqlDate>> a_(CqlInterval<CqlDate> _Coverage1) => Intervals;
		Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK b_(CqlInterval<CqlDate> _Coverage1, CqlInterval<CqlDate> _Coverage2)
		{
			var k_ = new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = _Coverage1,
				Coverage2 = _Coverage2,
			};

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, a_, b_);
		bool? e_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var l_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1;
			var m_ = context.Operators;
			var n_ = m_.End(l_);
			var o_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2;
			var q_ = m_.Start(o_);
			var s_ = m_.Quantity(1m, "day");
			var u_ = m_.Subtract(q_, s_);
			var x_ = m_.Start(o_);
			var z_ = m_.Quantity(1m, "day");
			var ab_ = m_.Add(x_, z_);
			var ad_ = m_.Interval(u_, ab_, true, true);
			var af_ = m_.ElementInInterval<CqlDate>(n_, ad_, null);
			var ai_ = m_.Start(o_);
			var aj_ = (ai_ == null);
			var al_ = m_.Not((bool?)aj_);
			var an_ = m_.And(af_, al_);

			return an_;
		};
		var g_ = c_.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(d_, e_);
		CqlInterval<CqlDate> h_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var ao_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1;
			var ap_ = context.Operators;
			var aq_ = ap_.Start(ao_);
			var ar_ = tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2;
			var at_ = ap_.End(ar_);
			var av_ = ap_.Interval(aq_, at_, true, true);

			return av_;
		};
		var j_ = c_.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(g_, h_);

		return j_;
	}


    [CqlDeclaration("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		var a_ = this.Collapsed_Coverage_Intervals(collapsedI);
		var b_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
		var c_ = context.Operators;
		var d_ = c_.ListUnion<CqlInterval<CqlDate>>(a_, b_);
		var e_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(d_);

		return e_;
	}


    [CqlDeclaration("All Coverage Info")]
    public IEnumerable<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC a_(Coverage C)
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
		var b_ = context.Operators;
		var c_ = b_.SelectOrNull<Coverage, Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, a_);

		return c_;
	}


    [CqlDeclaration("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var g_ = C.Type;
			var h_ = g_.Coding;
			bool? i_(Coding cTypeCoding)
			{
				var n_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var o_ = NCQATerminology_1_0_0.managed_care_policy();
				var p_ = context.Operators;
				var q_ = p_.Equivalent(n_, o_);
				var s_ = NCQATerminology_1_0_0.retiree_health_program();
				var u_ = p_.Equivalent(n_, s_);
				var w_ = p_.Or(q_, u_);
				var y_ = NCQATerminology_1_0_0.subsidized_health_program();
				var aa_ = p_.Equivalent(n_, y_);
				var ac_ = p_.Or(w_, aa_);

				return ac_;
			};
			var j_ = context.Operators;
			var k_ = j_.WhereOrNull<Coding>((h_ as IEnumerable<Coding>), i_);
			var m_ = j_.ExistsInList<Coding>(k_);

			return m_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Coverage>(Coverage, a_);
		bool? d_(Coverage HPCoverageResource)
		{
			var ad_ = (HPCoverageResource == null);
			var ae_ = context.Operators;
			var af_ = ae_.Not((bool?)ad_);

			return af_;
		};
		var f_ = b_.WhereOrNull<Coverage>(c_, d_);

		return f_;
	}


    [CqlDeclaration("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        if ((context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
		{
			var a__ = this.All_Coverage_Info(Coverage, participationPeriod);
			bool? b__(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
			{
				var o__ = @this.CollapsedFinal;
				var p__ = (o__ == null);
				var q__ = context.Operators;
				var r__ = q__.Not((bool?)p__);

				return r__;
			};
			var c__ = context.Operators;
			var d__ = c__.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(a__, b__);
			IEnumerable<CqlInterval<CqlDate>> e__(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
			{
				var s__ = @this.CollapsedFinal;

				return s__;
			};
			var g__ = c__.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d__, e__);
			var i__ = c__.FlattenList<CqlInterval<CqlDate>>(g__);
			bool? j__(CqlInterval<CqlDate> FinalInterval)
			{
				var t__ = context.Operators;
				var u__ = t__.ElementInInterval<CqlDate>(AnchorDate, FinalInterval, null);

				return u__;
			};
			var l__ = c__.WhereOrNull<CqlInterval<CqlDate>>(i__, j__);
			var n__ = c__.ExistsInList<CqlInterval<CqlDate>>(l__);

			return n__;
		}
        else if ((context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null)) ?? false))
		{
			bool? a__(Coverage @this)
			{
				var l__ = @this.Period;
				var m__ = (l__ == null);
				var n__ = context.Operators;
				var o__ = n__.Not((bool?)m__);

				return o__;
			};
			var b__ = context.Operators;
			var c__ = b__.WhereOrNull<Coverage>(Coverage, a__);
			Period d__(Coverage @this)
			{
				var p__ = @this.Period;

				return p__;
			};
			var f__ = b__.SelectOrNull<Coverage, Period>(c__, d__);
			bool? g__(Period Cperiod)
			{
				var q__ = NCQAFHIRBase_1_0_0.Normalize_Interval(Cperiod);
				var r__ = context.Operators;
				var s__ = r__.Start(q__);
				var u__ = r__.DateFrom(s__);
				var x__ = r__.End(q__);
				var z__ = r__.DateFrom(x__);
				var ab__ = r__.Interval(u__, z__, true, true);
				var ad__ = r__.ElementInInterval<CqlDate>(AnchorDate, ab__, null);

				return ad__;
			};
			var i__ = b__.WhereOrNull<Period>(f__, g__);
			var k__ = b__.ExistsInList<Period>(i__);

			return k__;
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
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var r_ = @this.CollapsedFinal;
			var s_ = (r_ == null);
			var t_ = context.Operators;
			var u_ = t_.Not((bool?)s_);

			return u_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> f_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var v_ = @this.CollapsedFinal;

			return v_;
		};
		var h_ = d_.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(e_, f_);
		var j_ = d_.FlattenList<CqlInterval<CqlDate>>(h_);
		var k_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, j_);
		var l_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			k_,
		};
		bool? m_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var w_ = GapsInEnrollment.Interval_Count;
			var x_ = context.Operators;
			var y_ = x_.LessOrEqual(w_, (int?)1);
			var z_ = GapsInEnrollment.Total_Days_In_Longest_Interval;
			var ab_ = x_.LessOrEqual(z_, AllowedGapDays);
			var ad_ = x_.And(y_, ab_);
			var ae_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);
			var ag_ = x_.And(ad_, ae_);

			return ag_;
		};
		var o_ = d_.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(l_, m_);
		var q_ = d_.SingleOrNull<bool?>(o_);

		return q_;
	}


    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var g_ = C.Type;
			var h_ = g_.Coding;
			bool? i_(Coding cTypeCoding)
			{
				var n_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var o_ = NCQATerminology_1_0_0.drug_policy();
				var p_ = context.Operators;
				var q_ = p_.Equivalent(n_, o_);

				return q_;
			};
			var j_ = context.Operators;
			var k_ = j_.WhereOrNull<Coding>((h_ as IEnumerable<Coding>), i_);
			var m_ = j_.ExistsInList<Coding>(k_);

			return m_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Coverage>(Coverage, a_);
		bool? d_(Coverage pharmacyCoverageResource)
		{
			var r_ = (pharmacyCoverageResource == null);
			var s_ = context.Operators;
			var t_ = s_.Not((bool?)r_);

			return t_;
		};
		var f_ = b_.WhereOrNull<Coverage>(c_, d_);

		return f_;
	}


    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var r_ = @this.CollapsedFinal;
			var s_ = (r_ == null);
			var t_ = context.Operators;
			var u_ = t_.Not((bool?)s_);

			return u_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> f_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var v_ = @this.CollapsedFinal;

			return v_;
		};
		var h_ = d_.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(e_, f_);
		var j_ = d_.FlattenList<CqlInterval<CqlDate>>(h_);
		var k_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, j_);
		var l_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			k_,
		};
		bool? m_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var w_ = GapsInEnrollment.Interval_Count;
			var x_ = context.Operators;
			var y_ = x_.LessOrEqual(w_, (int?)1);
			var z_ = GapsInEnrollment.Total_Days_In_Longest_Interval;
			var ab_ = x_.LessOrEqual(z_, AllowedGapDays);
			var ad_ = x_.And(y_, ab_);
			var ae_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);
			var ag_ = x_.And(ad_, ae_);

			return ag_;
		};
		var o_ = d_.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(l_, m_);
		var q_ = d_.SingleOrNull<bool?>(o_);

		return q_;
	}


    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var g_ = C.Type;
			var h_ = g_.Coding;
			bool? i_(Coding cTypeCoding)
			{
				var n_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var o_ = NCQATerminology_1_0_0.mental_health_policy();
				var p_ = context.Operators;
				var q_ = p_.Equivalent(n_, o_);

				return q_;
			};
			var j_ = context.Operators;
			var k_ = j_.WhereOrNull<Coding>((h_ as IEnumerable<Coding>), i_);
			var m_ = j_.ExistsInList<Coding>(k_);

			return m_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Coverage>(Coverage, a_);
		bool? d_(Coverage mentalHealthCoverageResource)
		{
			var r_ = (mentalHealthCoverageResource == null);
			var s_ = context.Operators;
			var t_ = s_.Not((bool?)r_);

			return t_;
		};
		var f_ = b_.WhereOrNull<Coverage>(c_, d_);

		return f_;
	}


    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var r_ = @this.CollapsedFinal;
			var s_ = (r_ == null);
			var t_ = context.Operators;
			var u_ = t_.Not((bool?)s_);

			return u_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> f_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var v_ = @this.CollapsedFinal;

			return v_;
		};
		var h_ = d_.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(e_, f_);
		var j_ = d_.FlattenList<CqlInterval<CqlDate>>(h_);
		var k_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, j_);
		var l_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			k_,
		};
		bool? m_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var w_ = GapsInEnrollment.Interval_Count;
			var x_ = context.Operators;
			var y_ = x_.LessOrEqual(w_, (int?)1);
			var z_ = GapsInEnrollment.Total_Days_In_Longest_Interval;
			var ab_ = x_.LessOrEqual(z_, AllowedGapDays);
			var ad_ = x_.And(y_, ab_);
			var ae_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);
			var ag_ = x_.And(ad_, ae_);

			return ag_;
		};
		var o_ = d_.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(l_, m_);
		var q_ = d_.SingleOrNull<bool?>(o_);

		return q_;
	}


}