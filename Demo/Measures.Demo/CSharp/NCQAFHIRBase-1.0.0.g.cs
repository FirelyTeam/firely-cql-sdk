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

                        bool? an_(CqlDate X) {
                            IEnumerable<CqlDate> av_ = FirstList?.NewList;
                            int? aw_ = FirstList?.IndexofNewDate;
                            CqlDate ax_ = context.Operators.Indexer<CqlDate>(av_, aw_);
                            CqlQuantity ay_ = context.Operators.Quantity(1m, "day");
                            CqlDate az_ = context.Operators.Add(ax_ as CqlDate, ay_);
                            CqlQuantity ba_ = context.Operators.Quantity(30m, "days");
                            CqlDate bb_ = context.Operators.Add(ax_ as CqlDate, ba_);
                            CqlInterval<CqlDate> bc_ = context.Operators.Interval(az_, bb_, true, true);
                            bool? bd_ = context.Operators.In<CqlDate>(X, bc_, (string)default);
                            return !bd_;
                        }

                        IEnumerable<CqlDate> ao_ = context.Operators.Where<CqlDate>(ak_, an_);
                        int? ap_ = context.Operators.Add(al_, 1);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, am_ as CqlDate, ao_, ap_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ar_ = [
                            aq_,
                        ];

                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? as_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList) {
                            IEnumerable<CqlDate> be_ = SecondList?.NewList;
                            int? bf_ = SecondList?.IndexofNewDate;
                            CqlDate bg_ = context.Operators.Indexer<CqlDate>(be_, bf_);
                            if (bg_ is null)
                            {
                                return SecondList;
                            }
                            else
                            {

                                bool? bh_(CqlDate X) {
                                    IEnumerable<CqlDate> bp_ = SecondList?.NewList;
                                    int? bq_ = SecondList?.IndexofNewDate;
                                    CqlDate br_ = context.Operators.Indexer<CqlDate>(bp_, bq_);
                                    CqlQuantity bs_ = context.Operators.Quantity(1m, "day");
                                    CqlDate bt_ = context.Operators.Add(br_ as CqlDate, bs_);
                                    CqlQuantity bu_ = context.Operators.Quantity(30m, "days");
                                    CqlDate bv_ = context.Operators.Add(br_ as CqlDate, bu_);
                                    CqlInterval<CqlDate> bw_ = context.Operators.Interval(bt_, bv_, true, true);
                                    bool? bx_ = context.Operators.In<CqlDate>(X, bw_, (string)default);
                                    return !bx_;
                                }

                                IEnumerable<CqlDate> bi_ = context.Operators.Where<CqlDate>(be_, bh_);
                                int? bj_ = context.Operators.Add(bf_, 1);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bk_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bg_ as CqlDate, bi_, bj_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bl_ = [
                                    bk_,
                                ];

                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bm_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList) {
                                    IEnumerable<CqlDate> by_ = ThirdList?.NewList;
                                    int? bz_ = ThirdList?.IndexofNewDate;
                                    CqlDate ca_ = context.Operators.Indexer<CqlDate>(by_, bz_);
                                    if (ca_ is null)
                                    {
                                        return ThirdList;
                                    }
                                    else
                                    {

                                        bool? cb_(CqlDate X) {
                                            IEnumerable<CqlDate> cj_ = ThirdList?.NewList;
                                            int? ck_ = ThirdList?.IndexofNewDate;
                                            CqlDate cl_ = context.Operators.Indexer<CqlDate>(cj_, ck_);
                                            CqlQuantity cm_ = context.Operators.Quantity(1m, "day");
                                            CqlDate cn_ = context.Operators.Add(cl_ as CqlDate, cm_);
                                            CqlQuantity co_ = context.Operators.Quantity(30m, "days");
                                            CqlDate cp_ = context.Operators.Add(cl_ as CqlDate, co_);
                                            CqlInterval<CqlDate> cq_ = context.Operators.Interval(cn_, cp_, true, true);
                                            bool? cr_ = context.Operators.In<CqlDate>(X, cq_, (string)default);
                                            return !cr_;
                                        }

                                        IEnumerable<CqlDate> cc_ = context.Operators.Where<CqlDate>(by_, cb_);
                                        int? cd_ = context.Operators.Add(bz_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ce_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ca_ as CqlDate, cc_, cd_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] cf_ = [
                                            ce_,
                                        ];

                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cg_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList) {
                                            IEnumerable<CqlDate> cs_ = FourthList?.NewList;
                                            int? ct_ = FourthList?.IndexofNewDate;
                                            CqlDate cu_ = context.Operators.Indexer<CqlDate>(cs_, ct_);
                                            if (cu_ is null)
                                            {
                                                return FourthList;
                                            }
                                            else
                                            {

                                                bool? cv_(CqlDate X) {
                                                    IEnumerable<CqlDate> dd_ = FourthList?.NewList;
                                                    int? de_ = FourthList?.IndexofNewDate;
                                                    CqlDate df_ = context.Operators.Indexer<CqlDate>(dd_, de_);
                                                    CqlQuantity dg_ = context.Operators.Quantity(1m, "day");
                                                    CqlDate dh_ = context.Operators.Add(df_ as CqlDate, dg_);
                                                    CqlQuantity di_ = context.Operators.Quantity(30m, "days");
                                                    CqlDate dj_ = context.Operators.Add(df_ as CqlDate, di_);
                                                    CqlInterval<CqlDate> dk_ = context.Operators.Interval(dh_, dj_, true, true);
                                                    bool? dl_ = context.Operators.In<CqlDate>(X, dk_, (string)default);
                                                    return !dl_;
                                                }

                                                IEnumerable<CqlDate> cw_ = context.Operators.Where<CqlDate>(cs_, cv_);
                                                int? cx_ = context.Operators.Add(ct_, 1);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, cu_ as CqlDate, cw_, cx_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] cz_ = [
                                                    cy_,
                                                ];

                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? da_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList) {
                                                    IEnumerable<CqlDate> dm_ = FifthList?.NewList;
                                                    int? dn_ = FifthList?.IndexofNewDate;
                                                    CqlDate do_ = context.Operators.Indexer<CqlDate>(dm_, dn_);
                                                    if (do_ is null)
                                                    {
                                                        return FifthList;
                                                    }
                                                    else
                                                    {

                                                        bool? dp_(CqlDate X) {
                                                            IEnumerable<CqlDate> dx_ = FifthList?.NewList;
                                                            int? dy_ = FifthList?.IndexofNewDate;
                                                            CqlDate dz_ = context.Operators.Indexer<CqlDate>(dx_, dy_);
                                                            CqlQuantity ea_ = context.Operators.Quantity(1m, "day");
                                                            CqlDate eb_ = context.Operators.Add(dz_ as CqlDate, ea_);
                                                            CqlQuantity ec_ = context.Operators.Quantity(30m, "days");
                                                            CqlDate ed_ = context.Operators.Add(dz_ as CqlDate, ec_);
                                                            CqlInterval<CqlDate> ee_ = context.Operators.Interval(eb_, ed_, true, true);
                                                            bool? ef_ = context.Operators.In<CqlDate>(X, ee_, (string)default);
                                                            return !ef_;
                                                        }

                                                        IEnumerable<CqlDate> dq_ = context.Operators.Where<CqlDate>(dm_, dp_);
                                                        int? dr_ = context.Operators.Add(dn_, 1);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ds_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, do_ as CqlDate, dq_, dr_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] dt_ = [
                                                            ds_,
                                                        ];

                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? du_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList) {
                                                            IEnumerable<CqlDate> eg_ = SixthList?.NewList;
                                                            int? eh_ = SixthList?.IndexofNewDate;
                                                            CqlDate ei_ = context.Operators.Indexer<CqlDate>(eg_, eh_);
                                                            if (ei_ is null)
                                                            {
                                                                return SixthList;
                                                            }
                                                            else
                                                            {

                                                                bool? ej_(CqlDate X) {
                                                                    IEnumerable<CqlDate> er_ = SixthList?.NewList;
                                                                    int? es_ = SixthList?.IndexofNewDate;
                                                                    CqlDate et_ = context.Operators.Indexer<CqlDate>(er_, es_);
                                                                    CqlQuantity eu_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate ev_ = context.Operators.Add(et_ as CqlDate, eu_);
                                                                    CqlQuantity ew_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate ex_ = context.Operators.Add(et_ as CqlDate, ew_);
                                                                    CqlInterval<CqlDate> ey_ = context.Operators.Interval(ev_, ex_, true, true);
                                                                    bool? ez_ = context.Operators.In<CqlDate>(X, ey_, (string)default);
                                                                    return !ez_;
                                                                }

                                                                IEnumerable<CqlDate> ek_ = context.Operators.Where<CqlDate>(eg_, ej_);
                                                                int? el_ = context.Operators.Add(eh_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? em_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ei_ as CqlDate, ek_, el_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] en_ = [
                                                                    em_,
                                                                ];

                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eo_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList) {
                                                                    IEnumerable<CqlDate> fa_ = SeventhList?.NewList;
                                                                    int? fb_ = SeventhList?.IndexofNewDate;
                                                                    CqlDate fc_ = context.Operators.Indexer<CqlDate>(fa_, fb_);
                                                                    if (fc_ is null)
                                                                    {
                                                                        return SeventhList;
                                                                    }
                                                                    else
                                                                    {

                                                                        bool? fd_(CqlDate X) {
                                                                            IEnumerable<CqlDate> fl_ = SeventhList?.NewList;
                                                                            int? fm_ = SeventhList?.IndexofNewDate;
                                                                            CqlDate fn_ = context.Operators.Indexer<CqlDate>(fl_, fm_);
                                                                            CqlQuantity fo_ = context.Operators.Quantity(1m, "day");
                                                                            CqlDate fp_ = context.Operators.Add(fn_ as CqlDate, fo_);
                                                                            CqlQuantity fq_ = context.Operators.Quantity(30m, "days");
                                                                            CqlDate fr_ = context.Operators.Add(fn_ as CqlDate, fq_);
                                                                            CqlInterval<CqlDate> fs_ = context.Operators.Interval(fp_, fr_, true, true);
                                                                            bool? ft_ = context.Operators.In<CqlDate>(X, fs_, (string)default);
                                                                            return !ft_;
                                                                        }

                                                                        IEnumerable<CqlDate> fe_ = context.Operators.Where<CqlDate>(fa_, fd_);
                                                                        int? ff_ = context.Operators.Add(fb_, 1);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fc_ as CqlDate, fe_, ff_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fh_ = [
                                                                            fg_,
                                                                        ];

                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList) {
                                                                            IEnumerable<CqlDate> fu_ = EighthList?.NewList;
                                                                            int? fv_ = EighthList?.IndexofNewDate;
                                                                            CqlDate fw_ = context.Operators.Indexer<CqlDate>(fu_, fv_);
                                                                            if (fw_ is null)
                                                                            {
                                                                                return EighthList;
                                                                            }
                                                                            else
                                                                            {

                                                                                bool? fx_(CqlDate X) {
                                                                                    IEnumerable<CqlDate> gf_ = EighthList?.NewList;
                                                                                    int? gg_ = EighthList?.IndexofNewDate;
                                                                                    CqlDate gh_ = context.Operators.Indexer<CqlDate>(gf_, gg_);
                                                                                    CqlQuantity gi_ = context.Operators.Quantity(1m, "day");
                                                                                    CqlDate gj_ = context.Operators.Add(gh_ as CqlDate, gi_);
                                                                                    CqlQuantity gk_ = context.Operators.Quantity(30m, "days");
                                                                                    CqlDate gl_ = context.Operators.Add(gh_ as CqlDate, gk_);
                                                                                    CqlInterval<CqlDate> gm_ = context.Operators.Interval(gj_, gl_, true, true);
                                                                                    bool? gn_ = context.Operators.In<CqlDate>(X, gm_, (string)default);
                                                                                    return !gn_;
                                                                                }

                                                                                IEnumerable<CqlDate> fy_ = context.Operators.Where<CqlDate>(fu_, fx_);
                                                                                int? fz_ = context.Operators.Add(fv_, 1);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ga_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fw_ as CqlDate, fy_, fz_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gb_ = [
                                                                                    ga_,
                                                                                ];

                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gc_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList) {
                                                                                    IEnumerable<CqlDate> go_ = NinethList?.NewList;
                                                                                    int? gp_ = NinethList?.IndexofNewDate;
                                                                                    CqlDate gq_ = context.Operators.Indexer<CqlDate>(go_, gp_);
                                                                                    if (gq_ is null)
                                                                                    {
                                                                                        return NinethList;
                                                                                    }
                                                                                    else
                                                                                    {

                                                                                        bool? gr_(CqlDate X) {
                                                                                            IEnumerable<CqlDate> gz_ = NinethList?.NewList;
                                                                                            int? ha_ = NinethList?.IndexofNewDate;
                                                                                            CqlDate hb_ = context.Operators.Indexer<CqlDate>(gz_, ha_);
                                                                                            CqlQuantity hc_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate hd_ = context.Operators.Add(hb_ as CqlDate, hc_);
                                                                                            CqlQuantity he_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate hf_ = context.Operators.Add(hb_ as CqlDate, he_);
                                                                                            CqlInterval<CqlDate> hg_ = context.Operators.Interval(hd_, hf_, true, true);
                                                                                            bool? hh_ = context.Operators.In<CqlDate>(X, hg_, (string)default);
                                                                                            return !hh_;
                                                                                        }

                                                                                        IEnumerable<CqlDate> gs_ = context.Operators.Where<CqlDate>(go_, gr_);
                                                                                        int? gt_ = context.Operators.Add(gp_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gq_ as CqlDate, gs_, gt_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gv_ = [
                                                                                            gu_,
                                                                                        ];

                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gw_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList) {
                                                                                            IEnumerable<CqlDate> hi_ = TenthList?.NewList;
                                                                                            int? hj_ = TenthList?.IndexofNewDate;
                                                                                            CqlDate hk_ = context.Operators.Indexer<CqlDate>(hi_, hj_);
                                                                                            if (hk_ is null)
                                                                                            {
                                                                                                return TenthList;
                                                                                            }
                                                                                            else
                                                                                            {

                                                                                                bool? hl_(CqlDate X) {
                                                                                                    IEnumerable<CqlDate> ht_ = TenthList?.NewList;
                                                                                                    int? hu_ = TenthList?.IndexofNewDate;
                                                                                                    CqlDate hv_ = context.Operators.Indexer<CqlDate>(ht_, hu_);
                                                                                                    CqlQuantity hw_ = context.Operators.Quantity(1m, "day");
                                                                                                    CqlDate hx_ = context.Operators.Add(hv_ as CqlDate, hw_);
                                                                                                    CqlQuantity hy_ = context.Operators.Quantity(30m, "days");
                                                                                                    CqlDate hz_ = context.Operators.Add(hv_ as CqlDate, hy_);
                                                                                                    CqlInterval<CqlDate> ia_ = context.Operators.Interval(hx_, hz_, true, true);
                                                                                                    bool? ib_ = context.Operators.In<CqlDate>(X, ia_, (string)default);
                                                                                                    return !ib_;
                                                                                                }

                                                                                                IEnumerable<CqlDate> hm_ = context.Operators.Where<CqlDate>(hi_, hl_);
                                                                                                int? hn_ = context.Operators.Add(hj_, 1);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ho_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hk_ as CqlDate, hm_, hn_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hp_ = [
                                                                                                    ho_,
                                                                                                ];

                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hq_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList) {
                                                                                                    IEnumerable<CqlDate> ic_ = EleventhList?.NewList;
                                                                                                    int? id_ = EleventhList?.IndexofNewDate;
                                                                                                    CqlDate ie_ = context.Operators.Indexer<CqlDate>(ic_, id_);
                                                                                                    if (ie_ is null)
                                                                                                    {
                                                                                                        return EleventhList;
                                                                                                    }
                                                                                                    else
                                                                                                    {

                                                                                                        bool? if_(CqlDate X) {
                                                                                                            IEnumerable<CqlDate> ij_ = EleventhList?.NewList;
                                                                                                            int? ik_ = EleventhList?.IndexofNewDate;
                                                                                                            CqlDate il_ = context.Operators.Indexer<CqlDate>(ij_, ik_);
                                                                                                            CqlQuantity im_ = context.Operators.Quantity(1m, "day");
                                                                                                            CqlDate in_ = context.Operators.Add(il_ as CqlDate, im_);
                                                                                                            CqlQuantity io_ = context.Operators.Quantity(30m, "days");
                                                                                                            CqlDate ip_ = context.Operators.Add(il_ as CqlDate, io_);
                                                                                                            CqlInterval<CqlDate> iq_ = context.Operators.Interval(in_, ip_, true, true);
                                                                                                            bool? ir_ = context.Operators.In<CqlDate>(X, iq_, (string)default);
                                                                                                            return !ir_;
                                                                                                        }

                                                                                                        IEnumerable<CqlDate> ig_ = context.Operators.Where<CqlDate>(ic_, if_);
                                                                                                        int? ih_ = context.Operators.Add(id_, 1);
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ii_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ie_ as CqlDate, ig_, ih_);
                                                                                                        return ii_;
                                                                                                    }
                                                                                                }

                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hr_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hp_, hq_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hr_);
                                                                                                return hs_;
                                                                                            }
                                                                                        }

                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gx_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gv_, gw_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gx_);
                                                                                        return gy_;
                                                                                    }
                                                                                }

                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gd_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gb_, gc_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ge_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gd_);
                                                                                return ge_;
                                                                            }
                                                                        }

                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fj_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fh_, fi_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fj_);
                                                                        return fk_;
                                                                    }
                                                                }

                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ep_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)en_, eo_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ep_);
                                                                return eq_;
                                                            }
                                                        }

                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dv_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)dt_, du_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dv_);
                                                        return dw_;
                                                    }
                                                }

                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> db_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cz_, da_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(db_);
                                                return dc_;
                                            }
                                        }

                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ch_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cf_, cg_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ci_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ch_);
                                        return ci_;
                                    }
                                }

                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bn_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bl_, bm_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bn_);
                                return bo_;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> at_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ar_, as_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? au_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(at_);
                        return au_;
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
