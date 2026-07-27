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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("NCQAFHIRBase", "1.0.0")]
public partial class NCQAFHIRBase_1_0_0 : ILibrary, ISingleton<NCQAFHIRBase_1_0_0>
{
    #region Functions and Expressions (8)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 1413873205984747853L;

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
                CqlInterval<CqlDateTime> c_ = context.Operators.Interval(b_, b_, true, true);
                return c_;
            }
            else if (onset is Period)
            {
                FhirDateTime d_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
                FhirDateTime f_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
                CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
                CqlInterval<CqlDateTime> h_ = context.Operators.Interval(e_, g_, true, true);
                return h_;
            }
            else if (onset is FhirString)
            {
                CqlInterval<CqlDateTime> i_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                return i_;
            }
            else
            {

                CqlInterval<CqlDate> j_() {
                    if (onset is Age)
                    {
                        Patient u_ = this.Patient(context);
                        Date v_ = u_?.BirthDateElement;
                        CqlDate w_ = FHIRHelpers_4_0_001.Instance.ToDate(context, v_);
                        CqlQuantity x_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate y_ = context.Operators.Add(w_, x_);
                        CqlQuantity z_ = context.Operators.Quantity(1m, "year");
                        CqlDate aa_ = context.Operators.Add(y_, z_);
                        CqlInterval<CqlDate> ab_ = context.Operators.Interval(y_, aa_, true, false);
                        return ab_;
                    }
                    else if (onset is Range)
                    {
                        Patient ac_ = this.Patient(context);
                        Date ad_ = ac_?.BirthDateElement;
                        CqlDate ae_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_);
                        Quantity af_ = (onset as Range)?.Low;
                        CqlQuantity ag_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, af_);
                        CqlDate ah_ = context.Operators.Add(ae_, ag_);
                        Quantity ai_ = (onset as Range)?.High;
                        CqlQuantity aj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ai_);
                        CqlDate ak_ = context.Operators.Add(ae_, aj_);
                        CqlQuantity al_ = context.Operators.Quantity(1m, "year");
                        CqlDate am_ = context.Operators.Add(ak_, al_);
                        CqlInterval<CqlDate> an_ = context.Operators.Interval(ah_, am_, true, false);
                        return an_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                CqlDate k_ = (j_())?.low;
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);

                CqlInterval<CqlDate> m_() {
                    if (onset is Age)
                    {
                        Patient ao_ = this.Patient(context);
                        Date ap_ = ao_?.BirthDateElement;
                        CqlDate aq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_);
                        CqlQuantity ar_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate as_ = context.Operators.Add(aq_, ar_);
                        CqlQuantity at_ = context.Operators.Quantity(1m, "year");
                        CqlDate au_ = context.Operators.Add(as_, at_);
                        CqlInterval<CqlDate> av_ = context.Operators.Interval(as_, au_, true, false);
                        return av_;
                    }
                    else if (onset is Range)
                    {
                        Patient aw_ = this.Patient(context);
                        Date ax_ = aw_?.BirthDateElement;
                        CqlDate ay_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ax_);
                        Quantity az_ = (onset as Range)?.Low;
                        CqlQuantity ba_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, az_);
                        CqlDate bb_ = context.Operators.Add(ay_, ba_);
                        Quantity bc_ = (onset as Range)?.High;
                        CqlQuantity bd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bc_);
                        CqlDate be_ = context.Operators.Add(ay_, bd_);
                        CqlQuantity bf_ = context.Operators.Quantity(1m, "year");
                        CqlDate bg_ = context.Operators.Add(be_, bf_);
                        CqlInterval<CqlDate> bh_ = context.Operators.Interval(bb_, bg_, true, false);
                        return bh_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                CqlDate n_ = (m_())?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);

                CqlInterval<CqlDate> p_() {
                    if (onset is Age)
                    {
                        Patient bi_ = this.Patient(context);
                        Date bj_ = bi_?.BirthDateElement;
                        CqlDate bk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bj_);
                        CqlQuantity bl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate bm_ = context.Operators.Add(bk_, bl_);
                        CqlQuantity bn_ = context.Operators.Quantity(1m, "year");
                        CqlDate bo_ = context.Operators.Add(bm_, bn_);
                        CqlInterval<CqlDate> bp_ = context.Operators.Interval(bm_, bo_, true, false);
                        return bp_;
                    }
                    else if (onset is Range)
                    {
                        Patient bq_ = this.Patient(context);
                        Date br_ = bq_?.BirthDateElement;
                        CqlDate bs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, br_);
                        Quantity bt_ = (onset as Range)?.Low;
                        CqlQuantity bu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bt_);
                        CqlDate bv_ = context.Operators.Add(bs_, bu_);
                        Quantity bw_ = (onset as Range)?.High;
                        CqlQuantity bx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bw_);
                        CqlDate by_ = context.Operators.Add(bs_, bx_);
                        CqlQuantity bz_ = context.Operators.Quantity(1m, "year");
                        CqlDate ca_ = context.Operators.Add(by_, bz_);
                        CqlInterval<CqlDate> cb_ = context.Operators.Interval(bv_, ca_, true, false);
                        return cb_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                bool? q_ = (p_())?.lowClosed;

                CqlInterval<CqlDate> r_() {
                    if (onset is Age)
                    {
                        Patient cc_ = this.Patient(context);
                        Date cd_ = cc_?.BirthDateElement;
                        CqlDate ce_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cd_);
                        CqlQuantity cf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate cg_ = context.Operators.Add(ce_, cf_);
                        CqlQuantity ch_ = context.Operators.Quantity(1m, "year");
                        CqlDate ci_ = context.Operators.Add(cg_, ch_);
                        CqlInterval<CqlDate> cj_ = context.Operators.Interval(cg_, ci_, true, false);
                        return cj_;
                    }
                    else if (onset is Range)
                    {
                        Patient ck_ = this.Patient(context);
                        Date cl_ = ck_?.BirthDateElement;
                        CqlDate cm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cl_);
                        Quantity cn_ = (onset as Range)?.Low;
                        CqlQuantity co_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cn_);
                        CqlDate cp_ = context.Operators.Add(cm_, co_);
                        Quantity cq_ = (onset as Range)?.High;
                        CqlQuantity cr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cq_);
                        CqlDate cs_ = context.Operators.Add(cm_, cr_);
                        CqlQuantity ct_ = context.Operators.Quantity(1m, "year");
                        CqlDate cu_ = context.Operators.Add(cs_, ct_);
                        CqlInterval<CqlDate> cv_ = context.Operators.Interval(cp_, cu_, true, false);
                        return cv_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                bool? s_ = (r_())?.highClosed;
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(l_, o_, q_, s_);
                return t_;
            }
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
                CqlInterval<CqlDateTime> c_ = context.Operators.Interval(b_, b_, true, true);
                return c_;
            }
            else if (abatement is Period)
            {
                FhirDateTime d_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
                FhirDateTime f_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
                CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
                CqlInterval<CqlDateTime> h_ = context.Operators.Interval(e_, g_, true, true);
                return h_;
            }
            else if (abatement is FhirString)
            {
                CqlInterval<CqlDateTime> i_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                return i_;
            }
            else
            {

                CqlInterval<CqlDate> j_() {
                    if (abatement is Age)
                    {
                        Patient u_ = this.Patient(context);
                        Date v_ = u_?.BirthDateElement;
                        CqlDate w_ = FHIRHelpers_4_0_001.Instance.ToDate(context, v_);
                        CqlQuantity x_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate y_ = context.Operators.Add(w_, x_);
                        CqlQuantity z_ = context.Operators.Quantity(1m, "year");
                        CqlDate aa_ = context.Operators.Add(y_, z_);
                        CqlInterval<CqlDate> ab_ = context.Operators.Interval(y_, aa_, true, false);
                        return ab_;
                    }
                    else if (abatement is Range)
                    {
                        Patient ac_ = this.Patient(context);
                        Date ad_ = ac_?.BirthDateElement;
                        CqlDate ae_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_);
                        Quantity af_ = (abatement as Range)?.Low;
                        CqlQuantity ag_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, af_);
                        CqlDate ah_ = context.Operators.Add(ae_, ag_);
                        Quantity ai_ = (abatement as Range)?.High;
                        CqlQuantity aj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ai_);
                        CqlDate ak_ = context.Operators.Add(ae_, aj_);
                        CqlQuantity al_ = context.Operators.Quantity(1m, "year");
                        CqlDate am_ = context.Operators.Add(ak_, al_);
                        CqlInterval<CqlDate> an_ = context.Operators.Interval(ah_, am_, true, false);
                        return an_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                CqlDate k_ = (j_())?.low;
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);

                CqlInterval<CqlDate> m_() {
                    if (abatement is Age)
                    {
                        Patient ao_ = this.Patient(context);
                        Date ap_ = ao_?.BirthDateElement;
                        CqlDate aq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ap_);
                        CqlQuantity ar_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate as_ = context.Operators.Add(aq_, ar_);
                        CqlQuantity at_ = context.Operators.Quantity(1m, "year");
                        CqlDate au_ = context.Operators.Add(as_, at_);
                        CqlInterval<CqlDate> av_ = context.Operators.Interval(as_, au_, true, false);
                        return av_;
                    }
                    else if (abatement is Range)
                    {
                        Patient aw_ = this.Patient(context);
                        Date ax_ = aw_?.BirthDateElement;
                        CqlDate ay_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ax_);
                        Quantity az_ = (abatement as Range)?.Low;
                        CqlQuantity ba_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, az_);
                        CqlDate bb_ = context.Operators.Add(ay_, ba_);
                        Quantity bc_ = (abatement as Range)?.High;
                        CqlQuantity bd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bc_);
                        CqlDate be_ = context.Operators.Add(ay_, bd_);
                        CqlQuantity bf_ = context.Operators.Quantity(1m, "year");
                        CqlDate bg_ = context.Operators.Add(be_, bf_);
                        CqlInterval<CqlDate> bh_ = context.Operators.Interval(bb_, bg_, true, false);
                        return bh_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                CqlDate n_ = (m_())?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);

                CqlInterval<CqlDate> p_() {
                    if (abatement is Age)
                    {
                        Patient bi_ = this.Patient(context);
                        Date bj_ = bi_?.BirthDateElement;
                        CqlDate bk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bj_);
                        CqlQuantity bl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate bm_ = context.Operators.Add(bk_, bl_);
                        CqlQuantity bn_ = context.Operators.Quantity(1m, "year");
                        CqlDate bo_ = context.Operators.Add(bm_, bn_);
                        CqlInterval<CqlDate> bp_ = context.Operators.Interval(bm_, bo_, true, false);
                        return bp_;
                    }
                    else if (abatement is Range)
                    {
                        Patient bq_ = this.Patient(context);
                        Date br_ = bq_?.BirthDateElement;
                        CqlDate bs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, br_);
                        Quantity bt_ = (abatement as Range)?.Low;
                        CqlQuantity bu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bt_);
                        CqlDate bv_ = context.Operators.Add(bs_, bu_);
                        Quantity bw_ = (abatement as Range)?.High;
                        CqlQuantity bx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bw_);
                        CqlDate by_ = context.Operators.Add(bs_, bx_);
                        CqlQuantity bz_ = context.Operators.Quantity(1m, "year");
                        CqlDate ca_ = context.Operators.Add(by_, bz_);
                        CqlInterval<CqlDate> cb_ = context.Operators.Interval(bv_, ca_, true, false);
                        return cb_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                bool? q_ = (p_())?.lowClosed;

                CqlInterval<CqlDate> r_() {
                    if (abatement is Age)
                    {
                        Patient cc_ = this.Patient(context);
                        Date cd_ = cc_?.BirthDateElement;
                        CqlDate ce_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cd_);
                        CqlQuantity cf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate cg_ = context.Operators.Add(ce_, cf_);
                        CqlQuantity ch_ = context.Operators.Quantity(1m, "year");
                        CqlDate ci_ = context.Operators.Add(cg_, ch_);
                        CqlInterval<CqlDate> cj_ = context.Operators.Interval(cg_, ci_, true, false);
                        return cj_;
                    }
                    else if (abatement is Range)
                    {
                        Patient ck_ = this.Patient(context);
                        Date cl_ = ck_?.BirthDateElement;
                        CqlDate cm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cl_);
                        Quantity cn_ = (abatement as Range)?.Low;
                        CqlQuantity co_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cn_);
                        CqlDate cp_ = context.Operators.Add(cm_, co_);
                        Quantity cq_ = (abatement as Range)?.High;
                        CqlQuantity cr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cq_);
                        CqlDate cs_ = context.Operators.Add(cm_, cr_);
                        CqlQuantity ct_ = context.Operators.Quantity(1m, "year");
                        CqlDate cu_ = context.Operators.Add(cs_, ct_);
                        CqlInterval<CqlDate> cv_ = context.Operators.Interval(cp_, cu_, true, false);
                        return cv_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                }

                bool? s_ = (r_())?.highClosed;
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(l_, o_, q_, s_);
                return t_;
            }
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
                CqlInterval<CqlDateTime> c_ = context.Operators.Interval(b_, b_, true, true);
                return c_;
            }
            else if (choice is Date)
            {
                CqlDate d_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
                CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
                CqlInterval<CqlDateTime> f_ = context.Operators.Interval(e_, e_, true, true);
                return f_;
            }
            else if (choice is Period)
            {
                FhirDateTime g_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
                CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
                FhirDateTime i_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);
                return k_;
            }
            else if (choice is Instant)
            {
                CqlDateTime l_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> m_ = context.Operators.Interval(l_, l_, true, true);
                return m_;
            }
            else if (choice is Age)
            {
                Patient n_ = this.Patient(context);
                Date o_ = n_?.BirthDateElement;
                CqlDate p_ = FHIRHelpers_4_0_001.Instance.ToDate(context, o_);
                CqlQuantity q_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate r_ = context.Operators.Add(p_, q_);
                CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
                CqlQuantity t_ = context.Operators.Quantity(1m, "year");
                CqlDate u_ = context.Operators.Add(r_, t_);
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, false);
                return w_;
            }
            else if (choice is Range)
            {
                Patient x_ = this.Patient(context);
                Date y_ = x_?.BirthDateElement;
                CqlDate z_ = FHIRHelpers_4_0_001.Instance.ToDate(context, y_);
                Quantity aa_ = (choice as Range)?.Low;
                CqlQuantity ab_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aa_);
                CqlDate ac_ = context.Operators.Add(z_, ab_);
                CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(ac_);
                Quantity ae_ = (choice as Range)?.High;
                CqlQuantity af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_);
                CqlDate ag_ = context.Operators.Add(z_, af_);
                CqlQuantity ah_ = context.Operators.Quantity(1m, "year");
                CqlDate ai_ = context.Operators.Add(ag_, ah_);
                CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ad_, aj_, true, false);
                return ak_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> al_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
                return al_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> am_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                return am_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
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
            }
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
                    IEnumerable<CqlDate> ag_ = AnchorList?.SortedList;
                    int? ah_ = AnchorList?.AnchorIndex;
                    CqlDate ai_ = context.Operators.Indexer<CqlDate>(ag_, ah_);
                    CqlQuantity aj_ = context.Operators.Quantity(1m, "day");
                    CqlDate ak_ = context.Operators.Add(ai_ as CqlDate, aj_);
                    CqlQuantity al_ = context.Operators.Quantity(30m, "days");
                    CqlDate am_ = context.Operators.Add(ai_ as CqlDate, al_);
                    CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                    bool? ao_ = context.Operators.In<CqlDate>(X, an_, (string)default);
                    bool? ap_ = context.Operators.Not(ao_);
                    return ap_;
                }

                IEnumerable<CqlDate> y_ = context.Operators.Where<CqlDate>(DateList, x_);
                int? z_ = context.Operators.Add(v_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aa_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, w_ as CqlDate, y_, z_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ab_ = [
                    aa_,
                ];

                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ac_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList) {

                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aq_() {

                        bool ar_() {
                            IEnumerable<CqlDate> as_ = FirstList?.NewList;
                            int? at_ = FirstList?.IndexofNewDate;
                            CqlDate au_ = context.Operators.Indexer<CqlDate>(as_, at_);
                            return au_ is null;
                        }

                        if (ar_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> av_ = FirstList?.NewList;
                            int? aw_ = FirstList?.IndexofNewDate;
                            CqlDate ax_ = context.Operators.Indexer<CqlDate>(av_, aw_);

                            bool? ay_(CqlDate X) {
                                IEnumerable<CqlDate> bh_ = FirstList?.NewList;
                                int? bi_ = FirstList?.IndexofNewDate;
                                CqlDate bj_ = context.Operators.Indexer<CqlDate>(bh_, bi_);
                                CqlQuantity bk_ = context.Operators.Quantity(1m, "day");
                                CqlDate bl_ = context.Operators.Add(bj_ as CqlDate, bk_);
                                CqlQuantity bm_ = context.Operators.Quantity(30m, "days");
                                CqlDate bn_ = context.Operators.Add(bj_ as CqlDate, bm_);
                                CqlInterval<CqlDate> bo_ = context.Operators.Interval(bl_, bn_, true, true);
                                bool? bp_ = context.Operators.In<CqlDate>(X, bo_, (string)default);
                                bool? bq_ = context.Operators.Not(bp_);
                                return bq_;
                            }

                            IEnumerable<CqlDate> az_ = context.Operators.Where<CqlDate>(av_, ay_);
                            int? ba_ = context.Operators.Add(aw_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bb_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ax_ as CqlDate, az_, ba_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bc_ = [
                                bb_,
                            ];

                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bd_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList) {

                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? br_() {

                                    bool bs_() {
                                        IEnumerable<CqlDate> bt_ = SecondList?.NewList;
                                        int? bu_ = SecondList?.IndexofNewDate;
                                        CqlDate bv_ = context.Operators.Indexer<CqlDate>(bt_, bu_);
                                        return bv_ is null;
                                    }

                                    if (bs_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> bw_ = SecondList?.NewList;
                                        int? bx_ = SecondList?.IndexofNewDate;
                                        CqlDate by_ = context.Operators.Indexer<CqlDate>(bw_, bx_);

                                        bool? bz_(CqlDate X) {
                                            IEnumerable<CqlDate> ci_ = SecondList?.NewList;
                                            int? cj_ = SecondList?.IndexofNewDate;
                                            CqlDate ck_ = context.Operators.Indexer<CqlDate>(ci_, cj_);
                                            CqlQuantity cl_ = context.Operators.Quantity(1m, "day");
                                            CqlDate cm_ = context.Operators.Add(ck_ as CqlDate, cl_);
                                            CqlQuantity cn_ = context.Operators.Quantity(30m, "days");
                                            CqlDate co_ = context.Operators.Add(ck_ as CqlDate, cn_);
                                            CqlInterval<CqlDate> cp_ = context.Operators.Interval(cm_, co_, true, true);
                                            bool? cq_ = context.Operators.In<CqlDate>(X, cp_, (string)default);
                                            bool? cr_ = context.Operators.Not(cq_);
                                            return cr_;
                                        }

                                        IEnumerable<CqlDate> ca_ = context.Operators.Where<CqlDate>(bw_, bz_);
                                        int? cb_ = context.Operators.Add(bx_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cc_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, by_ as CqlDate, ca_, cb_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] cd_ = [
                                            cc_,
                                        ];

                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ce_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList) {

                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cs_() {

                                                bool ct_() {
                                                    IEnumerable<CqlDate> cu_ = ThirdList?.NewList;
                                                    int? cv_ = ThirdList?.IndexofNewDate;
                                                    CqlDate cw_ = context.Operators.Indexer<CqlDate>(cu_, cv_);
                                                    return cw_ is null;
                                                }

                                                if (ct_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> cx_ = ThirdList?.NewList;
                                                    int? cy_ = ThirdList?.IndexofNewDate;
                                                    CqlDate cz_ = context.Operators.Indexer<CqlDate>(cx_, cy_);

                                                    bool? da_(CqlDate X) {
                                                        IEnumerable<CqlDate> dj_ = ThirdList?.NewList;
                                                        int? dk_ = ThirdList?.IndexofNewDate;
                                                        CqlDate dl_ = context.Operators.Indexer<CqlDate>(dj_, dk_);
                                                        CqlQuantity dm_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate dn_ = context.Operators.Add(dl_ as CqlDate, dm_);
                                                        CqlQuantity do_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate dp_ = context.Operators.Add(dl_ as CqlDate, do_);
                                                        CqlInterval<CqlDate> dq_ = context.Operators.Interval(dn_, dp_, true, true);
                                                        bool? dr_ = context.Operators.In<CqlDate>(X, dq_, (string)default);
                                                        bool? ds_ = context.Operators.Not(dr_);
                                                        return ds_;
                                                    }

                                                    IEnumerable<CqlDate> db_ = context.Operators.Where<CqlDate>(cx_, da_);
                                                    int? dc_ = context.Operators.Add(cy_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dd_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, cz_ as CqlDate, db_, dc_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] de_ = [
                                                        dd_,
                                                    ];

                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? df_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList) {

                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dt_() {

                                                            bool du_() {
                                                                IEnumerable<CqlDate> dv_ = FourthList?.NewList;
                                                                int? dw_ = FourthList?.IndexofNewDate;
                                                                CqlDate dx_ = context.Operators.Indexer<CqlDate>(dv_, dw_);
                                                                return dx_ is null;
                                                            }

                                                            if (du_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> dy_ = FourthList?.NewList;
                                                                int? dz_ = FourthList?.IndexofNewDate;
                                                                CqlDate ea_ = context.Operators.Indexer<CqlDate>(dy_, dz_);

                                                                bool? eb_(CqlDate X) {
                                                                    IEnumerable<CqlDate> ek_ = FourthList?.NewList;
                                                                    int? el_ = FourthList?.IndexofNewDate;
                                                                    CqlDate em_ = context.Operators.Indexer<CqlDate>(ek_, el_);
                                                                    CqlQuantity en_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate eo_ = context.Operators.Add(em_ as CqlDate, en_);
                                                                    CqlQuantity ep_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate eq_ = context.Operators.Add(em_ as CqlDate, ep_);
                                                                    CqlInterval<CqlDate> er_ = context.Operators.Interval(eo_, eq_, true, true);
                                                                    bool? es_ = context.Operators.In<CqlDate>(X, er_, (string)default);
                                                                    bool? et_ = context.Operators.Not(es_);
                                                                    return et_;
                                                                }

                                                                IEnumerable<CqlDate> ec_ = context.Operators.Where<CqlDate>(dy_, eb_);
                                                                int? ed_ = context.Operators.Add(dz_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ee_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ea_ as CqlDate, ec_, ed_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ef_ = [
                                                                    ee_,
                                                                ];

                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eg_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList) {

                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eu_() {

                                                                        bool ev_() {
                                                                            IEnumerable<CqlDate> ew_ = FifthList?.NewList;
                                                                            int? ex_ = FifthList?.IndexofNewDate;
                                                                            CqlDate ey_ = context.Operators.Indexer<CqlDate>(ew_, ex_);
                                                                            return ey_ is null;
                                                                        }

                                                                        if (ev_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> ez_ = FifthList?.NewList;
                                                                            int? fa_ = FifthList?.IndexofNewDate;
                                                                            CqlDate fb_ = context.Operators.Indexer<CqlDate>(ez_, fa_);

                                                                            bool? fc_(CqlDate X) {
                                                                                IEnumerable<CqlDate> fl_ = FifthList?.NewList;
                                                                                int? fm_ = FifthList?.IndexofNewDate;
                                                                                CqlDate fn_ = context.Operators.Indexer<CqlDate>(fl_, fm_);
                                                                                CqlQuantity fo_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate fp_ = context.Operators.Add(fn_ as CqlDate, fo_);
                                                                                CqlQuantity fq_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate fr_ = context.Operators.Add(fn_ as CqlDate, fq_);
                                                                                CqlInterval<CqlDate> fs_ = context.Operators.Interval(fp_, fr_, true, true);
                                                                                bool? ft_ = context.Operators.In<CqlDate>(X, fs_, (string)default);
                                                                                bool? fu_ = context.Operators.Not(ft_);
                                                                                return fu_;
                                                                            }

                                                                            IEnumerable<CqlDate> fd_ = context.Operators.Where<CqlDate>(ez_, fc_);
                                                                            int? fe_ = context.Operators.Add(fa_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ff_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fb_ as CqlDate, fd_, fe_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fg_ = [
                                                                                ff_,
                                                                            ];

                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fh_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList) {

                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fv_() {

                                                                                    bool fw_() {
                                                                                        IEnumerable<CqlDate> fx_ = SixthList?.NewList;
                                                                                        int? fy_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate fz_ = context.Operators.Indexer<CqlDate>(fx_, fy_);
                                                                                        return fz_ is null;
                                                                                    }

                                                                                    if (fw_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> ga_ = SixthList?.NewList;
                                                                                        int? gb_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate gc_ = context.Operators.Indexer<CqlDate>(ga_, gb_);

                                                                                        bool? gd_(CqlDate X) {
                                                                                            IEnumerable<CqlDate> gm_ = SixthList?.NewList;
                                                                                            int? gn_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate go_ = context.Operators.Indexer<CqlDate>(gm_, gn_);
                                                                                            CqlQuantity gp_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate gq_ = context.Operators.Add(go_ as CqlDate, gp_);
                                                                                            CqlQuantity gr_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate gs_ = context.Operators.Add(go_ as CqlDate, gr_);
                                                                                            CqlInterval<CqlDate> gt_ = context.Operators.Interval(gq_, gs_, true, true);
                                                                                            bool? gu_ = context.Operators.In<CqlDate>(X, gt_, (string)default);
                                                                                            bool? gv_ = context.Operators.Not(gu_);
                                                                                            return gv_;
                                                                                        }

                                                                                        IEnumerable<CqlDate> ge_ = context.Operators.Where<CqlDate>(ga_, gd_);
                                                                                        int? gf_ = context.Operators.Add(gb_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gc_ as CqlDate, ge_, gf_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gh_ = [
                                                                                            gg_,
                                                                                        ];

                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList) {

                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gw_() {

                                                                                                bool gx_() {
                                                                                                    IEnumerable<CqlDate> gy_ = SeventhList?.NewList;
                                                                                                    int? gz_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate ha_ = context.Operators.Indexer<CqlDate>(gy_, gz_);
                                                                                                    return ha_ is null;
                                                                                                }

                                                                                                if (gx_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> hb_ = SeventhList?.NewList;
                                                                                                    int? hc_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate hd_ = context.Operators.Indexer<CqlDate>(hb_, hc_);

                                                                                                    bool? he_(CqlDate X) {
                                                                                                        IEnumerable<CqlDate> hn_ = SeventhList?.NewList;
                                                                                                        int? ho_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate hp_ = context.Operators.Indexer<CqlDate>(hn_, ho_);
                                                                                                        CqlQuantity hq_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate hr_ = context.Operators.Add(hp_ as CqlDate, hq_);
                                                                                                        CqlQuantity hs_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate ht_ = context.Operators.Add(hp_ as CqlDate, hs_);
                                                                                                        CqlInterval<CqlDate> hu_ = context.Operators.Interval(hr_, ht_, true, true);
                                                                                                        bool? hv_ = context.Operators.In<CqlDate>(X, hu_, (string)default);
                                                                                                        bool? hw_ = context.Operators.Not(hv_);
                                                                                                        return hw_;
                                                                                                    }

                                                                                                    IEnumerable<CqlDate> hf_ = context.Operators.Where<CqlDate>(hb_, he_);
                                                                                                    int? hg_ = context.Operators.Add(hc_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hh_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hd_ as CqlDate, hf_, hg_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hi_ = [
                                                                                                        hh_,
                                                                                                    ];

                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hj_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList) {

                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hx_() {

                                                                                                            bool hy_() {
                                                                                                                IEnumerable<CqlDate> hz_ = EighthList?.NewList;
                                                                                                                int? ia_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate ib_ = context.Operators.Indexer<CqlDate>(hz_, ia_);
                                                                                                                return ib_ is null;
                                                                                                            }

                                                                                                            if (hy_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> ic_ = EighthList?.NewList;
                                                                                                                int? id_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate ie_ = context.Operators.Indexer<CqlDate>(ic_, id_);

                                                                                                                bool? if_(CqlDate X) {
                                                                                                                    IEnumerable<CqlDate> io_ = EighthList?.NewList;
                                                                                                                    int? ip_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate iq_ = context.Operators.Indexer<CqlDate>(io_, ip_);
                                                                                                                    CqlQuantity ir_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate is_ = context.Operators.Add(iq_ as CqlDate, ir_);
                                                                                                                    CqlQuantity it_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate iu_ = context.Operators.Add(iq_ as CqlDate, it_);
                                                                                                                    CqlInterval<CqlDate> iv_ = context.Operators.Interval(is_, iu_, true, true);
                                                                                                                    bool? iw_ = context.Operators.In<CqlDate>(X, iv_, (string)default);
                                                                                                                    bool? ix_ = context.Operators.Not(iw_);
                                                                                                                    return ix_;
                                                                                                                }

                                                                                                                IEnumerable<CqlDate> ig_ = context.Operators.Where<CqlDate>(ic_, if_);
                                                                                                                int? ih_ = context.Operators.Add(id_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ii_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ie_ as CqlDate, ig_, ih_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ij_ = [
                                                                                                                    ii_,
                                                                                                                ];

                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ik_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList) {

                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iy_() {

                                                                                                                        bool iz_() {
                                                                                                                            IEnumerable<CqlDate> ja_ = NinethList?.NewList;
                                                                                                                            int? jb_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate jc_ = context.Operators.Indexer<CqlDate>(ja_, jb_);
                                                                                                                            return jc_ is null;
                                                                                                                        }

                                                                                                                        if (iz_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> jd_ = NinethList?.NewList;
                                                                                                                            int? je_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate jf_ = context.Operators.Indexer<CqlDate>(jd_, je_);

                                                                                                                            bool? jg_(CqlDate X) {
                                                                                                                                IEnumerable<CqlDate> jp_ = NinethList?.NewList;
                                                                                                                                int? jq_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate jr_ = context.Operators.Indexer<CqlDate>(jp_, jq_);
                                                                                                                                CqlQuantity js_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate jt_ = context.Operators.Add(jr_ as CqlDate, js_);
                                                                                                                                CqlQuantity ju_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate jv_ = context.Operators.Add(jr_ as CqlDate, ju_);
                                                                                                                                CqlInterval<CqlDate> jw_ = context.Operators.Interval(jt_, jv_, true, true);
                                                                                                                                bool? jx_ = context.Operators.In<CqlDate>(X, jw_, (string)default);
                                                                                                                                bool? jy_ = context.Operators.Not(jx_);
                                                                                                                                return jy_;
                                                                                                                            }

                                                                                                                            IEnumerable<CqlDate> jh_ = context.Operators.Where<CqlDate>(jd_, jg_);
                                                                                                                            int? ji_ = context.Operators.Add(je_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jj_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jf_ as CqlDate, jh_, ji_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] jk_ = [
                                                                                                                                jj_,
                                                                                                                            ];

                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jl_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList) {

                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jz_() {

                                                                                                                                    bool ka_() {
                                                                                                                                        IEnumerable<CqlDate> kb_ = TenthList?.NewList;
                                                                                                                                        int? kc_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate kd_ = context.Operators.Indexer<CqlDate>(kb_, kc_);
                                                                                                                                        return kd_ is null;
                                                                                                                                    }

                                                                                                                                    if (ka_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> ke_ = TenthList?.NewList;
                                                                                                                                        int? kf_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate kg_ = context.Operators.Indexer<CqlDate>(ke_, kf_);

                                                                                                                                        bool? kh_(CqlDate X) {
                                                                                                                                            IEnumerable<CqlDate> kq_ = TenthList?.NewList;
                                                                                                                                            int? kr_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate ks_ = context.Operators.Indexer<CqlDate>(kq_, kr_);
                                                                                                                                            CqlQuantity kt_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate ku_ = context.Operators.Add(ks_ as CqlDate, kt_);
                                                                                                                                            CqlQuantity kv_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate kw_ = context.Operators.Add(ks_ as CqlDate, kv_);
                                                                                                                                            CqlInterval<CqlDate> kx_ = context.Operators.Interval(ku_, kw_, true, true);
                                                                                                                                            bool? ky_ = context.Operators.In<CqlDate>(X, kx_, (string)default);
                                                                                                                                            bool? kz_ = context.Operators.Not(ky_);
                                                                                                                                            return kz_;
                                                                                                                                        }

                                                                                                                                        IEnumerable<CqlDate> ki_ = context.Operators.Where<CqlDate>(ke_, kh_);
                                                                                                                                        int? kj_ = context.Operators.Add(kf_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kk_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, kg_ as CqlDate, ki_, kj_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] kl_ = [
                                                                                                                                            kk_,
                                                                                                                                        ];

                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? km_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList) {

                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? la_() {

                                                                                                                                                bool lb_() {
                                                                                                                                                    IEnumerable<CqlDate> lc_ = EleventhList?.NewList;
                                                                                                                                                    int? ld_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate le_ = context.Operators.Indexer<CqlDate>(lc_, ld_);
                                                                                                                                                    return le_ is null;
                                                                                                                                                }

                                                                                                                                                if (lb_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> lf_ = EleventhList?.NewList;
                                                                                                                                                    int? lg_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate lh_ = context.Operators.Indexer<CqlDate>(lf_, lg_);

                                                                                                                                                    bool? li_(CqlDate X) {
                                                                                                                                                        IEnumerable<CqlDate> lm_ = EleventhList?.NewList;
                                                                                                                                                        int? ln_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate lo_ = context.Operators.Indexer<CqlDate>(lm_, ln_);
                                                                                                                                                        CqlQuantity lp_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate lq_ = context.Operators.Add(lo_ as CqlDate, lp_);
                                                                                                                                                        CqlQuantity lr_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate ls_ = context.Operators.Add(lo_ as CqlDate, lr_);
                                                                                                                                                        CqlInterval<CqlDate> lt_ = context.Operators.Interval(lq_, ls_, true, true);
                                                                                                                                                        bool? lu_ = context.Operators.In<CqlDate>(X, lt_, (string)default);
                                                                                                                                                        bool? lv_ = context.Operators.Not(lu_);
                                                                                                                                                        return lv_;
                                                                                                                                                    }

                                                                                                                                                    IEnumerable<CqlDate> lj_ = context.Operators.Where<CqlDate>(lf_, li_);
                                                                                                                                                    int? lk_ = context.Operators.Add(lg_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ll_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, lh_ as CqlDate, lj_, lk_);
                                                                                                                                                    return ll_;
                                                                                                                                                }
                                                                                                                                            }

                                                                                                                                            return la_();
                                                                                                                                        }

                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kn_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)kl_, km_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ko_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kn_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ko_);
                                                                                                                                        return kp_;
                                                                                                                                    }
                                                                                                                                }

                                                                                                                                return jz_();
                                                                                                                            }

                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jm_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)jk_, jl_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jn_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jm_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jn_);
                                                                                                                            return jo_;
                                                                                                                        }
                                                                                                                    }

                                                                                                                    return iy_();
                                                                                                                }

                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> il_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ij_, ik_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> im_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(il_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? in_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(im_);
                                                                                                                return in_;
                                                                                                            }
                                                                                                        }

                                                                                                        return hx_();
                                                                                                    }

                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hk_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hi_, hj_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hl_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hk_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hl_);
                                                                                                    return hm_;
                                                                                                }
                                                                                            }

                                                                                            return gw_();
                                                                                        }

                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gh_, gi_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gj_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gk_);
                                                                                        return gl_;
                                                                                    }
                                                                                }

                                                                                return fv_();
                                                                            }

                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fi_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fg_, fh_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fj_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fi_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fj_);
                                                                            return fk_;
                                                                        }
                                                                    }

                                                                    return eu_();
                                                                }

                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> eh_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ef_, eg_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ei_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(eh_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ej_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ei_);
                                                                return ej_;
                                                            }
                                                        }

                                                        return dt_();
                                                    }

                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dg_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)de_, df_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dg_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? di_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dh_);
                                                    return di_;
                                                }
                                            }

                                            return cs_();
                                        }

                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cd_, ce_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cf_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ch_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cg_);
                                        return ch_;
                                    }
                                }

                                return br_();
                            }

                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> be_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bc_, bd_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bf_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(be_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bf_);
                            return bg_;
                        }
                    }

                    return aq_();
                }

                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ad_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ab_, ac_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ae_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ad_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? af_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ae_);
                return af_;
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
