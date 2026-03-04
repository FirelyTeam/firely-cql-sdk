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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("NCQAFHIRBase", "1.0.0")]
public partial class NCQAFHIRBase_1_0_0 : ILibrary, ISingleton<NCQAFHIRBase_1_0_0>
{
    #region Functions and Expressions (8)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private static readonly long _cacheIndex_Patient = 1413873205984747853L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
    {

        CqlInterval<CqlDateTime> a_() {
            if (onset is FhirDateTime)
            {
                CqlDateTime b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
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

                CqlInterval<CqlDate> k_() {
                    if (onset is Age)
                    {
                        Patient v_ = this.Patient(context);
                        Date w_ = v_?.BirthDateElement;
                        CqlDate x_ = FHIRHelpers_4_0_001.Instance.ToDate(context, w_);
                        CqlQuantity y_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate z_ = context.Operators.Add(x_, y_);
                        Date ab_ = v_?.BirthDateElement;
                        CqlDate ac_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ab_);
                        CqlDate ae_ = context.Operators.Add(ac_, y_);
                        CqlQuantity af_ = context.Operators.Quantity(1m, "year");
                        CqlDate ag_ = context.Operators.Add(ae_, af_);
                        CqlInterval<CqlDate> ah_ = context.Operators.Interval(z_, ag_, true, false);
                        return ah_;
                    }
                    else if (onset is Range)
                    {
                        Patient ai_ = this.Patient(context);
                        Date aj_ = ai_?.BirthDateElement;
                        CqlDate ak_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aj_);
                        Quantity al_ = (onset as Range)?.Low;
                        CqlQuantity am_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, al_);
                        CqlDate an_ = context.Operators.Add(ak_, am_);
                        Date ap_ = ai_?.BirthDateElement;
                        CqlDate aq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_);
                        Quantity ar_ = (onset as Range)?.High;
                        CqlQuantity as_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ar_);
                        CqlDate at_ = context.Operators.Add(aq_, as_);
                        CqlQuantity au_ = context.Operators.Quantity(1m, "year");
                        CqlDate av_ = context.Operators.Add(at_, au_);
                        CqlInterval<CqlDate> aw_ = context.Operators.Interval(an_, av_, true, false);
                        return aw_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                CqlDate l_ = (k_())?.low;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);

                CqlInterval<CqlDate> n_() {
                    if (onset is Age)
                    {
                        Patient ax_ = this.Patient(context);
                        Date ay_ = ax_?.BirthDateElement;
                        CqlDate az_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ay_);
                        CqlQuantity ba_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate bb_ = context.Operators.Add(az_, ba_);
                        Date bd_ = ax_?.BirthDateElement;
                        CqlDate be_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bd_);
                        CqlDate bg_ = context.Operators.Add(be_, ba_);
                        CqlQuantity bh_ = context.Operators.Quantity(1m, "year");
                        CqlDate bi_ = context.Operators.Add(bg_, bh_);
                        CqlInterval<CqlDate> bj_ = context.Operators.Interval(bb_, bi_, true, false);
                        return bj_;
                    }
                    else if (onset is Range)
                    {
                        Patient bk_ = this.Patient(context);
                        Date bl_ = bk_?.BirthDateElement;
                        CqlDate bm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bl_);
                        Quantity bn_ = (onset as Range)?.Low;
                        CqlQuantity bo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bn_);
                        CqlDate bp_ = context.Operators.Add(bm_, bo_);
                        Date br_ = bk_?.BirthDateElement;
                        CqlDate bs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, br_);
                        Quantity bt_ = (onset as Range)?.High;
                        CqlQuantity bu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bt_);
                        CqlDate bv_ = context.Operators.Add(bs_, bu_);
                        CqlQuantity bw_ = context.Operators.Quantity(1m, "year");
                        CqlDate bx_ = context.Operators.Add(bv_, bw_);
                        CqlInterval<CqlDate> by_ = context.Operators.Interval(bp_, bx_, true, false);
                        return by_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                CqlDate o_ = (n_())?.high;
                CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);

                CqlInterval<CqlDate> q_() {
                    if (onset is Age)
                    {
                        Patient bz_ = this.Patient(context);
                        Date ca_ = bz_?.BirthDateElement;
                        CqlDate cb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_);
                        CqlQuantity cc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate cd_ = context.Operators.Add(cb_, cc_);
                        Date cf_ = bz_?.BirthDateElement;
                        CqlDate cg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cf_);
                        CqlDate ci_ = context.Operators.Add(cg_, cc_);
                        CqlQuantity cj_ = context.Operators.Quantity(1m, "year");
                        CqlDate ck_ = context.Operators.Add(ci_, cj_);
                        CqlInterval<CqlDate> cl_ = context.Operators.Interval(cd_, ck_, true, false);
                        return cl_;
                    }
                    else if (onset is Range)
                    {
                        Patient cm_ = this.Patient(context);
                        Date cn_ = cm_?.BirthDateElement;
                        CqlDate co_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cn_);
                        Quantity cp_ = (onset as Range)?.Low;
                        CqlQuantity cq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cp_);
                        CqlDate cr_ = context.Operators.Add(co_, cq_);
                        Date ct_ = cm_?.BirthDateElement;
                        CqlDate cu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ct_);
                        Quantity cv_ = (onset as Range)?.High;
                        CqlQuantity cw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cv_);
                        CqlDate cx_ = context.Operators.Add(cu_, cw_);
                        CqlQuantity cy_ = context.Operators.Quantity(1m, "year");
                        CqlDate cz_ = context.Operators.Add(cx_, cy_);
                        CqlInterval<CqlDate> da_ = context.Operators.Interval(cr_, cz_, true, false);
                        return da_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                bool? r_ = (q_())?.lowClosed;

                CqlInterval<CqlDate> s_() {
                    if (onset is Age)
                    {
                        Patient db_ = this.Patient(context);
                        Date dc_ = db_?.BirthDateElement;
                        CqlDate dd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dc_);
                        CqlQuantity de_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate df_ = context.Operators.Add(dd_, de_);
                        Date dh_ = db_?.BirthDateElement;
                        CqlDate di_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dh_);
                        CqlDate dk_ = context.Operators.Add(di_, de_);
                        CqlQuantity dl_ = context.Operators.Quantity(1m, "year");
                        CqlDate dm_ = context.Operators.Add(dk_, dl_);
                        CqlInterval<CqlDate> dn_ = context.Operators.Interval(df_, dm_, true, false);
                        return dn_;
                    }
                    else if (onset is Range)
                    {
                        Patient do_ = this.Patient(context);
                        Date dp_ = do_?.BirthDateElement;
                        CqlDate dq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dp_);
                        Quantity dr_ = (onset as Range)?.Low;
                        CqlQuantity ds_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dr_);
                        CqlDate dt_ = context.Operators.Add(dq_, ds_);
                        Date dv_ = do_?.BirthDateElement;
                        CqlDate dw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dv_);
                        Quantity dx_ = (onset as Range)?.High;
                        CqlQuantity dy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dx_);
                        CqlDate dz_ = context.Operators.Add(dw_, dy_);
                        CqlQuantity ea_ = context.Operators.Quantity(1m, "year");
                        CqlDate eb_ = context.Operators.Add(dz_, ea_);
                        CqlInterval<CqlDate> ec_ = context.Operators.Interval(dt_, eb_, true, false);
                        return ec_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                bool? t_ = (s_())?.highClosed;
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(m_, p_, r_, t_);
                return u_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {

        CqlInterval<CqlDateTime> a_() {
            if (abatement is FhirDateTime)
            {
                CqlDateTime b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
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

                CqlInterval<CqlDate> k_() {
                    if (abatement is Age)
                    {
                        Patient v_ = this.Patient(context);
                        Date w_ = v_?.BirthDateElement;
                        CqlDate x_ = FHIRHelpers_4_0_001.Instance.ToDate(context, w_);
                        CqlQuantity y_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate z_ = context.Operators.Add(x_, y_);
                        Date ab_ = v_?.BirthDateElement;
                        CqlDate ac_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ab_);
                        CqlDate ae_ = context.Operators.Add(ac_, y_);
                        CqlQuantity af_ = context.Operators.Quantity(1m, "year");
                        CqlDate ag_ = context.Operators.Add(ae_, af_);
                        CqlInterval<CqlDate> ah_ = context.Operators.Interval(z_, ag_, true, false);
                        return ah_;
                    }
                    else if (abatement is Range)
                    {
                        Patient ai_ = this.Patient(context);
                        Date aj_ = ai_?.BirthDateElement;
                        CqlDate ak_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aj_);
                        Quantity al_ = (abatement as Range)?.Low;
                        CqlQuantity am_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, al_);
                        CqlDate an_ = context.Operators.Add(ak_, am_);
                        Date ap_ = ai_?.BirthDateElement;
                        CqlDate aq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_);
                        Quantity ar_ = (abatement as Range)?.High;
                        CqlQuantity as_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ar_);
                        CqlDate at_ = context.Operators.Add(aq_, as_);
                        CqlQuantity au_ = context.Operators.Quantity(1m, "year");
                        CqlDate av_ = context.Operators.Add(at_, au_);
                        CqlInterval<CqlDate> aw_ = context.Operators.Interval(an_, av_, true, false);
                        return aw_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                CqlDate l_ = (k_())?.low;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);

                CqlInterval<CqlDate> n_() {
                    if (abatement is Age)
                    {
                        Patient ax_ = this.Patient(context);
                        Date ay_ = ax_?.BirthDateElement;
                        CqlDate az_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ay_);
                        CqlQuantity ba_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate bb_ = context.Operators.Add(az_, ba_);
                        Date bd_ = ax_?.BirthDateElement;
                        CqlDate be_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bd_);
                        CqlDate bg_ = context.Operators.Add(be_, ba_);
                        CqlQuantity bh_ = context.Operators.Quantity(1m, "year");
                        CqlDate bi_ = context.Operators.Add(bg_, bh_);
                        CqlInterval<CqlDate> bj_ = context.Operators.Interval(bb_, bi_, true, false);
                        return bj_;
                    }
                    else if (abatement is Range)
                    {
                        Patient bk_ = this.Patient(context);
                        Date bl_ = bk_?.BirthDateElement;
                        CqlDate bm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bl_);
                        Quantity bn_ = (abatement as Range)?.Low;
                        CqlQuantity bo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bn_);
                        CqlDate bp_ = context.Operators.Add(bm_, bo_);
                        Date br_ = bk_?.BirthDateElement;
                        CqlDate bs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, br_);
                        Quantity bt_ = (abatement as Range)?.High;
                        CqlQuantity bu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bt_);
                        CqlDate bv_ = context.Operators.Add(bs_, bu_);
                        CqlQuantity bw_ = context.Operators.Quantity(1m, "year");
                        CqlDate bx_ = context.Operators.Add(bv_, bw_);
                        CqlInterval<CqlDate> by_ = context.Operators.Interval(bp_, bx_, true, false);
                        return by_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                CqlDate o_ = (n_())?.high;
                CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);

                CqlInterval<CqlDate> q_() {
                    if (abatement is Age)
                    {
                        Patient bz_ = this.Patient(context);
                        Date ca_ = bz_?.BirthDateElement;
                        CqlDate cb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_);
                        CqlQuantity cc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate cd_ = context.Operators.Add(cb_, cc_);
                        Date cf_ = bz_?.BirthDateElement;
                        CqlDate cg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cf_);
                        CqlDate ci_ = context.Operators.Add(cg_, cc_);
                        CqlQuantity cj_ = context.Operators.Quantity(1m, "year");
                        CqlDate ck_ = context.Operators.Add(ci_, cj_);
                        CqlInterval<CqlDate> cl_ = context.Operators.Interval(cd_, ck_, true, false);
                        return cl_;
                    }
                    else if (abatement is Range)
                    {
                        Patient cm_ = this.Patient(context);
                        Date cn_ = cm_?.BirthDateElement;
                        CqlDate co_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cn_);
                        Quantity cp_ = (abatement as Range)?.Low;
                        CqlQuantity cq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cp_);
                        CqlDate cr_ = context.Operators.Add(co_, cq_);
                        Date ct_ = cm_?.BirthDateElement;
                        CqlDate cu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ct_);
                        Quantity cv_ = (abatement as Range)?.High;
                        CqlQuantity cw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cv_);
                        CqlDate cx_ = context.Operators.Add(cu_, cw_);
                        CqlQuantity cy_ = context.Operators.Quantity(1m, "year");
                        CqlDate cz_ = context.Operators.Add(cx_, cy_);
                        CqlInterval<CqlDate> da_ = context.Operators.Interval(cr_, cz_, true, false);
                        return da_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                bool? r_ = (q_())?.lowClosed;

                CqlInterval<CqlDate> s_() {
                    if (abatement is Age)
                    {
                        Patient db_ = this.Patient(context);
                        Date dc_ = db_?.BirthDateElement;
                        CqlDate dd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dc_);
                        CqlQuantity de_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate df_ = context.Operators.Add(dd_, de_);
                        Date dh_ = db_?.BirthDateElement;
                        CqlDate di_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dh_);
                        CqlDate dk_ = context.Operators.Add(di_, de_);
                        CqlQuantity dl_ = context.Operators.Quantity(1m, "year");
                        CqlDate dm_ = context.Operators.Add(dk_, dl_);
                        CqlInterval<CqlDate> dn_ = context.Operators.Interval(df_, dm_, true, false);
                        return dn_;
                    }
                    else if (abatement is Range)
                    {
                        Patient do_ = this.Patient(context);
                        Date dp_ = do_?.BirthDateElement;
                        CqlDate dq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dp_);
                        Quantity dr_ = (abatement as Range)?.Low;
                        CqlQuantity ds_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dr_);
                        CqlDate dt_ = context.Operators.Add(dq_, ds_);
                        Date dv_ = do_?.BirthDateElement;
                        CqlDate dw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dv_);
                        Quantity dx_ = (abatement as Range)?.High;
                        CqlQuantity dy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dx_);
                        CqlDate dz_ = context.Operators.Add(dw_, dy_);
                        CqlQuantity ea_ = context.Operators.Quantity(1m, "year");
                        CqlDate eb_ = context.Operators.Add(dz_, ea_);
                        CqlInterval<CqlDate> ec_ = context.Operators.Interval(dt_, eb_, true, false);
                        return ec_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    };
                }

                bool? t_ = (s_())?.highClosed;
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(m_, p_, r_, t_);
                return u_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        DataType a_ = condition?.Onset;
        CqlInterval<CqlDateTime> b_ = this.Normalize_Onset(context, a_);
        CqlDateTime c_ = context.Operators.Start(b_);
        DataType d_ = condition?.Abatement;
        CqlInterval<CqlDateTime> e_ = this.Normalize_Abatement(context, d_);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlInterval<CqlDateTime> g_ = context.Operators.Interval(c_, f_, true, true);
        return g_;
    }


    [CqlFunctionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {

        CqlInterval<CqlDateTime> a_() {
            if (choice is FhirDateTime)
            {
                CqlDateTime b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);
                return d_;
            }
            else if (choice is Date)
            {
                CqlDate e_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
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
                CqlDateTime o_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, o_, true, true);
                return q_;
            }
            else if (choice is Age)
            {
                Patient r_ = this.Patient(context);
                Date s_ = r_?.BirthDateElement;
                CqlDate t_ = FHIRHelpers_4_0_001.Instance.ToDate(context, s_);
                CqlQuantity u_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate v_ = context.Operators.Add(t_, u_);
                Date x_ = r_?.BirthDateElement;
                CqlDate y_ = FHIRHelpers_4_0_001.Instance.ToDate(context, x_);
                CqlDate aa_ = context.Operators.Add(y_, u_);
                CqlQuantity ab_ = context.Operators.Quantity(1m, "year");
                CqlDate ac_ = context.Operators.Add(aa_, ab_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(v_, ac_, true, false);
                CqlDate ae_ = ad_?.low;
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                Date ah_ = r_?.BirthDateElement;
                CqlDate ai_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ah_);
                CqlDate ak_ = context.Operators.Add(ai_, u_);
                Date am_ = r_?.BirthDateElement;
                CqlDate an_ = FHIRHelpers_4_0_001.Instance.ToDate(context, am_);
                CqlDate ap_ = context.Operators.Add(an_, u_);
                CqlDate ar_ = context.Operators.Add(ap_, ab_);
                CqlInterval<CqlDate> as_ = context.Operators.Interval(ak_, ar_, true, false);
                CqlDate at_ = as_?.high;
                CqlDateTime au_ = context.Operators.ConvertDateToDateTime(at_);
                Date aw_ = r_?.BirthDateElement;
                CqlDate ax_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aw_);
                CqlDate az_ = context.Operators.Add(ax_, u_);
                Date bb_ = r_?.BirthDateElement;
                CqlDate bc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bb_);
                CqlDate be_ = context.Operators.Add(bc_, u_);
                CqlDate bg_ = context.Operators.Add(be_, ab_);
                CqlInterval<CqlDate> bh_ = context.Operators.Interval(az_, bg_, true, false);
                bool? bi_ = bh_?.lowClosed;
                Date bk_ = r_?.BirthDateElement;
                CqlDate bl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bk_);
                CqlDate bn_ = context.Operators.Add(bl_, u_);
                Date bp_ = r_?.BirthDateElement;
                CqlDate bq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bp_);
                CqlDate bs_ = context.Operators.Add(bq_, u_);
                CqlDate bu_ = context.Operators.Add(bs_, ab_);
                CqlInterval<CqlDate> bv_ = context.Operators.Interval(bn_, bu_, true, false);
                bool? bw_ = bv_?.highClosed;
                CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(af_, au_, bi_, bw_);
                return bx_;
            }
            else if (choice is Range)
            {
                Patient by_ = this.Patient(context);
                Date bz_ = by_?.BirthDateElement;
                CqlDate ca_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bz_);
                Quantity cb_ = (choice as Range)?.Low;
                CqlQuantity cc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cb_);
                CqlDate cd_ = context.Operators.Add(ca_, cc_);
                Date cf_ = by_?.BirthDateElement;
                CqlDate cg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cf_);
                Quantity ch_ = (choice as Range)?.High;
                CqlQuantity ci_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ch_);
                CqlDate cj_ = context.Operators.Add(cg_, ci_);
                CqlQuantity ck_ = context.Operators.Quantity(1m, "year");
                CqlDate cl_ = context.Operators.Add(cj_, ck_);
                CqlInterval<CqlDate> cm_ = context.Operators.Interval(cd_, cl_, true, false);
                CqlDate cn_ = cm_?.low;
                CqlDateTime co_ = context.Operators.ConvertDateToDateTime(cn_);
                Date cq_ = by_?.BirthDateElement;
                CqlDate cr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cq_);
                CqlQuantity ct_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cb_);
                CqlDate cu_ = context.Operators.Add(cr_, ct_);
                Date cw_ = by_?.BirthDateElement;
                CqlDate cx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cw_);
                CqlQuantity cz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ch_);
                CqlDate da_ = context.Operators.Add(cx_, cz_);
                CqlDate dc_ = context.Operators.Add(da_, ck_);
                CqlInterval<CqlDate> dd_ = context.Operators.Interval(cu_, dc_, true, false);
                CqlDate de_ = dd_?.high;
                CqlDateTime df_ = context.Operators.ConvertDateToDateTime(de_);
                Date dh_ = by_?.BirthDateElement;
                CqlDate di_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dh_);
                CqlQuantity dk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cb_);
                CqlDate dl_ = context.Operators.Add(di_, dk_);
                Date dn_ = by_?.BirthDateElement;
                CqlDate do_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dn_);
                CqlQuantity dq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ch_);
                CqlDate dr_ = context.Operators.Add(do_, dq_);
                CqlDate dt_ = context.Operators.Add(dr_, ck_);
                CqlInterval<CqlDate> du_ = context.Operators.Interval(dl_, dt_, true, false);
                bool? dv_ = du_?.lowClosed;
                Date dx_ = by_?.BirthDateElement;
                CqlDate dy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dx_);
                CqlQuantity ea_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cb_);
                CqlDate eb_ = context.Operators.Add(dy_, ea_);
                Date ed_ = by_?.BirthDateElement;
                CqlDate ee_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ed_);
                CqlQuantity eg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ch_);
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
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {

        string a_() {

            bool b_() {
                int? c_ = context.Operators.PositionOf("/", uri);
                bool? d_ = context.Operators.Greater(c_, 0);
                return d_ ?? false;
            }

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
        }

        return a_();
    }


    [CqlFunctionDefinition("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
    VSet;


    [CqlFunctionDefinition("First Dates per 31 Day Periods")]
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate a_(CqlDate d) => d;
        IEnumerable<CqlDate> b_ = context.Operators.Select<CqlDate, CqlDate>(DateList, a_);
        IEnumerable<CqlDate> c_ = context.Operators.Distinct<CqlDate>(b_);
        IEnumerable<CqlDate> d_ = context.Operators.ListSort<CqlDate>(c_, System.ComponentModel.ListSortDirection.Ascending);

        bool? e_(CqlDate X) {
            bool? m_ = context.Operators.Not((bool?)(X is null));
            return m_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.Where<CqlDate>(d_, e_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? g_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, f_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] h_ = [
            g_,
        ];

        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? i_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates) {
            IEnumerable<CqlDate> n_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? o_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, n_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] p_ = [
                o_,
            ];

            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? q_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList) {
                IEnumerable<CqlDate> u_ = AnchorList?.SortedList;
                int? v_ = AnchorList?.AnchorIndex;
                CqlDate w_ = context.Operators.Indexer<CqlDate>(u_, v_);

                bool? x_(CqlDate X) {
                    IEnumerable<CqlDate> ah_ = AnchorList?.SortedList;
                    int? ai_ = AnchorList?.AnchorIndex;
                    CqlDate aj_ = context.Operators.Indexer<CqlDate>(ah_, ai_);
                    CqlQuantity ak_ = context.Operators.Quantity(1m, "day");
                    CqlDate al_ = context.Operators.Add(aj_ as CqlDate, ak_);
                    CqlDate ao_ = context.Operators.Indexer<CqlDate>(ah_, ai_);
                    CqlQuantity ap_ = context.Operators.Quantity(30m, "days");
                    CqlDate aq_ = context.Operators.Add(ao_ as CqlDate, ap_);
                    CqlInterval<CqlDate> ar_ = context.Operators.Interval(al_, aq_, true, true);
                    bool? as_ = context.Operators.In<CqlDate>(X, ar_, (string)default);
                    bool? at_ = context.Operators.Not(as_);
                    return at_;
                }

                IEnumerable<CqlDate> y_ = context.Operators.Where<CqlDate>(DateList, x_);
                int? aa_ = context.Operators.Add(v_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ab_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, w_ as CqlDate, y_, aa_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ac_ = [
                    ab_,
                ];

                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ad_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList) {

                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? au_() {

                        bool av_() {
                            IEnumerable<CqlDate> aw_ = FirstList?.NewList;
                            int? ax_ = FirstList?.IndexofNewDate;
                            CqlDate ay_ = context.Operators.Indexer<CqlDate>(aw_, ax_);
                            return ay_ is null;
                        }

                        if (av_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> az_ = FirstList?.NewList;
                            int? ba_ = FirstList?.IndexofNewDate;
                            CqlDate bb_ = context.Operators.Indexer<CqlDate>(az_, ba_);

                            bool? bd_(CqlDate X) {
                                IEnumerable<CqlDate> bn_ = FirstList?.NewList;
                                int? bo_ = FirstList?.IndexofNewDate;
                                CqlDate bp_ = context.Operators.Indexer<CqlDate>(bn_, bo_);
                                CqlQuantity bq_ = context.Operators.Quantity(1m, "day");
                                CqlDate br_ = context.Operators.Add(bp_ as CqlDate, bq_);
                                CqlDate bu_ = context.Operators.Indexer<CqlDate>(bn_, bo_);
                                CqlQuantity bv_ = context.Operators.Quantity(30m, "days");
                                CqlDate bw_ = context.Operators.Add(bu_ as CqlDate, bv_);
                                CqlInterval<CqlDate> bx_ = context.Operators.Interval(br_, bw_, true, true);
                                bool? by_ = context.Operators.In<CqlDate>(X, bx_, (string)default);
                                bool? bz_ = context.Operators.Not(by_);
                                return bz_;
                            }

                            IEnumerable<CqlDate> be_ = context.Operators.Where<CqlDate>(az_, bd_);
                            int? bg_ = context.Operators.Add(ba_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bh_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bb_ as CqlDate, be_, bg_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bi_ = [
                                bh_,
                            ];

                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bj_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList) {

                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ca_() {

                                    bool cb_() {
                                        IEnumerable<CqlDate> cc_ = SecondList?.NewList;
                                        int? cd_ = SecondList?.IndexofNewDate;
                                        CqlDate ce_ = context.Operators.Indexer<CqlDate>(cc_, cd_);
                                        return ce_ is null;
                                    }

                                    if (cb_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> cf_ = SecondList?.NewList;
                                        int? cg_ = SecondList?.IndexofNewDate;
                                        CqlDate ch_ = context.Operators.Indexer<CqlDate>(cf_, cg_);

                                        bool? cj_(CqlDate X) {
                                            IEnumerable<CqlDate> ct_ = SecondList?.NewList;
                                            int? cu_ = SecondList?.IndexofNewDate;
                                            CqlDate cv_ = context.Operators.Indexer<CqlDate>(ct_, cu_);
                                            CqlQuantity cw_ = context.Operators.Quantity(1m, "day");
                                            CqlDate cx_ = context.Operators.Add(cv_ as CqlDate, cw_);
                                            CqlDate da_ = context.Operators.Indexer<CqlDate>(ct_, cu_);
                                            CqlQuantity db_ = context.Operators.Quantity(30m, "days");
                                            CqlDate dc_ = context.Operators.Add(da_ as CqlDate, db_);
                                            CqlInterval<CqlDate> dd_ = context.Operators.Interval(cx_, dc_, true, true);
                                            bool? de_ = context.Operators.In<CqlDate>(X, dd_, (string)default);
                                            bool? df_ = context.Operators.Not(de_);
                                            return df_;
                                        }

                                        IEnumerable<CqlDate> ck_ = context.Operators.Where<CqlDate>(cf_, cj_);
                                        int? cm_ = context.Operators.Add(cg_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cn_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ch_ as CqlDate, ck_, cm_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] co_ = [
                                            cn_,
                                        ];

                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cp_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList) {

                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dg_() {

                                                bool dh_() {
                                                    IEnumerable<CqlDate> di_ = ThirdList?.NewList;
                                                    int? dj_ = ThirdList?.IndexofNewDate;
                                                    CqlDate dk_ = context.Operators.Indexer<CqlDate>(di_, dj_);
                                                    return dk_ is null;
                                                }

                                                if (dh_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> dl_ = ThirdList?.NewList;
                                                    int? dm_ = ThirdList?.IndexofNewDate;
                                                    CqlDate dn_ = context.Operators.Indexer<CqlDate>(dl_, dm_);

                                                    bool? dp_(CqlDate X) {
                                                        IEnumerable<CqlDate> dz_ = ThirdList?.NewList;
                                                        int? ea_ = ThirdList?.IndexofNewDate;
                                                        CqlDate eb_ = context.Operators.Indexer<CqlDate>(dz_, ea_);
                                                        CqlQuantity ec_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate ed_ = context.Operators.Add(eb_ as CqlDate, ec_);
                                                        CqlDate eg_ = context.Operators.Indexer<CqlDate>(dz_, ea_);
                                                        CqlQuantity eh_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate ei_ = context.Operators.Add(eg_ as CqlDate, eh_);
                                                        CqlInterval<CqlDate> ej_ = context.Operators.Interval(ed_, ei_, true, true);
                                                        bool? ek_ = context.Operators.In<CqlDate>(X, ej_, (string)default);
                                                        bool? el_ = context.Operators.Not(ek_);
                                                        return el_;
                                                    }

                                                    IEnumerable<CqlDate> dq_ = context.Operators.Where<CqlDate>(dl_, dp_);
                                                    int? ds_ = context.Operators.Add(dm_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dt_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, dn_ as CqlDate, dq_, ds_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] du_ = [
                                                        dt_,
                                                    ];

                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dv_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList) {

                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? em_() {

                                                            bool en_() {
                                                                IEnumerable<CqlDate> eo_ = FourthList?.NewList;
                                                                int? ep_ = FourthList?.IndexofNewDate;
                                                                CqlDate eq_ = context.Operators.Indexer<CqlDate>(eo_, ep_);
                                                                return eq_ is null;
                                                            }

                                                            if (en_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> er_ = FourthList?.NewList;
                                                                int? es_ = FourthList?.IndexofNewDate;
                                                                CqlDate et_ = context.Operators.Indexer<CqlDate>(er_, es_);

                                                                bool? ev_(CqlDate X) {
                                                                    IEnumerable<CqlDate> ff_ = FourthList?.NewList;
                                                                    int? fg_ = FourthList?.IndexofNewDate;
                                                                    CqlDate fh_ = context.Operators.Indexer<CqlDate>(ff_, fg_);
                                                                    CqlQuantity fi_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate fj_ = context.Operators.Add(fh_ as CqlDate, fi_);
                                                                    CqlDate fm_ = context.Operators.Indexer<CqlDate>(ff_, fg_);
                                                                    CqlQuantity fn_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate fo_ = context.Operators.Add(fm_ as CqlDate, fn_);
                                                                    CqlInterval<CqlDate> fp_ = context.Operators.Interval(fj_, fo_, true, true);
                                                                    bool? fq_ = context.Operators.In<CqlDate>(X, fp_, (string)default);
                                                                    bool? fr_ = context.Operators.Not(fq_);
                                                                    return fr_;
                                                                }

                                                                IEnumerable<CqlDate> ew_ = context.Operators.Where<CqlDate>(er_, ev_);
                                                                int? ey_ = context.Operators.Add(es_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ez_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, et_ as CqlDate, ew_, ey_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fa_ = [
                                                                    ez_,
                                                                ];

                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fb_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList) {

                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fs_() {

                                                                        bool ft_() {
                                                                            IEnumerable<CqlDate> fu_ = FifthList?.NewList;
                                                                            int? fv_ = FifthList?.IndexofNewDate;
                                                                            CqlDate fw_ = context.Operators.Indexer<CqlDate>(fu_, fv_);
                                                                            return fw_ is null;
                                                                        }

                                                                        if (ft_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> fx_ = FifthList?.NewList;
                                                                            int? fy_ = FifthList?.IndexofNewDate;
                                                                            CqlDate fz_ = context.Operators.Indexer<CqlDate>(fx_, fy_);

                                                                            bool? gb_(CqlDate X) {
                                                                                IEnumerable<CqlDate> gl_ = FifthList?.NewList;
                                                                                int? gm_ = FifthList?.IndexofNewDate;
                                                                                CqlDate gn_ = context.Operators.Indexer<CqlDate>(gl_, gm_);
                                                                                CqlQuantity go_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate gp_ = context.Operators.Add(gn_ as CqlDate, go_);
                                                                                CqlDate gs_ = context.Operators.Indexer<CqlDate>(gl_, gm_);
                                                                                CqlQuantity gt_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate gu_ = context.Operators.Add(gs_ as CqlDate, gt_);
                                                                                CqlInterval<CqlDate> gv_ = context.Operators.Interval(gp_, gu_, true, true);
                                                                                bool? gw_ = context.Operators.In<CqlDate>(X, gv_, (string)default);
                                                                                bool? gx_ = context.Operators.Not(gw_);
                                                                                return gx_;
                                                                            }

                                                                            IEnumerable<CqlDate> gc_ = context.Operators.Where<CqlDate>(fx_, gb_);
                                                                            int? ge_ = context.Operators.Add(fy_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gf_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fz_ as CqlDate, gc_, ge_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gg_ = [
                                                                                gf_,
                                                                            ];

                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gh_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList) {

                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gy_() {

                                                                                    bool gz_() {
                                                                                        IEnumerable<CqlDate> ha_ = SixthList?.NewList;
                                                                                        int? hb_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate hc_ = context.Operators.Indexer<CqlDate>(ha_, hb_);
                                                                                        return hc_ is null;
                                                                                    }

                                                                                    if (gz_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> hd_ = SixthList?.NewList;
                                                                                        int? he_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate hf_ = context.Operators.Indexer<CqlDate>(hd_, he_);

                                                                                        bool? hh_(CqlDate X) {
                                                                                            IEnumerable<CqlDate> hr_ = SixthList?.NewList;
                                                                                            int? hs_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate ht_ = context.Operators.Indexer<CqlDate>(hr_, hs_);
                                                                                            CqlQuantity hu_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate hv_ = context.Operators.Add(ht_ as CqlDate, hu_);
                                                                                            CqlDate hy_ = context.Operators.Indexer<CqlDate>(hr_, hs_);
                                                                                            CqlQuantity hz_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate ia_ = context.Operators.Add(hy_ as CqlDate, hz_);
                                                                                            CqlInterval<CqlDate> ib_ = context.Operators.Interval(hv_, ia_, true, true);
                                                                                            bool? ic_ = context.Operators.In<CqlDate>(X, ib_, (string)default);
                                                                                            bool? id_ = context.Operators.Not(ic_);
                                                                                            return id_;
                                                                                        }

                                                                                        IEnumerable<CqlDate> hi_ = context.Operators.Where<CqlDate>(hd_, hh_);
                                                                                        int? hk_ = context.Operators.Add(he_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hl_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hf_ as CqlDate, hi_, hk_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hm_ = [
                                                                                            hl_,
                                                                                        ];

                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hn_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList) {

                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ie_() {

                                                                                                bool if_() {
                                                                                                    IEnumerable<CqlDate> ig_ = SeventhList?.NewList;
                                                                                                    int? ih_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate ii_ = context.Operators.Indexer<CqlDate>(ig_, ih_);
                                                                                                    return ii_ is null;
                                                                                                }

                                                                                                if (if_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> ij_ = SeventhList?.NewList;
                                                                                                    int? ik_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate il_ = context.Operators.Indexer<CqlDate>(ij_, ik_);

                                                                                                    bool? in_(CqlDate X) {
                                                                                                        IEnumerable<CqlDate> ix_ = SeventhList?.NewList;
                                                                                                        int? iy_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate iz_ = context.Operators.Indexer<CqlDate>(ix_, iy_);
                                                                                                        CqlQuantity ja_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate jb_ = context.Operators.Add(iz_ as CqlDate, ja_);
                                                                                                        CqlDate je_ = context.Operators.Indexer<CqlDate>(ix_, iy_);
                                                                                                        CqlQuantity jf_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate jg_ = context.Operators.Add(je_ as CqlDate, jf_);
                                                                                                        CqlInterval<CqlDate> jh_ = context.Operators.Interval(jb_, jg_, true, true);
                                                                                                        bool? ji_ = context.Operators.In<CqlDate>(X, jh_, (string)default);
                                                                                                        bool? jj_ = context.Operators.Not(ji_);
                                                                                                        return jj_;
                                                                                                    }

                                                                                                    IEnumerable<CqlDate> io_ = context.Operators.Where<CqlDate>(ij_, in_);
                                                                                                    int? iq_ = context.Operators.Add(ik_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ir_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, il_ as CqlDate, io_, iq_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] is_ = [
                                                                                                        ir_,
                                                                                                    ];

                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? it_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList) {

                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jk_() {

                                                                                                            bool jl_() {
                                                                                                                IEnumerable<CqlDate> jm_ = EighthList?.NewList;
                                                                                                                int? jn_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate jo_ = context.Operators.Indexer<CqlDate>(jm_, jn_);
                                                                                                                return jo_ is null;
                                                                                                            }

                                                                                                            if (jl_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> jp_ = EighthList?.NewList;
                                                                                                                int? jq_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate jr_ = context.Operators.Indexer<CqlDate>(jp_, jq_);

                                                                                                                bool? jt_(CqlDate X) {
                                                                                                                    IEnumerable<CqlDate> kd_ = EighthList?.NewList;
                                                                                                                    int? ke_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate kf_ = context.Operators.Indexer<CqlDate>(kd_, ke_);
                                                                                                                    CqlQuantity kg_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate kh_ = context.Operators.Add(kf_ as CqlDate, kg_);
                                                                                                                    CqlDate kk_ = context.Operators.Indexer<CqlDate>(kd_, ke_);
                                                                                                                    CqlQuantity kl_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate km_ = context.Operators.Add(kk_ as CqlDate, kl_);
                                                                                                                    CqlInterval<CqlDate> kn_ = context.Operators.Interval(kh_, km_, true, true);
                                                                                                                    bool? ko_ = context.Operators.In<CqlDate>(X, kn_, (string)default);
                                                                                                                    bool? kp_ = context.Operators.Not(ko_);
                                                                                                                    return kp_;
                                                                                                                }

                                                                                                                IEnumerable<CqlDate> ju_ = context.Operators.Where<CqlDate>(jp_, jt_);
                                                                                                                int? jw_ = context.Operators.Add(jq_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jx_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jr_ as CqlDate, ju_, jw_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] jy_ = [
                                                                                                                    jx_,
                                                                                                                ];

                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jz_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList) {

                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kq_() {

                                                                                                                        bool kr_() {
                                                                                                                            IEnumerable<CqlDate> ks_ = NinethList?.NewList;
                                                                                                                            int? kt_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate ku_ = context.Operators.Indexer<CqlDate>(ks_, kt_);
                                                                                                                            return ku_ is null;
                                                                                                                        }

                                                                                                                        if (kr_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> kv_ = NinethList?.NewList;
                                                                                                                            int? kw_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate kx_ = context.Operators.Indexer<CqlDate>(kv_, kw_);

                                                                                                                            bool? kz_(CqlDate X) {
                                                                                                                                IEnumerable<CqlDate> lj_ = NinethList?.NewList;
                                                                                                                                int? lk_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate ll_ = context.Operators.Indexer<CqlDate>(lj_, lk_);
                                                                                                                                CqlQuantity lm_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate ln_ = context.Operators.Add(ll_ as CqlDate, lm_);
                                                                                                                                CqlDate lq_ = context.Operators.Indexer<CqlDate>(lj_, lk_);
                                                                                                                                CqlQuantity lr_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate ls_ = context.Operators.Add(lq_ as CqlDate, lr_);
                                                                                                                                CqlInterval<CqlDate> lt_ = context.Operators.Interval(ln_, ls_, true, true);
                                                                                                                                bool? lu_ = context.Operators.In<CqlDate>(X, lt_, (string)default);
                                                                                                                                bool? lv_ = context.Operators.Not(lu_);
                                                                                                                                return lv_;
                                                                                                                            }

                                                                                                                            IEnumerable<CqlDate> la_ = context.Operators.Where<CqlDate>(kv_, kz_);
                                                                                                                            int? lc_ = context.Operators.Add(kw_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ld_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, kx_ as CqlDate, la_, lc_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] le_ = [
                                                                                                                                ld_,
                                                                                                                            ];

                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lf_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList) {

                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lw_() {

                                                                                                                                    bool lx_() {
                                                                                                                                        IEnumerable<CqlDate> ly_ = TenthList?.NewList;
                                                                                                                                        int? lz_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate ma_ = context.Operators.Indexer<CqlDate>(ly_, lz_);
                                                                                                                                        return ma_ is null;
                                                                                                                                    }

                                                                                                                                    if (lx_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> mb_ = TenthList?.NewList;
                                                                                                                                        int? mc_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate md_ = context.Operators.Indexer<CqlDate>(mb_, mc_);

                                                                                                                                        bool? mf_(CqlDate X) {
                                                                                                                                            IEnumerable<CqlDate> mp_ = TenthList?.NewList;
                                                                                                                                            int? mq_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate mr_ = context.Operators.Indexer<CqlDate>(mp_, mq_);
                                                                                                                                            CqlQuantity ms_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate mt_ = context.Operators.Add(mr_ as CqlDate, ms_);
                                                                                                                                            CqlDate mw_ = context.Operators.Indexer<CqlDate>(mp_, mq_);
                                                                                                                                            CqlQuantity mx_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate my_ = context.Operators.Add(mw_ as CqlDate, mx_);
                                                                                                                                            CqlInterval<CqlDate> mz_ = context.Operators.Interval(mt_, my_, true, true);
                                                                                                                                            bool? na_ = context.Operators.In<CqlDate>(X, mz_, (string)default);
                                                                                                                                            bool? nb_ = context.Operators.Not(na_);
                                                                                                                                            return nb_;
                                                                                                                                        }

                                                                                                                                        IEnumerable<CqlDate> mg_ = context.Operators.Where<CqlDate>(mb_, mf_);
                                                                                                                                        int? mi_ = context.Operators.Add(mc_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mj_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, md_ as CqlDate, mg_, mi_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] mk_ = [
                                                                                                                                            mj_,
                                                                                                                                        ];

                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ml_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList) {

                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nc_() {

                                                                                                                                                bool nd_() {
                                                                                                                                                    IEnumerable<CqlDate> ne_ = EleventhList?.NewList;
                                                                                                                                                    int? nf_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate ng_ = context.Operators.Indexer<CqlDate>(ne_, nf_);
                                                                                                                                                    return ng_ is null;
                                                                                                                                                }

                                                                                                                                                if (nd_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> nh_ = EleventhList?.NewList;
                                                                                                                                                    int? ni_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate nj_ = context.Operators.Indexer<CqlDate>(nh_, ni_);

                                                                                                                                                    bool? nl_(CqlDate X) {
                                                                                                                                                        IEnumerable<CqlDate> nq_ = EleventhList?.NewList;
                                                                                                                                                        int? nr_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate ns_ = context.Operators.Indexer<CqlDate>(nq_, nr_);
                                                                                                                                                        CqlQuantity nt_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate nu_ = context.Operators.Add(ns_ as CqlDate, nt_);
                                                                                                                                                        CqlDate nx_ = context.Operators.Indexer<CqlDate>(nq_, nr_);
                                                                                                                                                        CqlQuantity ny_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate nz_ = context.Operators.Add(nx_ as CqlDate, ny_);
                                                                                                                                                        CqlInterval<CqlDate> oa_ = context.Operators.Interval(nu_, nz_, true, true);
                                                                                                                                                        bool? ob_ = context.Operators.In<CqlDate>(X, oa_, (string)default);
                                                                                                                                                        bool? oc_ = context.Operators.Not(ob_);
                                                                                                                                                        return oc_;
                                                                                                                                                    }

                                                                                                                                                    IEnumerable<CqlDate> nm_ = context.Operators.Where<CqlDate>(nh_, nl_);
                                                                                                                                                    int? no_ = context.Operators.Add(ni_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? np_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, nj_ as CqlDate, nm_, no_);
                                                                                                                                                    return np_;
                                                                                                                                                };
                                                                                                                                            }

                                                                                                                                            return nc_();
                                                                                                                                        }

                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mm_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)mk_, ml_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mn_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mm_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mn_);
                                                                                                                                        return mo_;
                                                                                                                                    };
                                                                                                                                }

                                                                                                                                return lw_();
                                                                                                                            }

                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lg_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)le_, lf_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lg_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? li_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lh_);
                                                                                                                            return li_;
                                                                                                                        };
                                                                                                                    }

                                                                                                                    return kq_();
                                                                                                                }

                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ka_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)jy_, jz_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kb_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ka_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kb_);
                                                                                                                return kc_;
                                                                                                            };
                                                                                                        }

                                                                                                        return jk_();
                                                                                                    }

                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> iu_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)is_, it_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> iv_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(iu_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(iv_);
                                                                                                    return iw_;
                                                                                                };
                                                                                            }

                                                                                            return ie_();
                                                                                        }

                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ho_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hm_, hn_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hp_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ho_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hp_);
                                                                                        return hq_;
                                                                                    };
                                                                                }

                                                                                return gy_();
                                                                            }

                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gi_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gg_, gh_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gj_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gi_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gj_);
                                                                            return gk_;
                                                                        };
                                                                    }

                                                                    return fs_();
                                                                }

                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fc_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fa_, fb_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fd_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fc_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fe_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fd_);
                                                                return fe_;
                                                            };
                                                        }

                                                        return em_();
                                                    }

                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dw_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)du_, dv_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dx_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dw_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dx_);
                                                    return dy_;
                                                };
                                            }

                                            return dg_();
                                        }

                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cq_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)co_, cp_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cr_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cq_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cr_);
                                        return cs_;
                                    };
                                }

                                return ca_();
                            }

                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bk_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bi_, bj_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bl_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bk_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bl_);
                            return bm_;
                        };
                    }

                    return au_();
                }

                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ae_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ac_, ad_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> af_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ae_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ag_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(af_);
                return ag_;
            }

            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> r_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)p_, q_);
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> s_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(r_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? t_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(s_);
            return t_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> j_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)h_, i_);
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(j_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? l_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(k_);
        return l_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAFHIRBase_1_0_0() {}

    public static NCQAFHIRBase_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAFHIRBase";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD = new(
       [typeof(IEnumerable<CqlDate>), typeof(int?)],
       ["SortedList", "AnchorIndex"]);

    private static CqlTupleMetadata CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca = new(
       [typeof(IEnumerable<CqlDate>)],
       ["SortedDates"]);

    private static CqlTupleMetadata CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc = new(
       [typeof(CqlDate), typeof(IEnumerable<CqlDate>), typeof(int?)],
       ["NextDate", "NewList", "IndexofNewDate"]);

    #endregion CqlTupleMetadata Properties

}
