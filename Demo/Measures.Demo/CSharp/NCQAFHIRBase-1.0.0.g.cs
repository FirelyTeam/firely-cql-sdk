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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
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
				FhirDateTime b_ = onset switch { null => null , FhirDateTime a => a/* , Age => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDateTime c_ = FHIRHelpers_4_0_001.ToDateTime(b_);
				CqlDateTime e_ = FHIRHelpers_4_0_001.ToDateTime(b_);
				CqlInterval<CqlDateTime> f_ = context.Operators.Interval(c_, e_, true, true);

				return f_;
			}
			else if (onset is Period)
			{
				FhirDateTime g_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
				CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
				FhirDateTime i_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);

				return k_;
			}
			else if (onset is FhirString)
			{
				CqlInterval<CqlDateTime> l_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return l_;
			}
			else
			{
				CqlInterval<CqlDate> m_()
				{
					if (onset is Age)
					{
						Patient x_ = this.Patient();
						Date y_ = x_?.BirthDateElement;
						CqlDate z_ = FHIRHelpers_4_0_001.ToDate(y_);
						Age aa_ = onset switch { null => null , Age b => b/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity ab_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
						CqlDate ac_ = context.Operators.Add(z_, ab_);
						Date ae_ = x_?.BirthDateElement;
						CqlDate af_ = FHIRHelpers_4_0_001.ToDate(ae_);
						CqlQuantity ah_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
						CqlDate ai_ = context.Operators.Add(af_, ah_);
						CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
						CqlDate ak_ = context.Operators.Add(ai_, aj_);
						CqlInterval<CqlDate> al_ = context.Operators.Interval(ac_, ak_, true, false);

						return al_;
					}
					else if (onset is Range)
					{
						Patient am_ = this.Patient();
						Date an_ = am_?.BirthDateElement;
						CqlDate ao_ = FHIRHelpers_4_0_001.ToDate(an_);
						Range ap_ = onset switch { null => null , Range c => c/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity aq_ = ap_?.Low;
						CqlQuantity ar_ = FHIRHelpers_4_0_001.ToQuantity(aq_);
						CqlDate as_ = context.Operators.Add(ao_, ar_);
						Date au_ = am_?.BirthDateElement;
						CqlDate av_ = FHIRHelpers_4_0_001.ToDate(au_);
						Quantity ax_ = ap_?.High;
						CqlQuantity ay_ = FHIRHelpers_4_0_001.ToQuantity(ax_);
						CqlDate az_ = context.Operators.Add(av_, ay_);
						CqlQuantity ba_ = context.Operators.Quantity(1m, "year");
						CqlDate bb_ = context.Operators.Add(az_, ba_);
						CqlInterval<CqlDate> bc_ = context.Operators.Interval(as_, bb_, true, false);

						return bc_;
					}
					else
					{
						return null;
					}
				};
				CqlDate n_ = (m_())?.low;
				CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
				CqlInterval<CqlDate> p_()
				{
					if (onset is Age)
					{
						Patient bd_ = this.Patient();
						Date be_ = bd_?.BirthDateElement;
						CqlDate bf_ = FHIRHelpers_4_0_001.ToDate(be_);
						Age bg_ = onset switch { null => null , Age d => d/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity bh_ = FHIRHelpers_4_0_001.ToQuantity(bg_);
						CqlDate bi_ = context.Operators.Add(bf_, bh_);
						Date bk_ = bd_?.BirthDateElement;
						CqlDate bl_ = FHIRHelpers_4_0_001.ToDate(bk_);
						CqlQuantity bn_ = FHIRHelpers_4_0_001.ToQuantity(bg_);
						CqlDate bo_ = context.Operators.Add(bl_, bn_);
						CqlQuantity bp_ = context.Operators.Quantity(1m, "year");
						CqlDate bq_ = context.Operators.Add(bo_, bp_);
						CqlInterval<CqlDate> br_ = context.Operators.Interval(bi_, bq_, true, false);

						return br_;
					}
					else if (onset is Range)
					{
						Patient bs_ = this.Patient();
						Date bt_ = bs_?.BirthDateElement;
						CqlDate bu_ = FHIRHelpers_4_0_001.ToDate(bt_);
						Range bv_ = onset switch { null => null , Range e => e/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity bw_ = bv_?.Low;
						CqlQuantity bx_ = FHIRHelpers_4_0_001.ToQuantity(bw_);
						CqlDate by_ = context.Operators.Add(bu_, bx_);
						Date ca_ = bs_?.BirthDateElement;
						CqlDate cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
						Quantity cd_ = bv_?.High;
						CqlQuantity ce_ = FHIRHelpers_4_0_001.ToQuantity(cd_);
						CqlDate cf_ = context.Operators.Add(cb_, ce_);
						CqlQuantity cg_ = context.Operators.Quantity(1m, "year");
						CqlDate ch_ = context.Operators.Add(cf_, cg_);
						CqlInterval<CqlDate> ci_ = context.Operators.Interval(by_, ch_, true, false);

						return ci_;
					}
					else
					{
						return null;
					}
				};
				CqlDate q_ = (p_())?.high;
				CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
				CqlInterval<CqlDate> s_()
				{
					if (onset is Age)
					{
						Patient cj_ = this.Patient();
						Date ck_ = cj_?.BirthDateElement;
						CqlDate cl_ = FHIRHelpers_4_0_001.ToDate(ck_);
						Age cm_ = onset switch { null => null , Age f => f/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity cn_ = FHIRHelpers_4_0_001.ToQuantity(cm_);
						CqlDate co_ = context.Operators.Add(cl_, cn_);
						Date cq_ = cj_?.BirthDateElement;
						CqlDate cr_ = FHIRHelpers_4_0_001.ToDate(cq_);
						CqlQuantity ct_ = FHIRHelpers_4_0_001.ToQuantity(cm_);
						CqlDate cu_ = context.Operators.Add(cr_, ct_);
						CqlQuantity cv_ = context.Operators.Quantity(1m, "year");
						CqlDate cw_ = context.Operators.Add(cu_, cv_);
						CqlInterval<CqlDate> cx_ = context.Operators.Interval(co_, cw_, true, false);

						return cx_;
					}
					else if (onset is Range)
					{
						Patient cy_ = this.Patient();
						Date cz_ = cy_?.BirthDateElement;
						CqlDate da_ = FHIRHelpers_4_0_001.ToDate(cz_);
						Range db_ = onset switch { null => null , Range g => g/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity dc_ = db_?.Low;
						CqlQuantity dd_ = FHIRHelpers_4_0_001.ToQuantity(dc_);
						CqlDate de_ = context.Operators.Add(da_, dd_);
						Date dg_ = cy_?.BirthDateElement;
						CqlDate dh_ = FHIRHelpers_4_0_001.ToDate(dg_);
						Quantity dj_ = db_?.High;
						CqlQuantity dk_ = FHIRHelpers_4_0_001.ToQuantity(dj_);
						CqlDate dl_ = context.Operators.Add(dh_, dk_);
						CqlQuantity dm_ = context.Operators.Quantity(1m, "year");
						CqlDate dn_ = context.Operators.Add(dl_, dm_);
						CqlInterval<CqlDate> do_ = context.Operators.Interval(de_, dn_, true, false);

						return do_;
					}
					else
					{
						return null;
					}
				};
				bool? t_ = (s_())?.lowClosed;
				CqlInterval<CqlDate> u_()
				{
					if (onset is Age)
					{
						Patient dp_ = this.Patient();
						Date dq_ = dp_?.BirthDateElement;
						CqlDate dr_ = FHIRHelpers_4_0_001.ToDate(dq_);
						Age ds_ = onset switch { null => null , Age h => h/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity dt_ = FHIRHelpers_4_0_001.ToQuantity(ds_);
						CqlDate du_ = context.Operators.Add(dr_, dt_);
						Date dw_ = dp_?.BirthDateElement;
						CqlDate dx_ = FHIRHelpers_4_0_001.ToDate(dw_);
						CqlQuantity dz_ = FHIRHelpers_4_0_001.ToQuantity(ds_);
						CqlDate ea_ = context.Operators.Add(dx_, dz_);
						CqlQuantity eb_ = context.Operators.Quantity(1m, "year");
						CqlDate ec_ = context.Operators.Add(ea_, eb_);
						CqlInterval<CqlDate> ed_ = context.Operators.Interval(du_, ec_, true, false);

						return ed_;
					}
					else if (onset is Range)
					{
						Patient ee_ = this.Patient();
						Date ef_ = ee_?.BirthDateElement;
						CqlDate eg_ = FHIRHelpers_4_0_001.ToDate(ef_);
						Range eh_ = onset switch { null => null , Range i => i/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity ei_ = eh_?.Low;
						CqlQuantity ej_ = FHIRHelpers_4_0_001.ToQuantity(ei_);
						CqlDate ek_ = context.Operators.Add(eg_, ej_);
						Date em_ = ee_?.BirthDateElement;
						CqlDate en_ = FHIRHelpers_4_0_001.ToDate(em_);
						Quantity ep_ = eh_?.High;
						CqlQuantity eq_ = FHIRHelpers_4_0_001.ToQuantity(ep_);
						CqlDate er_ = context.Operators.Add(en_, eq_);
						CqlQuantity es_ = context.Operators.Quantity(1m, "year");
						CqlDate et_ = context.Operators.Add(er_, es_);
						CqlInterval<CqlDate> eu_ = context.Operators.Interval(ek_, et_, true, false);

						return eu_;
					}
					else
					{
						return null;
					}
				};
				bool? v_ = (u_())?.highClosed;
				CqlInterval<CqlDateTime> w_ = context.Operators.Interval(o_, r_, t_, v_);

				return w_;
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
				FhirDateTime b_ = abatement switch { null => null , FhirDateTime a => a/* , Age => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDateTime c_ = FHIRHelpers_4_0_001.ToDateTime(b_);
				CqlDateTime e_ = FHIRHelpers_4_0_001.ToDateTime(b_);
				CqlInterval<CqlDateTime> f_ = context.Operators.Interval(c_, e_, true, true);

				return f_;
			}
			else if (abatement is Period)
			{
				FhirDateTime g_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
				CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
				FhirDateTime i_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);

				return k_;
			}
			else if (abatement is FhirString)
			{
				CqlInterval<CqlDateTime> l_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return l_;
			}
			else
			{
				CqlInterval<CqlDate> m_()
				{
					if (abatement is Age)
					{
						Patient x_ = this.Patient();
						Date y_ = x_?.BirthDateElement;
						CqlDate z_ = FHIRHelpers_4_0_001.ToDate(y_);
						Age aa_ = abatement switch { null => null , Age b => b/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity ab_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
						CqlDate ac_ = context.Operators.Add(z_, ab_);
						Date ae_ = x_?.BirthDateElement;
						CqlDate af_ = FHIRHelpers_4_0_001.ToDate(ae_);
						CqlQuantity ah_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
						CqlDate ai_ = context.Operators.Add(af_, ah_);
						CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
						CqlDate ak_ = context.Operators.Add(ai_, aj_);
						CqlInterval<CqlDate> al_ = context.Operators.Interval(ac_, ak_, true, false);

						return al_;
					}
					else if (abatement is Range)
					{
						Patient am_ = this.Patient();
						Date an_ = am_?.BirthDateElement;
						CqlDate ao_ = FHIRHelpers_4_0_001.ToDate(an_);
						Range ap_ = abatement switch { null => null , Range c => c/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity aq_ = ap_?.Low;
						CqlQuantity ar_ = FHIRHelpers_4_0_001.ToQuantity(aq_);
						CqlDate as_ = context.Operators.Add(ao_, ar_);
						Date au_ = am_?.BirthDateElement;
						CqlDate av_ = FHIRHelpers_4_0_001.ToDate(au_);
						Quantity ax_ = ap_?.High;
						CqlQuantity ay_ = FHIRHelpers_4_0_001.ToQuantity(ax_);
						CqlDate az_ = context.Operators.Add(av_, ay_);
						CqlQuantity ba_ = context.Operators.Quantity(1m, "year");
						CqlDate bb_ = context.Operators.Add(az_, ba_);
						CqlInterval<CqlDate> bc_ = context.Operators.Interval(as_, bb_, true, false);

						return bc_;
					}
					else
					{
						return null;
					}
				};
				CqlDate n_ = (m_())?.low;
				CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
				CqlInterval<CqlDate> p_()
				{
					if (abatement is Age)
					{
						Patient bd_ = this.Patient();
						Date be_ = bd_?.BirthDateElement;
						CqlDate bf_ = FHIRHelpers_4_0_001.ToDate(be_);
						Age bg_ = abatement switch { null => null , Age d => d/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity bh_ = FHIRHelpers_4_0_001.ToQuantity(bg_);
						CqlDate bi_ = context.Operators.Add(bf_, bh_);
						Date bk_ = bd_?.BirthDateElement;
						CqlDate bl_ = FHIRHelpers_4_0_001.ToDate(bk_);
						CqlQuantity bn_ = FHIRHelpers_4_0_001.ToQuantity(bg_);
						CqlDate bo_ = context.Operators.Add(bl_, bn_);
						CqlQuantity bp_ = context.Operators.Quantity(1m, "year");
						CqlDate bq_ = context.Operators.Add(bo_, bp_);
						CqlInterval<CqlDate> br_ = context.Operators.Interval(bi_, bq_, true, false);

						return br_;
					}
					else if (abatement is Range)
					{
						Patient bs_ = this.Patient();
						Date bt_ = bs_?.BirthDateElement;
						CqlDate bu_ = FHIRHelpers_4_0_001.ToDate(bt_);
						Range bv_ = abatement switch { null => null , Range e => e/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity bw_ = bv_?.Low;
						CqlQuantity bx_ = FHIRHelpers_4_0_001.ToQuantity(bw_);
						CqlDate by_ = context.Operators.Add(bu_, bx_);
						Date ca_ = bs_?.BirthDateElement;
						CqlDate cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
						Quantity cd_ = bv_?.High;
						CqlQuantity ce_ = FHIRHelpers_4_0_001.ToQuantity(cd_);
						CqlDate cf_ = context.Operators.Add(cb_, ce_);
						CqlQuantity cg_ = context.Operators.Quantity(1m, "year");
						CqlDate ch_ = context.Operators.Add(cf_, cg_);
						CqlInterval<CqlDate> ci_ = context.Operators.Interval(by_, ch_, true, false);

						return ci_;
					}
					else
					{
						return null;
					}
				};
				CqlDate q_ = (p_())?.high;
				CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
				CqlInterval<CqlDate> s_()
				{
					if (abatement is Age)
					{
						Patient cj_ = this.Patient();
						Date ck_ = cj_?.BirthDateElement;
						CqlDate cl_ = FHIRHelpers_4_0_001.ToDate(ck_);
						Age cm_ = abatement switch { null => null , Age f => f/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity cn_ = FHIRHelpers_4_0_001.ToQuantity(cm_);
						CqlDate co_ = context.Operators.Add(cl_, cn_);
						Date cq_ = cj_?.BirthDateElement;
						CqlDate cr_ = FHIRHelpers_4_0_001.ToDate(cq_);
						CqlQuantity ct_ = FHIRHelpers_4_0_001.ToQuantity(cm_);
						CqlDate cu_ = context.Operators.Add(cr_, ct_);
						CqlQuantity cv_ = context.Operators.Quantity(1m, "year");
						CqlDate cw_ = context.Operators.Add(cu_, cv_);
						CqlInterval<CqlDate> cx_ = context.Operators.Interval(co_, cw_, true, false);

						return cx_;
					}
					else if (abatement is Range)
					{
						Patient cy_ = this.Patient();
						Date cz_ = cy_?.BirthDateElement;
						CqlDate da_ = FHIRHelpers_4_0_001.ToDate(cz_);
						Range db_ = abatement switch { null => null , Range g => g/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity dc_ = db_?.Low;
						CqlQuantity dd_ = FHIRHelpers_4_0_001.ToQuantity(dc_);
						CqlDate de_ = context.Operators.Add(da_, dd_);
						Date dg_ = cy_?.BirthDateElement;
						CqlDate dh_ = FHIRHelpers_4_0_001.ToDate(dg_);
						Quantity dj_ = db_?.High;
						CqlQuantity dk_ = FHIRHelpers_4_0_001.ToQuantity(dj_);
						CqlDate dl_ = context.Operators.Add(dh_, dk_);
						CqlQuantity dm_ = context.Operators.Quantity(1m, "year");
						CqlDate dn_ = context.Operators.Add(dl_, dm_);
						CqlInterval<CqlDate> do_ = context.Operators.Interval(de_, dn_, true, false);

						return do_;
					}
					else
					{
						return null;
					}
				};
				bool? t_ = (s_())?.lowClosed;
				CqlInterval<CqlDate> u_()
				{
					if (abatement is Age)
					{
						Patient dp_ = this.Patient();
						Date dq_ = dp_?.BirthDateElement;
						CqlDate dr_ = FHIRHelpers_4_0_001.ToDate(dq_);
						Age ds_ = abatement switch { null => null , Age h => h/* , FhirDateTime => ???, Period => ???, Range => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						CqlQuantity dt_ = FHIRHelpers_4_0_001.ToQuantity(ds_);
						CqlDate du_ = context.Operators.Add(dr_, dt_);
						Date dw_ = dp_?.BirthDateElement;
						CqlDate dx_ = FHIRHelpers_4_0_001.ToDate(dw_);
						CqlQuantity dz_ = FHIRHelpers_4_0_001.ToQuantity(ds_);
						CqlDate ea_ = context.Operators.Add(dx_, dz_);
						CqlQuantity eb_ = context.Operators.Quantity(1m, "year");
						CqlDate ec_ = context.Operators.Add(ea_, eb_);
						CqlInterval<CqlDate> ed_ = context.Operators.Interval(du_, ec_, true, false);

						return ed_;
					}
					else if (abatement is Range)
					{
						Patient ee_ = this.Patient();
						Date ef_ = ee_?.BirthDateElement;
						CqlDate eg_ = FHIRHelpers_4_0_001.ToDate(ef_);
						Range eh_ = abatement switch { null => null , Range i => i/* , FhirDateTime => ???, Age => ???, Period => ???, FhirString => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
						Quantity ei_ = eh_?.Low;
						CqlQuantity ej_ = FHIRHelpers_4_0_001.ToQuantity(ei_);
						CqlDate ek_ = context.Operators.Add(eg_, ej_);
						Date em_ = ee_?.BirthDateElement;
						CqlDate en_ = FHIRHelpers_4_0_001.ToDate(em_);
						Quantity ep_ = eh_?.High;
						CqlQuantity eq_ = FHIRHelpers_4_0_001.ToQuantity(ep_);
						CqlDate er_ = context.Operators.Add(en_, eq_);
						CqlQuantity es_ = context.Operators.Quantity(1m, "year");
						CqlDate et_ = context.Operators.Add(er_, es_);
						CqlInterval<CqlDate> eu_ = context.Operators.Interval(ek_, et_, true, false);

						return eu_;
					}
					else
					{
						return null;
					}
				};
				bool? v_ = (u_())?.highClosed;
				CqlInterval<CqlDateTime> w_ = context.Operators.Interval(o_, r_, t_, v_);

				return w_;
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
				FhirDateTime b_ = choice switch { null => null , FhirDateTime a => a/* , Date => ???, Period => ???, Timing => ???, Instant => ???, FhirString => ???, Age => ???, Range => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDateTime c_ = FHIRHelpers_4_0_001.ToDateTime(b_);
				CqlDateTime e_ = FHIRHelpers_4_0_001.ToDateTime(b_);
				CqlInterval<CqlDateTime> f_ = context.Operators.Interval(c_, e_, true, true);

				return f_;
			}
			else if (choice is Date)
			{
				Date g_ = choice switch { null => null , Date b => b/* , FhirDateTime => ???, Period => ???, Timing => ???, Instant => ???, FhirString => ???, Age => ???, Range => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate h_ = FHIRHelpers_4_0_001.ToDate(g_);
				CqlDateTime i_ = context.Operators.ConvertDateToDateTime(h_);
				CqlDate k_ = FHIRHelpers_4_0_001.ToDate(g_);
				CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
				CqlInterval<CqlDateTime> m_ = context.Operators.Interval(i_, l_, true, true);

				return m_;
			}
			else if (choice is Period)
			{
				FhirDateTime n_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
				CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
				FhirDateTime p_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
				CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
				CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);

				return r_;
			}
			else if (choice is Instant)
			{
				Instant s_ = choice switch { null => null , Instant c => c/* , FhirDateTime => ???, Date => ???, Period => ???, Timing => ???, FhirString => ???, Age => ???, Range => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDateTime t_ = FHIRHelpers_4_0_001.ToDateTime(s_);
				CqlDateTime v_ = FHIRHelpers_4_0_001.ToDateTime(s_);
				CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);

				return w_;
			}
			else if (choice is Age)
			{
				Patient x_ = this.Patient();
				Date y_ = x_?.BirthDateElement;
				CqlDate z_ = FHIRHelpers_4_0_001.ToDate(y_);
				Age aa_ = choice switch { null => null , Age d => d/* , FhirDateTime => ???, Date => ???, Period => ???, Timing => ???, Instant => ???, FhirString => ???, Range => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlQuantity ab_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate ac_ = context.Operators.Add(z_, ab_);
				Date ae_ = x_?.BirthDateElement;
				CqlDate af_ = FHIRHelpers_4_0_001.ToDate(ae_);
				CqlQuantity ah_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate ai_ = context.Operators.Add(af_, ah_);
				CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
				CqlDate ak_ = context.Operators.Add(ai_, aj_);
				CqlInterval<CqlDate> al_ = context.Operators.Interval(ac_, ak_, true, false);
				CqlDate am_ = al_?.low;
				CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
				Date ap_ = x_?.BirthDateElement;
				CqlDate aq_ = FHIRHelpers_4_0_001.ToDate(ap_);
				CqlQuantity as_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate at_ = context.Operators.Add(aq_, as_);
				Date av_ = x_?.BirthDateElement;
				CqlDate aw_ = FHIRHelpers_4_0_001.ToDate(av_);
				CqlQuantity ay_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate az_ = context.Operators.Add(aw_, ay_);
				CqlDate bb_ = context.Operators.Add(az_, aj_);
				CqlInterval<CqlDate> bc_ = context.Operators.Interval(at_, bb_, true, false);
				CqlDate bd_ = bc_?.high;
				CqlDateTime be_ = context.Operators.ConvertDateToDateTime(bd_);
				Date bg_ = x_?.BirthDateElement;
				CqlDate bh_ = FHIRHelpers_4_0_001.ToDate(bg_);
				CqlQuantity bj_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate bk_ = context.Operators.Add(bh_, bj_);
				Date bm_ = x_?.BirthDateElement;
				CqlDate bn_ = FHIRHelpers_4_0_001.ToDate(bm_);
				CqlQuantity bp_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate bq_ = context.Operators.Add(bn_, bp_);
				CqlDate bs_ = context.Operators.Add(bq_, aj_);
				CqlInterval<CqlDate> bt_ = context.Operators.Interval(bk_, bs_, true, false);
				bool? bu_ = bt_?.lowClosed;
				Date bw_ = x_?.BirthDateElement;
				CqlDate bx_ = FHIRHelpers_4_0_001.ToDate(bw_);
				CqlQuantity bz_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate ca_ = context.Operators.Add(bx_, bz_);
				Date cc_ = x_?.BirthDateElement;
				CqlDate cd_ = FHIRHelpers_4_0_001.ToDate(cc_);
				CqlQuantity cf_ = FHIRHelpers_4_0_001.ToQuantity(aa_);
				CqlDate cg_ = context.Operators.Add(cd_, cf_);
				CqlDate ci_ = context.Operators.Add(cg_, aj_);
				CqlInterval<CqlDate> cj_ = context.Operators.Interval(ca_, ci_, true, false);
				bool? ck_ = cj_?.highClosed;
				CqlInterval<CqlDateTime> cl_ = context.Operators.Interval(an_, be_, bu_, ck_);

				return cl_;
			}
			else if (choice is Range)
			{
				Patient cm_ = this.Patient();
				Date cn_ = cm_?.BirthDateElement;
				CqlDate co_ = FHIRHelpers_4_0_001.ToDate(cn_);
				Range cp_ = choice switch { null => null , Range e => e/* , FhirDateTime => ???, Date => ???, Period => ???, Timing => ???, Instant => ???, FhirString => ???, Age => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				Quantity cq_ = cp_?.Low;
				CqlQuantity cr_ = FHIRHelpers_4_0_001.ToQuantity(cq_);
				CqlDate cs_ = context.Operators.Add(co_, cr_);
				Date cu_ = cm_?.BirthDateElement;
				CqlDate cv_ = FHIRHelpers_4_0_001.ToDate(cu_);
				Quantity cx_ = cp_?.High;
				CqlQuantity cy_ = FHIRHelpers_4_0_001.ToQuantity(cx_);
				CqlDate cz_ = context.Operators.Add(cv_, cy_);
				CqlQuantity da_ = context.Operators.Quantity(1m, "year");
				CqlDate db_ = context.Operators.Add(cz_, da_);
				CqlInterval<CqlDate> dc_ = context.Operators.Interval(cs_, db_, true, false);
				CqlDate dd_ = dc_?.low;
				CqlDateTime de_ = context.Operators.ConvertDateToDateTime(dd_);
				Date dg_ = cm_?.BirthDateElement;
				CqlDate dh_ = FHIRHelpers_4_0_001.ToDate(dg_);
				Quantity dj_ = cp_?.Low;
				CqlQuantity dk_ = FHIRHelpers_4_0_001.ToQuantity(dj_);
				CqlDate dl_ = context.Operators.Add(dh_, dk_);
				Date dn_ = cm_?.BirthDateElement;
				CqlDate do_ = FHIRHelpers_4_0_001.ToDate(dn_);
				Quantity dq_ = cp_?.High;
				CqlQuantity dr_ = FHIRHelpers_4_0_001.ToQuantity(dq_);
				CqlDate ds_ = context.Operators.Add(do_, dr_);
				CqlDate du_ = context.Operators.Add(ds_, da_);
				CqlInterval<CqlDate> dv_ = context.Operators.Interval(dl_, du_, true, false);
				CqlDate dw_ = dv_?.high;
				CqlDateTime dx_ = context.Operators.ConvertDateToDateTime(dw_);
				Date dz_ = cm_?.BirthDateElement;
				CqlDate ea_ = FHIRHelpers_4_0_001.ToDate(dz_);
				Quantity ec_ = cp_?.Low;
				CqlQuantity ed_ = FHIRHelpers_4_0_001.ToQuantity(ec_);
				CqlDate ee_ = context.Operators.Add(ea_, ed_);
				Date eg_ = cm_?.BirthDateElement;
				CqlDate eh_ = FHIRHelpers_4_0_001.ToDate(eg_);
				Quantity ej_ = cp_?.High;
				CqlQuantity ek_ = FHIRHelpers_4_0_001.ToQuantity(ej_);
				CqlDate el_ = context.Operators.Add(eh_, ek_);
				CqlDate en_ = context.Operators.Add(el_, da_);
				CqlInterval<CqlDate> eo_ = context.Operators.Interval(ee_, en_, true, false);
				bool? ep_ = eo_?.lowClosed;
				Date er_ = cm_?.BirthDateElement;
				CqlDate es_ = FHIRHelpers_4_0_001.ToDate(er_);
				Quantity eu_ = cp_?.Low;
				CqlQuantity ev_ = FHIRHelpers_4_0_001.ToQuantity(eu_);
				CqlDate ew_ = context.Operators.Add(es_, ev_);
				Date ey_ = cm_?.BirthDateElement;
				CqlDate ez_ = FHIRHelpers_4_0_001.ToDate(ey_);
				Quantity fb_ = cp_?.High;
				CqlQuantity fc_ = FHIRHelpers_4_0_001.ToQuantity(fb_);
				CqlDate fd_ = context.Operators.Add(ez_, fc_);
				CqlDate ff_ = context.Operators.Add(fd_, da_);
				CqlInterval<CqlDate> fg_ = context.Operators.Interval(ew_, ff_, true, false);
				bool? fh_ = fg_?.highClosed;
				CqlInterval<CqlDateTime> fi_ = context.Operators.Interval(de_, dx_, ep_, fh_);

				return fi_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> fj_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute a single interval from a Timing type");

				return fj_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> fk_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return fk_;
			}
			else
			{
				return null;
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
