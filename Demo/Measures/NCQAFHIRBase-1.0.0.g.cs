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
				var j_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return j_;
			}
			else
			{
				CqlInterval<CqlDate> k_()
				{
					if (onset is Age)
					{
						var r_ = this.Patient();
						var s_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
						var t_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var u_ = context.Operators.Add(s_, t_);
						var w_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
						var y_ = context.Operators.Add(w_, t_);
						var z_ = context.Operators.Quantity(1m, "year");
						var aa_ = context.Operators.Add(y_, z_);
						var ab_ = context.Operators.Interval(u_, aa_, true, false);

						return ab_;
					}
					else if (onset is Range)
					{
						var ac_ = this.Patient();
						var ad_ = FHIRHelpers_4_0_001.ToDate(ac_?.BirthDateElement);
						var ae_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var af_ = context.Operators.Add(ad_, ae_);
						var ah_ = FHIRHelpers_4_0_001.ToDate(ac_?.BirthDateElement);
						var ai_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var aj_ = context.Operators.Add(ah_, ai_);
						var ak_ = context.Operators.Quantity(1m, "year");
						var al_ = context.Operators.Add(aj_, ak_);
						var am_ = context.Operators.Interval(af_, al_, true, false);

						return am_;
					}
					else
					{
						return null;
					};
				};
				var l_ = context.Operators.ConvertDateToDateTime(k_()?.low);
				CqlInterval<CqlDate> m_()
				{
					if (onset is Age)
					{
						var an_ = this.Patient();
						var ao_ = FHIRHelpers_4_0_001.ToDate(an_?.BirthDateElement);
						var ap_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var aq_ = context.Operators.Add(ao_, ap_);
						var as_ = FHIRHelpers_4_0_001.ToDate(an_?.BirthDateElement);
						var au_ = context.Operators.Add(as_, ap_);
						var av_ = context.Operators.Quantity(1m, "year");
						var aw_ = context.Operators.Add(au_, av_);
						var ax_ = context.Operators.Interval(aq_, aw_, true, false);

						return ax_;
					}
					else if (onset is Range)
					{
						var ay_ = this.Patient();
						var az_ = FHIRHelpers_4_0_001.ToDate(ay_?.BirthDateElement);
						var ba_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var bb_ = context.Operators.Add(az_, ba_);
						var bd_ = FHIRHelpers_4_0_001.ToDate(ay_?.BirthDateElement);
						var be_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var bf_ = context.Operators.Add(bd_, be_);
						var bg_ = context.Operators.Quantity(1m, "year");
						var bh_ = context.Operators.Add(bf_, bg_);
						var bi_ = context.Operators.Interval(bb_, bh_, true, false);

						return bi_;
					}
					else
					{
						return null;
					};
				};
				var n_ = context.Operators.ConvertDateToDateTime(m_()?.high);
				CqlInterval<CqlDate> o_()
				{
					if (onset is Age)
					{
						var bj_ = this.Patient();
						var bk_ = FHIRHelpers_4_0_001.ToDate(bj_?.BirthDateElement);
						var bl_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var bm_ = context.Operators.Add(bk_, bl_);
						var bo_ = FHIRHelpers_4_0_001.ToDate(bj_?.BirthDateElement);
						var bq_ = context.Operators.Add(bo_, bl_);
						var br_ = context.Operators.Quantity(1m, "year");
						var bs_ = context.Operators.Add(bq_, br_);
						var bt_ = context.Operators.Interval(bm_, bs_, true, false);

						return bt_;
					}
					else if (onset is Range)
					{
						var bu_ = this.Patient();
						var bv_ = FHIRHelpers_4_0_001.ToDate(bu_?.BirthDateElement);
						var bw_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var bx_ = context.Operators.Add(bv_, bw_);
						var bz_ = FHIRHelpers_4_0_001.ToDate(bu_?.BirthDateElement);
						var ca_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var cb_ = context.Operators.Add(bz_, ca_);
						var cc_ = context.Operators.Quantity(1m, "year");
						var cd_ = context.Operators.Add(cb_, cc_);
						var ce_ = context.Operators.Interval(bx_, cd_, true, false);

						return ce_;
					}
					else
					{
						return null;
					};
				};
				CqlInterval<CqlDate> p_()
				{
					if (onset is Age)
					{
						var cf_ = this.Patient();
						var cg_ = FHIRHelpers_4_0_001.ToDate(cf_?.BirthDateElement);
						var ch_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						var ci_ = context.Operators.Add(cg_, ch_);
						var ck_ = FHIRHelpers_4_0_001.ToDate(cf_?.BirthDateElement);
						var cm_ = context.Operators.Add(ck_, ch_);
						var cn_ = context.Operators.Quantity(1m, "year");
						var co_ = context.Operators.Add(cm_, cn_);
						var cp_ = context.Operators.Interval(ci_, co_, true, false);

						return cp_;
					}
					else if (onset is Range)
					{
						var cq_ = this.Patient();
						var cr_ = FHIRHelpers_4_0_001.ToDate(cq_?.BirthDateElement);
						var cs_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						var ct_ = context.Operators.Add(cr_, cs_);
						var cv_ = FHIRHelpers_4_0_001.ToDate(cq_?.BirthDateElement);
						var cw_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						var cx_ = context.Operators.Add(cv_, cw_);
						var cy_ = context.Operators.Quantity(1m, "year");
						var cz_ = context.Operators.Add(cx_, cy_);
						var da_ = context.Operators.Interval(ct_, cz_, true, false);

						return da_;
					}
					else
					{
						return null;
					};
				};
				var q_ = context.Operators.Interval(l_, n_, o_()?.lowClosed, p_()?.highClosed);

				return q_;
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
				var j_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return j_;
			}
			else
			{
				CqlInterval<CqlDate> k_()
				{
					if (abatement is Age)
					{
						var r_ = this.Patient();
						var s_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
						var t_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var u_ = context.Operators.Add(s_, t_);
						var w_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
						var y_ = context.Operators.Add(w_, t_);
						var z_ = context.Operators.Quantity(1m, "year");
						var aa_ = context.Operators.Add(y_, z_);
						var ab_ = context.Operators.Interval(u_, aa_, true, false);

						return ab_;
					}
					else if (abatement is Range)
					{
						var ac_ = this.Patient();
						var ad_ = FHIRHelpers_4_0_001.ToDate(ac_?.BirthDateElement);
						var ae_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var af_ = context.Operators.Add(ad_, ae_);
						var ah_ = FHIRHelpers_4_0_001.ToDate(ac_?.BirthDateElement);
						var ai_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var aj_ = context.Operators.Add(ah_, ai_);
						var ak_ = context.Operators.Quantity(1m, "year");
						var al_ = context.Operators.Add(aj_, ak_);
						var am_ = context.Operators.Interval(af_, al_, true, false);

						return am_;
					}
					else
					{
						return null;
					};
				};
				var l_ = context.Operators.ConvertDateToDateTime(k_()?.low);
				CqlInterval<CqlDate> m_()
				{
					if (abatement is Age)
					{
						var an_ = this.Patient();
						var ao_ = FHIRHelpers_4_0_001.ToDate(an_?.BirthDateElement);
						var ap_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var aq_ = context.Operators.Add(ao_, ap_);
						var as_ = FHIRHelpers_4_0_001.ToDate(an_?.BirthDateElement);
						var au_ = context.Operators.Add(as_, ap_);
						var av_ = context.Operators.Quantity(1m, "year");
						var aw_ = context.Operators.Add(au_, av_);
						var ax_ = context.Operators.Interval(aq_, aw_, true, false);

						return ax_;
					}
					else if (abatement is Range)
					{
						var ay_ = this.Patient();
						var az_ = FHIRHelpers_4_0_001.ToDate(ay_?.BirthDateElement);
						var ba_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var bb_ = context.Operators.Add(az_, ba_);
						var bd_ = FHIRHelpers_4_0_001.ToDate(ay_?.BirthDateElement);
						var be_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var bf_ = context.Operators.Add(bd_, be_);
						var bg_ = context.Operators.Quantity(1m, "year");
						var bh_ = context.Operators.Add(bf_, bg_);
						var bi_ = context.Operators.Interval(bb_, bh_, true, false);

						return bi_;
					}
					else
					{
						return null;
					};
				};
				var n_ = context.Operators.ConvertDateToDateTime(m_()?.high);
				CqlInterval<CqlDate> o_()
				{
					if (abatement is Age)
					{
						var bj_ = this.Patient();
						var bk_ = FHIRHelpers_4_0_001.ToDate(bj_?.BirthDateElement);
						var bl_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var bm_ = context.Operators.Add(bk_, bl_);
						var bo_ = FHIRHelpers_4_0_001.ToDate(bj_?.BirthDateElement);
						var bq_ = context.Operators.Add(bo_, bl_);
						var br_ = context.Operators.Quantity(1m, "year");
						var bs_ = context.Operators.Add(bq_, br_);
						var bt_ = context.Operators.Interval(bm_, bs_, true, false);

						return bt_;
					}
					else if (abatement is Range)
					{
						var bu_ = this.Patient();
						var bv_ = FHIRHelpers_4_0_001.ToDate(bu_?.BirthDateElement);
						var bw_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var bx_ = context.Operators.Add(bv_, bw_);
						var bz_ = FHIRHelpers_4_0_001.ToDate(bu_?.BirthDateElement);
						var ca_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var cb_ = context.Operators.Add(bz_, ca_);
						var cc_ = context.Operators.Quantity(1m, "year");
						var cd_ = context.Operators.Add(cb_, cc_);
						var ce_ = context.Operators.Interval(bx_, cd_, true, false);

						return ce_;
					}
					else
					{
						return null;
					};
				};
				CqlInterval<CqlDate> p_()
				{
					if (abatement is Age)
					{
						var cf_ = this.Patient();
						var cg_ = FHIRHelpers_4_0_001.ToDate(cf_?.BirthDateElement);
						var ch_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						var ci_ = context.Operators.Add(cg_, ch_);
						var ck_ = FHIRHelpers_4_0_001.ToDate(cf_?.BirthDateElement);
						var cm_ = context.Operators.Add(ck_, ch_);
						var cn_ = context.Operators.Quantity(1m, "year");
						var co_ = context.Operators.Add(cm_, cn_);
						var cp_ = context.Operators.Interval(ci_, co_, true, false);

						return cp_;
					}
					else if (abatement is Range)
					{
						var cq_ = this.Patient();
						var cr_ = FHIRHelpers_4_0_001.ToDate(cq_?.BirthDateElement);
						var cs_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						var ct_ = context.Operators.Add(cr_, cs_);
						var cv_ = FHIRHelpers_4_0_001.ToDate(cq_?.BirthDateElement);
						var cw_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						var cx_ = context.Operators.Add(cv_, cw_);
						var cy_ = context.Operators.Quantity(1m, "year");
						var cz_ = context.Operators.Add(cx_, cy_);
						var da_ = context.Operators.Interval(ct_, cz_, true, false);

						return da_;
					}
					else
					{
						return null;
					};
				};
				var q_ = context.Operators.Interval(l_, n_, o_()?.lowClosed, p_()?.highClosed);

				return q_;
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
				var dh_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute a single interval from a Timing type");

				return dh_;
			}
			else if (choice is FhirString)
			{
				var di_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return di_;
			}
			else
			{
				return null;
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
	public Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe First_Dates_per_31_Day_Periods(IEnumerable<CqlDate> DateList)
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
		var f_ = new Tuple_CfANiScMYDdVZFgRERKJQEVca
		{
			SortedDates = e_,
		};
		var g_ = new Tuple_CfANiScMYDdVZFgRERKJQEVca[]
		{
			f_,
		};
		Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe h_(Tuple_CfANiScMYDdVZFgRERKJQEVca SortedDates)
		{
			var l_ = new Tuple_CWPhjaWHbfdjhVAPZiRhbJcgZ
			{
				SortedList = SortedDates?.SortedDates,
				AnchorIndex = 0,
			};
			var m_ = new Tuple_CWPhjaWHbfdjhVAPZiRhbJcgZ[]
			{
				l_,
			};
			Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe n_(Tuple_CWPhjaWHbfdjhVAPZiRhbJcgZ AnchorList)
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
				var u_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
				{
					NextDate = q_,
					NewList = s_,
					IndexofNewDate = t_,
				};
				var v_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
				{
					u_,
				};
				Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe w_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe FirstList)
				{
					Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe ai_()
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
							var an_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
							{
								NextDate = aj_,
								NewList = al_,
								IndexofNewDate = am_,
							};
							var ao_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
							{
								an_,
							};
							Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe ap_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe SecondList)
							{
								Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe bb_()
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
										var bg_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
										{
											NextDate = bc_,
											NewList = be_,
											IndexofNewDate = bf_,
										};
										var bh_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
										{
											bg_,
										};
										Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe bi_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe ThirdList)
										{
											Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe bu_()
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
													var bz_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
													{
														NextDate = bv_,
														NewList = bx_,
														IndexofNewDate = by_,
													};
													var ca_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
													{
														bz_,
													};
													Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe cb_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe FourthList)
													{
														Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe cn_()
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
																var cs_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
																{
																	NextDate = co_,
																	NewList = cq_,
																	IndexofNewDate = cr_,
																};
																var ct_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
																{
																	cs_,
																};
																Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe cu_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe FifthList)
																{
																	Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe dg_()
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
																			var dl_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
																			{
																				NextDate = dh_,
																				NewList = dj_,
																				IndexofNewDate = dk_,
																			};
																			var dm_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
																			{
																				dl_,
																			};
																			Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe dn_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe SixthList)
																			{
																				Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe dz_()
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
																						var ee_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
																						{
																							NextDate = ea_,
																							NewList = ec_,
																							IndexofNewDate = ed_,
																						};
																						var ef_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
																						{
																							ee_,
																						};
																						Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe eg_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe SeventhList)
																						{
																							Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe es_()
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
																									var ex_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
																									{
																										NextDate = et_,
																										NewList = ev_,
																										IndexofNewDate = ew_,
																									};
																									var ey_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
																									{
																										ex_,
																									};
																									Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe ez_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe EighthList)
																									{
																										Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe fl_()
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
																												var fq_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
																												{
																													NextDate = fm_,
																													NewList = fo_,
																													IndexofNewDate = fp_,
																												};
																												var fr_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
																												{
																													fq_,
																												};
																												Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe fs_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe NinethList)
																												{
																													Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe ge_()
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
																															var gj_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
																															{
																																NextDate = gf_,
																																NewList = gh_,
																																IndexofNewDate = gi_,
																															};
																															var gk_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
																															{
																																gj_,
																															};
																															Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe gl_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe TenthList)
																															{
																																Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe gx_()
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
																																		var hc_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
																																		{
																																			NextDate = gy_,
																																			NewList = ha_,
																																			IndexofNewDate = hb_,
																																		};
																																		var hd_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe[]
																																		{
																																			hc_,
																																		};
																																		Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe he_(Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe EleventhList)
																																		{
																																			Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe hq_()
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
																																					var hv_ = new Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe
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
																																		var hf_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(hd_, he_);
																																		var hg_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(hf_);

																																		return hg_;
																																	};
																																};

																																return gx_();
																															};
																															var gm_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(gk_, gl_);
																															var gn_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(gm_);

																															return gn_;
																														};
																													};

																													return ge_();
																												};
																												var ft_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(fr_, fs_);
																												var fu_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(ft_);

																												return fu_;
																											};
																										};

																										return fl_();
																									};
																									var fa_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(ey_, ez_);
																									var fb_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(fa_);

																									return fb_;
																								};
																							};

																							return es_();
																						};
																						var eh_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(ef_, eg_);
																						var ei_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(eh_);

																						return ei_;
																					};
																				};

																				return dz_();
																			};
																			var do_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(dm_, dn_);
																			var dp_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(do_);

																			return dp_;
																		};
																	};

																	return dg_();
																};
																var cv_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(ct_, cu_);
																var cw_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(cv_);

																return cw_;
															};
														};

														return cn_();
													};
													var cc_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(ca_, cb_);
													var cd_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(cc_);

													return cd_;
												};
											};

											return bu_();
										};
										var bj_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(bh_, bi_);
										var bk_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(bj_);

										return bk_;
									};
								};

								return bb_();
							};
							var aq_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(ao_, ap_);
							var ar_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(aq_);

							return ar_;
						};
					};

					return ai_();
				};
				var x_ = context.Operators.Select<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(v_, w_);
				var y_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(x_);

				return y_;
			};
			var o_ = context.Operators.Select<Tuple_CWPhjaWHbfdjhVAPZiRhbJcgZ, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(m_, n_);
			var p_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(o_);

			return p_;
		};
		var i_ = context.Operators.Select<Tuple_CfANiScMYDdVZFgRERKJQEVca, Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(g_, h_);
		var j_ = context.Operators.SingletonFrom<Tuple_BGjDKhZUjGDUZgiFYQFiFVWOe>(i_);

		return j_;
	}

}
