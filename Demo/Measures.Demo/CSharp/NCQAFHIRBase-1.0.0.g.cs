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
            CqlQuantity r_ = context.Operators.Quantity(1m, "year");
            CqlDate s_ = context.Operators.Add(q_, r_);
            CqlInterval<CqlDate> t_ = context.Operators.Interval(q_, s_, true, false);
            CqlDate u_ = t_?.low;
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
            CqlDate w_ = t_?.high;
            CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
            bool? y_ = t_?.lowClosed;
            bool? z_ = t_?.highClosed;
            CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(v_, x_, y_, z_);
            return aa_;
        }
        else if (choice is Range)
        {
            Patient ab_ = this.Patient(context);
            Date ac_ = ab_?.BirthDateElement;
            CqlDate ad_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ac_);
            Quantity ae_ = (choice as Range)?.Low;
            CqlQuantity af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_);
            CqlDate ag_ = context.Operators.Add(ad_, af_);
            Quantity ah_ = (choice as Range)?.High;
            CqlQuantity ai_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ah_);
            CqlDate aj_ = context.Operators.Add(ad_, ai_);
            CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
            CqlDate al_ = context.Operators.Add(aj_, ak_);
            CqlInterval<CqlDate> am_ = context.Operators.Interval(ag_, al_, true, false);
            CqlDate an_ = am_?.low;
            CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
            CqlDate ap_ = am_?.high;
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
            bool? ar_ = am_?.lowClosed;
            bool? as_ = am_?.highClosed;
            CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ao_, aq_, ar_, as_);
            return at_;
        }
        else if (choice is Timing)
        {
            CqlInterval<CqlDateTime> au_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
            return au_;
        }
        else if (choice is FhirString)
        {
            CqlInterval<CqlDateTime> av_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return av_;
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
                    IEnumerable<CqlDate> aq_ = FirstList?.NewList;
                    int? ar_ = FirstList?.IndexofNewDate;
                    CqlDate as_ = context.Operators.Indexer<CqlDate>(aq_, ar_);
                    if (as_ is null)
                    {
                        return FirstList;
                    }
                    else
                    {
                        IEnumerable<CqlDate> at_ = FirstList?.NewList;
                        int? au_ = FirstList?.IndexofNewDate;
                        CqlDate av_ = context.Operators.Indexer<CqlDate>(at_, au_);

                        bool? aw_(CqlDate X) {
                            IEnumerable<CqlDate> bf_ = FirstList?.NewList;
                            int? bg_ = FirstList?.IndexofNewDate;
                            CqlDate bh_ = context.Operators.Indexer<CqlDate>(bf_, bg_);
                            CqlQuantity bi_ = context.Operators.Quantity(1m, "day");
                            CqlDate bj_ = context.Operators.Add(bh_ as CqlDate, bi_);
                            CqlQuantity bk_ = context.Operators.Quantity(30m, "days");
                            CqlDate bl_ = context.Operators.Add(bh_ as CqlDate, bk_);
                            CqlInterval<CqlDate> bm_ = context.Operators.Interval(bj_, bl_, true, true);
                            bool? bn_ = context.Operators.In<CqlDate>(X, bm_, (string)default);
                            bool? bo_ = context.Operators.Not(bn_);
                            return bo_;
                        }

                        IEnumerable<CqlDate> ax_ = context.Operators.Where<CqlDate>(at_, aw_);
                        int? ay_ = context.Operators.Add(au_, 1);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? az_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, av_ as CqlDate, ax_, ay_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ba_ = [
                            az_,
                        ];

                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bb_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList) {
                            IEnumerable<CqlDate> bp_ = SecondList?.NewList;
                            int? bq_ = SecondList?.IndexofNewDate;
                            CqlDate br_ = context.Operators.Indexer<CqlDate>(bp_, bq_);
                            if (br_ is null)
                            {
                                return SecondList;
                            }
                            else
                            {
                                IEnumerable<CqlDate> bs_ = SecondList?.NewList;
                                int? bt_ = SecondList?.IndexofNewDate;
                                CqlDate bu_ = context.Operators.Indexer<CqlDate>(bs_, bt_);

                                bool? bv_(CqlDate X) {
                                    IEnumerable<CqlDate> ce_ = SecondList?.NewList;
                                    int? cf_ = SecondList?.IndexofNewDate;
                                    CqlDate cg_ = context.Operators.Indexer<CqlDate>(ce_, cf_);
                                    CqlQuantity ch_ = context.Operators.Quantity(1m, "day");
                                    CqlDate ci_ = context.Operators.Add(cg_ as CqlDate, ch_);
                                    CqlQuantity cj_ = context.Operators.Quantity(30m, "days");
                                    CqlDate ck_ = context.Operators.Add(cg_ as CqlDate, cj_);
                                    CqlInterval<CqlDate> cl_ = context.Operators.Interval(ci_, ck_, true, true);
                                    bool? cm_ = context.Operators.In<CqlDate>(X, cl_, (string)default);
                                    bool? cn_ = context.Operators.Not(cm_);
                                    return cn_;
                                }

                                IEnumerable<CqlDate> bw_ = context.Operators.Where<CqlDate>(bs_, bv_);
                                int? bx_ = context.Operators.Add(bt_, 1);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? by_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bu_ as CqlDate, bw_, bx_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bz_ = [
                                    by_,
                                ];

                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ca_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList) {
                                    IEnumerable<CqlDate> co_ = ThirdList?.NewList;
                                    int? cp_ = ThirdList?.IndexofNewDate;
                                    CqlDate cq_ = context.Operators.Indexer<CqlDate>(co_, cp_);
                                    if (cq_ is null)
                                    {
                                        return ThirdList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> cr_ = ThirdList?.NewList;
                                        int? cs_ = ThirdList?.IndexofNewDate;
                                        CqlDate ct_ = context.Operators.Indexer<CqlDate>(cr_, cs_);

                                        bool? cu_(CqlDate X) {
                                            IEnumerable<CqlDate> dd_ = ThirdList?.NewList;
                                            int? de_ = ThirdList?.IndexofNewDate;
                                            CqlDate df_ = context.Operators.Indexer<CqlDate>(dd_, de_);
                                            CqlQuantity dg_ = context.Operators.Quantity(1m, "day");
                                            CqlDate dh_ = context.Operators.Add(df_ as CqlDate, dg_);
                                            CqlQuantity di_ = context.Operators.Quantity(30m, "days");
                                            CqlDate dj_ = context.Operators.Add(df_ as CqlDate, di_);
                                            CqlInterval<CqlDate> dk_ = context.Operators.Interval(dh_, dj_, true, true);
                                            bool? dl_ = context.Operators.In<CqlDate>(X, dk_, (string)default);
                                            bool? dm_ = context.Operators.Not(dl_);
                                            return dm_;
                                        }

                                        IEnumerable<CqlDate> cv_ = context.Operators.Where<CqlDate>(cr_, cu_);
                                        int? cw_ = context.Operators.Add(cs_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cx_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ct_ as CqlDate, cv_, cw_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] cy_ = [
                                            cx_,
                                        ];

                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cz_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList) {
                                            IEnumerable<CqlDate> dn_ = FourthList?.NewList;
                                            int? do_ = FourthList?.IndexofNewDate;
                                            CqlDate dp_ = context.Operators.Indexer<CqlDate>(dn_, do_);
                                            if (dp_ is null)
                                            {
                                                return FourthList;
                                            }
                                            else
                                            {
                                                IEnumerable<CqlDate> dq_ = FourthList?.NewList;
                                                int? dr_ = FourthList?.IndexofNewDate;
                                                CqlDate ds_ = context.Operators.Indexer<CqlDate>(dq_, dr_);

                                                bool? dt_(CqlDate X) {
                                                    IEnumerable<CqlDate> ec_ = FourthList?.NewList;
                                                    int? ed_ = FourthList?.IndexofNewDate;
                                                    CqlDate ee_ = context.Operators.Indexer<CqlDate>(ec_, ed_);
                                                    CqlQuantity ef_ = context.Operators.Quantity(1m, "day");
                                                    CqlDate eg_ = context.Operators.Add(ee_ as CqlDate, ef_);
                                                    CqlQuantity eh_ = context.Operators.Quantity(30m, "days");
                                                    CqlDate ei_ = context.Operators.Add(ee_ as CqlDate, eh_);
                                                    CqlInterval<CqlDate> ej_ = context.Operators.Interval(eg_, ei_, true, true);
                                                    bool? ek_ = context.Operators.In<CqlDate>(X, ej_, (string)default);
                                                    bool? el_ = context.Operators.Not(ek_);
                                                    return el_;
                                                }

                                                IEnumerable<CqlDate> du_ = context.Operators.Where<CqlDate>(dq_, dt_);
                                                int? dv_ = context.Operators.Add(dr_, 1);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dw_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ds_ as CqlDate, du_, dv_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] dx_ = [
                                                    dw_,
                                                ];

                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dy_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList) {
                                                    IEnumerable<CqlDate> em_ = FifthList?.NewList;
                                                    int? en_ = FifthList?.IndexofNewDate;
                                                    CqlDate eo_ = context.Operators.Indexer<CqlDate>(em_, en_);
                                                    if (eo_ is null)
                                                    {
                                                        return FifthList;
                                                    }
                                                    else
                                                    {
                                                        IEnumerable<CqlDate> ep_ = FifthList?.NewList;
                                                        int? eq_ = FifthList?.IndexofNewDate;
                                                        CqlDate er_ = context.Operators.Indexer<CqlDate>(ep_, eq_);

                                                        bool? es_(CqlDate X) {
                                                            IEnumerable<CqlDate> fb_ = FifthList?.NewList;
                                                            int? fc_ = FifthList?.IndexofNewDate;
                                                            CqlDate fd_ = context.Operators.Indexer<CqlDate>(fb_, fc_);
                                                            CqlQuantity fe_ = context.Operators.Quantity(1m, "day");
                                                            CqlDate ff_ = context.Operators.Add(fd_ as CqlDate, fe_);
                                                            CqlQuantity fg_ = context.Operators.Quantity(30m, "days");
                                                            CqlDate fh_ = context.Operators.Add(fd_ as CqlDate, fg_);
                                                            CqlInterval<CqlDate> fi_ = context.Operators.Interval(ff_, fh_, true, true);
                                                            bool? fj_ = context.Operators.In<CqlDate>(X, fi_, (string)default);
                                                            bool? fk_ = context.Operators.Not(fj_);
                                                            return fk_;
                                                        }

                                                        IEnumerable<CqlDate> et_ = context.Operators.Where<CqlDate>(ep_, es_);
                                                        int? eu_ = context.Operators.Add(eq_, 1);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ev_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, er_ as CqlDate, et_, eu_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ew_ = [
                                                            ev_,
                                                        ];

                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ex_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList) {
                                                            IEnumerable<CqlDate> fl_ = SixthList?.NewList;
                                                            int? fm_ = SixthList?.IndexofNewDate;
                                                            CqlDate fn_ = context.Operators.Indexer<CqlDate>(fl_, fm_);
                                                            if (fn_ is null)
                                                            {
                                                                return SixthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> fo_ = SixthList?.NewList;
                                                                int? fp_ = SixthList?.IndexofNewDate;
                                                                CqlDate fq_ = context.Operators.Indexer<CqlDate>(fo_, fp_);

                                                                bool? fr_(CqlDate X) {
                                                                    IEnumerable<CqlDate> ga_ = SixthList?.NewList;
                                                                    int? gb_ = SixthList?.IndexofNewDate;
                                                                    CqlDate gc_ = context.Operators.Indexer<CqlDate>(ga_, gb_);
                                                                    CqlQuantity gd_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate ge_ = context.Operators.Add(gc_ as CqlDate, gd_);
                                                                    CqlQuantity gf_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate gg_ = context.Operators.Add(gc_ as CqlDate, gf_);
                                                                    CqlInterval<CqlDate> gh_ = context.Operators.Interval(ge_, gg_, true, true);
                                                                    bool? gi_ = context.Operators.In<CqlDate>(X, gh_, (string)default);
                                                                    bool? gj_ = context.Operators.Not(gi_);
                                                                    return gj_;
                                                                }

                                                                IEnumerable<CqlDate> fs_ = context.Operators.Where<CqlDate>(fo_, fr_);
                                                                int? ft_ = context.Operators.Add(fp_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fq_ as CqlDate, fs_, ft_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fv_ = [
                                                                    fu_,
                                                                ];

                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fw_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList) {
                                                                    IEnumerable<CqlDate> gk_ = SeventhList?.NewList;
                                                                    int? gl_ = SeventhList?.IndexofNewDate;
                                                                    CqlDate gm_ = context.Operators.Indexer<CqlDate>(gk_, gl_);
                                                                    if (gm_ is null)
                                                                    {
                                                                        return SeventhList;
                                                                    }
                                                                    else
                                                                    {
                                                                        IEnumerable<CqlDate> gn_ = SeventhList?.NewList;
                                                                        int? go_ = SeventhList?.IndexofNewDate;
                                                                        CqlDate gp_ = context.Operators.Indexer<CqlDate>(gn_, go_);

                                                                        bool? gq_(CqlDate X) {
                                                                            IEnumerable<CqlDate> gz_ = SeventhList?.NewList;
                                                                            int? ha_ = SeventhList?.IndexofNewDate;
                                                                            CqlDate hb_ = context.Operators.Indexer<CqlDate>(gz_, ha_);
                                                                            CqlQuantity hc_ = context.Operators.Quantity(1m, "day");
                                                                            CqlDate hd_ = context.Operators.Add(hb_ as CqlDate, hc_);
                                                                            CqlQuantity he_ = context.Operators.Quantity(30m, "days");
                                                                            CqlDate hf_ = context.Operators.Add(hb_ as CqlDate, he_);
                                                                            CqlInterval<CqlDate> hg_ = context.Operators.Interval(hd_, hf_, true, true);
                                                                            bool? hh_ = context.Operators.In<CqlDate>(X, hg_, (string)default);
                                                                            bool? hi_ = context.Operators.Not(hh_);
                                                                            return hi_;
                                                                        }

                                                                        IEnumerable<CqlDate> gr_ = context.Operators.Where<CqlDate>(gn_, gq_);
                                                                        int? gs_ = context.Operators.Add(go_, 1);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gt_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gp_ as CqlDate, gr_, gs_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gu_ = [
                                                                            gt_,
                                                                        ];

                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gv_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList) {
                                                                            IEnumerable<CqlDate> hj_ = EighthList?.NewList;
                                                                            int? hk_ = EighthList?.IndexofNewDate;
                                                                            CqlDate hl_ = context.Operators.Indexer<CqlDate>(hj_, hk_);
                                                                            if (hl_ is null)
                                                                            {
                                                                                return EighthList;
                                                                            }
                                                                            else
                                                                            {
                                                                                IEnumerable<CqlDate> hm_ = EighthList?.NewList;
                                                                                int? hn_ = EighthList?.IndexofNewDate;
                                                                                CqlDate ho_ = context.Operators.Indexer<CqlDate>(hm_, hn_);

                                                                                bool? hp_(CqlDate X) {
                                                                                    IEnumerable<CqlDate> hy_ = EighthList?.NewList;
                                                                                    int? hz_ = EighthList?.IndexofNewDate;
                                                                                    CqlDate ia_ = context.Operators.Indexer<CqlDate>(hy_, hz_);
                                                                                    CqlQuantity ib_ = context.Operators.Quantity(1m, "day");
                                                                                    CqlDate ic_ = context.Operators.Add(ia_ as CqlDate, ib_);
                                                                                    CqlQuantity id_ = context.Operators.Quantity(30m, "days");
                                                                                    CqlDate ie_ = context.Operators.Add(ia_ as CqlDate, id_);
                                                                                    CqlInterval<CqlDate> if_ = context.Operators.Interval(ic_, ie_, true, true);
                                                                                    bool? ig_ = context.Operators.In<CqlDate>(X, if_, (string)default);
                                                                                    bool? ih_ = context.Operators.Not(ig_);
                                                                                    return ih_;
                                                                                }

                                                                                IEnumerable<CqlDate> hq_ = context.Operators.Where<CqlDate>(hm_, hp_);
                                                                                int? hr_ = context.Operators.Add(hn_, 1);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hs_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ho_ as CqlDate, hq_, hr_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ht_ = [
                                                                                    hs_,
                                                                                ];

                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList) {
                                                                                    IEnumerable<CqlDate> ii_ = NinethList?.NewList;
                                                                                    int? ij_ = NinethList?.IndexofNewDate;
                                                                                    CqlDate ik_ = context.Operators.Indexer<CqlDate>(ii_, ij_);
                                                                                    if (ik_ is null)
                                                                                    {
                                                                                        return NinethList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> il_ = NinethList?.NewList;
                                                                                        int? im_ = NinethList?.IndexofNewDate;
                                                                                        CqlDate in_ = context.Operators.Indexer<CqlDate>(il_, im_);

                                                                                        bool? io_(CqlDate X) {
                                                                                            IEnumerable<CqlDate> ix_ = NinethList?.NewList;
                                                                                            int? iy_ = NinethList?.IndexofNewDate;
                                                                                            CqlDate iz_ = context.Operators.Indexer<CqlDate>(ix_, iy_);
                                                                                            CqlQuantity ja_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate jb_ = context.Operators.Add(iz_ as CqlDate, ja_);
                                                                                            CqlQuantity jc_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate jd_ = context.Operators.Add(iz_ as CqlDate, jc_);
                                                                                            CqlInterval<CqlDate> je_ = context.Operators.Interval(jb_, jd_, true, true);
                                                                                            bool? jf_ = context.Operators.In<CqlDate>(X, je_, (string)default);
                                                                                            bool? jg_ = context.Operators.Not(jf_);
                                                                                            return jg_;
                                                                                        }

                                                                                        IEnumerable<CqlDate> ip_ = context.Operators.Where<CqlDate>(il_, io_);
                                                                                        int? iq_ = context.Operators.Add(im_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ir_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, in_ as CqlDate, ip_, iq_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] is_ = [
                                                                                            ir_,
                                                                                        ];

                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? it_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList) {
                                                                                            IEnumerable<CqlDate> jh_ = TenthList?.NewList;
                                                                                            int? ji_ = TenthList?.IndexofNewDate;
                                                                                            CqlDate jj_ = context.Operators.Indexer<CqlDate>(jh_, ji_);
                                                                                            if (jj_ is null)
                                                                                            {
                                                                                                return TenthList;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                IEnumerable<CqlDate> jk_ = TenthList?.NewList;
                                                                                                int? jl_ = TenthList?.IndexofNewDate;
                                                                                                CqlDate jm_ = context.Operators.Indexer<CqlDate>(jk_, jl_);

                                                                                                bool? jn_(CqlDate X) {
                                                                                                    IEnumerable<CqlDate> jw_ = TenthList?.NewList;
                                                                                                    int? jx_ = TenthList?.IndexofNewDate;
                                                                                                    CqlDate jy_ = context.Operators.Indexer<CqlDate>(jw_, jx_);
                                                                                                    CqlQuantity jz_ = context.Operators.Quantity(1m, "day");
                                                                                                    CqlDate ka_ = context.Operators.Add(jy_ as CqlDate, jz_);
                                                                                                    CqlQuantity kb_ = context.Operators.Quantity(30m, "days");
                                                                                                    CqlDate kc_ = context.Operators.Add(jy_ as CqlDate, kb_);
                                                                                                    CqlInterval<CqlDate> kd_ = context.Operators.Interval(ka_, kc_, true, true);
                                                                                                    bool? ke_ = context.Operators.In<CqlDate>(X, kd_, (string)default);
                                                                                                    bool? kf_ = context.Operators.Not(ke_);
                                                                                                    return kf_;
                                                                                                }

                                                                                                IEnumerable<CqlDate> jo_ = context.Operators.Where<CqlDate>(jk_, jn_);
                                                                                                int? jp_ = context.Operators.Add(jl_, 1);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jm_ as CqlDate, jo_, jp_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] jr_ = [
                                                                                                    jq_,
                                                                                                ];

                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? js_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList) {
                                                                                                    IEnumerable<CqlDate> kg_ = EleventhList?.NewList;
                                                                                                    int? kh_ = EleventhList?.IndexofNewDate;
                                                                                                    CqlDate ki_ = context.Operators.Indexer<CqlDate>(kg_, kh_);
                                                                                                    if (ki_ is null)
                                                                                                    {
                                                                                                        return EleventhList;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> kj_ = EleventhList?.NewList;
                                                                                                        int? kk_ = EleventhList?.IndexofNewDate;
                                                                                                        CqlDate kl_ = context.Operators.Indexer<CqlDate>(kj_, kk_);

                                                                                                        bool? km_(CqlDate X) {
                                                                                                            IEnumerable<CqlDate> kq_ = EleventhList?.NewList;
                                                                                                            int? kr_ = EleventhList?.IndexofNewDate;
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

                                                                                                        IEnumerable<CqlDate> kn_ = context.Operators.Where<CqlDate>(kj_, km_);
                                                                                                        int? ko_ = context.Operators.Add(kk_, 1);
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kp_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, kl_ as CqlDate, kn_, ko_);
                                                                                                        return kp_;
                                                                                                    }
                                                                                                }

                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)jr_, js_);
                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ju_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jt_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ju_);
                                                                                                return jv_;
                                                                                            }
                                                                                        }

                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> iu_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)is_, it_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> iv_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(iu_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(iv_);
                                                                                        return iw_;
                                                                                    }
                                                                                }

                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ht_, hu_);
                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hv_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hw_);
                                                                                return hx_;
                                                                            }
                                                                        }

                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gw_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gu_, gv_);
                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gx_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gw_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gx_);
                                                                        return gy_;
                                                                    }
                                                                }

                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fx_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fv_, fw_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fx_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fy_);
                                                                return fz_;
                                                            }
                                                        }

                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ey_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ew_, ex_);
                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ez_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ey_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fa_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ez_);
                                                        return fa_;
                                                    }
                                                }

                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)dx_, dy_);
                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ea_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dz_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? eb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ea_);
                                                return eb_;
                                            }
                                        }

                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> da_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cy_, cz_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> db_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(da_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(db_);
                                        return dc_;
                                    }
                                }

                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cb_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bz_, ca_);
                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cb_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cc_);
                                return cd_;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bc_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ba_, bb_);
                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bd_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bc_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? be_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bd_);
                        return be_;
                    }
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
