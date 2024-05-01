using System;
using Tuples;
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
				CqlInterval<CqlDateTime> j_ = null;
				var k_ = context.Operators.Message<CqlInterval<CqlDateTime>>(j_, "1", "Error", "Cannot compute an interval from a String value");

				return k_;
			}
			else
			{
				CqlInterval<CqlDate> l_()
				{
					if (onset is Age)
					{
						var s_ = this.Patient();
						var t_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						var u_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var v_ = context.Operators.Add(t_, u_);
						var x_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						var z_ = context.Operators.Add(x_, u_);
						var aa_ = context.Operators.Quantity(1m, "year");
						var ab_ = context.Operators.Add(z_, aa_);
						var ac_ = context.Operators.Interval(v_, ab_, true, false);

						return ac_;
					}
					else if (onset is Range)
					{
						var ad_ = this.Patient();
						var ae_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						var af_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var ag_ = context.Operators.Add(ae_, af_);
						var ai_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						var aj_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var ak_ = context.Operators.Add(ai_, aj_);
						var al_ = context.Operators.Quantity(1m, "year");
						var am_ = context.Operators.Add(ak_, al_);
						var an_ = context.Operators.Interval(ag_, am_, true, false);

						return an_;
					}
					else
					{
						CqlInterval<CqlDate> ao_ = null;

						return ao_;
					};
				};
				var m_ = context.Operators.ConvertDateToDateTime(l_()?.low);
				CqlInterval<CqlDate> n_()
				{
					if (onset is Age)
					{
						var ap_ = this.Patient();
						var aq_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						var ar_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var as_ = context.Operators.Add(aq_, ar_);
						var au_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						var aw_ = context.Operators.Add(au_, ar_);
						var ax_ = context.Operators.Quantity(1m, "year");
						var ay_ = context.Operators.Add(aw_, ax_);
						var az_ = context.Operators.Interval(as_, ay_, true, false);

						return az_;
					}
					else if (onset is Range)
					{
						var ba_ = this.Patient();
						var bb_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						var bc_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var bd_ = context.Operators.Add(bb_, bc_);
						var bf_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						var bg_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var bh_ = context.Operators.Add(bf_, bg_);
						var bi_ = context.Operators.Quantity(1m, "year");
						var bj_ = context.Operators.Add(bh_, bi_);
						var bk_ = context.Operators.Interval(bd_, bj_, true, false);

						return bk_;
					}
					else
					{
						CqlInterval<CqlDate> bl_ = null;

						return bl_;
					};
				};
				var o_ = context.Operators.ConvertDateToDateTime(n_()?.high);
				CqlInterval<CqlDate> p_()
				{
					if (onset is Age)
					{
						var bm_ = this.Patient();
						var bn_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						var bo_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var bp_ = context.Operators.Add(bn_, bo_);
						var br_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						var bt_ = context.Operators.Add(br_, bo_);
						var bu_ = context.Operators.Quantity(1m, "year");
						var bv_ = context.Operators.Add(bt_, bu_);
						var bw_ = context.Operators.Interval(bp_, bv_, true, false);

						return bw_;
					}
					else if (onset is Range)
					{
						var bx_ = this.Patient();
						var by_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						var bz_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var ca_ = context.Operators.Add(by_, bz_);
						var cc_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						var cd_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var ce_ = context.Operators.Add(cc_, cd_);
						var cf_ = context.Operators.Quantity(1m, "year");
						var cg_ = context.Operators.Add(ce_, cf_);
						var ch_ = context.Operators.Interval(ca_, cg_, true, false);

						return ch_;
					}
					else
					{
						CqlInterval<CqlDate> ci_ = null;

						return ci_;
					};
				};
				CqlInterval<CqlDate> q_()
				{
					if (onset is Age)
					{
						var cj_ = this.Patient();
						var ck_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						var cl_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var cm_ = context.Operators.Add(ck_, cl_);
						var co_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						var cq_ = context.Operators.Add(co_, cl_);
						var cr_ = context.Operators.Quantity(1m, "year");
						var cs_ = context.Operators.Add(cq_, cr_);
						var ct_ = context.Operators.Interval(cm_, cs_, true, false);

						return ct_;
					}
					else if (onset is Range)
					{
						var cu_ = this.Patient();
						var cv_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						var cw_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var cx_ = context.Operators.Add(cv_, cw_);
						var cz_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						var da_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var db_ = context.Operators.Add(cz_, da_);
						var dc_ = context.Operators.Quantity(1m, "year");
						var dd_ = context.Operators.Add(db_, dc_);
						var de_ = context.Operators.Interval(cx_, dd_, true, false);

						return de_;
					}
					else
					{
						CqlInterval<CqlDate> df_ = null;

						return df_;
					};
				};
				var r_ = context.Operators.Interval(m_, o_, p_()?.lowClosed, q_()?.highClosed);

				return r_;
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
				var f_ = context.Operators.Convert<CqlDateTime>(e_);
				var g_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
				var h_ = context.Operators.Convert<CqlDateTime>(g_);
				var i_ = context.Operators.Interval(f_, h_, true, true);

				return i_;
			}
			else if (abatement is FhirString)
			{
				CqlInterval<CqlDateTime> j_ = null;
				var k_ = context.Operators.Message<CqlInterval<CqlDateTime>>(j_, "1", "Error", "Cannot compute an interval from a String value");

				return k_;
			}
			else
			{
				CqlInterval<CqlDate> l_()
				{
					if (abatement is Age)
					{
						var s_ = this.Patient();
						var t_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						var u_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var v_ = context.Operators.Add(t_, u_);
						var x_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						var z_ = context.Operators.Add(x_, u_);
						var aa_ = context.Operators.Quantity(1m, "year");
						var ab_ = context.Operators.Add(z_, aa_);
						var ac_ = context.Operators.Interval(v_, ab_, true, false);

						return ac_;
					}
					else if (abatement is Range)
					{
						var ad_ = this.Patient();
						var ae_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						var af_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var ag_ = context.Operators.Add(ae_, af_);
						var ai_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						var aj_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var ak_ = context.Operators.Add(ai_, aj_);
						var al_ = context.Operators.Quantity(1m, "year");
						var am_ = context.Operators.Add(ak_, al_);
						var an_ = context.Operators.Interval(ag_, am_, true, false);

						return an_;
					}
					else
					{
						CqlInterval<CqlDate> ao_ = null;

						return ao_;
					};
				};
				var m_ = context.Operators.ConvertDateToDateTime(l_()?.low);
				CqlInterval<CqlDate> n_()
				{
					if (abatement is Age)
					{
						var ap_ = this.Patient();
						var aq_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						var ar_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var as_ = context.Operators.Add(aq_, ar_);
						var au_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						var aw_ = context.Operators.Add(au_, ar_);
						var ax_ = context.Operators.Quantity(1m, "year");
						var ay_ = context.Operators.Add(aw_, ax_);
						var az_ = context.Operators.Interval(as_, ay_, true, false);

						return az_;
					}
					else if (abatement is Range)
					{
						var ba_ = this.Patient();
						var bb_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						var bc_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var bd_ = context.Operators.Add(bb_, bc_);
						var bf_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						var bg_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var bh_ = context.Operators.Add(bf_, bg_);
						var bi_ = context.Operators.Quantity(1m, "year");
						var bj_ = context.Operators.Add(bh_, bi_);
						var bk_ = context.Operators.Interval(bd_, bj_, true, false);

						return bk_;
					}
					else
					{
						CqlInterval<CqlDate> bl_ = null;

						return bl_;
					};
				};
				var o_ = context.Operators.ConvertDateToDateTime(n_()?.high);
				CqlInterval<CqlDate> p_()
				{
					if (abatement is Age)
					{
						var bm_ = this.Patient();
						var bn_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						var bo_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var bp_ = context.Operators.Add(bn_, bo_);
						var br_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						var bt_ = context.Operators.Add(br_, bo_);
						var bu_ = context.Operators.Quantity(1m, "year");
						var bv_ = context.Operators.Add(bt_, bu_);
						var bw_ = context.Operators.Interval(bp_, bv_, true, false);

						return bw_;
					}
					else if (abatement is Range)
					{
						var bx_ = this.Patient();
						var by_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						var bz_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var ca_ = context.Operators.Add(by_, bz_);
						var cc_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						var cd_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var ce_ = context.Operators.Add(cc_, cd_);
						var cf_ = context.Operators.Quantity(1m, "year");
						var cg_ = context.Operators.Add(ce_, cf_);
						var ch_ = context.Operators.Interval(ca_, cg_, true, false);

						return ch_;
					}
					else
					{
						CqlInterval<CqlDate> ci_ = null;

						return ci_;
					};
				};
				CqlInterval<CqlDate> q_()
				{
					if (abatement is Age)
					{
						var cj_ = this.Patient();
						var ck_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						var cl_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var cm_ = context.Operators.Add(ck_, cl_);
						var co_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						var cq_ = context.Operators.Add(co_, cl_);
						var cr_ = context.Operators.Quantity(1m, "year");
						var cs_ = context.Operators.Add(cq_, cr_);
						var ct_ = context.Operators.Interval(cm_, cs_, true, false);

						return ct_;
					}
					else if (abatement is Range)
					{
						var cu_ = this.Patient();
						var cv_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						var cw_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var cx_ = context.Operators.Add(cv_, cw_);
						var cz_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						var da_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var db_ = context.Operators.Add(cz_, da_);
						var dc_ = context.Operators.Quantity(1m, "year");
						var dd_ = context.Operators.Add(db_, dc_);
						var de_ = context.Operators.Interval(cx_, dd_, true, false);

						return de_;
					}
					else
					{
						CqlInterval<CqlDate> df_ = null;

						return df_;
					};
				};
				var r_ = context.Operators.Interval(m_, o_, p_()?.lowClosed, q_()?.highClosed);

				return r_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		var a_ = this.Normalize_Onset(condition?.Onset);
		var b_ = context.Operators.Start(a_);
		var c_ = this.Normalize_Abatement(condition?.Abatement);
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
				var s_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var t_ = FHIRHelpers_4_0_001.ToQuantity(((choice as Age) as Quantity));
				var u_ = context.Operators.Add(s_, t_);
				var w_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var y_ = context.Operators.Add(w_, t_);
				var z_ = context.Operators.Quantity(1m, "year");
				var aa_ = context.Operators.Add(y_, z_);
				var ab_ = context.Operators.Interval(u_, aa_, true, false);
				var ac_ = context.Operators.ConvertDateToDateTime(ab_?.low);
				var ae_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var ag_ = context.Operators.Add(ae_, t_);
				var ai_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var ak_ = context.Operators.Add(ai_, t_);
				var am_ = context.Operators.Add(ak_, z_);
				var an_ = context.Operators.Interval(ag_, am_, true, false);
				var ao_ = context.Operators.ConvertDateToDateTime(an_?.high);
				var aq_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var as_ = context.Operators.Add(aq_, t_);
				var au_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var aw_ = context.Operators.Add(au_, t_);
				var ay_ = context.Operators.Add(aw_, z_);
				var az_ = context.Operators.Interval(as_, ay_, true, false);
				var bb_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var bd_ = context.Operators.Add(bb_, t_);
				var bf_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				var bh_ = context.Operators.Add(bf_, t_);
				var bj_ = context.Operators.Add(bh_, z_);
				var bk_ = context.Operators.Interval(bd_, bj_, true, false);
				var bl_ = context.Operators.Interval(ac_, ao_, az_?.lowClosed, bk_?.highClosed);

				return bl_;
			}
			else if (choice is Range)
			{
				var bm_ = this.Patient();
				var bn_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var bo_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.Low);
				var bp_ = context.Operators.Add(bn_, bo_);
				var br_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var bs_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.High);
				var bt_ = context.Operators.Add(br_, bs_);
				var bu_ = context.Operators.Quantity(1m, "year");
				var bv_ = context.Operators.Add(bt_, bu_);
				var bw_ = context.Operators.Interval(bp_, bv_, true, false);
				var bx_ = context.Operators.ConvertDateToDateTime(bw_?.low);
				var bz_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var cb_ = context.Operators.Add(bz_, bo_);
				var cd_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var cf_ = context.Operators.Add(cd_, bs_);
				var ch_ = context.Operators.Add(cf_, bu_);
				var ci_ = context.Operators.Interval(cb_, ch_, true, false);
				var cj_ = context.Operators.ConvertDateToDateTime(ci_?.high);
				var cl_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var cn_ = context.Operators.Add(cl_, bo_);
				var cp_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var cr_ = context.Operators.Add(cp_, bs_);
				var ct_ = context.Operators.Add(cr_, bu_);
				var cu_ = context.Operators.Interval(cn_, ct_, true, false);
				var cw_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var cy_ = context.Operators.Add(cw_, bo_);
				var da_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				var dc_ = context.Operators.Add(da_, bs_);
				var de_ = context.Operators.Add(dc_, bu_);
				var df_ = context.Operators.Interval(cy_, de_, true, false);
				var dg_ = context.Operators.Interval(bx_, cj_, cu_?.lowClosed, df_?.highClosed);

				return dg_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> dh_ = null;
				var di_ = context.Operators.Message<CqlInterval<CqlDateTime>>(dh_, "1", "Error", "Cannot compute a single interval from a Timing type");

				return di_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> dj_ = null;
				var dk_ = context.Operators.Message<CqlInterval<CqlDateTime>>(dj_, "1", "Error", "Cannot compute an interval from a String value");

				return dk_;
			}
			else
			{
				CqlInterval<CqlDateTime> dl_ = null;

				return dl_;
			};
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
			};
		};

		return a_();
	}

    [CqlDeclaration("VS Cast Function")]
	public IEnumerable<CqlCode> VS_Cast_Function(IEnumerable<CqlCode> VSet) => 
		VSet;

    [CqlDeclaration("First Dates per 31 Day Periods")]
	public Tuple_DUDddjZaCdFGjLXVHKdDKIRfT First_Dates_per_31_Day_Periods(IEnumerable<CqlDate> DateList)
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
		var f_ = new Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = e_,
		};
		var g_ = new Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			f_,
		};
		Tuple_DUDddjZaCdFGjLXVHKdDKIRfT h_(Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates)
		{
			var l_ = new Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = SortedDates?.SortedDates,
				AnchorIndex = 0,
			};
			var m_ = new Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				l_,
			};
			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT n_(Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList)
			{
				var q_ = context.Operators.Indexer<CqlDate>(AnchorList?.SortedList, AnchorList?.AnchorIndex);
				bool? r_(CqlDate X)
				{
					var z_ = context.Operators.Indexer<CqlDate>(AnchorList?.SortedList, AnchorList?.AnchorIndex);
					var aa_ = context.Operators.Quantity(1m, "day");
					var ab_ = context.Operators.Add(z_, aa_);
					var ad_ = context.Operators.Quantity(30m, "days");
					var ae_ = context.Operators.Add(z_, ad_);
					var af_ = context.Operators.Interval(ab_, ae_, true, true);
					var ag_ = context.Operators.In<CqlDate>(X, af_, null);
					var ah_ = context.Operators.Not(ag_);

					return ah_;
				};
				var s_ = context.Operators.Where<CqlDate>(DateList, r_);
				var t_ = context.Operators.Add(AnchorList?.AnchorIndex, 1);
				var u_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = q_,
					NewList = s_,
					IndexofNewDate = t_,
				};
				var v_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					u_,
				};
				Tuple_DUDddjZaCdFGjLXVHKdDKIRfT w_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList)
				{
					Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ai_()
					{
						if ((context.Operators.Indexer<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) is null))
						{
							return FirstList;
						}
						else
						{
							var aj_ = context.Operators.Indexer<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate);
							bool? ak_(CqlDate X)
							{
								var as_ = context.Operators.Indexer<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate);
								var at_ = context.Operators.Quantity(1m, "day");
								var au_ = context.Operators.Add(as_, at_);
								var aw_ = context.Operators.Quantity(30m, "days");
								var ax_ = context.Operators.Add(as_, aw_);
								var ay_ = context.Operators.Interval(au_, ax_, true, true);
								var az_ = context.Operators.In<CqlDate>(X, ay_, null);
								var ba_ = context.Operators.Not(az_);

								return ba_;
							};
							var al_ = context.Operators.Where<CqlDate>(FirstList?.NewList, ak_);
							var am_ = context.Operators.Add(FirstList?.IndexofNewDate, 1);
							var an_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
							{
								NextDate = aj_,
								NewList = al_,
								IndexofNewDate = am_,
							};
							var ao_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
							{
								an_,
							};
							Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ap_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SecondList)
							{
								Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bb_()
								{
									if ((context.Operators.Indexer<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) is null))
									{
										return SecondList;
									}
									else
									{
										var bc_ = context.Operators.Indexer<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate);
										bool? bd_(CqlDate X)
										{
											var bl_ = context.Operators.Indexer<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate);
											var bm_ = context.Operators.Quantity(1m, "day");
											var bn_ = context.Operators.Add(bl_, bm_);
											var bp_ = context.Operators.Quantity(30m, "days");
											var bq_ = context.Operators.Add(bl_, bp_);
											var br_ = context.Operators.Interval(bn_, bq_, true, true);
											var bs_ = context.Operators.In<CqlDate>(X, br_, null);
											var bt_ = context.Operators.Not(bs_);

											return bt_;
										};
										var be_ = context.Operators.Where<CqlDate>(SecondList?.NewList, bd_);
										var bf_ = context.Operators.Add(SecondList?.IndexofNewDate, 1);
										var bg_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
										{
											NextDate = bc_,
											NewList = be_,
											IndexofNewDate = bf_,
										};
										var bh_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
										{
											bg_,
										};
										Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bi_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ThirdList)
										{
											Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bu_()
											{
												if ((context.Operators.Indexer<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) is null))
												{
													return ThirdList;
												}
												else
												{
													var bv_ = context.Operators.Indexer<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate);
													bool? bw_(CqlDate X)
													{
														var ce_ = context.Operators.Indexer<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate);
														var cf_ = context.Operators.Quantity(1m, "day");
														var cg_ = context.Operators.Add(ce_, cf_);
														var ci_ = context.Operators.Quantity(30m, "days");
														var cj_ = context.Operators.Add(ce_, ci_);
														var ck_ = context.Operators.Interval(cg_, cj_, true, true);
														var cl_ = context.Operators.In<CqlDate>(X, ck_, null);
														var cm_ = context.Operators.Not(cl_);

														return cm_;
													};
													var bx_ = context.Operators.Where<CqlDate>(ThirdList?.NewList, bw_);
													var by_ = context.Operators.Add(ThirdList?.IndexofNewDate, 1);
													var bz_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = bv_,
														NewList = bx_,
														IndexofNewDate = by_,
													};
													var ca_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
													{
														bz_,
													};
													Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cb_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FourthList)
													{
														Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cn_()
														{
															if ((context.Operators.Indexer<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) is null))
															{
																return FourthList;
															}
															else
															{
																var co_ = context.Operators.Indexer<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate);
																bool? cp_(CqlDate X)
																{
																	var cx_ = context.Operators.Indexer<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate);
																	var cy_ = context.Operators.Quantity(1m, "day");
																	var cz_ = context.Operators.Add(cx_, cy_);
																	var db_ = context.Operators.Quantity(30m, "days");
																	var dc_ = context.Operators.Add(cx_, db_);
																	var dd_ = context.Operators.Interval(cz_, dc_, true, true);
																	var de_ = context.Operators.In<CqlDate>(X, dd_, null);
																	var df_ = context.Operators.Not(de_);

																	return df_;
																};
																var cq_ = context.Operators.Where<CqlDate>(FourthList?.NewList, cp_);
																var cr_ = context.Operators.Add(FourthList?.IndexofNewDate, 1);
																var cs_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																{
																	NextDate = co_,
																	NewList = cq_,
																	IndexofNewDate = cr_,
																};
																var ct_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																{
																	cs_,
																};
																Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cu_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FifthList)
																{
																	Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dg_()
																	{
																		if ((context.Operators.Indexer<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) is null))
																		{
																			return FifthList;
																		}
																		else
																		{
																			var dh_ = context.Operators.Indexer<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate);
																			bool? di_(CqlDate X)
																			{
																				var dq_ = context.Operators.Indexer<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate);
																				var dr_ = context.Operators.Quantity(1m, "day");
																				var ds_ = context.Operators.Add(dq_, dr_);
																				var du_ = context.Operators.Quantity(30m, "days");
																				var dv_ = context.Operators.Add(dq_, du_);
																				var dw_ = context.Operators.Interval(ds_, dv_, true, true);
																				var dx_ = context.Operators.In<CqlDate>(X, dw_, null);
																				var dy_ = context.Operators.Not(dx_);

																				return dy_;
																			};
																			var dj_ = context.Operators.Where<CqlDate>(FifthList?.NewList, di_);
																			var dk_ = context.Operators.Add(FifthList?.IndexofNewDate, 1);
																			var dl_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																			{
																				NextDate = dh_,
																				NewList = dj_,
																				IndexofNewDate = dk_,
																			};
																			var dm_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																			{
																				dl_,
																			};
																			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dn_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SixthList)
																			{
																				Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dz_()
																				{
																					if ((context.Operators.Indexer<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) is null))
																					{
																						return SixthList;
																					}
																					else
																					{
																						var ea_ = context.Operators.Indexer<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate);
																						bool? eb_(CqlDate X)
																						{
																							var ej_ = context.Operators.Indexer<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate);
																							var ek_ = context.Operators.Quantity(1m, "day");
																							var el_ = context.Operators.Add(ej_, ek_);
																							var en_ = context.Operators.Quantity(30m, "days");
																							var eo_ = context.Operators.Add(ej_, en_);
																							var ep_ = context.Operators.Interval(el_, eo_, true, true);
																							var eq_ = context.Operators.In<CqlDate>(X, ep_, null);
																							var er_ = context.Operators.Not(eq_);

																							return er_;
																						};
																						var ec_ = context.Operators.Where<CqlDate>(SixthList?.NewList, eb_);
																						var ed_ = context.Operators.Add(SixthList?.IndexofNewDate, 1);
																						var ee_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																						{
																							NextDate = ea_,
																							NewList = ec_,
																							IndexofNewDate = ed_,
																						};
																						var ef_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																						{
																							ee_,
																						};
																						Tuple_DUDddjZaCdFGjLXVHKdDKIRfT eg_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SeventhList)
																						{
																							Tuple_DUDddjZaCdFGjLXVHKdDKIRfT es_()
																							{
																								if ((context.Operators.Indexer<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) is null))
																								{
																									return SeventhList;
																								}
																								else
																								{
																									var et_ = context.Operators.Indexer<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate);
																									bool? eu_(CqlDate X)
																									{
																										var fc_ = context.Operators.Indexer<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate);
																										var fd_ = context.Operators.Quantity(1m, "day");
																										var fe_ = context.Operators.Add(fc_, fd_);
																										var fg_ = context.Operators.Quantity(30m, "days");
																										var fh_ = context.Operators.Add(fc_, fg_);
																										var fi_ = context.Operators.Interval(fe_, fh_, true, true);
																										var fj_ = context.Operators.In<CqlDate>(X, fi_, null);
																										var fk_ = context.Operators.Not(fj_);

																										return fk_;
																									};
																									var ev_ = context.Operators.Where<CqlDate>(SeventhList?.NewList, eu_);
																									var ew_ = context.Operators.Add(SeventhList?.IndexofNewDate, 1);
																									var ex_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = et_,
																										NewList = ev_,
																										IndexofNewDate = ew_,
																									};
																									var ey_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																									{
																										ex_,
																									};
																									Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ez_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EighthList)
																									{
																										Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fl_()
																										{
																											if ((context.Operators.Indexer<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) is null))
																											{
																												return EighthList;
																											}
																											else
																											{
																												var fm_ = context.Operators.Indexer<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate);
																												bool? fn_(CqlDate X)
																												{
																													var fv_ = context.Operators.Indexer<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate);
																													var fw_ = context.Operators.Quantity(1m, "day");
																													var fx_ = context.Operators.Add(fv_, fw_);
																													var fz_ = context.Operators.Quantity(30m, "days");
																													var ga_ = context.Operators.Add(fv_, fz_);
																													var gb_ = context.Operators.Interval(fx_, ga_, true, true);
																													var gc_ = context.Operators.In<CqlDate>(X, gb_, null);
																													var gd_ = context.Operators.Not(gc_);

																													return gd_;
																												};
																												var fo_ = context.Operators.Where<CqlDate>(EighthList?.NewList, fn_);
																												var fp_ = context.Operators.Add(EighthList?.IndexofNewDate, 1);
																												var fq_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																												{
																													NextDate = fm_,
																													NewList = fo_,
																													IndexofNewDate = fp_,
																												};
																												var fr_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																												{
																													fq_,
																												};
																												Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fs_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT NinethList)
																												{
																													Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ge_()
																													{
																														if ((context.Operators.Indexer<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) is null))
																														{
																															return NinethList;
																														}
																														else
																														{
																															var gf_ = context.Operators.Indexer<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate);
																															bool? gg_(CqlDate X)
																															{
																																var go_ = context.Operators.Indexer<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate);
																																var gp_ = context.Operators.Quantity(1m, "day");
																																var gq_ = context.Operators.Add(go_, gp_);
																																var gs_ = context.Operators.Quantity(30m, "days");
																																var gt_ = context.Operators.Add(go_, gs_);
																																var gu_ = context.Operators.Interval(gq_, gt_, true, true);
																																var gv_ = context.Operators.In<CqlDate>(X, gu_, null);
																																var gw_ = context.Operators.Not(gv_);

																																return gw_;
																															};
																															var gh_ = context.Operators.Where<CqlDate>(NinethList?.NewList, gg_);
																															var gi_ = context.Operators.Add(NinethList?.IndexofNewDate, 1);
																															var gj_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																															{
																																NextDate = gf_,
																																NewList = gh_,
																																IndexofNewDate = gi_,
																															};
																															var gk_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																															{
																																gj_,
																															};
																															Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gl_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT TenthList)
																															{
																																Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gx_()
																																{
																																	if ((context.Operators.Indexer<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) is null))
																																	{
																																		return TenthList;
																																	}
																																	else
																																	{
																																		var gy_ = context.Operators.Indexer<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate);
																																		bool? gz_(CqlDate X)
																																		{
																																			var hh_ = context.Operators.Indexer<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate);
																																			var hi_ = context.Operators.Quantity(1m, "day");
																																			var hj_ = context.Operators.Add(hh_, hi_);
																																			var hl_ = context.Operators.Quantity(30m, "days");
																																			var hm_ = context.Operators.Add(hh_, hl_);
																																			var hn_ = context.Operators.Interval(hj_, hm_, true, true);
																																			var ho_ = context.Operators.In<CqlDate>(X, hn_, null);
																																			var hp_ = context.Operators.Not(ho_);

																																			return hp_;
																																		};
																																		var ha_ = context.Operators.Where<CqlDate>(TenthList?.NewList, gz_);
																																		var hb_ = context.Operators.Add(TenthList?.IndexofNewDate, 1);
																																		var hc_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																		{
																																			NextDate = gy_,
																																			NewList = ha_,
																																			IndexofNewDate = hb_,
																																		};
																																		var hd_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																		{
																																			hc_,
																																		};
																																		Tuple_DUDddjZaCdFGjLXVHKdDKIRfT he_(Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EleventhList)
																																		{
																																			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hq_()
																																			{
																																				if ((context.Operators.Indexer<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) is null))
																																				{
																																					return EleventhList;
																																				}
																																				else
																																				{
																																					var hr_ = context.Operators.Indexer<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate);
																																					bool? hs_(CqlDate X)
																																					{
																																						var hw_ = context.Operators.Indexer<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate);
																																						var hx_ = context.Operators.Quantity(1m, "day");
																																						var hy_ = context.Operators.Add(hw_, hx_);
																																						var ia_ = context.Operators.Quantity(30m, "days");
																																						var ib_ = context.Operators.Add(hw_, ia_);
																																						var ic_ = context.Operators.Interval(hy_, ib_, true, true);
																																						var id_ = context.Operators.In<CqlDate>(X, ic_, null);
																																						var ie_ = context.Operators.Not(id_);

																																						return ie_;
																																					};
																																					var ht_ = context.Operators.Where<CqlDate>(EleventhList?.NewList, hs_);
																																					var hu_ = context.Operators.Add(EleventhList?.IndexofNewDate, 1);
																																					var hv_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																					{
																																						NextDate = hr_,
																																						NewList = ht_,
																																						IndexofNewDate = hu_,
																																					};

																																					return hv_;
																																				};
																																			};

																																			return hq_();
																																		};
																																		var hf_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hd_, he_);
																																		var hg_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hf_);

																																		return hg_;
																																	};
																																};

																																return gx_();
																															};
																															var gm_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gk_, gl_);
																															var gn_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gm_);

																															return gn_;
																														};
																													};

																													return ge_();
																												};
																												var ft_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fr_, fs_);
																												var fu_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ft_);

																												return fu_;
																											};
																										};

																										return fl_();
																									};
																									var fa_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ey_, ez_);
																									var fb_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fa_);

																									return fb_;
																								};
																							};

																							return es_();
																						};
																						var eh_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ef_, eg_);
																						var ei_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(eh_);

																						return ei_;
																					};
																				};

																				return dz_();
																			};
																			var do_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(dm_, dn_);
																			var dp_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(do_);

																			return dp_;
																		};
																	};

																	return dg_();
																};
																var cv_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ct_, cu_);
																var cw_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cv_);

																return cw_;
															};
														};

														return cn_();
													};
													var cc_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ca_, cb_);
													var cd_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cc_);

													return cd_;
												};
											};

											return bu_();
										};
										var bj_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(bh_, bi_);
										var bk_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(bj_);

										return bk_;
									};
								};

								return bb_();
							};
							var aq_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ao_, ap_);
							var ar_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(aq_);

							return ar_;
						};
					};

					return ai_();
				};
				var x_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(v_, w_);
				var y_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(x_);

				return y_;
			};
			var o_ = context.Operators.Select<Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(m_, n_);
			var p_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(o_);

			return p_;
		};
		var i_ = context.Operators.Select<Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(g_, h_);
		var j_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(i_);

		return j_;
	}

}
