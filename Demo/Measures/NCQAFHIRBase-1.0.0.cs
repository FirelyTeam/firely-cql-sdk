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
[CqlLibrary("NCQAFHIRBase", "1.0.0")]
public class NCQAFHIRBase_1_0_0
{

    public static NCQAFHIRBase_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Normalize Onset")]
	public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (onset is FhirDateTime)
			{
				var b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (onset as FhirDateTime));
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
				CqlInterval<CqlDateTime> j_ = null;
				var k_ = context.Operators.Message<CqlInterval<CqlDateTime>>((j_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return k_;
			}
			else
			{
				CqlInterval<CqlDate> l_()
				{
					if (onset is Age)
					{
						var s_ = this.Patient(context);
						var t_ = FHIRHelpers_4_0_001.Instance.ToDate(context, s_?.BirthDateElement);
						var u_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Age));
						var v_ = context.Operators.Add(t_, u_);
						var x_ = FHIRHelpers_4_0_001.Instance.ToDate(context, s_?.BirthDateElement);
						var z_ = context.Operators.Add(x_, u_);
						var aa_ = context.Operators.Quantity(1m, "year");
						var ab_ = context.Operators.Add(z_, aa_);
						var ac_ = context.Operators.Interval(v_, ab_, true, false);

						return ac_;
					}
					else if (onset is Range)
					{
						var ad_ = this.Patient(context);
						var ae_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_?.BirthDateElement);
						var af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.Low);
						var ag_ = context.Operators.Add(ae_, af_);
						var ai_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_?.BirthDateElement);
						var aj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.High);
						var ak_ = context.Operators.Add(ai_, aj_);
						var al_ = context.Operators.Quantity(1m, "year");
						var am_ = context.Operators.Add(ak_, al_);
						var an_ = context.Operators.Interval(ag_, am_, true, false);

						return an_;
					}
					else
					{
						CqlInterval<CqlDate> ao_ = null;

						return (ao_ as CqlInterval<CqlDate>);
					};
				};
				var m_ = context.Operators.ConvertDateToDateTime(l_()?.low);
				CqlInterval<CqlDate> n_()
				{
					if (onset is Age)
					{
						var ap_ = this.Patient(context);
						var aq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_?.BirthDateElement);
						var ar_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Age));
						var as_ = context.Operators.Add(aq_, ar_);
						var au_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_?.BirthDateElement);
						var aw_ = context.Operators.Add(au_, ar_);
						var ax_ = context.Operators.Quantity(1m, "year");
						var ay_ = context.Operators.Add(aw_, ax_);
						var az_ = context.Operators.Interval(as_, ay_, true, false);

						return az_;
					}
					else if (onset is Range)
					{
						var ba_ = this.Patient(context);
						var bb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ba_?.BirthDateElement);
						var bc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.Low);
						var bd_ = context.Operators.Add(bb_, bc_);
						var bf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ba_?.BirthDateElement);
						var bg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.High);
						var bh_ = context.Operators.Add(bf_, bg_);
						var bi_ = context.Operators.Quantity(1m, "year");
						var bj_ = context.Operators.Add(bh_, bi_);
						var bk_ = context.Operators.Interval(bd_, bj_, true, false);

						return bk_;
					}
					else
					{
						CqlInterval<CqlDate> bl_ = null;

						return (bl_ as CqlInterval<CqlDate>);
					};
				};
				var o_ = context.Operators.ConvertDateToDateTime(n_()?.high);
				CqlInterval<CqlDate> p_()
				{
					if (onset is Age)
					{
						var bm_ = this.Patient(context);
						var bn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
						var bo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Age));
						var bp_ = context.Operators.Add(bn_, bo_);
						var br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
						var bt_ = context.Operators.Add(br_, bo_);
						var bu_ = context.Operators.Quantity(1m, "year");
						var bv_ = context.Operators.Add(bt_, bu_);
						var bw_ = context.Operators.Interval(bp_, bv_, true, false);

						return bw_;
					}
					else if (onset is Range)
					{
						var bx_ = this.Patient(context);
						var by_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bx_?.BirthDateElement);
						var bz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.Low);
						var ca_ = context.Operators.Add(by_, bz_);
						var cc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bx_?.BirthDateElement);
						var cd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.High);
						var ce_ = context.Operators.Add(cc_, cd_);
						var cf_ = context.Operators.Quantity(1m, "year");
						var cg_ = context.Operators.Add(ce_, cf_);
						var ch_ = context.Operators.Interval(ca_, cg_, true, false);

						return ch_;
					}
					else
					{
						CqlInterval<CqlDate> ci_ = null;

						return (ci_ as CqlInterval<CqlDate>);
					};
				};
				CqlInterval<CqlDate> q_()
				{
					if (onset is Age)
					{
						var cj_ = this.Patient(context);
						var ck_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cj_?.BirthDateElement);
						var cl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Age));
						var cm_ = context.Operators.Add(ck_, cl_);
						var co_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cj_?.BirthDateElement);
						var cq_ = context.Operators.Add(co_, cl_);
						var cr_ = context.Operators.Quantity(1m, "year");
						var cs_ = context.Operators.Add(cq_, cr_);
						var ct_ = context.Operators.Interval(cm_, cs_, true, false);

						return ct_;
					}
					else if (onset is Range)
					{
						var cu_ = this.Patient(context);
						var cv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cu_?.BirthDateElement);
						var cw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.Low);
						var cx_ = context.Operators.Add(cv_, cw_);
						var cz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cu_?.BirthDateElement);
						var da_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (onset as Range)?.High);
						var db_ = context.Operators.Add(cz_, da_);
						var dc_ = context.Operators.Quantity(1m, "year");
						var dd_ = context.Operators.Add(db_, dc_);
						var de_ = context.Operators.Interval(cx_, dd_, true, false);

						return de_;
					}
					else
					{
						CqlInterval<CqlDate> df_ = null;

						return (df_ as CqlInterval<CqlDate>);
					};
				};
				var r_ = context.Operators.Interval(m_, o_, p_()?.lowClosed, q_()?.highClosed);

				return r_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Normalize Abatement")]
	public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (abatement is FhirDateTime)
			{
				var b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (abatement as FhirDateTime));
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
				CqlInterval<CqlDateTime> j_ = null;
				var k_ = context.Operators.Message<CqlInterval<CqlDateTime>>((j_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return k_;
			}
			else
			{
				CqlInterval<CqlDate> l_()
				{
					if (abatement is Age)
					{
						var s_ = this.Patient(context);
						var t_ = FHIRHelpers_4_0_001.Instance.ToDate(context, s_?.BirthDateElement);
						var u_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Age));
						var v_ = context.Operators.Add(t_, u_);
						var x_ = FHIRHelpers_4_0_001.Instance.ToDate(context, s_?.BirthDateElement);
						var z_ = context.Operators.Add(x_, u_);
						var aa_ = context.Operators.Quantity(1m, "year");
						var ab_ = context.Operators.Add(z_, aa_);
						var ac_ = context.Operators.Interval(v_, ab_, true, false);

						return ac_;
					}
					else if (abatement is Range)
					{
						var ad_ = this.Patient(context);
						var ae_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_?.BirthDateElement);
						var af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.Low);
						var ag_ = context.Operators.Add(ae_, af_);
						var ai_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_?.BirthDateElement);
						var aj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.High);
						var ak_ = context.Operators.Add(ai_, aj_);
						var al_ = context.Operators.Quantity(1m, "year");
						var am_ = context.Operators.Add(ak_, al_);
						var an_ = context.Operators.Interval(ag_, am_, true, false);

						return an_;
					}
					else
					{
						CqlInterval<CqlDate> ao_ = null;

						return (ao_ as CqlInterval<CqlDate>);
					};
				};
				var m_ = context.Operators.ConvertDateToDateTime(l_()?.low);
				CqlInterval<CqlDate> n_()
				{
					if (abatement is Age)
					{
						var ap_ = this.Patient(context);
						var aq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_?.BirthDateElement);
						var ar_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Age));
						var as_ = context.Operators.Add(aq_, ar_);
						var au_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_?.BirthDateElement);
						var aw_ = context.Operators.Add(au_, ar_);
						var ax_ = context.Operators.Quantity(1m, "year");
						var ay_ = context.Operators.Add(aw_, ax_);
						var az_ = context.Operators.Interval(as_, ay_, true, false);

						return az_;
					}
					else if (abatement is Range)
					{
						var ba_ = this.Patient(context);
						var bb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ba_?.BirthDateElement);
						var bc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.Low);
						var bd_ = context.Operators.Add(bb_, bc_);
						var bf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ba_?.BirthDateElement);
						var bg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.High);
						var bh_ = context.Operators.Add(bf_, bg_);
						var bi_ = context.Operators.Quantity(1m, "year");
						var bj_ = context.Operators.Add(bh_, bi_);
						var bk_ = context.Operators.Interval(bd_, bj_, true, false);

						return bk_;
					}
					else
					{
						CqlInterval<CqlDate> bl_ = null;

						return (bl_ as CqlInterval<CqlDate>);
					};
				};
				var o_ = context.Operators.ConvertDateToDateTime(n_()?.high);
				CqlInterval<CqlDate> p_()
				{
					if (abatement is Age)
					{
						var bm_ = this.Patient(context);
						var bn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
						var bo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Age));
						var bp_ = context.Operators.Add(bn_, bo_);
						var br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
						var bt_ = context.Operators.Add(br_, bo_);
						var bu_ = context.Operators.Quantity(1m, "year");
						var bv_ = context.Operators.Add(bt_, bu_);
						var bw_ = context.Operators.Interval(bp_, bv_, true, false);

						return bw_;
					}
					else if (abatement is Range)
					{
						var bx_ = this.Patient(context);
						var by_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bx_?.BirthDateElement);
						var bz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.Low);
						var ca_ = context.Operators.Add(by_, bz_);
						var cc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bx_?.BirthDateElement);
						var cd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.High);
						var ce_ = context.Operators.Add(cc_, cd_);
						var cf_ = context.Operators.Quantity(1m, "year");
						var cg_ = context.Operators.Add(ce_, cf_);
						var ch_ = context.Operators.Interval(ca_, cg_, true, false);

						return ch_;
					}
					else
					{
						CqlInterval<CqlDate> ci_ = null;

						return (ci_ as CqlInterval<CqlDate>);
					};
				};
				CqlInterval<CqlDate> q_()
				{
					if (abatement is Age)
					{
						var cj_ = this.Patient(context);
						var ck_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cj_?.BirthDateElement);
						var cl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Age));
						var cm_ = context.Operators.Add(ck_, cl_);
						var co_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cj_?.BirthDateElement);
						var cq_ = context.Operators.Add(co_, cl_);
						var cr_ = context.Operators.Quantity(1m, "year");
						var cs_ = context.Operators.Add(cq_, cr_);
						var ct_ = context.Operators.Interval(cm_, cs_, true, false);

						return ct_;
					}
					else if (abatement is Range)
					{
						var cu_ = this.Patient(context);
						var cv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cu_?.BirthDateElement);
						var cw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.Low);
						var cx_ = context.Operators.Add(cv_, cw_);
						var cz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cu_?.BirthDateElement);
						var da_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (abatement as Range)?.High);
						var db_ = context.Operators.Add(cz_, da_);
						var dc_ = context.Operators.Quantity(1m, "year");
						var dd_ = context.Operators.Add(db_, dc_);
						var de_ = context.Operators.Interval(cx_, dd_, true, false);

						return de_;
					}
					else
					{
						CqlInterval<CqlDate> df_ = null;

						return (df_ as CqlInterval<CqlDate>);
					};
				};
				var r_ = context.Operators.Interval(m_, o_, p_()?.lowClosed, q_()?.highClosed);

				return r_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
	{
		var a_ = this.Normalize_Onset(context, condition?.Onset);
		var b_ = context.Operators.Start(a_);
		var c_ = this.Normalize_Abatement(context, condition?.Abatement);
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				var b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (choice as FhirDateTime));
				var d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Date)
			{
				var e_ = FHIRHelpers_4_0_001.Instance.ToDate(context, (choice as Date));
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
				var o_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (choice as Instant));
				var q_ = context.Operators.Interval(o_, o_, true, true);

				return q_;
			}
			else if (choice is Age)
			{
				var r_ = this.Patient(context);
				var s_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var t_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (choice as Age));
				var u_ = context.Operators.Add(s_, t_);
				var w_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var y_ = context.Operators.Add(w_, t_);
				var z_ = context.Operators.Quantity(1m, "year");
				var aa_ = context.Operators.Add(y_, z_);
				var ab_ = context.Operators.Interval(u_, aa_, true, false);
				var ac_ = context.Operators.ConvertDateToDateTime(ab_?.low);
				var ae_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var ag_ = context.Operators.Add(ae_, t_);
				var ai_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var ak_ = context.Operators.Add(ai_, t_);
				var am_ = context.Operators.Add(ak_, z_);
				var an_ = context.Operators.Interval(ag_, am_, true, false);
				var ao_ = context.Operators.ConvertDateToDateTime(an_?.high);
				var aq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var as_ = context.Operators.Add(aq_, t_);
				var au_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var aw_ = context.Operators.Add(au_, t_);
				var ay_ = context.Operators.Add(aw_, z_);
				var az_ = context.Operators.Interval(as_, ay_, true, false);
				var bb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var bd_ = context.Operators.Add(bb_, t_);
				var bf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, r_?.BirthDateElement);
				var bh_ = context.Operators.Add(bf_, t_);
				var bj_ = context.Operators.Add(bh_, z_);
				var bk_ = context.Operators.Interval(bd_, bj_, true, false);
				var bl_ = context.Operators.Interval(ac_, ao_, az_?.lowClosed, bk_?.highClosed);

				return bl_;
			}
			else if (choice is Range)
			{
				var bm_ = this.Patient(context);
				var bn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var bo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (choice as Range)?.Low);
				var bp_ = context.Operators.Add(bn_, bo_);
				var br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var bs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (choice as Range)?.High);
				var bt_ = context.Operators.Add(br_, bs_);
				var bu_ = context.Operators.Quantity(1m, "year");
				var bv_ = context.Operators.Add(bt_, bu_);
				var bw_ = context.Operators.Interval(bp_, bv_, true, false);
				var bx_ = context.Operators.ConvertDateToDateTime(bw_?.low);
				var bz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var cb_ = context.Operators.Add(bz_, bo_);
				var cd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var cf_ = context.Operators.Add(cd_, bs_);
				var ch_ = context.Operators.Add(cf_, bu_);
				var ci_ = context.Operators.Interval(cb_, ch_, true, false);
				var cj_ = context.Operators.ConvertDateToDateTime(ci_?.high);
				var cl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var cn_ = context.Operators.Add(cl_, bo_);
				var cp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var cr_ = context.Operators.Add(cp_, bs_);
				var ct_ = context.Operators.Add(cr_, bu_);
				var cu_ = context.Operators.Interval(cn_, ct_, true, false);
				var cw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var cy_ = context.Operators.Add(cw_, bo_);
				var da_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bm_?.BirthDateElement);
				var dc_ = context.Operators.Add(da_, bs_);
				var de_ = context.Operators.Add(dc_, bu_);
				var df_ = context.Operators.Interval(cy_, de_, true, false);
				var dg_ = context.Operators.Interval(bx_, cj_, cu_?.lowClosed, df_?.highClosed);

				return dg_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> dh_ = null;
				var di_ = context.Operators.Message<CqlInterval<CqlDateTime>>((dh_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return di_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> dj_ = null;
				var dk_ = context.Operators.Message<CqlInterval<CqlDateTime>>((dj_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return dk_;
			}
			else
			{
				CqlInterval<CqlDateTime> dl_ = null;

				return (dl_ as CqlInterval<CqlDateTime>);
			};
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public string GetId(CqlContext context, string uri)
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
	public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) => 
		VSet;

    [CqlDeclaration("First Dates per 31 Day Periods")]
	public Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
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
			var l_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = SortedDates?.SortedDates,
				AnchorIndex = (int?)0,
			};
			var m_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				l_,
			};
			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT n_(Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList)
			{
				var q_ = context.Operators.ListElementAt<CqlDate>(AnchorList?.SortedList, AnchorList?.AnchorIndex);
				bool? r_(CqlDate X)
				{
					var z_ = context.Operators.ListElementAt<CqlDate>(AnchorList?.SortedList, AnchorList?.AnchorIndex);
					var aa_ = context.Operators.Quantity(1m, "day");
					var ab_ = context.Operators.Add((z_ as CqlDate), aa_);
					var ad_ = context.Operators.Quantity(30m, "days");
					var ae_ = context.Operators.Add((z_ as CqlDate), ad_);
					var af_ = context.Operators.Interval(ab_, ae_, true, true);
					var ag_ = context.Operators.ElementInInterval<CqlDate>(X, af_, null);
					var ah_ = context.Operators.Not(ag_);

					return ah_;
				};
				var s_ = context.Operators.WhereOrNull<CqlDate>(DateList, r_);
				var t_ = context.Operators.Add(AnchorList?.AnchorIndex, (int?)1);
				var u_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = (q_ as CqlDate),
					NewList = s_,
					IndexofNewDate = t_,
				};
				var v_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					u_,
				};
				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT w_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList)
				{
					Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ai_()
					{
						if ((context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) is null))
						{
							return FirstList;
						}
						else
						{
							var aj_ = context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate);
							bool? ak_(CqlDate X)
							{
								var as_ = context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate);
								var at_ = context.Operators.Quantity(1m, "day");
								var au_ = context.Operators.Add((as_ as CqlDate), at_);
								var aw_ = context.Operators.Quantity(30m, "days");
								var ax_ = context.Operators.Add((as_ as CqlDate), aw_);
								var ay_ = context.Operators.Interval(au_, ax_, true, true);
								var az_ = context.Operators.ElementInInterval<CqlDate>(X, ay_, null);
								var ba_ = context.Operators.Not(az_);

								return ba_;
							};
							var al_ = context.Operators.WhereOrNull<CqlDate>(FirstList?.NewList, ak_);
							var am_ = context.Operators.Add(FirstList?.IndexofNewDate, (int?)1);
							var an_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
							{
								NextDate = (aj_ as CqlDate),
								NewList = al_,
								IndexofNewDate = am_,
							};
							var ao_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
							{
								an_,
							};
							Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ap_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SecondList)
							{
								Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bb_()
								{
									if ((context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) is null))
									{
										return SecondList;
									}
									else
									{
										var bc_ = context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate);
										bool? bd_(CqlDate X)
										{
											var bl_ = context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate);
											var bm_ = context.Operators.Quantity(1m, "day");
											var bn_ = context.Operators.Add((bl_ as CqlDate), bm_);
											var bp_ = context.Operators.Quantity(30m, "days");
											var bq_ = context.Operators.Add((bl_ as CqlDate), bp_);
											var br_ = context.Operators.Interval(bn_, bq_, true, true);
											var bs_ = context.Operators.ElementInInterval<CqlDate>(X, br_, null);
											var bt_ = context.Operators.Not(bs_);

											return bt_;
										};
										var be_ = context.Operators.WhereOrNull<CqlDate>(SecondList?.NewList, bd_);
										var bf_ = context.Operators.Add(SecondList?.IndexofNewDate, (int?)1);
										var bg_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
										{
											NextDate = (bc_ as CqlDate),
											NewList = be_,
											IndexofNewDate = bf_,
										};
										var bh_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
										{
											bg_,
										};
										Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bi_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ThirdList)
										{
											Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bu_()
											{
												if ((context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) is null))
												{
													return ThirdList;
												}
												else
												{
													var bv_ = context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate);
													bool? bw_(CqlDate X)
													{
														var ce_ = context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate);
														var cf_ = context.Operators.Quantity(1m, "day");
														var cg_ = context.Operators.Add((ce_ as CqlDate), cf_);
														var ci_ = context.Operators.Quantity(30m, "days");
														var cj_ = context.Operators.Add((ce_ as CqlDate), ci_);
														var ck_ = context.Operators.Interval(cg_, cj_, true, true);
														var cl_ = context.Operators.ElementInInterval<CqlDate>(X, ck_, null);
														var cm_ = context.Operators.Not(cl_);

														return cm_;
													};
													var bx_ = context.Operators.WhereOrNull<CqlDate>(ThirdList?.NewList, bw_);
													var by_ = context.Operators.Add(ThirdList?.IndexofNewDate, (int?)1);
													var bz_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = (bv_ as CqlDate),
														NewList = bx_,
														IndexofNewDate = by_,
													};
													var ca_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
													{
														bz_,
													};
													Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cb_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FourthList)
													{
														Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cn_()
														{
															if ((context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) is null))
															{
																return FourthList;
															}
															else
															{
																var co_ = context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate);
																bool? cp_(CqlDate X)
																{
																	var cx_ = context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate);
																	var cy_ = context.Operators.Quantity(1m, "day");
																	var cz_ = context.Operators.Add((cx_ as CqlDate), cy_);
																	var db_ = context.Operators.Quantity(30m, "days");
																	var dc_ = context.Operators.Add((cx_ as CqlDate), db_);
																	var dd_ = context.Operators.Interval(cz_, dc_, true, true);
																	var de_ = context.Operators.ElementInInterval<CqlDate>(X, dd_, null);
																	var df_ = context.Operators.Not(de_);

																	return df_;
																};
																var cq_ = context.Operators.WhereOrNull<CqlDate>(FourthList?.NewList, cp_);
																var cr_ = context.Operators.Add(FourthList?.IndexofNewDate, (int?)1);
																var cs_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																{
																	NextDate = (co_ as CqlDate),
																	NewList = cq_,
																	IndexofNewDate = cr_,
																};
																var ct_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																{
																	cs_,
																};
																Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cu_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FifthList)
																{
																	Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dg_()
																	{
																		if ((context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) is null))
																		{
																			return FifthList;
																		}
																		else
																		{
																			var dh_ = context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate);
																			bool? di_(CqlDate X)
																			{
																				var dq_ = context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate);
																				var dr_ = context.Operators.Quantity(1m, "day");
																				var ds_ = context.Operators.Add((dq_ as CqlDate), dr_);
																				var du_ = context.Operators.Quantity(30m, "days");
																				var dv_ = context.Operators.Add((dq_ as CqlDate), du_);
																				var dw_ = context.Operators.Interval(ds_, dv_, true, true);
																				var dx_ = context.Operators.ElementInInterval<CqlDate>(X, dw_, null);
																				var dy_ = context.Operators.Not(dx_);

																				return dy_;
																			};
																			var dj_ = context.Operators.WhereOrNull<CqlDate>(FifthList?.NewList, di_);
																			var dk_ = context.Operators.Add(FifthList?.IndexofNewDate, (int?)1);
																			var dl_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																			{
																				NextDate = (dh_ as CqlDate),
																				NewList = dj_,
																				IndexofNewDate = dk_,
																			};
																			var dm_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																			{
																				dl_,
																			};
																			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dn_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SixthList)
																			{
																				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dz_()
																				{
																					if ((context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) is null))
																					{
																						return SixthList;
																					}
																					else
																					{
																						var ea_ = context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate);
																						bool? eb_(CqlDate X)
																						{
																							var ej_ = context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate);
																							var ek_ = context.Operators.Quantity(1m, "day");
																							var el_ = context.Operators.Add((ej_ as CqlDate), ek_);
																							var en_ = context.Operators.Quantity(30m, "days");
																							var eo_ = context.Operators.Add((ej_ as CqlDate), en_);
																							var ep_ = context.Operators.Interval(el_, eo_, true, true);
																							var eq_ = context.Operators.ElementInInterval<CqlDate>(X, ep_, null);
																							var er_ = context.Operators.Not(eq_);

																							return er_;
																						};
																						var ec_ = context.Operators.WhereOrNull<CqlDate>(SixthList?.NewList, eb_);
																						var ed_ = context.Operators.Add(SixthList?.IndexofNewDate, (int?)1);
																						var ee_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																						{
																							NextDate = (ea_ as CqlDate),
																							NewList = ec_,
																							IndexofNewDate = ed_,
																						};
																						var ef_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																						{
																							ee_,
																						};
																						Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT eg_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SeventhList)
																						{
																							Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT es_()
																							{
																								if ((context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) is null))
																								{
																									return SeventhList;
																								}
																								else
																								{
																									var et_ = context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate);
																									bool? eu_(CqlDate X)
																									{
																										var fc_ = context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate);
																										var fd_ = context.Operators.Quantity(1m, "day");
																										var fe_ = context.Operators.Add((fc_ as CqlDate), fd_);
																										var fg_ = context.Operators.Quantity(30m, "days");
																										var fh_ = context.Operators.Add((fc_ as CqlDate), fg_);
																										var fi_ = context.Operators.Interval(fe_, fh_, true, true);
																										var fj_ = context.Operators.ElementInInterval<CqlDate>(X, fi_, null);
																										var fk_ = context.Operators.Not(fj_);

																										return fk_;
																									};
																									var ev_ = context.Operators.WhereOrNull<CqlDate>(SeventhList?.NewList, eu_);
																									var ew_ = context.Operators.Add(SeventhList?.IndexofNewDate, (int?)1);
																									var ex_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = (et_ as CqlDate),
																										NewList = ev_,
																										IndexofNewDate = ew_,
																									};
																									var ey_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																									{
																										ex_,
																									};
																									Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ez_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EighthList)
																									{
																										Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fl_()
																										{
																											if ((context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) is null))
																											{
																												return EighthList;
																											}
																											else
																											{
																												var fm_ = context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate);
																												bool? fn_(CqlDate X)
																												{
																													var fv_ = context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate);
																													var fw_ = context.Operators.Quantity(1m, "day");
																													var fx_ = context.Operators.Add((fv_ as CqlDate), fw_);
																													var fz_ = context.Operators.Quantity(30m, "days");
																													var ga_ = context.Operators.Add((fv_ as CqlDate), fz_);
																													var gb_ = context.Operators.Interval(fx_, ga_, true, true);
																													var gc_ = context.Operators.ElementInInterval<CqlDate>(X, gb_, null);
																													var gd_ = context.Operators.Not(gc_);

																													return gd_;
																												};
																												var fo_ = context.Operators.WhereOrNull<CqlDate>(EighthList?.NewList, fn_);
																												var fp_ = context.Operators.Add(EighthList?.IndexofNewDate, (int?)1);
																												var fq_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																												{
																													NextDate = (fm_ as CqlDate),
																													NewList = fo_,
																													IndexofNewDate = fp_,
																												};
																												var fr_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																												{
																													fq_,
																												};
																												Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fs_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT NinethList)
																												{
																													Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ge_()
																													{
																														if ((context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) is null))
																														{
																															return NinethList;
																														}
																														else
																														{
																															var gf_ = context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate);
																															bool? gg_(CqlDate X)
																															{
																																var go_ = context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate);
																																var gp_ = context.Operators.Quantity(1m, "day");
																																var gq_ = context.Operators.Add((go_ as CqlDate), gp_);
																																var gs_ = context.Operators.Quantity(30m, "days");
																																var gt_ = context.Operators.Add((go_ as CqlDate), gs_);
																																var gu_ = context.Operators.Interval(gq_, gt_, true, true);
																																var gv_ = context.Operators.ElementInInterval<CqlDate>(X, gu_, null);
																																var gw_ = context.Operators.Not(gv_);

																																return gw_;
																															};
																															var gh_ = context.Operators.WhereOrNull<CqlDate>(NinethList?.NewList, gg_);
																															var gi_ = context.Operators.Add(NinethList?.IndexofNewDate, (int?)1);
																															var gj_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																															{
																																NextDate = (gf_ as CqlDate),
																																NewList = gh_,
																																IndexofNewDate = gi_,
																															};
																															var gk_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																															{
																																gj_,
																															};
																															Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gl_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT TenthList)
																															{
																																Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gx_()
																																{
																																	if ((context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) is null))
																																	{
																																		return TenthList;
																																	}
																																	else
																																	{
																																		var gy_ = context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate);
																																		bool? gz_(CqlDate X)
																																		{
																																			var hh_ = context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate);
																																			var hi_ = context.Operators.Quantity(1m, "day");
																																			var hj_ = context.Operators.Add((hh_ as CqlDate), hi_);
																																			var hl_ = context.Operators.Quantity(30m, "days");
																																			var hm_ = context.Operators.Add((hh_ as CqlDate), hl_);
																																			var hn_ = context.Operators.Interval(hj_, hm_, true, true);
																																			var ho_ = context.Operators.ElementInInterval<CqlDate>(X, hn_, null);
																																			var hp_ = context.Operators.Not(ho_);

																																			return hp_;
																																		};
																																		var ha_ = context.Operators.WhereOrNull<CqlDate>(TenthList?.NewList, gz_);
																																		var hb_ = context.Operators.Add(TenthList?.IndexofNewDate, (int?)1);
																																		var hc_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																		{
																																			NextDate = (gy_ as CqlDate),
																																			NewList = ha_,
																																			IndexofNewDate = hb_,
																																		};
																																		var hd_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																		{
																																			hc_,
																																		};
																																		Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT he_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EleventhList)
																																		{
																																			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hq_()
																																			{
																																				if ((context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) is null))
																																				{
																																					return EleventhList;
																																				}
																																				else
																																				{
																																					var hr_ = context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate);
																																					bool? hs_(CqlDate X)
																																					{
																																						var hw_ = context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate);
																																						var hx_ = context.Operators.Quantity(1m, "day");
																																						var hy_ = context.Operators.Add((hw_ as CqlDate), hx_);
																																						var ia_ = context.Operators.Quantity(30m, "days");
																																						var ib_ = context.Operators.Add((hw_ as CqlDate), ia_);
																																						var ic_ = context.Operators.Interval(hy_, ib_, true, true);
																																						var id_ = context.Operators.ElementInInterval<CqlDate>(X, ic_, null);
																																						var ie_ = context.Operators.Not(id_);

																																						return ie_;
																																					};
																																					var ht_ = context.Operators.WhereOrNull<CqlDate>(EleventhList?.NewList, hs_);
																																					var hu_ = context.Operators.Add(EleventhList?.IndexofNewDate, (int?)1);
																																					var hv_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																					{
																																						NextDate = (hr_ as CqlDate),
																																						NewList = ht_,
																																						IndexofNewDate = hu_,
																																					};

																																					return hv_;
																																				};
																																			};

																																			return hq_();
																																		};
																																		var hf_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hd_, he_);
																																		var hg_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hf_);

																																		return hg_;
																																	};
																																};

																																return gx_();
																															};
																															var gm_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gk_, gl_);
																															var gn_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gm_);

																															return gn_;
																														};
																													};

																													return ge_();
																												};
																												var ft_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fr_, fs_);
																												var fu_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ft_);

																												return fu_;
																											};
																										};

																										return fl_();
																									};
																									var fa_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ey_, ez_);
																									var fb_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fa_);

																									return fb_;
																								};
																							};

																							return es_();
																						};
																						var eh_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ef_, eg_);
																						var ei_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(eh_);

																						return ei_;
																					};
																				};

																				return dz_();
																			};
																			var do_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(dm_, dn_);
																			var dp_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(do_);

																			return dp_;
																		};
																	};

																	return dg_();
																};
																var cv_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ct_, cu_);
																var cw_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cv_);

																return cw_;
															};
														};

														return cn_();
													};
													var cc_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ca_, cb_);
													var cd_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cc_);

													return cd_;
												};
											};

											return bu_();
										};
										var bj_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(bh_, bi_);
										var bk_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(bj_);

										return bk_;
									};
								};

								return bb_();
							};
							var aq_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ao_, ap_);
							var ar_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(aq_);

							return ar_;
						};
					};

					return ai_();
				};
				var x_ = context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(v_, w_);
				var y_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(x_);

				return y_;
			};
			var o_ = context.Operators.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(m_, n_);
			var p_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(o_);

			return p_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(g_, h_);
		var j_ = context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(i_);

		return j_;
	}

}