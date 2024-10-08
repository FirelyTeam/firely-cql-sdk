using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
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
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime(onset as FhirDateTime);
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
				CqlInterval<CqlDateTime> j_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

				return j_;
			}
			else
			{
				CqlInterval<CqlDate> k_()
				{
					if (onset is Age)
					{
						Patient v_ = this.Patient();
						Date w_ = v_?.BirthDateElement;
						CqlDate x_ = FHIRHelpers_4_0_001.ToDate(w_);
						CqlQuantity y_ = FHIRHelpers_4_0_001.ToQuantity(onset as Age);
						CqlDate z_ = context.Operators.Add(x_, y_);
						Date ab_ = v_?.BirthDateElement;
						CqlDate ac_ = FHIRHelpers_4_0_001.ToDate(ab_);
						CqlDate ae_ = context.Operators.Add(ac_, y_);
						CqlQuantity af_ = context.Operators.Quantity(1m, "year");
						CqlDate ag_ = context.Operators.Add(ae_, af_);
						CqlInterval<CqlDate> ah_ = context.Operators.Interval(z_, ag_, true, false);

						return ah_;
					}
					else if (onset is Range)
					{
						Patient ai_ = this.Patient();
						Date aj_ = ai_?.BirthDateElement;
						CqlDate ak_ = FHIRHelpers_4_0_001.ToDate(aj_);
						Quantity al_ = (onset as Range)?.Low;
						CqlQuantity am_ = FHIRHelpers_4_0_001.ToQuantity(al_);
						CqlDate an_ = context.Operators.Add(ak_, am_);
						Date ap_ = ai_?.BirthDateElement;
						CqlDate aq_ = FHIRHelpers_4_0_001.ToDate(ap_);
						Quantity ar_ = (onset as Range)?.High;
						CqlQuantity as_ = FHIRHelpers_4_0_001.ToQuantity(ar_);
						CqlDate at_ = context.Operators.Add(aq_, as_);
						CqlQuantity au_ = context.Operators.Quantity(1m, "year");
						CqlDate av_ = context.Operators.Add(at_, au_);
						CqlInterval<CqlDate> aw_ = context.Operators.Interval(an_, av_, true, false);

						return aw_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				CqlDate l_ = (k_())?.low;
				CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
				CqlInterval<CqlDate> n_()
				{
					if (onset is Age)
					{
						Patient ax_ = this.Patient();
						Date ay_ = ax_?.BirthDateElement;
						CqlDate az_ = FHIRHelpers_4_0_001.ToDate(ay_);
						CqlQuantity ba_ = FHIRHelpers_4_0_001.ToQuantity(onset as Age);
						CqlDate bb_ = context.Operators.Add(az_, ba_);
						Date bd_ = ax_?.BirthDateElement;
						CqlDate be_ = FHIRHelpers_4_0_001.ToDate(bd_);
						CqlDate bg_ = context.Operators.Add(be_, ba_);
						CqlQuantity bh_ = context.Operators.Quantity(1m, "year");
						CqlDate bi_ = context.Operators.Add(bg_, bh_);
						CqlInterval<CqlDate> bj_ = context.Operators.Interval(bb_, bi_, true, false);

						return bj_;
					}
					else if (onset is Range)
					{
						Patient bk_ = this.Patient();
						Date bl_ = bk_?.BirthDateElement;
						CqlDate bm_ = FHIRHelpers_4_0_001.ToDate(bl_);
						Quantity bn_ = (onset as Range)?.Low;
						CqlQuantity bo_ = FHIRHelpers_4_0_001.ToQuantity(bn_);
						CqlDate bp_ = context.Operators.Add(bm_, bo_);
						Date br_ = bk_?.BirthDateElement;
						CqlDate bs_ = FHIRHelpers_4_0_001.ToDate(br_);
						Quantity bt_ = (onset as Range)?.High;
						CqlQuantity bu_ = FHIRHelpers_4_0_001.ToQuantity(bt_);
						CqlDate bv_ = context.Operators.Add(bs_, bu_);
						CqlQuantity bw_ = context.Operators.Quantity(1m, "year");
						CqlDate bx_ = context.Operators.Add(bv_, bw_);
						CqlInterval<CqlDate> by_ = context.Operators.Interval(bp_, bx_, true, false);

						return by_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				CqlDate o_ = (n_())?.high;
				CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
				CqlInterval<CqlDate> q_()
				{
					if (onset is Age)
					{
						Patient bz_ = this.Patient();
						Date ca_ = bz_?.BirthDateElement;
						CqlDate cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
						CqlQuantity cc_ = FHIRHelpers_4_0_001.ToQuantity(onset as Age);
						CqlDate cd_ = context.Operators.Add(cb_, cc_);
						Date cf_ = bz_?.BirthDateElement;
						CqlDate cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
						CqlDate ci_ = context.Operators.Add(cg_, cc_);
						CqlQuantity cj_ = context.Operators.Quantity(1m, "year");
						CqlDate ck_ = context.Operators.Add(ci_, cj_);
						CqlInterval<CqlDate> cl_ = context.Operators.Interval(cd_, ck_, true, false);

						return cl_;
					}
					else if (onset is Range)
					{
						Patient cm_ = this.Patient();
						Date cn_ = cm_?.BirthDateElement;
						CqlDate co_ = FHIRHelpers_4_0_001.ToDate(cn_);
						Quantity cp_ = (onset as Range)?.Low;
						CqlQuantity cq_ = FHIRHelpers_4_0_001.ToQuantity(cp_);
						CqlDate cr_ = context.Operators.Add(co_, cq_);
						Date ct_ = cm_?.BirthDateElement;
						CqlDate cu_ = FHIRHelpers_4_0_001.ToDate(ct_);
						Quantity cv_ = (onset as Range)?.High;
						CqlQuantity cw_ = FHIRHelpers_4_0_001.ToQuantity(cv_);
						CqlDate cx_ = context.Operators.Add(cu_, cw_);
						CqlQuantity cy_ = context.Operators.Quantity(1m, "year");
						CqlDate cz_ = context.Operators.Add(cx_, cy_);
						CqlInterval<CqlDate> da_ = context.Operators.Interval(cr_, cz_, true, false);

						return da_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				bool? r_ = (q_())?.lowClosed;
				CqlInterval<CqlDate> s_()
				{
					if (onset is Age)
					{
						Patient db_ = this.Patient();
						Date dc_ = db_?.BirthDateElement;
						CqlDate dd_ = FHIRHelpers_4_0_001.ToDate(dc_);
						CqlQuantity de_ = FHIRHelpers_4_0_001.ToQuantity(onset as Age);
						CqlDate df_ = context.Operators.Add(dd_, de_);
						Date dh_ = db_?.BirthDateElement;
						CqlDate di_ = FHIRHelpers_4_0_001.ToDate(dh_);
						CqlDate dk_ = context.Operators.Add(di_, de_);
						CqlQuantity dl_ = context.Operators.Quantity(1m, "year");
						CqlDate dm_ = context.Operators.Add(dk_, dl_);
						CqlInterval<CqlDate> dn_ = context.Operators.Interval(df_, dm_, true, false);

						return dn_;
					}
					else if (onset is Range)
					{
						Patient do_ = this.Patient();
						Date dp_ = do_?.BirthDateElement;
						CqlDate dq_ = FHIRHelpers_4_0_001.ToDate(dp_);
						Quantity dr_ = (onset as Range)?.Low;
						CqlQuantity ds_ = FHIRHelpers_4_0_001.ToQuantity(dr_);
						CqlDate dt_ = context.Operators.Add(dq_, ds_);
						Date dv_ = do_?.BirthDateElement;
						CqlDate dw_ = FHIRHelpers_4_0_001.ToDate(dv_);
						Quantity dx_ = (onset as Range)?.High;
						CqlQuantity dy_ = FHIRHelpers_4_0_001.ToQuantity(dx_);
						CqlDate dz_ = context.Operators.Add(dw_, dy_);
						CqlQuantity ea_ = context.Operators.Quantity(1m, "year");
						CqlDate eb_ = context.Operators.Add(dz_, ea_);
						CqlInterval<CqlDate> ec_ = context.Operators.Interval(dt_, eb_, true, false);

						return ec_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				bool? t_ = (s_())?.highClosed;
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(m_, p_, r_, t_);

				return u_;
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
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime(abatement as FhirDateTime);
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
				CqlInterval<CqlDateTime> j_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

				return j_;
			}
			else
			{
				CqlInterval<CqlDate> k_()
				{
					if (abatement is Age)
					{
						Patient v_ = this.Patient();
						Date w_ = v_?.BirthDateElement;
						CqlDate x_ = FHIRHelpers_4_0_001.ToDate(w_);
						CqlQuantity y_ = FHIRHelpers_4_0_001.ToQuantity(abatement as Age);
						CqlDate z_ = context.Operators.Add(x_, y_);
						Date ab_ = v_?.BirthDateElement;
						CqlDate ac_ = FHIRHelpers_4_0_001.ToDate(ab_);
						CqlDate ae_ = context.Operators.Add(ac_, y_);
						CqlQuantity af_ = context.Operators.Quantity(1m, "year");
						CqlDate ag_ = context.Operators.Add(ae_, af_);
						CqlInterval<CqlDate> ah_ = context.Operators.Interval(z_, ag_, true, false);

						return ah_;
					}
					else if (abatement is Range)
					{
						Patient ai_ = this.Patient();
						Date aj_ = ai_?.BirthDateElement;
						CqlDate ak_ = FHIRHelpers_4_0_001.ToDate(aj_);
						Quantity al_ = (abatement as Range)?.Low;
						CqlQuantity am_ = FHIRHelpers_4_0_001.ToQuantity(al_);
						CqlDate an_ = context.Operators.Add(ak_, am_);
						Date ap_ = ai_?.BirthDateElement;
						CqlDate aq_ = FHIRHelpers_4_0_001.ToDate(ap_);
						Quantity ar_ = (abatement as Range)?.High;
						CqlQuantity as_ = FHIRHelpers_4_0_001.ToQuantity(ar_);
						CqlDate at_ = context.Operators.Add(aq_, as_);
						CqlQuantity au_ = context.Operators.Quantity(1m, "year");
						CqlDate av_ = context.Operators.Add(at_, au_);
						CqlInterval<CqlDate> aw_ = context.Operators.Interval(an_, av_, true, false);

						return aw_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				CqlDate l_ = (k_())?.low;
				CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
				CqlInterval<CqlDate> n_()
				{
					if (abatement is Age)
					{
						Patient ax_ = this.Patient();
						Date ay_ = ax_?.BirthDateElement;
						CqlDate az_ = FHIRHelpers_4_0_001.ToDate(ay_);
						CqlQuantity ba_ = FHIRHelpers_4_0_001.ToQuantity(abatement as Age);
						CqlDate bb_ = context.Operators.Add(az_, ba_);
						Date bd_ = ax_?.BirthDateElement;
						CqlDate be_ = FHIRHelpers_4_0_001.ToDate(bd_);
						CqlDate bg_ = context.Operators.Add(be_, ba_);
						CqlQuantity bh_ = context.Operators.Quantity(1m, "year");
						CqlDate bi_ = context.Operators.Add(bg_, bh_);
						CqlInterval<CqlDate> bj_ = context.Operators.Interval(bb_, bi_, true, false);

						return bj_;
					}
					else if (abatement is Range)
					{
						Patient bk_ = this.Patient();
						Date bl_ = bk_?.BirthDateElement;
						CqlDate bm_ = FHIRHelpers_4_0_001.ToDate(bl_);
						Quantity bn_ = (abatement as Range)?.Low;
						CqlQuantity bo_ = FHIRHelpers_4_0_001.ToQuantity(bn_);
						CqlDate bp_ = context.Operators.Add(bm_, bo_);
						Date br_ = bk_?.BirthDateElement;
						CqlDate bs_ = FHIRHelpers_4_0_001.ToDate(br_);
						Quantity bt_ = (abatement as Range)?.High;
						CqlQuantity bu_ = FHIRHelpers_4_0_001.ToQuantity(bt_);
						CqlDate bv_ = context.Operators.Add(bs_, bu_);
						CqlQuantity bw_ = context.Operators.Quantity(1m, "year");
						CqlDate bx_ = context.Operators.Add(bv_, bw_);
						CqlInterval<CqlDate> by_ = context.Operators.Interval(bp_, bx_, true, false);

						return by_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				CqlDate o_ = (n_())?.high;
				CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
				CqlInterval<CqlDate> q_()
				{
					if (abatement is Age)
					{
						Patient bz_ = this.Patient();
						Date ca_ = bz_?.BirthDateElement;
						CqlDate cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
						CqlQuantity cc_ = FHIRHelpers_4_0_001.ToQuantity(abatement as Age);
						CqlDate cd_ = context.Operators.Add(cb_, cc_);
						Date cf_ = bz_?.BirthDateElement;
						CqlDate cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
						CqlDate ci_ = context.Operators.Add(cg_, cc_);
						CqlQuantity cj_ = context.Operators.Quantity(1m, "year");
						CqlDate ck_ = context.Operators.Add(ci_, cj_);
						CqlInterval<CqlDate> cl_ = context.Operators.Interval(cd_, ck_, true, false);

						return cl_;
					}
					else if (abatement is Range)
					{
						Patient cm_ = this.Patient();
						Date cn_ = cm_?.BirthDateElement;
						CqlDate co_ = FHIRHelpers_4_0_001.ToDate(cn_);
						Quantity cp_ = (abatement as Range)?.Low;
						CqlQuantity cq_ = FHIRHelpers_4_0_001.ToQuantity(cp_);
						CqlDate cr_ = context.Operators.Add(co_, cq_);
						Date ct_ = cm_?.BirthDateElement;
						CqlDate cu_ = FHIRHelpers_4_0_001.ToDate(ct_);
						Quantity cv_ = (abatement as Range)?.High;
						CqlQuantity cw_ = FHIRHelpers_4_0_001.ToQuantity(cv_);
						CqlDate cx_ = context.Operators.Add(cu_, cw_);
						CqlQuantity cy_ = context.Operators.Quantity(1m, "year");
						CqlDate cz_ = context.Operators.Add(cx_, cy_);
						CqlInterval<CqlDate> da_ = context.Operators.Interval(cr_, cz_, true, false);

						return da_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				bool? r_ = (q_())?.lowClosed;
				CqlInterval<CqlDate> s_()
				{
					if (abatement is Age)
					{
						Patient db_ = this.Patient();
						Date dc_ = db_?.BirthDateElement;
						CqlDate dd_ = FHIRHelpers_4_0_001.ToDate(dc_);
						CqlQuantity de_ = FHIRHelpers_4_0_001.ToQuantity(abatement as Age);
						CqlDate df_ = context.Operators.Add(dd_, de_);
						Date dh_ = db_?.BirthDateElement;
						CqlDate di_ = FHIRHelpers_4_0_001.ToDate(dh_);
						CqlDate dk_ = context.Operators.Add(di_, de_);
						CqlQuantity dl_ = context.Operators.Quantity(1m, "year");
						CqlDate dm_ = context.Operators.Add(dk_, dl_);
						CqlInterval<CqlDate> dn_ = context.Operators.Interval(df_, dm_, true, false);

						return dn_;
					}
					else if (abatement is Range)
					{
						Patient do_ = this.Patient();
						Date dp_ = do_?.BirthDateElement;
						CqlDate dq_ = FHIRHelpers_4_0_001.ToDate(dp_);
						Quantity dr_ = (abatement as Range)?.Low;
						CqlQuantity ds_ = FHIRHelpers_4_0_001.ToQuantity(dr_);
						CqlDate dt_ = context.Operators.Add(dq_, ds_);
						Date dv_ = do_?.BirthDateElement;
						CqlDate dw_ = FHIRHelpers_4_0_001.ToDate(dv_);
						Quantity dx_ = (abatement as Range)?.High;
						CqlQuantity dy_ = FHIRHelpers_4_0_001.ToQuantity(dx_);
						CqlDate dz_ = context.Operators.Add(dw_, dy_);
						CqlQuantity ea_ = context.Operators.Quantity(1m, "year");
						CqlDate eb_ = context.Operators.Add(dz_, ea_);
						CqlInterval<CqlDate> ec_ = context.Operators.Interval(dt_, eb_, true, false);

						return ec_;
					}
					else
					{
						return null as CqlInterval<CqlDate>;
					}
				};
				bool? t_ = (s_())?.highClosed;
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(m_, p_, r_, t_);

				return u_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		DataType a_ = condition?.Onset;
		CqlInterval<CqlDateTime> b_ = this.Normalize_Onset(a_);
		CqlDateTime c_ = context.Operators.Start(b_);
		DataType d_ = condition?.Abatement;
		CqlInterval<CqlDateTime> e_ = this.Normalize_Abatement(d_);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlInterval<CqlDateTime> g_ = context.Operators.Interval(c_, f_, true, true);

		return g_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime(choice as FhirDateTime);
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Date)
			{
				CqlDate e_ = FHIRHelpers_4_0_001.ToDate(choice as Date);
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
				CqlDateTime o_ = FHIRHelpers_4_0_001.ToDateTime(choice as Instant);
				CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, o_, true, true);

				return q_;
			}
			else if (choice is Age)
			{
				Patient r_ = this.Patient();
				Date s_ = r_?.BirthDateElement;
				CqlDate t_ = FHIRHelpers_4_0_001.ToDate(s_);
				CqlQuantity u_ = FHIRHelpers_4_0_001.ToQuantity(choice as Age);
				CqlDate v_ = context.Operators.Add(t_, u_);
				Date x_ = r_?.BirthDateElement;
				CqlDate y_ = FHIRHelpers_4_0_001.ToDate(x_);
				CqlDate aa_ = context.Operators.Add(y_, u_);
				CqlQuantity ab_ = context.Operators.Quantity(1m, "year");
				CqlDate ac_ = context.Operators.Add(aa_, ab_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(v_, ac_, true, false);
				CqlDate ae_ = ad_?.low;
				CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
				Date ah_ = r_?.BirthDateElement;
				CqlDate ai_ = FHIRHelpers_4_0_001.ToDate(ah_);
				CqlDate ak_ = context.Operators.Add(ai_, u_);
				Date am_ = r_?.BirthDateElement;
				CqlDate an_ = FHIRHelpers_4_0_001.ToDate(am_);
				CqlDate ap_ = context.Operators.Add(an_, u_);
				CqlDate ar_ = context.Operators.Add(ap_, ab_);
				CqlInterval<CqlDate> as_ = context.Operators.Interval(ak_, ar_, true, false);
				CqlDate at_ = as_?.high;
				CqlDateTime au_ = context.Operators.ConvertDateToDateTime(at_);
				Date aw_ = r_?.BirthDateElement;
				CqlDate ax_ = FHIRHelpers_4_0_001.ToDate(aw_);
				CqlDate az_ = context.Operators.Add(ax_, u_);
				Date bb_ = r_?.BirthDateElement;
				CqlDate bc_ = FHIRHelpers_4_0_001.ToDate(bb_);
				CqlDate be_ = context.Operators.Add(bc_, u_);
				CqlDate bg_ = context.Operators.Add(be_, ab_);
				CqlInterval<CqlDate> bh_ = context.Operators.Interval(az_, bg_, true, false);
				bool? bi_ = bh_?.lowClosed;
				Date bk_ = r_?.BirthDateElement;
				CqlDate bl_ = FHIRHelpers_4_0_001.ToDate(bk_);
				CqlDate bn_ = context.Operators.Add(bl_, u_);
				Date bp_ = r_?.BirthDateElement;
				CqlDate bq_ = FHIRHelpers_4_0_001.ToDate(bp_);
				CqlDate bs_ = context.Operators.Add(bq_, u_);
				CqlDate bu_ = context.Operators.Add(bs_, ab_);
				CqlInterval<CqlDate> bv_ = context.Operators.Interval(bn_, bu_, true, false);
				bool? bw_ = bv_?.highClosed;
				CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(af_, au_, bi_, bw_);

				return bx_;
			}
			else if (choice is Range)
			{
				Patient by_ = this.Patient();
				Date bz_ = by_?.BirthDateElement;
				CqlDate ca_ = FHIRHelpers_4_0_001.ToDate(bz_);
				Quantity cb_ = (choice as Range)?.Low;
				CqlQuantity cc_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				CqlDate cd_ = context.Operators.Add(ca_, cc_);
				Date cf_ = by_?.BirthDateElement;
				CqlDate cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
				Quantity ch_ = (choice as Range)?.High;
				CqlQuantity ci_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				CqlDate cj_ = context.Operators.Add(cg_, ci_);
				CqlQuantity ck_ = context.Operators.Quantity(1m, "year");
				CqlDate cl_ = context.Operators.Add(cj_, ck_);
				CqlInterval<CqlDate> cm_ = context.Operators.Interval(cd_, cl_, true, false);
				CqlDate cn_ = cm_?.low;
				CqlDateTime co_ = context.Operators.ConvertDateToDateTime(cn_);
				Date cq_ = by_?.BirthDateElement;
				CqlDate cr_ = FHIRHelpers_4_0_001.ToDate(cq_);
				CqlQuantity ct_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				CqlDate cu_ = context.Operators.Add(cr_, ct_);
				Date cw_ = by_?.BirthDateElement;
				CqlDate cx_ = FHIRHelpers_4_0_001.ToDate(cw_);
				CqlQuantity cz_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				CqlDate da_ = context.Operators.Add(cx_, cz_);
				CqlDate dc_ = context.Operators.Add(da_, ck_);
				CqlInterval<CqlDate> dd_ = context.Operators.Interval(cu_, dc_, true, false);
				CqlDate de_ = dd_?.high;
				CqlDateTime df_ = context.Operators.ConvertDateToDateTime(de_);
				Date dh_ = by_?.BirthDateElement;
				CqlDate di_ = FHIRHelpers_4_0_001.ToDate(dh_);
				CqlQuantity dk_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				CqlDate dl_ = context.Operators.Add(di_, dk_);
				Date dn_ = by_?.BirthDateElement;
				CqlDate do_ = FHIRHelpers_4_0_001.ToDate(dn_);
				CqlQuantity dq_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				CqlDate dr_ = context.Operators.Add(do_, dq_);
				CqlDate dt_ = context.Operators.Add(dr_, ck_);
				CqlInterval<CqlDate> du_ = context.Operators.Interval(dl_, dt_, true, false);
				bool? dv_ = du_?.lowClosed;
				Date dx_ = by_?.BirthDateElement;
				CqlDate dy_ = FHIRHelpers_4_0_001.ToDate(dx_);
				CqlQuantity ea_ = FHIRHelpers_4_0_001.ToQuantity(cb_);
				CqlDate eb_ = context.Operators.Add(dy_, ea_);
				Date ed_ = by_?.BirthDateElement;
				CqlDate ee_ = FHIRHelpers_4_0_001.ToDate(ed_);
				CqlQuantity eg_ = FHIRHelpers_4_0_001.ToQuantity(ch_);
				CqlDate eh_ = context.Operators.Add(ee_, eg_);
				CqlDate ej_ = context.Operators.Add(eh_, ck_);
				CqlInterval<CqlDate> ek_ = context.Operators.Interval(eb_, ej_, true, false);
				bool? el_ = ek_?.highClosed;
				CqlInterval<CqlDateTime> em_ = context.Operators.Interval(co_, df_, dv_, el_);

				return em_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> en_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

				return en_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> eo_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

				return eo_;
			}
			else
			{
				return null as CqlInterval<CqlDateTime>;
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
				int? c_ = context.Operators.PositionOf("/", uri);
				bool? d_ = context.Operators.Greater(c_, 0);

				return d_ ?? false;
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
		IEnumerable<CqlDate> b_ = context.Operators.Select<CqlDate, CqlDate>(DateList, a_);
		IEnumerable<CqlDate> c_ = context.Operators.ListSort<CqlDate>(b_, System.ComponentModel.ListSortDirection.Ascending);
		bool? d_(CqlDate X)
		{
			bool? k_ = context.Operators.Not((bool?)(X is null));

			return k_;
		};
		IEnumerable<CqlDate> e_ = context.Operators.Where<CqlDate>(c_, d_);
		(IEnumerable<CqlDate> SortedDates, nint _)? f_ = (e_, default);
		(IEnumerable<CqlDate> SortedDates, nint _)?[] g_ = [
			f_,
		];
		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? h_((IEnumerable<CqlDate> SortedDates, nint _)? SortedDates)
		{
			IEnumerable<CqlDate> l_ = SortedDates?.SortedDates;
			(IEnumerable<CqlDate> SortedList, int? AnchorIndex)? m_ = (l_, 0);
			(IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] n_ = [
				m_,
			];
			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? o_((IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
			{
				IEnumerable<CqlDate> r_ = AnchorList?.SortedList;
				int? s_ = AnchorList?.AnchorIndex;
				CqlDate t_ = context.Operators.Indexer<CqlDate>(r_, s_);
				bool? u_(CqlDate X)
				{
					IEnumerable<CqlDate> ad_ = AnchorList?.SortedList;
					int? ae_ = AnchorList?.AnchorIndex;
					CqlDate af_ = context.Operators.Indexer<CqlDate>(ad_, ae_);
					CqlQuantity ag_ = context.Operators.Quantity(1m, "day");
					CqlDate ah_ = context.Operators.Add(af_ as CqlDate, ag_);
					CqlDate ak_ = context.Operators.Indexer<CqlDate>(ad_, ae_);
					CqlQuantity al_ = context.Operators.Quantity(30m, "days");
					CqlDate am_ = context.Operators.Add(ak_ as CqlDate, al_);
					CqlInterval<CqlDate> an_ = context.Operators.Interval(ah_, am_, true, true);
					bool? ao_ = context.Operators.In<CqlDate>(X, an_, default);
					bool? ap_ = context.Operators.Not(ao_);

					return ap_;
				};
				IEnumerable<CqlDate> v_ = context.Operators.Where<CqlDate>(DateList, u_);
				int? x_ = context.Operators.Add(s_, 1);
				(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? y_ = (t_ as CqlDate, v_, x_);
				(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] z_ = [
					y_,
				];
				(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aa_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
				{
					(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aq_()
					{
						bool ar_()
						{
							IEnumerable<CqlDate> as_ = FirstList?.NewList;
							int? at_ = FirstList?.IndexofNewDate;
							CqlDate au_ = context.Operators.Indexer<CqlDate>(as_, at_);

							return au_ is null;
						};
						if (ar_())
						{
							return FirstList;
						}
						else
						{
							IEnumerable<CqlDate> av_ = FirstList?.NewList;
							int? aw_ = FirstList?.IndexofNewDate;
							CqlDate ax_ = context.Operators.Indexer<CqlDate>(av_, aw_);
							bool? az_(CqlDate X)
							{
								IEnumerable<CqlDate> bi_ = FirstList?.NewList;
								int? bj_ = FirstList?.IndexofNewDate;
								CqlDate bk_ = context.Operators.Indexer<CqlDate>(bi_, bj_);
								CqlQuantity bl_ = context.Operators.Quantity(1m, "day");
								CqlDate bm_ = context.Operators.Add(bk_ as CqlDate, bl_);
								CqlDate bp_ = context.Operators.Indexer<CqlDate>(bi_, bj_);
								CqlQuantity bq_ = context.Operators.Quantity(30m, "days");
								CqlDate br_ = context.Operators.Add(bp_ as CqlDate, bq_);
								CqlInterval<CqlDate> bs_ = context.Operators.Interval(bm_, br_, true, true);
								bool? bt_ = context.Operators.In<CqlDate>(X, bs_, default);
								bool? bu_ = context.Operators.Not(bt_);

								return bu_;
							};
							IEnumerable<CqlDate> ba_ = context.Operators.Where<CqlDate>(av_, az_);
							int? bc_ = context.Operators.Add(aw_, 1);
							(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bd_ = (ax_ as CqlDate, ba_, bc_);
							(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] be_ = [
								bd_,
							];
							(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bf_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
							{
								(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bv_()
								{
									bool bw_()
									{
										IEnumerable<CqlDate> bx_ = SecondList?.NewList;
										int? by_ = SecondList?.IndexofNewDate;
										CqlDate bz_ = context.Operators.Indexer<CqlDate>(bx_, by_);

										return bz_ is null;
									};
									if (bw_())
									{
										return SecondList;
									}
									else
									{
										IEnumerable<CqlDate> ca_ = SecondList?.NewList;
										int? cb_ = SecondList?.IndexofNewDate;
										CqlDate cc_ = context.Operators.Indexer<CqlDate>(ca_, cb_);
										bool? ce_(CqlDate X)
										{
											IEnumerable<CqlDate> cn_ = SecondList?.NewList;
											int? co_ = SecondList?.IndexofNewDate;
											CqlDate cp_ = context.Operators.Indexer<CqlDate>(cn_, co_);
											CqlQuantity cq_ = context.Operators.Quantity(1m, "day");
											CqlDate cr_ = context.Operators.Add(cp_ as CqlDate, cq_);
											CqlDate cu_ = context.Operators.Indexer<CqlDate>(cn_, co_);
											CqlQuantity cv_ = context.Operators.Quantity(30m, "days");
											CqlDate cw_ = context.Operators.Add(cu_ as CqlDate, cv_);
											CqlInterval<CqlDate> cx_ = context.Operators.Interval(cr_, cw_, true, true);
											bool? cy_ = context.Operators.In<CqlDate>(X, cx_, default);
											bool? cz_ = context.Operators.Not(cy_);

											return cz_;
										};
										IEnumerable<CqlDate> cf_ = context.Operators.Where<CqlDate>(ca_, ce_);
										int? ch_ = context.Operators.Add(cb_, 1);
										(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ci_ = (cc_ as CqlDate, cf_, ch_);
										(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] cj_ = [
											ci_,
										];
										(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ck_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
										{
											(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? da_()
											{
												bool db_()
												{
													IEnumerable<CqlDate> dc_ = ThirdList?.NewList;
													int? dd_ = ThirdList?.IndexofNewDate;
													CqlDate de_ = context.Operators.Indexer<CqlDate>(dc_, dd_);

													return de_ is null;
												};
												if (db_())
												{
													return ThirdList;
												}
												else
												{
													IEnumerable<CqlDate> df_ = ThirdList?.NewList;
													int? dg_ = ThirdList?.IndexofNewDate;
													CqlDate dh_ = context.Operators.Indexer<CqlDate>(df_, dg_);
													bool? dj_(CqlDate X)
													{
														IEnumerable<CqlDate> ds_ = ThirdList?.NewList;
														int? dt_ = ThirdList?.IndexofNewDate;
														CqlDate du_ = context.Operators.Indexer<CqlDate>(ds_, dt_);
														CqlQuantity dv_ = context.Operators.Quantity(1m, "day");
														CqlDate dw_ = context.Operators.Add(du_ as CqlDate, dv_);
														CqlDate dz_ = context.Operators.Indexer<CqlDate>(ds_, dt_);
														CqlQuantity ea_ = context.Operators.Quantity(30m, "days");
														CqlDate eb_ = context.Operators.Add(dz_ as CqlDate, ea_);
														CqlInterval<CqlDate> ec_ = context.Operators.Interval(dw_, eb_, true, true);
														bool? ed_ = context.Operators.In<CqlDate>(X, ec_, default);
														bool? ee_ = context.Operators.Not(ed_);

														return ee_;
													};
													IEnumerable<CqlDate> dk_ = context.Operators.Where<CqlDate>(df_, dj_);
													int? dm_ = context.Operators.Add(dg_, 1);
													(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dn_ = (dh_ as CqlDate, dk_, dm_);
													(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] do_ = [
														dn_,
													];
													(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dp_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
													{
														(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ef_()
														{
															bool eg_()
															{
																IEnumerable<CqlDate> eh_ = FourthList?.NewList;
																int? ei_ = FourthList?.IndexofNewDate;
																CqlDate ej_ = context.Operators.Indexer<CqlDate>(eh_, ei_);

																return ej_ is null;
															};
															if (eg_())
															{
																return FourthList;
															}
															else
															{
																IEnumerable<CqlDate> ek_ = FourthList?.NewList;
																int? el_ = FourthList?.IndexofNewDate;
																CqlDate em_ = context.Operators.Indexer<CqlDate>(ek_, el_);
																bool? eo_(CqlDate X)
																{
																	IEnumerable<CqlDate> ex_ = FourthList?.NewList;
																	int? ey_ = FourthList?.IndexofNewDate;
																	CqlDate ez_ = context.Operators.Indexer<CqlDate>(ex_, ey_);
																	CqlQuantity fa_ = context.Operators.Quantity(1m, "day");
																	CqlDate fb_ = context.Operators.Add(ez_ as CqlDate, fa_);
																	CqlDate fe_ = context.Operators.Indexer<CqlDate>(ex_, ey_);
																	CqlQuantity ff_ = context.Operators.Quantity(30m, "days");
																	CqlDate fg_ = context.Operators.Add(fe_ as CqlDate, ff_);
																	CqlInterval<CqlDate> fh_ = context.Operators.Interval(fb_, fg_, true, true);
																	bool? fi_ = context.Operators.In<CqlDate>(X, fh_, default);
																	bool? fj_ = context.Operators.Not(fi_);

																	return fj_;
																};
																IEnumerable<CqlDate> ep_ = context.Operators.Where<CqlDate>(ek_, eo_);
																int? er_ = context.Operators.Add(el_, 1);
																(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? es_ = (em_ as CqlDate, ep_, er_);
																(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] et_ = [
																	es_,
																];
																(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eu_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
																{
																	(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fk_()
																	{
																		bool fl_()
																		{
																			IEnumerable<CqlDate> fm_ = FifthList?.NewList;
																			int? fn_ = FifthList?.IndexofNewDate;
																			CqlDate fo_ = context.Operators.Indexer<CqlDate>(fm_, fn_);

																			return fo_ is null;
																		};
																		if (fl_())
																		{
																			return FifthList;
																		}
																		else
																		{
																			IEnumerable<CqlDate> fp_ = FifthList?.NewList;
																			int? fq_ = FifthList?.IndexofNewDate;
																			CqlDate fr_ = context.Operators.Indexer<CqlDate>(fp_, fq_);
																			bool? ft_(CqlDate X)
																			{
																				IEnumerable<CqlDate> gc_ = FifthList?.NewList;
																				int? gd_ = FifthList?.IndexofNewDate;
																				CqlDate ge_ = context.Operators.Indexer<CqlDate>(gc_, gd_);
																				CqlQuantity gf_ = context.Operators.Quantity(1m, "day");
																				CqlDate gg_ = context.Operators.Add(ge_ as CqlDate, gf_);
																				CqlDate gj_ = context.Operators.Indexer<CqlDate>(gc_, gd_);
																				CqlQuantity gk_ = context.Operators.Quantity(30m, "days");
																				CqlDate gl_ = context.Operators.Add(gj_ as CqlDate, gk_);
																				CqlInterval<CqlDate> gm_ = context.Operators.Interval(gg_, gl_, true, true);
																				bool? gn_ = context.Operators.In<CqlDate>(X, gm_, default);
																				bool? go_ = context.Operators.Not(gn_);

																				return go_;
																			};
																			IEnumerable<CqlDate> fu_ = context.Operators.Where<CqlDate>(fp_, ft_);
																			int? fw_ = context.Operators.Add(fq_, 1);
																			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fx_ = (fr_ as CqlDate, fu_, fw_);
																			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fy_ = [
																				fx_,
																			];
																			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fz_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
																			{
																				(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gp_()
																				{
																					bool gq_()
																					{
																						IEnumerable<CqlDate> gr_ = SixthList?.NewList;
																						int? gs_ = SixthList?.IndexofNewDate;
																						CqlDate gt_ = context.Operators.Indexer<CqlDate>(gr_, gs_);

																						return gt_ is null;
																					};
																					if (gq_())
																					{
																						return SixthList;
																					}
																					else
																					{
																						IEnumerable<CqlDate> gu_ = SixthList?.NewList;
																						int? gv_ = SixthList?.IndexofNewDate;
																						CqlDate gw_ = context.Operators.Indexer<CqlDate>(gu_, gv_);
																						bool? gy_(CqlDate X)
																						{
																							IEnumerable<CqlDate> hh_ = SixthList?.NewList;
																							int? hi_ = SixthList?.IndexofNewDate;
																							CqlDate hj_ = context.Operators.Indexer<CqlDate>(hh_, hi_);
																							CqlQuantity hk_ = context.Operators.Quantity(1m, "day");
																							CqlDate hl_ = context.Operators.Add(hj_ as CqlDate, hk_);
																							CqlDate ho_ = context.Operators.Indexer<CqlDate>(hh_, hi_);
																							CqlQuantity hp_ = context.Operators.Quantity(30m, "days");
																							CqlDate hq_ = context.Operators.Add(ho_ as CqlDate, hp_);
																							CqlInterval<CqlDate> hr_ = context.Operators.Interval(hl_, hq_, true, true);
																							bool? hs_ = context.Operators.In<CqlDate>(X, hr_, default);
																							bool? ht_ = context.Operators.Not(hs_);

																							return ht_;
																						};
																						IEnumerable<CqlDate> gz_ = context.Operators.Where<CqlDate>(gu_, gy_);
																						int? hb_ = context.Operators.Add(gv_, 1);
																						(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hc_ = (gw_ as CqlDate, gz_, hb_);
																						(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hd_ = [
																							hc_,
																						];
																						(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? he_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
																						{
																							(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hu_()
																							{
																								bool hv_()
																								{
																									IEnumerable<CqlDate> hw_ = SeventhList?.NewList;
																									int? hx_ = SeventhList?.IndexofNewDate;
																									CqlDate hy_ = context.Operators.Indexer<CqlDate>(hw_, hx_);

																									return hy_ is null;
																								};
																								if (hv_())
																								{
																									return SeventhList;
																								}
																								else
																								{
																									IEnumerable<CqlDate> hz_ = SeventhList?.NewList;
																									int? ia_ = SeventhList?.IndexofNewDate;
																									CqlDate ib_ = context.Operators.Indexer<CqlDate>(hz_, ia_);
																									bool? id_(CqlDate X)
																									{
																										IEnumerable<CqlDate> im_ = SeventhList?.NewList;
																										int? in_ = SeventhList?.IndexofNewDate;
																										CqlDate io_ = context.Operators.Indexer<CqlDate>(im_, in_);
																										CqlQuantity ip_ = context.Operators.Quantity(1m, "day");
																										CqlDate iq_ = context.Operators.Add(io_ as CqlDate, ip_);
																										CqlDate it_ = context.Operators.Indexer<CqlDate>(im_, in_);
																										CqlQuantity iu_ = context.Operators.Quantity(30m, "days");
																										CqlDate iv_ = context.Operators.Add(it_ as CqlDate, iu_);
																										CqlInterval<CqlDate> iw_ = context.Operators.Interval(iq_, iv_, true, true);
																										bool? ix_ = context.Operators.In<CqlDate>(X, iw_, default);
																										bool? iy_ = context.Operators.Not(ix_);

																										return iy_;
																									};
																									IEnumerable<CqlDate> ie_ = context.Operators.Where<CqlDate>(hz_, id_);
																									int? ig_ = context.Operators.Add(ia_, 1);
																									(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ih_ = (ib_ as CqlDate, ie_, ig_);
																									(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ii_ = [
																										ih_,
																									];
																									(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ij_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
																									{
																										(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iz_()
																										{
																											bool ja_()
																											{
																												IEnumerable<CqlDate> jb_ = EighthList?.NewList;
																												int? jc_ = EighthList?.IndexofNewDate;
																												CqlDate jd_ = context.Operators.Indexer<CqlDate>(jb_, jc_);

																												return jd_ is null;
																											};
																											if (ja_())
																											{
																												return EighthList;
																											}
																											else
																											{
																												IEnumerable<CqlDate> je_ = EighthList?.NewList;
																												int? jf_ = EighthList?.IndexofNewDate;
																												CqlDate jg_ = context.Operators.Indexer<CqlDate>(je_, jf_);
																												bool? ji_(CqlDate X)
																												{
																													IEnumerable<CqlDate> jr_ = EighthList?.NewList;
																													int? js_ = EighthList?.IndexofNewDate;
																													CqlDate jt_ = context.Operators.Indexer<CqlDate>(jr_, js_);
																													CqlQuantity ju_ = context.Operators.Quantity(1m, "day");
																													CqlDate jv_ = context.Operators.Add(jt_ as CqlDate, ju_);
																													CqlDate jy_ = context.Operators.Indexer<CqlDate>(jr_, js_);
																													CqlQuantity jz_ = context.Operators.Quantity(30m, "days");
																													CqlDate ka_ = context.Operators.Add(jy_ as CqlDate, jz_);
																													CqlInterval<CqlDate> kb_ = context.Operators.Interval(jv_, ka_, true, true);
																													bool? kc_ = context.Operators.In<CqlDate>(X, kb_, default);
																													bool? kd_ = context.Operators.Not(kc_);

																													return kd_;
																												};
																												IEnumerable<CqlDate> jj_ = context.Operators.Where<CqlDate>(je_, ji_);
																												int? jl_ = context.Operators.Add(jf_, 1);
																												(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jm_ = (jg_ as CqlDate, jj_, jl_);
																												(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] jn_ = [
																													jm_,
																												];
																												(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jo_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
																												{
																													(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ke_()
																													{
																														bool kf_()
																														{
																															IEnumerable<CqlDate> kg_ = NinethList?.NewList;
																															int? kh_ = NinethList?.IndexofNewDate;
																															CqlDate ki_ = context.Operators.Indexer<CqlDate>(kg_, kh_);

																															return ki_ is null;
																														};
																														if (kf_())
																														{
																															return NinethList;
																														}
																														else
																														{
																															IEnumerable<CqlDate> kj_ = NinethList?.NewList;
																															int? kk_ = NinethList?.IndexofNewDate;
																															CqlDate kl_ = context.Operators.Indexer<CqlDate>(kj_, kk_);
																															bool? kn_(CqlDate X)
																															{
																																IEnumerable<CqlDate> kw_ = NinethList?.NewList;
																																int? kx_ = NinethList?.IndexofNewDate;
																																CqlDate ky_ = context.Operators.Indexer<CqlDate>(kw_, kx_);
																																CqlQuantity kz_ = context.Operators.Quantity(1m, "day");
																																CqlDate la_ = context.Operators.Add(ky_ as CqlDate, kz_);
																																CqlDate ld_ = context.Operators.Indexer<CqlDate>(kw_, kx_);
																																CqlQuantity le_ = context.Operators.Quantity(30m, "days");
																																CqlDate lf_ = context.Operators.Add(ld_ as CqlDate, le_);
																																CqlInterval<CqlDate> lg_ = context.Operators.Interval(la_, lf_, true, true);
																																bool? lh_ = context.Operators.In<CqlDate>(X, lg_, default);
																																bool? li_ = context.Operators.Not(lh_);

																																return li_;
																															};
																															IEnumerable<CqlDate> ko_ = context.Operators.Where<CqlDate>(kj_, kn_);
																															int? kq_ = context.Operators.Add(kk_, 1);
																															(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kr_ = (kl_ as CqlDate, ko_, kq_);
																															(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ks_ = [
																																kr_,
																															];
																															(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kt_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
																															{
																																(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lj_()
																																{
																																	bool lk_()
																																	{
																																		IEnumerable<CqlDate> ll_ = TenthList?.NewList;
																																		int? lm_ = TenthList?.IndexofNewDate;
																																		CqlDate ln_ = context.Operators.Indexer<CqlDate>(ll_, lm_);

																																		return ln_ is null;
																																	};
																																	if (lk_())
																																	{
																																		return TenthList;
																																	}
																																	else
																																	{
																																		IEnumerable<CqlDate> lo_ = TenthList?.NewList;
																																		int? lp_ = TenthList?.IndexofNewDate;
																																		CqlDate lq_ = context.Operators.Indexer<CqlDate>(lo_, lp_);
																																		bool? ls_(CqlDate X)
																																		{
																																			IEnumerable<CqlDate> mb_ = TenthList?.NewList;
																																			int? mc_ = TenthList?.IndexofNewDate;
																																			CqlDate md_ = context.Operators.Indexer<CqlDate>(mb_, mc_);
																																			CqlQuantity me_ = context.Operators.Quantity(1m, "day");
																																			CqlDate mf_ = context.Operators.Add(md_ as CqlDate, me_);
																																			CqlDate mi_ = context.Operators.Indexer<CqlDate>(mb_, mc_);
																																			CqlQuantity mj_ = context.Operators.Quantity(30m, "days");
																																			CqlDate mk_ = context.Operators.Add(mi_ as CqlDate, mj_);
																																			CqlInterval<CqlDate> ml_ = context.Operators.Interval(mf_, mk_, true, true);
																																			bool? mm_ = context.Operators.In<CqlDate>(X, ml_, default);
																																			bool? mn_ = context.Operators.Not(mm_);

																																			return mn_;
																																		};
																																		IEnumerable<CqlDate> lt_ = context.Operators.Where<CqlDate>(lo_, ls_);
																																		int? lv_ = context.Operators.Add(lp_, 1);
																																		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lw_ = (lq_ as CqlDate, lt_, lv_);
																																		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] lx_ = [
																																			lw_,
																																		];
																																		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ly_((CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
																																		{
																																			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mo_()
																																			{
																																				bool mp_()
																																				{
																																					IEnumerable<CqlDate> mq_ = EleventhList?.NewList;
																																					int? mr_ = EleventhList?.IndexofNewDate;
																																					CqlDate ms_ = context.Operators.Indexer<CqlDate>(mq_, mr_);

																																					return ms_ is null;
																																				};
																																				if (mp_())
																																				{
																																					return EleventhList;
																																				}
																																				else
																																				{
																																					IEnumerable<CqlDate> mt_ = EleventhList?.NewList;
																																					int? mu_ = EleventhList?.IndexofNewDate;
																																					CqlDate mv_ = context.Operators.Indexer<CqlDate>(mt_, mu_);
																																					bool? mx_(CqlDate X)
																																					{
																																						IEnumerable<CqlDate> nc_ = EleventhList?.NewList;
																																						int? nd_ = EleventhList?.IndexofNewDate;
																																						CqlDate ne_ = context.Operators.Indexer<CqlDate>(nc_, nd_);
																																						CqlQuantity nf_ = context.Operators.Quantity(1m, "day");
																																						CqlDate ng_ = context.Operators.Add(ne_ as CqlDate, nf_);
																																						CqlDate nj_ = context.Operators.Indexer<CqlDate>(nc_, nd_);
																																						CqlQuantity nk_ = context.Operators.Quantity(30m, "days");
																																						CqlDate nl_ = context.Operators.Add(nj_ as CqlDate, nk_);
																																						CqlInterval<CqlDate> nm_ = context.Operators.Interval(ng_, nl_, true, true);
																																						bool? nn_ = context.Operators.In<CqlDate>(X, nm_, default);
																																						bool? no_ = context.Operators.Not(nn_);

																																						return no_;
																																					};
																																					IEnumerable<CqlDate> my_ = context.Operators.Where<CqlDate>(mt_, mx_);
																																					int? na_ = context.Operators.Add(mu_, 1);
																																					(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nb_ = (mv_ as CqlDate, my_, na_);

																																					return nb_;
																																				}
																																			};

																																			return mo_();
																																		};
																																		IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lz_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)lx_, ly_);
																																		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ma_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lz_);

																																		return ma_;
																																	}
																																};

																																return lj_();
																															};
																															IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ku_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ks_, kt_);
																															(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kv_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ku_);

																															return kv_;
																														}
																													};

																													return ke_();
																												};
																												IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jp_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)jn_, jo_);
																												(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jq_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jp_);

																												return jq_;
																											}
																										};

																										return iz_();
																									};
																									IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ik_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ii_, ij_);
																									(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? il_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ik_);

																									return il_;
																								}
																							};

																							return hu_();
																						};
																						IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hf_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hd_, he_);
																						(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hg_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hf_);

																						return hg_;
																					}
																				};

																				return gp_();
																			};
																			IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ga_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fy_, fz_);
																			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gb_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ga_);

																			return gb_;
																		}
																	};

																	return fk_();
																};
																IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ev_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)et_, eu_);
																(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ew_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ev_);

																return ew_;
															}
														};

														return ef_();
													};
													IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dq_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)do_, dp_);
													(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dr_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dq_);

													return dr_;
												}
											};

											return da_();
										};
										IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cl_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cj_, ck_);
										(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cm_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cl_);

										return cm_;
									}
								};

								return bv_();
							};
							IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bg_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)be_, bf_);
							(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bh_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bg_);

							return bh_;
						}
					};

					return aq_();
				};
				IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ab_ = context.Operators.Select<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)z_, aa_);
				(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ac_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ab_);

				return ac_;
			};
			IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> p_ = context.Operators.Select<(IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)n_, o_);
			(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? q_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(p_);

			return q_;
		};
		IEnumerable<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> i_ = context.Operators.Select<(IEnumerable<CqlDate> SortedDates, nint _)?, (CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(IEnumerable<CqlDate> SortedDates, nint _)?>)g_, h_);
		(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? j_ = context.Operators.SingletonFrom<(CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(i_);

		return j_;
	}

}
