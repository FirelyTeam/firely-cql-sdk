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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
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
				var b_ = context.Operators;
				var c_ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));
				var e_ = b_.Interval(c_, c_, true, true);

				return e_;
			}
			else if (onset is Period)
			{
				var f_ = context.Operators;
				var i_ = f_.LateBoundProperty<FhirDateTime>(onset, "start");
				var j_ = i_?.Value;
				var k_ = f_.ConvertStringToDateTime(j_);
				var n_ = f_.LateBoundProperty<FhirDateTime>(onset, "end");
				var o_ = n_?.Value;
				var p_ = f_.ConvertStringToDateTime(o_);
				var q_ = f_.Interval(k_, p_, true, true);

				return q_;
			}
			else if (onset is FhirString)
			{
				var r_ = context.Operators;
				CqlInterval<CqlDateTime> s_ = null;
				var t_ = r_.Message<CqlInterval<CqlDateTime>>((s_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return t_;
			}
			else
			{
				var u_ = context.Operators;
				CqlInterval<CqlDate> w_()
				{
					if (onset is Age)
					{
						var ai_ = context.Operators;
						var ak_ = this.Patient();
						var al_ = ak_?.BirthDateElement;
						var am_ = FHIRHelpers_4_0_001.ToDate(al_);
						var an_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var ao_ = ai_.Add(am_, an_);
						var as_ = ak_?.BirthDateElement;
						var at_ = FHIRHelpers_4_0_001.ToDate(as_);
						var av_ = ai_.Add(at_, an_);
						var ax_ = ai_.Quantity(1m, "year");
						var ay_ = ai_.Add(av_, ax_);
						var az_ = ai_.Interval(ao_, ay_, true, false);

						return az_;
					}
					else if (onset is Range)
					{
						var ba_ = context.Operators;
						var bc_ = this.Patient();
						var bd_ = bc_?.BirthDateElement;
						var be_ = FHIRHelpers_4_0_001.ToDate(bd_);
						var bf_ = (onset as Range)?.Low;
						var bg_ = FHIRHelpers_4_0_001.ToQuantity(bf_);
						var bh_ = ba_.Add(be_, bg_);
						var bl_ = bc_?.BirthDateElement;
						var bm_ = FHIRHelpers_4_0_001.ToDate(bl_);
						var bn_ = (onset as Range)?.High;
						var bo_ = FHIRHelpers_4_0_001.ToQuantity(bn_);
						var bp_ = ba_.Add(bm_, bo_);
						var br_ = ba_.Quantity(1m, "year");
						var bs_ = ba_.Add(bp_, br_);
						var bt_ = ba_.Interval(bh_, bs_, true, false);

						return bt_;
					}
					else
					{
						CqlInterval<CqlDate> bu_ = null;

						return (bu_ as CqlInterval<CqlDate>);
					};
				};
				var x_ = w_()?.low;
				var y_ = u_.ConvertDateToDateTime(x_);
				CqlInterval<CqlDate> aa_()
				{
					if (onset is Age)
					{
						var bv_ = context.Operators;
						var bx_ = this.Patient();
						var by_ = bx_?.BirthDateElement;
						var bz_ = FHIRHelpers_4_0_001.ToDate(by_);
						var ca_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var cb_ = bv_.Add(bz_, ca_);
						var cf_ = bx_?.BirthDateElement;
						var cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
						var ci_ = bv_.Add(cg_, ca_);
						var ck_ = bv_.Quantity(1m, "year");
						var cl_ = bv_.Add(ci_, ck_);
						var cm_ = bv_.Interval(cb_, cl_, true, false);

						return cm_;
					}
					else if (onset is Range)
					{
						var cn_ = context.Operators;
						var cp_ = this.Patient();
						var cq_ = cp_?.BirthDateElement;
						var cr_ = FHIRHelpers_4_0_001.ToDate(cq_);
						var cs_ = (onset as Range)?.Low;
						var ct_ = FHIRHelpers_4_0_001.ToQuantity(cs_);
						var cu_ = cn_.Add(cr_, ct_);
						var cy_ = cp_?.BirthDateElement;
						var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
						var da_ = (onset as Range)?.High;
						var db_ = FHIRHelpers_4_0_001.ToQuantity(da_);
						var dc_ = cn_.Add(cz_, db_);
						var de_ = cn_.Quantity(1m, "year");
						var df_ = cn_.Add(dc_, de_);
						var dg_ = cn_.Interval(cu_, df_, true, false);

						return dg_;
					}
					else
					{
						CqlInterval<CqlDate> dh_ = null;

						return (dh_ as CqlInterval<CqlDate>);
					};
				};
				var ab_ = aa_()?.high;
				var ac_ = u_.ConvertDateToDateTime(ab_);
				CqlInterval<CqlDate> ad_()
				{
					if (onset is Age)
					{
						var di_ = context.Operators;
						var dk_ = this.Patient();
						var dl_ = dk_?.BirthDateElement;
						var dm_ = FHIRHelpers_4_0_001.ToDate(dl_);
						var dn_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var do_ = di_.Add(dm_, dn_);
						var ds_ = dk_?.BirthDateElement;
						var dt_ = FHIRHelpers_4_0_001.ToDate(ds_);
						var dv_ = di_.Add(dt_, dn_);
						var dx_ = di_.Quantity(1m, "year");
						var dy_ = di_.Add(dv_, dx_);
						var dz_ = di_.Interval(do_, dy_, true, false);

						return dz_;
					}
					else if (onset is Range)
					{
						var ea_ = context.Operators;
						var ec_ = this.Patient();
						var ed_ = ec_?.BirthDateElement;
						var ee_ = FHIRHelpers_4_0_001.ToDate(ed_);
						var ef_ = (onset as Range)?.Low;
						var eg_ = FHIRHelpers_4_0_001.ToQuantity(ef_);
						var eh_ = ea_.Add(ee_, eg_);
						var el_ = ec_?.BirthDateElement;
						var em_ = FHIRHelpers_4_0_001.ToDate(el_);
						var en_ = (onset as Range)?.High;
						var eo_ = FHIRHelpers_4_0_001.ToQuantity(en_);
						var ep_ = ea_.Add(em_, eo_);
						var er_ = ea_.Quantity(1m, "year");
						var es_ = ea_.Add(ep_, er_);
						var et_ = ea_.Interval(eh_, es_, true, false);

						return et_;
					}
					else
					{
						CqlInterval<CqlDate> eu_ = null;

						return (eu_ as CqlInterval<CqlDate>);
					};
				};
				var ae_ = ad_()?.lowClosed;
				CqlInterval<CqlDate> af_()
				{
					if (onset is Age)
					{
						var ev_ = context.Operators;
						var ex_ = this.Patient();
						var ey_ = ex_?.BirthDateElement;
						var ez_ = FHIRHelpers_4_0_001.ToDate(ey_);
						var fa_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age));
						var fb_ = ev_.Add(ez_, fa_);
						var ff_ = ex_?.BirthDateElement;
						var fg_ = FHIRHelpers_4_0_001.ToDate(ff_);
						var fi_ = ev_.Add(fg_, fa_);
						var fk_ = ev_.Quantity(1m, "year");
						var fl_ = ev_.Add(fi_, fk_);
						var fm_ = ev_.Interval(fb_, fl_, true, false);

						return fm_;
					}
					else if (onset is Range)
					{
						var fn_ = context.Operators;
						var fp_ = this.Patient();
						var fq_ = fp_?.BirthDateElement;
						var fr_ = FHIRHelpers_4_0_001.ToDate(fq_);
						var fs_ = (onset as Range)?.Low;
						var ft_ = FHIRHelpers_4_0_001.ToQuantity(fs_);
						var fu_ = fn_.Add(fr_, ft_);
						var fy_ = fp_?.BirthDateElement;
						var fz_ = FHIRHelpers_4_0_001.ToDate(fy_);
						var ga_ = (onset as Range)?.High;
						var gb_ = FHIRHelpers_4_0_001.ToQuantity(ga_);
						var gc_ = fn_.Add(fz_, gb_);
						var ge_ = fn_.Quantity(1m, "year");
						var gf_ = fn_.Add(gc_, ge_);
						var gg_ = fn_.Interval(fu_, gf_, true, false);

						return gg_;
					}
					else
					{
						CqlInterval<CqlDate> gh_ = null;

						return (gh_ as CqlInterval<CqlDate>);
					};
				};
				var ag_ = af_()?.highClosed;
				var ah_ = u_.Interval(y_, ac_, ae_, ag_);

				return ah_;
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
				var b_ = context.Operators;
				var c_ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));
				var e_ = b_.Interval(c_, c_, true, true);

				return e_;
			}
			else if (abatement is Period)
			{
				var f_ = context.Operators;
				var i_ = f_.LateBoundProperty<FhirDateTime>(abatement, "start");
				var j_ = i_?.Value;
				var k_ = f_.ConvertStringToDateTime(j_);
				var n_ = f_.LateBoundProperty<FhirDateTime>(abatement, "end");
				var o_ = n_?.Value;
				var p_ = f_.ConvertStringToDateTime(o_);
				var q_ = f_.Interval(k_, p_, true, true);

				return q_;
			}
			else if (abatement is FhirString)
			{
				var r_ = context.Operators;
				CqlInterval<CqlDateTime> s_ = null;
				var t_ = r_.Message<CqlInterval<CqlDateTime>>((s_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return t_;
			}
			else
			{
				var u_ = context.Operators;
				CqlInterval<CqlDate> w_()
				{
					if (abatement is Age)
					{
						var ai_ = context.Operators;
						var ak_ = this.Patient();
						var al_ = ak_?.BirthDateElement;
						var am_ = FHIRHelpers_4_0_001.ToDate(al_);
						var an_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var ao_ = ai_.Add(am_, an_);
						var as_ = ak_?.BirthDateElement;
						var at_ = FHIRHelpers_4_0_001.ToDate(as_);
						var av_ = ai_.Add(at_, an_);
						var ax_ = ai_.Quantity(1m, "year");
						var ay_ = ai_.Add(av_, ax_);
						var az_ = ai_.Interval(ao_, ay_, true, false);

						return az_;
					}
					else if (abatement is Range)
					{
						var ba_ = context.Operators;
						var bc_ = this.Patient();
						var bd_ = bc_?.BirthDateElement;
						var be_ = FHIRHelpers_4_0_001.ToDate(bd_);
						var bf_ = (abatement as Range)?.Low;
						var bg_ = FHIRHelpers_4_0_001.ToQuantity(bf_);
						var bh_ = ba_.Add(be_, bg_);
						var bl_ = bc_?.BirthDateElement;
						var bm_ = FHIRHelpers_4_0_001.ToDate(bl_);
						var bn_ = (abatement as Range)?.High;
						var bo_ = FHIRHelpers_4_0_001.ToQuantity(bn_);
						var bp_ = ba_.Add(bm_, bo_);
						var br_ = ba_.Quantity(1m, "year");
						var bs_ = ba_.Add(bp_, br_);
						var bt_ = ba_.Interval(bh_, bs_, true, false);

						return bt_;
					}
					else
					{
						CqlInterval<CqlDate> bu_ = null;

						return (bu_ as CqlInterval<CqlDate>);
					};
				};
				var x_ = w_()?.low;
				var y_ = u_.ConvertDateToDateTime(x_);
				CqlInterval<CqlDate> aa_()
				{
					if (abatement is Age)
					{
						var bv_ = context.Operators;
						var bx_ = this.Patient();
						var by_ = bx_?.BirthDateElement;
						var bz_ = FHIRHelpers_4_0_001.ToDate(by_);
						var ca_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var cb_ = bv_.Add(bz_, ca_);
						var cf_ = bx_?.BirthDateElement;
						var cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
						var ci_ = bv_.Add(cg_, ca_);
						var ck_ = bv_.Quantity(1m, "year");
						var cl_ = bv_.Add(ci_, ck_);
						var cm_ = bv_.Interval(cb_, cl_, true, false);

						return cm_;
					}
					else if (abatement is Range)
					{
						var cn_ = context.Operators;
						var cp_ = this.Patient();
						var cq_ = cp_?.BirthDateElement;
						var cr_ = FHIRHelpers_4_0_001.ToDate(cq_);
						var cs_ = (abatement as Range)?.Low;
						var ct_ = FHIRHelpers_4_0_001.ToQuantity(cs_);
						var cu_ = cn_.Add(cr_, ct_);
						var cy_ = cp_?.BirthDateElement;
						var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
						var da_ = (abatement as Range)?.High;
						var db_ = FHIRHelpers_4_0_001.ToQuantity(da_);
						var dc_ = cn_.Add(cz_, db_);
						var de_ = cn_.Quantity(1m, "year");
						var df_ = cn_.Add(dc_, de_);
						var dg_ = cn_.Interval(cu_, df_, true, false);

						return dg_;
					}
					else
					{
						CqlInterval<CqlDate> dh_ = null;

						return (dh_ as CqlInterval<CqlDate>);
					};
				};
				var ab_ = aa_()?.high;
				var ac_ = u_.ConvertDateToDateTime(ab_);
				CqlInterval<CqlDate> ad_()
				{
					if (abatement is Age)
					{
						var di_ = context.Operators;
						var dk_ = this.Patient();
						var dl_ = dk_?.BirthDateElement;
						var dm_ = FHIRHelpers_4_0_001.ToDate(dl_);
						var dn_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var do_ = di_.Add(dm_, dn_);
						var ds_ = dk_?.BirthDateElement;
						var dt_ = FHIRHelpers_4_0_001.ToDate(ds_);
						var dv_ = di_.Add(dt_, dn_);
						var dx_ = di_.Quantity(1m, "year");
						var dy_ = di_.Add(dv_, dx_);
						var dz_ = di_.Interval(do_, dy_, true, false);

						return dz_;
					}
					else if (abatement is Range)
					{
						var ea_ = context.Operators;
						var ec_ = this.Patient();
						var ed_ = ec_?.BirthDateElement;
						var ee_ = FHIRHelpers_4_0_001.ToDate(ed_);
						var ef_ = (abatement as Range)?.Low;
						var eg_ = FHIRHelpers_4_0_001.ToQuantity(ef_);
						var eh_ = ea_.Add(ee_, eg_);
						var el_ = ec_?.BirthDateElement;
						var em_ = FHIRHelpers_4_0_001.ToDate(el_);
						var en_ = (abatement as Range)?.High;
						var eo_ = FHIRHelpers_4_0_001.ToQuantity(en_);
						var ep_ = ea_.Add(em_, eo_);
						var er_ = ea_.Quantity(1m, "year");
						var es_ = ea_.Add(ep_, er_);
						var et_ = ea_.Interval(eh_, es_, true, false);

						return et_;
					}
					else
					{
						CqlInterval<CqlDate> eu_ = null;

						return (eu_ as CqlInterval<CqlDate>);
					};
				};
				var ae_ = ad_()?.lowClosed;
				CqlInterval<CqlDate> af_()
				{
					if (abatement is Age)
					{
						var ev_ = context.Operators;
						var ex_ = this.Patient();
						var ey_ = ex_?.BirthDateElement;
						var ez_ = FHIRHelpers_4_0_001.ToDate(ey_);
						var fa_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age));
						var fb_ = ev_.Add(ez_, fa_);
						var ff_ = ex_?.BirthDateElement;
						var fg_ = FHIRHelpers_4_0_001.ToDate(ff_);
						var fi_ = ev_.Add(fg_, fa_);
						var fk_ = ev_.Quantity(1m, "year");
						var fl_ = ev_.Add(fi_, fk_);
						var fm_ = ev_.Interval(fb_, fl_, true, false);

						return fm_;
					}
					else if (abatement is Range)
					{
						var fn_ = context.Operators;
						var fp_ = this.Patient();
						var fq_ = fp_?.BirthDateElement;
						var fr_ = FHIRHelpers_4_0_001.ToDate(fq_);
						var fs_ = (abatement as Range)?.Low;
						var ft_ = FHIRHelpers_4_0_001.ToQuantity(fs_);
						var fu_ = fn_.Add(fr_, ft_);
						var fy_ = fp_?.BirthDateElement;
						var fz_ = FHIRHelpers_4_0_001.ToDate(fy_);
						var ga_ = (abatement as Range)?.High;
						var gb_ = FHIRHelpers_4_0_001.ToQuantity(ga_);
						var gc_ = fn_.Add(fz_, gb_);
						var ge_ = fn_.Quantity(1m, "year");
						var gf_ = fn_.Add(gc_, ge_);
						var gg_ = fn_.Interval(fu_, gf_, true, false);

						return gg_;
					}
					else
					{
						CqlInterval<CqlDate> gh_ = null;

						return (gh_ as CqlInterval<CqlDate>);
					};
				};
				var ag_ = af_()?.highClosed;
				var ah_ = u_.Interval(y_, ac_, ae_, ag_);

				return ah_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		var a_ = context.Operators;
		var c_ = condition?.Onset;
		var d_ = this.Normalize_Onset(c_);
		var e_ = a_.Start(d_);
		var g_ = condition?.Abatement;
		var h_ = this.Normalize_Abatement(g_);
		var i_ = a_.End(h_);
		var j_ = a_.Interval(e_, i_, true, true);

		return j_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				var b_ = context.Operators;
				var c_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				var e_ = b_.Interval(c_, c_, true, true);

				return e_;
			}
			else if (choice is Date)
			{
				var f_ = context.Operators;
				var h_ = FHIRHelpers_4_0_001.ToDate((choice as Date));
				var i_ = f_.ConvertDateToDateTime(h_);
				var l_ = f_.ConvertDateToDateTime(h_);
				var m_ = f_.Interval(i_, l_, true, true);

				return m_;
			}
			else if (choice is Period)
			{
				var n_ = context.Operators;
				var q_ = n_.LateBoundProperty<FhirDateTime>(choice, "start");
				var r_ = q_?.Value;
				var s_ = n_.ConvertStringToDateTime(r_);
				var v_ = n_.LateBoundProperty<FhirDateTime>(choice, "end");
				var w_ = v_?.Value;
				var x_ = n_.ConvertStringToDateTime(w_);
				var y_ = n_.Interval(s_, x_, true, true);

				return y_;
			}
			else if (choice is Instant)
			{
				var z_ = context.Operators;
				var aa_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				var ac_ = z_.Interval(aa_, aa_, true, true);

				return ac_;
			}
			else if (choice is Age)
			{
				var ad_ = context.Operators;
				var ah_ = this.Patient();
				var ai_ = ah_?.BirthDateElement;
				var aj_ = FHIRHelpers_4_0_001.ToDate(ai_);
				var ak_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var al_ = ad_.Add(aj_, ak_);
				var ap_ = ah_?.BirthDateElement;
				var aq_ = FHIRHelpers_4_0_001.ToDate(ap_);
				var as_ = ad_.Add(aq_, ak_);
				var au_ = ad_.Quantity(1m, "year");
				var av_ = ad_.Add(as_, au_);
				var aw_ = ad_.Interval(al_, av_, true, false);
				var ax_ = aw_?.low;
				var ay_ = ad_.ConvertDateToDateTime(ax_);
				var bd_ = ah_?.BirthDateElement;
				var be_ = FHIRHelpers_4_0_001.ToDate(bd_);
				var bg_ = ad_.Add(be_, ak_);
				var bk_ = ah_?.BirthDateElement;
				var bl_ = FHIRHelpers_4_0_001.ToDate(bk_);
				var bn_ = ad_.Add(bl_, ak_);
				var bp_ = ad_.Quantity(1m, "year");
				var bq_ = ad_.Add(bn_, bp_);
				var br_ = ad_.Interval(bg_, bq_, true, false);
				var bs_ = br_?.high;
				var bt_ = ad_.ConvertDateToDateTime(bs_);
				var bx_ = ah_?.BirthDateElement;
				var by_ = FHIRHelpers_4_0_001.ToDate(bx_);
				var ca_ = ad_.Add(by_, ak_);
				var ce_ = ah_?.BirthDateElement;
				var cf_ = FHIRHelpers_4_0_001.ToDate(ce_);
				var ch_ = ad_.Add(cf_, ak_);
				var cj_ = ad_.Quantity(1m, "year");
				var ck_ = ad_.Add(ch_, cj_);
				var cl_ = ad_.Interval(ca_, ck_, true, false);
				var cm_ = cl_?.lowClosed;
				var cq_ = ah_?.BirthDateElement;
				var cr_ = FHIRHelpers_4_0_001.ToDate(cq_);
				var ct_ = ad_.Add(cr_, ak_);
				var cx_ = ah_?.BirthDateElement;
				var cy_ = FHIRHelpers_4_0_001.ToDate(cx_);
				var da_ = ad_.Add(cy_, ak_);
				var dc_ = ad_.Quantity(1m, "year");
				var dd_ = ad_.Add(da_, dc_);
				var de_ = ad_.Interval(ct_, dd_, true, false);
				var df_ = de_?.highClosed;
				var dg_ = ad_.Interval(ay_, bt_, cm_, df_);

				return dg_;
			}
			else if (choice is Range)
			{
				var dh_ = context.Operators;
				var dl_ = this.Patient();
				var dm_ = dl_?.BirthDateElement;
				var dn_ = FHIRHelpers_4_0_001.ToDate(dm_);
				var do_ = (choice as Range)?.Low;
				var dp_ = FHIRHelpers_4_0_001.ToQuantity(do_);
				var dq_ = dh_.Add(dn_, dp_);
				var du_ = dl_?.BirthDateElement;
				var dv_ = FHIRHelpers_4_0_001.ToDate(du_);
				var dw_ = (choice as Range)?.High;
				var dx_ = FHIRHelpers_4_0_001.ToQuantity(dw_);
				var dy_ = dh_.Add(dv_, dx_);
				var ea_ = dh_.Quantity(1m, "year");
				var eb_ = dh_.Add(dy_, ea_);
				var ec_ = dh_.Interval(dq_, eb_, true, false);
				var ed_ = ec_?.low;
				var ee_ = dh_.ConvertDateToDateTime(ed_);
				var ej_ = dl_?.BirthDateElement;
				var ek_ = FHIRHelpers_4_0_001.ToDate(ej_);
				var em_ = FHIRHelpers_4_0_001.ToQuantity(do_);
				var en_ = dh_.Add(ek_, em_);
				var er_ = dl_?.BirthDateElement;
				var es_ = FHIRHelpers_4_0_001.ToDate(er_);
				var eu_ = FHIRHelpers_4_0_001.ToQuantity(dw_);
				var ev_ = dh_.Add(es_, eu_);
				var ex_ = dh_.Quantity(1m, "year");
				var ey_ = dh_.Add(ev_, ex_);
				var ez_ = dh_.Interval(en_, ey_, true, false);
				var fa_ = ez_?.high;
				var fb_ = dh_.ConvertDateToDateTime(fa_);
				var ff_ = dl_?.BirthDateElement;
				var fg_ = FHIRHelpers_4_0_001.ToDate(ff_);
				var fi_ = FHIRHelpers_4_0_001.ToQuantity(do_);
				var fj_ = dh_.Add(fg_, fi_);
				var fn_ = dl_?.BirthDateElement;
				var fo_ = FHIRHelpers_4_0_001.ToDate(fn_);
				var fq_ = FHIRHelpers_4_0_001.ToQuantity(dw_);
				var fr_ = dh_.Add(fo_, fq_);
				var ft_ = dh_.Quantity(1m, "year");
				var fu_ = dh_.Add(fr_, ft_);
				var fv_ = dh_.Interval(fj_, fu_, true, false);
				var fw_ = fv_?.lowClosed;
				var ga_ = dl_?.BirthDateElement;
				var gb_ = FHIRHelpers_4_0_001.ToDate(ga_);
				var gd_ = FHIRHelpers_4_0_001.ToQuantity(do_);
				var ge_ = dh_.Add(gb_, gd_);
				var gi_ = dl_?.BirthDateElement;
				var gj_ = FHIRHelpers_4_0_001.ToDate(gi_);
				var gl_ = FHIRHelpers_4_0_001.ToQuantity(dw_);
				var gm_ = dh_.Add(gj_, gl_);
				var go_ = dh_.Quantity(1m, "year");
				var gp_ = dh_.Add(gm_, go_);
				var gq_ = dh_.Interval(ge_, gp_, true, false);
				var gr_ = gq_?.highClosed;
				var gs_ = dh_.Interval(ee_, fb_, fw_, gr_);

				return gs_;
			}
			else if (choice is Timing)
			{
				var gt_ = context.Operators;
				CqlInterval<CqlDateTime> gu_ = null;
				var gv_ = gt_.Message<CqlInterval<CqlDateTime>>((gu_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return gv_;
			}
			else if (choice is FhirString)
			{
				var gw_ = context.Operators;
				CqlInterval<CqlDateTime> gx_ = null;
				var gy_ = gw_.Message<CqlInterval<CqlDateTime>>((gx_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return gy_;
			}
			else
			{
				CqlInterval<CqlDateTime> gz_ = null;

				return (gz_ as CqlInterval<CqlDateTime>);
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
				var b_ = context.Operators;
				var d_ = b_.Split(uri, "/");
				var e_ = b_.LastOfList<string>(d_);

				return e_;
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
		var a_ = context.Operators;
		CqlDate f_(CqlDate d) => 
			d;
		var g_ = a_.SelectOrNull<CqlDate, CqlDate>(DateList, f_);
		var h_ = a_.ListSort<CqlDate>(g_, System.ComponentModel.ListSortDirection.Ascending);
		bool? i_(CqlDate X)
		{
			var p_ = context.Operators;
			var q_ = p_.Not((bool?)(X is null));

			return q_;
		};
		var j_ = a_.WhereOrNull<CqlDate>(h_, i_);
		var k_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = j_,
		};
		var l_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			k_,
		};
		Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT m_(Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates)
		{
			var r_ = context.Operators;
			var t_ = SortedDates?.SortedDates;
			var u_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = t_,
				AnchorIndex = (int?)0,
			};
			var v_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				u_,
			};
			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT w_(Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList)
			{
				var z_ = context.Operators;
				var ac_ = AnchorList?.SortedList;
				var ad_ = AnchorList?.AnchorIndex;
				var ae_ = z_.ListElementAt<CqlDate>(ac_, ad_);
				bool? ag_(CqlDate X)
				{
					var aq_ = context.Operators;
					var av_ = AnchorList?.SortedList;
					var aw_ = AnchorList?.AnchorIndex;
					var ax_ = aq_.ListElementAt<CqlDate>(av_, aw_);
					var az_ = aq_.Quantity(1m, "day");
					var ba_ = aq_.Add((ax_ as CqlDate), az_);
					var bf_ = aq_.ListElementAt<CqlDate>(av_, aw_);
					var bh_ = aq_.Quantity(30m, "days");
					var bi_ = aq_.Add((bf_ as CqlDate), bh_);
					var bj_ = aq_.Interval(ba_, bi_, true, true);
					var bk_ = aq_.ElementInInterval<CqlDate>(X, bj_, null);
					var bl_ = aq_.Not(bk_);

					return bl_;
				};
				var ah_ = z_.WhereOrNull<CqlDate>(DateList, ag_);
				var ak_ = z_.Add(ad_, (int?)1);
				var al_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = (ae_ as CqlDate),
					NewList = ah_,
					IndexofNewDate = ak_,
				};
				var am_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					al_,
				};
				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT an_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList)
				{
					Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bm_()
					{
						if ((context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) is null))
						{
							return FirstList;
						}
						else
						{
							var bn_ = context.Operators;
							var bq_ = FirstList?.NewList;
							var br_ = FirstList?.IndexofNewDate;
							var bs_ = bn_.ListElementAt<CqlDate>(bq_, br_);
							bool? bv_(CqlDate X)
							{
								var cf_ = context.Operators;
								var ck_ = FirstList?.NewList;
								var cl_ = FirstList?.IndexofNewDate;
								var cm_ = cf_.ListElementAt<CqlDate>(ck_, cl_);
								var co_ = cf_.Quantity(1m, "day");
								var cp_ = cf_.Add((cm_ as CqlDate), co_);
								var cu_ = cf_.ListElementAt<CqlDate>(ck_, cl_);
								var cw_ = cf_.Quantity(30m, "days");
								var cx_ = cf_.Add((cu_ as CqlDate), cw_);
								var cy_ = cf_.Interval(cp_, cx_, true, true);
								var cz_ = cf_.ElementInInterval<CqlDate>(X, cy_, null);
								var da_ = cf_.Not(cz_);

								return da_;
							};
							var bw_ = bn_.WhereOrNull<CqlDate>(bq_, bv_);
							var bz_ = bn_.Add(br_, (int?)1);
							var ca_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
							{
								NextDate = (bs_ as CqlDate),
								NewList = bw_,
								IndexofNewDate = bz_,
							};
							var cb_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
							{
								ca_,
							};
							Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cc_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SecondList)
							{
								Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT db_()
								{
									if ((context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) is null))
									{
										return SecondList;
									}
									else
									{
										var dc_ = context.Operators;
										var df_ = SecondList?.NewList;
										var dg_ = SecondList?.IndexofNewDate;
										var dh_ = dc_.ListElementAt<CqlDate>(df_, dg_);
										bool? dk_(CqlDate X)
										{
											var du_ = context.Operators;
											var dz_ = SecondList?.NewList;
											var ea_ = SecondList?.IndexofNewDate;
											var eb_ = du_.ListElementAt<CqlDate>(dz_, ea_);
											var ed_ = du_.Quantity(1m, "day");
											var ee_ = du_.Add((eb_ as CqlDate), ed_);
											var ej_ = du_.ListElementAt<CqlDate>(dz_, ea_);
											var el_ = du_.Quantity(30m, "days");
											var em_ = du_.Add((ej_ as CqlDate), el_);
											var en_ = du_.Interval(ee_, em_, true, true);
											var eo_ = du_.ElementInInterval<CqlDate>(X, en_, null);
											var ep_ = du_.Not(eo_);

											return ep_;
										};
										var dl_ = dc_.WhereOrNull<CqlDate>(df_, dk_);
										var do_ = dc_.Add(dg_, (int?)1);
										var dp_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
										{
											NextDate = (dh_ as CqlDate),
											NewList = dl_,
											IndexofNewDate = do_,
										};
										var dq_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
										{
											dp_,
										};
										Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dr_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ThirdList)
										{
											Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT eq_()
											{
												if ((context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) is null))
												{
													return ThirdList;
												}
												else
												{
													var er_ = context.Operators;
													var eu_ = ThirdList?.NewList;
													var ev_ = ThirdList?.IndexofNewDate;
													var ew_ = er_.ListElementAt<CqlDate>(eu_, ev_);
													bool? ez_(CqlDate X)
													{
														var fj_ = context.Operators;
														var fo_ = ThirdList?.NewList;
														var fp_ = ThirdList?.IndexofNewDate;
														var fq_ = fj_.ListElementAt<CqlDate>(fo_, fp_);
														var fs_ = fj_.Quantity(1m, "day");
														var ft_ = fj_.Add((fq_ as CqlDate), fs_);
														var fy_ = fj_.ListElementAt<CqlDate>(fo_, fp_);
														var ga_ = fj_.Quantity(30m, "days");
														var gb_ = fj_.Add((fy_ as CqlDate), ga_);
														var gc_ = fj_.Interval(ft_, gb_, true, true);
														var gd_ = fj_.ElementInInterval<CqlDate>(X, gc_, null);
														var ge_ = fj_.Not(gd_);

														return ge_;
													};
													var fa_ = er_.WhereOrNull<CqlDate>(eu_, ez_);
													var fd_ = er_.Add(ev_, (int?)1);
													var fe_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = (ew_ as CqlDate),
														NewList = fa_,
														IndexofNewDate = fd_,
													};
													var ff_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
													{
														fe_,
													};
													Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fg_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FourthList)
													{
														Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gf_()
														{
															if ((context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) is null))
															{
																return FourthList;
															}
															else
															{
																var gg_ = context.Operators;
																var gj_ = FourthList?.NewList;
																var gk_ = FourthList?.IndexofNewDate;
																var gl_ = gg_.ListElementAt<CqlDate>(gj_, gk_);
																bool? go_(CqlDate X)
																{
																	var gy_ = context.Operators;
																	var hd_ = FourthList?.NewList;
																	var he_ = FourthList?.IndexofNewDate;
																	var hf_ = gy_.ListElementAt<CqlDate>(hd_, he_);
																	var hh_ = gy_.Quantity(1m, "day");
																	var hi_ = gy_.Add((hf_ as CqlDate), hh_);
																	var hn_ = gy_.ListElementAt<CqlDate>(hd_, he_);
																	var hp_ = gy_.Quantity(30m, "days");
																	var hq_ = gy_.Add((hn_ as CqlDate), hp_);
																	var hr_ = gy_.Interval(hi_, hq_, true, true);
																	var hs_ = gy_.ElementInInterval<CqlDate>(X, hr_, null);
																	var ht_ = gy_.Not(hs_);

																	return ht_;
																};
																var gp_ = gg_.WhereOrNull<CqlDate>(gj_, go_);
																var gs_ = gg_.Add(gk_, (int?)1);
																var gt_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																{
																	NextDate = (gl_ as CqlDate),
																	NewList = gp_,
																	IndexofNewDate = gs_,
																};
																var gu_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																{
																	gt_,
																};
																Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gv_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FifthList)
																{
																	Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hu_()
																	{
																		if ((context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) is null))
																		{
																			return FifthList;
																		}
																		else
																		{
																			var hv_ = context.Operators;
																			var hy_ = FifthList?.NewList;
																			var hz_ = FifthList?.IndexofNewDate;
																			var ia_ = hv_.ListElementAt<CqlDate>(hy_, hz_);
																			bool? id_(CqlDate X)
																			{
																				var in_ = context.Operators;
																				var is_ = FifthList?.NewList;
																				var it_ = FifthList?.IndexofNewDate;
																				var iu_ = in_.ListElementAt<CqlDate>(is_, it_);
																				var iw_ = in_.Quantity(1m, "day");
																				var ix_ = in_.Add((iu_ as CqlDate), iw_);
																				var jc_ = in_.ListElementAt<CqlDate>(is_, it_);
																				var je_ = in_.Quantity(30m, "days");
																				var jf_ = in_.Add((jc_ as CqlDate), je_);
																				var jg_ = in_.Interval(ix_, jf_, true, true);
																				var jh_ = in_.ElementInInterval<CqlDate>(X, jg_, null);
																				var ji_ = in_.Not(jh_);

																				return ji_;
																			};
																			var ie_ = hv_.WhereOrNull<CqlDate>(hy_, id_);
																			var ih_ = hv_.Add(hz_, (int?)1);
																			var ii_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																			{
																				NextDate = (ia_ as CqlDate),
																				NewList = ie_,
																				IndexofNewDate = ih_,
																			};
																			var ij_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																			{
																				ii_,
																			};
																			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ik_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SixthList)
																			{
																				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT jj_()
																				{
																					if ((context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) is null))
																					{
																						return SixthList;
																					}
																					else
																					{
																						var jk_ = context.Operators;
																						var jn_ = SixthList?.NewList;
																						var jo_ = SixthList?.IndexofNewDate;
																						var jp_ = jk_.ListElementAt<CqlDate>(jn_, jo_);
																						bool? js_(CqlDate X)
																						{
																							var kc_ = context.Operators;
																							var kh_ = SixthList?.NewList;
																							var ki_ = SixthList?.IndexofNewDate;
																							var kj_ = kc_.ListElementAt<CqlDate>(kh_, ki_);
																							var kl_ = kc_.Quantity(1m, "day");
																							var km_ = kc_.Add((kj_ as CqlDate), kl_);
																							var kr_ = kc_.ListElementAt<CqlDate>(kh_, ki_);
																							var kt_ = kc_.Quantity(30m, "days");
																							var ku_ = kc_.Add((kr_ as CqlDate), kt_);
																							var kv_ = kc_.Interval(km_, ku_, true, true);
																							var kw_ = kc_.ElementInInterval<CqlDate>(X, kv_, null);
																							var kx_ = kc_.Not(kw_);

																							return kx_;
																						};
																						var jt_ = jk_.WhereOrNull<CqlDate>(jn_, js_);
																						var jw_ = jk_.Add(jo_, (int?)1);
																						var jx_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																						{
																							NextDate = (jp_ as CqlDate),
																							NewList = jt_,
																							IndexofNewDate = jw_,
																						};
																						var jy_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																						{
																							jx_,
																						};
																						Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT jz_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SeventhList)
																						{
																							Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ky_()
																							{
																								if ((context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) is null))
																								{
																									return SeventhList;
																								}
																								else
																								{
																									var kz_ = context.Operators;
																									var lc_ = SeventhList?.NewList;
																									var ld_ = SeventhList?.IndexofNewDate;
																									var le_ = kz_.ListElementAt<CqlDate>(lc_, ld_);
																									bool? lh_(CqlDate X)
																									{
																										var lr_ = context.Operators;
																										var lw_ = SeventhList?.NewList;
																										var lx_ = SeventhList?.IndexofNewDate;
																										var ly_ = lr_.ListElementAt<CqlDate>(lw_, lx_);
																										var ma_ = lr_.Quantity(1m, "day");
																										var mb_ = lr_.Add((ly_ as CqlDate), ma_);
																										var mg_ = lr_.ListElementAt<CqlDate>(lw_, lx_);
																										var mi_ = lr_.Quantity(30m, "days");
																										var mj_ = lr_.Add((mg_ as CqlDate), mi_);
																										var mk_ = lr_.Interval(mb_, mj_, true, true);
																										var ml_ = lr_.ElementInInterval<CqlDate>(X, mk_, null);
																										var mm_ = lr_.Not(ml_);

																										return mm_;
																									};
																									var li_ = kz_.WhereOrNull<CqlDate>(lc_, lh_);
																									var ll_ = kz_.Add(ld_, (int?)1);
																									var lm_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = (le_ as CqlDate),
																										NewList = li_,
																										IndexofNewDate = ll_,
																									};
																									var ln_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																									{
																										lm_,
																									};
																									Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT lo_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EighthList)
																									{
																										Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT mn_()
																										{
																											if ((context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) is null))
																											{
																												return EighthList;
																											}
																											else
																											{
																												var mo_ = context.Operators;
																												var mr_ = EighthList?.NewList;
																												var ms_ = EighthList?.IndexofNewDate;
																												var mt_ = mo_.ListElementAt<CqlDate>(mr_, ms_);
																												bool? mw_(CqlDate X)
																												{
																													var ng_ = context.Operators;
																													var nl_ = EighthList?.NewList;
																													var nm_ = EighthList?.IndexofNewDate;
																													var nn_ = ng_.ListElementAt<CqlDate>(nl_, nm_);
																													var np_ = ng_.Quantity(1m, "day");
																													var nq_ = ng_.Add((nn_ as CqlDate), np_);
																													var nv_ = ng_.ListElementAt<CqlDate>(nl_, nm_);
																													var nx_ = ng_.Quantity(30m, "days");
																													var ny_ = ng_.Add((nv_ as CqlDate), nx_);
																													var nz_ = ng_.Interval(nq_, ny_, true, true);
																													var oa_ = ng_.ElementInInterval<CqlDate>(X, nz_, null);
																													var ob_ = ng_.Not(oa_);

																													return ob_;
																												};
																												var mx_ = mo_.WhereOrNull<CqlDate>(mr_, mw_);
																												var na_ = mo_.Add(ms_, (int?)1);
																												var nb_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																												{
																													NextDate = (mt_ as CqlDate),
																													NewList = mx_,
																													IndexofNewDate = na_,
																												};
																												var nc_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																												{
																													nb_,
																												};
																												Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT nd_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT NinethList)
																												{
																													Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT oc_()
																													{
																														if ((context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) is null))
																														{
																															return NinethList;
																														}
																														else
																														{
																															var od_ = context.Operators;
																															var og_ = NinethList?.NewList;
																															var oh_ = NinethList?.IndexofNewDate;
																															var oi_ = od_.ListElementAt<CqlDate>(og_, oh_);
																															bool? ol_(CqlDate X)
																															{
																																var ov_ = context.Operators;
																																var pa_ = NinethList?.NewList;
																																var pb_ = NinethList?.IndexofNewDate;
																																var pc_ = ov_.ListElementAt<CqlDate>(pa_, pb_);
																																var pe_ = ov_.Quantity(1m, "day");
																																var pf_ = ov_.Add((pc_ as CqlDate), pe_);
																																var pk_ = ov_.ListElementAt<CqlDate>(pa_, pb_);
																																var pm_ = ov_.Quantity(30m, "days");
																																var pn_ = ov_.Add((pk_ as CqlDate), pm_);
																																var po_ = ov_.Interval(pf_, pn_, true, true);
																																var pp_ = ov_.ElementInInterval<CqlDate>(X, po_, null);
																																var pq_ = ov_.Not(pp_);

																																return pq_;
																															};
																															var om_ = od_.WhereOrNull<CqlDate>(og_, ol_);
																															var op_ = od_.Add(oh_, (int?)1);
																															var oq_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																															{
																																NextDate = (oi_ as CqlDate),
																																NewList = om_,
																																IndexofNewDate = op_,
																															};
																															var or_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																															{
																																oq_,
																															};
																															Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT os_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT TenthList)
																															{
																																Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT pr_()
																																{
																																	if ((context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) is null))
																																	{
																																		return TenthList;
																																	}
																																	else
																																	{
																																		var ps_ = context.Operators;
																																		var pv_ = TenthList?.NewList;
																																		var pw_ = TenthList?.IndexofNewDate;
																																		var px_ = ps_.ListElementAt<CqlDate>(pv_, pw_);
																																		bool? qa_(CqlDate X)
																																		{
																																			var qk_ = context.Operators;
																																			var qp_ = TenthList?.NewList;
																																			var qq_ = TenthList?.IndexofNewDate;
																																			var qr_ = qk_.ListElementAt<CqlDate>(qp_, qq_);
																																			var qt_ = qk_.Quantity(1m, "day");
																																			var qu_ = qk_.Add((qr_ as CqlDate), qt_);
																																			var qz_ = qk_.ListElementAt<CqlDate>(qp_, qq_);
																																			var rb_ = qk_.Quantity(30m, "days");
																																			var rc_ = qk_.Add((qz_ as CqlDate), rb_);
																																			var rd_ = qk_.Interval(qu_, rc_, true, true);
																																			var re_ = qk_.ElementInInterval<CqlDate>(X, rd_, null);
																																			var rf_ = qk_.Not(re_);

																																			return rf_;
																																		};
																																		var qb_ = ps_.WhereOrNull<CqlDate>(pv_, qa_);
																																		var qe_ = ps_.Add(pw_, (int?)1);
																																		var qf_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																		{
																																			NextDate = (px_ as CqlDate),
																																			NewList = qb_,
																																			IndexofNewDate = qe_,
																																		};
																																		var qg_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																		{
																																			qf_,
																																		};
																																		Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT qh_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EleventhList)
																																		{
																																			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT rg_()
																																			{
																																				if ((context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) is null))
																																				{
																																					return EleventhList;
																																				}
																																				else
																																				{
																																					var rh_ = context.Operators;
																																					var ri_ = EleventhList?.NewList;
																																					var rj_ = EleventhList?.IndexofNewDate;
																																					var rk_ = rh_.ListElementAt<CqlDate>(ri_, rj_);
																																					bool? rn_(CqlDate X)
																																					{
																																						var rt_ = context.Operators;
																																						var ry_ = EleventhList?.NewList;
																																						var rz_ = EleventhList?.IndexofNewDate;
																																						var sa_ = rt_.ListElementAt<CqlDate>(ry_, rz_);
																																						var sc_ = rt_.Quantity(1m, "day");
																																						var sd_ = rt_.Add((sa_ as CqlDate), sc_);
																																						var si_ = rt_.ListElementAt<CqlDate>(ry_, rz_);
																																						var sk_ = rt_.Quantity(30m, "days");
																																						var sl_ = rt_.Add((si_ as CqlDate), sk_);
																																						var sm_ = rt_.Interval(sd_, sl_, true, true);
																																						var sn_ = rt_.ElementInInterval<CqlDate>(X, sm_, null);
																																						var so_ = rt_.Not(sn_);

																																						return so_;
																																					};
																																					var ro_ = rh_.WhereOrNull<CqlDate>(ri_, rn_);
																																					var rr_ = rh_.Add(rj_, (int?)1);
																																					var rs_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																					{
																																						NextDate = (rk_ as CqlDate),
																																						NewList = ro_,
																																						IndexofNewDate = rr_,
																																					};

																																					return rs_;
																																				};
																																			};

																																			return rg_();
																																		};
																																		var qi_ = ps_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(qg_, qh_);
																																		var qj_ = ps_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(qi_);

																																		return qj_;
																																	};
																																};

																																return pr_();
																															};
																															var ot_ = od_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(or_, os_);
																															var ou_ = od_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ot_);

																															return ou_;
																														};
																													};

																													return oc_();
																												};
																												var ne_ = mo_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(nc_, nd_);
																												var nf_ = mo_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ne_);

																												return nf_;
																											};
																										};

																										return mn_();
																									};
																									var lp_ = kz_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ln_, lo_);
																									var lq_ = kz_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(lp_);

																									return lq_;
																								};
																							};

																							return ky_();
																						};
																						var ka_ = jk_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(jy_, jz_);
																						var kb_ = jk_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ka_);

																						return kb_;
																					};
																				};

																				return jj_();
																			};
																			var il_ = hv_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ij_, ik_);
																			var im_ = hv_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(il_);

																			return im_;
																		};
																	};

																	return hu_();
																};
																var gw_ = gg_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gu_, gv_);
																var gx_ = gg_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gw_);

																return gx_;
															};
														};

														return gf_();
													};
													var fh_ = er_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ff_, fg_);
													var fi_ = er_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fh_);

													return fi_;
												};
											};

											return eq_();
										};
										var ds_ = dc_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(dq_, dr_);
										var dt_ = dc_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ds_);

										return dt_;
									};
								};

								return db_();
							};
							var cd_ = bn_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cb_, cc_);
							var ce_ = bn_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cd_);

							return ce_;
						};
					};

					return bm_();
				};
				var ao_ = z_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(am_, an_);
				var ap_ = z_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ao_);

				return ap_;
			};
			var x_ = r_.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(v_, w_);
			var y_ = r_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(x_);

			return y_;
		};
		var n_ = a_.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(l_, m_);
		var o_ = a_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(n_);

		return o_;
	}

}