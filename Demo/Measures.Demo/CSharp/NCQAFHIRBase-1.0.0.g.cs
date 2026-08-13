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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
            FhirDateTime c_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
            CqlDateTime d_ = context.Operators.Convert<CqlDateTime>(c_);
            FhirDateTime e_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            CqlInterval<CqlDateTime> g_ = context.Operators.Interval(d_, f_, true, true);
            return g_;
        }
        else if (onset is FhirString)
        {
            CqlInterval<CqlDateTime> h_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return h_;
        }
        else
        {
            CqlInterval<CqlDate> i_;
            if (onset is Age)
            {
                Patient t_ = this.Patient(context);
                Date u_ = t_?.BirthDateElement;
                CqlDate v_ = FHIRHelpers_4_0_001.Instance.ToDate(context, u_);
                CqlQuantity w_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate x_ = context.Operators.Add(v_, w_);
                CqlQuantity y_ = context.Operators.Quantity(1m, "year");
                CqlDate z_ = context.Operators.Add(x_, y_);
                CqlInterval<CqlDate> aa_ = context.Operators.Interval(x_, z_, true, false);
                i_ = aa_;
            }
            else if (onset is Range)
            {
                Patient ab_ = this.Patient(context);
                Date ac_ = ab_?.BirthDateElement;
                CqlDate ad_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ac_);
                Quantity ae_ = (onset as Range)?.Low;
                CqlQuantity af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_);
                CqlDate ag_ = context.Operators.Add(ad_, af_);
                Quantity ah_ = (onset as Range)?.High;
                CqlQuantity ai_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ah_);
                CqlDate aj_ = context.Operators.Add(ad_, ai_);
                CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
                CqlDate al_ = context.Operators.Add(aj_, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(ag_, al_, true, false);
                i_ = am_;
            }
            else
            {
                i_ = null as CqlInterval<CqlDate>;
            }
            CqlDate j_ = i_?.low;
            CqlDateTime k_ = context.Operators.ConvertDateToDateTime(j_);
            CqlInterval<CqlDate> l_;
            if (onset is Age)
            {
                Patient an_ = this.Patient(context);
                Date ao_ = an_?.BirthDateElement;
                CqlDate ap_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ao_);
                CqlQuantity aq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlQuantity as_ = context.Operators.Quantity(1m, "year");
                CqlDate at_ = context.Operators.Add(ar_, as_);
                CqlInterval<CqlDate> au_ = context.Operators.Interval(ar_, at_, true, false);
                l_ = au_;
            }
            else if (onset is Range)
            {
                Patient av_ = this.Patient(context);
                Date aw_ = av_?.BirthDateElement;
                CqlDate ax_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aw_);
                Quantity ay_ = (onset as Range)?.Low;
                CqlQuantity az_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ay_);
                CqlDate ba_ = context.Operators.Add(ax_, az_);
                Quantity bb_ = (onset as Range)?.High;
                CqlQuantity bc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bb_);
                CqlDate bd_ = context.Operators.Add(ax_, bc_);
                CqlQuantity be_ = context.Operators.Quantity(1m, "year");
                CqlDate bf_ = context.Operators.Add(bd_, be_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(ba_, bf_, true, false);
                l_ = bg_;
            }
            else
            {
                l_ = null as CqlInterval<CqlDate>;
            }
            CqlDate m_ = l_?.high;
            CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
            CqlInterval<CqlDate> o_;
            if (onset is Age)
            {
                Patient bh_ = this.Patient(context);
                Date bi_ = bh_?.BirthDateElement;
                CqlDate bj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bi_);
                CqlQuantity bk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate bl_ = context.Operators.Add(bj_, bk_);
                CqlQuantity bm_ = context.Operators.Quantity(1m, "year");
                CqlDate bn_ = context.Operators.Add(bl_, bm_);
                CqlInterval<CqlDate> bo_ = context.Operators.Interval(bl_, bn_, true, false);
                o_ = bo_;
            }
            else if (onset is Range)
            {
                Patient bp_ = this.Patient(context);
                Date bq_ = bp_?.BirthDateElement;
                CqlDate br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bq_);
                Quantity bs_ = (onset as Range)?.Low;
                CqlQuantity bt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bs_);
                CqlDate bu_ = context.Operators.Add(br_, bt_);
                Quantity bv_ = (onset as Range)?.High;
                CqlQuantity bw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bv_);
                CqlDate bx_ = context.Operators.Add(br_, bw_);
                CqlQuantity by_ = context.Operators.Quantity(1m, "year");
                CqlDate bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(bu_, bz_, true, false);
                o_ = ca_;
            }
            else
            {
                o_ = null as CqlInterval<CqlDate>;
            }
            bool? p_ = o_?.lowClosed;
            CqlInterval<CqlDate> q_;
            if (onset is Age)
            {
                Patient cb_ = this.Patient(context);
                Date cc_ = cb_?.BirthDateElement;
                CqlDate cd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cc_);
                CqlQuantity ce_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                CqlDate cf_ = context.Operators.Add(cd_, ce_);
                CqlQuantity cg_ = context.Operators.Quantity(1m, "year");
                CqlDate ch_ = context.Operators.Add(cf_, cg_);
                CqlInterval<CqlDate> ci_ = context.Operators.Interval(cf_, ch_, true, false);
                q_ = ci_;
            }
            else if (onset is Range)
            {
                Patient cj_ = this.Patient(context);
                Date ck_ = cj_?.BirthDateElement;
                CqlDate cl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ck_);
                Quantity cm_ = (onset as Range)?.Low;
                CqlQuantity cn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cm_);
                CqlDate co_ = context.Operators.Add(cl_, cn_);
                Quantity cp_ = (onset as Range)?.High;
                CqlQuantity cq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cp_);
                CqlDate cr_ = context.Operators.Add(cl_, cq_);
                CqlQuantity cs_ = context.Operators.Quantity(1m, "year");
                CqlDate ct_ = context.Operators.Add(cr_, cs_);
                CqlInterval<CqlDate> cu_ = context.Operators.Interval(co_, ct_, true, false);
                q_ = cu_;
            }
            else
            {
                q_ = null as CqlInterval<CqlDate>;
            }
            bool? r_ = q_?.highClosed;
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(k_, n_, p_, r_);
            return s_;
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
            FhirDateTime c_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
            CqlDateTime d_ = context.Operators.Convert<CqlDateTime>(c_);
            FhirDateTime e_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            CqlInterval<CqlDateTime> g_ = context.Operators.Interval(d_, f_, true, true);
            return g_;
        }
        else if (abatement is FhirString)
        {
            CqlInterval<CqlDateTime> h_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return h_;
        }
        else
        {
            CqlInterval<CqlDate> i_;
            if (abatement is Age)
            {
                Patient t_ = this.Patient(context);
                Date u_ = t_?.BirthDateElement;
                CqlDate v_ = FHIRHelpers_4_0_001.Instance.ToDate(context, u_);
                CqlQuantity w_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate x_ = context.Operators.Add(v_, w_);
                CqlQuantity y_ = context.Operators.Quantity(1m, "year");
                CqlDate z_ = context.Operators.Add(x_, y_);
                CqlInterval<CqlDate> aa_ = context.Operators.Interval(x_, z_, true, false);
                i_ = aa_;
            }
            else if (abatement is Range)
            {
                Patient ab_ = this.Patient(context);
                Date ac_ = ab_?.BirthDateElement;
                CqlDate ad_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ac_);
                Quantity ae_ = (abatement as Range)?.Low;
                CqlQuantity af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_);
                CqlDate ag_ = context.Operators.Add(ad_, af_);
                Quantity ah_ = (abatement as Range)?.High;
                CqlQuantity ai_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ah_);
                CqlDate aj_ = context.Operators.Add(ad_, ai_);
                CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
                CqlDate al_ = context.Operators.Add(aj_, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(ag_, al_, true, false);
                i_ = am_;
            }
            else
            {
                i_ = null as CqlInterval<CqlDate>;
            }
            CqlDate j_ = i_?.low;
            CqlDateTime k_ = context.Operators.ConvertDateToDateTime(j_);
            CqlInterval<CqlDate> l_;
            if (abatement is Age)
            {
                Patient an_ = this.Patient(context);
                Date ao_ = an_?.BirthDateElement;
                CqlDate ap_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ao_);
                CqlQuantity aq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlQuantity as_ = context.Operators.Quantity(1m, "year");
                CqlDate at_ = context.Operators.Add(ar_, as_);
                CqlInterval<CqlDate> au_ = context.Operators.Interval(ar_, at_, true, false);
                l_ = au_;
            }
            else if (abatement is Range)
            {
                Patient av_ = this.Patient(context);
                Date aw_ = av_?.BirthDateElement;
                CqlDate ax_ = FHIRHelpers_4_0_001.Instance.ToDate(context, aw_);
                Quantity ay_ = (abatement as Range)?.Low;
                CqlQuantity az_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ay_);
                CqlDate ba_ = context.Operators.Add(ax_, az_);
                Quantity bb_ = (abatement as Range)?.High;
                CqlQuantity bc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bb_);
                CqlDate bd_ = context.Operators.Add(ax_, bc_);
                CqlQuantity be_ = context.Operators.Quantity(1m, "year");
                CqlDate bf_ = context.Operators.Add(bd_, be_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(ba_, bf_, true, false);
                l_ = bg_;
            }
            else
            {
                l_ = null as CqlInterval<CqlDate>;
            }
            CqlDate m_ = l_?.high;
            CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
            CqlInterval<CqlDate> o_;
            if (abatement is Age)
            {
                Patient bh_ = this.Patient(context);
                Date bi_ = bh_?.BirthDateElement;
                CqlDate bj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bi_);
                CqlQuantity bk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate bl_ = context.Operators.Add(bj_, bk_);
                CqlQuantity bm_ = context.Operators.Quantity(1m, "year");
                CqlDate bn_ = context.Operators.Add(bl_, bm_);
                CqlInterval<CqlDate> bo_ = context.Operators.Interval(bl_, bn_, true, false);
                o_ = bo_;
            }
            else if (abatement is Range)
            {
                Patient bp_ = this.Patient(context);
                Date bq_ = bp_?.BirthDateElement;
                CqlDate br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bq_);
                Quantity bs_ = (abatement as Range)?.Low;
                CqlQuantity bt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bs_);
                CqlDate bu_ = context.Operators.Add(br_, bt_);
                Quantity bv_ = (abatement as Range)?.High;
                CqlQuantity bw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bv_);
                CqlDate bx_ = context.Operators.Add(br_, bw_);
                CqlQuantity by_ = context.Operators.Quantity(1m, "year");
                CqlDate bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(bu_, bz_, true, false);
                o_ = ca_;
            }
            else
            {
                o_ = null as CqlInterval<CqlDate>;
            }
            bool? p_ = o_?.lowClosed;
            CqlInterval<CqlDate> q_;
            if (abatement is Age)
            {
                Patient cb_ = this.Patient(context);
                Date cc_ = cb_?.BirthDateElement;
                CqlDate cd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cc_);
                CqlQuantity ce_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                CqlDate cf_ = context.Operators.Add(cd_, ce_);
                CqlQuantity cg_ = context.Operators.Quantity(1m, "year");
                CqlDate ch_ = context.Operators.Add(cf_, cg_);
                CqlInterval<CqlDate> ci_ = context.Operators.Interval(cf_, ch_, true, false);
                q_ = ci_;
            }
            else if (abatement is Range)
            {
                Patient cj_ = this.Patient(context);
                Date ck_ = cj_?.BirthDateElement;
                CqlDate cl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ck_);
                Quantity cm_ = (abatement as Range)?.Low;
                CqlQuantity cn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cm_);
                CqlDate co_ = context.Operators.Add(cl_, cn_);
                Quantity cp_ = (abatement as Range)?.High;
                CqlQuantity cq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cp_);
                CqlDate cr_ = context.Operators.Add(cl_, cq_);
                CqlQuantity cs_ = context.Operators.Quantity(1m, "year");
                CqlDate ct_ = context.Operators.Add(cr_, cs_);
                CqlInterval<CqlDate> cu_ = context.Operators.Interval(co_, ct_, true, false);
                q_ = cu_;
            }
            else
            {
                q_ = null as CqlInterval<CqlDate>;
            }
            bool? r_ = q_?.highClosed;
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(k_, n_, p_, r_);
            return s_;
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
            FhirDateTime f_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
            CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
            FhirDateTime h_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            CqlInterval<CqlDateTime> j_ = context.Operators.Interval(g_, i_, true, true);
            return j_;
        }
        else if (choice is Instant)
        {
            CqlDateTime k_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(k_, k_, true, true);
            return l_;
        }
        else if (choice is Age)
        {
            Patient m_ = this.Patient(context);
            Date n_ = m_?.BirthDateElement;
            CqlDate o_ = FHIRHelpers_4_0_001.Instance.ToDate(context, n_);
            CqlQuantity p_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
            CqlDate q_ = context.Operators.Add(o_, p_);
            CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "year");
            CqlDate t_ = context.Operators.Add(q_, s_);
            CqlDateTime u_ = context.Operators.ConvertDateToDateTime(t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
            return v_;
        }
        else if (choice is Range)
        {
            Patient w_ = this.Patient(context);
            Date x_ = w_?.BirthDateElement;
            CqlDate y_ = FHIRHelpers_4_0_001.Instance.ToDate(context, x_);
            Quantity z_ = (choice as Range)?.Low;
            CqlQuantity aa_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, z_);
            CqlDate ab_ = context.Operators.Add(y_, aa_);
            CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
            Quantity ad_ = (choice as Range)?.High;
            CqlQuantity ae_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ad_);
            CqlDate af_ = context.Operators.Add(y_, ae_);
            CqlQuantity ag_ = context.Operators.Quantity(1m, "year");
            CqlDate ah_ = context.Operators.Add(af_, ag_);
            CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ac_, ai_, true, false);
            return aj_;
        }
        else if (choice is Timing)
        {
            CqlInterval<CqlDateTime> ak_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
            return ak_;
        }
        else if (choice is FhirString)
        {
            CqlInterval<CqlDateTime> al_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return al_;
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
        bool? d_(CqlDate X) => !((bool?)(X is null));
        IEnumerable<CqlDate> e_ = context.Operators.Where<CqlDate>(c_, d_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? f_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, e_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] g_ = [
            f_,
        ];

        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? h_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates) {
            IEnumerable<CqlDate> k_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? l_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, k_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] m_ = [
                l_,
            ];

            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? n_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList) {
                IEnumerable<CqlDate> q_ = AnchorList?.SortedList;
                int? r_ = AnchorList?.AnchorIndex;
                CqlDate s_ = context.Operators.Indexer<CqlDate>(q_, r_);

                bool? t_(CqlDate X) {
                    IEnumerable<CqlDate> ab_ = AnchorList?.SortedList;
                    int? ac_ = AnchorList?.AnchorIndex;
                    CqlDate ad_ = context.Operators.Indexer<CqlDate>(ab_, ac_);
                    CqlQuantity ae_ = context.Operators.Quantity(1m, "day");
                    CqlDate af_ = context.Operators.Add(ad_ as CqlDate, ae_);
                    CqlQuantity ag_ = context.Operators.Quantity(30m, "days");
                    CqlDate ah_ = context.Operators.Add(ad_ as CqlDate, ag_);
                    CqlInterval<CqlDate> ai_ = context.Operators.Interval(af_, ah_, true, true);
                    bool? aj_ = context.Operators.In<CqlDate>(X, ai_, (string)default);
                    return !aj_;
                }

                IEnumerable<CqlDate> u_ = context.Operators.Where<CqlDate>(DateList, t_);
                int? v_ = context.Operators.Add(r_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? w_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, s_ as CqlDate, u_, v_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] x_ = [
                    w_,
                ];

                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? y_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList) {
                    IEnumerable<CqlDate> ak_ = FirstList?.NewList;
                    int? al_ = FirstList?.IndexofNewDate;
                    CqlDate am_ = context.Operators.Indexer<CqlDate>(ak_, al_);
                    if (am_ is null)
                    {
                        return FirstList;
                    }
                    else
                    {
                        IEnumerable<CqlDate> an_ = FirstList?.NewList;
                        int? ao_ = FirstList?.IndexofNewDate;
                        CqlDate ap_ = context.Operators.Indexer<CqlDate>(an_, ao_);

                        bool? aq_(CqlDate X) {
                            IEnumerable<CqlDate> ay_ = FirstList?.NewList;
                            int? az_ = FirstList?.IndexofNewDate;
                            CqlDate ba_ = context.Operators.Indexer<CqlDate>(ay_, az_);
                            CqlQuantity bb_ = context.Operators.Quantity(1m, "day");
                            CqlDate bc_ = context.Operators.Add(ba_ as CqlDate, bb_);
                            CqlQuantity bd_ = context.Operators.Quantity(30m, "days");
                            CqlDate be_ = context.Operators.Add(ba_ as CqlDate, bd_);
                            CqlInterval<CqlDate> bf_ = context.Operators.Interval(bc_, be_, true, true);
                            bool? bg_ = context.Operators.In<CqlDate>(X, bf_, (string)default);
                            return !bg_;
                        }

                        IEnumerable<CqlDate> ar_ = context.Operators.Where<CqlDate>(an_, aq_);
                        int? as_ = context.Operators.Add(ao_, 1);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? at_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ap_ as CqlDate, ar_, as_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] au_ = [
                            at_,
                        ];

                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? av_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList) {
                            IEnumerable<CqlDate> bh_ = SecondList?.NewList;
                            int? bi_ = SecondList?.IndexofNewDate;
                            CqlDate bj_ = context.Operators.Indexer<CqlDate>(bh_, bi_);
                            if (bj_ is null)
                            {
                                return SecondList;
                            }
                            else
                            {
                                IEnumerable<CqlDate> bk_ = SecondList?.NewList;
                                int? bl_ = SecondList?.IndexofNewDate;
                                CqlDate bm_ = context.Operators.Indexer<CqlDate>(bk_, bl_);

                                bool? bn_(CqlDate X) {
                                    IEnumerable<CqlDate> bv_ = SecondList?.NewList;
                                    int? bw_ = SecondList?.IndexofNewDate;
                                    CqlDate bx_ = context.Operators.Indexer<CqlDate>(bv_, bw_);
                                    CqlQuantity by_ = context.Operators.Quantity(1m, "day");
                                    CqlDate bz_ = context.Operators.Add(bx_ as CqlDate, by_);
                                    CqlQuantity ca_ = context.Operators.Quantity(30m, "days");
                                    CqlDate cb_ = context.Operators.Add(bx_ as CqlDate, ca_);
                                    CqlInterval<CqlDate> cc_ = context.Operators.Interval(bz_, cb_, true, true);
                                    bool? cd_ = context.Operators.In<CqlDate>(X, cc_, (string)default);
                                    return !cd_;
                                }

                                IEnumerable<CqlDate> bo_ = context.Operators.Where<CqlDate>(bk_, bn_);
                                int? bp_ = context.Operators.Add(bl_, 1);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bm_ as CqlDate, bo_, bp_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] br_ = [
                                    bq_,
                                ];

                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bs_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList) {
                                    IEnumerable<CqlDate> ce_ = ThirdList?.NewList;
                                    int? cf_ = ThirdList?.IndexofNewDate;
                                    CqlDate cg_ = context.Operators.Indexer<CqlDate>(ce_, cf_);
                                    if (cg_ is null)
                                    {
                                        return ThirdList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> ch_ = ThirdList?.NewList;
                                        int? ci_ = ThirdList?.IndexofNewDate;
                                        CqlDate cj_ = context.Operators.Indexer<CqlDate>(ch_, ci_);

                                        bool? ck_(CqlDate X) {
                                            IEnumerable<CqlDate> cs_ = ThirdList?.NewList;
                                            int? ct_ = ThirdList?.IndexofNewDate;
                                            CqlDate cu_ = context.Operators.Indexer<CqlDate>(cs_, ct_);
                                            CqlQuantity cv_ = context.Operators.Quantity(1m, "day");
                                            CqlDate cw_ = context.Operators.Add(cu_ as CqlDate, cv_);
                                            CqlQuantity cx_ = context.Operators.Quantity(30m, "days");
                                            CqlDate cy_ = context.Operators.Add(cu_ as CqlDate, cx_);
                                            CqlInterval<CqlDate> cz_ = context.Operators.Interval(cw_, cy_, true, true);
                                            bool? da_ = context.Operators.In<CqlDate>(X, cz_, (string)default);
                                            return !da_;
                                        }

                                        IEnumerable<CqlDate> cl_ = context.Operators.Where<CqlDate>(ch_, ck_);
                                        int? cm_ = context.Operators.Add(ci_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cn_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, cj_ as CqlDate, cl_, cm_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] co_ = [
                                            cn_,
                                        ];

                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cp_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList) {
                                            IEnumerable<CqlDate> db_ = FourthList?.NewList;
                                            int? dc_ = FourthList?.IndexofNewDate;
                                            CqlDate dd_ = context.Operators.Indexer<CqlDate>(db_, dc_);
                                            if (dd_ is null)
                                            {
                                                return FourthList;
                                            }
                                            else
                                            {
                                                IEnumerable<CqlDate> de_ = FourthList?.NewList;
                                                int? df_ = FourthList?.IndexofNewDate;
                                                CqlDate dg_ = context.Operators.Indexer<CqlDate>(de_, df_);

                                                bool? dh_(CqlDate X) {
                                                    IEnumerable<CqlDate> dp_ = FourthList?.NewList;
                                                    int? dq_ = FourthList?.IndexofNewDate;
                                                    CqlDate dr_ = context.Operators.Indexer<CqlDate>(dp_, dq_);
                                                    CqlQuantity ds_ = context.Operators.Quantity(1m, "day");
                                                    CqlDate dt_ = context.Operators.Add(dr_ as CqlDate, ds_);
                                                    CqlQuantity du_ = context.Operators.Quantity(30m, "days");
                                                    CqlDate dv_ = context.Operators.Add(dr_ as CqlDate, du_);
                                                    CqlInterval<CqlDate> dw_ = context.Operators.Interval(dt_, dv_, true, true);
                                                    bool? dx_ = context.Operators.In<CqlDate>(X, dw_, (string)default);
                                                    return !dx_;
                                                }

                                                IEnumerable<CqlDate> di_ = context.Operators.Where<CqlDate>(de_, dh_);
                                                int? dj_ = context.Operators.Add(df_, 1);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dk_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, dg_ as CqlDate, di_, dj_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] dl_ = [
                                                    dk_,
                                                ];

                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dm_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList) {
                                                    IEnumerable<CqlDate> dy_ = FifthList?.NewList;
                                                    int? dz_ = FifthList?.IndexofNewDate;
                                                    CqlDate ea_ = context.Operators.Indexer<CqlDate>(dy_, dz_);
                                                    if (ea_ is null)
                                                    {
                                                        return FifthList;
                                                    }
                                                    else
                                                    {
                                                        IEnumerable<CqlDate> eb_ = FifthList?.NewList;
                                                        int? ec_ = FifthList?.IndexofNewDate;
                                                        CqlDate ed_ = context.Operators.Indexer<CqlDate>(eb_, ec_);

                                                        bool? ee_(CqlDate X) {
                                                            IEnumerable<CqlDate> em_ = FifthList?.NewList;
                                                            int? en_ = FifthList?.IndexofNewDate;
                                                            CqlDate eo_ = context.Operators.Indexer<CqlDate>(em_, en_);
                                                            CqlQuantity ep_ = context.Operators.Quantity(1m, "day");
                                                            CqlDate eq_ = context.Operators.Add(eo_ as CqlDate, ep_);
                                                            CqlQuantity er_ = context.Operators.Quantity(30m, "days");
                                                            CqlDate es_ = context.Operators.Add(eo_ as CqlDate, er_);
                                                            CqlInterval<CqlDate> et_ = context.Operators.Interval(eq_, es_, true, true);
                                                            bool? eu_ = context.Operators.In<CqlDate>(X, et_, (string)default);
                                                            return !eu_;
                                                        }

                                                        IEnumerable<CqlDate> ef_ = context.Operators.Where<CqlDate>(eb_, ee_);
                                                        int? eg_ = context.Operators.Add(ec_, 1);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eh_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ed_ as CqlDate, ef_, eg_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ei_ = [
                                                            eh_,
                                                        ];

                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ej_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList) {
                                                            IEnumerable<CqlDate> ev_ = SixthList?.NewList;
                                                            int? ew_ = SixthList?.IndexofNewDate;
                                                            CqlDate ex_ = context.Operators.Indexer<CqlDate>(ev_, ew_);
                                                            if (ex_ is null)
                                                            {
                                                                return SixthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> ey_ = SixthList?.NewList;
                                                                int? ez_ = SixthList?.IndexofNewDate;
                                                                CqlDate fa_ = context.Operators.Indexer<CqlDate>(ey_, ez_);

                                                                bool? fb_(CqlDate X) {
                                                                    IEnumerable<CqlDate> fj_ = SixthList?.NewList;
                                                                    int? fk_ = SixthList?.IndexofNewDate;
                                                                    CqlDate fl_ = context.Operators.Indexer<CqlDate>(fj_, fk_);
                                                                    CqlQuantity fm_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate fn_ = context.Operators.Add(fl_ as CqlDate, fm_);
                                                                    CqlQuantity fo_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate fp_ = context.Operators.Add(fl_ as CqlDate, fo_);
                                                                    CqlInterval<CqlDate> fq_ = context.Operators.Interval(fn_, fp_, true, true);
                                                                    bool? fr_ = context.Operators.In<CqlDate>(X, fq_, (string)default);
                                                                    return !fr_;
                                                                }

                                                                IEnumerable<CqlDate> fc_ = context.Operators.Where<CqlDate>(ey_, fb_);
                                                                int? fd_ = context.Operators.Add(ez_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fe_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fa_ as CqlDate, fc_, fd_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ff_ = [
                                                                    fe_,
                                                                ];

                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fg_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList) {
                                                                    IEnumerable<CqlDate> fs_ = SeventhList?.NewList;
                                                                    int? ft_ = SeventhList?.IndexofNewDate;
                                                                    CqlDate fu_ = context.Operators.Indexer<CqlDate>(fs_, ft_);
                                                                    if (fu_ is null)
                                                                    {
                                                                        return SeventhList;
                                                                    }
                                                                    else
                                                                    {
                                                                        IEnumerable<CqlDate> fv_ = SeventhList?.NewList;
                                                                        int? fw_ = SeventhList?.IndexofNewDate;
                                                                        CqlDate fx_ = context.Operators.Indexer<CqlDate>(fv_, fw_);

                                                                        bool? fy_(CqlDate X) {
                                                                            IEnumerable<CqlDate> gg_ = SeventhList?.NewList;
                                                                            int? gh_ = SeventhList?.IndexofNewDate;
                                                                            CqlDate gi_ = context.Operators.Indexer<CqlDate>(gg_, gh_);
                                                                            CqlQuantity gj_ = context.Operators.Quantity(1m, "day");
                                                                            CqlDate gk_ = context.Operators.Add(gi_ as CqlDate, gj_);
                                                                            CqlQuantity gl_ = context.Operators.Quantity(30m, "days");
                                                                            CqlDate gm_ = context.Operators.Add(gi_ as CqlDate, gl_);
                                                                            CqlInterval<CqlDate> gn_ = context.Operators.Interval(gk_, gm_, true, true);
                                                                            bool? go_ = context.Operators.In<CqlDate>(X, gn_, (string)default);
                                                                            return !go_;
                                                                        }

                                                                        IEnumerable<CqlDate> fz_ = context.Operators.Where<CqlDate>(fv_, fy_);
                                                                        int? ga_ = context.Operators.Add(fw_, 1);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gb_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fx_ as CqlDate, fz_, ga_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gc_ = [
                                                                            gb_,
                                                                        ];

                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gd_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList) {
                                                                            IEnumerable<CqlDate> gp_ = EighthList?.NewList;
                                                                            int? gq_ = EighthList?.IndexofNewDate;
                                                                            CqlDate gr_ = context.Operators.Indexer<CqlDate>(gp_, gq_);
                                                                            if (gr_ is null)
                                                                            {
                                                                                return EighthList;
                                                                            }
                                                                            else
                                                                            {
                                                                                IEnumerable<CqlDate> gs_ = EighthList?.NewList;
                                                                                int? gt_ = EighthList?.IndexofNewDate;
                                                                                CqlDate gu_ = context.Operators.Indexer<CqlDate>(gs_, gt_);

                                                                                bool? gv_(CqlDate X) {
                                                                                    IEnumerable<CqlDate> hd_ = EighthList?.NewList;
                                                                                    int? he_ = EighthList?.IndexofNewDate;
                                                                                    CqlDate hf_ = context.Operators.Indexer<CqlDate>(hd_, he_);
                                                                                    CqlQuantity hg_ = context.Operators.Quantity(1m, "day");
                                                                                    CqlDate hh_ = context.Operators.Add(hf_ as CqlDate, hg_);
                                                                                    CqlQuantity hi_ = context.Operators.Quantity(30m, "days");
                                                                                    CqlDate hj_ = context.Operators.Add(hf_ as CqlDate, hi_);
                                                                                    CqlInterval<CqlDate> hk_ = context.Operators.Interval(hh_, hj_, true, true);
                                                                                    bool? hl_ = context.Operators.In<CqlDate>(X, hk_, (string)default);
                                                                                    return !hl_;
                                                                                }

                                                                                IEnumerable<CqlDate> gw_ = context.Operators.Where<CqlDate>(gs_, gv_);
                                                                                int? gx_ = context.Operators.Add(gt_, 1);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gu_ as CqlDate, gw_, gx_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gz_ = [
                                                                                    gy_,
                                                                                ];

                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ha_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList) {
                                                                                    IEnumerable<CqlDate> hm_ = NinethList?.NewList;
                                                                                    int? hn_ = NinethList?.IndexofNewDate;
                                                                                    CqlDate ho_ = context.Operators.Indexer<CqlDate>(hm_, hn_);
                                                                                    if (ho_ is null)
                                                                                    {
                                                                                        return NinethList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> hp_ = NinethList?.NewList;
                                                                                        int? hq_ = NinethList?.IndexofNewDate;
                                                                                        CqlDate hr_ = context.Operators.Indexer<CqlDate>(hp_, hq_);

                                                                                        bool? hs_(CqlDate X) {
                                                                                            IEnumerable<CqlDate> ia_ = NinethList?.NewList;
                                                                                            int? ib_ = NinethList?.IndexofNewDate;
                                                                                            CqlDate ic_ = context.Operators.Indexer<CqlDate>(ia_, ib_);
                                                                                            CqlQuantity id_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate ie_ = context.Operators.Add(ic_ as CqlDate, id_);
                                                                                            CqlQuantity if_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate ig_ = context.Operators.Add(ic_ as CqlDate, if_);
                                                                                            CqlInterval<CqlDate> ih_ = context.Operators.Interval(ie_, ig_, true, true);
                                                                                            bool? ii_ = context.Operators.In<CqlDate>(X, ih_, (string)default);
                                                                                            return !ii_;
                                                                                        }

                                                                                        IEnumerable<CqlDate> ht_ = context.Operators.Where<CqlDate>(hp_, hs_);
                                                                                        int? hu_ = context.Operators.Add(hq_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hv_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hr_ as CqlDate, ht_, hu_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hw_ = [
                                                                                            hv_,
                                                                                        ];

                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hx_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList) {
                                                                                            IEnumerable<CqlDate> ij_ = TenthList?.NewList;
                                                                                            int? ik_ = TenthList?.IndexofNewDate;
                                                                                            CqlDate il_ = context.Operators.Indexer<CqlDate>(ij_, ik_);
                                                                                            if (il_ is null)
                                                                                            {
                                                                                                return TenthList;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                IEnumerable<CqlDate> im_ = TenthList?.NewList;
                                                                                                int? in_ = TenthList?.IndexofNewDate;
                                                                                                CqlDate io_ = context.Operators.Indexer<CqlDate>(im_, in_);

                                                                                                bool? ip_(CqlDate X) {
                                                                                                    IEnumerable<CqlDate> ix_ = TenthList?.NewList;
                                                                                                    int? iy_ = TenthList?.IndexofNewDate;
                                                                                                    CqlDate iz_ = context.Operators.Indexer<CqlDate>(ix_, iy_);
                                                                                                    CqlQuantity ja_ = context.Operators.Quantity(1m, "day");
                                                                                                    CqlDate jb_ = context.Operators.Add(iz_ as CqlDate, ja_);
                                                                                                    CqlQuantity jc_ = context.Operators.Quantity(30m, "days");
                                                                                                    CqlDate jd_ = context.Operators.Add(iz_ as CqlDate, jc_);
                                                                                                    CqlInterval<CqlDate> je_ = context.Operators.Interval(jb_, jd_, true, true);
                                                                                                    bool? jf_ = context.Operators.In<CqlDate>(X, je_, (string)default);
                                                                                                    return !jf_;
                                                                                                }

                                                                                                IEnumerable<CqlDate> iq_ = context.Operators.Where<CqlDate>(im_, ip_);
                                                                                                int? ir_ = context.Operators.Add(in_, 1);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? is_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, io_ as CqlDate, iq_, ir_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] it_ = [
                                                                                                    is_,
                                                                                                ];

                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList) {
                                                                                                    IEnumerable<CqlDate> jg_ = EleventhList?.NewList;
                                                                                                    int? jh_ = EleventhList?.IndexofNewDate;
                                                                                                    CqlDate ji_ = context.Operators.Indexer<CqlDate>(jg_, jh_);
                                                                                                    if (ji_ is null)
                                                                                                    {
                                                                                                        return EleventhList;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> jj_ = EleventhList?.NewList;
                                                                                                        int? jk_ = EleventhList?.IndexofNewDate;
                                                                                                        CqlDate jl_ = context.Operators.Indexer<CqlDate>(jj_, jk_);

                                                                                                        bool? jm_(CqlDate X) {
                                                                                                            IEnumerable<CqlDate> jq_ = EleventhList?.NewList;
                                                                                                            int? jr_ = EleventhList?.IndexofNewDate;
                                                                                                            CqlDate js_ = context.Operators.Indexer<CqlDate>(jq_, jr_);
                                                                                                            CqlQuantity jt_ = context.Operators.Quantity(1m, "day");
                                                                                                            CqlDate ju_ = context.Operators.Add(js_ as CqlDate, jt_);
                                                                                                            CqlQuantity jv_ = context.Operators.Quantity(30m, "days");
                                                                                                            CqlDate jw_ = context.Operators.Add(js_ as CqlDate, jv_);
                                                                                                            CqlInterval<CqlDate> jx_ = context.Operators.Interval(ju_, jw_, true, true);
                                                                                                            bool? jy_ = context.Operators.In<CqlDate>(X, jx_, (string)default);
                                                                                                            return !jy_;
                                                                                                        }

                                                                                                        IEnumerable<CqlDate> jn_ = context.Operators.Where<CqlDate>(jj_, jm_);
                                                                                                        int? jo_ = context.Operators.Add(jk_, 1);
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jp_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jl_ as CqlDate, jn_, jo_);
                                                                                                        return jp_;
                                                                                                    }
                                                                                                }

                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> iv_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)it_, iu_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(iv_);
                                                                                                return iw_;
                                                                                            }
                                                                                        }

                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hy_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hw_, hx_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hy_);
                                                                                        return hz_;
                                                                                    }
                                                                                }

                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hb_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gz_, ha_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hb_);
                                                                                return hc_;
                                                                            }
                                                                        }

                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ge_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gc_, gd_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ge_);
                                                                        return gf_;
                                                                    }
                                                                }

                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fh_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ff_, fg_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fh_);
                                                                return fi_;
                                                            }
                                                        }

                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ek_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ei_, ej_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? el_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ek_);
                                                        return el_;
                                                    }
                                                }

                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dn_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)dl_, dm_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? do_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dn_);
                                                return do_;
                                            }
                                        }

                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cq_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)co_, cp_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cq_);
                                        return cr_;
                                    }
                                }

                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bt_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)br_, bs_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bt_);
                                return bu_;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> aw_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)au_, av_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ax_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(aw_);
                        return ax_;
                    }
                }

                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> z_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)x_, y_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aa_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(z_);
                return aa_;
            }

            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> o_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)m_, n_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? p_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(o_);
            return p_;
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
