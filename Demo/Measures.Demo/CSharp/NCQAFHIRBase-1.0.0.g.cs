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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
        if (onset is FhirDateTime)
        {
            CqlDateTime a_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
            CqlInterval<CqlDateTime> b_ = context.Operators.Interval(a_, a_, true, true);
            return b_;
        }
        else if (onset is Period)
        {
            FhirDateTime d_ = onset is Period c_ ? c_.StartElement : null;
            CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
            FhirDateTime g_ = onset is Period f_ ? f_.EndElement : null;
            CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
            CqlInterval<CqlDateTime> i_ = context.Operators.Interval(e_, h_, true, true);
            return i_;
        }
        else if (onset is FhirString)
        {
            CqlInterval<CqlDateTime> j_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return j_;
        }
        else
        {
            CqlInterval<CqlDate> k_;
            if (onset is Age)
            {
                Patient v_ = this.Patient(context);
                Date w_ = v_?.BirthDateElement;
                CqlDate x_ = FHIRHelpers_4_0_001.Instance.ToDate(context, w_);
                CqlQuantity y_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate z_ = context.Operators.Add(x_, y_);
                CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
                CqlDate ab_ = context.Operators.Add(z_, aa_);
                CqlInterval<CqlDate> ac_ = context.Operators.Interval(z_, ab_, true, false);
                k_ = ac_;
            }
            else if (onset is Range)
            {
                Patient ad_ = this.Patient(context);
                Date ae_ = ad_?.BirthDateElement;
                CqlDate af_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ae_);
                Quantity ag_ = (onset as Range)?.Low;
                CqlQuantity ah_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ag_);
                CqlDate ai_ = context.Operators.Add(af_, ah_);
                Quantity aj_ = (onset as Range)?.High;
                CqlQuantity ak_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aj_);
                CqlDate al_ = context.Operators.Add(af_, ak_);
                CqlQuantity am_ = context.Operators.Quantity(1m, "year");
                CqlDate an_ = context.Operators.Add(al_, am_);
                CqlInterval<CqlDate> ao_ = context.Operators.Interval(ai_, an_, true, false);
                k_ = ao_;
            }
            else
            {
                k_ = null as CqlInterval<CqlDate>;
            }
            CqlDate l_ = k_?.low;
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
            CqlInterval<CqlDate> n_;
            if (onset is Age)
            {
                Patient ap_ = this.Patient(context);
                Date aq_ = ap_?.BirthDateElement;
                CqlDate ar_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aq_);
                CqlQuantity as_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate at_ = context.Operators.Add(ar_, as_);
                CqlQuantity au_ = context.Operators.Quantity(1m, "year");
                CqlDate av_ = context.Operators.Add(at_, au_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(at_, av_, true, false);
                n_ = aw_;
            }
            else if (onset is Range)
            {
                Patient ax_ = this.Patient(context);
                Date ay_ = ax_?.BirthDateElement;
                CqlDate az_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ay_);
                Quantity ba_ = (onset as Range)?.Low;
                CqlQuantity bb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ba_);
                CqlDate bc_ = context.Operators.Add(az_, bb_);
                Quantity bd_ = (onset as Range)?.High;
                CqlQuantity be_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bd_);
                CqlDate bf_ = context.Operators.Add(az_, be_);
                CqlQuantity bg_ = context.Operators.Quantity(1m, "year");
                CqlDate bh_ = context.Operators.Add(bf_, bg_);
                CqlInterval<CqlDate> bi_ = context.Operators.Interval(bc_, bh_, true, false);
                n_ = bi_;
            }
            else
            {
                n_ = null as CqlInterval<CqlDate>;
            }
            CqlDate o_ = n_?.high;
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
            CqlInterval<CqlDate> q_;
            if (onset is Age)
            {
                Patient bj_ = this.Patient(context);
                Date bk_ = bj_?.BirthDateElement;
                CqlDate bl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bk_);
                CqlQuantity bm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate bn_ = context.Operators.Add(bl_, bm_);
                CqlQuantity bo_ = context.Operators.Quantity(1m, "year");
                CqlDate bp_ = context.Operators.Add(bn_, bo_);
                CqlInterval<CqlDate> bq_ = context.Operators.Interval(bn_, bp_, true, false);
                q_ = bq_;
            }
            else if (onset is Range)
            {
                Patient br_ = this.Patient(context);
                Date bs_ = br_?.BirthDateElement;
                CqlDate bt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bs_);
                Quantity bu_ = (onset as Range)?.Low;
                CqlQuantity bv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bu_);
                CqlDate bw_ = context.Operators.Add(bt_, bv_);
                Quantity bx_ = (onset as Range)?.High;
                CqlQuantity by_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bx_);
                CqlDate bz_ = context.Operators.Add(bt_, by_);
                CqlQuantity ca_ = context.Operators.Quantity(1m, "year");
                CqlDate cb_ = context.Operators.Add(bz_, ca_);
                CqlInterval<CqlDate> cc_ = context.Operators.Interval(bw_, cb_, true, false);
                q_ = cc_;
            }
            else
            {
                q_ = null as CqlInterval<CqlDate>;
            }
            bool? r_ = q_?.lowClosed;
            CqlInterval<CqlDate> s_;
            if (onset is Age)
            {
                Patient cd_ = this.Patient(context);
                Date ce_ = cd_?.BirthDateElement;
                CqlDate cf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ce_);
                CqlQuantity cg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate ch_ = context.Operators.Add(cf_, cg_);
                CqlQuantity ci_ = context.Operators.Quantity(1m, "year");
                CqlDate cj_ = context.Operators.Add(ch_, ci_);
                CqlInterval<CqlDate> ck_ = context.Operators.Interval(ch_, cj_, true, false);
                s_ = ck_;
            }
            else if (onset is Range)
            {
                Patient cl_ = this.Patient(context);
                Date cm_ = cl_?.BirthDateElement;
                CqlDate cn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cm_);
                Quantity co_ = (onset as Range)?.Low;
                CqlQuantity cp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, co_);
                CqlDate cq_ = context.Operators.Add(cn_, cp_);
                Quantity cr_ = (onset as Range)?.High;
                CqlQuantity cs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cr_);
                CqlDate ct_ = context.Operators.Add(cn_, cs_);
                CqlQuantity cu_ = context.Operators.Quantity(1m, "year");
                CqlDate cv_ = context.Operators.Add(ct_, cu_);
                CqlInterval<CqlDate> cw_ = context.Operators.Interval(cq_, cv_, true, false);
                s_ = cw_;
            }
            else
            {
                s_ = null as CqlInterval<CqlDate>;
            }
            bool? t_ = s_?.highClosed;
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(m_, p_, r_, t_);
            return u_;
        }
    }


    [CqlFunctionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        if (abatement is FhirDateTime)
        {
            CqlDateTime a_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
            CqlInterval<CqlDateTime> b_ = context.Operators.Interval(a_, a_, true, true);
            return b_;
        }
        else if (abatement is Period)
        {
            FhirDateTime d_ = abatement is Period c_ ? c_.StartElement : null;
            CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
            FhirDateTime g_ = abatement is Period f_ ? f_.EndElement : null;
            CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
            CqlInterval<CqlDateTime> i_ = context.Operators.Interval(e_, h_, true, true);
            return i_;
        }
        else if (abatement is FhirString)
        {
            CqlInterval<CqlDateTime> j_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return j_;
        }
        else
        {
            CqlInterval<CqlDate> k_;
            if (abatement is Age)
            {
                Patient v_ = this.Patient(context);
                Date w_ = v_?.BirthDateElement;
                CqlDate x_ = FHIRHelpers_4_0_001.Instance.ToDate(context, w_);
                CqlQuantity y_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate z_ = context.Operators.Add(x_, y_);
                CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
                CqlDate ab_ = context.Operators.Add(z_, aa_);
                CqlInterval<CqlDate> ac_ = context.Operators.Interval(z_, ab_, true, false);
                k_ = ac_;
            }
            else if (abatement is Range)
            {
                Patient ad_ = this.Patient(context);
                Date ae_ = ad_?.BirthDateElement;
                CqlDate af_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ae_);
                Quantity ag_ = (abatement as Range)?.Low;
                CqlQuantity ah_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ag_);
                CqlDate ai_ = context.Operators.Add(af_, ah_);
                Quantity aj_ = (abatement as Range)?.High;
                CqlQuantity ak_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aj_);
                CqlDate al_ = context.Operators.Add(af_, ak_);
                CqlQuantity am_ = context.Operators.Quantity(1m, "year");
                CqlDate an_ = context.Operators.Add(al_, am_);
                CqlInterval<CqlDate> ao_ = context.Operators.Interval(ai_, an_, true, false);
                k_ = ao_;
            }
            else
            {
                k_ = null as CqlInterval<CqlDate>;
            }
            CqlDate l_ = k_?.low;
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
            CqlInterval<CqlDate> n_;
            if (abatement is Age)
            {
                Patient ap_ = this.Patient(context);
                Date aq_ = ap_?.BirthDateElement;
                CqlDate ar_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aq_);
                CqlQuantity as_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate at_ = context.Operators.Add(ar_, as_);
                CqlQuantity au_ = context.Operators.Quantity(1m, "year");
                CqlDate av_ = context.Operators.Add(at_, au_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(at_, av_, true, false);
                n_ = aw_;
            }
            else if (abatement is Range)
            {
                Patient ax_ = this.Patient(context);
                Date ay_ = ax_?.BirthDateElement;
                CqlDate az_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ay_);
                Quantity ba_ = (abatement as Range)?.Low;
                CqlQuantity bb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ba_);
                CqlDate bc_ = context.Operators.Add(az_, bb_);
                Quantity bd_ = (abatement as Range)?.High;
                CqlQuantity be_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bd_);
                CqlDate bf_ = context.Operators.Add(az_, be_);
                CqlQuantity bg_ = context.Operators.Quantity(1m, "year");
                CqlDate bh_ = context.Operators.Add(bf_, bg_);
                CqlInterval<CqlDate> bi_ = context.Operators.Interval(bc_, bh_, true, false);
                n_ = bi_;
            }
            else
            {
                n_ = null as CqlInterval<CqlDate>;
            }
            CqlDate o_ = n_?.high;
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
            CqlInterval<CqlDate> q_;
            if (abatement is Age)
            {
                Patient bj_ = this.Patient(context);
                Date bk_ = bj_?.BirthDateElement;
                CqlDate bl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bk_);
                CqlQuantity bm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate bn_ = context.Operators.Add(bl_, bm_);
                CqlQuantity bo_ = context.Operators.Quantity(1m, "year");
                CqlDate bp_ = context.Operators.Add(bn_, bo_);
                CqlInterval<CqlDate> bq_ = context.Operators.Interval(bn_, bp_, true, false);
                q_ = bq_;
            }
            else if (abatement is Range)
            {
                Patient br_ = this.Patient(context);
                Date bs_ = br_?.BirthDateElement;
                CqlDate bt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bs_);
                Quantity bu_ = (abatement as Range)?.Low;
                CqlQuantity bv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bu_);
                CqlDate bw_ = context.Operators.Add(bt_, bv_);
                Quantity bx_ = (abatement as Range)?.High;
                CqlQuantity by_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bx_);
                CqlDate bz_ = context.Operators.Add(bt_, by_);
                CqlQuantity ca_ = context.Operators.Quantity(1m, "year");
                CqlDate cb_ = context.Operators.Add(bz_, ca_);
                CqlInterval<CqlDate> cc_ = context.Operators.Interval(bw_, cb_, true, false);
                q_ = cc_;
            }
            else
            {
                q_ = null as CqlInterval<CqlDate>;
            }
            bool? r_ = q_?.lowClosed;
            CqlInterval<CqlDate> s_;
            if (abatement is Age)
            {
                Patient cd_ = this.Patient(context);
                Date ce_ = cd_?.BirthDateElement;
                CqlDate cf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ce_);
                CqlQuantity cg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate ch_ = context.Operators.Add(cf_, cg_);
                CqlQuantity ci_ = context.Operators.Quantity(1m, "year");
                CqlDate cj_ = context.Operators.Add(ch_, ci_);
                CqlInterval<CqlDate> ck_ = context.Operators.Interval(ch_, cj_, true, false);
                s_ = ck_;
            }
            else if (abatement is Range)
            {
                Patient cl_ = this.Patient(context);
                Date cm_ = cl_?.BirthDateElement;
                CqlDate cn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cm_);
                Quantity co_ = (abatement as Range)?.Low;
                CqlQuantity cp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, co_);
                CqlDate cq_ = context.Operators.Add(cn_, cp_);
                Quantity cr_ = (abatement as Range)?.High;
                CqlQuantity cs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cr_);
                CqlDate ct_ = context.Operators.Add(cn_, cs_);
                CqlQuantity cu_ = context.Operators.Quantity(1m, "year");
                CqlDate cv_ = context.Operators.Add(ct_, cu_);
                CqlInterval<CqlDate> cw_ = context.Operators.Interval(cq_, cv_, true, false);
                s_ = cw_;
            }
            else
            {
                s_ = null as CqlInterval<CqlDate>;
            }
            bool? t_ = s_?.highClosed;
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(m_, p_, r_, t_);
            return u_;
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
        if (choice is FhirDateTime)
        {
            CqlDateTime a_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
            CqlInterval<CqlDateTime> b_ = context.Operators.Interval(a_, a_, true, true);
            return b_;
        }
        else if (choice is Date)
        {
            CqlDate c_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
            CqlDateTime d_ = context.Operators.ConvertDateToDateTime(c_);
            CqlInterval<CqlDateTime> e_ = context.Operators.Interval(d_, d_, true, true);
            return e_;
        }
        else if (choice is Period)
        {
            FhirDateTime g_ = choice is Period f_ ? f_.StartElement : null;
            CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
            FhirDateTime j_ = choice is Period i_ ? i_.EndElement : null;
            CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(h_, k_, true, true);
            return l_;
        }
        else if (choice is Instant)
        {
            CqlDateTime m_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(m_, m_, true, true);
            return n_;
        }
        else if (choice is Age)
        {
            Patient o_ = this.Patient(context);
            Date p_ = o_?.BirthDateElement;
            CqlDate q_ = FHIRHelpers_4_0_001.Instance.ToDate(context, p_);
            CqlQuantity r_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
            CqlDate s_ = context.Operators.Add(q_, r_);
            CqlDateTime t_ = context.Operators.ConvertDateToDateTime(s_);
            CqlQuantity u_ = context.Operators.Quantity(1m, "year");
            CqlDate v_ = context.Operators.Add(s_, u_);
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, false);
            return x_;
        }
        else if (choice is Range)
        {
            Patient y_ = this.Patient(context);
            Date z_ = y_?.BirthDateElement;
            CqlDate aa_ = FHIRHelpers_4_0_001.Instance.ToDate(context, z_);
            Quantity ab_ = (choice as Range)?.Low;
            CqlQuantity ac_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ab_);
            CqlDate ad_ = context.Operators.Add(aa_, ac_);
            CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
            Quantity af_ = (choice as Range)?.High;
            CqlQuantity ag_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, af_);
            CqlDate ah_ = context.Operators.Add(aa_, ag_);
            CqlQuantity ai_ = context.Operators.Quantity(1m, "year");
            CqlDate aj_ = context.Operators.Add(ah_, ai_);
            CqlDateTime ak_ = context.Operators.ConvertDateToDateTime(aj_);
            CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ae_, ak_, true, false);
            return al_;
        }
        else if (choice is Timing)
        {
            CqlInterval<CqlDateTime> am_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
            return am_;
        }
        else if (choice is FhirString)
        {
            CqlInterval<CqlDateTime> an_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return an_;
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
