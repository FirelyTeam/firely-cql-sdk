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
[CqlLibrary("NCQAFHIRBase", "1.0.0")]
public class NCQAFHIRBase_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<Patient> __Patient;

    #endregion
    public NCQAFHIRBase_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("Normalize Onset")]
	public CqlInterval<CqlDateTime> Normalize_Onset(object onset)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (onset is FhirDateTime)
			{
				var b_ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));
				var d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (onset is Period)
			{
				var e_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
				var f_ = context.Operators.Convert<CqlDateTime>(e_);
				var g_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
				var h_ = context.Operators.Convert<CqlDateTime>(g_);
				var i_ = context.Operators.Interval(f_, h_, true, true);

				return i_;
			}
			else if (onset is FhirString)
			{
				var j_ = context.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return j_;
			}
			else
			{
				CqlInterval<CqlDate> k_()
				{
					if (onset is Age)
					{
						var r_ = this.Patient();
						var s_ = r_.BirthDateElement;
						var t_ = FHIRHelpers_4_0_001.ToDate(s_);
						var u_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var v_ = context.Operators.Add(t_, u_);
						var x_ = r_.BirthDateElement;
						var y_ = FHIRHelpers_4_0_001.ToDate(x_);
						var aa_ = context.Operators.Add(y_, u_);
						var ab_ = context.Operators.Quantity(1m, "year");
						var ac_ = context.Operators.Add(aa_, ab_);
						var ad_ = context.Operators.Interval(v_, ac_, true, false);

						return ad_;
					}
					else if (onset is Range)
					{
						var ae_ = this.Patient();
						var af_ = ae_.BirthDateElement;
						var ag_ = FHIRHelpers_4_0_001.ToDate(af_);
						var ah_ = (onset as Range).Low;
						var ai_ = FHIRHelpers_4_0_001.ToQuantity(ah_);
						var aj_ = context.Operators.Add(ag_, ai_);
						var al_ = ae_.BirthDateElement;
						var am_ = FHIRHelpers_4_0_001.ToDate(al_);
						var an_ = (onset as Range).High;
						var ao_ = FHIRHelpers_4_0_001.ToQuantity(an_);
						var ap_ = context.Operators.Add(am_, ao_);
						var aq_ = context.Operators.Quantity(1m, "year");
						var ar_ = context.Operators.Add(ap_, aq_);
						var as_ = context.Operators.Interval(aj_, ar_, true, false);

						return as_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				var l_ = context.Operators.ConvertDateToDateTime(k_().low);
				CqlInterval<CqlDate> m_()
				{
					if (onset is Age)
					{
						var at_ = this.Patient();
						var au_ = at_.BirthDateElement;
						var av_ = FHIRHelpers_4_0_001.ToDate(au_);
						var aw_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var ax_ = context.Operators.Add(av_, aw_);
						var az_ = at_.BirthDateElement;
						var ba_ = FHIRHelpers_4_0_001.ToDate(az_);
						var bc_ = context.Operators.Add(ba_, aw_);
						var bd_ = context.Operators.Quantity(1m, "year");
						var be_ = context.Operators.Add(bc_, bd_);
						var bf_ = context.Operators.Interval(ax_, be_, true, false);

						return bf_;
					}
					else if (onset is Range)
					{
						var bg_ = this.Patient();
						var bh_ = bg_.BirthDateElement;
						var bi_ = FHIRHelpers_4_0_001.ToDate(bh_);
						var bj_ = (onset as Range).Low;
						var bk_ = FHIRHelpers_4_0_001.ToQuantity(bj_);
						var bl_ = context.Operators.Add(bi_, bk_);
						var bn_ = bg_.BirthDateElement;
						var bo_ = FHIRHelpers_4_0_001.ToDate(bn_);
						var bp_ = (onset as Range).High;
						var bq_ = FHIRHelpers_4_0_001.ToQuantity(bp_);
						var br_ = context.Operators.Add(bo_, bq_);
						var bs_ = context.Operators.Quantity(1m, "year");
						var bt_ = context.Operators.Add(br_, bs_);
						var bu_ = context.Operators.Interval(bl_, bt_, true, false);

						return bu_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				var n_ = context.Operators.ConvertDateToDateTime(m_().high);
				CqlInterval<CqlDate> o_()
				{
					if (onset is Age)
					{
						var bv_ = this.Patient();
						var bw_ = bv_.BirthDateElement;
						var bx_ = FHIRHelpers_4_0_001.ToDate(bw_);
						var by_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var bz_ = context.Operators.Add(bx_, by_);
						var cb_ = bv_.BirthDateElement;
						var cc_ = FHIRHelpers_4_0_001.ToDate(cb_);
						var ce_ = context.Operators.Add(cc_, by_);
						var cf_ = context.Operators.Quantity(1m, "year");
						var cg_ = context.Operators.Add(ce_, cf_);
						var ch_ = context.Operators.Interval(bz_, cg_, true, false);

						return ch_;
					}
					else if (onset is Range)
					{
						var ci_ = this.Patient();
						var cj_ = ci_.BirthDateElement;
						var ck_ = FHIRHelpers_4_0_001.ToDate(cj_);
						var cl_ = (onset as Range).Low;
						var cm_ = FHIRHelpers_4_0_001.ToQuantity(cl_);
						var cn_ = context.Operators.Add(ck_, cm_);
						var cp_ = ci_.BirthDateElement;
						var cq_ = FHIRHelpers_4_0_001.ToDate(cp_);
						var cr_ = (onset as Range).High;
						var cs_ = FHIRHelpers_4_0_001.ToQuantity(cr_);
						var ct_ = context.Operators.Add(cq_, cs_);
						var cu_ = context.Operators.Quantity(1m, "year");
						var cv_ = context.Operators.Add(ct_, cu_);
						var cw_ = context.Operators.Interval(cn_, cv_, true, false);

						return cw_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				CqlInterval<CqlDate> p_()
				{
					if (onset is Age)
					{
						var cx_ = this.Patient();
						var cy_ = cx_.BirthDateElement;
						var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
						var da_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var db_ = context.Operators.Add(cz_, da_);
						var dd_ = cx_.BirthDateElement;
						var de_ = FHIRHelpers_4_0_001.ToDate(dd_);
						var dg_ = context.Operators.Add(de_, da_);
						var dh_ = context.Operators.Quantity(1m, "year");
						var di_ = context.Operators.Add(dg_, dh_);
						var dj_ = context.Operators.Interval(db_, di_, true, false);

						return dj_;
					}
					else if (onset is Range)
					{
						var dk_ = this.Patient();
						var dl_ = dk_.BirthDateElement;
						var dm_ = FHIRHelpers_4_0_001.ToDate(dl_);
						var dn_ = (onset as Range).Low;
						var do_ = FHIRHelpers_4_0_001.ToQuantity(dn_);
						var dp_ = context.Operators.Add(dm_, do_);
						var dr_ = dk_.BirthDateElement;
						var ds_ = FHIRHelpers_4_0_001.ToDate(dr_);
						var dt_ = (onset as Range).High;
						var du_ = FHIRHelpers_4_0_001.ToQuantity(dt_);
						var dv_ = context.Operators.Add(ds_, du_);
						var dw_ = context.Operators.Quantity(1m, "year");
						var dx_ = context.Operators.Add(dv_, dw_);
						var dy_ = context.Operators.Interval(dp_, dx_, true, false);

						return dy_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				var q_ = context.Operators.Interval(l_, n_, o_().lowClosed, p_().highClosed);

				return q_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Normalize Abatement")]
	public CqlInterval<CqlDateTime> Normalize_Abatement(object abatement)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (abatement is FhirDateTime)
			{
				var b_ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));
				var d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (abatement is Period)
			{
				var e_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
				var f_ = context.Operators.Convert<CqlDateTime>(e_);
				var g_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
				var h_ = context.Operators.Convert<CqlDateTime>(g_);
				var i_ = context.Operators.Interval(f_, h_, true, true);

				return i_;
			}
			else if (abatement is FhirString)
			{
				var j_ = context.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return j_;
			}
			else
			{
				CqlInterval<CqlDate> k_()
				{
					if (abatement is Age)
					{
						var r_ = this.Patient();
						var s_ = r_.BirthDateElement;
						var t_ = FHIRHelpers_4_0_001.ToDate(s_);
						var u_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var v_ = context.Operators.Add(t_, u_);
						var x_ = r_.BirthDateElement;
						var y_ = FHIRHelpers_4_0_001.ToDate(x_);
						var aa_ = context.Operators.Add(y_, u_);
						var ab_ = context.Operators.Quantity(1m, "year");
						var ac_ = context.Operators.Add(aa_, ab_);
						var ad_ = context.Operators.Interval(v_, ac_, true, false);

						return ad_;
					}
					else if (abatement is Range)
					{
						var ae_ = this.Patient();
						var af_ = ae_.BirthDateElement;
						var ag_ = FHIRHelpers_4_0_001.ToDate(af_);
						var ah_ = (abatement as Range).Low;
						var ai_ = FHIRHelpers_4_0_001.ToQuantity(ah_);
						var aj_ = context.Operators.Add(ag_, ai_);
						var al_ = ae_.BirthDateElement;
						var am_ = FHIRHelpers_4_0_001.ToDate(al_);
						var an_ = (abatement as Range).High;
						var ao_ = FHIRHelpers_4_0_001.ToQuantity(an_);
						var ap_ = context.Operators.Add(am_, ao_);
						var aq_ = context.Operators.Quantity(1m, "year");
						var ar_ = context.Operators.Add(ap_, aq_);
						var as_ = context.Operators.Interval(aj_, ar_, true, false);

						return as_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				var l_ = context.Operators.ConvertDateToDateTime(k_().low);
				CqlInterval<CqlDate> m_()
				{
					if (abatement is Age)
					{
						var at_ = this.Patient();
						var au_ = at_.BirthDateElement;
						var av_ = FHIRHelpers_4_0_001.ToDate(au_);
						var aw_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var ax_ = context.Operators.Add(av_, aw_);
						var az_ = at_.BirthDateElement;
						var ba_ = FHIRHelpers_4_0_001.ToDate(az_);
						var bc_ = context.Operators.Add(ba_, aw_);
						var bd_ = context.Operators.Quantity(1m, "year");
						var be_ = context.Operators.Add(bc_, bd_);
						var bf_ = context.Operators.Interval(ax_, be_, true, false);

						return bf_;
					}
					else if (abatement is Range)
					{
						var bg_ = this.Patient();
						var bh_ = bg_.BirthDateElement;
						var bi_ = FHIRHelpers_4_0_001.ToDate(bh_);
						var bj_ = (abatement as Range).Low;
						var bk_ = FHIRHelpers_4_0_001.ToQuantity(bj_);
						var bl_ = context.Operators.Add(bi_, bk_);
						var bn_ = bg_.BirthDateElement;
						var bo_ = FHIRHelpers_4_0_001.ToDate(bn_);
						var bp_ = (abatement as Range).High;
						var bq_ = FHIRHelpers_4_0_001.ToQuantity(bp_);
						var br_ = context.Operators.Add(bo_, bq_);
						var bs_ = context.Operators.Quantity(1m, "year");
						var bt_ = context.Operators.Add(br_, bs_);
						var bu_ = context.Operators.Interval(bl_, bt_, true, false);

						return bu_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				var n_ = context.Operators.ConvertDateToDateTime(m_().high);
				CqlInterval<CqlDate> o_()
				{
					if (abatement is Age)
					{
						var bv_ = this.Patient();
						var bw_ = bv_.BirthDateElement;
						var bx_ = FHIRHelpers_4_0_001.ToDate(bw_);
						var by_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var bz_ = context.Operators.Add(bx_, by_);
						var cb_ = bv_.BirthDateElement;
						var cc_ = FHIRHelpers_4_0_001.ToDate(cb_);
						var ce_ = context.Operators.Add(cc_, by_);
						var cf_ = context.Operators.Quantity(1m, "year");
						var cg_ = context.Operators.Add(ce_, cf_);
						var ch_ = context.Operators.Interval(bz_, cg_, true, false);

						return ch_;
					}
					else if (abatement is Range)
					{
						var ci_ = this.Patient();
						var cj_ = ci_.BirthDateElement;
						var ck_ = FHIRHelpers_4_0_001.ToDate(cj_);
						var cl_ = (abatement as Range).Low;
						var cm_ = FHIRHelpers_4_0_001.ToQuantity(cl_);
						var cn_ = context.Operators.Add(ck_, cm_);
						var cp_ = ci_.BirthDateElement;
						var cq_ = FHIRHelpers_4_0_001.ToDate(cp_);
						var cr_ = (abatement as Range).High;
						var cs_ = FHIRHelpers_4_0_001.ToQuantity(cr_);
						var ct_ = context.Operators.Add(cq_, cs_);
						var cu_ = context.Operators.Quantity(1m, "year");
						var cv_ = context.Operators.Add(ct_, cu_);
						var cw_ = context.Operators.Interval(cn_, cv_, true, false);

						return cw_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				CqlInterval<CqlDate> p_()
				{
					if (abatement is Age)
					{
						var cx_ = this.Patient();
						var cy_ = cx_.BirthDateElement;
						var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
						var da_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var db_ = context.Operators.Add(cz_, da_);
						var dd_ = cx_.BirthDateElement;
						var de_ = FHIRHelpers_4_0_001.ToDate(dd_);
						var dg_ = context.Operators.Add(de_, da_);
						var dh_ = context.Operators.Quantity(1m, "year");
						var di_ = context.Operators.Add(dg_, dh_);
						var dj_ = context.Operators.Interval(db_, di_, true, false);

						return dj_;
					}
					else if (abatement is Range)
					{
						var dk_ = this.Patient();
						var dl_ = dk_.BirthDateElement;
						var dm_ = FHIRHelpers_4_0_001.ToDate(dl_);
						var dn_ = (abatement as Range).Low;
						var do_ = FHIRHelpers_4_0_001.ToQuantity(dn_);
						var dp_ = context.Operators.Add(dm_, do_);
						var dr_ = dk_.BirthDateElement;
						var ds_ = FHIRHelpers_4_0_001.ToDate(dr_);
						var dt_ = (abatement as Range).High;
						var du_ = FHIRHelpers_4_0_001.ToQuantity(dt_);
						var dv_ = context.Operators.Add(ds_, du_);
						var dw_ = context.Operators.Quantity(1m, "year");
						var dx_ = context.Operators.Add(dv_, dw_);
						var dy_ = context.Operators.Interval(dp_, dx_, true, false);

						return dy_;
					}
					else
					{
						return (null as CqlInterval<CqlDate>);
					}
				};
				var q_ = context.Operators.Interval(l_, n_, o_().lowClosed, p_().highClosed);

				return q_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		var a_ = this.Normalize_Onset(condition.Onset);
		var b_ = context.Operators.Start(a_);
		var c_ = this.Normalize_Abatement(condition.Abatement);
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				var b_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				var d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Date)
			{
				var e_ = FHIRHelpers_4_0_001.ToDate((choice as Date));
				var f_ = context.Operators.ConvertDateToDateTime(e_);
				var h_ = context.Operators.ConvertDateToDateTime(e_);
				var i_ = context.Operators.Interval(f_, h_, true, true);

				return i_;
			}
			else if (choice is Period)
			{
				var j_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
				var k_ = context.Operators.Convert<CqlDateTime>(j_);
				var l_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
				var m_ = context.Operators.Convert<CqlDateTime>(l_);
				var n_ = context.Operators.Interval(k_, m_, true, true);

				return n_;
			}
			else if (choice is Instant)
			{
				var o_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				var q_ = context.Operators.Interval(o_, o_, true, true);

				return q_;
			}
			else if (choice is Age)
			{
				var r_ = this.Patient();
				var s_ = r_.BirthDateElement;
				var t_ = FHIRHelpers_4_0_001.ToDate(s_);
				var u_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var v_ = context.Operators.Add(t_, u_);
				var x_ = r_.BirthDateElement;
				var y_ = FHIRHelpers_4_0_001.ToDate(x_);
				var aa_ = context.Operators.Add(y_, u_);
				var ab_ = context.Operators.Quantity(1m, "year");
				var ac_ = context.Operators.Add(aa_, ab_);
				var ad_ = context.Operators.Interval(v_, ac_, true, false);
				var ae_ = ad_.low;
				var af_ = context.Operators.ConvertDateToDateTime(ae_);
				var ah_ = r_.BirthDateElement;
				var ai_ = FHIRHelpers_4_0_001.ToDate(ah_);
				var ak_ = context.Operators.Add(ai_, u_);
				var am_ = r_.BirthDateElement;
				var an_ = FHIRHelpers_4_0_001.ToDate(am_);
				var ap_ = context.Operators.Add(an_, u_);
				var ar_ = context.Operators.Add(ap_, ab_);
				var as_ = context.Operators.Interval(ak_, ar_, true, false);
				var at_ = as_.high;
				var au_ = context.Operators.ConvertDateToDateTime(at_);
				var aw_ = r_.BirthDateElement;
				var ax_ = FHIRHelpers_4_0_001.ToDate(aw_);
				var az_ = context.Operators.Add(ax_, u_);
				var bb_ = r_.BirthDateElement;
				var bc_ = FHIRHelpers_4_0_001.ToDate(bb_);
				var be_ = context.Operators.Add(bc_, u_);
				var bg_ = context.Operators.Add(be_, ab_);
				var bh_ = context.Operators.Interval(az_, bg_, true, false);
				var bi_ = bh_.lowClosed;
				var bk_ = r_.BirthDateElement;
				var bl_ = FHIRHelpers_4_0_001.ToDate(bk_);
				var bn_ = context.Operators.Add(bl_, u_);
				var bp_ = r_.BirthDateElement;
				var bq_ = FHIRHelpers_4_0_001.ToDate(bp_);
				var bs_ = context.Operators.Add(bq_, u_);
				var bu_ = context.Operators.Add(bs_, ab_);
				var bv_ = context.Operators.Interval(bn_, bu_, true, false);
				var bw_ = bv_.highClosed;
				var bx_ = context.Operators.Interval(af_, au_, bi_, bw_);

				return bx_;
			}
			else if (choice is Range)
			{
				var by_ = this.Patient();
				var bz_ = by_.BirthDateElement;
				var ca_ = FHIRHelpers_4_0_001.ToDate(bz_);
				var cb_ = (choice as Range).Low;
				var cc_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				var cd_ = context.Operators.Add(ca_, cc_);
				var cf_ = by_.BirthDateElement;
				var cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
				var ch_ = (choice as Range).High;
				var ci_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				var cj_ = context.Operators.Add(cg_, ci_);
				var ck_ = context.Operators.Quantity(1m, "year");
				var cl_ = context.Operators.Add(cj_, ck_);
				var cm_ = context.Operators.Interval(cd_, cl_, true, false);
				var cn_ = cm_.low;
				var co_ = context.Operators.ConvertDateToDateTime(cn_);
				var cq_ = by_.BirthDateElement;
				var cr_ = FHIRHelpers_4_0_001.ToDate(cq_);
				var ct_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				var cu_ = context.Operators.Add(cr_, ct_);
				var cw_ = by_.BirthDateElement;
				var cx_ = FHIRHelpers_4_0_001.ToDate(cw_);
				var cz_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				var da_ = context.Operators.Add(cx_, cz_);
				var dc_ = context.Operators.Add(da_, ck_);
				var dd_ = context.Operators.Interval(cu_, dc_, true, false);
				var de_ = dd_.high;
				var df_ = context.Operators.ConvertDateToDateTime(de_);
				var dh_ = by_.BirthDateElement;
				var di_ = FHIRHelpers_4_0_001.ToDate(dh_);
				var dk_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				var dl_ = context.Operators.Add(di_, dk_);
				var dn_ = by_.BirthDateElement;
				var do_ = FHIRHelpers_4_0_001.ToDate(dn_);
				var dq_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				var dr_ = context.Operators.Add(do_, dq_);
				var dt_ = context.Operators.Add(dr_, ck_);
				var du_ = context.Operators.Interval(dl_, dt_, true, false);
				var dv_ = du_.lowClosed;
				var dx_ = by_.BirthDateElement;
				var dy_ = FHIRHelpers_4_0_001.ToDate(dx_);
				var ea_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				var eb_ = context.Operators.Add(dy_, ea_);
				var ed_ = by_.BirthDateElement;
				var ee_ = FHIRHelpers_4_0_001.ToDate(ed_);
				var eg_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				var eh_ = context.Operators.Add(ee_, eg_);
				var ej_ = context.Operators.Add(eh_, ck_);
				var ek_ = context.Operators.Interval(eb_, ej_, true, false);
				var el_ = ek_.highClosed;
				var em_ = context.Operators.Interval(co_, df_, dv_, el_);

				return em_;
			}
			else if (choice is Timing)
			{
				var en_ = context.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return en_;
			}
			else if (choice is FhirString)
			{
				var eo_ = context.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return eo_;
			}
			else
			{
				return (null as CqlInterval<CqlDateTime>);
			}
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public string GetId(string uri)
	{
		string a_()
		{
			bool b_()
			{
				var c_ = context.Operators.PositionOf("/", uri);
				var d_ = context.Operators.Greater(c_, 0);

				return (d_ ?? false);
			};
			if (b_())
			{
				var e_ = context.Operators.Split(uri, "/");
				var f_ = context.Operators.Last<string>(e_);

				return f_;
			}
			else
			{
				return uri;
			}
		};

		return a_();
	}

    [CqlDeclaration("VS Cast Function")]
	public IEnumerable<CqlCode> VS_Cast_Function(IEnumerable<CqlCode> VSet) => 
		VSet;

    [CqlDeclaration("First Dates per 31 Day Periods")]
	public (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(IEnumerable<CqlDate> DateList)
	{
		CqlDate a_(CqlDate d) => 
			d;
		var b_ = context.Operators.Select<CqlDate, CqlDate>(DateList, a_);
		var c_ = context.Operators.ListSort<CqlDate>(b_, System.ComponentModel.ListSortDirection.Ascending);
		bool? d_(CqlDate X)
		{
			var k_ = context.Operators.Not((bool?)(X is null));

			return k_;
		};
		var e_ = context.Operators.Where<CqlDate>(c_, d_);
		var f_ = (e_, default(nint));
		var g_ = new (IEnumerable<CqlDate> SortedDates, nint _)?[]
		{
			f_,
		};
		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? h_((IEnumerable<CqlDate> SortedDates, nint _)? SortedDates)
		{
			var l_ = SortedDates?.SortedDates;
			var m_ = (l_, 0);
			var n_ = new (IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[]
			{
				m_,
			};
			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? o_((IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
			{
				var r_ = AnchorList?.SortedList;
				var s_ = AnchorList?.AnchorIndex;
				var t_ = context.Operators.Indexer<CqlDate>(r_, s_);
				bool? u_(CqlDate X)
				{
					var ad_ = AnchorList?.SortedList;
					var ae_ = AnchorList?.AnchorIndex;
					var af_ = context.Operators.Indexer<CqlDate>(ad_, ae_);
					var ag_ = context.Operators.Quantity(1m, "day");
					var ah_ = context.Operators.Add((af_ as CqlDate), ag_);
					var ak_ = context.Operators.Indexer<CqlDate>(ad_, ae_);
					var al_ = context.Operators.Quantity(30m, "days");
					var am_ = context.Operators.Add((ak_ as CqlDate), al_);
					var an_ = context.Operators.Interval(ah_, am_, true, true);
					var ao_ = context.Operators.In<CqlDate>(X, an_, null);
					var ap_ = context.Operators.Not(ao_);

					return ap_;
				};
				var v_ = context.Operators.Where<CqlDate>(DateList, u_);
				var x_ = context.Operators.Add(s_, 1);
				var y_ = ((t_ as CqlDate), v_, x_);
				var z_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
				{
					y_,
				};
				(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aa_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
				{
					(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aq_()
					{
						bool ar_()
						{
							var as_ = FirstList?.NewList;
							var at_ = FirstList?.IndexofNewDate;
							var au_ = context.Operators.Indexer<CqlDate>(as_, at_);

							return (au_ is null);
						};
						if (ar_())
						{
							return FirstList;
						}
						else
						{
							var av_ = FirstList?.NewList;
							var aw_ = FirstList?.IndexofNewDate;
							var ax_ = context.Operators.Indexer<CqlDate>(av_, aw_);
							bool? az_(CqlDate X)
							{
								var bi_ = FirstList?.NewList;
								var bj_ = FirstList?.IndexofNewDate;
								var bk_ = context.Operators.Indexer<CqlDate>(bi_, bj_);
								var bl_ = context.Operators.Quantity(1m, "day");
								var bm_ = context.Operators.Add((bk_ as CqlDate), bl_);
								var bp_ = context.Operators.Indexer<CqlDate>(bi_, bj_);
								var bq_ = context.Operators.Quantity(30m, "days");
								var br_ = context.Operators.Add((bp_ as CqlDate), bq_);
								var bs_ = context.Operators.Interval(bm_, br_, true, true);
								var bt_ = context.Operators.In<CqlDate>(X, bs_, null);
								var bu_ = context.Operators.Not(bt_);

								return bu_;
							};
							var ba_ = context.Operators.Where<CqlDate>(av_, az_);
							var bc_ = context.Operators.Add(aw_, 1);
							var bd_ = ((ax_ as CqlDate), ba_, bc_);
							var be_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
							{
								bd_,
							};
							(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bf_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
							{
								(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bv_()
								{
									bool bw_()
									{
										var bx_ = SecondList?.NewList;
										var by_ = SecondList?.IndexofNewDate;
										var bz_ = context.Operators.Indexer<CqlDate>(bx_, by_);

										return (bz_ is null);
									};
									if (bw_())
									{
										return SecondList;
									}
									else
									{
										var ca_ = SecondList?.NewList;
										var cb_ = SecondList?.IndexofNewDate;
										var cc_ = context.Operators.Indexer<CqlDate>(ca_, cb_);
										bool? ce_(CqlDate X)
										{
											var cn_ = SecondList?.NewList;
											var co_ = SecondList?.IndexofNewDate;
											var cp_ = context.Operators.Indexer<CqlDate>(cn_, co_);
											var cq_ = context.Operators.Quantity(1m, "day");
											var cr_ = context.Operators.Add((cp_ as CqlDate), cq_);
											var cu_ = context.Operators.Indexer<CqlDate>(cn_, co_);
											var cv_ = context.Operators.Quantity(30m, "days");
											var cw_ = context.Operators.Add((cu_ as CqlDate), cv_);
											var cx_ = context.Operators.Interval(cr_, cw_, true, true);
											var cy_ = context.Operators.In<CqlDate>(X, cx_, null);
											var cz_ = context.Operators.Not(cy_);

											return cz_;
										};
										var cf_ = context.Operators.Where<CqlDate>(ca_, ce_);
										var ch_ = context.Operators.Add(cb_, 1);
										var ci_ = ((cc_ as CqlDate), cf_, ch_);
										var cj_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
										{
											ci_,
										};
										(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ck_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
										{
											(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? da_()
											{
												bool db_()
												{
													var dc_ = ThirdList?.NewList;
													var dd_ = ThirdList?.IndexofNewDate;
													var de_ = context.Operators.Indexer<CqlDate>(dc_, dd_);

													return (de_ is null);
												};
												if (db_())
												{
													return ThirdList;
												}
												else
												{
													var df_ = ThirdList?.NewList;
													var dg_ = ThirdList?.IndexofNewDate;
													var dh_ = context.Operators.Indexer<CqlDate>(df_, dg_);
													bool? dj_(CqlDate X)
													{
														var ds_ = ThirdList?.NewList;
														var dt_ = ThirdList?.IndexofNewDate;
														var du_ = context.Operators.Indexer<CqlDate>(ds_, dt_);
														var dv_ = context.Operators.Quantity(1m, "day");
														var dw_ = context.Operators.Add((du_ as CqlDate), dv_);
														var dz_ = context.Operators.Indexer<CqlDate>(ds_, dt_);
														var ea_ = context.Operators.Quantity(30m, "days");
														var eb_ = context.Operators.Add((dz_ as CqlDate), ea_);
														var ec_ = context.Operators.Interval(dw_, eb_, true, true);
														var ed_ = context.Operators.In<CqlDate>(X, ec_, null);
														var ee_ = context.Operators.Not(ed_);

														return ee_;
													};
													var dk_ = context.Operators.Where<CqlDate>(df_, dj_);
													var dm_ = context.Operators.Add(dg_, 1);
													var dn_ = ((dh_ as CqlDate), dk_, dm_);
													var do_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
													{
														dn_,
													};
													(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dp_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
													{
														(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ef_()
														{
															bool eg_()
															{
																var eh_ = FourthList?.NewList;
																var ei_ = FourthList?.IndexofNewDate;
																var ej_ = context.Operators.Indexer<CqlDate>(eh_, ei_);

																return (ej_ is null);
															};
															if (eg_())
															{
																return FourthList;
															}
															else
															{
																var ek_ = FourthList?.NewList;
																var el_ = FourthList?.IndexofNewDate;
																var em_ = context.Operators.Indexer<CqlDate>(ek_, el_);
																bool? eo_(CqlDate X)
																{
																	var ex_ = FourthList?.NewList;
																	var ey_ = FourthList?.IndexofNewDate;
																	var ez_ = context.Operators.Indexer<CqlDate>(ex_, ey_);
																	var fa_ = context.Operators.Quantity(1m, "day");
																	var fb_ = context.Operators.Add((ez_ as CqlDate), fa_);
																	var fe_ = context.Operators.Indexer<CqlDate>(ex_, ey_);
																	var ff_ = context.Operators.Quantity(30m, "days");
																	var fg_ = context.Operators.Add((fe_ as CqlDate), ff_);
																	var fh_ = context.Operators.Interval(fb_, fg_, true, true);
																	var fi_ = context.Operators.In<CqlDate>(X, fh_, null);
																	var fj_ = context.Operators.Not(fi_);

																	return fj_;
																};
																var ep_ = context.Operators.Where<CqlDate>(ek_, eo_);
																var er_ = context.Operators.Add(el_, 1);
																var es_ = ((em_ as CqlDate), ep_, er_);
																var et_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
																{
																	es_,
																};
																(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eu_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
																{
																	(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fk_()
																	{
																		bool fl_()
																		{
																			var fm_ = FifthList?.NewList;
																			var fn_ = FifthList?.IndexofNewDate;
																			var fo_ = context.Operators.Indexer<CqlDate>(fm_, fn_);

																			return (fo_ is null);
																		};
																		if (fl_())
																		{
																			return FifthList;
																		}
																		else
																		{
																			var fp_ = FifthList?.NewList;
																			var fq_ = FifthList?.IndexofNewDate;
																			var fr_ = context.Operators.Indexer<CqlDate>(fp_, fq_);
																			bool? ft_(CqlDate X)
																			{
																				var gc_ = FifthList?.NewList;
																				var gd_ = FifthList?.IndexofNewDate;
																				var ge_ = context.Operators.Indexer<CqlDate>(gc_, gd_);
																				var gf_ = context.Operators.Quantity(1m, "day");
																				var gg_ = context.Operators.Add((ge_ as CqlDate), gf_);
																				var gj_ = context.Operators.Indexer<CqlDate>(gc_, gd_);
																				var gk_ = context.Operators.Quantity(30m, "days");
																				var gl_ = context.Operators.Add((gj_ as CqlDate), gk_);
																				var gm_ = context.Operators.Interval(gg_, gl_, true, true);
																				var gn_ = context.Operators.In<CqlDate>(X, gm_, null);
																				var go_ = context.Operators.Not(gn_);

																				return go_;
																			};
																			var fu_ = context.Operators.Where<CqlDate>(fp_, ft_);
																			var fw_ = context.Operators.Add(fq_, 1);
																			var fx_ = ((fr_ as CqlDate), fu_, fw_);
																			var fy_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
																			{
																				fx_,
																			};
																			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fz_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
																			{
																				(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gp_()
																				{
																					bool gq_()
																					{
																						var gr_ = SixthList?.NewList;
																						var gs_ = SixthList?.IndexofNewDate;
																						var gt_ = context.Operators.Indexer<CqlDate>(gr_, gs_);

																						return (gt_ is null);
																					};
																					if (gq_())
																					{
																						return SixthList;
																					}
																					else
																					{
																						var gu_ = SixthList?.NewList;
																						var gv_ = SixthList?.IndexofNewDate;
																						var gw_ = context.Operators.Indexer<CqlDate>(gu_, gv_);
																						bool? gy_(CqlDate X)
																						{
																							var hh_ = SixthList?.NewList;
																							var hi_ = SixthList?.IndexofNewDate;
																							var hj_ = context.Operators.Indexer<CqlDate>(hh_, hi_);
																							var hk_ = context.Operators.Quantity(1m, "day");
																							var hl_ = context.Operators.Add((hj_ as CqlDate), hk_);
																							var ho_ = context.Operators.Indexer<CqlDate>(hh_, hi_);
																							var hp_ = context.Operators.Quantity(30m, "days");
																							var hq_ = context.Operators.Add((ho_ as CqlDate), hp_);
																							var hr_ = context.Operators.Interval(hl_, hq_, true, true);
																							var hs_ = context.Operators.In<CqlDate>(X, hr_, null);
																							var ht_ = context.Operators.Not(hs_);

																							return ht_;
																						};
																						var gz_ = context.Operators.Where<CqlDate>(gu_, gy_);
																						var hb_ = context.Operators.Add(gv_, 1);
																						var hc_ = ((gw_ as CqlDate), gz_, hb_);
																						var hd_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
																						{
																							hc_,
																						};
																						(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? he_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
																						{
																							(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hu_()
																							{
																								bool hv_()
																								{
																									var hw_ = SeventhList?.NewList;
																									var hx_ = SeventhList?.IndexofNewDate;
																									var hy_ = context.Operators.Indexer<CqlDate>(hw_, hx_);

																									return (hy_ is null);
																								};
																								if (hv_())
																								{
																									return SeventhList;
																								}
																								else
																								{
																									var hz_ = SeventhList?.NewList;
																									var ia_ = SeventhList?.IndexofNewDate;
																									var ib_ = context.Operators.Indexer<CqlDate>(hz_, ia_);
																									bool? id_(CqlDate X)
																									{
																										var im_ = SeventhList?.NewList;
																										var in_ = SeventhList?.IndexofNewDate;
																										var io_ = context.Operators.Indexer<CqlDate>(im_, in_);
																										var ip_ = context.Operators.Quantity(1m, "day");
																										var iq_ = context.Operators.Add((io_ as CqlDate), ip_);
																										var it_ = context.Operators.Indexer<CqlDate>(im_, in_);
																										var iu_ = context.Operators.Quantity(30m, "days");
																										var iv_ = context.Operators.Add((it_ as CqlDate), iu_);
																										var iw_ = context.Operators.Interval(iq_, iv_, true, true);
																										var ix_ = context.Operators.In<CqlDate>(X, iw_, null);
																										var iy_ = context.Operators.Not(ix_);

																										return iy_;
																									};
																									var ie_ = context.Operators.Where<CqlDate>(hz_, id_);
																									var ig_ = context.Operators.Add(ia_, 1);
																									var ih_ = ((ib_ as CqlDate), ie_, ig_);
																									var ii_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
																									{
																										ih_,
																									};
																									(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ij_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
																									{
																										(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iz_()
																										{
																											bool ja_()
																											{
																												var jb_ = EighthList?.NewList;
																												var jc_ = EighthList?.IndexofNewDate;
																												var jd_ = context.Operators.Indexer<CqlDate>(jb_, jc_);

																												return (jd_ is null);
																											};
																											if (ja_())
																											{
																												return EighthList;
																											}
																											else
																											{
																												var je_ = EighthList?.NewList;
																												var jf_ = EighthList?.IndexofNewDate;
																												var jg_ = context.Operators.Indexer<CqlDate>(je_, jf_);
																												bool? ji_(CqlDate X)
																												{
																													var jr_ = EighthList?.NewList;
																													var js_ = EighthList?.IndexofNewDate;
																													var jt_ = context.Operators.Indexer<CqlDate>(jr_, js_);
																													var ju_ = context.Operators.Quantity(1m, "day");
																													var jv_ = context.Operators.Add((jt_ as CqlDate), ju_);
																													var jy_ = context.Operators.Indexer<CqlDate>(jr_, js_);
																													var jz_ = context.Operators.Quantity(30m, "days");
																													var ka_ = context.Operators.Add((jy_ as CqlDate), jz_);
																													var kb_ = context.Operators.Interval(jv_, ka_, true, true);
																													var kc_ = context.Operators.In<CqlDate>(X, kb_, null);
																													var kd_ = context.Operators.Not(kc_);

																													return kd_;
																												};
																												var jj_ = context.Operators.Where<CqlDate>(je_, ji_);
																												var jl_ = context.Operators.Add(jf_, 1);
																												var jm_ = ((jg_ as CqlDate), jj_, jl_);
																												var jn_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
																												{
																													jm_,
																												};
																												(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jo_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
																												{
																													(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ke_()
																													{
																														bool kf_()
																														{
																															var kg_ = NinethList?.NewList;
																															var kh_ = NinethList?.IndexofNewDate;
																															var ki_ = context.Operators.Indexer<CqlDate>(kg_, kh_);

																															return (ki_ is null);
																														};
																														if (kf_())
																														{
																															return NinethList;
																														}
																														else
																														{
																															var kj_ = NinethList?.NewList;
																															var kk_ = NinethList?.IndexofNewDate;
																															var kl_ = context.Operators.Indexer<CqlDate>(kj_, kk_);
																															bool? kn_(CqlDate X)
																															{
																																var kw_ = NinethList?.NewList;
																																var kx_ = NinethList?.IndexofNewDate;
																																var ky_ = context.Operators.Indexer<CqlDate>(kw_, kx_);
																																var kz_ = context.Operators.Quantity(1m, "day");
																																var la_ = context.Operators.Add((ky_ as CqlDate), kz_);
																																var ld_ = context.Operators.Indexer<CqlDate>(kw_, kx_);
																																var le_ = context.Operators.Quantity(30m, "days");
																																var lf_ = context.Operators.Add((ld_ as CqlDate), le_);
																																var lg_ = context.Operators.Interval(la_, lf_, true, true);
																																var lh_ = context.Operators.In<CqlDate>(X, lg_, null);
																																var li_ = context.Operators.Not(lh_);

																																return li_;
																															};
																															var ko_ = context.Operators.Where<CqlDate>(kj_, kn_);
																															var kq_ = context.Operators.Add(kk_, 1);
																															var kr_ = ((kl_ as CqlDate), ko_, kq_);
																															var ks_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
																															{
																																kr_,
																															};
																															(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kt_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
																															{
																																(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lj_()
																																{
																																	bool lk_()
																																	{
																																		var ll_ = TenthList?.NewList;
																																		var lm_ = TenthList?.IndexofNewDate;
																																		var ln_ = context.Operators.Indexer<CqlDate>(ll_, lm_);

																																		return (ln_ is null);
																																	};
																																	if (lk_())
																																	{
																																		return TenthList;
																																	}
																																	else
																																	{
																																		var lo_ = TenthList?.NewList;
																																		var lp_ = TenthList?.IndexofNewDate;
																																		var lq_ = context.Operators.Indexer<CqlDate>(lo_, lp_);
																																		bool? ls_(CqlDate X)
																																		{
																																			var mb_ = TenthList?.NewList;
																																			var mc_ = TenthList?.IndexofNewDate;
																																			var md_ = context.Operators.Indexer<CqlDate>(mb_, mc_);
																																			var me_ = context.Operators.Quantity(1m, "day");
																																			var mf_ = context.Operators.Add((md_ as CqlDate), me_);
																																			var mi_ = context.Operators.Indexer<CqlDate>(mb_, mc_);
																																			var mj_ = context.Operators.Quantity(30m, "days");
																																			var mk_ = context.Operators.Add((mi_ as CqlDate), mj_);
																																			var ml_ = context.Operators.Interval(mf_, mk_, true, true);
																																			var mm_ = context.Operators.In<CqlDate>(X, ml_, null);
																																			var mn_ = context.Operators.Not(mm_);

																																			return mn_;
																																		};
																																		var lt_ = context.Operators.Where<CqlDate>(lo_, ls_);
																																		var lv_ = context.Operators.Add(lp_, 1);
																																		var lw_ = ((lq_ as CqlDate), lt_, lv_);
																																		var lx_ = new (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[]
																																		{
																																			lw_,
																																		};
																																		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ly_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
																																		{
																																			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mo_()
																																			{
																																				bool mp_()
																																				{
																																					var mq_ = EleventhList?.NewList;
																																					var mr_ = EleventhList?.IndexofNewDate;
																																					var ms_ = context.Operators.Indexer<CqlDate>(mq_, mr_);

																																					return (ms_ is null);
																																				};
																																				if (mp_())
																																				{
																																					return EleventhList;
																																				}
																																				else
																																				{
																																					var mt_ = EleventhList?.NewList;
																																					var mu_ = EleventhList?.IndexofNewDate;
																																					var mv_ = context.Operators.Indexer<CqlDate>(mt_, mu_);
																																					bool? mx_(CqlDate X)
																																					{
																																						var nc_ = EleventhList?.NewList;
																																						var nd_ = EleventhList?.IndexofNewDate;
																																						var ne_ = context.Operators.Indexer<CqlDate>(nc_, nd_);
																																						var nf_ = context.Operators.Quantity(1m, "day");
																																						var ng_ = context.Operators.Add((ne_ as CqlDate), nf_);
																																						var nj_ = context.Operators.Indexer<CqlDate>(nc_, nd_);
																																						var nk_ = context.Operators.Quantity(30m, "days");
																																						var nl_ = context.Operators.Add((nj_ as CqlDate), nk_);
																																						var nm_ = context.Operators.Interval(ng_, nl_, true, true);
																																						var nn_ = context.Operators.In<CqlDate>(X, nm_, null);
																																						var no_ = context.Operators.Not(nn_);

																																						return no_;
																																					};
																																					var my_ = context.Operators.Where<CqlDate>(mt_, mx_);
																																					var na_ = context.Operators.Add(mu_, 1);
																																					var nb_ = ((mv_ as CqlDate), my_, na_);

																																					return nb_;
																																				}
																																			};

																																			return mo_();
																																		};
																																		var lz_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)lx_), ly_);
																																		var ma_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lz_);

																																		return ma_;
																																	}
																																};

																																return lj_();
																															};
																															var ku_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ks_), kt_);
																															var kv_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ku_);

																															return kv_;
																														}
																													};

																													return ke_();
																												};
																												var jp_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)jn_), jo_);
																												var jq_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jp_);

																												return jq_;
																											}
																										};

																										return iz_();
																									};
																									var ik_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ii_), ij_);
																									var il_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ik_);

																									return il_;
																								}
																							};

																							return hu_();
																						};
																						var hf_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hd_), he_);
																						var hg_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hf_);

																						return hg_;
																					}
																				};

																				return gp_();
																			};
																			var ga_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fy_), fz_);
																			var gb_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ga_);

																			return gb_;
																		}
																	};

																	return fk_();
																};
																var ev_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)et_), eu_);
																var ew_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ev_);

																return ew_;
															}
														};

														return ef_();
													};
													var dq_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)do_), dp_);
													var dr_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dq_);

													return dr_;
												}
											};

											return da_();
										};
										var cl_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cj_), ck_);
										var cm_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cl_);

										return cm_;
									}
								};

								return bv_();
							};
							var bg_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)be_), bf_);
							var bh_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bg_);

							return bh_;
						}
					};

					return aq_();
				};
				var ab_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)z_), aa_);
				var ac_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ab_);

				return ac_;
			};
			var p_ = context.Operators.Select<(IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)n_), o_);
			var q_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(p_);

			return q_;
		};
		var i_ = context.Operators.Select<(IEnumerable<CqlDate> SortedDates, nint _)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(((IEnumerable<(IEnumerable<CqlDate> SortedDates, nint _)?>)g_), h_);
		var j_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(i_);

		return j_;
	}

}
