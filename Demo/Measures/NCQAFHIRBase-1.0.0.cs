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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
				var f_ = e_?.Value;
				var g_ = context.Operators.ConvertStringToDateTime(f_);
				var h_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
				var i_ = h_?.Value;
				var j_ = context.Operators.ConvertStringToDateTime(i_);
				var k_ = context.Operators.Interval(g_, j_, true, true);

				return k_;
			}
			else if (onset is FhirString)
			{
				CqlInterval<CqlDateTime> l_ = null;
				var m_ = context.Operators.Message<CqlInterval<CqlDateTime>>((l_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return m_;
			}
			else
			{
				CqlInterval<CqlDate> n_()
				{
					if (onset is Age)
					{
						var y_ = this.Patient();
						var z_ = y_?.BirthDateElement;
						var aa_ = FHIRHelpers_4_0_001.ToDate(z_);
						var ab_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var ac_ = context.Operators.Add(aa_, ab_);
						var ae_ = y_?.BirthDateElement;
						var af_ = FHIRHelpers_4_0_001.ToDate(ae_);
						var ah_ = context.Operators.Add(af_, ab_);
						var ai_ = context.Operators.Quantity(1m, "year");
						var aj_ = context.Operators.Add(ah_, ai_);
						var ak_ = context.Operators.Interval(ac_, aj_, true, false);

						return ak_;
					}
					else if (onset is Range)
					{
						var al_ = this.Patient();
						var am_ = al_?.BirthDateElement;
						var an_ = FHIRHelpers_4_0_001.ToDate(am_);
						var ao_ = (onset as Range)?.Low;
						var ap_ = FHIRHelpers_4_0_001.ToQuantity(ao_);
						var aq_ = context.Operators.Add(an_, ap_);
						var as_ = al_?.BirthDateElement;
						var at_ = FHIRHelpers_4_0_001.ToDate(as_);
						var au_ = (onset as Range)?.High;
						var av_ = FHIRHelpers_4_0_001.ToQuantity(au_);
						var aw_ = context.Operators.Add(at_, av_);
						var ax_ = context.Operators.Quantity(1m, "year");
						var ay_ = context.Operators.Add(aw_, ax_);
						var az_ = context.Operators.Interval(aq_, ay_, true, false);

						return az_;
					}
					else
					{
						CqlInterval<CqlDate> ba_ = null;

						return (ba_ as CqlInterval<CqlDate>);
					};
				};
				var o_ = n_()?.low;
				var p_ = context.Operators.ConvertDateToDateTime(o_);
				CqlInterval<CqlDate> q_()
				{
					if (onset is Age)
					{
						var bb_ = this.Patient();
						var bc_ = bb_?.BirthDateElement;
						var bd_ = FHIRHelpers_4_0_001.ToDate(bc_);
						var be_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var bf_ = context.Operators.Add(bd_, be_);
						var bh_ = bb_?.BirthDateElement;
						var bi_ = FHIRHelpers_4_0_001.ToDate(bh_);
						var bk_ = context.Operators.Add(bi_, be_);
						var bl_ = context.Operators.Quantity(1m, "year");
						var bm_ = context.Operators.Add(bk_, bl_);
						var bn_ = context.Operators.Interval(bf_, bm_, true, false);

						return bn_;
					}
					else if (onset is Range)
					{
						var bo_ = this.Patient();
						var bp_ = bo_?.BirthDateElement;
						var bq_ = FHIRHelpers_4_0_001.ToDate(bp_);
						var br_ = (onset as Range)?.Low;
						var bs_ = FHIRHelpers_4_0_001.ToQuantity(br_);
						var bt_ = context.Operators.Add(bq_, bs_);
						var bv_ = bo_?.BirthDateElement;
						var bw_ = FHIRHelpers_4_0_001.ToDate(bv_);
						var bx_ = (onset as Range)?.High;
						var by_ = FHIRHelpers_4_0_001.ToQuantity(bx_);
						var bz_ = context.Operators.Add(bw_, by_);
						var ca_ = context.Operators.Quantity(1m, "year");
						var cb_ = context.Operators.Add(bz_, ca_);
						var cc_ = context.Operators.Interval(bt_, cb_, true, false);

						return cc_;
					}
					else
					{
						CqlInterval<CqlDate> cd_ = null;

						return (cd_ as CqlInterval<CqlDate>);
					};
				};
				var r_ = q_()?.high;
				var s_ = context.Operators.ConvertDateToDateTime(r_);
				CqlInterval<CqlDate> t_()
				{
					if (onset is Age)
					{
						var ce_ = this.Patient();
						var cf_ = ce_?.BirthDateElement;
						var cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
						var ch_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var ci_ = context.Operators.Add(cg_, ch_);
						var ck_ = ce_?.BirthDateElement;
						var cl_ = FHIRHelpers_4_0_001.ToDate(ck_);
						var cn_ = context.Operators.Add(cl_, ch_);
						var co_ = context.Operators.Quantity(1m, "year");
						var cp_ = context.Operators.Add(cn_, co_);
						var cq_ = context.Operators.Interval(ci_, cp_, true, false);

						return cq_;
					}
					else if (onset is Range)
					{
						var cr_ = this.Patient();
						var cs_ = cr_?.BirthDateElement;
						var ct_ = FHIRHelpers_4_0_001.ToDate(cs_);
						var cu_ = (onset as Range)?.Low;
						var cv_ = FHIRHelpers_4_0_001.ToQuantity(cu_);
						var cw_ = context.Operators.Add(ct_, cv_);
						var cy_ = cr_?.BirthDateElement;
						var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
						var da_ = (onset as Range)?.High;
						var db_ = FHIRHelpers_4_0_001.ToQuantity(da_);
						var dc_ = context.Operators.Add(cz_, db_);
						var dd_ = context.Operators.Quantity(1m, "year");
						var de_ = context.Operators.Add(dc_, dd_);
						var df_ = context.Operators.Interval(cw_, de_, true, false);

						return df_;
					}
					else
					{
						CqlInterval<CqlDate> dg_ = null;

						return (dg_ as CqlInterval<CqlDate>);
					};
				};
				var u_ = t_()?.lowClosed;
				CqlInterval<CqlDate> v_()
				{
					if (onset is Age)
					{
						var dh_ = this.Patient();
						var di_ = dh_?.BirthDateElement;
						var dj_ = FHIRHelpers_4_0_001.ToDate(di_);
						var dk_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var dl_ = context.Operators.Add(dj_, dk_);
						var dn_ = dh_?.BirthDateElement;
						var do_ = FHIRHelpers_4_0_001.ToDate(dn_);
						var dq_ = context.Operators.Add(do_, dk_);
						var dr_ = context.Operators.Quantity(1m, "year");
						var ds_ = context.Operators.Add(dq_, dr_);
						var dt_ = context.Operators.Interval(dl_, ds_, true, false);

						return dt_;
					}
					else if (onset is Range)
					{
						var du_ = this.Patient();
						var dv_ = du_?.BirthDateElement;
						var dw_ = FHIRHelpers_4_0_001.ToDate(dv_);
						var dx_ = (onset as Range)?.Low;
						var dy_ = FHIRHelpers_4_0_001.ToQuantity(dx_);
						var dz_ = context.Operators.Add(dw_, dy_);
						var eb_ = du_?.BirthDateElement;
						var ec_ = FHIRHelpers_4_0_001.ToDate(eb_);
						var ed_ = (onset as Range)?.High;
						var ee_ = FHIRHelpers_4_0_001.ToQuantity(ed_);
						var ef_ = context.Operators.Add(ec_, ee_);
						var eg_ = context.Operators.Quantity(1m, "year");
						var eh_ = context.Operators.Add(ef_, eg_);
						var ei_ = context.Operators.Interval(dz_, eh_, true, false);

						return ei_;
					}
					else
					{
						CqlInterval<CqlDate> ej_ = null;

						return (ej_ as CqlInterval<CqlDate>);
					};
				};
				var w_ = v_()?.highClosed;
				var x_ = context.Operators.Interval(p_, s_, u_, w_);

				return x_;
			};
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
				var f_ = e_?.Value;
				var g_ = context.Operators.ConvertStringToDateTime(f_);
				var h_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
				var i_ = h_?.Value;
				var j_ = context.Operators.ConvertStringToDateTime(i_);
				var k_ = context.Operators.Interval(g_, j_, true, true);

				return k_;
			}
			else if (abatement is FhirString)
			{
				CqlInterval<CqlDateTime> l_ = null;
				var m_ = context.Operators.Message<CqlInterval<CqlDateTime>>((l_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return m_;
			}
			else
			{
				CqlInterval<CqlDate> n_()
				{
					if (abatement is Age)
					{
						var y_ = this.Patient();
						var z_ = y_?.BirthDateElement;
						var aa_ = FHIRHelpers_4_0_001.ToDate(z_);
						var ab_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var ac_ = context.Operators.Add(aa_, ab_);
						var ae_ = y_?.BirthDateElement;
						var af_ = FHIRHelpers_4_0_001.ToDate(ae_);
						var ah_ = context.Operators.Add(af_, ab_);
						var ai_ = context.Operators.Quantity(1m, "year");
						var aj_ = context.Operators.Add(ah_, ai_);
						var ak_ = context.Operators.Interval(ac_, aj_, true, false);

						return ak_;
					}
					else if (abatement is Range)
					{
						var al_ = this.Patient();
						var am_ = al_?.BirthDateElement;
						var an_ = FHIRHelpers_4_0_001.ToDate(am_);
						var ao_ = (abatement as Range)?.Low;
						var ap_ = FHIRHelpers_4_0_001.ToQuantity(ao_);
						var aq_ = context.Operators.Add(an_, ap_);
						var as_ = al_?.BirthDateElement;
						var at_ = FHIRHelpers_4_0_001.ToDate(as_);
						var au_ = (abatement as Range)?.High;
						var av_ = FHIRHelpers_4_0_001.ToQuantity(au_);
						var aw_ = context.Operators.Add(at_, av_);
						var ax_ = context.Operators.Quantity(1m, "year");
						var ay_ = context.Operators.Add(aw_, ax_);
						var az_ = context.Operators.Interval(aq_, ay_, true, false);

						return az_;
					}
					else
					{
						CqlInterval<CqlDate> ba_ = null;

						return (ba_ as CqlInterval<CqlDate>);
					};
				};
				var o_ = n_()?.low;
				var p_ = context.Operators.ConvertDateToDateTime(o_);
				CqlInterval<CqlDate> q_()
				{
					if (abatement is Age)
					{
						var bb_ = this.Patient();
						var bc_ = bb_?.BirthDateElement;
						var bd_ = FHIRHelpers_4_0_001.ToDate(bc_);
						var be_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var bf_ = context.Operators.Add(bd_, be_);
						var bh_ = bb_?.BirthDateElement;
						var bi_ = FHIRHelpers_4_0_001.ToDate(bh_);
						var bk_ = context.Operators.Add(bi_, be_);
						var bl_ = context.Operators.Quantity(1m, "year");
						var bm_ = context.Operators.Add(bk_, bl_);
						var bn_ = context.Operators.Interval(bf_, bm_, true, false);

						return bn_;
					}
					else if (abatement is Range)
					{
						var bo_ = this.Patient();
						var bp_ = bo_?.BirthDateElement;
						var bq_ = FHIRHelpers_4_0_001.ToDate(bp_);
						var br_ = (abatement as Range)?.Low;
						var bs_ = FHIRHelpers_4_0_001.ToQuantity(br_);
						var bt_ = context.Operators.Add(bq_, bs_);
						var bv_ = bo_?.BirthDateElement;
						var bw_ = FHIRHelpers_4_0_001.ToDate(bv_);
						var bx_ = (abatement as Range)?.High;
						var by_ = FHIRHelpers_4_0_001.ToQuantity(bx_);
						var bz_ = context.Operators.Add(bw_, by_);
						var ca_ = context.Operators.Quantity(1m, "year");
						var cb_ = context.Operators.Add(bz_, ca_);
						var cc_ = context.Operators.Interval(bt_, cb_, true, false);

						return cc_;
					}
					else
					{
						CqlInterval<CqlDate> cd_ = null;

						return (cd_ as CqlInterval<CqlDate>);
					};
				};
				var r_ = q_()?.high;
				var s_ = context.Operators.ConvertDateToDateTime(r_);
				CqlInterval<CqlDate> t_()
				{
					if (abatement is Age)
					{
						var ce_ = this.Patient();
						var cf_ = ce_?.BirthDateElement;
						var cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
						var ch_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var ci_ = context.Operators.Add(cg_, ch_);
						var ck_ = ce_?.BirthDateElement;
						var cl_ = FHIRHelpers_4_0_001.ToDate(ck_);
						var cn_ = context.Operators.Add(cl_, ch_);
						var co_ = context.Operators.Quantity(1m, "year");
						var cp_ = context.Operators.Add(cn_, co_);
						var cq_ = context.Operators.Interval(ci_, cp_, true, false);

						return cq_;
					}
					else if (abatement is Range)
					{
						var cr_ = this.Patient();
						var cs_ = cr_?.BirthDateElement;
						var ct_ = FHIRHelpers_4_0_001.ToDate(cs_);
						var cu_ = (abatement as Range)?.Low;
						var cv_ = FHIRHelpers_4_0_001.ToQuantity(cu_);
						var cw_ = context.Operators.Add(ct_, cv_);
						var cy_ = cr_?.BirthDateElement;
						var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
						var da_ = (abatement as Range)?.High;
						var db_ = FHIRHelpers_4_0_001.ToQuantity(da_);
						var dc_ = context.Operators.Add(cz_, db_);
						var dd_ = context.Operators.Quantity(1m, "year");
						var de_ = context.Operators.Add(dc_, dd_);
						var df_ = context.Operators.Interval(cw_, de_, true, false);

						return df_;
					}
					else
					{
						CqlInterval<CqlDate> dg_ = null;

						return (dg_ as CqlInterval<CqlDate>);
					};
				};
				var u_ = t_()?.lowClosed;
				CqlInterval<CqlDate> v_()
				{
					if (abatement is Age)
					{
						var dh_ = this.Patient();
						var di_ = dh_?.BirthDateElement;
						var dj_ = FHIRHelpers_4_0_001.ToDate(di_);
						var dk_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var dl_ = context.Operators.Add(dj_, dk_);
						var dn_ = dh_?.BirthDateElement;
						var do_ = FHIRHelpers_4_0_001.ToDate(dn_);
						var dq_ = context.Operators.Add(do_, dk_);
						var dr_ = context.Operators.Quantity(1m, "year");
						var ds_ = context.Operators.Add(dq_, dr_);
						var dt_ = context.Operators.Interval(dl_, ds_, true, false);

						return dt_;
					}
					else if (abatement is Range)
					{
						var du_ = this.Patient();
						var dv_ = du_?.BirthDateElement;
						var dw_ = FHIRHelpers_4_0_001.ToDate(dv_);
						var dx_ = (abatement as Range)?.Low;
						var dy_ = FHIRHelpers_4_0_001.ToQuantity(dx_);
						var dz_ = context.Operators.Add(dw_, dy_);
						var eb_ = du_?.BirthDateElement;
						var ec_ = FHIRHelpers_4_0_001.ToDate(eb_);
						var ed_ = (abatement as Range)?.High;
						var ee_ = FHIRHelpers_4_0_001.ToQuantity(ed_);
						var ef_ = context.Operators.Add(ec_, ee_);
						var eg_ = context.Operators.Quantity(1m, "year");
						var eh_ = context.Operators.Add(ef_, eg_);
						var ei_ = context.Operators.Interval(dz_, eh_, true, false);

						return ei_;
					}
					else
					{
						CqlInterval<CqlDate> ej_ = null;

						return (ej_ as CqlInterval<CqlDate>);
					};
				};
				var w_ = v_()?.highClosed;
				var x_ = context.Operators.Interval(p_, s_, u_, w_);

				return x_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		var a_ = condition?.Onset;
		var b_ = this.Normalize_Onset(a_);
		var c_ = context.Operators.Start(b_);
		var d_ = condition?.Abatement;
		var e_ = this.Normalize_Abatement(d_);
		var f_ = context.Operators.End(e_);
		var g_ = context.Operators.Interval(c_, f_, true, true);

		return g_;
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
				var k_ = j_?.Value;
				var l_ = context.Operators.ConvertStringToDateTime(k_);
				var m_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
				var n_ = m_?.Value;
				var o_ = context.Operators.ConvertStringToDateTime(n_);
				var p_ = context.Operators.Interval(l_, o_, true, true);

				return p_;
			}
			else if (choice is Instant)
			{
				var q_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				var s_ = context.Operators.Interval(q_, q_, true, true);

				return s_;
			}
			else if (choice is Age)
			{
				var t_ = this.Patient();
				var u_ = t_?.BirthDateElement;
				var v_ = FHIRHelpers_4_0_001.ToDate(u_);
				var w_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var x_ = context.Operators.Add(v_, w_);
				var z_ = t_?.BirthDateElement;
				var aa_ = FHIRHelpers_4_0_001.ToDate(z_);
				var ac_ = context.Operators.Add(aa_, w_);
				var ad_ = context.Operators.Quantity(1m, "year");
				var ae_ = context.Operators.Add(ac_, ad_);
				var af_ = context.Operators.Interval(x_, ae_, true, false);
				var ag_ = af_?.low;
				var ah_ = context.Operators.ConvertDateToDateTime(ag_);
				var aj_ = t_?.BirthDateElement;
				var ak_ = FHIRHelpers_4_0_001.ToDate(aj_);
				var am_ = context.Operators.Add(ak_, w_);
				var ao_ = t_?.BirthDateElement;
				var ap_ = FHIRHelpers_4_0_001.ToDate(ao_);
				var ar_ = context.Operators.Add(ap_, w_);
				var at_ = context.Operators.Add(ar_, ad_);
				var au_ = context.Operators.Interval(am_, at_, true, false);
				var av_ = au_?.high;
				var aw_ = context.Operators.ConvertDateToDateTime(av_);
				var ay_ = t_?.BirthDateElement;
				var az_ = FHIRHelpers_4_0_001.ToDate(ay_);
				var bb_ = context.Operators.Add(az_, w_);
				var bd_ = t_?.BirthDateElement;
				var be_ = FHIRHelpers_4_0_001.ToDate(bd_);
				var bg_ = context.Operators.Add(be_, w_);
				var bi_ = context.Operators.Add(bg_, ad_);
				var bj_ = context.Operators.Interval(bb_, bi_, true, false);
				var bk_ = bj_?.lowClosed;
				var bm_ = t_?.BirthDateElement;
				var bn_ = FHIRHelpers_4_0_001.ToDate(bm_);
				var bp_ = context.Operators.Add(bn_, w_);
				var br_ = t_?.BirthDateElement;
				var bs_ = FHIRHelpers_4_0_001.ToDate(br_);
				var bu_ = context.Operators.Add(bs_, w_);
				var bw_ = context.Operators.Add(bu_, ad_);
				var bx_ = context.Operators.Interval(bp_, bw_, true, false);
				var by_ = bx_?.highClosed;
				var bz_ = context.Operators.Interval(ah_, aw_, bk_, by_);

				return bz_;
			}
			else if (choice is Range)
			{
				var ca_ = this.Patient();
				var cb_ = ca_?.BirthDateElement;
				var cc_ = FHIRHelpers_4_0_001.ToDate(cb_);
				var cd_ = (choice as Range)?.Low;
				var ce_ = FHIRHelpers_4_0_001.ToQuantity(cd_);
				var cf_ = context.Operators.Add(cc_, ce_);
				var ch_ = ca_?.BirthDateElement;
				var ci_ = FHIRHelpers_4_0_001.ToDate(ch_);
				var cj_ = (choice as Range)?.High;
				var ck_ = FHIRHelpers_4_0_001.ToQuantity(cj_);
				var cl_ = context.Operators.Add(ci_, ck_);
				var cm_ = context.Operators.Quantity(1m, "year");
				var cn_ = context.Operators.Add(cl_, cm_);
				var co_ = context.Operators.Interval(cf_, cn_, true, false);
				var cp_ = co_?.low;
				var cq_ = context.Operators.ConvertDateToDateTime(cp_);
				var cs_ = ca_?.BirthDateElement;
				var ct_ = FHIRHelpers_4_0_001.ToDate(cs_);
				var cv_ = FHIRHelpers_4_0_001.ToQuantity(cd_);
				var cw_ = context.Operators.Add(ct_, cv_);
				var cy_ = ca_?.BirthDateElement;
				var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
				var db_ = FHIRHelpers_4_0_001.ToQuantity(cj_);
				var dc_ = context.Operators.Add(cz_, db_);
				var de_ = context.Operators.Add(dc_, cm_);
				var df_ = context.Operators.Interval(cw_, de_, true, false);
				var dg_ = df_?.high;
				var dh_ = context.Operators.ConvertDateToDateTime(dg_);
				var dj_ = ca_?.BirthDateElement;
				var dk_ = FHIRHelpers_4_0_001.ToDate(dj_);
				var dm_ = FHIRHelpers_4_0_001.ToQuantity(cd_);
				var dn_ = context.Operators.Add(dk_, dm_);
				var dp_ = ca_?.BirthDateElement;
				var dq_ = FHIRHelpers_4_0_001.ToDate(dp_);
				var ds_ = FHIRHelpers_4_0_001.ToQuantity(cj_);
				var dt_ = context.Operators.Add(dq_, ds_);
				var dv_ = context.Operators.Add(dt_, cm_);
				var dw_ = context.Operators.Interval(dn_, dv_, true, false);
				var dx_ = dw_?.lowClosed;
				var dz_ = ca_?.BirthDateElement;
				var ea_ = FHIRHelpers_4_0_001.ToDate(dz_);
				var ec_ = FHIRHelpers_4_0_001.ToQuantity(cd_);
				var ed_ = context.Operators.Add(ea_, ec_);
				var ef_ = ca_?.BirthDateElement;
				var eg_ = FHIRHelpers_4_0_001.ToDate(ef_);
				var ei_ = FHIRHelpers_4_0_001.ToQuantity(cj_);
				var ej_ = context.Operators.Add(eg_, ei_);
				var el_ = context.Operators.Add(ej_, cm_);
				var em_ = context.Operators.Interval(ed_, el_, true, false);
				var en_ = em_?.highClosed;
				var eo_ = context.Operators.Interval(cq_, dh_, dx_, en_);

				return eo_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> ep_ = null;
				var eq_ = context.Operators.Message<CqlInterval<CqlDateTime>>((ep_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return eq_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> er_ = null;
				var es_ = context.Operators.Message<CqlInterval<CqlDateTime>>((er_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return es_;
			}
			else
			{
				CqlInterval<CqlDateTime> et_ = null;

				return (et_ as CqlInterval<CqlDateTime>);
			};
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public string GetId(string uri)
	{
		string a_()
		{
			if ((context.Operators.Greater(context.Operators.PositionOf("/", uri), (int?)0) ?? false))
			{
				var b_ = context.Operators.Split(uri, "/");
				var c_ = context.Operators.LastOfList<string>(b_);

				return c_;
			}
			else
			{
				return uri;
			};
		};

		return a_();
	}

    [CqlDeclaration("VS Cast Function")]
	public IEnumerable<CqlCode> VS_Cast_Function(IEnumerable<CqlCode> VSet) => 
		VSet;

    [CqlDeclaration("First Dates per 31 Day Periods")]
	public Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT First_Dates_per_31_Day_Periods(IEnumerable<CqlDate> DateList)
	{
		CqlDate a_(CqlDate d) => 
			d;
		var b_ = context.Operators.SelectOrNull<CqlDate, CqlDate>(DateList, a_);
		var c_ = context.Operators.ListSort<CqlDate>(b_, System.ComponentModel.ListSortDirection.Ascending);
		bool? d_(CqlDate X)
		{
			var k_ = context.Operators.Not((bool?)(X is null));

			return k_;
		};
		var e_ = context.Operators.WhereOrNull<CqlDate>(c_, d_);
		var f_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = e_,
		};
		var g_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			f_,
		};
		Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT h_(Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates)
		{
			var l_ = SortedDates?.SortedDates;
			var m_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = l_,
				AnchorIndex = (int?)0,
			};
			var n_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				m_,
			};
			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT o_(Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList)
			{
				var r_ = AnchorList?.SortedList;
				var s_ = AnchorList?.AnchorIndex;
				var t_ = context.Operators.ListElementAt<CqlDate>(r_, s_);
				bool? u_(CqlDate X)
				{
					var ad_ = AnchorList?.SortedList;
					var ae_ = AnchorList?.AnchorIndex;
					var af_ = context.Operators.ListElementAt<CqlDate>(ad_, ae_);
					var ag_ = context.Operators.Quantity(1m, "day");
					var ah_ = context.Operators.Add((af_ as CqlDate), ag_);
					var ak_ = context.Operators.ListElementAt<CqlDate>(ad_, ae_);
					var al_ = context.Operators.Quantity(30m, "days");
					var am_ = context.Operators.Add((ak_ as CqlDate), al_);
					var an_ = context.Operators.Interval(ah_, am_, true, true);
					var ao_ = context.Operators.ElementInInterval<CqlDate>(X, an_, null);
					var ap_ = context.Operators.Not(ao_);

					return ap_;
				};
				var v_ = context.Operators.WhereOrNull<CqlDate>(DateList, u_);
				var x_ = context.Operators.Add(s_, (int?)1);
				var y_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = (t_ as CqlDate),
					NewList = v_,
					IndexofNewDate = x_,
				};
				var z_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					y_,
				};
				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT aa_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList)
				{
					Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT aq_()
					{
						if ((context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) is null))
						{
							return FirstList;
						}
						else
						{
							var ar_ = FirstList?.NewList;
							var as_ = FirstList?.IndexofNewDate;
							var at_ = context.Operators.ListElementAt<CqlDate>(ar_, as_);
							bool? av_(CqlDate X)
							{
								var be_ = FirstList?.NewList;
								var bf_ = FirstList?.IndexofNewDate;
								var bg_ = context.Operators.ListElementAt<CqlDate>(be_, bf_);
								var bh_ = context.Operators.Quantity(1m, "day");
								var bi_ = context.Operators.Add((bg_ as CqlDate), bh_);
								var bl_ = context.Operators.ListElementAt<CqlDate>(be_, bf_);
								var bm_ = context.Operators.Quantity(30m, "days");
								var bn_ = context.Operators.Add((bl_ as CqlDate), bm_);
								var bo_ = context.Operators.Interval(bi_, bn_, true, true);
								var bp_ = context.Operators.ElementInInterval<CqlDate>(X, bo_, null);
								var bq_ = context.Operators.Not(bp_);

								return bq_;
							};
							var aw_ = context.Operators.WhereOrNull<CqlDate>(ar_, av_);
							var ay_ = context.Operators.Add(as_, (int?)1);
							var az_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
							{
								NextDate = (at_ as CqlDate),
								NewList = aw_,
								IndexofNewDate = ay_,
							};
							var ba_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
							{
								az_,
							};
							Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bb_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SecondList)
							{
								Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT br_()
								{
									if ((context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) is null))
									{
										return SecondList;
									}
									else
									{
										var bs_ = SecondList?.NewList;
										var bt_ = SecondList?.IndexofNewDate;
										var bu_ = context.Operators.ListElementAt<CqlDate>(bs_, bt_);
										bool? bw_(CqlDate X)
										{
											var cf_ = SecondList?.NewList;
											var cg_ = SecondList?.IndexofNewDate;
											var ch_ = context.Operators.ListElementAt<CqlDate>(cf_, cg_);
											var ci_ = context.Operators.Quantity(1m, "day");
											var cj_ = context.Operators.Add((ch_ as CqlDate), ci_);
											var cm_ = context.Operators.ListElementAt<CqlDate>(cf_, cg_);
											var cn_ = context.Operators.Quantity(30m, "days");
											var co_ = context.Operators.Add((cm_ as CqlDate), cn_);
											var cp_ = context.Operators.Interval(cj_, co_, true, true);
											var cq_ = context.Operators.ElementInInterval<CqlDate>(X, cp_, null);
											var cr_ = context.Operators.Not(cq_);

											return cr_;
										};
										var bx_ = context.Operators.WhereOrNull<CqlDate>(bs_, bw_);
										var bz_ = context.Operators.Add(bt_, (int?)1);
										var ca_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
										{
											NextDate = (bu_ as CqlDate),
											NewList = bx_,
											IndexofNewDate = bz_,
										};
										var cb_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
										{
											ca_,
										};
										Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cc_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ThirdList)
										{
											Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cs_()
											{
												if ((context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) is null))
												{
													return ThirdList;
												}
												else
												{
													var ct_ = ThirdList?.NewList;
													var cu_ = ThirdList?.IndexofNewDate;
													var cv_ = context.Operators.ListElementAt<CqlDate>(ct_, cu_);
													bool? cx_(CqlDate X)
													{
														var dg_ = ThirdList?.NewList;
														var dh_ = ThirdList?.IndexofNewDate;
														var di_ = context.Operators.ListElementAt<CqlDate>(dg_, dh_);
														var dj_ = context.Operators.Quantity(1m, "day");
														var dk_ = context.Operators.Add((di_ as CqlDate), dj_);
														var dn_ = context.Operators.ListElementAt<CqlDate>(dg_, dh_);
														var do_ = context.Operators.Quantity(30m, "days");
														var dp_ = context.Operators.Add((dn_ as CqlDate), do_);
														var dq_ = context.Operators.Interval(dk_, dp_, true, true);
														var dr_ = context.Operators.ElementInInterval<CqlDate>(X, dq_, null);
														var ds_ = context.Operators.Not(dr_);

														return ds_;
													};
													var cy_ = context.Operators.WhereOrNull<CqlDate>(ct_, cx_);
													var da_ = context.Operators.Add(cu_, (int?)1);
													var db_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = (cv_ as CqlDate),
														NewList = cy_,
														IndexofNewDate = da_,
													};
													var dc_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
													{
														db_,
													};
													Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dd_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FourthList)
													{
														Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dt_()
														{
															if ((context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) is null))
															{
																return FourthList;
															}
															else
															{
																var du_ = FourthList?.NewList;
																var dv_ = FourthList?.IndexofNewDate;
																var dw_ = context.Operators.ListElementAt<CqlDate>(du_, dv_);
																bool? dy_(CqlDate X)
																{
																	var eh_ = FourthList?.NewList;
																	var ei_ = FourthList?.IndexofNewDate;
																	var ej_ = context.Operators.ListElementAt<CqlDate>(eh_, ei_);
																	var ek_ = context.Operators.Quantity(1m, "day");
																	var el_ = context.Operators.Add((ej_ as CqlDate), ek_);
																	var eo_ = context.Operators.ListElementAt<CqlDate>(eh_, ei_);
																	var ep_ = context.Operators.Quantity(30m, "days");
																	var eq_ = context.Operators.Add((eo_ as CqlDate), ep_);
																	var er_ = context.Operators.Interval(el_, eq_, true, true);
																	var es_ = context.Operators.ElementInInterval<CqlDate>(X, er_, null);
																	var et_ = context.Operators.Not(es_);

																	return et_;
																};
																var dz_ = context.Operators.WhereOrNull<CqlDate>(du_, dy_);
																var eb_ = context.Operators.Add(dv_, (int?)1);
																var ec_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																{
																	NextDate = (dw_ as CqlDate),
																	NewList = dz_,
																	IndexofNewDate = eb_,
																};
																var ed_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																{
																	ec_,
																};
																Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ee_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FifthList)
																{
																	Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT eu_()
																	{
																		if ((context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) is null))
																		{
																			return FifthList;
																		}
																		else
																		{
																			var ev_ = FifthList?.NewList;
																			var ew_ = FifthList?.IndexofNewDate;
																			var ex_ = context.Operators.ListElementAt<CqlDate>(ev_, ew_);
																			bool? ez_(CqlDate X)
																			{
																				var fi_ = FifthList?.NewList;
																				var fj_ = FifthList?.IndexofNewDate;
																				var fk_ = context.Operators.ListElementAt<CqlDate>(fi_, fj_);
																				var fl_ = context.Operators.Quantity(1m, "day");
																				var fm_ = context.Operators.Add((fk_ as CqlDate), fl_);
																				var fp_ = context.Operators.ListElementAt<CqlDate>(fi_, fj_);
																				var fq_ = context.Operators.Quantity(30m, "days");
																				var fr_ = context.Operators.Add((fp_ as CqlDate), fq_);
																				var fs_ = context.Operators.Interval(fm_, fr_, true, true);
																				var ft_ = context.Operators.ElementInInterval<CqlDate>(X, fs_, null);
																				var fu_ = context.Operators.Not(ft_);

																				return fu_;
																			};
																			var fa_ = context.Operators.WhereOrNull<CqlDate>(ev_, ez_);
																			var fc_ = context.Operators.Add(ew_, (int?)1);
																			var fd_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																			{
																				NextDate = (ex_ as CqlDate),
																				NewList = fa_,
																				IndexofNewDate = fc_,
																			};
																			var fe_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																			{
																				fd_,
																			};
																			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ff_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SixthList)
																			{
																				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fv_()
																				{
																					if ((context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) is null))
																					{
																						return SixthList;
																					}
																					else
																					{
																						var fw_ = SixthList?.NewList;
																						var fx_ = SixthList?.IndexofNewDate;
																						var fy_ = context.Operators.ListElementAt<CqlDate>(fw_, fx_);
																						bool? ga_(CqlDate X)
																						{
																							var gj_ = SixthList?.NewList;
																							var gk_ = SixthList?.IndexofNewDate;
																							var gl_ = context.Operators.ListElementAt<CqlDate>(gj_, gk_);
																							var gm_ = context.Operators.Quantity(1m, "day");
																							var gn_ = context.Operators.Add((gl_ as CqlDate), gm_);
																							var gq_ = context.Operators.ListElementAt<CqlDate>(gj_, gk_);
																							var gr_ = context.Operators.Quantity(30m, "days");
																							var gs_ = context.Operators.Add((gq_ as CqlDate), gr_);
																							var gt_ = context.Operators.Interval(gn_, gs_, true, true);
																							var gu_ = context.Operators.ElementInInterval<CqlDate>(X, gt_, null);
																							var gv_ = context.Operators.Not(gu_);

																							return gv_;
																						};
																						var gb_ = context.Operators.WhereOrNull<CqlDate>(fw_, ga_);
																						var gd_ = context.Operators.Add(fx_, (int?)1);
																						var ge_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																						{
																							NextDate = (fy_ as CqlDate),
																							NewList = gb_,
																							IndexofNewDate = gd_,
																						};
																						var gf_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																						{
																							ge_,
																						};
																						Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gg_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SeventhList)
																						{
																							Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gw_()
																							{
																								if ((context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) is null))
																								{
																									return SeventhList;
																								}
																								else
																								{
																									var gx_ = SeventhList?.NewList;
																									var gy_ = SeventhList?.IndexofNewDate;
																									var gz_ = context.Operators.ListElementAt<CqlDate>(gx_, gy_);
																									bool? hb_(CqlDate X)
																									{
																										var hk_ = SeventhList?.NewList;
																										var hl_ = SeventhList?.IndexofNewDate;
																										var hm_ = context.Operators.ListElementAt<CqlDate>(hk_, hl_);
																										var hn_ = context.Operators.Quantity(1m, "day");
																										var ho_ = context.Operators.Add((hm_ as CqlDate), hn_);
																										var hr_ = context.Operators.ListElementAt<CqlDate>(hk_, hl_);
																										var hs_ = context.Operators.Quantity(30m, "days");
																										var ht_ = context.Operators.Add((hr_ as CqlDate), hs_);
																										var hu_ = context.Operators.Interval(ho_, ht_, true, true);
																										var hv_ = context.Operators.ElementInInterval<CqlDate>(X, hu_, null);
																										var hw_ = context.Operators.Not(hv_);

																										return hw_;
																									};
																									var hc_ = context.Operators.WhereOrNull<CqlDate>(gx_, hb_);
																									var he_ = context.Operators.Add(gy_, (int?)1);
																									var hf_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = (gz_ as CqlDate),
																										NewList = hc_,
																										IndexofNewDate = he_,
																									};
																									var hg_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																									{
																										hf_,
																									};
																									Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hh_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EighthList)
																									{
																										Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hx_()
																										{
																											if ((context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) is null))
																											{
																												return EighthList;
																											}
																											else
																											{
																												var hy_ = EighthList?.NewList;
																												var hz_ = EighthList?.IndexofNewDate;
																												var ia_ = context.Operators.ListElementAt<CqlDate>(hy_, hz_);
																												bool? ic_(CqlDate X)
																												{
																													var il_ = EighthList?.NewList;
																													var im_ = EighthList?.IndexofNewDate;
																													var in_ = context.Operators.ListElementAt<CqlDate>(il_, im_);
																													var io_ = context.Operators.Quantity(1m, "day");
																													var ip_ = context.Operators.Add((in_ as CqlDate), io_);
																													var is_ = context.Operators.ListElementAt<CqlDate>(il_, im_);
																													var it_ = context.Operators.Quantity(30m, "days");
																													var iu_ = context.Operators.Add((is_ as CqlDate), it_);
																													var iv_ = context.Operators.Interval(ip_, iu_, true, true);
																													var iw_ = context.Operators.ElementInInterval<CqlDate>(X, iv_, null);
																													var ix_ = context.Operators.Not(iw_);

																													return ix_;
																												};
																												var id_ = context.Operators.WhereOrNull<CqlDate>(hy_, ic_);
																												var if_ = context.Operators.Add(hz_, (int?)1);
																												var ig_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																												{
																													NextDate = (ia_ as CqlDate),
																													NewList = id_,
																													IndexofNewDate = if_,
																												};
																												var ih_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																												{
																													ig_,
																												};
																												Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ii_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT NinethList)
																												{
																													Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT iy_()
																													{
																														if ((context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) is null))
																														{
																															return NinethList;
																														}
																														else
																														{
																															var iz_ = NinethList?.NewList;
																															var ja_ = NinethList?.IndexofNewDate;
																															var jb_ = context.Operators.ListElementAt<CqlDate>(iz_, ja_);
																															bool? jd_(CqlDate X)
																															{
																																var jm_ = NinethList?.NewList;
																																var jn_ = NinethList?.IndexofNewDate;
																																var jo_ = context.Operators.ListElementAt<CqlDate>(jm_, jn_);
																																var jp_ = context.Operators.Quantity(1m, "day");
																																var jq_ = context.Operators.Add((jo_ as CqlDate), jp_);
																																var jt_ = context.Operators.ListElementAt<CqlDate>(jm_, jn_);
																																var ju_ = context.Operators.Quantity(30m, "days");
																																var jv_ = context.Operators.Add((jt_ as CqlDate), ju_);
																																var jw_ = context.Operators.Interval(jq_, jv_, true, true);
																																var jx_ = context.Operators.ElementInInterval<CqlDate>(X, jw_, null);
																																var jy_ = context.Operators.Not(jx_);

																																return jy_;
																															};
																															var je_ = context.Operators.WhereOrNull<CqlDate>(iz_, jd_);
																															var jg_ = context.Operators.Add(ja_, (int?)1);
																															var jh_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																															{
																																NextDate = (jb_ as CqlDate),
																																NewList = je_,
																																IndexofNewDate = jg_,
																															};
																															var ji_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																															{
																																jh_,
																															};
																															Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT jj_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT TenthList)
																															{
																																Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT jz_()
																																{
																																	if ((context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) is null))
																																	{
																																		return TenthList;
																																	}
																																	else
																																	{
																																		var ka_ = TenthList?.NewList;
																																		var kb_ = TenthList?.IndexofNewDate;
																																		var kc_ = context.Operators.ListElementAt<CqlDate>(ka_, kb_);
																																		bool? ke_(CqlDate X)
																																		{
																																			var kn_ = TenthList?.NewList;
																																			var ko_ = TenthList?.IndexofNewDate;
																																			var kp_ = context.Operators.ListElementAt<CqlDate>(kn_, ko_);
																																			var kq_ = context.Operators.Quantity(1m, "day");
																																			var kr_ = context.Operators.Add((kp_ as CqlDate), kq_);
																																			var ku_ = context.Operators.ListElementAt<CqlDate>(kn_, ko_);
																																			var kv_ = context.Operators.Quantity(30m, "days");
																																			var kw_ = context.Operators.Add((ku_ as CqlDate), kv_);
																																			var kx_ = context.Operators.Interval(kr_, kw_, true, true);
																																			var ky_ = context.Operators.ElementInInterval<CqlDate>(X, kx_, null);
																																			var kz_ = context.Operators.Not(ky_);

																																			return kz_;
																																		};
																																		var kf_ = context.Operators.WhereOrNull<CqlDate>(ka_, ke_);
																																		var kh_ = context.Operators.Add(kb_, (int?)1);
																																		var ki_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																		{
																																			NextDate = (kc_ as CqlDate),
																																			NewList = kf_,
																																			IndexofNewDate = kh_,
																																		};
																																		var kj_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																		{
																																			ki_,
																																		};
																																		Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT kk_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EleventhList)
																																		{
																																			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT la_()
																																			{
																																				if ((context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) is null))
																																				{
																																					return EleventhList;
																																				}
																																				else
																																				{
																																					var lb_ = EleventhList?.NewList;
																																					var lc_ = EleventhList?.IndexofNewDate;
																																					var ld_ = context.Operators.ListElementAt<CqlDate>(lb_, lc_);
																																					bool? lf_(CqlDate X)
																																					{
																																						var lk_ = EleventhList?.NewList;
																																						var ll_ = EleventhList?.IndexofNewDate;
																																						var lm_ = context.Operators.ListElementAt<CqlDate>(lk_, ll_);
																																						var ln_ = context.Operators.Quantity(1m, "day");
																																						var lo_ = context.Operators.Add((lm_ as CqlDate), ln_);
																																						var lr_ = context.Operators.ListElementAt<CqlDate>(lk_, ll_);
																																						var ls_ = context.Operators.Quantity(30m, "days");
																																						var lt_ = context.Operators.Add((lr_ as CqlDate), ls_);
																																						var lu_ = context.Operators.Interval(lo_, lt_, true, true);
																																						var lv_ = context.Operators.ElementInInterval<CqlDate>(X, lu_, null);
																																						var lw_ = context.Operators.Not(lv_);

																																						return lw_;
																																					};
																																					var lg_ = context.Operators.WhereOrNull<CqlDate>(lb_, lf_);
																																					var li_ = context.Operators.Add(lc_, (int?)1);
																																					var lj_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																					{
																																						NextDate = (ld_ as CqlDate),
																																						NewList = lg_,
																																						IndexofNewDate = li_,
																																					};

																																					return lj_;
																																				};
																																			};

																																			return la_();
																																		};
																																		var kl_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(kj_, kk_);
																																		var km_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(kl_);

																																		return km_;
																																	};
																																};

																																return jz_();
																															};
																															var jk_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ji_, jj_);
																															var jl_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(jk_);

																															return jl_;
																														};
																													};

																													return iy_();
																												};
																												var ij_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ih_, ii_);
																												var ik_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ij_);

																												return ik_;
																											};
																										};

																										return hx_();
																									};
																									var hi_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hg_, hh_);
																									var hj_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hi_);

																									return hj_;
																								};
																							};

																							return gw_();
																						};
																						var gh_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gf_, gg_);
																						var gi_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gh_);

																						return gi_;
																					};
																				};

																				return fv_();
																			};
																			var fg_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fe_, ff_);
																			var fh_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fg_);

																			return fh_;
																		};
																	};

																	return eu_();
																};
																var ef_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ed_, ee_);
																var eg_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ef_);

																return eg_;
															};
														};

														return dt_();
													};
													var de_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(dc_, dd_);
													var df_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(de_);

													return df_;
												};
											};

											return cs_();
										};
										var cd_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cb_, cc_);
										var ce_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cd_);

										return ce_;
									};
								};

								return br_();
							};
							var bc_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ba_, bb_);
							var bd_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(bc_);

							return bd_;
						};
					};

					return aq_();
				};
				var ab_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(z_, aa_);
				var ac_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ab_);

				return ac_;
			};
			var p_ = context.Operators.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(n_, o_);
			var q_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(p_);

			return q_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(g_, h_);
		var j_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(i_);

		return j_;
	}

}