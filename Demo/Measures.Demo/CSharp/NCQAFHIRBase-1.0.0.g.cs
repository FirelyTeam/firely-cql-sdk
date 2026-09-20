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
            FhirDateTime c_;
            if (onset is Period)
            {
                FhirDateTime h_ = (onset as Period)?.StartElement;
                c_ = h_;
            }
            else
            {
                c_ = default;
            }
            CqlDateTime d_ = context.Operators.Convert<CqlDateTime>(c_);
            FhirDateTime e_;
            if (onset is Period)
            {
                FhirDateTime i_ = (onset as Period)?.EndElement;
                e_ = i_;
            }
            else
            {
                e_ = default;
            }
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            CqlInterval<CqlDateTime> g_ = context.Operators.Interval(d_, f_, true, true);
            return g_;
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
            FhirDateTime c_;
            if (abatement is Period)
            {
                FhirDateTime h_ = (abatement as Period)?.StartElement;
                c_ = h_;
            }
            else
            {
                c_ = default;
            }
            CqlDateTime d_ = context.Operators.Convert<CqlDateTime>(c_);
            FhirDateTime e_;
            if (abatement is Period)
            {
                FhirDateTime i_ = (abatement as Period)?.EndElement;
                e_ = i_;
            }
            else
            {
                e_ = default;
            }
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            CqlInterval<CqlDateTime> g_ = context.Operators.Interval(d_, f_, true, true);
            return g_;
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
            FhirDateTime f_;
            if (choice is Period)
            {
                FhirDateTime k_ = (choice as Period)?.StartElement;
                f_ = k_;
            }
            else
            {
                f_ = default;
            }
            CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
            FhirDateTime h_;
            if (choice is Period)
            {
                FhirDateTime l_ = (choice as Period)?.EndElement;
                h_ = l_;
            }
            else
            {
                h_ = default;
            }
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            CqlInterval<CqlDateTime> j_ = context.Operators.Interval(g_, i_, true, true);
            return j_;
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

                        bool? ap_(CqlDate X) {
                            IEnumerable<CqlDate> ax_ = FirstList?.NewList;
                            int? ay_ = FirstList?.IndexofNewDate;
                            CqlDate az_ = context.Operators.Indexer<CqlDate>(ax_, ay_);
                            CqlQuantity ba_ = context.Operators.Quantity(1m, "day");
                            CqlDate bb_ = context.Operators.Add(az_ as CqlDate, ba_);
                            CqlQuantity bc_ = context.Operators.Quantity(30m, "days");
                            CqlDate bd_ = context.Operators.Add(az_ as CqlDate, bc_);
                            CqlInterval<CqlDate> be_ = context.Operators.Interval(bb_, bd_, true, true);
                            bool? bf_ = context.Operators.In<CqlDate>(X, be_, (string)default);
                            bool? bg_ = context.Operators.Not(bf_);
                            return bg_;
                        }

                        IEnumerable<CqlDate> aq_ = context.Operators.Where<CqlDate>(am_, ap_);
                        int? ar_ = context.Operators.Add(an_, 1);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? as_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ao_ as CqlDate, aq_, ar_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] at_ = [
                            as_,
                        ];

                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? au_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList) {
                            IEnumerable<CqlDate> bh_ = SecondList?.NewList;
                            int? bi_ = SecondList?.IndexofNewDate;
                            CqlDate bj_ = context.Operators.Indexer<CqlDate>(bh_, bi_);
                            if (bj_ is null)
                            {
                                return SecondList;
                            }
                            else
                            {

                                bool? bk_(CqlDate X) {
                                    IEnumerable<CqlDate> bs_ = SecondList?.NewList;
                                    int? bt_ = SecondList?.IndexofNewDate;
                                    CqlDate bu_ = context.Operators.Indexer<CqlDate>(bs_, bt_);
                                    CqlQuantity bv_ = context.Operators.Quantity(1m, "day");
                                    CqlDate bw_ = context.Operators.Add(bu_ as CqlDate, bv_);
                                    CqlQuantity bx_ = context.Operators.Quantity(30m, "days");
                                    CqlDate by_ = context.Operators.Add(bu_ as CqlDate, bx_);
                                    CqlInterval<CqlDate> bz_ = context.Operators.Interval(bw_, by_, true, true);
                                    bool? ca_ = context.Operators.In<CqlDate>(X, bz_, (string)default);
                                    bool? cb_ = context.Operators.Not(ca_);
                                    return cb_;
                                }

                                IEnumerable<CqlDate> bl_ = context.Operators.Where<CqlDate>(bh_, bk_);
                                int? bm_ = context.Operators.Add(bi_, 1);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bn_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bj_ as CqlDate, bl_, bm_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bo_ = [
                                    bn_,
                                ];

                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bp_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList) {
                                    IEnumerable<CqlDate> cc_ = ThirdList?.NewList;
                                    int? cd_ = ThirdList?.IndexofNewDate;
                                    CqlDate ce_ = context.Operators.Indexer<CqlDate>(cc_, cd_);
                                    if (ce_ is null)
                                    {
                                        return ThirdList;
                                    }
                                    else
                                    {

                                        bool? cf_(CqlDate X) {
                                            IEnumerable<CqlDate> cn_ = ThirdList?.NewList;
                                            int? co_ = ThirdList?.IndexofNewDate;
                                            CqlDate cp_ = context.Operators.Indexer<CqlDate>(cn_, co_);
                                            CqlQuantity cq_ = context.Operators.Quantity(1m, "day");
                                            CqlDate cr_ = context.Operators.Add(cp_ as CqlDate, cq_);
                                            CqlQuantity cs_ = context.Operators.Quantity(30m, "days");
                                            CqlDate ct_ = context.Operators.Add(cp_ as CqlDate, cs_);
                                            CqlInterval<CqlDate> cu_ = context.Operators.Interval(cr_, ct_, true, true);
                                            bool? cv_ = context.Operators.In<CqlDate>(X, cu_, (string)default);
                                            bool? cw_ = context.Operators.Not(cv_);
                                            return cw_;
                                        }

                                        IEnumerable<CqlDate> cg_ = context.Operators.Where<CqlDate>(cc_, cf_);
                                        int? ch_ = context.Operators.Add(cd_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ci_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ce_ as CqlDate, cg_, ch_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] cj_ = [
                                            ci_,
                                        ];

                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ck_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList) {
                                            IEnumerable<CqlDate> cx_ = FourthList?.NewList;
                                            int? cy_ = FourthList?.IndexofNewDate;
                                            CqlDate cz_ = context.Operators.Indexer<CqlDate>(cx_, cy_);
                                            if (cz_ is null)
                                            {
                                                return FourthList;
                                            }
                                            else
                                            {

                                                bool? da_(CqlDate X) {
                                                    IEnumerable<CqlDate> di_ = FourthList?.NewList;
                                                    int? dj_ = FourthList?.IndexofNewDate;
                                                    CqlDate dk_ = context.Operators.Indexer<CqlDate>(di_, dj_);
                                                    CqlQuantity dl_ = context.Operators.Quantity(1m, "day");
                                                    CqlDate dm_ = context.Operators.Add(dk_ as CqlDate, dl_);
                                                    CqlQuantity dn_ = context.Operators.Quantity(30m, "days");
                                                    CqlDate do_ = context.Operators.Add(dk_ as CqlDate, dn_);
                                                    CqlInterval<CqlDate> dp_ = context.Operators.Interval(dm_, do_, true, true);
                                                    bool? dq_ = context.Operators.In<CqlDate>(X, dp_, (string)default);
                                                    bool? dr_ = context.Operators.Not(dq_);
                                                    return dr_;
                                                }

                                                IEnumerable<CqlDate> db_ = context.Operators.Where<CqlDate>(cx_, da_);
                                                int? dc_ = context.Operators.Add(cy_, 1);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dd_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, cz_ as CqlDate, db_, dc_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] de_ = [
                                                    dd_,
                                                ];

                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? df_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList) {
                                                    IEnumerable<CqlDate> ds_ = FifthList?.NewList;
                                                    int? dt_ = FifthList?.IndexofNewDate;
                                                    CqlDate du_ = context.Operators.Indexer<CqlDate>(ds_, dt_);
                                                    if (du_ is null)
                                                    {
                                                        return FifthList;
                                                    }
                                                    else
                                                    {

                                                        bool? dv_(CqlDate X) {
                                                            IEnumerable<CqlDate> ed_ = FifthList?.NewList;
                                                            int? ee_ = FifthList?.IndexofNewDate;
                                                            CqlDate ef_ = context.Operators.Indexer<CqlDate>(ed_, ee_);
                                                            CqlQuantity eg_ = context.Operators.Quantity(1m, "day");
                                                            CqlDate eh_ = context.Operators.Add(ef_ as CqlDate, eg_);
                                                            CqlQuantity ei_ = context.Operators.Quantity(30m, "days");
                                                            CqlDate ej_ = context.Operators.Add(ef_ as CqlDate, ei_);
                                                            CqlInterval<CqlDate> ek_ = context.Operators.Interval(eh_, ej_, true, true);
                                                            bool? el_ = context.Operators.In<CqlDate>(X, ek_, (string)default);
                                                            bool? em_ = context.Operators.Not(el_);
                                                            return em_;
                                                        }

                                                        IEnumerable<CqlDate> dw_ = context.Operators.Where<CqlDate>(ds_, dv_);
                                                        int? dx_ = context.Operators.Add(dt_, 1);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, du_ as CqlDate, dw_, dx_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] dz_ = [
                                                            dy_,
                                                        ];

                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ea_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList) {
                                                            IEnumerable<CqlDate> en_ = SixthList?.NewList;
                                                            int? eo_ = SixthList?.IndexofNewDate;
                                                            CqlDate ep_ = context.Operators.Indexer<CqlDate>(en_, eo_);
                                                            if (ep_ is null)
                                                            {
                                                                return SixthList;
                                                            }
                                                            else
                                                            {

                                                                bool? eq_(CqlDate X) {
                                                                    IEnumerable<CqlDate> ey_ = SixthList?.NewList;
                                                                    int? ez_ = SixthList?.IndexofNewDate;
                                                                    CqlDate fa_ = context.Operators.Indexer<CqlDate>(ey_, ez_);
                                                                    CqlQuantity fb_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate fc_ = context.Operators.Add(fa_ as CqlDate, fb_);
                                                                    CqlQuantity fd_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate fe_ = context.Operators.Add(fa_ as CqlDate, fd_);
                                                                    CqlInterval<CqlDate> ff_ = context.Operators.Interval(fc_, fe_, true, true);
                                                                    bool? fg_ = context.Operators.In<CqlDate>(X, ff_, (string)default);
                                                                    bool? fh_ = context.Operators.Not(fg_);
                                                                    return fh_;
                                                                }

                                                                IEnumerable<CqlDate> er_ = context.Operators.Where<CqlDate>(en_, eq_);
                                                                int? es_ = context.Operators.Add(eo_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? et_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ep_ as CqlDate, er_, es_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] eu_ = [
                                                                    et_,
                                                                ];

                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ev_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList) {
                                                                    IEnumerable<CqlDate> fi_ = SeventhList?.NewList;
                                                                    int? fj_ = SeventhList?.IndexofNewDate;
                                                                    CqlDate fk_ = context.Operators.Indexer<CqlDate>(fi_, fj_);
                                                                    if (fk_ is null)
                                                                    {
                                                                        return SeventhList;
                                                                    }
                                                                    else
                                                                    {

                                                                        bool? fl_(CqlDate X) {
                                                                            IEnumerable<CqlDate> ft_ = SeventhList?.NewList;
                                                                            int? fu_ = SeventhList?.IndexofNewDate;
                                                                            CqlDate fv_ = context.Operators.Indexer<CqlDate>(ft_, fu_);
                                                                            CqlQuantity fw_ = context.Operators.Quantity(1m, "day");
                                                                            CqlDate fx_ = context.Operators.Add(fv_ as CqlDate, fw_);
                                                                            CqlQuantity fy_ = context.Operators.Quantity(30m, "days");
                                                                            CqlDate fz_ = context.Operators.Add(fv_ as CqlDate, fy_);
                                                                            CqlInterval<CqlDate> ga_ = context.Operators.Interval(fx_, fz_, true, true);
                                                                            bool? gb_ = context.Operators.In<CqlDate>(X, ga_, (string)default);
                                                                            bool? gc_ = context.Operators.Not(gb_);
                                                                            return gc_;
                                                                        }

                                                                        IEnumerable<CqlDate> fm_ = context.Operators.Where<CqlDate>(fi_, fl_);
                                                                        int? fn_ = context.Operators.Add(fj_, 1);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fo_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fk_ as CqlDate, fm_, fn_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fp_ = [
                                                                            fo_,
                                                                        ];

                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fq_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList) {
                                                                            IEnumerable<CqlDate> gd_ = EighthList?.NewList;
                                                                            int? ge_ = EighthList?.IndexofNewDate;
                                                                            CqlDate gf_ = context.Operators.Indexer<CqlDate>(gd_, ge_);
                                                                            if (gf_ is null)
                                                                            {
                                                                                return EighthList;
                                                                            }
                                                                            else
                                                                            {

                                                                                bool? gg_(CqlDate X) {
                                                                                    IEnumerable<CqlDate> go_ = EighthList?.NewList;
                                                                                    int? gp_ = EighthList?.IndexofNewDate;
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

                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gl_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList) {
                                                                                    IEnumerable<CqlDate> gy_ = NinethList?.NewList;
                                                                                    int? gz_ = NinethList?.IndexofNewDate;
                                                                                    CqlDate ha_ = context.Operators.Indexer<CqlDate>(gy_, gz_);
                                                                                    if (ha_ is null)
                                                                                    {
                                                                                        return NinethList;
                                                                                    }
                                                                                    else
                                                                                    {

                                                                                        bool? hb_(CqlDate X) {
                                                                                            IEnumerable<CqlDate> hj_ = NinethList?.NewList;
                                                                                            int? hk_ = NinethList?.IndexofNewDate;
                                                                                            CqlDate hl_ = context.Operators.Indexer<CqlDate>(hj_, hk_);
                                                                                            CqlQuantity hm_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate hn_ = context.Operators.Add(hl_ as CqlDate, hm_);
                                                                                            CqlQuantity ho_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate hp_ = context.Operators.Add(hl_ as CqlDate, ho_);
                                                                                            CqlInterval<CqlDate> hq_ = context.Operators.Interval(hn_, hp_, true, true);
                                                                                            bool? hr_ = context.Operators.In<CqlDate>(X, hq_, (string)default);
                                                                                            bool? hs_ = context.Operators.Not(hr_);
                                                                                            return hs_;
                                                                                        }

                                                                                        IEnumerable<CqlDate> hc_ = context.Operators.Where<CqlDate>(gy_, hb_);
                                                                                        int? hd_ = context.Operators.Add(gz_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? he_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ha_ as CqlDate, hc_, hd_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hf_ = [
                                                                                            he_,
                                                                                        ];

                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hg_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList) {
                                                                                            IEnumerable<CqlDate> ht_ = TenthList?.NewList;
                                                                                            int? hu_ = TenthList?.IndexofNewDate;
                                                                                            CqlDate hv_ = context.Operators.Indexer<CqlDate>(ht_, hu_);
                                                                                            if (hv_ is null)
                                                                                            {
                                                                                                return TenthList;
                                                                                            }
                                                                                            else
                                                                                            {

                                                                                                bool? hw_(CqlDate X) {
                                                                                                    IEnumerable<CqlDate> ie_ = TenthList?.NewList;
                                                                                                    int? if_ = TenthList?.IndexofNewDate;
                                                                                                    CqlDate ig_ = context.Operators.Indexer<CqlDate>(ie_, if_);
                                                                                                    CqlQuantity ih_ = context.Operators.Quantity(1m, "day");
                                                                                                    CqlDate ii_ = context.Operators.Add(ig_ as CqlDate, ih_);
                                                                                                    CqlQuantity ij_ = context.Operators.Quantity(30m, "days");
                                                                                                    CqlDate ik_ = context.Operators.Add(ig_ as CqlDate, ij_);
                                                                                                    CqlInterval<CqlDate> il_ = context.Operators.Interval(ii_, ik_, true, true);
                                                                                                    bool? im_ = context.Operators.In<CqlDate>(X, il_, (string)default);
                                                                                                    bool? in_ = context.Operators.Not(im_);
                                                                                                    return in_;
                                                                                                }

                                                                                                IEnumerable<CqlDate> hx_ = context.Operators.Where<CqlDate>(ht_, hw_);
                                                                                                int? hy_ = context.Operators.Add(hu_, 1);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hz_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hv_ as CqlDate, hx_, hy_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ia_ = [
                                                                                                    hz_,
                                                                                                ];

                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ib_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList) {
                                                                                                    IEnumerable<CqlDate> io_ = EleventhList?.NewList;
                                                                                                    int? ip_ = EleventhList?.IndexofNewDate;
                                                                                                    CqlDate iq_ = context.Operators.Indexer<CqlDate>(io_, ip_);
                                                                                                    if (iq_ is null)
                                                                                                    {
                                                                                                        return EleventhList;
                                                                                                    }
                                                                                                    else
                                                                                                    {

                                                                                                        bool? ir_(CqlDate X) {
                                                                                                            IEnumerable<CqlDate> iv_ = EleventhList?.NewList;
                                                                                                            int? iw_ = EleventhList?.IndexofNewDate;
                                                                                                            CqlDate ix_ = context.Operators.Indexer<CqlDate>(iv_, iw_);
                                                                                                            CqlQuantity iy_ = context.Operators.Quantity(1m, "day");
                                                                                                            CqlDate iz_ = context.Operators.Add(ix_ as CqlDate, iy_);
                                                                                                            CqlQuantity ja_ = context.Operators.Quantity(30m, "days");
                                                                                                            CqlDate jb_ = context.Operators.Add(ix_ as CqlDate, ja_);
                                                                                                            CqlInterval<CqlDate> jc_ = context.Operators.Interval(iz_, jb_, true, true);
                                                                                                            bool? jd_ = context.Operators.In<CqlDate>(X, jc_, (string)default);
                                                                                                            bool? je_ = context.Operators.Not(jd_);
                                                                                                            return je_;
                                                                                                        }

                                                                                                        IEnumerable<CqlDate> is_ = context.Operators.Where<CqlDate>(io_, ir_);
                                                                                                        int? it_ = context.Operators.Add(ip_, 1);
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? iu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, iq_ as CqlDate, is_, it_);
                                                                                                        return iu_;
                                                                                                    }
                                                                                                }

                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ic_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ia_, ib_);
                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? id_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ic_);
                                                                                                return id_;
                                                                                            }
                                                                                        }

                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hh_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hf_, hg_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hh_);
                                                                                        return hi_;
                                                                                    }
                                                                                }

                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gm_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gk_, gl_);
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gm_);
                                                                                return gn_;
                                                                            }
                                                                        }

                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fr_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fp_, fq_);
                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fr_);
                                                                        return fs_;
                                                                    }
                                                                }

                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ew_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)eu_, ev_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ex_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ew_);
                                                                return ex_;
                                                            }
                                                        }

                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> eb_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)dz_, ea_);
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ec_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(eb_);
                                                        return ec_;
                                                    }
                                                }

                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dg_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)de_, df_);
                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dg_);
                                                return dh_;
                                            }
                                        }

                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> cl_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)cj_, ck_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? cm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(cl_);
                                        return cm_;
                                    }
                                }

                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bq_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bo_, bp_);
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? br_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bq_);
                                return br_;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> av_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)at_, au_);
                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? aw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(av_);
                        return aw_;
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
