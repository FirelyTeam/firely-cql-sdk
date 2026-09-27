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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.5.0")]
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
        if (onset is FhirDateTime a_)
        {
            CqlDateTime b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, a_);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(b_, b_, true, true);
            return c_;
        }
        else
        {
            if (onset is Period d_)
            {
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_.StartElement);
                CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(d_.EndElement);
                CqlInterval<CqlDateTime> g_ = context.Operators.Interval(e_, f_, true, true);
                return g_;
            }
            else
            {
                if (onset is FhirString h_)
                {
                    CqlInterval<CqlDateTime> i_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                    return i_;
                }
                else
                {
                    CqlInterval<CqlDate> k_;
                    if (onset is Age j_)
                    {
                        Patient y_ = this.Patient(context);
                        Date z_ = y_?.BirthDateElement;
                        CqlDate aa_ = FHIRHelpers_4_0_001.Instance.ToDate(context, z_);
                        CqlQuantity ab_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, j_);
                        CqlDate ac_ = context.Operators.Add(aa_, ab_);
                        CqlQuantity ad_ = context.Operators.Quantity(1m, "year");
                        CqlDate ae_ = context.Operators.Add(ac_, ad_);
                        CqlInterval<CqlDate> af_ = context.Operators.Interval(ac_, ae_, true, false);
                        k_ = af_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> ah_;
                        if (onset is Range ag_)
                        {
                            Patient ai_ = this.Patient(context);
                            Date aj_ = ai_?.BirthDateElement;
                            CqlDate ak_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aj_);
                            CqlQuantity al_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ag_.Low);
                            CqlDate am_ = context.Operators.Add(ak_, al_);
                            CqlQuantity an_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ag_.High);
                            CqlDate ao_ = context.Operators.Add(ak_, an_);
                            CqlQuantity ap_ = context.Operators.Quantity(1m, "year");
                            CqlDate aq_ = context.Operators.Add(ao_, ap_);
                            CqlInterval<CqlDate> ar_ = context.Operators.Interval(am_, aq_, true, false);
                            ah_ = ar_;
                        }
                        else
                        {
                            ah_ = null as CqlInterval<CqlDate>;
                        }
                        k_ = ah_;
                    }
                    CqlDate l_ = k_?.low;
                    CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                    CqlInterval<CqlDate> o_;
                    if (onset is Age n_)
                    {
                        Patient as_ = this.Patient(context);
                        Date at_ = as_?.BirthDateElement;
                        CqlDate au_ = FHIRHelpers_4_0_001.Instance.ToDate(context, at_);
                        CqlQuantity av_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, n_);
                        CqlDate aw_ = context.Operators.Add(au_, av_);
                        CqlQuantity ax_ = context.Operators.Quantity(1m, "year");
                        CqlDate ay_ = context.Operators.Add(aw_, ax_);
                        CqlInterval<CqlDate> az_ = context.Operators.Interval(aw_, ay_, true, false);
                        o_ = az_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> bb_;
                        if (onset is Range ba_)
                        {
                            Patient bc_ = this.Patient(context);
                            Date bd_ = bc_?.BirthDateElement;
                            CqlDate be_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bd_);
                            CqlQuantity bf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ba_.Low);
                            CqlDate bg_ = context.Operators.Add(be_, bf_);
                            CqlQuantity bh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ba_.High);
                            CqlDate bi_ = context.Operators.Add(be_, bh_);
                            CqlQuantity bj_ = context.Operators.Quantity(1m, "year");
                            CqlDate bk_ = context.Operators.Add(bi_, bj_);
                            CqlInterval<CqlDate> bl_ = context.Operators.Interval(bg_, bk_, true, false);
                            bb_ = bl_;
                        }
                        else
                        {
                            bb_ = null as CqlInterval<CqlDate>;
                        }
                        o_ = bb_;
                    }
                    CqlDate p_ = o_?.high;
                    CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                    CqlInterval<CqlDate> s_;
                    if (onset is Age r_)
                    {
                        Patient bm_ = this.Patient(context);
                        Date bn_ = bm_?.BirthDateElement;
                        CqlDate bo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bn_);
                        CqlQuantity bp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, r_);
                        CqlDate bq_ = context.Operators.Add(bo_, bp_);
                        CqlQuantity br_ = context.Operators.Quantity(1m, "year");
                        CqlDate bs_ = context.Operators.Add(bq_, br_);
                        CqlInterval<CqlDate> bt_ = context.Operators.Interval(bq_, bs_, true, false);
                        s_ = bt_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> bv_;
                        if (onset is Range bu_)
                        {
                            Patient bw_ = this.Patient(context);
                            Date bx_ = bw_?.BirthDateElement;
                            CqlDate by_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bx_);
                            CqlQuantity bz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bu_.Low);
                            CqlDate ca_ = context.Operators.Add(by_, bz_);
                            CqlQuantity cb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bu_.High);
                            CqlDate cc_ = context.Operators.Add(by_, cb_);
                            CqlQuantity cd_ = context.Operators.Quantity(1m, "year");
                            CqlDate ce_ = context.Operators.Add(cc_, cd_);
                            CqlInterval<CqlDate> cf_ = context.Operators.Interval(ca_, ce_, true, false);
                            bv_ = cf_;
                        }
                        else
                        {
                            bv_ = null as CqlInterval<CqlDate>;
                        }
                        s_ = bv_;
                    }
                    bool? t_ = s_?.lowClosed;
                    CqlInterval<CqlDate> v_;
                    if (onset is Age u_)
                    {
                        Patient cg_ = this.Patient(context);
                        Date ch_ = cg_?.BirthDateElement;
                        CqlDate ci_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ch_);
                        CqlQuantity cj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, u_);
                        CqlDate ck_ = context.Operators.Add(ci_, cj_);
                        CqlQuantity cl_ = context.Operators.Quantity(1m, "year");
                        CqlDate cm_ = context.Operators.Add(ck_, cl_);
                        CqlInterval<CqlDate> cn_ = context.Operators.Interval(ck_, cm_, true, false);
                        v_ = cn_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> cp_;
                        if (onset is Range co_)
                        {
                            Patient cq_ = this.Patient(context);
                            Date cr_ = cq_?.BirthDateElement;
                            CqlDate cs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cr_);
                            CqlQuantity ct_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, co_.Low);
                            CqlDate cu_ = context.Operators.Add(cs_, ct_);
                            CqlQuantity cv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, co_.High);
                            CqlDate cw_ = context.Operators.Add(cs_, cv_);
                            CqlQuantity cx_ = context.Operators.Quantity(1m, "year");
                            CqlDate cy_ = context.Operators.Add(cw_, cx_);
                            CqlInterval<CqlDate> cz_ = context.Operators.Interval(cu_, cy_, true, false);
                            cp_ = cz_;
                        }
                        else
                        {
                            cp_ = null as CqlInterval<CqlDate>;
                        }
                        v_ = cp_;
                    }
                    bool? w_ = v_?.highClosed;
                    CqlInterval<CqlDateTime> x_ = context.Operators.Interval(m_, q_, t_, w_);
                    return x_;
                }
            }
        }
    }


    [CqlFunctionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        if (abatement is FhirDateTime a_)
        {
            CqlDateTime b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, a_);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(b_, b_, true, true);
            return c_;
        }
        else
        {
            if (abatement is Period d_)
            {
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_.StartElement);
                CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(d_.EndElement);
                CqlInterval<CqlDateTime> g_ = context.Operators.Interval(e_, f_, true, true);
                return g_;
            }
            else
            {
                if (abatement is FhirString h_)
                {
                    CqlInterval<CqlDateTime> i_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                    return i_;
                }
                else
                {
                    CqlInterval<CqlDate> k_;
                    if (abatement is Age j_)
                    {
                        Patient y_ = this.Patient(context);
                        Date z_ = y_?.BirthDateElement;
                        CqlDate aa_ = FHIRHelpers_4_0_001.Instance.ToDate(context, z_);
                        CqlQuantity ab_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, j_);
                        CqlDate ac_ = context.Operators.Add(aa_, ab_);
                        CqlQuantity ad_ = context.Operators.Quantity(1m, "year");
                        CqlDate ae_ = context.Operators.Add(ac_, ad_);
                        CqlInterval<CqlDate> af_ = context.Operators.Interval(ac_, ae_, true, false);
                        k_ = af_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> ah_;
                        if (abatement is Range ag_)
                        {
                            Patient ai_ = this.Patient(context);
                            Date aj_ = ai_?.BirthDateElement;
                            CqlDate ak_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aj_);
                            CqlQuantity al_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ag_.Low);
                            CqlDate am_ = context.Operators.Add(ak_, al_);
                            CqlQuantity an_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ag_.High);
                            CqlDate ao_ = context.Operators.Add(ak_, an_);
                            CqlQuantity ap_ = context.Operators.Quantity(1m, "year");
                            CqlDate aq_ = context.Operators.Add(ao_, ap_);
                            CqlInterval<CqlDate> ar_ = context.Operators.Interval(am_, aq_, true, false);
                            ah_ = ar_;
                        }
                        else
                        {
                            ah_ = null as CqlInterval<CqlDate>;
                        }
                        k_ = ah_;
                    }
                    CqlDate l_ = k_?.low;
                    CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                    CqlInterval<CqlDate> o_;
                    if (abatement is Age n_)
                    {
                        Patient as_ = this.Patient(context);
                        Date at_ = as_?.BirthDateElement;
                        CqlDate au_ = FHIRHelpers_4_0_001.Instance.ToDate(context, at_);
                        CqlQuantity av_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, n_);
                        CqlDate aw_ = context.Operators.Add(au_, av_);
                        CqlQuantity ax_ = context.Operators.Quantity(1m, "year");
                        CqlDate ay_ = context.Operators.Add(aw_, ax_);
                        CqlInterval<CqlDate> az_ = context.Operators.Interval(aw_, ay_, true, false);
                        o_ = az_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> bb_;
                        if (abatement is Range ba_)
                        {
                            Patient bc_ = this.Patient(context);
                            Date bd_ = bc_?.BirthDateElement;
                            CqlDate be_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bd_);
                            CqlQuantity bf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ba_.Low);
                            CqlDate bg_ = context.Operators.Add(be_, bf_);
                            CqlQuantity bh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ba_.High);
                            CqlDate bi_ = context.Operators.Add(be_, bh_);
                            CqlQuantity bj_ = context.Operators.Quantity(1m, "year");
                            CqlDate bk_ = context.Operators.Add(bi_, bj_);
                            CqlInterval<CqlDate> bl_ = context.Operators.Interval(bg_, bk_, true, false);
                            bb_ = bl_;
                        }
                        else
                        {
                            bb_ = null as CqlInterval<CqlDate>;
                        }
                        o_ = bb_;
                    }
                    CqlDate p_ = o_?.high;
                    CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                    CqlInterval<CqlDate> s_;
                    if (abatement is Age r_)
                    {
                        Patient bm_ = this.Patient(context);
                        Date bn_ = bm_?.BirthDateElement;
                        CqlDate bo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bn_);
                        CqlQuantity bp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, r_);
                        CqlDate bq_ = context.Operators.Add(bo_, bp_);
                        CqlQuantity br_ = context.Operators.Quantity(1m, "year");
                        CqlDate bs_ = context.Operators.Add(bq_, br_);
                        CqlInterval<CqlDate> bt_ = context.Operators.Interval(bq_, bs_, true, false);
                        s_ = bt_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> bv_;
                        if (abatement is Range bu_)
                        {
                            Patient bw_ = this.Patient(context);
                            Date bx_ = bw_?.BirthDateElement;
                            CqlDate by_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bx_);
                            CqlQuantity bz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bu_.Low);
                            CqlDate ca_ = context.Operators.Add(by_, bz_);
                            CqlQuantity cb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bu_.High);
                            CqlDate cc_ = context.Operators.Add(by_, cb_);
                            CqlQuantity cd_ = context.Operators.Quantity(1m, "year");
                            CqlDate ce_ = context.Operators.Add(cc_, cd_);
                            CqlInterval<CqlDate> cf_ = context.Operators.Interval(ca_, ce_, true, false);
                            bv_ = cf_;
                        }
                        else
                        {
                            bv_ = null as CqlInterval<CqlDate>;
                        }
                        s_ = bv_;
                    }
                    bool? t_ = s_?.lowClosed;
                    CqlInterval<CqlDate> v_;
                    if (abatement is Age u_)
                    {
                        Patient cg_ = this.Patient(context);
                        Date ch_ = cg_?.BirthDateElement;
                        CqlDate ci_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ch_);
                        CqlQuantity cj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, u_);
                        CqlDate ck_ = context.Operators.Add(ci_, cj_);
                        CqlQuantity cl_ = context.Operators.Quantity(1m, "year");
                        CqlDate cm_ = context.Operators.Add(ck_, cl_);
                        CqlInterval<CqlDate> cn_ = context.Operators.Interval(ck_, cm_, true, false);
                        v_ = cn_;
                    }
                    else
                    {
                        CqlInterval<CqlDate> cp_;
                        if (abatement is Range co_)
                        {
                            Patient cq_ = this.Patient(context);
                            Date cr_ = cq_?.BirthDateElement;
                            CqlDate cs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cr_);
                            CqlQuantity ct_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, co_.Low);
                            CqlDate cu_ = context.Operators.Add(cs_, ct_);
                            CqlQuantity cv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, co_.High);
                            CqlDate cw_ = context.Operators.Add(cs_, cv_);
                            CqlQuantity cx_ = context.Operators.Quantity(1m, "year");
                            CqlDate cy_ = context.Operators.Add(cw_, cx_);
                            CqlInterval<CqlDate> cz_ = context.Operators.Interval(cu_, cy_, true, false);
                            cp_ = cz_;
                        }
                        else
                        {
                            cp_ = null as CqlInterval<CqlDate>;
                        }
                        v_ = cp_;
                    }
                    bool? w_ = v_?.highClosed;
                    CqlInterval<CqlDateTime> x_ = context.Operators.Interval(m_, q_, t_, w_);
                    return x_;
                }
            }
        }
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
        if (choice is FhirDateTime a_)
        {
            CqlDateTime i_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, a_);
            CqlInterval<CqlDateTime> j_ = context.Operators.Interval(i_, i_, true, true);
            return j_;
        }
        else if (choice is Date b_)
        {
            CqlDate k_ = FHIRHelpers_4_0_001.Instance.ToDate(context, b_);
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
            CqlInterval<CqlDateTime> m_ = context.Operators.Interval(l_, l_, true, true);
            return m_;
        }
        else if (choice is Period c_)
        {
            CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(c_.StartElement);
            CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(c_.EndElement);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, o_, true, true);
            return p_;
        }
        else if (choice is Instant d_)
        {
            CqlDateTime q_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, d_);
            CqlInterval<CqlDateTime> r_ = context.Operators.Interval(q_, q_, true, true);
            return r_;
        }
        else if (choice is Age e_)
        {
            Patient s_ = this.Patient(context);
            Date t_ = s_?.BirthDateElement;
            CqlDate u_ = FHIRHelpers_4_0_001.Instance.ToDate(context, t_);
            CqlQuantity v_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, e_);
            CqlDate w_ = context.Operators.Add(u_, v_);
            CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
            CqlQuantity y_ = context.Operators.Quantity(1m, "year");
            CqlDate z_ = context.Operators.Add(w_, y_);
            CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
            CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(x_, aa_, true, false);
            return ab_;
        }
        else if (choice is Range f_)
        {
            Patient ac_ = this.Patient(context);
            Date ad_ = ac_?.BirthDateElement;
            CqlDate ae_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_);
            CqlQuantity af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, f_.Low);
            CqlDate ag_ = context.Operators.Add(ae_, af_);
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
            CqlQuantity ai_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, f_.High);
            CqlDate aj_ = context.Operators.Add(ae_, ai_);
            CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
            CqlDate al_ = context.Operators.Add(aj_, ak_);
            CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ah_, am_, true, false);
            return an_;
        }
        else if (choice is Timing g_)
        {
            CqlInterval<CqlDateTime> ao_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
            return ao_;
        }
        else if (choice is FhirString h_)
        {
            CqlInterval<CqlDateTime> ap_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return ap_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    [CqlFunctionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        int? a_ = context.Operators.PositionOf("/", uri);
        bool? b_ = context.Operators.Greater(a_, 0);
        if (b_ ?? false)
        {
            IEnumerable<string> c_ = context.Operators.Split(uri, "/");
            string d_ = context.Operators.Last<string>(c_);
            return d_;
        }
        else
        {
            return uri;
        }
    }


    [CqlFunctionDefinition("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
    VSet;


    [CqlFunctionDefinition("First Dates per 31 Day Periods")]
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate a_(CqlDate d) => d;
        IEnumerable<CqlDate> b_ = context.Operators.SelectDistinct<CqlDate, CqlDate>(DateList, a_);
        IEnumerable<CqlDate> c_ = context.Operators.ListSort<CqlDate>(b_, System.ComponentModel.ListSortDirection.Ascending);

        bool? d_(CqlDate X) {
            bool? k_ = context.Operators.Not((bool?)(X is null));
            return k_;
        }

        IEnumerable<CqlDate> e_ = context.Operators.Where<CqlDate>(c_, d_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? f_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, e_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] g_ = [
            f_,
        ];

        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? h_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates) {
            IEnumerable<CqlDate> l_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? m_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, l_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] n_ = [
                m_,
            ];

            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? o_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList) {
                IEnumerable<CqlDate> r_ = AnchorList?.SortedList;
                int? s_ = AnchorList?.AnchorIndex;
                CqlDate t_ = context.Operators.Indexer<CqlDate>(r_, s_);

                bool? u_(CqlDate X) {
                    IEnumerable<CqlDate> ac_ = AnchorList?.SortedList;
                    int? ad_ = AnchorList?.AnchorIndex;
                    CqlDate ae_ = context.Operators.Indexer<CqlDate>(ac_, ad_);
                    CqlQuantity af_ = context.Operators.Quantity(1m, "day");
                    CqlDate ag_ = context.Operators.Add(ae_ as CqlDate, af_);
                    CqlQuantity ah_ = context.Operators.Quantity(30m, "days");
                    CqlDate ai_ = context.Operators.Add(ae_ as CqlDate, ah_);
                    CqlInterval<CqlDate> aj_ = context.Operators.Interval(ag_, ai_, true, true);
                    bool? ak_ = context.Operators.In<CqlDate>(X, aj_, (string)default);
                    bool? al_ = context.Operators.Not(ak_);
                    return al_;
                }

                IEnumerable<CqlDate> v_ = context.Operators.Where<CqlDate>(DateList, u_);
                int? w_ = context.Operators.Add(s_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? x_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, t_ as CqlDate, v_, w_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] y_ = [
                    x_,
                ];

                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? z_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList) {
                    IEnumerable<CqlDate> am_ = FirstList?.NewList;
                    int? an_ = FirstList?.IndexofNewDate;
                    CqlDate ao_ = context.Operators.Indexer<CqlDate>(am_, an_);
                    if (ao_ is null)
                    {
                        return FirstList;
                    }
                    else
                    {
                        IEnumerable<CqlDate> ap_ = FirstList?.NewList;
                        int? aq_ = FirstList?.IndexofNewDate;
                        CqlDate ar_ = context.Operators.Indexer<CqlDate>(ap_, aq_);

                        bool? as_(CqlDate X) {
                            IEnumerable<CqlDate> ba_ = FirstList?.NewList;
                            int? bb_ = FirstList?.IndexofNewDate;
                            CqlDate bc_ = context.Operators.Indexer<CqlDate>(ba_, bb_);
                            CqlQuantity bd_ = context.Operators.Quantity(1m, "day");
                            CqlDate be_ = context.Operators.Add(bc_ as CqlDate, bd_);
                            CqlQuantity bf_ = context.Operators.Quantity(30m, "days");
                            CqlDate bg_ = context.Operators.Add(bc_ as CqlDate, bf_);
                            CqlInterval<CqlDate> bh_ = context.Operators.Interval(be_, bg_, true, true);
                            bool? bi_ = context.Operators.In<CqlDate>(X, bh_, (string)default);
                            bool? bj_ = context.Operators.Not(bi_);
                            return bj_;
                        }

                        IEnumerable<CqlDate> at_ = context.Operators.Where<CqlDate>(ap_, as_);
                        int? au_ = context.Operators.Add(aq_, 1);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? av_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ar_ as CqlDate, at_, au_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] aw_ = [
                            av_,
                        ];

                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ax_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList) {
                            IEnumerable<CqlDate> bk_ = SecondList?.NewList;
                            int? bl_ = SecondList?.IndexofNewDate;
                            CqlDate bm_ = context.Operators.Indexer<CqlDate>(bk_, bl_);
                            if (bm_ is null)
                            {
                                return SecondList;
                            }
                            else
                            {
                                IEnumerable<CqlDate> bn_ = SecondList?.NewList;
                                int? bo_ = SecondList?.IndexofNewDate;
                                CqlDate bp_ = context.Operators.Indexer<CqlDate>(bn_, bo_);

                                bool? bq_(CqlDate X) {
                                    IEnumerable<CqlDate> by_ = SecondList?.NewList;
                                    int? bz_ = SecondList?.IndexofNewDate;
                                    CqlDate ca_ = context.Operators.Indexer<CqlDate>(by_, bz_);
                                    CqlQuantity cb_ = context.Operators.Quantity(1m, "day");
                                    CqlDate cc_ = context.Operators.Add(ca_ as CqlDate, cb_);
                                    CqlQuantity cd_ = context.Operators.Quantity(30m, "days");
                                    CqlDate ce_ = context.Operators.Add(ca_ as CqlDate, cd_);
                                    CqlInterval<CqlDate> cf_ = context.Operators.Interval(cc_, ce_, true, true);
                                    bool? cg_ = context.Operators.In<CqlDate>(X, cf_, (string)default);
                                    bool? ch_ = context.Operators.Not(cg_);
                                    return ch_;
                                }

                                IEnumerable<CqlDate> br_ = context.Operators.Where<CqlDate>(bn_, bq_);
                                int? bs_ = context.Operators.Add(bo_, 1);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bt_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bp_ as CqlDate, br_, bs_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bu_ = [
                                    bt_,
                                ];

                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bv_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList) {
                                    IEnumerable<CqlDate> ci_ = ThirdList?.NewList;
                                    int? cj_ = ThirdList?.IndexofNewDate;
                                    CqlDate ck_ = context.Operators.Indexer<CqlDate>(ci_, cj_);
                                    if (ck_ is null)
                                    {
                                        return ThirdList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> cl_ = ThirdList?.NewList;
                                        int? cm_ = ThirdList?.IndexofNewDate;
                                        CqlDate cn_ = context.Operators.Indexer<CqlDate>(cl_, cm_);

                                        bool? co_(CqlDate X) {
                                            IEnumerable<CqlDate> cw_ = ThirdList?.NewList;
                                            int? cx_ = ThirdList?.IndexofNewDate;
                                            CqlDate cy_ = context.Operators.Indexer<CqlDate>(cw_, cx_);
                                            CqlQuantity cz_ = context.Operators.Quantity(1m, "day");
                                            CqlDate da_ = context.Operators.Add(cy_ as CqlDate, cz_);
                                            CqlQuantity db_ = context.Operators.Quantity(30m, "days");
                                            CqlDate dc_ = context.Operators.Add(cy_ as CqlDate, db_);
                                            CqlInterval<CqlDate> dd_ = context.Operators.Interval(da_, dc_, true, true);
                                            bool? de_ = context.Operators.In<CqlDate>(X, dd_, (string)default);
                                            bool? df_ = context.Operators.Not(de_);
                                            return df_;
                                        }

                                        IEnumerable<CqlDate> cp_ = context.Operators.Where<CqlDate>(cl_, co_);
                                        int? cq_ = context.Operators.Add(cm_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cr_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, cn_ as CqlDate, cp_, cq_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] cs_ = [
                                            cr_,
                                        ];

                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ct_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList) {
                                            IEnumerable<CqlDate> dg_ = FourthList?.NewList;
                                            int? dh_ = FourthList?.IndexofNewDate;
                                            CqlDate di_ = context.Operators.Indexer<CqlDate>(dg_, dh_);
                                            if (di_ is null)
                                            {
                                                return FourthList;
                                            }
                                            else
                                            {
                                                IEnumerable<CqlDate> dj_ = FourthList?.NewList;
                                                int? dk_ = FourthList?.IndexofNewDate;
                                                CqlDate dl_ = context.Operators.Indexer<CqlDate>(dj_, dk_);

                                                bool? dm_(CqlDate X) {
                                                    IEnumerable<CqlDate> du_ = FourthList?.NewList;
                                                    int? dv_ = FourthList?.IndexofNewDate;
                                                    CqlDate dw_ = context.Operators.Indexer<CqlDate>(du_, dv_);
                                                    CqlQuantity dx_ = context.Operators.Quantity(1m, "day");
                                                    CqlDate dy_ = context.Operators.Add(dw_ as CqlDate, dx_);
                                                    CqlQuantity dz_ = context.Operators.Quantity(30m, "days");
                                                    CqlDate ea_ = context.Operators.Add(dw_ as CqlDate, dz_);
                                                    CqlInterval<CqlDate> eb_ = context.Operators.Interval(dy_, ea_, true, true);
                                                    bool? ec_ = context.Operators.In<CqlDate>(X, eb_, (string)default);
                                                    bool? ed_ = context.Operators.Not(ec_);
                                                    return ed_;
                                                }

                                                IEnumerable<CqlDate> dn_ = context.Operators.Where<CqlDate>(dj_, dm_);
                                                int? do_ = context.Operators.Add(dk_, 1);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dp_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, dl_ as CqlDate, dn_, do_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] dq_ = [
                                                    dp_,
                                                ];

                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dr_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList) {
                                                    IEnumerable<CqlDate> ee_ = FifthList?.NewList;
                                                    int? ef_ = FifthList?.IndexofNewDate;
                                                    CqlDate eg_ = context.Operators.Indexer<CqlDate>(ee_, ef_);
                                                    if (eg_ is null)
                                                    {
                                                        return FifthList;
                                                    }
                                                    else
                                                    {
                                                        IEnumerable<CqlDate> eh_ = FifthList?.NewList;
                                                        int? ei_ = FifthList?.IndexofNewDate;
                                                        CqlDate ej_ = context.Operators.Indexer<CqlDate>(eh_, ei_);

                                                        bool? ek_(CqlDate X) {
                                                            IEnumerable<CqlDate> es_ = FifthList?.NewList;
                                                            int? et_ = FifthList?.IndexofNewDate;
                                                            CqlDate eu_ = context.Operators.Indexer<CqlDate>(es_, et_);
                                                            CqlQuantity ev_ = context.Operators.Quantity(1m, "day");
                                                            CqlDate ew_ = context.Operators.Add(eu_ as CqlDate, ev_);
                                                            CqlQuantity ex_ = context.Operators.Quantity(30m, "days");
                                                            CqlDate ey_ = context.Operators.Add(eu_ as CqlDate, ex_);
                                                            CqlInterval<CqlDate> ez_ = context.Operators.Interval(ew_, ey_, true, true);
                                                            bool? fa_ = context.Operators.In<CqlDate>(X, ez_, (string)default);
                                                            bool? fb_ = context.Operators.Not(fa_);
                                                            return fb_;
                                                        }

                                                        IEnumerable<CqlDate> el_ = context.Operators.Where<CqlDate>(eh_, ek_);
                                                        int? em_ = context.Operators.Add(ei_, 1);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? en_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ej_ as CqlDate, el_, em_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] eo_ = [
                                                            en_,
                                                        ];

                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ep_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList) {
                                                            IEnumerable<CqlDate> fc_ = SixthList?.NewList;
                                                            int? fd_ = SixthList?.IndexofNewDate;
                                                            CqlDate fe_ = context.Operators.Indexer<CqlDate>(fc_, fd_);
                                                            if (fe_ is null)
                                                            {
                                                                return SixthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> ff_ = SixthList?.NewList;
                                                                int? fg_ = SixthList?.IndexofNewDate;
                                                                CqlDate fh_ = context.Operators.Indexer<CqlDate>(ff_, fg_);

                                                                bool? fi_(CqlDate X) {
                                                                    IEnumerable<CqlDate> fq_ = SixthList?.NewList;
                                                                    int? fr_ = SixthList?.IndexofNewDate;
                                                                    CqlDate fs_ = context.Operators.Indexer<CqlDate>(fq_, fr_);
                                                                    CqlQuantity ft_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate fu_ = context.Operators.Add(fs_ as CqlDate, ft_);
                                                                    CqlQuantity fv_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate fw_ = context.Operators.Add(fs_ as CqlDate, fv_);
                                                                    CqlInterval<CqlDate> fx_ = context.Operators.Interval(fu_, fw_, true, true);
                                                                    bool? fy_ = context.Operators.In<CqlDate>(X, fx_, (string)default);
                                                                    bool? fz_ = context.Operators.Not(fy_);
                                                                    return fz_;
                                                                }

                                                                IEnumerable<CqlDate> fj_ = context.Operators.Where<CqlDate>(ff_, fi_);
                                                                int? fk_ = context.Operators.Add(fg_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fl_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fh_ as CqlDate, fj_, fk_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fm_ = [
                                                                    fl_,
                                                                ];

                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fn_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList) {
                                                                    IEnumerable<CqlDate> ga_ = SeventhList?.NewList;
                                                                    int? gb_ = SeventhList?.IndexofNewDate;
                                                                    CqlDate gc_ = context.Operators.Indexer<CqlDate>(ga_, gb_);
                                                                    if (gc_ is null)
                                                                    {
                                                                        return SeventhList;
                                                                    }
                                                                    else
                                                                    {
                                                                        IEnumerable<CqlDate> gd_ = SeventhList?.NewList;
                                                                        int? ge_ = SeventhList?.IndexofNewDate;
                                                                        CqlDate gf_ = context.Operators.Indexer<CqlDate>(gd_, ge_);

                                                                        bool? gg_(CqlDate X) {
                                                                            IEnumerable<CqlDate> go_ = SeventhList?.NewList;
                                                                            int? gp_ = SeventhList?.IndexofNewDate;
                                                                            CqlDate gq_ = context.Operators.Indexer<CqlDate>(go_, gp_);
                                                                            CqlQuantity gr_ = context.Operators.Quantity(1m, "day");
                                                                            CqlDate gs_ = context.Operators.Add(gq_ as CqlDate, gr_);
                                                                            CqlQuantity gt_ = context.Operators.Quantity(30m, "days");
                                                                            CqlDate gu_ = context.Operators.Add(gq_ as CqlDate, gt_);
                                                                            CqlInterval<CqlDate> gv_ = context.Operators.Interval(gs_, gu_, true, true);
                                                                            bool? gw_ = context.Operators.In<CqlDate>(X, gv_, (string)default);
                                                                            bool? gx_ = context.Operators.Not(gw_);
                                                                            return gx_;
                                                                        }

                                                                        IEnumerable<CqlDate> gh_ = context.Operators.Where<CqlDate>(gd_, gg_);
                                                                        int? gi_ = context.Operators.Add(ge_, 1);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gj_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gf_ as CqlDate, gh_, gi_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gk_ = [
                                                                            gj_,
                                                                        ];

                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gl_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList) {
                                                                            IEnumerable<CqlDate> gy_ = EighthList?.NewList;
                                                                            int? gz_ = EighthList?.IndexofNewDate;
                                                                            CqlDate ha_ = context.Operators.Indexer<CqlDate>(gy_, gz_);
                                                                            if (ha_ is null)
                                                                            {
                                                                                return EighthList;
                                                                            }
                                                                            else
                                                                            {
                                                                                IEnumerable<CqlDate> hb_ = EighthList?.NewList;
                                                                                int? hc_ = EighthList?.IndexofNewDate;
                                                                                CqlDate hd_ = context.Operators.Indexer<CqlDate>(hb_, hc_);

                                                                                bool? he_(CqlDate X) {
                                                                                    IEnumerable<CqlDate> hm_ = EighthList?.NewList;
                                                                                    int? hn_ = EighthList?.IndexofNewDate;
                                                                                    CqlDate ho_ = context.Operators.Indexer<CqlDate>(hm_, hn_);
                                                                                    CqlQuantity hp_ = context.Operators.Quantity(1m, "day");
                                                                                    CqlDate hq_ = context.Operators.Add(ho_ as CqlDate, hp_);
                                                                                    CqlQuantity hr_ = context.Operators.Quantity(30m, "days");
                                                                                    CqlDate hs_ = context.Operators.Add(ho_ as CqlDate, hr_);
                                                                                    CqlInterval<CqlDate> ht_ = context.Operators.Interval(hq_, hs_, true, true);
                                                                                    bool? hu_ = context.Operators.In<CqlDate>(X, ht_, (string)default);
                                                                                    bool? hv_ = context.Operators.Not(hu_);
                                                                                    return hv_;
                                                                                }

                                                                                IEnumerable<CqlDate> hf_ = context.Operators.Where<CqlDate>(hb_, he_);
                                                                                int? hg_ = context.Operators.Add(hc_, 1);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hh_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hd_ as CqlDate, hf_, hg_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hi_ = [
                                                                                    hh_,
                                                                                ];

                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hj_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList) {
                                                                                    IEnumerable<CqlDate> hw_ = NinethList?.NewList;
                                                                                    int? hx_ = NinethList?.IndexofNewDate;
                                                                                    CqlDate hy_ = context.Operators.Indexer<CqlDate>(hw_, hx_);
                                                                                    if (hy_ is null)
                                                                                    {
                                                                                        return NinethList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> hz_ = NinethList?.NewList;
                                                                                        int? ia_ = NinethList?.IndexofNewDate;
                                                                                        CqlDate ib_ = context.Operators.Indexer<CqlDate>(hz_, ia_);

                                                                                        bool? ic_(CqlDate X) {
                                                                                            IEnumerable<CqlDate> ik_ = NinethList?.NewList;
                                                                                            int? il_ = NinethList?.IndexofNewDate;
                                                                                            CqlDate im_ = context.Operators.Indexer<CqlDate>(ik_, il_);
                                                                                            CqlQuantity in_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate io_ = context.Operators.Add(im_ as CqlDate, in_);
                                                                                            CqlQuantity ip_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate iq_ = context.Operators.Add(im_ as CqlDate, ip_);
                                                                                            CqlInterval<CqlDate> ir_ = context.Operators.Interval(io_, iq_, true, true);
                                                                                            bool? is_ = context.Operators.In<CqlDate>(X, ir_, (string)default);
                                                                                            bool? it_ = context.Operators.Not(is_);
                                                                                            return it_;
                                                                                        }

                                                                                        IEnumerable<CqlDate> id_ = context.Operators.Where<CqlDate>(hz_, ic_);
                                                                                        int? ie_ = context.Operators.Add(ia_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? if_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ib_ as CqlDate, id_, ie_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ig_ = [
                                                                                            if_,
                                                                                        ];

                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ih_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList) {
                                                                                            IEnumerable<CqlDate> iu_ = TenthList?.NewList;
                                                                                            int? iv_ = TenthList?.IndexofNewDate;
                                                                                            CqlDate iw_ = context.Operators.Indexer<CqlDate>(iu_, iv_);
                                                                                            if (iw_ is null)
                                                                                            {
                                                                                                return TenthList;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                IEnumerable<CqlDate> ix_ = TenthList?.NewList;
                                                                                                int? iy_ = TenthList?.IndexofNewDate;
                                                                                                CqlDate iz_ = context.Operators.Indexer<CqlDate>(ix_, iy_);

                                                                                                bool? ja_(CqlDate X) {
                                                                                                    IEnumerable<CqlDate> ji_ = TenthList?.NewList;
                                                                                                    int? jj_ = TenthList?.IndexofNewDate;
                                                                                                    CqlDate jk_ = context.Operators.Indexer<CqlDate>(ji_, jj_);
                                                                                                    CqlQuantity jl_ = context.Operators.Quantity(1m, "day");
                                                                                                    CqlDate jm_ = context.Operators.Add(jk_ as CqlDate, jl_);
                                                                                                    CqlQuantity jn_ = context.Operators.Quantity(30m, "days");
                                                                                                    CqlDate jo_ = context.Operators.Add(jk_ as CqlDate, jn_);
                                                                                                    CqlInterval<CqlDate> jp_ = context.Operators.Interval(jm_, jo_, true, true);
                                                                                                    bool? jq_ = context.Operators.In<CqlDate>(X, jp_, (string)default);
                                                                                                    bool? jr_ = context.Operators.Not(jq_);
                                                                                                    return jr_;
                                                                                                }

                                                                                                IEnumerable<CqlDate> jb_ = context.Operators.Where<CqlDate>(ix_, ja_);
                                                                                                int? jc_ = context.Operators.Add(iy_, 1);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jd_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, iz_ as CqlDate, jb_, jc_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] je_ = [
                                                                                                    jd_,
                                                                                                ];

                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jf_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList) {
                                                                                                    IEnumerable<CqlDate> js_ = EleventhList?.NewList;
                                                                                                    int? jt_ = EleventhList?.IndexofNewDate;
                                                                                                    CqlDate ju_ = context.Operators.Indexer<CqlDate>(js_, jt_);
                                                                                                    if (ju_ is null)
                                                                                                    {
                                                                                                        return EleventhList;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> jv_ = EleventhList?.NewList;
                                                                                                        int? jw_ = EleventhList?.IndexofNewDate;
                                                                                                        CqlDate jx_ = context.Operators.Indexer<CqlDate>(jv_, jw_);

                                                                                                        bool? jy_(CqlDate X) {
                                                                                                            IEnumerable<CqlDate> kc_ = EleventhList?.NewList;
                                                                                                            int? kd_ = EleventhList?.IndexofNewDate;
                                                                                                            CqlDate ke_ = context.Operators.Indexer<CqlDate>(kc_, kd_);
                                                                                                            CqlQuantity kf_ = context.Operators.Quantity(1m, "day");
                                                                                                            CqlDate kg_ = context.Operators.Add(ke_ as CqlDate, kf_);
                                                                                                            CqlQuantity kh_ = context.Operators.Quantity(30m, "days");
                                                                                                            CqlDate ki_ = context.Operators.Add(ke_ as CqlDate, kh_);
                                                                                                            CqlInterval<CqlDate> kj_ = context.Operators.Interval(kg_, ki_, true, true);
                                                                                                            bool? kk_ = context.Operators.In<CqlDate>(X, kj_, (string)default);
                                                                                                            bool? kl_ = context.Operators.Not(kk_);
                                                                                                            return kl_;
                                                                                                        }

                                                                                                        IEnumerable<CqlDate> jz_ = context.Operators.Where<CqlDate>(jv_, jy_);
                                                                                                        int? ka_ = context.Operators.Add(jw_, 1);
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kb_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jx_ as CqlDate, jz_, ka_);
                                                                                                        return kb_;
                                                                                                    }
                                                                                                }

                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jg_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)je_, jf_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jg_);
                                                                                                return jh_;
                                                                                            }
                                                                                        }

                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ii_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ig_, ih_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ij_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ii_);
                                                                                        return ij_;
                                                                                    }
                                                                                }

                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hk_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hi_, hj_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hk_);
                                                                                return hl_;
                                                                            }
                                                                        }

                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gm_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gk_, gl_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gm_);
                                                                        return gn_;
                                                                    }
                                                                }

                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fo_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fm_, fn_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fo_);
                                                                return fp_;
                                                            }
                                                        }

                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> eq_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)eo_, ep_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? er_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(eq_);
                                                        return er_;
                                                    }
                                                }

                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ds_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)dq_, dr_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ds_);
                                                return dt_;
                                            }
                                        }

                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cu_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cs_, ct_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cu_);
                                        return cv_;
                                    }
                                }

                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bw_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bu_, bv_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bw_);
                                return bx_;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ay_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)aw_, ax_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? az_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ay_);
                        return az_;
                    }
                }

                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> aa_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)y_, z_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ab_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(aa_);
                return ab_;
            }

            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> p_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)n_, o_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? q_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(p_);
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)g_, h_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? j_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(i_);
        return j_;
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
