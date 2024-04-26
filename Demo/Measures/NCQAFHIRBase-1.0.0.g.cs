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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

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
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (onset is Period)
			{
				FhirDateTime e_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
				CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
				FhirDateTime g_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
				CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
				CqlInterval<CqlDateTime> i_ = context.Operators.Interval(f_, h_, true, true);

				return i_;
			}
			else if (onset is FhirString)
			{
				CqlInterval<CqlDateTime> j_ = null;
				CqlInterval<CqlDateTime> k_ = context.Operators.Message<CqlInterval<CqlDateTime>>(j_, "1", "Error", "Cannot compute an interval from a String value");

				return k_;
			}
			else
			{
				CqlInterval<CqlDate> l_()
				{
					if (onset is Age)
					{
						Patient s_ = this.Patient();
						CqlDate t_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						CqlQuantity u_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						CqlDate v_ = context.Operators.Add(t_, u_);
						CqlDate x_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						CqlDate z_ = context.Operators.Add(x_, u_);
						CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
						CqlDate ab_ = context.Operators.Add(z_, aa_);
						CqlInterval<CqlDate> ac_ = context.Operators.Interval(v_, ab_, true, false);

						return ac_;
					}
					else if (onset is Range)
					{
						Patient ad_ = this.Patient();
						CqlDate ae_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						CqlQuantity af_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						CqlDate ag_ = context.Operators.Add(ae_, af_);
						CqlDate ai_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						CqlQuantity aj_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						CqlDate ak_ = context.Operators.Add(ai_, aj_);
						CqlQuantity al_ = context.Operators.Quantity(1m, "year");
						CqlDate am_ = context.Operators.Add(ak_, al_);
						CqlInterval<CqlDate> an_ = context.Operators.Interval(ag_, am_, true, false);

						return an_;
					}
					else
					{
						CqlInterval<CqlDate> ao_ = null;

						return ao_;
					};
				};
				CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_()?.low);
				CqlInterval<CqlDate> n_()
				{
					if (onset is Age)
					{
						Patient ap_ = this.Patient();
						CqlDate aq_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						CqlQuantity ar_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						CqlDate as_ = context.Operators.Add(aq_, ar_);
						CqlDate au_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						CqlDate aw_ = context.Operators.Add(au_, ar_);
						CqlQuantity ax_ = context.Operators.Quantity(1m, "year");
						CqlDate ay_ = context.Operators.Add(aw_, ax_);
						CqlInterval<CqlDate> az_ = context.Operators.Interval(as_, ay_, true, false);

						return az_;
					}
					else if (onset is Range)
					{
						Patient ba_ = this.Patient();
						CqlDate bb_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						CqlQuantity bc_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						CqlDate bd_ = context.Operators.Add(bb_, bc_);
						CqlDate bf_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						CqlQuantity bg_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						CqlDate bh_ = context.Operators.Add(bf_, bg_);
						CqlQuantity bi_ = context.Operators.Quantity(1m, "year");
						CqlDate bj_ = context.Operators.Add(bh_, bi_);
						CqlInterval<CqlDate> bk_ = context.Operators.Interval(bd_, bj_, true, false);

						return bk_;
					}
					else
					{
						CqlInterval<CqlDate> bl_ = null;

						return bl_;
					};
				};
				CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_()?.high);
				CqlInterval<CqlDate> p_()
				{
					if (onset is Age)
					{
						Patient bm_ = this.Patient();
						CqlDate bn_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						CqlQuantity bo_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						CqlDate bp_ = context.Operators.Add(bn_, bo_);
						CqlDate br_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						CqlDate bt_ = context.Operators.Add(br_, bo_);
						CqlQuantity bu_ = context.Operators.Quantity(1m, "year");
						CqlDate bv_ = context.Operators.Add(bt_, bu_);
						CqlInterval<CqlDate> bw_ = context.Operators.Interval(bp_, bv_, true, false);

						return bw_;
					}
					else if (onset is Range)
					{
						Patient bx_ = this.Patient();
						CqlDate by_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						CqlQuantity bz_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						CqlDate ca_ = context.Operators.Add(by_, bz_);
						CqlDate cc_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						CqlQuantity cd_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						CqlDate ce_ = context.Operators.Add(cc_, cd_);
						CqlQuantity cf_ = context.Operators.Quantity(1m, "year");
						CqlDate cg_ = context.Operators.Add(ce_, cf_);
						CqlInterval<CqlDate> ch_ = context.Operators.Interval(ca_, cg_, true, false);

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
						Patient cj_ = this.Patient();
						CqlDate ck_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						CqlQuantity cl_ = FHIRHelpers_4_0_001.ToQuantity(((onset as Age) as Quantity));
						CqlDate cm_ = context.Operators.Add(ck_, cl_);
						CqlDate co_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						CqlDate cq_ = context.Operators.Add(co_, cl_);
						CqlQuantity cr_ = context.Operators.Quantity(1m, "year");
						CqlDate cs_ = context.Operators.Add(cq_, cr_);
						CqlInterval<CqlDate> ct_ = context.Operators.Interval(cm_, cs_, true, false);

						return ct_;
					}
					else if (onset is Range)
					{
						Patient cu_ = this.Patient();
						CqlDate cv_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						CqlQuantity cw_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low);
						CqlDate cx_ = context.Operators.Add(cv_, cw_);
						CqlDate cz_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						CqlQuantity da_ = FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High);
						CqlDate db_ = context.Operators.Add(cz_, da_);
						CqlQuantity dc_ = context.Operators.Quantity(1m, "year");
						CqlDate dd_ = context.Operators.Add(db_, dc_);
						CqlInterval<CqlDate> de_ = context.Operators.Interval(cx_, dd_, true, false);

						return de_;
					}
					else
					{
						CqlInterval<CqlDate> df_ = null;

						return df_;
					};
				};
				CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, p_()?.lowClosed, q_()?.highClosed);

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
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (abatement is Period)
			{
				FhirDateTime e_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
				CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
				FhirDateTime g_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
				CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
				CqlInterval<CqlDateTime> i_ = context.Operators.Interval(f_, h_, true, true);

				return i_;
			}
			else if (abatement is FhirString)
			{
				CqlInterval<CqlDateTime> j_ = null;
				CqlInterval<CqlDateTime> k_ = context.Operators.Message<CqlInterval<CqlDateTime>>(j_, "1", "Error", "Cannot compute an interval from a String value");

				return k_;
			}
			else
			{
				CqlInterval<CqlDate> l_()
				{
					if (abatement is Age)
					{
						Patient s_ = this.Patient();
						CqlDate t_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						CqlQuantity u_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						CqlDate v_ = context.Operators.Add(t_, u_);
						CqlDate x_ = FHIRHelpers_4_0_001.ToDate(s_?.BirthDateElement);
						CqlDate z_ = context.Operators.Add(x_, u_);
						CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
						CqlDate ab_ = context.Operators.Add(z_, aa_);
						CqlInterval<CqlDate> ac_ = context.Operators.Interval(v_, ab_, true, false);

						return ac_;
					}
					else if (abatement is Range)
					{
						Patient ad_ = this.Patient();
						CqlDate ae_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						CqlQuantity af_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						CqlDate ag_ = context.Operators.Add(ae_, af_);
						CqlDate ai_ = FHIRHelpers_4_0_001.ToDate(ad_?.BirthDateElement);
						CqlQuantity aj_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						CqlDate ak_ = context.Operators.Add(ai_, aj_);
						CqlQuantity al_ = context.Operators.Quantity(1m, "year");
						CqlDate am_ = context.Operators.Add(ak_, al_);
						CqlInterval<CqlDate> an_ = context.Operators.Interval(ag_, am_, true, false);

						return an_;
					}
					else
					{
						CqlInterval<CqlDate> ao_ = null;

						return ao_;
					};
				};
				CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_()?.low);
				CqlInterval<CqlDate> n_()
				{
					if (abatement is Age)
					{
						Patient ap_ = this.Patient();
						CqlDate aq_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						CqlQuantity ar_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						CqlDate as_ = context.Operators.Add(aq_, ar_);
						CqlDate au_ = FHIRHelpers_4_0_001.ToDate(ap_?.BirthDateElement);
						CqlDate aw_ = context.Operators.Add(au_, ar_);
						CqlQuantity ax_ = context.Operators.Quantity(1m, "year");
						CqlDate ay_ = context.Operators.Add(aw_, ax_);
						CqlInterval<CqlDate> az_ = context.Operators.Interval(as_, ay_, true, false);

						return az_;
					}
					else if (abatement is Range)
					{
						Patient ba_ = this.Patient();
						CqlDate bb_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						CqlQuantity bc_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						CqlDate bd_ = context.Operators.Add(bb_, bc_);
						CqlDate bf_ = FHIRHelpers_4_0_001.ToDate(ba_?.BirthDateElement);
						CqlQuantity bg_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						CqlDate bh_ = context.Operators.Add(bf_, bg_);
						CqlQuantity bi_ = context.Operators.Quantity(1m, "year");
						CqlDate bj_ = context.Operators.Add(bh_, bi_);
						CqlInterval<CqlDate> bk_ = context.Operators.Interval(bd_, bj_, true, false);

						return bk_;
					}
					else
					{
						CqlInterval<CqlDate> bl_ = null;

						return bl_;
					};
				};
				CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_()?.high);
				CqlInterval<CqlDate> p_()
				{
					if (abatement is Age)
					{
						Patient bm_ = this.Patient();
						CqlDate bn_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						CqlQuantity bo_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						CqlDate bp_ = context.Operators.Add(bn_, bo_);
						CqlDate br_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
						CqlDate bt_ = context.Operators.Add(br_, bo_);
						CqlQuantity bu_ = context.Operators.Quantity(1m, "year");
						CqlDate bv_ = context.Operators.Add(bt_, bu_);
						CqlInterval<CqlDate> bw_ = context.Operators.Interval(bp_, bv_, true, false);

						return bw_;
					}
					else if (abatement is Range)
					{
						Patient bx_ = this.Patient();
						CqlDate by_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						CqlQuantity bz_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						CqlDate ca_ = context.Operators.Add(by_, bz_);
						CqlDate cc_ = FHIRHelpers_4_0_001.ToDate(bx_?.BirthDateElement);
						CqlQuantity cd_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						CqlDate ce_ = context.Operators.Add(cc_, cd_);
						CqlQuantity cf_ = context.Operators.Quantity(1m, "year");
						CqlDate cg_ = context.Operators.Add(ce_, cf_);
						CqlInterval<CqlDate> ch_ = context.Operators.Interval(ca_, cg_, true, false);

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
						Patient cj_ = this.Patient();
						CqlDate ck_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						CqlQuantity cl_ = FHIRHelpers_4_0_001.ToQuantity(((abatement as Age) as Quantity));
						CqlDate cm_ = context.Operators.Add(ck_, cl_);
						CqlDate co_ = FHIRHelpers_4_0_001.ToDate(cj_?.BirthDateElement);
						CqlDate cq_ = context.Operators.Add(co_, cl_);
						CqlQuantity cr_ = context.Operators.Quantity(1m, "year");
						CqlDate cs_ = context.Operators.Add(cq_, cr_);
						CqlInterval<CqlDate> ct_ = context.Operators.Interval(cm_, cs_, true, false);

						return ct_;
					}
					else if (abatement is Range)
					{
						Patient cu_ = this.Patient();
						CqlDate cv_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						CqlQuantity cw_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low);
						CqlDate cx_ = context.Operators.Add(cv_, cw_);
						CqlDate cz_ = FHIRHelpers_4_0_001.ToDate(cu_?.BirthDateElement);
						CqlQuantity da_ = FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High);
						CqlDate db_ = context.Operators.Add(cz_, da_);
						CqlQuantity dc_ = context.Operators.Quantity(1m, "year");
						CqlDate dd_ = context.Operators.Add(db_, dc_);
						CqlInterval<CqlDate> de_ = context.Operators.Interval(cx_, dd_, true, false);

						return de_;
					}
					else
					{
						CqlInterval<CqlDate> df_ = null;

						return df_;
					};
				};
				CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, p_()?.lowClosed, q_()?.highClosed);

				return r_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		CqlInterval<CqlDateTime> a_ = this.Normalize_Onset(condition?.Onset);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlInterval<CqlDateTime> c_ = this.Normalize_Abatement(condition?.Abatement);
		CqlDateTime d_ = context.Operators.End(c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Date)
			{
				CqlDate e_ = FHIRHelpers_4_0_001.ToDate((choice as Date));
				CqlDateTime f_ = context.Operators.ConvertDateToDateTime(e_);
				CqlDateTime h_ = context.Operators.ConvertDateToDateTime(e_);
				CqlInterval<CqlDateTime> i_ = context.Operators.Interval(f_, h_, true, true);

				return i_;
			}
			else if (choice is Period)
			{
				FhirDateTime j_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
				CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
				FhirDateTime l_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
				CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, true, true);

				return n_;
			}
			else if (choice is Instant)
			{
				CqlDateTime o_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, o_, true, true);

				return q_;
			}
			else if (choice is Age)
			{
				Patient r_ = this.Patient();
				CqlDate s_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlQuantity t_ = FHIRHelpers_4_0_001.ToQuantity(((choice as Age) as Quantity));
				CqlDate u_ = context.Operators.Add(s_, t_);
				CqlDate w_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlDate y_ = context.Operators.Add(w_, t_);
				CqlQuantity z_ = context.Operators.Quantity(1m, "year");
				CqlDate aa_ = context.Operators.Add(y_, z_);
				CqlInterval<CqlDate> ab_ = context.Operators.Interval(u_, aa_, true, false);
				CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_?.low);
				CqlDate ae_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlDate ag_ = context.Operators.Add(ae_, t_);
				CqlDate ai_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlDate ak_ = context.Operators.Add(ai_, t_);
				CqlDate am_ = context.Operators.Add(ak_, z_);
				CqlInterval<CqlDate> an_ = context.Operators.Interval(ag_, am_, true, false);
				CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_?.high);
				CqlDate aq_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlDate as_ = context.Operators.Add(aq_, t_);
				CqlDate au_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlDate aw_ = context.Operators.Add(au_, t_);
				CqlDate ay_ = context.Operators.Add(aw_, z_);
				CqlInterval<CqlDate> az_ = context.Operators.Interval(as_, ay_, true, false);
				CqlDate bb_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlDate bd_ = context.Operators.Add(bb_, t_);
				CqlDate bf_ = FHIRHelpers_4_0_001.ToDate(r_?.BirthDateElement);
				CqlDate bh_ = context.Operators.Add(bf_, t_);
				CqlDate bj_ = context.Operators.Add(bh_, z_);
				CqlInterval<CqlDate> bk_ = context.Operators.Interval(bd_, bj_, true, false);
				CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(ac_, ao_, az_?.lowClosed, bk_?.highClosed);

				return bl_;
			}
			else if (choice is Range)
			{
				Patient bm_ = this.Patient();
				CqlDate bn_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlQuantity bo_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.Low);
				CqlDate bp_ = context.Operators.Add(bn_, bo_);
				CqlDate br_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlQuantity bs_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.High);
				CqlDate bt_ = context.Operators.Add(br_, bs_);
				CqlQuantity bu_ = context.Operators.Quantity(1m, "year");
				CqlDate bv_ = context.Operators.Add(bt_, bu_);
				CqlInterval<CqlDate> bw_ = context.Operators.Interval(bp_, bv_, true, false);
				CqlDateTime bx_ = context.Operators.ConvertDateToDateTime(bw_?.low);
				CqlDate bz_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlDate cb_ = context.Operators.Add(bz_, bo_);
				CqlDate cd_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlDate cf_ = context.Operators.Add(cd_, bs_);
				CqlDate ch_ = context.Operators.Add(cf_, bu_);
				CqlInterval<CqlDate> ci_ = context.Operators.Interval(cb_, ch_, true, false);
				CqlDateTime cj_ = context.Operators.ConvertDateToDateTime(ci_?.high);
				CqlDate cl_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlDate cn_ = context.Operators.Add(cl_, bo_);
				CqlDate cp_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlDate cr_ = context.Operators.Add(cp_, bs_);
				CqlDate ct_ = context.Operators.Add(cr_, bu_);
				CqlInterval<CqlDate> cu_ = context.Operators.Interval(cn_, ct_, true, false);
				CqlDate cw_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlDate cy_ = context.Operators.Add(cw_, bo_);
				CqlDate da_ = FHIRHelpers_4_0_001.ToDate(bm_?.BirthDateElement);
				CqlDate dc_ = context.Operators.Add(da_, bs_);
				CqlDate de_ = context.Operators.Add(dc_, bu_);
				CqlInterval<CqlDate> df_ = context.Operators.Interval(cy_, de_, true, false);
				CqlInterval<CqlDateTime> dg_ = context.Operators.Interval(bx_, cj_, cu_?.lowClosed, df_?.highClosed);

				return dg_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> dh_ = null;
				CqlInterval<CqlDateTime> di_ = context.Operators.Message<CqlInterval<CqlDateTime>>(dh_, "1", "Error", "Cannot compute a single interval from a Timing type");

				return di_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> dj_ = null;
				CqlInterval<CqlDateTime> dk_ = context.Operators.Message<CqlInterval<CqlDateTime>>(dj_, "1", "Error", "Cannot compute an interval from a String value");

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
				int? c_ = context.Operators.PositionOf("/", uri);
				bool? d_ = context.Operators.Greater(c_, 0);

				return (d_ ?? false);
			};
			if (b_())
			{
				IEnumerable<string> e_ = context.Operators.Split(uri, "/");
				string f_ = context.Operators.Last<string>(e_);

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
		IEnumerable<CqlDate> b_ = context.Operators.Select<CqlDate, CqlDate>(DateList, a_);
		IEnumerable<CqlDate> c_ = context.Operators.ListSort<CqlDate>(b_, System.ComponentModel.ListSortDirection.Ascending);
		bool? d_(CqlDate X)
		{
			bool? k_ = context.Operators.Not((bool?)(X is null));

			return k_;
		};
		IEnumerable<CqlDate> e_ = context.Operators.Where<CqlDate>(c_, d_);
		Tuple_GcLaDggiecCUAgUhQSXhADYJf f_ = new Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = e_,
		};
		Tuple_GcLaDggiecCUAgUhQSXhADYJf[] g_ = new Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			f_,
		};
		Tuple_DUDddjZaCdFGjLXVHKdDKIRfT h_(Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates)
		{
			Tuple_GTiMeVaPZjPXLPBaGARAOCFd l_ = new Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = SortedDates?.SortedDates,
				AnchorIndex = 0,
			};
			Tuple_GTiMeVaPZjPXLPBaGARAOCFd[] m_ = new Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				l_,
			};
			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT n_(Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList)
			{
				CqlDate q_ = context.Operators.Indexer<CqlDate>(AnchorList?.SortedList, AnchorList?.AnchorIndex);
				bool? r_(CqlDate X)
				{
					CqlDate z_ = context.Operators.Indexer<CqlDate>(AnchorList?.SortedList, AnchorList?.AnchorIndex);
					CqlQuantity aa_ = context.Operators.Quantity(1m, "day");
					CqlDate ab_ = context.Operators.Add(z_, aa_);
					CqlQuantity ad_ = context.Operators.Quantity(30m, "days");
					CqlDate ae_ = context.Operators.Add(z_, ad_);
					CqlInterval<CqlDate> af_ = context.Operators.Interval(ab_, ae_, true, true);
					bool? ag_ = context.Operators.In<CqlDate>(X, af_, null);
					bool? ah_ = context.Operators.Not(ag_);

					return ah_;
				};
				IEnumerable<CqlDate> s_ = context.Operators.Where<CqlDate>(DateList, r_);
				int? t_ = context.Operators.Add(AnchorList?.AnchorIndex, 1);
				Tuple_DUDddjZaCdFGjLXVHKdDKIRfT u_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = q_,
					NewList = s_,
					IndexofNewDate = t_,
				};
				Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] v_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
							CqlDate aj_ = context.Operators.Indexer<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate);
							bool? ak_(CqlDate X)
							{
								CqlDate as_ = context.Operators.Indexer<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate);
								CqlQuantity at_ = context.Operators.Quantity(1m, "day");
								CqlDate au_ = context.Operators.Add(as_, at_);
								CqlQuantity aw_ = context.Operators.Quantity(30m, "days");
								CqlDate ax_ = context.Operators.Add(as_, aw_);
								CqlInterval<CqlDate> ay_ = context.Operators.Interval(au_, ax_, true, true);
								bool? az_ = context.Operators.In<CqlDate>(X, ay_, null);
								bool? ba_ = context.Operators.Not(az_);

								return ba_;
							};
							IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>(FirstList?.NewList, ak_);
							int? am_ = context.Operators.Add(FirstList?.IndexofNewDate, 1);
							Tuple_DUDddjZaCdFGjLXVHKdDKIRfT an_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
							{
								NextDate = aj_,
								NewList = al_,
								IndexofNewDate = am_,
							};
							Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] ao_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
										CqlDate bc_ = context.Operators.Indexer<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate);
										bool? bd_(CqlDate X)
										{
											CqlDate bl_ = context.Operators.Indexer<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate);
											CqlQuantity bm_ = context.Operators.Quantity(1m, "day");
											CqlDate bn_ = context.Operators.Add(bl_, bm_);
											CqlQuantity bp_ = context.Operators.Quantity(30m, "days");
											CqlDate bq_ = context.Operators.Add(bl_, bp_);
											CqlInterval<CqlDate> br_ = context.Operators.Interval(bn_, bq_, true, true);
											bool? bs_ = context.Operators.In<CqlDate>(X, br_, null);
											bool? bt_ = context.Operators.Not(bs_);

											return bt_;
										};
										IEnumerable<CqlDate> be_ = context.Operators.Where<CqlDate>(SecondList?.NewList, bd_);
										int? bf_ = context.Operators.Add(SecondList?.IndexofNewDate, 1);
										Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bg_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
										{
											NextDate = bc_,
											NewList = be_,
											IndexofNewDate = bf_,
										};
										Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] bh_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
													CqlDate bv_ = context.Operators.Indexer<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate);
													bool? bw_(CqlDate X)
													{
														CqlDate ce_ = context.Operators.Indexer<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate);
														CqlQuantity cf_ = context.Operators.Quantity(1m, "day");
														CqlDate cg_ = context.Operators.Add(ce_, cf_);
														CqlQuantity ci_ = context.Operators.Quantity(30m, "days");
														CqlDate cj_ = context.Operators.Add(ce_, ci_);
														CqlInterval<CqlDate> ck_ = context.Operators.Interval(cg_, cj_, true, true);
														bool? cl_ = context.Operators.In<CqlDate>(X, ck_, null);
														bool? cm_ = context.Operators.Not(cl_);

														return cm_;
													};
													IEnumerable<CqlDate> bx_ = context.Operators.Where<CqlDate>(ThirdList?.NewList, bw_);
													int? by_ = context.Operators.Add(ThirdList?.IndexofNewDate, 1);
													Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bz_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = bv_,
														NewList = bx_,
														IndexofNewDate = by_,
													};
													Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] ca_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																CqlDate co_ = context.Operators.Indexer<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate);
																bool? cp_(CqlDate X)
																{
																	CqlDate cx_ = context.Operators.Indexer<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate);
																	CqlQuantity cy_ = context.Operators.Quantity(1m, "day");
																	CqlDate cz_ = context.Operators.Add(cx_, cy_);
																	CqlQuantity db_ = context.Operators.Quantity(30m, "days");
																	CqlDate dc_ = context.Operators.Add(cx_, db_);
																	CqlInterval<CqlDate> dd_ = context.Operators.Interval(cz_, dc_, true, true);
																	bool? de_ = context.Operators.In<CqlDate>(X, dd_, null);
																	bool? df_ = context.Operators.Not(de_);

																	return df_;
																};
																IEnumerable<CqlDate> cq_ = context.Operators.Where<CqlDate>(FourthList?.NewList, cp_);
																int? cr_ = context.Operators.Add(FourthList?.IndexofNewDate, 1);
																Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cs_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																{
																	NextDate = co_,
																	NewList = cq_,
																	IndexofNewDate = cr_,
																};
																Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] ct_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																			CqlDate dh_ = context.Operators.Indexer<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate);
																			bool? di_(CqlDate X)
																			{
																				CqlDate dq_ = context.Operators.Indexer<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate);
																				CqlQuantity dr_ = context.Operators.Quantity(1m, "day");
																				CqlDate ds_ = context.Operators.Add(dq_, dr_);
																				CqlQuantity du_ = context.Operators.Quantity(30m, "days");
																				CqlDate dv_ = context.Operators.Add(dq_, du_);
																				CqlInterval<CqlDate> dw_ = context.Operators.Interval(ds_, dv_, true, true);
																				bool? dx_ = context.Operators.In<CqlDate>(X, dw_, null);
																				bool? dy_ = context.Operators.Not(dx_);

																				return dy_;
																			};
																			IEnumerable<CqlDate> dj_ = context.Operators.Where<CqlDate>(FifthList?.NewList, di_);
																			int? dk_ = context.Operators.Add(FifthList?.IndexofNewDate, 1);
																			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dl_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																			{
																				NextDate = dh_,
																				NewList = dj_,
																				IndexofNewDate = dk_,
																			};
																			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] dm_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																						CqlDate ea_ = context.Operators.Indexer<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate);
																						bool? eb_(CqlDate X)
																						{
																							CqlDate ej_ = context.Operators.Indexer<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate);
																							CqlQuantity ek_ = context.Operators.Quantity(1m, "day");
																							CqlDate el_ = context.Operators.Add(ej_, ek_);
																							CqlQuantity en_ = context.Operators.Quantity(30m, "days");
																							CqlDate eo_ = context.Operators.Add(ej_, en_);
																							CqlInterval<CqlDate> ep_ = context.Operators.Interval(el_, eo_, true, true);
																							bool? eq_ = context.Operators.In<CqlDate>(X, ep_, null);
																							bool? er_ = context.Operators.Not(eq_);

																							return er_;
																						};
																						IEnumerable<CqlDate> ec_ = context.Operators.Where<CqlDate>(SixthList?.NewList, eb_);
																						int? ed_ = context.Operators.Add(SixthList?.IndexofNewDate, 1);
																						Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ee_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																						{
																							NextDate = ea_,
																							NewList = ec_,
																							IndexofNewDate = ed_,
																						};
																						Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] ef_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																									CqlDate et_ = context.Operators.Indexer<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate);
																									bool? eu_(CqlDate X)
																									{
																										CqlDate fc_ = context.Operators.Indexer<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate);
																										CqlQuantity fd_ = context.Operators.Quantity(1m, "day");
																										CqlDate fe_ = context.Operators.Add(fc_, fd_);
																										CqlQuantity fg_ = context.Operators.Quantity(30m, "days");
																										CqlDate fh_ = context.Operators.Add(fc_, fg_);
																										CqlInterval<CqlDate> fi_ = context.Operators.Interval(fe_, fh_, true, true);
																										bool? fj_ = context.Operators.In<CqlDate>(X, fi_, null);
																										bool? fk_ = context.Operators.Not(fj_);

																										return fk_;
																									};
																									IEnumerable<CqlDate> ev_ = context.Operators.Where<CqlDate>(SeventhList?.NewList, eu_);
																									int? ew_ = context.Operators.Add(SeventhList?.IndexofNewDate, 1);
																									Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ex_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = et_,
																										NewList = ev_,
																										IndexofNewDate = ew_,
																									};
																									Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] ey_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																												CqlDate fm_ = context.Operators.Indexer<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate);
																												bool? fn_(CqlDate X)
																												{
																													CqlDate fv_ = context.Operators.Indexer<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate);
																													CqlQuantity fw_ = context.Operators.Quantity(1m, "day");
																													CqlDate fx_ = context.Operators.Add(fv_, fw_);
																													CqlQuantity fz_ = context.Operators.Quantity(30m, "days");
																													CqlDate ga_ = context.Operators.Add(fv_, fz_);
																													CqlInterval<CqlDate> gb_ = context.Operators.Interval(fx_, ga_, true, true);
																													bool? gc_ = context.Operators.In<CqlDate>(X, gb_, null);
																													bool? gd_ = context.Operators.Not(gc_);

																													return gd_;
																												};
																												IEnumerable<CqlDate> fo_ = context.Operators.Where<CqlDate>(EighthList?.NewList, fn_);
																												int? fp_ = context.Operators.Add(EighthList?.IndexofNewDate, 1);
																												Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fq_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																												{
																													NextDate = fm_,
																													NewList = fo_,
																													IndexofNewDate = fp_,
																												};
																												Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] fr_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																															CqlDate gf_ = context.Operators.Indexer<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate);
																															bool? gg_(CqlDate X)
																															{
																																CqlDate go_ = context.Operators.Indexer<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate);
																																CqlQuantity gp_ = context.Operators.Quantity(1m, "day");
																																CqlDate gq_ = context.Operators.Add(go_, gp_);
																																CqlQuantity gs_ = context.Operators.Quantity(30m, "days");
																																CqlDate gt_ = context.Operators.Add(go_, gs_);
																																CqlInterval<CqlDate> gu_ = context.Operators.Interval(gq_, gt_, true, true);
																																bool? gv_ = context.Operators.In<CqlDate>(X, gu_, null);
																																bool? gw_ = context.Operators.Not(gv_);

																																return gw_;
																															};
																															IEnumerable<CqlDate> gh_ = context.Operators.Where<CqlDate>(NinethList?.NewList, gg_);
																															int? gi_ = context.Operators.Add(NinethList?.IndexofNewDate, 1);
																															Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gj_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																															{
																																NextDate = gf_,
																																NewList = gh_,
																																IndexofNewDate = gi_,
																															};
																															Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] gk_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																																		CqlDate gy_ = context.Operators.Indexer<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate);
																																		bool? gz_(CqlDate X)
																																		{
																																			CqlDate hh_ = context.Operators.Indexer<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate);
																																			CqlQuantity hi_ = context.Operators.Quantity(1m, "day");
																																			CqlDate hj_ = context.Operators.Add(hh_, hi_);
																																			CqlQuantity hl_ = context.Operators.Quantity(30m, "days");
																																			CqlDate hm_ = context.Operators.Add(hh_, hl_);
																																			CqlInterval<CqlDate> hn_ = context.Operators.Interval(hj_, hm_, true, true);
																																			bool? ho_ = context.Operators.In<CqlDate>(X, hn_, null);
																																			bool? hp_ = context.Operators.Not(ho_);

																																			return hp_;
																																		};
																																		IEnumerable<CqlDate> ha_ = context.Operators.Where<CqlDate>(TenthList?.NewList, gz_);
																																		int? hb_ = context.Operators.Add(TenthList?.IndexofNewDate, 1);
																																		Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hc_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																		{
																																			NextDate = gy_,
																																			NewList = ha_,
																																			IndexofNewDate = hb_,
																																		};
																																		Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[] hd_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
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
																																					CqlDate hr_ = context.Operators.Indexer<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate);
																																					bool? hs_(CqlDate X)
																																					{
																																						CqlDate hw_ = context.Operators.Indexer<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate);
																																						CqlQuantity hx_ = context.Operators.Quantity(1m, "day");
																																						CqlDate hy_ = context.Operators.Add(hw_, hx_);
																																						CqlQuantity ia_ = context.Operators.Quantity(30m, "days");
																																						CqlDate ib_ = context.Operators.Add(hw_, ia_);
																																						CqlInterval<CqlDate> ic_ = context.Operators.Interval(hy_, ib_, true, true);
																																						bool? id_ = context.Operators.In<CqlDate>(X, ic_, null);
																																						bool? ie_ = context.Operators.Not(id_);

																																						return ie_;
																																					};
																																					IEnumerable<CqlDate> ht_ = context.Operators.Where<CqlDate>(EleventhList?.NewList, hs_);
																																					int? hu_ = context.Operators.Add(EleventhList?.IndexofNewDate, 1);
																																					Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hv_ = new Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
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
																																		IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> hf_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hd_, he_);
																																		Tuple_DUDddjZaCdFGjLXVHKdDKIRfT hg_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(hf_);

																																		return hg_;
																																	};
																																};

																																return gx_();
																															};
																															IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> gm_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gk_, gl_);
																															Tuple_DUDddjZaCdFGjLXVHKdDKIRfT gn_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(gm_);

																															return gn_;
																														};
																													};

																													return ge_();
																												};
																												IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> ft_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fr_, fs_);
																												Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fu_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ft_);

																												return fu_;
																											};
																										};

																										return fl_();
																									};
																									IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> fa_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ey_, ez_);
																									Tuple_DUDddjZaCdFGjLXVHKdDKIRfT fb_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(fa_);

																									return fb_;
																								};
																							};

																							return es_();
																						};
																						IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> eh_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ef_, eg_);
																						Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ei_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(eh_);

																						return ei_;
																					};
																				};

																				return dz_();
																			};
																			IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> do_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(dm_, dn_);
																			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT dp_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(do_);

																			return dp_;
																		};
																	};

																	return dg_();
																};
																IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> cv_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ct_, cu_);
																Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cw_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cv_);

																return cw_;
															};
														};

														return cn_();
													};
													IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> cc_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ca_, cb_);
													Tuple_DUDddjZaCdFGjLXVHKdDKIRfT cd_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(cc_);

													return cd_;
												};
											};

											return bu_();
										};
										IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> bj_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(bh_, bi_);
										Tuple_DUDddjZaCdFGjLXVHKdDKIRfT bk_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(bj_);

										return bk_;
									};
								};

								return bb_();
							};
							IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> aq_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ao_, ap_);
							Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ar_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(aq_);

							return ar_;
						};
					};

					return ai_();
				};
				IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> x_ = context.Operators.Select<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(v_, w_);
				Tuple_DUDddjZaCdFGjLXVHKdDKIRfT y_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(x_);

				return y_;
			};
			IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> o_ = context.Operators.Select<Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(m_, n_);
			Tuple_DUDddjZaCdFGjLXVHKdDKIRfT p_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(o_);

			return p_;
		};
		IEnumerable<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> i_ = context.Operators.Select<Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(g_, h_);
		Tuple_DUDddjZaCdFGjLXVHKdDKIRfT j_ = context.Operators.SingletonFrom<Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(i_);

		return j_;
	}

}
